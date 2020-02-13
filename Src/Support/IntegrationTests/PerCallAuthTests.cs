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

using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using IntegrationTests.Utils;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Auth.OAuth2.GoogleCredential;

namespace IntegrationTests
{
    public class PerCallAuthTests
    {
        [Fact]
        public void ServiceAccountPerCallCredential()
        {
            // No auth in the client.
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                ApplicationName = "IntegrationTest"
            });
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl);
            // Create a request with a per-call credential.
            Buckets buckets = client.Buckets.List(Helper.GetProjectId()).AddCredential(credential).Execute();
            // Check the response is sane.
            Assert.NotNull(buckets.Items);
        }

        [Fact]
        public void OverridesServiceCredentialWithPerCallCredential_Header()
        {
            // Broken credential in the client.
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                ApplicationName = "IntegrationTest",
                HttpClientInitializer = GoogleCredential.FromAccessToken("BROKEN_ACCESS_TOKEN")
            });
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl);
            // Create a request with a per-call credential.; this overrides the service-level credential.
            Buckets buckets = client.Buckets.List(Helper.GetProjectId()).AddCredential(credential).Execute();
            // Check the response is sane.
            Assert.NotNull(buckets.Items);
        }

        private class RequestInterceptorCredentialWrapper : IConfigurableHttpClientInitializer, IHttpExecuteInterceptor
        {
            private AccessTokenCredential _credential;
            public HttpRequestMessage Request { get; private set; }

            public RequestInterceptorCredentialWrapper(string accessToken, IAccessMethod accessMethod) =>
                _credential = new AccessTokenCredential(accessToken, accessMethod);

            public void Initialize(ConfigurableHttpClient httpClient)
            {
                _credential.Initialize(httpClient);
                httpClient.MessageHandler.AddExecuteInterceptor(this);
            }

            public Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Request = request;
                return Task.FromResult(true);
            }
        }

        [Fact]
        public void OverridesServiceCredentialWithPerCallCredential_QueryString()
        {
            var serviceCredential = new RequestInterceptorCredentialWrapper("SERVICE_CREDENTIAL_TOKEN", new BearerToken.QueryParameterAccessMethod());
            var callCredential = new AccessTokenCredential("CALL_CREDENTIAL_TOKEN", new BearerToken.QueryParameterAccessMethod());

            // Set one credential in the client
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                ApplicationName = "IntegrationTest",
                HttpClientInitializer = serviceCredential
            }); ;

            // Create a request with a per-call credential.; this overrides the service-level credential.
            var request = client.Buckets.List(Helper.GetProjectId()).AddCredential(callCredential);

            // This should throw unauthorized, the credentials are fake, but let's make sure the
            // request got to the server so we know all appropiate interceptors executed.
            var exception = Assert.ThrowsAny<GoogleApiException>(() => request.Execute());
            Assert.Equal(401, exception.Error.Code);

            string query = serviceCredential.Request.RequestUri.Query;

            int serviceIndex = query.IndexOf("access_token=SERVICE_CREDENTIAL_TOKEN", StringComparison.OrdinalIgnoreCase);
            int callIndex = query.LastIndexOf("access_token=CALL_CREDENTIAL_TOKEN", StringComparison.OrdinalIgnoreCase);

            Assert.Equal(-1, serviceIndex);
            Assert.NotEqual(-1, callIndex);
        }

        [Fact]
        public void OverridesServiceCredentialWithPerCallCredential_Mixed_Header_Query()
        {
            var serviceCredential = new RequestInterceptorCredentialWrapper("SERVICE_CREDENTIAL_TOKEN", new BearerToken.AuthorizationHeaderAccessMethod());
            var callCredential = new AccessTokenCredential("CALL_CREDENTIAL_TOKEN", new BearerToken.QueryParameterAccessMethod());

            // Set one credential in the client
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                ApplicationName = "IntegrationTest",
                HttpClientInitializer = serviceCredential
            }); ;

            // Create a request with a per-call credential.; this overrides the service-level credential.
            var request = client.Buckets.List(Helper.GetProjectId()).AddCredential(callCredential);

            // This should throw unauthorized, the credentials are fake, but let's make sure the
            // request got to the server so we know all appropiate interceptors executed.
            var exception = Assert.ThrowsAny<GoogleApiException>(() => request.Execute());
            Assert.Equal(401, exception.Error.Code);

            HttpRequestMessage httpRequest = serviceCredential.Request;
            string query = httpRequest.RequestUri.Query;

            int callIndex = query.LastIndexOf("access_token=CALL_CREDENTIAL_TOKEN", StringComparison.OrdinalIgnoreCase);

            Assert.Null(httpRequest.Headers.Authorization);
            Assert.NotEqual(-1, callIndex);
        }

        [Fact]
        public void OverridesServiceCredentialWithPerCallCredential_Mixed_Query_Header()
        {
            var serviceCredential = new RequestInterceptorCredentialWrapper("SERVICE_CREDENTIAL_TOKEN", new BearerToken.QueryParameterAccessMethod());
            var callCredential = new AccessTokenCredential("CALL_CREDENTIAL_TOKEN", new BearerToken.AuthorizationHeaderAccessMethod());

            // Set one credential in the client
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                ApplicationName = "IntegrationTest",
                HttpClientInitializer = serviceCredential
            }); ;

            // Create a request with a per-call credential.; this overrides the service-level credential.
            var request = client.Buckets.List(Helper.GetProjectId()).AddCredential(callCredential);

            // This should throw unauthorized, the credentials are fake, but let's make sure the
            // request got to the server so we know all appropiate interceptors executed.
            var exception = Assert.ThrowsAny<GoogleApiException>(() => request.Execute());
            Assert.Equal(401, exception.Error.Code);

            HttpRequestMessage httpRequest = serviceCredential.Request;
            string query = httpRequest.RequestUri.Query;

            int serviceIndex = query.LastIndexOf("access_token=SERVICE_CREDENTIAL_TOKEN", StringComparison.OrdinalIgnoreCase);

            Assert.Equal(-1, serviceIndex);
            Assert.Equal("CALL_CREDENTIAL_TOKEN", httpRequest.Headers.Authorization.Parameter);
        }

        [Fact]
        public void OverridesServiceCredentialWithPerCallCredential_TwoCallCredentials()
        {
            var serviceCredential = new RequestInterceptorCredentialWrapper("SERVICE_CREDENTIAL_TOKEN", new BearerToken.QueryParameterAccessMethod());
            var callCredential1 = new AccessTokenCredential("CALL_CREDENTIAL_TOKEN_1", new BearerToken.QueryParameterAccessMethod());
            var callCredential2 = new AccessTokenCredential("CALL_CREDENTIAL_TOKEN_2", new BearerToken.QueryParameterAccessMethod());

            // Set one credential in the client
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                ApplicationName = "IntegrationTest",
                HttpClientInitializer = serviceCredential
            }); ;

            // Create a request with a per-call credential.; this overrides the service-level credential.
            var request = client.Buckets.List(Helper.GetProjectId()).AddCredential(callCredential1);
            request.AddCredential(callCredential2);

            // This should throw unauthorized, the credentials are fake, but let's make sure the
            // request got to the server so we know all appropiate interceptors executed.
            var exception = Assert.ThrowsAny<GoogleApiException>(() => request.Execute());
            Assert.Equal(401, exception.Error.Code);

            string query = serviceCredential.Request.RequestUri.Query;

            int serviceIndex = query.IndexOf("access_token=SERVICE_CREDENTIAL_TOKEN", StringComparison.OrdinalIgnoreCase);
            int call1Index = query.LastIndexOf("access_token=CALL_CREDENTIAL_TOKEN_1", StringComparison.OrdinalIgnoreCase);
            int call2Index = query.LastIndexOf("access_token=CALL_CREDENTIAL_TOKEN_2", StringComparison.OrdinalIgnoreCase);

            Assert.Equal(-1, serviceIndex);
            Assert.Equal(-1, call1Index);
            Assert.NotEqual(-1, call2Index);
        }

        [Fact]
        public void NullParameters()
        {
            StorageService client = new StorageService();
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl);
            Assert.Throws<ArgumentNullException>(() => ((ClientServiceRequest)null).AddCredential(credential));
            var request = client.Buckets.List(Helper.GetProjectId());
            Assert.Throws<ArgumentNullException>(() => request.AddCredential(null));
        }

        private class CredentialNoInterceptors : ICredential
        {
            public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
                throw new NotImplementedException();
            public void Initialize(ConfigurableHttpClient httpClient) => throw new NotImplementedException();
        }

        [Fact]
        public void InvalidCredential()
        {
            StorageService client = new StorageService();
            var credential = new CredentialNoInterceptors();
            var request = client.Buckets.List(Helper.GetProjectId());
            // Provided credential doesn't implement the required execute interceptor.
            Assert.Throws<ArgumentException>(() => request.AddCredential(credential));
        }
    }
}
