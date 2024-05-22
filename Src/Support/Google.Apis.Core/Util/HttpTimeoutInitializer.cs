/*
Copyright 2024 Google Inc

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

using Google.Apis.Http;
using System;

namespace Google.Apis.Core;

/// <summary>
/// Used for specifying a custom timeout for a <see cref="ConfigurableHttpClient"/>.
/// </summary>
public sealed class HttpTimeoutInitializer : IConfigurableHttpClientInitializer
{
    /// <summary>
    /// The timeout to set on <see cref="ConfigurableHttpClient"/> instances on which this initializer is applied.
    /// </summary>
    public TimeSpan HttpClientTimeout { get; }

    /// <summary>
    /// Creates a new instance with the given timeout.
    /// </summary>
    /// <remarks>
    /// This initializer relies on <see cref="ConfigurableHttpClient"/> for validation.
    /// That means that <paramref name="httpClientTimeout"/> is not validated in this constructor.
    /// It's when this initializer is applied to a <see cref="ConfigurableHttpClient"/>
    /// that the value will be validated and an exception possibly thrown.
    /// </remarks>
    public HttpTimeoutInitializer(TimeSpan httpClientTimeout) => HttpClientTimeout = httpClientTimeout;

    /// <inheritdoc/>
    public void Initialize(ConfigurableHttpClient httpClient) => httpClient.Timeout = HttpClientTimeout;
}
