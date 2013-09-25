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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Apis.Auth
{
    /// <summary>
    /// JSON Web Signature (JWS) implementation as specified in 
    /// http://tools.ietf.org/html/draft-ietf-jose-json-web-signature-11.
    /// </summary>
    public class JsonWebSignature
    {
        // TODO(peleyal): Implement some verify method:
        // http://tools.ietf.org/html/draft-ietf-oauth-json-web-token-08#section-7

        /// <summary>
        /// Header as specified in http://tools.ietf.org/html/draft-ietf-jose-json-web-signature-11#section-4.1.
        /// </summary>
        public class Header : JsonWebToken.Header
        {
            /// <summary>
            /// Gets or set the algorithm header parameter that identifies the cryptographic algorithm used to secure 
            /// the JWS or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("alg")]
            public string Algorithm { get; set; }

            /// <summary>
            /// Gets or sets the JSON Web Key URL header parameter that is an absolute URL that refers to a resource 
            /// for a set of JSON-encoded public keys, one of which corresponds to the key that was used to digitally 
            /// sign the JWS or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("jku")]
            public string JwkUrl { get; set; }

            /// <summary>
            /// Gets or sets JSON Web Key header parameter that is a public key that corresponds to the key used to 
            /// digitally sign the JWS or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("jwk")]
            public string Jwk { get; set; }

            /// <summary>
            /// Gets or sets key ID header parameter that is a hint indicating which specific key owned by the signer 
            /// should be used to validate the digital signature or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("kid")]
            public string KeyId { get; set; }

            /// <summary>
            /// Gets or sets X.509 URL header parameter that is an absolute URL that refers to a resource for the X.509
            /// public key certificate or certificate chain corresponding to the key used to digitally sign the JWS or 
            /// <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("x5u")]
            public string X509Url { get; set; }

            /// <summary>
            /// Gets or sets X.509 certificate thumb print header parameter that provides a base64url encoded SHA-1 
            /// thumb-print (a.k.a. digest) of the DER encoding of an X.509 certificate that can be used to match the 
            /// certificate or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("x5t")]
            public string X509Thumbprint { get; set; }

            /// <summary>
            /// Gets or sets X.509 certificate chain header parameter contains the X.509 public key certificate or 
            /// certificate chain corresponding to the key used to digitally sign the JWS or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("x5c")]
            public string X509Certificate { get; set; }

            /// <summary>
            /// Gets or sets array listing the header parameter names that define extensions that are used in the JWS 
            /// header that MUST be understood and processed or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("crit")]
            public IList<string> critical { get; set; }
        }

        /// <summary>JWS Payload.</summary>
        public class Payload : JsonWebToken.Payload
        {
        }
    }
}
