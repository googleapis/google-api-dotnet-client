// Copyright 2019 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Text;

// Copied from Google.Api.Generator.Utils
namespace Google.Api.Generator.Utils
{
    public static class SystemExtensions
    {
        private static char MaybeForceCase(char c, bool? toUpper) =>
            toUpper is bool upper ? upper ? char.ToUpperInvariant(c) : char.ToLowerInvariant(c) : c;

        private static string Camelizer(string s, bool firstUpper, bool forceAllChars, bool? upperAfterDigit) =>
            s.Aggregate((upper: (bool?) firstUpper, prev: '\0', sb: new StringBuilder()), (acc, c) =>
                !char.IsLetterOrDigit(c) ?
                    (acc.sb.Length > 0 ? true : firstUpper, c, acc.sb) :
                    (char.IsDigit(c) ? upperAfterDigit : forceAllChars ? (bool?) false : null, c,
                        acc.sb.Append(MaybeForceCase(c, char.IsLower(acc.prev) && char.IsUpper(c) ? true : acc.upper))),
                acc => acc.sb.ToString());

        public static string ToLowerCamelCase(this string s, bool forceAllChars = false, bool? upperAfterDigit = true) => Camelizer(s, firstUpper: false, forceAllChars, upperAfterDigit);
        public static string ToUpperCamelCase(this string s, bool forceAllChars = false, bool? upperAfterDigit = true) => Camelizer(s, firstUpper: true, forceAllChars, upperAfterDigit);

        public static string RemoveSuffix(this string s, string suffix) => s.EndsWith(suffix) ? s.Substring(0, s.Length - suffix.Length) : s;
    }
}
