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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.Tests.OAuth2;
using Google.Apis.Http;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests;

public class GoogleAuthConstsTests
{
    [Fact]
    public void OAuth2TokenEndpointRecommendedRetry()
    {
        var httpClient = new ConfigurableHttpClient(new ConfigurableMessageHandler(new DelegatedMessageHandler(request => Task.FromResult(new HttpResponseMessage()))));

        GoogleAuthConsts.OAuth2TokenEndpointRecommendedRetry.Initialize(httpClient);

        // MessageHandler no longer provides a supported way for clients to query the list of handlers,
        // but we rely on the obsolete property as an implementation detail here.
#pragma warning disable CS0618 // Type or member is obsolete
        var badResponseHandler = Assert.Single(httpClient.MessageHandler.UnsuccessfulResponseHandlers);
        var exceptionHandler = Assert.Single(httpClient.MessageHandler.ExceptionHandlers);
#pragma warning restore CS0618 // Type or member is obsolete

        var badResponseBackoffHandler = Assert.IsType<BackOffHandler>(badResponseHandler);
        var exceptionBackoffHandler = Assert.IsType<BackOffHandler>(exceptionHandler);
        Assert.Same(badResponseBackoffHandler, exceptionBackoffHandler);

        Assert.Equal(TimeSpan.MaxValue, badResponseBackoffHandler.MaxTimeSpan);

        // Check that it doesn't handle (some) exceptions.
        Assert.False(badResponseBackoffHandler.HandleExceptionFunc(new Exception()));
        Assert.False(badResponseBackoffHandler.HandleExceptionFunc(new HttpRequestException()));
        Assert.False(badResponseBackoffHandler.HandleExceptionFunc(new TaskCanceledException()));
        Assert.False(badResponseBackoffHandler.HandleExceptionFunc(new OperationCanceledException()));

        // Check that it handles the expected bad responses.
        Assert.True(badResponseBackoffHandler.HandleUnsuccessfulResponseFunc(new HttpResponseMessage(HttpStatusCode.RequestTimeout)));
        Assert.True(badResponseBackoffHandler.HandleUnsuccessfulResponseFunc(new HttpResponseMessage((HttpStatusCode) 429)));
        Assert.True(badResponseBackoffHandler.HandleUnsuccessfulResponseFunc(new HttpResponseMessage(HttpStatusCode.InternalServerError)));
        Assert.True(badResponseBackoffHandler.HandleUnsuccessfulResponseFunc(new HttpResponseMessage(HttpStatusCode.ServiceUnavailable)));
    }
}
