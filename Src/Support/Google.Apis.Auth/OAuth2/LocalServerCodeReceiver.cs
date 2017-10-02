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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 verification code receiver that runs a local server on a free port and waits for a call with the 
    /// authorization verification code.
    /// </summary>
    public class LocalServerCodeReceiver : ICodeReceiver
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<LocalServerCodeReceiver>();

        /// <summary>The call back request path.</summary>
        internal const string LoopbackCallbackPath = "/authorize/";

        /// <summary>Localhost callback URI, expects a port parameter.</summary>
        internal static readonly string CallbackUriTemplateLocalhost = $"http://localhost:{{0}}{LoopbackCallbackPath}";
        /// <summary>127.0.0.1 callback URI, expects a port parameter.</summary>
        internal static readonly string CallbackUriTemplate127001 = $"http://127.0.0.1:{{0}}{LoopbackCallbackPath}";

        /// <summary>Close HTML tag to return the browser so it will close itself.</summary>
        internal const string ClosePageResponse =
@"<html>
  <head><title>OAuth 2.0 Authentication Token Received</title></head>
  <body>
    Received verification code. You may now close this window.
    <script type='text/javascript'>
      // This doesn't work on every browser.
      window.setTimeout(function() {
          this.focus();
          window.opener = this;
          window.open('', '_self', ''); 
          window.close(); 
        }, 1000);
      //if (window.opener) { window.opener.checkToken(); }
    </script>
  </body>
