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

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Represents an abstract, strongly typed request base class to make requests made to a service.
    /// Supports a strongly typed response.
    /// </summary>
    /// <remarks>Internally uses the dynamic Request class to execute requests.</remarks>
    /// <typeparam name="TResponse">The type of the response object</typeparam>
    public abstract class ServiceRequest<TResponse> : IServiceRequest<TResponse>
    {
        protected ServiceRequest()
        {
            ETagAction = ETagAction.Default;
        }

        /// <summary>
        /// The name of the "GetBody" method
        /// </summary>
        public const string GetBodyMethodName = "GetBody";

        private static readonly ILogger logger = ApplicationContext.Logger.ForType<ServiceRequest<TResponse>>();
        private readonly IRequestProvider service;

        /// <summary>
        /// Defines whether the E-Tag will be used in a specified way or ignored.
        /// </summary>
        public ETagAction ETagAction { get; set; }

        /// <summary>
        /// The E-Tag to use with this request. If this is null, the e-tag of the body will be used (if possible).
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Creates a new service request.
        /// </summary>
        protected ServiceRequest(IRequestProvider service)
        {
            this.service = service;
        }

        /// <summary>
        /// Name of the Resource to which the method belongs.
        /// </summary>
        protected abstract string ResourceName { get; }

        /// <summary>
        /// The name of the method to which this request belongs.
        /// </summary>
        protected abstract string MethodName { get; }

        /// <summary>
        /// The service on which the request will be executed.
        /// </summary>
        protected IRequestProvider Service
        {
            get { return service; }
        }
        
        /// <summary>
        /// Should return the body of the request (if applicable), or null.
        /// </summary>
        protected virtual object GetBody()
        {
            return null;
        }

        /// <summary>
        /// Returns the serialized version of the body, or null if unavailable.
        /// </summary>
        private string GetSerializedBody()
        {
            object body = GetBody();
            if (body == null)
            {
                return null;
            }

            // Serialize the body.
            return service.SerializeObject(body);
        }

        /// <summary>
        /// Builds an executeable base request containing the data of this request class.
        /// </summary>
        [VisibleForTestOnly]
        internal IRequest BuildRequest()
        {
            IRequest request = service.CreateRequest(ResourceName, MethodName);
            request.WithBody(GetSerializedBody());
            request.WithParameters(CreateParameterDictionary());
            request.WithETagAction(ETagAction);

            // Check if there is an ETag to attach.
            if (!string.IsNullOrEmpty(ETag))
            {
                request.WithETag(ETag);
            }
            else
            {
                // If no custom ETag has been set, try to use the one which might come with the body.
                // If this is a ISchemaResponse, the etag has been added to the object as it was created.
                IDirectResponseSchema body = GetBody() as IDirectResponseSchema;
                if (body != null)
                {
                    request.WithETag(body.ETag);
                }
            }

            return request;
        }

        private IResponse GetResponse()
        {
            string requestName = string.Format("{0}.{1}", ResourceName, MethodName);
            logger.Debug("Start Executing " + requestName);
            IResponse response = BuildRequest().ExecuteRequest();
            logger.Debug("Done Executing " + requestName);
            return response;
        }

        /// <summary>
        ///Executes the request synchronously and returns the result.
        /// </summary>
        public TResponse Fetch()
        {
            return service.DeserializeResponse<TResponse>(GetResponse());
        }

        /// <summary>
        /// Executes the request synchronously and returns the unparsed response stream.
        /// </summary>
        /// <remarks>The returned stream is encoded in UTF-8.</remarks>
        public Stream FetchAsStream()
        {
            return GetResponse().Stream;
        }
        
        /// <summary>
        /// Executes the request asynchronously without parsing the response, 
        /// and calls the specified method once finished.
        /// </summary>
        /// <remarks>The returned stream is encoded in UTF-8.</remarks>
        public void FetchAsyncAsStream([Optional] ExecuteRequestDelegate<Stream> methodToCall)
        {
            // TODO(mlinder): Make this implementation compatible with the .NET 3.5 Client Profile.
            //                Will probably require us to add an async implementation to the dynamic Request class.
            ThreadPool.QueueUserWorkItem(cb =>
                                            {
                                                // If we have a method to call, invoke it.
                                                Stream response = FetchAsStream();
                                                if (methodToCall != null)
                                                {
                                                    methodToCall(response);
                                                }
                                            });
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
        /// <summary>
        /// Executes the request asynchronously and optionally calls the specified method once finished.
        /// </summary>
        public void FetchAsync([Optional] ExecuteRequestDelegate<TResponse> methodToCall)
        {
            // TODO(mlinder): Make this implementation compatible with the .NET 3.5 Client Profile.
            //                Will probably require us to add an async implementation to the dynamic Request class.
            ThreadPool.QueueUserWorkItem(cb =>
                                            {
                                                // If we have a method to call, invoke it.
                                                TResponse response = Fetch();
                                                if (methodToCall != null)
                                                {
                                                    methodToCall(response);
                                                }
                                            });
        }
    }
}
