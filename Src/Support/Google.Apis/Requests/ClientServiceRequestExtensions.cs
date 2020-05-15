/*
Copyright 2020 Google LLC

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

namespace Google.Apis.Requests
{
    /// <summary>
    /// Extension methods for request objects.
    /// </summary>
    public static class ClientServiceRequestExtensions
    {
        /// <summary>
        /// Allows a request to be configured in a fluent manner, where normally separate statements are required
        /// after the request creation method is called.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request to configure.</typeparam>
        /// <param name="request">The request to configure. Must not be null.</param>
        /// <param name="configurationAction">The configuration action to apply to the request. This is typically
        /// setting properties. Must not be null.</param>
        /// <returns>The value of <paramref name="request"/>, after applying the configuration action.</returns>
        public static TRequest Configure<TRequest>(this TRequest request, Action<TRequest> configurationAction)
            where TRequest : ClientServiceRequest
        {
            request.ThrowIfNull(nameof(request));
            configurationAction.ThrowIfNull(nameof(configurationAction));
            configurationAction(request);
            return request;
        }
    }
}
