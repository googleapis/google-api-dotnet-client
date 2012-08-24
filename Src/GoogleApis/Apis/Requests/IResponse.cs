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

using System.IO;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Interface defining the response of a request.
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// The response stream.
        /// </summary>
        Stream Stream { get; }

        /// <summary>
        /// The ETag which came with this response (if available), or null otherwise.
        /// </summary>
        string ETag { get; }
    }
}
