// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiscoveryDocDownloader
{
    /// <summary>
    /// Downloads Discovery docs for all APIs. The discovery documents are saved in
    /// the specified directory in files named APINAME_VERSION.json (e.g. adexchangebuyer_v1.4.json).
    /// Existing files are overwritten.The destination directory is created if it doesn't exist.
    /// </summary>
    class Program
    {
        private static async Task<int> Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Required argument: destination directory");
                return 1;
            }
            string destination = args[0];
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            var client = new HttpClient();
            // Make sure the Discovery server never treats us as a Google-internal client.
            client.DefaultRequestHeaders.Add("X-User-Ip", "0.0.0.0");
            var apis = await LoadApiListAsync(client);
            Console.WriteLine($"Discovery returned {apis.Count} APIs");
            foreach (var api in apis)
            {
                try
                {
                    string text = await FetchAndReformat(client, api);
                    string filename = $"{api.Name}_{api.Version}.json";
                    File.WriteAllText(Path.Combine(destination, filename), text);
                    Console.WriteLine($"Written {filename}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to download API '{api.Name}' version '{api.Version}': {e.Message}");
                }
            }
            return 0;
        }

        private static async Task<List<ApiMetadata>> LoadApiListAsync(HttpClient client)
        {
            var json = await client.GetStringAsync("https://www.googleapis.com/discovery/v1/apis");
            var list = JsonConvert.DeserializeObject<ApiList>(json);
            return list.Items
                .OrderBy(api => api.Name, StringComparer.Ordinal)
                .ThenBy(api => api.Version, StringComparer.Ordinal)
                .ToList();
        }

        private static async Task<string> FetchAndReformat(HttpClient client, ApiMetadata api)
        {
            var json = await client.GetStringAsync(api.DiscoveryUrl);
            var root = JObject.Parse(json);
            var sorted = Sort(root);
            var stringWriter = new StringWriter();
            var writer = new JsonTextWriter(stringWriter)
            {
                Indentation = 1,
                IndentChar = ' ',
                Formatting = Formatting.Indented,
                StringEscapeHandling = StringEscapeHandling.EscapeNonAscii
            };
            sorted.WriteTo(writer);
            return stringWriter.ToString().Replace("\r\n", "\n");
        }

        private static JToken Sort(JToken token) => token switch
        {
            JArray array => Sort(array),
            JObject obj => Sort(obj),
            _ => token
        };

        private static JObject Sort(JObject obj)
        {
            JObject ret = new JObject();
            foreach (var property in obj.Properties().OrderBy(prop => prop.Name, StringComparer.Ordinal))
            {
                ret.Add(property.Name, Sort(property.Value));
            }
            return ret;
        }

        private static JArray Sort(JArray array) => new JArray(array.Select(Sort));
    }
}
