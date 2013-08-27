/*
Copyright 2013 Google Inc

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
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Apis.NuGet.Publisher.Discovery
{
    /// <summary>The discovery service which returns all the APIs.</summary>
    public class DiscoveryService
    {
        /// <summary>Returns all the APIs which supported by the discovery service in the given URI.</summary>
        public async Task<IEnumerable<DiscoveryItem>> GetApis(Uri discoveryUri)
        {
            using (var client = new HttpClient())
            {
                // change X-User-Ip to get only external APIs
                client.DefaultRequestHeaders.Add("X-User-Ip", "0.0.0.0");
                var apis = await client.GetStringAsync(discoveryUri);
                var doc = Newtonsoft.Json.JsonConvert.DeserializeObject<DiscoveryDoc>(apis);
                return doc.Items;
            }
        }
    }
}
