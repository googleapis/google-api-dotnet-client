// Copyright 2021 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Apis.Verifiedaccess.v1
{
    /// <summary>The Verifiedaccess Service.</summary>
    public class VerifiedaccessService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public VerifiedaccessService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public VerifiedaccessService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Challenge = new ChallengeResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "verifiedaccess";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://verifiedaccess.googleapis.com/";
        #else
            "https://verifiedaccess.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://verifiedaccess.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Chrome Verified Access API.</summary>
        public class Scope
        {
            /// <summary>Verify your enterprise credentials</summary>
            public static string Verifiedaccess = "https://www.googleapis.com/auth/verifiedaccess";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Chrome Verified Access API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Verify your enterprise credentials</summary>
            public const string Verifiedaccess = "https://www.googleapis.com/auth/verifiedaccess";
        }

        /// <summary>Gets the Challenge resource.</summary>
        public virtual ChallengeResource Challenge { get; }
    }

    /// <summary>A base abstract class for Verifiedaccess requests.</summary>
    public abstract class VerifiedaccessBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new VerifiedaccessBaseServiceRequest instance.</summary>
        protected VerifiedaccessBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Verifiedaccess parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "challenge" collection of methods.</summary>
    public class ChallengeResource
    {
        private const string Resource = "challenge";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChallengeResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>CreateChallenge API</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Verifiedaccess.v1.Data.Empty body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>CreateChallenge API</summary>
        public class CreateRequest : VerifiedaccessBaseServiceRequest<Google.Apis.Verifiedaccess.v1.Data.Challenge>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Verifiedaccess.v1.Data.Empty body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Verifiedaccess.v1.Data.Empty Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/challenge";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>VerifyChallengeResponse API</summary>
        /// <param name="body">The body of the request.</param>
        public virtual VerifyRequest Verify(Google.Apis.Verifiedaccess.v1.Data.VerifyChallengeResponseRequest body)
        {
            return new VerifyRequest(service, body);
        }

        /// <summary>VerifyChallengeResponse API</summary>
        public class VerifyRequest : VerifiedaccessBaseServiceRequest<Google.Apis.Verifiedaccess.v1.Data.VerifyChallengeResponseResult>
        {
            /// <summary>Constructs a new Verify request.</summary>
            public VerifyRequest(Google.Apis.Services.IClientService service, Google.Apis.Verifiedaccess.v1.Data.VerifyChallengeResponseRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Verifiedaccess.v1.Data.VerifyChallengeResponseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "verify";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/challenge:verify";

            /// <summary>Initializes Verify parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.Verifiedaccess.v1.Data
{
    /// <summary>Result message for VerifiedAccess.CreateChallenge.</summary>
    public class Challenge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Challenge generated with the old signing key (this will only be present during key rotation)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternativeChallenge")]
        public virtual SignedData AlternativeChallenge { get; set; }

        /// <summary>Generated challenge</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challenge")]
        public virtual SignedData ChallengeValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The wrapper message of any data and its signature.</summary>
    public class SignedData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data to be signed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>The signature of the data field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>signed ChallengeResponse</summary>
    public class VerifyChallengeResponseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The generated response to the challenge</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challengeResponse")]
        public virtual SignedData ChallengeResponse { get; set; }

        /// <summary>
        /// Service can optionally provide identity information about the device or user associated with the key. For an
        /// EMK, this value is the enrolled domain. For an EUK, this value is the user's email address. If present, this
        /// value will be checked against contents of the response, and verification will fail if there is no match.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedIdentity")]
        public virtual string ExpectedIdentity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result message for VerifiedAccess.VerifyChallengeResponse.</summary>
    public class VerifyChallengeResponseResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device enrollment id is returned in this field (for the machine response only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceEnrollmentId")]
        public virtual string DeviceEnrollmentId { get; set; }

        /// <summary>Device permanent id is returned in this field (for the machine response only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePermanentId")]
        public virtual string DevicePermanentId { get; set; }

        /// <summary>
        /// Certificate Signing Request (in the SPKAC format, base64 encoded) is returned in this field. This field will
        /// be set only if device has included CSR in its challenge response. (the option to include CSR is now
        /// available for both user and machine responses)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedPublicKeyAndChallenge")]
        public virtual string SignedPublicKeyAndChallenge { get; set; }

        /// <summary>
        /// For EMCert check, device permanent id is returned here. For EUCert check, signed_public_key_and_challenge
        /// [base64 encoded] is returned if present, otherwise empty string is returned. This field is deprecated,
        /// please use device_permanent_id or signed_public_key_and_challenge fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationOutput")]
        public virtual string VerificationOutput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
