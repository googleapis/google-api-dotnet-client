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

#if ASPNETCORE3
namespace Google.Apis.Auth.AspNetCore3
#else
namespace Google.Apis.Auth.AspNetCore
#endif
{
    /// <summary>
    /// Simple class to allow the authentication scheme to be injected.
    /// </summary>
    internal class GoogleAuthenticationSchemeProvider
    {
        public GoogleAuthenticationSchemeProvider(string scheme) => Scheme = scheme;
        public string Scheme { get; }
    }
}
