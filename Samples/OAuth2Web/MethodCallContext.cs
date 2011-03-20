using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Google.Apis.Samples.OAuth2Web
{
    /// <summary>
    /// Provides a set of properties to store and recreate a particular Api method call.
    /// </summary>
    public class MethodCallContext
    {
        public string Service
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }

        public string Resource
        {
            get;
            set;
        }

        public string Method
        {
            get;
            set;
        }

        public Dictionary<string, string> Parameters
        {
            get;
            set;
        }
    }
}
