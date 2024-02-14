/*
Copyright 2024 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Net.Http;

namespace Google.Apis.Auth.OAuth2;

/// <summary>
/// Extension methods for <see cref="HttpRequestMessage"/>.
/// </summary>
// Note: This class exists in Google.Apis.Core, Google.Apis and Google.Apis.Auth so that we don't expose it
// publicly. Changes need to be made on the three classes at the same time.
// Only the one in Google.Apis is tested.
internal static class HttpRequestMessageExtensions
{
    /// <summary>
    /// Sets the given key/value pair as a request option.
    /// </summary>
    /// <remarks>
    /// This method exist mostly to handle the fact that HttpRequestMessage.Options are only available
    /// from .NET 5 and up.
    /// </remarks>
    public static void SetOption<TValue>(this HttpRequestMessage request, string key, TValue value)
    {
#if NET6_0_OR_GREATER
        request.Options.Set(new HttpRequestOptionsKey<TValue>(key), value);
#else
        request.Properties[key] = value;
#endif
    }

    /// <summary>
    /// Gets the value associated with the given key on the request options.
    /// </summary>
    /// <remarks>
    /// This method exist mostly to handle the fact that HttpRequestMessage.Options are only available
    /// from .NET 5 and up.
    /// </remarks>
    public static bool TryGetOption<TValue>(this HttpRequestMessage request, string key, out TValue value)
    {
#if NET6_0_OR_GREATER
        return request.Options.TryGetValue(new HttpRequestOptionsKey<TValue>(key), out value);
#else
        object foundValue = null;
        if (request.Properties.TryGetValue(key, out foundValue) && foundValue is TValue tempValue)
        {
            value = tempValue;
            return true;
        }
        value = default;
        return false;
#endif
    }
}