</html>";

        private static object s_lock = new object();
        // Current best-guess as to most suitable callback URI.
        private static string s_callbackUriTemplate;
        // Has a successful callback been received?
        private static bool s_receivedCallback;

        /// <summary>
        /// Create an instance of <see cref="LocalServerCodeReceiver"/>.
        /// </summary>
        public LocalServerCodeReceiver()
        {
            lock (s_lock)
            {
                // Listening on 127.0.0.1 is recommended, but can't be done in non-admin Windows 7 & 8.
                // So use some tests/heuristics so maybe listen on localhost instead.
                if (s_callbackUriTemplate != null && !s_receivedCallback)
                {
                    // On non-first runs, if a successful callback has not been received
                    // then force callback to use localhost rather than 127.0.0.1
                    // This is to heuristically avoid errors on browsers that can't connect to 127.0.0.1
                    // E.g. IE11 in enhanced protection mode.
                    s_callbackUriTemplate = CallbackUriTemplateLocalhost;
                }
                if (s_callbackUriTemplate == null)
                {
                    s_callbackUriTemplate = CallbackUriTemplate127001;
#if NETSTANDARD1_3
                    // No check required on NETStandard, it uses TcpListener which can only use IP adddresses, not DNS names.
#elif NET45
                    // On first run, check whether it's possible to start a listener on 127.0.0.1
                    // This fails on Windows 7 and 8, for non-admin users.
                    try
                    {
                        // This listener isn't used for anything except to check if it can listen on 127.0.0.1
                        // Hence it is disposed immediately.
                        using (var listener = new HttpListener())
                        {
                            listener.Prefixes.Add(string.Format(CallbackUriTemplate127001, GetRandomUnusedPort()));
                            listener.Start();
                        }
                    }
                    catch (HttpListenerException e) when (e.ErrorCode == 5) // 5: Access denied
                    {
                        // Access denied for 127.0.0.1, so use localhost
                        s_callbackUriTemplate = CallbackUriTemplateLocalhost;
                    }
                    catch
                    {
                        // Ignore any errors in the constructor, they will re-occur later.
                    }
#else
#error Unsupported target
#endif

                }
                // Set the instance field of which callback URI to use.
                // An instance field is used to ensure any one instance of this class
                // uses a consistent callback URI.
                _callbackUriTemplate = s_callbackUriTemplate;
            }
        }

        // Callback URI used for this instance.
        private string _callbackUriTemplate;

        // Not required in NET45, but present for testing.
        /// <summary>
        /// An extremely limited HTTP server that can only do exactly what is required
        /// for this use-case.
        /// It can only serve localhost; receive a single GET request; read only the query paremters;
        /// send back a fixed response. Nothing else.
        /// </summary>
        internal class LimitedLocalhostHttpServer : IDisposable
        {
            private const int MaxRequestLineLength = 256;
            private const int MaxHeadersLength = 8192;
            private const int NetworkReadBufferSize = 1024;

            private static ILogger Logger = ApplicationContext.Logger.ForType<LimitedLocalhostHttpServer>();

            public class ServerException : Exception
            {
                public ServerException(string msg) : base(msg) { }
            }

            public static LimitedLocalhostHttpServer Start(string url)
            {
                var uri = new Uri(url);
                if (!uri.IsLoopback)
                {
                    throw new ArgumentException($"Url must be loopback, but given: '{url}'", nameof(url));
                }
                var listener = new TcpListener(IPAddress.Loopback, uri.Port);
                return new LimitedLocalhostHttpServer(listener);
            }

            private LimitedLocalhostHttpServer(TcpListener listener)
            {
                _listener = listener;
                _cts = new CancellationTokenSource();
                _listener.Start();
                Port = ((IPEndPoint)_listener.LocalEndpoint).Port;
            }

            private readonly TcpListener _listener;
            private readonly CancellationTokenSource _cts;

            public int Port { get; }

            public async Task<Dictionary<string, string>> GetQueryParamsAsync(CancellationToken cancellationToken = default(CancellationToken))
            {
                var ct = CancellationTokenSource.CreateLinkedTokenSource(_cts.Token, cancellationToken).Token;
                using (TcpClient client = await _listener.AcceptTcpClientAsync().ConfigureAwait(false))
                {
                    try
                    {
                        return await GetQueryParamsFromClientAsync(client, ct).ConfigureAwait(false);
                    }
                    catch (ServerException e)
                    {
                        Logger.Warning("{0}", e.Message);
                        throw;
                    }
                }
            }

            private async Task<Dictionary<string, string>> GetQueryParamsFromClientAsync(TcpClient client, CancellationToken cancellationToken)
            {
                var stream = client.GetStream();

                var buffer = new byte[NetworkReadBufferSize];
                int bufferOfs = 0;
                int bufferSize = 0;
                Func<Task<char?>> getChar = async () =>
                {
                    if (bufferOfs == bufferSize)
                    {
                        bufferSize = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken).ConfigureAwait(false);
                        if (bufferSize == 0)
                        {
                            // End of stream
                            return null;
                        }
                        bufferOfs = 0;
                    }
                    byte b = buffer[bufferOfs++];
                    // HTTP headers are generally ASCII, but historically allowed ISO-8859-1.
                    // Non-ASCII bytes should be treated opaquely, not further processed (e.g. as UTF8).
                    return (char)b;
                };

                string requestLine = await ReadRequestLine(getChar).ConfigureAwait(false);
                var requestParams = ValidateAndGetRequestParams(requestLine);
                await WaitForAllHeaders(getChar).ConfigureAwait(false);
                await WriteResponse(stream, cancellationToken).ConfigureAwait(false);

                return requestParams;
            }

            private async Task<string> ReadRequestLine(Func<Task<char?>> getChar)
            {
                var requestLine = new StringBuilder(MaxRequestLineLength);
                do
                {
                    if (requestLine.Length >= MaxRequestLineLength)
                    {
                        throw new ServerException($"Request line too long: > {MaxRequestLineLength} bytes.");
                    }
                    char? c = await getChar().ConfigureAwait(false);
                    if (c == null)
                    {
                        throw new ServerException("Unexpected end of network stream reading request line.");
                    }
                    requestLine.Append(c);
                } while (requestLine.Length < 2 || requestLine[requestLine.Length - 2] != '\r' || requestLine[requestLine.Length - 1] != '\n');
                requestLine.Length -= 2; // Remove \r\n
                return requestLine.ToString();
            }

            private Dictionary<string, string> ValidateAndGetRequestParams(string requestLine)
            {
                var requestLineParts = requestLine.Split(' ');
                if (requestLineParts.Length != 3)
                {
                    throw new ServerException("Request line ill-formatted. Should be '<request-method> <request-path> HTTP/1.1'");
                }
                string requestVerb = requestLineParts[0];
                if (requestVerb != "GET")
                {
                    throw new ServerException($"Expected 'GET' request, got '{requestVerb}'");
                }
                string requestPath = requestLineParts[1];
                if (!requestPath.StartsWith(LoopbackCallbackPath))
                {
                    throw new ServerException($"Expected request path to start '{LoopbackCallbackPath}', got '{requestPath}'");
                }
                var pathParts = requestPath.Split('?');
                if (pathParts.Length == 1)
                {
                    return new Dictionary<string, string>();
                }
                if (pathParts.Length != 2)
                {
                    throw new ServerException($"Expected a single '?' in request path, got '{requestPath}'");
                }
                var queryParams = pathParts[1];
                var result = queryParams.Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries).Select(param =>
                {
                    var keyValue = param.Split('=');
                    if (keyValue.Length > 2)
                    {
                        throw new ServerException($"Invalid query parameter: '{param}'");
                    }
                    var key = WebUtility.UrlDecode(keyValue[0]);
                    var value = keyValue.Length == 2 ? WebUtility.UrlDecode(keyValue[1]) : "";
                    return new { key, value };
                }).ToDictionary(x => x.key, x => x.value);
                return result;
            }

            private async Task WaitForAllHeaders(Func<Task<char?>> getChar)
            {
                // Looking for an empty line, terminated by \r\n
                int byteCount = 0;
                int lineLength = 0;
                char c0 = '\0';
                char c1 = '\0';
                while (true)
                {
                    if (byteCount > MaxHeadersLength)
                    {
                        throw new ServerException($"Headers too long: > {MaxHeadersLength} bytes.");
                    }
                    char? c = await getChar().ConfigureAwait(false);
                    if (c == null)
                    {
                        throw new ServerException("Unexpected end of network stream waiting for headers.");
                    }
                    c0 = c1;
                    c1 = (char)c;
                    lineLength += 1;
                    byteCount += 1;
                    if (c0 == '\r' && c1 == '\n')
                    {
                        // End of line
                        if (lineLength == 2)
                        {
                            return;
                        }
                        lineLength = 0;
                    }
                }
            }

            private async Task WriteResponse(NetworkStream stream, CancellationToken cancellationToken)
            {
                string fullResponse = $"HTTP/1.1 200 OK\r\n\r\n{ClosePageResponse}";
                var response = Encoding.ASCII.GetBytes(fullResponse);
                await stream.WriteAsync(response, 0, response.Length, cancellationToken).ConfigureAwait(false);
                await stream.FlushAsync(cancellationToken).ConfigureAwait(false);
            }

            public void Dispose()
            {
                _cts.Cancel();
                _listener.Stop();
            }
        }

        // There is a race condition on the port used for the loopback callback.
        // This is not good, but is now difficult to change due to RedirectUri and ReceiveCodeAsync
        // being public methods.

        private string redirectUri;
        /// <inheritdoc />
        public string RedirectUri
        {
            get
            {
                if (string.IsNullOrEmpty(redirectUri))
                {
                    redirectUri = string.Format(_callbackUriTemplate, GetRandomUnusedPort());
                }
                return redirectUri;
            }
        }

        /// <inheritdoc />
        public async Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url,
            CancellationToken taskCancellationToken)
        {
            var authorizationUrl = url.Build().AbsoluteUri;
            // The listener type depends on platform:
            // * .NET desktop: System.Net.HttpListener
            // * .NET Core: LimitedLocalhostHttpServer (above, HttpListener is not available in any version of netstandard)
            using (var listener = StartListener())
            {
                Logger.Debug("Open a browser with \"{0}\" URL", authorizationUrl);
                bool browserOpenedOk;
                try
                {
                    browserOpenedOk = OpenBrowser(authorizationUrl);
                }
                catch (Exception e)
                {
                    Logger.Error(e, "Failed to launch browser with \"{0}\" for authorization", authorizationUrl);
                    throw new NotSupportedException(
                        $"Failed to launch browser with \"{authorizationUrl}\" for authorization. See inner exception for details.", e);
                }
                if (!browserOpenedOk)
                {
                    Logger.Error("Failed to launch browser with \"{0}\" for authorization; platform not supported.", authorizationUrl);
                    throw new NotSupportedException(
                        $"Failed to launch browser with \"{authorizationUrl}\" for authorization; platform not supported.");
                }

                var ret = await GetResponseFromListener(listener, taskCancellationToken).ConfigureAwait(false);

                // Note that a successful callback has been received.
                s_receivedCallback = true;

                return ret;
            }
        }

        /// <summary>Returns a random, unused port.</summary>
        private static int GetRandomUnusedPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            try
            {
                listener.Start();
                return ((IPEndPoint)listener.LocalEndpoint).Port;
            }
            finally
            {
                listener.Stop();
            }
        }

