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

using System.Collections.Generic;
using Google.Apis.Authentication;
using Google.Apis.Discovery.v1;
using Google.Apis.Discovery.v1.Data;

namespace Google.Build.Utils.Apis
{
    /// <summary>
    /// Gives access to the discovery service.
    /// </summary>
    public static class Discovery
    {
        private static DiscoveryService service;

        /// <summary>
        /// Returns an instance of the discovery service.
        /// </summary>
        public static DiscoveryService Service
        {
            get
            {
                if (service == null)
                {
                    var auth = new DelegateAuthenticator(request => request.Headers["X-User-IP"] = "0.0.0.0");
                    service = new DiscoveryService(auth);
                }
                return service;
            }
        }

        /// <summary>
        /// Lists all APIs in discovery.
        /// </summary>
        public static IEnumerable<DirectoryList.ItemsData> ListApis()
        {
            return Service.Apis.List().Fetch().Items;
        }
    }
}
