/*
Copyright 2020 Google Inc

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
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.Tests.OAuth2
{
    internal class OidcTokenResponseSuccessMessageHandler : CountableMessageHandler
    {
        // Token with audience https://first_call.test
        // Unusable, it was usable on May 13, 2020 from 2:54pm UTC and for 1 hour.
        internal const string FirstCallToken = 
            "eyJhbGciOiJSUzI1NiIsImtpZCI6ImMxNzcxODE0YmE2YTcwNjkzZmI5NDEyZGEzYzZlOTBjMmJmNWI5Mj"+
            "ciLCJ0eXAiOiJKV1QifQ.eyJhdWQiOiJodHRwczovL2ZpcnN0X2NhbGwudGVzdCIsImF6cCI6ImludGVnc"+
            "mF0aW9uLXRlc3RpbmdAYXRhcmFmYW1hcy1pbnRlZ3JhdGlvbi10ZXN0cy5pYW0uZ3NlcnZpY2VhY2NvdW5"+
            "0LmNvbSIsImVtYWlsIjoiaW50ZWdyYXRpb24tdGVzdGluZ0BhdGFyYWZhbWFzLWludGVncmF0aW9uLXRlc"+
            "3RzLmlhbS5nc2VydmljZWFjY291bnQuY29tIiwiZW1haWxfdmVyaWZpZWQiOnRydWUsImV4cCI6MTU4OTM"+
            "4NTI2MywiaWF0IjoxNTg5MzgxNjYzLCJpc3MiOiJodHRwczovL2FjY291bnRzLmdvb2dsZS5jb20iLCJzd"+
            "WIiOiIxMTE2MTEyMjAyOTc3NjczMTkzODkifQ.mjqOsfsH01rHip0AMWKrrx13Gjx5ryiD9K4a2UrrrXxX"+
            "dT05j7uqCu7fifMmuCmbvUfZAbVIjHl4Cp9eX4oqj5IX3sqCoOCEFDRQ2nz0HZ_yyYf1ZEmERTAekKtDbG"+
            "Ji20gqLyk-KRKnal-Ay0ySb2zhvMzFA7mrNmpDlhhNI_VDgtxoDwNWhye57hy-9cbNqYNCpPKiCgixLmcL"+
            "BkFN-X7KLNNJCogix6zwqWeKdkWhO78Hec0JepGuA-1lJ3XQBvzpjVSvuRjKpagybNXp6YDkfg8ca2jMWB"+
            "F905Ht0ANUAniSq8CyN5QJAxlr0IbmPRCkJM4jzx1aNFjzjSUFTw";

        // Token with audience https://subsequent_calls.test
        // Unusable, it was usable on May 13, 2020 from 2:56pm UTC and for 1 hour.
        internal const string SubsequentCallsToken = 
            "eyJhbGciOiJSUzI1NiIsImtpZCI6ImMxNzcxODE0YmE2YTcwNjkzZmI5NDEyZGEzYzZlOTBjMmJmNWI5Mj"+
            "ciLCJ0eXAiOiJKV1QifQ.eyJhdWQiOiJodHRwczovL3N1YnNlcXVlbnRfY2FsbHMudGVzdCIsImF6cCI6I"+
            "mludGVncmF0aW9uLXRlc3RpbmdAYXRhcmFmYW1hcy1pbnRlZ3JhdGlvbi10ZXN0cy5pYW0uZ3NlcnZpY2V"+
            "hY2NvdW50LmNvbSIsImVtYWlsIjoiaW50ZWdyYXRpb24tdGVzdGluZ0BhdGFyYWZhbWFzLWludGVncmF0a"+
            "W9uLXRlc3RzLmlhbS5nc2VydmljZWFjY291bnQuY29tIiwiZW1haWxfdmVyaWZpZWQiOnRydWUsImV4cCI"+
            "6MTU4OTM4NTM3NSwiaWF0IjoxNTg5MzgxNzc1LCJpc3MiOiJodHRwczovL2FjY291bnRzLmdvb2dsZS5jb"+
            "20iLCJzdWIiOiIxMTE2MTEyMjAyOTc3NjczMTkzODkifQ.Aaumn3oXOe48Or8oN2U8_8_KWdRYaR8p1SzT"+
            "mhvWHc9_4AZSodKmZQMyzttwkNrA17HRXGNygVtSi4ocf8aYjHPJWjjqIDIUNAo9Wf3ha_nyqpqkFKq76i"+
            "OtaMoClLDmBva44m9qUUSIe__evNBSHb8aKrzW1gt2ClYzpquFQKxhL0oiRrPYZ2LSBfLvIZb0j9Lz357a"+
            "VGYfXkGIVuXBrl9FBWYn93Qa0eHEgf1AVFR1vuX6vcGaDcTKbjo41bu_QEEytXDDsCn4ab2tZTnVwLIZht"+
            "Y9HxxNMq_nA1m8GKX_CMEIVZ5WBrSe7N7aTZ8dCqo8nHZlM96sUB8WA5pDcA";

        public HttpRequestMessage LatestRequest { get; private set; }
        public string LatestRequestContent { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            LatestRequest = request;
            // We need this because by the time we are back on test code this stream is closed.
            if (request.Content != null)
            {
                LatestRequestContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            TokenResponse token = new TokenResponse
            {
                IdToken = Calls == 1 ? FirstCallToken : SubsequentCallsToken,
            };
            var serializedToken = NewtonsoftJsonSerializer.Instance.Serialize(token);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(serializedToken),
                RequestMessage = request
            };
            return response;
        }
    }

    internal class OidcComputeSuccessMessageHandler : CountableMessageHandler
    {
        // Token with audience https://first_call.test
        // Unusable, it was usable on May 21, 2020 from 9:15am UTC and for 1 hour.
        internal const string FirstCallToken =
            "eyJhbGciOiJSUzI1NiIsImtpZCI6Ijk2MGE3ZThlODM0MWVkNzUyZjEyYjE4NmZhMT" +
            "I5NzMxZmUwYjA0YzAiLCJ0eXAiOiJKV1QifQ.eyJhdWQiOiJodHRwczovL2ZpcnN0X" +
            "2NhbGwudGVzdCIsImF6cCI6IjExNDkxMTI3MjU1NzUxODc4MDU4MSIsImV4cCI6MTU" +
            "5MDA1NjE0NiwiaWF0IjoxNTkwMDUyNTQ2LCJpc3MiOiJodHRwczovL2FjY291bnRzL" +
            "mdvb2dsZS5jb20iLCJzdWIiOiIxMTQ5MTEyNzI1NTc1MTg3ODA1ODEifQ.USxkyjNQ" +
            "X9PzVZSEJNaiLdmZldvTC7DTJfdhrlIHSK3LV9DLKDCtEw07o1glA5lqELMCq7I6wq" +
            "QAHls8lqDtShDIz7ouYudMV9ABnN-SFmcrG1wiPnDJt4N0oCyXbtMksrujgkyDCsrw" +
            "sCxUV3YdhIEwUYVUnBUnk_Tf6MjzFXJK9UQiOGYFYeN9vFg38HoYpwFq0wHkFXq-Uw" +
            "1gvmi46PfnwV3Ow67ehJQSFJd9cS2_Nh0u2j83h6KBNW1q0UzL_eNiXSlFA8YiXpwV" +
            "Zw1-YHV5Q7nrILJQlB1X0T6pEZkvMmkNBoswFPXCFy444BihLcdrHDhZHiAfIDN7X1sZVA";

        // Token with audience https://subsequent_calls.test
        // Unusable, it was usable on May 21, 2020 from 9:15am UTC and for 1 hour.
        internal const string SubsequentCallsToken =
            "eyJhbGciOiJSUzI1NiIsImtpZCI6Ijk2MGE3ZThlODM0MWVkNzUyZjEyYjE4NmZhMT" +
            "I5NzMxZmUwYjA0YzAiLCJ0eXAiOiJKV1QifQ.eyJhdWQiOiJodHRwczovL3N1YnNlc" +
            "XVlbnRfY2FsbHMudGVzdCIsImF6cCI6IjExNDkxMTI3MjU1NzUxODc4MDU4MSIsImV" +
            "4cCI6MTU5MDA1NjIzNCwiaWF0IjoxNTkwMDUyNjM0LCJpc3MiOiJodHRwczovL2FjY" +
            "291bnRzLmdvb2dsZS5jb20iLCJzdWIiOiIxMTQ5MTEyNzI1NTc1MTg3ODA1ODEifQ." +
            "dRiegvwAyv8O96REghtPA83oDDgWhIcleeG8EmBpxdFu-k7W9pF5J-DERAR7s-VzqJ" +
            "fNoWGX8-7HZJTvZ_ye0wgPPAvrhlFOrO6ySxMLrJPWiGOmiPNh5BKHd6mevMAhHE3Q" +
            "t0r0wNk3oWHPtTx5D9cJhcgw4WflDHt1Ci0OPpZKOlO4SuV9WD_0KhvygMjC04tr1e" +
            "qWHglCxzu5-sq5_nEYYQJjI8GmWyrCZ9ZivyoOVZ8vfAR7TEMgNg6pmkkN-kLKhRJ1" +
            "d16z7juYZm6_FsaUp7Cml7vbHmFW4XiRC0gAm6lUECd-KNYSoQRceeLj3fW0LDnNWljfNZXlOkbghA";

        public HttpRequestMessage LatestRequest { get; private set; }
        public string LatestRequestContent { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            LatestRequest = request;
            // We need this because by the time we are back on test code this stream is closed.
            if (request.Content != null)
            {
                LatestRequestContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            // The way we have for identifying that a response came from the compute metadata server identity endpoint
            // is through the request URI, and that's how we know to not build a TokenResponse, so we need to set that here.
            request.RequestUri = new Uri(GoogleAuthConsts.EffectiveComputeOidcTokenUrl + request.RequestUri.Query);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                // The Compute metadata server identity endpoint only sends the raw id_token in the response.
                Content = new StringContent(Calls == 1 ? FirstCallToken : SubsequentCallsToken),
                RequestMessage = request
            };
            return response;
        }
    }

    /// <summary>
    /// Returns some access token, when we don't care about the token in the following tests,
    /// but we need token fetching to work because that's a prerequisite for being
    /// able to perform authenticated requests.
    /// </summary>
    internal class FetchesTokenMessageHandler : CountableMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request, CancellationToken taskCancellationToken) =>
            Task.FromResult(new HttpResponseMessage()
            {
                Content = new StringContent(
                    NewtonsoftJsonSerializer.Instance.Serialize(new TokenResponse
                    {
                        AccessToken = "a",
                        RefreshToken = "r",
                        ExpiresInSeconds = 100,
                        Scope = "b"
                    }),
                    Encoding.UTF8)
            });
    }

    /// <summary>
    /// Throws an  <see cref="HttpRequestException"/> when attempting to fetch the token.
    /// </summary>
    internal class ResponseExceptionOnFetchingTokenMessageHandler : CountableMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request, CancellationToken cancellationToken) =>
            throw new HttpRequestException("Couldn't reach server.");
    }

    /// <summary>
    /// Message handler that accepts a list of delegates to be used sequentially on incoming requests.
    /// </summary>
    internal class DelegatedMessageHandler : CountableMessageHandler
    {
        private Func<HttpRequestMessage, Task<HttpResponseMessage>>[] _delegates;

        internal DelegatedMessageHandler(params Func<HttpRequestMessage, Task<HttpResponseMessage>>[] delegates) => _delegates = delegates;

        protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request, CancellationToken taskCancellationToken) =>
            // At this point our call has already been counted.
            _delegates[Calls - 1](request);
    }
}
