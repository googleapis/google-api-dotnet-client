// Copyright 2023 Google LLC
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
        public override string BaseUri => BaseUriOverride ?? "https://sts.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://sts.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

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
        /// Exchanges a credential that represents the resource owner's authorization for a Google-generated [OAuth 2.0
        /// access token] (https://www.rfc-editor.org/rfc/rfc6749#section-5) or [refreshes an accesstoken]
        /// (https://www.rfc-editor.org/rfc/rfc6749#section-6) following [the OAuth 2.0 authorization framework]
        /// (https://tools.ietf.org/html/rfc8693) The credential can be one of the following: - An authorization code
        /// issued by the workforce identity federation authorization endpoint - A [refresh
        /// token](https://www.rfc-editor.org/rfc/rfc6749#section-10.4) issued by this endpoint This endpoint is only
        /// meant to be called by the Google Cloud CLI. Also note that this API only accepts the authorization code
        /// issued for workforce pools.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual OauthtokenRequest Oauthtoken(Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeOauthTokenRequest body)
        {
            return new OauthtokenRequest(service, body);
        }

        /// <summary>
        /// Exchanges a credential that represents the resource owner's authorization for a Google-generated [OAuth 2.0
        /// access token] (https://www.rfc-editor.org/rfc/rfc6749#section-5) or [refreshes an accesstoken]
        /// (https://www.rfc-editor.org/rfc/rfc6749#section-6) following [the OAuth 2.0 authorization framework]
        /// (https://tools.ietf.org/html/rfc8693) The credential can be one of the following: - An authorization code
        /// issued by the workforce identity federation authorization endpoint - A [refresh
        /// token](https://www.rfc-editor.org/rfc/rfc6749#section-10.4) issued by this endpoint This endpoint is only
        /// meant to be called by the Google Cloud CLI. Also note that this API only accepts the authorization code
        /// issued for workforce pools.
        /// </summary>
        public class OauthtokenRequest : CloudSecurityTokenBaseServiceRequest<Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeOauthTokenResponse>
        {
            /// <summary>Constructs a new Oauthtoken request.</summary>
            public OauthtokenRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeOauthTokenRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeOauthTokenRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "oauthtoken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/oauthtoken";

            /// <summary>Initializes Oauthtoken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Exchanges a credential for a Google OAuth 2.0 access token. The token asserts an external identity within an
        /// identity pool, or it applies a Credential Access Boundary to a Google access token. Note that workforce
        /// pools do not support Credential Access Boundaries. When you call this method, do not send the
        /// `Authorization` HTTP header in the request. This method does not require the `Authorization` header, and
        /// using the header can cause the request to fail.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual TokenRequest Token(Google.Apis.CloudSecurityToken.v1.Data.GoogleIdentityStsV1ExchangeTokenRequest body)
        {
            return new TokenRequest(service, body);
        }

        /// <summary>
        /// Exchanges a credential for a Google OAuth 2.0 access token. The token asserts an external identity within an
        /// identity pool, or it applies a Credential Access Boundary to a Google access token. Note that workforce
        /// pools do not support Credential Access Boundaries. When you call this method, do not send the
        /// `Authorization` HTTP header in the request. This method does not require the `Authorization` header, and
        /// using the header can cause the request to fail.
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
    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. * `user:{emailid}`: An email address that represents a
        /// specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address
        /// that represents a Google service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]`: An identifier for a [Kubernetes
        /// service account](https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For
        /// example, `my-project.svc.id.goog[my-namespace/my-kubernetes-sa]`. * `group:{emailid}`: An email address that
        /// represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An
        /// email address (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An access boundary defines the upper bound of what a principal may access. It includes a list of access boundary
    /// rules that each defines the resource that may be allowed as well as permissions that may be used on those
    /// resources.
    /// </summary>
    public class GoogleIdentityStsV1AccessBoundary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of access boundary rules which defines the upper bound of the permission a principal may carry. If
        /// multiple rules are specified, the effective access boundary is the union of all the access boundary rules
        /// attached. One access boundary can contain at most 10 rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBoundaryRules")]
        public virtual System.Collections.Generic.IList<GoogleIdentityStsV1AccessBoundaryRule> AccessBoundaryRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An access boundary rule defines an upper bound of IAM permissions on a single resource.</summary>
    public class GoogleIdentityStsV1AccessBoundaryRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The availability condition further constrains the access allowed by the access boundary rule. If the
        /// condition evaluates to `true`, then this access boundary rule will provide access to the specified resource,
        /// assuming the principal has the required permissions for the resource. If the condition does not evaluate to
        /// `true`, then access to the specified resource will not be available. Note that all access boundary rules in
        /// an access boundary are evaluated together as a union. As such, another access boundary rule may allow access
        /// to the resource, even if this access boundary rule does not allow access. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). The maximum length of the
        /// `expression` field is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityCondition")]
        public virtual GoogleTypeExpr AvailabilityCondition { get; set; }

        /// <summary>
        /// A list of permissions that may be allowed for use on the specified resource. The only supported values in
        /// the list are IAM roles, following the format of google.iam.v1.Binding.role. Example value:
        /// `inRole:roles/logging.viewer` for predefined roles and
        /// `inRole:organizations/{ORGANIZATION_ID}/roles/logging.viewer` for custom roles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availablePermissions")]
        public virtual System.Collections.Generic.IList<string> AvailablePermissions { get; set; }

        /// <summary>
        /// The full resource name of a Google Cloud resource entity. The format definition is at
        /// https://cloud.google.com/apis/design/resource_names. Example value:
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableResource")]
        public virtual string AvailableResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ExchangeOauthToken</summary>
    public class GoogleIdentityStsV1ExchangeOauthTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The client identifier for the OAuth 2.0 client that requested the provided token. It is REQUIRED
        /// when the [client] (https://www.rfc-editor.org/rfc/rfc6749#section-1.1) is not authenticating with the
        /// authorization server, i.e. when authentication method is [client authentication]
        /// (https://www.rfc-editor.org/rfc/rfc6749#section-3.2.1).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Optional. The authorization code that was previously from workforce identity federation's `authorize`
        /// endpoint. Required if the flow is authorization code flow, i.e. if grant_type is 'authorization_code'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// Optional. The code verifier for the PKCE request, Google Cloud CLI originally generates it before the
        /// authorization request. PKCE is used to protect authorization code from interception attacks. See
        /// https://www.rfc-editor.org/rfc/rfc7636#section-1.1 and https://www.rfc-editor.org/rfc/rfc7636#section-3. It
        /// is required when the flow is authorization code flow, i.e. if grant_type is 'authorization_code'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeVerifier")]
        public virtual string CodeVerifier { get; set; }

        /// <summary>
        /// Required. The grant types are as follows: - 'authorization_code' : an authorization code flow, i.e. exchange
        /// of authorization code for the Oauth access token - 'refresh_token' : a refresh token flow, i.e. obtain a new
        /// access token by providing the refresh token. See https://www.rfc-editor.org/rfc/rfc6749#section-6
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantType")]
        public virtual string GrantType { get; set; }

        /// <summary>
        /// Optional. redirect_url is required when the flow is authorization code flow i.e. if grant_type is
        /// `authorization_code` See https://www.rfc-editor.org/rfc/rfc6749#section-4.1.3
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>
        /// Optional. The Refresh token is the credential that is used to obtain a new access token when the current
        /// access token becomes invalid or expires. Required when using refresh token flow, i.e. if `grant_type` is
        /// 'refresh_token' See https://www.rfc-editor.org/rfc/rfc6749#section-1.5 and
        /// https://www.rfc-editor.org/rfc/rfc6749#section-6
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshToken")]
        public virtual string RefreshToken { get; set; }

        /// <summary>
        /// Optional. An optional list of scopes that are requested for the token to be returned. See
        /// https://www.rfc-editor.org/rfc/rfc6749#section-3.3 Must be a list of space-delimited, case-sensitive
        /// strings. Note: Currently, the scopes in the request are not supported
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for ExchangeOauthToken. see https://www.rfc-editor.org/rfc/rfc6749#section-5.1
    /// </summary>
    public class GoogleIdentityStsV1ExchangeOauthTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An OAuth 2.0 security token, issued by Google, in response to the Oauth token exchange request for the
        /// authorization code and refresh token flows. The returned [access
        /// token](https://www.rfc-editor.org/rfc/rfc6749#section-4.1.4). Tokens can vary in size, depending, in part,
        /// on the size of mapped claims, up to a maximum of 12288 bytes (12 KB). Google reserves the right to change
        /// the token size and the maximum length at any time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access_token")]
        public virtual string AccessToken { get; set; }

        /// <summary>
        /// The amount of time, in seconds, between the time when the access token was issued and the time when the
        /// access token will expires.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expires_in")]
        public virtual System.Nullable<int> ExpiresIn { get; set; }

        /// <summary>
        /// A refresh token, issued by Google, in response to the OAuth token exchange request for refresh token flow
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refresh_token")]
        public virtual string RefreshToken { get; set; }

        /// <summary>A list of scopes associated with the returned token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// The type of token. Field reserved for RFC compliance. See https://www.rfc-editor.org/rfc/rfc6749#section-5.1
        /// Note: No token_type is returned for current implementation
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token_type")]
        public virtual string TokenType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ExchangeToken.</summary>
    public class GoogleIdentityStsV1ExchangeTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full resource name of the identity provider; for example:
        /// `//iam.googleapis.com/projects//locations/global/workloadIdentityPools//providers/` for workload identity
        /// pool providers, or `//iam.googleapis.com/locations/global/workforcePools//providers/` for workforce pool
        /// providers. Required when exchanging an external credential for a Google access token.
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
        /// exchange, formatted as a serialized JSON object of Options. The size of the parameter value must not exceed
        /// 4096 characters.
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
        /// https://cloud.google.com/iam/docs/reference/rest/v1/projects.locations.workloadIdentityPools.providers#oidc.
        /// For workforce pools, this must match the client ID specified in the provider configuration. See
        /// https://cloud.google.com/iam/docs/reference/rest/v1/locations.workforcePools.providers#oidc. Example header:
        /// ``` { "alg": "RS256", "kid": "us-east-11" } ``` Example payload: ``` { "iss": "https://accounts.google.com",
        /// "iat": 1517963104, "exp": 1517966704, "aud":
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
        /// request. For example: //iam.googleapis.com/projects//locations/global/workloadIdentityPools//providers/
        /// https://iam.googleapis.com/projects//locations/global/workloadIdentityPools//providers/ If you are using
        /// temporary security credentials provided by AWS, you must also include the header `x-amz-security-token`,
        /// with the value set to the session token. The following example shows a `GetCallerIdentity` token: ``` {
        /// "headers": [ {"key": "x-amz-date", "value": "20200815T015049Z"}, {"key": "Authorization", "value":
        /// "AWS4-HMAC-SHA256+Credential=$credential,+SignedHeaders=host;x-amz-date;x-goog-cloud-target-resource,+Signature=$signature"},
        /// {"key": "x-goog-cloud-target-resource", "value":
        /// "//iam.googleapis.com/projects//locations/global/workloadIdentityPools//providers/"}, {"key": "host",
        /// "value": "sts.amazonaws.com"} . ], "method": "POST", "url":
        /// "https://sts.amazonaws.com?Action=GetCallerIdentity&amp;amp;Version=2011-06-15" } ``` If the token is a SAML
        /// 2.0 assertion, it must use the format defined in [the SAML 2.0
        /// spec](https://www.oasis-open.org/committees/download.php/56776/sstc-saml-core-errata-2.0-wd-07.pdf), and the
        /// `subject_token_type` must be `urn:ietf:params:oauth:token-type:saml2`. See [Verification of external
        /// credentials](https://cloud.google.com/iam/docs/using-workload-identity-federation#verification_of_external_credentials)
        /// for details on how SAML 2.0 assertions are validated during token exchanges. You can also use a
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
        /// `urn:ietf:params:aws:token-type:aws4_request`, `urn:ietf:params:oauth:token-type:access_token`, and
        /// `urn:ietf:params:oauth:token-type:saml2`.
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
        /// `principal://iam.googleapis.com/projects//locations/global/workloadIdentityPools//subject/`. If the provided
        /// token is associated with a workforce pool, this field contains a value in the following format:
        /// `principal://iam.googleapis.com/locations/global/workforcePools//subject/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `Options` object configures features that the Security Token Service supports, but that are not supported by
    /// standard OAuth 2.0 token exchange endpoints, as defined in https://tools.ietf.org/html/rfc8693.
    /// </summary>
    public class GoogleIdentityStsV1Options : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An access boundary that defines the upper bound of permissions the credential may have. The value should be
        /// a JSON object of AccessBoundary. The access boundary can include up to 10 rules. The size of the parameter
        /// value should not exceed 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBoundary")]
        public virtual GoogleIdentityStsV1AccessBoundary AccessBoundary { get; set; }

        /// <summary>
        /// The intended audience(s) of the credential. The audience value(s) should be the name(s) of services intended
        /// to receive the credential. Example: `["https://pubsub.googleapis.com/", "https://storage.googleapis.com/"]`.
        /// A maximum of 5 audiences can be included. For each provided audience, the maximum length is 262 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audiences")]
        public virtual System.Collections.Generic.IList<string> Audiences { get; set; }

        /// <summary>
        /// A Google project used for quota and billing purposes when the credential is used to access Google APIs. The
        /// provided project overrides the project bound to the credential. The value must be a project number or a
        /// project ID. Example: `my-sample-project-191923`. The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userProject")]
        public virtual string UserProject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An access boundary defines the upper bound of what a principal may access. It includes a list of access boundary
    /// rules that each defines the resource that may be allowed as well as permissions that may be used on those
    /// resources.
    /// </summary>
    public class GoogleIdentityStsV1betaAccessBoundary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of access boundary rules which defines the upper bound of the permission a principal may carry. If
        /// multiple rules are specified, the effective access boundary is the union of all the access boundary rules
        /// attached. One access boundary can contain at most 10 rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBoundaryRules")]
        public virtual System.Collections.Generic.IList<GoogleIdentityStsV1betaAccessBoundaryRule> AccessBoundaryRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An access boundary rule defines an upper bound of IAM permissions on a single resource.</summary>
    public class GoogleIdentityStsV1betaAccessBoundaryRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The availability condition further constrains the access allowed by the access boundary rule. If the
        /// condition evaluates to `true`, then this access boundary rule will provide access to the specified resource,
        /// assuming the principal has the required permissions for the resource. If the condition does not evaluate to
        /// `true`, then access to the specified resource will not be available. Note that all access boundary rules in
        /// an access boundary are evaluated together as a union. As such, another access boundary rule may allow access
        /// to the resource, even if this access boundary rule does not allow access. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). The maximum length of the
        /// `expression` field is 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityCondition")]
        public virtual GoogleTypeExpr AvailabilityCondition { get; set; }

        /// <summary>
        /// A list of permissions that may be allowed for use on the specified resource. The only supported values in
        /// the list are IAM roles, following the format of google.iam.v1.Binding.role. Example value:
        /// `inRole:roles/logging.viewer` for predefined roles and
        /// `inRole:organizations/{ORGANIZATION_ID}/roles/logging.viewer` for custom roles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availablePermissions")]
        public virtual System.Collections.Generic.IList<string> AvailablePermissions { get; set; }

        /// <summary>
        /// The full resource name of a Google Cloud resource entity. The format definition is at
        /// https://cloud.google.com/apis/design/resource_names. Example value:
        /// `//cloudresourcemanager.googleapis.com/projects/my-project`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableResource")]
        public virtual string AvailableResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `Options` object configures features that the Security Token Service supports, but that are not supported by
    /// standard OAuth 2.0 token exchange endpoints, as defined in https://tools.ietf.org/html/rfc8693.
    /// </summary>
    public class GoogleIdentityStsV1betaOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An access boundary that defines the upper bound of permissions the credential may have. The value should be
        /// a JSON object of AccessBoundary. The access boundary can include up to 10 rules. The size of the parameter
        /// value should not exceed 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessBoundary")]
        public virtual GoogleIdentityStsV1betaAccessBoundary AccessBoundary { get; set; }

        /// <summary>
        /// The intended audience(s) of the credential. The audience value(s) should be the name(s) of services intended
        /// to receive the credential. Example: `["https://pubsub.googleapis.com/", "https://storage.googleapis.com/"]`.
        /// A maximum of 5 audiences can be included. For each provided audience, the maximum length is 262 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audiences")]
        public virtual System.Collections.Generic.IList<string> Audiences { get; set; }

        /// <summary>
        /// A Google project used for quota and billing purposes when the credential is used to access Google APIs. The
        /// provided project overrides the project bound to the credential. The value must be a project number or a
        /// project ID. Example: `my-sample-project-191923`. The maximum length is 32 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userProject")]
        public virtual string UserProject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class GoogleTypeExpr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
