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

using Google.Apis.Util.Store;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class FileDataStoreTests
    {
        [Fact]
        public async Task DefaultLocation()
        {
            const string key1 = "testkey1";
            const string key2 = "testkey2";
            var store = new FileDataStore("IntegrationTesting");
            // Clear
            await store.ClearAsync();
            // Check it's empty
            Assert.Null(await store.GetAsync<string>(key1));
            Assert.Equal(0, await store.GetAsync<int>(key2));
            // Add data
            await store.StoreAsync(key1, "1");
            await store.StoreAsync(key2, 2);
            // Check data still there
            Assert.Equal("1", await store.GetAsync<string>(key1));
            Assert.Equal(2, await store.GetAsync<int>(key2));
            // Delete one item
            await store.DeleteAsync<string>(key1);
            // Check only that one item has gone
            Assert.Null(await store.GetAsync<string>(key1));
            Assert.Equal(2, await store.GetAsync<int>(key2));
            // Clear
            await store.ClearAsync();
            // Check alldata has gone
            Assert.Null(await store.GetAsync<string>(key1));
            Assert.Equal(0, await store.GetAsync<int>(key2));
        }
    }
}
