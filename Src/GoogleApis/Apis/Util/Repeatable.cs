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

using System.Collections;
using System.Collections.Generic;

namespace Google.Apis.Util
{
    /// <summary>
    /// Class which allows you to both pass a single object, as well as an array, as a parameter value.
    /// </summary>
    public class Repeatable<T> : IEnumerable<T>
    {
        private readonly IList<T> values;

        /// <summary>
        /// Creates a repeatable value.
        /// </summary>
        public Repeatable(IEnumerable<T> enumeration)
        {
            values = new List<T>(enumeration).AsReadOnly();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Converts the single element into a repeatable.
        /// </summary>
        public static implicit operator Repeatable<T>(T elem)
        {
            if (elem == null)
            {
                return null;
            }

            return new Repeatable<T>(new[] { elem });
        }

        /// <summary>
        /// Converts a number of elements into a repeatable.
        /// </summary>
        public static implicit operator Repeatable<T>(T[] elem)
        {
            if (elem.Length == 0)
            {
                return null;
            }

            return new Repeatable<T>(elem);
        }

        /// <summary>
        /// Converts a number of elements into a repeatable.
        /// </summary>
        public static implicit operator Repeatable<T>(List<T> elem)
        {
            return new Repeatable<T>(elem);
        }
    }
}
