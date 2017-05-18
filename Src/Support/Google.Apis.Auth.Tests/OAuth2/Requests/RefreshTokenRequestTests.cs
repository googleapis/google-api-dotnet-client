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

using Google.Apis.Auth.OAuth2.Requests;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2.Requests
{
    /// <summary>
    /// Tests for <seealso cref="Google.Apis.Auth.OAuth2.Requests.RefreshTokenRequest"/>.
    /// </summary>
    public class RefreshTokenRequestTests
    {
        [Fact]
        public void TestConstructor()
        {
            var request = new RefreshTokenRequest();
            Assert.Null(request.Scope);
            Assert.Null(request.ClientId);
            Assert.Null(request.ClientSecret);

            Assert.Null(request.RefreshToken);
            Assert.Equal("refresh_token", request.GrantType);
        }
    }
}
