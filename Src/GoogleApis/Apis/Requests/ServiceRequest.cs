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
using System.Threading;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Util;
using log4net;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Represents an abstract, strongly typed request base class to make requests made to a service.
    /// </summary>
    /// <remarks>Internally uses the dynamic Request class to execute requests.</remarks>
    /// <typeparam name="TResponse">The type of the response object</typeparam>
    public abstract class ServiceRequest<TResponse>
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(ServiceRequest<TResponse>));
        private readonly ISchemaAwareRequestExecutor service;

        /// <summary>
        /// Creates a new service request.
        /// </summary>
        protected ServiceRequest(ISchemaAwareRequestExecutor service)
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
        /// Should return the body of the request in form of a string (if applicable), or null.
        /// </summary>
        protected virtual string GetBody()
        {
            return null;
        }

        /// <summary>
        /// Executes the request synchronously and returns the result.
        /// </summary>
        public TResponse Fetch()
        {
            return service.JsonToObject<TResponse>(FetchAsStream());
        }

        /// <summary>
        /// Executes the request synchronously and returns the unparsed response stream.
        /// </summary>
        public Stream FetchAsStream()
        {
            string requestName = string.Format("{0}.{1}", ResourceName, MethodName);
            logger.Debug("Start Executing " + requestName);
            Stream response = service.ExecuteRequest(ResourceName, MethodName, GetBody(), CreateParameterDictionary());
            logger.Debug("Done Executing " + requestName);
            return response;
        }

        /// <summary>
        /// Executes the request asynchronously and calls the specified method once finished.
        /// </summary>
        public void FetchAsync(ExecuteRequestDelegate<TResponse> methodToCall)
        {
            // ToDo: Make this implementation compatible with the .NET 3.5 Client Profile.
            //       Will probably require us to add an async implementation to the dynamic Request class.
            ThreadPool.QueueUserWorkItem(cb => methodToCall(Fetch()));
        }

        /// <summary>
        /// Executes the request asynchronously without parsing the response, 
        /// and calls the specified method once finished.
        /// </summary>
        public void FetchAsyncAsStream(ExecuteRequestDelegate<Stream> methodToCall)
        {
            // ToDo: Make this implementation compatible with the .NET 3.5 Client Profile.
            //       Will probably require us to add an async implementation to the dynamic Request class.
            ThreadPool.QueueUserWorkItem(cb => methodToCall(FetchAsStream()));
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
                    property.GetCustomAttributes(typeof(RequestParameterAttribute), false).FirstOrDefault() as RequestParameterAttribute;
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
    }

    /// <summary>
    /// Delegate for executing an asynchronous request.
    /// </summary>
    public delegate void ExecuteRequestDelegate<in T>(T response);
}
