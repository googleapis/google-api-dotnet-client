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
using DotNetOpenAuth.OAuth2;

namespace Google.Apis.Authentication.OAuth2
{
    /// <summary>
    /// Class containing information about the Google OAuth2 authentication server.
    /// </summary>
    public static class GoogleAuthenticationServer
    {
        static GoogleAuthenticationServer()
        {
            // Set the auth server description.
            Description = new AuthorizationServerDescription
                              {
                                  AuthorizationEndpoint = new Uri("https://accounts.google.com/o/oauth2/auth"),
                                  TokenEndpoint = new Uri("https://accounts.google.com/o/oauth2/token"),
                                  ProtocolVersion = ProtocolVersion.V20,
                              };
        }

        /// <summary>
        /// Returns the description for the Google Authorization Server.
        /// </summary>
        /// <returns></returns>
        public static AuthorizationServerDescription Description { get; private set; }
    }
}