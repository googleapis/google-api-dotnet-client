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

namespace Google.Apis.Util;

/// <summary>Cached metadata for a single request parameter property.</summary>
/// <remarks>Only properties that carry <see cref="RequestParameterAttribute"/> are represented.</remarks>
internal sealed class RequestParameterDescriptor
{
    /// <summary>Gets the <see cref="PropertyInfo"/> used to read the runtime value.</summary>
    public PropertyInfo Property { get; }

    /// <summary>Gets the resolved parameter name (attribute name, or lowercased property name).</summary>
    public string Name { get; }

    /// <summary>Gets the <see cref="RequestParameterType"/> for this parameter.</summary>
    public RequestParameterType Type { get; }

    /// <summary>Gets whether this parameter carries user-defined query pairs.</summary>
    public bool IsUserDefinedQueries { get; }

    public RequestParameterDescriptor(PropertyInfo property, string name, RequestParameterType type)
    {
        Property = property;
        Name = name;
        Type = type;
        IsUserDefinedQueries = type == RequestParameterType.UserDefinedQueries;
    }
}
