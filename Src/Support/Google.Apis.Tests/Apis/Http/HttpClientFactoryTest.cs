using Google.Apis.Http;
using System.Net.Http;
using Xunit;

namespace Google.Apis.Tests.Apis.Http
{
    public class HttpClientFactoryTest
    {
        [Fact]
        public void TestCreateStreamInterceptionHandler()
        {
            var httpClientHandler = new TestHttpClientHandler(true);
            var httpClientFactory = new TestHttpClientFactory(httpClientHandler);

            var httpMessageHandler = httpClientFactory.AccessibleCreateHandler(new CreateHttpClientArgs());

            var streamInterceptionHandler = Assert.IsType<StreamInterceptionHandler>(httpMessageHandler);
            Assert.Equal(httpClientHandler, streamInterceptionHandler.InnerHandler);
        }

        [Fact]
        public void TestCreateGzipDeflateHandler()
        {
            var httpClientHandler = new TestHttpClientHandler(false);
            var httpClientFactory = new TestHttpClientFactory(httpClientHandler);

            var httpMessageHandler = httpClientFactory.AccessibleCreateHandler(new CreateHttpClientArgs
            {
                GZipEnabled = true,
            });

            var gzipDeflateHandler = Assert.IsType<GzipDeflateHandler>(httpMessageHandler);
            var streamInterceptionHandler = Assert.IsType<StreamInterceptionHandler>(gzipDeflateHandler.InnerHandler);
            Assert.Equal(httpClientHandler, streamInterceptionHandler.InnerHandler);
        }

        [Fact]
        public void TestCreateTwoWayDelegatingHandler()
        {
            var httpClientHandler = new TestHttpClientHandler(true);
            var httpClientFactory = new TestHttpClientFactory(httpClientHandler);

            var httpMessageHandler = httpClientFactory.AccessibleCreateHandler(new CreateHttpClientArgs
            {
                GZipEnabled = true,
            });

            var twoWayDelegatingHandler = Assert.IsType<TwoWayDelegatingHandler>(httpMessageHandler);
            Assert.Equal(httpClientHandler, twoWayDelegatingHandler.InnerHandler);
        }

        [Fact]
        public void TestCreateStreamInterceptionHandler_WithDelegatedHttpClientHandler()
        {
            var httpClientHandler = new TestDelegatingHandler(
                new TestDelegatingHandler(
                    new TestHttpClientHandler(true)
                )
            );
            var httpClientFactory = new TestHttpClientFactory(httpClientHandler);

            var httpMessageHandler = httpClientFactory.AccessibleCreateHandler(new CreateHttpClientArgs());

            var streamInterceptionHandler = Assert.IsType<StreamInterceptionHandler>(httpMessageHandler);
            Assert.Equal(httpClientHandler, streamInterceptionHandler.InnerHandler);
        }

        [Fact]
        public void TestCreateGzipDeflateHandler_WithDelegatedHttpClientHandler()
        {
            var httpClientHandler = new TestDelegatingHandler(
                new TestDelegatingHandler(
                    new TestHttpClientHandler(false)
                )
            );
            var httpClientFactory = new TestHttpClientFactory(httpClientHandler);

            var httpMessageHandler = httpClientFactory.AccessibleCreateHandler(new CreateHttpClientArgs
            {
                GZipEnabled = true,
            });

            var gzipDeflateHandler = Assert.IsType<GzipDeflateHandler>(httpMessageHandler);
            var streamInterceptionHandler = Assert.IsType<StreamInterceptionHandler>(gzipDeflateHandler.InnerHandler);
            Assert.Equal(httpClientHandler, streamInterceptionHandler.InnerHandler);
        }

        [Fact]
        public void TestCreateTwoWayDelegatingHandler_WithDelegatedHttpClientHandler()
        {
            var httpClientHandler = new TestDelegatingHandler(
                new TestDelegatingHandler(
                    new TestHttpClientHandler(true)
                )
            );
            var httpClientFactory = new TestHttpClientFactory(httpClientHandler);

            var httpMessageHandler = httpClientFactory.AccessibleCreateHandler(new CreateHttpClientArgs
            {
                GZipEnabled = true,
            });

            var twoWayDelegatingHandler = Assert.IsType<TwoWayDelegatingHandler>(httpMessageHandler);
            Assert.Equal(httpClientHandler, twoWayDelegatingHandler.InnerHandler);
        }

        private class TestHttpClientHandler : HttpClientHandler
        {
            public TestHttpClientHandler(bool supportsAutomaticDecompression)
            {
                SupportsAutomaticDecompression = supportsAutomaticDecompression;
            }

            public override bool SupportsAutomaticDecompression { get; }
        }

        private class TestDelegatingHandler : DelegatingHandler
        {
            public TestDelegatingHandler(HttpMessageHandler innerHandler) : base(innerHandler)
            {
            }
        }

        private class TestHttpClientFactory : HttpClientFactory
        {
            private readonly HttpMessageHandler _httpMessageHandler;

            public TestHttpClientFactory(HttpMessageHandler httpMessageHandler = null)
            {
                _httpMessageHandler = httpMessageHandler;
            }

            public HttpMessageHandler AccessibleCreateHandler(CreateHttpClientArgs args) => base.CreateHandler(args);

            protected override HttpMessageHandler CreateClientHandler()
            {
                return _httpMessageHandler ?? base.CreateClientHandler();
            }
        }
    }
}
