/*
Copyright 2013 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.BearerToken"/>.</summary>
    public class BearerTokenTests
    {
        [Fact]
        public void AuthorizationHeaderAccessMethod_Intercept()
        {
            var request = new HttpRequestMessage();
            new BearerToken.AuthorizationHeaderAccessMethod().Intercept(request, "abc");
            Assert.Equal("Bearer abc", request.Headers.Authorization.ToString());
        }

        [Fact]
        public void AuthorizationHeaderAccessMethod_InterceptOverride()
        {
            var request = new HttpRequestMessage();
            request.Headers.Authorization = new AuthenticationHeaderValue("a", "1");
            new BearerToken.AuthorizationHeaderAccessMethod().Intercept(request, "abc");
            Assert.Equal("Bearer abc", request.Headers.Authorization.ToString());
        }

        [Fact]
        public void AuthorizationHeaderAccessMethod_GetAccessToken()
        {
            var request = new HttpRequestMessage();
            request.Headers.Authorization = new AuthenticationHeaderValue("a", "1");
            var accessToken = new BearerToken.AuthorizationHeaderAccessMethod().GetAccessToken(request);
            Assert.Null(accessToken);

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "abc");
            accessToken = new BearerToken.AuthorizationHeaderAccessMethod().GetAccessToken(request);
            Assert.Equal("abc", accessToken);
        }

        [Fact]
        public void QueryParameterAccessMethod_Intercept()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://sample.com/path"));
            new BearerToken.QueryParameterAccessMethod().Intercept(request, "abc");
            Assert.Equal(new Uri("https://sample.com/path?access_token=abc"), request.RequestUri);
        }

        [Fact]
        public void QueryParameterAccessMethod_Intercept_WithQueryParameters()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://sample.com/path?a=1"));
            new BearerToken.QueryParameterAccessMethod().Intercept(request, "abc");
            Assert.Equal(new Uri("https://sample.com/path?a=1&access_token=abc"), request.RequestUri);
        }

        [Fact]
        public void QueryParameterAccessMethod_GetAccessToken()
        {
            // No query parameter at all.
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://sample.com"));
            var accessToken = new BearerToken.QueryParameterAccessMethod().GetAccessToken(request);
            Assert.Null(accessToken);

            // Different query parameter.
            request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://sample.com?a=1"));
            accessToken = new BearerToken.QueryParameterAccessMethod().GetAccessToken(request);
            Assert.Null(accessToken);

            // One query parameter and it's access_token.
            request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://sample.com?a=1&access_token=abc"));
            accessToken = new BearerToken.QueryParameterAccessMethod().GetAccessToken(request);
            Assert.Equal("abc", accessToken);

            // 2 query parameters and one of them is access_token.
            request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://sample.com?access_token=abc"));
            accessToken = new BearerToken.QueryParameterAccessMethod().GetAccessToken(request);
            Assert.Equal("abc", accessToken);
        }

    }
}
