/*
Copyright 2023 Google Inc

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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2;

public class UserCredentialTests
{
    [Fact]
    public async Task UniverseDomain_Default()
    {
        var credential = new UserCredential(
            FakeAuthorizationCodeFlow.Default, "userId", token: null, quotaProjectId: "quotaProject") as IGoogleCredential;

        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));
    }

    [Theory]
    [InlineData(null)]
    [InlineData(GoogleAuthConsts.DefaultUniverseDomain)]
    public async Task WithUniverseDomain_Default(string universeDomain)
    {
        var credential = new UserCredential(
            FakeAuthorizationCodeFlow.Default, "userId", token: null, quotaProjectId: "quotaProject") as IGoogleCredential;

        var newCredential = credential.WithUniverseDomain(universeDomain);

        Assert.Same(credential, newCredential);

        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, newCredential.GetUniverseDomain());
        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await newCredential.GetUniverseDomainAsync(default));
    }

    [Fact]
    public void WithUniverseDomain_Custom_Fails()
    {
        var credential = new UserCredential(
            FakeAuthorizationCodeFlow.Default, "userId", token: null, quotaProjectId: "quotaProject") as IGoogleCredential;

        Assert.Throws<InvalidOperationException>(() => credential.WithUniverseDomain("universeDomain"));
    }

    private class FakeAuthorizationCodeFlow : IAuthorizationCodeFlow
    {
        public static readonly FakeAuthorizationCodeFlow Default = new FakeAuthorizationCodeFlow();

        public IAccessMethod AccessMethod => throw new NotImplementedException();

        public IClock Clock => SystemClock.Default;

        public IDataStore DataStore => throw new NotImplementedException();

        public AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri) => throw new NotImplementedException();

        public Task DeleteTokenAsync(string userId, CancellationToken taskCancellationToken) => throw new NotImplementedException();

        public void Dispose() => throw new NotImplementedException();

        public Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, string code, string redirectUri, CancellationToken taskCancellationToken) => throw new NotImplementedException();

        public Task<TokenResponse> LoadTokenAsync(string userId, CancellationToken taskCancellationToken) => throw new NotImplementedException();

        public Task<TokenResponse> RefreshTokenAsync(string userId, string refreshToken, CancellationToken taskCancellationToken) => throw new NotImplementedException();

        public Task RevokeTokenAsync(string userId, string token, CancellationToken taskCancellationToken) => throw new NotImplementedException();

        public bool ShouldForceTokenRetrieval() => throw new NotImplementedException();
    }
}
