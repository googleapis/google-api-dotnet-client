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
using System.IO;
using System.Linq;
using Google.Apis.Samples.Helper;
using Ionic.Zip;

namespace Google.Build.Utils
{
    /// <summary>
    /// Zip support class.
    /// </summary>
    public class Zip : IDisposable
    {
        private readonly ZipFile zipFile;

        public Zip(string file)
        {
            CommandLine.WriteAction("Creating zip: "+Path.GetFileName(file));
            zipFile = new ZipFile(file);
        }

        /// <summary>
        /// Adds the specified file to the zip archive under "zipDir".
        /// </summary>
        public void AddFile(string file, string zipDir)
        {
            CommandLine.WriteResult("Adding File", Path.Combine(zipDir, Path.GetFileName(file)));
            zipFile.AddFile(file, zipDir);
        }

        /// <summary>
        /// Adds the specified folder to the zip archive as "zipDir".
        /// </summary>
        public void AddDirectory(string dir, string zipDir)
        {
            CommandLine.WriteResult("Adding Directory", Path.GetFileName(dir) + " -> " + zipDir);
            zipFile.AddDirectory(dir, zipDir);
        }

        /// <summary>
        /// Removes the specified entry from this zip if it existed in the first place.
        /// </summary>
        /// <returns>True if an entry was removed.</returns>
        public bool RemoveFile(string entry)
        {
            if (!zipFile.ContainsEntry(entry))
            {
                return false;
            }
            zipFile.RemoveEntry(entry);
            return true;
        }

        /// <summary>
        /// Removes the specified directory from this zip.
        /// </summary>
        /// <returns>True if the directory existed before.</returns>
        public bool RemoveDirectory(string entry)
        {
            if (!entry.EndsWith("/"))
            {
                entry = entry + "/";
            }
            List<ZipEntry> toRemove = (from file in zipFile 
                                       where file.FileName.StartsWith(entry) 
                                       select file).ToList();
            zipFile.RemoveEntries(toRemove);
            return toRemove.Count > 0;
        }

        public void Dispose()
        {
            CommandLine.WriteAction("Saving zip...");
            zipFile.Save();
            zipFile.Dispose();   
        }
    }
}
