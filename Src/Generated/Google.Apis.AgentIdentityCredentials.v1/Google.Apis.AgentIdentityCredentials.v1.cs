// Copyright 2026 Google LLC
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

namespace Google.Apis.AgentIdentityCredentials.v1
{
    /// <summary>The AgentIdentityCredentials Service.</summary>
    public class AgentIdentityCredentialsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AgentIdentityCredentialsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AgentIdentityCredentialsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://agentidentitycredentials.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://agentidentitycredentials.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "agentidentitycredentials";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Agent Identity Credentials API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Agent Identity Credentials API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for AgentIdentityCredentials requests.</summary>
    public abstract class AgentIdentityCredentialsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AgentIdentityCredentialsBaseServiceRequest instance.</summary>
        protected AgentIdentityCredentialsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AgentIdentityCredentials parameter list.</summary>
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

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                AuthProviders = new AuthProvidersResource(service);
            }

            /// <summary>Gets the AuthProviders resource.</summary>
            public virtual AuthProvidersResource AuthProviders { get; }

            /// <summary>The "authProviders" collection of methods.</summary>
            public class AuthProvidersResource
            {
                private const string Resource = "authProviders";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuthProvidersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Credentials = new CredentialsResource(service);
                }

                /// <summary>Gets the Credentials resource.</summary>
                public virtual CredentialsResource Credentials { get; }

                /// <summary>The "credentials" collection of methods.</summary>
                public class CredentialsResource
                {
                    private const string Resource = "credentials";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CredentialsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Finalizes the credentials after a successful consent flow.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="authProvider">
                    /// Required. The resource name of the AuthProvider. Format:
                    /// `projects/{project}/locations/{location}/authProviders/{auth_provider}`
                    /// </param>
                    public virtual FinalizeRequest Finalize(Google.Apis.AgentIdentityCredentials.v1.Data.GoogleCloudAgentidentitycredentialsV1FinalizeCredentialsRequest body, string authProvider)
                    {
                        return new FinalizeRequest(this.service, body, authProvider);
                    }

                    /// <summary>Finalizes the credentials after a successful consent flow.</summary>
                    public class FinalizeRequest : AgentIdentityCredentialsBaseServiceRequest<Google.Apis.AgentIdentityCredentials.v1.Data.GoogleCloudAgentidentitycredentialsV1FinalizeCredentialsResponse>
                    {
                        /// <summary>Constructs a new Finalize request.</summary>
                        public FinalizeRequest(Google.Apis.Services.IClientService service, Google.Apis.AgentIdentityCredentials.v1.Data.GoogleCloudAgentidentitycredentialsV1FinalizeCredentialsRequest body, string authProvider) : base(service)
                        {
                            AuthProvider = authProvider;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the AuthProvider. Format:
                        /// `projects/{project}/locations/{location}/authProviders/{auth_provider}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("authProvider", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AuthProvider { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AgentIdentityCredentials.v1.Data.GoogleCloudAgentidentitycredentialsV1FinalizeCredentialsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "finalize";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+authProvider}/credentials:finalize";

                        /// <summary>Initializes Finalize parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("authProvider", new Google.Apis.Discovery.Parameter
                            {
                                Name = "authProvider",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/authProviders/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Retrieves authorization credentials for an authprovider, or indicates what action needs to be
                    /// taken to obtain credentials. If the `token` field in the response is populated, credential
                    /// retrieval was successful. If one of the fields in the `status` oneof is populated, further
                    /// action is required to obtain credentials, such as redirecting the user for consent. View
                    /// comments on `RetrieveCredentialsResponse` for more information.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="authProvider">
                    /// Required. The parent resource name of the AuthProvider. Format:
                    /// `projects/{project}/locations/{location}/authProviders/{auth_provider}`
                    /// </param>
                    public virtual RetrieveRequest Retrieve(Google.Apis.AgentIdentityCredentials.v1.Data.GoogleCloudAgentidentitycredentialsV1RetrieveCredentialsRequest body, string authProvider)
                    {
                        return new RetrieveRequest(this.service, body, authProvider);
                    }

                    /// <summary>
                    /// Retrieves authorization credentials for an authprovider, or indicates what action needs to be
                    /// taken to obtain credentials. If the `token` field in the response is populated, credential
                    /// retrieval was successful. If one of the fields in the `status` oneof is populated, further
                    /// action is required to obtain credentials, such as redirecting the user for consent. View
                    /// comments on `RetrieveCredentialsResponse` for more information.
                    /// </summary>
                    public class RetrieveRequest : AgentIdentityCredentialsBaseServiceRequest<Google.Apis.AgentIdentityCredentials.v1.Data.GoogleCloudAgentidentitycredentialsV1RetrieveCredentialsResponse>
                    {
                        /// <summary>Constructs a new Retrieve request.</summary>
                        public RetrieveRequest(Google.Apis.Services.IClientService service, Google.Apis.AgentIdentityCredentials.v1.Data.GoogleCloudAgentidentitycredentialsV1RetrieveCredentialsRequest body, string authProvider) : base(service)
                        {
                            AuthProvider = authProvider;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name of the AuthProvider. Format:
                        /// `projects/{project}/locations/{location}/authProviders/{auth_provider}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("authProvider", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AuthProvider { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AgentIdentityCredentials.v1.Data.GoogleCloudAgentidentitycredentialsV1RetrieveCredentialsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "retrieve";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+authProvider}/credentials:retrieve";

                        /// <summary>Initializes Retrieve parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("authProvider", new Google.Apis.Discovery.Parameter
                            {
                                Name = "authProvider",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/authProviders/[^/]+$",
                            });
                        }
                    }
                }
            }
        }
    }
}
namespace Google.Apis.AgentIdentityCredentials.v1.Data
{
    /// <summary>Indicates the user has rejected the permission delegation or cancelled the request.</summary>
    public class GoogleCloudAgentidentitycredentialsV1ConsentRejected : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for FinalizeCredentials.</summary>
    public class GoogleCloudAgentidentitycredentialsV1FinalizeCredentialsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The same consent_nonce value that was provided during redirect in the UriConsentRequired metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentNonce")]
        public virtual string ConsentNonce { get; set; }

