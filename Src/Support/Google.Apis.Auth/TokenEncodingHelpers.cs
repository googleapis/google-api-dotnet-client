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

using System;
using System.Text;

namespace Google.Apis.Auth
{
    internal static class TokenEncodingHelpers
    {
        /// <summary>
        /// Decodes the provided URL safe base 64 string.
        /// </summary>
        /// <param name="base64Url">The URL safe base 64 string to decode.</param>
        /// <returns>The UTF8 decoded string.</returns>
        internal static string Base64UrlToString(string base64Url) =>
            Encoding.UTF8.GetString(Base64UrlDecode(base64Url));

        /// <summary>
        /// Decodes the provided URL safe base 64 string.
        /// </summary>
        /// <param name="base64Url">The URL safe base 64 string to decode.</param>
        /// <returns>The UTF8 byte representation of the decoded string.</returns>
        internal static byte[] Base64UrlDecode(string base64Url)
        {
            var base64 = base64Url.Replace('-', '+').Replace('_', '/');
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }

        /// <summary>Encodes the provided UTF8 string into an URL safe base64 string.</summary>
        /// <param name="value">Value to encode.</param>
        /// <returns>The URL safe base64 string.</returns>
        internal static string UrlSafeBase64Encode(string value) =>
            UrlSafeBase64Encode(Encoding.UTF8.GetBytes(value));

        /// <summary>Encodes the byte array into an URL safe base64 string.</summary>
        /// <param name="bytes">Byte array to encode.</param>
        /// <returns>The URL safe base64 string.</returns>
        internal static string UrlSafeBase64Encode(byte[] bytes) =>
            UrlSafeEncode(Convert.ToBase64String(bytes));


        /// <summary>Encodes the base64 string into an URL safe string.</summary>
        /// <param name="base64Value">The base64 string to make URL safe.</param>
        /// <returns>The URL safe base64 string.</returns>
        internal static string UrlSafeEncode(string base64Value) =>
            base64Value.Replace("=", String.Empty).Replace('+', '-').Replace('/', '_');
    }
}
