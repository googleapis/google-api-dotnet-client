/*
Copyright 2019 Google Inc

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
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class AccessTokenWithHeadersTests
    {
        [Fact]
        public void AccessTokenWithHeaders_NullToken()
        {
            // This class is being used in GAX in cases where there are no
            // tokens but there are headers.
            var token = new AccessTokenWithHeaders.Builder().Build(null);

            Assert.Null(token.AccessToken);
            Assert.Empty(token.Headers);
        }

        [Fact]
        public void AccessTokenWithHeaders_NoQuotaProject()
        {
            var token = new AccessTokenWithHeaders.Builder().Build("FAKE_TOKEN");

            Assert.Equal("FAKE_TOKEN", token.AccessToken);
            Assert.Empty(token.Headers);
        }

        [Fact]
        public void AccessTokenWithHeaders_WithQuotaProject()
        {
            var token = new AccessTokenWithHeaders.Builder { QuotaProject = "FAKE_QUOTA_PROJECT" }.Build("FAKE_TOKEN");

            Assert.Equal("FAKE_TOKEN", token.AccessToken);
            Assert.Single(token.Headers);
            Assert.Contains("x-goog-user-project", token.Headers.Keys);

            var values = token.Headers["x-goog-user-project"];
            Assert.Single(values);
            Assert.Contains("FAKE_QUOTA_PROJECT", values);
        }

        [Fact]
        public void AddHeaders_SucceedsOnRetry()
        {
            var token = new AccessTokenWithHeaders.Builder { QuotaProject = "RETRY_QUOTA_PROJECT" }.Build("FAKE_TOKEN");
            var request = new System.Net.Http.HttpRequestMessage();

            // First call (first try)
            token.AddHeaders(request);

            // Second call (retry) - should not throw and should not duplicate the header
            token.AddHeaders(request);

            var values = request.Headers.GetValues("x-goog-user-project");
            Assert.Single(values);
            Assert.Contains("RETRY_QUOTA_PROJECT", values);
        }

        [Fact]
        public void AddHeaders_ConflictThrows()
        {
            var token = new AccessTokenWithHeaders.Builder { QuotaProject = "NEW_QUOTA_PROJECT" }.Build("FAKE_TOKEN");
            var request = new System.Net.Http.HttpRequestMessage();
            request.Headers.Add("x-goog-user-project", "OLD_QUOTA_PROJECT");

            Assert.Throws<System.InvalidOperationException>(() => token.AddHeaders(request));
        }

        [Fact]
        public void AddHeaders_MatchingSucceeds()
        {
            var token = new AccessTokenWithHeaders.Builder { QuotaProject = "SAME_QUOTA_PROJECT" }.Build("FAKE_TOKEN");
            var request = new System.Net.Http.HttpRequestMessage();
            request.Headers.Add("x-goog-user-project", "SAME_QUOTA_PROJECT");

            // Should not throw
            token.AddHeaders(request);

            var values = request.Headers.GetValues("x-goog-user-project");
            Assert.Single(values);
            Assert.Contains("SAME_QUOTA_PROJECT", values);
        }

        [Fact]
        public void AddHeaders_MultipleExistingValuesThrows()
        {
            var token = new AccessTokenWithHeaders.Builder { QuotaProject = "NEW_PROJECT" }.Build("TOKEN");
            var request = new System.Net.Http.HttpRequestMessage();
            request.Headers.Add("x-goog-user-project", "VAL1");
            request.Headers.Add("x-goog-user-project", "VAL2");

            Assert.Throws<System.InvalidOperationException>(() => token.AddHeaders(request));
        }

        [Fact]
        public void AddHeaders_MultipleIncomingValuesThrows()
        {
            var headers = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IReadOnlyList<string>>
            {
                { "x-goog-user-project", new System.Collections.Generic.List<string> { "VAL1", "VAL2" }.AsReadOnly() }
            };
            var token = new AccessTokenWithHeaders("TOKEN", new System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<string>>(headers));
            var request = new System.Net.Http.HttpRequestMessage();
            request.Headers.Add("x-goog-user-project", "VAL1");

            Assert.Throws<System.InvalidOperationException>(() => token.AddHeaders(request));
        }
    }
}
