using Google.Apis.Json;
using Google.Apis.Tests;
using NUnit.Framework;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    [TestFixture]
    public class ServiceAccountCredentialTests
    {

        [Test]
        public async Task ValidLocallySignedAccessToken_FromPrivateKey()
        {
            const string dummyServiceAccountCredentialFileContents = @"{
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
4Z5p2prkjWTLcA==
-----END PRIVATE KEY-----"",
""client_email"": ""CLIENT_EMAIL"",
""client_id"": ""CLIENT_ID"",
""type"": ""service_account""}";

            var credentialParameters = NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(dummyServiceAccountCredentialFileContents);
            var initializer = new ServiceAccountCredential.Initializer(credentialParameters.ClientEmail)
            {
                Clock = new MockClock { UtcNow = new DateTime(2016, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            };
            var cred = new ServiceAccountCredential(initializer.FromPrivateKey(credentialParameters.PrivateKey));

            Assert.That(cred.Scopes?.Any(), Is.False); // HasScopes must be false for the type of access token we want to test.

            string accessToken = await cred.GetAccessTokenForRequestAsync("http://authurl/");

            string expectedToken =
                "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJDTElFTlRfRU1BSUwiLCJz" +
                "dWIiOiJDTElFTlRfRU1BSUwiLCJhdWQiOiJodHRwOi8vYXV0aHVybC8iLCJleHAiOjE0N" +
                "TE2MTAwMDAsImlhdCI6MTQ1MTYwNjQwMH0.WLljSaAqxMVZnAxFA2SvpA3n2WRlQW71Nb" +
                "CUkbN-ZI-EWoL-HhgiV_3ISrXMvbDHYhBR0vvtXE0PcRcsMEf51Y0jV4DXZ8hf-QJFq7O" +
                "Hrepwe93dnDE6uNVnbj41_0phuy1WKwae29Qp2aPI2Y8E8Z2tXQlF87E_MdgjXVeTF8k";
            Assert.That(accessToken, Is.EqualTo(expectedToken));
        }

        [Test]
        public async Task ValidLocallySignedAccessToken_FromX509Certificate()
        {
#if NETSTANDARD
            const string sPfx = @"
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";

            var x509Cert = new X509Certificate2(Convert.FromBase64String(sPfx));
#else
            const string sPrivateKey = @"
MIICdgIBADANBgkqhkiG9w0BAQEFAASCAmAwggJcAgEAAoGBALQoMIfUT93VMvb5
4U5dsJLXD1D6z4o/VuVlNUaf5xH01qAv8Egpxe6f5frLB/p1eNyDjNIZ3QitD6aN
9Vfh4ifg6txBuBJtIMfSDvRJITNZ2SjKJREbflZuBk0HINKYQk2H+3TIzUbE/pN4
Cu6Mids5L/oVOnRWIe3bEC+PHR7ZAgMBAAECgYBI1qrwb+2ukeFeK59lcMnQRLVD
l3RLv9ohOy80E7h38RbJgzhR5NnK5ck1AduC7vXjqihIVf6g4F+ghmq4knI94KPQ
2fOyQGVV6jVeRVqMusx7tP9V1H26yABiK6TPklcCsWwADFmexfOxfIgbBGSmlbAd
N2/ad1Xog1xDebrbEQJBAO+2qSIDX1ahfxUyvvcMaix6Mrh/OYKb5aH1Y/7MfAav
lpbQavQHNvak2147aPNxy0ZvWdJ2HVA7hUMkgysYWSUCQQDAZalkZMSrve+Onh55
U+w5xjLklhh8PhYxx8plT8ae9VG75dGvWSz/W81B3ILg2lrNU6o08NKBJdZsJYmc
BeKlAkBtJh3zF9gEaTqlW1rqwKNjpyyLJ5r3JqczzLmAXnmmzbLi7vmULejP+5bL
XH/YQZtOcgtTMmb8jm2Kegijyc1lAkANGt+e5v4+dIGMxVhuCzlb9hQhXdftHo2E
dodivzxYN32Jvu25c+mMu0QP6GVBy53Dvp8pW/36rgkc9LGa3wvBAkEA7dGAl95T
UeNFVfuzkYNtQppcSgrx1oTcpTHoNgcvk8AgBf4yDdJJyo0IUONmgJCVffc1aTWn
nf/8cW9YC+0icQ==";
            const string sCert = @"
MIICNDCCAZ2gAwIBAgIJAKl3qU1+NsuuMA0GCSqGSIb3DQEBCwUAMDMxCzAJBgNV
BAYTAkdCMRMwEQYDVQQIDApTb21lLVN0YXRlMQ8wDQYDVQQKDAZHb29nbGUwHhcN
MTYwODEwMTQwOTQ2WhcNNDMxMjI3MTQwOTQ2WjAzMQswCQYDVQQGEwJHQjETMBEG
A1UECAwKU29tZS1TdGF0ZTEPMA0GA1UECgwGR29vZ2xlMIGfMA0GCSqGSIb3DQEB
AQUAA4GNADCBiQKBgQC0KDCH1E/d1TL2+eFOXbCS1w9Q+s+KP1blZTVGn+cR9Nag
L/BIKcXun+X6ywf6dXjcg4zSGd0IrQ+mjfVX4eIn4OrcQbgSbSDH0g70SSEzWdko
yiURG35WbgZNByDSmEJNh/t0yM1GxP6TeArujInbOS/6FTp0ViHt2xAvjx0e2QID
AQABo1AwTjAdBgNVHQ4EFgQUMqzJi099PA8ML5CV1OSiHgiTGoUwHwYDVR0jBBgw
FoAUMqzJi099PA8ML5CV1OSiHgiTGoUwDAYDVR0TBAUwAwEB/zANBgkqhkiG9w0B
AQsFAAOBgQBQ9cMInb2rEcg8TTYq8MjDEegHWLUI9Dq/IvP/FHyKDczza4eX8m+G
3buutN74pX2/GHRgqvqEvvUUuAQUnZ36k6KjTNxfzNLiSXDPNeYmy6PWsUZy4Rye
/Van/ePiXdipTKMiUyl7V6dTjkE5p/e372wNVXUpcxOMmYdWmzSMvg==";

            var privateParams = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(sPrivateKey));
            var x509Cert = new X509Certificate2(Convert.FromBase64String(sCert));
            var rsaParameters = DotNetUtilities.ToRSAParameters(privateParams);
            var privateKey = new System.Security.Cryptography.RSACryptoServiceProvider();
            privateKey.ImportParameters(rsaParameters);
            x509Cert.PrivateKey = privateKey;
#endif
            Assert.That(x509Cert.HasPrivateKey);

            var initializer = new ServiceAccountCredential.Initializer("some-id")
            {
                Clock = new MockClock { UtcNow = new DateTime(2016, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            };
            var cred = new ServiceAccountCredential(initializer.FromCertificate(x509Cert));

            Assert.That(cred.Scopes?.Any(), Is.False); // HasScopes must be false for the type of access token we want to test.

            string accessToken = await cred.GetAccessTokenForRequestAsync("http://authurl/");

            string expectedToken =
                "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzb21lLWlkIiwic3ViIjoi" +
                "c29tZS1pZCIsImF1ZCI6Imh0dHA6Ly9hdXRodXJsLyIsImV4cCI6MTQ1MTYxMDAwMCwia" +
                "WF0IjoxNDUxNjA2NDAwfQ.GfpDHgrFi4ZlGC5LuJEarLU4_eTrT5PVa-S40YtkdB2E1f3" +
                "4naYG2ItcfBEFg7Gbdkr1cIAyipuhEd2yLfPmWGwhOwVcBRNyK_J5w8RodS44mxNJwau0" +
                "jKy4x1K20ybLqcnNgzE0wag6fi5GHwdNIB0URdHDTiC88CRYdl1CIdk";
            Assert.That(accessToken, Is.EqualTo(expectedToken));
        }
    }
}
