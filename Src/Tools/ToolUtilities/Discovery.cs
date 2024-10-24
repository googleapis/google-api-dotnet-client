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
