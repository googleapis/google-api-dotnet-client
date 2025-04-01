/*
Copyright 2025 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using Google.Apis.Tests.Mocks;
using System;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2;

public class ExternalAcountAuthorizeUserCredentialTests
{
    [Theory]
    [InlineData(null, null, null, GoogleAuthConsts.DefaultUniverseDomain)]
    [InlineData("audience", "token.info.url", "custom.domain", "custom.domain")]
    public void Valid(string audience, string tokenInfoUrl, string universeDomain, string expectedUniverseDomain)
    {
        var credential = new ExternalAccountAuthorizedUserCredential(
            new ExternalAccountAuthorizedUserCredential.Initializer("token.url", "refreshToken", "client ID", "secret")
            { 
                Audience = audience,
                TokenInfoUrl = tokenInfoUrl,
                UniverseDomain = universeDomain,
            });

        Assert.Equal("token.url", credential.TokenServerUrl);
        Assert.Equal("refreshToken", credential.RefreshToken);
        Assert.Equal("client ID", credential.ClientId);
        Assert.Equal("secret", credential.ClientSecret);
        Assert.Equal(audience, credential.Audience);
        Assert.Equal(tokenInfoUrl, credential.TokenInfoUrl);
        Assert.Equal(expectedUniverseDomain, credential.UniverseDomain);

        var googleCredential = credential as IGoogleCredential;
        Assert.False(googleCredential.SupportsExplicitScopes);
    }

    [Theory]
    [InlineData(null, "refreshToken", "client ID", "secret")]
    [InlineData("token.url", null, "client ID", "secret")]
    [InlineData("token.url", "refreshToken", null, "secret")]
    [InlineData("token.url", "refreshToken", "client ID", null)]
    public void InvalidInitializer(string tokenServerUrl, string refreshToken, string clientId, string clientSecret) =>
        Assert.Throws<ArgumentException>(() => new ExternalAccountAuthorizedUserCredential.Initializer(tokenServerUrl, refreshToken, clientId, clientSecret));

    [Fact]
    public void MaybeWithScopes_Same()
    {
        var credential = new ExternalAccountAuthorizedUserCredential(
            new ExternalAccountAuthorizedUserCredential.Initializer("token.url", "refreshToken", "client ID", "secret"));

        var maybeNewCredential = (credential as IGoogleCredential).MaybeWithScopes(new string[] { "scope1" });

        Assert.Same(credential, maybeNewCredential);
        Assert.False(maybeNewCredential.SupportsExplicitScopes);
        Assert.False(maybeNewCredential.HasExplicitScopes);
    }

    [Fact]
    public void WithUserForDomainDelegation_Throws()
    {
        var credential = new ExternalAccountAuthorizedUserCredential(
            new ExternalAccountAuthorizedUserCredential.Initializer("token.url", "refreshToken", "client ID", "secret"));

        Assert.Throws<InvalidOperationException>(() => (credential as IGoogleCredential).WithUserForDomainWideDelegation("user"));
    }

    [Fact]
    public async Task FetchesAccessToken()
    {
        var handler = new FetchesTokenMessageHandler();
        var credential = new ExternalAccountAuthorizedUserCredential(
            new ExternalAccountAuthorizedUserCredential.Initializer("https://token.url/", "refreshToken", "client ID", "secret")
            {
                HttpClientFactory = new MockHttpClientFactory(handler)
            });

        var token = await credential.GetAccessTokenForRequestAsync();
        Assert.Equal("a", token);
        Assert.Equal("r", credential.RefreshToken);

        var request = Assert.Single(handler.Requests);
        Assert.Equal("https://token.url/", request.RequestUri.AbsoluteUri);
        Assert.Equal("Basic", request.Headers.Authorization.Scheme);
        Assert.Equal(Convert.ToBase64String(Encoding.UTF8.GetBytes("client ID:secret")), request.Headers.Authorization.Parameter);
        Assert.Equal("refresh_token=refreshToken&grant_type=refresh_token", handler.LatestRequestContent);
    }
}
