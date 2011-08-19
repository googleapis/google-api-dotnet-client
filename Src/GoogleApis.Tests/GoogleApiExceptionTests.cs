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
using Google.Apis.Tests.Apis.Requests;
using NUnit.Framework;

namespace Google.Apis.Tests
{
    /// <summary>
    /// Tests for the GoogleApiException class
    /// </summary>
    [TestFixture]
    public class GoogleApiExceptionTests
    {
        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void ConstructorTest()
        {
            var service = new MockService();

            var exception = new GoogleApiException(service, "Test");
            Assert.IsInstanceOf<Exception>(exception);
            Assert.That(exception.Service, Is.EqualTo(service));
            Assert.That(exception.ToString(), Contains.Substring(service.Name));
        }

        /// <summary>
        /// Tests if the exception can thrown correctly
        /// </summary>
        [Test]
        public void ThrowTest()
        {
            var service = new MockService();
            Assert.Throws<GoogleApiException>(() => { throw new GoogleApiException(service, "Test"); });
        }

        /// <summary>
        /// Tests that the constructor will fail when invalid arguments are passed
        /// </summary>
        [Test]
        public void ConstructorFailTest()
        {
            Assert.Throws<ArgumentNullException>(() => new GoogleApiException(null, "Test"));
        }
    }
}
