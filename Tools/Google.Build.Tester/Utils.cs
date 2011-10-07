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

namespace Google.Build.Tester
{
    /// <summary>
    /// Utility class.
    /// </summary>
    internal class Utils
    {
        /// <summary>
        /// Copies all files and directories from the source to the destination.
        /// </summary>
        public static void CopyFiles(string source, string dest)
        {
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
    }
}
