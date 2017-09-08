#if UAP10_0

using Google.Apis.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Google.Apis.Util.Store
{
    /// <summary>
    /// Data store that implements <see cref="IDataStore"/>, using Windows Storage.
    /// A separate file within a <see cref="StorageFolder"/> is used for each key.
    /// </summary>
    public class WindowsStorageDataStore : IDataStore
    {
        /// <summary>
        /// Constructs a new <see cref="WindowsStorageDataStore"/>, with all files stored in
        /// the specified <see cref="StorageFolder"/>.
        /// WARNING: This folder will be deleted when <see cref="ClearAsync"/> is called.
        /// </summary>
        /// <param name="folder">The folder in which to store data.
        /// This folder will be created if it doesn't exist.</param>
        public WindowsStorageDataStore(StorageFolder folder) => Folder = folder;

        /// <summary>
        /// The folder in which data is stored.
        /// </summary>
        public StorageFolder Folder { get; }

        private async Task EnsureFolderExists()
        {
            var current = Folder;
            var toCreate = new List<string>();
            while (true)
            {
                var parent = await current.GetParentAsync();
                if (await parent.TryGetItemAsync(current.Name) != null)
                {
                    break;
                }
                toCreate.Add(current.Name);
                current = parent;
            }
            toCreate.Reverse();
            foreach (var name in toCreate)
            {
                current = await current.CreateFolderAsync(name, CreationCollisionOption.FailIfExists);
            }
        }

        private static string GenerateStoredKey(string key, Type t) => string.Format("{0}-{1}", t.FullName, key);

        /// <inheritdoc />
        public Task ClearAsync() => Folder.DeleteAsync().AsTask();

        /// <inheritdoc />
        public async Task DeleteAsync<T>(string key)
        {
            var file = await Folder.TryGetItemAsync(GenerateStoredKey(key, typeof(T)));
            if (file != null)
            {
                await file.DeleteAsync();
            }
        }

        /// <inheritdoc />
        public async Task<T> GetAsync<T>(string key)
        {
            key.ThrowIfNullOrEmpty(nameof(key));
            var file = await Folder.TryGetItemAsync(GenerateStoredKey(key, typeof(T)));
            if (file == null)
            {
                return default(T);
            }
            using (var stream = await ((StorageFile)file).OpenStreamForReadAsync())
            {
                var ms = new MemoryStream();
                await stream.CopyToAsync(ms);
                return NewtonsoftJsonSerializer.Instance.Deserialize<T>(Encoding.UTF8.GetString(ms.ToArray()));
            }
        }

        /// <inheritdoc />
        public async Task StoreAsync<T>(string key, T value)
        {
            key.ThrowIfNullOrEmpty(nameof(key));
            await EnsureFolderExists();
            var serialized = Encoding.UTF8.GetBytes(NewtonsoftJsonSerializer.Instance.Serialize(value));
            var name = GenerateStoredKey(key, typeof(T));
            using (var stream = await Folder.OpenStreamForWriteAsync(name, CreationCollisionOption.ReplaceExisting))
            {
                await stream.WriteAsync(serialized, 0, serialized.Length);
            }
        }
    }
}

#endif
