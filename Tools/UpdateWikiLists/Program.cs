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
        /// Updates the Wiki
        /// </summary>
        public static void UpdateWiki(Hg wiki, Hg samples, string releaseNotes, string zipDir)
        {
            // Make the changes.
            CommandLine.WriteAction("Updating 'APILibraries.wiki' ...");
            new APILibrariesPage(samples).InsertIntoFile(Path.Combine(wiki.WorkingDirectory, "APIs.wiki"));

            if (releaseNotes != null)
            {
                CommandLine.WriteAction("Updating 'Downloads.wiki' ...");
                new DownloadsPage(releaseNotes, zipDir).InsertIntoFile(
                    Path.Combine(wiki.WorkingDirectory, "Downloads.wiki"));
            }
        }

        static void Main(string[] args)
        {
            CommandLine.DisplayGoogleSampleHeader("Update Wiki");
            CommandLine.EnableExceptionHandling();

            using (Hg wiki = Hg.Clone("https://code.google.com/p/google-api-dotnet-client.wiki/"))
            using (Hg samples = Hg.Clone("https://code.google.com/p/google-api-dotnet-client.samples/"))
            {
                // Make all the changes.
                UpdateWiki(wiki, samples, null, null);
                
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
