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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Google.Apis.Samples.Helper;
using Google.Build.Utils;
using Google.Build.Utils.Build;
using Google.Build.Utils.Repositories;
using Google.Build.Utils.Text;

namespace BuildRelease
{
    /// <summary>
    /// Release Builder.
    /// Will automatically check out all repositories, run unit tests and create a release.
    /// Can be re-run if the build should fail.
    /// </summary>
    public class Program
    {
        #region Command Line Arguments
        public class CommandLineArguments
        {
            [CommandLine.Argument("local", ShortName = "l",
                Description = "Uses the local repository instead of checking out a new one. Not releasable.")]
            public bool UseLocalRepository { get; set; }

            [CommandLine.Argument("stable", ShortName = "s",
                Description = "Creates a stable release instead of a development build.")]
            public bool IsStableRelease { get; set; }

            [CommandLine.Argument("tag", ShortName = "t",
                Description = "Use this as the tag suffix for this build.")]
            public string Tag { get; set; }

            /// <summary>
            /// True if this repository set can be used to build a full release.
            /// </summary>
            public bool CanRelease
            {
                get { return UseLocalRepository; }
            }
        }

        /// <summary>
        /// Command line arguments.
        /// </summary>
        public static CommandLineArguments Arguments { get; private set; }

        #endregion

        /// <summary>
        /// The "default" repository.
        /// </summary>
        public static Hg Default { get; private set; }

        /// <summary>
        /// The "samples" repository.
        /// </summary>
        public static Hg Samples { get; private set; }

        /// <summary>
        /// The "wiki" repository.
        /// </summary>
        public static Hg Wiki { get; private set; }

        /// <summary>
        /// The "contrib" repository.
        /// </summary>
        public static Hg Contrib { get; private set; }

        /// <summary>
        /// An array of all relevant mercurial repositories.
        /// </summary>
        public static Hg[] AllRepositories { get; private set; }

        /// <summary>
        /// The name of the directory containing the working copy.
        /// </summary>
        public static string WorkingCopy { get; private set; }

        /// <summary>
        /// Extracts the version and name part out of the specified tag.
        /// </summary>
        /// <param name="tag">date-version-name</param>
        /// <returns></returns>
        public static string ExtractTagVersionAndName(string tag)
        {
            return tag.Substring(tag.IndexOf('-') + 1);
        }

        /// <summary>
        /// Points to third party dependencies.
        /// </summary>
        public static string[] ThirdPartyFiles
        {
            get
            {
                var files = new List<string>();
                string dir = Default.Combine("ThirdParty");
                foreach (string file in Directory.GetFiles(dir, "*"))
                {
                    switch (Path.GetFileName(file))
                    {
                        case "Moq.dll":
                        case "Moq.LICENSE":
                        case "NAnt.Core.dll":
                        case "NAnt.Core.GNU.LICENSE":
                        case "NAnt.Core.LICENSE":
                        case "nunit.framework":
                        case "nunit.framework.LICENSE":
                            continue; // Skip those files. They are not required for normal operation.
                        default:
                            files.Add(file);
                            break;
                    }
                }
                //files.Add(typeof(System.Web.UI.MobileControls.TextBox).Assembly.GetCodebasePath());
                return files.ToArray();
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
            } catch (Exception) {}

            // Create the name of the local working copy.
            string workingCopy = DateTime.UtcNow.ToString("d", CultureInfo.CreateSpecificCulture("en-US")).Replace('/', '-');
            string fullPath = Path.GetFullPath(workingCopy);
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }

            Environment.CurrentDirectory = WorkingCopy = fullPath;
            CommandLine.DisplayGoogleSampleHeader("Release Builder: "+workingCopy);
            CommandLine.EnableExceptionHandling();

            // Parse command line arguments.
            CommandLine.ParseArguments(Arguments = new CommandLineArguments(), args);

            // 1. Create the local repositories.
            CheckoutRepositories();

            // Clean up the default/ repository by removing cache-files.
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

            // 2. Create the project/build tasks.
            FileVersionInfo apiVersion;
            Project[] allProjects;
            Project[] baseLibrary = BuildProjects(out apiVersion, out allProjects);
            Project servicegen = baseLibrary.Where(proj => proj.Name == "GoogleApis.Tools.ServiceGenerator").Single();

            // Retrieve tag name.
            string tag = GetTagName(apiVersion);
            
