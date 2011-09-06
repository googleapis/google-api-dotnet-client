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
using System.Collections;
using System.Collections.Generic;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// A collection of parameters (key value pairs). May contain duplicate keys.
    /// </summary>
    public class ParameterCollection : List<KeyValuePair<string, string>>
    {
        public ParameterCollection() : base() {}
        public ParameterCollection(IEnumerable<KeyValuePair<string,string>> collection) : base(collection) { }

        /// <summary>
        /// Adds a single parameter to this collection.
        /// </summary>
        public void Add(string key, string value)
        {
            Add(new KeyValuePair<string, string>(key, value));
        }

        /// <summary>
        /// Returns true if this parameter is set within the collection.
        /// </summary>
        public bool ContainsKey(string key)
        {
            key.ThrowIfNullOrEmpty("key");
            string value;
            return TryGetValue(key, out value);
        }

        /// <summary>
        /// Tries to find the a key within the specified key value collection. Returns true if the key was found.
        /// If a pair was found the out parameter value will contain the value of that pair.
        /// </summary>
        public bool TryGetValue(string key, out string value)
        {
            key.ThrowIfNullOrEmpty("key");

            foreach (KeyValuePair<string, string> pair in this)
            {
                // Check if this pair matches the specified key name.
                if (pair.Key.Equals(key))
                {
                    value = pair.Value;
                    return true;
                }
            }

            // No result found.
            value = null;
            return false;
        }

        /// <summary>
        /// Returns the value of the first matching key, or throws a KeyNotFoundException if the parameter is not
        /// present within the collection.
        /// </summary>
        public string GetFirstMatch(string key)
        {
            string val;
            if (!TryGetValue(key, out val))
            {
                throw new KeyNotFoundException("Parameter with the name '" + key + "' was not found.");
            }
            return val;
        }

        /// <summary>
        /// Returns all matches for the specified key. May return an empty enumeration if the key is not present.
        /// </summary>
        public IEnumerable<string> GetAllMatches(string key)
        {
            key.ThrowIfNullOrEmpty("key");

            foreach (KeyValuePair<string, string> pair in this)
            {
                // Check if this pair matches the specified key name.
                if (pair.Key.Equals(key))
                {
                    yield return pair.Value;
                }
            }
        }

        /// <summary>
        /// Returns all matches for the specified key. May return an empty enumeration if the key is not present.
        /// </summary>
        public IEnumerable<string> this[string key]
        {
            get { return GetAllMatches(key); }
        }

        /// <summary>
        /// Creates a parameter collection from the specified URL encoded query string.
        /// Example: 
        ///     The query string "foo=bar&chocolate=cookie" would result in two parameters (foo and bar)
        ///     with the values "bar" and "cookie" set.
        /// </summary>
        public static ParameterCollection FromQueryString(string qs)
        {
            var collection = new ParameterCollection();
            var qsParam = qs.Split('&');
            foreach (var param in qsParam)
            {
                // Split the parameter into key and value.
                var info = param.Split(new [] {'='}, 2);
                if (info.Length >= 2)
                {
                    collection.Add(Uri.UnescapeDataString(info[0]), Uri.UnescapeDataString(info[1]));
                }
            }

            return collection;
        }

        /// <summary>
        /// Creates a parameter collection from the specified dictionary.
        /// If the value is an enumerable, a parameter pair will be added for each value.
        /// Otherwise the value will be converted into a string using the .ToString() method.
        /// </summary>
        public static ParameterCollection FromDictionary(IDictionary<string, object> dictionary)
        {
            var collection = new ParameterCollection();
            foreach (KeyValuePair<string, object> pair in dictionary)
            {
                // Try parsing the value of the pair as an enumerable.
                var valueAsEnumerable = pair.Value as IEnumerable;
                if (!(pair.Value is string) && valueAsEnumerable != null)
                {
                    foreach (var value in valueAsEnumerable)
                    {
                        collection.Add(pair.Key, Util.Utilities.ConvertToString(value));
                    }
                }
                else
                {
                    // Otherwise just convert it to a string.
                    collection.Add(pair.Key, pair.Value == null ? null : Util.Utilities.ConvertToString(pair.Value));
                }
            }

            return collection;
        }
    }
}
