namespace CloudPackageMapGenerator;

/// <summary>
/// Massively reduced version of the full API catalog in google-cloud-dotnet.
/// </summary>
public class ApiCatalog
{
    /// <summary>
    /// The APIs within the catalog.
    /// </summary>
    public List<ApiMetadata> Apis { get; set; }
}
