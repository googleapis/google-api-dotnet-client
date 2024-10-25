// Copyright 2024 Google LLC
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

using Google.Api.Generator.Rest.Models;
using Google.Api.Generator.Utils;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Json;

namespace ToolUtilities;

/// <summary>
/// Utilities for working with Discovery docs.
/// </summary>
public static class Discovery
{
    public static RestDescription ParseDiscoveryJson(string discoveryJson) =>
        NewtonsoftJsonSerializer.Instance.Deserialize<RestDescription>(discoveryJson);

    /// <summary>
    /// Returns the name of the package generated from the given Discovery doc (in JSON form).
    /// </summary>
    public static string GetPackageName(string discoveryJson) =>
        GetPackageName(ParseDiscoveryJson(discoveryJson));

    /// <summary>
    /// Returns the name of the package generated from the given Discovery doc.
    /// </summary>
    public static string GetPackageName(RestDescription discoveryDoc)
    {
        // The code below is taken from PackageModel in the REST generator.
        var className = (discoveryDoc.CanonicalName ?? discoveryDoc.Name).Replace(" ", "").ToMemberName();
        string versionNoDots = discoveryDoc.Version.Replace('.', '_');
        var camelizedPackagePath = discoveryDoc.PackagePath is null
            ? ""
            : string.Join('.', discoveryDoc.PackagePath.Split('/').Select(part => part.ToUpperCamelCase())) + ".";
        return $"Google.Apis.{camelizedPackagePath}{className}.{versionNoDots}";
    }
}
