/*
Copyright 2026 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Http;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Xunit;

namespace Google.Apis.Tests.Apis.Http;

public class RetryAfterBackOffTest
{
    [Fact]
    public void Constructor_NullClock_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new RetryAfterBackOff(null));
    }

    [Fact]
    public void GetRetryAfterDelay_NullResponse_ReturnsNull()
    {
        var backOff = new RetryAfterBackOff(SystemClock.Default);
        Assert.Null(backOff.GetRetryAfterDelay(null));
    }

    [Fact]
    public void GetRetryAfterDelay_NoHeader_ReturnsNull()
    {
        var backOff = new RetryAfterBackOff(SystemClock.Default);
        using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        Assert.Null(backOff.GetRetryAfterDelay(response));
    }

    [Fact]
    public void GetRetryAfterDelay_DeltaSeconds_ReturnsDelay()
    {
        var backOff = new RetryAfterBackOff(SystemClock.Default);
        using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        response.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromSeconds(30));

        var delay = backOff.GetRetryAfterDelay(response);
        Assert.Equal(TimeSpan.FromSeconds(30), delay);
    }

    [Fact]
    public void GetRetryAfterDelay_NegativeDelta_ClampsToZero()
    {
        var backOff = new RetryAfterBackOff(SystemClock.Default);
        using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        response.Headers.RetryAfter = new RetryConditionHeaderValue(TimeSpan.FromSeconds(-5));

        var delay = backOff.GetRetryAfterDelay(response);
        Assert.Equal(TimeSpan.Zero, delay);
    }

    [Fact]
    public void GetRetryAfterDelay_AbsoluteDate_ReturnsDelay()
    {
        var clock = new MockClock(new DateTime(2026, 1, 1, 12, 0, 0, DateTimeKind.Utc));
        var backOff = new RetryAfterBackOff(clock);
        using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        response.Headers.RetryAfter = new RetryConditionHeaderValue(new DateTimeOffset(2026, 1, 1, 12, 0, 45, TimeSpan.Zero));

        var delay = backOff.GetRetryAfterDelay(response);
        Assert.Equal(TimeSpan.FromSeconds(45), delay);
    }

    [Fact]
    public void GetRetryAfterDelay_PastDate_ClampsToZero()
    {
        var clock = new MockClock(new DateTime(2026, 1, 1, 12, 0, 0, DateTimeKind.Utc));
        var backOff = new RetryAfterBackOff(clock);
        using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        response.Headers.RetryAfter = new RetryConditionHeaderValue(new DateTimeOffset(2026, 1, 1, 11, 59, 30, TimeSpan.Zero));

        var delay = backOff.GetRetryAfterDelay(response);
        Assert.Equal(TimeSpan.Zero, delay);
    }

    [Fact]
    public void GetRetryAfterDelay_ServerDateHeader_CompensatesClockSkew()
    {
        var clock = new MockClock(new DateTime(2026, 1, 1, 12, 0, 0, DateTimeKind.Utc));
        var backOff = new RetryAfterBackOff(clock);
        using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        response.Headers.Date = new DateTimeOffset(2026, 1, 1, 12, 0, 10, TimeSpan.Zero);
        response.Headers.RetryAfter = new RetryConditionHeaderValue(new DateTimeOffset(2026, 1, 1, 12, 0, 40, TimeSpan.Zero));

        // Server is 10s ahead of local clock, delay should be 12:00:40 - 12:00:10 = 30s.
        var delay = backOff.GetRetryAfterDelay(response);
        Assert.Equal(TimeSpan.FromSeconds(30), delay);
    }

    [Fact]
    public void GetRetryAfterDelay_MalformedHeader_ReturnsNull()
    {
        var backOff = new RetryAfterBackOff(SystemClock.Default);
        using var response = new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
        response.Headers.TryAddWithoutValidation("Retry-After", "invalid-retry-after-string");

        var delay = backOff.GetRetryAfterDelay(response);
        Assert.Null(delay);
    }
}
