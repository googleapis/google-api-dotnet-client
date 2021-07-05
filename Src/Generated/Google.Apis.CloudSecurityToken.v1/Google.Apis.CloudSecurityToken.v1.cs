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

namespace Google.Apis.CloudSecurityToken.v1
{
    /// <summary>The CloudSecurityToken Service.</summary>
    public class CloudSecurityTokenService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudSecurityTokenService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudSecurityTokenService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            V1 = new V1Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "sts";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://sts.googleapis.com/";
        #else
            "https://sts.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://sts.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for CloudSecurityToken requests.</summary>
    public abstract class CloudSecurityTokenBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudSecurityTokenBaseServiceRequest instance.</summary>
        protected CloudSecurityTokenBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
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
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
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

        /// <summary>Initializes CloudSecurityToken parameter list.</summary>
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

    /// <summary>The "v1" collection of methods.</summary>
    public class V1Resource
    {
        private const string Resource = "v1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets information about a Google OAuth 2.0 access token issued by the Google Cloud [Security Token Service
        /// API](https://cloud.google.com/iam/docs/reference/sts/rest).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual IntrospectRequest Introspect(Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1IntrospectTokenRequest body)
        {
            return new IntrospectRequest(service, body);
        }

        /// <summary>
        /// Gets information about a Google OAuth 2.0 access token issued by the Google Cloud [Security Token Service
        /// API](https://cloud.google.com/iam/docs/reference/sts/rest).
        /// </summary>
        public class IntrospectRequest : CloudSecurityTokenBaseServiceRequest<Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1IntrospectTokenResponse>
        {
            /// <summary>Constructs a new Introspect request.</summary>
            public IntrospectRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1IntrospectTokenRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1IntrospectTokenRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "introspect";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/introspect";

            /// <summary>Initializes Introspect parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Exchanges a credential for a Google OAuth 2.0 access token. The token asserts an external identity within a
        /// workload identity pool, or it applies a Credential Access Boundary to a Google access token. When you call
        /// this method, do not send the `Authorization` HTTP header in the request. This method does not require the
        /// `Authorization` header, and using the header can cause the request to fail.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual TokenRequest Token(Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeTokenRequest body)
        {
            return new TokenRequest(service, body);
        }

        /// <summary>
        /// Exchanges a credential for a Google OAuth 2.0 access token. The token asserts an external identity within a
        /// workload identity pool, or it applies a Credential Access Boundary to a Google access token. When you call
        /// this method, do not send the `Authorization` HTTP header in the request. This method does not require the
        /// `Authorization` header, and using the header can cause the request to fail.
        /// </summary>
        public class TokenRequest : CloudSecurityTokenBaseServiceRequest<Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeTokenResponse>
        {
            /// <summary>Constructs a new Token request.</summary>
            public TokenRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeTokenRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeTokenRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "token";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/token";

