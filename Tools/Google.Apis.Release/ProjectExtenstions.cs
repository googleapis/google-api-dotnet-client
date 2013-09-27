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

using Microsoft.Build.Evaluation;

using Google.Apis.Utils;
using Google.Apis.Utils.Trace;

namespace Google.Apis.Release
{
    /// <summary>
    /// Extension methods for the Project class. 
    /// Add support in getting the short name of the project and also in replacing the current library version with 
    /// the new version (<see cref="ReplaceVersion"/>).
    /// </summary>
    internal static class ProjectExtenstions
    {
        static readonly TraceSource TraceSource = new TraceSource("Google.Apis");

        /// <summary>Gets the name of the project.</summary>
        public static string GetName(this Project project)
        {
            return project.DirectoryPath.Substring(project.DirectoryPath.LastIndexOf(Path.DirectorySeparatorChar) + 1);
        }

        /// <summary>Replaces Assembly version number with the given one.</summary>
        public static void ReplaceVersion(this Project project, string newVersion)
        {
            const string ASSEMBLY_INFO_PREFIX = "[assembly: AssemblyVersion(\"";

            // no need to increase version
            if (newVersion == null)
                return;

            var assemblyInfoFile = System.IO.Path.Combine(project.DirectoryPath, "Properties", "AssemblyInfo.cs");

            try
            {
                // read all lines and replace the current version with the given newVersion
                var allLines = File.ReadAllLines(assemblyInfoFile).Select(
                    l =>
                    {
                        // if the line contains assembly information, replace old version with new version
                        if (l.StartsWith(ASSEMBLY_INFO_PREFIX))
                            return ReplaceVersionInLine(l, ASSEMBLY_INFO_PREFIX, newVersion);
                        else
                            return l;
                    });
                File.WriteAllLines(assemblyInfoFile, allLines);
            }
            catch (Exception ex)
            {
                TraceSource.TraceEvent(TraceEventType.Error, "Exception occurred while replacing version", ex.Message);
            }
        }

        /// <summary>Returns the assembly information line with the new version. </summary>
        private static string ReplaceVersionInLine(string line, string assemblyVersionPrefix, string newVersion)
        {
            var startVersion = assemblyVersionPrefix.Length;
            // '.*' ends the old version number (e.g 1.2.* or 1.2.0.*)
            var endVersion = line.IndexOf(".*", startVersion);
            var oldVersion = line.Substring(startVersion, endVersion - startVersion);
            return line.Replace(assemblyVersionPrefix + oldVersion, assemblyVersionPrefix + newVersion);
        }
    }
}
