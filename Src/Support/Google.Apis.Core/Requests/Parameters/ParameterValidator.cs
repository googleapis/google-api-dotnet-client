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
using System.Linq;
using System.Text.RegularExpressions;

using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Requests.Parameters
{
    /// <summary>Logic for validating a parameter.</summary>
    public static class ParameterValidator
    {
        /// <summary>Validates a parameter value against the methods regex.</summary>
        [VisibleForTestOnly]
        public static bool ValidateRegex(IParameter param, string paramValue, out string error)
        {
            if (string.IsNullOrEmpty(param.Pattern) || new Regex(param.Pattern).IsMatch(paramValue))
            {
                error = null;
                return true;
            }
            else
            {
                error = string.Format("The value did not match the regex {0}", param.Pattern);
                return false;
            }
        }

        /// <summary>Validates if a parameter is valid.</summary>
        public static bool ValidateParameter(IParameter parameter, string value, out string error)
        {
            if (string.IsNullOrEmpty(value))
            {
                // Fail if a required parameter is not present.
                if (parameter.IsRequired)
                {
                    error = "The parameter value must be a non-empty string";
                    return false;
                }
                else
                {
                    error = null;
                    return true;
                }
            }
            else
            {
                // The parameter has value so validate the regex.
                return ValidateRegex(parameter, value, out error);
            }
        }
    }
}