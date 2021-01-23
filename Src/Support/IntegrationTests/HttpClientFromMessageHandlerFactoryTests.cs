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

#if NETCOREAPP2_1

using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using IntegrationTests.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class HttpClientFromMessageHandlerFactoryTests
    {
        public static IHostBuilder ConfigureHostBuilder(bool transientServiceClient) =>
            Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    // Configure one HttpClient that performs automatic decompression.
                    services.AddHttpClient("allowsDecompression").ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                    {
                        // We don't need to check for SupportsRedirectConfiguration
                        // or SupportsAutomaticDecompression because they are true by default
                        // for System.Net.HttpClientHandler
                        AllowAutoRedirect = false,
                        AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
                    });
                    // Configure one HttpClient that doesn't perform automatic decompression.
                    services.AddHttpClient("disallowsDecompression").ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                    {
                        // We don't need to check for SupportsRedirectConfiguration
                        // or SupportsAutomaticDecompression because they are true by default
                        // for System.Net.HttpClientHandler
                        AllowAutoRedirect = false,
                        AutomaticDecompression = DecompressionMethods.None
                    });
                    // Register Google.Apis.Http.IHttpClientFactory using the registered
                    // System.Net.Http.IHttpMessageHandlerFactory to obtain inner message handlers.
                    services.AddSingleton<Google.Apis.Http.IHttpClientFactory>(sp => new HttpClientFromMessageHandlerFactory(
                        options => new HttpClientFromMessageHandlerFactory.ConfiguredHttpMessageHandler(
                            messageHandler: sp.GetRequiredService<IHttpMessageHandlerFactory>().CreateHandler(options.MayPerformDecompression ? "allowsDecompression" : "disallowsDecompression"),
                            // We know we have configured them correctly.
                            handlesRedirect: false,
                            performsAutomaticDecompression: options.MayPerformDecompression
                        )));
                    // Configure a TransalateService that uses the HttpClientFromMessageHandlerFactory
                    // Transient or not for testing different reuse scenarios.
                    if (transientServiceClient)
                    {
                        services.AddTransient(CreateTranslateService);
                    }
                    else
                    {
                        services.AddScoped(CreateTranslateService);
                    }

                    static TranslateService CreateTranslateService(IServiceProvider sp) => new TranslateService(new BaseClientService.Initializer
                    {
                        HttpClientInitializer = Helper.GetServiceCredential().CreateScoped(TranslateService.Scope.CloudTranslation),
                        ApplicationName = "IntegrationTest",
                        HttpClientFactory = sp.GetRequiredService<Google.Apis.Http.IHttpClientFactory>()
                    });
                });

        [Theory]
        [CombinatorialData]
        public async Task SingleCall(bool transientServiceClient)
        {
            using var host = await ConfigureHostBuilder(transientServiceClient).StartAsync();
            var translateService = host.Services.GetRequiredService<TranslateService>();

            var translateRequest = translateService.Translations.Translate(new TranslateTextRequest
            {
                Format = "text",
                Q = new List<string> { "The cold weather will soon be over" },
                Source = "en",
                Target = "fr",
            });
            var response = await translateRequest.ExecuteAsync();

            var translation = Assert.Single(response.Translations);
            // We sometimes get:
            // Le temps froid sera bientôt fini
            // Le froid sera bientôt terminé
            Assert.Contains("froid sera bientôt", translation.TranslatedText);
            await host.StopAsync();
        }

        [Theory]
        [CombinatorialData]
        public async Task ConcurrentCalls(bool transientServiceClient)
        {
            using var host = await ConfigureHostBuilder(transientServiceClient).StartAsync();

            var translationTasks = Enumerable.Range(0, 100).Select(i =>
            {
                var translateService = host.Services.GetRequiredService<TranslateService>();
                var translateRequest = translateService.Translations.Translate(new TranslateTextRequest
                {
                    Format = "text",
                    Q = new List<string> { $"Task {i}" },
                    Source = "en",
                    Target = "fr",
                });
                return translateRequest.ExecuteAsync();
            });

            var responses = await Task.WhenAll(translationTasks);
            for (int i = 0; i < responses.Length; i++)
            {
                var translation = Assert.Single(responses[i].Translations);
                Assert.Contains(i.ToString(), translation.TranslatedText);
            }
            await host.StopAsync();
        }
    }
}

#endif
