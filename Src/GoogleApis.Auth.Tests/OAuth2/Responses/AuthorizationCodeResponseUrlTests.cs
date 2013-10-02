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
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace Google.Apis.Auth.OAuth2.Responses
{
    /// <summary>
    /// Tests for <seealso cref="Google.Apis.Auth.OAuth2.Responses.AuthorizationCodeResponseUrl"/>.
    /// </summary>
    [TestFixture]
    public class AuthorizationCodeResponseUrlTests
    {
        [Test]
        public void TestConstructor_Default()
        {
            var response = new AuthorizationCodeResponseUrl();
            Assert.Null(response.Code);
            Assert.Null(response.Error);
            Assert.Null(response.ErrorUri);
            Assert.Null(response.ErrorDescription);
            Assert.Null(response.State);
        }

        [Test]
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

        [Test]
        public void TestConstructor_Query()
        {
            string query = "code=123&error=ERR&error_uri=URI&error_description=DESC&state=STATE&other_ine=2222222222";
            var response = new AuthorizationCodeResponseUrl(query);
            SubtestConstructor(response);
        }

        private void SubtestConstructor(AuthorizationCodeResponseUrl response)
        {
            Assert.That(response.Code, Is.EqualTo("123"));
            Assert.That(response.Error, Is.EqualTo("ERR"));
            Assert.That(response.ErrorUri, Is.EqualTo("URI"));
            Assert.That(response.ErrorDescription, Is.EqualTo("DESC"));
            Assert.That(response.State, Is.EqualTo("STATE"));
        }
    }
}
