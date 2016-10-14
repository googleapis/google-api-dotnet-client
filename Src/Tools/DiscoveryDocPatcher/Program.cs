using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoveryDocPatcher
{

    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                string discoveryDocPath = args[0];
                PatchGames(discoveryDocPath);
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
            var patcher = Patcher.Load(Path.Combine(rootPath, "games_v1.json"));
            // Remove deprecated enum value that causes duplicate C# enum value.
            patcher.Remove("resources.players.methods.list.parameters.collection.enum[1]", "'playedWith'", "'played_with'");
            patcher.Remove("resources.players.methods.list.parameters.collection.enumDescriptions[1]",
                "'(DEPRECATED: please use played_with!) Retrieve a list of players you have played a multiplayer game (realtime or turn-based) with recently.'",
                "'Retrieve a list of players you have played a multiplayer game (realtime or turn-based) with recently.'");
            patcher.SaveWithBackup();
        }

        static void PatchDirectory(string rootPath)
        {
            var patcher = Patcher.Load(Path.Combine(rootPath, "admin_directory_v1.json"));
            // Strongly-type properties that are defined without typing.
            patcher.Replace("schemas.User.properties.addresses", "{ 'type': 'any' }", "{ 'type': 'array', 'items': { '$ref': 'UserAddress' } }");
            patcher.Replace("schemas.User.properties.emails", "{ 'type': 'any' }", "{ 'type': 'array', 'items': { '$ref': 'UserEmail' } }");
            patcher.Replace("schemas.User.properties.externalIds", "{ 'type': 'any' }", "{ 'type': 'array', 'items': { '$ref': 'UserExternalId' } }");
            patcher.Replace("schemas.User.properties.ims", "{ 'type': 'any' }", "{ 'type': 'array', 'items': { '$ref': 'UserIm' } }");
            patcher.Replace("schemas.User.properties.organizations", "{ 'type': 'any' }", "{ 'type': 'array', 'items': { '$ref': 'UserOrganization' } }");
            patcher.Replace("schemas.User.properties.phones", "{ 'type': 'any' }", "{ 'type': 'array', 'items': { '$ref': 'UserPhone' } }");
            patcher.Replace("schemas.User.properties.relations", "{ 'type': 'any' }", "{ 'type': 'array', 'items': { '$ref': 'UserRelation' } }");
            patcher.Replace("schemas.User.properties.websites", "{ 'type': 'any' }", "{ 'type': 'array', 'items': { '$ref': 'UserWebsite' } }");
            patcher.Replace("schemas.Aliases.properties.aliases.items", "{ 'type': 'any' }", "{ '$ref': 'Alias' }");
            patcher.SaveWithBackup();

        }
    }
}
