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

using Google.Apis.Json;
using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>Indicates the type of Client Credential.</summary>
    public enum ClientCredentialType
    {
        /// <summary>UserCredential is created by the gcloud sdk tool when the user runs <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>.</summary>
        UserCredential = 1,
        /// <summary>ServiceAccountCredential is downloaded by the user from <a href="https://console.developers.google.com">Google Developers Console</a>.</summary>
        ServiceAccountCredential = 2
    }

    /// <summary>Container for the union of parameters/properties from all credential types.</summary>
    public sealed class ClientCredentialParameters
    {
        /// <summary>Indicates whether the credentials is of type ServiceAccountCredential or UserCredential.</summary>
        [Newtonsoft.Json.JsonProperty("type")]
        private string Type { get; set; }

        /// <summary>Private Key associated with ServiceAccountCredential obtained from <a href="https://console.developers.google.com">Google Developers Console</a>.</summary>
        [Newtonsoft.Json.JsonProperty("private_key")]
        private string PrivateKey { get; set; }

        /// <summary>Client Email assocaited with ServiceAccountCredential obtained from <a href="https://console.developers.google.com">Google Developers Console</a></summary>
        [Newtonsoft.Json.JsonProperty("client_email")]
        public string ClientEmail { get; set; }

        /// <summary>Cliend Id associated with UserCredential created by <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>.</summary>
        [Newtonsoft.Json.JsonProperty("client_id")]
        private string ClientId { get; set; }

        /// <summary>Client Secret associated with UserCredential created by <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>.</summary>
        [Newtonsoft.Json.JsonProperty("client_secret")]
        private string ClientSecret { get; set; }

        /// <summary>Refresh Token associated with UserCredential created by <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>.</summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>Gets the client secrets which contains the client identifier and client secret. </summary>
        public ClientCredentialType CredentialType
        {
            get
            {
                Utilities.ThrowIfNullOrEmpty(Type, "Type");

                switch (Type)
                {
                    case "authorized_user":
                        return ClientCredentialType.UserCredential;

                    case "service_account":
                        return ClientCredentialType.ServiceAccountCredential;

                    default:
                        throw new InvalidOperationException(String.Format("Error parsing stream contents. Unrecognized Credential Type {0}.", Type));
                }
            }
        }

        /// <summary>Gets the ClientSecrets portion of the credential parameters.</summary>
        public ClientSecrets ClientSecrets
        {
            get
            {
                Utilities.ThrowIfNullOrEmpty(ClientId, "ClientId");
                Utilities.ThrowIfNullOrEmpty(ClientSecret, "ClientSecret");

                return new ClientSecrets()
                {
                    ClientId = this.ClientId,
                    ClientSecret = this.ClientSecret
                };
            }
        }

        /// <summary>Gets the PKCS8 unencrypted private key portion of the credential parameters.</summary>
        public string Pkcs8PrivateKey
        {
            get 
            {
                Utilities.ThrowIfNullOrEmpty(PrivateKey, "PrivateKey");
                return PrivateKey;
            }
        }

        /// <summary>Loads the Google client credentials from the input stream.</summary>
        public static ClientCredentialParameters Load(Stream stream)
        {
            return NewtonsoftJsonSerializer.Instance.Deserialize<ClientCredentialParameters>(stream);
        }
    }
}
