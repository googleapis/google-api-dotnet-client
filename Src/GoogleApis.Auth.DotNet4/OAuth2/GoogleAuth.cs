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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Provides the Application Default Credential from the environment. 
    /// </summary>
    public static class GoogleAuth
    {
        private static DefaultCredentialProvider defaultCredentialProvider = new DefaultCredentialProvider();

        /// <summary>
        /// Returns the Application Default Credentials which are credentials that identify and authorize 
        /// the whole application. This is the built-in service account if running on Google Compute Engine 
        /// or the credentials file from the path in the environment variable GOOGLE_APPLICATION_CREDENTIALS.
        /// </summary>
        public static ICredential GetApplicationDefaultCredential()
        {
            return defaultCredentialProvider.GetApplicationDefaultCredential();
        }
    }
}
