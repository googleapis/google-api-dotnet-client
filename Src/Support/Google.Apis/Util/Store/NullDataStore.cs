/*
Copyright 2017 Google Inc

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

using System.Threading.Tasks;

namespace Google.Apis.Util.Store
{
    /// <summary>
    /// A null datastore. Nothing is stored, nothing is retrievable.
    /// </summary>
    public class NullDataStore : IDataStore
    {
        private static readonly Task s_completedTask = CompletedTask<int>();

        private static Task<T> CompletedTask<T>()
        {
            var tcs = new TaskCompletionSource<T>();
            tcs.SetResult(default(T));
            return tcs.Task;
        }

        /// <summary>
        /// Construct a new null datastore, that stores nothing.
        /// </summary>
        public NullDataStore()
        {
        }

        /// <inheritdoc/>
        public Task ClearAsync() => s_completedTask;

        /// <inheritdoc/>
        public Task DeleteAsync<T>(string key) => s_completedTask;

        /// <summary>
        /// Asynchronously returns the stored value for the given key or <c>null</c> if not found.
        /// This implementation of <see cref="IDataStore"/> will always return a completed task
        /// with a result of <c>null</c>. 
        /// </summary>
        /// <typeparam name="T">The type to retrieve from the data store.</typeparam>
        /// <param name="key">The key to retrieve its value.</param>
        /// <returns>Always <c>null</c>.</returns>
        public Task<T> GetAsync<T>(string key) => CompletedTask<T>();

        /// <summary>
        /// Asynchronously stores the given value for the given key (replacing any existing value).
        /// This implementation of <see cref="IDataStore"/> does not store the value,
        /// and will not return it in future calls to <see cref="GetAsync{T}(string)"/>. 
        /// </summary>
        /// <typeparam name="T">The type to store in the data store.</typeparam>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>A task that completes immediately.</returns>
        public Task StoreAsync<T>(string key, T value) => s_completedTask;
    }
}
