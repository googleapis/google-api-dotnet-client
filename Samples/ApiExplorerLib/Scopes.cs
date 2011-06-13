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
using System.Linq;
using System.Web;

namespace Google.Apis.Samples.ApiExplorer
{
    /// <summary>
    /// Provides map from service name to the (first) scope to use for multiple Google APIs
    /// </summary>
    /// <remarks>
    /// Hard-coded here because Discovery service does not provide scope information.
    /// </remarks>
    public class Scopes
    {
        private static IDictionary<string, string> _scopes = 
            new Dictionary<string, string>
            {
    			{ "buzz", "https://www.googleapis.com/auth/buzz" },
    			{ "chromewebstore", "https://www.googleapis.com/auth/chromewebstore" },
    			{ "translate", "https://translate.google.com/toolkit/feeds" },
                { "moderator", "https://www.googleapis.com/auth/moderator" },
            };

        public static string GetScope(string serviceName)
        {
            if (_scopes.ContainsKey(serviceName))
            {
                return _scopes[serviceName];
            }
            else
            {
                return "https://www.googleapis.com/auth/" + serviceName;
            }
        }
    }
}
