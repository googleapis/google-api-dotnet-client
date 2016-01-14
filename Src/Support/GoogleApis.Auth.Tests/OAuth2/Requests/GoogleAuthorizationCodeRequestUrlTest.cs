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

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// Tests for <seealso cref="Google.Apis.Auth.OAuth2.Requests.GoogleAuthorizationCodeRequestUrl"/>.
    /// </summary>
    [TestFixture]
    public class GoogleAuthorizationCodeRequestUrlTest
    {
        private readonly Uri AuthorizationCodeUrl = new Uri("http://www.authorization-server.com");

        [Test]
        public void TestConstructor()
        {
            var request = new GoogleAuthorizationCodeRequestUrl(AuthorizationCodeUrl);
            Assert.That(request.AuthorizationServerUrl, Is.EqualTo(AuthorizationCodeUrl));
            Assert.Null(request.ClientId);
            Assert.Null(request.RedirectUri);
            Assert.That(request.ResponseType, Is.EqualTo("code"));
            Assert.Null(request.Scope);
            Assert.Null(request.State);
            Assert.That(request.AccessType, Is.EqualTo("offline"));
            Assert.Null(request.ApprovalPrompt);
            Assert.Null(request.LoginHint);
        }
    }
}
