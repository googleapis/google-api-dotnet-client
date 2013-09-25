using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Apis.Auth
{
    /// <summary>
    /// Google JSON Web Signature as specified in https://developers.google.com/accounts/docs/OAuth2ServiceAccount.
    /// </summary>
    public class GoogleJsonWebSignature
    {
        // TODO(peleyal): We should provide a way to verify JWS.
        // Take a look at: https://github.com/googleplus/gplus-verifytoken-csharp/blob/master/verifytoken.ashx.cs.

        /// <summary>
        /// The header as specified in https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingheader.
        /// </summary>
        public class Header : JsonWebSignature.Header
        {
        }

        /// <summary>
        /// The payload as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingclaimset.
        /// </summary>
        public class Payload : JsonWebSignature.Payload
        {
            /// <summary>
            /// a space-delimited list of the permissions the application requests or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("scope")]
            public string Scope { get; set; }

            /// <summary>
            /// The email address of the user for which the application is requesting delegated access.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("prn")]
            public string Prn { get; set; }
        }
    }
}
