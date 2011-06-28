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

using Google.Apis.Authentication.OAuth2.DotNetOpenAuth;
using NUnit.Framework;

namespace Google.Apis.Authentication.OAuth2.Tests.DotNetOpenAuth
{
    /// <summary>
    /// Tests for the NativeApplicationClient class.
    /// </summary>
    [TestFixture]
    public class NativeApplicationClientTest
    {
        /// <summary>
        /// Tests the constructor of this class.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new NativeApplicationClient(GoogleAuthenticationServer.Description));
            Assert.IsNotNullOrEmpty(NativeApplicationClient.OutOfBandCallbackUrl);
        }

        /// <summary>
        /// Tests that the RequestUserAuthorization method will return a valid Request URI.
        /// </summary>
        [Test]
        public void RequestUserAuthorizationTest()
        {
            var client = new NativeApplicationClient(GoogleAuthenticationServer.Description);
            client.ClientIdentifier = "Test";
            client.ClientSecret = "123";

            // Check that the callback URL is set correctly. We test this, as the Out of Band URI is required
            // for most cases of the Native-Application flow.
            Assert.IsTrue(
                client.RequestUserAuthorization().ToString().Contains(NativeApplicationClient.OutOfBandCallbackUrl));
        }
    }
}
