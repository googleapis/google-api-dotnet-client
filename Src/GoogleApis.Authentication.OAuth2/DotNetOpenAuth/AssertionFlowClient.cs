/*
Copyright 2012 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using DotNetOpenAuth;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth2;
using DotNetOpenAuth.OAuth2.Messages;
using DotNetOpenAuth.OAuth2.ChannelElements;

using Google.Apis.Json;
using Google.Apis.Util;

namespace Google.Apis.Authentication.OAuth2.DotNetOpenAuth
{

    #region JSON helpers
    /// <summary>
    /// Assertion flow header used to generate the assertion flow message header.
    /// </summary>
    public class AssertionFlowHeader {

        /// <summary>
        /// Gets or sets the encryption algorithm used by the assertion flow message.
        /// </summary>
        /// <value>
        /// The alg.
        /// </value>
        [Newtonsoft.Json.JsonPropertyAttribute("alg")]
        public String Algorithm { get; set; }

        /// <summary>
        /// Gets or sets the type of the claim.
        /// </summary>
        /// <value>
        /// The typ.
        /// </value>
        [Newtonsoft.Json.JsonPropertyAttribute("typ")]
        public String Type { get; set; }

    }

    /// <summary>
    /// Google assertion flow header holding Google supported values.
    /// </summary>
    public class GoogleAssertionFlowHeader : AssertionFlowHeader {

        /// <summary>
        /// The google signing algorithm, currently RSA-SHA256
        /// <see cref="https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingheader"/>.
        /// </summary>
        public const string GoogleSigningAlgorithm = "RS256";
        /// <summary>
        /// The type of the google assertion, currently JSON Web Token
        /// <see cref="https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingheader"/>
        /// </summary>
        public const string GoogleAssertionType = "JWT";

        public GoogleAssertionFlowHeader() {
            Algorithm = GoogleSigningAlgorithm;
            Type = GoogleAssertionType;
        }

    }

    /// <summary>
    /// Assertion flow claim used to generate the assertion flow message claim.
    /// </summary>
    public class AssertionFlowClaim {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Google.Apis.Authentication.OAuth2.DotNetOpenAuth.AssertionFlowClaim"/> class.
        /// </summary>
        public AssertionFlowClaim() {
            IssuedAt = (long) (DateTime.UtcNow - new DateTime(1970, 01, 01, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            ExpiresAt = IssuedAt + 3600;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Google.Apis.Authentication.OAuth2.DotNetOpenAuth.AssertionFlowClaim"/> class.
        /// </summary>
        /// <param name='authorizationServer'>
        /// Authorization server description.
        /// </param>
        public AssertionFlowClaim(AuthorizationServerDescription authorizationServer) : this() {
            Audience = authorizationServer.TokenEndpoint.ToString();
        }

        /// <summary>
        /// Gets or sets the assertion flow issuer (e.g client ID).
        /// </summary>
        /// <value>
        /// The issuer.
        /// </value>
        [Newtonsoft.Json.JsonPropertyAttribute("iss")]
        public String Issuer { get; set; }

        /// <summary>
        /// Gets or sets the service account user (for domain-wide delegation).
        /// </summary>
        /// <value>
        /// The service account user.
        /// </value>
        [Newtonsoft.Json.JsonPropertyAttribute("prn")]
        public String Principal { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        /// <value>
        /// The scope.
        /// </value>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public String Scope { get; set; }

        /// <summary>
        /// Gets or sets the token endpoint.
        /// </summary>
        /// <value>
        /// The audience.
        /// </value>
        [Newtonsoft.Json.JsonPropertyAttribute("aud")]
        public String Audience { get; set; }

        /// <summary>
        /// Gets or sets the expected expiration of the token to retrieve.
        /// </summary>
        /// <value>
        /// The expiration UTC timestamp.
        /// </value>
        [Newtonsoft.Json.JsonPropertyAttribute("exp")]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets the UTC timestamp at which this claim has been built.
        /// </summary>
        /// <value>
        /// The issued UTC timestamp.
        /// </value>
        [Newtonsoft.Json.JsonPropertyAttribute("iat")]
        public long IssuedAt { get; set; }
    }
    #endregion

    #region Request message
    /// <summary>
    /// Assertion flow message to be sent to the token endpoint.
    /// </summary>
    public class AssertionFlowMessage : MessageBase {

        /// <summary>
        /// Google supported assertion type 
        /// <see cref="https://developers.google.com/accounts/docs/OAuth2ServiceAccount#makingrequest"/>.
        /// </summary>
        public const string GoogleAssertionType = "http://oauth.net/grant_type/jwt/1.0/bearer";

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Google.Apis.Authentication.OAuth2.DotNetOpenAuth.AssertionFlowMessage"/> class.
        /// </summary>
        /// <param name='authorizationServer'>
        /// Authorization server description.
        /// </param>
        public AssertionFlowMessage(AuthorizationServerDescription authorizationServer) :
                base(new Version(2, 0), MessageTransport.Direct, authorizationServer.TokenEndpoint) {
            GrantType = "assertion";
            AssertionType = GoogleAssertionType;
            this.HttpMethods = HttpDeliveryMethods.PostRequest;
        }

        /// <summary>
        /// Gets or sets the type of the grant (defaults to "assertion").
        /// </summary>
        /// <value>
        /// The type of the grant.
        /// </value>
        [MessagePart("grant_type", IsRequired = true)]
        public String GrantType { get; set ;}

        /// <summary>
        /// Gets or sets the type of the assertion (defaults to "http://oauth.net/grant_type/jwt/1.0/bearer").
        /// </summary>
        /// <value>
        /// The type of the assertion.
        /// </value>
        [MessagePart("assertion_type", IsRequired = true)]
        public String AssertionType { get; set ;}

        /// <summary>
        /// Gets or sets the assertion message.
        /// </summary>
        /// <value>
        /// The assertion.
        /// </value>
        [MessagePart("assertion", IsRequired = true)]
        public String Assertion { get; set ;}

    }
    #endregion

    #region Assertion Flow Implementation
    /// <summary>
    /// The OAuth2 client for use by applications using Service Accounts or other implementation of the OAuth 2.0
    /// Assertion Flow.
    /// </summary>
    public class AssertionFlowClient : ClientBase
    {

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Google.Apis.Authentication.OAuth2.DotNetOpenAuth.AssertionFlowClient"/> class.
        /// </summary>
        /// <param name='authorizationServer'>
        /// Authorization server description.
        /// </param>
        /// <param name='certificate'>
        /// Certificate to use to sign the assertion flow messages.
        /// </param>
        public AssertionFlowClient(AuthorizationServerDescription authorizationServer,
                                   X509Certificate2 certificate) : base(authorizationServer, null, null) {
            certificate.ThrowIfNull("certificate");
            certificate.PrivateKey.ThrowIfNull("certificate.PrivateKey");

            Header = new GoogleAssertionFlowHeader();
            Certificate = certificate;

            // Workaround to correctly cast the private key as a RSACryptoServiceProvider type 24
            RSACryptoServiceProvider rsa = (RSACryptoServiceProvider) certificate.PrivateKey;
            byte[] privateKeyBlob = rsa.ExportCspBlob(true);

            Key = new RSACryptoServiceProvider();
            Key.ImportCspBlob(privateKeyBlob);
        }

        /// <summary>
        /// Gets or sets the service account identifier.
        /// </summary>
        /// <value>
        /// The service account identifier.
        /// </value>
        public String ServiceAccountId { get; set; }

        /// <summary>
        /// Gets or sets the service account user (used for domain-wide delegation).
        /// </summary>
        /// <value>
        /// The service account user.
        /// </value>
        public String ServiceAccountUser { get; set; }

        /// <summary>
        /// Gets or sets the scope to get access for.
        /// </summary>
        /// <value>
        /// The scope.
        /// </value>
        public String Scope { get; set; }

        /// <summary>
        /// Gets the certificate used to sign the assertion.
        /// </summary>
        /// <value>
        /// The certificate.
        /// </value>
        public X509Certificate2 Certificate { get; private set; }

        /// <summary>
        /// Gets or sets the JWT claim's header (defaults to Google's supported values).
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        public AssertionFlowHeader Header { get; set; }

        public RSACryptoServiceProvider Key { get; private set; }

        /// <summary>
        /// Helper method to retrieve the Authorization State from the 
        /// <see cref="Google.Apis.Authentication.OAuth2.OAuth2Authenticator"/> class.
        /// </summary>
        /// <returns>
        /// The authorization state.
        /// </returns>
        /// <param name='provider'>
        /// The provider to use to retrieve the authorization state.
        /// </param>
        public static IAuthorizationState GetState(AssertionFlowClient provider)
        {
            provider.Scope.ThrowIfNull("Scope");
            IAuthorizationState state = new AuthorizationState(provider.Scope.Split(' '));

            if (provider.RefreshToken(state, null)) {
                return state;
            } else {
                return null;
            }
        }

        /// <summary>
        /// Request a new access token using the OAuth 2.0 assertion flow.
        /// </summary>
        /// <returns>
        /// Whether or not a new access token has been successfully retrieved.
        /// </returns>
        /// <param name='authorization'>
        /// Object containing the current authorization state.
        /// </param>
        /// <param name='skipIfUsefulLifeExceeds'>
        /// If set to <c>true</c> skip if useful life exceeds.
        /// </param>
        public new bool RefreshToken(IAuthorizationState authorization, TimeSpan? skipIfUsefulLifeExceeds = null)
        {
            return RefreshToken(authorization, skipIfUsefulLifeExceeds, this.Channel.Request);
        }

        public bool RefreshToken(IAuthorizationState authorization, TimeSpan? skipIfUsefulLifeExceeds,
                                 Func<IDirectedProtocolMessage, IProtocolMessage> requestProvider) {
            authorization.ThrowIfNull("authorization");
            Certificate.ThrowIfNull("certificate");
            bool result = false;

            // Check if the token is still valid.
            if (skipIfUsefulLifeExceeds.HasValue && authorization.AccessTokenExpirationUtc.HasValue)
            {
                TimeSpan timeSpan = authorization.AccessTokenExpirationUtc.Value - DateTime.UtcNow;
                if (timeSpan > skipIfUsefulLifeExceeds.Value)
                {
                    return result;
                }
            }

            var requestMessage = GenerateMessage();
            var response = requestProvider(requestMessage);

            // Response is not strongly-typed to an AccessTokenSuccessResponse because DotNetOpenAuth can't infer the
            // type from the request message type. The only way to get access to the result data is through the
            // resulting Dictionary.
            if (response.ExtraData.ContainsKey("access_token") && response.ExtraData.ContainsKey("expires_in")) {
                result = true;
                authorization.AccessToken = response.ExtraData["access_token"];
                long expiresIn = long.Parse(response.ExtraData["expires_in"]);
                DateTime utcNow = DateTime.UtcNow;
                authorization.AccessTokenExpirationUtc = new DateTime? (utcNow.AddSeconds(expiresIn));
                authorization.AccessTokenIssueDateUtc = new DateTime? (utcNow);
                authorization.SaveChanges();
            } else {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Generates the assertion flow message to be sent to the token endpoint.
        /// </summary>
        /// <returns>
        /// The assertion flow message.
        /// </returns>
        private AssertionFlowMessage GenerateMessage() {
            String header = NewtonsoftJsonSerializer.Instance.Serialize(Header);
            String claim = NewtonsoftJsonSerializer.Instance.Serialize(new AssertionFlowClaim(AuthorizationServer) {
                Issuer = this.ServiceAccountId,
                Principal = this.ServiceAccountUser,
                Scope = this.Scope
            });

            StringBuilder assertion = new StringBuilder();
            assertion.Append(UnpaddedUrlSafeBase64Encode(header));
            assertion.Append(".");
            assertion.Append(UnpaddedUrlSafeBase64Encode(claim));

            // TODO: Check if this is working on FIPS enabled systems.
            String signature = UnpaddedUrlSafeBase64Encode(
                Key.SignData(Encoding.ASCII.GetBytes(assertion.ToString()), "SHA256"));
            assertion.Append(".");
            assertion.Append(signature);

            return new AssertionFlowMessage (this.AuthorizationServer)
            {
                Assertion = assertion.ToString()
            };
        }

        /// <summary>
        /// Encode the provided UTF8 string into an URL safe base64 string.
        /// </summary>
        /// <returns>
        /// The URL safe base64 string.
        /// </returns>
        /// <param name='value'>
        /// String to encode.
        /// </param>
        private String UnpaddedUrlSafeBase64Encode(String value) {
            return UnpaddedUrlSafeBase64Encode(Encoding.UTF8.GetBytes(value));
        }

        /// <summary>
        /// Encode the byte array into an URL safe base64 string.
        /// </summary>
        /// <returns>
        /// The URL safe base64 string.
        /// </returns>
        /// <param name='bytes'>
        /// Bytes to encode.
        /// </param>
        private String UnpaddedUrlSafeBase64Encode(Byte[] bytes) {
            return Convert.ToBase64String(bytes).Replace("=", String.Empty).Replace('+', '-').Replace('/', '_');
        }

    }

    #endregion
}
