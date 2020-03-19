/*
Copyright 2020 Google Inc

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

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Represents the OIDC token formats supported when the token is obtained using the GCE metadata server.
    /// </summary>
    public enum OidcTokenFormat
    {
        /// <summary>
        /// Specifies that the project and instance details should not be
        /// included in the payload of the JWT token returned by the GCE
        /// metadata server.
        /// </summary>
        Standard,

        /// <summary>
        /// Specifies that the project and instance details should be
        /// included in the payload of the JWT token returned by the GCE
        /// metadata server.
        /// </summary>
        Full,

        /// <summary>
        /// Same as <see cref="Full"/>. License codes for images associated with the
        /// GCE instance the token is being obtained from will also be included in the
        /// payload of the JWT token returned by the GCE metadata server.
        /// </summary>
        FullWithLicences
    }
}
