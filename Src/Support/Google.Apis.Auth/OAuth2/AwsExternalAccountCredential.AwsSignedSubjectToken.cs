/*
Copyright 2022 Google LLC

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

using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Google.Apis.Auth.OAuth2
{
    public partial class AwsExternalAccountCredential
    {
        /// <summary>
        /// Partial implementation of AWS signed request, enough to support signing
        /// of a, usually, AWS GetCallerIdentity request. The signed request is sent
        /// to Google's subject token service as the subject token to be exchanged for
        /// access tokens. Google STS triggers the request as specified by the signed
        /// request to verify the callers identity.
        /// </summary>
        internal sealed class AwsSignedSubjectToken
        {
            private const string StVerificationHttpMethod = "POST";
            private const string BasicFormatIso8601 = "yyyyMMdd'T'HHmmss'Z'";
            private const string ShortDateFormat = "yyyyMMdd";
            private const string AwsRequestType = "aws4_request";
            private const string AwsSha256Designation = "AWS4-HMAC-SHA256";

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("method")]
            public string HttpMethod { get; set; }

            [JsonProperty("body")]
            public string Body { get; set; }

            [JsonProperty("headers")]
            public AwsSignedSubjectTokenHeader[] Headers { get; set; }

            public AwsSignedSubjectToken() { }

            private AwsSignedSubjectToken(string url, string httpMethod, string body, AwsSignedSubjectTokenHeader[] headers)
            {
                Url = url;
                HttpMethod = httpMethod;
                Body = body;
                Headers = headers;
            }

            public sealed class AwsSignedSubjectTokenHeader
            {
                [JsonProperty("key")]
                public string Key { get; set; }

                [JsonProperty("value")]
                public string Value { get; set; }

                public AwsSignedSubjectTokenHeader() { }

                internal AwsSignedSubjectTokenHeader(string key, string value)
                {
                    Key = key;
                    Value = value;
                }
            }
            internal static AwsSignedSubjectToken Create(AwsSecurityCredentials credentials, AwsRegion region, Uri verificationRequestUrl, string audience, IClock clock)
            {
                credentials.ThrowIfNull(nameof(credentials));
                region.ThrowIfNull(nameof(region));
                verificationRequestUrl.ThrowIfNull(nameof(verificationRequestUrl));
                audience.ThrowIfNull(nameof(audience));
                clock.ThrowIfNull(nameof(clock));

                const string newLine = "\n";

                // https://docs.aws.amazon.com/general/latest/gr/sigv4_signing.html

                DateTime utcNow = clock.UtcNow;
                string host = verificationRequestUrl.Host;
                // The service name is the first part of the host, for instance
                // iam in iam.amazonaws.com or sts in sts.amazonaws.com
                string serviceName = host.Split('.')[0];
                IDictionary<string, string> canonicalHeaders = CreateCanonicalHeaders();
                var sortedHeaders = canonicalHeaders.OrderBy(pair => pair.Key, StringComparer.Ordinal);
                var signedHeaders = string.Join(";", sortedHeaders.Select(pair => pair.Key));
                // See point 3 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-string-to-sign.html
                string credentialScope = $"{utcNow.ToString(ShortDateFormat, CultureInfo.InvariantCulture)}/{region.Region}/{serviceName}/{AwsRequestType}";

                string hashedCanonicalRequest = GetHashedCanonicalRequest();
                string stringToSign = GetStringToSign();
                string signature = GetSignature();
                string authorizationHeader = GetAuthorizationHeader();

                return new AwsSignedSubjectToken(verificationRequestUrl.ToString(), StVerificationHttpMethod, "",
                    canonicalHeaders
                        .Select(pair => new AwsSignedSubjectTokenHeader(pair.Key, pair.Value))
                        .Concat(Enumerable.Repeat(new AwsSignedSubjectTokenHeader("Authorization", authorizationHeader), 1))
                        .ToArray());

                string GetHashedCanonicalRequest()
                {
                    const string EmptyStringHexEncodedSha256Hash = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";

                    // Step 1
                    // https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html

                    // First, the HTTP Method.
                    // See point 1 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
                    StringBuilder canonicalRequest = new StringBuilder(StVerificationHttpMethod).Append(newLine);

                    // Now the URI's absolute path.
                    // See point 2 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
                    canonicalRequest.Append(verificationRequestUrl.GetPathForAwsCanonicalRequest()).Append(newLine);

                    // Now the query string.
                    // See point 3 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
                    canonicalRequest.Append(verificationRequestUrl.GetQueryStringForAwsCanonicalRequest()).Append(newLine);

                    // Now the canonical headers.
                    // We just built them ourselves, so we know header names are lower case and that values
                    // that could have leading or trailing spaces have been trimmed.
                    // Also, the values we add won't have sequential spaces.
                    // See point 4 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
                    foreach (var headerPair in sortedHeaders)
                    {
                        canonicalRequest.Append(headerPair.Key);
                        canonicalRequest.Append(":");
                        canonicalRequest.Append(headerPair.Value);
                        canonicalRequest.Append(newLine);
                    }
                    canonicalRequest.Append(newLine);

                    // Now the list of headers that will be signed.
                    // See point 5 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
                    canonicalRequest.Append(signedHeaders).Append(newLine);

                    // Now the hashed request payload which is empty in our case.
                    // See point 6 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
                    canonicalRequest.Append(EmptyStringHexEncodedSha256Hash);

                    // Point 7 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
                    // is just to combine all of the previous elements into a single string, and we've been doing
                    // that already in canonicalRequest.

                    // Now hash and return the canonical request.
                    // See point 8 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
                    return GetHexEncodedSha256Hash(canonicalRequest.ToString());
                }

                string GetStringToSign()
                {
                    // Step 2
                    // https://docs.aws.amazon.com/general/latest/gr/sigv4-create-string-to-sign.html

                    // First the algorithm designation.
                    // See point 1 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-string-to-sign.html
                    StringBuilder stringToSign = new StringBuilder(AwsSha256Designation).Append(newLine);

                    // Now the request date.
                    // See point 2 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-string-to-sign.html
                    stringToSign.Append(utcNow.ToString(BasicFormatIso8601, CultureInfo.InvariantCulture)).Append(newLine);

                    // Now the credential scope value.
                    // See point 3 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-string-to-sign.html
                    stringToSign.Append(credentialScope).Append(newLine);

                    // Now the hashed canonical request
                    // See point 3 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-string-to-sign.html
                    stringToSign.Append(hashedCanonicalRequest);

                    return stringToSign.ToString();
                }

                string GetSignature()
                {
                    // Step 3
                    // https://docs.aws.amazon.com/general/latest/gr/sigv4-calculate-signature.html

                    const string initialKeyPrefix = "AWS4";

                    // First derive the key.
                    // See point 1 in https://docs.aws.amazon.com/general/latest/gr/sigv4-calculate-signature.html
                    var keySecret = Encoding.UTF8.GetBytes($"{initialKeyPrefix}{credentials.SecretAccessKey}");
                    var keyDate = GetHmacSha256Hash(keySecret, utcNow.ToString(ShortDateFormat, CultureInfo.InvariantCulture));
                    var keyRegion = GetHmacSha256Hash(keyDate, region.Region);
                    var keyService = GetHmacSha256Hash(keyRegion, serviceName);
                    var keySigning = GetHmacSha256Hash(keyService, AwsRequestType);

                    // Now sign the string to sign
                    // See point 2 in https://docs.aws.amazon.com/general/latest/gr/sigv4-calculate-signature.html
                    var signature = GetHmacSha256Hash(keySigning, stringToSign);
                    return FormatHex(signature);
                }

                string GetAuthorizationHeader()
                {
                    // Step 4
                    // https://docs.aws.amazon.com/general/latest/gr/sigv4-add-signature-to-request.html

                    // First the algorithm designation
                    var authorizationHeader = new StringBuilder(AwsSha256Designation).Append(" ");
                    // Now the credential, which includes the access key ID and the scope
                    authorizationHeader.Append("Credential=");
                    authorizationHeader.Append(credentials.AccessKeyId).Append("/");
                    authorizationHeader.Append(credentialScope).Append(", ");
                    // Now the signed headers
                    authorizationHeader.Append("SignedHeaders=");
                    authorizationHeader.Append(signedHeaders).Append(", ");
                    // Now the actual signature
                    authorizationHeader.Append("Signature=");
                    authorizationHeader.Append(signature);

                    return authorizationHeader.ToString();
                }

                IDictionary<string, string> CreateCanonicalHeaders()
                {
                    const string HostHeaderName = "host";
                    const string DateHeaderName = "x-amz-date";
                    const string SecurityTokenHeaderName = "x-amz-security-token";
                    const string AudienceHeaderName = "x-goog-cloud-target-resource";

                    var headers = new Dictionary<string, string>
                    {
                        { HostHeaderName , host },
                        { DateHeaderName, utcNow.ToString(BasicFormatIso8601, CultureInfo.InvariantCulture) },
                        { AudienceHeaderName , audience.Trim() }
                    };

                    if (credentials.Token is string)
                    {
                        headers[SecurityTokenHeaderName] = credentials.Token;
                    }

                    return headers;
                }
            }

            private static byte[] GetHmacSha256Hash(byte[] key, string value)
            {
                using var hmac = new HMACSHA256(key);
                return hmac.ComputeHash(Encoding.UTF8.GetBytes(value));
            }

            private static string GetHexEncodedSha256Hash(string value)
            {
                using var sha256 = SHA256.Create();
                return FormatHex(sha256.ComputeHash(Encoding.UTF8.GetBytes(value)));
            }

            private static string FormatHex(byte[] value)
            {
                const string HexCharacters = "0123456789abcdef";

                // Could just use BitConverter, but it's inefficient to create multiple strings and
                // easy to do it ourselves instead.
                char[] chars = new char[value.Length * 2];
                for (int i = 0; i < value.Length; i++)
                {
                    chars[i * 2] = HexCharacters[value[i] >> 4];
                    chars[i * 2 + 1] = HexCharacters[value[i] & 0xf];
                }
                return new string(chars);
            }
        }
    }
}
