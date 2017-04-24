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
    /// <summary>Represents a parameter for a method.</summary>
    public interface IParameter
    {
        /// <summary>Gets the name of the parameter.</summary>
        string Name { get; }

        /// <summary>Gets the pattern that this parameter must follow.</summary>
        string Pattern { get; }

        /// <summary>Gets an indication whether this parameter is optional or required.</summary>
        bool IsRequired { get; }

        /// <summary>Gets the default value of this parameter.</summary>
        string DefaultValue { get; }

        /// <summary>Gets the type of the parameter.</summary>
        string ParameterType { get; }
    }
}