using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    public class HttpListenerContext
    {
        public HttpListenerContext(HttpListenerRequest request, HttpListenerResponse response)
        {
            Request = request;
            Response = response;
        }

        public HttpListenerRequest Request { get; }

        public HttpListenerResponse Response { get; }
    }
}
