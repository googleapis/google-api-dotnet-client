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

using System.Collections.Generic;

namespace Google.Apis.Discovery
{
    /// <summary>Represents a parameter for a method. </summary>
    public interface IParameter
    {
        /// <summary>
        /// Name of the parameter.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The type of the parameter.
        /// </summary>
        string ParameterType { get; }

        /// <summary>
        /// The pattern in which this parameter has to be defined.
        /// </summary>
        string Pattern { get; }

        /// <summary>
        /// Defines whether this parameter is optional or required.
        /// </summary>
        bool IsRequired { get; }

        /// <summary>
        /// Defines whether this parameter can be repeated multiple times.
        /// </summary>
        bool IsRepeatable { get; }

        /// <summary>
        /// The default value of this parameter.
        /// </summary>
        string DefaultValue { get; }

        /// <summary>
        /// The type of the value.
        /// </summary>
        string ValueType { get; }

        /// <summary>
        /// Description of this parameter.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The maximum valid value. (Only for numeric values)
        /// </summary>
        string Maximum { get; }

        /// <summary>
        /// The minimum valid value. (Only for numeric values)
        /// </summary>
        string Minimum { get; }

        /// <summary>
        /// A list of valid enum values. (Only for enum values)
        /// </summary>
        IEnumerable<string> EnumValues { get; }

        /// <summary>
        /// A list of valid enum value descriptions. (Only for enum values)
        /// </summary>
        IEnumerable<string> EnumValueDescriptions { get; }
    }
}