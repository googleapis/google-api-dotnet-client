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
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

using Google.Apis.Json;
using Google.Apis.Logging;

namespace Google.Apis.Util.Store
{
    /// <summary>
    /// Windows Store data store that implements <see cref="IDataStore"/>. This store creates a different file for each 
    /// combination of type and key.
    /// </summary>
    public class StorageDataStore : IDataStore
    {
        // TODO(peleyal): consider adding also PasswordValutDataStore

        private static readonly StorageFolder LocalFolder = ApplicationData.Current.LocalFolder;
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<StorageDataStore>();

        #region IDataStore Members

        public async Task StoreAsync<T>(string key, T value)
        {
            StorageFile file = await LocalFolder.CreateFileAsync(GenerateStoredKey(key, typeof(T)),
                CreationCollisionOption.ReplaceExisting);

            var content = Encoding.UTF8.GetBytes(NewtonsoftJsonSerializer.Instance.Serialize(value));
            using (var stream = await file.OpenStreamForWriteAsync().ConfigureAwait(false))
            {
                await stream.WriteAsync(content, 0, content.Length).ConfigureAwait(false);
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
            StorageFile file = await LocalFolder.CreateFileAsync(GenerateStoredKey(key, typeof(T)),
                CreationCollisionOption.OpenIfExists);
            var content = await FileIO.ReadTextAsync(file);
            if (string.IsNullOrEmpty(content))
            {
                return default(T);
            }
            return NewtonsoftJsonSerializer.Instance.Deserialize<T>(content);

        }

        public async Task ClearAsync()
        {
            await LocalFolder.DeleteAsync();
        }

        #endregion

        private string GenerateStoredKey(string key, Type t)
        {
            return string.Format("{0}-{1}", t.FullName, key);
        }
    }
}
