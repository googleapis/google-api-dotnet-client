using Google.Apis.Util.Store;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests
{
    [TestFixture]
    class FileDataStoreTests
    {
        [Test]
        public async Task DefaultLocation()
        {
            const string key1 = "testkey1";
            const string key2 = "testkey2";
            var store = new FileDataStore("IntegrationTesting");
            // Clear
            await store.ClearAsync();
            // Check it's empty
            Assert.That(await store.GetAsync<string>(key1), Is.Null);
            Assert.That(await store.GetAsync<int>(key2), Is.Zero);
            // Add data
            await store.StoreAsync(key1, "1");
            await store.StoreAsync(key2, 2);
            // Check data still there
            Assert.That(await store.GetAsync<string>(key1), Is.EqualTo("1"));
            Assert.That(await store.GetAsync<int>(key2), Is.EqualTo(2));
            // Delete one item
            await store.DeleteAsync<string>(key1);
            // Check only that one item has gone
            Assert.That(await store.GetAsync<string>(key1), Is.Null);
            Assert.That(await store.GetAsync<int>(key2), Is.EqualTo(2));
            // Clear
            await store.ClearAsync();
            // Check alldata has gone
            Assert.That(await store.GetAsync<string>(key1), Is.Null);
            Assert.That(await store.GetAsync<int>(key2), Is.Zero);
        }
    }
}
