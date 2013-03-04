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

namespace Google.Apis.Authentication
{
    /// <summary>
    /// The abstract class used for all OAuth authenticators
    /// </summary>
    public abstract class OAuthAuthenticator : IAuthenticator
    {
        protected OAuthAuthenticator(string consumerKey, string consumerSecret) : base()
        {
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
        }

        /// <summary>
        /// The Consumer Key of OAuth
        /// </summary>
        public string ConsumerKey { get; private set; }

        /// <summary>
        /// The Consumer Secret of OAuth
        /// </summary>
        public string ConsumerSecret { get; private set; }

        #region IAuthenticator Members

        public abstract void ApplyAuthenticationToRequest(System.Net.HttpWebRequest request);

        #endregion
    }
}