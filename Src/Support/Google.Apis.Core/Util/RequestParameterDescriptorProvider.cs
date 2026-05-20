/*
Copyright 2026 Google Inc

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

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Google.Apis.Util;

/// <summary>
/// Cached and uncached request parameter descriptor provider.
/// </summary>
internal static class RequestParameterDescriptorProvider
{
    // We may not need the cache but we initialize it regardless as doing so once at application startup is not costly,
    // simpliflies the code and avoids adding per request latency to check for initialization.
    private static readonly ConcurrentDictionary<Type, PropertyInfo[]> s_cache = new ConcurrentDictionary<Type, PropertyInfo[]>();

    /// <summary>
    /// Returns cached <see cref="PropertyInfo"/> for all properties of <paramref name="type"/> that are request parameters,
    /// that is, are marked with <see cref="RequestParameterAttribute"/>.
    /// </summary>
    internal static IEnumerable<PropertyInfo> GetCachedRequestParameterProperties(Type type) =>
        s_cache.GetOrAdd(type, t => GetUncachedRequestParameterProperties(t).ToArray());

    /// <summary>
    /// Returns uncached <see cref="PropertyInfo"/> for all properties of <paramref name="type"/> that are request parameters,
    /// that is, are marked with <see cref="RequestParameterAttribute"/>.
    /// </summary>
    internal static IEnumerable<PropertyInfo> GetUncachedRequestParameterProperties(Type type) =>
        type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(prop => prop.GetCustomAttribute<RequestParameterAttribute>(inherit: false) is not null);

    internal static void ClearCache() => s_cache.Clear();
}
