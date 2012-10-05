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

namespace Google.Apis.Json
{
    /// <summary>
    /// Dictionary used for Json parsing
    /// </summary>
    public class JsonDictionary : Dictionary<string, object>
    {
        /// <summary>
        /// Returns the value from the dictionary, or, if not set, throws an ArgumentException
        /// </summary>
        public object GetMandatoryValue(string key)
        {
            if (!ContainsKey(key))
            {
                string message = String.Format("JsonDictionary did not contain mandatory key [{0}]", key);
                throw new ArgumentException(key, message);
            }

            return this[key];
        }

        /// <summary>
        /// Returns the value from the dictionary and
        /// converts it to the specified [T]ype. 
        /// Throws an ArgumentException if the key is not set within the dictionary, 
        /// or if the value is not of the requested type
        /// </summary>
        public T GetMandatoryValue<T>(string key)
        {
            object val = GetMandatoryValue(key);

            if (!(val is T))
            {
                throw new ArgumentException(
                    string.Format(
                        "The type \"{1}\" of the value of \"{0}\" is not of the expected type \"{2}\"", val.GetType(),
                        key, typeof(T)));
            }

            return (T) val;
        }

        public T Get<T>(string key)
            where T : class
        {
            return this[key] as T;
        }
    }
}