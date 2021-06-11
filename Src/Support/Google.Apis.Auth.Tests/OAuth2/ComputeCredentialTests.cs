/*
Copyright 2015 Google Inc

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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using Google.Apis.Tests.Mocks;
using System;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Auth.JsonWebSignature;

namespace Google.Apis.Auth.Tests.OAuth2
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.ComputeCredential"/>.</summary>
    public class ComputeCredentialTests
    {
        // Temporarily remove this test as we often are testing on GCE instances.
        /*[Test]
        public void IsRunningOnComputeEngine()
        {
            // It should be safe to assume that this test is not running on GCE.
            Assert.IsFalse(ComputeCredential.IsRunningOnComputeEngine().Result);
        }*/

        [Fact]
        public void IsRunningOnComputeEngine_ResultIsCached()
        {
            // Two subsequent invocations should return the same task.
            Assert.Same(ComputeCredential.IsRunningOnComputeEngine(),
                ComputeCredential.IsRunningOnComputeEngine());
        }

        [Fact]
        public void WithHttpClientFactory()
        {
            var credential = new ComputeCredential();
            var factory = new HttpClientFactory();
            var credentialWithFactory = Assert.IsType<ComputeCredential>(((IGoogleCredential)credential).WithHttpClientFactory(factory));

            Assert.NotSame(credential, credentialWithFactory);
            Assert.NotSame(credential.HttpClient, credentialWithFactory.HttpClient);
            Assert.NotSame(credential.HttpClientFactory, credentialWithFactory.HttpClientFactory);
            Assert.Same(factory, credentialWithFactory.HttpClientFactory);
        }

        [Fact]
        public async Task FetchesOidcToken()
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            // The fake Oidc server returns valid tokens (expired in the real world for safty)
            // but with a set audience that lets us know if the token was refreshed or not.
            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));

            var signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://first_call.test", signedToken.Payload.Audience);
            // Move the clock some but not enough that the token expires.
            clock.UtcNow = clock.UtcNow.AddMinutes(20);
            signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://first_call.test", signedToken.Payload.Audience);
            // Only the first call should have resulted in a request. The second time the token hadn't expired.
            Assert.Equal(1, messageHandler.Calls);
        }

        [Fact]
        public async Task RefreshesOidcToken()
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            // The fake Oidc server returns valid tokens (expired in the real world for safty)
            // but with a set audience that lets us know if the token was refreshed or not.
            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));

            var signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://first_call.test", signedToken.Payload.Audience);
            // Move the clock so that the token expires.
            clock.UtcNow = clock.UtcNow.AddHours(2);
            signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://subsequent_calls.test", signedToken.Payload.Audience);
            // Two calls, because the second time we tried to get the token, the first one had expired.
            Assert.Equal(2, messageHandler.Calls);
        }

        [Fact]
        public async Task FetchesOidcToken_WithDefaultOptions()
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("any_audience"));
            await oidcToken.GetAccessTokenAsync();

            Assert.Equal("?audience=any_audience&format=full", messageHandler.LatestRequest.RequestUri.Query);
        }

        [Theory]
        [InlineData(OidcTokenFormat.Full, "another_audience", "?audience=another_audience&format=full")]
        [InlineData(OidcTokenFormat.Standard, "another_audience", "?audience=another_audience")]
        [InlineData(OidcTokenFormat.FullWithLicences, "another_audience", "?audience=another_audience&format=full&licenses=true")]
        public async Task FetchesOidcToken_WithOptions(OidcTokenFormat format, string targetAudience, string expectedQueryString)
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var credential = new ComputeCredential(initializer);

            var oidcToken = await credential.GetOidcTokenAsync(
                OidcTokenOptions.FromTargetAudience("any_audience")
                .WithTargetAudience(targetAudience)
                .WithTokenFormat(format));
            await oidcToken.GetAccessTokenAsync();

            Assert.Equal(expectedQueryString, messageHandler.LatestRequest.RequestUri.Query);
        }
    }
}
