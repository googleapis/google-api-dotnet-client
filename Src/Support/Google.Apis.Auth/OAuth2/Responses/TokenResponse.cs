/*
Copyright 2013 Google Inc

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

using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Responses
{
    /// <summary>
    /// OAuth 2.0 model for a successful access token response as specified in 
    /// http://tools.ietf.org/html/rfc6749#section-5.1.
    /// </summary>
    public class TokenResponse
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // Internal for testing.
        // Refresh token 3 minutes and 45 seconds before it expires.
        internal const int TokenRefreshWindowSeconds = 60 * 3 + 45;
        // Don't use a token within 1 minute of it actually expiring.
        internal const int TokenInvalidWindowSeconds = 60;

        /// <summary>Gets or sets the access token issued by the authorization server.</summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the token type as specified in http://tools.ietf.org/html/rfc6749#section-7.1.
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>Gets or sets the lifetime in seconds of the access token.</summary>
        [JsonProperty("expires_in")]
        public long? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the refresh token which can be used to obtain a new access token.
        /// For example, the value "3600" denotes that the access token will expire in one hour from the time the 
        /// response was generated.
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the scope of the access token as specified in http://tools.ietf.org/html/rfc6749#section-3.3.
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the id_token, which is a JSON Web Token (JWT) as specified in http://tools.ietf.org/html/draft-ietf-oauth-json-web-token
        /// </summary>
        [JsonProperty("id_token")]
        public string IdToken { get; set; }

        /// <summary>
        /// The date and time that this token was issued, expressed in the system time zone.
        /// This property only exists for backward compatibility; it can cause inappropriate behavior around
        /// time zone transitions (e.g. daylight saving transitions).
        /// </summary>
        [Obsolete("Use IssuedUtc instead")]
        [JsonProperty(Order = 1)] // Serialize this before IssuedUtc, so that IssuedUtc takes priority when deserializing
        public DateTime Issued
        {
            get { return IssuedUtc.ToLocalTime(); }
            set { IssuedUtc = value.ToUniversalTime(); }
        }

        /// <summary>
        /// The date and time that this token was issued, expressed in UTC.
        /// </summary>
        /// <remarks>
        /// This should be set by the CLIENT after the token was received from the server.
        /// </remarks>
        [JsonProperty(Order = 2)]
        public DateTime IssuedUtc { get; set; }

        /// <summary>Access token for impersonated credentials.</summary>
        [JsonProperty("accessToken")]
        private string ImpersonatedAccessToken { set => AccessToken = value; }

        /// <summary>ID token for impersonated credentials.</summary>
        [JsonProperty("token")]
        private string ImpersonatedIdToken { set => IdToken = value; }

        /// <summary>
        /// Access token expiration time for impersonated credentials. It has the RFC3339
        /// format: "yyyy-MM-dd'T'HH:mm:sssssssss'Z'". For example: 2020-05-13T16:00:00.045123456Z.
        /// </summary>
        [JsonProperty("expireTime")]
        private string ImpersonatedAccessTokenExpireTime { get; set; }

        /// <summary>
        /// Returns true if the token represented by this token response should be refreshed.
        /// Note that this may be true for valid tokens, in which case a pre-emptive refresh is adviced
        /// even if the current token may be used while it continues to be valid.
        /// </summary>
        /// <remarks>
        /// See <see cref="MayBeUsed(IClock)"/> for information on when a token is considered valid.
        /// A valid token is considered stale if it's close to expiring, but not so much as to be unusable.
        /// </remarks>
        [JsonIgnore]
        public bool IsStale => ShouldBeRefreshed(SystemClock.Default);

        /// <summary>
        /// The start of the refresh window for this token, if known. Otherwise, null.
        /// </summary>
        /// <remarks>
        /// At the start of token refresh window, the token is still usable, but efforts should
        /// be made to obtain a fresher one.
        /// </remarks>
        [JsonIgnore]
        internal DateTime? RefreshWindowStartUtc => ExpiresInSeconds.HasValue
            ? IssuedUtc.AddSeconds(ExpiresInSeconds.Value - TokenRefreshWindowSeconds)
            : null;

        /// <summary>
        /// The start of the expiry window for this token, if known. Otherwise, null.
        /// </summary>
        /// <remarks>
        /// A token that's within its expiry window, may still be usable, but doing so
        /// may run into clock skew related issues.
        /// </remarks>
        [JsonIgnore]
        internal DateTime? ExpiryWindowStartUtc => ExpiresInSeconds.HasValue
            ? IssuedUtc.AddSeconds(ExpiresInSeconds.Value - TokenInvalidWindowSeconds)
            : null;

        /// <summary>
        /// Returns true if the token is expired or it's going to expire soon.
        /// </summary>
        /// <remarks>If a token response doens't have at least one of <see cref="AccessToken"/>
        /// or <see cref="IdToken"/> set then it's considered expired.
        /// If <see cref="ExpiresInSeconds"/> is null, the token is also considered expired. </remarks>
        [Obsolete("Please use the TokenResponse.IsStale property instead.")]
        public bool IsExpired(IClock clock) => ShouldBeRefreshed(clock);

        /// <summary>
        /// Returns true if the token represented by this token response should be refreshed.
        /// Note that this may be true for valid tokens, in which case a pre-emptive refresh is adviced
        /// even if the current token may be used while it continues to be valid.
        /// </summary>
        /// <remarks>
        /// See <see cref="MayBeUsed(IClock)"/> for information on when a token is considered valid.
        /// A valid token is considered stale if it's close to expiring, but not so much as to be unusable.
        /// </remarks>
        internal bool ShouldBeRefreshed(IClock clock) =>
            !MayBeUsed(clock) || clock.UtcNow >= RefreshWindowStartUtc;

        /// <summary>
        /// Returns true if the token represented by this token response is valid, that is, it may be used
        /// for authentication and authorizations purposes.
        /// </summary>
        /// <remarks>
        /// A token is considered valid if all of the following are true:
        /// <list type="bullet">
        /// <item>At least one of <see cref="AccessToken"/> and <see cref="IdToken"/> is not null.</item>
        /// <item><see cref="ExpiresInSeconds"/> is not null.</item>
        /// <item>The token has not expired and will not expire in the very near future. That is if
        /// <see cref="IssuedUtc"/> plus <see cref="ExpiresInSeconds"/> is in the not so near future.</item>
        /// </list>
        /// </remarks>
        internal bool MayBeUsed(IClock clock) =>
            (AccessToken is not null || IdToken is not null) &&
            ExpiresInSeconds.HasValue &&
            clock.UtcNow < ExpiryWindowStartUtc;

        /// <summary>
        /// Asynchronously parses a <see cref="TokenResponse"/> instance from the specified <see cref="HttpResponseMessage"/>.
        /// </summary>
        /// <param name="response">The http response from which to parse the token.</param>
        /// <param name="clock">The clock used to set the <see cref="Issued"/> value of the token.</param>
        /// <param name="logger">The logger used to output messages incase of error.</param>
        /// <exception cref="TokenResponseException">
        /// The response was not successful or there is an error parsing the response into valid <see cref="TokenResponse"/> instance.
        /// </exception>
        /// <returns>
        /// A task containing the <see cref="TokenResponse"/> parsed form the response message.
        /// </returns>
        public static async Task<TokenResponse> FromHttpResponseAsync(HttpResponseMessage response, IClock clock, ILogger logger)
        {
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var typeName = "";
            try
            {
                if (!response.IsSuccessStatusCode)
                {
                    typeName = nameof(TokenErrorResponse);
                    // For impersonated credential, the error field is not a string so it cannot be parsed
                    // as TokenErrorResponse. Since the content has nothing but a single error field, We
                    // just use the content itself as the error. For example:
                    // "{"error": {"code": 404, "message": "...", "errors": [{"message": "...", ...}], "status": "NOT_FOUND"}}" 
                    var error = response.RequestMessage?.RequestUri?.AbsoluteUri.StartsWith(GoogleAuthConsts.IamServiceHostPrefix, StringComparison.Ordinal) == true ?
                        new TokenErrorResponse { Error = content } :
                        NewtonsoftJsonSerializer.Instance.Deserialize<TokenErrorResponse>(content);
                    throw new TokenResponseException(error, response.StatusCode);
                }

                TokenResponse newToken;
                // GCE's metadata server identity endpoint doesn't return a TokenResponse but the raw
                // id_token, so we build a TokenResponse from that.
                if (response.RequestMessage?.RequestUri?.AbsoluteUri.StartsWith(GoogleAuthConsts.EffectiveComputeOidcTokenUrl, StringComparison.Ordinal) == true)
                {
                    newToken = new TokenResponse
                    {
                        IdToken = content
                    };
                }
                else
                {
                    typeName = nameof(TokenResponse);
                    newToken = NewtonsoftJsonSerializer.Instance.Deserialize<TokenResponse>(content);
                }
                // We make some modifications to the token before returning, to guarantee consistency
                // for our code across endpoint usage.

                // We should set issuance ourselves.
                newToken.IssuedUtc = clock.UtcNow;
                // If no access token was specified, then we're probably receiving
                // and OIDC token for IAP. The IdToken is used for access in that case.
                newToken.AccessToken ??= newToken.IdToken;

                // For impersonated credentials access token we need to convert expire time to seconds.
                // Example of the expire time: "2020-05-13T16:00:00.045123456Z"
                if (!String.IsNullOrEmpty(newToken.ImpersonatedAccessTokenExpireTime))
                {
                    var expiry = DateTimeOffset.Parse(newToken.ImpersonatedAccessTokenExpireTime, CultureInfo.InvariantCulture);
                    var timeBeforeExpiry = expiry - clock.UtcNow;
                    newToken.ExpiresInSeconds = (long) timeBeforeExpiry.TotalSeconds;        
                }

                // If no expiry is specified, maybe the IdToken has it specified.
                // We can try and get it from there.
                if (newToken.ExpiresInSeconds is null && newToken.IdToken != null)
                {
                    // Unpack the IdToken.
                    var idToken = SignedToken<JsonWebSignature.Header, JsonWebSignature.Payload>.FromSignedToken(newToken.IdToken);
                    // If no expiry was specified in the ID token, there's nothing we can do.
                    if (idToken.Payload.ExpirationTimeSeconds.HasValue)
                    {
                        var expiration = UnixEpoch.AddSeconds(idToken.Payload.ExpirationTimeSeconds.Value);
                        newToken.ExpiresInSeconds = (long)(expiration - newToken.IssuedUtc).TotalSeconds;
                    }
                }
                return newToken;
            }
            catch (JsonException ex)
            {
                logger.Error(ex, $"Exception was caught when deserializing {typeName}. Content is: {content}");
                throw new TokenResponseException(new TokenErrorResponse
                {
                    Error = "Server response does not contain a JSON object. Status code is: " + response.StatusCode
                }, response.StatusCode);
            }
        }
    }
}
