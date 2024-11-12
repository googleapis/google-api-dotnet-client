/*
Copyright 2024 Google Inc

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

using Google.Apis.Http;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using Xunit;

namespace Google.Apis.Tests.Apis.Http;

public class ExponentialBackOffInitializerTest
{
    private static readonly BackOffHandler s_backOffHandler = new BackOffHandler(new ExponentialBackOff());

    [Fact]
    public void Policy_None()
    {
        var initializer = new ExponentialBackOffInitializer(ExponentialBackOffPolicy.None, () => s_backOffHandler);
        var httpClient = new ConfigurableHttpClient(new ConfigurableMessageHandler(new MockMessageHandler()));

        initializer.Initialize(httpClient);

        // MessageHandler no longer provides a supported way for clients to query the list of handlers,
        // but we rely on the obsolete property as an implementation detail here.
#pragma warning disable CS0618 // Type or member is obsolete
        Assert.Empty(httpClient.MessageHandler.UnsuccessfulResponseHandlers);
        Assert.Empty(httpClient.MessageHandler.ExceptionHandlers);
#pragma warning restore CS0618 // Type or member is obsolete
    }

    [Fact]
    public void Policy_Exception()
    {
        var initializer = new ExponentialBackOffInitializer(ExponentialBackOffPolicy.Exception, () => s_backOffHandler);
        var httpClient = new ConfigurableHttpClient(new ConfigurableMessageHandler(new MockMessageHandler()));

        initializer.Initialize(httpClient);

        // MessageHandler no longer provides a supported way for clients to query the list of handlers,
        // but we rely on the obsolete property as an implementation detail here.
#pragma warning disable CS0618 // Type or member is obsolete
        Assert.Empty(httpClient.MessageHandler.UnsuccessfulResponseHandlers);
        var exceptionHandler = Assert.Single(httpClient.MessageHandler.ExceptionHandlers);
#pragma warning restore CS0618 // Type or member is obsolete

        var backoffHandler = Assert.IsType<BackOffHandler>(exceptionHandler);
        Assert.Same(backoffHandler, s_backOffHandler);
    }

    [Fact]
    public void Policy_BadResponse()
    {
        var initializer = new ExponentialBackOffInitializer(ExponentialBackOffPolicy.UnsuccessfulResponse503, () => s_backOffHandler);
        var httpClient = new ConfigurableHttpClient(new ConfigurableMessageHandler(new MockMessageHandler()));

        initializer.Initialize(httpClient);

        // MessageHandler no longer provides a supported way for clients to query the list of handlers,
        // but we rely on the obsolete property as an implementation detail here.
#pragma warning disable CS0618 // Type or member is obsolete
        var badResponseHandler = Assert.Single(httpClient.MessageHandler.UnsuccessfulResponseHandlers);
        Assert.Empty(httpClient.MessageHandler.ExceptionHandlers);
#pragma warning restore CS0618 // Type or member is obsolete

        var backoffHandler = Assert.IsType<BackOffHandler>(badResponseHandler);
        Assert.Same(backoffHandler, s_backOffHandler);
    }

    [Theory]
    [InlineData(ExponentialBackOffPolicy.RecommendedOrDefault)]
    [InlineData(ExponentialBackOffPolicy.Exception | ExponentialBackOffPolicy.UnsuccessfulResponse503)]
    [InlineData(ExponentialBackOffPolicy.RecommendedOrDefault | ExponentialBackOffPolicy.Exception)]
    [InlineData(ExponentialBackOffPolicy.RecommendedOrDefault | ExponentialBackOffPolicy.UnsuccessfulResponse503)]
    [InlineData(ExponentialBackOffPolicy.RecommendedOrDefault | ExponentialBackOffPolicy.Exception | ExponentialBackOffPolicy.UnsuccessfulResponse503)]
    public void Policy_ExceptionAndBadResponse(ExponentialBackOffPolicy policy)
    {
        var initializer = new ExponentialBackOffInitializer(policy, () => s_backOffHandler);
        var httpClient = new ConfigurableHttpClient(new ConfigurableMessageHandler(new MockMessageHandler()));

        initializer.Initialize(httpClient);

        // MessageHandler no longer provides a supported way for clients to query the list of handlers,
        // but we rely on the obsolete property as an implementation detail here.
#pragma warning disable CS0618 // Type or member is obsolete
        var badResponseHandler = Assert.Single(httpClient.MessageHandler.UnsuccessfulResponseHandlers);
        var exceptionHandler = Assert.Single(httpClient.MessageHandler.ExceptionHandlers);
#pragma warning restore CS0618 // Type or member is obsolete

        var badResponseBackoffHandler = Assert.IsType<BackOffHandler>(badResponseHandler);
        Assert.Same(badResponseBackoffHandler, s_backOffHandler);

        var exceptionBackoffHandler = Assert.IsType<BackOffHandler>(exceptionHandler);
        Assert.Same(exceptionBackoffHandler, s_backOffHandler);
    }
}
