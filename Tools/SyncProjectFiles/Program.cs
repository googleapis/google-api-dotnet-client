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
using System.Text.RegularExpressions;

namespace SyncProjectFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.Error.WriteLine("SyncProjectFiles.exe <src.csproj> <dest.csproj>");
                return;
            }

            string sourceProject = args[0];
            string destinationProject = args[1];

            try
            {
                Match sourceBlock = FindCodeGroupBlock(sourceProject);
                Match destinationBlock = FindCodeGroupBlock(destinationProject);
                ReplaceCodeGroupBlock(destinationProject, sourceBlock, destinationBlock);
                
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Syncing projects failed:");
                Console.Error.WriteLine(" -> " + e.Message);
                Console.Error.WriteLine(e.StackTrace);
                Environment.Exit(1);
            }
        }

        private const RegexOptions RegexSettings = RegexOptions.Compiled | RegexOptions.Singleline;
        private static readonly Regex ItemGroupRegex = new Regex("<ItemGroup>(.*?)</ItemGroup>", RegexSettings);
        private static readonly Regex IsCodeSectionRegex = new Regex("<Compile(\\s+\\S*)?\\s*(/>|>)", RegexSettings);

        /// <summary>
        /// Finds the ItemGroup block which contains the source code files.
        /// </summary>
        /// <param name="file">The .csproj</param>
        /// <returns>The match containing the CodeBlock</returns>
        /// <exception cref="ArgumentException">Thrown if no appropritae ItemGroup block was found.</exception>
        private static Match FindCodeGroupBlock(string file)
        {
            if (!File.Exists(file))
            {
                throw new ArgumentException("The specified file does not exist: "+file);
            }

            // Search through all <ItemGroup>s and look for the one refering to code files.
            string content = File.ReadAllText(file);
            foreach (Match m in ItemGroupRegex.Matches(content))
            {
                // Check whether the section contains files.
                if (IsCodeSectionRegex.IsMatch(m.Groups[1].ToString()))
                {
                    Console.WriteLine("Found CodeBlock in '"+file+"' from "+m.Index+" to "+(m.Index + m.Length));
                    return m;
                }
            }
            throw new ArgumentException("The specified file does not contain a code-block: "+file);
        }

        /// <summary>
        /// Replaces the destination block in the specified file with the source block.
        /// </summary>
        /// <param name="fileToModify">The file to modify.</param>
        /// <param name="sourceBlock">The replacement value.</param>
        /// <param name="destinationBlock">The block to replace.</param>
        private static void ReplaceCodeGroupBlock(string fileToModify, Match sourceBlock, Match destinationBlock)
        {
            Console.WriteLine("Replacing CodeBlock in '"+fileToModify+"'");
            string content = File.ReadAllText(fileToModify);
            string newCodeblock = sourceBlock.Value;

            int start = destinationBlock.Index;
            int end = start + destinationBlock.Length;

            content = content.Substring(0, start) + newCodeblock + content.Substring(end);
            File.WriteAllText(fileToModify, content);
        }
    }
}
