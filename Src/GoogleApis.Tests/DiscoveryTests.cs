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
using System.IO;
using NUnit.Framework;
using Google.Apis.Discovery;

namespace Google.Apis.Tests
{
    /// <summary>
    /// A test implementation of the IDiscoveryDevice
    /// </summary>
    public class StubDiscoveryDevice : IDiscoveryDevice
    {
        #region IDiscoveryDevice Members

        public Stream Fetch()
        {
            return Stream.Null;
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    /// <summary>
    /// Tests for the discovery ser vice
    /// </summary>
    [TestFixture]
    public class DiscoveryTests
    {
        /// <summary>
        /// Checks if the constructor of the DiscoveryService works
        /// </summary>
        [Test]
        public void Construct()
        {
            Assert.IsInstanceOf<DiscoveryService>(new DiscoveryService(null));
        }

        /// <summary>
        /// Checks if the constructor accepts the test discovery device
        /// </summary>
        [Test]
        public void ConstructWithDiscoveryDevice()
        {
            var d = new DiscoveryService(new StubDiscoveryDevice());
            Assert.IsInstanceOf<StubDiscoveryDevice>(d.DiscoveryDevice);
        }

        /// <summary>
        /// Tests if the constructor works at all
        /// </summary>
        [Test]
        public void Create()
        {
            var d = new DiscoveryService(new StubDiscoveryDevice());
            Assert.IsNotNull(d);
        }
    }
}