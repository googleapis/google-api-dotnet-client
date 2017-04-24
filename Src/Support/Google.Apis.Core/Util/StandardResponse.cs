/*
Copyright 2010 Google Inc

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

using Google.Apis.Requests;
using Newtonsoft.Json;

namespace Google.Apis.Util
{
    /// <summary>
    /// Calls to Google Api return StandardResponses as Json with
    /// two properties Data, being the return type of the method called
    /// and Error, being any errors that occure.
    /// </summary>
    public sealed class StandardResponse<InnerType>
    {
        /// <summary>May be null if call failed.</summary>
        [JsonProperty("data")]
        public InnerType Data { get; set; }

        /// <summary>May be null if call succedded.</summary>
        [JsonProperty("error")]
        public RequestError Error { get; set; }
    }
}