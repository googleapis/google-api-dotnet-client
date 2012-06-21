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
using System.Linq;
using NUnit.Framework;
using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Discovery
{
    /// <summary>
    /// Tests the "MediaUpload"-class
    /// </summary>
    [TestFixture]
    public class MediaUploadTest
    {
        private const string SampleInsertMethod = @"
{
    'accept': [
        'image/*',
        'video/*',
        'audio/*'
    ],
    'maxSize': '10GB',
    'protocols': {
        'simple': {
            'multipart': true,
            'path': '/upload/test/v4/resources'
        },
        'resumable': {
            'multipart': true,
            'path': '/resumable/upload/test/v4/resources'
        }
    }
}";

        /// <summary>
        /// Tests that the constructor fills in the proper default arguments
        /// </summary>
        [Test]
        public void TestConstructor()
        {
            var method = new MediaUpload(JsonReader.Parse(SampleInsertMethod) as JsonDictionary);
            Assert.That(method.MaxSize, Is.Not.Null);
            Assert.That(method.MaxSize, Is.EqualTo("10GB"));
        }

        [Test]
        public void TestAccepts()
        {
            var method = new MediaUpload(JsonReader.Parse(SampleInsertMethod) as JsonDictionary);
            Assert.That(method.Accepts, Is.Not.Null);
            Assert.That(method.Accepts.Length, Is.EqualTo(3));
            Assert.That(method.Accepts, Is.EquivalentTo(
                new string[] { "image/*", "video/*", "audio/*" }));
        }

        [Test]
        public void TestProtocols()
        {
            var method = new MediaUpload(JsonReader.Parse(SampleInsertMethod) as JsonDictionary);
            Assert.That(method.Simple, Is.Not.Null);
            Assert.That(method.Simple.MultiPart, Is.True);
            Assert.That(method.Simple.Path, Is.Not.Null);
            Assert.That(method.Simple.Path, Is.EqualTo("/upload/test/v4/resources"));

            Assert.That(method.Resumable, Is.Not.Null);
            Assert.That(method.Resumable.MultiPart, Is.True);
            Assert.That(method.Resumable.Path, Is.Not.Null);
            Assert.That(method.Resumable.Path, Is.EqualTo("/resumable/upload/test/v4/resources"));
        }
    }
}
