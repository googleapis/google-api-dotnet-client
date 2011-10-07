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
using Google.Apis.Requests;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// Tests for the UriFactory and System.Uri class.
    /// </summary>
    [TestFixture]
    public class UriFactoryTest
    {
        /// <summary>
        /// Tests whether a simple Uri is created correctly.
        /// </summary>
        [Test]
        public void CreateUriTest()
        {
            Assert.AreEqual(new Uri("http://example.com/").ToString(), 
                            UriFactory.Create("http://example.com/").ToString());
        }

        /// <summary>
        /// This tests whether the "Uri-unescape"-bug (see link below) has been fixed.
        /// http://stackoverflow.com/questions/781205/c-net-getting-a-url-with-an-url-encoded-slash
        /// 
        /// If this test should FAIL, then this bug has been fixed in the latest version of the Microsoft .NET
        /// Framework, and our workaround is no longer necessary.
        /// </summary>
        [Test]
        public void UriSlashUnescapeBugStillExistsTest()
        {
            if (Utilities.IsRunningOnMono)
            {
                return; // The bug does not exist on mono.
            }

            const string pathAndQuery = "/te%2Fst/";
            const string testUrl = "http://example.com" + pathAndQuery;

            Assert.IsFalse(pathAndQuery == new Uri(testUrl).PathAndQuery);
        }

        /// <summary>
        /// This tests whether the workaround for the "Uri-unescape"-bug (see link below) works.
        /// http://stackoverflow.com/questions/781205/c-net-getting-a-url-with-an-url-encoded-slash
        /// </summary>
        [Test]
        public void UriSlashUnescapeBugWorkaroundTest()
        {
            const string pathAndQuery = "/te%2Fst/";
            const string testUrl = "http://example.com" + pathAndQuery;
            
            Assert.AreEqual(pathAndQuery, UriFactory.Create(testUrl).PathAndQuery);
        }
    }
}
