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

using System.Web.Mvc;

using Google.Apis.Auth.OAuth2.Flows;

namespace Google.Apis.Auth.OAuth2.Mvc
{
    /// <summary>
    /// Flow metadata abstract class which contains the reference to the
    /// <see cref="Google.Apis.Auth.OAuth2.Flows.IAuthorizationCodeFlow"/> and
    /// method to get the user identifier.
    /// </summary>
    public abstract class FlowMetadata
    {
        /// <summary>
        /// Gets the user identifier.
        /// </summary>
        /// <param name="controller">The controller</param>
        /// <returns>User identifier</returns>
        public abstract string GetUserId(Controller controller);

        /// <summary>Gets the authorization code flow.</summary>
        public abstract IAuthorizationCodeFlow Flow { get; }

        /// <summary>
        /// Gets the authorization application's call back. That relative URL will handle the authorization code 
        /// response.
        /// </summary>
        public virtual string AuthCallback
        {
            get { return @"/AuthCallback/IndexAsync"; }
        }
    }
}
