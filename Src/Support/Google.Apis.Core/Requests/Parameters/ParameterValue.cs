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
    /// Represents a parameter value together with its <see cref="RequestParameterType"/> metadata.
    /// </summary>
    /// <remarks>
    /// <see cref="Value"/> contains the raw CLR value (prior to any string conversion for the wire format).
    /// </remarks>    
    internal readonly struct ParameterValue
    {
        /// <summary>
        /// Gets the parameter type (Path, Query, etc.)
        /// </summary>
        public RequestParameterType Type { get; }

        /// <summary>
        /// Gets the parameter value.
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// Constructs a new parameter value with type.
        /// </summary>
        public ParameterValue(RequestParameterType type, object value)
        {
            Type = type;
            Value = value;
        }
    }
}
