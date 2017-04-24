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

using Newtonsoft.Json;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Interface containing additional response-properties which will be added to every schema type which is 
    /// a direct response to a request.
    /// </summary>
    public interface IDirectResponseSchema
    {
        /// <summary>
        /// The e-tag of this response.
        /// </summary>
        /// <remarks>
        /// Will be set by the service deserialization method, 
        /// or the by json response parser if implemented on service.
        /// </remarks>
        string ETag { get; set; }
    }
}
