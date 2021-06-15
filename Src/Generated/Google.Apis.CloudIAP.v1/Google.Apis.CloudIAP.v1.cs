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

namespace Google.Apis.CloudIAP.v1
{
    /// <summary>The CloudIAP Service.</summary>
    public class CloudIAPService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudIAPService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudIAPService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            V1 = new V1Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "iap";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://iap.googleapis.com/";
        #else
            "https://iap.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://iap.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Identity-Aware Proxy API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Identity-Aware Proxy API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the V1 resource.</summary>
        public virtual V1Resource V1 { get; }
    }

    /// <summary>A base abstract class for CloudIAP requests.</summary>
    public abstract class CloudIAPBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudIAPBaseServiceRequest instance.</summary>
        protected CloudIAPBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudIAP parameter list.</summary>
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
            Brands = new BrandsResource(service);
        }

        /// <summary>Gets the Brands resource.</summary>
        public virtual BrandsResource Brands { get; }

        /// <summary>The "brands" collection of methods.</summary>
        public class BrandsResource
        {
            private const string Resource = "brands";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BrandsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                IdentityAwareProxyClients = new IdentityAwareProxyClientsResource(service);
            }

            /// <summary>Gets the IdentityAwareProxyClients resource.</summary>
            public virtual IdentityAwareProxyClientsResource IdentityAwareProxyClients { get; }

            /// <summary>The "identityAwareProxyClients" collection of methods.</summary>
            public class IdentityAwareProxyClientsResource
            {
                private const string Resource = "identityAwareProxyClients";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IdentityAwareProxyClientsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates an Identity Aware Proxy (IAP) OAuth client. The client is owned by IAP. Requires that the
                /// brand for the project exists and that it is set for internal-only use.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Path to create the client in. In the following format:
                /// projects/{project_number/id}/brands/{brand}. The project must belong to a G Suite account.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudIAP.v1.Data.IdentityAwareProxyClient body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates an Identity Aware Proxy (IAP) OAuth client. The client is owned by IAP. Requires that the
                /// brand for the project exists and that it is set for internal-only use.
                /// </summary>
                public class CreateRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.IdentityAwareProxyClient>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIAP.v1.Data.IdentityAwareProxyClient body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Path to create the client in. In the following format:
                    /// projects/{project_number/id}/brands/{brand}. The project must belong to a G Suite account.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIAP.v1.Data.IdentityAwareProxyClient Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/identityAwareProxyClients";

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
                            Pattern = @"^projects/[^/]+/brands/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes an Identity Aware Proxy (IAP) OAuth client. Useful for removing obsolete clients, managing
                /// the number of clients in a given project, and cleaning up after tests. Requires that the client is
                /// owned by IAP.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the Identity Aware Proxy client to be deleted. In the following format:
                /// projects/{project_number/id}/brands/{brand}/identityAwareProxyClients/{client_id}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes an Identity Aware Proxy (IAP) OAuth client. Useful for removing obsolete clients, managing
                /// the number of clients in a given project, and cleaning up after tests. Requires that the client is
                /// owned by IAP.
                /// </summary>
                public class DeleteRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the Identity Aware Proxy client to be deleted. In the following format:
                    /// projects/{project_number/id}/brands/{brand}/identityAwareProxyClients/{client_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/brands/[^/]+/identityAwareProxyClients/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Retrieves an Identity Aware Proxy (IAP) OAuth client. Requires that the client is owned by IAP.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the Identity Aware Proxy client to be fetched. In the following format:
                /// projects/{project_number/id}/brands/{brand}/identityAwareProxyClients/{client_id}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Retrieves an Identity Aware Proxy (IAP) OAuth client. Requires that the client is owned by IAP.
                /// </summary>
                public class GetRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.IdentityAwareProxyClient>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the Identity Aware Proxy client to be fetched. In the following format:
                    /// projects/{project_number/id}/brands/{brand}/identityAwareProxyClients/{client_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/brands/[^/]+/identityAwareProxyClients/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the existing clients for the brand.</summary>
                /// <param name="parent">
                /// Required. Full brand path. In the following format: projects/{project_number/id}/brands/{brand}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists the existing clients for the brand.</summary>
                public class ListRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.ListIdentityAwareProxyClientsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Full brand path. In the following format: projects/{project_number/id}/brands/{brand}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of clients to return. The service may return fewer than this value. If
                    /// unspecified, at most 100 clients will be returned. The maximum value is 1000; values above 1000
                    /// will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListIdentityAwareProxyClients` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListIdentityAwareProxyClients` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/identityAwareProxyClients";

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
                            Pattern = @"^projects/[^/]+/brands/[^/]+$",
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
                /// Resets an Identity Aware Proxy (IAP) OAuth client secret. Useful if the secret was compromised.
                /// Requires that the client is owned by IAP.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the Identity Aware Proxy client to that will have its secret reset. In the
                /// following format: projects/{project_number/id}/brands/{brand}/identityAwareProxyClients/{client_id}.
                /// </param>
                public virtual ResetSecretRequest ResetSecret(Google.Apis.CloudIAP.v1.Data.ResetIdentityAwareProxyClientSecretRequest body, string name)
                {
                    return new ResetSecretRequest(service, body, name);
                }

                /// <summary>
                /// Resets an Identity Aware Proxy (IAP) OAuth client secret. Useful if the secret was compromised.
                /// Requires that the client is owned by IAP.
                /// </summary>
                public class ResetSecretRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.IdentityAwareProxyClient>
                {
                    /// <summary>Constructs a new ResetSecret request.</summary>
                    public ResetSecretRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIAP.v1.Data.ResetIdentityAwareProxyClientSecretRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the Identity Aware Proxy client to that will have its secret reset. In the
                    /// following format:
                    /// projects/{project_number/id}/brands/{brand}/identityAwareProxyClients/{client_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIAP.v1.Data.ResetIdentityAwareProxyClientSecretRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resetSecret";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:resetSecret";

                    /// <summary>Initializes ResetSecret parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/brands/[^/]+/identityAwareProxyClients/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Constructs a new OAuth brand for the project if one does not exist. The created brand is "internal
            /// only", meaning that OAuth clients created under it only accept requests from users who belong to the
            /// same G Suite organization as the project. The brand is created in an un-reviewed status. NOTE: The
            /// "internal only" status can be manually changed in the Google Cloud console. Requires that a brand does
            /// not already exist for the project, and that the specified support email is owned by the caller.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. GCP Project number/id under which the brand is to be created. In the following format:
            /// projects/{project_number/id}.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudIAP.v1.Data.Brand body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Constructs a new OAuth brand for the project if one does not exist. The created brand is "internal
            /// only", meaning that OAuth clients created under it only accept requests from users who belong to the
            /// same G Suite organization as the project. The brand is created in an un-reviewed status. NOTE: The
            /// "internal only" status can be manually changed in the Google Cloud console. Requires that a brand does
            /// not already exist for the project, and that the specified support email is owned by the caller.
            /// </summary>
            public class CreateRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.Brand>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIAP.v1.Data.Brand body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. GCP Project number/id under which the brand is to be created. In the following format:
                /// projects/{project_number/id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIAP.v1.Data.Brand Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/brands";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves the OAuth brand of the project.</summary>
            /// <param name="name">
            /// Required. Name of the brand to be fetched. In the following format:
            /// projects/{project_number/id}/brands/{brand}.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves the OAuth brand of the project.</summary>
            public class GetRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.Brand>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the brand to be fetched. In the following format:
                /// projects/{project_number/id}/brands/{brand}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/brands/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the existing brands for the project.</summary>
            /// <param name="parent">
            /// Required. GCP Project number/id. In the following format: projects/{project_number/id}.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the existing brands for the project.</summary>
            public class ListRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.ListBrandsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. GCP Project number/id. In the following format: projects/{project_number/id}.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/brands";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
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
        /// Gets the access control policy for an Identity-Aware Proxy protected resource. More information about
        /// managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudIAP.v1.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Gets the access control policy for an Identity-Aware Proxy protected resource. More information about
        /// managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        public class GetIamPolicyRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIAP.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIAP.v1.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:getIamPolicy";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>Gets the IAP settings on a particular IAP protected resource.</summary>
        /// <param name="name">
        /// Required. The resource name for which to retrieve the settings. Authorization: Requires the `getSettings`
        /// permission for the associated resource.
        /// </param>
        public virtual GetIapSettingsRequest GetIapSettings(string name)
        {
            return new GetIapSettingsRequest(service, name);
        }

        /// <summary>Gets the IAP settings on a particular IAP protected resource.</summary>
        public class GetIapSettingsRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.IapSettings>
        {
            /// <summary>Constructs a new GetIapSettings request.</summary>
            public GetIapSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name for which to retrieve the settings. Authorization: Requires the
            /// `getSettings` permission for the associated resource.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIapSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:iapSettings";

            /// <summary>Initializes GetIapSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>
        /// Sets the access control policy for an Identity-Aware Proxy protected resource. Replaces any existing policy.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
        /// appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudIAP.v1.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(service, body, resource);
        }

        /// <summary>
        /// Sets the access control policy for an Identity-Aware Proxy protected resource. Replaces any existing policy.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        public class SetIamPolicyRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIAP.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIAP.v1.Data.SetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:setIamPolicy";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the Identity-Aware Proxy protected resource. More information about
        /// managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation for
        /// the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudIAP.v1.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(service, body, resource);
        }

        /// <summary>
        /// Returns permissions that a caller has on the Identity-Aware Proxy protected resource. More information about
        /// managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        public class TestIamPermissionsRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIAP.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIAP.v1.Data.TestIamPermissionsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+resource}:testIamPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                {
                    Name = "resource",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>
        /// Updates the IAP settings on a particular IAP protected resource. It replaces all fields unless the
        /// `update_mask` is set.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The resource name of the IAP protected resource.</param>
        public virtual UpdateIapSettingsRequest UpdateIapSettings(Google.Apis.CloudIAP.v1.Data.IapSettings body, string name)
        {
            return new UpdateIapSettingsRequest(service, body, name);
        }

        /// <summary>
        /// Updates the IAP settings on a particular IAP protected resource. It replaces all fields unless the
        /// `update_mask` is set.
        /// </summary>
        public class UpdateIapSettingsRequest : CloudIAPBaseServiceRequest<Google.Apis.CloudIAP.v1.Data.IapSettings>
        {
            /// <summary>Constructs a new UpdateIapSettings request.</summary>
            public UpdateIapSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIAP.v1.Data.IapSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the IAP protected resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The field mask specifying which IAP settings should be updated. If omitted, the all of the settings are
            /// updated. See https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIAP.v1.Data.IapSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateIapSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:iapSettings";

            /// <summary>Initializes UpdateIapSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
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
}
namespace Google.Apis.CloudIAP.v1.Data
{
    /// <summary>
    /// Custom content configuration for access denied page. IAP allows customers to define a custom URI to use as the
    /// error page when access is denied to users. If IAP prevents access to this page, the default IAP error page will
    /// be displayed instead.
    /// </summary>
    public class AccessDeniedPageSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI to be redirected to when access is denied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessDeniedPageUri")]
        public virtual string AccessDeniedPageUri { get; set; }

        /// <summary>Whether to generate a troubleshooting URL on access denied events to this application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateTroubleshootingUri")]
        public virtual System.Nullable<bool> GenerateTroubleshootingUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Access related settings for IAP protected apps.</summary>
    public class AccessSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration to allow cross-origin requests via IAP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corsSettings")]
        public virtual CorsSettings CorsSettings { get; set; }

        /// <summary>GCIP claims and endpoint configurations for 3p identity providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcipSettings")]
        public virtual GcipSettings GcipSettings { get; set; }

        /// <summary>Settings to configure IAP's OAuth behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthSettings")]
        public virtual OAuthSettings OauthSettings { get; set; }

        /// <summary>
        /// Settings to configure Policy delegation for apps hosted in tenant projects. INTERNAL_ONLY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDelegationSettings")]
        public virtual PolicyDelegationSettings PolicyDelegationSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper over application specific settings for IAP.</summary>
    public class ApplicationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Customization for Access Denied page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessDeniedPageSettings")]
        public virtual AccessDeniedPageSettings AccessDeniedPageSettings { get; set; }

        /// <summary>
        /// The Domain value to set for cookies generated by IAP. This value is not validated by the API, but will be
        /// ignored at runtime if invalid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieDomain")]
        public virtual string CookieDomain { get; set; }

        /// <summary>Settings to configure IAP's behavior for a CSM mesh.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csmSettings")]
        public virtual CsmSettings CsmSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
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
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OAuth brand data. NOTE: Only contains a portion of the data that describes a brand.</summary>
    public class Brand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Application name displayed on OAuth consent screen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationTitle")]
        public virtual string ApplicationTitle { get; set; }

        /// <summary>
        /// Output only. Identifier of the brand. NOTE: GCP project number achieves the same brand identification
        /// purpose as only one brand per project can be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Whether the brand is only intended for usage inside the G Suite organization only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgInternalOnly")]
        public virtual System.Nullable<bool> OrgInternalOnly { get; set; }

        /// <summary>Support email displayed on the OAuth consent screen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportEmail")]
        public virtual string SupportEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Allows customers to configure HTTP request paths that'll allow HTTP OPTIONS call to bypass authentication and
    /// authorization.
    /// </summary>
    public class CorsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Configuration to allow HTTP OPTIONS calls to skip authorization. If undefined, IAP will not apply any
        /// special logic to OPTIONS requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowHttpOptions")]
        public virtual System.Nullable<bool> AllowHttpOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for RCTokens generated for CSM workloads protected by IAP. RCTokens are IAP generated JWTs that
    /// can be verified at the application. The RCToken is primarily used for ISTIO deployments, and can be scoped to a
    /// single mesh by configuring the audience field accordingly
    /// </summary>
    public class CsmSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Audience claim set in the generated RCToken. This value is not validated by IAP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rctokenAud")]
        public virtual string RctokenAud { get; set; }

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
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Allows customers to configure tenant_id for GCIP instance per-app.</summary>
    public class GcipSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Login page URI associated with the GCIP tenants. Typically, all resources within the same project share the
        /// same login page, though it could be overridden at the sub resource level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginPageUri")]
        public virtual string LoginPageUri { get; set; }

        /// <summary>
        /// GCIP tenant ids that are linked to the IAP resource. tenant_ids could be a string beginning with a number
        /// character to indicate authenticating with GCIP tenant flow, or in the format of _ to indicate authenticating
        /// with GCIP agent flow. If agent flow is used, tenant_ids should only contain one single element, while for
        /// tenant flow, tenant_ids can contain multiple elements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantIds")]
        public virtual System.Collections.Generic.IList<string> TenantIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The IAP configurable settings.</summary>
    public class IapSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Top level wrapper for all access related setting in IAP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessSettings")]
        public virtual AccessSettings AccessSettings { get; set; }

        /// <summary>Top level wrapper for all application related settings in IAP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationSettings")]
        public virtual ApplicationSettings ApplicationSettings { get; set; }

        /// <summary>Required. The resource name of the IAP protected resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the data that describes an Identity Aware Proxy owned client.</summary>
    public class IdentityAwareProxyClient : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human-friendly name given to the OAuth client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Unique identifier of the OAuth client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Client secret of the OAuth client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBrands.</summary>
    public class ListBrandsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Brands existing in the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brands")]
        public virtual System.Collections.Generic.IList<Brand> Brands { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListIdentityAwareProxyClients.</summary>
    public class ListIdentityAwareProxyClientsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Clients existing in the brand.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityAwareProxyClients")]
        public virtual System.Collections.Generic.IList<IdentityAwareProxyClient> IdentityAwareProxyClients { get; set; }

        /// <summary>
        /// A token, which can be send as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for OAuth login&amp;consent flow behavior as well as for OAuth Credentials.</summary>
    public class OAuthSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Domain hint to send as hd=? parameter in OAuth request flow. Enables redirect to primary IDP by skipping
        /// Google's login screen. https://developers.google.com/identity/protocols/OpenIDConnect#hd-param Note: IAP
        /// does not verify that the id token's hd claim matches this value since access behavior is managed by IAM
        /// policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginHint")]
        public virtual string LoginHint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>
    /// PolicyDelegationConfig allows google-internal teams to use IAP for apps hosted in a tenant project. Using these
    /// settings, the app can delegate permission check to happen against the linked customer project. This is only ever
    /// supposed to be used by google internal teams, hence the restriction on the proto.
    /// </summary>
    public class PolicyDelegationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Permission to check in IAM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPermission")]
        public virtual string IamPermission { get; set; }

        /// <summary>
        /// The DNS name of the service (e.g. "resourcemanager.googleapis.com"). This should be the domain name part of
        /// the full resource names (see https://aip.dev/122#full-resource-names), which is usually the same as
        /// IamServiceSpec.service of the service where the resource type is defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamServiceName")]
        public virtual string IamServiceName { get; set; }

        /// <summary>Policy name to be checked</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyName")]
        public virtual PolicyName PolicyName { get; set; }

        /// <summary>IAM resource to check permission on</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An internal name for an IAM policy, based on the resource to which the policy applies. Not to be confused with a
    /// resource's external full resource name. For more information on this distinction, see
    /// go/iam-full-resource-names.
    /// </summary>
    public class PolicyName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies an instance of the type. ID format varies by type. The ID format is defined in the IAM .service
        /// file that defines the type, either in path_mapping or in a comment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// For Cloud IAM: The location of the Policy. Must be empty or "global" for Policies owned by global IAM. Must
        /// name a region from prodspec/cloud-iam-cloudspec for Regional IAM Policies, see
        /// go/iam-faq#where-is-iam-currently-deployed. For Local IAM: This field should be set to "local".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>
        /// Resource type. Types are defined in IAM's .service files. Valid values for type might be 'gce', 'gcs',
        /// 'project', 'account' etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to ResetIdentityAwareProxyClientSecret.</summary>
    public class ResetIdentityAwareProxyClientSecretRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The service defined labels of the resource on which the conditions will be evaluated. The semantics -
        /// including the key names - are vague to IAM. If the effective condition has a reference to a
        /// `resource.labels[foo]` construct, IAM consults with this map to retrieve the values associated with `foo`
        /// key for Conditions evaluation. If the provided key is not found in the labels map, the condition would
        /// evaluate to false. This field is in limited use. If your intended use case is not expected to express
        /// resource.labels attribute in IAM Conditions, leave this field empty. Before planning on using this attribute
        /// please: * Read go/iam-conditions-labels-comm and ensure your service can meet the data availability and
        /// management requirements. * Talk to iam-conditions-eng@ about your use case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Name of the resource on which conditions will be evaluated. Must use the Relative Resource Name of the
        /// resource, which is the URI path of the resource without the leading "/". Examples are
        /// "projects/_/buckets/[BUCKET-ID]" for storage buckets or
        /// "projects/[PROJECT-ID]/global/firewalls/[FIREWALL-ID]" for a firewall. This field is required for evaluating
        /// conditions with rules on resource names. For a `list` permission check, the resource.name value must be set
        /// to the parent resource. If the parent resource is a project, this field should be left unset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the service this resource belongs to. It is configured using the official_service_name of the
        /// Service as defined in service configurations under //configs/cloud/resourcetypes. For example, the
        /// official_service_name of cloud resource manager service is set as 'cloudresourcemanager.googleapis.com'
        /// according to //configs/cloud/resourcetypes/google/cloud/resourcemanager/prod.yaml
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// The public resource type name of the resource on which conditions will be evaluated. It is configured using
        /// the official_name of the ResourceType as defined in service configurations under
        /// //configs/cloud/resourcetypes. For example, the official_name for GCP projects is set as
        /// 'cloudresourcemanager.googleapis.com/Project' according to
        /// //configs/cloud/resourcetypes/google/cloud/resourcemanager/prod.yaml For details see
        /// go/iam-conditions-integration-guide.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
