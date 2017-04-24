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

namespace Google.Apis.Auth.OAuth2.Responses
{
    /// <summary>
    /// Token response exception which is thrown in case of receiving a token error when an authorization code or an 
    /// access token is expected.
    /// </summary>
    public class TokenResponseException : Exception
    {
        /// <summary>The error information.</summary>
        public TokenErrorResponse Error { get; private set; }

        /// <summary>Constructs a new token response exception from the given error.</summary>
        public TokenResponseException(TokenErrorResponse error)
            : base(error.ToString())
        {
            Error = error;
        }
    }
}
