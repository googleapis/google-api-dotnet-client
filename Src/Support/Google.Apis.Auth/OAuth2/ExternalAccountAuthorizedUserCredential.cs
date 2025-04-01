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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Http;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2;

/// <summary>
/// OAuth2 credentials sourced using external identities through Workforce Identity Federation.
/// Obtaining the initial access and refresh token can be done through the Google Cloud CLI.
/// </summary>
public sealed class ExternalAccountAuthorizedUserCredential : ServiceCredential, IGoogleCredential
{
    // Even though this represents and external user credential it's not a descendant of ExternalAccountCredential
    // or UserCredential, because all the external account and user account parts of the authorization flow
    // happen outside Google.Apis.Auth. For the library, this is just a credential for which we know how to obtain
    // and refresh an access token.

    new internal class Initializer : ServiceCredential.Initializer
    {
        /// <summary>
        /// The refresh token used to refresh the access token that will be associated with the credential.
        /// Must not be null or empty.
        /// </summary>
        internal string RefreshToken { get; }

        /// <summary>
        /// The client ID to use for basic authentication for refresh token requests.
        /// Must not be null or empty.
        /// </summary>
        internal string ClientId { get; }

        /// <summary>
        /// The client secret to use for basic authentication for refresh token requests.
        /// Must not be null or empty.
        /// </summary>
        internal string ClientSecret { get; }

        /// <summary>
        /// This is the STS audience which contains the resource name for the workforce pool
        /// and the provider identifier in that pool. May be null as this value is kept for
        /// informational purposes only.
        /// </summary>
        internal string Audience { get; set; }

        /// <summary>
        /// Endpoint to retrieve information related to the user account, like email, username, etc.
        /// May be null as this value is kept for informational purposes only.
        /// </summary>
        internal string TokenInfoUrl { get; set; }

        /// <summary>
        /// The universe domain this credential belongs to.
        /// May be null, in which case the default universe domain will be used.
        /// </summary>
        internal string UniverseDomain { get; set; }

        internal Initializer(string tokenServerUrl, string refreshToken, string clientId, string clientSecret)
            : base(tokenServerUrl.ThrowIfNullOrEmpty(nameof(tokenServerUrl)))
        {
            RefreshToken = refreshToken.ThrowIfNullOrEmpty(nameof(refreshToken));
            ClientId = clientId.ThrowIfNullOrEmpty(nameof(clientId));
            ClientSecret = clientSecret.ThrowIfNullOrEmpty(nameof(clientSecret));
        }

        internal Initializer(ExternalAccountAuthorizedUserCredential other)
            : base(other)
        {
            RefreshToken = other.RefreshToken;
            ClientId = other.ClientId;
            ClientSecret = other.ClientSecret;
            Audience = other.Audience;
            TokenInfoUrl = other.TokenInfoUrl;
            UniverseDomain = other.UniverseDomain;
        }
    }

    /// <summary>
    /// The refresh token used to refresh the access token that will be associated with the credential.
    /// Must not be null or empty.
    /// </summary>
    public string RefreshToken { get; private set; }

    /// <summary>
    /// The client ID to use for basic authentication for refresh token requests.
    /// Must not be null or empty.
    /// </summary>
    public string ClientId { get; }

    /// <summary>
    /// The client secret to use for basic authentication for refresh token requests.
    /// Must not be null or empty.
    /// </summary>
    public string ClientSecret { get; }

    /// <summary>
    /// This is the STS audience which contains the resource name for the workforce pool
    /// and the provider identifier in that pool. May be null as this value is kept for
    /// informational purposes only.
    /// </summary>
    public string Audience { get; }

    /// <summary>
    /// Endpoint to retrieve information related to the user account, like email, username, etc.
    /// May be null as this value is kept for informational purposes only.
    /// </summary>
    public string TokenInfoUrl { get; }

    /// <summary>
    /// The universe domain this credential belogns to.
    /// Won't be null.
    /// </summary>
    public string UniverseDomain { get; }

    internal ExternalAccountAuthorizedUserCredential(Initializer initializer)
        : base(initializer)
    {
        RefreshToken = initializer.RefreshToken;
        ClientId = initializer.ClientId;
        ClientSecret = initializer.ClientSecret;
        Audience = initializer.Audience;
        TokenInfoUrl = initializer.TokenInfoUrl;
        UniverseDomain = initializer.UniverseDomain ?? GoogleAuthConsts.DefaultUniverseDomain;
    }

    bool IGoogleCredential.HasExplicitScopes => false;

    bool IGoogleCredential.SupportsExplicitScopes => false;

    Task<string> IGoogleCredential.GetUniverseDomainAsync(CancellationToken cancellationToken) => Task.FromResult(UniverseDomain);

    string IGoogleCredential.GetUniverseDomain() => UniverseDomain;

    IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
        new ExternalAccountAuthorizedUserCredential(new Initializer(this) { QuotaProject = quotaProject });

    IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) => this;

    IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
        throw new InvalidOperationException($"{nameof(ComputeCredential)} does not support Domain-Wide Delegation");

    IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
        new ExternalAccountAuthorizedUserCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });

    IGoogleCredential IGoogleCredential.WithUniverseDomain(string universeDomain) =>
        new ExternalAccountAuthorizedUserCredential(new Initializer(this) { UniverseDomain = universeDomain });

    /// <inheritodoc/>
    public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
    {
        RefreshTokenRequest request = new RefreshTokenRequest
        {
            RefreshToken = RefreshToken
        };

        var authenticationHeader = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}")));

        Token = await request.PostFormAsync(HttpClient, TokenServerUrl, authenticationHeader, Clock, Logger, taskCancellationToken).ConfigureAwait(false);
        if (!string.IsNullOrEmpty(Token.RefreshToken))
        {
            RefreshToken = Token.RefreshToken;
        }
        return true;
    }
}