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

using System.Diagnostics;
using System.IO;
using System.Linq;

using Google.Apis.Utils.Trace;

namespace Google.Apis.Utils
{
    /// <summary>Directory utilities which support copying, clearing and other operations on directories.</summary>
    public static class DirectoryUtilities
    {
        private static readonly TraceSource TraceSource = new TraceSource("Google.Apis");

        /// <summary>Copies a directory recursively to a new one.</summary>
        /// <param name="sourceDir">Source directory</param>
        /// <param name="destDir">Destination directory</param>
        public static void CopyDirectory(string sourceDir, string destDir)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    string.Format("Source directory \"{0}\" does not exist", sourceDir));
            }

            ClearOrCreateDirectory(destDir);

            // copy all files
            dir.GetFiles().ToList().ForEach(
                f => f.CopyTo(Path.Combine(destDir, f.Name)));

            // copy all nested directories
            dir.GetDirectories().ToList().ForEach(
                s => CopyDirectory(s.FullName, Path.Combine(destDir, s.Name)));
        }

        /// <summary>Clears or creates the specified directory.</summary>
        public static void ClearOrCreateDirectory(string dir)
        {
            if (Directory.Exists(dir))
            {
                TraceSource.TraceEvent(TraceEventType.Verbose, "Clearing '{0}'", dir);
                Directory.Delete(dir, true);
            }

            Directory.CreateDirectory(dir);
            TraceSource.TraceEvent(TraceEventType.Verbose, "Creating '{0}'", dir);
        }

        /// <summary>Retrieves the relative path from the parent to the child.</summary>
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
