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
using System.Linq;
using System.Threading.Tasks;
using Windows.Security.Credentials;

namespace Google.Apis.Util.Store
{
    /// <summary>
    /// Data store that implements <see cref="IDataStore"/>, using the Windows
    /// <see cref="PasswordVault"/> for storage.
    /// </summary>
    public class PasswordVaultDataStore : IDataStore
    {
        private const string ResourcePrefix = "google-datastore";
        private readonly PasswordVault vault = new PasswordVault();

        private string MakeResource<T>() => $"{ResourcePrefix}-{typeof(T)}";

        /// <inheritdoc />
        public Task ClearAsync()
        {
            try
            {
                // RetrieveAll will throw if there are no credentials. Ignore it.
                foreach (var credential in vault.RetrieveAll().Where(x => x.Resource.StartsWith(ResourcePrefix)))
                {
                    vault.Remove(credential);
                }
            }
            catch { } // Throws a COMException on failure
            return Task.CompletedTask;
        }

        /// <inheritdoc />
        public Task DeleteAsync<T>(string key)
        {
            try
            {
                // Retrieve will throw if the key doesn't exist. Ignore it.
                vault.Remove(vault.Retrieve(MakeResource<T>(), key));
            }
            catch { } // Throws a COMException on failure
            return Task.CompletedTask;
        }

        /// <inheritdoc />
        public Task<T> GetAsync<T>(string key)
        {
            try
            {
                // Retrieve will throw is key doesn't exist.
                var credential = vault.Retrieve(MakeResource<T>(), key);
                credential.RetrievePassword();
                return Task.FromResult(NewtonsoftJsonSerializer.Instance.Deserialize<T>(credential.Password));
            }
            catch // Throws a COMException on failure
            {
                return Task.FromResult(default(T));
            }
        }

        /// <inheritdoc />
        public Task StoreAsync<T>(string key, T value)
        {
            var serialized = NewtonsoftJsonSerializer.Instance.Serialize(value);
            vault.Add(new PasswordCredential(MakeResource<T>(), key, serialized));
            return Task.CompletedTask;
        }
    }
}

#endif
