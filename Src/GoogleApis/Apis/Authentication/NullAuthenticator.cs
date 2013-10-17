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

using System;
using System.Net;

namespace Google.Apis.Authentication
{
    /// <summary>
    /// A placeholder Authenticator which adds no authentication to the request. 
    /// </summary>
    [Obsolete("NullAuthenticator is not supported any more and it's going to be removed in 1.7.0-beta. " +
            "Consider using UserCredential or ServiceAccountCredential from the new Google.Apis.Auth NuGet package " +
            "which supports .NET 4, .NET for Windows, Store apps, Windows Phone 7.5 and 8 and Portable Class " +
            "Libraries as well")]
    public class NullAuthenticator : IAuthenticator
    {
        /// <summary>
        /// Returns the default instance of the NullAuthenticator.
        /// </summary>
        public static readonly NullAuthenticator Instance = new NullAuthenticator();

        #region IAuthenticator Members

        public void ApplyAuthenticationToRequest(HttpWebRequest request)
        {
            // No-op
        }

        #endregion
    }
}