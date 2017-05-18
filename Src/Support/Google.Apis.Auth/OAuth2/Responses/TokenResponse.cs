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

using System;

using Google.Apis.Util;
using System.Threading.Tasks;
using System.Net.Http;
using Google.Apis.Json;
using Google.Apis.Logging;

namespace Google.Apis.Auth.OAuth2.Responses
{
    /// <summary>
    /// OAuth 2.0 model for a successful access token response as specified in 
    /// http://tools.ietf.org/html/rfc6749#section-5.1.
    /// </summary>
    public class TokenResponse
    {
        private const int TokenExpiryTimeWindowSeconds = 60 * 5; // Refresh token 5 minutes before it expires.

        /// <summary>Gets or sets the access token issued by the authorization server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the token type as specified in http://tools.ietf.org/html/rfc6749#section-7.1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token_type")]
        public string TokenType { get; set; }

        /// <summary>Gets or sets the lifetime in seconds of the access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expires_in")]
        public Nullable<long> ExpiresInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the refresh token which can be used to obtain a new access token.
        /// For example, the value "3600" denotes that the access token will expire in one hour from the time the 
        /// response was generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the scope of the access token as specified in http://tools.ietf.org/html/rfc6749#section-3.3.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the id_token, which is a JSON Web Token (JWT) as specified in http://tools.ietf.org/html/draft-ietf-oauth-json-web-token
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id_token")]
        public string IdToken { get; set; }

        /// <summary>
        /// The date and time that this token was issued, expressed in the system time zone.
        /// This property only exists for backward compatibility; it can cause inappropriate behavior around
        /// time zone transitions (e.g. daylight saving transitions).
        /// </summary>
        [Obsolete("Use IssuedUtc instead")]
        [Newtonsoft.Json.JsonPropertyAttribute(Order = 1)] // Serialize this before IssuedUtc, so that IssuedUtc takes priority when deserializing
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
        [Newtonsoft.Json.JsonPropertyAttribute(Order = 2)]
        public DateTime IssuedUtc { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the token is expired or it's going to be expired in the next minute.
        /// </summary>
        public bool IsExpired(IClock clock)
        {
            if (AccessToken == null || !ExpiresInSeconds.HasValue)
            {
                return true;
            }

            return IssuedUtc.AddSeconds(ExpiresInSeconds.Value - TokenExpiryTimeWindowSeconds) <= clock.UtcNow;
        }

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
        public static async Task<TokenResponse> FromHttpResponseAsync(HttpResponseMessage response, Util.IClock clock, ILogger logger)
        {
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var typeName = "";
            try
            {
                if (!response.IsSuccessStatusCode)
                {
                    typeName = nameof(TokenErrorResponse);
                    var error = NewtonsoftJsonSerializer.Instance.Deserialize<TokenErrorResponse>(content);
                    throw new TokenResponseException(error, response.StatusCode);
                }

                // Gets the token and sets its issued time.
                typeName = nameof(TokenResponse);
                var newToken = NewtonsoftJsonSerializer.Instance.Deserialize<TokenResponse>(content);
                newToken.IssuedUtc = clock.UtcNow;
                return newToken;
            }
            catch (Newtonsoft.Json.JsonException ex)
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
