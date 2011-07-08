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

namespace Google.Apis.Util
{
    /// <summary>
    /// A attribute which is used to mark a property as a request parameter.
    /// Allows you to set the formal name of the parameter if it differs from the property name.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RequestParameterAttribute : Attribute
    {
        private readonly string name;

        /// <summary>
        /// Name/Key of this attribute
        /// </summary>
        public string Name { get { return name; }}

        public RequestParameterAttribute()
        {
            name = null;
        }

        public RequestParameterAttribute(string name)
        {
            this.name = name;
        }
    }
}
