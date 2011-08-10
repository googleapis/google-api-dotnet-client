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
using Google.Apis.Samples.Helper;
using Google.Build.Utils;
using Google.Build.Utils.Build;
using Google.Build.Utils.Repositories;
using Google.Build.Utils.Text;

namespace BuildRelease
{
    public class Program
    {
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
                        case "NAnt.Core.dll":
                        case "nunit.framework":
                            continue; // Skip those files. They are not required for normal operation.
                        default:
                            files.Add(file);
                            break;
                    }
                }
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
            // Try to enlarge the window
            try
            {
                Console.SetWindowSize(Console.LargestWindowWidth * 8 / 9, Console.LargestWindowHeight * 8 / 9);
            } catch (Exception expected) {}

            // Create the name of the local working copy.
            WorkingCopy = DateTime.UtcNow.ToString("d", CultureInfo.CreateSpecificCulture("en-US")).Replace('/', '-');
            string fullPath = Path.GetFullPath(WorkingCopy);
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }

            Environment.CurrentDirectory = Path.GetFullPath(WorkingCopy);
            CommandLine.DisplayGoogleSampleHeader("Release Builder: "+WorkingCopy);
            CommandLine.EnableExceptionHandling();

            // 1. Create the local repositories.
            CheckoutRepositories();

            // Ask the user whether he wants to start the build
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine();
            CommandLine.WriteLine(" {{gray}}Repositories checked out. Start the build?");
            CommandLine.WriteLine(" {{gray}}(Change the AssemblyVersion before starting the build)");
            CommandLine.PressEnterToContinue();
            CommandLine.WriteLine();

            // 2. Create the project/build tasks
            FileVersionInfo apiVersion;
            Project[] allProjects;
            Project[] baseLibrary = BuildProjects(out apiVersion, out allProjects);
            Project codegen = baseLibrary.Where(proj => proj.Name == "GoogleApis.Tools.CodeGen").Single();
            
            // Retrieve tag name
            string tag = GetTagName(apiVersion);

            // 3. Update & Build the samples
            Project servicegen = UpdateServiceGenerator(codegen);
            UpdateSamples(baseLibrary, servicegen);

            // 4. Build contrib
            BuildContribRelease(tag, baseLibrary, allProjects);

            // 5. Update the Wiki
            UpdateWiki();

            // Ask the user whether he wants to continue the release.
            string res = "no";
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteResult("Version: ", apiVersion.ProductVersion);
            CommandLine.WriteLine();
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

                // 5. Commit & tag the release
                CommitAndTagRelease(tag);

                // 6. Push
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
            Default = Hg.Get("default", string.Format(URL, ""));
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
            Project codegen = new Project(Default.Combine("Src", "GoogleApis.Tools.CodeGen", "GoogleApis.Tools.CodeGen.csproj"));
            Project oauth2 = new Project(Default.Combine("Src", "GoogleApis.Authentication.OAuth2", "GoogleApis.Authentication.OAuth2.csproj"));

            var releaseProjects = new[] { baseApi, codegen, oauth2 };
            projects.AddRange(releaseProjects);
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Tests", "GoogleApis.Tests.csproj")));
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Tools.CodeGen.Tests", "GoogleApis.Tools.CodeGen.Tests.csproj")));
            projects.Add(new Project(Default.Combine("Src", "GoogleApis.Authentication.OAuth2.Tests", "GoogleApis.Authentication.OAuth2.Tests.csproj")));
            projects.Add(new Project(Default.Combine("GoogleApis.Tools.CodeGen.IntegrationTests", "GoogleApis.Tools.CodeGen.IntegrationTests.csproj")));

            foreach (Project proj in projects)
            {
                proj.RunBuildTask();
                Google.Build.Tester.Program.Run(proj.BinaryFile);
            }

            CommandLine.WriteLine();
            apiVersion = FileVersionInfo.GetVersionInfo(baseApi.BinaryFile);
            allProjects = projects.ToArray();
            return releaseProjects;
        }

        private static string GetTagName(FileVersionInfo releaseVersion)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Creating Tag for the release");
            CommandLine.WriteLine("{{white}} =======================================");

            const string tagFile = "release.tag";

            if (File.Exists(tagFile))
            {
                string existing = File.ReadAllText(tagFile);
                CommandLine.WriteResult("Existing tag", existing);
                CommandLine.WriteLine();
                return existing;
            }

            DateTime releaseDate = DateTime.UtcNow;
            string tag = string.Format("{0:D4}{1:D2}{2:D2}-{3}.{4}.{5}",
                                       releaseDate.Year,
                                       releaseDate.Month,
                                       releaseDate.Day,
                                       releaseVersion.ProductMajorPart,
                                       releaseVersion.ProductMinorPart,
                                       releaseVersion.ProductBuildPart);

            // Add a suffix?
            string suffix = "";
            CommandLine.RequestUserInput("Tag suffix", ref suffix);
            if (!string.IsNullOrEmpty(suffix))
            {
                tag += "-" + suffix;
            }

            CommandLine.WriteResult("Tag", tag);
            File.WriteAllText(tagFile, tag);
            CommandLine.WriteLine();
            return tag;
        }

        /// <summary>
        /// Migrates the service generator to the newest version. This is achieved by first creating its own
        /// dependency using the new CodeGen.dll.
        /// </summary>
        /// <param name="codegenProject">The project pointing to the CodeGenerator.dll</param>
        /// <returns>Project pointing to the ServiceGenerator.exe</returns>
        private static Project UpdateServiceGenerator(Project codegenProject)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Updating the ServiceGenerator");
            CommandLine.WriteLine("{{white}} =======================================");

            // Update the *.Codegen.dll.
            string destFile = Samples.Combine("Lib", Path.GetFileName(codegenProject.BinaryFile));
            File.Copy(codegenProject.BinaryFile, destFile, true);

            try
            {
                // Build the ServiceGenerator.
                Project serviceGenerator =
                    new Project(Samples.Combine("ServiceGenerator", "GoogleApis.ServiceGenerator.csproj"));
                serviceGenerator.RunBuildTask();

                // Generate its own discovery dependency.
                var runner = new Runner(serviceGenerator.BinaryFile , "--non-interactive", "-c", "-o=" + ServiceDir, "discovery", "v1");
                runner.WorkingDirectory = Path.GetDirectoryName(serviceGenerator.BinaryFile);
                runner.Run();

                CommandLine.WriteLine();
                return serviceGenerator;
            } catch (Exception)
            {
                CommandLine.WriteLine();
                CommandLine.WriteError("Automatic migration of the ServiceGenerator has failed!");
                CommandLine.WriteError("Please fix the Discovery dependency of the generator manually,");
                CommandLine.WriteError("and then re-run this build.");
                CommandLine.WriteLine();
                throw;
            }
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
                File.Copy(file, Path.Combine(thirdpartyDir, Path.GetFileName(file)));
            }

            // Build the updated ServiceGenerator.
            serviceGenerator.RunBuildTask();

            // Clear the "Services" directory.
            DirUtils.ClearDir(ServiceDir);

            // Generate all strongly typed services.
            var runner = new Runner(serviceGenerator.BinaryFile, "--non-interactive", "-o="+ServiceDir, "-c", "-a");
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
        private static void BuildContribRelease(string tag,
                                                IEnumerable<Project> baseLibrary,
                                                IEnumerable<Project> allProjects)
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Building Contrib-Release");
            CommandLine.WriteLine("{{white}} =======================================");

            string releaseDir = Contrib.Combine(tag);
            string currentDir = Contrib.Combine("Current");

            // Clear existing directories.
            DirUtils.ClearOrCreateDir(releaseDir);
            DirUtils.ClearOrCreateDir(currentDir);

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
                    File.Copy(file, Path.Combine(libDir, Path.GetFileName(file)));
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
                        File.Copy(file, Path.Combine(sourceDir, fileName));
                    }
                    if (toBin.Contains(ext)) // Copy this file into the "Binary" directory.
                    {
                        // Get the folder name by looking at the .dll assembly info.
                        string id = FileVersionInfo.GetVersionInfo(Path.ChangeExtension(file, ".dll")).ProductName;
                        string serviceName = id.Split(':')[0]; // "buzz:v1" -> "buzz"
                        string folderName = serviceName.ToUpperFirstChar() + "Service"; // "buzz" -> "BuzzService"

                        // Copy the file there.
                        string folder = Path.Combine(binDir, folderName);
                        if (!Directory.Exists(folder))
                        {
                            Directory.CreateDirectory(folder);
                        }
                        File.Copy(file, Path.Combine(folder, fileName));
                    }
                }
            }
            #endregion

            #region
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
                }
            }
            #endregion

            // Copy the content to the <tagname> release directory.
            DirUtils.CopyFiles(currentDir, releaseDir);
            
            CommandLine.WriteLine();
        }

        private static void UpdateWiki()
        {
            CommandLine.WriteLine("{{white}} =======================================");
            CommandLine.WriteLine("{{white}} Updating the Wiki");
            CommandLine.WriteLine("{{white}} =======================================");

            UpdateWikiLists.Program.UpdateWiki(Wiki, Samples);

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
