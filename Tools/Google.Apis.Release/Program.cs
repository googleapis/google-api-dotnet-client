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
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;

using CommandLine;
using CommandLine.Text;
using Ionic.Zip;

using Google.Apis.Release.Repositories;
using Google.Apis.Release.Wiki;
using Google.Apis.Utils;
using Google.Apis.Utils.Trace;

namespace Google.Apis.Release
{
    /// <summary>The main program for creating a new Google.Apis release.</summary>
    class Program
    {
        /// <summary>The options class which contains the different options to this publish release utility.</summary>
        public class Options
        {
            #region HelpText

            const string VersionHelpText = "The version number of this release - <Major.Minor.Build> only.";
            const string OutputHelpText = "Define the output directory for this build. " +
                "Notice that it's relative to current directory.";
            const string StepHelpText = "Two options: " +
                "'1' for building the core library. \n" +
                "'2' for compiling samples, updating wiki and push to contrib the new version.";
            const string IsBetaHelpText = "Is this release beta?";
            const string IsRCHelpText = "Is this release RC?";
            const string NuGetApiKeyHelpText = "Define the NuGet API key to publish to NuGet main repository.";
            const string IsLocalHelpText = "Define if current default repository will be used.";

            [HelpOption]
            public string GetHelp()
            {
                return HelpText.AutoBuild(this, c => HelpText.DefaultParsingErrorsHandler(this, c));
            }

            #endregion

            [Option('v', "version", Required = true, HelpText = VersionHelpText)]
            public string Version { get; set; }

            [Option('d', "dir", HelpText = OutputHelpText)]
            public string OutputDirectory { get; set; }

            [Option('l', "local", DefaultValue = false, HelpText = IsLocalHelpText)]
            public bool IsLocal { get; set; }

            [Option('s', "step", Required = true, HelpText = StepHelpText)]
            public int Step { get; set; }

            [Option('b', "beta", DefaultValue = false, HelpText = IsBetaHelpText)]
            public bool IsBeta { get; set; }

            [Option('r', "rc", DefaultValue = false, HelpText = IsRCHelpText)]
            public bool IsRC { get; set; }

            [Option('k', "nuget_key", HelpText = NuGetApiKeyHelpText)]
            public string NuGetApiKey { get; set; }
        }

        private static readonly TraceSource TraceSource = new TraceSource("Google.Apis");

        /// <summary>Command line arguments.</summary>
        private readonly Options options;

        /// <summary>The current repository (default) relative path.</summary>
        private readonly string LocalRepositoryRelativePath = "..\\..\\..\\..\\";

        private int MajorVersion { get; set; }
        private int MinorVersion { get; set; }
        private int BuildVersion { get; set; }

        private string Tag
        {
            get { return options.Version + (options.IsBeta ? "-beta" : (options.IsRC ? "-rc" : "")); }
        }

        /// <summary>Gets or sets the "default" repository.</summary>
        private Hg DefaultRepository { get; set; }

        /// <summary>Gets or sets the "samples" repository.</summary>
        private Hg SamplesRepository { get; set; }

        /// <summary>Gets or sets the "wiki" repository.</summary>
        private Hg WikiRepository { get; set; }

        /// <summary>Gets or sets the "contrib" repository.</summary>
        private Hg ContribRepository { get; set; }

        /// <summary>Gets all four repositories.</summary>
        private IEnumerable<Hg> AllRepositories
        {
            get { return new List<Hg> { DefaultRepository, SamplesRepository, WikiRepository, ContribRepository }; }
        }

        /// <summary>Gets all Nuspec packages.</summary>
        private IEnumerable<string> NuspecPackages
        {
            get
            {
                return new[] 
                {
                    "Google.Apis.Core.VERSION.nuspec", 
                    "Google.Apis.VERSION.nuspec", 
                    "Google.Apis.Auth.VERSION.nuspec", 
                    "Google.Apis.Auth.Mvc.VERSION.nuspec"
                };
            }
        }

        /// <summary>
        /// Clone URL format which expects one parameter of the repository name (the default repository should be 
        /// empty).
        /// </summary>
        private const string CloneUrlFormat = "https://code.google.com/p/google-api-dotnet-client{0}/";

