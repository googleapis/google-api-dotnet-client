/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.IO;
using System.Linq;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Json;

namespace GoogleApis.Tools.ServiceGenerator
{
    /// <summary>
    /// Describes a discovery service repository.
    /// </summary>
    public static class DiscoveryRepository
    {
        private const string GoogleDiscoveryURL = "https://www.googleapis.com/discovery/v1/apis";
 
        /// <summary>
        /// Retrieves the list of APIs of the specified discovery reposistory.
        /// </summary>
        public static IEnumerable<DirectoryList.ItemsData> RetrieveDiscovery(Uri listUri)
        {
            string document = Utils.FetchDocument(listUri);
            var items = new NewtonsoftJsonSerializer().Deserialize<DirectoryList>(document).Items 
                            ?? Enumerable.Empty<DirectoryList.ItemsData>();

            // Make the path references rooted. We do this so that we can use just the ItemsData object
            // to generate an API.
            string basePath = listUri.ToString().Substring(0, listUri.ToString().LastIndexOf('/') + 1);
            foreach (DirectoryList.ItemsData api in items)
            {
                if (api.DiscoveryLink.StartsWith("./"))
                {
                    api.DiscoveryLink = basePath + api.DiscoveryLink.Substring("./".Length);
                }
                else if (api.DiscoveryLink.StartsWith("../"))
                {
                    api.DiscoveryLink = basePath + api.DiscoveryLink;
                }
            }

            return items;
        }

        /// <summary>
        /// Retrieves the list of apis in the Google Discovery repository.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<DirectoryList.ItemsData> RetrieveGoogleDiscovery()
        {
            return RetrieveDiscovery(new Uri(GoogleDiscoveryURL));
        }
    }
}
