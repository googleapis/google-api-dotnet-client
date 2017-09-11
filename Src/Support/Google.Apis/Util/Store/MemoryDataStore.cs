using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Google.Apis.Util.Store
{
    /// <summary>
    /// An in-memory datastore, that stores items in memory only.
    /// Contents do not persist across program restarts.
    /// </summary>
    public class MemoryDataStore : IDataStore
    {
        private static readonly Task s_completedTask = CompletedTask<int>();

        private static Task<T> CompletedTask<T>()
        {
            var tcs = new TaskCompletionSource<T>();
            tcs.SetResult(default(T));
            return tcs.Task;
        }

        internal static string GenerateStoredKey(string key, Type t) => string.Format("{0}-{1}", t.FullName, key);

        /// <summary>
        /// Construct a new memory datastore, that stores items in memory only.
        /// Contents do not persist across program restarts.
        /// </summary>
        public MemoryDataStore()
        {
        }

        /// <summary>
        /// The live memory datastore contents. Writing/removing items from this dictionary
        /// will alter the datastore contents. The returned dictionary is not thread-safe.
        /// </summary>
        public Dictionary<string, object> Items { get; } = new Dictionary<string, object>();

        /// <inheritdoc/>
        public Task ClearAsync()
        {
            Items.Clear();
            return s_completedTask;
        }

        /// <inheritdoc/>
        public Task DeleteAsync<T>(string key)
        {
            Items.Remove(GenerateStoredKey(key, typeof(T)));
            return s_completedTask;
        }

        /// <inheritdoc/>
        public Task<T> GetAsync<T>(string key)
        {
            if (Items.TryGetValue(GenerateStoredKey(key, typeof(T)), out var value))
            {
                return Task.FromResult((T)value);
            }
            return Task.FromResult(default(T));
        }

        /// <inheritdoc/>
        public Task StoreAsync<T>(string key, T value)
        {
            Items[GenerateStoredKey(key, typeof(T))] = value;
            return s_completedTask;
        }
    }
}