        static void Main(string[] args)
        {
            bool valid = true;

            var options = new Options();
            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                TraceSource.TraceEvent(TraceEventType.Error, "Error in reading arguments");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            if (options.Step > 2 || options.Step < 1)
            {
                TraceSource.TraceEvent(TraceEventType.Error, "Invalid Step. Valid step is '1' or '2'.");
                valid = false;
            }
            if (options.IsLocal)
            {
                if (options.Step == 2)
                {
                    TraceSource.TraceEvent(TraceEventType.Error, "You can run step 2 using your local folder only.");
                    valid = false;
                }
                else
                {
                    TraceSource.TraceEvent(TraceEventType.Information, "Working locally!");
                }
            }
            else if (string.IsNullOrEmpty(options.OutputDirectory))
            {
                TraceSource.TraceEvent(TraceEventType.Error, "Please specify output directory (using -d option), " +
                    "or run locally (using -l option).");
                valid = false;
            }

            var match = Regex.Match(options.Version, @"^(\d+)\.(\d+)\.(\d)+$");
            if (!match.Success)
            {
                TraceSource.TraceEvent(TraceEventType.Error,
                    "Invalid version Number. Version should be in <Major>.<Minor>.<Build> form.");
                valid = false;
            }

            var program = new Program(options)
            {
                MajorVersion = int.Parse(match.Groups[1].Value),
                MinorVersion = int.Parse(match.Groups[2].Value),
                BuildVersion = int.Parse(match.Groups[3].Value),
            };

            if (valid)
            {
                try
                {
                    program.Run();
                }
                catch (Exception ex)
                {
                    TraceSource.TraceEvent(TraceEventType.Error, "Exception occurred while running. Exception is: {0}",
                        ex.Message);
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>The main release logic for creating a new release of Google.Apis.</summary>
        private void Run()
        {
            DefaultRepository = new Hg(new Uri(string.Format(CloneUrlFormat, "")), options.IsLocal ? null : "default");

            // Step 1 is only for creating the core Google.Apis packages.
            if (options.Step == 1)
            {
                DoStep1();
            }
            // Step 2 should be done after the NuGet publisher generated all the APIs and the samples repository was 
            // updated with the new packages
            else if (options.Step == 2)
            {
                DoStep2();
            }
        }

        /// <summary>Creates the core Google.Apis packages.</summary>
        private void DoStep1()
        {
            if (BuildVersion != 0)
            {
                DefaultRepository.Update(string.Format("{0}.{1}", MajorVersion, MinorVersion));
            }

            // if there are incoming changes those changes will be printed, otherwise we can continue in the process
            if (!HasIncomingChanges(new List<Hg> { DefaultRepository }))
            {
                // in case build fails the method will print its failures
                if (BuildDefaultRepository())
                {
                    CreateCoreNuGetPackages();
                    // TODO(peleyal): release notes should be part of the package
                }
            }
        }

        /// <summary>
        /// Doing Step 2 of the release process which includes the following:
        /// <list type="number">
        /// <item><description>Builds samples</description></item>
        /// <item><description>Creates a release notes</description></item>
        /// <item><description>Update wiki download page</description></item>
        /// <item><description>Create a new release in the contrib repository</description></item>
        /// <item><description>Commits, Tags and Pushes</description></item>
        /// </list>
        /// </summary>
        private void DoStep2()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine("Prerequisites for Step 2:");
            Console.WriteLine("You ran Step 1.");
            Console.WriteLine("You upgraded the Google.Apis NuGet packages for each sample in the samples " +
                "repository and pushed that change.");
            Console.WriteLine("=========================");
            if (!CanContinue())
            {
                return;
            }

            SamplesRepository = new Hg(new Uri(string.Format(CloneUrlFormat, ".samples")), "samples");
            WikiRepository = new Hg(new Uri(string.Format(CloneUrlFormat, ".wiki")), "wiki");
            ContribRepository = new Hg(new Uri(string.Format(CloneUrlFormat, ".contrib")), "contrib");

            // if there are incoming changes those changes will be printed, otherwise we can continue in the 
            // process
            if (!HasIncomingChanges(AllRepositories))
            {
                BuildSamples();
                var notes = CreateContribNewRelease();
                UpdateWiki(notes);

                foreach (var repository in AllRepositories)
                {
                    repository.AddRemoveFiles();
                }

                Console.WriteLine("=========================");
                Console.WriteLine("Commit, Tag and Push");
                Console.WriteLine("=========================");
                if (!CanContinue())
                {
                    return;
                }

                // commit
                CommitAndTag();

                // push
                foreach (Hg repository in AllRepositories)
                {
                    repository.Push();
                }

                // create branch
                PrintCreateBranch();

                // publish core components to NuGet
                if (!string.IsNullOrEmpty(options.NuGetApiKey))
                {
                    PublishPackagesToNuGet();
                    Console.WriteLine("Now... you should run the NuGet publisher to publish a new PCL "
                        + "for each generated Google API. Run: " +
                        "Google.Apis.NuGet.Publisher --all_apis true -m publisher -k [NUGET_KEY]");
                }
                else
                {
                    TraceSource.TraceEvent(TraceEventType.Error, "NuGet API key is empty!");
                }
            }
        }

        /// <summary>Asks the user if he wants to continue in the process.</summary>
        /// <returns><c>true</c> if the user to press 'y' or 'yes' to continue</returns>
        private bool CanContinue()
        {
            var yesOptions = new[] { "y", "yes" };
            var noOptions = new[] { "n", "no" };

            string input;
            do
            {
                Console.WriteLine("Press 'y' | 'yes' to continue, or 'n' | 'no' to stop");
                input = Console.ReadLine().ToLower();
            } while (!yesOptions.Contains(input) && !noOptions.Contains(input));

            return yesOptions.Contains(input);
        }

        /// <summary>Publishes the core packages to NuGet main repository.</summary>
        private void PublishPackagesToNuGet()
        {
            var pacakges = from nuspec in NuspecPackages
                           select nuspec.Replace("VERSION", Tag).Replace("nuspec", "nupkg");
            foreach (var nupkg in pacakges)
            {
                var nupkgPath = Path.Combine(NuGetUtilities.LocalNuGetPackageFolder, nupkg);
                NuGetUtilities.PublishToNuget(nupkgPath, options.NuGetApiKey);
            }
        }

        /// <summary>
        /// Displays the user orders how to create a branch (only in case it's a new major or minor release.
        /// </summary>
        private void PrintCreateBranch()
        {
            if (BuildVersion != 0)
            {
                // No need to branch in that case
                return;
            }

            // TODO(peleyal): consider automate this as well
            Console.WriteLine("You should create a new branch for this release now:");
            Console.WriteLine("cd " + DefaultRepository.WorkingDirectory);
            var branchVersion = string.Format("{0}.{1}", MajorVersion, MinorVersion);
            Console.WriteLine("hg branch " + branchVersion);
            Console.WriteLine(string.Format("hg commit -m create {0} branch", branchVersion));
            Console.WriteLine("hg push --new-branch");
        }

        /// <summary>Commits all changes in all repositories and tags the "default" repository.</summary>
        private void CommitAndTag()
        {
            foreach (var repository in AllRepositories)
            {
                TraceSource.TraceEvent(TraceEventType.Information, "{0} - Committing", repository.Name);

                bool committed = repository.Commit("Release " + Tag);

                // TODO(peleyal): think to remove this if from this function. I don't like a if inside a loop statement
                if (repository.Equals(DefaultRepository) && committed)
                {
                    try
                    {
                        repository.Tag(Tag, false);
                        TraceSource.TraceEvent(TraceEventType.Information, "{0} - Was tagged \"{1}\"",
                            repository.Name, Tag);
                    }
                    catch (Exception ex)
                    {
                        TraceSource.TraceEvent(TraceEventType.Error, "{0} - Tagging Failed. Exception is: {1}",
                            repository.Name, ex.Message);
                    }
                }

                TraceSource.TraceEvent(TraceEventType.Information, "{0} - Committed", repository.Name);
            }
        }

        /// <summary>Updates the "Downloads" wiki page with the new release notes.</summary>
        private void UpdateWiki(string notes)
        {
            TraceSource.TraceEvent(TraceEventType.Information, "Updating wiki downloads page");

            // TODO(peleyal): improve. Currently we count on that old release of X.Y.Z is X.Y-1.0
            var oldVersion = string.Format("{0}.{1}.{2}", MajorVersion, MinorVersion - 1, 0);
            DownloadsPageUpdater.UpdateWiki(WikiRepository.WorkingDirectory, notes, oldVersion, options.Version);

            TraceSource.TraceEvent(TraceEventType.Information, "wiki downloads page was updated");
        }

        /// <summary>Creates a new release in the "contrib" repository.</summary>
        /// <returns>The release notes of this version</returns>
        private string CreateContribNewRelease()
        {
            TraceSource.TraceEvent(TraceEventType.Information, "Building Contrib release");

            string releaseDir = ContribRepository.Combine(Tag);

            // Clear existing directories.
            DirectoryUtilities.ClearOrCreateDirectory(releaseDir);
            string genDir = Path.Combine(releaseDir, "Generated");
            Directory.CreateDirectory(genDir);

            #region [RELEASE_VERSION]/Generated/Bin

            string binDir = Path.Combine(genDir, "Bin");
            TraceSource.TraceEvent(TraceEventType.Information, "Generating \"{0}\" directory",
                DirectoryUtilities.GetRelativePath(binDir, ContribRepository.WorkingDirectory));

            Directory.CreateDirectory(binDir);
            Directory.CreateDirectory(Path.Combine(binDir, "WP"));
            Directory.CreateDirectory(Path.Combine(binDir, "WinRT"));

            foreach (var project in ReleaseProjects)
            {
                var outputDir = binDir;
                // Add Google.Apis.WP and Google.Apis.Auth.WP assemblies to a WP folder.
                if (project.GetName().Contains("WP"))
                {
                    outputDir = Path.Combine(outputDir, "WP");
                }
                // Add Google.Apis.WinRT and Google.Apis.Auth.WinRT assemblies to a WinRT folder.
                else if (project.GetName().Contains("WinRT"))
                {
                    outputDir = Path.Combine(outputDir, "WinRT");
                }

                var releasePath = Path.Combine(project.DirectoryPath, "Bin", "Release");
                foreach (var filePath in Directory.GetFiles(releasePath, "Google.Apis.*"))
                {
                    File.Copy(filePath,
                        Path.Combine(outputDir,
                                     filePath.Substring(filePath.LastIndexOf(Path.DirectorySeparatorChar) + 1)), true);
                }
            }

            // TODO(peleyal): Put also the nuspec and nupkg

            #endregion

            #region [RELEASE_VERSION]/ZipFiles

            string zipFilesDir = Path.Combine(genDir, "ZipFiles");
            TraceSource.TraceEvent(TraceEventType.Information, "Generating \"{0}\" directory",
                DirectoryUtilities.GetRelativePath(zipFilesDir, ContribRepository.WorkingDirectory));

            Directory.CreateDirectory(zipFilesDir);
            foreach (var project in ReleaseProjects)
            {
                project.Build("Clean");
            }

            TraceSource.TraceEvent(TraceEventType.Information, "Release projects were cleaned");

            // source.zip
            var fileNameFormat = "google-api-dotnet-client-{0}.{1}.zip";
            var sourceZipName = string.Format(fileNameFormat, Tag, "source");
            using (var zip = new ZipFile(Path.Combine(zipFilesDir, sourceZipName)))
            {
                zip.AddDirectory(Path.Combine(DefaultRepository.WorkingDirectory, "Src"), "Src");
                zip.AddFile(Path.Combine(DefaultRepository.WorkingDirectory, "GoogleApisClient.sln"), "");
                zip.AddFile(Path.Combine(DefaultRepository.WorkingDirectory, "LICENSE"), "");
                zip.Save();
            }
            TraceSource.TraceEvent(TraceEventType.Information, "{0} was created", sourceZipName);

            // binary.zip
            var binaryZipName = string.Format(fileNameFormat, Tag, "binary");
            using (var zip = new ZipFile(Path.Combine(zipFilesDir, binaryZipName)))
            {
                Directory.GetFiles(binDir).ToList().ForEach(f => zip.AddFile(Path.Combine(binDir, f), ""));
                zip.Save();
            }
            TraceSource.TraceEvent(TraceEventType.Information, "{0} was created", binaryZipName);


            // samples.zip
            var samplesZipName = string.Format(fileNameFormat, Tag, "samples");
            using (var zip = new ZipFile(Path.Combine(zipFilesDir, samplesZipName)))
            {
                foreach (var d in Directory.GetDirectories(SamplesRepository.WorkingDirectory))
                {
                    if (!d.EndsWith(".hg"))
                    {
                        var directoryName = d.Substring(d.LastIndexOf("\\") + 1);
                        zip.AddDirectory(Path.Combine(SamplesRepository.WorkingDirectory, d), directoryName);
                    }
                }
                foreach (var f in Directory.GetFiles(SamplesRepository.WorkingDirectory, "*.sln"))
                {
                    zip.AddFile(Path.Combine(SamplesRepository.WorkingDirectory, f), "");
                }
                zip.Save();
            }

            TraceSource.TraceEvent(TraceEventType.Information, "{0} was created", samplesZipName);

            #endregion

            #region [RELEASE_VERSION]/ReleaseNotes.txt

            var notes = GetChangelog();
            TraceSource.TraceEvent(TraceEventType.Information, "Creating ReleaseNotes file");
            var noteFilePath = Path.Combine(genDir, "ReleaseNotes.txt");
            File.WriteAllText(noteFilePath, notes);

            #endregion

            // open the created change-log and read again the notes (in case the user had modified the file)
            Process.Start(noteFilePath).WaitForExit();
            notes = File.ReadAllText(noteFilePath);

            return notes;
        }

        /// <summary>
        /// Returns the notes list of this release. It contains the change log of all pushes to the "default" 
        /// repository.
        /// </summary>
        private string GetChangelog()
        {
            StringBuilder log = new StringBuilder();
            log.AppendLine("Google .NET Client Library");
            log.AppendLine(string.Format("Stable Release '{0}'", Tag));
            log.AppendLine(DateTime.UtcNow.ToLongDateString());
            log.AppendLine("===========================================");

            log.AppendLine().AppendLine("Changes:");
            foreach (string line in DefaultRepository.CreateChangelist())
            {
                log.AppendLine("  " + line);
            }

            return log.ToString();
        }

        /// <summary>Builds all projects in the "samples" repository.</summary>
        private void BuildSamples()
        {
            // build all the samples projects.
            TraceSource.TraceEvent(TraceEventType.Information, "Building the samples");
            foreach (string csproj in Directory.GetFiles(SamplesRepository.WorkingDirectory, "*.csproj",
                SearchOption.AllDirectories))
            {
                Project project = new Project(csproj);
                project.SetProperty("Configuration", "Release");
                TraceSource.TraceEvent(TraceEventType.Information, "Building {0}", project.GetName());
                bool success = project.Build("Build", new[] { new ConsoleLogger(LoggerVerbosity.Quiet) });
                if (!success)
                {
                    TraceSource.TraceEvent(TraceEventType.Error, "Building {0} FAILED", project.GetName());
                }
                project.Build("Clean");
                TraceSource.TraceEvent(TraceEventType.Information, "Building {0} succeeded", project.GetName());
            }
        }

        /// <summary>Returns <c>true</c> if one of the repositories has incoming changes.</summary>
        private bool HasIncomingChanges(IEnumerable<Hg> repositories)
        {
            foreach (var repository in repositories)
            {
                if (repository.HasIncomingChanges)
                {
                    TraceSource.TraceEvent(TraceEventType.Error,
                        "[{0}] has incoming changes. Run hg pull & update first!", repository.Name);
                    return true;
                }
            }
            return false;
        }

        /// <summary>Creates the core Google.Apis NuGet packages.</summary>
        private void CreateCoreNuGetPackages()
        {
            var currentDir = options.IsLocal
                    ? Environment.CurrentDirectory
                    : Path.Combine(Environment.CurrentDirectory, "default");

            // Create a resource dir in the working folder.
            var destDirectory = Path.Combine(currentDir, "Resources");
            if (Directory.Exists(destDirectory))
            {
                Directory.Delete(destDirectory, true);
            }

            FileInfo info = new FileInfo(Assembly.GetEntryAssembly().Location);
            DirectoryUtilities.CopyDirectory(Path.Combine(info.Directory.FullName, "Resources"), destDirectory);

            var newVersion = Tag;

            foreach (var nuspec in NuspecPackages)
            {
                var pathNuspec = Path.Combine(destDirectory, nuspec);
                var newNuspec = pathNuspec.Replace("VERSION", newVersion);
                File.Move(pathNuspec, newNuspec);

                var allLines = File.ReadAllText(newNuspec).Replace("VERSION", newVersion);
                File.WriteAllText(newNuspec, allLines);

                NuGetUtilities.CreateLocalNupkgFile(newNuspec, currentDir);
            }

            Directory.Delete(destDirectory, true);
        }

        private IEnumerable<Project> releaseProjects;
        /// <summary>Gets the release projects of from the "default" repository.</summary>
        private IEnumerable<Project> ReleaseProjects
        {
            get
            {
                if (releaseProjects != null)
                {
                    return releaseProjects;
                }

                var releasePaths = new[] 
                {
                    DefaultRepository.Combine("Src", "GoogleApis.Core", "GoogleApis.Core.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis", "GoogleApis.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.Auth", "GoogleApis.Auth.csproj"),

                    DefaultRepository.Combine("Src", "GoogleApis.DotNet4", "GoogleApis.DotNet4.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.WinRT", "GoogleApis.WinRT.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.WP", "GoogleApis.WP.csproj"),

                    DefaultRepository.Combine("Src", "GoogleApis.Auth.DotNet4", "GoogleApis.Auth.DotNet4.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.Auth.Mvc4", "GoogleApis.Auth.Mvc4.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.Auth.WinRT", "GoogleApis.Auth.WinRT.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.Auth.WP", "GoogleApis.Auth.WP.csproj"),
                };
                return releaseProjects = (from path in releasePaths
                                          select new Project(path)).ToList();
            }
        }

        /// <summary>Builds the "default" repository projects.</summary>
        /// <returns><c>true</c> if the default repository was build successfully</returns>
        private bool BuildDefaultRepository()
        {
            TraceSource.TraceEvent(TraceEventType.Information, "Building projects....");

            var allProjects = new List<Project>();
            allProjects.AddRange(ReleaseProjects);
            allProjects.Add(new Project(DefaultRepository.Combine("Src", "GoogleApis.Tests",
                "GoogleApis.Tests.csproj")));
            allProjects.Add(new Project(DefaultRepository.Combine("Src", "GoogleApis.Auth.Tests",
                "GoogleApis.Auth.Tests.csproj")));

            foreach (var project in allProjects)
            {
                var name = project.GetName();
                TraceSource.TraceEvent(TraceEventType.Information, "Replacing version for {0}", name);
                project.ReplaceVersion(options.Version);
                project.SetProperty("Configuration", "Release");
                TraceSource.TraceEvent(TraceEventType.Information, "Building {0}", name);
                bool success = project.Build("Build", new[] { new ConsoleLogger(LoggerVerbosity.Quiet) });

                if (success)
                {
                    TraceSource.TraceEvent(TraceEventType.Information, "Building {0} succeeded!", name);
                }
                else
                {
                    TraceSource.TraceEvent(TraceEventType.Error, "Building {0} failed!", name);
                    return false;
                }

                if (!ReleaseProjects.Contains(project))
                {
                    // TODO(peleyal): run unit tests for all test projects
                }
            }

            return true;
        }

        /// <summary>Constructs a new program with the given options.</summary>
        public Program(Options options)
        {
            this.options = options;

            string path = !string.IsNullOrEmpty(options.OutputDirectory) ? Path.GetFullPath(options.OutputDirectory) :
                  Path.Combine(Environment.CurrentDirectory, LocalRepositoryRelativePath);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            Environment.CurrentDirectory = path;
        }
    }
}
