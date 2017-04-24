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

namespace Google.Apis
{
    /// <summary>
    /// Defines the behaviour/header used for sending an etag along with a request.
    /// </summary>
    public enum ETagAction
    {
        /// <summary>
        /// The default etag behaviour will be determined by the type of the request.
        /// </summary>
        Default,

        /// <summary>
        /// The ETag won't be added to the header of the request.
        /// </summary>
        Ignore,

        /// <summary>
        /// The ETag will be added as an "If-Match" header.
        /// A request sent with an "If-Match" header will only succeed if both ETags are identical.
        /// </summary>
        IfMatch,

        /// <summary>
        /// The ETag will be added as an "If-None-Match" header.
        /// A request sent with an "If-Match" header will only succeed if both ETags are not identical.
        /// </summary>
        IfNoneMatch,
    }
}