        /// <summary>Required. The identity of the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>Required. The encrypted state passed back from the consent flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIdValidationState")]
        public virtual string UserIdValidationState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for FinalizeCredentials. Intentionally empty</summary>
    public class GoogleCloudAgentidentitycredentialsV1FinalizeCredentialsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates that the credential retrieval is pending. The caller should retry the RetrieveCredentials request
    /// after some time.
    /// </summary>
    public class GoogleCloudAgentidentitycredentialsV1Pending : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RetrieveCredentials.</summary>
    public class GoogleCloudAgentidentitycredentialsV1RetrieveCredentialsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The URI to redirect the user to after consent is completed. This field is required for
        /// authproviders using the 3-legged OAuth flow. For other authprovider types, this field is unused but not
        /// rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continueUri")]
        public virtual string ContinueUri { get; set; }

        /// <summary>
        /// Optional. Input only. Set this field only if the previous token was expired or invalid. This value must be
        /// the full, previously returned token string. Will trigger a refresh of the access token with a stored refresh
        /// token, if possible, or a new consent flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forceRefreshToken")]
        public virtual string ForceRefreshToken { get; set; }

        /// <summary>Optional. The OAuth scopes required for this access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>Required. The identity of the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for RetrieveCredentials. Contains the access tokens and related artifacts.</summary>
    public class GoogleCloudAgentidentitycredentialsV1RetrieveCredentialsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Message indicating consent was rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentRejected")]
        public virtual GoogleCloudAgentidentitycredentialsV1ConsentRejected ConsentRejected { get; set; }

        /// <summary>Message indicating credential retrieval is pending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pending")]
        public virtual GoogleCloudAgentidentitycredentialsV1Pending Pending { get; set; }

        /// <summary>Message indicating credentials were successfully retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("success")]
        public virtual GoogleCloudAgentidentitycredentialsV1Success Success { get; set; }

        /// <summary>Message indicating uri based consent is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriConsentRequired")]
        public virtual GoogleCloudAgentidentitycredentialsV1UriConsentRequired UriConsentRequired { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message indicating successful retrieval of credentials.</summary>
    public class GoogleCloudAgentidentitycredentialsV1Success : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// The expiration time of the token. This does not guarantee that the token will be valid until this time,
        /// since the token could be revoked earlier. There could also be clock skew between the auth provider and the
        /// client so it may expire slightly earlier. If not set, the token might be permanent or it may be that the
        /// service does not (or cannot) know when it will expire.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The HTTP header name where the token should be placed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>
        /// The scopes actually associated with the retrieved token. End users may have rejected some requested scopes,
        /// or the third-party authorization servers can return a different set of scopes than what was asked for.
        /// Callers should verify that all required scopes for their intended use are included in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// The retrieved access token or credential for the end user. On MCPTool call, for an invalid token OAuth spec
        /// says this should return 401 or 403, but MCPServers may implement this differently. If you get any flavor of
        /// `PERMISSION_DENIED`, retry your original request to RetrieveCredentials with force_refresh_token set to the
        /// expired/invalid token string, which will fetch a new token or initiate a new consent flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates that the user must visit the provided URI to consent to delegate permission to the agent to act on
    /// their behalf. The caller can either poll the `RetrieveCredentials` method, or await the /ValidateUserId callback
    /// </summary>
    public class GoogleCloudAgentidentitycredentialsV1UriConsentRequired : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The URL where the user should be redirected to grant consent. This will always be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationUri")]
        public virtual string AuthorizationUri { get; set; }

        /// <summary>
        /// Output only. A one-time, randomly generated value that validates the entire consent flow is handled by a
        /// single user, avoiding CSRF attacks. It must be submitted with the FinalizeCredentials request to complete
        /// the OAuth exchange. This will always be present. Implemented per
        /// https://www.rfc-editor.org/rfc/rfc6819#section-5.3.5
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentNonce")]
        public virtual string ConsentNonce { get; set; }

        /// <summary>Output only. The unique ID of the credentials retrieval operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
