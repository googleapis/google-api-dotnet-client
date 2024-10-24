
using Google.Apis.Discovery.v1.Data;
using ToolUtilities;

namespace UpdateReadmePackageList;

internal class PackageTableEntry
{
    public string PackageName { get; }
    public string NugetLink => $"https://www.nuget.org/packages/{PackageName}";
    public string ReferenceDocsLink => $"https://googleapis.dev/dotnet/{PackageName}/latest/api/{PackageName}.html";
    public string ApiDocsLink { get; }
    public string ApiName { get; }

    private PackageTableEntry(RestDescription discoveryDoc)
    {
        PackageName = Discovery.GetPackageName(discoveryDoc);
        ApiDocsLink = discoveryDoc.DocumentationLink;
        ApiName = $"{discoveryDoc.Title} {discoveryDoc.Version.Replace('.', '_')}";
    }

    public static PackageTableEntry Load(string discoveryFilePath) =>
        new(Discovery.ParseDiscoveryJson(File.ReadAllText(discoveryFilePath)));

    internal string ToMarkdown() =>
        $"|[{ApiName}]({ApiDocsLink})|[{PackageName}]({NugetLink})|[Library documentation]({ReferenceDocsLink})|";
}