            /// <summary>Initializes Token parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.CloudSecurityToken.v1.Data
{
    /// <summary>Request message for ExchangeToken.</summary>
    public class GoogleIdentityStsV1ExchangeTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full resource name of the identity provider; for example:
        /// `//iam.googleapis.com/projects//workloadIdentityPools//providers/`. Required when exchanging an external
        /// credential for a Google access token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>
        /// Required. The grant type. Must be `urn:ietf:params:oauth:grant-type:token-exchange`, which indicates a token
        /// exchange.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantType")]
        public virtual string GrantType { get; set; }

        /// <summary>
        /// A set of features that Security Token Service supports, in addition to the standard OAuth 2.0 token
        /// exchange, formatted as a serialized JSON object of Options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual string Options { get; set; }

        /// <summary>
        /// Required. An identifier for the type of requested security token. Must be
        /// `urn:ietf:params:oauth:token-type:access_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedTokenType")]
        public virtual string RequestedTokenType { get; set; }

        /// <summary>
        /// The OAuth 2.0 scopes to include on the resulting access token, formatted as a list of space-delimited,
        /// case-sensitive strings. Required when exchanging an external credential for a Google access token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// Required. The input token. This token is either an external credential issued by a workload identity pool
        /// provider, or a short-lived access token issued by Google. If the token is an OIDC JWT, it must use the JWT
        /// format defined in [RFC 7523](https://tools.ietf.org/html/rfc7523), and the `subject_token_type` must be
        /// either `urn:ietf:params:oauth:token-type:jwt` or `urn:ietf:params:oauth:token-type:id_token`. The following
        /// headers are required: - `kid`: The identifier of the signing key securing the JWT. - `alg`: The
        /// cryptographic algorithm securing the JWT. Must be `RS256` or `ES256`. The following payload fields are
        /// required. For more information, see [RFC 7523, Section 3](https://tools.ietf.org/html/rfc7523#section-3): -
        /// `iss`: The issuer of the token. The issuer must provide a discovery document at the URL
        /// `/.well-known/openid-configuration`, where `` is the value of this field. The document must be formatted
        /// according to section 4.2 of the [OIDC 1.0 Discovery
        /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html#ProviderConfigurationResponse). -
        /// `iat`: The issue time, in seconds, since the Unix epoch. Must be in the past. - `exp`: The expiration time,
        /// in seconds, since the Unix epoch. Must be less than 48 hours after `iat`. Shorter expiration times are more
        /// secure. If possible, we recommend setting an expiration time less than 6 hours. - `sub`: The identity
        /// asserted in the JWT. - `aud`: For workload identity pools, this must be a value specified in the allowed
        /// audiences for the workload identity pool provider, or one of the audiences allowed by default if no
        /// audiences were specified. See
        /// https://cloud.google.com/iam/docs/reference/rest/v1/projects.locations.workloadIdentityPools.providers#oidc
        /// Example header: ``` { "alg": "RS256", "kid": "us-east-11" } ``` Example payload: ``` { "iss":
        /// "https://accounts.google.com", "iat": 1517963104, "exp": 1517966704, "aud":
        /// "//iam.googleapis.com/projects/1234567890123/locations/global/workloadIdentityPools/my-pool/providers/my-provider",
        /// "sub": "113475438248934895348", "my_claims": { "additional_claim": "value" } } ``` If `subject_token` is for
        /// AWS, it must be a serialized `GetCallerIdentity` token. This token contains the same information as a
        /// request to the AWS
        /// [`GetCallerIdentity()`](https://docs.aws.amazon.com/STS/latest/APIReference/API_GetCallerIdentity) method,
        /// as well as the AWS [signature](https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html)
        /// for the request information. Use Signature Version 4. Format the request as URL-encoded JSON, and set the
        /// `subject_token_type` parameter to `urn:ietf:params:aws:token-type:aws4_request`. The following parameters
        /// are required: - `url`: The URL of the AWS STS endpoint for `GetCallerIdentity()`, such as
        /// `https://sts.amazonaws.com?Action=GetCallerIdentity&amp;amp;Version=2011-06-15`. Regional endpoints are also
        /// supported. - `method`: The HTTP request method: `POST`. - `headers`: The HTTP request headers, which must
        /// include: - `Authorization`: The request signature. - `x-amz-date`: The time you will send the request,
        /// formatted as an [ISO8601
        /// Basic](https://docs.aws.amazon.com/general/latest/gr/sigv4_elements.html#sigv4_elements_date) string. This
        /// value is typically set to the current time and is used to help prevent replay attacks. - `host`: The
        /// hostname of the `url` field; for example, `sts.amazonaws.com`. - `x-goog-cloud-target-resource`: The full,
        /// canonical resource name of the workload identity pool provider, with or without an `https:` prefix. To help
        /// ensure data integrity, we recommend including this header in the `SignedHeaders` field of the signed
        /// request. For example: //iam.googleapis.com/projects//locations//workloadIdentityPools//providers/
        /// https://iam.googleapis.com/projects//locations//workloadIdentityPools//providers/ If you are using temporary
        /// security credentials provided by AWS, you must also include the header `x-amz-security-token`, with the
        /// value set to the session token. The following example shows a `GetCallerIdentity` token: ``` { "headers": [
        /// {"key": "x-amz-date", "value": "20200815T015049Z"}, {"key": "Authorization", "value":
        /// "AWS4-HMAC-SHA256+Credential=$credential,+SignedHeaders=host;x-amz-date;x-goog-cloud-target-resource,+Signature=$signature"},
        /// {"key": "x-goog-cloud-target-resource", "value":
        /// "//iam.googleapis.com/projects//locations//workloadIdentityPools//providers/"}, {"key": "host", "value":
        /// "sts.amazonaws.com"} . ], "method": "POST", "url":
        /// "https://sts.amazonaws.com?Action=GetCallerIdentity&amp;amp;Version=2011-06-15" } ``` You can also use a
        /// Google-issued OAuth 2.0 access token with this field to obtain an access token with new security attributes
        /// applied, such as a Credential Access Boundary. In this case, set `subject_token_type` to
        /// `urn:ietf:params:oauth:token-type:access_token`. If an access token already contains security attributes,
        /// you cannot apply additional security attributes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectToken")]
        public virtual string SubjectToken { get; set; }

        /// <summary>
        /// Required. An identifier that indicates the type of the security token in the `subject_token` parameter.
        /// Supported values are `urn:ietf:params:oauth:token-type:jwt`, `urn:ietf:params:oauth:token-type:id_token`,
        /// `urn:ietf:params:aws:token-type:aws4_request`, and `urn:ietf:params:oauth:token-type:access_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectTokenType")]
        public virtual string SubjectTokenType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ExchangeToken.</summary>
    public class GoogleIdentityStsV1ExchangeTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An OAuth 2.0 security token, issued by Google, in response to the token exchange request. Tokens can vary in
        /// size, depending in part on the size of mapped claims, up to a maximum of 12288 bytes (12 KB). Google
        /// reserves the right to change the token size and the maximum length at any time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access_token")]
        public virtual string AccessToken { get; set; }

        /// <summary>
        /// The amount of time, in seconds, between the time when the access token was issued and the time when the
        /// access token will expire. This field is absent when the `subject_token` in the request is a Google-issued,
        /// short-lived access token. In this case, the access token has the same expiration time as the
        /// `subject_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expires_in")]
        public virtual System.Nullable<int> ExpiresIn { get; set; }

        /// <summary>The token type. Always matches the value of `requested_token_type` from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issued_token_type")]
        public virtual string IssuedTokenType { get; set; }

        /// <summary>The type of access token. Always has the value `Bearer`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token_type")]
        public virtual string TokenType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for IntrospectToken.</summary>
    public class GoogleIdentityStsV1IntrospectTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The OAuth 2.0 security token issued by the Security Token Service API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// Optional. The type of the given token. Supported values are `urn:ietf:params:oauth:token-type:access_token`
        /// and `access_token`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenTypeHint")]
        public virtual string TokenTypeHint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for IntrospectToken.</summary>
    public class GoogleIdentityStsV1IntrospectTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean value that indicates whether the provided access token is currently active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>The client identifier for the OAuth 2.0 client that requested the provided token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client_id")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// The expiration timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this
        /// token will expire.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exp")]
        public virtual System.Nullable<long> Exp { get; set; }

        /// <summary>
        /// The issued timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token
        /// was originally issued.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iat")]
        public virtual System.Nullable<long> Iat { get; set; }

        /// <summary>The issuer of the provided token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iss")]
        public virtual string Iss { get; set; }

        /// <summary>A list of scopes associated with the provided token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// The unique user ID associated with the provided token. For Google Accounts, this value is based on the
        /// Google Account's user ID. For federated identities, this value is based on the identity pool ID and the
        /// value of the mapped `google.subject` attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sub")]
        public virtual string Sub { get; set; }

        /// <summary>
        /// The human-readable identifier for the token principal subject. For example, if the provided token is
        /// associated with a workload identity pool, this field contains a value in the following format:
        /// `principal://iam.googleapis.com/projects//locations//workloadIdentityPools//subject/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
