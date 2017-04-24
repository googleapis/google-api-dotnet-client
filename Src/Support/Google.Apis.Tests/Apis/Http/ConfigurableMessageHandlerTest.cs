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

using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Http
{
    /// <summary>Tests for <see cref="Google.Apis.Http.ConfigurableMessageHandler"/>.</summary>
    public class ConfigurableMessageHandlerTest
    {
        #region Handlers

        /// <summary>Unsuccessful handler which always returns <c>true</c>.</summary>
        private class TrueUnsuccessfulResponseHandler : IHttpUnsuccessfulResponseHandler
        {
            public Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
            {
                TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                tcs.SetResult(true);
                return tcs.Task;
            }
        }

        /// <summary>Message handler which returns a new successful (and empty) response.</summary>
        private class MockMessageHandler : HttpMessageHandler
        {
            public HttpResponseMessage Response { get; set; } = new HttpResponseMessage();

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(Response);
                return tcs.Task;
            }
        }

        #endregion

        #region Redirect

        /// <summary>Redirect message handler which return redirect response.</summary>
        private class RedirectMessageHandler : CountableMessageHandler
        {
            /// <summary>Gets or sets the redirect location Uri string.</summary>
            private string Location { get; set; }

            /// <summary>Constructs a new redirect message handler with the given location.</summary>
            public RedirectMessageHandler(string location)
            {
                Location = location;
            }

            protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsyncCore(
                HttpRequestMessage request, CancellationToken cancellationToken)
            {
                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                var response = new HttpResponseMessage();

                response.StatusCode = HttpStatusCode.Redirect;
                response.Headers.Location = new Uri(Location + Calls);
                response.RequestMessage = request;

                if (Calls == 1)
                {
                    // First call the message should contain If-* headers
                    Assert.Equal(new Uri(Location), request.RequestUri);
                    Assert.Equal(1, request.Headers.IfMatch.Count);
                    Assert.Equal(1, request.Headers.IfNoneMatch.Count);
                    Assert.True(request.Headers.IfModifiedSince.HasValue);
                    Assert.True(request.Headers.IfUnmodifiedSince.HasValue);
                }
                else
                {
                    // After first call the message should not contain If-* headers
                    Assert.Equal(new Uri(Location + (Calls - 1)), request.RequestUri);
                    Assert.Equal(0, request.Headers.IfMatch.Count);
                    Assert.Equal(0, request.Headers.IfNoneMatch.Count);
                    Assert.Null(request.Headers.IfModifiedSince);
                    Assert.Null(request.Headers.IfUnmodifiedSince);
                }

                tcs.SetResult(response);
                return tcs.Task;
            }
        }

        /// <summary>Tests that the message handler handles redirect messages successfully.</summary>
        [Fact]
        public void SendAsync_Redirect()
        {
            var location = "https://google.com";
            var redirectHandler = new RedirectMessageHandler(location);
            var configurableHanlder = new ConfigurableMessageHandler(redirectHandler)
            {
                NumRedirects = 5
            };

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, location);
                request.Headers.IfModifiedSince = DateTimeOffset.UtcNow;
                request.Headers.IfUnmodifiedSince = DateTimeOffset.UtcNow;
                request.Headers.IfMatch.Add(new EntityTagHeaderValue("\"a\""));
                request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue("\"b\""));

                HttpResponseMessage response = client.SendAsync(request).Result;

                Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
                Assert.Equal(new Uri(location + (configurableHanlder.NumRedirects + 1)), response.Headers.Location);
                Assert.Equal(configurableHanlder.NumRedirects + 1, redirectHandler.Calls);
            }
        }

        /// <summary>
        /// Tests that the message handler doesn't handle redirect messages when follow redirect is <c>false</c>. 
        /// </summary>
        [Fact]
        public void SendAsync_Redirect_FollowRedirectFalse()
        {
            const int tries = 12;
            var location = "https://google.com";
            var redirectHandler = new RedirectMessageHandler(location);
            var configurableHanlder = new ConfigurableMessageHandler(redirectHandler)
            {
                NumRedirects = tries,
                FollowRedirect = false
            };

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, location);
                request.Headers.IfModifiedSince = DateTimeOffset.UtcNow;
                request.Headers.IfUnmodifiedSince = DateTimeOffset.UtcNow;
                request.Headers.IfMatch.Add(new EntityTagHeaderValue("\"a\""));
                request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue("\"b\""));

                HttpResponseMessage response = client.SendAsync(request).Result;

                // there should be only one request because follow redirect is false
                Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
                Assert.Equal(new Uri(location + 1), response.Headers.Location);
                Assert.Equal(1, redirectHandler.Calls);
            }
        }

        #endregion

        #region Execute interceptor

        /// <summary>
        /// Mock interceptor handler which verifies that an interceptor is being called on a request. 
        /// </summary>
        private class InterceptorMessageHandler : CountableMessageHandler
        {
            /// <summary>Gets or sets an injected response message which will be returned on send.</summary>
            public HttpResponseMessage InjectedResponseMessage { get; set; }

            const string InjectedHeader = "Some-Header";
            const string InjectedValue = "123";

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                Assert.Equal(InjectedValue, request.Headers.GetValues(InjectedHeader).First());

                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(InjectedResponseMessage);
                return tcs.Task;
            }

            /// <summary>A mock interceptor which inject a header to a request.</summary>
            internal class Interceptor : IHttpExecuteInterceptor
            {
                public int Calls { get; set; }

                public Task InterceptAsync(HttpRequestMessage request, CancellationToken token)
                {
                    ++Calls;
                    request.Headers.Add(InjectedHeader, InjectedValue);
                    return Task.Delay(0);
                }
            }
        }

        /// <summary>Tests that execute interceptor is called on successful response.</summary>
        [Fact]
        public void SendAsync_ExecuteInterceptor()
        {
            SubtestSendAsyncExecuteInterceptor(HttpStatusCode.OK);
        }

        /// <summary>
        /// Tests that execute interceptor is called once on unsuccessful request. In this test unsuccessful response 
        /// handler isn't plugged to the handler. 
        /// </summary>
        [Fact]
        public void SendAsync_ExecuteInterceptor_AbnormalResponse()
        {
            SubtestSendAsyncExecuteInterceptor(HttpStatusCode.BadRequest);
        }

        /// <summary>Tests that execute interceptor is called.</summary>
        private void SubtestSendAsyncExecuteInterceptor(HttpStatusCode code)
        {
            var handler = new InterceptorMessageHandler();
            handler.InjectedResponseMessage = new HttpResponseMessage()
                {
                    StatusCode = code
                };

            var configurableHanlder = new ConfigurableMessageHandler(handler);
            var interceptor = new InterceptorMessageHandler.Interceptor();
            configurableHanlder.AddExecuteInterceptor(interceptor);

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-execute-interceptor");

                HttpResponseMessage response = client.SendAsync(request).Result;
                Assert.Equal(1, interceptor.Calls);
                Assert.Equal(1, handler.Calls);
            }
        }

        /// <summary>
        /// Tests that execute interceptor is called for each request. In this case an unsuccessful response handler is 
        /// plugged to the handler
        /// </summary>
        [Fact]
        public void SendAsync_ExecuteInterceptor_AbnormalResponse_UnsuccessfulResponseHandler()
        {
            var handler = new InterceptorMessageHandler();
            handler.InjectedResponseMessage = new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.ServiceUnavailable
                };

            var configurableHanlder = new ConfigurableMessageHandler(handler);
            var interceptor = new InterceptorMessageHandler.Interceptor();
            configurableHanlder.AddExecuteInterceptor(interceptor);
            configurableHanlder.AddUnsuccessfulResponseHandler(new TrueUnsuccessfulResponseHandler());

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-execute-interceptor");

                HttpResponseMessage response = client.SendAsync(request).Result;
                Assert.Equal(configurableHanlder.NumTries, interceptor.Calls);
                Assert.Equal(configurableHanlder.NumTries, handler.Calls);
            }
        }

        #endregion

        #region Unsuccessful reponse handler

        /// <summary>
        /// Mock unsuccessful response handler which verifies that unsuccessful response handler is being called.
        /// </summary>
        private class UnsuccessfulResponseMessageHandler : CountableMessageHandler
        {
            /// <summary>Gets or sets the status code to return on the response.</summary>
            public HttpStatusCode ResponseStatusCode { get; set; }

            /// <summary>Gets or sets the cancellation token source.</summary>
            public CancellationTokenSource CancellationTokenSource { get; set; }

            /// <summary>
            /// Gets or sets the request number to invoke the Cancel method on <see cref="CancellationTokenSource"/>.
            /// </summary>
            public int CancelRequestNum { get; set; }

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                if (Calls == CancelRequestNum)
                {
                    CancellationTokenSource.Cancel();
                }

                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(new HttpResponseMessage { StatusCode = ResponseStatusCode });
                return tcs.Task;
            }

            /// <summary>Unsuccessful response handler which "handles" only service unavailable responses.</summary>
            internal class ServiceUnavailableResponseHandler : IHttpUnsuccessfulResponseHandler
            {
                public int Calls { get; set; }

                public Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
                {
                    ++Calls;
                    TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                    tcs.SetResult(args.Response.StatusCode.Equals(HttpStatusCode.ServiceUnavailable));
                    return tcs.Task;
                }
            }
        }

        /// <summary>Test helper for testing unsuccessful response handlers.</summary>
        private void SubtestSendAsyncUnsuccessfulReponseHanlder(HttpStatusCode code)
        {
            var handler = new UnsuccessfulResponseMessageHandler { ResponseStatusCode = code };

            var configurableHanlder = new ConfigurableMessageHandler(handler);
            var unsuccessfulHandler = new UnsuccessfulResponseMessageHandler.ServiceUnavailableResponseHandler();
            configurableHanlder.AddUnsuccessfulResponseHandler(unsuccessfulHandler);

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-unsuccessful-handler");

                HttpResponseMessage response = client.SendAsync(request).Result;
                Assert.Equal(code, response.StatusCode);

                // if service unavailable, retry will occur because we plugged unsuccessful response handler which 
                // handles service unavailable responses
                if (code == HttpStatusCode.ServiceUnavailable)
                {
                    Assert.Equal(configurableHanlder.NumTries, unsuccessfulHandler.Calls);
                    Assert.Equal(configurableHanlder.NumTries, handler.Calls);
                }
                else
                {
                    // if status is OK, there isn't any call to unsuccessful response handler
                    Assert.Equal(code != HttpStatusCode.OK ? 1 : 0, unsuccessfulHandler.Calls);
                    Assert.Equal(1, handler.Calls);
                }
            }
        }

        /// <summary>Tests that unsuccessful response handler isn't called when the response is successful.</summary>
        [Fact]
        public void SendAsync_UnsuccessfulReponseHanlder_SuccessfulReponse()
        {
            SubtestSendAsyncUnsuccessfulReponseHanlder(HttpStatusCode.OK);
        }

        /// <summary>
        /// Tests that unsuccessful response handler is called when the response is unsuccessful, but the handler can't
        /// handle the abnormal response (e.g. different status code).
        /// </summary>
        [Fact]
        public void SendAsync_UnsuccessfulReponseHanlder_AbnormalResponse_DifferentStatusCode()
        {
            SubtestSendAsyncUnsuccessfulReponseHanlder(HttpStatusCode.BadGateway);
        }

        /// <summary>
        /// Tests that unsuccessful response handler is called when the response is unsuccessful and the handler can 
        /// handle the abnormal response (e.g. same status code).
        /// </summary>
        [Fact]
        public void SendAsync_UnsuccessfulReponseHanlder_AbnormalResponse_SameStatusCode()
        {
            SubtestSendAsyncUnsuccessfulReponseHanlder(HttpStatusCode.ServiceUnavailable);
        }

        /// <summary>Tests abnormal response when unsuccessful response handler isn't plugged.</summary>
        [Fact]
        public void SendAsync_AbnormalResponse_WithoutUnsuccessfulReponseHandler()
        {
            var handler = new UnsuccessfulResponseMessageHandler
                {
                    ResponseStatusCode = HttpStatusCode.ServiceUnavailable
                };

            var configurableHanlder = new ConfigurableMessageHandler(handler);
            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-unsuccessful-handler");

                HttpResponseMessage response = client.SendAsync(request).Result;
                Assert.Equal(HttpStatusCode.ServiceUnavailable, response.StatusCode);
                Assert.Equal(1, handler.Calls);
            }
        }

        #endregion

        #region Exception Handler

        /// <summary>Mock exception message handler which verifies that exception handler is being called.</summary>
        private class ExceptionMessageHandler : CountableMessageHandler
        {
            public ExceptionMessageHandler()
            {
                Exception = new Exception(ExceptionMessage);
            }

            /// <summary>Gets or sets indication if exception should be thrown.</summary>
            public bool ThrowException { get; set; }

            /// <summary>
            /// Gets or sets a specific exception to throw. Default value is <seealso cref="System.Exception"/> 
            /// with <see cref="ExceptionMessage"/>.</summary>
            public Exception Exception { get; set; }

            /// <summary>
            /// The exception message which is thrown in case <see cref="ThrowException"/> is <c>true</c>. 
            /// </summary>
            public const string ExceptionMessage = "Exception from execute";

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                if (ThrowException)
                {
                    throw Exception;
                }

                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(new HttpResponseMessage());
                return tcs.Task;
            }

            /// <summary>Mock Exception handler which "handles" the exception.</summary>
            internal class ExceptionHandler : IHttpExceptionHandler
            {
                public int Calls { get; set; }
                public bool Handle { get; set; }

                public ExceptionHandler(bool handle = true)
                {
                    Handle = handle;
                }

                public Task<bool> HandleExceptionAsync(HandleExceptionArgs args)
                {
                    ++Calls;
                    TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                    tcs.SetResult(Handle);
                    return tcs.Task;
                }
            }
        }

        /// <summary>Subtest for exception handler which tests that exception handler is invoked.</summary>
        private void SubtestSendAsyncExceptionHandler(bool throwException, bool handle)
        {
            var handler = new ExceptionMessageHandler { ThrowException = throwException };

            var configurableHanlder = new ConfigurableMessageHandler(handler);
            var exceptionHandler = new ExceptionMessageHandler.ExceptionHandler { Handle = handle };
            configurableHanlder.AddExceptionHandler(exceptionHandler);

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
                try
                {
                    HttpResponseMessage response = client.SendAsync(request).Result;
                    if (throwException)
                    {
                        Assert.True(false, "SendAsync should throw an exception");
                    }
                }
                catch (AggregateException ae)
                {
                    Assert.Equal(ExceptionMessageHandler.ExceptionMessage, ae.InnerException.Message);
                }

                // if exception is thrown, check if it's handles. if so, there should be num tries calls, otherwise
                // only 1
                if (throwException)
                {
                    Assert.Equal(handle ? configurableHanlder.NumTries : 1, exceptionHandler.Calls);
                }
                // exception wasn't supposed to be thrown, so no call to exception handler should be made
                else
                {
                    Assert.Equal(0, exceptionHandler.Calls);
                }

                Assert.Equal(throwException & handle ? configurableHanlder.NumTries : 1, handler.Calls);
            }
        }


        /// <summary>Tests that the exception handler isn't called on successful response.</summary>
        [Fact]
        public void SendAsync_ExceptionHandler_SuccessReponse()
        {
            SubtestSendAsyncExceptionHandler(false, true);
        }

        /// <summary>
        /// Tests that the exception handler is called when exception is thrown on execute, but it can't handle the 
        /// exception. 
        /// </summary>
        [Fact]
        public void SendAsync_ExceptionHandler_ThrowException_DontHandle()
        {
            SubtestSendAsyncExceptionHandler(true, false);
        }

        /// <summary>
        /// Tests that the exception handler is called when exception is thrown on execute, and it handles the 
        /// exception. 
        /// </summary>
        [Fact]
        public void SendAsync_ExceptionHandler_ThrowException_Handle()
        {
            SubtestSendAsyncExceptionHandler(true, true);
        }

        /// <summary>Tests an exception is thrown on execute and there is no exception handler.</summary>
        [Fact]
        public void SendAsync_ThrowException_WithoutExceptionHandler()
        {
            var handler = new ExceptionMessageHandler { ThrowException = true };

            var configurableHanlder = new ConfigurableMessageHandler(handler);

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
                try
                {
                    HttpResponseMessage response = client.SendAsync(request).Result;
                    Assert.True(false, "SendAsync should throw an exception");
                }
                catch (AggregateException ae)
                {
                    Assert.Equal(ExceptionMessageHandler.ExceptionMessage, ae.InnerException.Message);
                }
                catch (Exception)
                {
                    Assert.True(false, "AggregateException was suppose to be thrown");
                }
                Assert.Equal(1, handler.Calls);
            }
        }

        #endregion

        #region Back-off

        #region Exception

        /// <summary>
        /// Tests that back-off handler works as expected when exception is thrown. 
        /// Use default max time span (2 minutes).
        /// </summary>
        [Fact]
        public void SendAsync_BackOffExceptionHandler_Throw_Max2Minutes()
        {
            // create exponential back-off without delta interval, so expected seconds are exactly 1, 2, 4, 8, etc.
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            SubtestSendAsync_BackOffExceptionHandler(true, initializer);
        }

        /// <summary>
        /// Tests that back-off handler works as expected when exception is thrown. 
        /// Max time span is set to 200 milliseconds (as a result the back-off handler can't handle the exception).
        /// </summary>
        [Fact]
        public void SendAsync_BackOffExceptionHandler_Throw_Max200Milliseconds()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromMilliseconds(200)
                };
            SubtestSendAsync_BackOffExceptionHandler(true, initializer);
        }

        /// <summary>
        /// Tests that back-off handler works as expected when exception is thrown. 
        /// Max time span is set to 1 hour.
        /// </summary>
        [Fact]
        public void SendAsync_BackOffExceptionHandler_Throw_Max1Hour()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromHours(1)
                };
            SubtestSendAsync_BackOffExceptionHandler(true, initializer);
        }

        /// <summary>
        /// Tests that back-off handler works as expected when 
        /// <seealso cref="System.Threading.Tasks.TaskCanceledException"/>> is thrown. 
        /// </summary>
        [Fact]
        public void SendAsync_BackOffExceptionHandler_ThrowCanceledException()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            SubtestSendAsync_BackOffExceptionHandler(true, initializer, new TaskCanceledException());
        }

        /// <summary>
        /// Tests that back-off handler works as expected with the not defaulted exception handler. 
        /// </summary>
        [Fact]
        public void SendAsync_BackOffExceptionHandler_DifferentHandler()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            initializer.HandleExceptionFunc = e => (e is InvalidCastException);
            SubtestSendAsync_BackOffExceptionHandler(true, initializer, new InvalidCastException());

            initializer.HandleExceptionFunc = e => !(e is InvalidCastException);
            SubtestSendAsync_BackOffExceptionHandler(true, initializer, new InvalidCastException());
        }

        /// <summary>Tests that back-off handler works as expected when exception isn't thrown.</summary>
        [Fact]
        public void SendAsync_BackOffExceptionHandler_DontThrow()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            SubtestSendAsync_BackOffExceptionHandler(false, initializer);
        }

        /// <summary>Subtest that back-off handler works as expected when exception is or isn't thrown.</summary>
        private void SubtestSendAsync_BackOffExceptionHandler(bool throwException,
            BackOffHandler.Initializer initializer, Exception exceptionToThrow = null)
        {
            var handler = new ExceptionMessageHandler { ThrowException = throwException };
            if (exceptionToThrow != null)
            {
                handler.Exception = exceptionToThrow;
            }

            var configurableHanlder = new ConfigurableMessageHandler(handler);
            var boHandler = new MockBackOffHandler(initializer);
            configurableHanlder.AddExceptionHandler(boHandler);

            int boHandleCount = 0;
            // if an exception should be thrown and the handler can handle it then calculate the handle count by the 
            // lg(MaxTimeSpan)
            if (throwException && initializer.HandleExceptionFunc(exceptionToThrow))
            {
                boHandleCount = Math.Min((int)Math.Floor(Math.Log(boHandler.MaxTimeSpan.TotalSeconds, 2)) + 1,
                    configurableHanlder.NumTries - 1);
                boHandleCount = boHandleCount >= 0 ? boHandleCount : 0;
            }

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
                try
                {
                    HttpResponseMessage response = client.SendAsync(request).Result;
                    Assert.False(throwException);
                }
                catch (AggregateException ae)
                {
                    Assert.True(throwException);
                    // Don't compare exception messages because for TaskCanceledException the message
                    // on Mono is different if there is a task associated with the exception.
                    Assert.Equal(handler.Exception.GetType(), ae.InnerException.GetType());
                }

                Assert.Equal(boHandleCount, boHandler.Waits.Count);
                // check the exponential behavior - wait 1, 2, 4, 8, ... seconds.
                if (throwException)
                {
                    for (int i = 0; i < boHandler.Waits.Count; ++i)
                    {
                        Assert.Equal((int)Math.Pow(2, i), boHandler.Waits[i].TotalSeconds);
                    }
                }
                Assert.Equal(boHandleCount + 1, handler.Calls);
            }
        }

        #endregion

        #region Unsuccessful Response Handler

        /// <summary>
        /// Tests that back-off handler works as expected when the server returns 5xx and the maximum time span is set
        /// to 5 seconds.
        /// </summary>
        [Fact]
        public void SendAsync_BackOffUnsuccessfulResponseHandler_ServiceUnavailable_Max5Seconds()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromSeconds(5)
                };
            SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.ServiceUnavailable, initializer);
        }

        /// <summary>
        /// Tests that back-off handler works as expected when the server returns 5xx and the maximum time span is set
        /// to 10 hours.
        /// </summary>
        [Fact]
        public void SendAsync_BackOffUnsuccessfulResponseHandler_ServiceUnavailable_Max10Hours()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromHours(10)
                };
            SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.ServiceUnavailable, initializer);
        }

        /// <summary>
        /// Tests that back-off handler isn't be called when the server returns a successful response.
        /// </summary>
        [Fact]
        public void SendAsync_BackOffUnsuccessfulResponseHandler_OK()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.OK, initializer);
        }

        /// <summary>Tests that back-off handler is canceled when cancellation token is used.</summary>
        [Fact]
        public void SendAsync_BackOffUnsuccessfulResponseHandler_Cancel()
        {
            // test back-off with maximum 30 minutes per single request
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero))
                {
                    MaxTimeSpan = TimeSpan.FromMinutes(30)
                };
            SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.ServiceUnavailable, initializer, 2);
            SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.ServiceUnavailable, initializer, 6);
        }

        /// <summary>
        /// Subtest that back-off handler works as expected when a successful or abnormal response is returned.
        /// For testing the back-off handler in case of a canceled request, set the <code>cancelRequestNum</code>
        /// parameter to the index of the request you want to cancel.
        /// </summary>
        private void SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode statusCode,
            BackOffHandler.Initializer initializer, int cancelRequestNum = 0, int numTries = 10)
        {
            var handler = new UnsuccessfulResponseMessageHandler { ResponseStatusCode = statusCode };

            CancellationToken cancellationToken = CancellationToken.None;
            bool cancel = cancelRequestNum > 0;

            if (cancel)
            {
                CancellationTokenSource tcs = new CancellationTokenSource();
                handler.CancellationTokenSource = tcs;
                handler.CancelRequestNum = cancelRequestNum;
                cancellationToken = tcs.Token;
            }

            var configurableHanlder = new ConfigurableMessageHandler(handler)
                {
                    NumTries = numTries
                };
            var boHandler = new MockBackOffHandler(initializer);
            configurableHanlder.AddUnsuccessfulResponseHandler(boHandler);

            int boHandleCount = 0;
            if (initializer.HandleUnsuccessfulResponseFunc != null &&
                initializer.HandleUnsuccessfulResponseFunc(new HttpResponseMessage { StatusCode = statusCode }))
            {
                boHandleCount = Math.Min((int)Math.Floor(Math.Log(boHandler.MaxTimeSpan.TotalSeconds, 2)) + 1,
                    configurableHanlder.NumTries - 1);
                boHandleCount = boHandleCount >= 0 ? boHandleCount : 0;
                if (cancel)
                {
                    boHandleCount = Math.Min(boHandleCount, cancelRequestNum);
                }
            }

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
                try
                {
                    HttpResponseMessage response = client.SendAsync(request, cancellationToken).Result;
                    Assert.False(cancel);
                }
                catch (AggregateException ae)
                {
                    // a canceled request should throw an exception
                    Assert.IsType<TaskCanceledException>(ae.InnerException);
                    Assert.True(cancel);
                }

                Assert.Equal(boHandleCount, boHandler.Waits.Count);

                // check the exponential behavior - wait 1, 2, 4, 8, ... seconds.
                for (int i = 0; i < boHandler.Waits.Count; ++i)
                {
                    Assert.Equal((int)Math.Pow(2, i), boHandler.Waits[i].TotalSeconds);
                }

                // if the request was canceled the number of calls to the message handler is equal to the number of 
                // calls to back-off handler
                Assert.Equal(boHandleCount + (cancel ? 0 : 1), handler.Calls);
            }
        }

        #endregion

        #endregion

        #region Content

        /// <summary>Mock message handler which verifies that the content is correct on retry.</summary>
        private class ContentMessageHandler : CountableMessageHandler
        {
            public const int NumFails = 4;
            public string ReadContent;

            protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                if (Calls < NumFails)
                {
                    return new HttpResponseMessage() { StatusCode = HttpStatusCode.ServiceUnavailable };
                }

                ReadContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
                return new HttpResponseMessage();
            }
        }

        /// <summary>
        /// Defines the different content types we test in <see cref="SubtestSendAsyncRetryContent"/>.
        /// </summary>
        private enum ContentType
        {
            String,
            Stream,
            ByteArray
        }

        /// <summary>Tests that retry works with different kind of contents (String, Stream and ByteArray).</summary>
        private void SubtestSendAsyncRetryContent(ContentType type)
        {
            var content = "test-content";
            var contentHandler = new ContentMessageHandler();
            var configurableHanlder = new ConfigurableMessageHandler(contentHandler)
                {
                    NumTries = 10
                };
            configurableHanlder.AddUnsuccessfulResponseHandler(new TrueUnsuccessfulResponseHandler());
            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Put, "https://test-unsuccessful-handler");
                // set the right content
                switch (type)
                {
                    case ContentType.String:
                        request.Content = new StringContent(content);
                        break;
                    case ContentType.Stream:
                        {
                            var stream = new MemoryStream();
                            var buffer = Encoding.UTF8.GetBytes(content);
                            stream.Write(buffer, 0, buffer.Length);
                            stream.Position = 0;
                            request.Content = new StreamContent(stream);
                        }
                        break;
                    case ContentType.ByteArray:
                        request.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
                        break;
                }

                HttpResponseMessage response = client.SendAsync(request).Result;
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
                Assert.Equal(ContentMessageHandler.NumFails, contentHandler.Calls);
                Assert.Equal(content, contentHandler.ReadContent);
            }
        }

        /// <summary>Tests that a string content works as expected on retry.</summary>
        [Fact]
        public void SendAsync_Retry_CorrectStringContent()
        {
            SubtestSendAsyncRetryContent(ContentType.String);
        }

        /// <summary>Tests that a stream content works as expected on retry.</summary>
        [Fact]
        public void SendAsync_Retry_CorrectStreamContent()
        {
            SubtestSendAsyncRetryContent(ContentType.Stream);
        }

        /// <summary>Tests that a byte array content works as expected on retry.</summary>
        [Fact]
        public void SendAsync_Retry_CorrectByteArrayContent()
        {
            SubtestSendAsyncRetryContent(ContentType.ByteArray);
        }

        #endregion

        /// <summary>Tests setting number of tries.</summary>
        [Fact]
        public void NumTries_Setter()
        {
            var configurableHanlder = new ConfigurableMessageHandler(new HttpClientHandler());

            // valid values
            configurableHanlder.NumTries = ConfigurableMessageHandler.MaxAllowedNumTries;
            configurableHanlder.NumTries = ConfigurableMessageHandler.MaxAllowedNumTries - 1;
            configurableHanlder.NumTries = 1;

            // test invalid values
            try
            {
                configurableHanlder.NumTries = ConfigurableMessageHandler.MaxAllowedNumTries + 1;
                Assert.True(false, "Exception expected");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(ex.Message.Contains("Parameter name: NumTries"));
            }
            try
            {
                configurableHanlder.NumTries = 0;
                Assert.True(false, "Exception expected");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(ex.Message.Contains("Parameter name: NumTries"));
            }
            try
            {
                configurableHanlder.NumTries = -2;
                Assert.True(false, "Exception expected");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(ex.Message.Contains("Parameter name: NumTries"));
            }
        }

        /// <summary>
        /// Tests the number of tries in case of unsuccessful response when unsuccessful response handler is plugged to 
        /// the message handler. 
        /// </summary>
        [Fact]
        public void SendAsync_NumTries()
        {
            SubtestSendAsyncNumTries(5, false);
            SubtestSendAsyncNumTries(5);
            SubtestSendAsyncNumTries(1);
            SubtestSendAsyncNumTries(1, false);
            SubtestSendAsyncNumTries(10);
            SubtestSendAsyncNumTries(10, false);
        }

        /// <summary>
        /// Tests the retry mechanism. In case the abnormal response is handled, there should be retries, but otherwise
        /// there should not be any retry.
        /// </summary>
        /// <param name="numTries"></param>
        /// <param name="handle"></param>
        private void SubtestSendAsyncNumTries(int numTries, bool handle = true)
        {
            var handler = new UnsuccessfulResponseMessageHandler
                {
                    ResponseStatusCode = HttpStatusCode.ServiceUnavailable
                };
            var configurableHanlder = new ConfigurableMessageHandler(handler)
                {
                    NumTries = numTries
                };
            if (handle)
            {
                var unsuccessfulHandler = new UnsuccessfulResponseMessageHandler.ServiceUnavailableResponseHandler();
                configurableHanlder.AddUnsuccessfulResponseHandler(unsuccessfulHandler);
            }

            using (var client = new HttpClient(configurableHanlder))
            {
                client.GetAsync("http://num-retres");
                Assert.Equal(handle ? numTries : 1, handler.Calls);
            }
        }

        /// <summary>Tests that the configurable message handler sets the User-Agent header.</summary>
        [Fact]
        public void SendAsync_UserAgent()
        {
            var apiVersion = string.Format("google-api-dotnet-client/{0} (gzip)", Utilities.GetLibraryVersion());
            const string applicationName = "NO NAME";

            var handler = new MockMessageHandler();
            var configurableHanlder = new ConfigurableMessageHandler(handler);

            using (var client = new HttpClient(configurableHanlder))
            {
                // without application name
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-user-agent");
                HttpResponseMessage response = client.SendAsync(request).Result;
                var userAgent = string.Join(" ", request.Headers.GetValues("User-Agent").ToArray());
                Assert.Equal(apiVersion, userAgent);

                // with application name
                configurableHanlder.ApplicationName = applicationName;
                request = new HttpRequestMessage(HttpMethod.Get, "https://test-user-agent");
                response = client.SendAsync(request).Result;
                userAgent = string.Join(" ", request.Headers.GetValues("User-Agent").ToArray());
                Assert.Equal(applicationName + " " + apiVersion, userAgent);
            }
        }

        private async Task<IList<string>> LogTest(ConfigurableMessageHandler.LogEventType logEvents, bool errorResponse = false)
        {
            var clock = new MockClock { UtcNow = new DateTime(2017, 1, 2, 3, 4, 5, DateTimeKind.Utc) };
            var logger = new MemoryLogger(LogLevel.All, clock: clock);
            HttpMessageHandler handler;
            if (errorResponse)
            {
                handler = new MockMessageHandler
                {
                    Response = new HttpResponseMessage
                    {
                        StatusCode = HttpStatusCode.ServiceUnavailable
                    }
                };
            }
            else
            {
                handler = new MockMessageHandler
                {
                    Response = new HttpResponseMessage
                    {
                        Headers = { { "header1", "One" }, { "header2", "Two" } },
                        Content = new ByteArrayContent(new byte[] { 65, 66, 67, 0, 1, 255, 68, 69 }) // ABC...DE
                    }
                };
            }
            var configurableHandler = new ConfigurableMessageHandler(handler)
            {
                LogEvents = logEvents,
                InstanceLogger = logger
            };
            using (var client = new HttpClient(configurableHandler))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-host/")
                {
                    Headers = { Host = "test-host", Referrer = new Uri("https://referrer/") },
                    Content = new ByteArrayContent(new byte[] { 88, 89, 90, 0, 1, 255, 68, 69 }) // XYZ...DE
                };
                await client.SendAsync(request).ConfigureAwait(false);
            }
            return logger.LogEntries;
        }

        [Fact]
        public async Task Logging_RequestUri()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.RequestUri).ConfigureAwait(false);
            Assert.Equal(1, logEntries.Count);
            Assert.Equal("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Request[00000001] (triesRemaining=3) URI: 'https://test-host/'", logEntries[0]);
        }

        [Fact]
        public async Task Logging_RequestHeaders()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.RequestHeaders).ConfigureAwait(false);
            Assert.Equal(1, logEntries.Count);
            // Header order may vary, and extra headers may be present (e.g. UserAgent), so test using Contain()
            Assert.Contains("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Request[00000001] Headers:\n", logEntries[0]);
            Assert.Contains("  [Host] 'test-host'", logEntries[0]);
            Assert.Contains("  [Referer] 'https://referrer/'", logEntries[0]);
        }

        [Fact]
        public async Task Logging_RequestBody()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.RequestBody).ConfigureAwait(false);
            Assert.Equal(1, logEntries.Count);
            Assert.Equal("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Request[00000001] Body: 'XYZ...DE'", logEntries[0]);
        }

        [Fact]
        public async Task Logging_ResponseStatus()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.ResponseStatus).ConfigureAwait(false);
            Assert.Equal(1, logEntries.Count);
            Assert.Equal("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Response status: OK 'OK'", logEntries[0]);
        }

        [Fact]
        public async Task Logging_ResponseError()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.ResponseAbnormal, true).ConfigureAwait(false);
            Assert.Equal(2, logEntries.Count);
            Assert.Equal("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] An abnormal response wasn't handled. Status code is ServiceUnavailable", logEntries[0]);
            Assert.Equal("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Abnormal response is being returned. Status Code is ServiceUnavailable", logEntries[1]);
        }

        [Fact]
        public async Task Logging_ResponseHeaders()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.ResponseHeaders).ConfigureAwait(false);
            Assert.Equal(1, logEntries.Count);
            Assert.Contains("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Headers:\n", logEntries[0]);
            Assert.Contains("  [header1] 'One'", logEntries[0]);
            Assert.Contains("  [header2] 'Two'", logEntries[0]);
        }

        [Fact]
        public async Task Logging_ResponseBody()
        {
            var logEntries = await LogTest(ConfigurableMessageHandler.LogEventType.ResponseBody).ConfigureAwait(false);
            Assert.Equal(1, logEntries.Count);
            Assert.Equal("D2017-01-02 03:04:05.000000 Google.Apis.Http.ConfigurableMessageHandler Response[00000001] Body: 'ABC...DE'", logEntries[0]);
        }
    }
}
