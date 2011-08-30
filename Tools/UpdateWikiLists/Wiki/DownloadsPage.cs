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
using Google.Build.Utils.Text;

namespace UpdateWikiLists.Wiki
{
    /// <summary>
    /// Updater for the Downloads wiki page.
    /// </summary>
    public class DownloadsPage
    {
        private const string StartTag = "<wiki:comment>GENERATED_STABLE_BEGIN</wiki:comment>";
        private const string EndTag = "<wiki:comment>GENERATED_STABLE_END</wiki:comment>";

        /// <summary>
        /// The Samples repository used for generating the list of samples.
        /// </summary>
        public string ReleaseNotes { get; private set; }
        
        public DownloadsPage(string releaseNotes)
        {
            ReleaseNotes = releaseNotes;
        }

        /// <summary>
        /// Generates the Releases Notes section.
        /// </summary>
        public string GenerateNotes()
        {
            return "{{{" + Environment.NewLine + ReleaseNotes + Environment.NewLine + "}}}";
        }

        /// <summary>
        /// Modifies the existing Downloads wiki file by replacing the "generated" section.
        /// </summary>
        public void InsertIntoFile(string file)
        {
            TextUtils.InsertIntoFile(file, StartTag, EndTag, GenerateNotes());
        }
    }
}
