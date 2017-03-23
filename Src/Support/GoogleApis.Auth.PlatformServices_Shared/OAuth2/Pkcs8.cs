/*
Copyright 2016 Google Inc

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

using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace Google.Apis.Auth.OAuth2
{
    internal class Pkcs8
    {
        // PKCS#8 specification: https://www.ietf.org/rfc/rfc5208.txt
        // ASN.1 specification: https://www.itu.int/ITU-T/studygroups/com17/languages/X.690-0207.pdf

        /// <summary>
        /// An incomplete ASN.1 decoder, only implements what's required
        /// to decode a Service Credential.
        /// </summary>
        internal class Asn1
        {
            internal enum Tag
            {
                Integer = 2,
                OctetString = 4,
                Null = 5,
                ObjectIdentifier = 6,
                Sequence = 16,
            }

            internal class Decoder
            {
                public Decoder(byte[] bytes)
                {
                    _bytes = bytes;
                    _index = 0;
                }

                private byte[] _bytes;
                private int _index;

                public object Decode()
                {
                    Tag tag = ReadTag();
                    switch (tag)
                    {
                        case Tag.Integer:
                            return ReadInteger();
                        case Tag.OctetString:
                            return ReadOctetString();
                        case Tag.Null:
                            return ReadNull();
                        case Tag.ObjectIdentifier:
                            return ReadOid();
                        case Tag.Sequence:
                            return ReadSequence();
                        default:
                            throw new NotSupportedException($"Tag '{tag}' not supported.");
                    }
                }

                private byte NextByte() => _bytes[_index++];

                private byte[] ReadLengthPrefixedBytes()
                {
                    int length = ReadLength();
                    return ReadBytes(length);
                }

                private byte[] ReadInteger() => ReadLengthPrefixedBytes();

                private object ReadOctetString()
                {
                    byte[] bytes = ReadLengthPrefixedBytes();
                    return new Decoder(bytes).Decode();
                }

                private object ReadNull()
                {
                    int length = ReadLength();
                    if (length != 0)
                    {
                        throw new InvalidDataException("Invalid data, Null length must be 0.");
                    }
                    return null;
                }

                private int[] ReadOid()
                {
                    byte[] oidBytes = ReadLengthPrefixedBytes();
                    List<int> result = new List<int>();
                    bool first = true;
                    int index = 0;
                    while (index < oidBytes.Length)
                    {
                        int subId = 0;
                        byte b;
                        do
                        {
                            b = oidBytes[index++];
                            if ((subId & 0xff000000) != 0)
                            {
                                throw new NotSupportedException("Oid subId > 2^31 not supported.");
                            }
                            subId = (subId << 7) | (b & 0x7f);
                        } while ((b & 0x80) != 0);
                        if (first)
                        {
                            first = false;
                            result.Add(subId / 40);
                            result.Add(subId % 40);
                        }
                        else
                        {
                            result.Add(subId);
                        }
                    }
                    return result.ToArray();
                }

                private object[] ReadSequence()
                {
                    int length = ReadLength();
                    int endOffset = _index + length;
                    if (endOffset < 0 || endOffset > _bytes.Length)
                    {
                        throw new InvalidDataException("Invalid sequence, too long.");
                    }
                    List<object> sequence = new List<object>();
                    while (_index < endOffset)
                    {
                        sequence.Add(Decode());
                    }
                    return sequence.ToArray();
                }

                private byte[] ReadBytes(int length)
                {
                    if (length <= 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(length), "length must be positive.");
                    }
                    if (_bytes.Length - length < 0)
                    {
                        throw new ArgumentException("Cannot read past end of buffer.");
                    }
                    byte[] result = new byte[length];
                    Array.Copy(_bytes, _index, result, 0, length);
                    _index += length;
                    return result;
                }

                private Tag ReadTag()
                {
                    byte b = NextByte();
                    int tag = b & 0x1f;
                    if (tag == 0x1f)
                    {
                        // A tag value of 0x1f (31) indicates a tag value of >30 (spec section 8.1.2.4)
                        throw new NotSupportedException("Tags of value > 30 not supported.");
                    }
                    else
                    {
                        return (Tag)tag;
                    }
                }

                private int ReadLength()
                {
                    byte b0 = NextByte();
                    if ((b0 & 0x80) == 0)
                    {
                        return b0;
                    }
                    else
                    {
                        if (b0 == 0xff)
                        {
                            throw new InvalidDataException("Invalid length byte: 0xff");
                        }
                        int byteCount = b0 & 0x7f;
                        if (byteCount == 0)
                        {
                            throw new NotSupportedException("Lengths in Indefinite Form not supported.");
                        }
                        int result = 0;
                        for (int i = 0; i < byteCount; i++)
                        {
                            if ((result & 0xff800000) != 0)
                            {
                                throw new NotSupportedException("Lengths > 2^31 not supported.");
                            }
                            result = (result << 8) | NextByte();
                        }
                        return result;
                    }
                }

            }

            public static object Decode(byte[] bs) => new Decoder(bs).Decode();

        }

        public static RSAParameters DecodeRsaParameters(string pkcs8PrivateKey)
        {
            const string PrivateKeyPrefix = "-----BEGIN PRIVATE KEY-----";
            const string PrivateKeySuffix = "-----END PRIVATE KEY-----";

            Utilities.ThrowIfNullOrEmpty(pkcs8PrivateKey, nameof(pkcs8PrivateKey));
            pkcs8PrivateKey = pkcs8PrivateKey.Trim();
            if (!pkcs8PrivateKey.StartsWith(PrivateKeyPrefix) || !pkcs8PrivateKey.EndsWith(PrivateKeySuffix))
            {
                throw new ArgumentException(
                    $"PKCS8 data must be contained within '{PrivateKeyPrefix}' and '{PrivateKeySuffix}'.", nameof(pkcs8PrivateKey));
            }
            string base64PrivateKey =
                pkcs8PrivateKey.Substring(PrivateKeyPrefix.Length, pkcs8PrivateKey.Length - PrivateKeyPrefix.Length - PrivateKeySuffix.Length);
            // FromBase64String() ignores whitespace, so further Trim()ing isn't required.
            byte[] pkcs8Bytes = Convert.FromBase64String(base64PrivateKey);

            object ans1 = Asn1.Decode(pkcs8Bytes);
            object[] parameters = (object[])((object[])ans1)[2];

            var rsaParmeters = new RSAParameters
            {
                Modulus = TrimLeadingZeroes((byte[])parameters[1]),
                Exponent = TrimLeadingZeroes((byte[])parameters[2], alignTo8Bytes: false),
                D = TrimLeadingZeroes((byte[])parameters[3]),
                P = TrimLeadingZeroes((byte[])parameters[4]),
                Q = TrimLeadingZeroes((byte[])parameters[5]),
                DP = TrimLeadingZeroes((byte[])parameters[6]),
                DQ = TrimLeadingZeroes((byte[])parameters[7]),
                InverseQ = TrimLeadingZeroes((byte[])parameters[8]),
            };

            return rsaParmeters;
        }

        internal static byte[] TrimLeadingZeroes(byte[] bs, bool alignTo8Bytes = true)
        {
            int zeroCount = 0;
            while (zeroCount < bs.Length && bs[zeroCount] == 0) zeroCount += 1;

            int newLength = bs.Length - zeroCount;
            if (alignTo8Bytes)
            {
                int remainder = newLength & 0x07;
                if (remainder != 0)
                {
                    newLength += 8 - remainder;
                }
            }

            if (newLength == bs.Length)
            {
                return bs;
            }

            byte[] result = new byte[newLength];
            if (newLength < bs.Length)
            {
                Buffer.BlockCopy(bs, bs.Length - newLength, result, 0, newLength);
            }
            else
            {
                Buffer.BlockCopy(bs, 0, result, newLength - bs.Length, bs.Length);
            }
            return result;
        }

    }
}
