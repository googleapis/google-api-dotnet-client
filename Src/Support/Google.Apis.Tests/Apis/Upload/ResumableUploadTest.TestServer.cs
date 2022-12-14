/*
Copyright 2017 Google Inc

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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Tests.Apis.Upload
{
    public partial class ResumableUploadTest
    {
        /// <summary>
        /// HTTP server which listens on localhost:&lt;random port&gt; for testing.
        /// </summary>
        /// <remarks>
        /// <para>A single server is started for all tests, and is shutdown when all tests
        /// have run.</para>
        /// <para>Each test registers its own <see cref="Handler"/> with a unique
        /// URL path prefix, with the handler designed to fake a server with the
        /// required behaviour for the specific test. The test handler is unregistered
        /// when the test ends.</para>
        /// </remarks>
        private class TestServer : IDisposable
        {
            internal TestLogger Logger { get; }

            public TestServer(TestLogger logger)
            {
                Logger = logger;

                var rnd = new Random();
                // Find an available port and start an HttpListener.
                do
                {
                    _httpListener = new HttpListener();
                    HttpPrefix = $"http://localhost:{rnd.Next(49152, 65535)}/";
                    _httpListener.Prefixes.Add(HttpPrefix);
                    try
                    {
                        _httpListener.Start();
                    }
                    // Catch errors that mean the port is already in use
                    catch (HttpListenerException e) when (e.ErrorCode == 183 || e.ErrorCode == 32 || e.Message.Contains("already in use"))
                    {
                        _httpListener.Close();
                        _httpListener = null;
                    }
                    catch (SocketException e) when (e.SocketErrorCode == SocketError.AddressAlreadyInUse)
                    {
                        _httpListener.Close();
                        _httpListener = null;
                    }
                } while (_httpListener == null);
                _httpTask = RunServer();
            }

            private readonly HttpListener _httpListener;
            private readonly Task _httpTask;

            public string HttpPrefix { get; }

            private async Task RunServer()
            {
                while (_httpListener.IsListening)
                {
                    var context = await _httpListener.GetContextAsync();
                    var response = context.Response;
                    if (context.Request.Url.AbsolutePath.EndsWith("/Quit"))
                    {
                        response.Close();
                        _httpListener.Stop();
                    }
                    else
                    {
                        response.ContentType = "text/plain";
                        IEnumerable<byte> body;
                        try
                        {
                            body = await HandleCall(context.Request, response);
                            var bodyBytes = body?.ToArray() ?? new byte[0];
                            await response.OutputStream.WriteAsync(bodyBytes, 0, bodyBytes.Length);
                        }
                        catch (HttpListenerException ex)
                        {
                            Logger.WriteLine($"HttpListener failed while handling response: {ex}");
                        }
                        finally
                        {
                            try
                            {
                                response.Close();
                            }
                            catch (Exception ex)
                            {
                                Logger.WriteLine($"HttpListener failed while closing response: {ex}");
                            }
                        }
                    }
                }
            }

            public abstract class Handler : IDisposable
            {
                private static int handlerId = 0;

                private TestServer _server;

                public Handler(TestServer server)
                {
                    _server = server;
                    Id = Interlocked.Increment(ref handlerId).ToString();
                    _server.RegisterHandler(this);
                }

                public string Id { get; }
                public string HttpPrefix => $"{_server.HttpPrefix}{Id}/";

                public string RemovePrefix(string s)
                {
                    var prefix = $"/{Id}/";
                    if (s.StartsWith(prefix))
                    {
                        return s.Substring(prefix.Length);
                    }
                    throw new InvalidOperationException("Doesn't start with prefix");
                }

                public List<RequestInfo> Requests { get; } = new List<RequestInfo>();

                public Task<IEnumerable<byte>> HandleCall0(
                    HttpListenerRequest request, HttpListenerResponse response)
                {
                    Requests.Add(new RequestInfo(request));
                    return HandleCall(request, response);
                }

                protected abstract Task<IEnumerable<byte>> HandleCall(
                    HttpListenerRequest request, HttpListenerResponse response);

                public void Dispose()
                {
                    _server.UnregisterHandler(Id);
                }
            }

            private ConcurrentDictionary<string, Handler> _handlers =
                new ConcurrentDictionary<string, Handler>();

            private Task<IEnumerable<byte>> HandleCall(
                HttpListenerRequest request, HttpListenerResponse response)
            {
                var id = request.Url.Segments[1].TrimEnd('/');
                var handler = _handlers[id];
                return handler.HandleCall0(request, response);
            }

            private void RegisterHandler(Handler handler)
            {
                _handlers.TryAdd(handler.Id, handler);
            }

            private void UnregisterHandler(string id)
            {
                Handler handler;
                _handlers.TryRemove(id, out handler);
            }

            public void Dispose()
            {
                var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(5));
                _httpTask.ContinueWith(task => timeout.Cancel());
                Task.Run(async () =>
                {
                    await new HttpClient().GetAsync(HttpPrefix + "Quit", timeout.Token);
                    _httpListener.Stop();
                });
                _httpTask.Wait();
            }
        }

    }
}
