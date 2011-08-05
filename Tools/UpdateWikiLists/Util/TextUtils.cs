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

namespace UpdateWikiLists.Util
{
    /// <summary>
    /// Text helper utility.
    /// </summary>
    internal static class TextUtils
    {
        /// <summary>
        /// Inserts the specified content in the place between the start and end tag, which can be found in the
        /// specified source text.
        /// </summary>
        /// <param name="sourceText">Text which contains the tags.</param>
        /// <param name="startTag">The tag marking the start of the replacement area.</param>
        /// <param name="endTag">The tag marking the end of the replacement area.</param>
        /// <param name="content">The content to insert into the replacement area.</param>
        /// <returns>[..] {startTag} content {endTag} [..]</returns>
        public static string InsertIntoText(string sourceText, string startTag, string endTag, string content)
        {
            // Find the start tag.
            int startIndex = sourceText.IndexOf(startTag);
            if (startIndex < 0)
            {
                throw new ArgumentException("Start Tag not found: " + startTag);
            }
            startIndex += startTag.Length;

            // Find the end tag.
            int endIndex = sourceText.IndexOf(endTag, startIndex);
            if (endIndex < 0)
            {
                throw new ArgumentException("End Tag not found: " + endTag);
            }
            
            // Replace the text
            string newText = sourceText.Substring(0, startIndex) + Environment.NewLine + 
                             content + Environment.NewLine + 
                             sourceText.Substring(endIndex);
            return newText;
        }

        /// <summary>
        /// Inserts the specified content in the place between the start and end tag, which can be found in the
        /// specified source text.
        /// </summary>
        /// <param name="file">The file containing the tags.</param>
        /// <param name="startTag">The tag marking the start of the replacement area.</param>
        /// <param name="endTag">The tag marking the end of the replacement area.</param>
        /// <param name="content">The content to insert into the replacement area.</param>
        /// <returns>[..] {startTag} content {endTag} [..]</returns>
        public static void InsertIntoFile(string file, string startTag, string endTag, string content)
        {
            File.WriteAllText(file, InsertIntoText(File.ReadAllText(file), startTag, endTag, content));
        }

        /// <summary>
        /// Transforms the first letter of the string into uppercase.
        /// </summary>
        public static string ToUpperFirstChar(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            return Char.ToUpper(str[0]) + str.Substring(1);
        }

        /// <summary>
        /// Joins the two specified lines into a common string.
        /// </summary>
        public static string JoinLines(string a, string b)
        {
            return a + Environment.NewLine + b;
        }
    }
}
