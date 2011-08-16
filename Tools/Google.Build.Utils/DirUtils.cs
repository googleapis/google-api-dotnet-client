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

using System.IO;
using Google.Apis.Samples.Helper;

namespace Google.Build.Utils
{
    /// <summary>
    /// Directory helper utils.
    /// </summary>
    public static class DirUtils
    {
        /// <summary>
        /// Removes all files and subdirectories of the specified directory.
        /// </summary>
        public static void ClearDir(string dir)
        {
            CommandLine.WriteAction("Clearing '" + Path.GetFileName(dir) + "' ...");
            Directory.Delete(dir, true);
            Directory.CreateDirectory(dir);
        }

        /// <summary>
        /// Clears or creates the specified directory.
        /// </summary>
        public static void ClearOrCreateDir(string dir)
        {
            if (Directory.Exists(dir))
            {
                ClearDir(dir);
            }
            else
            {
                Directory.CreateDirectory(dir);
                CommandLine.WriteAction("Creating '"+Path.GetFileName(dir)+"' ...");
            }
        }

        /// <summary>
        /// Retrieves the relative path from the parent to the child.
        /// </summary>
        public static string GetRelativePath(string child, string parent)
        {
            string absoluteChild = Path.GetFullPath(child);
            string absoluteParent = Path.GetFullPath(parent);

            if (!absoluteChild.StartsWith(absoluteParent + Path.DirectorySeparatorChar))
            {
                return absoluteChild; // Nothing in common.
            }

            return absoluteChild.Substring(absoluteParent.Length + 1);
        }

        /// <summary>
        /// Copies a single file to the specified destination.
        /// </summary>
        /// <param name="sourceFile">The source file.</param>
        /// <param name="destFolder">The destination folder.</param>
        public static void CopyFile(string sourceFile, string destFolder)
        {
            CommandLine.WriteAction(
                "Copying '" + Path.GetFileName(sourceFile) + "' to '" + Path.GetFileName(destFolder) + "/' ...");

            if (!Directory.Exists(destFolder))
            {
                Directory.CreateDirectory(destFolder);
            }

            string destFile = Path.Combine(destFolder, Path.GetFileName(sourceFile));
            File.Copy(sourceFile, destFile, true);
        }

        /// <summary>
        /// Copies all files and directories from the source to the destination.
        /// </summary>
        public static void CopyFiles(string source, string dest)
        {
            CommandLine.WriteAction(
                "Copying '" + Path.GetFileName(source) + "' to '" + Path.GetFileName(dest) + "' ...");

            foreach (var file in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
            {
                string fileDest = Path.Combine(dest, GetRelativePath(file, source));
                string dir = Path.GetDirectoryName(fileDest);

                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.Copy(file, fileDest, true);
            }
        }
    }
}
