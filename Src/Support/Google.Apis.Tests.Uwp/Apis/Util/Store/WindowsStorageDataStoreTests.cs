using Google.Apis.Util.Store;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace Google.Apis.Tests.Uwp.Apis.Util.Store
{
    [TestClass]
    public class WindowsStorageDataStoreTests
    {
        private Task<StorageFolder> GetTestFolder() =>
            ApplicationData.Current.LocalFolder.CreateFolderAsync(Guid.NewGuid().ToString()).AsTask();

        [TestMethod]
        public async Task StoreAndGet()
        {
            var store = new WindowsStorageDataStore(await GetTestFolder());
            Assert.AreEqual(0, await store.GetAsync<int>("key1"));
            await store.StoreAsync<int>("key1", 1);
            Assert.AreEqual(1, await store.GetAsync<int>("key1"));
            await store.DeleteAsync<int>("key1");
            await store.ClearAsync();
        }

        [TestMethod]
        public async Task StoreAndGetDeepFolder()
        {
            var folder0 = await GetTestFolder();
            var folder1 = await folder0.CreateFolderAsync("1");
            var folder2 = await folder1.CreateFolderAsync("2");
            await folder2.DeleteAsync();
            await folder1.DeleteAsync();
            await folder0.DeleteAsync();
            var store = new WindowsStorageDataStore(await GetTestFolder());
            Assert.AreEqual(0, await store.GetAsync<int>("key1"));
            await store.StoreAsync<int>("key1", 1);
            Assert.AreEqual(1, await store.GetAsync<int>("key1"));
            await store.DeleteAsync<int>("key1");
            await store.ClearAsync();
        }

        [TestMethod]
        public async Task Delete()
        {
            var store = new WindowsStorageDataStore(await GetTestFolder());
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
            var store = new WindowsStorageDataStore(await GetTestFolder());
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
