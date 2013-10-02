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
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework;

using Google.Apis.Http;
using Google.Apis.Util;

namespace Google.Apis.Tests.Apis.Http
{
    /// <summary>Tests for <see cref="Google.Apis.Http.ConfigurableMessageHandler"/>.</summary>
    [TestFixture]
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
            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(new HttpResponseMessage());
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
                    Assert.That(request.RequestUri, Is.EqualTo(new Uri(Location)));
                    Assert.That(request.Headers.IfMatch.Count == 1);
                    Assert.That(request.Headers.IfNoneMatch.Count == 1);
                    Assert.That(request.Headers.IfModifiedSince.HasValue);
                    Assert.That(request.Headers.IfUnmodifiedSince.HasValue);
                }
                else
                {
                    // After first call the message should not contain If-* headers
                    Assert.That(request.RequestUri, Is.EqualTo(new Uri(Location + (Calls - 1))));
                    Assert.That(request.Headers.IfMatch.Count == 0);
                    Assert.That(request.Headers.IfNoneMatch.Count == 0);
                    Assert.IsNull(request.Headers.IfModifiedSince);
                    Assert.IsNull(request.Headers.IfUnmodifiedSince);
                }

                tcs.SetResult(response);
                return tcs.Task;
            }
        }

        /// <summary>Tests that the message handler handles redirect messages successfully.</summary>
        [Test]
        public void SendAsync_Redirect()
        {
            var location = "https://google.com";
            var redirectHandler = new RedirectMessageHandler(location);
            var configurableHanlder = new ConfigurableMessageHandler(redirectHandler)
                {
                    NumTries = 8
                };
            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, location);
                request.Headers.IfModifiedSince = new DateTimeOffset(DateTime.Now);
                request.Headers.IfUnmodifiedSince = new DateTimeOffset(DateTime.Now);
                request.Headers.IfMatch.Add(new EntityTagHeaderValue("\"a\""));
                request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue("\"b\""));

                HttpResponseMessage response = client.SendAsync(request).Result;

                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Redirect));
                Assert.That(response.Headers.Location, Is.EqualTo(new Uri(location + configurableHanlder.NumTries)));
                Assert.That(redirectHandler.Calls, Is.EqualTo(configurableHanlder.NumTries));
            }
        }

        /// <summary>
        /// Tests that the message handler doesn't handle redirect messages when follow redirect is <c>false</c>. 
        /// </summary>
        [Test]
        public void SendAsync_Redirect_FollowRedirectFalse()
        {
            const int tries = 12;
            var location = "https://google.com";
            var redirectHandler = new RedirectMessageHandler(location);
            var configurableHanlder = new ConfigurableMessageHandler(redirectHandler)
                {
                    NumTries = tries,
                    FollowRedirect = false
                };
            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, location);
                request.Headers.IfModifiedSince = new DateTimeOffset(DateTime.Now);
                request.Headers.IfUnmodifiedSince = new DateTimeOffset(DateTime.Now);
                request.Headers.IfMatch.Add(new EntityTagHeaderValue("\"a\""));
                request.Headers.IfNoneMatch.Add(new EntityTagHeaderValue("\"b\""));

                HttpResponseMessage response = client.SendAsync(request).Result;

                // there should be only one request because follow redirect is false
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Redirect));
                Assert.That(response.Headers.Location, Is.EqualTo(new Uri(location + 1)));
                Assert.That(redirectHandler.Calls, Is.EqualTo(1));
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
                Assert.That(request.Headers.GetValues(InjectedHeader).First(), Is.EqualTo(InjectedValue));

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
                    return TaskEx.Delay(0);
                }
            }
        }

        /// <summary>Tests that execute interceptor is called on successful response.</summary>
        [Test]
        public void SendAsync_ExecuteInterceptor()
        {
            SubtestSendAsyncExecuteInterceptor(HttpStatusCode.OK);
        }

        /// <summary>
        /// Tests that execute interceptor is called once on unsuccessful request. In this test unsuccessful response 
        /// handler isn't plugged to the handler. 
        /// </summary>
        [Test]
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
            configurableHanlder.ExecuteInterceptors.Add(interceptor);

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-execute-interceptor");

                HttpResponseMessage response = client.SendAsync(request).Result;
                Assert.That(interceptor.Calls, Is.EqualTo(1));
                Assert.That(handler.Calls, Is.EqualTo(1));
            }
        }

        /// <summary>
        /// Tests that execute interceptor is called for each request. In this case an unsuccessful response handler is 
        /// plugged to the handler
        /// </summary>
        [Test]
        public void SendAsync_ExecuteInterceptor_AbnormalResponse_UnsuccessfulResponseHandler()
        {
            var handler = new InterceptorMessageHandler();
            handler.InjectedResponseMessage = new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.ServiceUnavailable
                };

            var configurableHanlder = new ConfigurableMessageHandler(handler);
            var interceptor = new InterceptorMessageHandler.Interceptor();
            configurableHanlder.ExecuteInterceptors.Add(interceptor);
            configurableHanlder.UnsuccessfulResponseHandlers.Add(new TrueUnsuccessfulResponseHandler());

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-execute-interceptor");

                HttpResponseMessage response = client.SendAsync(request).Result;
                Assert.That(interceptor.Calls, Is.EqualTo(configurableHanlder.NumTries));
                Assert.That(handler.Calls, Is.EqualTo(configurableHanlder.NumTries));
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
            configurableHanlder.UnsuccessfulResponseHandlers.Add(unsuccessfulHandler);

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-unsuccessful-handler");

                HttpResponseMessage response = client.SendAsync(request).Result;
                Assert.That(response.StatusCode, Is.EqualTo(code));

                // if service unavailable, retry will occur because we plugged unsuccessful response handler which 
                // handles service unavailable responses
                if (code == HttpStatusCode.ServiceUnavailable)
                {
                    Assert.That(unsuccessfulHandler.Calls, Is.EqualTo(configurableHanlder.NumTries));
                    Assert.That(handler.Calls, Is.EqualTo(configurableHanlder.NumTries));
                }
                else
                {
                    // if status is OK, there isn't any call to unsuccessful response handler
                    Assert.That(unsuccessfulHandler.Calls, Is.EqualTo(code != HttpStatusCode.OK ? 1 : 0));
                    Assert.That(handler.Calls, Is.EqualTo(1));
                }
            }
        }

        /// <summary>Tests that unsuccessful response handler isn't called when the response is successful.</summary>
        [Test]
        public void SendAsync_UnsuccessfulReponseHanlder_SuccessfulReponse()
        {
            SubtestSendAsyncUnsuccessfulReponseHanlder(HttpStatusCode.OK);
        }

        /// <summary>
        /// Tests that unsuccessful response handler is called when the response is unsuccessful, but the handler can't
        /// handle the abnormal response (e.g. different status code).
        /// </summary>
        [Test]
        public void SendAsync_UnsuccessfulReponseHanlder_AbnormalResponse_DifferentStatusCode()
        {
            SubtestSendAsyncUnsuccessfulReponseHanlder(HttpStatusCode.BadGateway);
        }

        /// <summary>
        /// Tests that unsuccessful response handler is called when the response is unsuccessful and the handler can 
        /// handle the abnormal response (e.g. same status code).
        /// </summary>
        [Test]
        public void SendAsync_UnsuccessfulReponseHanlder_AbnormalResponse_SameStatusCode()
        {
            SubtestSendAsyncUnsuccessfulReponseHanlder(HttpStatusCode.ServiceUnavailable);
        }

        /// <summary>Tests abnormal response when unsuccessful response handler isn't plugged.</summary>
        [Test]
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
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.ServiceUnavailable));
                Assert.That(handler.Calls, Is.EqualTo(1));
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
            configurableHanlder.ExceptionHandlers.Add(exceptionHandler);

            using (var client = new HttpClient(configurableHanlder))
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://test-exception-handler");
                try
                {
                    HttpResponseMessage response = client.SendAsync(request).Result;
                    if (throwException)
                    {
                        Assert.Fail("SendAsync should throw an exception");
                    }
                }
                catch (AggregateException ae)
                {
                    Assert.That(ae.InnerException.Message, Is.EqualTo(ExceptionMessageHandler.ExceptionMessage));
                }

                // if exception is thrown, check if it's handles. if so, there should be num tries calls, otherwise
                // only 1
                if (throwException)
                {
                    Assert.That(exceptionHandler.Calls, Is.EqualTo(handle ? configurableHanlder.NumTries : 1));
                }
                // exception wasn't supposed to be thrown, so no call to exception handler should be made
                else
                {
                    Assert.That(exceptionHandler.Calls, Is.EqualTo(0));
                }

                Assert.That(handler.Calls, Is.EqualTo(throwException & handle ? configurableHanlder.NumTries : 1));
            }
        }


        /// <summary>Tests that the exception handler isn't called on successful response.</summary>
        [Test]
        public void SendAsync_ExceptionHandler_SuccessReponse()
        {
            SubtestSendAsyncExceptionHandler(false, true);
        }

        /// <summary>
        /// Tests that the exception handler is called when exception is thrown on execute, but it can't handle the 
        /// exception. 
        /// </summary>
        [Test]
        public void SendAsync_ExceptionHandler_ThrowException_DontHandle()
        {
            SubtestSendAsyncExceptionHandler(true, false);
        }

        /// <summary>
        /// Tests that the exception handler is called when exception is thrown on execute, and it handles the 
        /// exception. 
        /// </summary>
        [Test]
        public void SendAsync_ExceptionHandler_ThrowException_Handle()
        {
            SubtestSendAsyncExceptionHandler(true, true);
        }

        /// <summary>Tests an exception is thrown on execute and there is no exception handler.</summary>
        [Test]
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
                    Assert.Fail("SendAsync should throw an exception");
                }
                catch (AggregateException ae)
                {
                    Assert.That(ae.InnerException.Message, Is.EqualTo(ExceptionMessageHandler.ExceptionMessage));
                }
                catch (Exception)
                {
                    Assert.Fail("AggregateException was suppose to be thrown");
                }
                Assert.That(handler.Calls, Is.EqualTo(1));
            }
        }

        #endregion

        #region Back-off

        #region Exception

        /// <summary>
        /// Tests that back-off handler works as expected when exception is thrown. 
        /// Use default max time span (2 minutes).
        /// </summary>
        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
        public void SendAsync_BackOffExceptionHandler_ThrowCanceledException()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            SubtestSendAsync_BackOffExceptionHandler(true, initializer, new TaskCanceledException());
        }

        /// <summary>
        /// Tests that back-off handler works as expected with the not defaulted exception handler. 
        /// </summary>
        [Test]
        public void SendAsync_BackOffExceptionHandler_DifferentHandler()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            initializer.HandleExceptionFunc = e => (e is InvalidCastException);
            SubtestSendAsync_BackOffExceptionHandler(true, initializer, new InvalidCastException());

            initializer.HandleExceptionFunc = e => !(e is InvalidCastException);
            SubtestSendAsync_BackOffExceptionHandler(true, initializer, new InvalidCastException());
        }

        /// <summary>Tests that back-off handler works as expected when exception isn't thrown.</summary>
        [Test]
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
            configurableHanlder.ExceptionHandlers.Add(boHandler);

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
                    Assert.That(ae.InnerException.Message, Is.EqualTo(handler.Exception.Message));
                }

                Assert.That(boHandler.Waits.Count, Is.EqualTo(boHandleCount));
                // check the exponential behavior - wait 1, 2, 4, 8, ... seconds.
                if (throwException)
                {
                    for (int i = 0; i < boHandler.Waits.Count; ++i)
                    {
                        Assert.That(boHandler.Waits[i].TotalSeconds, Is.EqualTo((int)Math.Pow(2, i)));
                    }
                }
                Assert.That(handler.Calls, Is.EqualTo(boHandleCount + 1));
            }
        }

        #endregion

        #region Unsuccessful Response Handler

        /// <summary>
        /// Tests that back-off handler works as expected when the server returns 5xx and the maximum time span is set
        /// to 5 seconds.
        /// </summary>
        [Test]
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
        [Test]
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
        [Test]
        public void SendAsync_BackOffUnsuccessfulResponseHandler_OK()
        {
            var initializer = new BackOffHandler.Initializer(new ExponentialBackOff(TimeSpan.Zero));
            SubtestSendAsync_BackOffUnsuccessfulResponseHandler(HttpStatusCode.OK, initializer);
        }

        /// <summary>Tests that back-off handler is canceled when cancellation token is used.</summary>
        [Test]
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
            configurableHanlder.UnsuccessfulResponseHandlers.Add(boHandler);

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
                    Assert.IsInstanceOf<TaskCanceledException>(ae.InnerException);
                    Assert.True(cancel);
                }

                Assert.That(boHandler.Waits.Count, Is.EqualTo(boHandleCount));

                // check the exponential behavior - wait 1, 2, 4, 8, ... seconds.
                for (int i = 0; i < boHandler.Waits.Count; ++i)
                {
                    Assert.That(boHandler.Waits[i].TotalSeconds, Is.EqualTo((int)Math.Pow(2, i)));
                }

                // if the request was canceled the number of calls to the message handler is equal to the number of 
                // calls to back-off handler
                Assert.That(handler.Calls, Is.EqualTo(boHandleCount + (cancel ? 0 : 1)));
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

                ReadContent = await request.Content.ReadAsStringAsync();
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
            configurableHanlder.UnsuccessfulResponseHandlers.Add(new TrueUnsuccessfulResponseHandler());
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
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(contentHandler.Calls, Is.EqualTo(ContentMessageHandler.NumFails));
                Assert.That(contentHandler.ReadContent, Is.EqualTo(content));
            }
        }

        /// <summary>Tests that a string content works as expected on retry.</summary>
        [Test]
        public void SendAsync_Retry_CorrectStringContent()
        {
            SubtestSendAsyncRetryContent(ContentType.String);
        }

        /// <summary>Tests that a stream content works as expected on retry.</summary>
        [Test]
        public void SendAsync_Retry_CorrectStreamContent()
        {
            SubtestSendAsyncRetryContent(ContentType.Stream);
        }

        /// <summary>Tests that a byte array content works as expected on retry.</summary>
        [Test]
        public void SendAsync_Retry_CorrectByteArrayContent()
        {
            SubtestSendAsyncRetryContent(ContentType.ByteArray);
        }

        #endregion

        /// <summary>Tests setting number of tries.</summary>
        [Test]
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
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(ex.Message.Contains("Parameter name: NumTries"));
            }
            try
            {
                configurableHanlder.NumTries = 0;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(ex.Message.Contains("Parameter name: NumTries"));
            }
            try
            {
                configurableHanlder.NumTries = -2;
                Assert.Fail();
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
        [Test]
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
                configurableHanlder.UnsuccessfulResponseHandlers.Add(unsuccessfulHandler);
            }

            using (var client = new HttpClient(configurableHanlder))
            {
                client.GetAsync("http://num-retres");
                Assert.That(handler.Calls, Is.EqualTo(handle ? numTries : 1));
            }
        }

        /// <summary>Tests that the configurable message handler sets the User-Agent header.</summary>
        [Test]
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
                Assert.That(userAgent, Is.EqualTo(apiVersion));

                // with application name
                configurableHanlder.ApplicationName = applicationName;
                request = new HttpRequestMessage(HttpMethod.Get, "https://test-user-agent");
                response = client.SendAsync(request).Result;
                userAgent = string.Join(" ", request.Headers.GetValues("User-Agent").ToArray());
                Assert.That(userAgent, Is.EqualTo(applicationName + " " + apiVersion));
            }
        }
    }
}
