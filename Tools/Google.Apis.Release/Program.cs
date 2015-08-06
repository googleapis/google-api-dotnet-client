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
                "'2' for publishing the packages to NuGet and tagging the release.";
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
        private Git DefaultRepository { get; set; }

        /// <summary>Gets or sets the "samples" repository.</summary>
        private Git SamplesRepository { get; set; }

        /// <summary>Gets all four repositories.</summary>
        private IEnumerable<Git> AllRepositories
        {
            get { return new List<Git> { DefaultRepository, SamplesRepository }; }
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
        private const string CloneUrlFormat = "https://github.com/google/google-api-dotnet-client{0}";

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
            DefaultRepository = new Git(new Uri(string.Format(CloneUrlFormat, "")), options.IsLocal ? null : "default");

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
            // If there are incoming changes those changes will be printed, otherwise we can continue in the process.
            if (!HasIncomingChanges(new List<Git> { DefaultRepository }))
            {
                if (BuildDefaultRepository())
                {
                    Console.WriteLine("Make sure you build the packages manually in 'ReleaseSigned' mode.");
                    CreateCoreNuGetPackages();
                }
            }
        }

        /// <summary>
        /// Doing Step 2 of the release process which includes the following:
        /// <list type="number">
        /// <item><description>Builds samples</description></item>
        /// <item><description>Creates a release notes</description></item>
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

            SamplesRepository = new Git(new Uri(string.Format(CloneUrlFormat, "-samples")), "samples");

            // if there are incoming changes those changes will be printed, otherwise we can continue in the 
            // process
            if (!HasIncomingChanges(AllRepositories))
            {
                // TODO(peleyal): Currently samples don't compile, compile&build manually. INVESTIGATE!
                // BuildSamples();
                var notes = GetChangelog();
                // TODO(peleyal): Save notes to some file, its content should be used by
                // https://developers.google.com/api-client-library/dotnet/release_notes.

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
                foreach (Git repository in AllRepositories)
                {
                    repository.Push();
                }

                // create branch
                PrintCreateBranch();

                // publish core components to NuGet
                if (!string.IsNullOrEmpty(options.NuGetApiKey))
                {
                    PublishCorePackagesToNuGet();
                    PublishGeneratedPackagesToNuGet();
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
        private void PublishCorePackagesToNuGet()
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
        /// Publishes the generated packages for this release to NuGet main repository. It publishes any generated
        /// package in <see cref="NuGetUtilities.LocalNuGetPackageFolder"/> that contains the current version in its
        /// package name (e.g. it looks for any nupkg file that contains "1.9.2").
        /// </summary>
        private void PublishGeneratedPackagesToNuGet()
        {
            var corePacakges = from nuspec in NuspecPackages
                               select Path.Combine(NuGetUtilities.LocalNuGetPackageFolder,
                                                   nuspec.Replace("VERSION", Tag).Replace("nuspec", "nupkg"));
            var generatedPackages = from nuspec in Directory.GetFiles(NuGetUtilities.LocalNuGetPackageFolder)
                                    where nuspec.Contains(Tag) && !corePacakges.Contains(nuspec)
                                    select nuspec;
            foreach (var nupkg in generatedPackages)
            {
                NuGetUtilities.PublishToNuget(nupkg, options.NuGetApiKey);
            }
        }

        /// <summary>Displays the user orders about creating a new branch for this release.</summary>
        private void PrintCreateBranch()
        {
            Console.WriteLine("Go the github repository and create a new branch for this version.");
        }

        /// <summary>Commits all changes in all repositories and tags the "default" repository.</summary>
        private void CommitAndTag()
        {
            foreach (var repository in AllRepositories)
            {
                TraceSource.TraceEvent(TraceEventType.Information, "{0} - Committing", repository.Name);

                bool committed = repository.Commit("Release " + Tag);
                if (committed)
                {
                    try
                    {
                        repository.Tag(Tag);
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
        private bool HasIncomingChanges(IEnumerable<Git> repositories)
        {
            foreach (var repository in repositories)
            {
                if (repository.HasIncomingChanges)
                {
                    TraceSource.TraceEvent(TraceEventType.Error,
                        "[{0}] has incoming changes. Run Git pull & update first!", repository.Name);
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
                    DefaultRepository.Combine("Src", "GoogleApis.Windows", "GoogleApis.Windows.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.WP", "GoogleApis.WP.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.WP81", "GoogleApis.WP81.csproj"),


                    DefaultRepository.Combine("Src", "GoogleApis.Auth.DotNet4", "GoogleApis.Auth.DotNet4.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.Auth.Mvc4", "GoogleApis.Auth.Mvc4.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.Auth.Windows", "GoogleApis.Auth.Windows.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.Auth.WP", "GoogleApis.Auth.WP.csproj"),
                    DefaultRepository.Combine("Src", "GoogleApis.Auth.WP81", "GoogleApis.Auth.WP81.csproj"),
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
                
                // TODO(peleyal): Currently some projects can't build. Build manually for now! That's why the following
                // if statement is commented out. INVESTIGATE!
                /*
                project.SetProperty("Configuration", "ReleaseSigned");
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
                */

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
