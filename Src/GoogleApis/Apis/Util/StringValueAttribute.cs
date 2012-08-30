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
    /// Defines an attribute containing a string representation of the member
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class StringValueAttribute : Attribute
    {
        private readonly string text;

        /// <summary>
        /// The text which belongs to this member
        /// </summary>
        public string Text { get { return text; } }

        /// <summary>
        /// Creates a new StringValue attribute with the specified text
        /// </summary>
        /// <param name="text"></param>
        public StringValueAttribute(string text)
        {
            text.ThrowIfNull("text");
            this.text = text;
        }
    }
}
