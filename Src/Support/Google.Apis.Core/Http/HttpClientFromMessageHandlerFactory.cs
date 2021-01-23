// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Util;
using System;
using System.Net.Http;

namespace Google.Apis.Http
{
    /// <summary>
    /// An implementation of <see cref="IHttpClientFactory"/> that allows
    /// for the inner message handler to be injected.
    /// </summary>
    public sealed class HttpClientFromMessageHandlerFactory : IHttpClientFactory
    {
        /// <summary>
        /// Factory for obtaining the underlying <see cref="HttpMessageHandler"/>
        /// of the <see cref="ConfigurableHttpClient"/> returned by
        /// <see cref="IHttpClientFactory.CreateHttpClient(CreateHttpClientArgs)"/>.
        /// Won't be null.
        /// </summary>
        private readonly Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler> _httpMessageHandlerFactory;

        /// <summary>
        /// Creates an <see cref="HttpClientFromMessageHandlerFactory"/> that will use
        /// the given <see cref="HttpMessageHandler"/> factory for creating the inner
        /// message handlers that will be used when creating the <see cref="ConfigurableHttpClient"/>.
        /// </summary>
        /// <remarks>
        /// The <see cref="HttpMessageHandler"/> obtained from the factory won't be disposed
        /// when the created <see cref="ConfigurableHttpClient"/> is. This allows calling code
        /// to control the handlers' lifetime and so they can possibly be reused.
        /// This may be a requirement for using System.Net.Http.IHttpMessageHandler. See
        /// https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests
        /// for information on why to use System.Net.Http.IHttpMessageHandler.
        /// </remarks>
        public HttpClientFromMessageHandlerFactory(Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler> httpMessageHandlerFactory) =>
            _httpMessageHandlerFactory = httpMessageHandlerFactory.ThrowIfNull(nameof(httpMessageHandlerFactory));

        /// <inheritdoc/>
        public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
        {
            var handler = CreateHandler(args);
            var configurableHandler = new ConfigurableMessageHandler(handler)
            {
                ApplicationName = args.ApplicationName,
                GoogleApiClientHeader = args.GoogleApiClientHeader
            };

            // We always set not to dispose the inner handler, it's not created
            // by us so we don't control it's lifetime.
            var client = new ConfigurableHttpClient(configurableHandler, false);
            foreach (var initializer in args.Initializers)
            {
                initializer.Initialize(client);
            }

            return client;
        }

        private HttpMessageHandler CreateHandler(CreateHttpClientArgs args)
        {
            // We need to handle three situations in order to intercept uncompressed data where necessary
            // while using the built-in decompression where possible.
            // - No compression requested
            // - Compression requested but not supported by the injected message handler
            //   (easy; just GzipDeflateHandler on top of an interceptor on top of HttpMessagetHandler)
            // - Compression requested and supported by the injected message handler
            //   (complex: create two different handlers and decide which to use on a per-request basis)

            // First request a message handler that may perform decompression or not depending on whether
            // GZip is enabled.
            var effectiveOptions = args.GZipEnabled ? 
                HttpMessageHandlerOptions.AllowDecompressionOptions :
                HttpMessageHandlerOptions.DisallowDecompressionOptions;
            var configuredMessageHandler = effectiveOptions.CheckItMatches(_httpMessageHandlerFactory(effectiveOptions));

            if (!effectiveOptions.MayPerformDecompression)
            {
                // Simple: nothing will be decompressing content, because we have a configured handler that does not
                // perform automatic decompression, so we can just intercept the original handler.
                return new StreamInterceptionHandler(configuredMessageHandler.MessageHandler);
            }
            else if (configuredMessageHandler.PerformsAutomaticDecompression)
            {
                // Complex: we want to use a simple handler with no interception but with built-in decompression
                // for requests that wouldn't perform interception anyway, and a longer chain for interception cases.

                var noCompressionMessageHandler = HttpMessageHandlerOptions.DisallowDecompressionOptions.CheckItMatches(
                    _httpMessageHandlerFactory(HttpMessageHandlerOptions.DisallowDecompressionOptions));

                return new TwoWayDelegatingHandler(
                    // Normal handler (with built-in decompression) when there's no interception.
                    configuredMessageHandler.MessageHandler,
                    // Alternative handler for requests that might be intercepted, and need that interception to happen
                    // before decompression.
                    new GzipDeflateHandler(new StreamInterceptionHandler(noCompressionMessageHandler.MessageHandler)),
                    request => StreamInterceptionHandler.GetInterceptorProvider(request) != null);
            }
            else
            {
                // Simple: we have to create our own decompression handler anyway, so there's still just a single chain.
                var interceptionHandler = new StreamInterceptionHandler(configuredMessageHandler.MessageHandler);
                return new GzipDeflateHandler(interceptionHandler);
            }
        }

