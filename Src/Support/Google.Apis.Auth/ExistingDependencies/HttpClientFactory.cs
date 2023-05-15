/*
Copyright 2013 Google Inc

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

using System.Net;
using System.Net.Http;

namespace Google.Apis.Http
{
    /// <summary>The default implementation of the HTTP client factory.</summary>
    public class HttpClientFactory : IHttpClientFactory
    {
        /// <summary>
        /// Creates a new instance of <see cref="HttpClientFactory"/> that
        /// will set the given proxy on HTTP clients created by this factory.
        /// </summary>
        /// <param name="proxy">The proxy to set on HTTP clients created by this factory.
        /// May be null, in which case no proxy will be used.</param>
        public static HttpClientFactory ForProxy(IWebProxy proxy) =>
            new HttpClientFactory(proxy);

        /// <summary>
        /// Creates a new instance of <see cref="HttpClientFactory"/>.
        /// </summary>
        public HttpClientFactory() : this(null)
        { }

        /// <summary>
        /// Creates a new instance of <see cref="HttpClientFactory"/> that
        /// will set the given proxy on HTTP clients created by this factory.
        /// </summary>
        /// <param name="proxy">The proxy to set on HTTP clients created by this factory.
        /// May be null, in which case no proxy will be used.</param>
        protected HttpClientFactory(IWebProxy proxy) => Proxy = proxy;

        /// <summary>
        /// Gets the proxy to use when creating HTTP clients, if any.
        /// May be null, in which case, no proxy will be set for HTTP clients
        /// created by this factory.
        /// </summary>
        public IWebProxy Proxy { get; }

        /// <inheritdoc/>
        public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
        {
            // Create the handler.
            var handler = CreateHandler(args);
            var configurableHandler = new ConfigurableMessageHandler(handler)
                {
                    ApplicationName = args.ApplicationName,
                    GoogleApiClientHeader = args.GoogleApiClientHeader
                };

            // Create the client.
            var client = new ConfigurableHttpClient(configurableHandler);
            foreach (var initializer in args.Initializers)
            {
                initializer.Initialize(client);
            }

            return client;
        }

        /// <summary>Creates a HTTP message handler. Override this method to mock a message handler.</summary>
        protected virtual HttpMessageHandler CreateHandler(CreateHttpClientArgs args)
        {
            // We need to handle three situations in order to intercept uncompressed data where necessary
            // while using the built-in decompression where possible.
            // - No compression requested
            // - Compression requested but not supported by HttpClientHandler (easy; just GzipDeflateHandler on top of an interceptor on top of HttpClientHandler)
            // - Compression requested and HttpClientHandler (complex: create two different handlers and decide which to use on a per-request basis)

            var clientHandler = CreateAndConfigureClientHandler();

            if (!args.GZipEnabled)
            {
                // Simple: nothing will be decompressing content, so we can just intercept the original handler.
                return new StreamInterceptionHandler(clientHandler);
            }
            else if (!clientHandler.SupportsAutomaticDecompression)
            {
                // Simple: we have to create our own decompression handler anyway, so there's still just a single chain.
                var interceptionHandler = new StreamInterceptionHandler(clientHandler);
                return new GzipDeflateHandler(interceptionHandler);
            }
            else
            {
                // Complex: we want to use a simple handler with no interception but with built-in decompression
                // for requests that wouldn't perform interception anyway, and a longer chain for interception cases.
                clientHandler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

                return new TwoWayDelegatingHandler(
                    // Normal handler (with built-in decompression) when there's no interception.
                    clientHandler,
                    // Alternative handler for requests that might be intercepted, and need that interception to happen
                    // before decompression. We need to delegate to a new client handler that *doesn't* 
                    new GzipDeflateHandler(new StreamInterceptionHandler(CreateAndConfigureClientHandler())),
                    request => StreamInterceptionHandler.GetInterceptorProvider(request) != null);
            }
        }

        /// <summary>
        /// Creates a simple client handler with redirection and compression disabled.
        /// </summary>
        private HttpClientHandler CreateAndConfigureClientHandler()
        {
            var handler = CreateClientHandler();
            if (handler.SupportsRedirectConfiguration)
            {
                handler.AllowAutoRedirect = false;
            }
            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = DecompressionMethods.None;
            }
            return handler;
        }

        /// <summary>
        /// Create a <see cref="HttpClientHandler"/> for use when communicating with the server.
        /// Please read the remarks closely before overriding this method.
        /// </summary>
        /// <remarks>
        /// When overriding this method, please observe the following:
        /// <list type="bullet">
        /// <item><description>
        /// <see cref="HttpClientHandler.AllowAutoRedirect"/> and
        /// <see cref="HttpClientHandler.AutomaticDecompression"/>
        /// of the returned instance are configured after this method returns.
        /// Configuring these within this method will have no effect.
        /// </description></item>
        /// <item><description>
        /// <see cref="HttpClientHandler.Proxy"/> is set in this method to <see cref="Proxy"/>
        /// if <see cref="Proxy"/> value is not null. You may override that behaviour.
        /// </description></item>
        /// <item><description>
        /// Return a new instance of an <see cref="HttpClientHandler"/> for each call to this method.
        /// </description></item>
        /// <item><description>
        /// This method may be called once, or more than once, when initializing a single client service.
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <returns>A suitable <see cref="HttpClientHandler"/>.</returns>
        protected virtual HttpClientHandler CreateClientHandler()
        {
            var client = new HttpClientHandler();
            if (Proxy != null)
            {
                client.Proxy = Proxy;
            }
            return client;
        }
    }
}
