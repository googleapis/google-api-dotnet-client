using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
