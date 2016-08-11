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

#if !NETSTANDARD // ServiceAccountCredential initialization from X509 cert not currently supported on netstandard.
        [Test]
        public async Task ValidLocallySignedAccessToken_FromX509Certificate()
        {
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
#endif
    }
}
