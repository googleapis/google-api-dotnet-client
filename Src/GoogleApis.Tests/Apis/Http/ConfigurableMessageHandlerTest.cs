/*
Copyright 2012 Google Inc

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

namespace Google.Apis.Tests.Apis.Http
{
    /// <summary> Tests for <see cref="Google.Apis.Http.ConfigurableMessageHandler"/>. </summary>
    [TestFixture]
    public class ConfigurableMessageHandlerTest
    {
        #region Handlers

        /// <summary> Unsuccessful handler which always returns <c>true</c>. </summary>
        private class TrueUnsuccessfulResponseHandler : IHttpUnsuccessfulResponseHandler
        {
            public bool HandleResponse(HttpRequestMessage request, HttpResponseMessage response, bool supportsRetry)
            {
                return true;
            }
        }

        /// <summary> Message handler which returns a new successful (and empty) response. </summary>
        private class MockMessageHandler : HttpMessageHandler
        {
            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                return new HttpResponseMessage();
            }
        }

        #endregion

        #region Redirect

        /// <summary> Redirect message handler which return redirect response. </summary>
        private class RedirectMessageHandler : CountableMessageHandler
        {
            /// <summary> Gets or sets the redirect location Uri string. </summary>
            private string Location { get; set; }

            /// <summary> Constructs a new redirect message handler with the given location. </summary>
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

        /// <summary> Tests that the message handler handles redirect messages successfully. </summary>
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
            /// <summary> Gets or sets an injected response message which will be returned on send. </summary>
            public HttpResponseMessage InjectedResponseMessage { get; set; }

            const string InjectedHeader = "Some-Header";
            const string InjectedValue = "123";

            protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                Assert.That(request.Headers.GetValues(InjectedHeader).First(), Is.EqualTo(InjectedValue));
                return InjectedResponseMessage;
            }

            /// <summary> A mock interceptor which inject a header to a request. </summary>
            internal class Interceptor : IHttpExecuteInterceptor
            {
                public int Calls { get; set; }

                public void Intercept(HttpRequestMessage request)
                {
                    ++Calls;
                    request.Headers.Add(InjectedHeader, InjectedValue);
                }
            }
        }

        /// <summary> Tests that execute interceptor is called on successful response. </summary>
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

        /// <summary> Tests that execute interceptor is called. </summary>
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
            /// <summary> Status code to return on the response. </summary>
            public HttpStatusCode ResponseStatusCode { get; set; }

            protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                return new HttpResponseMessage { StatusCode = ResponseStatusCode };
            }

            /// <summary> Unsuccessful response handler which "handles" only service unavailable responses. </summary>
            internal class ServiceUnavailableResponseHandler : IHttpUnsuccessfulResponseHandler
            {
                public int Calls { get; set; }

                public bool HandleResponse(HttpRequestMessage request, HttpResponseMessage response,
                    bool supportsRetry)
                {
                    ++Calls;
                    return response.StatusCode.Equals(HttpStatusCode.ServiceUnavailable);
                }
            }
        }

        /// <summary> Test helper for testing unsuccessful response handlers. </summary>
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

        /// <summary> Tests that unsuccessful response handler isn't called when the response is successful. </summary>
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

        /// <summary> Tests abnormal response when unsuccessful response handler isn't plugged. </summary>
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

        /// <summary> Mock exception message handler which verifies that exception handler is being called. </summary>
        private class ExceptionMessageHandler : CountableMessageHandler
        {
            /// <summary> Gets or sets indication if exception should be thrown. </summary>
            public bool ThrowException { get; set; }

            /// <summary> 
            /// The exception message which is thrown in case <see cref="ThrowException"/> is <c>true</c>. 
            /// </summary>
            public const string ExceptionMessage = "Exception from execute";

            protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                if (ThrowException)
                {
                    throw new Exception(ExceptionMessage);
                }
                return new HttpResponseMessage();
            }

            /// <summary> Mock Exception handler which "handles" the exception. </summary>
            internal class ExceptionHandler : IHttpExceptionHandler
            {
                public int Calls { get; set; }
                public bool Handle { get; set; }

                public ExceptionHandler(bool handle = true)
                {
                    Handle = handle;
                }

                public bool HandleException(HttpRequestMessage request, Exception exception, bool supportsRetry)
                {
                    ++Calls;
                    return Handle;
                }
            }
        }

        /// <summary> Subtest for exception handler which tests that exception handler is invoked. </summary>
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


        /// <summary> Tests that the exception handler isn't called on successful response. </summary>
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

        /// <summary> Tests an exception is thrown on execute and there is no exception handler. </summary>
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

        #region Content

        /// <summary> Mock message handler which verifies that the content is correct on retry. </summary>
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

        /// <summary> Tests that retry works with different kind of contents (String, Stream and ByteArray). </summary>
        private void SubtestSendAsyncRetryContent(ContentType type)
        {
            var content = "test-content";
            var contentHandler = new ContentMessageHandler();
            var configurableHanlder = new ConfigurableMessageHandler(contentHandler);
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

        /// <summary> Tests that a string content works as expected on retry. </summary>
        [Test]
        public void SendAsync_Retry_CorrectStringContent()
        {
            SubtestSendAsyncRetryContent(ContentType.String);
        }

        /// <summary> Tests that a stream content works as expected on retry. </summary>
        [Test]
        public void SendAsync_Retry_CorrectStreamContent()
        {
            SubtestSendAsyncRetryContent(ContentType.Stream);
        }

        /// <summary> Tests that a byte array content works as expected on retry. </summary>
        [Test]
        public void SendAsync_Retry_CorrectByteArrayContent()
        {
            SubtestSendAsyncRetryContent(ContentType.ByteArray);
        }

        #endregion

        /// <summary> Tests setting number of tries. </summary>
        [Test]
        public void TestNumTries_Setter()
        {
            var configurableHanlder = new ConfigurableMessageHandler(new HttpClientHandler());
            // valid values
            configurableHanlder.NumTries = 5;
            configurableHanlder.NumTries = 1;
            configurableHanlder.NumTries = ConfigurableMessageHandler.MaxAllowedNumTries;

            // test invalid values
            try
            {
                configurableHanlder.NumTries = ConfigurableMessageHandler.MaxAllowedNumTries + 1;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(ex.Message.Contains("Parameter name: NumRetries"));
            }
            try
            {
                configurableHanlder.NumTries = 0;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(ex.Message.Contains("Parameter name: NumRetries"));
            }
            try
            {
                configurableHanlder.NumTries = -2;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.True(ex.Message.Contains("Parameter name: NumRetries"));
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

        /// <summary> Tests that the configurable message handler sets the User-Agent header. </summary>
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
