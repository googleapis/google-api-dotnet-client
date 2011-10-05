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
using Google.Apis.Samples.Helper;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;
using ConsoleLogger = Microsoft.Build.BuildEngine.ConsoleLogger;

namespace Google.Build.Utils.Build
{
    /// <summary>
    /// Represents a buildable project.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// The working directory in which the project file resides.
        /// </summary>
        public string WorkingDirectory { get; private set; }

        /// <summary>
        /// The .csproj project file.
        /// </summary>
        public string ProjectFile { get; private set; }

        /// <summary>
        /// The Configuration to build. Default: "Release"
        /// </summary>
        public string Configuration
        {
            get { return internalProject.GetProperty("Configuration").EvaluatedValue; }
            set { internalProject.SetProperty("Configuration", value); }
        }

        /// <summary>
        /// Path to the generated binary file.
        /// </summary>
        public string BinaryFile
        {
            get { return internalProject.GetPropertyValue("TargetPath"); }
        }
        
        /// <summary>
        /// The simple name of this project.
        /// </summary>
        public string Name
        {
            get { return internalProject.GetPropertyValue("ProjectName");  }
        }

        /// <summary>
        /// Returns the paths to all generated output files.
        /// </summary>
        public string[] OutputFiles
        {
            get
            {
                string[] extensions = new[] { ".pdb", ".xml" };
                string binary = BinaryFile;

                // Generate the list of output files.
                var result = new List<string>();
                result.Add(BinaryFile);
                result.AddRange(extensions.Select(ext => Path.ChangeExtension(binary, ext)).Where(File.Exists));
                return result.ToArray();
            }
        }

        private readonly Microsoft.Build.Evaluation.Project internalProject;

        public Project(string projectFile)
        {
            if (!File.Exists(projectFile))
            {
                throw new FileNotFoundException("The specified project file cannot be found.", projectFile);
            }
            ProjectFile = projectFile;
            WorkingDirectory = Path.GetDirectoryName(projectFile);
            internalProject = (from p in ProjectCollection.GlobalProjectCollection.LoadedProjects
                               where p.FullPath == Path.GetFullPath(projectFile)
                               select p).SingleOrDefault() ?? new Microsoft.Build.Evaluation.Project(ProjectFile);
            Configuration = "Release";
        }

        private void Build(string target)
        {
            if (!internalProject.Build(target))
            {
                // If the build fails, re-run this build with a logger attached.
                internalProject.Build(target, new[] { new ConsoleLogger(LoggerVerbosity.Quiet) });
                Process.Start(WorkingDirectory);
                throw new ApplicationException("Build of project [" + this + ":"+target+"] failed!");
            }
        }

        /// <summary>
        /// Cleans the project.
        /// </summary>
        public void Clean()
        {
            Log("Cleaning ...");
            Build("Clean");
        }

        /// <summary>
        /// Compiles the project.
        /// </summary>
        public void Compile()
        {
            Log("Compiling ...");
            Build("Build");

            if (!File.Exists(BinaryFile))
            {
                throw new ApplicationException(
                    "Build was successful, but target binary file does not exist: " + BinaryFile);
            }
        }

        /// <summary>
        /// Copies the resulting binaries to the specified directory.
        /// </summary>
        public void CopyTo(string dir)
        {
            Log("Copying output to "+Path.GetFileName(dir)+" ...");

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Copy all output files into the target directory
            foreach (string file in OutputFiles)
            {
                string fileName = Path.GetFileName(file);
                Log("  * " + fileName);
                File.Copy(file, Path.Combine(dir, fileName), true);
            }
        }

        /// <summary>
        /// Copies the resulting binaries and dependencies to the specified directory.
        /// </summary>
        public void CopyAllFilesTo(string dir)
        {
            Log("Copying output to " + Path.GetFileName(dir) + " ...");

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Copy all output files into the target directory
            string buildDir = Path.GetDirectoryName(BinaryFile);
            foreach (string file in Directory.GetFiles(buildDir, "*.*", SearchOption.TopDirectoryOnly))
            {
                switch (Path.GetExtension(file).ToLower())
                {
                    case ".dll":
                    case ".exe":
                    case ".pdb":
                    case ".xml":
                        break; // Copy all assemblies and relevant information into the target directory.

                    default:
                        continue; // Unsupported.
                }

                string fileName = Path.GetFileName(file);
                Log("  * " + fileName);
                File.Copy(file, Path.Combine(dir, fileName), true);
            }
        }

        /// <summary>
        /// Runs the 
        /// </summary>
        public void RunBuildTask()
        {
            CommandLine.WriteAction("Running [" + Name + "] build task..");
            Clean();
            Compile();
        }

        public override string ToString()
        {
            return Path.GetFileNameWithoutExtension(ProjectFile);
        }

        private void Log(string msg)
        {
            CommandLine.WriteLine("{{green}}  "+msg, this);
        }
    }
}
