/*
Copyright 2014 Google Inc

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

using Windows.Security.Authentication.Web;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Contains the WebAuthenticationResult data. WebAuthenticationResult doesn't have an empty constructor, and as a
    /// result it can't be deserialized.
    /// </summary>
    public class SerializableWebAuthResult
    {
        public static string Name = "authorization_result";

        /// <summary>Gets or sets the the protocol data when the operation successfully completes.</summary>
        public string ResponseData { get; set; }
        /// <summary>Gets or sets the HTTP error code when ResponseStatus is equal to ErrorHttp.</summary>
        public uint ResponseErrorDetail { get; set; }
        /// <summary>Gets or sets the status of the asynchronous operation when it completes.</summary>
        public WebAuthenticationStatus ResponseStatus { get; set; }

        /// <summary>Empty default constructor.</summary>
        public SerializableWebAuthResult() { }

        /// <summary>Constructs a new instance of the class and set its properties by the specified result.</summary>
        public SerializableWebAuthResult(WebAuthenticationResult result)
        {
            this.ResponseData = result.ResponseData;
            this.ResponseErrorDetail = result.ResponseErrorDetail;
            this.ResponseStatus = result.ResponseStatus;
        }
    }
}