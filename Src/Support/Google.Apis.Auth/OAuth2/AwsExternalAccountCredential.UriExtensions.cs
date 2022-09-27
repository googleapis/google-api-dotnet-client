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
using System;
using System.Linq;
using System.Text;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Helper class to use with some of the formatting required for AWS
    /// canonical requests:
    /// https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html
    /// </summary>
    internal static class AwsCanonicalRequestUriExtensions
    {
        private const string DoubleEscapedEqual = "%253D";
        private static readonly char[] Ampersand = new char[] { '&' };
        private static readonly char[] Equal = new char[] { '=' };

        internal static string GetPathForAwsCanonicalRequest(this Uri uri)
        {
            // See point 2 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html

            uri.ThrowIfNull(nameof(uri));

            StringBuilder encodedPath = new StringBuilder("/");
            var segments = uri.GetComponents(UriComponents.Path, UriFormat.Unescaped).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var segment in segments)
            {
                // Doubly encoded as we are not signing for AWS S3.
                encodedPath.Append(Uri.EscapeDataString(Uri.EscapeDataString(segment)));
                encodedPath.Append("/");
            }

            return encodedPath.ToString();
        }

        internal static string GetQueryStringForAwsCanonicalRequest(this Uri uri)
        {
            // See point 3 in https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html

            uri.ThrowIfNull(nameof(uri));

            string originalQuery = uri.GetComponents(UriComponents.Query, UriFormat.Unescaped);
            StringBuilder encodedQuery = new StringBuilder();

            foreach(var pair in originalQuery
                .Split(Ampersand, StringSplitOptions.RemoveEmptyEntries)
                // We sort the pairs which mean that for duplicate parameter names we sort by value as required.
                .OrderBy(p => p, StringComparer.Ordinal))
            {
                // We need to double encode all `=` in the value part of the pair,
                // so we need to keep the empty strings to account for pontetial
                // sequential `=` in the value.
                var pairParts = pair.Split(Equal, StringSplitOptions.None);

                // The first part is the parameter name.
                encodedQuery.Append(Uri.EscapeDataString(pairParts[0]));
                // Now the equal sign.
                encodedQuery.Append("=");
                // If there is a second part, then that's the first part of the value,
                // that is, the value up to a possible `=` in the original value.
                if (pairParts.Length > 1)
                {
                    encodedQuery.Append(Uri.EscapeDataString(pairParts[1]));
                }
                // Let's do all the other parts of the value, if any, separating them
                // with double escaped `=`.
                for (int i = 2; i < pairParts.Length; i++)
                {
                    encodedQuery = encodedQuery.Append(DoubleEscapedEqual);
                    encodedQuery.Append(Uri.EscapeDataString(pairParts[i]));
                }
                // And now we add the `&`
                encodedQuery.Append("&");
            }

            // Let's remove the last `&`
            encodedQuery.Length--;

            return encodedQuery.ToString();
        }
    }
}
