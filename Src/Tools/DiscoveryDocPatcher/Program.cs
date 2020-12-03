/*
Copyright 2016 Google Inc

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

namespace DiscoveryDocPatcher
{

    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                string discoveryDocPath = args[0];

                // No longer required as on 2020-07-09. The offending resource is no longer present at all.
                // PatchGames(discoveryDocPath);

                // No need to generate (or patch) while an internal issue is being fixed.
                // We'll need to review patching once we have the new discovery doc produced by that fix.
                // I've let a comment on the script as well.
                // PatchDirectory(discoveryDocPath);

                PatchDataLabeling(discoveryDocPath);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }
        }

        static void PatchGames(string rootPath)
        {
            var patcher = IfFileExists(() => Patcher.Load(Path.Combine(rootPath, "games_v1.json")));
            if (patcher is null)
            {
                return;
            }
            // Remove deprecated enum value that causes duplicate C# enum value.
            patcher.Remove("resources.players.methods.list.parameters.collection.enum[2]", "'playedWith'", "'played_with'");
            // There are now two descriptions that look the same. We just want to remove the first of them.
            patcher.Remove("resources.players.methods.list.parameters.collection.enumDescriptions[2]",
                "'(DEPRECATED) Retrieve a list of players you have played a multiplayer game (realtime or turn-based) with recently.'",
                "'(DEPRECATED) Retrieve a list of players you have played a multiplayer game (realtime or turn-based) with recently.'");
            patcher.SaveWithBackup();
        }

        static void PatchDirectory(string rootPath)
        {
            var patcher = IfFileExists(() => Patcher.Load(Path.Combine(rootPath, "admin_directory_v1.json")));
            if (patcher is null)
            {
                return;
            }
            // Strongly-type properties that are defined without typing.
            patcher.Replace("schemas.User.properties.addresses", "{ 'type': 'any', 'description': 'Addresses of User'}", "{ 'type': 'array', 'items': { '$ref': 'UserAddress' }, 'description': 'Addresses of User' }");
            patcher.Replace("schemas.User.properties.emails", "{ 'type': 'any', 'description': 'Emails of User' }", "{ 'type': 'array', 'items': { '$ref': 'UserEmail' }, 'description': 'Emails of User' }");
            patcher.Replace("schemas.User.properties.externalIds", "{ 'type': 'any', 'description': 'The external Ids of User *' }", "{ 'type': 'array', 'items': { '$ref': 'UserExternalId' }, 'description': 'The external Ids of User *' }");
            patcher.Replace("schemas.User.properties.ims", "{ 'type': 'any', 'description': 'User&s Instant Messenger' }", "{ 'type': 'array', 'items': { '$ref': 'UserIm' }, 'description': 'User&s Instant Messenger' }");
            patcher.Replace("schemas.User.properties.organizations", "{ 'type': 'any', 'description': 'Organizations of User' }", "{ 'type': 'array', 'items': { '$ref': 'UserOrganization' }, 'description': 'Organizations of User' }");
            patcher.Replace("schemas.User.properties.phones", "{ 'type': 'any', 'description': 'Phone numbers of User' }", "{ 'type': 'array', 'items': { '$ref': 'UserPhone' }, 'description': 'Phone numbers of User' }");
            patcher.Replace("schemas.User.properties.relations", "{ 'type': 'any', 'description': 'The Relations of User *' }", "{ 'type': 'array', 'items': { '$ref': 'UserRelation' }, 'description': 'The Relations of User *' }");
            patcher.Replace("schemas.User.properties.websites", "{ 'type': 'any', 'description': 'Websites of User' }", "{ 'type': 'array', 'items': { '$ref': 'UserWebsite' }, 'description': 'Websites of User' }");
            patcher.Replace("schemas.Aliases.properties.aliases.items", "{ 'type': 'any' }", "{ '$ref': 'Alias' }");
            patcher.SaveWithBackup();

        }

        static void PatchDataLabeling(string rootPath)
        {
            var patcher = IfFileExists(() => Patcher.Load(Path.Combine(rootPath, "datalabeling_v1beta1.json")));
            if (patcher is null)
            {
                return;
            }
            // This just increases the length of one parameter description by adding spaces
            // so that text wrapping doens't interfere with EOL markers when generating.
            patcher.Replace(
                "resources.projects.resources.datasets.resources.annotatedDatasets.resources.feedbackThreads.resources.feedbackMessages.methods.get.parameters.name.description",
                "'Required. Name of the feedback. Format: &projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}/feedbackMessages/{feedback_message_id}&.'",
                "'Required.   Name of the feedback.   Format:   &projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/{annotated_dataset_id}/feedbackThreads/{feedback_thread_id}/feedbackMessages/{feedback_message_id}&.'");

            patcher.SaveWithBackup();
        }

        static T IfFileExists<T>(Func<T> fn)
        {
            try
            {
                return fn();
            }
            catch (FileNotFoundException)
            {
                return default;
            }
        }
    }
}