#if NETSTANDARD1_3
        private LimitedLocalhostHttpServer StartListener() => LimitedLocalhostHttpServer.Start(RedirectUri);

        private async Task<AuthorizationCodeResponseUrl> GetResponseFromListener(LimitedLocalhostHttpServer server, CancellationToken ct)
        {
            var queryParams = await server.GetQueryParamsAsync(ct).ConfigureAwait(false);

            // Create a new response URL with a dictionary that contains all the response query parameters.
            return new AuthorizationCodeResponseUrl(queryParams);
        }

        private bool OpenBrowser(string url)
        {
            // See https://github.com/dotnet/corefx/issues/10361
            // This is best-effort only, but should work most of the time.
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // See https://stackoverflow.com/a/6040946/44360 for why this is required
                url = System.Text.RegularExpressions.Regex.Replace(url, @"(\\*)" + "\"", @"$1$1\" + "\"");
                url = System.Text.RegularExpressions.Regex.Replace(url, @"(\\+)$", @"$1$1");
                Process.Start(new ProcessStartInfo("cmd", $"/c start \"\" \"{url}\"") { CreateNoWindow = true });
                return true;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
                return true;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
                return true;
            }
            return false;
        }
#elif NET45
        private HttpListener StartListener()
        {
            var listener = new HttpListener();
            listener.Prefixes.Add(RedirectUri);
            listener.Start();
            return listener;
        }

        private async Task<AuthorizationCodeResponseUrl> GetResponseFromListener(HttpListener listener, CancellationToken ct)
        {
            HttpListenerContext context;
            // Set up cancellation. HttpListener.GetContextAsync() doesn't accept a cancellation token,
            // the HttpListener needs to be stopped which immediately aborts the GetContextAsync() call.
            using (ct.Register(listener.Stop))
            {
                // Wait to get the authorization code response.
                try
                {
                    context = await listener.GetContextAsync().ConfigureAwait(false);
                }
                catch (Exception) when (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                    // Next line will never be reached because cancellation will always have been requested in this catch block.
                    // But it's required to satisfy compiler.
                    throw new InvalidOperationException();
                }
            }
            NameValueCollection coll = context.Request.QueryString;

            // Write a "close" response.
            var bytes = Encoding.UTF8.GetBytes(ClosePageResponse);
            context.Response.ContentLength64 = bytes.Length;
            context.Response.SendChunked = false;
            context.Response.KeepAlive = false;
            var output = context.Response.OutputStream;
            await output.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
            await output.FlushAsync().ConfigureAwait(false);
            output.Close();
            context.Response.Close();

            // Create a new response URL with a dictionary that contains all the response query parameters.
            return new AuthorizationCodeResponseUrl(coll.AllKeys.ToDictionary(k => k, k => coll[k]));
        }

        private bool OpenBrowser(string url)
        {
            Process.Start(url);
            return true;
        }
#else
#error Unsupported target
#endif
    }
}
