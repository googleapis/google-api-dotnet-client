/*
Copyright 2010 Google Inc

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

using Google.Apis.Json;
using System.Collections.Generic;
using Xunit;

namespace Google.Apis.Tests.Json
{
    public class JsonExplicitNullTest
    {
        class A
        {
            public IList<string> List { get; set; }
        }

        [Fact]
        public void ImplicitNullElided()
        {
            string json = NewtonsoftJsonSerializer.Instance.Serialize(new A { List = null });
            Assert.Equal("{}", json);
        }

        [Fact]
        public void ExplicitNullPresent()
        {
            string json = NewtonsoftJsonSerializer.Instance.Serialize(new A { List = JsonExplicitNull.ForIList<string>() });
            Assert.Equal("{\"List\":null}", json);
        }
    }
}
