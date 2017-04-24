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

using Google.Apis.Auth.OAuth2.Responses;
using System.Collections.Generic;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2.Responses
{
    /// <summary>
    /// Tests for <seealso cref="Google.Apis.Auth.OAuth2.Responses.AuthorizationCodeResponseUrl"/>.
    /// </summary>
    public class AuthorizationCodeResponseUrlTests
    {
        [Fact]
        public void TestConstructor_Default()
        {
            var response = new AuthorizationCodeResponseUrl();
            Assert.Null(response.Code);
            Assert.Null(response.Error);
            Assert.Null(response.ErrorUri);
            Assert.Null(response.ErrorDescription);
            Assert.Null(response.State);
        }

        [Fact]
        public void TestConstructor_Dictionary()
        {
            var dic = new Dictionary<string, string>();
            dic["code"] = "123";
            dic["error"] = "ERR";
            dic["error_uri"] = "URI";
            dic["error_description"] = "DESC";
            dic["state"] = "STATE";

            // Some other parameter, which is not part of the response.
            dic["another_one"] = "BLAH BLAH BLAH";

            var response = new AuthorizationCodeResponseUrl(dic);
            SubtestConstructor(response);
        }

        [Fact]
        public void TestConstructor_Query()
        {
            string query = "code=123&error=ERR&error_uri=URI&error_description=DESC&state=STATE&other_ine=2222222222";
            var response = new AuthorizationCodeResponseUrl(query);
            SubtestConstructor(response);
        }

        private void SubtestConstructor(AuthorizationCodeResponseUrl response)
        {
            Assert.Equal("123", response.Code);
            Assert.Equal("ERR", response.Error);
            Assert.Equal("URI", response.ErrorUri);
            Assert.Equal("DESC", response.ErrorDescription);
            Assert.Equal("STATE", response.State);
        }
    }
}
