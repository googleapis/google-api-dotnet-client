/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Discovery;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Services;
using Google.Apis.Testing;
using Google.Apis.Util;
using Google.Apis.Requests.Parameters;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Represents an abstract, strongly typed request base class to make requests to a service.
    /// Supports a strongly typed response.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response object</typeparam>
    public abstract class ClientServiceRequest<TResponse> : IClientServiceRequest<TResponse>
    {
        /// <summary>The class logger.</summary>
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<ClientServiceRequest<TResponse>>();

        /// <summary>The service on which this request will be executed.</summary>
        private readonly IClientService service;

        /// <summary>Defines whether the E-Tag will be used in a specified way or be ignored.</summary>
        public ETagAction ETagAction { get; set; }

        #region IClientServiceRequest Properties

        public abstract string MethodName { get; }
        public abstract string RestPath { get; }
        public abstract string HttpMethod { get; }

        public IDictionary<string, IParameter> RequestParameters { get; private set; }

        public IClientService Service
        {
            get { return service; }
        }

        #endregion

        /// <summary>Creates a new service request.</summary>
        protected ClientServiceRequest(IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Initializes request's parameters. Inherited classes MUST override this method to add parameters to the
        /// <see cref="RequestParameters"/> dictionary.
        /// </summary>
        protected virtual void InitParameters()
        {
            RequestParameters = new Dictionary<string, IParameter>();
        }

        #region Execution

        public TResponse Execute()
        {
            try
            {
                using (var response = ExecuteUnparsedAsync(CancellationToken.None).Result)
                {
                    return ParseResponse(response).Result;
                }
            }
            catch (AggregateException aex)
            {
                // If an exception was thrown during the tasks, unwrap and throw it.
                throw aex.InnerException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Stream ExecuteAsStream()
        {
            // TODO(peleyal): should we copy the stream, and dispose the response?
            try
            {
                // Sync call.
                var response = ExecuteUnparsedAsync(CancellationToken.None).Result;
                return response.Content.ReadAsStreamAsync().Result;
            }
            catch (AggregateException aex)
            {
                // If an exception was thrown during the tasks, unwrap and throw it.
                throw aex.InnerException;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TResponse> ExecuteAsync()
        {
            return await ExecuteAsync(CancellationToken.None).ConfigureAwait(false);
        }

        public async Task<TResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            using (var response = await ExecuteUnparsedAsync(cancellationToken).ConfigureAwait(false))
            {
                cancellationToken.ThrowIfCancellationRequested();
                return await ParseResponse(response).ConfigureAwait(false);
            }
        }

        public async Task<Stream> ExecuteAsStreamAsync()
        {
            return await ExecuteAsStreamAsync(CancellationToken.None).ConfigureAwait(false);
        }

        public async Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken)
        {
            // TODO(peleyal): should we copy the stream, and dispose the response?
            var response = await ExecuteUnparsedAsync(cancellationToken).ConfigureAwait(false);

            cancellationToken.ThrowIfCancellationRequested();
            return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        }

        #region Helpers

        /// <summary>Sync executes the request without parsing the result. </summary>
        private async Task<HttpResponseMessage> ExecuteUnparsedAsync(CancellationToken cancellationToken)
        {
            using (var request = CreateRequest())
            {
                return await service.HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>Parses the response and deserialize the content into the requested response object. </summary>
        private async Task<TResponse> ParseResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return await service.DeserializeResponse<TResponse>(response).ConfigureAwait(false);
            }
            var error = await service.DeserializeError(response).ConfigureAwait(false);
            throw new GoogleApiException(service.Name, error.ToString())
            {
                HttpStatusCode = response.StatusCode
            };
        }

        #endregion

        #endregion

        public HttpRequestMessage CreateRequest(Nullable<bool> overrideGZipEnabled = null)
        {
            var builder = CreateBuilder();
            var request = builder.CreateRequest();
            object body = GetBody();
            request.SetRequestSerailizedContent(service, body, overrideGZipEnabled.HasValue
                ? overrideGZipEnabled.Value : service.GZipEnabled);
            AddETag(request);
            return request;
        }

        /// <summary>
        /// Creates the <see cref="Google.Apis.Requests.RequestBuilder"/> which is used to generate a request.
        /// </summary>
        /// <returns>
        /// A new builder instance which contains the HTTP method and the right Uri with its path and query parameters.
        /// </returns>
        private RequestBuilder CreateBuilder()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri(Service.BaseUri),
                Path = RestPath,
                Method = HttpMethod,
            };

            // Init parameters.
            builder.AddParameter(RequestParameterType.Query, "key", service.ApiKey);
            var parameters = ParameterUtils.CreateParameterDictionary(this);
            AddParameters(builder, ParameterCollection.FromDictionary(parameters));
            return builder;
        }

        /// <summary>Generates the right URL for this request.</summary>
        protected string GenerateRequestUri()
        {
            return CreateBuilder().BuildUri().ToString();
        }

        protected virtual object GetBody()
        {
            return null;
        }

        #region ETag

        /// <summary>
        /// Adds the right ETag action (e.g. If-Match) header to the given HTTP request if the body contains ETag.
        /// </summary>
        private void AddETag(HttpRequestMessage request)
        {
            IDirectResponseSchema body = GetBody() as IDirectResponseSchema;
            if (body != null && !string.IsNullOrEmpty(body.ETag))
            {
                var etag = body.ETag;
                ETagAction action = ETagAction == ETagAction.Default ? GetDefaultETagAction(HttpMethod) : ETagAction;
                try
                {
                    switch (action)
                    {
                        case ETagAction.IfMatch:
                            request.Headers.IfMatch.Add(new EntityTagHeaderValue(etag));
                            break;
                        case ETagAction.IfNoneMatch:
                            request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue(etag));
                            break;
                    }
                }
                // When ETag is invalid we are going to create a request anyway.
                // See https://code.google.com/p/google-api-dotnet-client/issues/detail?id=464 for more details.
                catch (FormatException ex)
                {
                    Logger.Error(ex, "Can't set {0}. Etag is: {1}.", action, etag);
                }
            }
        }

        /// <summary>Returns the default ETagAction for a specific HTTP verb.</summary>
        [VisibleForTestOnly]
        internal static ETagAction GetDefaultETagAction(string httpMethod)
        {
            switch (httpMethod)
            {
                // Incoming data should only be updated if it has been changed on the server.
                case HttpConsts.Get:
                    return ETagAction.IfNoneMatch;

                // Outgoing data should only be committed if it hasn't been changed on the server.
                case HttpConsts.Put:
                case HttpConsts.Post:
                case HttpConsts.Patch:
                case HttpConsts.Delete:
                    return ETagAction.IfMatch;

                default:
                    return ETagAction.Ignore;
            }
        }

        #endregion

        #region Parameters

        /// <summary>Adds path and query parameters to the given <c>requestBuilder</c>.</summary>
        private void AddParameters(RequestBuilder requestBuilder, ParameterCollection inputParameters)
        {
            foreach (var parameter in inputParameters)
            {
                IParameter parameterDefinition;

                if (!RequestParameters.TryGetValue(parameter.Key, out parameterDefinition))
                {
                    throw new GoogleApiException(Service.Name,
                        String.Format("Invalid parameter \"{0}\" was specified", parameter.Key));
                }

                string value = parameter.Value;
                if (!ParameterValidator.ValidateParameter(parameterDefinition, value))
                {
                    throw new GoogleApiException(Service.Name,
                        string.Format("Parameter validation failed for \"{0}\"", parameterDefinition.Name));
                }

                if (value == null) // If the parameter is null, use the default value.
                {
                    value = parameterDefinition.DefaultValue;
                }

                switch (parameterDefinition.ParameterType)
                {
                    case "path":
                        requestBuilder.AddParameter(RequestParameterType.Path, parameter.Key, value);
                        break;
                    case "query":
                        // If the parameter is optional and no value is given, don't add to url.
                        if (!Object.Equals(value, parameterDefinition.DefaultValue) || parameterDefinition.IsRequired)
                        {
                            requestBuilder.AddParameter(RequestParameterType.Query, parameter.Key, value);
                        }
                        break;
                    default:
                        throw new GoogleApiException(service.Name,
                            string.Format("Unsupported parameter type \"{0}\" for \"{1}\"",
                            parameterDefinition.ParameterType, parameterDefinition.Name));
                }
            }

            // Check if there is a required parameter which wasn't set.
            foreach (var parameter in RequestParameters.Values)
            {
                if (parameter.IsRequired && !inputParameters.ContainsKey(parameter.Name))
                {
                    throw new GoogleApiException(service.Name,
                        string.Format("Parameter \"{0}\" is missing", parameter.Name));
                }
            }
        }

        #endregion
    }
}
