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

using System;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util.Store;

namespace Google.Apis.Auth.OAuth2.Web
{
    /// <summary>Auth Utility methods for web development.</summary>
    public class AuthWebUtility
    {
        /// <summary>Extracts the redirect URI from the state OAuth2 parameter.</summary>
        /// <remarks>
        /// If the data store is not <c>null</c>, this method verifies that the state parameter which was returned
        /// from the authorization server is the same as the one we set before redirecting to the authorization server.
        /// </remarks>
        /// <param name="dataStore">The data store which contains the original state parameter.</param>
        /// <param name="userId">User identifier.</param>
        /// <param name="state">
        /// The authorization state parameter which we got back from the authorization server.
        /// </param>
        /// <returns>Redirect URI to the address which initializes the authorization code flow.</returns>
        public static async Task<string> ExtracRedirectFromState(IDataStore dataStore, string userId, string state)
        {
            var oauthState = state;
            if (dataStore != null)
            {
                var userKey = AuthorizationCodeWebApp.StateKey + userId;
                var expectedState = await dataStore.GetAsync<string>(userKey).ConfigureAwait(false);

                // Verify that the stored state is equal to the one we got back from the authorization server.
                if (!Object.Equals(oauthState, expectedState))
                {
                    throw new TokenResponseException(new TokenErrorResponse
                    {
                        Error = "State is invalid"
                    });
                }
                await dataStore.DeleteAsync<string>(userKey).ConfigureAwait(false);
                oauthState = oauthState.Substring(0, oauthState.Length - AuthorizationCodeWebApp.StateRandomLength);
            }

            return oauthState;
        }
    }
}
