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
using System.IO;
using System.IO.IsolatedStorage;
using System.Threading.Tasks;
using Windows.Storage;

using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Util.Protect;

namespace Google.Apis.Util.Store
{
    /// <summary>
    /// Windows phone data store that implements <see cref="IDataStore"/>. This store creates a different file for each 
    /// combination of type and key.
    /// </summary>
    public class StorageDataStore : IDataStore
    {
        private static readonly StorageFolder LocalFolder = ApplicationData.Current.LocalFolder;
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<StorageDataStore>();

        #region IDataStore Members

        public async Task StoreAsync<T>(string key, T value)
        {
            StorageFile file = await LocalFolder.CreateFileAsync(GenerateStoredKey(key, typeof(T)),
                CreationCollisionOption.ReplaceExisting);

            var content = NewtonsoftJsonSerializer.Instance.Serialize(value);
            byte[] protectedContent = DataProtection.Protect(content);
            using (var stream = await file.OpenStreamForWriteAsync())
            {
                await stream.WriteAsync(protectedContent, 0, protectedContent.Length);
            }
        }

        public async Task DeleteAsync<T>(string key)
        {
            var storedKey = GenerateStoredKey(key, typeof(T));
            var file = await LocalFolder.CreateFileAsync(storedKey, CreationCollisionOption.OpenIfExists);
            await file.DeleteAsync(StorageDeleteOption.PermanentDelete);
        }

        public async Task<T> GetAsync<T>(string key)
        {
            byte[] content = await ReadFileContentAsync(GenerateStoredKey(key, typeof(T)));
            TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
            if (content.Length == 0)
            {
                return default(T);
            }

            var data = DataProtection.Unprotect(content);
            return NewtonsoftJsonSerializer.Instance.Deserialize<T>(data);

        }

        public async Task ClearAsync()
        {
            await LocalFolder.DeleteAsync(StorageDeleteOption.PermanentDelete);
        }

        #endregion

        /// <summary>Reads and returns the content of the given file.</summary>
        private async static Task<byte[]> ReadFileContentAsync(string file)
        {
            using (var stream = new IsolatedStorageFileStream(file, FileMode.OpenOrCreate, FileAccess.Read,
                IsolatedStorageFile.GetUserStoreForApplication()))
            {
                using (Stream reader = new StreamReader(stream).BaseStream)
                {
                    byte[] data = new byte[reader.Length];
                    await reader.ReadAsync(data, 0, data.Length);
                    return data;
                }
            }
        }

        private string GenerateStoredKey(string key, Type t)
        {
            return string.Format("{0}-{1}", t.FullName, key);
        }
    }
}
