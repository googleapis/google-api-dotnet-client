using NUnit.Framework;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Security.Cryptography;

#if NETSTANDARD
using Rsa = System.Security.Cryptography.RSA;
#else
using Rsa = System.Security.Cryptography.RSACryptoServiceProvider;
#endif

namespace Google.Apis.Auth.OAuth2
{
    // This test is executed in NET45 and NETCore.
    // Together they confirm that the RsaStandard RSA implementation is correct.
    [TestFixture]
    public class RsaTests
    {
        private static readonly string base64PrivateKey =
@"MIICdgIBADANBgkqhkiG9w0BAQEFAASCAmAwggJcAgEAAoGBAJJM6HT4s6btOsfe
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
4Z5p2prkjWTLcA==";

        private Rsa GetRsa()
        {
            var privateKeyBytes = Convert.FromBase64String(base64PrivateKey);
            var parameters = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
#if NETSTANDARD
            return new RsaStandard(parameters);
#else
            var rsaCsp = new RSACryptoServiceProvider();
            rsaCsp.ImportParameters(DotNetUtilities.ToRSAParameters(parameters));
            return rsaCsp;
#endif
        }

        [Test]
        public void SignHash()
        {
            Rsa rsa = GetRsa();
            var hash = new byte[32];
            hash[0] = 45;
#if NETSTANDARD
            var signature = rsa.SignHash(hash, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
#else
            var signature = rsa.SignHash(hash, "2.16.840.1.101.3.4.2.1" /* SHA256 OIG */);
#endif
            var expected = new byte[]
            {
                0x5d, 0xfc, 0x98, 0x59, 0x94, 0x64, 0x8c, 0x18, 0x54, 0x88, 0x8d, 0x65, 0xf3, 0xae, 0xdf, 0x76,
                0x66, 0x9c, 0x4d, 0x11, 0x76, 0xf7, 0x16, 0xb8, 0xcb, 0x01, 0xe3, 0x66, 0xf9, 0xc2, 0x1d, 0x96,
                0x26, 0x0a, 0x4f, 0x44, 0xf0, 0x55, 0x8e, 0xe9, 0x37, 0x2e, 0xd8, 0x14, 0xbb, 0xb6, 0x28, 0x24,
                0xbc, 0x41, 0xbc, 0x60, 0xea, 0xfa, 0x66, 0x32, 0xa2, 0x67, 0x5d, 0xd9, 0x12, 0x10, 0xc4, 0x17,
                0x5c, 0x88, 0x21, 0xf7, 0x3a, 0xea, 0xb7, 0x71, 0x14, 0x37, 0xa3, 0xaf, 0x87, 0xa6, 0x5b, 0x80,
                0xd0, 0xa3, 0x95, 0xe6, 0xbd, 0xe0, 0xcf, 0x64, 0xd1, 0xad, 0xf8, 0x11, 0x15, 0x41, 0x6c, 0xb7,
                0x9d, 0xe0, 0xfb, 0x65, 0x51, 0x03, 0xcf, 0xc9, 0x44, 0x66, 0xe7, 0xf7, 0x43, 0x6f, 0xf7, 0xff,
                0x33, 0x44, 0xef, 0x18, 0x18, 0xd1, 0x48, 0xff, 0x0b, 0xc8, 0x93, 0xe9, 0x9f, 0x71, 0x5e, 0xda
            };
            Assert.That(signature, Is.EqualTo(expected));
        }
    }
}
