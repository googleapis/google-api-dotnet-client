/*
Copyright 2018 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Apis.Auth.AspNetCore
{
    /// <summary>
    /// Default values related to the Google OpenIdConnect authentication handler.
    /// </summary>
    public static class GoogleOpenIdConnectDefaults
    {
        /// <summary>
        /// The default value used for the authentication scheme.
        /// </summary>
        public const string AuthenticationScheme = "GoogleOpenIdConnect";

        /// <summary>
        /// The default value for the display name.
        /// </summary>
        public const string DisplayName = "Google OpenIdConnect";
    }
}
