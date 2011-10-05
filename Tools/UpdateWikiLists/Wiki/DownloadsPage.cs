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
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Google.Build.Utils.Text;

namespace UpdateWikiLists.Wiki
{
    /// <summary>
    /// Updater for the Downloads wiki page.
    /// </summary>
    public class DownloadsPage
    {
        private const string StableStartTag = "<wiki:comment>GENERATED_STABLE_BEGIN</wiki:comment>";
        private const string StableEndTag = "<wiki:comment>GENERATED_STABLE_END</wiki:comment>";
        private const string DownloadsStartTag = "<wiki:comment>GENERATED_DOWNLOADS_BEGIN</wiki:comment>";
        private const string DownloadsEndTag = "<wiki:comment>GENERATED_DOWNLOADS_END</wiki:comment>";

        private static readonly Regex LinkRegex = new Regex(@"\[([^ \]]*/)\S+ ([^\]]+)]", RegexOptions.Compiled);

        /// <summary>
        /// The Samples repository used for generating the list of samples.
        /// </summary>
        public string ReleaseNotes { get; private set; }

        /// <summary>
        /// The directory containing the release .zip files
        /// </summary>
        public string ZipDir { get; private set; }

        /// <summary>
        /// Name of this release.
        /// </summary>
        public string ReleaseName { get; private set; }
        
        public DownloadsPage(string releaseNotes, string zipDir)
        {
            ReleaseNotes = releaseNotes;
            ZipDir = zipDir;
            ReleaseName = Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(zipDir)));
        }

        /// <summary>
        /// Generates the Releases Notes section.
        /// </summary>
        public string GenerateNotes()
        {
            return "{{{" + Environment.NewLine + ReleaseNotes + Environment.NewLine + "}}}";
        }

        /// <summary>
        /// Replaces the download links within the specified text.
        /// </summary>
        /// <param name="input">The text block containing the wiki links.</param>
        /// <returns>Replaced & updated text.</returns>
        public string ReplaceLinks(string input)
        {
            const string format = 
                "[http://contrib.google-api-dotnet-client.googlecode.com/hg/{0}/Generated/ZipFiles/{1} {2}]";
            return LinkRegex.Replace(input, (match) => string.Format(format,
                                                                     ReleaseName,
                                                                     GetFileName(match.Groups[2].ToString()),
                                                                     match.Groups[2].ToString()));
        }

        /// <summary>
        /// Retrieves the filename of the release for the specified title/keyword.
        /// Example:
        ///     'Binary Release' results in 'google-api-dotnet-client-1.0.0.Binary.zip'
        /// </summary>
        private string GetFileName(string title)
        {
            string keyword = title.Split(' ')[0];
            return Path.GetFileName(Directory.GetFiles(ZipDir, "*" + keyword + "*").Single());
        }

        /// <summary>
        /// Modifies the existing Downloads wiki file by replacing the "generated" section.
        /// </summary>
        public void InsertIntoFile(string file)
        {
            string content = File.ReadAllText(file);
            content = TextUtils.InsertIntoText(content, StableStartTag, StableEndTag, GenerateNotes());
            content = TextUtils.ReplaceInText(content, DownloadsStartTag, DownloadsEndTag, ReplaceLinks);
            File.WriteAllText(file, content);
        }
    }
}
