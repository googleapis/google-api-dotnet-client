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
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2.Flows
{
    public class PkceGoogleAuthorizationCodeFlowTests
    {
        [Fact]
        public void CreateAuthorizationCodeRequest()
        {
            string redirectUrl = "Redirect URL";
            string loginHint = "user@dom.ain";
            string prompt = "select_account";
            string nonce = "nonce";
            var userDefinedParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string,string>("customParam1","customVal1"),
                new KeyValuePair<string,string>("customParam2","customVal2")
            };

            var initializer = new GoogleAuthorizationCodeFlow.Initializer()
            {
                IncludeGrantedScopes = true,
                LoginHint = loginHint,
                Prompt = prompt,
                Nonce = nonce,
                UserDefinedQueryParams = userDefinedParams,
                ClientSecrets = new ClientSecrets()
            };

            var flow = new PkceGoogleAuthorizationCodeFlow(initializer);
            var request = flow.CreateAuthorizationCodeRequest(redirectUrl, out string codeVerifier);

            var googleRequest = Assert.IsType<GoogleAuthorizationCodeRequestUrl>(request);

            Assert.Equal(redirectUrl, googleRequest.RedirectUri);
            Assert.Equal("offline", googleRequest.AccessType);
            Assert.Equal("true", googleRequest.IncludeGrantedScopes);
            Assert.Equal(loginHint, googleRequest.LoginHint);
            Assert.Equal(prompt, googleRequest.Prompt);
            Assert.Equal(nonce, googleRequest.Nonce);
            Assert.Equal(userDefinedParams, googleRequest.UserDefinedQueryParams);

            Assert.Equal(128, codeVerifier.Length);
            Assert.DoesNotContain("=", codeVerifier);
            Assert.DoesNotContain("+", codeVerifier);
            Assert.DoesNotContain("/", codeVerifier);

            // This is unfortunate, but it's not easy to simulate an environment that does not support Sha256.
            // This is mostly for documentation purposes.
            if (googleRequest.CodeChallengeMethod == "plain")
            {
                Assert.Equal(codeVerifier, googleRequest.CodeChallenge);
            }
            else if (googleRequest.CodeChallengeMethod == "S256")
            {
                byte[] codeVerifierAsciiBytes = Encoding.ASCII.GetBytes(codeVerifier);
                using var sha256 = SHA256.Create();
                byte[] hashedCodeVerifier = sha256.ComputeHash(codeVerifierAsciiBytes);

                var expectedChallenge = TokenEncodingHelpers.UrlSafeBase64Encode(hashedCodeVerifier);
                Assert.Equal(expectedChallenge, googleRequest.CodeChallenge);
            }
            else
            {
                Assert.Fail($"Unknown {nameof(googleRequest.CodeChallengeMethod)}={googleRequest.CodeChallengeMethod}");
            }
        }
    }
}
