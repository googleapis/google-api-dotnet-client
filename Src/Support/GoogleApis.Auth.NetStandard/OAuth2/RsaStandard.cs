using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using System;
using System.IO;
using System.Security.Cryptography;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// An implementation of RSA, just sufficient for the needs of ServiceAccountCredential.
    /// This is not a general-purpose implementation of RSA.
    /// </summary>
    internal class RsaStandard : RSA
    {
        public RsaStandard(RsaPrivateCrtKeyParameters parameters)
        {
            _parameters = parameters;
        }

        private RsaPrivateCrtKeyParameters _parameters;

        public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
        {
            throw new NotImplementedException();
        }

        public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
        {
            throw new NotImplementedException();
        }

        public override RSAParameters ExportParameters(bool includePrivateParameters)
        {
            throw new NotImplementedException();
        }

        public override void ImportParameters(RSAParameters parameters)
        {
            throw new NotImplementedException();
        }

        public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
        {
            if (hashAlgorithm != HashAlgorithmName.SHA256)
            {
                throw new ArgumentException(
                    $"Unsupported HashAlgorithmName '{hashAlgorithm}', only SHA256 supported.", nameof(hashAlgorithm));
            }
            if (padding != RSASignaturePadding.Pkcs1)
            {
                throw new ArgumentException(
                    $"Unsupported RSASignaturePadding '{padding}', only Pkcs1 supported.", nameof(padding));
            }
            var signer = new RsaDigestSigner(new NullDigest(), NistObjectIdentifiers.IdSha256);
            signer.Init(true, _parameters);
            signer.BlockUpdate(hash, 0, hash.Length);
            return signer.GenerateSignature();
        }

        public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
        {
            throw new NotImplementedException();
        }

        protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
        {
            throw new NotImplementedException();
        }

        protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
        {
            throw new NotImplementedException();
        }
    }
}
