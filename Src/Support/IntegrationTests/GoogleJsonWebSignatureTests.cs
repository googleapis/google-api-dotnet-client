/*
Copyright 2017 Google Inc

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

using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using IntegrationTests.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class GoogleJsonWebSignatureTests
    {
        [Fact]
        public async Task GetGoogleCerts()
        {
            // Verifies certs are downloaded and loaded into RSAs
            var certs = await GoogleJsonWebSignature.GetGoogleCertsAsync(SystemClock.Default, false, null);
            Assert.NotEmpty(certs);
        }

        [Fact]
        public async Task GetAndValidateJwt()
        {
            // Warning: This test is interactive!
            // It will bring up a browser window that must be responded to before the test can complete.

            // Do auth.
            var codeReceiver = new LocalServerCodeReceiver();
            var initializer = new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecretsStream = Helper.GetClientSecretStream(),
                Scopes = new string[] { "openid email" },
            };
            var flow = new GoogleAuthorizationCodeFlow(initializer);
            var redirectUri = codeReceiver.RedirectUri;
            AuthorizationCodeRequestUrl codeRequest = flow.CreateAuthorizationCodeRequest(redirectUri);

            // Receive the code.
            var response = await codeReceiver.ReceiveCodeAsync(codeRequest, CancellationToken.None);
            var code = response.Code;

            // Get a JWT from code.
            var secretJson = JToken.Parse(Helper.GetClientSecret());
            var codeReq = "https://www.googleapis.com/oauth2/v4/token";
            var contentStr = "code=" + code +
                "&client_id=" + secretJson["installed"]["client_id"] +
                "&client_secret=" + secretJson["installed"]["client_secret"] +
                "&redirect_uri=" + redirectUri +
                "&grant_type=authorization_code";
            var contentBytes = Encoding.ASCII.GetBytes(contentStr);
            var content = new ByteArrayContent(contentBytes);
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");
            var httpClient = new HttpClient();
            var res = httpClient.PostAsync(codeReq, content).Result;
            var json = JToken.Parse(Encoding.UTF8.GetString(await res.Content.ReadAsByteArrayAsync()));
            var jwt = (string)json["id_token"];

            // Confirm JWT is valid
            var validPayload = await GoogleJsonWebSignature.ValidateAsync(jwt);
            Assert.NotNull(validPayload);
        }
    }
}
