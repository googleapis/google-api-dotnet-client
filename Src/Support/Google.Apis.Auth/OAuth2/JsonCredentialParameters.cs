/*
Copyright 2015 Google Inc

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
using System.Collections.Generic;
using System.IO;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Holder for credential parameters read from JSON credential file.
    /// Fields are union of parameters for all supported credential types.
    /// </summary>
    public class JsonCredentialParameters
    {
        /// <summary>
        /// UserCredential is created by the GCloud SDK tool when the user runs
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>.
        /// </summary>
        public const string AuthorizedUserCredentialType = "authorized_user";
        
        /// <summary>
        /// ServiceAccountCredential is downloaded by the user from
        /// <a href="https://console.developers.google.com">Google Developers Console</a>.
        /// </summary>
        public const string ServiceAccountCredentialType = "service_account";

        /// <summary>Type of the credential.</summary>
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Client Id associated with UserCredential created by
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Client Secret associated with UserCredential created by
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
        
        /// <summary>
        /// Client Email associated with ServiceAccountCredential obtained from
        /// <a href="https://console.developers.google.com">Google Developers Console</a>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_email")]
        public string ClientEmail { get; set; }

        /// <summary>
        /// Private Key associated with ServiceAccountCredential obtained from
        /// <a href="https://console.developers.google.com">Google Developers Console</a>.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("private_key")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Refresh Token associated with UserCredential created by
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
