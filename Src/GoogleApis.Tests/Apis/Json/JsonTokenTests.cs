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
using NUnit.Framework;

namespace Google.Apis.Tests.Json
{
    /// <summary>
    /// This is a test class for JSONTokenTest and is intended
    /// to contain all JSONTokenTest Unit Tests
    ///</summary>
    [TestFixture]
    public class JsonTokenTest
    {
        /// <summary>
        /// A test for JSONToken Constructor
        ///</summary>
        [Test]
        public void JsonTokenConstructorTest()
        {
            JsonToken target = new JsonToken();
            Assert.IsNotNull(target);
        }
    }
}