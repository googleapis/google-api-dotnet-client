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

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Represents a class containing further implementation details for a schema
    /// </summary>
    public class SchemaImplementationDetails
    {
        /// <summary>
        /// True if this schema is a direct result of a resource method call
        /// </summary>
        public bool IsMethodResult { get; set; }

        /// <summary>
        /// A proposed (alternative) name for this schema
        /// </summary>
        public string ProposedName { get; set; }

        /// <summary>
        /// True if this implementation has been traversed by the implementation generator.
        /// Used to prevent endless recursion / stack overflow.
        /// </summary>
        internal bool TraversedByGenerator { get; set; }
    }
}
