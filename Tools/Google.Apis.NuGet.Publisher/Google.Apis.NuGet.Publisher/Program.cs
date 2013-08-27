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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using CommandLine;
using CommandLine.Text;

using Google.Apis.NuGet.Publisher.Discovery;
using Google.Apis.Utils;

namespace Google.Apis.NuGet.Publisher
{
    /// <summary>The options class which contains the different options to this utility.</summary>
    class Options
    {
        public const string ModeTest = "test";
        public const string ModePublish = "publisher";

        [Option('a', "all_apis", HelpText = "Define if NuGet publisher works on all Google APIs")]
        public bool AllApis { get; set; }

        [Option('n', "api_name", HelpText = "Define the specific API to work on")]
        public string ApiName { get; set; }

        [Option('v', "api_version", HelpText = "Define the specific API version to work on")]
        public string ApiVersion { get; set; }

        [Option('m', "mode", DefaultValue = "test",
            HelpText = "Indicate the mode of operation {" + ModeTest + "|" + ModePublish + "}")]
        public string Mode { get; set; }

        [Option('k', "nuget_key",
            HelpText = @"Define the NuGet API key. If empty the publisher works local on 'C:\LocalNuGetFeed'")]
        public string NuGetApiKey { get; set; }

        [Option('l', "library_version",
            HelpText = "Define the Google.Apis library which is used to download the bundles (e.g. 1.5.0-beta)")]
        public string GoogleApisVersion { get; set; }

        [Option('d', "apis_directory",
            HelpText = "For testing purposes only. " +
            "It Defines the APIs directory which contains all the APIs we want to test.")]
        public string ApisDirectory { get; set; }

        [HelpOption]
        public string GetHelp()
        {
            return HelpText.AutoBuild(this, c => HelpText.DefaultParsingErrorsHandler(this, c));
        }
    }

    /// <summary>
    /// A Google APIs NuGet publisher which downloads the APIs latest bundles. For each API it checks if there a NuGet
    /// package doesn't exist for the client version and the API revision, and if so it builds a new NuGet package and
    /// publish it to NuGet main repository.
    /// </summary>
    /// <remarks>
    /// The Google APIs NuGet publisher uses a local folder "C:\LocalNuGetFeed" to store all the NuGet packages
    /// locally.
    /// Notice also the different between bundle and package:
    /// A bundle is the zip file that contains the sources, and it's is downloaded from
    /// "https://google-api-client-libraries.appspot.com/"
    /// A package is the NuGet package we use to build a solution. We can store NuGet packages locally (e.g. in
    /// "C:\LocalNuGetFeed") or use the main NuGet repository at "https://nuget.org/api/v2/"
    /// </remarks>
    class Program
    {
        private static TraceSource TraceSource = new TraceSource("Google.Apis");

        /// <summary>The discovery URI to get all the public APIs.</summary>
        static readonly Uri DiscoveryApiUri = new Uri(@"https://www.googleapis.com/discovery/v1/apis");

        /// <summary>The download URI format to download a specific API format. Two parameters are expected the API 
        /// name and its version.</summary>
        const string DownloadUriFormat =
            "https://google-api-client-libraries.appspot.com/download/library/{0}/{1}/csharp?deps=0";

        /// <summary>The template directory which contains the '.nuget' directory and the necessary  
        /// 'Microsoft.Bcl.Build.targets' file.</summary>
        readonly string TemplateDirectory;

        /// <summary>The directory that the bundle will be downloaded to.</summary>
        readonly string DownloadBundleTempDirectory = Path.Combine(Path.GetTempPath(), "GoogleAPIsPublisher");

        /// <summary>The program's options.</summary>
        readonly Options options;

        #region Main

        static void Main(string[] args)
        {
            var options = new Options();
            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                // TODO(peleyal): add explanation which option is missing. Currently the command line utility just
                // print the whole help without mention what is missing.
            }
            else if (!options.AllApis && (options.ApiName == null || options.ApiVersion == null))
            {
                Console.WriteLine("Please Set '--all_apis true' or the API name and version, e.g. " +
                    "'--api_name=drive --api_version=v2'");
            }
            else if (!new[] { Options.ModePublish, Options.ModeTest }.Contains(options.Mode))
            {
                Console.WriteLine("Mode should be '{0}' or '{1}'", Options.ModeTest, Options.ModePublish);
            }
            else
            {

                try
                {
                    new Program(options).Run().Wait();
                }
                catch (AggregateException ex)
                {
                    foreach (var inner in ex.InnerExceptions)
                    {
                        TraceSource.TraceEvent(TraceEventType.Error, "Exception was thrown. {0}", inner.Message);
                    }
                }
            }
            Console.ReadKey();
        }

