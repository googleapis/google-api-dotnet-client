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

using System.Diagnostics;
using System.IO;
using Google.Apis.Samples.Helper;
using Google.Build.Utils.Repositories;
using UpdateWikiLists.Wiki;

namespace UpdateWikiLists
{
    /// <summary>
    /// Main Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Updates the 
        /// </summary>
        /// <param name="wiki"></param>
        /// <param name="samples"></param>
        public static void UpdateWiki(Hg wiki, Hg samples)
        {
            // Make the changes.
            CommandLine.WriteAction("Updating 'APILibraries.wiki' ...");
            new APILibraries(samples).InsertIntoFile(Path.Combine(wiki.WorkingDirectory, "APILibraries.wiki"));
        }

        static void Main(string[] args)
        {
            CommandLine.DisplayGoogleSampleHeader("Update Wiki");
            CommandLine.EnableExceptionHandling();

            using (Hg wiki = Hg.Clone("https://code.google.com/p/google-api-dotnet-client.wiki/"))
            using (Hg samples = Hg.Clone("https://code.google.com/p/google-api-dotnet-client.samples/"))
            {
                // Make all the changes.
                UpdateWiki(wiki, samples);
                
                // Show them to the user.
                CommandLine.WriteAction("Opening modified working directory ...");

                if (!wiki.HasUncommitedChanges)
                {
                    CommandLine.WriteAction("No changes detected.");
                    CommandLine.PressAnyKeyToExit();
                }
                else
                {
                    CommandLine.WriteAction("Showing diff ...");
                    wiki.ShowDiff();
                    Process.Start(wiki.WorkingDirectory);

                    if (CommandLine.RequestUserChoice("Do you want to push these changes to the server?"))
                    {
                        wiki.Commit("Updated the generated section of the APILibraries.wiki.");
                        wiki.Push();
                    }
                }
            }
        }
    }
}
