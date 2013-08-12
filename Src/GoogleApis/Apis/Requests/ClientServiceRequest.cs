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
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Discovery;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Services;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Represents an abstract, strongly typed request base class to make requests to a service.
    /// Supports a strongly typed response.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response object</typeparam>
    public abstract class ClientServiceRequest<TResponse> : IClientServiceRequest<TResponse>
    {
        /// <summary> The class logger </summary>
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<ClientServiceRequest<TResponse>>();

        /// <summary> The service on which this request will be executed. </summary>
        private readonly IClientService service;

        /// <summary> Defines whether the E-Tag will be used in a specified way or be ignored. </summary>
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

        /// <summary> Creates a new service request. </summary>
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
                using (var response = ExecuteUnparsed(CancellationToken.None).Result)
                {
                    return ParseResponse(response).Result;
                }
            }
            catch (AggregateException aex)
            {
                // if an exception was thrown during the tasks, unwrap and throw it
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
                // sync call
                var response = ExecuteUnparsed(CancellationToken.None).Result;
                return response.Content.ReadAsStreamAsync().Result;
            }
            catch (AggregateException aex)
            {
                // if an exception was thrown during the tasks, unwrap and throw it
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
            using (var response = await ExecuteAsyncUnparsed(cancellationToken).ConfigureAwait(false))
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
            var response = await ExecuteAsyncUnparsed(cancellationToken).ConfigureAwait(false);

            cancellationToken.ThrowIfCancellationRequested();
            return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        }

        #region Helpers

        /// <summary> Sync executes the request without parsing the result. </summary>
        private async Task<HttpResponseMessage> ExecuteUnparsed(CancellationToken cancellationToken)
        {
            using (var request = CreateRequest())
            {
                return await service.HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary> Async executes the request without parsing the result. </summary>
        private Task<HttpResponseMessage> ExecuteAsyncUnparsed(CancellationToken cancellationToken)
        {
            // TODO(peleyal): remove the creation of a new Task (it's not necessary).
            // It should also be removed from ResumableMediaUpload and MediaDownloader!

            // create a new task completion source and return its task. In additional task we actually send the request
            // using ExecuteUnparsed and setting the result or the exception on the completion source
            TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
            Task.Factory.StartNew(async () =>
                {
                    try
                    {
                        var response = await ExecuteUnparsed(cancellationToken).ConfigureAwait(false);
                        tcs.SetResult(response);
                    }
                    catch (Exception ex)
                    {
                        // exception was thrown - it must be set on the task completion source
                        tcs.SetException(ex);
                    }
                }).ConfigureAwait(false);
            return tcs.Task;
        }

        /// <summary> Parses the response and deserialize the content into the requested response object. </summary>
        private async Task<TResponse> ParseResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return await service.DeserializeResponse<TResponse>(response).ConfigureAwait(false);
            }
            var error = await service.DeserializeError(response).ConfigureAwait(false);
            throw new GoogleApiException(service.Name, error.ToString());
        }

        #endregion

        #endregion

        /// <summary>
        /// Creates the <seealso cref="Google.Apis.Requests.RequestBuilder"/> which is used to generate a request.
        /// </summary>
        /// <returns>
        /// A new builder instance which contains the Http method and the right Uri with its path and query parameters.
        /// </returns>
        private RequestBuilder CreateBuilder()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri(Service.BaseUri),
                Path = RestPath,
                Method = HttpMethod,
            };

            // init parameters
            builder.AddParameter(RequestParameterType.Query, "key", service.ApiKey);
            AddParameters(builder, ParameterCollection.FromDictionary(CreateParameterDictionary()));
            return builder;
        }

        /// <summary>Generates the right Url for this request.</summary>
        protected string GenerateRequestUri()
        {
            return CreateBuilder().BuildUri().ToString();
        }

        /// <summary>Creates an Http request message with all class parameters, developer-key, ETag, etc.</summary>
        [VisibleForTestOnly]
        internal HttpRequestMessage CreateRequest()
        {
            var builder = CreateBuilder();
            var request = builder.CreateRequest();
            object body = GetBody();
            if (body != null)
            {
                service.SetRequestSerailizedContent(request, body);
            }

            AddETag(request);
            return request;
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
                ETagAction action = ETagAction == ETagAction.Default ? GetDefaultETagAction(HttpMethod) : ETagAction;
                switch (action)
                {
                    case ETagAction.IfMatch:
                        request.Headers.IfMatch.Add(new EntityTagHeaderValue(body.ETag));
                        break;
                    case ETagAction.IfNoneMatch:
                        request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue(body.ETag));
                        break;
                }
            }
        }

        /// <summary>
        /// Returns the default ETagAction for a specific http verb.
        /// </summary>
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

        /// <summary> Adds path and query parameters to the given <c>requestBuilder</c>. </summary>
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

            // check if there is a required parameter which wasn't set
            foreach (var parameter in RequestParameters.Values)
            {
                if (parameter.IsRequired && !inputParameters.ContainsKey(parameter.Name))
                {
                    throw new GoogleApiException(service.Name,
                        string.Format("Parameter \"{0}\" is missing", parameter.Name));
                }
            }
        }

        /// <summary>
        /// Creates a parameter dictionary by using reflection to look at all properties marked with a KeyAttribute.
        /// </summary>
        [VisibleForTestOnly]
        internal IDictionary<string, object> CreateParameterDictionary()
        {
            var dict = new Dictionary<string, object>();

            // Use reflection to build the parameter dictionary.
            foreach (PropertyInfo property in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                // Retrieve the attribute.
                RequestParameterAttribute requestParameterAttribute =
                    property.GetCustomAttributes(typeof(RequestParameterAttribute), false).FirstOrDefault() as
                    RequestParameterAttribute;
                if (requestParameterAttribute == null)
                {
                    continue;
                }

                // Get the discovery name of this parameter by looking at the attribute, or taking a lower-case
                // variant of the property name if no special name was set.
                string name = requestParameterAttribute.Name ?? property.Name.ToLower();

                // Set the value in the dictionary.
                var propertyType = property.PropertyType;
                var value = property.GetValue(this, null);
                if (propertyType.IsValueType || value != null)
                {
                    dict.Add(name, value);
                }
            }

            return dict;
        }

        #endregion
    }
}
