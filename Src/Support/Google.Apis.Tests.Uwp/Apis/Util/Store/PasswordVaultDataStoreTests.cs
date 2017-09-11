using Google.Apis.Util.Store;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Google.Apis.Tests.Uwp.Apis.Util.Store
{
    [TestClass]
    public class PasswordVaultDataStoreTests
    {
        [TestMethod]
        public async Task StoreAndGet()
        {
            Assert.Fail("Testing a UWP-only failure");
            var store = new PasswordVaultDataStore();
            Assert.AreEqual(0, await store.GetAsync<int>("key1"));
            await store.StoreAsync<int>("key1", 1);
            Assert.AreEqual(1, await store.GetAsync<int>("key1"));
            await store.DeleteAsync<int>("key1");
            await store.ClearAsync();
        }

        [TestMethod]
        public async Task Delete()
        {
            var store = new PasswordVaultDataStore();
            Assert.AreEqual(0, await store.GetAsync<int>("key1"));
            Assert.AreEqual(0, await store.GetAsync<int>("key2"));
            await store.StoreAsync<int>("key1", 1);
            await store.StoreAsync<int>("key2", 2);
            Assert.AreEqual(1, await store.GetAsync<int>("key1"));
            Assert.AreEqual(2, await store.GetAsync<int>("key2"));
            await store.DeleteAsync<int>("key1");
            Assert.AreEqual(0, await store.GetAsync<int>("key1"));
            Assert.AreEqual(2, await store.GetAsync<int>("key2"));
            await store.DeleteAsync<int>("key2");
            Assert.AreEqual(0, await store.GetAsync<int>("key1"));
            Assert.AreEqual(0, await store.GetAsync<int>("key2"));
        }

        [TestMethod]
        public async Task StoreGetClear()
        {
            var store = new PasswordVaultDataStore();
            Assert.AreEqual(0, await store.GetAsync<int>("key1"));
            Assert.AreEqual(0, await store.GetAsync<int>("key2"));
            await store.StoreAsync<int>("key1", 1);
            await store.StoreAsync<int>("key2", 2);
            Assert.AreEqual(1, await store.GetAsync<int>("key1"));
            Assert.AreEqual(2, await store.GetAsync<int>("key2"));
            await store.ClearAsync();
            Assert.AreEqual(0, await store.GetAsync<int>("key1"));
            Assert.AreEqual(0, await store.GetAsync<int>("key2"));
        }
    }
}
