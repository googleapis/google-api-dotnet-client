/*
Copyright 2026 Google Inc

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

using Google.Apis.Util;

namespace Google.Apis.Requests.Parameters
{
    /// <summary>
    /// Represents a parameter together with its <see cref="RequestParameterType"/> metadata.
    /// </summary>
    /// <remarks>
    /// <see cref="Value"/> is the string value to be sent on the wire (after conversion via <c>Utilities.ConvertToString</c>).
    /// </remarks>
    internal readonly struct TypedParameter
    {
        /// <summary>Gets the parameter type (Path, Query, etc.)</summary>
        public RequestParameterType Type { get; }

        /// <summary>Gets the parameter name.</summary>
        public string Name { get; }

        /// <summary>Gets the parameter value.</summary>
        public string Value { get; }

        /// <summary>Constructs a new typed parameter.</summary>
        public TypedParameter(RequestParameterType type, string name, string value)
        {
            Type = type;
            Name = name;
            Value = value;
        }
    }
}
