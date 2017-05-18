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
using Xunit;

namespace Google.Apis.Tests
{
    /// <summary>
    /// Tests for the GoogleApiException class
    /// </summary>
    public class GoogleApiExceptionTests
    {
        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Fact]
        public void ConstructorTest()
        {
            var name = "TestName_ConstructorTest";

            var exception = new GoogleApiException(name, "Test");
            Assert.IsAssignableFrom<Exception>(exception);
            Assert.Contains(name, exception.ToString());
        }

        /// <summary>
        /// Tests if the exception can thrown correctly
        /// </summary>
        [Fact]
        public void ThrowTest()
        {
            Assert.Throws<GoogleApiException>((Action)(() => throw new GoogleApiException("name", "Test")));
        }

        /// <summary>
        /// Tests that the constructor will fail when invalid arguments are passed
        /// </summary>
        [Fact]
        public void ConstructorFailTest()
        {
            Assert.Throws<ArgumentNullException>(() => new GoogleApiException(null, "Test"));
        }
    }
}
