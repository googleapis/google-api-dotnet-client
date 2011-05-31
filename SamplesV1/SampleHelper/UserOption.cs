/*
Copyright 2011 Google Inc

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

namespace Google.Apis.Samples.Helper
{
    /// <summary>
    /// A choice option which can be picked by the user
    /// Used by the CommandLine class
    /// </summary>
    public sealed class UserOption
    {
        /// <summary>
        /// Creates a new option based upon the specified data
        /// </summary>
        /// <param name="name">Name to display</param>
        /// <param name="target">Target function to call if this option was picked</param>
        public UserOption(string name, Action target)
        {
            Name = name;
            Target = target;
        }

        /// <summary>
        /// Name/Keyword to display
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The function which will be called if this option was picked
        /// </summary>
        public Action Target { get; private set; }
    }
}
