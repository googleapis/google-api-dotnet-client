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
using System.IO;

namespace Google.Apis.Release.Wiki
{
    /// <summary>
    /// Updates the Downloads wiki page (https://code.google.com/p/google-api-dotnet-client/wiki/Downloads). 
    /// </summary>
    public static class DownloadsPageUpdater
    {
        private const string StableStartTag = "<wiki:comment>GENERATED_STABLE_BEGIN</wiki:comment>";
        private const string StableEndTag = "<wiki:comment>GENERATED_STABLE_END</wiki:comment>";

        /// <summary>Updates the Wiki.</summary>
        public static void UpdateWiki(string workingDirectory, string notes, string oldVersion, string newVersion)
        {
            if (string.IsNullOrEmpty(workingDirectory)) throw new ArgumentNullException("workingDirectory");
            if (string.IsNullOrEmpty(notes)) throw new ArgumentNullException("notes");
            if (string.IsNullOrEmpty(oldVersion)) throw new ArgumentNullException("oldVersion");
            if (string.IsNullOrEmpty(newVersion)) throw new ArgumentNullException("newVersion");


            var filePath = Path.Combine(workingDirectory, "Downloads.wiki");
            string content = File.ReadAllText(filePath);

            // update notes. Replace all text from StableStartTag to StableEndTag
            var generatedNotes = "{{{" + Environment.NewLine + notes + Environment.NewLine + "}}}";
            content = ReplacePart(content, StableStartTag, StableEndTag, oldText => generatedNotes);

            // update links
            content = content.Replace(oldVersion, newVersion);
            File.WriteAllText(filePath, content);
        }

        /// <summary>
        /// Returns a new string with the content of the source and a new text based on <c>replaceFunc</c>between 
        /// <c>startPartTag</c> to <c>endPartTag</c>.
        /// </summary>
        /// <param name="source">The source content</param>
        /// <param name="startPartTag">The start part tag</param>
        /// <param name="endPartTag">The end part tag</param>
        /// <param name="replaceFunc">The replacement function from the old text to new text</param>
        private static string ReplacePart(string source, string startPartTag, string endPartTag,
            Func<string, string> replaceFunc)
        {
            // find the start tag
            int startIndex = source.IndexOf(startPartTag);
            if (startIndex < 0)
            {
                throw new ArgumentException("Start Tag not found: " + startPartTag);
            }
            startIndex += startPartTag.Length;

            // find the end tag
            int endIndex = source.IndexOf(endPartTag, startIndex);
            if (endIndex < 0)
            {
                throw new ArgumentException("End Tag not found: " + endPartTag);
            }

            var oldText = source.Substring(startIndex, endIndex - startIndex).Trim('\r', '\n');
            var newText = replaceFunc(oldText);

            // replace the text
            return source.Substring(0, startIndex) + Environment.NewLine +
                newText + Environment.NewLine + source.Substring(endIndex);
        }
    }
}
