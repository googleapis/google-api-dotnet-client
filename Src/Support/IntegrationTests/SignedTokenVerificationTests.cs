/*
Copyright 2020 Google Inc

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

using Google.Apis.Auth.OAuth2;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Auth.SignedTokenVerification;

namespace IntegrationTests
{
    public class SignedTokenVerificationTests
    {
        [Fact]
        public async Task CertificateCache()
        {
            var certCache = new CertificateCache();

            // We don't care about cert transformation here, that'll be tested when verifying.
            var certificates = await certCache.GetCertificatesAsync(GoogleAuthConsts.JsonWebKeySetUrl, json => RSA.Create(), false, default);

            Assert.NotEmpty(certificates);
        }
    }
}
