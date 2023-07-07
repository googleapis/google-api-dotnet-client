// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Http;
using Google.Apis.Storage.v1;
using IntegrationTests.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests;

public class HttpClientWithExecuteInterceptorTests
{
    [Fact]
    public async Task NoAuthentication_Fails()
    {
        using var client = new HttpClient();
        var request = CreateListBucketsRequest();
        var response = await client.SendAsync(request);
        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
    }

    [Fact]
    public async Task InterceptWithCredentials()
    {
        var credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl);
        var handler = credential.ToDelegatingHandler(new HttpClientHandler());
        using var client = new HttpClient(handler);
        var request = CreateListBucketsRequest();
        var response = await client.SendAsync(request);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        // Validate that this does look like a listing for buckets...
        var json = await response.Content.ReadAsStringAsync();
        var obj = JObject.Parse(json);
        var kind = (string) obj["kind"];
        Assert.Equal("storage#buckets", kind);
    }

    private static HttpRequestMessage CreateListBucketsRequest()
    {
        var uri = new StorageService().Buckets.List(Helper.GetProjectId()).CreateRequest().RequestUri;

        return new HttpRequestMessage
        {
            RequestUri = uri,
            Method = HttpMethod.Get
        };
    }
}
