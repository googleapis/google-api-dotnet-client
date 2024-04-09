// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using CloudPackageMapGenerator;
using Newtonsoft.Json;

if (args.Length != 2)
{
    Console.WriteLine("Required arguments: <path-to-google-api-dotnet-client root> <path-to-google-cloud-dotnet-root>");
    return 1;
}

// Work out the files and directories involved.
string featuresFile = Path.Combine(args[0], "features.json");
string generatedDir = Path.Combine(args[0], "Src", "Generated");
string apiCatalogFile = Path.Combine(args[1], "apis", "apis.json");

if (!File.Exists(featuresFile))
{
    Console.WriteLine($"Can't find '{featuresFile}'.");
    return 1;
}

if (!Directory.Exists(generatedDir))
{
    Console.WriteLine($"Can't find '{generatedDir}'.");
    return 1;
}

if (!File.Exists(apiCatalogFile))
{
    Console.WriteLine($"Can't find '{apiCatalogFile}'.");
    return 1;
}

var allRestLibraries = Directory.GetDirectories(generatedDir).Select(Path.GetFileName).ToList();
var apiCatalogJson = File.ReadAllText(apiCatalogFile);

// Read the features file as a list of lines, as we don't want to disturb any comments etc.
// We find the cloudPackageMap expecting the file to be formatted, potentially with // comments.
var featuresFileLines = File.ReadAllLines(featuresFile).ToList();
int packageMapStartIndex = featuresFileLines.IndexOf("  \"cloudPackageMap\": {");
if (packageMapStartIndex == -1)
{
    Console.WriteLine("Can't find start of cloudPackageMap property in features.json");
    return 1;
}

int packageMapEndIndex = featuresFileLines.IndexOf("  },", packageMapStartIndex);
if (packageMapEndIndex == -1)
{
    Console.WriteLine("Can't find end of cloudPackageMap property in features.json");
    return 1;
}

var existingMappedRestLibraries = featuresFileLines
    .Skip(packageMapStartIndex + 1)
    .Take(packageMapEndIndex - packageMapStartIndex - 1)
    .Where(line => !line.Trim().StartsWith("//"))
    .Select(line => line.Split(':')[0].Trim(' ', '"'))
    .ToHashSet();

// Find all published (not 1.0.0-beta00) libraries in the API catalog.
// We retain a case-insensitive map from "package name without dots" to "full package name".
var apiCatalog = JsonConvert.DeserializeObject<ApiCatalog>(apiCatalogJson);
var gapicLibraries = apiCatalog.Apis
    .Where(api => api.Version != "1.0.0-beta00")
    .Select(api => api.Id)
    .ToDictionary(id => id.Replace(".", ""), id => id, StringComparer.OrdinalIgnoreCase);

// Now do the mapping, currently just by name.
// We could potentially load the Discovery doc and examine the GAPIC proto path / service config.
int newlyMappedCount = 0;
foreach (var library in allRestLibraries.Except(existingMappedRestLibraries))
{
    bool mapped = false;
    var noApis = library.Replace(".Apis.", ".");
    MaybeMap(noApis);
    MaybeMap(noApis.Replace("Service.", "."));
    MaybeMap(noApis.Replace("Google.", "Google.Cloud."));
    if (!mapped)
    {
        Console.WriteLine($"No mapping for {library}");
    }

    void MaybeMap(string candidate)
    {
        if (mapped)
        {
            return;
        }
        if (gapicLibraries.TryGetValue(candidate.Replace(".", ""), out var gapic))
        {
            Console.WriteLine($"Mapping {library} to {gapic}");
            mapped = true;
            newlyMappedCount++;
            featuresFileLines.Insert(packageMapEndIndex++, $"    \"{library}\": \"{gapic}\",");
        }
    }
}

// Print a summary and write out the file if we've added mappings.
Console.WriteLine();
Console.WriteLine($"Total REST libraries: {allRestLibraries.Count}");
Console.WriteLine($"Previously-mapped: {existingMappedRestLibraries.Count}");
Console.WriteLine($"Newly-mapped: {newlyMappedCount}");
Console.WriteLine($"Unmapped: {allRestLibraries.Count - existingMappedRestLibraries.Count - newlyMappedCount}");

if (newlyMappedCount != 0)
{
    File.WriteAllLines(featuresFile, featuresFileLines);
}

return 0;