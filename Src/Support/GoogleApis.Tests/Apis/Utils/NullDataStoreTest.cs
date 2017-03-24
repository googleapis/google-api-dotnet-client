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

using GoogleApis.Apis.Util.Store;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Apis.Tests.Apis.Utils
{
    [TestFixture]
    public class NullDataStoreTest
    {
        [Test]
        public void Clear()
        {
            var ds = new NullDataStore();
            Assert.That(ds.ClearAsync().IsCompleted, Is.True);
        }

        [Test]
        public void Delete()
        {
            var ds = new NullDataStore();
            Assert.That(ds.DeleteAsync<string>("key").IsCompleted, Is.True);
        }

        [Test]
        public void StoreAndGet()
        {
            var ds = new NullDataStore();
            Assert.That(ds.StoreAsync("key", "value").IsCompleted, Is.True);
            var task = ds.GetAsync<string>("key");
            Assert.That(task.IsCompleted, Is.True);
            Assert.That(task.Result, Is.Null);
        }
    }
}
