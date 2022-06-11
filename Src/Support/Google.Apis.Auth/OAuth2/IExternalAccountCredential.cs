/*
Copyright 2022 Google LLC

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

using Google.Apis.Http;

namespace Google.Apis.Auth.OAuth2
{

    /// <summary>
    /// An external account credential to support Workload Identity Federation.
    /// You can read about Workload Identity Federation in
    /// https://cloud.google.com/iam/docs/workload-identity-federation and
    /// https://google.aip.dev/auth/4117.
    /// </summary>
    public interface IExternalAccountCredential: ICredential, ITokenAccessWithHeaders,
        IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler
    {
        /// <summary>
        /// The configuration of this external account credential.
        /// </summary>
        ExternalAccountConfiguration Configuration { get; }
    }
}
