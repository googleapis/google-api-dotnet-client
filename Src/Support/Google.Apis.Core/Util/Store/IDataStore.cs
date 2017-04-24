/*
Copyright 2013 Google Inc

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
using System.Threading.Tasks;

namespace Google.Apis.Util.Store
{
    /// <summary>
    /// Stores and manages data objects, where the key is a string and the value is an object.
    /// <para>
    /// <c>null</c> keys are not allowed.
    /// </para>
    /// </summary>
    public interface IDataStore
    {
        /// <summary>Asynchronously stores the given value for the given key (replacing any existing value).</summary>
        /// <typeparam name="T">The type to store in the data store.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="value">The value to store.</param>
        Task StoreAsync<T>(string key, T value);

        /// <summary>
        /// Asynchronously deletes the given key. The type is provided here as well because the "real" saved key should
        /// contain type information as well, so the data store will be able to store the same key for different types.
        /// </summary>
        /// <typeparam name="T">The type to delete from the data store.</typeparam>
        /// <param name="key">The key to delete.</param>
        Task DeleteAsync<T>(string key);

        /// <summary>Asynchronously returns the stored value for the given key or <c>null</c> if not found.</summary>
        /// <typeparam name="T">The type to retrieve from the data store.</typeparam>
        /// <param name="key">The key to retrieve its value.</param>
        /// <returns>The stored object.</returns>
        Task<T> GetAsync<T>(string key);

        /// <summary>Asynchronously clears all values in the data store.</summary>
        Task ClearAsync();
    }
}