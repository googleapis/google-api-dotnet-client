/*
Copyright 2012 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Net.Http;

using Google.Apis.Util;
using Google.Apis.Http;

namespace Google.Apis.Requests
{
    /// <summary> Utility class used to build a request from the various parts of a REST Method call. </summary>
    internal class RequestBuilder
    {
        /// <summary> Supported Http methods. </summary>
        private static IEnumerable<string> SupportedMethods = new List<string> 
            { 
                HttpConsts.Get, HttpConsts.Post, HttpConsts.Put, HttpConsts.Delete, HttpConsts.Patch 
            };

        /// <summary>
        /// A dictionary containing the parameters which will be inserted into the path
        /// of the URI. These parameters will be substituted into the URI path where the 
        /// path contains "{key}" that portion of the path will be replaced by the value 
        /// for the specified key in this dictionary.
        /// </summary>
        private IDictionary<string, string> PathParameters { get; set; }

        /// <summary>
        /// A dictionary containing the parameters which will apply to the query portion
        /// of this request.
        /// </summary>
        private List<KeyValuePair<string, string>> QueryParameters { get; set; }

        /// <summary>
        /// The base uri for this request (usually applies to the service itself).
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// The path portion of this request. Appended to the <see cref="BaseUri"/> and
        /// the parameters are substituted from the <see cref="PathParameters"/> dictionary.
        /// </summary>
        public string Path { get; set; }

        /// <summary> The Http method used for this request. </summary>
        private string method;

        /// <summary> The Http method used for this request (such as GET, PUT, POST, etc...) </summary>
        /// <remarks> Default Value is <see cref="Google.Apis.Http.HttpConsts.Get"/>. </remarks>
        public string Method
        {
            get { return method; }
            set
            {
                if (!SupportedMethods.Contains(value))
                    throw new ArgumentOutOfRangeException("Method");
                method = value;
            }
        }

        /// <summary> Construct a new request builder. </summary>
        public RequestBuilder()
        {
            this.PathParameters = new Dictionary<string, string>();
            this.QueryParameters = new List<KeyValuePair<string, string>>();
            this.Method = HttpConsts.Get;
        }

        /// <summary> Constructs a Uri as defined by the parts of this request builder. </summary>
        public Uri BuildUri()
        {
            var restPath = new StringBuilder(PathParameters
                .Select(param => new { Token = "{" + param.Key + "}", Value = Uri.EscapeDataString(param.Value) })
                .Aggregate(this.Path, (path, param) => path.Replace(param.Token, param.Value)));

            if (QueryParameters.Count > 0)
            {
                restPath.Append("?");
                // If parameter value is empty - just add the "name", otherwise "name=value"
                restPath.Append(String.Join("&", QueryParameters.Select(
                    x => x.Value.IsNullOrEmpty() ?
                        Uri.EscapeDataString(x.Key) :
                        String.Format("{0}={1}", Uri.EscapeDataString(x.Key), Uri.EscapeDataString(x.Value)))
                    .ToArray()));
            }

            return new Uri(this.BaseUri, restPath.ToString());
        }

        /// <summary> Adds a parameter value. </summary>
        /// <param name="type">Type of the parameter (must be Path or Query).</param>
        /// <param name="name">Parameter name.</param>
        /// <param name="value">Parameter value.</param>
        public void AddParameter(RequestParameterType type, string name, string value)
        {
            switch (type)
            {
                case RequestParameterType.Path:
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Path parameters cannot be null or empty.");
                    }
                    PathParameters.Add(name, value);
                    break;
                case RequestParameterType.Query:
                    if (value == null) // don't allow null values on query (empty value is valid)
                    {
                        break;
                    }
                    QueryParameters.Add(new KeyValuePair<string, string>(name, value));
                    break;
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }

        /// <summary> Creates a new Http request message. </summary>
        public HttpRequestMessage CreateRequest()
        {
            return new HttpRequestMessage(new HttpMethod(Method), BuildUri());
        }
    }
}
