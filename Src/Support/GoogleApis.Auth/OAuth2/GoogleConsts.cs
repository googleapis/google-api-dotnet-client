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

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>Google OAuth2 constants.</summary>
    public static class GoogleAuthConsts
    {
        /// <summary>The authorization code server URL.</summary>
        public const string AuthorizationUrl = "https://accounts.google.com/o/oauth2/auth";

        /// <summary>The approval URL (used in the Windows solution as a callback).</summary>
        public const string ApprovalUrl = "https://accounts.google.com/o/oauth2/approval";

        /// <summary>The authorization token server URL.</summary>
        public const string TokenUrl = "https://accounts.google.com/o/oauth2/token";

        /// <summary>The Compute Engine authorization token server URL</summary>
        public const string ComputeTokenUrl =
            "http://metadata/computeMetadata/v1/instance/service-accounts/default/token";

        /// <summary>The path to the Google revocation endpoint.</summary>
        public const string RevokeTokenUrl = "https://accounts.google.com/o/oauth2/revoke";

        /// <summary>Installed application redirect URI.</summary>
        public const string InstalledAppRedirectUri = "urn:ietf:wg:oauth:2.0:oob";

        /// <summary>Installed application localhost redirect URI.</summary>
        public const string LocalhostRedirectUri = "http://localhost";
    }
}