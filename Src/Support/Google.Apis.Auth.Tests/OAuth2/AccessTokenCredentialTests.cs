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
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2;

public class AccessTokenCredentialTests
{
    private const string FakeAccessToken = "fake access token";
    private const string FakeQuotaProject = "fake-quota-project";
    private const string FakeUniverseDomain = "fake.universe.domain.com";

    [Fact]
    public async Task Constructor_Minimal()
    {
        var credential = new AccessTokenCredential(FakeAccessToken, FakeAccessMethod.Default);

        Assert.Equal(FakeAccessToken, await credential.GetAccessTokenForRequestAsync());
        Assert.Null(credential.QuotaProject);

        var googleCredential = credential as IGoogleCredential;
        Assert.False(googleCredential.SupportsExplicitScopes);
        Assert.False(googleCredential.HasExplicitScopes);
        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, googleCredential.GetUniverseDomain());
        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await googleCredential.GetUniverseDomainAsync(default));
    }

    [Fact]
    public async Task Constructor_Full()
    {
        var credential = new AccessTokenCredential(FakeAccessToken, FakeAccessMethod.Default, FakeQuotaProject, FakeUniverseDomain);

        Assert.Equal(FakeAccessToken, await credential.GetAccessTokenForRequestAsync());
        Assert.Equal(FakeQuotaProject, credential.QuotaProject);

        var googleCredential = credential as IGoogleCredential;
        Assert.False(googleCredential.SupportsExplicitScopes);
        Assert.False(googleCredential.HasExplicitScopes);
        Assert.Equal(FakeUniverseDomain, googleCredential.GetUniverseDomain());
        Assert.Equal(FakeUniverseDomain, await googleCredential.GetUniverseDomainAsync(default));
    }

    [Fact]
    public async Task WithUniverseDomain()
    {
        var credential = new AccessTokenCredential(FakeAccessToken, FakeAccessMethod.Default) as IGoogleCredential;
        var newCredential = credential.WithUniverseDomain(FakeUniverseDomain);

        Assert.NotSame(credential, newCredential);
        Assert.IsType<AccessTokenCredential>(newCredential);

        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));

        Assert.Equal(FakeUniverseDomain, newCredential.GetUniverseDomain());
        Assert.Equal(FakeUniverseDomain, await newCredential.GetUniverseDomainAsync(default));
    }

    private class FakeAccessMethod : IAccessMethod
    {
        public static readonly FakeAccessMethod Default = new FakeAccessMethod();
        public string GetAccessToken(HttpRequestMessage request) => throw new NotImplementedException();

        public void Intercept(HttpRequestMessage request, string accessToken) => throw new NotImplementedException();
    }
}
