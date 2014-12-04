/*
Copyright 2014 Google Inc

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
using Windows.Security.Credentials;

using Google.Apis.Json;
using Google.Apis.Util.Store;

namespace Google.Apis.Util.Store
{
    /// <summary>
    /// Credentials store that implements <see cref="IDataStore"/>.
    /// This store saves all keys encrypted in a <see cref="PasswordVault"/>
    /// </summary>
    public class PasswordVaultDataStore : IDataStore
    {
        public static PasswordVaultDataStore Default = new PasswordVaultDataStore();
        PasswordVault passwordVault = new PasswordVault();

        /// <summary>Adds a new key to the password vault.</summary>
        public Task StoreAsync<T>(string key, T value)
        {
            passwordVault.Add(new PasswordCredential(
                typeof(T).ToString(),
                key,
                NewtonsoftJsonSerializer.Instance.Serialize(value)));
            return TaskEx.Delay(0);
        }

        /// <summary>Deletes a given key from the password vault.</summary>
        public Task DeleteAsync<T>(string key)
        {
            try
            {
                PasswordCredential credential = passwordVault.Retrieve(typeof(T).ToString(), key);
                passwordVault.Remove(credential);
            }
            // PasswordVault.Retrieve might throw a general exception. DO NOTHING, there is no value for this key.
            catch (Exception) { }
            return TaskEx.Delay(0);
        }

        /// <summary>
        /// Gets a specific key from the password vault. Returns <c>default(T)</c> if there is no matching entry.
        /// </summary>
        public Task<T> GetAsync<T>(string key)
        {
            TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
            try
            {
                PasswordCredential credential = passwordVault.Retrieve(typeof(T).ToString(), key);
                // No matching entry.
                if (credential == null)
                {
                    tcs.SetResult(default(T));
                }
                else
                {
                    credential.RetrievePassword();
                    tcs.SetResult(NewtonsoftJsonSerializer.Instance.Deserialize<T>(credential.Password));
                }
            }
            // PasswordVault.Retrieve might throw a general exception, which mean there isn't a matching entry.
            catch (Exception)
            {
                tcs.SetResult(default(T));
            }
            return tcs.Task;
        }

        /// <summary>Removes all values from the password vault.</summary>
        public Task ClearAsync()
        {
            try
            {
                foreach (var credential in passwordVault.RetrieveAll())
                {
                    passwordVault.Remove(credential);
                }
            }
            // PasswordVault.RetrieveAll might throw a general exception - DO NOTHING, there are no values to remove.
            catch (Exception) { }
            return TaskEx.Delay(0);
        }
    }
}
