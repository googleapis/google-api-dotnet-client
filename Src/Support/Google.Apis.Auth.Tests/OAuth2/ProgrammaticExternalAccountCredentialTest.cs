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
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2;

public class ProgrammaticExternalAccountCredentialTest : ExternalAccountCredentialTestsBase
{
    public class FakeSubjectTokenProvider : ProgrammaticExternalAccountCredential.ISubjectTokenProvider
    {
        private readonly string _subjectToken;
        
        public ProgrammaticExternalAccountCredential LatestCaller { get; private set; }

        private int _callCount = 0;
        public int CallCount => _callCount;

        public FakeSubjectTokenProvider(string subjectToken = FakeSubjectTokenText) => _subjectToken = subjectToken;

        public Task<string> GetSubjectTokenAsync(ProgrammaticExternalAccountCredential caller, CancellationToken taskCancellationToken)
        {
            LatestCaller = caller;
            Interlocked.Increment(ref _callCount);
            return Task.FromResult(_subjectToken);
        }
    }

    [Fact]
    public async Task UniverseDomain_Default()
    {
        var credential = new ProgrammaticExternalAccountCredential(new ProgrammaticExternalAccountCredential.Initializer(
            TokenUrl, FakeAudience, FakeSubjectTokenType, new FakeSubjectTokenProvider())) as IGoogleCredential;

        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));
    }

    [Fact]
    public async Task UniverseDomain_Custom()
    {
        var credential = new ProgrammaticExternalAccountCredential(new ProgrammaticExternalAccountCredential.Initializer(
            TokenUrl, FakeAudience, FakeSubjectTokenType, new FakeSubjectTokenProvider())
        {
            UniverseDomain = FakeUniverseDomain
        }) as IGoogleCredential;

        Assert.Equal(FakeUniverseDomain, credential.GetUniverseDomain());
        Assert.Equal(FakeUniverseDomain, await credential.GetUniverseDomainAsync(default));
    }

    [Fact]
    public async Task WithUniverseDomain()
    {
        var credential = new ProgrammaticExternalAccountCredential(new ProgrammaticExternalAccountCredential.Initializer(
            TokenUrl, FakeAudience, FakeSubjectTokenType, new FakeSubjectTokenProvider())) as IGoogleCredential;

        var newCredential = credential.WithUniverseDomain(FakeUniverseDomain);

        Assert.NotSame(credential, newCredential);
        Assert.IsType<ProgrammaticExternalAccountCredential>(newCredential);

        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
        Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));

        Assert.Equal(FakeUniverseDomain, newCredential.GetUniverseDomain());
        Assert.Equal(FakeUniverseDomain, await newCredential.GetUniverseDomainAsync(default));
    }

    [Fact]
    public async Task FetchesAccessToken()
    {
        var messageHandler = new DelegatedMessageHandler(request => ValidateAccessTokenRequest(request, FakeScope));

        var credential = new ProgrammaticExternalAccountCredential(
            new ProgrammaticExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, new FakeSubjectTokenProvider())
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                ClientId = FakeClientId,
                ClientSecret = FakeClientSecret,
                Scopes = new string[] { FakeScope },
                QuotaProject = FakeQuotaProject
            });

        var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

        AssertAccessTokenWithHeaders(token);
        messageHandler.AssertAllCallsMade();
    }

    [Fact]
    public async Task FetchesAccessToken_Caller()
    {
        var subjectTokenProvider = new FakeSubjectTokenProvider();
        var messageHandler = new DelegatedMessageHandler(request => ValidateAccessTokenRequest(request, FakeScope));

        var credential = new ProgrammaticExternalAccountCredential(
            new ProgrammaticExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, subjectTokenProvider)
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                ClientId = FakeClientId,
                ClientSecret = FakeClientSecret,
                Scopes = new string[] { FakeScope }
            });

        await credential.GetAccessTokenForRequestAsync();

        Assert.Same(credential, subjectTokenProvider.LatestCaller);
        messageHandler.AssertAllCallsMade();
    }

    [Fact]
    public async Task FetchesAccessToken_Impersonated()
    {
        var messageHandler = new DelegatedMessageHandler(
            request => ValidateAccessTokenRequest(request, ImpersonationScope),
            ValidateImpersonatedAccessTokenRequest);

        var credential = new ProgrammaticExternalAccountCredential(
            new ProgrammaticExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, new FakeSubjectTokenProvider())
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                ClientId = FakeClientId,
                ClientSecret = FakeClientSecret,
                Scopes = new string[] { FakeScope },
                QuotaProject = FakeQuotaProject,
                ServiceAccountImpersonationUrl = ImpersonationUrl
            });

        var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

        AssertImpersonatedAccessTokenWithHeaders(token);
        messageHandler.AssertAllCallsMade();
    }

    [Fact]
    public async Task FetchesAccessToken_Workforce()
    {
        var messageHandler = new DelegatedMessageHandler(request =>
            // Note this method will validate workforce.
            ValidateAccessTokenRequest(request, FakeScope, isWorkforce: true));

        var credential = new ProgrammaticExternalAccountCredential(
            new ProgrammaticExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, new FakeSubjectTokenProvider())
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                WorkforcePoolUserProject = FakeWorkforcePoolUserProject,
                Scopes = new string[] { FakeScope },
                QuotaProject = FakeQuotaProject
            });

        var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

        AssertAccessTokenWithHeaders(token);
        messageHandler.AssertAllCallsMade();
    }

    [Fact]
    public async Task FetchesAccessToken_ClientIdAndSecret_IgnoresWorkforce()
    {
        var messageHandler = new DelegatedMessageHandler(request =>
            // The workforce project is not sent if the Client ID and secret are sent.
            // This method will validate that because we set isWorkforce to false.
            ValidateAccessTokenRequest(request, FakeScope, isWorkforce: false));

        var credential = new ProgrammaticExternalAccountCredential(
            new ProgrammaticExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, new FakeSubjectTokenProvider())
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                WorkforcePoolUserProject = FakeWorkforcePoolUserProject,
                ClientId = FakeClientId,
                ClientSecret = FakeClientSecret,
                Scopes = new string[] { FakeScope },
                QuotaProject = FakeQuotaProject
            });

        var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

        AssertAccessTokenWithHeaders(token);
        messageHandler.AssertAllCallsMade();
    }

    [Fact]
    public async Task RefreshesAccessToken()
    {
        var fakeSubjectTokenProvider = new FakeSubjectTokenProvider();
        var messageHandler = new DelegatedMessageHandler(AccessTokenRequest, RefreshTokenRequest);
        var clock = new MockClock(DateTime.UtcNow);

        var credential = new ProgrammaticExternalAccountCredential(
            new ProgrammaticExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, fakeSubjectTokenProvider)
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                Clock = clock
            });

        Assert.Equal(FakeAccessToken, await credential.GetAccessTokenForRequestAsync());

        clock.UtcNow = clock.UtcNow.AddDays(2);

        Assert.Equal(FakeRefreshedAccessToken, await credential.GetAccessTokenForRequestAsync());

        Assert.Equal(2, fakeSubjectTokenProvider.CallCount);
        messageHandler.AssertAllCallsMade();
    }
}
