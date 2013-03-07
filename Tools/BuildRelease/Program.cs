/*
Copyright 2011 Google Inc

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
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

using BuildRelease.Wiki;
using Google.Apis.Samples.Helper;
using Google.Build.Utils;
using Google.Build.Utils.Build;
using Google.Build.Utils.Repositories;

namespace BuildRelease
{
    /// <summary>
    /// Release Builder.
    /// Will automatically check out all repositories, run unit tests and create a release.
    /// Can be re-run if the build should fail - Run this tool again, with the same dir argument after fixing the 
    /// problem.
    /// </summary>
    public class Program
    {
        #region Command Line Arguments
        public class CommandLineArguments
        {
            [Argument("version", ShortName = "v",
                Description = "[Required] The version number of this release - <Major.Minor.Build> only.")]
            public string Version { get; set; }

            [Argument("local", ShortName = "l",
                Description = "Uses the local repository instead of checking out a new one. Not releasable.")]
            public bool UseLocalRepository { get; set; }

            [Argument("tag", ShortName = "t",
                Description = "Use this as the tag suffix for this build.")]
            public string Tag { get; set; }

            [Argument("dir", ShortName = "d",
                Description = "Use this as the output directory for this build (relative to current directory). " +
                "If not specified, dir will be set to current date.")]
            public string OutputDirectory { get; set; }

            public override string ToString()
            {
                return string.Format("CommandLineArguments " +
                    "[UseLocalRepository: {0}; Tag: {1}; Dir: {2}; Version: {3}]",
                    UseLocalRepository, Tag, OutputDirectory, Version);
            }
        }

        /// <summary> Command line arguments. </summary>
        public static CommandLineArguments Arguments { get; private set; }

        #endregion

        /// <summary> The "default" repository. </summary>
        public static Hg Default { get; private set; }

        /// <summary> The "samples" repository. </summary>
        public static Hg Samples { get; private set; }

        /// <summary> The "wiki" repository. </summary>
        public static Hg Wiki { get; private set; }

        /// <summary> The "contrib" repository. </summary>
        public static Hg Contrib { get; private set; }

        /// <summary> An array of all relevant mercurial repositories. </summary>
        public static Hg[] AllRepositories { get; private set; }

        /// <summary> The name of the directory containing the working copy. </summary>
        public static string WorkingCopy { get; private set; }

        private static int MajorVersion { get; set; }
        private static int MinorVersion { get; set; }
        private static int BuildVersion { get; set; }

        private static IEnumerable<string> _excludeThirdParties = new[] 
        { 
            "Moq.dll", "Moq.LICENSE", "nunit.framework.dll", "nunit.framework.LICENSE" 
        };

        /// <summary> Points to third party dependencies which will appear in the bundle. </summary>
        public static IEnumerable<string> ThirdPartyFiles
        {
            get
            {
                string dir = Default.Combine("ThirdParty");
                return from file in Directory.GetFiles(dir, "*")
                       where !_excludeThirdParties.Contains(Path.GetFileName(file))
                       select file;
            }
        }

        /// <summary>
        /// The directory containing all the generated services.
        /// </summary>
        public static string ServiceDir
        {
            get { return Samples.Combine("Services"); }
        }

        [STAThread]
        static void Main(string[] args)
        {
            // Try to enlarge the window.
            try
            {
                Console.SetWindowSize(Console.LargestWindowWidth * 8 / 9, Console.LargestWindowHeight * 8 / 9);
            }
            catch (Exception) { }

            CommandLine.DisplayGoogleSampleHeader("Build Release");
            CommandLine.EnableExceptionHandling();

            // Init arguments
            if (!InitArguments(args))
            {
                CommandLine.PressAnyKeyToExit();
                return;
            }

            // Clone repositories
            CheckoutRepositories();

            // Clean up the default/ repository by removing cache-files
            CleanDefaultRepository();

            // Check for incoming changes
            foreach (Hg repository in AllRepositories)
            {
                if (repository.HasIncomingChanges)
                {
                    CommandLine.WriteError(
                        "Repository [{0}] has incoming changes. Run hg pull & update first!", repository.Name);
                    CommandLine.PressAnyKeyToExit();
                    return;
                }
            }

            // Build projects
            FileVersionInfo apiVersion;
            Project[] allProjects;
            Project[] baseLibraries = BuildProjects(out apiVersion, out allProjects);
            Project servicegen = baseLibraries.Where(proj => proj.Name == "GoogleApis.Tools.ServiceGenerator").Single();

            // Create tag
            string tag = GetTagName(apiVersion);

            // Update samples
            UpdateSamples(baseLibraries, servicegen);

            // Update contrib
            string notes = CreateChangelog(tag);
            string zipDir;
            notes = BuildContribRelease(tag, notes, baseLibraries, allProjects, servicegen, out zipDir);

            // Update wiki
            UpdateWiki(notes, zipDir);

            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteResult("Version: ", apiVersion.ProductVersion);
            CommandLine.WriteLine();

            if (Arguments.UseLocalRepository)
            {
                CommandLine.WriteAction("Local build done.");
                CommandLine.PressAnyKeyToExit();
                return;
            }

            // Ask the user whether he wants to continue the release.
            string res = "no";
            CommandLine.WriteLine("   {{gray}}In the next step all changes will be commited, tagged and pushed.");
            CommandLine.WriteLine("   {{gray}}Only continue when you are sure that you don't have to make " +
                "any new changes.");
            CommandLine.RequestUserInput("Do you want to continue with the release? Type YES.", ref res);
            CommandLine.WriteLine();

            if (res != "YES")
            {
                Console.WriteLine("Done - NO CODE was commited, tagged or pushed");
                CommandLine.PressAnyKeyToExit();
                return;
            }

            // Commit
            CommitAndTagRelease(tag);

            // Push
            PushChanges();

            // Create branch
            PrintCreateBranch();

            CommandLine.PressAnyKeyToExit();
        }

        /// <summary> Prints the user orders how to create a branch. </summary>
        private static void PrintCreateBranch()
        {
            if (BuildVersion != 0)
            {
                // No need to branch in that case
                return;
            }

            // TODO(peleyal): automate this as well
            CommandLine.WriteAction("You should create a new branch for this release now:");
            CommandLine.WriteAction("cd " + Default.WorkingDirectory);
            var branchVersion = string.Format("{0}.{1}", MajorVersion, MinorVersion);
            CommandLine.WriteAction("hg branch " + branchVersion);
            CommandLine.WriteAction(string.Format("hg commit -m create {0} branch", branchVersion));
            CommandLine.WriteAction("hg push --new-branch");
        }

        /// <summary> 
        /// Inits the Arguments for this release. 
        /// Returns <code>true</code> if all arguments are valid.
        /// </summary>
        private static bool InitArguments(string[] args)
        {
            // TODO(peleyal): Add default value option on Argument (and then add those values to the definition above)
            Arguments = new CommandLineArguments()
            {
                Tag = "beta",
                UseLocalRepository = false
            };

            // Parse command line arguments.
            CommandLineFlags.ParseArguments(Arguments, args);
            if (string.IsNullOrEmpty(Arguments.Version))
            {
                CommandLine.WriteError("Version number can't be null");
                return false;
            }

            var match = Regex.Match(Arguments.Version, @"^(\d+)\.(\d+)\.(\d)+$");
            if (!match.Success)
            {
                CommandLine.WriteError("Invalid version Number. Version should be in <Major>.<Minor>.<Build> form.");
                return false;
            }

            MajorVersion = int.Parse(match.Groups[1].Value);
            MinorVersion = int.Parse(match.Groups[2].Value);
            BuildVersion = int.Parse(match.Groups[3].Value);

            // Create the name of the local working copy.
            if (String.IsNullOrEmpty(Arguments.OutputDirectory))
            {
                Arguments.OutputDirectory = DateTime.UtcNow.ToString("yyyy-MM-dd-hh-mm-ss");
            }

            string fullPath = Path.GetFullPath(Arguments.OutputDirectory);
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }

            Environment.CurrentDirectory = WorkingCopy = fullPath;
            CommandLine.WriteLine(Arguments.ToString());

            return true;
        }

        /// <summary> Cleans the default repository from user files ('resharper', '.user', etc.). </summary>
        private static void CleanDefaultRepository()
        {
            string toDelete = Default.Combine("_ReSharper.GoogleApisClient");
            if (Directory.Exists(toDelete))
            {
                Directory.Delete(toDelete, true);
            }
            foreach (string pattern in new[] { "*.dotcover", "*.user", "*.suo" })
            {
                foreach (string file in Directory.GetFiles(Default.WorkingDirectory, pattern))
                {
                    File.Delete(file);
                }
            }
        }

        /// <summary> Checks out all repositories. </summary>
        private static void CheckoutRepositories()
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Checking out repositories");
            CommandLine.WriteLine("{{white}} =======================================");
            const string URL = "https://code.google.com/p/google-api-dotnet-client{0}/";

            if (Arguments.UseLocalRepository)
            {
                CommandLine.WriteAction("Using local Default repository. This won't release!");
                Default = Hg.Get("../../../../../", string.Format(URL, ""));
            }
            else
            {
                Default = Hg.Get("default", string.Format(URL, ""));
                if (BuildVersion != 0)
                {
                    Default.Update(string.Format("{0}.{1}", MajorVersion, MinorVersion));
                }
            }

            Samples = Hg.Get("samples", string.Format(URL, ".samples"));
            Wiki = Hg.Get("wiki", string.Format(URL, ".wiki"));
            Contrib = Hg.Get("contrib", string.Format(URL, ".contrib"));
            AllRepositories = new[] { Default, Wiki, Contrib, Samples };

            CommandLine.WriteLine();
        }

        /// <summary> 
        /// Builds projects.
        /// In addition runs UnitTest for testing projects.
        /// </summary>
        private static Project[] BuildProjects(out FileVersionInfo apiVersion, out Project[] allProjects)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Building the Projects");
            CommandLine.WriteLine("{{white}} =======================================");

            var projects = new List<Project>();
            Project baseApi = new Project(Default.Combine("Src", "GoogleApis", "GoogleApis.csproj"));

            Project baseApiSilverlight = new Project(Default.Combine("Src", "GoogleApis",
                "GoogleApis.Silverlight.csproj"));
            Project codegen = new Project(Default.Combine("Src", "GoogleApis.Tools.CodeGen",
                "GoogleApis.Tools.CodeGen.csproj"));
            Project oauth2 = new Project(Default.Combine("Src", "GoogleApis.Authentication.OAuth2",
                "GoogleApis.Authentication.OAuth2.csproj"));
            Project generator = new Project(Default.Combine("GoogleApis.Tools.ServiceGenerator",
                "GoogleApis.Tools.ServiceGenerator.csproj"));

            var releaseProjects = new[] { baseApi, baseApiSilverlight, codegen, oauth2, generator };
            projects.AddRange(releaseProjects);
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Tests.Utility",
                "GoogleApis.Tests.Utility.csproj")));
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Tests", "GoogleApis.Tests.csproj")));
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Tools.CodeGen.Tests",
                "GoogleApis.Tools.CodeGen.Tests.csproj")));
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Authentication.OAuth2.Tests",
                "GoogleApis.Authentication.OAuth2.Tests.csproj")));
            projects.Add(new Project(Default.Combine("GoogleApis.Tools.CodeGen.IntegrationTests",
                "GoogleApis.Tools.CodeGen.IntegrationTests.csproj")));

            foreach (Project proj in projects)
            {
                proj.ReplaceVersion(Arguments.Version);
                proj.RunBuildTask();
                if (!releaseProjects.Contains(proj)) // If this assembly may contain tests, then run them.
                {
                    RunUnitTest(proj.BinaryFile);
                }
            }

            CommandLine.WriteLine();
            apiVersion = FileVersionInfo.GetVersionInfo(baseApi.BinaryFile);
            allProjects = projects.ToArray();
            return releaseProjects;
        }

        /// <summary>
        /// Runs the unit tester on the specified assembly.
        /// </summary>
        /// <remarks>Called from extern assemblies.</remarks>
        public static void RunUnitTest(string assembly)
        {
            // Run the unit tester.
            try
            {
                new Runner(Google.Build.Tester.Program.BinPath, assembly).Run();
            }
            catch (ExternalException ex)
            {
                CommandLine.WriteError(" {0} tests failed.", ex.ErrorCode < 0 ? "Loading" : ex.ErrorCode.ToString());
                if (!CommandLine.RequestUserChoice("Do you want to continue anyway?"))
                {
                    throw;
                }
            }
        }

        /// <summary> Gets tag name by the given release version. </summary>
        private static string GetTagName(FileVersionInfo releaseVersion)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Creating Tag for the release");
            CommandLine.WriteLine("{{white}} =======================================");

            if (Arguments.UseLocalRepository)
            {
                return "date-version-local";
            }

            string tag = Arguments.Version;
            if (!string.IsNullOrEmpty(Arguments.Tag))
            {
                tag += "-" + Arguments.Tag;
            }

            CommandLine.WriteResult("Tag", tag);
            CommandLine.WriteLine();
            return tag;
        }

        /// <summary> Returns all changelist notes for this release. </summary>
        private static string CreateChangelog(string tag)
        {
            StringBuilder log = new StringBuilder();
            log.AppendLine("Google .NET Client Library");
            log.AppendLine(string.Format("Stable Release '{0}'", tag));
            log.AppendLine(DateTime.UtcNow.ToLongDateString());
            log.AppendLine("===========================================");

            log.AppendLine();
            log.AppendLine("Changes:");
            foreach (string line in Default.CreateChangelist())
            {
                log.AppendLine("  " + line);
            }

            return log.ToString();
        }

        /// <summary> Udates the samples repository. </summary>
        private static void UpdateSamples(IEnumerable<Project> releaseProjects, Project serviceGenerator)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Updating Samples");
            CommandLine.WriteLine("{{white}} =======================================");

            // Update all the dependencies.
            string libDir = Samples.Combine("Lib");
            DirUtils.ClearDir(libDir);

            foreach (Project p in releaseProjects)
            {
                p.CopyTo(libDir);
            }

            string thirdpartyDir = Samples.Combine("Lib", "ThirdParty");
            Directory.CreateDirectory(thirdpartyDir);
            foreach (string file in ThirdPartyFiles)
            {
                DirUtils.CopyFile(file, thirdpartyDir);
            }

            // Generate all strongly typed services.
            DirUtils.ClearDir(ServiceDir);
            var runner = new Runner(
                serviceGenerator.BinaryFile, "--google", "--output", ServiceDir, "repository");
            runner.WorkingDirectory = Path.GetDirectoryName(serviceGenerator.BinaryFile);
            runner.Run();

            // Build all the samples projects.
            CommandLine.WriteAction("Building samples...");
            foreach (string csproj in
                Directory.GetFiles(Samples.WorkingDirectory, "*.csproj", SearchOption.AllDirectories))
            {
                Project project = new Project(csproj);
                project.RunBuildTask();
                project.Clean();
            }
            CommandLine.WriteLine();
        }

        /// <summary>
        /// Builds the Releases in the Contrib repository.
        /// Depends on: 
        ///     - Compiled BaseLibrary
        ///     - Updated Sample repository
        ///     - Existing release tag name
        /// </summary>
        /// <returns>Edited changelog.</returns>
        private static string BuildContribRelease(string tag,
                                                  string changelog,
                                                  IEnumerable<Project> baseLibrary,
                                                  IEnumerable<Project> allProjects,
                                                  Project serviceGenerator,
                                                  out string zipDir)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Building Contrib-Release");
            CommandLine.WriteLine("{{white}} =======================================");

            string releaseDir = Contrib.Combine(tag);
            string currentDir = Contrib.Combine("Current");

            // Clear existing directories.
            DirUtils.ClearOrCreateDir(releaseDir);
            // TODO(peleyal): remove currentDir eventually (after at least one or two releases)
            DirUtils.ClearOrCreateDir(currentDir);

            // Create the <current> release
            string genDir = Path.Combine(currentDir, "Generated");
            Directory.CreateDirectory(genDir);

            #region Current/Generated/Bin
            string binDir = Path.Combine(genDir, "Bin");
            CommandLine.WriteAction("Generating dir: " + DirUtils.GetRelativePath(binDir, Contrib.WorkingDirectory));
            Directory.CreateDirectory(binDir);
            {
                // Copy all third party dlls into this directory.
                foreach (string file in ThirdPartyFiles)
                {
                    DirUtils.CopyFile(file, binDir);
                }

                // Copy all release dlls to this directory.
                foreach (Project project in baseLibrary)
                {
                    project.CopyTo(binDir);
                }
            }
            #endregion

            #region Current/ZipFiles
            string zipFilesDir = Path.Combine(genDir, "ZipFiles");
            CommandLine.WriteAction("Generating dir: " +
                DirUtils.GetRelativePath(zipFilesDir, Contrib.WorkingDirectory));
            Directory.CreateDirectory(zipFilesDir);
            {
                // clean all projects
                foreach (Project project in allProjects)
                {
                    project.Clean();
                }

                // Source.zip
                using (Zip zip = new Zip(Path.Combine(zipFilesDir, "Source.zip")))
                {
                    zip.AddDirectory(Default.WorkingDirectory, "");
                    zip.RemoveDirectory(".hg");
                    zip.RemoveFile(".hgtags");
                    zip.RemoveFile(".hgignore");
                }

                // Binary.zip
                using (Zip zip = new Zip(Path.Combine(zipFilesDir, "Binary.zip")))
                {
                    zip.AddDirectory(binDir, "");
                }

                // Samples.zip
                using (Zip zip = new Zip(Path.Combine(zipFilesDir, "Samples.zip")))
                {
                    zip.AddDirectory(Samples.WorkingDirectory, "");
                    zip.RemoveDirectory(".hg");
                    zip.RemoveFile(".hgtags");
                    zip.RemoveFile(".hgignore");
                }
            }
            #endregion

            #region Current/ReleaseNotes.txt
            CommandLine.WriteAction("Writing file...");
            string changelogFile = Path.Combine(currentDir, "ReleaseNotes.txt");
            using (var writer = new StreamWriter(changelogFile, false))
            {
                writer.WriteLine(changelog);
            }
            #endregion

            // Open the created changelog.
            CommandLine.WriteAction("Showing result...");
            Process.Start(changelogFile).WaitForExit();

            // Copy the content to the <tagname> release directory.
            DirUtils.CopyFiles(currentDir, releaseDir);

            // Rename the zips in the named release.
            // Example: Binary.zip -> google-api-dotnet-client-1.0.0-beta.Binary.zip
            string fileFormat = "google-api-dotnet-client-" + tag + ".{0}";
            zipDir = zipFilesDir.Replace(currentDir, releaseDir);
            foreach (string file in Directory.GetFiles(zipDir, "*.zip"))
            {
                string dir = Path.GetDirectoryName(file);
                string newFile = string.Format(fileFormat, Path.GetFileName(file).ToLower());
                File.Move(file, Path.Combine(dir, newFile));
            }

            CommandLine.WriteLine();
            return File.ReadAllText(changelogFile);
        }

        /// <summary> Updates wiki Downloads page. </summary>
        private static void UpdateWiki(string releaseNotes, string zipDir)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Updating the Wiki");
            CommandLine.WriteLine("{{white}} =======================================");

            new DownloadsPage(releaseNotes, zipDir).UpdateWiki(Wiki.WorkingDirectory);

            CommandLine.WriteLine();
        }

        /// <summary> Commits and Tags this release with the given tag </summary>
        private static void CommitAndTagRelease(string tag)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Tagging the release");
            CommandLine.WriteLine("{{white}} =======================================");

            foreach (Hg repository in AllRepositories)
            {
                repository.AddUnversionedFiles();
                repository.RemoveDeletedFiles();
                bool madeCommit = repository.Commit("Release " + tag);
                if (repository == Default || madeCommit)
                {
                    try
                    {
                        repository.Tag(tag, false);
                    }
                    catch (Exception ex)
                    {
                        CommandLine.WriteError("Tagging Failed with message {0}", ex.Message);
                        string response = "yes";
                        CommandLine.RequestUserInput("Do you want to force the label?", ref response);
                        if (response.ToLower() == "yes")
                        {
                            repository.Tag(tag, true);
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
            CommandLine.WriteLine();
        }

        /// <summary> Pushes the changes in all repositories. </summary>
        private static void PushChanges()
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Pushing changes");
            CommandLine.WriteLine("{{white}} =======================================");

            foreach (Hg repository in AllRepositories)
            {
                repository.Push();
            }

            CommandLine.WriteLine();
        }
    }
}
