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

namespace Google.Apis.Util
{
    /// <summary>
    /// Lazily returns the result of an operation. Can be used to pass Exceptions along asynchronous methods.
    /// </summary>
    /// <typeparam name="T">Type of the result.</typeparam>
    public class LazyResult<T>
    {
        private T result;
        private bool resultFetched;
        private readonly Func<T> fetchFunction;

        internal LazyResult(Func<T> resultFetcher)
        {
            resultFetcher.ThrowIfNull("resultFetcher");
            fetchFunction = resultFetcher;
        }

        /// <summary>
        /// Returns the result associated with this object. Might throw an exception.
        /// </summary>
        public T GetResult()
        {
            if (!resultFetched)
            {
                resultFetched = true;
                result = fetchFunction();
            }

            return result;
        }
    }
}
