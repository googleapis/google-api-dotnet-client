/*
Copyright 2012 Google Inc

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

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth2;
using NUnit.Framework;

using Google.Apis.Authentication.OAuth2.DotNetOpenAuth;
using Google.Apis.Json;

namespace Google.Apis.Authentication.OAuth2.Tests.DotNetOpenAuth
{
    /// <summary>
    /// Tests for the NativeApplicationClient class.
    /// </summary>
    [TestFixture]
    public class AssertionFlowClientTest
    {
        private const string Scope = "https://www.googleapis.com/auth/drive.file";
        private const string ServiceAccountId = "APP_ID-test@developer.gserviceaccount.com";
        private const string ServiceAccountUser = "user@example.com";

        private AssertionFlowClient client;
        private IAuthorizationState state;
        private MockChannel channel;

        private class MockChannel {

            public IDirectedProtocolMessage Request(IProtocolMessage request) {
                RequestMessage = request;
                return ResponseMessage;
            }

            public IProtocolMessage RequestMessage { get; internal set; }
            public IDirectedProtocolMessage ResponseMessage { get; set; }

        }

        /// <summary>
        /// Sets up the test case by instantiating the AssertionFlowClient and AuthorizationState.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            client = new AssertionFlowClient(
                GoogleAuthenticationServer.Description, new X509Certificate2(@"test-key.p12", "notasecret", X509KeyStorageFlags.Exportable)) {
                Scope = Scope,
                ServiceAccountId = ServiceAccountId
            };
            state = new AuthorizationState(client.Scope.Split(' '));
            channel = new MockChannel() {
                ResponseMessage = new AssertionFlowMessage(GoogleAuthenticationServer.Description)
            };
        }

        /// <summary>
        /// Test that the assertion message is properly constructed.
        /// </summary>
        [Test]
        public void AssertionMessageTest()
        {
            client.RefreshToken(state, null, channel.Request);
            Assert.NotNull(channel.RequestMessage);
            Assert.IsInstanceOf<AssertionFlowMessage>(channel.RequestMessage);

            AssertionFlowMessage requestMessage = channel.RequestMessage as AssertionFlowMessage;
            Assert.AreEqual(requestMessage.GrantType, "assertion");
            Assert.AreEqual(requestMessage.AssertionType, "http://oauth.net/grant_type/jwt/1.0/bearer");
            string[] assertion = requestMessage.Assertion.Split('.');
            Assert.AreEqual(3, assertion.Length);
        }

        /// <summary>
        /// Test that the assertion JWT's header is properly constructed.
        /// </summary>
        [Test]
        public void JWTHeaderTest()
        {
            client.RefreshToken(state, null, channel.Request);
            AssertionFlowMessage requestMessage = channel.RequestMessage as AssertionFlowMessage;
            string[] assertion = requestMessage.Assertion.Split('.');
            // Constant JWT header.
            Assert.AreEqual("eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9", assertion[0]);
        }

        /// <summary>
        /// Test that the JWT claim is properly constructed.
        /// </summary>
        [Test]
        public void JWTClaimTestNoServiceAccountUser()
        {
            client.RefreshToken(state, null, channel.Request);
            AssertionFlowMessage requestMessage = channel.RequestMessage as AssertionFlowMessage;
            string[] assertion = requestMessage.Assertion.Split('.');
            AssertClaim(assertion[1]);
        }

        /// <summary>
        /// Test that the JWT claim is properly constructed.
        /// </summary>
        [Test]
        public void JWTClaimTestWithServiceAccountUser()
        {
            client.ServiceAccountUser = ServiceAccountUser;
            client.RefreshToken(state, null, channel.Request);
            AssertionFlowMessage requestMessage = channel.RequestMessage as AssertionFlowMessage;
            string[] assertion = requestMessage.Assertion.Split('.');
            AssertClaim(assertion[1], ServiceAccountUser);
        }

        /// <summary>
        /// Test that the JWT signature is properly constructed.
        /// </summary>
        [Test]
        public void JWTSignatureTest()
        {
            client.RefreshToken(state, null, channel.Request);
            AssertionFlowMessage requestMessage = channel.RequestMessage as AssertionFlowMessage;
            string[] assertion = requestMessage.Assertion.Split('.');
            StringBuilder signatureBase = new StringBuilder();
            signatureBase.Append(assertion[0]);
            signatureBase.Append(".");
            signatureBase.Append(assertion[1]);
            string signature = urlsafeBase64Decode(assertion[2]);

            Assert.AreEqual(
                signature,
                Encoding.UTF8.GetString(client.Key.SignData(Encoding.ASCII.GetBytes(signatureBase.ToString()), "SHA256")));
        }

        /// <summary>
        /// Tests that the RefreshToken method successfully parses a success response.
        /// </summary>
        [Test]
        public void SuccessfulRefreshTokenTest()
        {
            channel.ResponseMessage.ExtraData.Add("access_token", "ACCESS_TOKEN");
            channel.ResponseMessage.ExtraData.Add("expires_in", "3600");

            // Call RefreshToken and ensure the call is successful.
            Assert.True(client.RefreshToken(state, null, channel.Request));

            // Test the Authorization state.
            Assert.AreEqual("ACCESS_TOKEN", state.AccessToken);
            Assert.AreEqual(
                3600, (state.AccessTokenExpirationUtc.Value - state.AccessTokenIssueDateUtc.Value).TotalSeconds);
        }

        /// <summary>
        /// Tests that the RefreshToken method successfully parses a failure response.
        /// </summary>
        [Test]
        public void FailedRefreshTokenTest()
        {
            Assert.False(client.RefreshToken(state, null, channel.Request));
            // Test the Authorization state.
            Assert.IsNullOrEmpty(state.AccessToken);
        }

        /// <summary>
        /// Asserts the claim values against the constants.
        /// </summary>
        /// <param name='base64EncodedClaim'>
        /// Base64 encoded claim.
        /// </param>
        /// <param name='serviceAccountUser'>
        /// Service account user to test against (can be null).
        /// </param>
        private void AssertClaim(string base64EncodedClaim, string serviceAccountUser = null) {
            AssertionFlowClaim claim = NewtonsoftJsonSerializer.Instance.Deserialize<AssertionFlowClaim>(
                urlsafeBase64Decode(base64EncodedClaim));
            Assert.IsNotNull(claim);
            Assert.AreEqual(ServiceAccountId, claim.Issuer);
            Assert.AreEqual(Scope, claim.Scope);
            Assert.AreEqual(serviceAccountUser, claim.Principal);
            Assert.AreEqual(GoogleAuthenticationServer.Description.TokenEndpoint.ToString(), claim.Audience);
            Assert.AreEqual(3600, claim.ExpiresAt - claim.IssuedAt);
        }

        /// <summary>
        /// Base64 decode the provided string.
        /// </summary>
        /// <returns>
        /// The base64 decoded string.
        /// </returns>
        /// <param name='base64String'>
        /// Base64 string.
        /// </param>
        private string urlsafeBase64Decode(string base64String) {
            // Remove the URL safe encoding.
            var paddedString = base64String.PadRight(base64String.Length + (4 - base64String.Length % 4) % 4, '=');
            paddedString = paddedString.Replace('-', '+').Replace('_', '/');
            // Decode the string.
            return Encoding.UTF8.GetString(Convert.FromBase64String(paddedString));
        }

    }
}
