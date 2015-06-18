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
    /// <summary>Provides the Application Default Credential from the environment.</summary>
    public static class GoogleAuth
    {
        private static DefaultCredentialProvider defaultCredentialProvider = new DefaultCredentialProvider();

        /// <summary>
        /// <para>Returns the Application Default Credentials which are ambient credentials that identify and authorize 
        /// the whole application.</para>
        /// <para>The ambient credentials are determined as following order:</para>
        /// <list type="number">
        /// <item> 
        /// <description>The environment variable GOOGLE_APPLICATION_CREDENTIALS is checked. If this variable is specified, it 
        /// should point to a file that defines the credentials. The simplest way to get a credential for this purpose is to 
        /// create a service account using the <a href="https://console.developers.google.com">Google Developers Console</a> in 
        /// the section APIs & Auth, in the sub-section Credentials. Create a service account or choose an existing one and 
        /// select Generate new JSON key. Set the environment variable to the path of the JSON file downloaded.</description> 
        /// </item> 
        /// <item> 
        /// <description>If you have installed the Google Cloud SDK on your machine and have run the command 
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>, your identity can be used as 
        /// a proxy to test code calling APIs from that machine.</description> 
        /// </item> 
        /// <item> 
        /// <description>If you are running in Google Compute Engine production, the built-in service account associated with the 
        /// virtual machine instance will be used.</description> 
        /// </item> 
        /// </list>
        /// </summary>
        public static ICredential GetApplicationDefaultCredential()
        {
            return defaultCredentialProvider.GetApplicationDefaultCredential();
        }
    }
}