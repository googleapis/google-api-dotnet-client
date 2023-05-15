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

using System;
using System.Collections;
using System.Collections.Generic;

namespace Google.Apis.Json
{
    /// <summary>
    /// Provides values which are explicitly expressed as <c>null</c> when converted to JSON.
    /// </summary>
    public static class JsonExplicitNull
    {
        /// <summary>
        /// Get an <see cref="IList{T}"/> that is explicitly expressed as <c>null</c> when converted to JSON.
        /// </summary>
        /// <returns>An <see cref="IList{T}"/> that is explicitly expressed as <c>null</c> when converted to JSON.</returns>
        public static IList<T> ForIList<T>() => ExplicitNullList<T>.Instance;

        [JsonExplicitNull]
        private sealed class ExplicitNullList<T> : IList<T>
        {
            public static ExplicitNullList<T> Instance = new ExplicitNullList<T>();

            public T this[int index]
            {
                get { throw new NotSupportedException(); }
                set { throw new NotSupportedException(); }
            }

            public int Count { get { throw new NotSupportedException(); } }

            public bool IsReadOnly { get { throw new NotSupportedException(); } }

            public void Add(T item)
            {
                throw new NotSupportedException();
            }

            public void Clear()
            {
                throw new NotSupportedException();
            }

            public bool Contains(T item)
            {
                throw new NotSupportedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new NotSupportedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotSupportedException();
            }

            public int IndexOf(T item)
            {
                throw new NotSupportedException();
            }

            public void Insert(int index, T item)
            {
                throw new NotSupportedException();
            }

            public bool Remove(T item)
            {
                throw new NotSupportedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotSupportedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotSupportedException();
            }
        }
    }
}
