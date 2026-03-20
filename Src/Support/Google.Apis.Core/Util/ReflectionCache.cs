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
using System.Linq;
using System.Reflection;
using Google;

namespace Google.Apis.Util
{
    /// <summary>
    /// Provides cached reflection results for request parameter discovery.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class is thread-safe. The internal cache uses <see cref="ConcurrentDictionary{TKey,TValue}"/>,
    /// which allows concurrent reads and writes without external locking.
    /// </para>
    /// <para>
    /// Caching is opt-in: set <see cref="ApplicationContext.EnableReflectionCache"/> to <c>true</c>
    /// at application startup to activate it. By default, reflection results are recomputed on every call
    /// to preserve the existing no-overhead-at-rest behavior.
    /// </para>
    /// <para>
    /// When caching is enabled, each unique request type incurs a one-time reflection cost. Subsequent calls
    /// for the same type return the cached <see cref="PropertyWithAttribute"/> array directly, eliminating
    /// per-call reflection and attribute-lookup overhead.
    /// </para>
    /// <para>
    /// The cache is intentionally unbounded, but in practice it is finite: entries are keyed by the concrete
    /// request types that carry <see cref="RequestParameterAttribute"/>-decorated properties. The set of such
    /// types in any application is small and fixed at compile time.
    /// </para>
    /// </remarks>
    /// <example>
    /// Enable caching once at application startup, before issuing any API requests:
    /// <code>
    /// // Enable caching at application startup
    /// ApplicationContext.EnableReflectionCache = true;
    ///
    /// // The cache is used automatically by ParameterUtils
    /// // (no further configuration required)
    /// </code>
    /// </example>
    public static partial class ReflectionCache
    {
        /// <summary>
        /// Cache of properties filtered by RequestParameterAttribute.
        /// Key is the type, value is an array of PropertyWithAttribute structs.
        /// </summary>
        /// <remarks>
        /// This cache is intentionally unbounded; it is keyed by request types
        /// annotated with RequestParameterAttribute, which are expected to be
        /// a finite set in normal usage.
        /// </remarks>
        private static readonly ConcurrentDictionary<Type, PropertyWithAttribute[]> RequestParameterPropertiesCache =
            new ConcurrentDictionary<Type, PropertyWithAttribute[]>();

        /// <summary>
        /// Returns the set of <see cref="RequestParameterAttribute"/>-decorated properties for the specified
        /// request type.
        /// </summary>
        /// <param name="type">The request type whose parameter properties should be returned.</param>
        /// <returns>
        /// An array of <see cref="PropertyWithAttribute"/> values, each pairing a
        /// <see cref="System.Reflection.PropertyInfo"/> with its <see cref="RequestParameterAttribute"/>.
        /// Only properties that carry the attribute are included; properties without it are omitted.
        /// </returns>
        /// <remarks>
        /// When <see cref="ApplicationContext.EnableReflectionCache"/> is <c>true</c>, the result is
        /// stored in an internal <see cref="ConcurrentDictionary{TKey,TValue}"/> and returned on subsequent
        /// calls without re-executing reflection. When the setting is <c>false</c> (the default), reflection
        /// is performed on every invocation.
        /// </remarks>
        public static PropertyWithAttribute[] GetRequestParameterProperties(Type type)
        {
            // Only use cache if explicitly enabled by user
            if (ApplicationContext.EnableReflectionCache)
            {
                return RequestParameterPropertiesCache.GetOrAdd(type, ComputeProperties);
            }

            // Default behavior: compute properties without caching
            return ComputeProperties(type);
        }

        /// <summary>
        /// Computes the request parameter properties for a given type using reflection.
        /// </summary>
        private static PropertyWithAttribute[] ComputeProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Select(prop => new PropertyWithAttribute(prop, prop.GetCustomAttribute<RequestParameterAttribute>(inherit: false)))
                .Where(pwa => pwa.Attribute != null)
                .ToArray();
        }
    }
}
