/*
Copyright 2013 Google Inc

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

using System.Security.Cryptography;
using System.Text;

namespace Google.Apis.Util.Protect
{
    /// <summary>Data protection utility to protect data.</summary>
    internal static class DataProtection
    {
        /// <summary>Protects the given content and transform it into a byte array.</summary>
        public static byte[] Protect(string content)
        {
            return ProtectedData.Protect(Encoding.UTF8.GetBytes(content), null);
        }

        /// <summary>Unprotects the given byte array and return the original content.</summary>
        public static string Unprotect(byte[] data)
        {
            byte[] unprotectedData = ProtectedData.Unprotect(data, null);
            return Encoding.UTF8.GetString(unprotectedData, 0, unprotectedData.Length);
        }
    }
}
