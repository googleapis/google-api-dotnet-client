/*
Copyright 2022 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Util;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    public partial class AwsExternalAccountCredential
    {
        /// <summary>
        /// Helper class for querying the AWS Metadata Server.
        /// It will fetch and use the sesion token if required.
        /// </summary>
        private sealed class AwsMetadataServerClient
        {
            private const string AwsMetadataServerHostV4 = "169.254.169.254";
            private const string AwsMetadataServerHostV6 = "fd00:ec2::254";

            private const string ImdsV2SessionTokenTtlHeaderName = "X-aws-ec2-metadata-token-ttl-seconds";
            // Only one hour which should be enough for accessing the metadata server to obtaine the data
            // we need to generate one subject token. It could possibly be way less, but let's be conservatives
            // as a start.
            private const string ImdsV2SessionTokenTtlSeconds = "3600";

            private const string MetatadaServerRequestImdsV2SessionTokenHeaderName = "X-aws-ec2-metadata-token";

            private readonly string _imdsV2SessionTokenUrl;
            private readonly Lazy<Task<string>> _imdsV2SessionToken;
            private readonly HttpClient _httpClient;
            private readonly CancellationToken _cancellationToken;

            internal AwsMetadataServerClient(string imdsV2SessionTokenUrl, HttpClient httpClient, CancellationToken cancellationToken)
            {
                // Please do not change this constructor to trigger any requests, as created instances
                // may not be used at all.
                _httpClient = httpClient.ThrowIfNull(nameof(httpClient));
                _imdsV2SessionTokenUrl = imdsV2SessionTokenUrl;
                _imdsV2SessionToken = new Lazy<Task<string>>(FetchImdsV2SessionTokenAsync);
                // Note: a cancellation token is received here for convenience, so it can be used on the lazy fetching of the
                // IMDS V2 token. It'll also be used on all the metadata fetching operations.
                // This means that an instance of AwsMetadataServerClient should be created for each credential refresh, which
                // is the case anyway as the IMDS V2 token also needs to be fetched for each credential refresh.
                _cancellationToken = cancellationToken;
            }

            internal async Task<string> FetchImdsV2SessionTokenAsync()
            {
                if (string.IsNullOrEmpty(_imdsV2SessionTokenUrl))
                {
                    return null;
                }

                // https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-service.html#instance-metadata-v2-how-it-works
                var request = new HttpRequestMessage(HttpMethod.Put, _imdsV2SessionTokenUrl)
                {
                    Headers = { { ImdsV2SessionTokenTtlHeaderName, ImdsV2SessionTokenTtlSeconds } }
                };
                var response = await _httpClient.SendAsync(request, _cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }

            internal async Task<string> FetchMetadataAsync(string metadataUrl)
            {
                var request = new HttpRequestMessage(HttpMethod.Get, metadataUrl);

                // https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-service.html#instance-metadata-v2-how-it-works
                if (await _imdsV2SessionToken.Value.ConfigureAwait(false) is string sessionToken)
                {
                    request.Headers.Add(MetatadaServerRequestImdsV2SessionTokenHeaderName, sessionToken);
                }

                var response = await _httpClient.SendAsync(request, _cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }

            internal static void ValidateMetadataServerUrlIfAny(string url, string nameOfData)
            {
                if (string.IsNullOrEmpty(url))
                {
                    return;
                }

                var uri = new Uri(url);
                if (uri.Host != AwsMetadataServerHostV4 && uri.Host != AwsMetadataServerHostV6)
                {
                    throw new InvalidOperationException(
                        $"The host of the URL given for fetching the {nameOfData} does not match one of the expected hosts. " +
                        $"Given URL: {url} " +
                        $"Expected hosts: {AwsMetadataServerHostV4} or {AwsMetadataServerHostV6}");
                }
            }
        }
    }
}
