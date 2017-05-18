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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Google.Apis.Logging;

namespace Google.Apis.Http
{
    /// <summary>The default implementation of the HTTP client factory.</summary>
    public class HttpClientFactory : IHttpClientFactory
    {
        /// <summary>The class logger.</summary>
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<HttpClientFactory>();

        public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
        {
            // Create the handler.
            var handler = CreateHandler(args);
            var configurableHandler = new ConfigurableMessageHandler(handler)
                {
                    ApplicationName = args.ApplicationName
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
            var handler = new HttpClientHandler();

            // If the framework supports redirect configuration, set it to false, because ConfigurableMessageHandler 
            // handles redirect.
            if (handler.SupportsRedirectConfiguration)
            {
                handler.AllowAutoRedirect = false;
            }

            // If the framework supports automatic decompression and GZip is enabled, set automatic decompression.
            if (handler.SupportsAutomaticDecompression && args.GZipEnabled)
            {
                handler.AutomaticDecompression = System.Net.DecompressionMethods.GZip |
                    System.Net.DecompressionMethods.Deflate;
            }

            Logger.Debug("Handler was created. SupportsRedirectConfiguration={0}, SupportsAutomaticDecompression={1}",
                handler.SupportsRedirectConfiguration, handler.SupportsAutomaticDecompression);

            return handler;
        }
    }
}
