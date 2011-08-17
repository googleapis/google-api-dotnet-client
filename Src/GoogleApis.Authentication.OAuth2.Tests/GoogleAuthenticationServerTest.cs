/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using DotNetOpenAuth.OAuth2;
using NUnit.Framework;

namespace Google.Apis.Authentication.OAuth2.Tests
{
    /// <summary>
    /// Tests for the GoogleAuthenticationServer class.
    /// </summary>
    [TestFixture]
    public class GoogleAuthenticationServerTest
    {
        /// <summary>
        /// Confirms that the Description property is initialised and that it will return plausible values.
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // Test that the property is set.
            Assert.IsNotNull(GoogleAuthenticationServer.Description);
            
            // Test that it returns the same instance on every call.
            Assert.AreEqual(GoogleAuthenticationServer.Description, GoogleAuthenticationServer.Description);

            AuthorizationServerDescription description = GoogleAuthenticationServer.Description;
            Assert.IsNotNull(description.AuthorizationEndpoint);
            Assert.IsNotNull(description.TokenEndpoint);
            Assert.AreEqual(
                ProtocolVersion.V20, description.ProtocolVersion,
                "A new or invalid protocol version has been specified. Did you forget to update an unit test?");
        }
    }
}
