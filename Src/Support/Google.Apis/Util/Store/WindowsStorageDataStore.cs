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
            var parent = await Folder.GetParentAsync();
            if (parent == null)
            {
                throw new InvalidOperationException("Storage directory does not exist.");
            }
            if (await parent.TryGetItemAsync(Folder.Name) == null)
            {
                await parent.CreateFolderAsync(Folder.Name, CreationCollisionOption.FailIfExists);
            }
        }

        private static string GenerateStoredKey(string key, Type t) => $"{t.FullName}-{key}";

        /// <inheritdoc />
        public async Task ClearAsync()
        {
            try
            {
                await Folder.DeleteAsync();
            }
            catch { } // Throws COMException if folder doesn't exist
        }

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
