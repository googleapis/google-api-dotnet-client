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
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;
using NuGet;

using Google.Apis.NuGet.Publisher.Discovery;
using Google.Apis.Utils;
using Google.Apis.Utils.Trace;

namespace Google.Apis.NuGet.Publisher
{
    /// <summary>This publisher publishes Google API packages to NuGet main repository.</summary>
    public class NuGetApiPublisher
    {
        private static TraceSource TraceSource = new TraceSource("Google.Apis");

        private readonly DiscoveryItem item;

        /// <summary>Gets or sets the working directory which the source will be downloaded to.</summary>
        public string BundleDirectory { get; set; }

        /// <summary>Gets or sets the bundle URI. The API's bundle is going to be downloaded from this URI.</summary>
        public Uri BundleUri { get; set; }

        /// <summary>Gets or sets the NuGet API key.</summary>
        public string NuGetApiKey { get; set; }

        /// <summary>Gets or sets the template directory which contains the '.nuget' directory and the necessary  
        /// 'Microsoft.Bcl.Build.targets' file.</summary>
        public string TemplateDirectory { get; set; }

        /// <summary>The regex to extract the id version of the nuspec in the source folder.</summary>
        private static readonly Regex IdPattern = new Regex(@"<id>(.*)</id>");

        /// <summary>The regex to extract the version of the nuspec in the source folder.</summary>
        private static readonly Regex VersionPattern = new Regex(@"<version>(.*)</version>");

        /// <summary>Constructs a new logic item.</summary>
        public NuGetApiPublisher(DiscoveryItem item)
        {
            this.item = item;
        }

        /// <summary>This is the main logic, which does the following:
        /// <list type="number">
        /// <item><description>
        /// Download the API's bundle from "https://google-api-client-libraries.appspot.com/"
        /// </description></item>
        /// <item><description>Extract the API's sources</description></item>
        /// <item><description>Build the sources</description></item>
        /// <item><description>Create a NuGet package</description></item>
        /// <item><description>Publish the package to NuGet main repository</description></item>
        /// </list>
        /// </summary>
        /// <remarks>Leave the <see cref="NuGetApiKey"/> empty to avoid publishing to NuGet main repository</remarks>
        /// <returns>In case there is already a NuGet package with the same name and version, we won't build, create
        /// a new package or publish to the main repository</returns>
        public async Task Run()
        {
            TraceSource.TraceEvent(TraceEventType.Verbose, "{0}\t start working...", item);

            string zipFile = await DownloadBundle();
            string sourceFolder = ExtractSources(zipFile);
            if (!string.IsNullOrEmpty(sourceFolder))
            {
                var buildDirectory = await Build(sourceFolder);
                if (!string.IsNullOrEmpty(buildDirectory))
                {
                    var packagePath = CreateLocalNupkgFile(buildDirectory);
                    if (!string.IsNullOrEmpty(NuGetApiKey))
                    {
                        NuGetUtilities.PublishToNuget(packagePath, NuGetApiKey);
                    }
                }
                Directory.Delete(buildDirectory, true);
            }
        }

        /// <summary>Tests the main logic and does the following:
        /// <list type="number">
        /// <item><description>Build the source files which specified in the input directory</description></item>
        /// <item><description>Create a local NuGet package</description></item>
        /// </list>
        /// </summary>
        public async Task Test(string directory)
        {
            TraceSource.TraceEvent(TraceEventType.Verbose, "{0}\t start working on ...", item);

            var sourceFolder = directory + item;
            if (!string.IsNullOrEmpty(sourceFolder))
            {
                var buildDirectory = await Build(sourceFolder);
                CreateLocalNupkgFile(buildDirectory);
                Directory.Delete(buildDirectory, true);
            }
        }

        #region Download Sources

        /// <summary>Downloads the API's bundle.</summary>
        /// <returns>The path to the bundle file</returns>
        private async Task<string> DownloadBundle()
        {
            var outputFile = string.Format(Path.Combine(BundleDirectory, item + ".zip"));

            // Downloading the bundle
            using (var client = new WebClient())
            {
                TraceSource.TraceEvent(TraceEventType.Verbose, "{0}\t Downloading \"{1}\"", item, BundleUri);
                await client.DownloadFileTaskAsync(BundleUri, outputFile);
                TraceSource.TraceEvent(TraceEventType.Information, "{0}\t \"{1}\" was downloaded successfully", item,
                    BundleUri);

                return outputFile;
            }
        }

