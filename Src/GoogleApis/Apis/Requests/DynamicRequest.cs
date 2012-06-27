/*
Copyright 2012 Google Inc

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
using System.Linq;
using System.Text;

using Google.Apis.Discovery;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// An implementation of a Request which uses information looked up dynamically from
    /// a discovery service.
    /// </summary>
    internal class DynamicRequest : Request
    {
        private DynamicRequest(IService service, IMethod method)
            : base(service.BaseUri, method.RestPath, method.HttpMethod)
        {
            switch (method.HttpMethod)
            {
                case GET:
                case PUT:
                case POST:
                case DELETE:
                case PATCH:
                    break;
                default:
                    throw new NotSupportedException(
                        string.Format(
                            "The HttpMethod[{0}] of Method[{1}] in Service[{2}] was not supported", method.HttpMethod,
                            method.Name, service.Name));
            }

            this.Service = service;
            this.Method = method;
            this.GZipEnabled = service.GZipEnabled;
        }
        
        private IService Service { get; set; }
        private IMethod Method { get; set; }

        /// <summary>
        /// Given an API method, create the appropriate Request for it.
        /// </summary>
        public static IRequest CreateDynamicRequest(IService service, IMethod method)
        {
            return new DynamicRequest(service, method);
        }

        protected override void AssembleParameters(HttpWebRequestBuilder requestBuilder)
        {
            // Replace the substitution parameters.
            foreach (var parameter in Parameters)
            {
                IParameter parameterDefinition;// = Method.Parameters[parameter.Key];

                if (!(Method.Parameters.TryGetValue(parameter.Key, out parameterDefinition)
                    || Service.Parameters.TryGetValue(parameter.Key, out parameterDefinition)
                    ))
                {
                    throw new GoogleApiException(
                        String.Format("Invalid parameter \"{0}\" specified.", parameter.Key))
                        { Service = Service };
                }

                string value = parameter.Value;
                if (String.IsNullOrEmpty(value)) // If the parameter is present and has no value, use the default.
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
                        if (parameterDefinition.IsRequired && String.IsNullOrEmpty(value))
                        {
                            throw new GoogleApiException(
                                String.Format("Required parameter \"{0}\" missing.", parameter.Key))
                                    { Service = Service };
                        }
                        requestBuilder.AddParameter(RequestParameterType.Query, parameter.Key, value);
                        break;
                    default:
                        throw new NotSupportedException(
                            "Found an unsupported Parametertype [" + parameterDefinition.ParameterType + "]");
                }
            }
        }

        protected override void Validate()
        {
            base.Validate();

            // Validate the input.
            var validator = new MethodValidator(Method, Parameters);
            if (validator.ValidateAllParameters() == false)
            {
                throw new InvalidOperationException("Request parameter validation failed for [" + this + "]");
            }
        }

        public override string ToString()
        {
            return string.Format("{0}({1} @ {2})", GetType(), Method.Name, BuildRequest().RequestUri);
        }
    }
}
