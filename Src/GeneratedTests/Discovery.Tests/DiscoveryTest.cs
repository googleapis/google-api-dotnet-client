using Google.Apis.Http;
using Google.Apis.Services;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace Google.Apis.Discovery.v1.Tests
{
    [TestFixture]
    public class DiscoveryTest
    {
        class FakeHttpMessageHandler : ConfigurableMessageHandler
        {
            public FakeHttpMessageHandler(Dictionary<string, HttpContent> data) : base(new HttpClientHandler())
            {
                _data = data;
            }

            private Dictionary<string, HttpContent> _data;

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var result = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = _data[request.RequestUri.AbsolutePath]
                };
                return Task.FromResult(result);
            }
        }

        class FakeHttpClientFactory : IHttpClientFactory
        {
            public FakeHttpClientFactory(Dictionary<string, HttpContent> data)
            {
                _data = data;
            }

            private Dictionary<string, HttpContent> _data;

            public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
            {
                return new ConfigurableHttpClient(new FakeHttpMessageHandler(_data));
            }
        }

        [Test]
        public async Task TestUrlShortenerRef()
        {
            // Test that the "$ref" names as used by the discovery API are treated as normal names by the JSON deserializer.
            // This is the first test of a generated library.
            var urlShortenerStream = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Discovery.Tests.resources.urlshortener.json");
            var data = new Dictionary<string, HttpContent>
            {
                { "/discovery/v1/apis/urlshortener/v1/rest", new StreamContent(urlShortenerStream) }
            };
            var initializer = new BaseClientService.Initializer
            {
                HttpClientFactory = new FakeHttpClientFactory(data)
            };
            var service = new DiscoveryService(initializer);
            var urlshortener = await service.Apis.GetRest("urlshortener", "v1").ExecuteAsync();
            Assert.That(urlshortener.Id, Is.EqualTo("urlshortener:v1"));
            Assert.That(urlshortener.Schemas["AnalyticsSnapshot"].Properties["browsers"].Items.Ref__, Is.EqualTo("StringCount"));
        }
    }
}
