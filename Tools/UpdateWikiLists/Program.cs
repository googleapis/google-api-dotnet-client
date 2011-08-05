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
using System.Diagnostics;
using System.IO;
using Google.Apis.Samples.Helper;
using UpdateWikiLists.Util;
using UpdateWikiLists.Wiki;

namespace UpdateWikiLists
{
    /// <summary>
    /// Main Program class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The .wiki repository
        /// </summary>
        public static Hg Wiki { get; private set; }

        /// <summary>
        /// The .samples repository
        /// </summary>
        public static Hg Samples { get; private set; }

        static void Main(string[] args)
        {
            CommandLine.DisplayGoogleSampleHeader("Update Wiki");
            CommandLine.EnableExceptionHandling();

            using (Wiki = Hg.Clone("https://code.google.com/p/google-api-dotnet-client.wiki/"))
            using (Samples = Hg.Clone("https://code.google.com/p/google-api-dotnet-client.samples/"))
            {
                // Make the changes.
                APILibraries.InsertIntoFile(Path.Combine(Wiki.WorkingDirectory, "APILibraries.wiki"));
                
                // Show them to the user.
                CommandLine.WriteAction("Opening modified working directory ...");
                Process.Start(Wiki.WorkingDirectory);
                if (CommandLine.RequestUserChoice("Do you want to push these changes to the server?"))
                {
                    Wiki.Commit("Updated the generated section of the APILibraries.wiki.");
                    Wiki.Push();
                }
            }
        }
    }
}