        /// <summary>
        /// Extracts the sources. This method first extracts the bundle and then checks by the source zip if a NuGet 
        /// package already exists for the specific API version. 
        /// If not, the method extracts also the source zip to the returned folder path.
        /// </summary>
        /// <param name="zipFile">The bundle zip file which contains the sources</param>
        /// <returns>The path to the source folder. <c>null</c> if a NuGet package already exists for this bundle 
        /// version</returns>
        private string ExtractSources(string zipFile)
        {
            TraceSource.TraceEvent(TraceEventType.Verbose, "{0}\t Extracting sources", item);

            System.IO.Compression.ZipFile.ExtractToDirectory(zipFile, BundleDirectory);
            var apiFolder = Path.Combine(BundleDirectory, item.Name);

            // gets the zip file which contains a "src.zip" suffix
            var sourceZip = Directory.GetFiles(apiFolder).FirstOrDefault(f => f.EndsWith("src.zip"));
            var sourceFolder = Path.Combine(BundleDirectory, "Source");
            System.IO.Compression.ZipFile.ExtractToDirectory(sourceZip, sourceFolder);

            // gets the nuget id and version of the package
            var nuspecFile = Directory.GetFiles(sourceFolder, "*.nuspec").Single();
            var content = File.ReadAllText(nuspecFile);
            var id = IdPattern.Match(content).Groups[1].Value;
            var version = VersionPattern.Match(content).Groups[1].Value;

            // If a NuGet package already exists for this id and version - we don't need to continue with the process
            bool exists = NuGetUtilities.DoesNugetPackageExist(id, version);
            if (exists)
            {
                TraceSource.TraceEvent(TraceEventType.Information, "{0}\t A NuGet package already exists for {1}",
                    item, version);
                return null;
            }

            TraceSource.TraceEvent(TraceEventType.Verbose, "{0}\t Extracting sources in \"{1}\"", item,
                sourceFolder);

            return sourceFolder;
        }

        #endregion

        #region Build

        /// <summary>
        /// Builds the source folder. First it copies all the sources into the template folder and then build the 
        /// project file.
        /// </summary>
        /// <returns>The build directory</returns>
        private Task<string> Build(string sourceFolder)
        {
            var buildDirectory = Path.Combine(TemplateDirectory, "Build");
            if (Directory.Exists(buildDirectory))
            {
                Directory.Delete(buildDirectory, true);
            }
            DirectoryUtilities.CopyDirectory(sourceFolder, buildDirectory);

            var projectFile = Directory.GetFiles(buildDirectory, "*.csproj").Single();
            TraceSource.TraceEvent(TraceEventType.Verbose, "{0}\t Building \"{1}\"", item, projectFile);

            // create a MS project instance and configure it to build 'Release'
            Project project = new Project(projectFile);
            project.SetProperty("Configuration", "Release");

            bool success = project.Build("Build", new[] { new ConsoleLogger(LoggerVerbosity.Quiet) });
            if (success)
            {
                TraceSource.TraceEvent(TraceEventType.Information, "{0}\t \"{1}\" was built successfully!", item,
                    projectFile);
            }
            else
            {
                TraceSource.TraceEvent(TraceEventType.Error, "{0}\t \"{1}\" ERROR IN BUILDING THE PROJECT!", item,
                    projectFile);
                buildDirectory = null;
            }

            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
            tcs.SetResult(buildDirectory);
            return tcs.Task;
        }

        #endregion

        #region NuGet

        /// <summary>Creates a local nupkg file.</summary>
        /// <param name="buildDirectoryPath">Path to build directory which contains the dll, pdb , etc</param>
        /// <returns>The path to the nupkg file</returns>
        private string CreateLocalNupkgFile(string buildDirectoryPath)
        {
            TraceSource.TraceEvent(TraceEventType.Verbose, "{0}\t Start creating .nupkg file", item);
            var nuspec = Directory.GetFiles(buildDirectoryPath, "*.nuspec").Single();
            return NuGetUtilities.CreateLocalNupkgFile(nuspec, buildDirectoryPath);
        }

        #endregion
    }
}
