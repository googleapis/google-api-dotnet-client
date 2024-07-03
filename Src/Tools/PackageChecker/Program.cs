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

// Checks for the presence of NuGet packages with the version number declared
// in each project file beneath the given directory, reporting project files that
// should be built and released.

using System.Net;
using System.Xml.Linq;

if (args.Length != 1)
{
    Console.WriteLine("Argument: <parent-directory>");
    Console.WriteLine("(All project files below this directory, recursively, will be checked.");
    return 1;
}

bool errors = false;
var client = new HttpClient();

// Fetch everything in parallel.
var packages = Directory.GetFiles(args[0], "*.csproj", SearchOption.AllDirectories).Select(Fetch).ToList();

// We don't care what order we await the tasks in.
foreach (var package in packages)
{
    var response = await package.ResponseTask;
    switch (response.StatusCode)
    {
        case HttpStatusCode.OK:
            // Ignore
            break;
        case HttpStatusCode.NotFound:
            // We want to build/generate this
            Console.WriteLine(package.ProjectFile.Replace("\\", "/"));
            break;
        default:
            // Keep going to find all broken packages, but remember to fail eventually.
            Console.Error.WriteLine($"Package {package.Id} check failed with status code {response.StatusCode}");
            errors = true;
            break;
    }
}

return errors ? 1 : 0;

Package Fetch(string projectFile)
{
    var doc = XDocument.Load(projectFile);
    string id = Path.GetFileNameWithoutExtension(projectFile);
    var version = doc.Root.Element("PropertyGroup").Element("Version").Value;

    // A version of x.y.z.0 is packaged as just x.y.z
    var bits = version.Split('.');
    if (bits.Length == 4 && bits[3] == "0")
    {
        version = string.Join(".", bits.Take(3));
    }

    var url = new Uri($"https://globalcdn.nuget.org/packages/{id.ToLowerInvariant()}.{version}.nupkg");
    var request = new HttpRequestMessage
    {
        RequestUri = url,
        Method = HttpMethod.Head
    };
    var responseTask = client.SendAsync(request);
    return new Package(projectFile, id, version, responseTask);
}

record Package (string ProjectFile, string Id, string Version, Task<HttpResponseMessage> ResponseTask);