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
    public class WindowsStorageDataStore : IDataStore
    {
        public WindowsStorageDataStore(StorageFolder folder)
        {
            Folder = folder;
        }

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

        public Task ClearAsync() => Folder.DeleteAsync().AsTask();

        public async Task DeleteAsync<T>(string key)
        {
            var file = await Folder.TryGetItemAsync(GenerateStoredKey(key, typeof(T)));
            if (file != null)
            {
                await file.DeleteAsync();
            }
        }

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

        private static string GenerateStoredKey(string key, Type t)
        {
            return string.Format("{0}-{1}", t.FullName, key);
        }

    }
}

#endif