        /// <summary>
        /// Specifies the configuration options for a message handler.
        /// </summary>
        public sealed class HttpMessageHandlerOptions
        {
            internal static readonly HttpMessageHandlerOptions AllowDecompressionOptions = new HttpMessageHandlerOptions(true, false);
            internal static readonly HttpMessageHandlerOptions DisallowDecompressionOptions = new HttpMessageHandlerOptions(false, false);

            /// <summary>
            /// Whether the message handler built from these options
            /// may perform automatic decompression or not.
            /// If set to true, the message handler may or may not perform automatic decompression.
            /// If set to false, the message handler must not perform automatic decompression.
            /// </summary>
            public bool MayPerformDecompression { get; }

            /// <summary>
            /// Whether the message handler built from these options
            /// may handle redirects or not. Redirects that are not handled
            /// should bubble up the handlers chain.
            /// If set to true, the message handler may or may not handle redirects.
            /// If set to false, the message handler must not handle redirects.
            /// </summary>
            public bool MayHandleRedirects { get; }

            private HttpMessageHandlerOptions(bool mayPerformDecompression, bool mayHandleRedirects)
            {
                MayPerformDecompression = mayPerformDecompression;
                MayHandleRedirects = mayHandleRedirects;
            }

            internal ConfiguredHttpMessageHandler CheckItMatches(ConfiguredHttpMessageHandler handler)
            {
                if (handler == null)
                {
                    throw new InvalidOperationException("The given HTTP message handler factory returned null.");
                }
                if (handler.MessageHandler == null)
                {
                    throw new InvalidOperationException(
                        $"The given HTTP message handler factory returned a null {nameof(ConfiguredHttpMessageHandler.MessageHandler)}.");
                }
                if (!MayPerformDecompression && handler.PerformsAutomaticDecompression)
                {
                    throw new InvalidOperationException(
                        "A handler that does not perform decompression was requested, but the HTTP message handler factory returned one that does.");
                }
                if (!MayHandleRedirects && handler.HandlesRedirects)
                {
                    throw new InvalidOperationException(
                        "A handler that does not handles redirects was requested, but the HTTP message handler factory returned one that does.");
                }
                return handler;
            }
        }

        /// <summary>
        /// Represents the already configured <see cref="HttpMessageHandler"/> to be used
        /// when building a <see cref="ConfigurableHttpClient"/> by the factory and
        /// information about the actual configuration.
        /// </summary>
        public sealed class ConfiguredHttpMessageHandler
        {
            /// <summary>
            /// The already configured <see cref="HttpMessageHandler"/> to be used
            /// when building a <see cref="ConfigurableHttpClient"/> by the factory.
            /// </summary>
            public HttpMessageHandler MessageHandler { get; }

            /// <summary>
            /// Whether <see cref="MessageHandler"/> is configured
            /// to perform automatic decompression or not.
            /// </summary>
            public bool PerformsAutomaticDecompression { get; }

            /// <summary>
            /// Whether <see cref="MessageHandler"/> is configured
            /// to handle redirects or not.
            /// </summary>
            public bool HandlesRedirects { get; }

            /// <summary>
            /// Builds a new <see cref="ConfiguredHttpMessageHandler"/> with the given parameters.
            /// </summary>
            public ConfiguredHttpMessageHandler(HttpMessageHandler messageHandler, bool performsAutomaticDecompression, bool handlesRedirect)
            {
                MessageHandler = messageHandler;
                PerformsAutomaticDecompression = performsAutomaticDecompression;
                HandlesRedirects = handlesRedirect;
            }
        }
    }
}
