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

using System.IO;

namespace System.Net
{
    public class HttpListenerResponse
    {
        public HttpListenerResponse(Action<HttpListenerResponse, byte[]> onClose)
        {
            _onClose = onClose;
            _outputStream = new MemoryStream();
            OutputStream = _outputStream;
        }

        private readonly Action<HttpListenerResponse, byte[]> _onClose;
        private readonly MemoryStream _outputStream;

        public string ContentType { get; set; } = "";
        public bool SendChunked { get; set; } = false;
        public int StatusCode { get; set; } = 200;
        public string StatusDescription { get; set; } = "OK";

        public WebHeaderCollection Headers { get; set; } = new WebHeaderCollection();

        public Stream OutputStream { get; }

        public void AddHeader(string name, string value) => Headers[name] = value;

        public void Close() => _onClose(this, _outputStream.ToArray());
    }
}

#elif NET452 || NET46
// Nothing required
#else
#error Unsupported platform
#endif
