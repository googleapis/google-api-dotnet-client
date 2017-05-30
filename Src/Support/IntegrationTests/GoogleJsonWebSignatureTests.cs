/*
Copyright 2017 Google Inc

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

using Google.Apis.Auth;
using Google.Apis.Util;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class GoogleJsonWebSignatureTests
    {
        [Fact]
        public async Task GetGoogleCerts()
        {
            // Verifies certs are downloaded and loaded into RSAs
            var certs = await GoogleJsonWebSignature.GetGoogleCertsAsync(SystemClock.Default, false, null);
            Assert.NotEmpty(certs);
        }
    }
}
