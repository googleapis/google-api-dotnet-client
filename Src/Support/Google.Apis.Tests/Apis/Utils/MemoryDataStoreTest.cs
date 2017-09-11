using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Text;
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
