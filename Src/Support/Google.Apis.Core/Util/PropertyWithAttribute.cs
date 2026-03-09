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

using System.Reflection;

namespace Google.Apis.Util
{
    /// <summary>
    /// Pairs a <see cref="PropertyInfo"/> with its associated <see cref="RequestParameterAttribute"/>.
    /// </summary>
    /// <remarks>
    /// Instances of this struct are produced by <see cref="ReflectionCache.GetRequestParameterProperties"/>
    /// and consumed by <c>ParameterUtils</c> when building request URLs and form bodies. Only properties
    /// that are decorated with <see cref="RequestParameterAttribute"/> are represented; properties without
    /// the attribute are filtered out before any <see cref="PropertyWithAttribute"/> value is created.
    /// </remarks>
    public readonly struct PropertyWithAttribute
    {
        /// <summary>
        /// Gets the <see cref="PropertyInfo"/> for the request parameter property.
        /// </summary>
        /// <value>
        /// The <see cref="PropertyInfo"/> that describes the request parameter property on the request type.
        /// </value>
        public PropertyInfo Property { get; }

        /// <summary>
        /// Gets the <see cref="RequestParameterAttribute"/> applied to <see cref="Property"/>.
        /// </summary>
        /// <value>
        /// The <see cref="RequestParameterAttribute"/> that annotates <see cref="Property"/>, providing the
        /// parameter name and <see cref="RequestParameterType"/> used when serializing the request.
        /// </value>
        /// <remarks>
        /// This value is never <c>null</c> on instances returned by
        /// <see cref="ReflectionCache.GetRequestParameterProperties"/>; properties without the attribute
        /// are excluded from the results.
        /// </remarks>
        public RequestParameterAttribute Attribute { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="PropertyWithAttribute"/>.
        /// </summary>
        /// <param name="property">The <see cref="PropertyInfo"/> of the request parameter property.</param>
        /// <param name="attribute">The <see cref="RequestParameterAttribute"/> applied to <paramref name="property"/>.</param>
        public PropertyWithAttribute(PropertyInfo property, RequestParameterAttribute attribute)
        {
            Property = property;
            Attribute = attribute;
        }
    }
}
