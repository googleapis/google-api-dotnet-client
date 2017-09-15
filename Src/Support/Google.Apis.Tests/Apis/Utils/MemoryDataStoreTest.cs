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

namespace Google.Apis.Tests.Apis.Utils
{
    public class MemoryDataStoreTest
    {
        [Fact]
        public async Task StoreAndGet()
        {
            var store = new MemoryDataStore();
            Assert.Equal(0, await store.GetAsync<int>("key1"));
            await store.StoreAsync<int>("key1", 1);
            Assert.Equal(1, await store.GetAsync<int>("key1"));
        }

        [Fact]
        public async Task Delete()
        {
            var store = new MemoryDataStore();
            Assert.Equal(0, await store.GetAsync<int>("key1"));
            Assert.Equal(0, await store.GetAsync<int>("key2"));
            await store.StoreAsync<int>("key1", 1);
            await store.StoreAsync<int>("key2", 2);
            Assert.Equal(1, await store.GetAsync<int>("key1"));
            Assert.Equal(2, await store.GetAsync<int>("key2"));
            await store.DeleteAsync<int>("key1");
            Assert.Equal(0, await store.GetAsync<int>("key1"));
            Assert.Equal(2, await store.GetAsync<int>("key2"));
            await store.DeleteAsync<int>("key2");
            Assert.Equal(0, await store.GetAsync<int>("key1"));
            Assert.Equal(0, await store.GetAsync<int>("key2"));
        }

        [Fact]
        public async Task StoreGetClear()
        {
            var store = new MemoryDataStore();
            Assert.Equal(0, await store.GetAsync<int>("key1"));
            Assert.Equal(0, await store.GetAsync<int>("key2"));
            await store.StoreAsync<int>("key1", 1);
            await store.StoreAsync<int>("key2", 2);
            Assert.Equal(1, await store.GetAsync<int>("key1"));
            Assert.Equal(2, await store.GetAsync<int>("key2"));
            await store.ClearAsync();
            Assert.Equal(0, await store.GetAsync<int>("key1"));
            Assert.Equal(0, await store.GetAsync<int>("key2"));
        }
    }
}
