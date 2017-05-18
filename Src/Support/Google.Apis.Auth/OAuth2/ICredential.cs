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

using Google.Apis.Http;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// The main interface to represent credential in the client library.
    /// Service account, User account and Compute credential inherit from this interface
    /// to provide access token functionality. In addition this interface inherits from
    /// <see cref="IConfigurableHttpClientInitializer"/> to be able to hook to http requests.
    /// More details are available in the specific implementations.
    /// </summary>
    public interface ICredential : IConfigurableHttpClientInitializer, ITokenAccess
    {
    }
}