        #endregion

        Program(Options options)
        {
            this.options = options;
            // remove "Google.Apis.NuGet.Publisher\\bin\\{Debug|Release}\\Google.Apis.NuGet.Publisher.exe"
            var fileInfo = new FileInfo(Assembly.GetEntryAssembly().Location);
            TemplateDirectory = Path.Combine(fileInfo.Directory.Parent.Parent.Parent.FullName, "Template");
        }

        Task Run()
        {
            switch (options.Mode)
            {
                case Options.ModeTest:
                    return RunAsync("TEST", TestAsync);
                case Options.ModePublish:
                    return RunAsync("PUBLISH", PublishAsync);
                default:
                    throw new ArgumentException(string.Format("Mode should be {0} or {1}",
                        Options.ModePublish, Options.ModeTest));
            }
        }

        /// <summary>The main wrapper to run, gets a function to run which contains the main logic.</summary>
        async Task RunAsync(string header, Func<IEnumerable<DiscoveryItem>, Task> core)
        {
            TraceSource.TraceEvent(TraceEventType.Information, "=============== {0} ===============", header);
            TraceSource.TraceEvent(TraceEventType.Information, "Entering Google.Apis.Nuget.Publihser");

            IEnumerable<DiscoveryItem> apis;
            if (options.AllApis)
            {
                apis = await new DiscoveryService().GetApis(DiscoveryApiUri);
            }
            else
            {
                apis = new List<DiscoveryItem> { new DiscoveryItem
                    {
                        Name = options.ApiName.ToLower(),
                        Version = options.ApiVersion.ToLower()
                    }};
            }

            if (Directory.Exists(DownloadBundleTempDirectory))
            {
                Directory.Delete(DownloadBundleTempDirectory, true);
            }
            Directory.CreateDirectory(DownloadBundleTempDirectory);

            try
            {
                TraceSource.TraceEvent(TraceEventType.Information, "\"{0}\" folder was created",
                    DownloadBundleTempDirectory);

                await core(apis);

                TraceSource.TraceEvent(TraceEventType.Information, 0, "Exiting Google.Apis.Nuget.Publihser");
            }
            finally
            {
                Directory.Delete(DownloadBundleTempDirectory, true);
            }
        }

        /// <summary>Publishes new APIs to NuGet main repository.</summary>
        async Task PublishAsync(IEnumerable<DiscoveryItem> apis)
        {
            // TODO(peleyal): validate NuGetApiKey
            foreach (var item in apis)
            {
                var workingDir = Path.Combine(DownloadBundleTempDirectory,
                    item.Name + "-" + item.Version);
                Directory.CreateDirectory(workingDir);

                var bundleUri = string.Format(DownloadUriFormat, item.Name, item.Version);
                if (!string.IsNullOrEmpty(options.GoogleApisVersion))
                {
                    bundleUri = bundleUri + "&lv=" + options.GoogleApisVersion;
                }

                var publisher = new NuGetApiPublisher(item)
                    {
                        BundleDirectory = workingDir,
                        BundleUri = new Uri(bundleUri),
                        TemplateDirectory = TemplateDirectory,
                        NuGetApiKey = options.NuGetApiKey,
                    };

                try
                {
                    await publisher.Run();
                }
                catch (Exception ex)
                {
                    TraceSource.TraceEvent(TraceEventType.Error, "{0}\t Exception [{1}] occurred", item, ex.Message);
                }
            }
        }

        /// <summary>
        /// Tests the main logic behave as expected. <see cref="NuGetApiPublisher.Test"/> for more details.
        /// </summary>
        async Task TestAsync(IEnumerable<DiscoveryItem> apis)
        {
            foreach (var item in apis)
            {
                var publisher = new NuGetApiPublisher(item)
                    {
                        TemplateDirectory = TemplateDirectory,
                    };
                try
                {
                    await publisher.Test(options.ApisDirectory);
                }
                catch (Exception ex)
                {
                    TraceSource.TraceEvent(TraceEventType.Error, "{0}\t Exception [{1}] occurred", item, ex.Message);
                }
            }
        }
    }
}
