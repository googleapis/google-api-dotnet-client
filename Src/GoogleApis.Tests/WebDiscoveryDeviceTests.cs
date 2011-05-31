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
using NUnit.Framework;
using Google.Apis.Discovery;

namespace Google.Apis.Tests
{
    /// <summary>
    /// Tests for the "WebDiscoveryDevice" class
    /// </summary>
    [TestFixture]
    public class WebDiscoveryDeviceTests
    {
        /// <summary>
        /// Tests that the constructor succeeds
        /// </summary>
        [Test]
        public void Construct()
        {
            Assert.IsInstanceOf<WebDiscoveryDevice>(new WebDiscoveryDevice());
        }

        /// <summary>
        /// Tests that the URI is saved when set at construction time
        /// </summary>
        [Test]
        public void SetURI()
        {
            var device = new WebDiscoveryDevice { DiscoveryUri = new Uri("http://test.com") };
            Assert.IsNotNull(device.DiscoveryUri);
            Assert.AreEqual("http://test.com/", device.DiscoveryUri.ToString());
        }
    }
}