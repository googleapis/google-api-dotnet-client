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
using Xunit;

namespace Google.Apis.Tests.Apis.Utils
{
    public class NullDataStoreTest
    {
        [Fact]
        public void Clear()
        {
            var ds = new NullDataStore();
            Assert.True(ds.ClearAsync().IsCompleted);
        }

        [Fact]
        public void Delete()
        {
            var ds = new NullDataStore();
            Assert.True(ds.DeleteAsync<string>("key").IsCompleted);
        }

        [Fact]
        public void StoreAndGet()
        {
            var ds = new NullDataStore();
            Assert.True(ds.StoreAsync("key", "value").IsCompleted);
            var task = ds.GetAsync<string>("key");
            Assert.True(task.IsCompleted);
            Assert.Null(task.Result);
        }
    }
}
