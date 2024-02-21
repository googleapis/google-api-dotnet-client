/*
Copyright 2023 Google LLC

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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Http;

/// <summary>
/// A <see cref="DelegatingHandler"/> which executes an <see cref="IHttpExecuteInterceptor"/> before
/// delegating onwards.
/// </summary>
internal sealed class InterceptorDelegatingHandler : DelegatingHandler
{
    private readonly IHttpExecuteInterceptor _interceptor;

    internal InterceptorDelegatingHandler(IHttpExecuteInterceptor interceptor, HttpMessageHandler innerHandler) : base(innerHandler)
    {
        _interceptor = interceptor.ThrowIfNull(nameof(interceptor));
    }

    internal InterceptorDelegatingHandler(IHttpExecuteInterceptor interceptor)
    {
        _interceptor = interceptor.ThrowIfNull(nameof(interceptor));
    }

    protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        await _interceptor.InterceptAsync(request, cancellationToken).ConfigureAwait(false);
        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
    }
}
