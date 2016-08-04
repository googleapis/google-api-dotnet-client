using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    public class HttpListenerException : Exception
    {
        public int ErrorCode { get { throw new NotImplementedException(); } }
    }
}
