/*
Copyright 2010 Google Inc

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
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Request to a service
    /// </summary>
    public class Request : IRequest
    {
        private static readonly String ApiVersion = typeof(Request).Assembly.GetName().Version.ToString();

        public const string DELETE = "DELETE";
        public const string GET = "GET";
        public const string PATCH = "PATCH";
        public const string POST = "POST";
        public const string PUT = "PUT";

        public static readonly ReadOnlyCollection<string> SupportedHttpMethods = 
            new List<string> { POST, PUT, DELETE, GET, PATCH }.AsReadOnly();

        internal IAuthenticator Authenticator { get; private set; }
        private IService Service { get; set; }
        private IMethod Method { get; set; }
        private Uri BaseURI { get; set; }
        private string RPCName { get; set; } // note: this property is apparently never used
        private string Body { get; set; }
        private Uri RequestUrl;
        private ReturnType ReturnType { get; set; }
        internal String AppName { get; private set; }
        internal String DeveloperKey { get; private set; }

        [VisibleForTestOnly]
        internal IDictionary<string, string> Parameters { get; set; }

        private const string UserAgent = "{0} google-api-dotnet-client/{1}";
        private const string GZipUserAgentSuffix = " (gzip)";

        public Request()
        {
            AppName = "Unknown Application";
            Authenticator = new NullAuthenticator();
        }

        /// <summary>
        /// Given an API method, create the appropriate Request for it.
        /// </summary>
        public static IRequest CreateRequest(IService service, IMethod method)
        {
            switch (method.HttpMethod)
            {
                case GET:
                case PUT:
                case POST:
                case DELETE:
                case PATCH:
                    return new Request { Service = service, Method = method, BaseURI = service.BaseUri };
                default:
                    throw new NotSupportedException(string.Format(
                        "The HttpMethod[{0}] of Method[{1}] in Service[{2}] was not supported",
                        method.HttpMethod, method.Name, service.Name));
            }
        }

        /// <summary>
        /// The method to call
        /// </summary>
        /// <returns>
        /// A <see cref="Request"/>
        /// </returns>
        public IRequest On(string rpcName)
        {
            RPCName = rpcName;

            return this;
        }

        /// <summary>
        /// Sets the type of data that is expected to be returned from the request.
        /// 
        /// Defaults to Json
        /// </summary>
        /// <param name="returnType">
        /// A <see cref="ReturnType"/>
        /// </param>
        /// <returns>
        /// A <see cref="Request"/>
        /// </returns>
        public IRequest Returning(ReturnType returnType)
        {
            ReturnType = returnType;
            return this;
        }


        /// <summary>
        /// Adds the parameters to the request.
        /// </summary>
        /// <returns>
        /// A <see cref="Request"/>
        /// </returns>
        public IRequest WithParameters(IDictionary<string, object> parameters)
        {
            return WithParameters(parameters.ToDictionary(k => k.Key, v => v.Value != null ? v.Value.ToString() : null));
        }


        /// <summary>
        /// Adds the parameters to the request.
        /// </summary>
        /// <returns>
        /// A <see cref="Request"/>
        /// </returns>
        public IRequest WithParameters(IDictionary<string, string> parameters)
        {
            // Convert the parameters

            Parameters = parameters;
            return this;
        }

        /// <summary>
        /// Adds the parameters which are URL encoded to the request
        /// </summary>
        public IRequest WithParameters(string parameters)
        {
            // Check to ensure that the 
            Parameters = Utilities.QueryStringToDictionary(parameters);
            return this;
        }

        /// <summary>
        /// Adds the parameters provided to the body of the request
        /// </summary>
        public IRequest WithBody(IDictionary<string, string> parameters)
        {
            // Check to ensure that the 
            Body = parameters.ToString();
            return this;
        }

        /// <summary>
        /// Uses the string provied as the body of the request.
        /// </summary>
        public IRequest WithBody(string body)
        {
            // Check to ensure that the 
            Body = body;
            return this;
        }

        /// <summary>
        /// Sets the Application name on the UserAgent String
        /// </summary>
        /// <param name="name">
        /// A <see cref="System.String"/>
        /// </param>
        public IRequest WithAppName(string name)
        {
            AppName = name;
            return this;
        }

        /// <summary>
        /// Uses the provided authenticator to add authentication information to this request.
        /// </summary>
        public IRequest WithAuthentication(IAuthenticator authenticator)
        {
            Authenticator = authenticator;
            // Check to ensure that the 
            return this;
        }

        public IRequest WithDeveloperKey(string key)
        {
            DeveloperKey = key;
            return this;
        }

        /// <summary>
        /// Builds the resulting Url for the whole request
        /// </summary>
        [VisibleForTestOnly]
        internal Uri BuildRequestUrl()
        {
            string restPath = Method.RestPath;
            var queryParams = new List<string>();

            if (ReturnType == ReturnType.Json)
            {
                queryParams.Add("alt=json");
            }
            else
            {
                queryParams.Add("alt=atom");
            }

            if (DeveloperKey.IsNotNullOrEmpty())
            {
                queryParams.Add("key=" + Uri.EscapeUriString(DeveloperKey). // Escapses most of what we need
                                             Replace("&", "%26"). // Also escaped & and ?
                                             Replace("?", "%3F"));
            }

            // Replace the substitution parameters
            foreach (var parameter in Parameters)
            {
                IParameter parameterDefinition = Method.Parameters[parameter.Key];
                string value = parameter.Value;
                if (value.IsNullOrEmpty()) // If the parameter is present and has no value, use the default
                {
                    value = parameterDefinition.DefaultValue;
                }
                switch (parameterDefinition.ParameterType)
                {
                    case "path":
                        restPath = restPath.Replace(String.Format("{{{0}}}", parameter.Key), value);
                        break;
                    case "query":
                        // If the parameter is optional and no value is given, don't add to url.
                        if (parameterDefinition.Required == false && value.IsNullOrEmpty())
                        {
                            continue;
                        }
                        queryParams.Add(parameterDefinition.Name + "=" + value);
                        break;
                    default:
                        throw new NotSupportedException("Found an unsupported Parametertype [" +
                                                        parameterDefinition.ParameterType + "]");
                }
            }

            string path = restPath;

            if (queryParams.Count > 0)
            {
                path += "?" + String.Join("&", queryParams.ToArray());
            }


            return new Uri(BaseURI, path);
        }


        /// <summary>
        /// Executes a request given the configuration options supplied.
        /// </summary>
        /// <returns>
        /// A <see cref="Stream"/>
        /// </returns>
        public Stream ExecuteRequest()
        {
            var validator = new MethodValidator(Method, Parameters);


            if (validator.ValidateAllParameters() == false)
            {
                return Stream.Null;
            }

            // Formulate the RequestUrl
            RequestUrl = BuildRequestUrl();

            HttpWebRequest request = Authenticator.CreateHttpWebRequest(Method.HttpMethod, RequestUrl);

            if (ReturnType == ReturnType.Json)
            {
                //All requests are JSON.
                request.ContentType = "application/json";
            }
            else
            {
                request.ContentType = "application/atom+xml";
            }

            request.UserAgent = String.Format(UserAgent, AppName, ApiVersion);

            // Check if compression is supported
            if (Service.GZipEnabled)
            {
                request.UserAgent += GZipUserAgentSuffix;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }

            // Attach a body if a POST and there is something to attach.
            if (String.IsNullOrEmpty(Body) == false && HttpMethodHasBody(Method.HttpMethod))
            {
                // The anonymous method used to post the Body to the stream
                var writeToStream = new Action<Stream>(
                    stream =>
                        {
                            byte[] postBody = Encoding.ASCII.GetBytes(Body);
                            stream.Write(postBody, 0, postBody.Length);
                        });

                // Execute the anonymous method on the proper stream
                using (Stream bodyStream = request.GetRequestStream())
                {
                    if (Service.GZipEnabled) // GZip stream
                    {
                        // Change the content encoding
                        request.Headers.Add(HttpRequestHeader.ContentEncoding, "gzip");

                        using (Stream zipStream = new GZipStream(bodyStream, CompressionMode.Compress))
                            writeToStream(zipStream);
                    }
                    else // Normal stream
                        writeToStream(bodyStream);
                }
            }

            try
            {
                var response = (HttpWebResponse) request.GetResponse();
                return response.GetResponseStream();
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    return ex.Response.GetResponseStream();
                }
                // The exception is not something the client can handle via a stream.
                throw;
            }
        }

        public static bool HttpMethodHasBody(string httpMethod)
        {
            switch (httpMethod)
            {
                case DELETE:
                case GET:
                    return false;
                case PATCH:
                case POST:
                case PUT:
                    return true;
                default:
                    throw new NotSupportedException(
                        string.Format("The HttpMethod[{0}] is not supported", httpMethod));
            }
        }
    }
}
