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

using Google.Apis.Authentication;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Authentication
{
    /// <summary>
    /// Tests for the Authenticator class
    /// </summary>
    [TestFixture]
    public class AuthenticatorFactoryTest
    {
        private class MockAuthenticator : Authenticator
        {
            public MockAuthenticator() : base("Mock Application") {}
        }

        /// <summary>
        /// Checks if an instance of the AuthenticatorFactory can be retrieved
        /// </summary>
        [Test]
        public void GetInstanceTest()
        {
            Assert.NotNull(AuthenticatorFactory.GetInstance());
        }

        /// <summary>
        /// Check that a NullAuthenticator is returned by default
        /// </summary>
        [Test]
        public void DefaultAuthenticatorTest()
        {
            Assert.IsInstanceOf<NullAuthenticator>(AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator());
        }

        /// <summary>
        /// Checks that other authenticators can be registered
        /// </summary>
        [Test]
        public void RegisterAuthenticatorTest()
        {
            var authFactory = AuthenticatorFactory.GetInstance();
            Assert.IsNotInstanceOf<MockAuthenticator>(authFactory.GetRegisteredAuthenticator());

            // Register Authenticator
            authFactory.RegisterAuthenticator(() => new MockAuthenticator());

            // Test result
            Assert.IsInstanceOf<MockAuthenticator>(authFactory.GetRegisteredAuthenticator());
        } 
    }
}
