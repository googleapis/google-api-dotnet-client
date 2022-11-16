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
            patcher.FromAnyToTypedArray("schemas.User.properties.addresses", "UserAddress");
            patcher.FromAnyToTypedArray("schemas.User.properties.emails", "UserEmail");
            patcher.FromAnyToTypedArray("schemas.User.properties.externalIds", "UserExternalId");
            patcher.FromAnyToTypedArray("schemas.User.properties.ims", "UserIm");
            patcher.FromAnyToTypedArray("schemas.User.properties.organizations", "UserOrganization");
            patcher.FromAnyToTypedArray("schemas.User.properties.phones", "UserPhone");
            patcher.FromAnyToTypedArray("schemas.User.properties.relations", "UserRelation");
            patcher.FromAnyToTypedArray("schemas.User.properties.websites", "UserWebsite");
            patcher.FromAnyToTyped("schemas.Aliases.properties.aliases.items", "Alias");
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
