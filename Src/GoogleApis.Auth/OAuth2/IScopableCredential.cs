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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Interface for credential types that support alerting scopes
    /// </summary>
    public interface IScopableCredential 
    {
        /// <summary>
        /// Only returns true if this credential type has no scopes by default and requires 
        /// a call to createScoped before use. 
        ///
        /// Credentials need to have scopes in them before they can be used to access Google services. 
        /// Some Credential types have scopes built-in, and some dont. This property indicates whether 
        /// the Credential type has scopes built-in.
        /// 
        /// e.g. 
        /// 1. ComputeCredential has scopes built-in. Nothing additional is required. 
        /// 
        /// 2. UserCredential has scopes built-in, as they were obtained during the consent 
        /// screen. Nothing additional is requierd.
        /// 
        /// 3. ServiceAccountCredentials does not have scopes built-in by default. Caller should 
        /// invoke CreateScoped to add scopes to the Credential.
        /// </summary>
        bool IsCreateScopedRequired { get; }

        /// <summary>
        /// If the credential supports scopes, creates a copy with the specified scopes, 
        /// otherwise return the same instance.
        /// </summary>
        /// <param name="scopes"></param>
        /// <returns></returns>
        ICredential CreateScoped(IEnumerable<string> scopes);
    }
}
