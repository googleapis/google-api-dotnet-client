/*
Copyright 2026 Google LLC

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
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Http;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using Xunit;

namespace Google.Apis.Tests.Apis.Http;

public class BackOffHandlerTest
{
    private class ConstantBackOff : IBackOff
    {
        private readonly TimeSpan _backoff;

        public ConstantBackOff(TimeSpan backoff)
        {
            _backoff = backoff;
        }

        public TimeSpan GetNextBackOff(int currentRetry) => _backoff;

        public int MaxNumOfRetries => 3;
    }

    [Fact]
    public async Task HandleResponseAsync_HonorRetryAfter_Delta()
    {
        var initializer = new BackOffHandler.Initializer(new ConstantBackOff(TimeSpan.FromSeconds(1)))
        {
            HonorRetryAfter = true,
            MaxTimeSpan = TimeSpan.FromSeconds(30),
            HandleUnsuccessfulResponseFunc = (r) => (int)r.StatusCode == 429 || (int)r.StatusCode == 503
        };

        var handler = new MockBackOffHandler(initializer);
        var response = new HttpResponseMessage((HttpStatusCode)429);
        response.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromSeconds(5));

        var args = new HandleUnsuccessfulResponseArgs
        {
            Request = new HttpRequestMessage(HttpMethod.Get, "https://test.googleapis.com"),
            Response = response,
            CurrentFailedTry = 1,
            TotalTries = 3,
            CancellationToken = CancellationToken.None
        };

        bool handled = await handler.HandleResponseAsync(args);
        Assert.True(handled);
        Assert.Single(handler.Waits);
        Assert.Equal(TimeSpan.FromSeconds(5), handler.Waits[0]);
    }

    [Fact]
    public async Task HandleResponseAsync_HonorRetryAfter_Date()
    {
        var initializer = new BackOffHandler.Initializer(new ConstantBackOff(TimeSpan.FromSeconds(1)))
        {
            HonorRetryAfter = true,
            MaxTimeSpan = TimeSpan.FromSeconds(30),
            HandleUnsuccessfulResponseFunc = (r) => (int)r.StatusCode == 503
        };

        var handler = new MockBackOffHandler(initializer);
        var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        DateTimeOffset futureDate = DateTimeOffset.UtcNow.AddSeconds(4);
        response.Headers.RetryAfter = new RetryConditionHeaderValue(futureDate);

        var args = new HandleUnsuccessfulResponseArgs
        {
            Request = new HttpRequestMessage(HttpMethod.Get, "https://test.googleapis.com"),
            Response = response,
            CurrentFailedTry = 1,
            TotalTries = 3,
            CancellationToken = CancellationToken.None
        };

        bool handled = await handler.HandleResponseAsync(args);
        Assert.True(handled);
        Assert.Single(handler.Waits);
        // The difference should be roughly 4 seconds (allowing for test execution tolerance)
        Assert.InRange(handler.Waits[0].TotalSeconds, 1.0, 6.0);
    }

    [Fact]
    public async Task HandleResponseAsync_HonorRetryAfter_ExceedsMaxTimeSpan_ReturnsFalse()
    {
        var initializer = new BackOffHandler.Initializer(new ConstantBackOff(TimeSpan.FromSeconds(1)))
        {
            HonorRetryAfter = true,
            MaxTimeSpan = TimeSpan.FromSeconds(10),
            HandleUnsuccessfulResponseFunc = (r) => (int)r.StatusCode == 429
        };

        var handler = new MockBackOffHandler(initializer);
        var response = new HttpResponseMessage((HttpStatusCode)429);
        // 60 seconds exceeds MaxTimeSpan of 10 seconds
        response.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromSeconds(60));

        var args = new HandleUnsuccessfulResponseArgs
        {
            Request = new HttpRequestMessage(HttpMethod.Get, "https://test.googleapis.com"),
            Response = response,
            CurrentFailedTry = 1,
            TotalTries = 3,
            CancellationToken = CancellationToken.None
        };

        bool handled = await handler.HandleResponseAsync(args);
        Assert.False(handled);
        Assert.Empty(handler.Waits);
    }

    [Fact]
    public async Task HandleResponseAsync_HonorRetryAfter_Disabled_UsesBackOff()
    {
        var initializer = new BackOffHandler.Initializer(new ConstantBackOff(TimeSpan.FromSeconds(2)))
        {
            HonorRetryAfter = false, // default
            HandleUnsuccessfulResponseFunc = (r) => (int)r.StatusCode == 503
        };

        var handler = new MockBackOffHandler(initializer);
        var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        response.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromSeconds(10));

        var args = new HandleUnsuccessfulResponseArgs
        {
            Request = new HttpRequestMessage(HttpMethod.Get, "https://test.googleapis.com"),
            Response = response,
            CurrentFailedTry = 1,
            TotalTries = 3,
            CancellationToken = CancellationToken.None
        };

        bool handled = await handler.HandleResponseAsync(args);
        Assert.True(handled);
        Assert.Single(handler.Waits);
        Assert.Equal(TimeSpan.FromSeconds(2), handler.Waits[0]);
    }

    [Fact]
    public async Task HandleResponseAsync_HonorRetryAfter_NoHeader_FallsBackToBackOff()
    {
        var initializer = new BackOffHandler.Initializer(new ConstantBackOff(TimeSpan.FromSeconds(3)))
        {
            HonorRetryAfter = true,
            HandleUnsuccessfulResponseFunc = (r) => (int)r.StatusCode == 503
        };

        var handler = new MockBackOffHandler(initializer);
        var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        // No RetryAfter header on response

        var args = new HandleUnsuccessfulResponseArgs
        {
            Request = new HttpRequestMessage(HttpMethod.Get, "https://test.googleapis.com"),
            Response = response,
            CurrentFailedTry = 1,
            TotalTries = 3,
            CancellationToken = CancellationToken.None
        };

        bool handled = await handler.HandleResponseAsync(args);
        Assert.True(handled);
        Assert.Single(handler.Waits);
        Assert.Equal(TimeSpan.FromSeconds(3), handler.Waits[0]);
    }
}
