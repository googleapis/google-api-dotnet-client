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
using System.Net;

using Google.Apis.Util;
using Google.Apis.Authentication;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Utility class used to build an HttpWebRequest from the various parts of a REST Method call.
    /// </summary>
    internal class HttpWebRequestBuilder
    {
        /// <summary>
        /// Cached default request factory.
        /// </summary>
        private static readonly HttpRequestFactory DefaultRequestFactory = new HttpRequestFactory();

        /// <summary>
        /// Cached default uri factory.
        /// </summary>
        private static readonly UriFactory DefaultUriFactory = new UriFactory();

        /// <summary>
        /// Gets/Sets a factory used to create basic HttpWebRequests.
        /// </summary>
        public ICreateHttpRequest HttpRequestFactory { get; set; }

        /// <summary>
        /// Gets/Sets a factory used to create Uri objects.
        /// </summary>
        public UriFactory UriFactory { get; set; }

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

        /// <summary>
        /// The HTTP method used for this request (such as GET, PUT, POST, etc...)
        /// </summary>
        /// <remarks>
        /// Defaults to "GET".
        /// </remarks>
        public string Method { get; set; }

        /// <summary>
        /// Construct a new HTTP web request builder. The 
        /// </summary>
        public HttpWebRequestBuilder()
        {
            this.PathParameters = new Dictionary<string, string>();
            this.QueryParameters = new List<KeyValuePair<string, string>>();
            this.Method = "GET";
            this.UriFactory = DefaultUriFactory;
            this.HttpRequestFactory = DefaultRequestFactory;
        }

        /// <summary>
        /// Construct a URI as defined by the parts of this request builder.
        /// </summary>
        /// <returns>A <see cref="System.Uri"/> for this request.</returns>
        /// <remarks>Method is not included in the Uri.</remarks>
        public Uri BuildUri()
        {
            var restPath = new StringBuilder(PathParameters
                .Select(param => new { Token = "{" + param.Key + "}", Value = Uri.EscapeDataString(param.Value) })
                .Aggregate(this.Path, (path, param) => path.Replace(param.Token, param.Value)));

            if (QueryParameters.Count > 0)
            {
                restPath.Append("?");
                restPath.Append(String.Join("&", QueryParameters.Select(
                    x => String.Format("{0}={1}", Uri.EscapeDataString(x.Key), Uri.EscapeDataString(x.Value)))
                    .ToArray()));
            }

            return UriFactory.Create(this.BaseUri, restPath.ToString());
        }

        /// <summary>
        /// Construct an HttpWebRequest using the <see cref="HttpRequestFactory"/> and
        /// the uri constructed by <see cref="BuildUri"/>.
        /// </summary>
        /// <returns>
        /// An <see cref="HttpWebRequest"/> instance, with the uri and method configured by
        /// this builder.
        /// </returns>
        public HttpWebRequest GetWebRequest()
        {
            Uri uri = BuildUri();
            return HttpRequestFactory.Create(uri, this.Method);
        }

        /// <summary>
        /// Add a parameter value.
        /// </summary>
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
                    if (string.IsNullOrEmpty(value))
                    {
                        break;
                    }
                    QueryParameters.Add(new KeyValuePair<string, string>(name, value));
                    break;
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }
    }
}
