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

#if NETCOREAPP1_0 || NETCOREAPP1_1

using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System.Net
{
    public class HttpListener : IDisposable
    {
        private static readonly Regex s_prefixRegex = new Regex(@"^http://([\w.-]+):(\d+)(.*)$");

        public IList<string> Prefixes { get; } = new List<string>();

        private TcpListener _listener = null;

        public void Start()
        {
            if (Prefixes.Count != 1)
            {
                throw new InvalidOperationException("Only supports a single prefix");
            }
            var match = s_prefixRegex.Match(Prefixes[0]);
            if (match == null)
            {
                throw new InvalidOperationException("Prefix formed incorrectly");
            }
            var host = match.Groups[1].Value;
            var port = int.Parse(match.Groups[2].Value);
            var path = match.Groups[3].Value;
            // Hardcoded to "localhost" as that's all we need for testing
            _listener = new TcpListener(new IPEndPoint(IPAddress.Loopback, port));
            _listener.Start();
        }

        public void Stop()
        {
            if (_listener != null)
            {
                _listener.Stop();
                _listener = null;
            }
        }

        private void SendHttpResponse(TcpClient client, Stream stream, HttpListenerResponse response, byte[] body)
        {
            // Status line
            var statusLine = $"HTTP/1.1 {response.StatusCode} {response.StatusDescription}\r\n";
            var statusBytes = Encoding.ASCII.GetBytes(statusLine);
            stream.Write(statusBytes, 0, statusBytes.Length);
            // Headers
            foreach (var key in response.Headers.AllKeys)
            {
                var value = response.Headers[key];
                var line = $"{key}: {value}\r\n";
                var lineBytes = Encoding.ASCII.GetBytes(line);
                stream.Write(lineBytes, 0, lineBytes.Length);
            }
            // Content-Type header
            var contentType = Encoding.ASCII.GetBytes($"Content-Type: {response.ContentType}\r\n");
            stream.Write(contentType, 0, contentType.Length);
            // Content-Length header
            var contentLength = Encoding.ASCII.GetBytes($"Content-Length: {body.Length}\r\n");
            stream.Write(contentLength, 0, contentLength.Length);
            // "Connection: close", to tell the client we can't handle persistent TCP connections
            var connection = Encoding.ASCII.GetBytes("Connection: close\r\n");
            stream.Write(connection, 0, connection.Length);
            // Blank line to indicate end of headers
            stream.Write(new[] { (byte)'\r', (byte)'\n' }, 0, 2);
            // Body
            stream.Write(body, 0, body.Length);
            stream.Flush();
            // Graceful socket shutdown
            client.Client.Shutdown(SocketShutdown.Both);
            client.Dispose();
        }

        public async Task<HttpListenerContext> GetContextAsync()
        {
            var client = await _listener.AcceptTcpClientAsync().ConfigureAwait(false);
            var stream = client.GetStream();
            var request = await HttpListenerRequest.Build(stream).ConfigureAwait(false);
            var response = new HttpListenerResponse((resp, body) => SendHttpResponse(client, stream, resp, body));
            var context = new HttpListenerContext(request, response);
            return context;
        }

        public bool IsListening => _listener != null;

        public bool IgnoreWriteExceptions { get; set; }

        public void Close() => Stop();

        public void Dispose() => Stop();
    }
}

#elif NET452 || NET46
// Nothing required
#else
#error Unsupported platform
#endif
