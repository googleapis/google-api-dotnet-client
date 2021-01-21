using System;
using System.Net.Http;

namespace Google.Apis.Http
{
    /// <summary>Throws when <see cref="HttpClientFactory.GetHttpClientHandler"/> cannot resolve <see cref="HttpClientHandler"/></summary>
    public class UnableToResolveHttpClientHandlerException : Exception
    {
        /// <summary>A handler on which was <see cref="HttpClientHandler"/> not found</summary>
        public HttpMessageHandler HttpMessageHandler { get; }

        /// <summary>Creates an exception.</summary>
        public UnableToResolveHttpClientHandlerException(HttpMessageHandler httpMessageHandler)
        {
            HttpMessageHandler = httpMessageHandler;
        }
    }
}
