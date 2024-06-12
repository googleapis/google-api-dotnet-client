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

// Updates the canonical set of Discovery docs based on a freshly-downloaded set, observing which
// services we exclude, and optionally reporting any new/updated Discovery docs in a file for later
// build stages.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

if (args.Length < 3 || args.Length > 4)
{
    Console.WriteLine("Arguments: <download-directory> <target-directory> <excluded-services> [<new/updated file list>]");
    return 1;
}

var downloadDirectory = args[0];
var targetDirectory = args[1];
var excludedServicesFile = args[2];
var newOrUpdatedFile = args.Length == 3 ? null : args[3];

var excludedServices = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(excludedServicesFile));
var downloadDirectoryFiles = Directory.GetFiles(downloadDirectory).Select(Path.GetFileName).OrderBy(x => x, StringComparer.Ordinal);
var targetDirectoryFiles = Directory.GetFiles(targetDirectory).Select(Path.GetFileName).OrderBy(x => x, StringComparer.Ordinal);
var newOrUpdated = new List<string>();

// First go through all the Discovery docs we've just downloaded.
foreach (string relativeDownloadedFile in downloadDirectoryFiles)
{
    string service = Path.GetFileNameWithoutExtension(relativeDownloadedFile);
    string downloadedFile = Path.Combine(downloadDirectory, relativeDownloadedFile);
    string targetFile = Path.Combine(targetDirectory, relativeDownloadedFile);

    // Skip excluded services.
    if (excludedServices.Contains(service))
    {
        Console.WriteLine(service + ": excluded from generation.");
        continue;
    }

    // Anything that doesn't already exist in the target directory is new. Copy it.
    if (!targetDirectoryFiles.Contains(relativeDownloadedFile))
    {
        Console.WriteLine(service + ": New.");
        File.Copy(downloadedFile, targetFile);
        newOrUpdated.Add(targetFile);
        continue;
    }

    // For existing Discovery docs, there are three states:
    // - Completely unchanged (skip)
    // - New etag and/or revision, but otherwise the same content (skip)
    // - Changed (copy)

    JObject newDiscovery = JObject.Parse(File.ReadAllText(downloadedFile));
    JObject oldDiscovery = JObject.Parse(File.ReadAllText(targetFile));
    if (JsonEqual(oldDiscovery, newDiscovery))
    {
        Console.WriteLine(service + ": Unchanged.");
        continue;
    }

    newDiscovery.Remove("revision");
    newDiscovery.Remove("etag");
    oldDiscovery.Remove("revision");
    oldDiscovery.Remove("etag");
    if (JsonEqual(oldDiscovery, newDiscovery))
    {
        Console.WriteLine(service + ": Unchanged except revision/etag.");
        continue;
    }
    
    Console.WriteLine(service + ": Updated.");
    File.Copy(downloadedFile, targetFile, true);
    newOrUpdated.Add(targetFile);
}

// Finally, delete any obsolete Discovery docs.
// Note that we don't currently automatically delete the associated generated library.
foreach (string obsoleteFile in targetDirectoryFiles.Except(downloadDirectoryFiles))
{
    Console.WriteLine(Path.GetFileNameWithoutExtension(obsoleteFile) + " is obsolete; deleting");
    File.Delete(Path.Combine(targetDirectory, obsoleteFile));
}

// Optionally report new/updated Discovery docs for later steps.
if (newOrUpdatedFile is not null)
{
    File.WriteAllLines(newOrUpdatedFile, newOrUpdated.Select(x => x.Replace('\\', '/')));
}

return 0;

// Simple utility method to compare two JObjects for equality;
// we already sort Discovery docs, so just converting both to a string should be fine.
static bool JsonEqual(JObject x, JObject y) => x.ToString() == y.ToString();
