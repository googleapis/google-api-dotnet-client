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

namespace Google.Apis.Integrations.v1alpha
{
    /// <summary>The Integrations Service.</summary>
    public class IntegrationsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public IntegrationsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public IntegrationsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Callback = new CallbackResource(this);
            ConnectorPlatformRegions = new ConnectorPlatformRegionsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "integrations";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://integrations.googleapis.com/";
        #else
            "https://integrations.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://integrations.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Application Integration API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Application Integration API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Callback resource.</summary>
        public virtual CallbackResource Callback { get; }

        /// <summary>Gets the ConnectorPlatformRegions resource.</summary>
        public virtual ConnectorPlatformRegionsResource ConnectorPlatformRegions { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Integrations requests.</summary>
    public abstract class IntegrationsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new IntegrationsBaseServiceRequest instance.</summary>
        protected IntegrationsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Integrations parameter list.</summary>
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

    /// <summary>The "callback" collection of methods.</summary>
    public class CallbackResource
    {
        private const string Resource = "callback";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CallbackResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Receives the auth code and auth config id to combine that with the client id and secret to retrieve access
        /// tokens from the token endpoint. Returns either a success or error message when it's done.
        /// </summary>
        public virtual GenerateTokenRequest GenerateToken()
        {
            return new GenerateTokenRequest(service);
        }

        /// <summary>
        /// Receives the auth code and auth config id to combine that with the client id and secret to retrieve access
        /// tokens from the token endpoint. Returns either a success or error message when it's done.
        /// </summary>
        public class GenerateTokenRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaGenerateTokenResponse>
        {
            /// <summary>Constructs a new GenerateToken request.</summary>
            public GenerateTokenRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The auth code for the given request</summary>
            [Google.Apis.Util.RequestParameterAttribute("code", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Code { get; set; }

            /// <summary>The gcp project id of the request</summary>
            [Google.Apis.Util.RequestParameterAttribute("gcpProjectId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GcpProjectId { get; set; }

            /// <summary>Which product sends the request</summary>
            [Google.Apis.Util.RequestParameterAttribute("product", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProductEnum> Product { get; set; }

            /// <summary>Which product sends the request</summary>
            public enum ProductEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("UNSPECIFIED_PRODUCT")]
                UNSPECIFIEDPRODUCT = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("IP")]
                IP = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("APIGEE")]
                APIGEE = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SECURITY")]
                SECURITY = 3,
            }

            /// <summary>Redirect uri of the auth code request</summary>
            [Google.Apis.Util.RequestParameterAttribute("redirectUri", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RedirectUri { get; set; }

            /// <summary>The auth config id for the given request</summary>
            [Google.Apis.Util.RequestParameterAttribute("state", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string State { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generateToken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/callback:generateToken";

            /// <summary>Initializes GenerateToken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("code", new Google.Apis.Discovery.Parameter
                {
                    Name = "code",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("gcpProjectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "gcpProjectId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("product", new Google.Apis.Discovery.Parameter
                {
                    Name = "product",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("redirectUri", new Google.Apis.Discovery.Parameter
                {
                    Name = "redirectUri",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("state", new Google.Apis.Discovery.Parameter
                {
                    Name = "state",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "connectorPlatformRegions" collection of methods.</summary>
    public class ConnectorPlatformRegionsResource
    {
        private const string Resource = "connectorPlatformRegions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ConnectorPlatformRegionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Enumerates the regions for which Connector Platform is provisioned.</summary>
        public virtual EnumerateRequest Enumerate()
        {
            return new EnumerateRequest(service);
        }

        /// <summary>Enumerates the regions for which Connector Platform is provisioned.</summary>
        public class EnumerateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaEnumerateConnectorPlatformRegionsResponse>
        {
            /// <summary>Constructs a new Enumerate request.</summary>
            public EnumerateRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "enumerate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/connectorPlatformRegions:enumerate";

            /// <summary>Initializes Enumerate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
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
                AppsScriptProjects = new AppsScriptProjectsResource(service);
                AuthConfigs = new AuthConfigsResource(service);
                Certificates = new CertificatesResource(service);
                Connections = new ConnectionsResource(service);
                Integrations = new IntegrationsResource(service);
                Products = new ProductsResource(service);
                SfdcInstances = new SfdcInstancesResource(service);
            }

            /// <summary>Gets the AppsScriptProjects resource.</summary>
            public virtual AppsScriptProjectsResource AppsScriptProjects { get; }

            /// <summary>The "appsScriptProjects" collection of methods.</summary>
            public class AppsScriptProjectsResource
            {
                private const string Resource = "appsScriptProjects";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AppsScriptProjectsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates an Apps Script project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The project that the executed integration belongs to.</param>
                public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCreateAppsScriptProjectRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates an Apps Script project.</summary>
                public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCreateAppsScriptProjectResponse>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCreateAppsScriptProjectRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The project that the executed integration belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCreateAppsScriptProjectRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/appsScriptProjects";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Links a existing Apps Script project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The project that the executed integration belongs to.</param>
                public virtual LinkRequest Link(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaLinkAppsScriptProjectRequest body, string parent)
                {
                    return new LinkRequest(service, body, parent);
                }

                /// <summary>Links a existing Apps Script project.</summary>
                public class LinkRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaLinkAppsScriptProjectResponse>
                {
                    /// <summary>Constructs a new Link request.</summary>
                    public LinkRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaLinkAppsScriptProjectRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The project that the executed integration belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaLinkAppsScriptProjectRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "link";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/appsScriptProjects:link";

                    /// <summary>Initializes Link parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the AuthConfigs resource.</summary>
            public virtual AuthConfigsResource AuthConfigs { get; }

            /// <summary>The "authConfigs" collection of methods.</summary>
            public class AuthConfigsResource
            {
                private const string Resource = "authConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AuthConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates an auth config record. Fetch corresponding credentials for specific auth types, e.g. access
                /// token for OAuth 2.0, JWT token for JWT. Encrypt the auth config with Cloud KMS and store the
                /// encrypted credentials in Spanner. Returns the encrypted auth config.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. "projects/{project}/locations/{location}" format.</param>
                public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates an auth config record. Fetch corresponding credentials for specific auth types, e.g. access
                /// token for OAuth 2.0, JWT token for JWT. Encrypt the auth config with Cloud KMS and store the
                /// encrypted credentials in Spanner. Returns the encrypted auth config.
                /// </summary>
                public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. "projects/{project}/locations/{location}" format.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The ssl certificate encoded in PEM format. This string must include the begin header and end
                    /// footer lines. For example, -----BEGIN CERTIFICATE-----
                    /// MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
                    /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
                    /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
                    /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
                    /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
                    /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
                    /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
                    /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
                    /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
                    /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
                    /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
                    /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg=
                    /// -----END CERTIFICATE-----
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientCertificate.encryptedPrivateKey", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientCertificateEncryptedPrivateKey { get; set; }

                    /// <summary>
                    /// 'passphrase' should be left unset if private key is not encrypted. Note that 'passphrase' is not
                    /// the password for web server, but an extra layer of security to protected private key.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientCertificate.passphrase", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientCertificatePassphrase { get; set; }

                    /// <summary>
                    /// The ssl certificate encoded in PEM format. This string must include the begin header and end
                    /// footer lines. For example, -----BEGIN CERTIFICATE-----
                    /// MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
                    /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
                    /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
                    /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
                    /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
                    /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
                    /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
                    /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
                    /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
                    /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
                    /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
                    /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg=
                    /// -----END CERTIFICATE-----
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientCertificate.sslCertificate", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientCertificateSslCertificate { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/authConfigs";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("clientCertificate.encryptedPrivateKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientCertificate.encryptedPrivateKey",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientCertificate.passphrase", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientCertificate.passphrase",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientCertificate.sslCertificate", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientCertificate.sslCertificate",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes an auth config.</summary>
                /// <param name="name">Required. The name that is associated with the AuthConfig.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes an auth config.</summary>
                public class DeleteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name that is associated with the AuthConfig.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/authConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a complete auth config. If the auth config doesn't exist, Code.NOT_FOUND exception will be
                /// thrown. Returns the decrypted auth config.
                /// </summary>
                /// <param name="name">Required. The name that is associated with the AuthConfig.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets a complete auth config. If the auth config doesn't exist, Code.NOT_FOUND exception will be
                /// thrown. Returns the decrypted auth config.
                /// </summary>
                public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name that is associated with the AuthConfig.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/authConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all auth configs that match the filter. Restrict to auth configs belong to the current client
                /// only.
                /// </summary>
                /// <param name="parent">Required. The client, which owns this collection of AuthConfigs.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists all auth configs that match the filter. Restrict to auth configs belong to the current client
                /// only.
                /// </summary>
                public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListAuthConfigsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The client, which owns this collection of AuthConfigs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filtering as supported in
                    /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The size of entries in the response. If unspecified, defaults to 100.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The token returned in the previous response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// The mask which specifies fields that need to be returned in the AuthConfig's response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadMask { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/authConfigs";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates an auth config. If credential is updated, fetch the encrypted auth config from Spanner,
                /// decrypt with Cloud KMS key, update the credential fields, re-encrypt with Cloud KMS key and update
                /// the Spanner record. For other fields, directly update the Spanner record. Returns the encrypted auth
                /// config.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Resource name of the SFDC instance projects/{project}/locations/{location}/authConfigs/{authConfig}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates an auth config. If credential is updated, fetch the encrypted auth config from Spanner,
                /// decrypt with Cloud KMS key, update the credential fields, re-encrypt with Cloud KMS key and update
                /// the Spanner record. For other fields, directly update the Spanner record. Returns the encrypted auth
                /// config.
                /// </summary>
                public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Resource name of the SFDC instance
                    /// projects/{project}/locations/{location}/authConfigs/{authConfig}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The ssl certificate encoded in PEM format. This string must include the begin header and end
                    /// footer lines. For example, -----BEGIN CERTIFICATE-----
                    /// MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
                    /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
                    /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
                    /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
                    /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
                    /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
                    /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
                    /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
                    /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
                    /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
                    /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
                    /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg=
                    /// -----END CERTIFICATE-----
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientCertificate.encryptedPrivateKey", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientCertificateEncryptedPrivateKey { get; set; }

                    /// <summary>
                    /// 'passphrase' should be left unset if private key is not encrypted. Note that 'passphrase' is not
                    /// the password for web server, but an extra layer of security to protected private key.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientCertificate.passphrase", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientCertificatePassphrase { get; set; }

                    /// <summary>
                    /// The ssl certificate encoded in PEM format. This string must include the begin header and end
                    /// footer lines. For example, -----BEGIN CERTIFICATE-----
                    /// MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
                    /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
                    /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
                    /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
                    /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
                    /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
                    /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
                    /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
                    /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
                    /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
                    /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
                    /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg=
                    /// -----END CERTIFICATE-----
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clientCertificate.sslCertificate", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClientCertificateSslCertificate { get; set; }

                    /// <summary>
                    /// Field mask specifying the fields in the above AuthConfig that have been modified and need to be
                    /// updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/authConfigs/[^/]+$",
                        });
                        RequestParameters.Add("clientCertificate.encryptedPrivateKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientCertificate.encryptedPrivateKey",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientCertificate.passphrase", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientCertificate.passphrase",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clientCertificate.sslCertificate", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clientCertificate.sslCertificate",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Certificates resource.</summary>
            public virtual CertificatesResource Certificates { get; }

            /// <summary>The "certificates" collection of methods.</summary>
            public class CertificatesResource
            {
                private const string Resource = "certificates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CertificatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get a certificates in the specified project.</summary>
                /// <param name="name">
                /// Required. The certificate to retrieve. Format:
                /// projects/{project}/locations/{location}/certificates/{certificate}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get a certificates in the specified project.</summary>
                public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The certificate to retrieve. Format:
                    /// projects/{project}/locations/{location}/certificates/{certificate}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/certificates/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Connections resource.</summary>
            public virtual ConnectionsResource Connections { get; }

            /// <summary>The "connections" collection of methods.</summary>
            public class ConnectionsResource
            {
                private const string Resource = "connections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConnectionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    RuntimeActionSchemas = new RuntimeActionSchemasResource(service);
                    RuntimeEntitySchemas = new RuntimeEntitySchemasResource(service);
                }

                /// <summary>Gets the RuntimeActionSchemas resource.</summary>
                public virtual RuntimeActionSchemasResource RuntimeActionSchemas { get; }

                /// <summary>The "runtimeActionSchemas" collection of methods.</summary>
                public class RuntimeActionSchemasResource
                {
                    private const string Resource = "runtimeActionSchemas";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RuntimeActionSchemasResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists the JSON schemas for the inputs and outputs of actions, filtered by action name.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. Parent resource of RuntimeActionSchema. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists the JSON schemas for the inputs and outputs of actions, filtered by action name.
                    /// </summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListRuntimeActionSchemasResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of RuntimeActionSchema. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filter. Only the action field with literal equality operator is supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/runtimeActionSchemas";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the RuntimeEntitySchemas resource.</summary>
                public virtual RuntimeEntitySchemasResource RuntimeEntitySchemas { get; }

                /// <summary>The "runtimeEntitySchemas" collection of methods.</summary>
                public class RuntimeEntitySchemasResource
                {
                    private const string Resource = "runtimeEntitySchemas";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RuntimeEntitySchemasResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists the JSON schemas for the properties of runtime entities, filtered by entity name.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. Parent resource of RuntimeEntitySchema. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists the JSON schemas for the properties of runtime entities, filtered by entity name.
                    /// </summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListRuntimeEntitySchemasResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of RuntimeEntitySchema. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filter. Only the entity field with literal equality operator is supported.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/runtimeEntitySchemas";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Lists the available entities and actions associated with a Connection.</summary>
                /// <param name="name">
                /// Required. ConnectionSchemaMetadata name. Format:
                /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                /// </param>
                public virtual GetConnectionSchemaMetadataRequest GetConnectionSchemaMetadata(string name)
                {
                    return new GetConnectionSchemaMetadataRequest(service, name);
                }

                /// <summary>Lists the available entities and actions associated with a Connection.</summary>
                public class GetConnectionSchemaMetadataRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaConnectionSchemaMetadata>
                {
                    /// <summary>Constructs a new GetConnectionSchemaMetadata request.</summary>
                    public GetConnectionSchemaMetadataRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. ConnectionSchemaMetadata name. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getConnectionSchemaMetadata";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes GetConnectionSchemaMetadata parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/connectionSchemaMetadata$",
                        });
                    }
                }

                /// <summary>Lists Connections in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent resource of the Connection, of the form: `projects/*/locations/*`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists Connections in a given project and location.</summary>
                public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListConnectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the Connection, of the form: `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order by parameters.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/connections";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Integrations resource.</summary>
            public virtual IntegrationsResource Integrations { get; }

            /// <summary>The "integrations" collection of methods.</summary>
            public class IntegrationsResource
            {
                private const string Resource = "integrations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IntegrationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Executions = new ExecutionsResource(service);
                    Versions = new VersionsResource(service);
                }

                /// <summary>Gets the Executions resource.</summary>
                public virtual ExecutionsResource Executions { get; }

                /// <summary>The "executions" collection of methods.</summary>
                public class ExecutionsResource
                {
                    private const string Resource = "executions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExecutionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists the status of the integration executions.</summary>
                    /// <param name="parent">Required. The parent resource name of the integration execution.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the status of the integration executions.</summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListExecutionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource name of the integration execution.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Standard filter field, we support filtering on all fields in
                        /// EventExecutionParamIndexes table. All fields support for EQUALS, in additional:
                        /// CreateTimestamp support for LESS_THAN, GREATER_THAN ParameterKey, ParameterValue,
                        /// ParameterType support for HAS For example: "parameter_value" HAS \"parameter1\" Also
                        /// supports operators like AND, OR, NOT For example, trigger_id=\"id1\" AND
                        /// event_execution_state=\"FAILED\"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional user-provided custom filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.customFilter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FilterParamsCustomFilter { get; set; }

                        /// <summary>End timestamp.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.endTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<long> FilterParamsEndTime { get; set; }

                        /// <summary>List of possible event statuses.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.eventStatuses", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<string> FilterParamsEventStatuses { get; set; }

                        /// <summary>Execution id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.executionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FilterParamsExecutionId { get; set; }

                        /// <summary>Param key. DEPRECATED. User parameter_pair_key instead.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterKey", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FilterParamsParameterKey { get; set; }

                        /// <summary>Param key in the key value pair filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterPairKey", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FilterParamsParameterPairKey { get; set; }

                        /// <summary>Param value in the key value pair filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterPairValue", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FilterParamsParameterPairValue { get; set; }

                        /// <summary>Param type.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FilterParamsParameterType { get; set; }

                        /// <summary>Param value. DEPRECATED. User parameter_pair_value instead.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterValue", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FilterParamsParameterValue { get; set; }

                        /// <summary>Start timestamp.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.startTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<long> FilterParamsStartTime { get; set; }

                        /// <summary>List of possible task statuses.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.taskStatuses", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<string> FilterParamsTaskStatuses { get; set; }

                        /// <summary>Workflow name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filterParams.workflowName", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FilterParamsWorkflowName { get; set; }

                        /// <summary>
                        /// Optional. The results would be returned in order you specified here. Currently supporting
                        /// "last_modified_time" and "create_time".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>Optional. The size of entries in the response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. The token returned in the previous response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. View mask for the response data. If set, only the field specified will be returned
                        /// as part of the result. If not set, all fields in event execution info will be filled and
                        /// returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object ReadMask { get; set; }

                        /// <summary>
                        /// Optional. If true, the service will use the most recent acl information to list event
                        /// execution infos and renew the acl cache. Note that fetching the most recent acl is
                        /// synchronous, so it will increase RPC call latency.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("refreshAcl", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> RefreshAcl { get; set; }

                        /// <summary>
                        /// Optional. If true, the service will truncate the params to only keep the first 1000
                        /// characters of string params and empty the executions in order to make response smaller. Only
                        /// works for UI and when the params fields are not filtered out.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("truncateParams", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> TruncateParams { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/executions";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.customFilter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.customFilter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.endTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.endTime",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.eventStatuses", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.eventStatuses",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.executionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.executionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.parameterKey", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.parameterKey",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.parameterPairKey", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.parameterPairKey",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.parameterPairValue", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.parameterPairValue",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.parameterType", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.parameterType",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.parameterValue", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.parameterValue",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.startTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.startTime",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.taskStatuses", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.taskStatuses",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filterParams.workflowName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filterParams.workflowName",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                            {
                                Name = "orderBy",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "readMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("refreshAcl", new Google.Apis.Discovery.Parameter
                            {
                                Name = "refreshAcl",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("truncateParams", new Google.Apis.Discovery.Parameter
                            {
                                Name = "truncateParams",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Versions resource.</summary>
                public virtual VersionsResource Versions { get; }

                /// <summary>The "versions" collection of methods.</summary>
                public class VersionsResource
                {
                    private const string Resource = "versions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public VersionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Soft-deletes the integration. Changes the status of the integration to ARCHIVED. If the
                    /// integration being ARCHIVED is tagged as "HEAD", the tag is removed from this snapshot and set to
                    /// the previous non-ARCHIVED snapshot. The PUBLISH_REQUESTED, DUE_FOR_DELETION tags are removed
                    /// too. This RPC throws an exception if the version being archived is DRAFT, and if the `locked_by`
                    /// user is not the same as the user performing the Archive. Audit fields updated include
                    /// last_modified_timestamp, last_modified_by. Any existing lock is released when Archiving a
                    /// integration. Currently, there is no unarchive mechanism.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The version to archive. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                    /// </param>
                    public virtual ArchiveRequest Archive(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionRequest body, string name)
                    {
                        return new ArchiveRequest(service, body, name);
                    }

                    /// <summary>
                    /// Soft-deletes the integration. Changes the status of the integration to ARCHIVED. If the
                    /// integration being ARCHIVED is tagged as "HEAD", the tag is removed from this snapshot and set to
                    /// the previous non-ARCHIVED snapshot. The PUBLISH_REQUESTED, DUE_FOR_DELETION tags are removed
                    /// too. This RPC throws an exception if the version being archived is DRAFT, and if the `locked_by`
                    /// user is not the same as the user performing the Archive. Audit fields updated include
                    /// last_modified_timestamp, last_modified_by. Any existing lock is released when Archiving a
                    /// integration. Currently, there is no unarchive mechanism.
                    /// </summary>
                    public class ArchiveRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionResponse>
                    {
                        /// <summary>Constructs a new Archive request.</summary>
                        public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The version to archive. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "archive";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:archive";

                        /// <summary>Initializes Archive parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Create a integration with a draft version in the specified project.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource where this version will be created. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Create a integration with a draft version in the specified project.</summary>
                    public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this version will be created. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Set this flag to true, if draft version is to be created for a brand new integration. False,
                        /// if the request is for an existing integration. For backward compatibility reasons, even if
                        /// this flag is set to `false` and no existing integration is found, a new draft integration
                        /// will still be created.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("newIntegration", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> NewIntegration { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/versions";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+$",
                            });
                            RequestParameters.Add("newIntegration", new Google.Apis.Discovery.Parameter
                            {
                                Name = "newIntegration",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the status of the ACTIVE integration to SNAPSHOT with a new tag "PREVIOUSLY_PUBLISHED"
                    /// after validating it. The "HEAD" and "PUBLISH_REQUESTED" tags do not change. This RPC throws an
                    /// exception if the version being snapshot is not ACTIVE. Audit fields added include action,
                    /// action_by, action_timestamp.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The version to deactivate. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                    /// </param>
                    public virtual DeactivateRequest Deactivate(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionRequest body, string name)
                    {
                        return new DeactivateRequest(service, body, name);
                    }

                    /// <summary>
                    /// Sets the status of the ACTIVE integration to SNAPSHOT with a new tag "PREVIOUSLY_PUBLISHED"
                    /// after validating it. The "HEAD" and "PUBLISH_REQUESTED" tags do not change. This RPC throws an
                    /// exception if the version being snapshot is not ACTIVE. Audit fields added include action,
                    /// action_by, action_timestamp.
                    /// </summary>
                    public class DeactivateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionResponse>
                    {
                        /// <summary>Constructs a new Deactivate request.</summary>
                        public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The version to deactivate. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "deactivate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:deactivate";

                        /// <summary>Initializes Deactivate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Get a integration in the specified project.</summary>
                    /// <param name="name">
                    /// Required. The version to retrieve. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get a integration in the specified project.</summary>
                    public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The version to retrieve. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the list of all integration versions in the specified project.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource where this version will be created. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration} Specifically, when parent
                    /// equals: 1. projects//locations//integrations/, Meaning: "List versions (with filter) for a
                    /// particular integration". 2. projects//locations//integrations/- Meaning: "List versions (with
                    /// filter) for a client within a particular region". 3. projects//locations/-/integrations/-
                    /// Meaning: "List versions (with filter) for a client".
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of all integration versions in the specified project.</summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListIntegrationVersionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this version will be created. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration} Specifically, when parent
                        /// equals: 1. projects//locations//integrations/, Meaning: "List versions (with filter) for a
                        /// particular integration". 2. projects//locations//integrations/- Meaning: "List versions
                        /// (with filter) for a client within a particular region". 3.
                        /// projects//locations/-/integrations/- Meaning: "List versions (with filter) for a client".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The field mask which specifies the particular data to be returned.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object FieldMask { get; set; }

                        /// <summary>
                        /// Filter on fields of IntegrationVersion. Fields can be compared with literal values by use of
                        /// ":" (containment), "=" (equality), "&amp;gt;" (greater), "&amp;lt;" (less than), &amp;gt;="
                        /// (greater than or equal to), "&amp;lt;=" (less than or equal to), and "!=" (inequality)
                        /// operators. Negation, conjunction, and disjunction are written using NOT, AND, and OR
                        /// keywords. For example, organization_id=\"1\" AND state=ACTIVE AND description:"test".
                        /// Filtering cannot be performed on repeated fields like `task_config`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// The results would be returned in order you specified here. Currently supported sort keys
                        /// are: Descending sort order for "last_modified_time", "created_time", "snapshot_number"
                        /// Ascending sort order for "name".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// The maximum number of versions to return. The service may return fewer than this value. If
                        /// unspecified, at most 50 versions will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListIntegrationVersions` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListIntegrationVersions` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/versions";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+$",
                            });
                            RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fieldMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                            {
                                Name = "orderBy",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Update a integration with a draft version in the specified project.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Output only. Auto-generated primary key.</param>
                    public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Update a integration with a draft version in the specified project.</summary>
                    public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Output only. Auto-generated primary key.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Field mask specifying the fields in the above integration that have been modified and need
                        /// to be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+/versions/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// This RPC throws an exception if the integration is in ARCHIVED or ACTIVE state. This RPC throws
                    /// an exception if the version being published is DRAFT, and if the `locked_by` user is not the
                    /// same as the user performing the Publish. Audit fields updated include last_published_timestamp,
                    /// last_published_by, last_modified_timestamp, last_modified_by. Any existing lock is on this
                    /// integration is released.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The version to publish. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                    /// </param>
                    public virtual PublishRequest Publish(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaPublishIntegrationVersionRequest body, string name)
                    {
                        return new PublishRequest(service, body, name);
                    }

                    /// <summary>
                    /// This RPC throws an exception if the integration is in ARCHIVED or ACTIVE state. This RPC throws
                    /// an exception if the version being published is DRAFT, and if the `locked_by` user is not the
                    /// same as the user performing the Publish. Audit fields updated include last_published_timestamp,
                    /// last_published_by, last_modified_timestamp, last_modified_by. Any existing lock is on this
                    /// integration is released.
                    /// </summary>
                    public class PublishRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaPublishIntegrationVersionResponse>
                    {
                        /// <summary>Constructs a new Publish request.</summary>
                        public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaPublishIntegrationVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The version to publish. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaPublishIntegrationVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "publish";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:publish";

                        /// <summary>Initializes Publish parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Clears the `locked_by` and `locked_at_timestamp`in the DRAFT version of this integration. It
                    /// then performs the same action as the CreateDraftIntegrationVersion (i.e., copies the DRAFT
                    /// version of the integration as a SNAPSHOT and then creates a new DRAFT version with the
                    /// `locked_by` set to the `user_taking_over` and the `locked_at_timestamp` set to the current
                    /// timestamp). Both the `locked_by` and `user_taking_over` are notified via email about the
                    /// takeover. This RPC throws an exception if the integration is not in DRAFT status or if the
                    /// `locked_by` and `locked_at_timestamp` fields are not set.The TakeoverEdit lock is treated the
                    /// same as an edit of the integration, and hence shares ACLs with edit. Audit fields updated
                    /// include last_modified_timestamp, last_modified_by.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="integrationVersion">
                    /// Required. The version to take over edit lock. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                    /// </param>
                    public virtual TakeoverEditLockRequest TakeoverEditLock(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaTakeoverEditLockRequest body, string integrationVersion)
                    {
                        return new TakeoverEditLockRequest(service, body, integrationVersion);
                    }

                    /// <summary>
                    /// Clears the `locked_by` and `locked_at_timestamp`in the DRAFT version of this integration. It
                    /// then performs the same action as the CreateDraftIntegrationVersion (i.e., copies the DRAFT
                    /// version of the integration as a SNAPSHOT and then creates a new DRAFT version with the
                    /// `locked_by` set to the `user_taking_over` and the `locked_at_timestamp` set to the current
                    /// timestamp). Both the `locked_by` and `user_taking_over` are notified via email about the
                    /// takeover. This RPC throws an exception if the integration is not in DRAFT status or if the
                    /// `locked_by` and `locked_at_timestamp` fields are not set.The TakeoverEdit lock is treated the
                    /// same as an edit of the integration, and hence shares ACLs with edit. Audit fields updated
                    /// include last_modified_timestamp, last_modified_by.
                    /// </summary>
                    public class TakeoverEditLockRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaTakeoverEditLockResponse>
                    {
                        /// <summary>Constructs a new TakeoverEditLock request.</summary>
                        public TakeoverEditLockRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaTakeoverEditLockRequest body, string integrationVersion) : base(service)
                        {
                            IntegrationVersion = integrationVersion;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The version to take over edit lock. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("integrationVersion", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string IntegrationVersion { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaTakeoverEditLockRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "takeoverEditLock";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+integrationVersion}:takeoverEditLock";

                        /// <summary>Initializes TakeoverEditLock parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("integrationVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "integrationVersion",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Validates the given integration. If the id doesn't exist, a NotFoundException is thrown. If
                    /// validation fails a CanonicalCodeException is thrown. If there was no failure an empty response
                    /// is returned.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The version to validate. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                    /// </param>
                    public virtual ValidateRequest Validate(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaValidateIntegrationVersionRequest body, string name)
                    {
                        return new ValidateRequest(service, body, name);
                    }

                    /// <summary>
                    /// Validates the given integration. If the id doesn't exist, a NotFoundException is thrown. If
                    /// validation fails a CanonicalCodeException is thrown. If there was no failure an empty response
                    /// is returned.
                    /// </summary>
                    public class ValidateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaValidateIntegrationVersionResponse>
                    {
                        /// <summary>Constructs a new Validate request.</summary>
                        public ValidateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaValidateIntegrationVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The version to validate. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaValidateIntegrationVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "validate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:validate";

                        /// <summary>Initializes Validate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+/versions/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Executes integrations synchronously by passing the trigger id in the request body. The request is
                /// not returned until the requested executions are either fulfilled or experienced an error. If the
                /// integration name is not specified (passing `-`), all of the associated integration under the given
                /// trigger_id will be executed. Otherwise only the specified integration for the given `trigger_id` is
                /// executed. This is helpful for execution the integration from UI.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The integration resource name.</param>
                public virtual ExecuteRequest Execute(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecuteIntegrationsRequest body, string name)
                {
                    return new ExecuteRequest(service, body, name);
                }

                /// <summary>
                /// Executes integrations synchronously by passing the trigger id in the request body. The request is
                /// not returned until the requested executions are either fulfilled or experienced an error. If the
                /// integration name is not specified (passing `-`), all of the associated integration under the given
                /// trigger_id will be executed. Otherwise only the specified integration for the given `trigger_id` is
                /// executed. This is helpful for execution the integration from UI.
                /// </summary>
                public class ExecuteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecuteIntegrationsResponse>
                {
                    /// <summary>Constructs a new Execute request.</summary>
                    public ExecuteRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecuteIntegrationsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The integration resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecuteIntegrationsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "execute";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:execute";

                    /// <summary>Initializes Execute parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+$",
                        });
                    }
                }

                /// <summary>Returns the list of all integrations in the specified project.</summary>
                /// <param name="parent">
                /// Required. Project and location from which the integrations should be listed. Format:
                /// projects/{project}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns the list of all integrations in the specified project.</summary>
                public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListIntegrationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Project and location from which the integrations should be listed. Format:
                    /// projects/{project}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filter on fields of IntegrationVersion. Fields can be compared with literal values by use of ":"
                    /// (containment), "=" (equality), "&amp;gt;" (greater), "&amp;lt;" (less than), &amp;gt;=" (greater
                    /// than or equal to), "&amp;lt;=" (less than or equal to), and "!=" (inequality) operators.
                    /// Negation, conjunction, and disjunction are written using NOT, AND, and OR keywords. For example,
                    /// organization_id=\"1\" AND state=ACTIVE AND description:"test". Filtering cannot be performed on
                    /// repeated fields like `task_config`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The results would be returned in order you specified here. Supported sort keys are: Descending
                    /// sort order by "last_modified_time", "created_time", "snapshot_number". Ascending sort order by
                    /// the integration name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The page size for the resquest.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The page token for the resquest.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/integrations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Get execution stats</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The parent resource name: {parent=projects/*/locations/*}.</param>
                public virtual MonitorexecutionstatsRequest Monitorexecutionstats(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequest body, string parent)
                {
                    return new MonitorexecutionstatsRequest(service, body, parent);
                }

                /// <summary>Get execution stats</summary>
                public class MonitorexecutionstatsRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaMonitorExecutionStatsResponse>
                {
                    /// <summary>Constructs a new Monitorexecutionstats request.</summary>
                    public MonitorexecutionstatsRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource name: {parent=projects/*/locations/*}.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "monitorexecutionstats";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}:monitorexecutionstats";

                    /// <summary>Initializes Monitorexecutionstats parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Schedules an integration for execution by passing the trigger id and the scheduled time in the
                /// request body.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The integration resource name.</param>
                public virtual ScheduleRequest Schedule(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaScheduleIntegrationsRequest body, string name)
                {
                    return new ScheduleRequest(service, body, name);
                }

                /// <summary>
                /// Schedules an integration for execution by passing the trigger id and the scheduled time in the
                /// request body.
                /// </summary>
                public class ScheduleRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaScheduleIntegrationsResponse>
                {
                    /// <summary>Constructs a new Schedule request.</summary>
                    public ScheduleRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaScheduleIntegrationsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The integration resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaScheduleIntegrationsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "schedule";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:schedule";

                    /// <summary>Initializes Schedule parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/integrations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Products resource.</summary>
            public virtual ProductsResource Products { get; }

            /// <summary>The "products" collection of methods.</summary>
            public class ProductsResource
            {
                private const string Resource = "products";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ProductsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    AuthConfigs = new AuthConfigsResource(service);
                    Certificates = new CertificatesResource(service);
                    Integrations = new IntegrationsResource(service);
                    Integrationtemplates = new IntegrationtemplatesResource(service);
                    SfdcInstances = new SfdcInstancesResource(service);
                }

                /// <summary>Gets the AuthConfigs resource.</summary>
                public virtual AuthConfigsResource AuthConfigs { get; }

                /// <summary>The "authConfigs" collection of methods.</summary>
                public class AuthConfigsResource
                {
                    private const string Resource = "authConfigs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AuthConfigsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates an auth config record. Fetch corresponding credentials for specific auth types, e.g.
                    /// access token for OAuth 2.0, JWT token for JWT. Encrypt the auth config with Cloud KMS and store
                    /// the encrypted credentials in Spanner. Returns the encrypted auth config.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. "projects/{project}/locations/{location}" format.</param>
                    public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates an auth config record. Fetch corresponding credentials for specific auth types, e.g.
                    /// access token for OAuth 2.0, JWT token for JWT. Encrypt the auth config with Cloud KMS and store
                    /// the encrypted credentials in Spanner. Returns the encrypted auth config.
                    /// </summary>
                    public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. "projects/{project}/locations/{location}" format.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The ssl certificate encoded in PEM format. This string must include the begin header and end
                        /// footer lines. For example, -----BEGIN CERTIFICATE-----
                        /// MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
                        /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
                        /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
                        /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
                        /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
                        /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
                        /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
                        /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
                        /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
                        /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
                        /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
                        /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg=
                        /// -----END CERTIFICATE-----
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clientCertificate.encryptedPrivateKey", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClientCertificateEncryptedPrivateKey { get; set; }

                        /// <summary>
                        /// 'passphrase' should be left unset if private key is not encrypted. Note that 'passphrase' is
                        /// not the password for web server, but an extra layer of security to protected private key.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clientCertificate.passphrase", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClientCertificatePassphrase { get; set; }

                        /// <summary>
                        /// The ssl certificate encoded in PEM format. This string must include the begin header and end
                        /// footer lines. For example, -----BEGIN CERTIFICATE-----
                        /// MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
                        /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
                        /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
                        /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
                        /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
                        /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
                        /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
                        /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
                        /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
                        /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
                        /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
                        /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg=
                        /// -----END CERTIFICATE-----
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clientCertificate.sslCertificate", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClientCertificateSslCertificate { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/authConfigs";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                            });
                            RequestParameters.Add("clientCertificate.encryptedPrivateKey", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clientCertificate.encryptedPrivateKey",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clientCertificate.passphrase", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clientCertificate.passphrase",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clientCertificate.sslCertificate", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clientCertificate.sslCertificate",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes an auth config.</summary>
                    /// <param name="name">Required. The name that is associated with the AuthConfig.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an auth config.</summary>
                    public class DeleteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name that is associated with the AuthConfig.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/authConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets a complete auth config. If the auth config doesn't exist, Code.NOT_FOUND exception will be
                    /// thrown. Returns the decrypted auth config.
                    /// </summary>
                    /// <param name="name">Required. The name that is associated with the AuthConfig.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets a complete auth config. If the auth config doesn't exist, Code.NOT_FOUND exception will be
                    /// thrown. Returns the decrypted auth config.
                    /// </summary>
                    public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name that is associated with the AuthConfig.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/authConfigs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists all auth configs that match the filter. Restrict to auth configs belong to the current
                    /// client only.
                    /// </summary>
                    /// <param name="parent">Required. The client, which owns this collection of AuthConfigs.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists all auth configs that match the filter. Restrict to auth configs belong to the current
                    /// client only.
                    /// </summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListAuthConfigsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The client, which owns this collection of AuthConfigs.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filtering as supported in
                        /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The size of entries in the response. If unspecified, defaults to 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The token returned in the previous response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// The mask which specifies fields that need to be returned in the AuthConfig's response.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object ReadMask { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/authConfigs";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "readMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Updates an auth config. If credential is updated, fetch the encrypted auth config from Spanner,
                    /// decrypt with Cloud KMS key, update the credential fields, re-encrypt with Cloud KMS key and
                    /// update the Spanner record. For other fields, directly update the Spanner record. Returns the
                    /// encrypted auth config.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Resource name of the SFDC instance
                    /// projects/{project}/locations/{location}/authConfigs/{authConfig}.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates an auth config. If credential is updated, fetch the encrypted auth config from Spanner,
                    /// decrypt with Cloud KMS key, update the credential fields, re-encrypt with Cloud KMS key and
                    /// update the Spanner record. For other fields, directly update the Spanner record. Returns the
                    /// encrypted auth config.
                    /// </summary>
                    public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Resource name of the SFDC instance
                        /// projects/{project}/locations/{location}/authConfigs/{authConfig}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The ssl certificate encoded in PEM format. This string must include the begin header and end
                        /// footer lines. For example, -----BEGIN CERTIFICATE-----
                        /// MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
                        /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
                        /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
                        /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
                        /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
                        /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
                        /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
                        /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
                        /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
                        /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
                        /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
                        /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg=
                        /// -----END CERTIFICATE-----
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clientCertificate.encryptedPrivateKey", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClientCertificateEncryptedPrivateKey { get; set; }

                        /// <summary>
                        /// 'passphrase' should be left unset if private key is not encrypted. Note that 'passphrase' is
                        /// not the password for web server, but an extra layer of security to protected private key.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clientCertificate.passphrase", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClientCertificatePassphrase { get; set; }

                        /// <summary>
                        /// The ssl certificate encoded in PEM format. This string must include the begin header and end
                        /// footer lines. For example, -----BEGIN CERTIFICATE-----
                        /// MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
                        /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
                        /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
                        /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
                        /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
                        /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
                        /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
                        /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
                        /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
                        /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
                        /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
                        /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg=
                        /// -----END CERTIFICATE-----
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clientCertificate.sslCertificate", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClientCertificateSslCertificate { get; set; }

                        /// <summary>
                        /// Field mask specifying the fields in the above AuthConfig that have been modified and need to
                        /// be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaAuthConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/authConfigs/[^/]+$",
                            });
                            RequestParameters.Add("clientCertificate.encryptedPrivateKey", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clientCertificate.encryptedPrivateKey",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clientCertificate.passphrase", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clientCertificate.passphrase",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clientCertificate.sslCertificate", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clientCertificate.sslCertificate",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Certificates resource.</summary>
                public virtual CertificatesResource Certificates { get; }

                /// <summary>The "certificates" collection of methods.</summary>
                public class CertificatesResource
                {
                    private const string Resource = "certificates";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CertificatesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new certificate. The certificate will be registered to the trawler service and will be
                    /// encrypted using cloud KMS and stored in Spanner Returns the certificate.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. "projects/{project}/locations/{location}" format.</param>
                    public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new certificate. The certificate will be registered to the trawler service and will be
                    /// encrypted using cloud KMS and stored in Spanner Returns the certificate.
                    /// </summary>
                    public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. "projects/{project}/locations/{location}" format.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/certificates";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Delete a certificate</summary>
                    /// <param name="name">Required. The name that is associated with the Certificate.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Delete a certificate</summary>
                    public class DeleteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name that is associated with the Certificate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/certificates/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Get a certificates in the specified project.</summary>
                    /// <param name="name">
                    /// Required. The certificate to retrieve. Format:
                    /// projects/{project}/locations/{location}/certificates/{certificate}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get a certificates in the specified project.</summary>
                    public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The certificate to retrieve. Format:
                        /// projects/{project}/locations/{location}/certificates/{certificate}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/certificates/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// List all the certificates that match the filter. Restrict to certificate of current client only.
                    /// </summary>
                    /// <param name="parent">Required. The client, which owns this collection of Certificates.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// List all the certificates that match the filter. Restrict to certificate of current client only.
                    /// </summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListCertificatesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The client, which owns this collection of Certificates.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filtering as supported in
                        /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The size of entries in the response. If unspecified, defaults to 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The token returned in the previous response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// The mask which specifies fields that need to be returned in the Certificate's response.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object ReadMask { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/certificates";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "readMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Updates the certificate by id. If new certificate file is updated, it will register with the
                    /// trawler service, re-encrypt with cloud KMS and update the Spanner record. Other fields will
                    /// directly update the Spanner record. Returns the Certificate.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Output only. Auto generated primary key</param>
                    public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates the certificate by id. If new certificate file is updated, it will register with the
                    /// trawler service, re-encrypt with cloud KMS and update the Spanner record. Other fields will
                    /// directly update the Spanner record. Returns the Certificate.
                    /// </summary>
                    public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Output only. Auto generated primary key</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Field mask specifying the fields in the above Certificate that have been modified and need
                        /// to be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCertificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/certificates/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Integrations resource.</summary>
                public virtual IntegrationsResource Integrations { get; }

                /// <summary>The "integrations" collection of methods.</summary>
                public class IntegrationsResource
                {
                    private const string Resource = "integrations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public IntegrationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Executions = new ExecutionsResource(service);
                        Executionsnapshots = new ExecutionsnapshotsResource(service);
                        Versions = new VersionsResource(service);
                    }

                    /// <summary>Gets the Executions resource.</summary>
                    public virtual ExecutionsResource Executions { get; }

                    /// <summary>The "executions" collection of methods.</summary>
                    public class ExecutionsResource
                    {
                        private const string Resource = "executions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ExecutionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Suspensions = new SuspensionsResource(service);
                        }

                        /// <summary>Gets the Suspensions resource.</summary>
                        public virtual SuspensionsResource Suspensions { get; }

                        /// <summary>The "suspensions" collection of methods.</summary>
                        public class SuspensionsResource
                        {
                            private const string Resource = "suspensions";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public SuspensionsResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;
                            }

                            /// <summary>
                            /// * Lifts suspension for advanced suspension task. Fetch corresponding suspension with
                            /// provided suspension Id, resolve suspension, and set up suspension result for the
                            /// Suspension Task.
                            /// </summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="name">
                            /// Required. The resource that the suspension belongs to.
                            /// "projects/{project}/locations/{location}/products/{product}/integrations/{integration}/executions/{execution}/suspensions/{suspenion}"
                            /// format.
                            /// </param>
                            public virtual LiftRequest Lift(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaLiftSuspensionRequest body, string name)
                            {
                                return new LiftRequest(service, body, name);
                            }

                            /// <summary>
                            /// * Lifts suspension for advanced suspension task. Fetch corresponding suspension with
                            /// provided suspension Id, resolve suspension, and set up suspension result for the
                            /// Suspension Task.
                            /// </summary>
                            public class LiftRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaLiftSuspensionResponse>
                            {
                                /// <summary>Constructs a new Lift request.</summary>
                                public LiftRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaLiftSuspensionRequest body, string name) : base(service)
                                {
                                    Name = name;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. The resource that the suspension belongs to.
                                /// "projects/{project}/locations/{location}/products/{product}/integrations/{integration}/executions/{execution}/suspensions/{suspenion}"
                                /// format.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaLiftSuspensionRequest Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "lift";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1alpha/{+name}:lift";

                                /// <summary>Initializes Lift parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "name",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/executions/[^/]+/suspensions/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// * Lists suspensions associated with a specific execution. Only those with permissions to
                            /// resolve the relevant suspensions will be able to view them.
                            /// </summary>
                            /// <param name="parent">
                            /// Required.
                            /// projects/{gcp_project_id}/locations/{location}/products/{product}/integrations/{integration_name}/executions/{execution_name}
                            /// </param>
                            public virtual ListRequest List(string parent)
                            {
                                return new ListRequest(service, parent);
                            }

                            /// <summary>
                            /// * Lists suspensions associated with a specific execution. Only those with permissions to
                            /// resolve the relevant suspensions will be able to view them.
                            /// </summary>
                            public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListSuspensionsResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                                {
                                    Parent = parent;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required.
                                /// projects/{gcp_project_id}/locations/{location}/products/{product}/integrations/{integration_name}/executions/{execution_name}
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>Standard filter field.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string Filter { get; set; }

                                /// <summary>Field name to order by.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string OrderBy { get; set; }

                                /// <summary>Maximum number of entries in the response.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>Token to retrieve a specific page.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1alpha/{+parent}/suspensions";

                                /// <summary>Initializes List parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "parent",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/executions/[^/]+$",
                                    });
                                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "filter",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "orderBy",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "pageSize",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "pageToken",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                                }
                            }

                            /// <summary>
                            /// * Resolves (lifts/rejects) any number of suspensions. If the integration is already
                            /// running, only the status of the suspension is updated. Otherwise, the suspended
                            /// integration will begin execution again.
                            /// </summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="name">
                            /// Required.
                            /// projects/{gcp_project_id}/locations/{location}/products/{product}/integrations/{integration_name}/executions/{execution_name}/suspensions/{suspension_id}
                            /// </param>
                            public virtual ResolveRequest Resolve(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaResolveSuspensionRequest body, string name)
                            {
                                return new ResolveRequest(service, body, name);
                            }

                            /// <summary>
                            /// * Resolves (lifts/rejects) any number of suspensions. If the integration is already
                            /// running, only the status of the suspension is updated. Otherwise, the suspended
                            /// integration will begin execution again.
                            /// </summary>
                            public class ResolveRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaResolveSuspensionResponse>
                            {
                                /// <summary>Constructs a new Resolve request.</summary>
                                public ResolveRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaResolveSuspensionRequest body, string name) : base(service)
                                {
                                    Name = name;
                                    Body = body;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required.
                                /// projects/{gcp_project_id}/locations/{location}/products/{product}/integrations/{integration_name}/executions/{execution_name}/suspensions/{suspension_id}
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaResolveSuspensionRequest Body { get; set; }

                                /// <summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "resolve";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1alpha/{+name}:resolve";

                                /// <summary>Initializes Resolve parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "name",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/executions/[^/]+/suspensions/[^/]+$",
                                    });
                                }
                            }
                        }

                        /// <summary>Cancellation of an execution</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The execution resource name. Format:
                        /// projects/{gcp_project_id}/locations/{location}/products/{product}/integrations/{integration_id}/executions/{execution_id}
                        /// </param>
                        public virtual CancelRequest Cancel(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCancelExecutionRequest body, string name)
                        {
                            return new CancelRequest(service, body, name);
                        }

                        /// <summary>Cancellation of an execution</summary>
                        public class CancelRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCancelExecutionResponse>
                        {
                            /// <summary>Constructs a new Cancel request.</summary>
                            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCancelExecutionRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The execution resource name. Format:
                            /// projects/{gcp_project_id}/locations/{location}/products/{product}/integrations/{integration_id}/executions/{execution_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCancelExecutionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "cancel";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}:cancel";

                            /// <summary>Initializes Cancel parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/executions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Get an execution in the specified project.</summary>
                        /// <param name="name">
                        /// Required. The execution resource name. Format:
                        /// projects/{gcp_project_id}/locations/{location}/products/{product}/integrations/{integration_id}/executions/{execution_id}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Get an execution in the specified project.</summary>
                        public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecution>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The execution resource name. Format:
                            /// projects/{gcp_project_id}/locations/{location}/products/{product}/integrations/{integration_id}/executions/{execution_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}";

                            /// <summary>Initializes Get parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/executions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists the status of the integration executions.</summary>
                        /// <param name="parent">
                        /// Required. The parent resource name of the integration execution.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists the status of the integration executions.</summary>
                        public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListExecutionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. The parent resource name of the integration execution.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Standard filter field, we support filtering on all fields in
                            /// EventExecutionParamIndexes table. All fields support for EQUALS, in additional:
                            /// CreateTimestamp support for LESS_THAN, GREATER_THAN ParameterKey, ParameterValue,
                            /// ParameterType support for HAS For example: "parameter_value" HAS \"parameter1\" Also
                            /// supports operators like AND, OR, NOT For example, trigger_id=\"id1\" AND
                            /// event_execution_state=\"FAILED\"
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Optional user-provided custom filter.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.customFilter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string FilterParamsCustomFilter { get; set; }

                            /// <summary>End timestamp.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.endTime", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<long> FilterParamsEndTime { get; set; }

                            /// <summary>List of possible event statuses.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.eventStatuses", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual Google.Apis.Util.Repeatable<string> FilterParamsEventStatuses { get; set; }

                            /// <summary>Execution id.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.executionId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string FilterParamsExecutionId { get; set; }

                            /// <summary>Param key. DEPRECATED. User parameter_pair_key instead.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterKey", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string FilterParamsParameterKey { get; set; }

                            /// <summary>Param key in the key value pair filter.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterPairKey", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string FilterParamsParameterPairKey { get; set; }

                            /// <summary>Param value in the key value pair filter.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterPairValue", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string FilterParamsParameterPairValue { get; set; }

                            /// <summary>Param type.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterType", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string FilterParamsParameterType { get; set; }

                            /// <summary>Param value. DEPRECATED. User parameter_pair_value instead.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.parameterValue", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string FilterParamsParameterValue { get; set; }

                            /// <summary>Start timestamp.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.startTime", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<long> FilterParamsStartTime { get; set; }

                            /// <summary>List of possible task statuses.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.taskStatuses", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual Google.Apis.Util.Repeatable<string> FilterParamsTaskStatuses { get; set; }

                            /// <summary>Workflow name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filterParams.workflowName", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string FilterParamsWorkflowName { get; set; }

                            /// <summary>
                            /// Optional. The results would be returned in order you specified here. Currently
                            /// supporting "last_modified_time" and "create_time".
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>Optional. The size of entries in the response.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>Optional. The token returned in the previous response.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// Optional. View mask for the response data. If set, only the field specified will be
                            /// returned as part of the result. If not set, all fields in event execution info will be
                            /// filled and returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object ReadMask { get; set; }

                            /// <summary>
                            /// Optional. If true, the service will use the most recent acl information to list event
                            /// execution infos and renew the acl cache. Note that fetching the most recent acl is
                            /// synchronous, so it will increase RPC call latency.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("refreshAcl", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> RefreshAcl { get; set; }

                            /// <summary>
                            /// Optional. If true, the service will truncate the params to only keep the first 1000
                            /// characters of string params and empty the executions in order to make response smaller.
                            /// Only works for UI and when the params fields are not filtered out.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("truncateParams", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> TruncateParams { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/executions";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.customFilter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.customFilter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.endTime", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.endTime",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.eventStatuses", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.eventStatuses",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.executionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.executionId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.parameterKey", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.parameterKey",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.parameterPairKey", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.parameterPairKey",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.parameterPairValue", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.parameterPairValue",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.parameterType", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.parameterType",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.parameterValue", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.parameterValue",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.startTime", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.startTime",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.taskStatuses", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.taskStatuses",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filterParams.workflowName", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filterParams.workflowName",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "orderBy",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "readMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("refreshAcl", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "refreshAcl",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("truncateParams", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "truncateParams",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>Gets the Executionsnapshots resource.</summary>
                    public virtual ExecutionsnapshotsResource Executionsnapshots { get; }

                    /// <summary>The "executionsnapshots" collection of methods.</summary>
                    public class ExecutionsnapshotsResource
                    {
                        private const string Resource = "executionsnapshots";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ExecutionsnapshotsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Lists the snapshots of a given integration executions. This RPC is not being used.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The parent resource name of the integration execution.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>
                        /// Lists the snapshots of a given integration executions. This RPC is not being used.
                        /// </summary>
                        public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListExecutionSnapshotsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. The parent resource name of the integration execution.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Currently supports filter by `execution_info_id` or `execution_snapshot_id`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>Number of entries to be returned in a page.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>The token used to retrieve the next page results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// View mask for the response data. If set, only the field specified will be returned as
                            /// part of the result. If not set, all fields in event execution snapshot will be filled
                            /// and returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object ReadMask { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/executionsnapshots";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "readMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>Gets the Versions resource.</summary>
                    public virtual VersionsResource Versions { get; }

                    /// <summary>The "versions" collection of methods.</summary>
                    public class VersionsResource
                    {
                        private const string Resource = "versions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public VersionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Soft-deletes the integration. Changes the status of the integration to ARCHIVED. If the
                        /// integration being ARCHIVED is tagged as "HEAD", the tag is removed from this snapshot and
                        /// set to the previous non-ARCHIVED snapshot. The PUBLISH_REQUESTED, DUE_FOR_DELETION tags are
                        /// removed too. This RPC throws an exception if the version being archived is DRAFT, and if the
                        /// `locked_by` user is not the same as the user performing the Archive. Audit fields updated
                        /// include last_modified_timestamp, last_modified_by. Any existing lock is released when
                        /// Archiving a integration. Currently, there is no unarchive mechanism.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The version to archive. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </param>
                        public virtual ArchiveRequest Archive(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionRequest body, string name)
                        {
                            return new ArchiveRequest(service, body, name);
                        }

                        /// <summary>
                        /// Soft-deletes the integration. Changes the status of the integration to ARCHIVED. If the
                        /// integration being ARCHIVED is tagged as "HEAD", the tag is removed from this snapshot and
                        /// set to the previous non-ARCHIVED snapshot. The PUBLISH_REQUESTED, DUE_FOR_DELETION tags are
                        /// removed too. This RPC throws an exception if the version being archived is DRAFT, and if the
                        /// `locked_by` user is not the same as the user performing the Archive. Audit fields updated
                        /// include last_modified_timestamp, last_modified_by. Any existing lock is released when
                        /// Archiving a integration. Currently, there is no unarchive mechanism.
                        /// </summary>
                        public class ArchiveRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionResponse>
                        {
                            /// <summary>Constructs a new Archive request.</summary>
                            public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The version to archive. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "archive";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}:archive";

                            /// <summary>Initializes Archive parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Create a integration with a draft version in the specified project.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource where this version will be created. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Create a integration with a draft version in the specified project.</summary>
                        public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource where this version will be created. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Set this flag to true, if draft version is to be created for a brand new integration.
                            /// False, if the request is for an existing integration. For backward compatibility
                            /// reasons, even if this flag is set to `false` and no existing integration is found, a new
                            /// draft integration will still be created.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("newIntegration", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> NewIntegration { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/versions";

                            /// <summary>Initializes Create parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                                });
                                RequestParameters.Add("newIntegration", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "newIntegration",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Sets the status of the ACTIVE integration to SNAPSHOT with a new tag "PREVIOUSLY_PUBLISHED"
                        /// after validating it. The "HEAD" and "PUBLISH_REQUESTED" tags do not change. This RPC throws
                        /// an exception if the version being snapshot is not ACTIVE. Audit fields added include action,
                        /// action_by, action_timestamp.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The version to deactivate. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </param>
                        public virtual DeactivateRequest Deactivate(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionRequest body, string name)
                        {
                            return new DeactivateRequest(service, body, name);
                        }

                        /// <summary>
                        /// Sets the status of the ACTIVE integration to SNAPSHOT with a new tag "PREVIOUSLY_PUBLISHED"
                        /// after validating it. The "HEAD" and "PUBLISH_REQUESTED" tags do not change. This RPC throws
                        /// an exception if the version being snapshot is not ACTIVE. Audit fields added include action,
                        /// action_by, action_timestamp.
                        /// </summary>
                        public class DeactivateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionResponse>
                        {
                            /// <summary>Constructs a new Deactivate request.</summary>
                            public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The version to deactivate. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "deactivate";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}:deactivate";

                            /// <summary>Initializes Deactivate parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Downloads an integration. Retrieves the `IntegrationVersion` for a given `integration_id`
                        /// and returns the response as a string.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The version to download. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </param>
                        public virtual DownloadRequest Download(string name)
                        {
                            return new DownloadRequest(service, name);
                        }

                        /// <summary>
                        /// Downloads an integration. Retrieves the `IntegrationVersion` for a given `integration_id`
                        /// and returns the response as a string.
                        /// </summary>
                        public class DownloadRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaDownloadIntegrationVersionResponse>
                        {
                            /// <summary>Constructs a new Download request.</summary>
                            public DownloadRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The version to download. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>File format for download request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("fileFormat", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<FileFormatEnum> FileFormat { get; set; }

                            /// <summary>File format for download request.</summary>
                            public enum FileFormatEnum
                            {
                                /// <summary>Unspecified file format</summary>
                                [Google.Apis.Util.StringValueAttribute("FILE_FORMAT_UNSPECIFIED")]
                                FILEFORMATUNSPECIFIED = 0,

                                /// <summary>JSON File Format</summary>
                                [Google.Apis.Util.StringValueAttribute("JSON")]
                                JSON = 1,

                                /// <summary>YAML File Format</summary>
                                [Google.Apis.Util.StringValueAttribute("YAML")]
                                YAML = 2,
                            }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "download";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}:download";

                            /// <summary>Initializes Download parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("fileFormat", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fileFormat",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Get a integration in the specified project.</summary>
                        /// <param name="name">
                        /// Required. The version to retrieve. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Get a integration in the specified project.</summary>
                        public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The version to retrieve. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}";

                            /// <summary>Initializes Get parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// PROTECT WITH A VISIBILITY LABEL. THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. RPC to get
                        /// details of the Bundle
                        /// </summary>
                        /// <param name="name">Required. The bundle name.</param>
                        public virtual GetBundleRequest GetBundle(string name)
                        {
                            return new GetBundleRequest(service, name);
                        }

                        /// <summary>
                        /// PROTECT WITH A VISIBILITY LABEL. THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. RPC to get
                        /// details of the Bundle
                        /// </summary>
                        public class GetBundleRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaGetBundleResponse>
                        {
                            /// <summary>Constructs a new GetBundle request.</summary>
                            public GetBundleRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The bundle name.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getBundle";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}:getBundle";

                            /// <summary>Initializes GetBundle parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Returns the list of all integration versions in the specified project.</summary>
                        /// <param name="parent">
                        /// Required. The parent resource where this version will be created. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration} Specifically, when parent
                        /// equals: 1. projects//locations//integrations/, Meaning: "List versions (with filter) for a
                        /// particular integration". 2. projects//locations//integrations/- Meaning: "List versions
                        /// (with filter) for a client within a particular region". 3.
                        /// projects//locations/-/integrations/- Meaning: "List versions (with filter) for a client".
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns the list of all integration versions in the specified project.</summary>
                        public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListIntegrationVersionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource where this version will be created. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration} Specifically, when
                            /// parent equals: 1. projects//locations//integrations/, Meaning: "List versions (with
                            /// filter) for a particular integration". 2. projects//locations//integrations/- Meaning:
                            /// "List versions (with filter) for a client within a particular region". 3.
                            /// projects//locations/-/integrations/- Meaning: "List versions (with filter) for a
                            /// client".
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>The field mask which specifies the particular data to be returned.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object FieldMask { get; set; }

                            /// <summary>
                            /// Filter on fields of IntegrationVersion. Fields can be compared with literal values by
                            /// use of ":" (containment), "=" (equality), "&amp;gt;" (greater), "&amp;lt;" (less than),
                            /// &amp;gt;=" (greater than or equal to), "&amp;lt;=" (less than or equal to), and "!="
                            /// (inequality) operators. Negation, conjunction, and disjunction are written using NOT,
                            /// AND, and OR keywords. For example, organization_id=\"1\" AND state=ACTIVE AND
                            /// description:"test". Filtering cannot be performed on repeated fields like `task_config`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// The results would be returned in order you specified here. Currently supported sort keys
                            /// are: Descending sort order for "last_modified_time", "created_time", "snapshot_number"
                            /// Ascending sort order for "name".
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// The maximum number of versions to return. The service may return fewer than this value.
                            /// If unspecified, at most 50 versions will be returned. The maximum value is 1000; values
                            /// above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListIntegrationVersions` call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListIntegrationVersions` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/versions";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                                });
                                RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fieldMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "orderBy",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Update a integration with a draft version in the specified project.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Output only. Auto-generated primary key.</param>
                        public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Update a integration with a draft version in the specified project.</summary>
                        public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Output only. Auto-generated primary key.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Field mask specifying the fields in the above integration that have been modified and
                            /// need to be updated.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationVersion Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}";

                            /// <summary>Initializes Patch parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "updateMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// This RPC throws an exception if the integration is in ARCHIVED or ACTIVE state. This RPC
                        /// throws an exception if the version being published is DRAFT, and if the `locked_by` user is
                        /// not the same as the user performing the Publish. Audit fields updated include
                        /// last_published_timestamp, last_published_by, last_modified_timestamp, last_modified_by. Any
                        /// existing lock is on this integration is released.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The version to publish. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </param>
                        public virtual PublishRequest Publish(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaPublishIntegrationVersionRequest body, string name)
                        {
                            return new PublishRequest(service, body, name);
                        }

                        /// <summary>
                        /// This RPC throws an exception if the integration is in ARCHIVED or ACTIVE state. This RPC
                        /// throws an exception if the version being published is DRAFT, and if the `locked_by` user is
                        /// not the same as the user performing the Publish. Audit fields updated include
                        /// last_published_timestamp, last_published_by, last_modified_timestamp, last_modified_by. Any
                        /// existing lock is on this integration is released.
                        /// </summary>
                        public class PublishRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaPublishIntegrationVersionResponse>
                        {
                            /// <summary>Constructs a new Publish request.</summary>
                            public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaPublishIntegrationVersionRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The version to publish. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaPublishIntegrationVersionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "publish";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}:publish";

                            /// <summary>Initializes Publish parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Clears the `locked_by` and `locked_at_timestamp`in the DRAFT version of this integration. It
                        /// then performs the same action as the CreateDraftIntegrationVersion (i.e., copies the DRAFT
                        /// version of the integration as a SNAPSHOT and then creates a new DRAFT version with the
                        /// `locked_by` set to the `user_taking_over` and the `locked_at_timestamp` set to the current
                        /// timestamp). Both the `locked_by` and `user_taking_over` are notified via email about the
                        /// takeover. This RPC throws an exception if the integration is not in DRAFT status or if the
                        /// `locked_by` and `locked_at_timestamp` fields are not set.The TakeoverEdit lock is treated
                        /// the same as an edit of the integration, and hence shares ACLs with edit. Audit fields
                        /// updated include last_modified_timestamp, last_modified_by.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="integrationVersion">
                        /// Required. The version to take over edit lock. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </param>
                        public virtual TakeoverEditLockRequest TakeoverEditLock(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaTakeoverEditLockRequest body, string integrationVersion)
                        {
                            return new TakeoverEditLockRequest(service, body, integrationVersion);
                        }

                        /// <summary>
                        /// Clears the `locked_by` and `locked_at_timestamp`in the DRAFT version of this integration. It
                        /// then performs the same action as the CreateDraftIntegrationVersion (i.e., copies the DRAFT
                        /// version of the integration as a SNAPSHOT and then creates a new DRAFT version with the
                        /// `locked_by` set to the `user_taking_over` and the `locked_at_timestamp` set to the current
                        /// timestamp). Both the `locked_by` and `user_taking_over` are notified via email about the
                        /// takeover. This RPC throws an exception if the integration is not in DRAFT status or if the
                        /// `locked_by` and `locked_at_timestamp` fields are not set.The TakeoverEdit lock is treated
                        /// the same as an edit of the integration, and hence shares ACLs with edit. Audit fields
                        /// updated include last_modified_timestamp, last_modified_by.
                        /// </summary>
                        public class TakeoverEditLockRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaTakeoverEditLockResponse>
                        {
                            /// <summary>Constructs a new TakeoverEditLock request.</summary>
                            public TakeoverEditLockRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaTakeoverEditLockRequest body, string integrationVersion) : base(service)
                            {
                                IntegrationVersion = integrationVersion;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The version to take over edit lock. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("integrationVersion", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string IntegrationVersion { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaTakeoverEditLockRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "takeoverEditLock";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+integrationVersion}:takeoverEditLock";

                            /// <summary>Initializes TakeoverEditLock parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("integrationVersion", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "integrationVersion",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. RPC to update the Bundle</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. Bundle name</param>
                        public virtual UpdateBundleRequest UpdateBundle(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaUpdateBundleRequest body, string name)
                        {
                            return new UpdateBundleRequest(service, body, name);
                        }

                        /// <summary>THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. RPC to update the Bundle</summary>
                        public class UpdateBundleRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaUpdateBundleResponse>
                        {
                            /// <summary>Constructs a new UpdateBundle request.</summary>
                            public UpdateBundleRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaUpdateBundleRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. Bundle name</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaUpdateBundleRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "updateBundle";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}:updateBundle";

                            /// <summary>Initializes UpdateBundle parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Uploads an integration. The content can be a previously downloaded integration. Performs the
                        /// same function as CreateDraftIntegrationVersion, but accepts input in a string format, which
                        /// holds the complete representation of the IntegrationVersion content.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The version to upload. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}
                        /// </param>
                        public virtual UploadRequest Upload(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaUploadIntegrationVersionRequest body, string parent)
                        {
                            return new UploadRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Uploads an integration. The content can be a previously downloaded integration. Performs the
                        /// same function as CreateDraftIntegrationVersion, but accepts input in a string format, which
                        /// holds the complete representation of the IntegrationVersion content.
                        /// </summary>
                        public class UploadRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaUploadIntegrationVersionResponse>
                        {
                            /// <summary>Constructs a new Upload request.</summary>
                            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaUploadIntegrationVersionRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The version to upload. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaUploadIntegrationVersionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "upload";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/versions:upload";

                            /// <summary>Initializes Upload parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Validates the given integration. If the id doesn't exist, a NotFoundException is thrown. If
                        /// validation fails a CanonicalCodeException is thrown. If there was no failure an empty
                        /// response is returned.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The version to validate. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                        /// </param>
                        public virtual ValidateRequest Validate(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaValidateIntegrationVersionRequest body, string name)
                        {
                            return new ValidateRequest(service, body, name);
                        }

                        /// <summary>
                        /// Validates the given integration. If the id doesn't exist, a NotFoundException is thrown. If
                        /// validation fails a CanonicalCodeException is thrown. If there was no failure an empty
                        /// response is returned.
                        /// </summary>
                        public class ValidateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaValidateIntegrationVersionResponse>
                        {
                            /// <summary>Constructs a new Validate request.</summary>
                            public ValidateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaValidateIntegrationVersionRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The version to validate. Format:
                            /// projects/{project}/locations/{location}/integrations/{integration}/versions/{version}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaValidateIntegrationVersionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "validate";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}:validate";

                            /// <summary>Initializes Validate parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+/versions/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// PROTECT WITH A VISIBILITY LABEL. THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. Soft-deletes
                    /// the bundle.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The bundle to archive. Format:
                    /// projects/{project}/locations/{location}/integrations/{integration}
                    /// </param>
                    public virtual ArchiveBundleRequest ArchiveBundle(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveBundleRequest body, string name)
                    {
                        return new ArchiveBundleRequest(service, body, name);
                    }

                    /// <summary>
                    /// PROTECT WITH A VISIBILITY LABEL. THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. Soft-deletes
                    /// the bundle.
                    /// </summary>
                    public class ArchiveBundleRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveBundleResponse>
                    {
                        /// <summary>Constructs a new ArchiveBundle request.</summary>
                        public ArchiveBundleRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveBundleRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The bundle to archive. Format:
                        /// projects/{project}/locations/{location}/integrations/{integration}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaArchiveBundleRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "archiveBundle";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:archiveBundle";

                        /// <summary>Initializes ArchiveBundle parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Executes integrations synchronously by passing the trigger id in the request body. The request
                    /// is not returned until the requested executions are either fulfilled or experienced an error. If
                    /// the integration name is not specified (passing `-`), all of the associated integration under the
                    /// given trigger_id will be executed. Otherwise only the specified integration for the given
                    /// `trigger_id` is executed. This is helpful for execution the integration from UI.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The integration resource name.</param>
                    public virtual ExecuteRequest Execute(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecuteIntegrationsRequest body, string name)
                    {
                        return new ExecuteRequest(service, body, name);
                    }

                    /// <summary>
                    /// Executes integrations synchronously by passing the trigger id in the request body. The request
                    /// is not returned until the requested executions are either fulfilled or experienced an error. If
                    /// the integration name is not specified (passing `-`), all of the associated integration under the
                    /// given trigger_id will be executed. Otherwise only the specified integration for the given
                    /// `trigger_id` is executed. This is helpful for execution the integration from UI.
                    /// </summary>
                    public class ExecuteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecuteIntegrationsResponse>
                    {
                        /// <summary>Constructs a new Execute request.</summary>
                        public ExecuteRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecuteIntegrationsRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The integration resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaExecuteIntegrationsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "execute";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:execute";

                        /// <summary>Initializes Execute parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the list of all integrations in the specified project.</summary>
                    /// <param name="parent">
                    /// Required. Project and location from which the integrations should be listed. Format:
                    /// projects/{project}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of all integrations in the specified project.</summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListIntegrationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Project and location from which the integrations should be listed. Format:
                        /// projects/{project}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filter on fields of IntegrationVersion. Fields can be compared with literal values by use of
                        /// ":" (containment), "=" (equality), "&amp;gt;" (greater), "&amp;lt;" (less than), &amp;gt;="
                        /// (greater than or equal to), "&amp;lt;=" (less than or equal to), and "!=" (inequality)
                        /// operators. Negation, conjunction, and disjunction are written using NOT, AND, and OR
                        /// keywords. For example, organization_id=\"1\" AND state=ACTIVE AND description:"test".
                        /// Filtering cannot be performed on repeated fields like `task_config`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// The results would be returned in order you specified here. Supported sort keys are:
                        /// Descending sort order by "last_modified_time", "created_time", "snapshot_number". Ascending
                        /// sort order by the integration name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>The page size for the resquest.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The page token for the resquest.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/integrations";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                            {
                                Name = "orderBy",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Get execution stats</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource name: {parent=projects/*/locations/*}.
                    /// </param>
                    public virtual MonitorexecutionstatsRequest Monitorexecutionstats(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequest body, string parent)
                    {
                        return new MonitorexecutionstatsRequest(service, body, parent);
                    }

                    /// <summary>Get execution stats</summary>
                    public class MonitorexecutionstatsRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaMonitorExecutionStatsResponse>
                    {
                        /// <summary>Constructs a new Monitorexecutionstats request.</summary>
                        public MonitorexecutionstatsRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource name: {parent=projects/*/locations/*}.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "monitorexecutionstats";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}:monitorexecutionstats";

                        /// <summary>Initializes Monitorexecutionstats parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Schedules an integration for execution by passing the trigger id and the scheduled time in the
                    /// request body.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The integration resource name.</param>
                    public virtual ScheduleRequest Schedule(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaScheduleIntegrationsRequest body, string name)
                    {
                        return new ScheduleRequest(service, body, name);
                    }

                    /// <summary>
                    /// Schedules an integration for execution by passing the trigger id and the scheduled time in the
                    /// request body.
                    /// </summary>
                    public class ScheduleRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaScheduleIntegrationsResponse>
                    {
                        /// <summary>Constructs a new Schedule request.</summary>
                        public ScheduleRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaScheduleIntegrationsRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The integration resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaScheduleIntegrationsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "schedule";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}:schedule";

                        /// <summary>Initializes Schedule parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrations/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Integrationtemplates resource.</summary>
                public virtual IntegrationtemplatesResource Integrationtemplates { get; }

                /// <summary>The "integrationtemplates" collection of methods.</summary>
                public class IntegrationtemplatesResource
                {
                    private const string Resource = "integrationtemplates";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public IntegrationtemplatesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Versions = new VersionsResource(service);
                    }

                    /// <summary>Gets the Versions resource.</summary>
                    public virtual VersionsResource Versions { get; }

                    /// <summary>The "versions" collection of methods.</summary>
                    public class VersionsResource
                    {
                        private const string Resource = "versions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public VersionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates an IntegrationTemplateVersion.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource where this TemplateVersion will be created. Format:
                        /// projects/{project}/location/{location}/product/{product}/integrationtemplates/{integrationtemplate}
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationTemplateVersion body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates an IntegrationTemplateVersion.</summary>
                        public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationTemplateVersion>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationTemplateVersion body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource where this TemplateVersion will be created. Format:
                            /// projects/{project}/location/{location}/product/{product}/integrationtemplates/{integrationtemplate}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationTemplateVersion Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/versions";

                            /// <summary>Initializes Create parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrationtemplates/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Returns an IntegrationTemplateVersion in the specified project.</summary>
                        /// <param name="name">
                        /// Required. The TemplateVersion to retrieve. Format:
                        /// projects/{project}/locations/{location}/products/{product}/integrationtemplates/{integrationtemplate}/versions/{version}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Returns an IntegrationTemplateVersion in the specified project.</summary>
                        public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaIntegrationTemplateVersion>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The TemplateVersion to retrieve. Format:
                            /// projects/{project}/locations/{location}/products/{product}/integrationtemplates/{integrationtemplate}/versions/{version}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}";

                            /// <summary>Initializes Get parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrationtemplates/[^/]+/versions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns the list of all IntegrationTemplateVersions in the specified project.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. Format:
                        /// projects/{project}/location/{location}/product/{product}/integrationtemplates/{integrationtemplate}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>
                        /// Returns the list of all IntegrationTemplateVersions in the specified project.
                        /// </summary>
                        public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListIntegrationTemplateVersionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Format:
                            /// projects/{project}/location/{location}/product/{product}/integrationtemplates/{integrationtemplate}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Filter syntax: defined in the EBNF grammar.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// The maximum number of IntegrationTemplateVersions to return. The service may return
                            /// fewer than this value. If unspecified, at most 50 versions will be returned. The maximum
                            /// value is 1000; values above 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListIntegrationTemplateVersions` call. Provide
                            /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListIntegrationTemplateVersions` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/versions";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/integrationtemplates/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }
                }

                /// <summary>Gets the SfdcInstances resource.</summary>
                public virtual SfdcInstancesResource SfdcInstances { get; }

                /// <summary>The "sfdcInstances" collection of methods.</summary>
                public class SfdcInstancesResource
                {
                    private const string Resource = "sfdcInstances";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SfdcInstancesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        SfdcChannels = new SfdcChannelsResource(service);
                    }

                    /// <summary>Gets the SfdcChannels resource.</summary>
                    public virtual SfdcChannelsResource SfdcChannels { get; }

                    /// <summary>The "sfdcChannels" collection of methods.</summary>
                    public class SfdcChannelsResource
                    {
                        private const string Resource = "sfdcChannels";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public SfdcChannelsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Creates an sfdc channel record. Store the sfdc channel in Spanner. Returns the sfdc channel.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. "projects/{project}/locations/{location}" format.</param>
                        public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Creates an sfdc channel record. Store the sfdc channel in Spanner. Returns the sfdc channel.
                        /// </summary>
                        public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. "projects/{project}/locations/{location}" format.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/sfdcChannels";

                            /// <summary>Initializes Create parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/sfdcInstances/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Deletes an sfdc channel.</summary>
                        /// <param name="name">Required. The name that is associated with the SfdcChannel.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes an sfdc channel.</summary>
                        public class DeleteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name that is associated with the SfdcChannel.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}";

                            /// <summary>Initializes Delete parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/sfdcInstances/[^/]+/sfdcChannels/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets an sfdc channel. If the channel doesn't exist, Code.NOT_FOUND exception will be thrown.
                        /// </summary>
                        /// <param name="name">Required. The name that is associated with the SfdcChannel.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>
                        /// Gets an sfdc channel. If the channel doesn't exist, Code.NOT_FOUND exception will be thrown.
                        /// </summary>
                        public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name that is associated with the SfdcChannel.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}";

                            /// <summary>Initializes Get parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/sfdcInstances/[^/]+/sfdcChannels/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists all sfdc channels that match the filter. Restrict to sfdc channels belonging to the
                        /// current client only.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. The client, which owns this collection of SfdcChannels.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>
                        /// Lists all sfdc channels that match the filter. Restrict to sfdc channels belonging to the
                        /// current client only.
                        /// </summary>
                        public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListSfdcChannelsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. The client, which owns this collection of SfdcChannels.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Filtering as supported in
                            /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>The size of entries in the response. If unspecified, defaults to 100.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>The token returned in the previous response.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// The mask which specifies fields that need to be returned in the SfdcChannel's response.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object ReadMask { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+parent}/sfdcChannels";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/sfdcInstances/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "readMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Updates an sfdc channel. Updates the sfdc channel in spanner. Returns the sfdc channel.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Resource name of the SFDC channel
                        /// projects/{project}/locations/{location}/sfdcInstances/{sfdc_instance}/sfdcChannels/{sfdc_channel}.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>
                        /// Updates an sfdc channel. Updates the sfdc channel in spanner. Returns the sfdc channel.
                        /// </summary>
                        public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Resource name of the SFDC channel
                            /// projects/{project}/locations/{location}/sfdcInstances/{sfdc_instance}/sfdcChannels/{sfdc_channel}.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Field mask specifying the fields in the above SfdcChannel that have been modified and
                            /// need to be updated.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1alpha/{+name}";

                            /// <summary>Initializes Patch parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/sfdcInstances/[^/]+/sfdcChannels/[^/]+$",
                                });
                                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "updateMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// Creates an sfdc instance record. Store the sfdc instance in Spanner. Returns the sfdc instance.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. "projects/{project}/locations/{location}" format.</param>
                    public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates an sfdc instance record. Store the sfdc instance in Spanner. Returns the sfdc instance.
                    /// </summary>
                    public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. "projects/{project}/locations/{location}" format.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/sfdcInstances";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes an sfdc instance.</summary>
                    /// <param name="name">Required. The name that is associated with the SfdcInstance.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an sfdc instance.</summary>
                    public class DeleteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name that is associated with the SfdcInstance.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/sfdcInstances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets an sfdc instance. If the instance doesn't exist, Code.NOT_FOUND exception will be thrown.
                    /// </summary>
                    /// <param name="name">Required. The name that is associated with the SfdcInstance.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets an sfdc instance. If the instance doesn't exist, Code.NOT_FOUND exception will be thrown.
                    /// </summary>
                    public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name that is associated with the SfdcInstance.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/sfdcInstances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists all sfdc instances that match the filter. Restrict to sfdc instances belonging to the
                    /// current client only.
                    /// </summary>
                    /// <param name="parent">Required. The client, which owns this collection of SfdcInstances.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists all sfdc instances that match the filter. Restrict to sfdc instances belonging to the
                    /// current client only.
                    /// </summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListSfdcInstancesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The client, which owns this collection of SfdcInstances.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filtering as supported in
                        /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The size of entries in the response. If unspecified, defaults to 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The token returned in the previous response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// The mask which specifies fields that need to be returned in the SfdcInstance's response.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object ReadMask { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/sfdcInstances";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "readMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Updates an sfdc instance. Updates the sfdc instance in spanner. Returns the sfdc instance.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Resource name of the SFDC instance
                    /// projects/{project}/locations/{location}/sfdcInstances/{sfdcInstance}.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates an sfdc instance. Updates the sfdc instance in spanner. Returns the sfdc instance.
                    /// </summary>
                    public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Resource name of the SFDC instance
                        /// projects/{project}/locations/{location}/sfdcInstances/{sfdcInstance}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Field mask specifying the fields in the above SfdcInstance that have been modified and need
                        /// to be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+/sfdcInstances/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>
                /// PROTECT WITH A VISIBILITY LABEL. THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. Create a bundle.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The location resource of the request.</param>
                public virtual CreateBundleRequest CreateBundle(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCreateBundleRequest body, string parent)
                {
                    return new CreateBundleRequest(service, body, parent);
                }

                /// <summary>
                /// PROTECT WITH A VISIBILITY LABEL. THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. Create a bundle.
                /// </summary>
                public class CreateBundleRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCreateBundleResponse>
                {
                    /// <summary>Constructs a new CreateBundle request.</summary>
                    public CreateBundleRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCreateBundleRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The location resource of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaCreateBundleRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "createBundle";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}:createBundle";

                    /// <summary>Initializes CreateBundle parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                        });
                    }
                }

                /// <summary>This is a UI only method and will be moved away. Returns a list of common tasks.</summary>
                /// <param name="parent">
                /// Required. The location resource of the request. This is not going to be used but preserve the field
                /// for future.
                /// </param>
                public virtual ListTaskEntitiesRequest ListTaskEntities(string parent)
                {
                    return new ListTaskEntitiesRequest(service, parent);
                }

                /// <summary>This is a UI only method and will be moved away. Returns a list of common tasks.</summary>
                public class ListTaskEntitiesRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListTaskEntitiesResponse>
                {
                    /// <summary>Constructs a new ListTaskEntities request.</summary>
                    public ListTaskEntitiesRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location resource of the request. This is not going to be used but preserve the
                    /// field for future.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listTaskEntities";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}:listTaskEntities";

                    /// <summary>Initializes ListTaskEntities parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/products/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the SfdcInstances resource.</summary>
            public virtual SfdcInstancesResource SfdcInstances { get; }

            /// <summary>The "sfdcInstances" collection of methods.</summary>
            public class SfdcInstancesResource
            {
                private const string Resource = "sfdcInstances";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SfdcInstancesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    SfdcChannels = new SfdcChannelsResource(service);
                }

                /// <summary>Gets the SfdcChannels resource.</summary>
                public virtual SfdcChannelsResource SfdcChannels { get; }

                /// <summary>The "sfdcChannels" collection of methods.</summary>
                public class SfdcChannelsResource
                {
                    private const string Resource = "sfdcChannels";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SfdcChannelsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates an sfdc channel record. Store the sfdc channel in Spanner. Returns the sfdc channel.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. "projects/{project}/locations/{location}" format.</param>
                    public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates an sfdc channel record. Store the sfdc channel in Spanner. Returns the sfdc channel.
                    /// </summary>
                    public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. "projects/{project}/locations/{location}" format.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/sfdcChannels";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sfdcInstances/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes an sfdc channel.</summary>
                    /// <param name="name">Required. The name that is associated with the SfdcChannel.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an sfdc channel.</summary>
                    public class DeleteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name that is associated with the SfdcChannel.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sfdcInstances/[^/]+/sfdcChannels/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets an sfdc channel. If the channel doesn't exist, Code.NOT_FOUND exception will be thrown.
                    /// </summary>
                    /// <param name="name">Required. The name that is associated with the SfdcChannel.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets an sfdc channel. If the channel doesn't exist, Code.NOT_FOUND exception will be thrown.
                    /// </summary>
                    public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name that is associated with the SfdcChannel.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sfdcInstances/[^/]+/sfdcChannels/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists all sfdc channels that match the filter. Restrict to sfdc channels belonging to the
                    /// current client only.
                    /// </summary>
                    /// <param name="parent">Required. The client, which owns this collection of SfdcChannels.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists all sfdc channels that match the filter. Restrict to sfdc channels belonging to the
                    /// current client only.
                    /// </summary>
                    public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListSfdcChannelsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The client, which owns this collection of SfdcChannels.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filtering as supported in
                        /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The size of entries in the response. If unspecified, defaults to 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The token returned in the previous response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// The mask which specifies fields that need to be returned in the SfdcChannel's response.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object ReadMask { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/sfdcChannels";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sfdcInstances/[^/]+$",
                            });
                            RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "readMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Updates an sfdc channel. Updates the sfdc channel in spanner. Returns the sfdc channel.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Resource name of the SFDC channel
                    /// projects/{project}/locations/{location}/sfdcInstances/{sfdc_instance}/sfdcChannels/{sfdc_channel}.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>
                    /// Updates an sfdc channel. Updates the sfdc channel in spanner. Returns the sfdc channel.
                    /// </summary>
                    public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Resource name of the SFDC channel
                        /// projects/{project}/locations/{location}/sfdcInstances/{sfdc_instance}/sfdcChannels/{sfdc_channel}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Field mask specifying the fields in the above SfdcChannel that have been modified and need
                        /// to be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcChannel Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/sfdcInstances/[^/]+/sfdcChannels/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates an sfdc instance record. Store the sfdc instance in Spanner. Returns the sfdc instance.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. "projects/{project}/locations/{location}" format.</param>
                public virtual CreateRequest Create(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates an sfdc instance record. Store the sfdc instance in Spanner. Returns the sfdc instance.
                /// </summary>
                public class CreateRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. "projects/{project}/locations/{location}" format.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/sfdcInstances";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes an sfdc instance.</summary>
                /// <param name="name">Required. The name that is associated with the SfdcInstance.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes an sfdc instance.</summary>
                public class DeleteRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name that is associated with the SfdcInstance.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sfdcInstances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets an sfdc instance. If the instance doesn't exist, Code.NOT_FOUND exception will be thrown.
                /// </summary>
                /// <param name="name">Required. The name that is associated with the SfdcInstance.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets an sfdc instance. If the instance doesn't exist, Code.NOT_FOUND exception will be thrown.
                /// </summary>
                public class GetRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name that is associated with the SfdcInstance.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sfdcInstances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all sfdc instances that match the filter. Restrict to sfdc instances belonging to the current
                /// client only.
                /// </summary>
                /// <param name="parent">Required. The client, which owns this collection of SfdcInstances.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists all sfdc instances that match the filter. Restrict to sfdc instances belonging to the current
                /// client only.
                /// </summary>
                public class ListRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListSfdcInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The client, which owns this collection of SfdcInstances.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filtering as supported in
                    /// https://developers.google.com/authorized-buyers/apis/guides/v2/list-filters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The size of entries in the response. If unspecified, defaults to 100.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The token returned in the previous response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// The mask which specifies fields that need to be returned in the SfdcInstance's response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadMask { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/sfdcInstances";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates an sfdc instance. Updates the sfdc instance in spanner. Returns the sfdc instance.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Resource name of the SFDC instance
                /// projects/{project}/locations/{location}/sfdcInstances/{sfdcInstance}.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates an sfdc instance. Updates the sfdc instance in spanner. Returns the sfdc instance.
                /// </summary>
                public class PatchRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Resource name of the SFDC instance
                    /// projects/{project}/locations/{location}/sfdcInstances/{sfdcInstance}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Field mask specifying the fields in the above SfdcInstance that have been modified and need to
                    /// be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaSfdcInstance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/sfdcInstances/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>This is a UI only method and will be moved away. Returns a list of common tasks.</summary>
            /// <param name="parent">
            /// Required. The location resource of the request. This is not going to be used but preserve the field for
            /// future.
            /// </param>
            public virtual ListTaskEntitiesRequest ListTaskEntities(string parent)
            {
                return new ListTaskEntitiesRequest(service, parent);
            }

            /// <summary>This is a UI only method and will be moved away. Returns a list of common tasks.</summary>
            public class ListTaskEntitiesRequest : IntegrationsBaseServiceRequest<Google.Apis.Integrations.v1alpha.Data.GoogleCloudIntegrationsV1alphaListTaskEntitiesResponse>
            {
                /// <summary>Constructs a new ListTaskEntities request.</summary>
                public ListTaskEntitiesRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The location resource of the request. This is not going to be used but preserve the field
                /// for future.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "listTaskEntities";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}:listTaskEntities";

                /// <summary>Initializes ListTaskEntities parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Integrations.v1alpha.Data
{
    /// <summary>
    /// Registered ids for errors, as "oneof" enums. Each task or logical grouping of tasks may share the same enum.
    /// </summary>
    public class CrmlogErrorCode : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("commonErrorCode")]
        public virtual string CommonErrorCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmCardsCellValue : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("empty")]
        public virtual GoogleProtobufEmpty Empty { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("longValue")]
        public virtual System.Nullable<long> LongValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmCardsRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ordered list of cell values within a row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmCardsCellValue> Cells { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The generic data format returned from all connectors.</summary>
    public class EnterpriseCrmCardsTabularData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ordered list of column headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<string> Headers { get; set; }

        /// <summary>Ordered list of table rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmCardsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data used to render an Aplos Series card.</summary>
    public class EnterpriseCrmCardsTemplatesAplosSeriesData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A single Series Row</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmCardsTemplatesAplosSeriesDataRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aplos series row is exactly two columns labeled x and y.</summary>
    public class EnterpriseCrmCardsTemplatesAplosSeriesDataRow : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual EnterpriseCrmCardsCellValue X { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual EnterpriseCrmCardsCellValue Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data used for Aplos charts that accept multiple Series.</summary>
    public class EnterpriseCrmCardsTemplatesAplosSeriesListData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmCardsTemplatesAplosSeriesListDataSeries> Series { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmCardsTemplatesAplosSeriesListDataSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual EnterpriseCrmCardsTemplatesAplosSeriesData Data { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusAuthconfigAuthConfigTaskParam : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defines the credential types to be supported as Task may restrict specific types to use, e.g. Cloud SQL Task
        /// will use username/password type only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedCredentialTypes")]
        public virtual System.Collections.Generic.IList<string> AllowedCredentialTypes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("allowedServiceAccountInContext")]
        public virtual System.Nullable<bool> AllowedServiceAccountInContext { get; set; }

        /// <summary>UUID of the AuthConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfigId")]
        public virtual string AuthConfigId { get; set; }

        /// <summary>A space-delimited list of requested scope permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("useServiceAccountInContext")]
        public virtual System.Nullable<bool> UseServiceAccountInContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Email address along with optional name and tokens. These tokens will be substituted for the variables in the
    /// form of [{var_name}], where var_name could be any string of no more than 32 bytes.
    /// </summary>
    public class EnterpriseCrmEventbusProtoAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tokens")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoToken> Tokens { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Attributes are additional options that can be associated with each event property. For more information, see
    /// go/integration-platform/event_bus/attributes_registry.md. Next available: 8
    /// </summary>
    public class EnterpriseCrmEventbusProtoAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Things like URL, Email, Currency, Timestamp (rather than string, int64...)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Used to define defaults.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual EnterpriseCrmEventbusProtoValueType DefaultValue { get; set; }

        /// <summary>
        /// Required for event execution. The validation will be done by the event bus when the event is triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRequired")]
        public virtual System.Nullable<bool> IsRequired { get; set; }

        /// <summary>
        /// Used to indicate if a ParameterEntry should be converted to ParamIndexes for ST-Spanner full-text search.
        /// DEPRECATED: use searchable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSearchable")]
        public virtual System.Nullable<bool> IsSearchable { get; set; }

        /// <summary>See go/integration-platform/analytics/logging_task.md for details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logSettings")]
        public virtual EnterpriseCrmEventbusProtoLogSettings LogSettings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("searchable")]
        public virtual string Searchable { get; set; }

        /// <summary>List of tasks that can view this property, if empty then all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskVisibility")]
        public virtual System.Collections.Generic.IList<string> TaskVisibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of error enums for alerts.</summary>
    public class EnterpriseCrmEventbusProtoBaseAlertConfigErrorEnumList : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("enumStrings")]
        public virtual System.Collections.Generic.IList<string> EnumStrings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("filterType")]
        public virtual string FilterType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The threshold value of the metric, above or below which the alert should be triggered. See EventAlertConfig or
    /// TaskAlertConfig for the different alert metric types in each case. For the *RATE metrics, one or both of these
    /// fields may be set. Zero is the default value and can be left at that. For *PERCENTILE_DURATION metrics, one or
    /// both of these fields may be set, and also, the duration threshold value should be specified in the
    /// threshold_duration_ms member below. For *AVERAGE_DURATION metrics, these fields should not be set at all. A
    /// different member, threshold_duration_ms, must be set in the EventAlertConfig or the TaskAlertConfig. See
    /// go/eventbus-alert-config-examples
    /// </summary>
    public class EnterpriseCrmEventbusProtoBaseAlertConfigThresholdValue : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("absolute")]
        public virtual System.Nullable<long> Absolute { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoBaseFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoBaseValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Start with a function that does not build on existing values. Eg. CurrentTime, Min, Max, Exists, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseFunction")]
        public virtual EnterpriseCrmEventbusProtoFunction BaseFunction { get; set; }

        /// <summary>Start with a literal value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("literalValue")]
        public virtual EnterpriseCrmEventbusProtoParameterValueType LiteralValue { get; set; }

        /// <summary>Start with a reference value to dereference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceValue")]
        public virtual string ReferenceValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoBooleanArrayFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoBooleanFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoBooleanParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<bool>> BooleanValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoBuganizerNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whom to assign the new bug. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assigneeEmailAddress")]
        public virtual string AssigneeEmailAddress { get; set; }

        /// <summary>ID of the buganizer component within which to create a new issue. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentId")]
        public virtual System.Nullable<long> ComponentId { get; set; }

        /// <summary>ID of the buganizer template to use. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateId")]
        public virtual System.Nullable<long> TemplateId { get; set; }

        /// <summary>Title of the issue to be created. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Scheduler Trigger configuration</summary>
    public class EnterpriseCrmEventbusProtoCloudSchedulerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The cron tab of cloud scheduler trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronTab")]
        public virtual string CronTab { get; set; }

        /// <summary>
        /// Optional. When the job was deleted from Pantheon UI, error_message will be populated when Get/List
        /// integrations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Required. The location where associated cloud scheduler job will be created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Required. Service account used by Cloud Scheduler to trigger the integration at scheduled time
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message recursively combines constituent conditions using logical AND.</summary>
    public class EnterpriseCrmEventbusProtoCombinedCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of individual constituent conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoCondition> Conditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Condition that uses `operator` to evaluate the key against the value.</summary>
    public class EnterpriseCrmEventbusProtoCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Key that's evaluated against the `value`. Please note the data type of the runtime value associated with the
        /// key should match the data type of `value`, else an IllegalArgumentException is thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventPropertyKey")]
        public virtual string EventPropertyKey { get; set; }

        /// <summary>
        /// Operator used to evaluate the condition. Please note that an operator with an inappropriate key/value
        /// operand will result in IllegalArgumentException, e.g. CONTAINS with boolean key/value pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>Value that's checked for the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual EnterpriseCrmEventbusProtoValueType Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the combined condition calculation results.</summary>
    public class EnterpriseCrmEventbusProtoConditionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>the current task number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentTaskNumber")]
        public virtual string CurrentTaskNumber { get; set; }

        /// <summary>the next task number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextTaskNumber")]
        public virtual string NextTaskNumber { get; set; }

        /// <summary>
        /// the result comes out after evaluate the combined condition. True if there's no combined condition specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual System.Nullable<bool> Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoConnectorsConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Connection name Format: projects/{project}/locations/{location}/connections/{connection}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionName")]
        public virtual string ConnectionName { get; set; }

        /// <summary>
        /// Connector version Format:
        /// projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorVersion")]
        public virtual string ConnectorVersion { get; set; }

        /// <summary>
        /// Service name Format: projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoConnectorsGenericConnectorTaskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User-selected connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connection")]
        public virtual EnterpriseCrmEventbusProtoConnectorsConnection Connection { get; set; }

        /// <summary>Operation to perform using the configured connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents two-dimensional positions.</summary>
    public class EnterpriseCrmEventbusProtoCoordinate : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual System.Nullable<int> X { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual System.Nullable<int> Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoCustomSuspensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Request to fire an event containing the SuspensionInfo message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postToQueueWithTriggerIdRequest")]
        public virtual GoogleInternalCloudCrmEventbusV3PostToQueueWithTriggerIdRequest PostToQueueWithTriggerIdRequest { get; set; }

        /// <summary>In the fired event, set the SuspensionInfo message as the value for this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionInfoEventParameterKey")]
        public virtual string SuspensionInfoEventParameterKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoDoubleArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoDoubleArrayFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoDoubleFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoDoubleParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> DoubleValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An error, warning, or information message associated with a workflow.</summary>
    public class EnterpriseCrmEventbusProtoErrorDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The associated error-code, which can be a common or internal code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual CrmlogErrorCode ErrorCode { get; set; }

        /// <summary>
        /// The full text of the error message, including any parameters that were thrown along with the exception.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The severity of the error: ERROR|WARN|INFO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// The task try-number, in which, the error occurred. If zero, the error happened at the event level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual System.Nullable<int> TaskNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// LINT.IfChange This message is used for storing key value pair properties for each Event / Task in the EventBus.
    /// Please see go/cloud-crm-eng/platform/event_bus.md for more details.
    /// </summary>
    public class EnterpriseCrmEventbusProtoEventBusProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An unordered list of property entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoPropertyEntry> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the details of the execution info of this event: this includes the tasks execution details plus the
    /// event execution statistics. Next available id: 10
    /// </summary>
    public class EnterpriseCrmEventbusProtoEventExecutionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eventAttemptStats")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoEventExecutionDetailsEventAttemptStats> EventAttemptStats { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionSnapshot")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoEventExecutionSnapshot> EventExecutionSnapshot { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionState")]
        public virtual string EventExecutionState { get; set; }

        /// <summary>Indicates the number of times the execution has restarted from the beginning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventRetriesFromBeginningCount")]
        public virtual System.Nullable<int> EventRetriesFromBeginningCount { get; set; }

        /// <summary>The log file path (aka. cns address) for this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logFilePath")]
        public virtual string LogFilePath { get; set; }

        /// <summary>
        /// The network address (aka. bns address) that indicates where the event executor is running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkAddress")]
        public virtual string NetworkAddress { get; set; }

        /// <summary>Next scheduled execution time in case the execution status was RETRY_ON_HOLD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextExecutionTime")]
        public virtual System.Nullable<long> NextExecutionTime { get; set; }

        /// <summary>
        /// Used internally and shouldn't be exposed to users. A counter for the cron job to record how many times this
        /// event is in in_process state but don't have a lock consecutively/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ryeLockUnheldCount")]
        public virtual System.Nullable<int> RyeLockUnheldCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoEventExecutionDetailsEventAttemptStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end time of the event execution for current attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual System.Nullable<long> EndTime { get; set; }

        /// <summary>
        /// The start time of the event execution for current attempt. This could be in the future if it's been
        /// scheduled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual System.Nullable<long> StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the snapshot of the event execution for a given checkpoint. Next available id: 13</summary>
    public class EnterpriseCrmEventbusProtoEventExecutionSnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates "right after which checkpoint task's execution" this snapshot is taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkpointTaskNumber")]
        public virtual string CheckpointTaskNumber { get; set; }

        /// <summary>All of the computed conditions that been calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionResults")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoConditionResult> ConditionResults { get; set; }

        /// <summary>The parameters in Event object that differs from last snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffParams")]
        public virtual EnterpriseCrmEventbusProtoEventParameters DiffParams { get; set; }

        /// <summary>Points to the event execution info this snapshot belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionInfoId")]
        public virtual string EventExecutionInfoId { get; set; }

        /// <summary>Auto-generated. Used as primary key for EventExecutionSnapshots table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionSnapshotId")]
        public virtual string EventExecutionSnapshotId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionSnapshotMetadata")]
        public virtual EnterpriseCrmEventbusProtoEventExecutionSnapshotEventExecutionSnapshotMetadata EventExecutionSnapshotMetadata { get; set; }

        /// <summary>The parameters in Event object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventParams")]
        public virtual EnterpriseCrmEventbusProtoEventParameters EventParams { get; set; }

        /// <summary>indicate whether snapshot exceeded maximum size before clean up</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceedMaxSize")]
        public virtual System.Nullable<bool> ExceedMaxSize { get; set; }

        /// <summary>Indicates when this snapshot is taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotTime")]
        public virtual System.Nullable<long> SnapshotTime { get; set; }

        /// <summary>All of the task execution details at the given point of time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskExecutionDetails")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoTaskExecutionDetails> TaskExecutionDetails { get; set; }

        /// <summary>The task name associated with this snapshot. Could be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskName")]
        public virtual string TaskName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoEventExecutionSnapshotEventExecutionSnapshotMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>the event attempt number this snapshot belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventAttemptNum")]
        public virtual System.Nullable<int> EventAttemptNum { get; set; }

        /// <summary>the task attempt number this snapshot belongs to. Could be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskAttemptNum")]
        public virtual System.Nullable<int> TaskAttemptNum { get; set; }

        /// <summary>the task name associated with this snapshot. Could be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskName")]
        public virtual string TaskName { get; set; }

        /// <summary>The task number associated with this snapshot. Could be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual string TaskNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// LINT.IfChange This message is used for processing and persisting (when applicable) key value pair parameters for
    /// each event in the event bus. Please see go/integration-platform/event_bus.md for more details. Next id: 4
    /// </summary>
    public class EnterpriseCrmEventbusProtoEventParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Parameters are a part of Event and can be used to communicate between different tasks that are part of the
        /// same integration execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoParameterEntry> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message that helps aggregate all sub-executions triggered by one execution and keeps track of child-parent
    /// relationships.
    /// </summary>
    public class EnterpriseCrmEventbusProtoExecutionTraceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Parent event execution info id that triggers the current execution through SubWorkflowExecutorTask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentEventExecutionInfoId")]
        public virtual string ParentEventExecutionInfoId { get; set; }

        /// <summary>Used to aggregate ExecutionTraceInfo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceId")]
        public virtual string TraceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents external traffic type and id.</summary>
    public class EnterpriseCrmEventbusProtoExternalTraffic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User’s GCP project id the traffic is referring to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpProjectId")]
        public virtual string GcpProjectId { get; set; }

        /// <summary>User’s GCP project number the traffic is referring to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpProjectNumber")]
        public virtual string GcpProjectNumber { get; set; }

        /// <summary>Location for the user's request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// LINT.ThenChange(//depot/google3/enterprise/crm/eventbus/proto/product.proto:product,
        /// //depot/google3/java/com/google/enterprise/crm/integrationplatform/api/utils/ConverterUtils.java:source_to_product)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy that defines the task retry logic and failure type. If no FailurePolicy is defined for a task, all its
    /// dependent tasks will not be executed (i.e, a `retry_strategy` of NONE will be applied).
    /// </summary>
    public class EnterpriseCrmEventbusProtoFailurePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required if retry_strategy is FIXED_INTERVAL or LINEAR/EXPONENTIAL_BACKOFF/RESTART_WORKFLOW_WITH_BACKOFF.
        /// Defines the initial interval for backoff.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervalInSeconds")]
        public virtual System.Nullable<long> IntervalInSeconds { get; set; }

        /// <summary>
        /// Required if retry_strategy is FIXED_INTERVAL or LINEAR/EXPONENTIAL_BACKOFF/RESTART_WORKFLOW_WITH_BACKOFF.
        /// Defines the number of times the task will be retried if failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNumRetries")]
        public virtual System.Nullable<int> MaxNumRetries { get; set; }

        /// <summary>Defines what happens to the task upon failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryStrategy")]
        public virtual string RetryStrategy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the value and type of the field. Next Id: 8</summary>
    public class EnterpriseCrmEventbusProtoField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default, if the cardinality is unspecified the field is considered required while mapping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardinality")]
        public virtual string Cardinality { get; set; }

        /// <summary>
        /// This holds the default values for the fields. This value is supplied by user so may or may not contain PII
        /// or SPII data. This field will be scrubbed using DatapolScrubber#maybeScrub() with go/proto-sanitizer#level3
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual EnterpriseCrmEventbusProtoParameterValueType DefaultValue { get; set; }

        /// <summary>Specifies the data type of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldType")]
        public virtual string FieldType { get; set; }

        /// <summary>
        /// Optional. The fully qualified proto name (e.g. enterprise.crm.storage.Account). Required for output field of
        /// type PROTO_VALUE or PROTO_ARRAY. For e.g., if input field_type is BYTES and output field_type is
        /// PROTO_VALUE, then fully qualified proto type url should be provided to parse the input bytes. If field_type
        /// is *_ARRAY, then all the converted protos are of the same type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoDefPath")]
        public virtual string ProtoDefPath { get; set; }

        /// <summary>
        /// This holds the reference key of the workflow or task parameter. 1. Any workflow parameter, for e.g.
        /// $workflowParam1$. 2. Any task input or output parameter, for e.g. $task1_param1$. 3. Any workflow or task
        /// parameters with subfield references, for e.g., $task1_param1.employee.id$
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceKey")]
        public virtual string ReferenceKey { get; set; }

        /// <summary>
        /// This is the transform expression to fetch the input field value. for e.g. $param1$.CONCAT('test'). See
        /// go/transform-functions-design for more details. Keep points - 1. Only input field can have a transform
        /// expression. 2. If a transform expression is provided, reference_key will be ignored. 3. If no value is
        /// returned after evaluation of transform expression, default_value can be mapped if provided. 4. The
        /// field_type should be the type of the final object returned after the transform expression is evaluated.
        /// Scrubs the transform expression before logging as value provided by user so may or may not contain PII or
        /// SPII data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformExpression")]
        public virtual EnterpriseCrmEventbusProtoTransformExpression TransformExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Field Mapping Config to map multiple output fields values from input fields values. Next id: 2
    /// </summary>
    public class EnterpriseCrmEventbusProtoFieldMappingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("mappedFields")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoMappedField> MappedFields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the function to perform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionType")]
        public virtual EnterpriseCrmEventbusProtoFunctionType FunctionType { get; set; }

        /// <summary>List of parameters required for the transformation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoTransformExpression> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoFunctionType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>LINT.IfChange</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseFunction")]
        public virtual EnterpriseCrmEventbusProtoBaseFunction BaseFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("booleanArrayFunction")]
        public virtual EnterpriseCrmEventbusProtoBooleanArrayFunction BooleanArrayFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("booleanFunction")]
        public virtual EnterpriseCrmEventbusProtoBooleanFunction BooleanFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleArrayFunction")]
        public virtual EnterpriseCrmEventbusProtoDoubleArrayFunction DoubleArrayFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleFunction")]
        public virtual EnterpriseCrmEventbusProtoDoubleFunction DoubleFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intArrayFunction")]
        public virtual EnterpriseCrmEventbusProtoIntArrayFunction IntArrayFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intFunction")]
        public virtual EnterpriseCrmEventbusProtoIntFunction IntFunction { get; set; }

        /// <summary>
        /// LINT.ThenChange(//depot/google3/alkali/apps/integrationplatform/client/workflow_editor/utils/transform_function.ts)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonFunction")]
        public virtual EnterpriseCrmEventbusProtoJsonFunction JsonFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protoArrayFunction")]
        public virtual EnterpriseCrmEventbusProtoProtoArrayFunction ProtoArrayFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protoFunction")]
        public virtual EnterpriseCrmEventbusProtoProtoFunction ProtoFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringArrayFunction")]
        public virtual EnterpriseCrmEventbusProtoStringArrayFunction StringArrayFunction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringFunction")]
        public virtual EnterpriseCrmEventbusProtoStringFunction StringFunction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoIntArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoIntArrayFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoIntFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoIntParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("intValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> IntValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoJsonFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The LogSettings define the logging attributes for an event property. These attributes are used to map the
    /// property to the parameter in the log proto. Also used to define scrubbing/truncation behavior and PII
    /// information. See go/integration-platform/analytics/logging_task.md for details.
    /// </summary>
    public class EnterpriseCrmEventbusProtoLogSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of corresponding logging field of the event property. If omitted, assumes the same name as the
        /// event property key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logFieldName")]
        public virtual string LogFieldName { get; set; }

        /// <summary>Contains the scrubbing options, such as whether to scrub, obfuscate, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sanitizeOptions")]
        public virtual EnterpriseCrmLoggingGwsSanitizeOptions SanitizeOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("seedPeriod")]
        public virtual string SeedPeriod { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("seedScope")]
        public virtual string SeedScope { get; set; }

        /// <summary>Contains the field limits for shortening, such as max string length and max array length.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shorteningLimits")]
        public virtual EnterpriseCrmLoggingGwsFieldLimits ShorteningLimits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoLoopMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Starting from 1, not 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentIterationCount")]
        public virtual System.Nullable<long> CurrentIterationCount { get; set; }

        /// <summary>
        /// Needs to be set by the loop impl class before each iteration. The abstract loop class will append the
        /// request and response to it. Eg. The foreach Loop will clean up and set it as the current iteration element
        /// at the start of each loop. The post request and response will be appended to the value once they are
        /// available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentIterationDetail")]
        public virtual string CurrentIterationDetail { get; set; }

        /// <summary>Add the error message when loops fail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMsg")]
        public virtual string ErrorMsg { get; set; }

        /// <summary>Indicates where in the loop logic did it error out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureLocation")]
        public virtual string FailureLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mapped field is a pair of input field and output field. Next Id: 3</summary>
    public class EnterpriseCrmEventbusProtoMappedField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The input field being mapped from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputField")]
        public virtual EnterpriseCrmEventbusProtoField InputField { get; set; }

        /// <summary>The output field being mapped to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputField")]
        public virtual EnterpriseCrmEventbusProtoField OutputField { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The task that is next in line to be executed, if the condition specified evaluated to true.</summary>
    public class EnterpriseCrmEventbusProtoNextTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Combined condition for this task to become an eligible next task. Each of these combined_conditions are
        /// joined with logical OR. DEPRECATED: use `condition`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combinedConditions")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoCombinedCondition> CombinedConditions { get; set; }

        /// <summary>Standard filter expression for this task to become an eligible next task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>
        /// User-provided description intended to give more business context about the next task edge or condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User-provided label that is attached to this edge in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>ID of the next task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskConfigId")]
        public virtual string TaskConfigId { get; set; }

        /// <summary>Task number of the next task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual string TaskNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The teardown task that is next in line to be executed. We support only sequential execution of teardown tasks
    /// (i.e. no branching).
    /// </summary>
    public class EnterpriseCrmEventbusProtoNextTeardownTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the next teardown task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a node identifier (type + id). Next highest id: 3</summary>
    public class EnterpriseCrmEventbusProtoNodeIdentifier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration of the edge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementIdentifier")]
        public virtual string ElementIdentifier { get; set; }

        /// <summary>Destination node where the edge ends. It can only be a task config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elementType")]
        public virtual string ElementType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("buganizerNotification")]
        public virtual EnterpriseCrmEventbusProtoBuganizerNotification BuganizerNotification { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual EnterpriseCrmEventbusProtoAddress EmailAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("escalatorQueue")]
        public virtual string EscalatorQueue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>
        /// If the out-of-the-box email/pubsub notifications are not suitable and custom logic is required, fire a
        /// workflow containing all info needed to notify users to resume execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual EnterpriseCrmEventbusProtoCustomSuspensionRequest Request { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoParamSpecEntryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short phrase to describe what this parameter contains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptivePhrase")]
        public virtual string DescriptivePhrase { get; set; }

        /// <summary>
        /// Detailed help text for this parameter containing information not provided elsewhere. For example,
        /// instructions on how to migrate from a deprecated parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpText")]
        public virtual string HelpText { get; set; }

        /// <summary>Whether the default value is hidden in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideDefaultValue")]
        public virtual System.Nullable<bool> HideDefaultValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("inputDisplayOption")]
        public virtual string InputDisplayOption { get; set; }

        /// <summary>Whether this field is hidden in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isHidden")]
        public virtual System.Nullable<bool> IsHidden { get; set; }

        /// <summary>A user-friendly label for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parameterNameOption")]
        public virtual string ParameterNameOption { get; set; }

        /// <summary>A user-friendly label for subSection under which the parameter will be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subSectionLabel")]
        public virtual string SubSectionLabel { get; set; }

        /// <summary>Placeholder text which will appear in the UI input form for this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uiPlaceholderText")]
        public virtual string UiPlaceholderText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoParamSpecEntryProtoDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fully-qualified proto name. This message, for example, would be
        /// "enterprise.crm.eventbus.proto.ParamSpecEntry.ProtoDefinition".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; }

        /// <summary>Path to the proto file that contains the message type's definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoParamSpecEntryValidationRule : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("doubleRange")]
        public virtual EnterpriseCrmEventbusProtoParamSpecEntryValidationRuleDoubleRange DoubleRange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intRange")]
        public virtual EnterpriseCrmEventbusProtoParamSpecEntryValidationRuleIntRange IntRange { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringRegex")]
        public virtual EnterpriseCrmEventbusProtoParamSpecEntryValidationRuleStringRegex StringRegex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Range used to validate doubles and floats.</summary>
    public class EnterpriseCrmEventbusProtoParamSpecEntryValidationRuleDoubleRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The inclusive maximum of the acceptable range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<double> Max { get; set; }

        /// <summary>The inclusive minimum of the acceptable range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<double> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Range used to validate longs and ints.</summary>
    public class EnterpriseCrmEventbusProtoParamSpecEntryValidationRuleIntRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The inclusive maximum of the acceptable range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<long> Max { get; set; }

        /// <summary>The inclusive minimum of the acceptable range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<long> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rule used to validate strings.</summary>
    public class EnterpriseCrmEventbusProtoParamSpecEntryValidationRuleStringRegex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the regex matcher is applied exclusively (if true, matching values will be rejected).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusive")]
        public virtual System.Nullable<bool> Exclusive { get; set; }

        /// <summary>The regex applied to the input value(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual string Regex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Key-value pair of EventBus parameters.</summary>
    public class EnterpriseCrmEventbusProtoParameterEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Key is used to retrieve the corresponding parameter value. This should be unique for a given fired event.
        /// These parameters must be predefined in the integration definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Values for the defined keys. Each value can either be string, int, double or any proto message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual EnterpriseCrmEventbusProtoParameterValueType Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic multi-map that holds key value pairs. They keys and values can be of any type, unless specified.
    /// </summary>
    public class EnterpriseCrmEventbusProtoParameterMap : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoParameterMapEntry> Entries { get; set; }

        /// <summary>
        /// Option to specify key value type for all entries of the map. If provided then field types for all entries
        /// must conform to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entry is a pair of key and value.</summary>
    public class EnterpriseCrmEventbusProtoParameterMapEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual EnterpriseCrmEventbusProtoParameterMapField Key { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual EnterpriseCrmEventbusProtoParameterMapField Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Field represents either the key or value in an entry.</summary>
    public class EnterpriseCrmEventbusProtoParameterMapField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Passing a literal value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("literalValue")]
        public virtual EnterpriseCrmEventbusProtoParameterValueType LiteralValue { get; set; }

        /// <summary>Referencing one of the WF variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceKey")]
        public virtual string ReferenceKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LINT.IfChange To support various types of parameter values. Next available id: 14</summary>
    public class EnterpriseCrmEventbusProtoParameterValueType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanArray")]
        public virtual EnterpriseCrmEventbusProtoBooleanParameterArray BooleanArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleArray")]
        public virtual EnterpriseCrmEventbusProtoDoubleParameterArray DoubleArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intArray")]
        public virtual EnterpriseCrmEventbusProtoIntParameterArray IntArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protoArray")]
        public virtual EnterpriseCrmEventbusProtoProtoParameterArray ProtoArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protoValue")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serializedObjectValue")]
        public virtual EnterpriseCrmEventbusProtoSerializedObjectParameter SerializedObjectValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringArray")]
        public virtual EnterpriseCrmEventbusProtoStringParameterArray StringArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Key-value pair of EventBus property.</summary>
    public class EnterpriseCrmEventbusProtoPropertyEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Key is used to retrieve the corresponding property value. This should be unique for a given fired event. The
        /// Tasks should be aware of the keys used while firing the events for them to be able to retrieve the values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Values for the defined keys. Each value can either be string, int, double or any proto message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual EnterpriseCrmEventbusProtoValueType Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoProtoArrayFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoProtoFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoProtoParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("protoValues")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> ProtoValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoScatterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error message of the failure if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMsg")]
        public virtual string ErrorMsg { get; set; }

        /// <summary>The execution ids of each Subworkflow fired by this scatter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionIds")]
        public virtual System.Collections.Generic.IList<string> ExecutionIds { get; set; }

        /// <summary>
        /// If execution is sync, this is true if the execution passed and false if it failed. If the execution is
        /// async, this is true if the WF was fired off successfully, and false if it failed to execute. The success or
        /// failure of the subworkflows executed are not captured.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSuccessful")]
        public virtual System.Nullable<bool> IsSuccessful { get; set; }

        /// <summary>A list of all the response parameters in the aggregtorMap stored with the remapped key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseParams")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoParameterEntry> ResponseParams { get; set; }

        /// <summary>The element that was scattered for this execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scatterElement")]
        public virtual EnterpriseCrmEventbusProtoParameterValueType ScatterElement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoSerializedObjectParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("objectValue")]
        public virtual string ObjectValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoStringArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoStringArrayFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoStringFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoStringParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("stringValues")]
        public virtual System.Collections.Generic.IList<string> StringValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policy that dictates the behavior for the task after it completes successfully.</summary>
    public class EnterpriseCrmEventbusProtoSuccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>State to which the execution snapshot status will be set if the task succeeds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalState")]
        public virtual string FinalState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LINT.IfChange</summary>
    public class EnterpriseCrmEventbusProtoSuspensionAuthPermissions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a Gaia identity for a person or service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gaiaIdentity")]
        public virtual EnterpriseCrmEventbusProtoSuspensionAuthPermissionsGaiaIdentity GaiaIdentity { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("googleGroup")]
        public virtual EnterpriseCrmEventbusProtoSuspensionAuthPermissionsGaiaIdentity GoogleGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loasRole")]
        public virtual string LoasRole { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mdbGroup")]
        public virtual string MdbGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoSuspensionAuthPermissionsGaiaIdentity : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gaiaId")]
        public virtual System.Nullable<long> GaiaId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoSuspensionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional information to provide recipients of the suspension in addition to the resolution URL, typically
        /// containing relevant parameter values from the originating workflow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMessage")]
        public virtual string CustomMessage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notifications")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoNotification> Notifications { get; set; }

        /// <summary>Indicates the next steps when no external actions happen on the suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionExpiration")]
        public virtual EnterpriseCrmEventbusProtoSuspensionExpiration SuspensionExpiration { get; set; }

        /// <summary>Identities able to resolve this suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoMayResolve")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoSuspensionAuthPermissions> WhoMayResolve { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoSuspensionExpiration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Milliseconds after which the suspension expires, if no action taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireAfterMs")]
        public virtual System.Nullable<int> ExpireAfterMs { get; set; }

        /// <summary>
        /// Whether the suspension will be REJECTED or LIFTED upon expiration. REJECTED is the default behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liftWhenExpired")]
        public virtual System.Nullable<bool> LiftWhenExpired { get; set; }

        /// <summary>
        /// Milliseconds after which the previous suspension action reminder, if any, is sent using the selected
        /// notification option, for a suspension which is still PENDING_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remindAfterMs")]
        public virtual System.Nullable<int> RemindAfterMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoSuspensionResolutionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("audit")]
        public virtual EnterpriseCrmEventbusProtoSuspensionResolutionInfoAudit Audit { get; set; }

        /// <summary>Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdTimestamp")]
        public virtual object CreatedTimestamp { get; set; }

        /// <summary>Required. ID of the associated execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionInfoId")]
        public virtual string EventExecutionInfoId { get; set; }

        /// <summary>The origin of the suspension for periodic notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalTraffic")]
        public virtual EnterpriseCrmEventbusProtoExternalTraffic ExternalTraffic { get; set; }

        /// <summary>Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTimestamp")]
        public virtual object LastModifiedTimestamp { get; set; }

        /// <summary>
        /// Which Google product the suspension belongs to. If not set, the suspension belongs to Integration Platform
        /// by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("suspensionConfig")]
        public virtual EnterpriseCrmEventbusProtoSuspensionConfig SuspensionConfig { get; set; }

        /// <summary>Primary key for the SuspensionResolutionInfoTable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionId")]
        public virtual string SuspensionId { get; set; }

        /// <summary>Required. Task number of the associated SuspensionTask.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual string TaskNumber { get; set; }

        /// <summary>Required. The name of the originating workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowName")]
        public virtual string WorkflowName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoSuspensionResolutionInfoAudit : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedBy")]
        public virtual string ResolvedBy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message to be used to configure alerting in the {@code TaskConfig} protos for tasks in an event. See
    /// go/eventbus-alert-config-examples for examples of the different alerts that can be configured.
    /// </summary>
    public class EnterpriseCrmEventbusProtoTaskAlertConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The period over which the metric value should be aggregated and evaluated. Format is , where integer should
        /// be a positive integer and unit should be one of (s,m,h,d,w) meaning (second, minute, hour, day, week).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationPeriod")]
        public virtual string AggregationPeriod { get; set; }

        /// <summary>
        /// Set to false by default. When set to true, the metrics are not aggregated or pushed to Monarch for this
        /// workflow alert.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertDisabled")]
        public virtual System.Nullable<bool> AlertDisabled { get; set; }

        /// <summary>
        /// A name to identify this alert. This will be displayed in the alert subject. If set, this name should be
        /// unique in within the scope of the containing workflow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertName")]
        public virtual string AlertName { get; set; }

        /// <summary>
        /// Client associated with this alert configuration. Must be a client enabled in one of the containing
        /// workflow's triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Should be specified only for TASK_AVERAGE_DURATION and TASK_PERCENTILE_DURATION metrics. This member should
        /// be used to specify what duration value the metrics should exceed for the alert to trigger.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationThresholdMs")]
        public virtual System.Nullable<long> DurationThresholdMs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("errorEnumList")]
        public virtual EnterpriseCrmEventbusProtoBaseAlertConfigErrorEnumList ErrorEnumList { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metricType")]
        public virtual string MetricType { get; set; }

        /// <summary>
        /// For how many contiguous aggregation periods should the expected min or max be violated for the alert to be
        /// fired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numAggregationPeriods")]
        public virtual System.Nullable<int> NumAggregationPeriods { get; set; }

        /// <summary>Only count final task attempts, not retries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyFinalAttempt")]
        public virtual System.Nullable<bool> OnlyFinalAttempt { get; set; }

        /// <summary>Link to a playbook for resolving the issue that triggered this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playbookUrl")]
        public virtual string PlaybookUrl { get; set; }

        /// <summary>
        /// The threshold type for which this alert is being configured. If value falls below expected_min or exceeds
        /// expected_max, an alert will be fired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdType")]
        public virtual string ThresholdType { get; set; }

        /// <summary>The metric value, above or below which the alert should be triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdValue")]
        public virtual EnterpriseCrmEventbusProtoBaseAlertConfigThresholdValue ThresholdValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("warningEnumList")]
        public virtual EnterpriseCrmEventbusProtoBaseAlertConfigErrorEnumList WarningEnumList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the details of the execution of this task. Next available id: 11</summary>
    public class EnterpriseCrmEventbusProtoTaskExecutionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("taskAttemptStats")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoTaskExecutionDetailsTaskAttemptStats> TaskAttemptStats { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("taskExecutionState")]
        public virtual string TaskExecutionState { get; set; }

        /// <summary>Pointer to the task config it used for execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual string TaskNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoTaskExecutionDetailsTaskAttemptStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end time of the task execution for current attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual System.Nullable<long> EndTime { get; set; }

        /// <summary>
        /// The start time of the task execution for current attempt. This could be in the future if it's been
        /// scheduled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual System.Nullable<long> StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TaskMetadata are attributes that are associated to every common Task we have. Next available: 26
    /// </summary>
    public class EnterpriseCrmEventbusProtoTaskMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new task name to replace the current task if it is deprecated. Otherwise, it is the same as the current
        /// task name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeTaskName")]
        public virtual string ActiveTaskName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("admins")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoTaskMetadataAdmin> Admins { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The Code Search link to the Task Java file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeSearchLink")]
        public virtual string CodeSearchLink { get; set; }

        /// <summary>
        /// Controls whether JSON workflow parameters are validated against provided schemas before and/or after this
        /// task's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultJsonValidationOption")]
        public virtual string DefaultJsonValidationOption { get; set; }

        /// <summary>
        /// Contains the initial configuration of the task with default values set. For now, The string should be
        /// compatible to an ASCII-proto format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSpec")]
        public virtual string DefaultSpec { get; set; }

        /// <summary>In a few sentences, describe the purpose and usage of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The string name to show on the task list on the Workflow editor screen. This should be a very short, one to
        /// two words name for the task. (e.g. "Send Mail")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptiveName")]
        public virtual string DescriptiveName { get; set; }

        /// <summary>Snippet of markdown documentation to embed in the RHP for this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docMarkdown")]
        public virtual string DocMarkdown { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalCategory")]
        public virtual string ExternalCategory { get; set; }

        /// <summary>
        /// Sequence with which the task in specific category to be displayed in task discovery panel for external
        /// users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalCategorySequence")]
        public virtual System.Nullable<int> ExternalCategorySequence { get; set; }

        /// <summary>External-facing documention embedded in the RHP for this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDocHtml")]
        public virtual string ExternalDocHtml { get; set; }

        /// <summary>Doc link for external-facing documentation (separate from g3doc).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDocLink")]
        public virtual string ExternalDocLink { get; set; }

        /// <summary>DEPRECATED: Use external_doc_html.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDocMarkdown")]
        public virtual string ExternalDocMarkdown { get; set; }

        /// <summary>URL to the associated G3 Doc for the task if available</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("g3DocLink")]
        public virtual string G3DocLink { get; set; }

        /// <summary>
        /// URL to gstatic image icon for this task. This icon shows up on the task list panel along with the task name
        /// in the Workflow Editor screen. Use the 24p, 2x, gray color icon image format. See go/icons.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconLink")]
        public virtual string IconLink { get; set; }

        /// <summary>The deprecation status of the current task. Default value is false;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDeprecated")]
        public virtual System.Nullable<bool> IsDeprecated { get; set; }

        /// <summary>
        /// The actual class name or the annotated name of the task. Task Author should initialize this field with value
        /// from the getName() method of the Task class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// External-facing documention for standalone IP in pantheon embedded in the RHP for this task. Non null only
        /// if different from external_doc_html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standaloneExternalDocHtml")]
        public virtual string StandaloneExternalDocHtml { get; set; }

        /// <summary>
        /// Allows author to indicate if the task is ready to use or not. If not set, then it will default to INACTIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("system")]
        public virtual string System { get; set; }

        /// <summary>
        /// A set of tags that pertain to a particular task. This can be used to improve the searchability of tasks with
        /// several names ("REST Caller" vs. "Call REST Endpoint") or to help users find tasks based on related words.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Admins are owners of a Task, and have all permissions on a particular task identified by the task name. By
    /// default, Eventbus periodically scans all task metadata and syncs (adds) any new admins defined here to Zanzibar.
    /// </summary>
    public class EnterpriseCrmEventbusProtoTaskMetadataAdmin : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("googleGroupEmail")]
        public virtual string GoogleGroupEmail { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Task authors would use this type to configure the UI for a particular task by specifying what UI config modules
    /// should be included to compose the UI. Learn more about config module framework:
    /// go/integration-platform-config-module-framework
    /// </summary>
    public class EnterpriseCrmEventbusProtoTaskUiConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configurations of included config modules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskUiModuleConfigs")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoTaskUiModuleConfig> TaskUiModuleConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Task author would use this type to configure a config module.</summary>
    public class EnterpriseCrmEventbusProtoTaskUiModuleConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the config module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleId")]
        public virtual string ModuleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoTeardown : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teardownTaskConfigs")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoTeardownTaskConfig> TeardownTaskConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoTeardownTaskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creator's email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorEmail")]
        public virtual string CreatorEmail { get; set; }

        /// <summary>
        /// Required. Unique identifier of the teardown task within this Config. We use this field as the identifier to
        /// find next teardown tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextTeardownTask")]
        public virtual EnterpriseCrmEventbusProtoNextTeardownTask NextTeardownTask { get; set; }

        /// <summary>The parameters the user can pass to this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual EnterpriseCrmEventbusProtoEventParameters Parameters { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual EnterpriseCrmEventbusProtoEventBusProperties Properties { get; set; }

        /// <summary>Required. Implementation class name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teardownTaskImplementationClassName")]
        public virtual string TeardownTaskImplementationClassName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoToken : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoTransformExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Initial value upon which to perform transformations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialValue")]
        public virtual EnterpriseCrmEventbusProtoBaseValue InitialValue { get; set; }

        /// <summary>Transformations to be applied sequentially.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformationFunctions")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoFunction> TransformationFunctions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusProtoTriggerCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Standard filter expression, when true the workflow will be executed. If there's no
        /// trigger_criteria_task_implementation_class_name specified, the condition will be validated directly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>Optional. To be used in TaskConfig for the implementation class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual EnterpriseCrmEventbusProtoEventParameters Parameters { get; set; }

        /// <summary>
        /// Optional. Implementation class name. The class should implement the “TypedTask” interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerCriteriaTaskImplementationClassName")]
        public virtual string TriggerCriteriaTaskImplementationClassName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used for define type for values. Currently supported value types include int, string, double, array, and any
    /// proto message.
    /// </summary>
    public class EnterpriseCrmEventbusProtoValueType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleArray")]
        public virtual EnterpriseCrmEventbusProtoDoubleArray DoubleArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intArray")]
        public virtual EnterpriseCrmEventbusProtoIntArray IntArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protoValue")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringArray")]
        public virtual EnterpriseCrmEventbusProtoStringArray StringArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message to be used to configure custom alerting in the {@code EventConfig} protos for an event. See
    /// go/eventbus-alert-config-examples for examples of the different alerts that can be configured.
    /// </summary>
    public class EnterpriseCrmEventbusProtoWorkflowAlertConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For an EXPECTED_MIN threshold, this aggregation_period must be lesser than 24 hours.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationPeriod")]
        public virtual string AggregationPeriod { get; set; }

        /// <summary>
        /// Set to false by default. When set to true, the metrics are not aggregated or pushed to Monarch for this
        /// workflow alert.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertDisabled")]
        public virtual System.Nullable<bool> AlertDisabled { get; set; }

        /// <summary>
        /// A name to identify this alert. This will be displayed in the alert subject. If set, this name should be
        /// unique within the scope of the workflow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertName")]
        public virtual string AlertName { get; set; }

        /// <summary>Client associated with this alert configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Should be specified only for *AVERAGE_DURATION and *PERCENTILE_DURATION metrics. This member should be used
        /// to specify what duration value the metrics should exceed for the alert to trigger.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationThresholdMs")]
        public virtual System.Nullable<long> DurationThresholdMs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("errorEnumList")]
        public virtual EnterpriseCrmEventbusProtoBaseAlertConfigErrorEnumList ErrorEnumList { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("metricType")]
        public virtual string MetricType { get; set; }

        /// <summary>
        /// For how many contiguous aggregation periods should the expected min or max be violated for the alert to be
        /// fired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numAggregationPeriods")]
        public virtual System.Nullable<int> NumAggregationPeriods { get; set; }

        /// <summary>
        /// For either events or tasks, depending on the type of alert, count only final attempts, not retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyFinalAttempt")]
        public virtual System.Nullable<bool> OnlyFinalAttempt { get; set; }

        /// <summary>Link to a playbook for resolving the issue that triggered this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playbookUrl")]
        public virtual string PlaybookUrl { get; set; }

        /// <summary>
        /// The threshold type, whether lower(expected_min) or upper(expected_max), for which this alert is being
        /// configured. If value falls below expected_min or exceeds expected_max, an alert will be fired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdType")]
        public virtual string ThresholdType { get; set; }

        /// <summary>
        /// The metric value, above or below which the alert should be triggered. See go/eventbus-alert-config-examples.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdValue")]
        public virtual EnterpriseCrmEventbusProtoBaseAlertConfigThresholdValue ThresholdValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("warningEnumList")]
        public virtual EnterpriseCrmEventbusProtoBaseAlertConfigErrorEnumList WarningEnumList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stats for the requested dimensions: QPS, duration, and error/warning rate</summary>
    public class EnterpriseCrmEventbusStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dimensions that these stats have been aggregated on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual EnterpriseCrmEventbusStatsDimensions Dimensions { get; set; }

        /// <summary>Average duration in seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationInSeconds")]
        public virtual System.Nullable<double> DurationInSeconds { get; set; }

        /// <summary>Average error rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorRate")]
        public virtual System.Nullable<double> ErrorRate { get; set; }

        /// <summary>Queries per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qps")]
        public virtual System.Nullable<double> Qps { get; set; }

        /// <summary>Average warning rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningRate")]
        public virtual System.Nullable<double> WarningRate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmEventbusStatsDimensions : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Whether to include or exclude the enums matching the regex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumFilterType")]
        public virtual string EnumFilterType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("errorEnumString")]
        public virtual string ErrorEnumString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("retryAttempt")]
        public virtual string RetryAttempt { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("taskName")]
        public virtual string TaskName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual string TaskNumber { get; set; }

        /// <summary>
        /// Stats have been or will be aggregated on set fields for any semantically-meaningful combination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("warningEnumString")]
        public virtual string WarningEnumString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("workflowId")]
        public virtual string WorkflowId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("workflowName")]
        public virtual string WorkflowName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoBooleanParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<bool>> BooleanValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoDoubleParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> DoubleValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the details of the execution info of this event: this includes the tasks execution details plus the
    /// event execution statistics. Next available id: 10
    /// </summary>
    public class EnterpriseCrmFrontendsEventbusProtoEventExecutionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eventAttemptStats")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoEventExecutionDetailsEventAttemptStats> EventAttemptStats { get; set; }

        /// <summary>
        /// After snapshot migration, this field will no longer be populated, but old execution snapshots will still be
        /// accessible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionSnapshot")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoEventExecutionSnapshot> EventExecutionSnapshot { get; set; }

        /// <summary>The execution state of this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionState")]
        public virtual string EventExecutionState { get; set; }

        /// <summary>Indicates the number of times the execution has restarted from the beginning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventRetriesFromBeginningCount")]
        public virtual System.Nullable<int> EventRetriesFromBeginningCount { get; set; }

        /// <summary>The log file path (aka. cns address) for this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logFilePath")]
        public virtual string LogFilePath { get; set; }

        /// <summary>
        /// The network address (aka. bns address) that indicates where the event executor is running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkAddress")]
        public virtual string NetworkAddress { get; set; }

        /// <summary>Next scheduled execution time in case the execution status was RETRY_ON_HOLD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextExecutionTime")]
        public virtual System.Nullable<long> NextExecutionTime { get; set; }

        /// <summary>
        /// Used internally and shouldn't be exposed to users. A counter for the cron job to record how many times this
        /// event is in in_process state but don't have a lock consecutively/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ryeLockUnheldCount")]
        public virtual System.Nullable<int> RyeLockUnheldCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains all the execution details for a workflow instance. Next available id: 24</summary>
    public class EnterpriseCrmFrontendsEventbusProtoEventExecutionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The event data user sends as request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual System.Nullable<long> CreateTime { get; set; }

        /// <summary>Final error-code if event failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual CrmlogErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Errors, warnings, and informationals associated with the workflow/task. The order in which the errors were
        /// added by the workflow/task is maintained.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoErrorDetail> Errors { get; set; }

        /// <summary>The execution info about this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionDetails")]
        public virtual EnterpriseCrmFrontendsEventbusProtoEventExecutionDetails EventExecutionDetails { get; set; }

        /// <summary>Auto-generated primary key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionInfoId")]
        public virtual string EventExecutionInfoId { get; set; }

        /// <summary>Execution trace info to aggregate parent-child executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionTraceInfo")]
        public virtual EnterpriseCrmEventbusProtoExecutionTraceInfo ExecutionTraceInfo { get; set; }

        /// <summary>Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual System.Nullable<long> LastModifiedTime { get; set; }

        /// <summary>The ways user posts this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postMethod")]
        public virtual string PostMethod { get; set; }

        /// <summary>
        /// Which Google product the execution_info belongs to. If not set, the execution_info belongs to Integration
        /// Platform by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>Optional. This is used to de-dup incoming request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>Event parameters come in as part of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestParams")]
        public virtual EnterpriseCrmFrontendsEventbusProtoEventParameters RequestParams { get; set; }

        /// <summary>Event parameters come out as part of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseParams")]
        public virtual EnterpriseCrmFrontendsEventbusProtoEventParameters ResponseParams { get; set; }

        /// <summary>Workflow snapshot number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotNumber")]
        public virtual System.Nullable<long> SnapshotNumber { get; set; }

        /// <summary>Tenant this event is created. Used to reschedule the event to correct tenant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenant")]
        public virtual string Tenant { get; set; }

        /// <summary>
        /// The trigger id of the workflow trigger config. If both trigger_id and client_id is present, the workflow is
        /// executed from the start tasks provided by the matching trigger config otherwise it is executed from the
        /// default start tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>Required. Pointer to the workflow it is executing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowId")]
        public virtual string WorkflowId { get; set; }

        /// <summary>Name of the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowName")]
        public virtual string WorkflowName { get; set; }

        /// <summary>
        /// Time interval in seconds to schedule retry of workflow in manifold when workflow is already running
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowRetryBackoffIntervalSeconds")]
        public virtual System.Nullable<long> WorkflowRetryBackoffIntervalSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoEventExecutionSnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates "right after which checkpoint task's execution" this snapshot is taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkpointTaskNumber")]
        public virtual string CheckpointTaskNumber { get; set; }

        /// <summary>All of the computed conditions that been calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionResults")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoConditionResult> ConditionResults { get; set; }

        /// <summary>The parameters in Event object that differs from last snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffParams")]
        public virtual EnterpriseCrmFrontendsEventbusProtoEventParameters DiffParams { get; set; }

        /// <summary>Points to the event execution info this snapshot belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionInfoId")]
        public virtual string EventExecutionInfoId { get; set; }

        /// <summary>Auto-generated. Used as primary key for EventExecutionSnapshots table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionSnapshotId")]
        public virtual string EventExecutionSnapshotId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionSnapshotMetadata")]
        public virtual EnterpriseCrmEventbusProtoEventExecutionSnapshotEventExecutionSnapshotMetadata EventExecutionSnapshotMetadata { get; set; }

        /// <summary>The parameters in Event object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventParams")]
        public virtual EnterpriseCrmFrontendsEventbusProtoEventParameters EventParams { get; set; }

        /// <summary>Indicates when this snapshot is taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotTime")]
        public virtual System.Nullable<long> SnapshotTime { get; set; }

        /// <summary>All of the task execution details at the given point of time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskExecutionDetails")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoTaskExecutionDetails> TaskExecutionDetails { get; set; }

        /// <summary>The task name associated with this snapshot. Could be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskName")]
        public virtual string TaskName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// LINT.IfChange This message is used for processing and persisting (when applicable) key value pair parameters for
    /// each event in the event bus. Please see go/integration-platform/event_bus.md for more details. Next id: 4
    /// </summary>
    public class EnterpriseCrmFrontendsEventbusProtoEventParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Parameters are a part of Event and can be used to communicate between different tasks that are part of the
        /// same workflow execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoParameterEntry> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoIntParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("intValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> IntValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Key-value pair of EventBus task parameters. Next id: 13</summary>
    public class EnterpriseCrmFrontendsEventbusProtoParamSpecEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The FQCN of the Java object this represents. A string, for example, would be "java.lang.String". If this is
        /// "java.lang.Object", the parameter can be of any type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("className")]
        public virtual string ClassName { get; set; }

        /// <summary>
        /// If it is a collection of objects, this would be the FCQN of every individual element in the collection. If
        /// this is "java.lang.Object", the parameter is a collection of any type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionElementClassName")]
        public virtual string CollectionElementClassName { get; set; }

        /// <summary>Optional fields, such as help text and other useful info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual EnterpriseCrmEventbusProtoParamSpecEntryConfig Config { get; set; }

        /// <summary>The data type of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// Default values for the defined keys. Each value can either be string, int, double or any proto message or a
        /// serialized object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual EnterpriseCrmFrontendsEventbusProtoParameterValueType DefaultValue { get; set; }

        /// <summary>If set, this entry is deprecated, so further use of this parameter should be prohibited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDeprecated")]
        public virtual System.Nullable<bool> IsDeprecated { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("isOutput")]
        public virtual System.Nullable<bool> IsOutput { get; set; }

        /// <summary>If the data_type is JSON_VALUE, then this will define its schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual string JsonSchema { get; set; }

        /// <summary>
        /// Key is used to retrieve the corresponding parameter value. This should be unique for a given task. These
        /// parameters must be predefined in the workflow definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Populated if this represents a proto or proto array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoDef")]
        public virtual EnterpriseCrmEventbusProtoParamSpecEntryProtoDefinition ProtoDef { get; set; }

        /// <summary>If set, the user must provide an input value for this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>
        /// Rule used to validate inputs (individual values and collection elements) for this parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationRule")]
        public virtual EnterpriseCrmEventbusProtoParamSpecEntryValidationRule ValidationRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoParamSpecsMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoParamSpecEntry> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Key-value pair of EventBus parameters.</summary>
    public class EnterpriseCrmFrontendsEventbusProtoParameterEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explicitly getting the type of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// Key is used to retrieve the corresponding parameter value. This should be unique for a given fired event.
        /// These parameters must be predefined in the workflow definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Values for the defined keys. Each value can either be string, int, double or any proto message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual EnterpriseCrmFrontendsEventbusProtoParameterValueType Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic multi-map that holds key value pairs. They keys and values can be of any type, unless specified.
    /// </summary>
    public class EnterpriseCrmFrontendsEventbusProtoParameterMap : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoParameterMapEntry> Entries { get; set; }

        /// <summary>
        /// Option to specify key value type for all entries of the map. If provided then field types for all entries
        /// must conform to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entry is a pair of key and value.</summary>
    public class EnterpriseCrmFrontendsEventbusProtoParameterMapEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual EnterpriseCrmFrontendsEventbusProtoParameterMapField Key { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual EnterpriseCrmFrontendsEventbusProtoParameterMapField Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Field represents either the key or value in an entry.</summary>
    public class EnterpriseCrmFrontendsEventbusProtoParameterMapField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Passing a literal value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("literalValue")]
        public virtual EnterpriseCrmFrontendsEventbusProtoParameterValueType LiteralValue { get; set; }

        /// <summary>Referencing one of the WF variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceKey")]
        public virtual string ReferenceKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>To support various types of parameter values. Next available id: 14</summary>
    public class EnterpriseCrmFrontendsEventbusProtoParameterValueType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("booleanArray")]
        public virtual EnterpriseCrmFrontendsEventbusProtoBooleanParameterArray BooleanArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleArray")]
        public virtual EnterpriseCrmFrontendsEventbusProtoDoubleParameterArray DoubleArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intArray")]
        public virtual EnterpriseCrmFrontendsEventbusProtoIntParameterArray IntArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("jsonValue")]
        public virtual string JsonValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protoArray")]
        public virtual EnterpriseCrmFrontendsEventbusProtoProtoParameterArray ProtoArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protoValue")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serializedObjectValue")]
        public virtual EnterpriseCrmFrontendsEventbusProtoSerializedObjectParameter SerializedObjectValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringArray")]
        public virtual EnterpriseCrmFrontendsEventbusProtoStringParameterArray StringArray { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoProtoParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("protoValues")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> ProtoValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Next available id: 4</summary>
    public class EnterpriseCrmFrontendsEventbusProtoRollbackStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The customized parameters the user can pass to this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual EnterpriseCrmFrontendsEventbusProtoEventParameters Parameters { get; set; }

        /// <summary>
        /// Required. This is the name of the task that needs to be executed upon rollback of this task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollbackTaskImplementationClassName")]
        public virtual string RollbackTaskImplementationClassName { get; set; }

        /// <summary>
        /// Required. These are the tasks numbers of the tasks whose
        /// `rollback_strategy.rollback_task_implementation_class_name` needs to be executed upon failure of this task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumbersToRollback")]
        public virtual System.Collections.Generic.IList<string> TaskNumbersToRollback { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoSerializedObjectParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("objectValue")]
        public virtual string ObjectValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoStringParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("stringValues")]
        public virtual System.Collections.Generic.IList<string> StringValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The task configuration details. This is not the implementation of Task. There might be multiple TaskConfigs for
    /// the same Task. Next available id: 27
    /// </summary>
    public class EnterpriseCrmFrontendsEventbusProtoTaskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Alert configurations on error rate, warning rate, number of runs, durations, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertConfigs")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoTaskAlertConfig> AlertConfigs { get; set; }

        /// <summary>Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The creator's email address. Auto-generated from the user's email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorEmail")]
        public virtual string CreatorEmail { get; set; }

        /// <summary>User-provided description intended to give more business context about the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// If this config contains a TypedTask, allow validation to succeed if an input is read from the output of
        /// another TypedTask whose output type is declared as a superclass of the requested input type. For instance,
        /// if the previous task declares an output of type Message, any task with this flag enabled will pass
        /// validation when attempting to read any proto Message type from the resultant Event parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableStrictTypeValidation")]
        public virtual System.Nullable<bool> DisableStrictTypeValidation { get; set; }

        /// <summary>
        /// Optional. Determines the number of times the task will be retried on failure and with what retry strategy.
        /// This is applicable for asynchronous calls to Eventbus alone (Post To Queue, Schedule etc.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failurePolicy")]
        public virtual EnterpriseCrmEventbusProtoFailurePolicy FailurePolicy { get; set; }

        /// <summary>The number of edges leading into this TaskConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incomingEdgeCount")]
        public virtual System.Nullable<int> IncomingEdgeCount { get; set; }

        /// <summary>If set, overrides the option configured in the Task implementation class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonValidationOption")]
        public virtual string JsonValidationOption { get; set; }

        /// <summary>User-provided label that is attached to this TaskConfig in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifiedTime")]
        public virtual object LastModifiedTime { get; set; }

        /// <summary>
        /// The set of tasks that are next in line to be executed as per the execution graph defined for the parent
        /// event, specified by `event_config_id`. Each of these next tasks are executed only if the condition
        /// associated with them evaluates to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextTasks")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoNextTask> NextTasks { get; set; }

        /// <summary>The policy dictating the execution of the next set of tasks for the current task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextTasksExecutionPolicy")]
        public virtual string NextTasksExecutionPolicy { get; set; }

        /// <summary>The customized parameters the user can pass to this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, EnterpriseCrmFrontendsEventbusProtoParameterEntry> Parameters { get; set; }

        /// <summary>Optional. Informs the front-end application where to draw this task config on the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual EnterpriseCrmEventbusProtoCoordinate Position { get; set; }

        /// <summary>
        /// Optional. Standard filter expression evaluated before execution. Independent of other conditions and tasks.
        /// Can be used to enable rollout. e.g. "rollout(5)" will only allow 5% of incoming traffic to task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("precondition")]
        public virtual string Precondition { get; set; }

        /// <summary>Optional. User-provided label that is attached to precondition in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preconditionLabel")]
        public virtual string PreconditionLabel { get; set; }

        /// <summary>
        /// Optional. Contains information about what needs to be done upon failure (either a permanent error or after
        /// it has been retried too many times).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollbackStrategy")]
        public virtual EnterpriseCrmFrontendsEventbusProtoRollbackStrategy RollbackStrategy { get; set; }

        /// <summary>Determines what action to take upon successful task completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successPolicy")]
        public virtual EnterpriseCrmEventbusProtoSuccessPolicy SuccessPolicy { get; set; }

        /// <summary>
        /// Optional. Determines the number of times the task will be retried on failure and with what retry strategy.
        /// This is applicable for synchronous calls to Eventbus alone (Post).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synchronousCallFailurePolicy")]
        public virtual EnterpriseCrmEventbusProtoFailurePolicy SynchronousCallFailurePolicy { get; set; }

        /// <summary>Copy of the task entity that this task config is an instance of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskEntity")]
        public virtual EnterpriseCrmFrontendsEventbusProtoTaskEntity TaskEntity { get; set; }

        /// <summary>The policy dictating the execution strategy of this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskExecutionStrategy")]
        public virtual string TaskExecutionStrategy { get; set; }

        /// <summary>The name for the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskName")]
        public virtual string TaskName { get; set; }

        /// <summary>
        /// REQUIRED: the identifier of this task within its parent event config, specified by the client. This should
        /// be unique among all the tasks belong to the same event config. We use this field as the identifier to find
        /// next tasks (via field `next_tasks.task_number`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual string TaskNumber { get; set; }

        /// <summary>
        /// A string template that allows user to configure task parameters (with either literal default values or
        /// tokens which will be resolved at execution time) for the task. It will eventually replace the old
        /// "parameters" field. Please refer to go/eventbus-task-spec-example for detailed usage example.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskSpec")]
        public virtual string TaskSpec { get; set; }

        /// <summary>Used to define task-template name if task is of type task-template</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskTemplateName")]
        public virtual string TaskTemplateName { get; set; }

        /// <summary>Defines the type of the task</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskType")]
        public virtual string TaskType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a task's metadata and associated information. Next available id: 7</summary>
    public class EnterpriseCrmFrontendsEventbusProtoTaskEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the task has conflict with vpcsc</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabledForVpcSc")]
        public virtual System.Nullable<bool> DisabledForVpcSc { get; set; }

        /// <summary>Metadata inclueds the task name, author and so on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual EnterpriseCrmEventbusProtoTaskMetadata Metadata { get; set; }

        /// <summary>
        /// Declarations for inputs/outputs for a TypedTask. This is also associated with the METADATA mask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paramSpecs")]
        public virtual EnterpriseCrmFrontendsEventbusProtoParamSpecsMessage ParamSpecs { get; set; }

        /// <summary>Deprecated - statistics from the Monarch query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual EnterpriseCrmEventbusStats Stats { get; set; }

        /// <summary>Defines the type of the task</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskType")]
        public virtual string TaskType { get; set; }

        /// <summary>UI configuration for this task Also associated with the METADATA mask.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uiConfig")]
        public virtual EnterpriseCrmEventbusProtoTaskUiConfig UiConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration detail of a trigger. Next available id: 17</summary>
    public class EnterpriseCrmFrontendsEventbusProtoTriggerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An alert threshold configuration for the [trigger + client + workflow] tuple. If these values are not
        /// specified in the trigger config, default values will be populated by the system. Note that there must be
        /// exactly one alert threshold configured per [client + trigger + workflow] when published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertConfig")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoWorkflowAlertConfig> AlertConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudSchedulerConfig")]
        public virtual EnterpriseCrmEventbusProtoCloudSchedulerConfig CloudSchedulerConfig { get; set; }

        /// <summary>User-provided description intended to give more business context about the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The list of client ids which are enabled to execute the workflow using this trigger. In other
        /// words, these clients have the workflow execution privledges for this trigger. For API trigger, the client id
        /// in the incoming request is validated against the list of enabled clients. For non-API triggers, one workflow
        /// execution is triggered on behalf of each enabled client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledClients")]
        public virtual System.Collections.Generic.IList<string> EnabledClients { get; set; }

        /// <summary>The user created label for a particular trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Dictates how next tasks will be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextTasksExecutionPolicy")]
        public virtual string NextTasksExecutionPolicy { get; set; }

        /// <summary>
        /// Optional. If set to true, any upcoming requests for this trigger config will be paused and the executions
        /// will be resumed later when the flag is reset. The workflow to which this trigger config belongs has to be in
        /// ACTIVE status for the executions to be paused or resumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pauseWorkflowExecutions")]
        public virtual System.Nullable<bool> PauseWorkflowExecutions { get; set; }

        /// <summary>Optional. Informs the front-end application where to draw this trigger config on the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual EnterpriseCrmEventbusProtoCoordinate Position { get; set; }

        /// <summary>
        /// Configurable properties of the trigger, not to be confused with workflow parameters. E.g. "name" is a
        /// property for API triggers and "subscription" is a property for Cloud Pubsub triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Set of tasks numbers from where the workflow execution is started by this trigger. If this is empty, then
        /// workflow is executed with default start tasks. In the list of start tasks, none of two tasks can have direct
        /// ancestor-descendant relationships (i.e. in a same workflow execution graph).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTasks")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoNextTask> StartTasks { get; set; }

        /// <summary>
        /// Optional. When set, Eventbus will run the task specified in the trigger_criteria and validate the result
        /// using the trigger_criteria.condition, and only execute the workflow when result is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerCriteria")]
        public virtual EnterpriseCrmEventbusProtoTriggerCriteria TriggerCriteria { get; set; }

        /// <summary>The backend trigger ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>Required. A number to uniquely identify each trigger config within the workflow on UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerNumber")]
        public virtual string TriggerNumber { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("triggerType")]
        public virtual string TriggerType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnterpriseCrmFrontendsEventbusProtoWorkflowParameterEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata information about the parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual EnterpriseCrmEventbusProtoAttributes Attributes { get; set; }

        /// <summary>
        /// Child parameters nested within this parameter. This field only applies to protobuf parameters
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("children")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoWorkflowParameterEntry> Children { get; set; }

        /// <summary>The data type of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// Default values for the defined keys. Each value can either be string, int, double or any proto message or a
        /// serialized object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual EnterpriseCrmFrontendsEventbusProtoParameterValueType DefaultValue { get; set; }

        /// <summary>Specifies the input/output type for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inOutType")]
        public virtual string InOutType { get; set; }

        /// <summary>Whether this parameter is a transient parameter. go/ip-transient-parameters</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTransient")]
        public virtual System.Nullable<bool> IsTransient { get; set; }

        /// <summary>This schema will be used to validate runtime JSON-typed values of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual string JsonSchema { get; set; }

        /// <summary>
        /// Key is used to retrieve the corresponding parameter value. This should be unique for a given fired event.
        /// These parameters must be predefined in the workflow definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The name (without prefix) to be displayed in the UI for this parameter. E.g. if the key is "foo.bar.myName",
        /// then the name would be "myName".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The identifier of the node (TaskConfig/TriggerConfig) this parameter was produced by, if it is a transient
        /// param or a copy of an input param.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producedBy")]
        public virtual EnterpriseCrmEventbusProtoNodeIdentifier ProducedBy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("producer")]
        public virtual string Producer { get; set; }

        /// <summary>The name of the protobuf type if the parameter has a protobuf data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoDefName")]
        public virtual string ProtoDefName { get; set; }

        /// <summary>
        /// If the data type is of type proto or proto array, this field needs to be populated with the fully qualified
        /// proto name. This message, for example, would be
        /// "enterprise.crm.frontends.eventbus.proto.WorkflowParameterEntry".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoDefPath")]
        public virtual string ProtoDefPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// LINT.IfChange This is the frontend version of WorkflowParameters. It's exactly like the backend version except
    /// that instead of flattening protobuf parameters and treating every field and subfield of a protobuf parameter as
    /// a separate parameter, the fields/subfields of a protobuf parameter will be nested as "children" (see 'children'
    /// field below) parameters of the parent parameter. Please refer to
    /// enterprise/crm/eventbus/proto/workflow_parameters.proto for more information about WorkflowParameters.
    /// </summary>
    public class EnterpriseCrmFrontendsEventbusProtoWorkflowParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Parameters are a part of Event and can be used to communiticate between different tasks that are part of the
        /// same workflow execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoWorkflowParameterEntry> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes string and array limits when writing to logs. When a limit is exceeded the *shortener_type* describes
    /// how to shorten the field. next_id: 6
    /// </summary>
    public class EnterpriseCrmLoggingGwsFieldLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("logAction")]
        public virtual string LogAction { get; set; }

        /// <summary>To which type(s) of logs the limits apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual System.Collections.Generic.IList<string> LogType { get; set; }

        /// <summary>maximum array size. If the array exceds this size, the field (list) is truncated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxArraySize")]
        public virtual System.Nullable<int> MaxArraySize { get; set; }

        /// <summary>maximum string length. If the field exceeds this amount the field is shortened.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxStringLength")]
        public virtual System.Nullable<int> MaxStringLength { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("shortenerType")]
        public virtual string ShortenerType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies whether a field contains, or may contain, PII or sensitive data, and how to sanitize the field if it
    /// does. If a field's privacy type cannot be determined then it is sanitized (e.g., scrubbed). The specific
    /// sanitizer implementation is determined by run-time configuration and environment options (e.g., prod vs. qa).
    /// next_id: 5
    /// </summary>
    public class EnterpriseCrmLoggingGwsSanitizeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the value has already been sanitized and needs no further sanitization. For instance, a D3 customer
        /// id is already an obfuscated entity and *might not* need further sanitization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAlreadySanitized")]
        public virtual System.Nullable<bool> IsAlreadySanitized { get; set; }

        /// <summary>To which type(s) of logs the sanitize options apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual System.Collections.Generic.IList<string> LogType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("privacy")]
        public virtual string Privacy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sanitizeType")]
        public virtual string SanitizeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthConfig defines details of a authentication type.</summary>
    public class GoogleCloudConnectorsV1AuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List containing additional auth configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalVariables")]
        public virtual System.Collections.Generic.IList<GoogleCloudConnectorsV1ConfigVariable> AdditionalVariables { get; set; }

        /// <summary>The type of authentication configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authType")]
        public virtual string AuthType { get; set; }

        /// <summary>Oauth2ClientCredentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientCredentials")]
        public virtual GoogleCloudConnectorsV1AuthConfigOauth2ClientCredentials Oauth2ClientCredentials { get; set; }

        /// <summary>Oauth2JwtBearer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2JwtBearer")]
        public virtual GoogleCloudConnectorsV1AuthConfigOauth2JwtBearer Oauth2JwtBearer { get; set; }

        /// <summary>SSH Public Key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKey")]
        public virtual GoogleCloudConnectorsV1AuthConfigSshPublicKey SshPublicKey { get; set; }

        /// <summary>UserPassword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPassword")]
        public virtual GoogleCloudConnectorsV1AuthConfigUserPassword UserPassword { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support Oauth 2.0 Client Credentials Grant Authentication. See
    /// https://tools.ietf.org/html/rfc6749#section-1.3.4 for more details.
    /// </summary>
    public class GoogleCloudConnectorsV1AuthConfigOauth2ClientCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The client identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Secret version reference containing the client secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual GoogleCloudConnectorsV1Secret ClientSecret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support JSON Web Token (JWT) Profile for Oauth 2.0 Authorization Grant based authentication. See
    /// https://tools.ietf.org/html/rfc7523 for more details.
    /// </summary>
    public class GoogleCloudConnectorsV1AuthConfigOauth2JwtBearer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Secret version reference containing a PKCS#8 PEM-encoded private key associated with the Client Certificate.
        /// This private key will be used to sign JWTs used for the jwt-bearer authorization grant. Specified in the
        /// form as: `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual GoogleCloudConnectorsV1Secret ClientKey { get; set; }

        /// <summary>JwtClaims providers fields to generate the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwtClaims")]
        public virtual GoogleCloudConnectorsV1AuthConfigOauth2JwtBearerJwtClaims JwtClaims { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JWT claims used for the jwt-bearer authorization grant.</summary>
    public class GoogleCloudConnectorsV1AuthConfigOauth2JwtBearerJwtClaims : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value for the "aud" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>Value for the "iss" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        /// <summary>Value for the "sub" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to support Ssh public key Authentication.</summary>
    public class GoogleCloudConnectorsV1AuthConfigSshPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Format of SSH Client cert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certType")]
        public virtual string CertType { get; set; }

        /// <summary>SSH Client Cert. It should contain both public and private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshClientCert")]
        public virtual GoogleCloudConnectorsV1Secret SshClientCert { get; set; }

        /// <summary>Password (passphrase) for ssh client certificate if it has one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshClientCertPass")]
        public virtual GoogleCloudConnectorsV1Secret SshClientCertPass { get; set; }

        /// <summary>The user account used to authenticate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to support Username and Password Authentication.</summary>
    public class GoogleCloudConnectorsV1AuthConfigUserPassword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Secret version reference containing the password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual GoogleCloudConnectorsV1Secret Password { get; set; }

        /// <summary>Username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConfigVariable represents a configuration variable present in a Connection. or AuthConfig.</summary>
    public class GoogleCloudConnectorsV1ConfigVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value is a bool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Value is an integer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Key of the config variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value is a secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretValue")]
        public virtual GoogleCloudConnectorsV1Secret SecretValue { get; set; }

        /// <summary>Value is a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Connection represents an instance of connector.</summary>
    public class GoogleCloudConnectorsV1Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Configuration for establishing the connection's authentication with an external system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual GoogleCloudConnectorsV1AuthConfig AuthConfig { get; set; }

        /// <summary>Optional. Configuration for configuring the connection with an external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configVariables")]
        public virtual System.Collections.Generic.IList<GoogleCloudConnectorsV1ConfigVariable> ConfigVariables { get; set; }

        /// <summary>
        /// Required. Connector version on which the connection is created. The format is:
        /// projects/*/locations/*/providers/*/connectors/*/versions/* Only global location is supported for
        /// ConnectorVersion resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorVersion")]
        public virtual string ConnectorVersion { get; set; }

        /// <summary>Output only. Created time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Optional. Description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Configuration of the Connector's destination. Only accepted for Connectors that accepts user
        /// defined destination(s).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudConnectorsV1DestinationConfig> DestinationConfigs { get; set; }

        /// <summary>
        /// Output only. GCR location where the envoy image is stored. formatted like: gcr.io/{bucketName}/{imageName}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envoyImageLocation")]
        public virtual string EnvoyImageLocation { get; set; }

        /// <summary>
        /// Output only. GCR location where the runtime image is stored. formatted like: gcr.io/{bucketName}/{imageName}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageLocation")]
        public virtual string ImageLocation { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Configuration that indicates whether or not the Connection can be edited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockConfig")]
        public virtual GoogleCloudConnectorsV1LockConfig LockConfig { get; set; }

        /// <summary>
        /// Output only. Resource name of the Connection. Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Configuration for the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeConfig")]
        public virtual GoogleCloudConnectorsV1NodeConfig NodeConfig { get; set; }

        /// <summary>Optional. Service account needed for runtime plane to access GCP resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Output only. The name of the Service Directory service name. Used for Private Harpoon to resolve the ILB
        /// address. e.g.
        /// "projects/cloud-connectors-e2e-testing/locations/us-central1/namespaces/istio-system/services/istio-ingressgateway-connectors"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectory")]
        public virtual string ServiceDirectory { get; set; }

        /// <summary>Output only. Current status of the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleCloudConnectorsV1ConnectionStatus Status { get; set; }

        /// <summary>Optional. Suspended indicates if a user has suspended a connection or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; }

        /// <summary>Output only. Updated time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConnectionStatus indicates the state of the connection.</summary>
    public class GoogleCloudConnectorsV1ConnectionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>State.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Status provides detailed information for the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudConnectorsV1Destination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For publicly routable host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>The port is the target port number that is accepted by the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>PSC service attachments. Format: projects/*/regions/*/serviceAttachments/*</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachment")]
        public virtual string ServiceAttachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Define the Connectors target endpoint.</summary>
    public class GoogleCloudConnectorsV1DestinationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The destinations for the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<GoogleCloudConnectorsV1Destination> Destinations { get; set; }

        /// <summary>The key is the destination identifier that is supported by the Connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Determines whether or no a connection is locked. If locked, a reason must be specified.</summary>
    public class GoogleCloudConnectorsV1LockConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether or not the connection is locked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locked")]
        public virtual System.Nullable<bool> Locked { get; set; }

        /// <summary>Describes why a connection is locked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the connection.</summary>
    public class GoogleCloudConnectorsV1NodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum number of nodes in the runtime nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNodeCount")]
        public virtual System.Nullable<int> MaxNodeCount { get; set; }

        /// <summary>Minimum number of nodes in the runtime nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minNodeCount")]
        public virtual System.Nullable<int> MinNodeCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Secret provides a reference to entries in Secret Manager.</summary>
    public class GoogleCloudConnectorsV1Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the secret version in the format, format as: `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretVersion")]
        public virtual string SecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The access token represents the authorization of a specific application to access specific parts of a user’s
    /// data.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaAccessToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The access token encapsulating the security identity of a process or thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual string AccessToken { get; set; }

        /// <summary>Required. The approximate time until the access token retrieved is valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessTokenExpireTime")]
        public virtual object AccessTokenExpireTime { get; set; }

        /// <summary>If the access token will expire, use the refresh token to obtain another access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshToken")]
        public virtual string RefreshToken { get; set; }

        /// <summary>The approximate time until the refresh token retrieved is valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshTokenExpireTime")]
        public virtual object RefreshTokenExpireTime { get; set; }

        /// <summary>
        /// Only support "bearer" token in v1 as bearer token is the predominant type used with OAuth 2.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenType")]
        public virtual string TokenType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for ArchiveBundle.</summary>
    public class GoogleCloudIntegrationsV1alphaArchiveBundleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ArchiveBundle.</summary>
    public class GoogleCloudIntegrationsV1alphaArchiveBundleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for ArchiveIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ArchiveIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaArchiveIntegrationVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status for the execution attempt.</summary>
    public class GoogleCloudIntegrationsV1alphaAttemptStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end time of the event execution for current attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The start time of the event execution for current attempt. This could be in the future if it's been
        /// scheduled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The AuthConfig resource use to hold channels and connection config data.</summary>
    public class GoogleCloudIntegrationsV1alphaAuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Certificate id for client certificate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateId")]
        public virtual string CertificateId { get; set; }

        /// <summary>Output only. The timestamp when the auth config is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The creator's email address. Generated based on the End User Credentials/LOAS role of the user making the
        /// call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorEmail")]
        public virtual string CreatorEmail { get; set; }

        /// <summary>Credential type of the encrypted credential.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentialType")]
        public virtual string CredentialType { get; set; }

        /// <summary>Raw auth credentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decryptedCredential")]
        public virtual GoogleCloudIntegrationsV1alphaCredential DecryptedCredential { get; set; }

        /// <summary>A description of the auth config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The name of the auth config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Auth credential encrypted by Cloud KMS. Can be decrypted as Credential with proper KMS key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedCredential")]
        public virtual string EncryptedCredential { get; set; }

        /// <summary>
        /// User can define the time to receive notification after which the auth config becomes invalid. Support up to
        /// 30 days. Support granularity in hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryNotificationDuration")]
        public virtual System.Collections.Generic.IList<object> ExpiryNotificationDuration { get; set; }

        /// <summary>
        /// The last modifier's email address. Generated based on the End User Credentials/LOAS role of the user making
        /// the call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifierEmail")]
        public virtual string LastModifierEmail { get; set; }

        /// <summary>
        /// Resource name of the SFDC instance projects/{project}/locations/{location}/authConfigs/{authConfig}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// User provided expiry time to override. For the example of Salesforce, username/password credentials can be
        /// valid for 6 months depending on the instance settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideValidTime")]
        public virtual object OverrideValidTime { get; set; }

        /// <summary>The reason / details of the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The status of the auth config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The timestamp when the auth config is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// The time until the auth config is valid. Empty or max value is considered the auth config won't expire.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validTime")]
        public virtual object ValidTime { get; set; }

        /// <summary>The visibility of the auth config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The credentials to authenticate a user agent with a server that is put in HTTP Authorization request header.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaAuthToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token for the auth type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>Authentication type, e.g. "Basic", "Bearer", etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message only contains a field of boolean array.</summary>
    public class GoogleCloudIntegrationsV1alphaBooleanParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Boolean array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<bool>> BooleanValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for cancelling an execution.</summary>
    public class GoogleCloudIntegrationsV1alphaCancelExecutionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for cancelling an execution.</summary>
    public class GoogleCloudIntegrationsV1alphaCancelExecutionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if cancellation performed successfully</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCanceled")]
        public virtual System.Nullable<bool> IsCanceled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The certificate definition</summary>
    public class GoogleCloudIntegrationsV1alphaCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status of the certificate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateStatus")]
        public virtual string CertificateStatus { get; set; }

        /// <summary>Immutable. Credential id that will be used to register with trawler INTERNAL_ONLY</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentialId")]
        public virtual string CredentialId { get; set; }

        /// <summary>Description of the certificate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Name of the certificate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Auto generated primary key</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Input only. Raw client certificate which would be registered with trawler</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawCertificate")]
        public virtual GoogleCloudIntegrationsV1alphaClientCertificate RawCertificate { get; set; }

        /// <summary>Immutable. Requestor ID to be used to register certificate with trawler</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestorId")]
        public virtual string RequestorId { get; set; }

        /// <summary>Output only. The timestamp after which certificate will expire</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validEndTime")]
        public virtual object ValidEndTime { get; set; }

        /// <summary>Output only. The timestamp after which certificate will be valid</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validStartTime")]
        public virtual object ValidStartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains client certificate information</summary>
    public class GoogleCloudIntegrationsV1alphaClientCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
        /// For example, -----BEGIN CERTIFICATE----- MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
        /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
        /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
        /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
        /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
        /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
        /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
        /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
        /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
        /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
        /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
        /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg= -----END
        /// CERTIFICATE-----
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedPrivateKey")]
        public virtual string EncryptedPrivateKey { get; set; }

        /// <summary>
        /// 'passphrase' should be left unset if private key is not encrypted. Note that 'passphrase' is not the
        /// password for web server, but an extra layer of security to protected private key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passphrase")]
        public virtual string Passphrase { get; set; }

        /// <summary>
        /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
        /// For example, -----BEGIN CERTIFICATE----- MIICTTCCAbagAwIBAgIJAPT0tSKNxan/MA0GCSqGSIb3DQEBCwUAMCoxFzAVBgNV
        /// BAoTDkdvb2dsZSBURVNUSU5HMQ8wDQYDVQQDEwZ0ZXN0Q0EwHhcNMTUwMTAxMDAw
        /// MDAwWhcNMjUwMTAxMDAwMDAwWjAuMRcwFQYDVQQKEw5Hb29nbGUgVEVTVElORzET
        /// MBEGA1UEAwwKam9lQGJhbmFuYTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA
        /// vDYFgMgxi5W488d9J7UpCInl0NXmZQpJDEHE4hvkaRlH7pnC71H0DLt0/3zATRP1
        /// JzY2+eqBmbGl4/sgZKYv8UrLnNyQNUTsNx1iZAfPUflf5FwgVsai8BM0pUciq1NB
        /// xD429VFcrGZNucvFLh72RuRFIKH8WUpiK/iZNFkWhZ0CAwEAAaN3MHUwDgYDVR0P
        /// AQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAMBgNVHRMB
        /// Af8EAjAAMBkGA1UdDgQSBBCVgnFBCWgL/iwCqnGrhTPQMBsGA1UdIwQUMBKAEKey
        /// Um2o4k2WiEVA0ldQvNYwDQYJKoZIhvcNAQELBQADgYEAYK986R4E3L1v+Q6esBtW
        /// JrUwA9UmJRSQr0N5w3o9XzarU37/bkjOP0Fw0k/A6Vv1n3vlciYfBFaBIam1qRHr
        /// 5dMsYf4CZS6w50r7hyzqyrwDoyNxkLnd2PdcHT/sym1QmflsjEs7pejtnohO6N2H wQW6M0H7Zt8claGRla4fKkg= -----END
        /// CERTIFICATE-----
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCertificate")]
        public virtual string SslCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Scheduler Trigger configuration</summary>
    public class GoogleCloudIntegrationsV1alphaCloudSchedulerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The cron tab of cloud scheduler trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronTab")]
        public virtual string CronTab { get; set; }

        /// <summary>
        /// Optional. When the job was deleted from Pantheon UI, error_message will be populated when Get/List
        /// integrations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Required. The location where associated cloud scheduler job will be created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Required. Service account used by Cloud Scheduler to trigger the integration at scheduled time
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of runtime connection schema.</summary>
    public class GoogleCloudIntegrationsV1alphaConnectionSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<string> Actions { get; set; }

        /// <summary>List of entity names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<string> Entities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for CreateAppsScriptProject rpc call.</summary>
    public class GoogleCloudIntegrationsV1alphaCreateAppsScriptProjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Apps Script project to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appsScriptProject")]
        public virtual string AppsScriptProject { get; set; }

        /// <summary>
        /// The auth config id necessary to fetch the necessary credentials to create the project for external clients
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfigId")]
        public virtual string AuthConfigId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for CreateAppsScriptProject rpc call.</summary>
    public class GoogleCloudIntegrationsV1alphaCreateAppsScriptProjectResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The created AppsScriptProject ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// PROTECT WITH A VISIBILITY LABEL. THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. Request to create a new
    /// Bundle.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaCreateBundleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. name of the bundle that will be created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleId")]
        public virtual string BundleId { get; set; }

        /// <summary>A list of integrations that can be executed by the bundle</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrations")]
        public virtual System.Collections.Generic.IList<string> Integrations { get; set; }

        /// <summary>
        /// Optional. The prefix for the SA, it should be in the format "o". This is an optional field, and if empty
        /// service account will be created per project, where we are creating bundle. This should only be used as the
        /// org ID for which we want to run the integrations in the bundle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryCustomerOrgId")]
        public virtual string SecondaryCustomerOrgId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for create bundle.</summary>
    public class GoogleCloudIntegrationsV1alphaCreateBundleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>It contains the bundle data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudIntegrationsV1alphaIntegrationBundleConfig Config { get; set; }

        /// <summary>trigger_id of the bundle task</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines parameters for a single, canonical credential.</summary>
    public class GoogleCloudIntegrationsV1alphaCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Auth token credential</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authToken")]
        public virtual GoogleCloudIntegrationsV1alphaAuthToken AuthToken { get; set; }

        /// <summary>Credential type associated with auth config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentialType")]
        public virtual string CredentialType { get; set; }

        /// <summary>JWT credential</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwt")]
        public virtual GoogleCloudIntegrationsV1alphaJwt Jwt { get; set; }

        /// <summary>
        /// The api_key and oauth2_implicit are not covered in v1 and will be picked up once v1 is implemented. ApiKey
        /// api_key = 3; OAuth2 authorization code credential
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2AuthorizationCode")]
        public virtual GoogleCloudIntegrationsV1alphaOAuth2AuthorizationCode Oauth2AuthorizationCode { get; set; }

        /// <summary>OAuth2Implicit oauth2_implicit = 5; OAuth2 client credentials</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientCredentials")]
        public virtual GoogleCloudIntegrationsV1alphaOAuth2ClientCredentials Oauth2ClientCredentials { get; set; }

        /// <summary>OAuth2 resource owner credentials</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ResourceOwnerCredentials")]
        public virtual GoogleCloudIntegrationsV1alphaOAuth2ResourceOwnerCredentials Oauth2ResourceOwnerCredentials { get; set; }

        /// <summary>Google OIDC ID Token</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcToken")]
        public virtual GoogleCloudIntegrationsV1alphaOidcToken OidcToken { get; set; }

        /// <summary>Service account credential</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountCredentials")]
        public virtual GoogleCloudIntegrationsV1alphaServiceAccountCredentials ServiceAccountCredentials { get; set; }

        /// <summary>Username and password credential</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usernameAndPassword")]
        public virtual GoogleCloudIntegrationsV1alphaUsernameAndPassword UsernameAndPassword { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for DeactivateIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for DeactivateIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaDeactivateIntegrationVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message only contains a field of double number array.</summary>
    public class GoogleCloudIntegrationsV1alphaDoubleParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Double number array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> DoubleValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for DownloadIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaDownloadIntegrationVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>String representation of the integration version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing all provisioned regions for Connector Platform.</summary>
    public class GoogleCloudIntegrationsV1alphaEnumerateConnectorPlatformRegionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All regions where Connector Platform is provisioned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message is used for processing and persisting (when applicable) key value pair parameters for each event in
    /// the event bus.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaEventParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Key is used to retrieve the corresponding parameter value. This should be unique for a given fired event.
        /// These parameters must be predefined in the integration definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Values for the defined keys. Each value can either be string, int, double or any proto message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleCloudIntegrationsV1alphaValueType Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for executing an integration.</summary>
    public class GoogleCloudIntegrationsV1alphaExecuteIntegrationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Flag to determine how to should propagate errors. If this flag is set to be true, it will not
        /// throw an exception. Instead, it will return a {@link ExecuteIntegrationsResponse} with an execution id and
        /// error messages as PostWithTriggerIdExecutionException in {@link EventParameters}. The flag is set to be
        /// false by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doNotPropagateError")]
        public virtual System.Nullable<bool> DoNotPropagateError { get; set; }

        /// <summary>Optional. The id of the ON_HOLD execution to be resumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; }

        /// <summary>Optional. Input parameters used by integration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputParameters")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudIntegrationsV1alphaValueType> InputParameters { get; set; }

        /// <summary>
        /// Optional. Parameters are a part of Event and can be used to communicate between different tasks that are
        /// part of the same integration execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterEntries")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoParameterEntry> ParameterEntries { get; set; }

        /// <summary>Optional. Passed in as parameters to each integration execution. Redacted</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual EnterpriseCrmFrontendsEventbusProtoEventParameters Parameters { get; set; }

        /// <summary>
        /// Optional. This is used to de-dup incoming request: if the duplicate request was detected, the response from
        /// the previous execution is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Optional. Matched against all {@link TriggerConfig}s across all integrations. i.e.
        /// TriggerConfig.trigger_id.equals(trigger_id)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for executing an integration.</summary>
    public class GoogleCloudIntegrationsV1alphaExecuteIntegrationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details for the integration that were executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventParameters")]
        public virtual EnterpriseCrmFrontendsEventbusProtoEventParameters EventParameters { get; set; }

        /// <summary>Is true if any execution in the integration failed. False otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionFailed")]
        public virtual System.Nullable<bool> ExecutionFailed { get; set; }

        /// <summary>The id of the execution corresponding to this run of integration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; }

        /// <summary>
        /// OUTPUT parameters in format of Map. Where Key is the name of the parameter. Note: Name of the system
        /// generated parameters are wrapped by backtick(`) to distinguish them from the user defined parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputParameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> OutputParameters { get; set; }

        /// <summary>
        /// Parameters are a part of Event and can be used to communicate between different tasks that are part of the
        /// same integration execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterEntries")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoParameterEntry> ParameterEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Execution resource contains detailed information of an individual integration execution.</summary>
    public class GoogleCloudIntegrationsV1alphaExecution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Created time of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Direct sub executions of the following Execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directSubExecutions")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaExecution> DirectSubExecutions { get; set; }

        /// <summary>The execution info about this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionDetails")]
        public virtual EnterpriseCrmEventbusProtoEventExecutionDetails EventExecutionDetails { get; set; }

        /// <summary>Detailed info of this execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionDetails")]
        public virtual GoogleCloudIntegrationsV1alphaExecutionDetails ExecutionDetails { get; set; }

        /// <summary>The ways user posts this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionMethod")]
        public virtual string ExecutionMethod { get; set; }

        /// <summary>Auto-generated primary key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Event parameters come in as part of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestParameters")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudIntegrationsV1alphaValueType> RequestParameters { get; set; }

        /// <summary>Event parameters come in as part of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestParams")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoParameterEntry> RequestParams { get; set; }

        /// <summary>Event parameters returned as part of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseParameters")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudIntegrationsV1alphaValueType> ResponseParameters { get; set; }

        /// <summary>Event parameters come out as part of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseParams")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoParameterEntry> ResponseParams { get; set; }

        /// <summary>
        /// The trigger id of the integration trigger config. If both trigger_id and client_id is present, the
        /// integration is executed from the start tasks provided by the matching trigger config otherwise it is
        /// executed from the default start tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>Output only. Last modified time of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the details of the execution info: this includes the tasks execution details plus the event execution
    /// statistics.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaExecutionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Start and end time of the execution attempts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attemptStats")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaAttemptStats> AttemptStats { get; set; }

        /// <summary>List of snapshots taken during the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionSnapshots")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaExecutionSnapshot> ExecutionSnapshots { get; set; }

        /// <summary>Status of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the snapshot of the execution for a given checkpoint.</summary>
    public class GoogleCloudIntegrationsV1alphaExecutionSnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates "after which checkpoint task's execution" this snapshot is taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkpointTaskNumber")]
        public virtual string CheckpointTaskNumber { get; set; }

        /// <summary>Metadata of the execution snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionSnapshotMetadata")]
        public virtual GoogleCloudIntegrationsV1alphaExecutionSnapshotExecutionSnapshotMetadata ExecutionSnapshotMetadata { get; set; }

        /// <summary>Parameters used during the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudIntegrationsV1alphaValueType> Params__ { get; set; }

        /// <summary>All of the task execution details at the given point of time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskExecutionDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaTaskExecutionDetails> TaskExecutionDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of the execution snapshot.</summary>
    public class GoogleCloudIntegrationsV1alphaExecutionSnapshotExecutionSnapshotMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>the execution attempt number this snapshot belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionAttempt")]
        public virtual System.Nullable<int> ExecutionAttempt { get; set; }

        /// <summary>the task name associated with this snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("task")]
        public virtual string Task { get; set; }

        /// <summary>the task attempt number this snapshot belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskAttempt")]
        public virtual System.Nullable<int> TaskAttempt { get; set; }

        /// <summary>The task number associated with this snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual string TaskNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy that defines the task retry logic and failure type. If no FailurePolicy is defined for a task, all its
    /// dependent tasks will not be executed (i.e, a `retry_strategy` of NONE will be applied).
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaFailurePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required if retry_strategy is FIXED_INTERVAL or LINEAR/EXPONENTIAL_BACKOFF/RESTART_INTEGRATION_WITH_BACKOFF.
        /// Defines the initial interval in seconds for backoff.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervalTime")]
        public virtual object IntervalTime { get; set; }

        /// <summary>
        /// Required if retry_strategy is FIXED_INTERVAL or LINEAR/EXPONENTIAL_BACKOFF/RESTART_INTEGRATION_WITH_BACKOFF.
        /// Defines the number of times the task will be retried if failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetries")]
        public virtual System.Nullable<int> MaxRetries { get; set; }

        /// <summary>Defines what happens to the task upon failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryStrategy")]
        public virtual string RetryStrategy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Returns success or error message</summary>
    public class GoogleCloudIntegrationsV1alphaGenerateTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message that notifies the user if the request succeeded or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for GetBundle.</summary>
    public class GoogleCloudIntegrationsV1alphaGetBundleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>It contains the bundle data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudIntegrationsV1alphaIntegrationBundleConfig Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message only contains a field of integer array.</summary>
    public class GoogleCloudIntegrationsV1alphaIntParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Integer array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValues")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> IntValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The integration definition.</summary>
    public class GoogleCloudIntegrationsV1alphaIntegration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. If any integration version is published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active { get; set; }

        /// <summary>Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The resource name of the integration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message to be used to configure custom alerting in the {@code EventConfig} protos for an event.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaIntegrationAlertConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The period over which the metric value should be aggregated and evaluated. Format is , where integer should
        /// be a positive integer and unit should be one of (s,m,h,d,w) meaning (second, minute, hour, day, week). For
        /// an EXPECTED_MIN threshold, this aggregation_period must be lesser than 24 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationPeriod")]
        public virtual string AggregationPeriod { get; set; }

        /// <summary>
        /// For how many contiguous aggregation periods should the expected min or max be violated for the alert to be
        /// fired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertThreshold")]
        public virtual System.Nullable<int> AlertThreshold { get; set; }

        /// <summary>
        /// Set to false by default. When set to true, the metrics are not aggregated or pushed to Monarch for this
        /// integration alert.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableAlert")]
        public virtual System.Nullable<bool> DisableAlert { get; set; }

        /// <summary>
        /// Name of the alert. This will be displayed in the alert subject. If set, this name should be unique within
        /// the scope of the integration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Should be specified only for *AVERAGE_DURATION and *PERCENTILE_DURATION metrics. This member should be used
        /// to specify what duration value the metrics should exceed for the alert to trigger.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationThreshold")]
        public virtual object DurationThreshold { get; set; }

        /// <summary>The type of metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricType")]
        public virtual string MetricType { get; set; }

        /// <summary>
        /// For either events or tasks, depending on the type of alert, count only final attempts, not retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyFinalAttempt")]
        public virtual System.Nullable<bool> OnlyFinalAttempt { get; set; }

        /// <summary>
        /// The threshold type, whether lower(expected_min) or upper(expected_max), for which this alert is being
        /// configured. If value falls below expected_min or exceeds expected_max, an alert will be fired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdType")]
        public virtual string ThresholdType { get; set; }

        /// <summary>The metric value, above or below which the alert should be triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdValue")]
        public virtual GoogleCloudIntegrationsV1alphaIntegrationAlertConfigThresholdValue ThresholdValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The threshold value of the metric, above or below which the alert should be triggered. See EventAlertConfig or
    /// TaskAlertConfig for the different alert metric types in each case. For the *RATE metrics, one or both of these
    /// fields may be set. Zero is the default value and can be left at that. For *PERCENTILE_DURATION metrics, one or
    /// both of these fields may be set, and also, the duration threshold value should be specified in the
    /// threshold_duration_ms member below. For *AVERAGE_DURATION metrics, these fields should not be set at all. A
    /// different member, threshold_duration_ms, must be set in the EventAlertConfig or the TaskAlertConfig.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaIntegrationAlertConfigThresholdValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Absolute value threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absolute")]
        public virtual System.Nullable<long> Absolute { get; set; }

        /// <summary>Percentage threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<int> Percentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This proto holds the core runner data in the bundle task. It is not expected to be directly edited by the user.
    /// Instead, a default value will be provided at the task creation time.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaIntegrationBundleConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A bundle of integrations that can be executed by the task at runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrations")]
        public virtual System.Collections.Generic.IList<string> Integrations { get; set; }

        /// <summary>
        /// Output only. The service account created and owned by IP and added to the customers GCP project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Integration Parameter is defined in the integration config and are used to provide information about data types
    /// of the expected parameters and provide any default values if needed. They can also be used to add custom
    /// attributes. These are static in nature and should not be used for dynamic event definition.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaIntegrationParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// Default values for the defined keys. Each value can either be string, int, double or any proto message or a
        /// serialized object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual GoogleCloudIntegrationsV1alphaValueType DefaultValue { get; set; }

        /// <summary>
        /// The name (without prefix) to be displayed in the UI for this parameter. E.g. if the key is "foo.bar.myName",
        /// then the name would be "myName".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Specifies the input/output type for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputOutputType")]
        public virtual string InputOutputType { get; set; }

        /// <summary>Whether this parameter is a transient parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTransient")]
        public virtual System.Nullable<bool> IsTransient { get; set; }

        /// <summary>This schema will be used to validate runtime JSON-typed values of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual string JsonSchema { get; set; }

        /// <summary>
        /// Key is used to retrieve the corresponding parameter value. This should be unique for a given fired event.
        /// These parameters must be predefined in the integration definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The identifier of the node (TaskConfig/TriggerConfig) this parameter was produced by, if it is a transient
        /// param or a copy of an input param.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producer")]
        public virtual string Producer { get; set; }

        /// <summary>Searchable in the execution log or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchable")]
        public virtual System.Nullable<bool> Searchable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// IntegrationTemplateVersion definition. An IntegrationTemplateVersion provides configurations required to
    /// construct an IntegrationVersion. It cannot be executed directly like an Integration. Users can create
    /// IntegrationTemplateVersions using Integrations. These Templates can be shared by users across GCP projects.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaIntegrationTemplateVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. Flag to disable database persistence for execution data, including event execution info, execution
        /// export info, execution metadata index and execution param index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databasePersistencePolicy")]
        public virtual string DatabasePersistencePolicy { get; set; }

        /// <summary>
        /// Optional. The templateversion description. Permitted format is alphanumeric with underscores and no spaces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. The last modifier's email address. Generated based on the End User Credentials/LOAS role of the
        /// user making the call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifierEmail")]
        public virtual string LastModifierEmail { get; set; }

        /// <summary>
        /// Output only. Auto-generated primary key. Format:
        /// projects/{project}/locations/{location}/products/{product}/integrationtemplates/{integrationtemplate}/versions/{version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. ID of the IntegrationVersion that was used to create this IntegrationTemplateVersion
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentIntegrationVersionId")]
        public virtual string ParentIntegrationVersionId { get; set; }

        /// <summary>Output only. An increasing sequence that is set when a new snapshot is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotNumber")]
        public virtual System.Nullable<long> SnapshotNumber { get; set; }

        /// <summary>Optional. Generated by eventbus. User should not set it as an input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Optional. Task configuration for the IntegrationTemplateVersion. It's optional, but the
        /// IntegrationTemplateVersion doesn't do anything without task_configs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskConfigs")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoTaskConfig> TaskConfigs { get; set; }

        /// <summary>
        /// Optional. Contains a graph of tasks that will be executed before putting the event in a terminal state
        /// (SUCCEEDED/FAILED/FATAL), regardless of success or failure, similar to "finally" in code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teardown")]
        public virtual EnterpriseCrmEventbusProtoTeardown Teardown { get; set; }

        /// <summary>
        /// Optional. Parameters that are expected to be passed to the IntegrationTemplateVersion when an event is
        /// triggered. This consists of all the parameters that are expected in the IntegrationTemplateVersion
        /// execution. This gives the user the ability to provide default values, add information like PII and also
        /// provide data types of each parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateParameters")]
        public virtual EnterpriseCrmFrontendsEventbusProtoWorkflowParameters TemplateParameters { get; set; }

        /// <summary>Optional. Trigger configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerConfigs")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoTriggerConfig> TriggerConfigs { get; set; }

        /// <summary>Output only. Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Optional. A user-defined label that annotates an integration version. Typically, this is only set when the
        /// integration version is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabel")]
        public virtual string UserLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The integration version definition.</summary>
    public class GoogleCloudIntegrationsV1alphaIntegrationVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. Flag to disable database persistence for execution data, including event execution info, execution
        /// export info, execution metadata index and execution param index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databasePersistencePolicy")]
        public virtual string DatabasePersistencePolicy { get; set; }

        /// <summary>Optional. The integration description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Parameters that are expected to be passed to the integration when an event is triggered. This
        /// consists of all the parameters that are expected in the integration execution. This gives the user the
        /// ability to provide default values, add information like PII and also provide data types of each parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationParameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaIntegrationParameter> IntegrationParameters { get; set; }

        /// <summary>
        /// Optional. Parameters that are expected to be passed to the integration when an event is triggered. This
        /// consists of all the parameters that are expected in the integration execution. This gives the user the
        /// ability to provide default values, add information like PII and also provide data types of each parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationParametersInternal")]
        public virtual EnterpriseCrmFrontendsEventbusProtoWorkflowParameters IntegrationParametersInternal { get; set; }

        /// <summary>
        /// Optional. The last modifier's email address. Generated based on the End User Credentials/LOAS role of the
        /// user making the call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifierEmail")]
        public virtual string LastModifierEmail { get; set; }

        /// <summary>
        /// Optional. The edit lock holder's email address. Generated based on the End User Credentials/LOAS role of the
        /// user making the call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockHolder")]
        public virtual string LockHolder { get; set; }

        /// <summary>Output only. Auto-generated primary key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The origin that indicates where this integration is coming from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>Optional. The id of the template which was used to create this integration_version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentTemplateId")]
        public virtual string ParentTemplateId { get; set; }

        /// <summary>
        /// Optional. An increasing sequence that is set when a new snapshot is created. The last created snapshot can
        /// be identified by [workflow_name, org_id latest(snapshot_number)]. However, last created snapshot need not be
        /// same as the HEAD. So users should always use "HEAD" tag to identify the head.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotNumber")]
        public virtual System.Nullable<long> SnapshotNumber { get; set; }

        /// <summary>Output only. User should not set it as an input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Generated by eventbus. User should not set it as an input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Optional. Task configuration for the integration. It's optional, but the integration doesn't do anything
        /// without task_configs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaTaskConfig> TaskConfigs { get; set; }

        /// <summary>
        /// Optional. Task configuration for the integration. It's optional, but the integration doesn't do anything
        /// without task_configs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskConfigsInternal")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoTaskConfig> TaskConfigsInternal { get; set; }

        /// <summary>
        /// Optional. Contains a graph of tasks that will be executed before putting the event in a terminal state
        /// (SUCCEEDED/FAILED/FATAL), regardless of success or failure, similar to "finally" in code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teardown")]
        public virtual EnterpriseCrmEventbusProtoTeardown Teardown { get; set; }

        /// <summary>Optional. Trigger configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaTriggerConfig> TriggerConfigs { get; set; }

        /// <summary>Optional. Trigger configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerConfigsInternal")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoTriggerConfig> TriggerConfigsInternal { get; set; }

        /// <summary>Output only. Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Optional. A user-defined label that annotates an integration version. Typically, this is only set when the
        /// integration version is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabel")]
        public virtual string UserLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents JSON web token(JWT), which is a compact, URL-safe means of representing claims to be transferred
    /// between two parties, enabling the claims to be digitally signed or integrity protected.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaJwt : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token calculated by the header, payload and signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwt")]
        public virtual string Jwt { get; set; }

        /// <summary>Identifies which algorithm is used to generate the signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwtHeader")]
        public virtual string JwtHeader { get; set; }

        /// <summary>
        /// Contains a set of claims. The JWT specification defines seven Registered Claim Names which are the standard
        /// fields commonly included in tokens. Custom claims are usually also included, depending on the purpose of the
        /// token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwtPayload")]
        public virtual string JwtPayload { get; set; }

        /// <summary>User's pre-shared secret to sign the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for lift Suspension</summary>
    public class GoogleCloudIntegrationsV1alphaLiftSuspensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User passed in suspension result and will be used to control workflow execution branching behavior by
        /// setting up corresponnding edge condition with suspension result. For example, if you want to lift the
        /// suspension, you can pass "Approved", or if you want to reject the suspension and terminate workfloe
        /// execution, you can pass "Rejected" and terminate the workflow execution with configuring the edge condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionResult")]
        public virtual string SuspensionResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of lift Suspense</summary>
    public class GoogleCloudIntegrationsV1alphaLiftSuspensionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Execution Id that will be returned</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionInfoId")]
        public virtual string EventExecutionInfoId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for LinkAppsScriptProject rpc call.</summary>
    public class GoogleCloudIntegrationsV1alphaLinkAppsScriptProjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the Apps Script project to be linked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptId")]
        public virtual string ScriptId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for LinkAppsScriptProject rpc call.</summary>
    public class GoogleCloudIntegrationsV1alphaLinkAppsScriptProjectResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the linked Apps Script project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptId")]
        public virtual string ScriptId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list AuthConfigs.</summary>
    public class GoogleCloudIntegrationsV1alphaListAuthConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of AuthConfigs retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaAuthConfig> AuthConfigs { get; set; }

        /// <summary>The token used to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list Certificates.</summary>
    public class GoogleCloudIntegrationsV1alphaListCertificatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Certificates retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificates")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaCertificate> Certificates { get; set; }

        /// <summary>The token used to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing Connections listed by region.</summary>
    public class GoogleCloudIntegrationsV1alphaListConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<GoogleCloudConnectorsV1Connection> Connections { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing the integration execution snapshot.</summary>
    public class GoogleCloudIntegrationsV1alphaListExecutionSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The detailed information for the execution snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionSnapshots")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmEventbusProtoEventExecutionSnapshot> ExecutionSnapshots { get; set; }

        /// <summary>The token returned in the previous response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing the integration execution data.</summary>
    public class GoogleCloudIntegrationsV1alphaListExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The detailed information of requested executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionInfos")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoEventExecutionInfo> ExecutionInfos { get; set; }

        /// <summary>The detailed information of requested executions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executions")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaExecution> Executions { get; set; }

        /// <summary>The token used to retrieve the next page results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for IntegrationTemplateVersions.ListIntegrationTemplateVersions.</summary>
    public class GoogleCloudIntegrationsV1alphaListIntegrationTemplateVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IntegrationTemplateVersions which match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationTemplateVersions")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaIntegrationTemplateVersion> IntegrationTemplateVersions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListIntegrationVersions.</summary>
    public class GoogleCloudIntegrationsV1alphaListIntegrationVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The integrations which match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationVersions")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaIntegrationVersion> IntegrationVersions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Whether the user has no permission on the version or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noPermission")]
        public virtual System.Nullable<bool> NoPermission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListIntegrations.</summary>
    public class GoogleCloudIntegrationsV1alphaListIntegrationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The integrations which match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrations")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaIntegration> Integrations { get; set; }

        /// <summary>The next page token for the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing RuntimeActionSchemas for a specific Connection.</summary>
    public class GoogleCloudIntegrationsV1alphaListRuntimeActionSchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Runtime action schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeActionSchemas")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaRuntimeActionSchema> RuntimeActionSchemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for listing RuntimeEntitySchemas for a specific Connection.</summary>
    public class GoogleCloudIntegrationsV1alphaListRuntimeEntitySchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Runtime entity schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeEntitySchemas")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaRuntimeEntitySchema> RuntimeEntitySchemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list SfdcChannels.</summary>
    public class GoogleCloudIntegrationsV1alphaListSfdcChannelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token used to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of SfdcChannels retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sfdcChannels")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaSfdcChannel> SfdcChannels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list SfdcInstances.</summary>
    public class GoogleCloudIntegrationsV1alphaListSfdcInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The token used to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of SfdcInstances retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sfdcInstances")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaSfdcInstance> SfdcInstances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for Suspensions.ListSuspensions.</summary>
    public class GoogleCloudIntegrationsV1alphaListSuspensionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The suspensions for the relevant execution which the caller has permissions to view and resolve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensions")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaSuspension> Suspensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This is a UI only method and will be moved away. Response for ListTaskEntities.</summary>
    public class GoogleCloudIntegrationsV1alphaListTaskEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of the tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskEntities")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoTaskEntity> TaskEntities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to get data for monarch connector config.</summary>
    public class GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How long the series data range: "1h","1d",etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Final time to query over, or the current time if left unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Required. Query for searching data in monarch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mashQuery")]
        public virtual GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQuery MashQuery { get; set; }

        /// <summary>
        /// Returns a table of all possible metric field values within the specified duration, ignoring any data
        /// samples. Useful for autocomplete functionality.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricFieldTable")]
        public virtual System.Nullable<bool> MetricFieldTable { get; set; }

        /// <summary>
        /// The output period for the query. Must be set if there is a window operation within the query and unset
        /// otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputPeriod")]
        public virtual object OutputPeriod { get; set; }

        /// <summary>Required. Template for response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseTemplate")]
        public virtual string ResponseTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MashQuery GroupBy parameters.</summary>
    public class GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestGroupBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. optional, metrics list for GroupBy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<string> Fields { get; set; }

        /// <summary>Optional. optional, reduce function for GroupBy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reducer")]
        public virtual string Reducer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The MashQuery for searching data, set both queries for Join Operation.</summary>
    public class GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The components for constructing a mash query. Set "point_operation" if this is a single query
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstQuery")]
        public virtual GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryComponent FirstQuery { get; set; }

        /// <summary>
        /// Optional. optional, only set when joining 2 queries. By default join 2 queries with join operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationMode")]
        public virtual GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryOperationMode OperationMode { get; set; }

        /// <summary>
        /// Optional. optional, only set when joining 2 queries. Set "point_operation" for joined query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondQuery")]
        public virtual GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryComponent SecondQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The components for constructing MashQuery.</summary>
    public class GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The metric for monarch.BorgTask.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borgTaskMetric")]
        public virtual string BorgTaskMetric { get; set; }

        /// <summary>Optional. optional, filters on fetched data, "metric:client_id" not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilters")]
        public virtual System.Collections.Generic.IList<string> DataFilters { get; set; }

        /// <summary>Optional. optional, filters for Fetch Raw, "metric:client_id" not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fetchFilters")]
        public virtual System.Collections.Generic.IList<string> FetchFilters { get; set; }

        /// <summary>Optional. optional, GroupBy variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupBy")]
        public virtual GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestGroupBy GroupBy { get; set; }

        /// <summary>Optional. optional, Point Operation on single query or joined query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointOperation")]
        public virtual string PointOperation { get; set; }

        /// <summary>Required. Window time delta.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeDelta")]
        public virtual string TimeDelta { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operation between 2 query</summary>
    public class GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryOperationMode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. join operation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("joinConfig")]
        public virtual GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryOperationModeJoinConfig JoinConfig { get; set; }

        /// <summary>Optional. optional operation types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>Optional. union operation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unionConfig")]
        public virtual GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryOperationModeUnionConfig UnionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Join Operation</summary>
    public class GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryOperationModeJoinConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Union operation</summary>
    public class GoogleCloudIntegrationsV1alphaMonitorExecutionStatsRequestMashQueryOperationModeUnionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. optional, reduce function</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reducer")]
        public virtual string Reducer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for getting Execution stats.</summary>
    public class GoogleCloudIntegrationsV1alphaMonitorExecutionStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aplosSeriesListData")]
        public virtual EnterpriseCrmCardsTemplatesAplosSeriesListData AplosSeriesListData { get; set; }

        /// <summary>Data in form of table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableData")]
        public virtual EnterpriseCrmCardsTabularData TableData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The task that is next in line to be executed, if the condition specified evaluated to true.</summary>
    public class GoogleCloudIntegrationsV1alphaNextTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Standard filter expression for this task to become an eligible next task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>User-provided description intended to give additional business context about the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User-provided label that is attached to this edge in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>ID of the next task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskConfigId")]
        public virtual string TaskConfigId { get; set; }

        /// <summary>Task number of the next task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskId")]
        public virtual string TaskId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The OAuth Type where the client sends request with the client id and requested scopes to auth endpoint. User
    /// sees a consent screen and auth code is received at specified redirect url afterwards. The auth code is then
    /// combined with the client id and secret and sent to the token endpoint in exchange for the access and refresh
    /// token. The refresh token can be used to fetch new access tokens.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaOAuth2AuthorizationCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The access token received from the token endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual GoogleCloudIntegrationsV1alphaAccessToken AccessToken { get; set; }

        /// <summary>
        /// Indicates if the user has opted in Google Reauth Policy. If opted in, the refresh token will be valid for 20
        /// hours, after which time users must re-authenticate in order to obtain a new one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyReauthPolicy")]
        public virtual System.Nullable<bool> ApplyReauthPolicy { get; set; }

        /// <summary>The Auth Code that is used to initially retrieve the access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authCode")]
        public virtual string AuthCode { get; set; }

        /// <summary>The auth url endpoint to send the auth code request to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authEndpoint")]
        public virtual string AuthEndpoint { get; set; }

        /// <summary>The auth parameters sent along with the auth code request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authParams")]
        public virtual GoogleCloudIntegrationsV1alphaParameterMap AuthParams { get; set; }

        /// <summary>The client's id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>The client's secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>Represent how to pass parameters to fetch access token</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestType")]
        public virtual string RequestType { get; set; }

        /// <summary>A space-delimited list of requested scope permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The token url endpoint to send the token request to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenEndpoint")]
        public virtual string TokenEndpoint { get; set; }

        /// <summary>The token parameters sent along with the token request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenParams")]
        public virtual GoogleCloudIntegrationsV1alphaParameterMap TokenParams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For client credentials grant, the client sends a POST request with grant_type as 'client_credentials' to the
    /// authorization server. The authorization server will respond with a JSON object containing the access token.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaOAuth2ClientCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access token fetched from the authorization server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual GoogleCloudIntegrationsV1alphaAccessToken AccessToken { get; set; }

        /// <summary>The client's ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>The client's secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>Represent how to pass parameters to fetch access token</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestType")]
        public virtual string RequestType { get; set; }

        /// <summary>A space-delimited list of requested scope permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// The token endpoint is used by the client to obtain an access token by presenting its authorization grant or
        /// refresh token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenEndpoint")]
        public virtual string TokenEndpoint { get; set; }

        /// <summary>Token parameters for the auth request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenParams")]
        public virtual GoogleCloudIntegrationsV1alphaParameterMap TokenParams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For resource owner credentials grant, the client will ask the user for their authorization credentials (ususally
    /// a username and password) and send a POST request to the authorization server. The authorization server will
    /// respond with a JSON object containing the access token.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaOAuth2ResourceOwnerCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access token fetched from the authorization server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual GoogleCloudIntegrationsV1alphaAccessToken AccessToken { get; set; }

        /// <summary>The client's ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>The client's secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>The user's password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Represent how to pass parameters to fetch access token</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestType")]
        public virtual string RequestType { get; set; }

        /// <summary>A space-delimited list of requested scope permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// The token endpoint is used by the client to obtain an access token by presenting its authorization grant or
        /// refresh token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenEndpoint")]
        public virtual string TokenEndpoint { get; set; }

        /// <summary>Token parameters for the auth request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenParams")]
        public virtual GoogleCloudIntegrationsV1alphaParameterMap TokenParams { get; set; }

        /// <summary>The user's username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OIDC Token</summary>
    public class GoogleCloudIntegrationsV1alphaOidcToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Audience to be used when generating OIDC token. The audience claim identifies the recipients that the JWT is
        /// intended for.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>The service account email to be used as the identity for the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>ID token obtained for the service account</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The approximate time until the token retrieved is valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenExpireTime")]
        public virtual object TokenExpireTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic multi-map that holds key value pairs. They keys and values can be of any type, unless specified.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaParameterMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of parameter map entries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaParameterMapEntry> Entries { get; set; }

        /// <summary>
        /// Option to specify key type for all entries of the map. If provided then field types for all entries must
        /// conform to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyType")]
        public virtual string KeyType { get; set; }

        /// <summary>
        /// Option to specify value type for all entries of the map. If provided then field types for all entries must
        /// conform to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entry is a pair of key and value.</summary>
    public class GoogleCloudIntegrationsV1alphaParameterMapEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key of the map entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual GoogleCloudIntegrationsV1alphaParameterMapField Key { get; set; }

        /// <summary>Value of the map entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleCloudIntegrationsV1alphaParameterMapField Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Field represents either the key or value in an entry.</summary>
    public class GoogleCloudIntegrationsV1alphaParameterMapField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Passing a literal value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("literalValue")]
        public virtual GoogleCloudIntegrationsV1alphaValueType LiteralValue { get; set; }

        /// <summary>Referencing one of the Integration variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceKey")]
        public virtual string ReferenceKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for PublishIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaPublishIntegrationVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for PublishIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaPublishIntegrationVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for [Suspensions.ResolveSuspensions].</summary>
    public class GoogleCloudIntegrationsV1alphaResolveSuspensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Suspension, containing the event_execution_info_id, task_id, and state to set on the corresponding
        /// suspension record.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspension")]
        public virtual GoogleCloudIntegrationsV1alphaSuspension Suspension { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for Suspensions.ResolveSuspensions.</summary>
    public class GoogleCloudIntegrationsV1alphaResolveSuspensionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of an action, including schemas for its inputs and outputs.</summary>
    public class GoogleCloudIntegrationsV1alphaRuntimeActionSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Input parameter schema for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputSchema")]
        public virtual string InputSchema { get; set; }

        /// <summary>Output parameter schema for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputSchema")]
        public virtual string OutputSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of an entity, including a schema for its properties.</summary>
    public class GoogleCloudIntegrationsV1alphaRuntimeEntitySchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The above schema, but for an array of the associated entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayFieldSchema")]
        public virtual string ArrayFieldSchema { get; set; }

        /// <summary>Name of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual string Entity { get; set; }

        /// <summary>List of fields in the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldSchema")]
        public virtual string FieldSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for scheduling an integration.</summary>
    public class GoogleCloudIntegrationsV1alphaScheduleIntegrationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Input parameters used by integration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputParameters")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudIntegrationsV1alphaValueType> InputParameters { get; set; }

        /// <summary>
        /// Parameters are a part of Event and can be used to communicate between different tasks that are part of the
        /// same integration execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterEntries")]
        public virtual System.Collections.Generic.IList<EnterpriseCrmFrontendsEventbusProtoParameterEntry> ParameterEntries { get; set; }

        /// <summary>Passed in as parameters to each integration execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual EnterpriseCrmEventbusProtoEventParameters Parameters { get; set; }

        /// <summary>
        /// This is used to de-dup incoming request: if the duplicate request was detected, the response from the
        /// previous execution is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// The time that the integration should be executed. If the time is less or equal to the current time, the
        /// integration is executed immediately.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleTime")]
        public virtual object ScheduleTime { get; set; }

        /// <summary>
        /// Matched against all {@link TriggerConfig}s across all integrations. i.e.
        /// TriggerConfig.trigger_id.equals(trigger_id)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for executing an integration.</summary>
    public class GoogleCloudIntegrationsV1alphaScheduleIntegrationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The execution info id for the executed integrations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionInfoIds")]
        public virtual System.Collections.Generic.IList<string> ExecutionInfoIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the service account which can be used to generate access token for authenticating the service call.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaServiceAccountCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A space-delimited list of requested scope permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Name of the service account that has the permission to make the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The SfdcChannel that points to a CDC or Platform Event Channel.</summary>
    public class GoogleCloudIntegrationsV1alphaSfdcChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Channel topic defined by salesforce once an channel is opened</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTopic")]
        public virtual string ChannelTopic { get; set; }

        /// <summary>Output only. Time when the channel is created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Time when the channel was deleted. Empty if not deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>The description for this channel</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Client level unique name/alias to easily reference a channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Indicated if a channel has any active integrations referencing it. Set to false when the channel is created,
        /// and set to true if there is any integration published with the channel configured in it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isActive")]
        public virtual System.Nullable<bool> IsActive { get; set; }

        /// <summary>Last sfdc messsage replay id for channel</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastReplayId")]
        public virtual string LastReplayId { get; set; }

        /// <summary>
        /// Resource name of the SFDC channel
        /// projects/{project}/locations/{location}/sfdcInstances/{sfdc_instance}/sfdcChannels/{sfdc_channel}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Time when the channel was last updated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The SfdcInstance resource use to hold channels and connection config data.</summary>
    public class GoogleCloudIntegrationsV1alphaSfdcInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of AuthConfigs that can be tried to open the channel to SFDC</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfigId")]
        public virtual System.Collections.Generic.IList<string> AuthConfigId { get; set; }

        /// <summary>Output only. Time when the instance is created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. Time when the instance was deleted. Empty if not deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>A description of the sfdc instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>User selected unique name/alias to easily reference an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Resource name of the SFDC instance projects/{project}/locations/{location}/sfdcInstances/{sfdcInstance}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// URL used for API calls after authentication (the login authority is configured within the referenced
        /// AuthConfig).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAuthority")]
        public virtual string ServiceAuthority { get; set; }

        /// <summary>The SFDC Org Id. This is defined in salesforce.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sfdcOrgId")]
        public virtual string SfdcOrgId { get; set; }

        /// <summary>Output only. Time when the instance was last updated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message only contains a field of string array.</summary>
    public class GoogleCloudIntegrationsV1alphaStringParameterArray : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>String array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValues")]
        public virtual System.Collections.Generic.IList<string> StringValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policy that dictates the behavior for the task after it completes successfully.</summary>
    public class GoogleCloudIntegrationsV1alphaSuccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>State to which the execution snapshot status will be set if the task succeeds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalState")]
        public virtual string FinalState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A record representing a suspension.</summary>
    public class GoogleCloudIntegrationsV1alphaSuspension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Controls the notifications and approval permissions for this suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalConfig")]
        public virtual GoogleCloudIntegrationsV1alphaSuspensionApprovalConfig ApprovalConfig { get; set; }

        /// <summary>Metadata pertaining to the resolution of this suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audit")]
        public virtual GoogleCloudIntegrationsV1alphaSuspensionAudit Audit { get; set; }

        /// <summary>Output only. Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Required. ID of the associated execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventExecutionInfoId")]
        public virtual string EventExecutionInfoId { get; set; }

        /// <summary>Required. The name of the originating integration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integration")]
        public virtual string Integration { get; set; }

        /// <summary>Output only. Auto-generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifyTime")]
        public virtual object LastModifyTime { get; set; }

        /// <summary>Resource name for suspensions suspension/{suspension_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. State of this suspension, indicating what action a resolver has taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Controls the notifications and resolver permissions for this suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionConfig")]
        public virtual EnterpriseCrmEventbusProtoSuspensionConfig SuspensionConfig { get; set; }

        /// <summary>Required. Task id of the associated SuspensionTask.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskId")]
        public virtual string TaskId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for approving the Suspension.</summary>
    public class GoogleCloudIntegrationsV1alphaSuspensionApprovalConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information to provide for recipients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMessage")]
        public virtual string CustomMessage { get; set; }

        /// <summary>Email addresses to send approval request to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddresses")]
        public virtual System.Collections.Generic.IList<string> EmailAddresses { get; set; }

        /// <summary>Indicates the next steps when no external actions happen on the suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual GoogleCloudIntegrationsV1alphaSuspensionApprovalExpiration Expiration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Expiration configs for the approval request.</summary>
    public class GoogleCloudIntegrationsV1alphaSuspensionApprovalExpiration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Time after which the suspension expires, if no action taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Whether the suspension will be REJECTED or LIFTED upon expiration. REJECTED is the default behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liftWhenExpired")]
        public virtual System.Nullable<bool> LiftWhenExpired { get; set; }

        /// <summary>
        /// Time after the previous suspension action reminder, if any, is sent using the selected notification option,
        /// for a suspension which is still PENDING_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remindTime")]
        public virtual object RemindTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains when and by whom the suspension was resolved.</summary>
    public class GoogleCloudIntegrationsV1alphaSuspensionAudit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time at which this suspension was resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolveTime")]
        public virtual object ResolveTime { get; set; }

        /// <summary>Email address of the person who resolved this suspension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolver")]
        public virtual string Resolver { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for TakeoverEditLock.</summary>
    public class GoogleCloudIntegrationsV1alphaTakeoverEditLockRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for TakeoverEditLock.</summary>
    public class GoogleCloudIntegrationsV1alphaTakeoverEditLockResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Version after the lock is acquired by the new user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationVersion")]
        public virtual GoogleCloudIntegrationsV1alphaIntegrationVersion IntegrationVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The task configuration details. This is not the implementation of Task. There might be multiple TaskConfigs for
    /// the same Task.
    /// </summary>
    public class GoogleCloudIntegrationsV1alphaTaskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. User-provided description intended to give additional business context about the task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. User-provided label that is attached to this TaskConfig in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Determines the number of times the task will be retried on failure and with what retry strategy.
        /// This is applicable for asynchronous calls to Eventbus alone (Post To Queue, Schedule etc.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failurePolicy")]
        public virtual GoogleCloudIntegrationsV1alphaFailurePolicy FailurePolicy { get; set; }

        /// <summary>Optional. If set, overrides the option configured in the Task implementation class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonValidationOption")]
        public virtual string JsonValidationOption { get; set; }

        /// <summary>
        /// Optional. The set of tasks that are next in line to be executed as per the execution graph defined for the
        /// parent event, specified by `event_config_id`. Each of these next tasks are executed only if the condition
        /// associated with them evaluates to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextTasks")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaNextTask> NextTasks { get; set; }

        /// <summary>
        /// Optional. The policy dictating the execution of the next set of tasks for the current task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextTasksExecutionPolicy")]
        public virtual string NextTasksExecutionPolicy { get; set; }

        /// <summary>Optional. The customized parameters the user can pass to this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudIntegrationsV1alphaEventParameter> Parameters { get; set; }

        /// <summary>Optional. Determines what action to take upon successful task completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successPolicy")]
        public virtual GoogleCloudIntegrationsV1alphaSuccessPolicy SuccessPolicy { get; set; }

        /// <summary>
        /// Optional. Determines the number of times the task will be retried on failure and with what retry strategy.
        /// This is applicable for synchronous calls to Eventbus alone (Post).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synchronousCallFailurePolicy")]
        public virtual GoogleCloudIntegrationsV1alphaFailurePolicy SynchronousCallFailurePolicy { get; set; }

        /// <summary>Optional. The name for the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("task")]
        public virtual string Task { get; set; }

        /// <summary>Optional. The policy dictating the execution strategy of this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskExecutionStrategy")]
        public virtual string TaskExecutionStrategy { get; set; }

        /// <summary>
        /// Required. The identifier of this task within its parent event config, specified by the client. This should
        /// be unique among all the tasks belong to the same event config. We use this field as the identifier to find
        /// next tasks (via field `next_tasks.task_id`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskId")]
        public virtual string TaskId { get; set; }

        /// <summary>Optional. Used to define task-template name if task is of type task-template</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskTemplate")]
        public virtual string TaskTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the details of the execution of this task.</summary>
    public class GoogleCloudIntegrationsV1alphaTaskExecutionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status for the current task execution attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskAttemptStats")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaAttemptStats> TaskAttemptStats { get; set; }

        /// <summary>The execution state of this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskExecutionState")]
        public virtual string TaskExecutionState { get; set; }

        /// <summary>Pointer to the task config it used for execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskNumber")]
        public virtual string TaskNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration detail of a trigger.</summary>
    public class GoogleCloudIntegrationsV1alphaTriggerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An alert threshold configuration for the [trigger + client + integration] tuple. If these values
        /// are not specified in the trigger config, default values will be populated by the system. Note that there
        /// must be exactly one alert threshold configured per [client + trigger + integration] when published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertConfig")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaIntegrationAlertConfig> AlertConfig { get; set; }

        /// <summary>Optional. Cloud Scheduler Trigger related metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSchedulerConfig")]
        public virtual GoogleCloudIntegrationsV1alphaCloudSchedulerConfig CloudSchedulerConfig { get; set; }

        /// <summary>
        /// Optional. User-provided description intended to give additional business context about the task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. The user created label for a particular trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Optional. Dictates how next tasks will be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextTasksExecutionPolicy")]
        public virtual string NextTasksExecutionPolicy { get; set; }

        /// <summary>
        /// Optional. Configurable properties of the trigger, not to be confused with integration parameters. E.g.
        /// "name" is a property for API triggers and "subscription" is a property for Pub/sub triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Optional. Set of tasks numbers from where the integration execution is started by this trigger. If this is
        /// empty, then integration is executed with default start tasks. In the list of start tasks, none of two tasks
        /// can have direct ancestor-descendant relationships (i.e. in a same integration execution graph).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTasks")]
        public virtual System.Collections.Generic.IList<GoogleCloudIntegrationsV1alphaNextTask> StartTasks { get; set; }

        /// <summary>Optional. The backend trigger ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>Required. A number to uniquely identify each trigger config within the integration on UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerNumber")]
        public virtual string TriggerNumber { get; set; }

        /// <summary>Optional. Type of trigger</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerType")]
        public virtual string TriggerType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>THIS METHOD WILL BE MOVED TO A SEPARATE SERVICE. Request message for Bundle update</summary>
    public class GoogleCloudIntegrationsV1alphaUpdateBundleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>It contains the updated bundle data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudIntegrationsV1alphaIntegrationBundleConfig Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Bundle update</summary>
    public class GoogleCloudIntegrationsV1alphaUpdateBundleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains updated bundle config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudIntegrationsV1alphaIntegrationBundleConfig Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for UploadIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaUploadIntegrationVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The textproto of the integration_version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>File format for upload request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileFormat")]
        public virtual string FileFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for UploadIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaUploadIntegrationVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uploaded integration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationVersion")]
        public virtual GoogleCloudIntegrationsV1alphaIntegrationVersion IntegrationVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Username and password pair.</summary>
    public class GoogleCloudIntegrationsV1alphaUsernameAndPassword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Password to be used</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>Username to be used</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for ValidateIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaValidateIntegrationVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ValidateIntegrationVersion.</summary>
    public class GoogleCloudIntegrationsV1alphaValidateIntegrationVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The type of the parameter.</summary>
    public class GoogleCloudIntegrationsV1alphaValueType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Boolean Array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanArray")]
        public virtual GoogleCloudIntegrationsV1alphaBooleanParameterArray BooleanArray { get; set; }

        /// <summary>Boolean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>Double Number Array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleArray")]
        public virtual GoogleCloudIntegrationsV1alphaDoubleParameterArray DoubleArray { get; set; }

        /// <summary>Double Number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Integer Array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intArray")]
        public virtual GoogleCloudIntegrationsV1alphaIntParameterArray IntArray { get; set; }

        /// <summary>Integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Json.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonValue")]
        public virtual string JsonValue { get; set; }

        /// <summary>String Array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringArray")]
        public virtual GoogleCloudIntegrationsV1alphaStringParameterArray StringArray { get; set; }

        /// <summary>String.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Use this request to post all workflows associated with a given trigger id. Next available id: 10
    /// </summary>
    public class GoogleInternalCloudCrmEventbusV3PostToQueueWithTriggerIdRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If the client id is provided, then the combination of trigger id and client id is matched across
        /// all the workflows. If the client id is not provided, then workflows with matching trigger id are executed
        /// for each client id in the {@link TriggerConfig}. For Api Trigger, the client id is required and will be
        /// validated against the allowed clients.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Optional. Flag to determine whether clients would suppress a warning when no ACTIVE workflows are not found.
        /// If this flag is set to be true, an error will not be thrown if the requested trigger_id or client_id is not
        /// found in any ACTIVE workflow. Otherwise, the error is always thrown. The flag is set to be false by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreErrorIfNoActiveWorkflow")]
        public virtual System.Nullable<bool> IgnoreErrorIfNoActiveWorkflow { get; set; }

        /// <summary>Passed in as parameters to each workflow execution. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual EnterpriseCrmEventbusProtoEventParameters Parameters { get; set; }

        /// <summary>The request priority this request should be processed at. For internal users:</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>
        /// Optional. This is used to de-dup incoming request: if the duplicate request was detected, the response from
        /// the previous execution is returned. Must have no more than 36 characters and contain only alphanumeric
        /// characters and hyphens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>Optional. Time in milliseconds since epoch when the given event would be scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledTime")]
        public virtual System.Nullable<long> ScheduledTime { get; set; }

        /// <summary>Optional. Sets test mode in {@link enterprise/crm/eventbus/event_message.proto}.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testMode")]
        public virtual System.Nullable<bool> TestMode { get; set; }

        /// <summary>
        /// Matched against all {@link TriggerConfig}s across all workflows. i.e.
        /// TriggerConfig.trigger_id.equals(trigger_id) Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>
        /// Optional. If provided, the workflow_name is used to filter all the matched workflows having same
        /// trigger_id+client_id. A combination of trigger_id, client_id and workflow_name identifies a unique workflow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowName")]
        public virtual string WorkflowName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
