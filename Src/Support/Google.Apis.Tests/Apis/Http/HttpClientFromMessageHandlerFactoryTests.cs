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

using Google.Apis.Http;
using Google.Apis.Tests.Mocks;
using System;
using System.Collections.Generic;
using Xunit;
using static Google.Apis.Http.HttpClientFromMessageHandlerFactory;

namespace Google.Apis.Tests.Apis.Http
{
    public class HttpClientFromMessageHandlerFactoryTests
    {
        public static IEnumerable<object[]> HttpMessageHandlerOptions_InstancesData
        {
            get
            {
                // At the moment we don't allow redirects.
                yield return new object[] { HttpMessageHandlerOptions.AllowDecompressionOptions, false, true };
                yield return new object[] { HttpMessageHandlerOptions.DisallowDecompressionOptions, false, false };
            }
        }

        [Theory]
        [MemberData(nameof(HttpMessageHandlerOptions_InstancesData))]
        public void HttpMessageHandlerOptions_Instances(HttpMessageHandlerOptions options, bool expectedRedirects, bool expectedDecompression)
        {
            Assert.Equal(expectedRedirects, options.MayHandleRedirects);
            Assert.Equal(expectedDecompression, options.MayPerformDecompression);
        }

        public static IEnumerable<object[]> HttpMessageHandlerOptions_MatchesData
        {
            get
            {
                // We don't care what this is as long as it is not null.
                // We don't actually inspect the returned message handler,
                // just the declaration of how it is configured.
                var mockHandler = new MockMessageHandler();
                // At the moment we don't allow redirects.
                yield return new object[] { HttpMessageHandlerOptions.AllowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, true, false) };
                yield return new object[] { HttpMessageHandlerOptions.AllowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, false, false) };
                yield return new object[] { HttpMessageHandlerOptions.DisallowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, false, false) };
            }
        }

        [Theory]
        [MemberData(nameof(HttpMessageHandlerOptions_MatchesData))]
        public void HttpMessageHandlerOptions_Matches(HttpMessageHandlerOptions options, ConfiguredHttpMessageHandler configuredHandler) =>
            Assert.Same(configuredHandler, options.CheckItMatches(configuredHandler));

        public static IEnumerable<object[]> HttpMessageHandlerOptions_DoesNotMatchData
        {
            get
            {
                var mockHandler = new MockMessageHandler();
                // At the moment we don't allow redirects.
                yield return new object[] { HttpMessageHandlerOptions.AllowDecompressionOptions, null };
                yield return new object[] { HttpMessageHandlerOptions.AllowDecompressionOptions, new ConfiguredHttpMessageHandler(null, true, false) };
                yield return new object[] { HttpMessageHandlerOptions.AllowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, true, true) };
                yield return new object[] { HttpMessageHandlerOptions.DisallowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, true, false) };
                yield return new object[] { HttpMessageHandlerOptions.DisallowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, false, true) };
                yield return new object[] { HttpMessageHandlerOptions.DisallowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, true, true) };
            }
        }

        [Theory]
        [MemberData(nameof(HttpMessageHandlerOptions_DoesNotMatchData))]
        public void HttpMessageHandlerOptions_DoesNotMatch(HttpMessageHandlerOptions options, ConfiguredHttpMessageHandler configuredHandler) =>
            Assert.Throws<InvalidOperationException>(() => options.CheckItMatches(configuredHandler));


        public static IEnumerable<object[]> HttpClientFromMessageHandlerFactory_CreateClientData
        {
            get
            {
                // We don't care what this is as long as it is not null.
                // We don't actually inspect the returned message handler,
                // just the declaration of how it is configured.
                var mockHandler = new MockMessageHandler();
                // At the moment we don't allow redirects.
                yield return new object[] { HttpMessageHandlerOptions.AllowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, true, false) };
                yield return new object[] { HttpMessageHandlerOptions.AllowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, false, false) };
                yield return new object[] { HttpMessageHandlerOptions.DisallowDecompressionOptions, new ConfiguredHttpMessageHandler(mockHandler, false, false) };
            }
        }

        public static IEnumerable<object[]> HttpClientFromMessageHandlerFactory_BadMessageHandlerFactoryData
        {
            get
            {
                var mockHandler = new MockMessageHandler();
                var nullHandler = new ConfiguredHttpMessageHandler(null, false, false);
                var redirectsHandler = new ConfiguredHttpMessageHandler(mockHandler, false, true);
                var compressionHandler = new ConfiguredHttpMessageHandler(mockHandler, true, false);

                yield return new object[] { (Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler>)(options => null), false };
                yield return new object[] { (Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler>)(options => null), true };
                yield return new object[] { (Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler>)(options => nullHandler), false };
                yield return new object[] { (Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler>)(options => nullHandler), true };
                yield return new object[] { (Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler>)(options => redirectsHandler), false };
                yield return new object[] { (Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler>)(options => redirectsHandler), true };
                yield return new object[] { (Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler>)(options => compressionHandler), false };
                // When the service and the first handler support decompression we ask for a second handler that doesn't support decompression.
                yield return new object[] { (Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler>)(options => compressionHandler), true };
            }
        }

        [Theory]
        [MemberData(nameof(HttpClientFromMessageHandlerFactory_BadMessageHandlerFactoryData))]
        public void HttpClientFromMessageHandlerFactory_BadMessageHandlerFactory(
            Func<HttpMessageHandlerOptions, ConfiguredHttpMessageHandler> handlerFactory, bool gZipEnabled)
        {
            var clientFactory = new HttpClientFromMessageHandlerFactory(handlerFactory);
            Assert.Throws<InvalidOperationException>(() => clientFactory.CreateHttpClient(new CreateHttpClientArgs { GZipEnabled = gZipEnabled }));
        }

        [Fact]
        public void HttpClientFromMessageHandlerFactory_NoCompression()
        {
            int handlerFactoryCalled = 0;
            var clientFactory = new HttpClientFromMessageHandlerFactory(MessageHandlerFactory);
            Assert.NotNull(clientFactory.CreateHttpClient(new CreateHttpClientArgs { GZipEnabled = false }));

            ConfiguredHttpMessageHandler MessageHandlerFactory(HttpMessageHandlerOptions options)
            {
                handlerFactoryCalled++;
                Assert.False(options.MayHandleRedirects);
                Assert.False(options.MayPerformDecompression);

                return new ConfiguredHttpMessageHandler(new MockMessageHandler(), false, false);
            }

            Assert.Equal(1, handlerFactoryCalled);
        }

        [Fact]
        public void HttpClientFromMessageHandlerFactory_ServiceCompression_HandlerNoCompression()
        {
            int handlerFactoryCalled = 0;
            var clientFactory = new HttpClientFromMessageHandlerFactory(MessageHandlerFactory);
            Assert.NotNull(clientFactory.CreateHttpClient(new CreateHttpClientArgs { GZipEnabled = true }));

            ConfiguredHttpMessageHandler MessageHandlerFactory(HttpMessageHandlerOptions options)
            {
                handlerFactoryCalled++;
                Assert.False(options.MayHandleRedirects);
                Assert.True(options.MayPerformDecompression);

                return new ConfiguredHttpMessageHandler(new MockMessageHandler(), false, false);
            }

            Assert.Equal(1, handlerFactoryCalled);
        }

        [Fact]
        public void HttpClientFromMessageHandlerFactory_Compression()
        {
            int handlerFactoryCalled = 0;
            var clientFactory = new HttpClientFromMessageHandlerFactory(MessageHandlerFactory);
            Assert.NotNull(clientFactory.CreateHttpClient(new CreateHttpClientArgs { GZipEnabled = true }));

            ConfiguredHttpMessageHandler MessageHandlerFactory(HttpMessageHandlerOptions options)
            {
                handlerFactoryCalled++;
                if (handlerFactoryCalled == 1)
                {
                    Assert.False(options.MayHandleRedirects);
                    Assert.True(options.MayPerformDecompression);

                    return new ConfiguredHttpMessageHandler(new MockMessageHandler(), true, false);
                }
                else
                {
                    Assert.False(options.MayHandleRedirects);
                    Assert.False(options.MayPerformDecompression);

                    return new ConfiguredHttpMessageHandler(new MockMessageHandler(), false, false);
                }
            }

            Assert.Equal(2, handlerFactoryCalled);
        }
    }
}
