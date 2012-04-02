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

namespace Google.Build.Utils.Text
{
    /// <summary>
    /// Text helper utility.
    /// </summary>
    public static class TextUtils
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
            return ReplaceInText(sourceText, startTag, endTag, old => content);
        }

        /// <summary>
        /// Replaces the text within the given tags using the specified replace function.
        /// </summary>
        /// <param name="sourceText">The text containing the tags.</param>
        /// <param name="startTag">The tag marking the start of the replacement area.</param>
        /// <param name="endTag">The tag marking the end of the replacement area.</param>
        /// <param name="replace">The function used to replace the tag content.</param>
        /// <returns>The resulting text.</returns>
        public static string ReplaceInText(string sourceText,
                                           string startTag,
                                           string endTag,
                                           Func<string, string> replace)
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
            string oldText = sourceText.Substring(startIndex, endIndex - startIndex).Trim('\r', '\n');
            string newText = replace(oldText);
            return sourceText.Substring(0, startIndex) + Environment.NewLine +
                   newText + Environment.NewLine +
                   sourceText.Substring(endIndex);
        }

        /// <summary>
        /// Replaces the text within the given tags using the specified replace function.
        /// </summary>
        /// <param name="file">The file to replace the text in.</param>
        /// <param name="startTag">The tag marking the start of the replacement area.</param>
        /// <param name="endTag">The tag marking the end of the replacement area.</param>
        /// <param name="replace">The function used to replace the tag content.</param>
        public static void ReplaceInFile(string file, string startTag, string endTag, Func<string, string> replace)
        {
            File.WriteAllText(file, ReplaceInText(File.ReadAllText(file), startTag, endTag, replace));
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
        /// Finishes the specified string with the specified character.
        /// </summary>
        /// <param name="str">The sentence to end.</param>
        /// <param name="endChar">The character with which this sentence should end.</param>
        public static string MakeSentence(this string str, char endChar)
        {
            string trimmed = str.TrimEnd(' ', '\r', '\n');

            if (trimmed.EndsWith(endChar.ToString()))
            {
                return str;
            }
            return trimmed + endChar + str.Substring(trimmed.Length);
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
