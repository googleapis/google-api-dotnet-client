using Google.Apis.Auth.OAuth2;
using Google.Apis.Json;
using Google.Apis.Tests;
using Google.Apis.Tests.Mocks;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class ServiceAccountCredentialTests
    {

        [Fact]
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

            Assert.False(cred.Scopes?.Any()); // HasScopes must be false for the type of access token we want to test.

            string accessToken = await cred.GetAccessTokenForRequestAsync("http://authurl/");

            string expectedToken =
                "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJDTElFTlRfRU1BSUwiLCJz" +
                "dWIiOiJDTElFTlRfRU1BSUwiLCJhdWQiOiJodHRwOi8vYXV0aHVybC8iLCJleHAiOjE0N" +
                "TE2MTAwMDAsImlhdCI6MTQ1MTYwNjQwMH0.WLljSaAqxMVZnAxFA2SvpA3n2WRlQW71Nb" +
                "CUkbN-ZI-EWoL-HhgiV_3ISrXMvbDHYhBR0vvtXE0PcRcsMEf51Y0jV4DXZ8hf-QJFq7O" +
                "Hrepwe93dnDE6uNVnbj41_0phuy1WKwae29Qp2aPI2Y8E8Z2tXQlF87E_MdgjXVeTF8k";
            Assert.Equal(expectedToken, accessToken);
        }

        private string ToHex(byte[] bs) => bs.Aggregate("", (acc, b) => acc + b.ToString("X2"));

        [Fact]
        public void Pkcs8Decoding_FromPrivateKey()
        {
            // This is a service credential, as downloaded from the Cloud Console on 2016-12-08
            string dummyServiceAccountCredentialFileContents = @"
{
""type"": ""service_account"",
""private_key_id"": ""71bb487f3414f923196c5c433cf20a8c0f689562"",
""private_key"": ""-----BEGIN PRIVATE KEY-----
MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQDQvitimRPWE2YM
tOADu3jb89UQmqZz8ao6NFoAjYiYDdg/6UBUTscQwGb6rIvllMtcT6BdS4rMKUwv
kSQFbO14gi7FiZBj4eJKveObVnt9RPxqT1txBieEPFtgJalh0GpyCo5GUmadgqe+
89ZF+VQBFE2hMoZhBny/FDba2/qDIk1GmksdXjC67ZI0EYRCGI71eXjOpQX/wOJs
tosMQRSTHjPKhZKvZTtjksMRWm8SlQoyORZKXsV6OGKztOieIvncKoX3lrkSupax
J+v0yYQJIF2uTFDbbCDL86bgUJ7TyZJ9X1AvrnHGNWp+QzQBDbTCMpZCuY81ARdu
BHeacqR3AgMBAAECggEAK7Cx+fgaO8Nhp6UwAff6KudVIB2OW1QokfglIlp9TX4Q
VggnC75VUf9DTpJQ0aOcEN0lroFCMssuBAK37F7JMWDmEzhgvVco+wXVnsyyGh0X
S9UCSZzFJptPcMdRNYTe0rG856EVk0AmhgQZRBoUaAls2iFuGN63u3KqrJJAU7O4
MPofQizwNcMmiDqRV0rnU6HgmIRQ64hMMh1bnnw4I35esOXjO1O2PiwyyK0jHuVz
eBNeD0wEXNLIP4CqDsQ0DKyBPKXZW4bmFnluq4s+VvgPMczUli7Ph0bM7G1oR0LF
nZk8tSO9cZ4lLcZpY5mHg7lHzSE6oPAxrkPYoa+6IQKBgQD6I7KaUcmkQj+vOQ18
sZCA28tXqjW2cGB4ThqG2uYeHK8khhjh/Pj07TFr8Xjpz1gNr1NNBJhR9Qs/dO9N
WCXS6s0fsVz/gm8N36w7kcBe+Uo43UIt3U6xvZVG4eJYWe2B5+0sZeXzMfzGhwug
VkinOJ0CoVpGFTByPrn17O9T8QKBgQDVoi5AO7jvL3nxLQyfXy6XhkHvmnrRU5hV
eHrgO2+0TsjAHNRhGGrKTMDqCrMvJqxXbXAwNIKxPdzGCXjam4QzaXgp8+bJWHNe
UNRfbWUxVo/Mzfp4owN6oCOVN2cTrnz/doFhuT1LjDj2KK5+hY6qtleH+h00XjCi
0xrTGCpG5wKBgDy0pya+jKI5lb0Pqo9FhJ1ROkM3QrvZAACSa+uoekp6iaLijG1j
+INwgRsCSmbr9CG2GBBL+i+Buc4Xse/iYaOTal6zq68y14LVcrYuRDKIa5PrVqFM
4UlPikfekBEDGhn50FyDClCAJCmGIrMx3YX/vlMiF4eEovJG+NiPPPHxAoGBANQq
qKJ0bbtmPEYQxot1HTGxTcSneDhyPEUOTYJqpQq+f9OEDkyL0msthR4rGD/Iubpu
XtARJobeeGdZuuPpNYdVxNhteZQXuyQ9RF2tqKUyYcg1/P5YbzkW15/3EPDUByIz
UFV8geqIzX1zc7EF9WWHiDDsbpq2vLjIzcg+JKabAoGAI7kuoGBdvIHne3Y3tucQ
JzcnYI3bppbhyn1dmm8jsaaWrtBvFqCb1y1MjaoL4lNi+brdd6bpV5u447GBQfG8
o3L1luXTksRPmwh5NbhXWl/ieiWc6WQL6sr8Q+vSYDKAo95zdhWJvWs+/v7NfWoF
lK1DcBvq+IFLucBdi0/9hXE=
-----END PRIVATE KEY-----"",
""client_email"": ""CLIENT_EMAIL"",
""client_id"": ""112326926692598796719""
}";

            var credentialParameters = NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(dummyServiceAccountCredentialFileContents);
            var initializer = new ServiceAccountCredential.Initializer(credentialParameters.ClientEmail)
            {
                Clock = new MockClock { UtcNow = new DateTime(2016, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            };
            initializer.FromPrivateKey(credentialParameters.PrivateKey);
            var ps = initializer.Key.ExportParameters(true);

            Assert.Equal("D0BE2B629913D613660CB4E003BB78DBF3D5109AA673F1AA3A345A008D88980DD83FE940544EC710C066FAAC8BE594CB5C4FA05D4B8ACC294C2F9124056CED78822EC5899063E1E24ABDE39B567B7D44FC6A4F5B710627843C5B6025A961D06A720A8E4652669D82A7BEF3D645F95401144DA1328661067CBF1436DADBFA83224D469A4B1D5E30BAED9234118442188EF57978CEA505FFC0E26CB68B0C4114931E33CA8592AF653B6392C3115A6F12950A3239164A5EC57A3862B3B4E89E22F9DC2A85F796B912BA96B127EBF4C98409205DAE4C50DB6C20CBF3A6E0509ED3C9927D5F502FAE71C6356A7E4334010DB4C2329642B98F3501176E04779A72A477", ToHex(ps.Modulus));
            Assert.Equal("010001", ToHex(ps.Exponent));
            Assert.Equal("2BB0B1F9F81A3BC361A7A53001F7FA2AE755201D8E5B542891F825225A7D4D7E105608270BBE5551FF434E9250D1A39C10DD25AE814232CB2E0402B7EC5EC93160E6133860BD5728FB05D59ECCB21A1D174BD502499CC5269B4F70C7513584DED2B1BCE7A115934026860419441A1468096CDA216E18DEB7BB72AAAC924053B3B830FA1F422CF035C326883A91574AE753A1E0988450EB884C321D5B9E7C38237E5EB0E5E33B53B63E2C32C8AD231EE57378135E0F4C045CD2C83F80AA0EC4340CAC813CA5D95B86E616796EAB8B3E56F80F31CCD4962ECF8746CCEC6D684742C59D993CB523BD719E252DC66963998783B947CD213AA0F031AE43D8A1AFBA21", ToHex(ps.D));
            Assert.Equal("FA23B29A51C9A4423FAF390D7CB19080DBCB57AA35B67060784E1A86DAE61E1CAF248618E1FCF8F4ED316BF178E9CF580DAF534D049851F50B3F74EF4D5825D2EACD1FB15CFF826F0DDFAC3B91C05EF94A38DD422DDD4EB1BD9546E1E25859ED81E7ED2C65E5F331FCC6870BA05648A7389D02A15A461530723EB9F5ECEF53F1", ToHex(ps.P));
            Assert.Equal("D5A22E403BB8EF2F79F12D0C9F5F2E978641EF9A7AD1539855787AE03B6FB44EC8C01CD461186ACA4CC0EA0AB32F26AC576D70303482B13DDCC60978DA9B8433697829F3E6C958735E50D45F6D6531568FCCCDFA78A3037AA02395376713AE7CFF768161B93D4B8C38F628AE7E858EAAB65787FA1D345E30A2D31AD3182A46E7", ToHex(ps.Q));
            Assert.Equal("3CB4A726BE8CA23995BD0FAA8F45849D513A433742BBD90000926BEBA87A4A7A89A2E28C6D63F88370811B024A66EBF421B618104BFA2F81B9CE17B1EFE261A3936A5EB3ABAF32D782D572B62E4432886B93EB56A14CE1494F8A47DE9011031A19F9D05C830A508024298622B331DD85FFBE5322178784A2F246F8D88F3CF1F1", ToHex(ps.DP));
            Assert.Equal("D42AA8A2746DBB663C4610C68B751D31B14DC4A77838723C450E4D826AA50ABE7FD3840E4C8BD26B2D851E2B183FC8B9BA6E5ED0112686DE786759BAE3E9358755C4D86D799417BB243D445DADA8A53261C835FCFE586F3916D79FF710F0D407223350557C81EA88CD7D7373B105F565878830EC6E9AB6BCB8C8CDC83E24A69B", ToHex(ps.DQ));
            Assert.Equal("23B92EA0605DBC81E77B7637B6E710273727608DDBA696E1CA7D5D9A6F23B1A696AED06F16A09BD72D4C8DAA0BE25362F9BADD77A6E9579BB8E3B18141F1BCA372F596E5D392C44F9B087935B8575A5FE27A259CE9640BEACAFC43EBD2603280A3DE73761589BD6B3EFEFECD7D6A0594AD43701BEAF8814BB9C05D8B4FFD8571", ToHex(ps.InverseQ));
        }

        [Fact]
        public async Task ValidLocallySignedAccessToken_FromX509Certificate()
        {
#if NETCOREAPP1_0 || NETCOREAPP1_1
            const string sPfx = @"
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";

            var x509Cert = new X509Certificate2(Convert.FromBase64String(sPfx));
#elif NET452 || NET46
            const string sPrivateKey = @"
-----BEGIN PRIVATE KEY-----
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
nf/8cW9YC+0icQ==
-----END PRIVATE KEY-----";
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

            var x509Cert = new X509Certificate2(Convert.FromBase64String(sCert));
            RSAParameters rsaParameters = Pkcs8.DecodeRsaParameters(sPrivateKey);
            var privateKey = new System.Security.Cryptography.RSACryptoServiceProvider();
            privateKey.ImportParameters(rsaParameters);
            x509Cert.PrivateKey = privateKey;
#else
#error Unsupported target
#endif
            Assert.True(x509Cert.HasPrivateKey);

            var initializer = new ServiceAccountCredential.Initializer("some-id")
            {
                Clock = new MockClock { UtcNow = new DateTime(2016, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            };
            var cred = new ServiceAccountCredential(initializer.FromCertificate(x509Cert));

            Assert.False(cred.Scopes?.Any()); // HasScopes must be false for the type of access token we want to test.

            string accessToken = await cred.GetAccessTokenForRequestAsync("http://authurl/");

            string expectedToken =
                "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzb21lLWlkIiwic3ViIjoi" +
                "c29tZS1pZCIsImF1ZCI6Imh0dHA6Ly9hdXRodXJsLyIsImV4cCI6MTQ1MTYxMDAwMCwia" +
                "WF0IjoxNDUxNjA2NDAwfQ.GfpDHgrFi4ZlGC5LuJEarLU4_eTrT5PVa-S40YtkdB2E1f3" +
                "4naYG2ItcfBEFg7Gbdkr1cIAyipuhEd2yLfPmWGwhOwVcBRNyK_J5w8RodS44mxNJwau0" +
                "jKy4x1K20ybLqcnNgzE0wag6fi5GHwdNIB0URdHDTiC88CRYdl1CIdk";
            Assert.Equal(expectedToken, accessToken);
        }
    }
}
