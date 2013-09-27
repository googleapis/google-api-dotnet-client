/*
Copyright 2013 Google Inc

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
using System.Diagnostics;
using System.IO;
using System.Linq;

using NuGet;

using Google.Apis.Utils.Trace;

namespace Google.Apis.Utils
{
    /// <summary>
    /// NuGet utilities class which support publishing to NuGet main repository, creating a local NuGet package, etc.
    /// </summary>
    public static class NuGetUtilities
    {
        private static readonly TraceSource TraceSource = new TraceSource("Google.Apis");

        /// <summary>The local NuGet folder which stores local NuGet packages.</summary>
        public static readonly string LocalNuGetPackageFolder;

        /// <summary>The main NuGet repository. This is used to publish a new package.</summary>
        private static readonly IPackageRepository MainNuGetRepository =
            new PackageRepositoryFactory().CreateRepository("https://nuget.org/api/v2/");

        private const int NuGetPushTimeoutMills = 10000;

        static NuGetUtilities()
        {
            LocalNuGetPackageFolder = Path.Combine(Path.DirectorySeparatorChar.ToString(), "LocalNuGetFeed");
            if (!Directory.Exists(LocalNuGetPackageFolder))
            {
                Directory.CreateDirectory(LocalNuGetPackageFolder);
            }
        }

        /// <summary>
        /// Creates a local nupkg file, and stores it in a local folder (<see cref="LocalNuGetPackageFolder"/>).
        /// </summary>
        /// <returns>The path to the nupkg file</returns>
        public static string CreateLocalNupkgFile(string nuspecFilePath, string directory)
        {
            var packageName = nuspecFilePath.Substring(nuspecFilePath.LastIndexOf(Path.DirectorySeparatorChar) + 1)
                .Replace(".nuspec", ".nupkg");
            var nupkg = Path.Combine(LocalNuGetPackageFolder, packageName);

            // read the nuspec metadata file 
            using (var stream = new FileStream(nuspecFilePath, FileMode.Open, FileAccess.Read))
            {
                TraceSource.TraceEvent(TraceEventType.Verbose, "Creating {0}", packageName);
                // create the package and save it to disk
                var builder = new PackageBuilder(stream, directory);
                using (FileStream nupkgStream = File.Open(nupkg, FileMode.Create))
                {
                    builder.Save(nupkgStream);
                }
                TraceSource.TraceEvent(TraceEventType.Information, "{0} was created", nupkg);
            }
            return nupkg;
        }

        /// <summary>Publishes to the NuGet main repository.</summary>
        public static void PublishToNuget(string packagePath, string nugetApiKey)
        {
            TraceSource.TraceEvent(TraceEventType.Verbose, "Pushing \"{0}\" to NuGet repository", packagePath);
            PackageServer packageServer = new PackageServer("https://nuget.org/", "Google.Apis");
            try
            {
                packageServer.PushPackage(nugetApiKey, new ZipPackage(packagePath), NuGetPushTimeoutMills);
                TraceSource.TraceEvent(TraceEventType.Information, "\"{0}\" was pushed successfully", packagePath);
            }
            catch (Exception ex)
            {
                TraceSource.TraceEvent(TraceEventType.Error, "Can't publish \"{0}\" to NuGet repository. " +
                    "Exception is: {1}", packagePath, ex.Message);
            }
        }

        /// <summary>
        /// Returns <c>true</c> if a NuGet package already exists in the main NuGet repository for the input name and 
        /// version.
        /// </summary>
        public static bool DoesNugetPackageExist(string packageName, string version)
        {
            IPackage package;
            return MainNuGetRepository.TryFindPackage(packageName, new SemanticVersion(version), out package);
        }
    }
}
