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

using System;
using Google.Apis.Discovery;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Discovery
{
    /// <summary>
    /// Tests for FactoryParameter classes
    /// </summary>
    [TestFixture]
    public class FactoryParametersTest
    {
        /// <summary>
        /// Mock class for testing purposes
        /// </summary>
        private class MockFactoryParameters : FactoryParameters
        {
            public MockFactoryParameters() : base() {}
            public MockFactoryParameters(string serverUrl) : base(serverUrl) { }
            public MockFactoryParameters(Uri serviceUri) : base(serviceUri) { }
            public MockFactoryParameters(string serverUrl, string basePath) : base(serverUrl, basePath) { }
        }

        /// <summary>
        /// Tests the constructors for the BaseFactoryParameters
        /// </summary>
        [Test]
        public void ConstructorsTest()
        {
            const string SERVER = "http://foo";
            const string PATH = "/bar/service";

            // Empty constructor
            var fp = new MockFactoryParameters();
            Assert.That(fp.ServerUrl, Is.EqualTo("https://www.googleapis.com"));
            Assert.That(fp.BasePath, Is.Null);

            // URL and Path constructor
            fp = new MockFactoryParameters(SERVER, PATH);
            Assert.That(fp.ServerUrl, Is.EqualTo(SERVER));
            Assert.That(fp.BasePath, Is.EqualTo(PATH));

            // URI constructor
            fp = new MockFactoryParameters(new Uri(SERVER + PATH));
            Assert.That(fp.ServerUrl, Is.EqualTo(SERVER));
            Assert.That(fp.BasePath, Is.EqualTo(PATH));
        }

        /// <summary>
        /// Tests if the constructors validate the input
        /// </summary>
        [Test]
        public void ConstructorsValidationTest()
        {
            Assert.Throws<ArgumentNullException>(() => new MockFactoryParameters((Uri)null));
            Assert.Throws<ArgumentNullException>(() => new MockFactoryParameters((string)null));
            Assert.Throws<UriFormatException>(() => new MockFactoryParameters(""));
            Assert.DoesNotThrow(() => new MockFactoryParameters("http://foo", null));
        }
    }
}