            if (Arguments.IsStableRelease)
            {
                UpdateSamples(baseLibrary, servicegen);
            }

            // 4. Build contrib.
            string notes = CreateChangelog(tag);
            string zipDir;
            notes = BuildContribRelease(tag, notes, baseLibrary, allProjects, servicegen, out zipDir);

            // 5. Update the Wiki.
            if (Arguments.IsStableRelease)
            {
                UpdateWiki(notes, zipDir);
            }

            // Ask the user whether he wants to continue the release.
            string res = "no";
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteResult("Version: ", apiVersion.ProductVersion);
            CommandLine.WriteLine();

            if (Arguments.UseLocalRepository)
            {
                CommandLine.WriteAction("Local build done.");
                CommandLine.PressAnyKeyToExit();
                return;
            }

            // 6. Commit & tag the release
            CommitAndTagRelease(tag);

            CommandLine.WriteLine("   {{gray}}In the next step all changes will be commited and tagged.");
            CommandLine.WriteLine("   {{gray}}Only continue when you are sure that you don't have to make any new changes.");
            CommandLine.RequestUserInput("Do you want to continue with the release? Type YES.", ref res);
            CommandLine.WriteLine();
            if (res == "YES")
            {
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

                // 7. Push
                PushChanges();
            }
            CommandLine.PressAnyKeyToExit();
        }

        
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
            }

            Samples = Hg.Get("samples", string.Format(URL, ".samples"));
            Wiki = Hg.Get("wiki", string.Format(URL, ".wiki"));
            Contrib = Hg.Get("contrib", string.Format(URL, ".contrib"));
            AllRepositories = new[] { Default, Wiki, Contrib, Samples };

            CommandLine.WriteLine();
        }

        private static Project[] BuildProjects(out FileVersionInfo apiVersion, out Project[] allProjects)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Building the Projects");
            CommandLine.WriteLine("{{white}} =======================================");
            
            var projects = new List<Project>();
            Project baseApi = new Project(Default.Combine("Src", "GoogleApis", "GoogleApis.csproj"));
            Project baseApiSilverlight = new Project(Default.Combine("Src", "GoogleApis", "GoogleApis.Silverlight.csproj"));
            Project codegen = new Project(Default.Combine("Src", "GoogleApis.Tools.CodeGen", "GoogleApis.Tools.CodeGen.csproj"));
            Project oauth2 = new Project(Default.Combine("Src", "GoogleApis.Authentication.OAuth2", "GoogleApis.Authentication.OAuth2.csproj"));
            Project generator = new Project(Default.Combine("GoogleApis.Tools.ServiceGenerator", "GoogleApis.Tools.ServiceGenerator.csproj"));

            var releaseProjects = new[] { baseApi, baseApiSilverlight, codegen, oauth2, generator };
            projects.AddRange(releaseProjects);
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Tests.Utility", "GoogleApis.Tests.Utility.csproj")));
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Tests", "GoogleApis.Tests.csproj")));
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Tools.CodeGen.Tests", "GoogleApis.Tools.CodeGen.Tests.csproj")));
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Authentication.OAuth2.Tests", "GoogleApis.Authentication.OAuth2.Tests.csproj")));
            projects.Add(new Project(Default.Combine("GoogleApis.Tools.CodeGen.IntegrationTests", "GoogleApis.Tools.CodeGen.IntegrationTests.csproj")));

            foreach (Project proj in projects)
            {
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

        private static string GetTagName(FileVersionInfo releaseVersion)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Creating Tag for the release");
            CommandLine.WriteLine("{{white}} =======================================");

            if (Arguments.UseLocalRepository)
            {
                return "date-version-local";
            }

            DateTime releaseDate = DateTime.UtcNow;
            string tag = string.Format("{0:D4}{1:D2}{2:D2}-{3}.{4}.{5}",
                                       releaseDate.Year,
                                       releaseDate.Month,
                                       releaseDate.Day,
                                       releaseVersion.ProductMajorPart,
                                       releaseVersion.ProductMinorPart,
                                       releaseVersion.ProductBuildPart);

            if (!string.IsNullOrEmpty(Arguments.Tag))
            {
                tag += "-" + Arguments.Tag;
            }

            CommandLine.WriteResult("Tag", tag);
            CommandLine.WriteLine();
            return tag;
        }

        private static string CreateChangelog(string tag)
        {
            StringBuilder log = new StringBuilder();
            log.AppendLine("Google .NET Client Library");
            log.AppendLine(string.Format("{0}Release '{1}'", Arguments.IsStableRelease ? "Stable " : "", tag));
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
            string stableDir = Contrib.Combine("Stable");

            // Clear existing directories.
            DirUtils.ClearOrCreateDir(releaseDir);
            DirUtils.ClearOrCreateDir(currentDir);
            if (Arguments.IsStableRelease)
            {
                DirUtils.ClearOrCreateDir(stableDir);
            }

            // Create the <current> release
            string genDir = Path.Combine(currentDir, "Generated");
            Directory.CreateDirectory(genDir);

            #region Current/Generated/Lib
            string libDir = Path.Combine(genDir, "Lib");
            CommandLine.WriteAction("Generating dir: "+DirUtils.GetRelativePath(libDir, Contrib.WorkingDirectory));
            Directory.CreateDirectory(libDir);
            {
                // Copy all third party dlls into this directory.
                foreach (string file in ThirdPartyFiles)
                {
                    DirUtils.CopyFile(file, libDir);
                }

                // Copy all release dlls to this directory.
                foreach (Project project in baseLibrary)
                {
                    project.CopyTo(libDir);
                }
            }
            #endregion

            #region Current/Generated/Bin - and - Current/Generated/Source
            string binDir = Path.Combine(genDir, "Bin");
            string sourceDir = Path.Combine(genDir, "Source");
            CommandLine.WriteAction("Generating dir: " + DirUtils.GetRelativePath(binDir, Contrib.WorkingDirectory));
            CommandLine.WriteAction("Generating dir: " + DirUtils.GetRelativePath(sourceDir, Contrib.WorkingDirectory));
            Directory.CreateDirectory(binDir);
            Directory.CreateDirectory(sourceDir);
            {
                // Iterate through all services, and put them into the right directory
                string[] toBin = new[] { ".dll", ".xml", ".pdb" };
                string[] toSrc = new[] { ".cs" };

                foreach (string file in Directory.GetFiles(ServiceDir, "*"))
                {
                    string fileName = Path.GetFileName(file);
                    CommandLine.WriteResult("File", fileName);
                    string ext = Path.GetExtension(fileName).ToLower();
                    if (toSrc.Contains(ext)) // Copy this file into the "Source" directory.
                    {
                        DirUtils.CopyFile(file, sourceDir);
                    }
                    if (toBin.Contains(ext)) // Copy this file into the "Binary" directory.
                    {
                        // Get the folder name by looking at the .dll assembly info.
                        string id = FileVersionInfo.GetVersionInfo(Path.ChangeExtension(file, ".dll")).ProductName;
                        string serviceName = id.Split(':')[0]; // "buzz:v1" -> "buzz"
                        string folderName = serviceName.ToUpperFirstChar() + "Service"; // "buzz" -> "BuzzService"

                        // Copy the file there.
                        string folder = Path.Combine(binDir, folderName);
                        DirUtils.CopyFile(file, folder);
                    }
                }
            }
            
            #endregion

            #region Current/ZipFiles
            string zipFilesDir = Path.Combine(genDir, "ZipFiles");
            CommandLine.WriteAction("Generating dir: " + DirUtils.GetRelativePath(zipFilesDir, Contrib.WorkingDirectory));
            Directory.CreateDirectory(zipFilesDir);
            {
                
                
                // Source.zip
                foreach (Project project in allProjects)
                {
                    project.Clean();
                }
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
                    zip.AddDirectory(binDir, "Services");
                    zip.AddDirectory(libDir, "Lib");
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
            if (Arguments.IsStableRelease)
            {
                DirUtils.CopyFiles(currentDir, stableDir);
            }

            // Rename the zips in the named release.
            // Example: Binary.zip -> google-api-dotnet-client-1.0.0-beta.Binary.zip
            string fileFormat = "google-api-dotnet-client-" + ExtractTagVersionAndName(tag) + ".{0}";
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

        private static void UpdateWiki(string releaseNotes, string zipDir)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Updating the Wiki");
            CommandLine.WriteLine("{{white}} =======================================");

            UpdateWikiLists.Program.UpdateWiki(Wiki, Samples, releaseNotes, zipDir);

            CommandLine.WriteLine();
        }
        
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
                    repository.Tag(tag);
                }
            }
            CommandLine.WriteLine();
        }

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
