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
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>Utility class for building a URI using <see cref="BuildUri"/> or a HTTP request using 
    /// <see cref="CreateRequest"/> from the query and path parameters of a REST call.</summary>
    public class RequestBuilder
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<RequestBuilder>();

        /// <summary>Pattern to get the groups that are part of the path.</summary>
        private static Regex PathParametersPattern = new Regex(@"{[^{}]*}*");

        /// <summary>Supported HTTP methods.</summary> 
        private static IEnumerable<string> SupportedMethods = new List<string> 
            { 
                HttpConsts.Get, HttpConsts.Post, HttpConsts.Put, HttpConsts.Delete, HttpConsts.Patch 
            };

        /// <summary>
        /// A dictionary containing the parameters which will be inserted into the path of the URI. These parameters 
        /// will be substituted into the URI path where the path contains "{key}". See 
        /// http://tools.ietf.org/html/rfc6570 for more information.
        /// </summary>
        private IDictionary<string, IList<string>> PathParameters { get; set; }

        /// <summary>
        /// A dictionary containing the parameters which will apply to the query portion of this request.
        /// </summary>
        private List<KeyValuePair<string, string>> QueryParameters { get; set; }

        /// <summary>The base URI for this request (usually applies to the service itself).</summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// The path portion of this request. It's appended to the <see cref="BaseUri"/> and the parameters are 
        /// substituted from the <see cref="PathParameters"/> dictionary.
        /// </summary>
        public string Path { get; set; }

        /// <summary>The HTTP method used for this request.</summary> 
        private string method;

        /// <summary>The HTTP method used for this request (such as GET, PUT, POST, etc...).</summary>
        /// <remarks>The default Value is <see cref="Google.Apis.Http.HttpConsts.Get"/>.</remarks>
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

        /// <summary>Construct a new request builder.</summary> 
        /// TODO(peleyal): Consider using the Factory pattern here.
        public RequestBuilder()
        {
            PathParameters = new Dictionary<string, IList<string>>();
            QueryParameters = new List<KeyValuePair<string, string>>();
            Method = HttpConsts.Get;
        }

        /// <summary>Constructs a Uri as defined by the parts of this request builder.</summary> 
        public Uri BuildUri()
        {
            var restPath = BuildRestPath();

            if (QueryParameters.Count > 0)
            {
                // In case the path already contains '?' - we should add '&'. Otherwise add '?'.
                restPath.Append(restPath.ToString().Contains("?") ? "&" : "?");

                // If parameter value is empty - just add the "name", otherwise "name=value"
                restPath.Append(String.Join("&", QueryParameters.Select(
                    x => string.IsNullOrEmpty(x.Value) ?
                        Uri.EscapeDataString(x.Key) :
                        String.Format("{0}={1}", Uri.EscapeDataString(x.Key), Uri.EscapeDataString(x.Value)))
                    .ToArray()));
            }

            return new Uri(this.BaseUri, restPath.ToString());
        }

        /// <summary>Operator list that can appear in the path argument.</summary>
        private const string OPERATORS = "+#./;?&|!@=";

        /// <summary>
        /// Builds the REST path string builder based on <see cref="PathParameters"/> and the URI template spec
        /// http://tools.ietf.org/html/rfc6570.
        /// </summary>
        /// <returns></returns>
        private StringBuilder BuildRestPath()
        {
            if (string.IsNullOrEmpty(Path))
            {
                return new StringBuilder(string.Empty);
            }

            var restPath = new StringBuilder(Path);
            var matches = PathParametersPattern.Matches(restPath.ToString());
            foreach (var match in matches)
            {
                var matchStr = match.ToString();
                // Strip the first and last characters: '{' and '}'.
                var content = matchStr.Substring(1, matchStr.Length - 2);

                var op = string.Empty;
                // If the content's first character is an operator, save and remove it from the content string.
                if (OPERATORS.Contains(content[0].ToString()))
                {
                    op = content[0].ToString();
                    content = content.Substring(1);
                }

                var newContent = new StringBuilder();

                // Iterate over all possible parameters.
                var parameters = content.Split(',');
                for (var index = 0; index < parameters.Length; ++index)
                {
                    var parameter = parameters[index];

                    var parameterName = parameter;
                    var containStar = false;
                    var numOfChars = 0;

                    // Check if it ends with '*'.
                    if (parameterName[parameterName.Length - 1] == '*')
                    {
                        containStar = true;
                        parameterName = parameterName.Substring(0, parameterName.Length - 1);
                    }
                    // Check if it contains :n which means we should only use the first n characters of this parameter.
                    if (parameterName.Contains(":"))
                    {
                        if (!int.TryParse(parameterName.Substring(parameterName.IndexOf(":") + 1), out numOfChars))
                        {
                            throw new ArgumentException(
                                string.Format("Can't parse number after ':' in Path \"{0}\". Parameter is \"{1}\"",
                                    Path, parameterName), Path);
                        }
                        parameterName = parameterName.Substring(0, parameterName.IndexOf(":"));
                    }

                    // We can improve the following if statement, but for readability we will leave it like that.
                    var joiner = op;
                    var start = op;
                    switch (op)
                    {
                        case "+":
                            start = index == 0 ? "" : ",";
                            joiner = ",";
                            break;
                        case ".":
                            if (!containStar)
                            {
                                joiner = ",";
                            }
                            break;
                        case "/":
                            if (!containStar)
                            {
                                joiner = ",";
                            }
                            break;
                        case "#":
                            start = index == 0 ? "#" : ",";
                            joiner = ",";
                            break;

                        case "?":
                            start = (index == 0 ? "?" : "&") + parameterName + "=";
                            joiner = ",";
                            if (containStar)
                            {
                                joiner = "&" + parameterName + "=";
                            }
                            break;
                        case "&":
                        case ";":
                            start = op + parameterName + "=";
                            joiner = ",";
                            if (containStar)
                            {
                                joiner = op + parameterName + "=";
                            }
                            break;
                        // No operator, in that case just ','.
                        default:
                            if (index > 0)
                            {
                                start = ",";
                            }
                            joiner = ",";
                            break;
                    }

                    // Check if a path parameter equals the name which appears in the REST path.
                    if (PathParameters.ContainsKey(parameterName))
                    {
                        var value = string.Join(joiner, PathParameters[parameterName]);

                        // Check if we need to use a substring of the value.
                        if (numOfChars != 0 && numOfChars < value.Length)
                        {
                            value = value.Substring(0, numOfChars);
                        }

                        if (op != "+" && op != "#" && PathParameters[parameterName].Count == 1)
                        {
                            value = Uri.EscapeDataString(value);
                        }

                        value = start + value;
                        newContent.Append(value);
                    }
                    else
                    {
                        throw new ArgumentException(
                            string.Format("Path \"{0}\" misses a \"{1}\" parameter", Path, parameterName), Path);
                    }
                }

                if (op == ";")
                {
                    if (newContent[newContent.Length - 1] == '=')
                    {
                        newContent = newContent.Remove(newContent.Length - 1, 1);
                    }
                    newContent = newContent.Replace("=;", ";");
                }
                restPath = restPath.Replace(matchStr, newContent.ToString());
            }
            return restPath;
        }

        /// <summary>Adds a parameter value.</summary> 
        /// <param name="type">Type of the parameter (must be 'Path' or 'Query').</param>
        /// <param name="name">Parameter name.</param>
        /// <param name="value">Parameter value.</param>
        public void AddParameter(RequestParameterType type, string name, string value)
        {
            name.ThrowIfNull("name");
            if (value == null)
            {
                Logger.Warning("Add parameter should not get null values. type={0}, name={1}", type, name);
                return;
            }
            switch (type)
            {
                case RequestParameterType.Path:
                    if (!PathParameters.ContainsKey(name))
                    {
                        PathParameters[name] = new List<string> { value };
                    }
                    else
                    {
                        PathParameters[name].Add(value);
                    }
                    break;
                case RequestParameterType.Query:
                    QueryParameters.Add(new KeyValuePair<string, string>(name, value));
                    break;
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }

        /// <summary>Creates a new HTTP request message.</summary> 
        public HttpRequestMessage CreateRequest()
        {
            return new HttpRequestMessage(new HttpMethod(Method), BuildUri());
        }
    }
}
