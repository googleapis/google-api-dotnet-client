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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>
    /// Google authorization flow implementation that supports PKCE as described in https://www.rfc-editor.org/rfc/rfc7636
    /// and https://developers.google.com/identity/protocols/oauth2/native-app.
    /// </summary>
    public class PkceGoogleAuthorizationCodeFlow : GoogleAuthorizationCodeFlow, IPkceAuthorizationCodeFlow
    {
        private const int CodeVerifierMaxLengthChars = 128;
        // We generate the random bytes and then encode them to Base64 whose characters are 6 bits long.
        private const int CodeVerifierRandomNumberLengthBytes = CodeVerifierMaxLengthChars * 6 / 8;
        private const string ChallengeMethodSha256 = "S256";
        private const string ChallengeMethodPlain = "plain";

        /// <summary>
        /// Creates a new instance from the given initializer.
        /// </summary>
        public PkceGoogleAuthorizationCodeFlow(Initializer initializer) : base(initializer)
        {
        }

        /// <inheritdoc/>
        public AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri, out string codeVerifier)
        {
            var request = CreateAuthorizationCodeRequest(redirectUri) as GoogleAuthorizationCodeRequestUrl;
            codeVerifier = GenerateCodeVerifier();
            AddCodeChallenge(request, codeVerifier);
            return request;
        }

        /// <inheritdoc/>
        public async Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, string code, string codeVerifier, string redirectUri, CancellationToken taskCancellationToken)
        {
            var request = CreateAuthorizationCodeTokenRequest(userId, code, redirectUri);
            request.CodeVerifier = codeVerifier;

            return await ExchangeCodeForTokenAsync(userId, request, taskCancellationToken).ConfigureAwait(false);
        }

        private static string GenerateCodeVerifier()
        {
            byte[] data = new byte[CodeVerifierRandomNumberLengthBytes];
            using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(data);

            // The code verifier should be Base64-URL encoded.
            // https://developers.google.com/identity/protocols/oauth2/native-app#step1-code-verifier
            return TokenEncodingHelpers.UrlSafeBase64Encode(data);
        }

        private static void AddCodeChallenge(GoogleAuthorizationCodeRequestUrl request, string codeVerifier)
        {
            // https://developers.google.com/identity/protocols/oauth2/native-app#step1-code-verifier
            string effectiveChallenge;
            string effectiveChallengeMethod;
            try
            {
                byte[] codeVerifierAsciiBytes = Encoding.ASCII.GetBytes(codeVerifier);
                using var sha256 = SHA256.Create();
                byte[] hashedCodeVerifier = sha256.ComputeHash(codeVerifierAsciiBytes);

                effectiveChallenge = TokenEncodingHelpers.UrlSafeBase64Encode(hashedCodeVerifier);
                effectiveChallengeMethod = ChallengeMethodSha256;
            }
            // Under certain conditions SHA256 is not supported for .NET Framework 4.6.1 or earlier.
            // See https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256.create
            catch (TargetInvocationException)
            {
                effectiveChallenge = codeVerifier;
                effectiveChallengeMethod = ChallengeMethodPlain;
            }

            request.CodeChallenge = effectiveChallenge;
            request.CodeChallengeMethod = effectiveChallengeMethod;
        }
    }
}
