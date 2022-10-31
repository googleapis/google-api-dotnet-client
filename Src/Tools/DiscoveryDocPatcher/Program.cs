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

                PatchDirectory(discoveryDocPath);

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
            patcher.Replace("schemas.User.properties.addresses", "{ 'type': 'any', 'description': 'The list of the user&s addresses. The maximum allowed data size for this field is 10Kb.'}", "{ 'type': 'array', 'items': { '$ref': 'UserAddress' }, 'description': 'The list of the user&s addresses. The maximum allowed data size for this field is 10Kb.' }");
            patcher.Replace("schemas.User.properties.emails", "{ 'type': 'any', 'description': 'The list of the user&s email addresses. The maximum allowed data size for this field is 10Kb.' }", "{ 'type': 'array', 'items': { '$ref': 'UserEmail' }, 'description': 'The list of the user&s email addresses. The maximum allowed data size for this field is 10Kb.' }");
            patcher.Replace("schemas.User.properties.externalIds", "{ 'type': 'any', 'description': 'The list of external IDs for the user, such as an employee or network ID. The maximum allowed data size for this field is 2Kb.' }", "{ 'type': 'array', 'items': { '$ref': 'UserExternalId' }, 'description': 'The list of external IDs for the user, such as an employee or network ID. The maximum allowed data size for this field is 2Kb.' }");
            patcher.Replace("schemas.User.properties.ims", "{ 'type': 'any', 'description': 'The list of the user&s Instant Messenger (IM) accounts. A user account can have multiple ims properties. But, only one of these ims properties can be the primary IM contact. The maximum allowed data size for this field is 2Kb.' }", "{ 'type': 'array', 'items': { '$ref': 'UserIm' }, 'description': 'The list of the user&s Instant Messenger (IM) accounts. A user account can have multiple ims properties. But, only one of these ims properties can be the primary IM contact. The maximum allowed data size for this field is 2Kb.' }");
            patcher.Replace("schemas.User.properties.organizations", "{ 'type': 'any', 'description': 'The list of organizations the user belongs to. The maximum allowed data size for this field is 10Kb.' }", "{ 'type': 'array', 'items': { '$ref': 'UserOrganization' }, 'description': 'The list of organizations the user belongs to. The maximum allowed data size for this field is 10Kb.' }");
            patcher.Replace("schemas.User.properties.phones", "{ 'type': 'any', 'description': 'The list of the user&s phone numbers. The maximum allowed data size for this field is 1Kb.' }", "{ 'type': 'array', 'items': { '$ref': 'UserPhone' }, 'description': 'The list of the user&s phone numbers. The maximum allowed data size for this field is 1Kb.' }");
            patcher.Replace("schemas.User.properties.relations", "{ 'type': 'any', 'description': 'The list of the user&s relationships to other users. The maximum allowed data size for this field is 2Kb.' }", "{ 'type': 'array', 'items': { '$ref': 'UserRelation' }, 'description': 'The list of the user&s relationships to other users. The maximum allowed data size for this field is 2Kb.' }");
            patcher.Replace("schemas.User.properties.websites", "{ 'type': 'any', 'description': 'The user&s websites. The maximum allowed data size for this field is 2Kb.' }", "{ 'type': 'array', 'items': { '$ref': 'UserWebsite' }, 'description': 'The user&s websites. The maximum allowed data size for this field is 2Kb.' }");
            patcher.Replace("schemas.Aliases.properties.aliases.items", "{ 'type': 'any' }", "{ '$ref': 'Alias' }");
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
