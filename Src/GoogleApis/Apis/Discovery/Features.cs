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

using Google.Apis.Util;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Specifies a list of features which can be defined within the discovery document of a service
    /// </summary>
    public enum Features
    {
        /// <summary>
        /// If this feature is specified, then the data of a response is encapsulated within a "data" resource
        /// </summary>
        [StringValue("dataWrapper")]
        LegacyDataResponse,
    }
}
