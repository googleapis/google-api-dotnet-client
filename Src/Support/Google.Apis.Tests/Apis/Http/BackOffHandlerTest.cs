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
using Xunit;

namespace Google.Apis.Tests.Apis.Http;

public class BackOffHandlerTest
{
    [Fact]
    public void Initializer_Defaults()
    {
        var backOff = new ExponentialBackOff(TimeSpan.Zero);
        var initializer = new BackOffHandler.Initializer(backOff);

        Assert.Same(backOff, initializer.BackOff);
        Assert.Equal(TimeSpan.FromSeconds(16), initializer.MaxTimeSpan);
        Assert.Null(initializer.Clock);
        Assert.False(initializer.RespectRetryAfterHeader);
        Assert.Same(BackOffHandler.Initializer.DefaultHandleUnsuccessfulResponseFunc, initializer.HandleUnsuccessfulResponseFunc);
        Assert.Same(BackOffHandler.Initializer.DefaultHandleExceptionFunc, initializer.HandleExceptionFunc);
    }

    [Fact]
    public void Constructor_Defaults()
    {
        var backOff = new ExponentialBackOff(TimeSpan.Zero);
        var initializer = new BackOffHandler.Initializer(backOff);
        var handler = new BackOffHandler(initializer);

        Assert.Same(backOff, handler.BackOff);
        Assert.False(handler.RespectRetryAfterHeader);
        Assert.Equal(TimeSpan.FromSeconds(16), handler.MaxTimeSpan);
        Assert.Null(handler.RetryAfterBackOff);
        Assert.Same(BackOffHandler.Initializer.DefaultHandleUnsuccessfulResponseFunc, handler.HandleUnsuccessfulResponseFunc);
        Assert.Same(BackOffHandler.Initializer.DefaultHandleExceptionFunc, handler.HandleExceptionFunc);
    }

    [Fact]
    public void Constructor_WithBackOff_Defaults()
    {
        var backOff = new ExponentialBackOff(TimeSpan.Zero);
        var handler = new BackOffHandler(backOff);

        Assert.Same(backOff, handler.BackOff);
        Assert.False(handler.RespectRetryAfterHeader);
        Assert.Equal(TimeSpan.FromSeconds(16), handler.MaxTimeSpan);
        Assert.Null(handler.RetryAfterBackOff);
        Assert.Same(BackOffHandler.Initializer.DefaultHandleUnsuccessfulResponseFunc, handler.HandleUnsuccessfulResponseFunc);
        Assert.Same(BackOffHandler.Initializer.DefaultHandleExceptionFunc, handler.HandleExceptionFunc);
    }

    [Fact]
    public void Constructor_RespectRetryAfterHeader_True_InitializesRetryAfterBackOff_WithExplicitClock()
    {
        var backOff = new ExponentialBackOff(TimeSpan.Zero);
        var clock = new MockClock(new DateTime(2026, 1, 1, 12, 0, 0, DateTimeKind.Utc));
        var initializer = new BackOffHandler.Initializer(backOff)
        {
            RespectRetryAfterHeader = true,
            Clock = clock
        };
        var handler = new BackOffHandler(initializer);

        Assert.True(handler.RespectRetryAfterHeader);
        var retryAfter = Assert.IsType<RetryAfterBackOff>(handler.RetryAfterBackOff);
        Assert.Same(clock, retryAfter.Clock);
    }

    [Fact]
    public void Constructor_RespectRetryAfterHeader_True_InitializesRetryAfterBackOff_WithDefaultClock()
    {
        var backOff = new ExponentialBackOff(TimeSpan.Zero);
        var initializer = new BackOffHandler.Initializer(backOff)
        {
            RespectRetryAfterHeader = true
        };
        var handler = new BackOffHandler(initializer);

        Assert.True(handler.RespectRetryAfterHeader);
        var retryAfter = Assert.IsType<RetryAfterBackOff>(handler.RetryAfterBackOff);
        Assert.Same(SystemClock.Default, retryAfter.Clock);
    }
}
