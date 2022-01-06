// Copyright 2022 Google LLC
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

namespace Google.Apis.IAMCredentials.v1
{
    /// <summary>The IAMCredentials Service.</summary>
    public class IAMCredentialsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public IAMCredentialsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public IAMCredentialsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "iamcredentials";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://iamcredentials.googleapis.com/";
        #else
            "https://iamcredentials.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://iamcredentials.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the IAM Service Account Credentials API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the IAM Service Account Credentials API.</summary>
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

    /// <summary>A base abstract class for IAMCredentials requests.</summary>
    public abstract class IAMCredentialsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new IAMCredentialsBaseServiceRequest instance.</summary>
        protected IAMCredentialsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes IAMCredentials parameter list.</summary>
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
            ServiceAccounts = new ServiceAccountsResource(service);
        }

        /// <summary>Gets the ServiceAccounts resource.</summary>
        public virtual ServiceAccountsResource ServiceAccounts { get; }

        /// <summary>The "serviceAccounts" collection of methods.</summary>
        public class ServiceAccountsResource
        {
            private const string Resource = "serviceAccounts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServiceAccountsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Generates an OAuth 2.0 access token for a service account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the service account for which the credentials are requested, in the
            /// following format: `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard character
            /// is required; replacing it with a project ID is invalid.
            /// </param>
            public virtual GenerateAccessTokenRequest GenerateAccessToken(Google.Apis.IAMCredentials.v1.Data.GenerateAccessTokenRequest body, string name)
            {
                return new GenerateAccessTokenRequest(service, body, name);
            }

            /// <summary>Generates an OAuth 2.0 access token for a service account.</summary>
            public class GenerateAccessTokenRequest : IAMCredentialsBaseServiceRequest<Google.Apis.IAMCredentials.v1.Data.GenerateAccessTokenResponse>
            {
                /// <summary>Constructs a new GenerateAccessToken request.</summary>
                public GenerateAccessTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.IAMCredentials.v1.Data.GenerateAccessTokenRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the service account for which the credentials are requested, in the
                /// following format: `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
                /// character is required; replacing it with a project ID is invalid.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.IAMCredentials.v1.Data.GenerateAccessTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generateAccessToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:generateAccessToken";

                /// <summary>Initializes GenerateAccessToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>Generates an OpenID Connect ID token for a service account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the service account for which the credentials are requested, in the
            /// following format: `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard character
            /// is required; replacing it with a project ID is invalid.
            /// </param>
            public virtual GenerateIdTokenRequest GenerateIdToken(Google.Apis.IAMCredentials.v1.Data.GenerateIdTokenRequest body, string name)
            {
                return new GenerateIdTokenRequest(service, body, name);
            }

            /// <summary>Generates an OpenID Connect ID token for a service account.</summary>
            public class GenerateIdTokenRequest : IAMCredentialsBaseServiceRequest<Google.Apis.IAMCredentials.v1.Data.GenerateIdTokenResponse>
            {
                /// <summary>Constructs a new GenerateIdToken request.</summary>
                public GenerateIdTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.IAMCredentials.v1.Data.GenerateIdTokenRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the service account for which the credentials are requested, in the
                /// following format: `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
                /// character is required; replacing it with a project ID is invalid.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.IAMCredentials.v1.Data.GenerateIdTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generateIdToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:generateIdToken";

                /// <summary>Initializes GenerateIdToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>Signs a blob using a service account's system-managed private key.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the service account for which the credentials are requested, in the
            /// following format: `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard character
            /// is required; replacing it with a project ID is invalid.
            /// </param>
            public virtual SignBlobRequest SignBlob(Google.Apis.IAMCredentials.v1.Data.SignBlobRequest body, string name)
            {
                return new SignBlobRequest(service, body, name);
            }

            /// <summary>Signs a blob using a service account's system-managed private key.</summary>
            public class SignBlobRequest : IAMCredentialsBaseServiceRequest<Google.Apis.IAMCredentials.v1.Data.SignBlobResponse>
            {
                /// <summary>Constructs a new SignBlob request.</summary>
                public SignBlobRequest(Google.Apis.Services.IClientService service, Google.Apis.IAMCredentials.v1.Data.SignBlobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the service account for which the credentials are requested, in the
                /// following format: `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
                /// character is required; replacing it with a project ID is invalid.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.IAMCredentials.v1.Data.SignBlobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "signBlob";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:signBlob";

                /// <summary>Initializes SignBlob parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }

            /// <summary>Signs a JWT using a service account's system-managed private key.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the service account for which the credentials are requested, in the
            /// following format: `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard character
            /// is required; replacing it with a project ID is invalid.
            /// </param>
            public virtual SignJwtRequest SignJwt(Google.Apis.IAMCredentials.v1.Data.SignJwtRequest body, string name)
            {
                return new SignJwtRequest(service, body, name);
            }

            /// <summary>Signs a JWT using a service account's system-managed private key.</summary>
            public class SignJwtRequest : IAMCredentialsBaseServiceRequest<Google.Apis.IAMCredentials.v1.Data.SignJwtResponse>
            {
                /// <summary>Constructs a new SignJwt request.</summary>
                public SignJwtRequest(Google.Apis.Services.IClientService service, Google.Apis.IAMCredentials.v1.Data.SignJwtRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the service account for which the credentials are requested, in the
                /// following format: `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard
                /// character is required; replacing it with a project ID is invalid.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.IAMCredentials.v1.Data.SignJwtRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "signJwt";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:signJwt";

                /// <summary>Initializes SignJwt parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/serviceAccounts/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.IAMCredentials.v1.Data
{
    public class GenerateAccessTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The sequence of service accounts in a delegation chain. This field is required for [delegated
        /// requests](https://cloud.google.com/iam/help/credentials/delegated-request). For [direct
        /// requests](https://cloud.google.com/iam/help/credentials/direct-request), which are more common, do not
        /// specify this field. Each service account must be granted the `roles/iam.serviceAccountTokenCreator` role on
        /// its next service account in the chain. The last service account in the chain must be granted the
        /// `roles/iam.serviceAccountTokenCreator` role on the service account that is specified in the `name` field of
        /// the request. The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard character is required; replacing
        /// it with a project ID is invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegates")]
        public virtual System.Collections.Generic.IList<string> Delegates { get; set; }

        /// <summary>
        /// The desired lifetime duration of the access token in seconds. By default, the maximum allowed value is 1
        /// hour. To set a lifetime of up to 12 hours, you can add the service account as an allowed value in an
        /// Organization Policy that enforces the `constraints/iam.allowServiceAccountCredentialLifetimeExtension`
        /// constraint. See detailed instructions at https://cloud.google.com/iam/help/credentials/lifetime If a value
        /// is not specified, the token's lifetime will be set to a default value of 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifetime")]
        public virtual object Lifetime { get; set; }

        /// <summary>
        /// Required. Code to identify the scopes to be included in the OAuth 2.0 access token. See
        /// https://developers.google.com/identity/protocols/googlescopes for more information. At least one value
        /// required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual System.Collections.Generic.IList<string> Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GenerateAccessTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OAuth 2.0 access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual string AccessToken { get; set; }

        /// <summary>Token expiration time. The expiration time is always set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GenerateIdTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The audience for the token, such as the API or account that this token grants access to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>
        /// The sequence of service accounts in a delegation chain. Each service account must be granted the
        /// `roles/iam.serviceAccountTokenCreator` role on its next service account in the chain. The last service
        /// account in the chain must be granted the `roles/iam.serviceAccountTokenCreator` role on the service account
        /// that is specified in the `name` field of the request. The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard character is required; replacing
        /// it with a project ID is invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegates")]
        public virtual System.Collections.Generic.IList<string> Delegates { get; set; }

        /// <summary>
        /// Include the service account email in the token. If set to `true`, the token will contain `email` and
        /// `email_verified` claims.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeEmail")]
        public virtual System.Nullable<bool> IncludeEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GenerateIdTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OpenId Connect ID token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SignBlobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The sequence of service accounts in a delegation chain. Each service account must be granted the
        /// `roles/iam.serviceAccountTokenCreator` role on its next service account in the chain. The last service
        /// account in the chain must be granted the `roles/iam.serviceAccountTokenCreator` role on the service account
        /// that is specified in the `name` field of the request. The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard character is required; replacing
        /// it with a project ID is invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegates")]
        public virtual System.Collections.Generic.IList<string> Delegates { get; set; }

        /// <summary>Required. The bytes to sign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SignBlobResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the key used to sign the blob. The key used for signing will remain valid for at least 12 hours
        /// after the blob is signed. To verify the signature, you can retrieve the public key in several formats from
        /// the following endpoints: - RSA public key wrapped in an X.509 v3 certificate:
        /// `https://www.googleapis.com/service_accounts/v1/metadata/x509/{ACCOUNT_EMAIL}` - Raw key in JSON format:
        /// `https://www.googleapis.com/service_accounts/v1/metadata/raw/{ACCOUNT_EMAIL}` - JSON Web Key (JWK):
        /// `https://www.googleapis.com/service_accounts/v1/metadata/jwk/{ACCOUNT_EMAIL}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>
        /// The signature for the blob. Does not include the original blob. After the key pair referenced by the
        /// `key_id` response field expires, Google no longer exposes the public key that can be used to verify the
        /// blob. As a result, the receiver can no longer verify the signature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedBlob")]
        public virtual string SignedBlob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SignJwtRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The sequence of service accounts in a delegation chain. Each service account must be granted the
        /// `roles/iam.serviceAccountTokenCreator` role on its next service account in the chain. The last service
        /// account in the chain must be granted the `roles/iam.serviceAccountTokenCreator` role on the service account
        /// that is specified in the `name` field of the request. The delegates must have the following format:
        /// `projects/-/serviceAccounts/{ACCOUNT_EMAIL_OR_UNIQUEID}`. The `-` wildcard character is required; replacing
        /// it with a project ID is invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegates")]
        public virtual System.Collections.Generic.IList<string> Delegates { get; set; }

        /// <summary>
        /// Required. The JWT payload to sign. Must be a serialized JSON object that contains a JWT Claims Set. For
        /// example: `{"sub": "user@example.com", "iat": 313435}` If the JWT Claims Set contains an expiration time
        /// (`exp`) claim, it must be an integer timestamp that is not in the past and no more than 12 hours in the
        /// future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SignJwtResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the key used to sign the JWT. The key used for signing will remain valid for at least 12 hours
        /// after the JWT is signed. To verify the signature, you can retrieve the public key in several formats from
        /// the following endpoints: - RSA public key wrapped in an X.509 v3 certificate:
        /// `https://www.googleapis.com/service_accounts/v1/metadata/x509/{ACCOUNT_EMAIL}` - Raw key in JSON format:
        /// `https://www.googleapis.com/service_accounts/v1/metadata/raw/{ACCOUNT_EMAIL}` - JSON Web Key (JWK):
        /// `https://www.googleapis.com/service_accounts/v1/metadata/jwk/{ACCOUNT_EMAIL}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>
        /// The signed JWT. Contains the automatically generated header; the client-supplied payload; and the signature,
        /// which is generated using the key referenced by the `kid` field in the header. After the key pair referenced
        /// by the `key_id` response field expires, Google no longer exposes the public key that can be used to verify
        /// the JWT. As a result, the receiver can no longer verify the signature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedJwt")]
        public virtual string SignedJwt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
