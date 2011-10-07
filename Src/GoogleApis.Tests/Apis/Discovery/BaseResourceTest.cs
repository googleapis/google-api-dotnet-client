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
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Json;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Discovery
{
    /// <summary>
    /// Tests for the BaseResource class.
    /// </summary>
    [TestFixture]
    public class BaseResourceTest
    {
        /// <summary>
        /// Tests the construction of a resource.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.Throws<ArgumentException>(
                () => new ResourceV1_0(new KeyValuePair<string, object>("Test", null)));
            Assert.Throws<ArgumentNullException>(
                () => new ResourceV1_0(new KeyValuePair<string, object>(null, new JsonDictionary())));
            Assert.DoesNotThrow(
                () => new ResourceV1_0(new KeyValuePair<string, object>("TestResource", new JsonDictionary())));
        }

        /// <summary>
        /// Tests the creation of subresources, and checks if the Parent is set correctly.
        /// </summary>
        [Test]
        public void SubresourceTest()
        {
            var topJson = new JsonDictionary();
            topJson.Add("resources", new JsonDictionary() { { "Sub", new JsonDictionary() } });

            // Create the resource hierachy and confirm results.
            var topResource = new ResourceV1_0(new KeyValuePair<string, object>("Top", topJson));
            Assert.IsNotNull(topResource.Resources);
            Assert.AreEqual(1, topResource.Resources.Count);
            Assert.AreEqual("Sub", topResource.Resources["Sub"].Name);
            Assert.AreEqual(topResource, topResource.Resources["Sub"].Parent);
        }

        /// <summary>
        /// Tests the BaseResource.GetFullName method.
        /// </summary>
        [Test]
        public void FullNameTest()
        {
            var subJson = new JsonDictionary();
            subJson.Add("resources", new JsonDictionary { { "Grandchild", new JsonDictionary() } });
            var topJson = new JsonDictionary();
            topJson.Add("resources", new JsonDictionary { { "Sub", subJson } });

            // Create the resource hierachy.
            var topResource = new ResourceV1_0(new KeyValuePair<string, object>("Top", topJson));
            var subResource = topResource.Resources["Sub"];
            var grandchildResource = subResource.Resources["Grandchild"];
         
            // Check the generated full name.
            Assert.AreEqual("Top", topResource.Path);
            Assert.AreEqual("Top.Sub", subResource.Path);
            Assert.AreEqual("Top.Sub.Grandchild", grandchildResource.Path);
        }

        /// <summary>
        /// Tests the BaseResource.GetFullName method when dealing with a root resource.
        /// </summary>
        [Test]
        public void RootResourceTest()
        {
            var subJson = new JsonDictionary();
            subJson.Add("resources", new JsonDictionary { { "Grandchild", new JsonDictionary() } });
            var topJson = new JsonDictionary();
            topJson.Add("resources", new JsonDictionary { { "Sub", subJson } });

            // Create the resource hierachy.
            var topResource = new ResourceV1_0(new KeyValuePair<string, object>("", topJson));
            var subResource = topResource.Resources["Sub"];
            var grandchildResource = subResource.Resources["Grandchild"];

            // Check the generated full name.
            Assert.AreEqual("", topResource.Path);
            Assert.AreEqual("Sub", subResource.Path);
            Assert.AreEqual("Sub.Grandchild", grandchildResource.Path);
        }
    }
}
