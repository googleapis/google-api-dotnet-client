/*
Copyright 2011 Google Inc

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
using Google.Apis.Discovery;
using NUnit.Framework;

namespace Google.Apis.Tests
{
    /// <summary>
    /// Tests the cache functionallity of the discovery devices
    /// IntegrationTest 
    /// -- requires File IO access to the cache dir
    /// -- requires Internet access to http://google.com
    /// </summary>
    [TestFixture]
    public class CachedWebDiscoveryDeviceTests
    {
        /// <summary>
        ///   Tests the cache procedure
        /// </summary>
        [Test]
        public void Cache()
        {
            var device = new CachedWebDiscoveryDevice { DiscoveryUri = new Uri("http://google.com") };

            // Get the cache file info
            FileInfo cacheFile = device.GetCacheFile();
            Assert.IsNotNull(cacheFile);

            // Delete the file (if it exists)
            if (cacheFile.Exists)
            {
                cacheFile.Delete();
            }

            // Check that the file does not exist anymore
            cacheFile = device.GetCacheFile();
            Assert.IsFalse(cacheFile.Exists);

            // Execute the fetch
            using (Stream stream = device.Fetch())
            {
                Assert.IsNotNull(stream);
            }

            // Check if the file was cached
            cacheFile = device.GetCacheFile();
            Assert.IsTrue(cacheFile.Exists);
            Assert.That(cacheFile.Length, Is.GreaterThan(0));

            // Remove the newly created file
            cacheFile.Delete();
        }

        /// <summary>
        ///   Tests if the constructor works
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new CachedWebDiscoveryDevice());
        }

        /// <summary>
        ///   Tests if invalid file names are escaped
        /// </summary>
        [Test]
        public void InvalidFilenames()
        {
            var device = new CachedWebDiscoveryDevice
                             { DiscoveryUri = new Uri("http://google.com/$#@!%^&*()[]+=/\\<>:;") };

            // Check if the file name was escaped at all
            FileInfo cacheFile = device.GetCacheFile();
            Assert.That(cacheFile.Name.Contains("_"));

            // Check the result
            Assert.IsFalse(cacheFile.Name.Contains("/"));
            
            if (Environment.OSVersion.Platform != PlatformID.Unix)
            {
                // Don't check this on mono, as mono automatically escapes the file name
                Assert.IsTrue(cacheFile.Name.StartsWith("http___google.com_$#@!%25^&_()[]+=_____;-"));
            }
        }

        /// <summary>
        ///   Tests if an URI can be assigned to this device
        /// </summary>
        [Test]
        public void SetCacheDurationTest()
        {
            // Check that the cache duration is set to 3 days per default
            var device = new CachedWebDiscoveryDevice();
            Assert.That(device.CacheDuration, Is.EqualTo(3 * 24 * 60 * 60));

            device.CacheDuration = 100;
            Assert.That(device.CacheDuration, Is.EqualTo(100));
        }

        /// <summary>
        ///   Tests if an URI can be assigned to this device
        /// </summary>
        [Test]
        public void SetURITest()
        {
            var device = new CachedWebDiscoveryDevice { DiscoveryUri = new Uri("http://google.com") };
            Assert.IsNotNull(device.DiscoveryUri);
            Assert.AreEqual("http://google.com/", device.DiscoveryUri.ToString());
        }
    }
}