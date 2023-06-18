using Google.Apis.Http;
using System;

namespace Google.Apis.Auth.ExistingDependencies;

/// <summary>
/// Default implementation of IHttpClientFactory just for auth.
/// Avoids us requiring the full HttpClientFactory.
/// </summary>
internal class AuthHttpClientFactory : IHttpClientFactory
{
    public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
    {
        throw new NotImplementedException();
    }
}
