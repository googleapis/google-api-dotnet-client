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
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Json;

using NUnit.Framework;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.GoogleCredential"/>.</summary>
    [TestFixture]
    public class GoogleCredentialTests
    {
        private const string DummyAuthUri = "https://www.googleapis.com/google.some_google_api";
        private const string DummyUserCredentialFileContents = @"{
""client_id"": ""CLIENT_ID"",
""client_secret"": ""CLIENT_SECRET"",
""refresh_token"": ""REFRESH_TOKEN"",
""type"": ""authorized_user""}";
        private const string DummyServiceAccountCredentialFileContents = @"{
""private_key_id"": ""PRIVATE_KEY_ID"",
""private_key"": ""-----BEGIN PRIVATE KEY-----
MIICdgIBADANBgkqhkiG9w0BAQEFAASCAmAwggJcAgEAAoGBAJJM6HT4s6btOsfe
2x4zrzrwSUtmtR37XTTi0sPARTDF8uzmXy8UnE5RcVJzEH5T2Ssz/ylX4Sl/CI4L
no1l8j9GiHJb49LSRjWe4Yx936q0Xj9H0R1HTxvjUPqwAsTwy2fKBTog+q1frqc9
o8s2r6LYivUGDVbhuUzCaMJsf+x3AgMBAAECgYEAi0FTXsu/zRswAUGaViQiHjrL
uU65BSHXNVjV/2fLNEKnGWGqpli68z1IXY+S2nwbUak7rnGsq9/0F6jtsW+hZbLk
KXUOuuExpeC5Kd6ngWX/f2jqmhlUabiQijU9cVk7pMq8EHkRtvlosnMTUAEzempu
QUPwn1PZHhmJkBvZ4lECQQDCErrxl+e3BwUDcS0yVEEmCNSG6xdXs2878b8rzbe7
3Mmi6SuuOLi3PU92J+j+f/MOdtYrk13mEDdYmd5dhrt5AkEAwPvDEsDT/W4y4h5n
gv1awGBA5aLFE1JNWM/Gwn4D1cGpEDHKFREaBtxMDCASpHJuw8r7zUywpKhmBZcf
GS37bwJANdSAKfbafLfjuhqwUJ9yGpykZm/a36aTmerp/bpn1iHdg+RtCzwMcDb/
TWSwibbvsflgWmHbz657y4WSWhq+8QJAWrpCNN/ZCk2zuGDo80lfUBAwkoVat8G6
wWU1oZyS+vzIGef+hLb8kHsjeZPej9eIwZ39kcBbT54oELrCkRjwGwJAQ8V2A7lT
ZUp8AsbVqF6rbLiiUfJMo2btGclQu4DEVyS+ymFA65tXDLUuR9EDqJYdqHNZJ5B8
4Z5p2prkjWTLcA\u003d\u003d
-----END PRIVATE KEY-----"",
""client_email"": ""CLIENT_EMAIL"",
""client_id"": ""CLIENT_ID"",
""type"": ""service_account""}";

        [Test]
        public void FromStream_UserCredential()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(DummyUserCredentialFileContents));
            var credential = GoogleCredential.FromStream(stream);
            Assert.IsFalse(credential.IsCreateScopedRequired);
        }

        [Test]
        public void FromStream_ServiceAccountCredential()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(DummyServiceAccountCredentialFileContents));
            var credential = GoogleCredential.FromStream(stream);
            Assert.IsInstanceOf(typeof(ServiceAccountCredential), credential.UnderlyingCredential);
            Assert.IsTrue(credential.IsCreateScopedRequired);
        }

        /// <summary>
        /// Creates service account credential from stream, obtains a JWT token
        /// from the credential and checks the access token is well-formed.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task FromStream_ServiceAccountCredential_GetJwtAccessToken()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(DummyServiceAccountCredentialFileContents));
            var credential = GoogleCredential.FromStream(stream);

            // Without adding scopes, the credential should be generating JWT scopes.
            string accessToken = await (credential as ITokenAccess).GetAccessTokenForRequestAsync(DummyAuthUri);
            var parts = accessToken.Split(new[] {'.'});
            Assert.AreEqual(3, parts.Length);

            var header = NewtonsoftJsonSerializer.Instance.Deserialize<JsonWebSignature.Header>(UrlSafeDecode64(parts[0]));
            Assert.AreEqual("JWT", header.Type);
            Assert.AreEqual("RS256", header.Algorithm);

            var payload = NewtonsoftJsonSerializer.Instance.Deserialize<JsonWebSignature.Payload>(UrlSafeDecode64(parts[1]));

            Assert.AreEqual("CLIENT_EMAIL", payload.Issuer);
            Assert.AreEqual("CLIENT_EMAIL", payload.Subject);
            Assert.AreEqual(DummyAuthUri, payload.Audience);
            Assert.AreEqual(3600, payload.ExpirationTimeSeconds - payload.IssuedAtTimeSeconds);
        }

        private string UrlSafeDecode64(string urlSafeBase64)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(urlSafeBase64));
        }
    }
}
