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
        public void AccessTokenWithHeaders_NoQuotaProject()
        {
            var token = new AccessTokenWithHeaders("FAKE_TOKEN");

            Assert.Equal("FAKE_TOKEN", token.AccessToken);
            Assert.Empty(token.Headers);
        }

        [Fact]
        public void AccessTokenWithHeaders_WithQuotaProject()
        {
            var token = new AccessTokenWithHeaders("FAKE_TOKEN", "FAKE_QUOTA_PROJECT");

            Assert.Equal("FAKE_TOKEN", token.AccessToken);
            Assert.Single(token.Headers);
            Assert.Contains("x-goog-user-project", token.Headers.Keys);

            var values = token.Headers["x-goog-user-project"];
            Assert.Single(values);
            Assert.Contains("FAKE_QUOTA_PROJECT", values);
        }
    }
}
