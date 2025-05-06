// Copyright 2025 Google LLC
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

namespace Google.Apis.GKEOnPrem.v1
{
    /// <summary>The GKEOnPrem Service.</summary>
    public class GKEOnPremService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GKEOnPremService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GKEOnPremService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://gkeonprem.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://gkeonprem.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gkeonprem";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the GKE On-Prem API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the GKE On-Prem API.</summary>
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

    /// <summary>A base abstract class for GKEOnPrem requests.</summary>
    public abstract class GKEOnPremBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GKEOnPremBaseServiceRequest instance.</summary>
        protected GKEOnPremBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GKEOnPrem parameter list.</summary>
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
                BareMetalAdminClusters = new BareMetalAdminClustersResource(service);
                BareMetalClusters = new BareMetalClustersResource(service);
                Operations = new OperationsResource(service);
                VmwareAdminClusters = new VmwareAdminClustersResource(service);
                VmwareClusters = new VmwareClustersResource(service);
            }

            /// <summary>Gets the BareMetalAdminClusters resource.</summary>
            public virtual BareMetalAdminClustersResource BareMetalAdminClusters { get; }

            /// <summary>The "bareMetalAdminClusters" collection of methods.</summary>
            public class BareMetalAdminClustersResource
            {
                private const string Resource = "bareMetalAdminClusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BareMetalAdminClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the Operations resource.</summary>
                public virtual OperationsResource Operations { get; }

                /// <summary>The "operations" collection of methods.</summary>
                public class OperationsResource
                {
                    private const string Resource = "operations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OperationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalAdminClusters/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListOperationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation's parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The standard list filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The standard list page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The standard list page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/operations";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalAdminClusters/[^/]+$",
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

                /// <summary>
                /// Creates a new bare metal admin cluster in a given project and location. The API needs to be combined
                /// with creating a bootstrap cluster to work. See:
                /// https://cloud.google.com/anthos/clusters/docs/bare-metal/latest/installing/creating-clusters/create-admin-cluster-api#prepare_bootstrap_environment
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the project and location where the cluster is created in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GKEOnPrem.v1.Data.BareMetalAdminCluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new bare metal admin cluster in a given project and location. The API needs to be combined
                /// with creating a bootstrap cluster to work. See:
                /// https://cloud.google.com/anthos/clusters/docs/bare-metal/latest/installing/creating-clusters/create-admin-cluster-api#prepare_bootstrap_environment
                /// </summary>
                public class CreateRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.BareMetalAdminCluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the cluster is created in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, CLM will force CCFE to persist the cluster resource in RMS when the
                    /// creation fails during standalone preflight checks. In that case the subsequent create call will
                    /// fail with "cluster already exists" error and hence a update cluster is required to fix the
                    /// cluster.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowPreflightFailure", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowPreflightFailure { get; set; }

                    /// <summary>
                    /// Required. User provided identifier that is used as part of the resource name; must conform to
                    /// RFC-1034 and additionally restrict to lower-cased letters. This comes out roughly to:
                    /// /^a-z+[a-z0-9]$/
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("bareMetalAdminClusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BareMetalAdminClusterId { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.BareMetalAdminCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bareMetalAdminClusters";

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
                        RequestParameters.Add("allowPreflightFailure", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowPreflightFailure",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("bareMetalAdminClusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "bareMetalAdminClusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Enrolls an existing bare metal admin cluster to the Anthos On-Prem API within a given project and
                /// location. Through enrollment, an existing admin cluster will become Anthos On-Prem API managed. The
                /// corresponding GCP resources will be created and all future modifications to the cluster will be
                /// expected to be performed through the API.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the project and location where the cluster is enrolled in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual EnrollRequest Enroll(Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalAdminClusterRequest body, string parent)
                {
                    return new EnrollRequest(this.service, body, parent);
                }

                /// <summary>
                /// Enrolls an existing bare metal admin cluster to the Anthos On-Prem API within a given project and
                /// location. Through enrollment, an existing admin cluster will become Anthos On-Prem API managed. The
                /// corresponding GCP resources will be created and all future modifications to the cluster will be
                /// expected to be performed through the API.
                /// </summary>
                public class EnrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Enroll request.</summary>
                    public EnrollRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalAdminClusterRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the cluster is enrolled in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalAdminClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enroll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bareMetalAdminClusters:enroll";

                    /// <summary>Initializes Enroll parameter list.</summary>
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

                /// <summary>Gets details of a single bare metal admin cluster.</summary>
                /// <param name="name">
                /// Required. Name of the bare metal admin cluster to get. Format:
                /// "projects/{project}/locations/{location}/bareMetalAdminClusters/{bare_metal_admin_cluster}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single bare metal admin cluster.</summary>
                public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.BareMetalAdminCluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the bare metal admin cluster to get. Format:
                    /// "projects/{project}/locations/{location}/bareMetalAdminClusters/{bare_metal_admin_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If true, return BareMetal Admin Cluster including the one that only exists in RMS.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// View for bare metal admin cluster. When `BASIC` is specified, only the cluster resource name and
                    /// membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same as
                    /// `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// View for bare metal admin cluster. When `BASIC` is specified, only the cluster resource name and
                    /// membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same as
                    /// `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes basic information of a cluster resource including cluster resource name and
                        /// membership.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>
                        /// Includes the complete configuration for bare metal admin cluster resource. This is the
                        /// default value for GetBareMetalAdminClusterRequest method.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalAdminClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalAdminClusters/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists bare metal admin clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent of the project and location where the clusters are listed in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists bare metal admin clusters in a given project and location.</summary>
                public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListBareMetalAdminClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the clusters are listed in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If true, return list of BareMetal Admin Clusters including the ones that only exists
                    /// in RMS.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, at most 50
                    /// clusters will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// View for bare metal admin clusters. When `BASIC` is specified, only the admin cluster resource
                    /// name and membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same
                    /// as `FULL', which returns the complete admin cluster configuration details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// View for bare metal admin clusters. When `BASIC` is specified, only the admin cluster resource
                    /// name and membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same
                    /// as `FULL', which returns the complete admin cluster configuration details.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes basic information of a admin cluster resource including admin cluster resource name
                        /// and membership.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>
                        /// Includes the complete configuration for bare metal admin cluster resource. This is the
                        /// default value for ListBareMetalAdminClustersRequest method.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bareMetalAdminClusters";

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
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates the parameters of a single bare metal admin cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Immutable. The bare metal admin cluster resource name.</param>
                public virtual PatchRequest Patch(Google.Apis.GKEOnPrem.v1.Data.BareMetalAdminCluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single bare metal admin cluster.</summary>
                public class PatchRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.BareMetalAdminCluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Immutable. The bare metal admin cluster resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the
                    /// BareMetalAdminCluster resource by the update. The fields specified in the update_mask are
                    /// relative to the resource, not the full request. A field will be overwritten if it is in the
                    /// mask. If the user does not provide a mask then all populated fields in the BareMetalAdminCluster
                    /// message will be updated. Empty fields will be ignored unless a field mask is used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.BareMetalAdminCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalAdminClusters/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Queries the bare metal admin cluster version config.</summary>
                /// <param name="parent">
                /// Required. The parent of the project and location to query for version config. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual QueryVersionConfigRequest QueryVersionConfig(string parent)
                {
                    return new QueryVersionConfigRequest(this.service, parent);
                }

                /// <summary>Queries the bare metal admin cluster version config.</summary>
                public class QueryVersionConfigRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.QueryBareMetalAdminVersionConfigResponse>
                {
                    /// <summary>Constructs a new QueryVersionConfig request.</summary>
                    public QueryVersionConfigRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location to query for version config. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The admin cluster resource name. This is the full resource name of the admin cluster resource.
                    /// Format:
                    /// "projects/{project}/locations/{location}/bareMetalAdminClusters/{bare_metal_admin_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("upgradeConfig.clusterName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UpgradeConfigClusterName { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "queryVersionConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bareMetalAdminClusters:queryVersionConfig";

                    /// <summary>Initializes QueryVersionConfig parameter list.</summary>
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
                        RequestParameters.Add("upgradeConfig.clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "upgradeConfig.clusterName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalAdminClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalAdminClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Unenrolls an existing bare metal admin cluster from the Anthos On-Prem API within a given project
                /// and location. Unenrollment removes the Cloud reference to the cluster without modifying the
                /// underlying OnPrem Resources. Clusters will continue to run; however, they will no longer be
                /// accessible through the Anthos On-Prem API or its clients.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the bare metal admin cluster to be unenrolled. Format:
                /// "projects/{project}/locations/{location}/bareMetalAdminClusters/{cluster}"
                /// </param>
                public virtual UnenrollRequest Unenroll(string name)
                {
                    return new UnenrollRequest(this.service, name);
                }

                /// <summary>
                /// Unenrolls an existing bare metal admin cluster from the Anthos On-Prem API within a given project
                /// and location. Unenrollment removes the Cloud reference to the cluster without modifying the
                /// underlying OnPrem Resources. Clusters will continue to run; however, they will no longer be
                /// accessible through the Anthos On-Prem API or its clients.
                /// </summary>
                public class UnenrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Unenroll request.</summary>
                    public UnenrollRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the bare metal admin cluster to be unenrolled. Format:
                    /// "projects/{project}/locations/{location}/bareMetalAdminClusters/{cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the bare metal admin cluster is not found, the request will succeed but no
                    /// action will be taken on the server and return a completed LRO.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// The current etag of the bare metal admin cluster. If an etag is provided and does not match the
                    /// current etag of the cluster, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// If set to true, the unenrollment of a bare metal admin cluster resource will succeed even if
                    /// errors occur during unenrollment. This parameter can be used when you want to unenroll admin
                    /// cluster resource and the on-prem admin cluster is disconnected / unreachable. WARNING: Using
                    /// this parameter when your admin cluster still exists may result in a deleted GCP admin cluster
                    /// but existing resourcelink in on-prem admin cluster and membership.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreErrors", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreErrors { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "unenroll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:unenroll";

                    /// <summary>Initializes Unenroll parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalAdminClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("ignoreErrors", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreErrors",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the BareMetalClusters resource.</summary>
            public virtual BareMetalClustersResource BareMetalClusters { get; }

            /// <summary>The "bareMetalClusters" collection of methods.</summary>
            public class BareMetalClustersResource
            {
                private const string Resource = "bareMetalClusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BareMetalClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    BareMetalNodePools = new BareMetalNodePoolsResource(service);
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the BareMetalNodePools resource.</summary>
                public virtual BareMetalNodePoolsResource BareMetalNodePools { get; }

                /// <summary>The "bareMetalNodePools" collection of methods.</summary>
                public class BareMetalNodePoolsResource
                {
                    private const string Resource = "bareMetalNodePools";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BareMetalNodePoolsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Operations = new OperationsResource(service);
                    }

                    /// <summary>Gets the Operations resource.</summary>
                    public virtual OperationsResource Operations { get; }

                    /// <summary>The "operations" collection of methods.</summary>
                    public class OperationsResource
                    {
                        private const string Resource = "operations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public OperationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        /// <param name="name">The name of the operation resource.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the operation resource.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        /// <param name="name">The name of the operation's parent resource.</param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(this.service, name);
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListOperationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the operation's parent resource.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The standard list filter.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>The standard list page size.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>The standard list page token.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/operations";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+$",
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

                    /// <summary>
                    /// Creates a new bare metal node pool in a given project, location and Bare Metal cluster.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource where this node pool will be created.
                    /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GKEOnPrem.v1.Data.BareMetalNodePool body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new bare metal node pool in a given project, location and Bare Metal cluster.
                    /// </summary>
                    public class CreateRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.BareMetalNodePool body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this node pool will be created.
                        /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The ID to use for the node pool, which will become the final component of the node pool's
                        /// resource name. This value must be up to 63 characters, and valid characters are /a-z-/. The
                        /// value must not be permitted to be a UUID (or UUID-like: anything matching
                        /// /^[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}$/i).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("bareMetalNodePoolId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string BareMetalNodePoolId { get; set; }

                        /// <summary>
                        /// If set, only validate the request, but do not actually create the node pool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.BareMetalNodePool Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/bareMetalNodePools";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                            });
                            RequestParameters.Add("bareMetalNodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "bareMetalNodePoolId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single bare metal node pool.</summary>
                    /// <param name="name">
                    /// Required. The name of the node pool to delete. Format:
                    /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}/bareMetalNodePools/{nodepool}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single bare metal node pool.</summary>
                    public class DeleteRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the node pool to delete. Format:
                        /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}/bareMetalNodePools/{nodepool}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, and the bare metal node pool is not found, the request will succeed but no
                        /// action will be taken on the server and return a completed LRO.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// The current etag of the BareMetalNodePool. If an etag is provided and does not match the
                        /// current etag of the node pool, deletion will be blocked and an ABORTED error will be
                        /// returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// If set to true, the deletion of a bare metal node pool resource will succeed even if errors
                        /// occur during deletion. This parameter can be used when you want to delete GCP's node pool
                        /// resource and you've already deleted the on-prem admin cluster that hosted your node pool.
                        /// WARNING: Using this parameter when your user cluster still exists may result in a deleted
                        /// GCP node pool but an existing on-prem node pool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("ignoreErrors", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> IgnoreErrors { get; set; }

                        /// <summary>
                        /// If set, only validate the request, but do not actually delete the node pool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("ignoreErrors", new Google.Apis.Discovery.Parameter
                            {
                                Name = "ignoreErrors",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Enrolls an existing bare metal node pool to the Anthos On-Prem API within a given project and
                    /// location. Through enrollment, an existing node pool will become Anthos On-Prem API managed. The
                    /// corresponding GCP resources will be created.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource where this node pool will be created.
                    /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}
                    /// </param>
                    public virtual EnrollRequest Enroll(Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalNodePoolRequest body, string parent)
                    {
                        return new EnrollRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Enrolls an existing bare metal node pool to the Anthos On-Prem API within a given project and
                    /// location. Through enrollment, an existing node pool will become Anthos On-Prem API managed. The
                    /// corresponding GCP resources will be created.
                    /// </summary>
                    public class EnrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Enroll request.</summary>
                        public EnrollRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalNodePoolRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this node pool will be created.
                        /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalNodePoolRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "enroll";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/bareMetalNodePools:enroll";

                        /// <summary>Initializes Enroll parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single bare metal node pool.</summary>
                    /// <param name="name">
                    /// Required. The name of the node pool to retrieve.
                    /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}/bareMetalNodePools/{nodepool}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single bare metal node pool.</summary>
                    public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.BareMetalNodePool>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the node pool to retrieve.
                        /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}/bareMetalNodePools/{nodepool}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// View for bare metal node pool. When `BASIC` is specified, only the node pool resource name
                        /// is returned. The default/unset value `NODE_POOL_VIEW_UNSPECIFIED` is the same as `FULL',
                        /// which returns the complete node pool configuration details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// View for bare metal node pool. When `BASIC` is specified, only the node pool resource name
                        /// is returned. The default/unset value `NODE_POOL_VIEW_UNSPECIFIED` is the same as `FULL',
                        /// which returns the complete node pool configuration details.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                            [Google.Apis.Util.StringValueAttribute("NODE_POOL_VIEW_UNSPECIFIED")]
                            NODEPOOLVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Includes basic information of a node pool resource including node pool resource name.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>
                            /// Includes the complete configuration for bare metal node pool resource. This is the
                            /// default value for GetBareMetalNodePoolRequest method.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+$",
                            });
                            RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                            {
                                Name = "view",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Lists bare metal node pools in a given project, location and bare metal cluster.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of node pools. Format:
                    /// projects/{project}/locations/{location}/bareMetalClusters/{bareMetalCluster}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists bare metal node pools in a given project, location and bare metal cluster.
                    /// </summary>
                    public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListBareMetalNodePoolsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of node pools. Format:
                        /// projects/{project}/locations/{location}/bareMetalClusters/{bareMetalCluster}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of node pools to return. The service may return fewer than this value. If
                        /// unspecified, at most 50 node pools will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListBareMetalNodePools` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListBareMetalNodePools` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// View for bare metal node pools. When `BASIC` is specified, only the node pool resource name
                        /// is returned. The default/unset value `NODE_POOL_VIEW_UNSPECIFIED` is the same as `FULL',
                        /// which returns the complete node pool configuration details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// View for bare metal node pools. When `BASIC` is specified, only the node pool resource name
                        /// is returned. The default/unset value `NODE_POOL_VIEW_UNSPECIFIED` is the same as `FULL',
                        /// which returns the complete node pool configuration details.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                            [Google.Apis.Util.StringValueAttribute("NODE_POOL_VIEW_UNSPECIFIED")]
                            NODEPOOLVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Includes basic information of a node pool resource including node pool resource name.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>
                            /// Includes the complete configuration for bare metal node pool resource. This is the
                            /// default value for ListBareMetalNodePoolsRequest method.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/bareMetalNodePools";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
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
                            RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                            {
                                Name = "view",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Updates the parameters of a single bare metal node pool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Immutable. The bare metal node pool resource name.</param>
                    public virtual PatchRequest Patch(Google.Apis.GKEOnPrem.v1.Data.BareMetalNodePool body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the parameters of a single bare metal node pool.</summary>
                    public class PatchRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.BareMetalNodePool body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Immutable. The bare metal node pool resource name.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, and the bare metal node pool is not found, the request will create a new
                        /// bare metal node pool with the provided configuration. The user must have both create and
                        /// update permission to call Update with allow_missing set to true.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the
                        /// BareMetalNodePool resource by the update. The fields specified in the update_mask are
                        /// relative to the resource, not the full request. A field will be overwritten if it is in the
                        /// mask. If the user does not provide a mask then all populated fields in the BareMetalNodePool
                        /// message will be updated. Empty fields will be ignored unless a field mask is used.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Validate the request without actually doing any updates.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.BareMetalNodePool Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
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
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Unenrolls a bare metal node pool from Anthos On-Prem API.</summary>
                    /// <param name="name">
                    /// Required. The name of the node pool to unenroll. Format:
                    /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}/bareMetalNodePools/{nodepool}
                    /// </param>
                    public virtual UnenrollRequest Unenroll(string name)
                    {
                        return new UnenrollRequest(this.service, name);
                    }

                    /// <summary>Unenrolls a bare metal node pool from Anthos On-Prem API.</summary>
                    public class UnenrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Unenroll request.</summary>
                        public UnenrollRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the node pool to unenroll. Format:
                        /// projects/{project}/locations/{location}/bareMetalClusters/{cluster}/bareMetalNodePools/{nodepool}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, and the bare metal node pool is not found, the request will succeed but no
                        /// action will be taken on the server and return a completed LRO.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// The current etag of the bare metal node pool. If an etag is provided and does not match the
                        /// current etag of node pool, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// If set, only validate the request, but do not actually unenroll the node pool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "unenroll";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:unenroll";

                        /// <summary>Initializes Unenroll parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/bareMetalNodePools/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Operations resource.</summary>
                public virtual OperationsResource Operations { get; }

                /// <summary>The "operations" collection of methods.</summary>
                public class OperationsResource
                {
                    private const string Resource = "operations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OperationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListOperationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation's parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The standard list filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The standard list page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The standard list page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/operations";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
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

                /// <summary>Creates a new bare metal cluster in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the project and location where the cluster is created in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GKEOnPrem.v1.Data.BareMetalCluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new bare metal cluster in a given project and location.</summary>
                public class CreateRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.BareMetalCluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the cluster is created in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, CLM will force CCFE to persist the cluster resource in RMS when the
                    /// creation fails during standalone preflight checks. In that case the subsequent create call will
                    /// fail with "cluster already exists" error and hence a update cluster is required to fix the
                    /// cluster.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowPreflightFailure", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowPreflightFailure { get; set; }

                    /// <summary>
                    /// Required. User provided identifier that is used as part of the resource name; must conform to
                    /// RFC-1034 and additionally restrict to lower-cased letters. This comes out roughly to:
                    /// /^a-z+[a-z0-9]$/
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("bareMetalClusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string BareMetalClusterId { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.BareMetalCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bareMetalClusters";

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
                        RequestParameters.Add("allowPreflightFailure", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowPreflightFailure",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("bareMetalClusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "bareMetalClusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single bare metal Cluster.</summary>
                /// <param name="name">
                /// Required. Name of the bare metal user cluster to be deleted. Format:
                /// "projects/{project}/locations/{location}/bareMetalClusters/{bare_metal_cluster}"
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single bare metal Cluster.</summary>
                public class DeleteRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the bare metal user cluster to be deleted. Format:
                    /// "projects/{project}/locations/{location}/bareMetalClusters/{bare_metal_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the bare metal cluster is not found, the request will succeed but no action
                    /// will be taken on the server and return a completed LRO.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// The current etag of the bare metal Cluster. If an etag is provided and does not match the
                    /// current etag of the cluster, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>If set to true, any node pools from the cluster will also be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// If set to true, the deletion of a bare metal user cluster resource will succeed even if errors
                    /// occur during deletion. This parameter can be used when you want to delete GCP's cluster resource
                    /// and the on-prem admin cluster that hosts your user cluster is disconnected / unreachable or
                    /// deleted. WARNING: Using this parameter when your user cluster still exists may result in a
                    /// deleted GCP user cluster but an existing on-prem user cluster.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreErrors", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreErrors { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("ignoreErrors", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreErrors",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Enrolls an existing bare metal user cluster and its node pools to the Anthos On-Prem API within a
                /// given project and location. Through enrollment, an existing cluster will become Anthos On-Prem API
                /// managed. The corresponding GCP resources will be created and all future modifications to the cluster
                /// and/or its node pools will be expected to be performed through the API.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the project and location where the cluster is enrolled in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual EnrollRequest Enroll(Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalClusterRequest body, string parent)
                {
                    return new EnrollRequest(this.service, body, parent);
                }

                /// <summary>
                /// Enrolls an existing bare metal user cluster and its node pools to the Anthos On-Prem API within a
                /// given project and location. Through enrollment, an existing cluster will become Anthos On-Prem API
                /// managed. The corresponding GCP resources will be created and all future modifications to the cluster
                /// and/or its node pools will be expected to be performed through the API.
                /// </summary>
                public class EnrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Enroll request.</summary>
                    public EnrollRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalClusterRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the cluster is enrolled in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.EnrollBareMetalClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enroll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bareMetalClusters:enroll";

                    /// <summary>Initializes Enroll parameter list.</summary>
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

                /// <summary>Gets details of a single bare metal Cluster.</summary>
                /// <param name="name">
                /// Required. Name of the bare metal user cluster to get. Format:
                /// "projects/{project}/locations/{location}/bareMetalClusters/{bare_metal_cluster}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single bare metal Cluster.</summary>
                public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.BareMetalCluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the bare metal user cluster to get. Format:
                    /// "projects/{project}/locations/{location}/bareMetalClusters/{bare_metal_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If true, return BareMetal Cluster including the one that only exists in RMS.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// View for bare metal user cluster. When `BASIC` is specified, only the cluster resource name and
                    /// admin cluster membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the
                    /// same as `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// View for bare metal user cluster. When `BASIC` is specified, only the cluster resource name and
                    /// admin cluster membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the
                    /// same as `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes basic information of a cluster resource including cluster resource name and admin
                        /// cluster membership.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>
                        /// Includes the complete configuration for bare metal cluster resource. This is the default
                        /// value for GetBareMetalClusterRequest method.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists bare metal clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent of the project and location where the clusters are listed in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists bare metal clusters in a given project and location.</summary>
                public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListBareMetalClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the clusters are listed in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If true, return list of BareMetal Clusters including the ones that only exists in RMS.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// A resource filtering expression following https://google.aip.dev/160. When non-empty, only
                    /// resource's whose attributes field matches the filter are returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, at most 50
                    /// clusters will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// View for bare metal Clusters. When `BASIC` is specified, only the cluster resource name and
                    /// admin cluster membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the
                    /// same as `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// View for bare metal Clusters. When `BASIC` is specified, only the cluster resource name and
                    /// admin cluster membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the
                    /// same as `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes basic information of a cluster resource including cluster resource name and admin
                        /// cluster membership.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>
                        /// Includes the complete configuration for bare metal cluster resource. This is the default
                        /// value for ListBareMetalClustersRequest method.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bareMetalClusters";

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
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates the parameters of a single bare metal Cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Immutable. The bare metal user cluster resource name.</param>
                public virtual PatchRequest Patch(Google.Apis.GKEOnPrem.v1.Data.BareMetalCluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single bare metal Cluster.</summary>
                public class PatchRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.BareMetalCluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Immutable. The bare metal user cluster resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the bare metal cluster is not found, the request will create a new bare
                    /// metal cluster with the provided configuration. The user must have both create and update
                    /// permission to call Update with allow_missing set to true.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the BareMetalCluster
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all populated fields in the BareMetalCluster message will be updated. Empty
                    /// fields will be ignored unless a field mask is used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.BareMetalCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Queries the bare metal user cluster version config.</summary>
                /// <param name="parent">
                /// Required. The parent of the project and location to query for version config. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual QueryVersionConfigRequest QueryVersionConfig(string parent)
                {
                    return new QueryVersionConfigRequest(this.service, parent);
                }

                /// <summary>Queries the bare metal user cluster version config.</summary>
                public class QueryVersionConfigRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.QueryBareMetalVersionConfigResponse>
                {
                    /// <summary>Constructs a new QueryVersionConfig request.</summary>
                    public QueryVersionConfigRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location to query for version config. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The admin cluster membership. This is the full resource name of the admin cluster's fleet
                    /// membership. Format: "projects/{project}/locations/{location}/memberships/{membership}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("createConfig.adminClusterMembership", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CreateConfigAdminClusterMembership { get; set; }

                    /// <summary>
                    /// The admin cluster resource name. This is the full resource name of the admin cluster resource.
                    /// Format:
                    /// "projects/{project}/locations/{location}/bareMetalAdminClusters/{bare_metal_admin_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("createConfig.adminClusterName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CreateConfigAdminClusterName { get; set; }

                    /// <summary>
                    /// The user cluster resource name. This is the full resource name of the user cluster resource.
                    /// Format: "projects/{project}/locations/{location}/bareMetalClusters/{bare_metal_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("upgradeConfig.clusterName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UpgradeConfigClusterName { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "queryVersionConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/bareMetalClusters:queryVersionConfig";

                    /// <summary>Initializes QueryVersionConfig parameter list.</summary>
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
                        RequestParameters.Add("createConfig.adminClusterMembership", new Google.Apis.Discovery.Parameter
                        {
                            Name = "createConfig.adminClusterMembership",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("createConfig.adminClusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "createConfig.adminClusterName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("upgradeConfig.clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "upgradeConfig.clusterName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Unenrolls an existing bare metal user cluster and its node pools from the Anthos On-Prem API within
                /// a given project and location. Unenrollment removes the Cloud reference to the cluster without
                /// modifying the underlying OnPrem Resources. Clusters and node pools will continue to run; however,
                /// they will no longer be accessible through the Anthos On-Prem API or its clients.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the bare metal user cluster to be unenrolled. Format:
                /// "projects/{project}/locations/{location}/bareMetalClusters/{cluster}"
                /// </param>
                public virtual UnenrollRequest Unenroll(string name)
                {
                    return new UnenrollRequest(this.service, name);
                }

                /// <summary>
                /// Unenrolls an existing bare metal user cluster and its node pools from the Anthos On-Prem API within
                /// a given project and location. Unenrollment removes the Cloud reference to the cluster without
                /// modifying the underlying OnPrem Resources. Clusters and node pools will continue to run; however,
                /// they will no longer be accessible through the Anthos On-Prem API or its clients.
                /// </summary>
                public class UnenrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Unenroll request.</summary>
                    public UnenrollRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the bare metal user cluster to be unenrolled. Format:
                    /// "projects/{project}/locations/{location}/bareMetalClusters/{cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the bare metal cluster is not found, the request will succeed but no action
                    /// will be taken on the server and return a completed LRO.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// The current etag of the bare metal Cluster. If an etag is provided and does not match the
                    /// current etag of the cluster, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// This is required if the cluster has any associated node pools. When set, any child node pools
                    /// will also be unenrolled.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "unenroll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:unenroll";

                    /// <summary>Initializes Unenroll parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/bareMetalClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Operations resource.</summary>
            public virtual OperationsResource Operations { get; }

            /// <summary>The "operations" collection of methods.</summary>
            public class OperationsResource
            {
                private const string Resource = "operations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.GKEOnPrem.v1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:cancel";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be deleted.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation's parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The standard list filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The standard list page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The standard list page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}/operations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
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
                    }
                }
            }

            /// <summary>Gets the VmwareAdminClusters resource.</summary>
            public virtual VmwareAdminClustersResource VmwareAdminClusters { get; }

            /// <summary>The "vmwareAdminClusters" collection of methods.</summary>
            public class VmwareAdminClustersResource
            {
                private const string Resource = "vmwareAdminClusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VmwareAdminClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the Operations resource.</summary>
                public virtual OperationsResource Operations { get; }

                /// <summary>The "operations" collection of methods.</summary>
                public class OperationsResource
                {
                    private const string Resource = "operations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OperationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareAdminClusters/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListOperationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation's parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The standard list filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The standard list page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The standard list page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/operations";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareAdminClusters/[^/]+$",
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

                /// <summary>
                /// Creates a new VMware admin cluster in a given project and location. The API needs to be combined
                /// with creating a bootstrap cluster to work.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the project and location where the cluster is created in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GKEOnPrem.v1.Data.VmwareAdminCluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new VMware admin cluster in a given project and location. The API needs to be combined
                /// with creating a bootstrap cluster to work.
                /// </summary>
                public class CreateRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.VmwareAdminCluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the cluster is created in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, CLM will force CCFE to persist the cluster resource in RMS when the
                    /// creation fails during standalone preflight checks. In that case the subsequent create call will
                    /// fail with "cluster already exists" error and hence a update cluster is required to fix the
                    /// cluster.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowPreflightFailure", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowPreflightFailure { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>
                    /// Required. User provided identifier that is used as part of the resource name; must conform to
                    /// RFC-1034 and additionally restrict to lower-cased letters. This comes out roughly to:
                    /// /^a-z+[a-z0-9]$/
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("vmwareAdminClusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VmwareAdminClusterId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.VmwareAdminCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareAdminClusters";

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
                        RequestParameters.Add("allowPreflightFailure", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowPreflightFailure",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("vmwareAdminClusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "vmwareAdminClusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Enrolls an existing VMware admin cluster to the Anthos On-Prem API within a given project and
                /// location. Through enrollment, an existing admin cluster will become Anthos On-Prem API managed. The
                /// corresponding GCP resources will be created and all future modifications to the cluster will be
                /// expected to be performed through the API.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the project and location where the cluster is enrolled in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual EnrollRequest Enroll(Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareAdminClusterRequest body, string parent)
                {
                    return new EnrollRequest(this.service, body, parent);
                }

                /// <summary>
                /// Enrolls an existing VMware admin cluster to the Anthos On-Prem API within a given project and
                /// location. Through enrollment, an existing admin cluster will become Anthos On-Prem API managed. The
                /// corresponding GCP resources will be created and all future modifications to the cluster will be
                /// expected to be performed through the API.
                /// </summary>
                public class EnrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Enroll request.</summary>
                    public EnrollRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareAdminClusterRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the cluster is enrolled in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareAdminClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enroll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareAdminClusters:enroll";

                    /// <summary>Initializes Enroll parameter list.</summary>
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

                /// <summary>Gets details of a single VMware admin cluster.</summary>
                /// <param name="name">
                /// Required. Name of the VMware admin cluster to be returned. Format:
                /// "projects/{project}/locations/{location}/vmwareAdminClusters/{vmware_admin_cluster}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single VMware admin cluster.</summary>
                public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.VmwareAdminCluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the VMware admin cluster to be returned. Format:
                    /// "projects/{project}/locations/{location}/vmwareAdminClusters/{vmware_admin_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If true, return Vmware Admin Cluster including the one that only exists in RMS.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// View for VMware admin cluster. When `BASIC` is specified, only the cluster resource name and
                    /// membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same as
                    /// `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// View for VMware admin cluster. When `BASIC` is specified, only the cluster resource name and
                    /// membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same as
                    /// `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes basic information of a cluster resource including cluster resource name and
                        /// membership.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>
                        /// Includes the complete configuration for VMware admin cluster resource. This is the default
                        /// value for GetVmwareAdminClusterRequest method.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareAdminClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareAdminClusters/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists VMware admin clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent of the project and location where the clusters are listed in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists VMware admin clusters in a given project and location.</summary>
                public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListVmwareAdminClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the clusters are listed in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If true, return list of Vmware Admin Clusters including the ones that only exists in
                    /// RMS.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, at most 50
                    /// clusters will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// View for VMware admin clusters. When `BASIC` is specified, only the admin cluster resource name
                    /// and membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same as
                    /// `FULL', which returns the complete admin cluster configuration details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// View for VMware admin clusters. When `BASIC` is specified, only the admin cluster resource name
                    /// and membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same as
                    /// `FULL', which returns the complete admin cluster configuration details.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes basic information of a admin cluster resource including admin cluster resource name
                        /// and membership.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>
                        /// Includes the complete configuration for bare metal admin cluster resource. This is the
                        /// default value for ListVmwareAdminClustersRequest method.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareAdminClusters";

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
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates the parameters of a single VMware admin cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Immutable. The VMware admin cluster resource name.</param>
                public virtual PatchRequest Patch(Google.Apis.GKEOnPrem.v1.Data.VmwareAdminCluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single VMware admin cluster.</summary>
                public class PatchRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.VmwareAdminCluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Immutable. The VMware admin cluster resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the VMwareAdminCluster
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all populated fields in the VmwareAdminCluster message will be updated.
                    /// Empty fields will be ignored unless a field mask is used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.VmwareAdminCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareAdminClusters/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareAdminClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareAdminClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Unenrolls an existing VMware admin cluster from the Anthos On-Prem API within a given project and
                /// location. Unenrollment removes the Cloud reference to the cluster without modifying the underlying
                /// OnPrem Resources. Clusters will continue to run; however, they will no longer be accessible through
                /// the Anthos On-Prem API or its clients.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the VMware admin cluster to be unenrolled. Format:
                /// "projects/{project}/locations/{location}/vmwareAdminClusters/{cluster}"
                /// </param>
                public virtual UnenrollRequest Unenroll(string name)
                {
                    return new UnenrollRequest(this.service, name);
                }

                /// <summary>
                /// Unenrolls an existing VMware admin cluster from the Anthos On-Prem API within a given project and
                /// location. Unenrollment removes the Cloud reference to the cluster without modifying the underlying
                /// OnPrem Resources. Clusters will continue to run; however, they will no longer be accessible through
                /// the Anthos On-Prem API or its clients.
                /// </summary>
                public class UnenrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Unenroll request.</summary>
                    public UnenrollRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the VMware admin cluster to be unenrolled. Format:
                    /// "projects/{project}/locations/{location}/vmwareAdminClusters/{cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the VMware admin cluster is not found, the request will succeed but no
                    /// action will be taken on the server and return a completed LRO.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// The current etag of the VMware admin cluster. If an etag is provided and does not match the
                    /// current etag of the cluster, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "unenroll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:unenroll";

                    /// <summary>Initializes Unenroll parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareAdminClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the VmwareClusters resource.</summary>
            public virtual VmwareClustersResource VmwareClusters { get; }

            /// <summary>The "vmwareClusters" collection of methods.</summary>
            public class VmwareClustersResource
            {
                private const string Resource = "vmwareClusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VmwareClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Operations = new OperationsResource(service);
                    VmwareNodePools = new VmwareNodePoolsResource(service);
                }

                /// <summary>Gets the Operations resource.</summary>
                public virtual OperationsResource Operations { get; }

                /// <summary>The "operations" collection of methods.</summary>
                public class OperationsResource
                {
                    private const string Resource = "operations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OperationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(this.service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`.
                    /// </summary>
                    public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListOperationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation's parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The standard list filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The standard list page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The standard list page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/operations";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
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

                /// <summary>Gets the VmwareNodePools resource.</summary>
                public virtual VmwareNodePoolsResource VmwareNodePools { get; }

                /// <summary>The "vmwareNodePools" collection of methods.</summary>
                public class VmwareNodePoolsResource
                {
                    private const string Resource = "vmwareNodePools";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public VmwareNodePoolsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Operations = new OperationsResource(service);
                    }

                    /// <summary>Gets the Operations resource.</summary>
                    public virtual OperationsResource Operations { get; }

                    /// <summary>The "operations" collection of methods.</summary>
                    public class OperationsResource
                    {
                        private const string Resource = "operations";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public OperationsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        /// <param name="name">The name of the operation resource.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>
                        /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                        /// operation result at intervals as recommended by the API service.
                        /// </summary>
                        public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the operation resource.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+/operations/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        /// <param name="name">The name of the operation's parent resource.</param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(this.service, name);
                        }

                        /// <summary>
                        /// Lists operations that match the specified filter in the request. If the server doesn't
                        /// support this method, it returns `UNIMPLEMENTED`.
                        /// </summary>
                        public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListOperationsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the operation's parent resource.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The standard list filter.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>The standard list page size.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>The standard list page token.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/operations";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+$",
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

                    /// <summary>
                    /// Creates a new VMware node pool in a given project, location and VMWare cluster.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource where this node pool will be created.
                    /// projects/{project}/locations/{location}/vmwareClusters/{cluster}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GKEOnPrem.v1.Data.VmwareNodePool body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new VMware node pool in a given project, location and VMWare cluster.
                    /// </summary>
                    public class CreateRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.VmwareNodePool body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this node pool will be created.
                        /// projects/{project}/locations/{location}/vmwareClusters/{cluster}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// If set, only validate the request, but do not actually create the node pool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>
                        /// The ID to use for the node pool, which will become the final component of the node pool's
                        /// resource name. This value must be up to 40 characters and follow RFC-1123
                        /// (https://tools.ietf.org/html/rfc1123) format. The value must not be permitted to be a UUID
                        /// (or UUID-like: anything matching /^[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}$/i).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("vmwareNodePoolId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string VmwareNodePoolId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.VmwareNodePool Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/vmwareNodePools";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("vmwareNodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "vmwareNodePoolId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single VMware node pool.</summary>
                    /// <param name="name">
                    /// Required. The name of the node pool to delete. Format:
                    /// projects/{project}/locations/{location}/vmwareClusters/{cluster}/vmwareNodePools/{nodepool}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single VMware node pool.</summary>
                    public class DeleteRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the node pool to delete. Format:
                        /// projects/{project}/locations/{location}/vmwareClusters/{cluster}/vmwareNodePools/{nodepool}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, and the VMware node pool is not found, the request will succeed but no
                        /// action will be taken on the server and return a completed LRO.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// The current etag of the VmwareNodePool. If an etag is provided and does not match the
                        /// current etag of the node pool, deletion will be blocked and an ABORTED error will be
                        /// returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// If set to true, the deletion of a VMware node pool resource will succeed even if errors
                        /// occur during deletion. This parameter can be used when you want to delete GCP's node pool
                        /// resource and you've already deleted the on-prem admin cluster that hosted your node pool.
                        /// WARNING: Using this parameter when your user cluster still exists may result in a deleted
                        /// GCP node pool but an existing on-prem node pool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("ignoreErrors", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> IgnoreErrors { get; set; }

                        /// <summary>
                        /// If set, only validate the request, but do not actually delete the node pool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("ignoreErrors", new Google.Apis.Discovery.Parameter
                            {
                                Name = "ignoreErrors",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Enrolls a VMware node pool to Anthos On-Prem API</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The parent resource where the node pool is enrolled in.</param>
                    public virtual EnrollRequest Enroll(Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareNodePoolRequest body, string parent)
                    {
                        return new EnrollRequest(this.service, body, parent);
                    }

                    /// <summary>Enrolls a VMware node pool to Anthos On-Prem API</summary>
                    public class EnrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Enroll request.</summary>
                        public EnrollRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareNodePoolRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent resource where the node pool is enrolled in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareNodePoolRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "enroll";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/vmwareNodePools:enroll";

                        /// <summary>Initializes Enroll parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single VMware node pool.</summary>
                    /// <param name="name">
                    /// Required. The name of the node pool to retrieve.
                    /// projects/{project}/locations/{location}/vmwareClusters/{cluster}/vmwareNodePools/{nodepool}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single VMware node pool.</summary>
                    public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.VmwareNodePool>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the node pool to retrieve.
                        /// projects/{project}/locations/{location}/vmwareClusters/{cluster}/vmwareNodePools/{nodepool}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// View for VMware node pool. When `BASIC` is specified, only the node pool resource name is
                        /// returned. The default/unset value `NODE_POOL_VIEW_UNSPECIFIED` is the same as `FULL', which
                        /// returns the complete node pool configuration details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// View for VMware node pool. When `BASIC` is specified, only the node pool resource name is
                        /// returned. The default/unset value `NODE_POOL_VIEW_UNSPECIFIED` is the same as `FULL', which
                        /// returns the complete node pool configuration details.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                            [Google.Apis.Util.StringValueAttribute("NODE_POOL_VIEW_UNSPECIFIED")]
                            NODEPOOLVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Includes basic information of a node pool resource including node pool resource name.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>
                            /// Includes the complete configuration for VMware node pool resource. This is the default
                            /// value for GetVmwareNodePoolRequest method.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+$",
                            });
                            RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                            {
                                Name = "view",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists VMware node pools in a given project, location and VMWare cluster.</summary>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of node pools. Format:
                    /// projects/{project}/locations/{location}/vmwareClusters/{vmwareCluster}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists VMware node pools in a given project, location and VMWare cluster.</summary>
                    public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListVmwareNodePoolsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of node pools. Format:
                        /// projects/{project}/locations/{location}/vmwareClusters/{vmwareCluster}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of node pools to return. The service may return fewer than this value. If
                        /// unspecified, at most 50 node pools will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListVmwareNodePools` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListVmwareNodePools`
                        /// must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// View for VMware node pools. When `BASIC` is specified, only the node pool resource name is
                        /// returned. The default/unset value `NODE_POOL_VIEW_UNSPECIFIED` is the same as `FULL', which
                        /// returns the complete node pool configuration details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// View for VMware node pools. When `BASIC` is specified, only the node pool resource name is
                        /// returned. The default/unset value `NODE_POOL_VIEW_UNSPECIFIED` is the same as `FULL', which
                        /// returns the complete node pool configuration details.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                            [Google.Apis.Util.StringValueAttribute("NODE_POOL_VIEW_UNSPECIFIED")]
                            NODEPOOLVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Includes basic information of a node pool resource including node pool resource name.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>
                            /// Includes the complete configuration for VMware node pool resource. This is the default
                            /// value for ListVmwareNodePoolsRequest method.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/vmwareNodePools";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
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
                            RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                            {
                                Name = "view",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Updates the parameters of a single VMware node pool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Immutable. The resource name of this node pool.</param>
                    public virtual PatchRequest Patch(Google.Apis.GKEOnPrem.v1.Data.VmwareNodePool body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the parameters of a single VMware node pool.</summary>
                    public class PatchRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.VmwareNodePool body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Immutable. The resource name of this node pool.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the VMwareNodePool
                        /// resource by the update. The fields specified in the update_mask are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. If the
                        /// user does not provide a mask then all populated fields in the VMwareNodePool message will be
                        /// updated. Empty fields will be ignored unless a field mask is used.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Validate the request without actually doing any updates.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.VmwareNodePool Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Unenrolls a VMware node pool to Anthos On-Prem API</summary>
                    /// <param name="name">
                    /// Required. The name of the node pool to unenroll. Format:
                    /// projects/{project}/locations/{location}/vmwareClusters/{cluster}/vmwareNodePools/{nodepool}
                    /// </param>
                    public virtual UnenrollRequest Unenroll(string name)
                    {
                        return new UnenrollRequest(this.service, name);
                    }

                    /// <summary>Unenrolls a VMware node pool to Anthos On-Prem API</summary>
                    public class UnenrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Unenroll request.</summary>
                        public UnenrollRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the node pool to unenroll. Format:
                        /// projects/{project}/locations/{location}/vmwareClusters/{cluster}/vmwareNodePools/{nodepool}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// If set to true, and the VMware node pool is not found, the request will succeed but no
                        /// action will be taken on the server and return a completed LRO.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// The current etag of the VMware node pool. If an etag is provided and does not match the
                        /// current etag of node pool, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// If set, only validate the request, but do not actually unenroll the node pool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "unenroll";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:unenroll";

                        /// <summary>Initializes Unenroll parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+/vmwareNodePools/[^/]+$",
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Creates a new VMware user cluster in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the project and location where this cluster is created in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GKEOnPrem.v1.Data.VmwareCluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new VMware user cluster in a given project and location.</summary>
                public class CreateRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.VmwareCluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where this cluster is created in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, CLM will force CCFE to persist the cluster resource in RMS when the
                    /// creation fails during standalone preflight checks. In that case the subsequent create call will
                    /// fail with "cluster already exists" error and hence a update cluster is required to fix the
                    /// cluster.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowPreflightFailure", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowPreflightFailure { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>
                    /// User provided identifier that is used as part of the resource name; This value must be up to 40
                    /// characters and follow RFC-1123 (https://tools.ietf.org/html/rfc1123) format.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("vmwareClusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string VmwareClusterId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.VmwareCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareClusters";

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
                        RequestParameters.Add("allowPreflightFailure", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowPreflightFailure",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("vmwareClusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "vmwareClusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single VMware Cluster.</summary>
                /// <param name="name">
                /// Required. Name of the VMware user cluster to be deleted. Format:
                /// "projects/{project}/locations/{location}/vmwareClusters/{vmware_cluster}"
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single VMware Cluster.</summary>
                public class DeleteRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the VMware user cluster to be deleted. Format:
                    /// "projects/{project}/locations/{location}/vmwareClusters/{vmware_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the VMware cluster is not found, the request will succeed but no action will
                    /// be taken on the server and return a completed LRO.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// The current etag of the VMware cluster. If an etag is provided and does not match the current
                    /// etag of the cluster, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>If set to true, any node pools from the cluster will also be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// If set to true, the deletion of a VMware user cluster resource will succeed even if errors occur
                    /// during deletion. This parameter can be used when you want to delete GCP's cluster resource and
                    /// the on-prem admin cluster that hosts your user cluster is disconnected / unreachable or deleted.
                    /// WARNING: Using this parameter when your user cluster still exists may result in a deleted GCP
                    /// user cluster but an existing on-prem user cluster.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ignoreErrors", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IgnoreErrors { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("ignoreErrors", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ignoreErrors",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Enrolls an existing VMware user cluster and its node pools to the Anthos On-Prem API within a given
                /// project and location. Through enrollment, an existing cluster will become Anthos On-Prem API
                /// managed. The corresponding GCP resources will be created and all future modifications to the cluster
                /// and/or its node pools will be expected to be performed through the API.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent of the project and location where the cluster is Enrolled in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual EnrollRequest Enroll(Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareClusterRequest body, string parent)
                {
                    return new EnrollRequest(this.service, body, parent);
                }

                /// <summary>
                /// Enrolls an existing VMware user cluster and its node pools to the Anthos On-Prem API within a given
                /// project and location. Through enrollment, an existing cluster will become Anthos On-Prem API
                /// managed. The corresponding GCP resources will be created and all future modifications to the cluster
                /// and/or its node pools will be expected to be performed through the API.
                /// </summary>
                public class EnrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Enroll request.</summary>
                    public EnrollRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareClusterRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the cluster is Enrolled in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.EnrollVmwareClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enroll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareClusters:enroll";

                    /// <summary>Initializes Enroll parameter list.</summary>
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

                /// <summary>Gets details of a single VMware Cluster.</summary>
                /// <param name="name">
                /// Required. Name of the VMware user cluster to be returned. Format:
                /// "projects/{project}/locations/{location}/vmwareClusters/{vmware_cluster}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single VMware Cluster.</summary>
                public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.VmwareCluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the VMware user cluster to be returned. Format:
                    /// "projects/{project}/locations/{location}/vmwareClusters/{vmware_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If true, return Vmware Cluster including the one that only exists in RMS.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// View for VMware user cluster. When `BASIC` is specified, only the cluster resource name and
                    /// admin cluster membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the
                    /// same as `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// View for VMware user cluster. When `BASIC` is specified, only the cluster resource name and
                    /// admin cluster membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the
                    /// same as `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes basic information of a cluster resource including cluster resource name and admin
                        /// cluster membership.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>
                        /// Includes the complete configuration for VMware cluster resource. This is the default value
                        /// for GetVmwareClusterRequest method.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists VMware Clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent of the project and location where the clusters are listed in. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists VMware Clusters in a given project and location.</summary>
                public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListVmwareClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location where the clusters are listed in. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. If true, return list of Vmware Clusters including the ones that only exists in RMS.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// A resource filtering expression following https://google.aip.dev/160. When non-empty, only
                    /// resource's whose attributes field matches the filter are returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, at most 50
                    /// clusters will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// View for VMware clusters. When `BASIC` is specified, only the cluster resource name and admin
                    /// cluster membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same
                    /// as `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// View for VMware clusters. When `BASIC` is specified, only the cluster resource name and admin
                    /// cluster membership are returned. The default/unset value `CLUSTER_VIEW_UNSPECIFIED` is the same
                    /// as `FULL', which returns the complete cluster configuration details.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>If the value is not set, the default `FULL` view is used.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLUSTER_VIEW_UNSPECIFIED")]
                        CLUSTERVIEWUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes basic information of a cluster resource including cluster resource name and admin
                        /// cluster membership.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>
                        /// Includes the complete configuration for VMware cluster resource. This is the default value
                        /// for ListVmwareClustersRequest method.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareClusters";

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
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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
                        RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates the parameters of a single VMware cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Immutable. The VMware user cluster resource name.</param>
                public virtual PatchRequest Patch(Google.Apis.GKEOnPrem.v1.Data.VmwareCluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single VMware cluster.</summary>
                public class PatchRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.VmwareCluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Immutable. The VMware user cluster resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the VMwareCluster
                    /// resource by the update. The fields specified in the update_mask are relative to the resource,
                    /// not the full request. A field will be overwritten if it is in the mask. If the user does not
                    /// provide a mask then all populated fields in the VmwareCluster message will be updated. Empty
                    /// fields will be ignored unless a field mask is used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.VmwareCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Queries the VMware user cluster version config.</summary>
                /// <param name="parent">
                /// Required. The parent of the project and location to query for version config. Format:
                /// "projects/{project}/locations/{location}"
                /// </param>
                public virtual QueryVersionConfigRequest QueryVersionConfig(string parent)
                {
                    return new QueryVersionConfigRequest(this.service, parent);
                }

                /// <summary>Queries the VMware user cluster version config.</summary>
                public class QueryVersionConfigRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.QueryVmwareVersionConfigResponse>
                {
                    /// <summary>Constructs a new QueryVersionConfig request.</summary>
                    public QueryVersionConfigRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent of the project and location to query for version config. Format:
                    /// "projects/{project}/locations/{location}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The admin cluster membership. This is the full resource name of the admin cluster's fleet
                    /// membership. Format: "projects/{project}/locations/{location}/memberships/{membership}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("createConfig.adminClusterMembership", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CreateConfigAdminClusterMembership { get; set; }

                    /// <summary>
                    /// The admin cluster resource name. This is the full resource name of the admin cluster resource.
                    /// Format: "projects/{project}/locations/{location}/vmwareAdminClusters/{vmware_admin_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("createConfig.adminClusterName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CreateConfigAdminClusterName { get; set; }

                    /// <summary>
                    /// The user cluster resource name. This is the full resource name of the user cluster resource.
                    /// Format: "projects/{project}/locations/{location}/vmwareClusters/{vmware_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("upgradeConfig.clusterName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UpgradeConfigClusterName { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "queryVersionConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/vmwareClusters:queryVersionConfig";

                    /// <summary>Initializes QueryVersionConfig parameter list.</summary>
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
                        RequestParameters.Add("createConfig.adminClusterMembership", new Google.Apis.Discovery.Parameter
                        {
                            Name = "createConfig.adminClusterMembership",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("createConfig.adminClusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "createConfig.adminClusterName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("upgradeConfig.clusterName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "upgradeConfig.clusterName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GKEOnPrem.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Unenrolls an existing VMware user cluster and its node pools from the Anthos On-Prem API within a
                /// given project and location. Unenrollment removes the Cloud reference to the cluster without
                /// modifying the underlying OnPrem Resources. Clusters and node pools will continue to run; however,
                /// they will no longer be accessible through the Anthos On-Prem API or UI.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the VMware user cluster to be unenrolled. Format:
                /// "projects/{project}/locations/{location}/vmwareClusters/{vmware_cluster}"
                /// </param>
                public virtual UnenrollRequest Unenroll(string name)
                {
                    return new UnenrollRequest(this.service, name);
                }

                /// <summary>
                /// Unenrolls an existing VMware user cluster and its node pools from the Anthos On-Prem API within a
                /// given project and location. Unenrollment removes the Cloud reference to the cluster without
                /// modifying the underlying OnPrem Resources. Clusters and node pools will continue to run; however,
                /// they will no longer be accessible through the Anthos On-Prem API or UI.
                /// </summary>
                public class UnenrollRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Unenroll request.</summary>
                    public UnenrollRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the VMware user cluster to be unenrolled. Format:
                    /// "projects/{project}/locations/{location}/vmwareClusters/{vmware_cluster}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// If set to true, and the VMware cluster is not found, the request will succeed but no action will
                    /// be taken on the server and return a completed LRO.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// The current etag of the VMware Cluster. If an etag is provided and does not match the current
                    /// etag of the cluster, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// This is required if the cluster has any associated node pools. When set, any child node pools
                    /// will also be unenrolled.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>Validate the request without actually doing any updates.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "unenroll";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:unenroll";

                    /// <summary>Initializes Unenroll parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/vmwareClusters/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Resource name for the location.</summary>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : GKEOnPremBaseServiceRequest<Google.Apis.GKEOnPrem.v1.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// `"displayName=tokyo"`, and is documented in more detail in [AIP-160](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the `next_page_token` field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/locations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("extraLocationTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "extraLocationTypes",
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
}
namespace Google.Apis.GKEOnPrem.v1.Data
{
    /// <summary>
    /// Authorization defines the On-Prem cluster authorization configuration to bootstrap onto the admin cluster.
    /// </summary>
    public class Authorization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For VMware and bare metal user clusters, users will be granted the cluster-admin role on the cluster, which
        /// provides full administrative access to the cluster. For bare metal admin clusters, users will be granted the
        /// cluster-view role, which limits users to read-only access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminUsers")]
        public virtual System.Collections.Generic.IList<ClusterUser> AdminUsers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BareMetalAdminApiServerArgument represents an arg name-&amp;gt;value pair. Only a subset of customized flags are
    /// supported. Please refer to the API server documentation below to know the exact format:
    /// https://kubernetes.io/docs/reference/command-line-tools-reference/kube-apiserver/
    /// </summary>
    public class BareMetalAdminApiServerArgument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The argument name as it appears on the API Server command line please make sure to remove the
        /// leading dashes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argument")]
        public virtual string Argument { get; set; }

        /// <summary>Required. The value of the arg as it will be passed to the API Server command line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that represents a bare metal admin cluster.</summary>
    public class BareMetalAdminCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations on the bare metal admin cluster. This field has the same restrictions as Kubernetes annotations.
        /// The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix
        /// (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63
        /// characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and
        /// alphanumerics between.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>The Anthos clusters on bare metal version for the bare metal admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bareMetalVersion")]
        public virtual string BareMetalVersion { get; set; }

        /// <summary>Binary Authorization related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>Cluster operations configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterOperations")]
        public virtual BareMetalAdminClusterOperationsConfig ClusterOperations { get; set; }

        /// <summary>Control plane configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlane")]
        public virtual BareMetalAdminControlPlaneConfig ControlPlane { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this bare metal admin cluster was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. The time at which this bare metal admin cluster was deleted. If the resource is not deleted,
        /// this must be empty
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A human readable description of this bare metal admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The IP address name of bare metal admin cluster's API server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding. Allows clients to perform
        /// consistent read-modify-writes through optimistic concurrency control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Fleet configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleet")]
        public virtual Fleet Fleet { get; set; }

        /// <summary>Load balancer configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancer")]
        public virtual BareMetalAdminLoadBalancerConfig LoadBalancer { get; set; }

        /// <summary>
        /// Output only. The object name of the bare metal cluster custom resource. This field is used to support
        /// conflicting names when enrolling existing clusters to the API. When used as a part of cluster enrollment,
        /// this field will differ from the ID in the resource name. For new clusters, this field will match the user
        /// provided cluster name and be visible in the last component of the resource name. It is not modifiable. All
        /// users should use this name to access their cluster using gkectl or kubectl and should expect to see the
        /// local name when viewing admin cluster controller logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localName")]
        public virtual string LocalName { get; set; }

        /// <summary>Maintenance configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceConfig")]
        public virtual BareMetalAdminMaintenanceConfig MaintenanceConfig { get; set; }

        /// <summary>Output only. MaintenanceStatus representing state of maintenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceStatus")]
        public virtual BareMetalAdminMaintenanceStatus MaintenanceStatus { get; set; }

        /// <summary>Immutable. The bare metal admin cluster resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Network configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual BareMetalAdminNetworkConfig NetworkConfig { get; set; }

        /// <summary>Node access related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeAccessConfig")]
        public virtual BareMetalAdminNodeAccessConfig NodeAccessConfig { get; set; }

        /// <summary>Workload node configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeConfig")]
        public virtual BareMetalAdminWorkloadNodeConfig NodeConfig { get; set; }

        /// <summary>OS environment related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osEnvironmentConfig")]
        public virtual BareMetalAdminOsEnvironmentConfig OsEnvironmentConfig { get; set; }

        /// <summary>Proxy configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxy")]
        public virtual BareMetalAdminProxyConfig Proxy { get; set; }

        /// <summary>
        /// Output only. If set, there are currently changes in flight to the bare metal Admin Cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Security related configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityConfig")]
        public virtual BareMetalAdminSecurityConfig SecurityConfig { get; set; }

        /// <summary>Output only. The current state of the bare metal admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. ResourceStatus representing detailed cluster status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ResourceStatus Status { get; set; }

        /// <summary>Storage configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storage")]
        public virtual BareMetalAdminStorageConfig Storage { get; set; }

        /// <summary>Output only. The unique identifier of the bare metal admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which this bare metal admin cluster was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. ValidationCheck representing the result of the preflight check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationCheck")]
        public virtual ValidationCheck ValidationCheck { get; set; }
    }

    /// <summary>
    /// BareMetalAdminClusterOperationsConfig specifies the admin cluster's observability infrastructure.
    /// </summary>
    public class BareMetalAdminClusterOperationsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether collection of application logs/metrics should be enabled (in addition to system logs/metrics).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableApplicationLogs")]
        public virtual System.Nullable<bool> EnableApplicationLogs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminControlPlaneConfig specifies the control plane configuration.</summary>
    public class BareMetalAdminControlPlaneConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Customizes the default API server args. Only a subset of customized flags are supported. Please refer to the
        /// API server documentation below to know the exact format:
        /// https://kubernetes.io/docs/reference/command-line-tools-reference/kube-apiserver/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiServerArgs")]
        public virtual System.Collections.Generic.IList<BareMetalAdminApiServerArgument> ApiServerArgs { get; set; }

        /// <summary>
        /// Required. Configures the node pool running the control plane. If specified the corresponding NodePool will
        /// be created for the cluster's control plane. The NodePool will have the same name and namespace as the
        /// cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneNodePoolConfig")]
        public virtual BareMetalAdminControlPlaneNodePoolConfig ControlPlaneNodePoolConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BareMetalAdminControlPlaneNodePoolConfig specifies the control plane node pool configuration. We have a control
    /// plane specific node pool config so that we can flexible about supporting control plane specific fields in the
    /// future.
    /// </summary>
    public class BareMetalAdminControlPlaneNodePoolConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The generic configuration for a node pool running the control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolConfig")]
        public virtual BareMetalNodePoolConfig NodePoolConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminDrainedMachine represents the machines that are drained.</summary>
    public class BareMetalAdminDrainedMachine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Drained machine IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeIp")]
        public virtual string NodeIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminDrainingMachine represents the machines that are currently draining.</summary>
    public class BareMetalAdminDrainingMachine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Draining machine IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeIp")]
        public virtual string NodeIp { get; set; }

        /// <summary>The count of pods yet to drain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podCount")]
        public virtual System.Nullable<int> PodCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BareMetalAdminIslandModeCidrConfig specifies the cluster CIDR configuration while running in island mode.
    /// </summary>
    public class BareMetalAdminIslandModeCidrConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges. This field cannot
        /// be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> PodAddressCidrBlocks { get; set; }

        /// <summary>
        /// Required. All services in the cluster are assigned an RFC1918 IPv4 address from these ranges. This field
        /// cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> ServiceAddressCidrBlocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminLoadBalancerConfig specifies the load balancer configuration.</summary>
    public class BareMetalAdminLoadBalancerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Manually configured load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualLbConfig")]
        public virtual BareMetalAdminManualLbConfig ManualLbConfig { get; set; }

        /// <summary>Configures the ports that the load balancer will listen on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portConfig")]
        public virtual BareMetalAdminPortConfig PortConfig { get; set; }

        /// <summary>The VIPs used by the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vipConfig")]
        public virtual BareMetalAdminVipConfig VipConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BareMetalAdminMachineDrainStatus represents the status of bare metal node machines that are undergoing drain
    /// operations.
    /// </summary>
    public class BareMetalAdminMachineDrainStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of drained machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drainedMachines")]
        public virtual System.Collections.Generic.IList<BareMetalAdminDrainedMachine> DrainedMachines { get; set; }

        /// <summary>The list of draning machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drainingMachines")]
        public virtual System.Collections.Generic.IList<BareMetalAdminDrainingMachine> DrainingMachines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BareMetalAdminMaintenanceConfig specifies configurations to put bare metal Admin cluster CRs nodes in and out of
    /// maintenance.
    /// </summary>
    public class BareMetalAdminMaintenanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. All IPv4 address from these ranges will be placed into maintenance mode. Nodes in maintenance mode
        /// will be cordoned and drained. When both of these are true, the "baremetal.cluster.gke.io/maintenance"
        /// annotation will be set on the node resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> MaintenanceAddressCidrBlocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BareMetalAdminMaintenanceStatus represents the maintenance status for bare metal Admin cluster CR's nodes.
    /// </summary>
    public class BareMetalAdminMaintenanceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the status of draining and drained machine nodes. This is used to show the progress of cluster
        /// upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineDrainStatus")]
        public virtual BareMetalAdminMachineDrainStatus MachineDrainStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminManualLbConfig represents configuration parameters for a manual load balancer.</summary>
    public class BareMetalAdminManualLbConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether manual load balancing is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminNetworkConfig specifies the cluster network configuration.</summary>
    public class BareMetalAdminNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for Island mode CIDR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("islandModeCidr")]
        public virtual BareMetalAdminIslandModeCidrConfig IslandModeCidr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the node access related settings for the bare metal admin cluster.</summary>
    public class BareMetalAdminNodeAccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. LoginUser is the user name used to access node machines. It defaults to "root" if not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginUser")]
        public virtual string LoginUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies operating system operation settings for cluster provisioning.</summary>
    public class BareMetalAdminOsEnvironmentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the package repo should be added when initializing bare metal machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageRepoExcluded")]
        public virtual System.Nullable<bool> PackageRepoExcluded { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminPortConfig is the specification of load balancer ports.</summary>
    public class BareMetalAdminPortConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The port that control plane hosted load balancers will listen on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneLoadBalancerPort")]
        public virtual System.Nullable<int> ControlPlaneLoadBalancerPort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminProxyConfig specifies the cluster proxy configuration.</summary>
    public class BareMetalAdminProxyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of IPs, hostnames, and domains that should skip the proxy. Examples: ["127.0.0.1", "example.com",
        /// ".corp", "localhost"].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noProxy")]
        public virtual System.Collections.Generic.IList<string> NoProxy { get; set; }

        /// <summary>
        /// Required. Specifies the address of your proxy server. Examples: `http://domain` WARNING: Do not provide
        /// credentials in the format `http://(username:password@)domain` these will be rejected by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the security related settings for the bare metal admin cluster.</summary>
    public class BareMetalAdminSecurityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configures user access to the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorization")]
        public virtual Authorization Authorization { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminStorageConfig specifies the cluster storage configuration.</summary>
    public class BareMetalAdminStorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Specifies the config for local PersistentVolumes backed by mounted node disks. These disks need to
        /// be formatted and mounted by the user, which can be done before or after cluster creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lvpNodeMountsConfig")]
        public virtual BareMetalLvpConfig LvpNodeMountsConfig { get; set; }

        /// <summary>
        /// Required. Specifies the config for local PersistentVolumes backed by subdirectories in a shared filesystem.
        /// These subdirectores are automatically created during cluster creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lvpShareConfig")]
        public virtual BareMetalLvpShareConfig LvpShareConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminVipConfig for bare metal load balancer configurations.</summary>
    public class BareMetalAdminVipConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The VIP which you previously set aside for the Kubernetes API of this bare metal admin cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneVip")]
        public virtual string ControlPlaneVip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalAdminWorkloadNodeConfig specifies the workload node configurations.</summary>
    public class BareMetalAdminWorkloadNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of pods a node can run. The size of the CIDR range assigned to the node will be derived
        /// from this parameter. By default 110 Pods are created per Node. Upper bound is 250 for both HA and non-HA
        /// admin cluster. Lower bound is 64 for non-HA admin cluster and 32 for HA admin cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPodsPerNode")]
        public virtual System.Nullable<long> MaxPodsPerNode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an arg name-&amp;gt;value pair. Only a subset of customized flags are supported. For the exact
    /// format, refer to the [API server
    /// documentation](https://kubernetes.io/docs/reference/command-line-tools-reference/kube-apiserver/).
    /// </summary>
    public class BareMetalApiServerArgument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The argument name as it appears on the API Server command line, make sure to remove the leading
        /// dashes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argument")]
        public virtual string Argument { get; set; }

        /// <summary>Required. The value of the arg as it will be passed to the API Server command line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BareMetalBgpLbConfig represents configuration parameters for a Border Gateway Protocol (BGP) load balancer.
    /// </summary>
    public class BareMetalBgpLbConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. AddressPools is a list of non-overlapping IP pools used by load balancer typed services. All
        /// addresses must be routable to load balancer nodes. IngressVIP must be included in the pools.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressPools")]
        public virtual System.Collections.Generic.IList<BareMetalLoadBalancerAddressPool> AddressPools { get; set; }

        /// <summary>
        /// Required. BGP autonomous system number (ASN) of the cluster. This field can be updated after cluster
        /// creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asn")]
        public virtual System.Nullable<long> Asn { get; set; }

        /// <summary>
        /// Required. The list of BGP peers that the cluster will connect to. At least one peer must be configured for
        /// each control plane node. Control plane nodes will connect to these peers to advertise the control plane VIP.
        /// The Services load balancer also uses these peers by default. This field can be updated after cluster
        /// creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bgpPeerConfigs")]
        public virtual System.Collections.Generic.IList<BareMetalBgpPeerConfig> BgpPeerConfigs { get; set; }

        /// <summary>
        /// Specifies the node pool running data plane load balancing. L2 connectivity is required among nodes in this
        /// pool. If missing, the control plane node pool is used for data plane load balancing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerNodePoolConfig")]
        public virtual BareMetalLoadBalancerNodePoolConfig LoadBalancerNodePoolConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BareMetalBgpPeerConfig represents configuration parameters for a Border Gateway Protocol (BGP) peer.
    /// </summary>
    public class BareMetalBgpPeerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. BGP autonomous system number (ASN) for the network that contains the external peer device.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asn")]
        public virtual System.Nullable<long> Asn { get; set; }

        /// <summary>
        /// The IP address of the control plane node that connects to the external peer. If you don't specify any
        /// control plane nodes, all control plane nodes can connect to the external peer. If you specify one or more IP
        /// addresses, only the nodes specified participate in peering sessions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneNodes")]
        public virtual System.Collections.Generic.IList<string> ControlPlaneNodes { get; set; }

        /// <summary>Required. The IP address of the external peer device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that represents a bare metal user cluster.</summary>
    public class BareMetalCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The admin cluster this bare metal user cluster belongs to. This is the full resource name of the
        /// admin cluster's fleet membership.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminClusterMembership")]
        public virtual string AdminClusterMembership { get; set; }

        /// <summary>
        /// Output only. The resource name of the bare metal admin cluster managing this user cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminClusterName")]
        public virtual string AdminClusterName { get; set; }

        /// <summary>
        /// Annotations on the bare metal user cluster. This field has the same restrictions as Kubernetes annotations.
        /// The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix
        /// (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63
        /// characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and
        /// alphanumerics between.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Required. The Anthos clusters on bare metal version for your user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bareMetalVersion")]
        public virtual string BareMetalVersion { get; set; }

        /// <summary>Binary Authorization related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>Cluster operations configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterOperations")]
        public virtual BareMetalClusterOperationsConfig ClusterOperations { get; set; }

        /// <summary>Required. Control plane configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlane")]
        public virtual BareMetalControlPlaneConfig ControlPlane { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the bare metal user cluster was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. The time when the bare metal user cluster was deleted. If the resource is not deleted, this
        /// must be empty
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A human readable description of this bare metal user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The IP address of the bare metal user cluster's API server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// Output only. This checksum is computed by the server based on the value of other fields, and may be sent on
        /// update and delete requests to ensure the client has an up-to-date value before proceeding. Allows clients to
        /// perform consistent read-modify-writes through optimistic concurrency control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Fleet configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleet")]
        public virtual Fleet Fleet { get; set; }

        /// <summary>Required. Load balancer configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancer")]
        public virtual BareMetalLoadBalancerConfig LoadBalancer { get; set; }

        /// <summary>
        /// Output only. The object name of the bare metal user cluster custom resource on the associated admin cluster.
        /// This field is used to support conflicting names when enrolling existing clusters to the API. When used as a
        /// part of cluster enrollment, this field will differ from the name in the resource name. For new clusters,
        /// this field will match the user provided cluster name and be visible in the last component of the resource
        /// name. It is not modifiable. When the local name and cluster name differ, the local name is used in the admin
        /// cluster controller logs. You use the cluster name when accessing the cluster using bmctl and kubectl.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localName")]
        public virtual string LocalName { get; set; }

        /// <summary>Output only. The namespace of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localNamespace")]
        public virtual string LocalNamespace { get; set; }

        /// <summary>Maintenance configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceConfig")]
        public virtual BareMetalMaintenanceConfig MaintenanceConfig { get; set; }

        /// <summary>Output only. Status of on-going maintenance tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceStatus")]
        public virtual BareMetalMaintenanceStatus MaintenanceStatus { get; set; }

        /// <summary>Immutable. The bare metal user cluster resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Network configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual BareMetalNetworkConfig NetworkConfig { get; set; }

        /// <summary>Node access related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeAccessConfig")]
        public virtual BareMetalNodeAccessConfig NodeAccessConfig { get; set; }

        /// <summary>Workload node configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeConfig")]
        public virtual BareMetalWorkloadNodeConfig NodeConfig { get; set; }

        /// <summary>OS environment related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osEnvironmentConfig")]
        public virtual BareMetalOsEnvironmentConfig OsEnvironmentConfig { get; set; }

        /// <summary>Proxy configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxy")]
        public virtual BareMetalProxyConfig Proxy { get; set; }

        /// <summary>
        /// Output only. If set, there are currently changes in flight to the bare metal user cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Security related setting configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityConfig")]
        public virtual BareMetalSecurityConfig SecurityConfig { get; set; }

        /// <summary>Output only. The current state of the bare metal user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Detailed cluster status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ResourceStatus Status { get; set; }

        /// <summary>Required. Storage configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storage")]
        public virtual BareMetalStorageConfig Storage { get; set; }

        /// <summary>Output only. The unique identifier of the bare metal user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the bare metal user cluster was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The cluster upgrade policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradePolicy")]
        public virtual BareMetalClusterUpgradePolicy UpgradePolicy { get; set; }

        /// <summary>Output only. The result of the preflight check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationCheck")]
        public virtual ValidationCheck ValidationCheck { get; set; }
    }

    /// <summary>Specifies the bare metal user cluster's observability infrastructure.</summary>
    public class BareMetalClusterOperationsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether collection of application logs/metrics should be enabled (in addition to system logs/metrics).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableApplicationLogs")]
        public virtual System.Nullable<bool> EnableApplicationLogs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalClusterUpgradePolicy defines the cluster upgrade policy.</summary>
    public class BareMetalClusterUpgradePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Pause is used to show the upgrade pause status. It's view only for now.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pause")]
        public virtual System.Nullable<bool> Pause { get; set; }

        /// <summary>Specifies which upgrade policy to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the control plane configuration.</summary>
    public class BareMetalControlPlaneConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Customizes the default API server args. Only a subset of customized flags are supported. For the exact
        /// format, refer to the [API server
        /// documentation](https://kubernetes.io/docs/reference/command-line-tools-reference/kube-apiserver/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiServerArgs")]
        public virtual System.Collections.Generic.IList<BareMetalApiServerArgument> ApiServerArgs { get; set; }

        /// <summary>Required. Configures the node pool running the control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneNodePoolConfig")]
        public virtual BareMetalControlPlaneNodePoolConfig ControlPlaneNodePoolConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the control plane node pool configuration.</summary>
    public class BareMetalControlPlaneNodePoolConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The generic configuration for a node pool running the control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolConfig")]
        public virtual BareMetalNodePoolConfig NodePoolConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a machine that is currently drained.</summary>
    public class BareMetalDrainedMachine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Drained machine IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeIp")]
        public virtual string NodeIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a machine that is currently draining.</summary>
    public class BareMetalDrainingMachine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Draining machine IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeIp")]
        public virtual string NodeIp { get; set; }

        /// <summary>The count of pods yet to drain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podCount")]
        public virtual System.Nullable<int> PodCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the cluster CIDR configuration while running in island mode.</summary>
    public class BareMetalIslandModeCidrConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges. This field cannot
        /// be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> PodAddressCidrBlocks { get; set; }

        /// <summary>
        /// Required. All services in the cluster are assigned an RFC1918 IPv4 address from these ranges. This field is
        /// mutable after creation starting with version 1.15.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> ServiceAddressCidrBlocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// KubeletConfig defines the modifiable kubelet configurations for bare metal machines. Note: this list includes
    /// fields supported in GKE (see
    /// https://cloud.google.com/kubernetes-engine/docs/how-to/node-system-config#kubelet-options).
    /// </summary>
    public class BareMetalKubeletConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum size of bursty pulls, temporarily allows pulls to burst to this number, while still not
        /// exceeding registry_pull_qps. The value must not be a negative number. Updating this field may impact
        /// scalability by changing the amount of traffic produced by image pulls. Defaults to 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registryBurst")]
        public virtual System.Nullable<int> RegistryBurst { get; set; }

        /// <summary>
        /// The limit of registry pulls per second. Setting this value to 0 means no limit. Updating this field may
        /// impact scalability by changing the amount of traffic produced by image pulls. Defaults to 5.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registryPullQps")]
        public virtual System.Nullable<int> RegistryPullQps { get; set; }

        /// <summary>
        /// Prevents the Kubelet from pulling multiple images at a time. We recommend *not* changing the default value
        /// on nodes that run docker daemon with version &amp;lt; 1.9 or an Another Union File System (Aufs) storage
        /// backend. Issue https://github.com/kubernetes/kubernetes/issues/10959 has more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializeImagePullsDisabled")]
        public virtual System.Nullable<bool> SerializeImagePullsDisabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an IP pool used by the load balancer.</summary>
    public class BareMetalLoadBalancerAddressPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The addresses that are part of this pool. Each address must be either in the CIDR form
        /// (1.2.3.0/24) or range form (1.2.3.1-1.2.3.5).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addresses")]
        public virtual System.Collections.Generic.IList<string> Addresses { get; set; }

        /// <summary>
        /// If true, avoid using IPs ending in .0 or .255. This avoids buggy consumer devices mistakenly dropping IPv4
        /// traffic for those special IP addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidBuggyIps")]
        public virtual System.Nullable<bool> AvoidBuggyIps { get; set; }

        /// <summary>If true, prevent IP addresses from being automatically assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualAssign")]
        public virtual System.Nullable<bool> ManualAssign { get; set; }

        /// <summary>Required. The name of the address pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pool")]
        public virtual string Pool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the load balancer configuration.</summary>
    public class BareMetalLoadBalancerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Configuration for BGP typed load balancers. When set network_config.advanced_networking is automatically set
        /// to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bgpLbConfig")]
        public virtual BareMetalBgpLbConfig BgpLbConfig { get; set; }

        /// <summary>Manually configured load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualLbConfig")]
        public virtual BareMetalManualLbConfig ManualLbConfig { get; set; }

        /// <summary>Configuration for MetalLB load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metalLbConfig")]
        public virtual BareMetalMetalLbConfig MetalLbConfig { get; set; }

        /// <summary>Configures the ports that the load balancer will listen on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portConfig")]
        public virtual BareMetalPortConfig PortConfig { get; set; }

        /// <summary>The VIPs used by the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vipConfig")]
        public virtual BareMetalVipConfig VipConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the load balancer's node pool configuration.</summary>
    public class BareMetalLoadBalancerNodePoolConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The generic configuration for a node pool running a load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolConfig")]
        public virtual BareMetalNodePoolConfig NodePoolConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the configs for local persistent volumes (PVs).</summary>
    public class BareMetalLvpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The host machine path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Required. The StorageClass name that PVs will be created with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageClass")]
        public virtual string StorageClass { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the configs for local persistent volumes under a shared file system.</summary>
    public class BareMetalLvpShareConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Defines the machine path and storage class for the LVP Share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lvpConfig")]
        public virtual BareMetalLvpConfig LvpConfig { get; set; }

        /// <summary>The number of subdirectories to create under path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedPathPvCount")]
        public virtual System.Nullable<int> SharedPathPvCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the status of node machines that are undergoing drain operations.</summary>
    public class BareMetalMachineDrainStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of drained machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drainedMachines")]
        public virtual System.Collections.Generic.IList<BareMetalDrainedMachine> DrainedMachines { get; set; }

        /// <summary>The list of draning machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drainingMachines")]
        public virtual System.Collections.Generic.IList<BareMetalDrainingMachine> DrainingMachines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies configurations to put bare metal nodes in and out of maintenance.</summary>
    public class BareMetalMaintenanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. All IPv4 address from these ranges will be placed into maintenance mode. Nodes in maintenance mode
        /// will be cordoned and drained. When both of these are true, the "baremetal.cluster.gke.io/maintenance"
        /// annotation will be set on the node resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> MaintenanceAddressCidrBlocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the maintenance status of the bare metal user cluster.</summary>
    public class BareMetalMaintenanceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maintenance status of node machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineDrainStatus")]
        public virtual BareMetalMachineDrainStatus MachineDrainStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents configuration parameters for a manual load balancer.</summary>
    public class BareMetalManualLbConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether manual load balancing is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents configuration parameters for a MetalLB load balancer.</summary>
    public class BareMetalMetalLbConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. AddressPools is a list of non-overlapping IP pools used by load balancer typed services. All
        /// addresses must be routable to load balancer nodes. IngressVIP must be included in the pools.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressPools")]
        public virtual System.Collections.Generic.IList<BareMetalLoadBalancerAddressPool> AddressPools { get; set; }

        /// <summary>
        /// Specifies the node pool running the load balancer. L2 connectivity is required among nodes in this pool. If
        /// missing, the control plane node pool is used as the load balancer pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerNodePoolConfig")]
        public virtual BareMetalLoadBalancerNodePoolConfig LoadBalancerNodePoolConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the multiple networking interfaces cluster configuration.</summary>
    public class BareMetalMultipleNetworkInterfacesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to enable multiple network interfaces for your pods. When set network_config.advanced_networking is
        /// automatically set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the cluster network configuration.</summary>
    public class BareMetalNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enables the use of advanced Anthos networking features, such as Bundled Load Balancing with BGP or the
        /// egress NAT gateway. Setting configuration for advanced networking features will automatically set this flag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedNetworking")]
        public virtual System.Nullable<bool> AdvancedNetworking { get; set; }

        /// <summary>
        /// Configuration for island mode CIDR. In an island-mode network, nodes have unique IP addresses, but pods
        /// don't have unique addresses across clusters. This doesn't cause problems because pods in one cluster never
        /// directly communicate with pods in another cluster. Instead, there are gateways that mediate between a pod in
        /// one cluster and a pod in another cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("islandModeCidr")]
        public virtual BareMetalIslandModeCidrConfig IslandModeCidr { get; set; }

        /// <summary>Configuration for multiple network interfaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleNetworkInterfacesConfig")]
        public virtual BareMetalMultipleNetworkInterfacesConfig MultipleNetworkInterfacesConfig { get; set; }

        /// <summary>Configuration for SR-IOV.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("srIovConfig")]
        public virtual BareMetalSrIovConfig SrIovConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the node access related settings for the bare metal user cluster.</summary>
    public class BareMetalNodeAccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// LoginUser is the user name used to access node machines. It defaults to "root" if not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginUser")]
        public virtual string LoginUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalNodeConfig lists machine addresses to access Nodes.</summary>
    public class BareMetalNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The labels assigned to this node. An object containing a list of key/value pairs. The labels here, unioned
        /// with the labels set on BareMetalNodePoolConfig are the set of labels that will be applied to the node. If
        /// there are any conflicts, the BareMetalNodeConfig labels take precedence. Example: { "name": "wrench",
        /// "mass": "1.3kg", "count": "3" }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The default IPv4 address for SSH access and Kubernetes node. Example: 192.168.0.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeIp")]
        public virtual string NodeIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that represents a bare metal node pool.</summary>
    public class BareMetalNodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations on the bare metal node pool. This field has the same restrictions as Kubernetes annotations. The
        /// total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional)
        /// and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or
        /// less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics
        /// between.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this bare metal node pool was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. The time at which this bare metal node pool was deleted. If the resource is not deleted, this
        /// must be empty
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The display name for the bare metal node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding. Allows clients to perform
        /// consistent read-modify-writes through optimistic concurrency control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Immutable. The bare metal node pool resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Node pool configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolConfig")]
        public virtual BareMetalNodePoolConfig NodePoolConfig { get; set; }

        /// <summary>Output only. If set, there are currently changes in flight to the bare metal node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. The current state of the bare metal node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. ResourceStatus representing the detailed node pool status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ResourceStatus Status { get; set; }

        /// <summary>Output only. The unique identifier of the bare metal node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which this bare metal node pool was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The worker node pool upgrade policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradePolicy")]
        public virtual BareMetalNodePoolUpgradePolicy UpgradePolicy { get; set; }
    }

    /// <summary>
    /// BareMetalNodePoolConfig describes the configuration of all nodes within a given bare metal node pool.
    /// </summary>
    public class BareMetalNodePoolConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The modifiable kubelet configurations for the bare metal machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubeletConfig")]
        public virtual BareMetalKubeletConfig KubeletConfig { get; set; }

        /// <summary>
        /// The labels assigned to nodes of this node pool. An object containing a list of key/value pairs. Example: {
        /// "name": "wrench", "mass": "1.3kg", "count": "3" }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Required. The list of machine addresses in the bare metal node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeConfigs")]
        public virtual System.Collections.Generic.IList<BareMetalNodeConfig> NodeConfigs { get; set; }

        /// <summary>Specifies the nodes operating system (default: LINUX).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual string OperatingSystem { get; set; }

        /// <summary>The initial taints assigned to nodes of this node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taints")]
        public virtual System.Collections.Generic.IList<NodeTaint> Taints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalNodePoolUpgradePolicy defines the node pool upgrade policy.</summary>
    public class BareMetalNodePoolUpgradePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The parallel upgrade settings for worker node pools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelUpgradeConfig")]
        public virtual BareMetalParallelUpgradeConfig ParallelUpgradeConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies operating system settings for cluster provisioning.</summary>
    public class BareMetalOsEnvironmentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the package repo should not be included when initializing bare metal machines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageRepoExcluded")]
        public virtual System.Nullable<bool> PackageRepoExcluded { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalParallelUpgradeConfig defines the parallel upgrade settings for worker node pools.</summary>
    public class BareMetalParallelUpgradeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum number of nodes that can be upgraded at once.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrentNodes")]
        public virtual System.Nullable<int> ConcurrentNodes { get; set; }

        /// <summary>
        /// The minimum number of nodes that should be healthy and available during an upgrade. If set to the default
        /// value of 0, it is possible that none of the nodes will be available during an upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumAvailableNodes")]
        public virtual System.Nullable<int> MinimumAvailableNodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies load balancer ports for the bare metal user cluster.</summary>
    public class BareMetalPortConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The port that control plane hosted load balancers will listen on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneLoadBalancerPort")]
        public virtual System.Nullable<int> ControlPlaneLoadBalancerPort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the cluster proxy configuration.</summary>
    public class BareMetalProxyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of IPs, hostnames, and domains that should skip the proxy. Examples: ["127.0.0.1", "example.com",
        /// ".corp", "localhost"].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noProxy")]
        public virtual System.Collections.Generic.IList<string> NoProxy { get; set; }

        /// <summary>
        /// Required. Specifies the address of your proxy server. Examples: `http://domain` Do not provide credentials
        /// in the format `http://(username:password@)domain` these will be rejected by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the security related settings for the bare metal user cluster.</summary>
    public class BareMetalSecurityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configures user access to the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorization")]
        public virtual Authorization Authorization { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the SR-IOV networking operator config.</summary>
    public class BareMetalSrIovConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to install the SR-IOV operator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BareMetalStorageConfig specifies the cluster storage configuration.</summary>
    public class BareMetalStorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Specifies the config for local PersistentVolumes backed by mounted node disks. These disks need to
        /// be formatted and mounted by the user, which can be done before or after cluster creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lvpNodeMountsConfig")]
        public virtual BareMetalLvpConfig LvpNodeMountsConfig { get; set; }

        /// <summary>
        /// Required. Specifies the config for local PersistentVolumes backed by subdirectories in a shared filesystem.
        /// These subdirectores are automatically created during cluster creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lvpShareConfig")]
        public virtual BareMetalLvpShareConfig LvpShareConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about a specific Anthos on bare metal version.</summary>
    public class BareMetalVersionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of upgrade dependencies for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<UpgradeDependency> Dependencies { get; set; }

        /// <summary>
        /// If set, the cluster dependencies (e.g. the admin cluster, other user clusters managed by the same admin
        /// cluster, version skew policy, etc) must be upgraded before this version can be installed or upgraded to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDependencies")]
        public virtual System.Nullable<bool> HasDependencies { get; set; }

        /// <summary>Version number e.g. 1.13.1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the VIP config for the bare metal load balancer.</summary>
    public class BareMetalVipConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The VIP which you previously set aside for the Kubernetes API of this bare metal user cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneVip")]
        public virtual string ControlPlaneVip { get; set; }

        /// <summary>
        /// The VIP which you previously set aside for ingress traffic into this bare metal user cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressVip")]
        public virtual string IngressVip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the workload node configurations.</summary>
    public class BareMetalWorkloadNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies which container runtime will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerRuntime")]
        public virtual string ContainerRuntime { get; set; }

        /// <summary>
        /// The maximum number of pods a node can run. The size of the CIDR range assigned to the node will be derived
        /// from this parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPodsPerNode")]
        public virtual System.Nullable<long> MaxPodsPerNode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Binary Authorization.</summary>
    public class BinaryAuthorization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mode of operation for binauthz policy evaluation. If unspecified, defaults to DISABLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMode")]
        public virtual string EvaluationMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

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
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. * `deleted:user:{emailid}?uid={uniqueid}`: An email address
        /// (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`. For an overview of the IAM roles and permissions, see the [IAM
        /// documentation](https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined
        /// roles, see [here](https://cloud.google.com/iam/docs/understanding-roles).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ClusterUser configures user principals for an RBAC policy.</summary>
    public class ClusterUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the user, e.g. `my-gcp-id@gmail.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for enrolling an existing bare metal admin cluster to the GKE on-prem API.</summary>
    public class EnrollBareMetalAdminClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User provided OnePlatform identifier that is used as part of the resource name. This must be unique among
        /// all GKE on-prem clusters within a project and location and will return a 409 if the cluster already exists.
        /// (https://tools.ietf.org/html/rfc1123) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bareMetalAdminClusterId")]
        public virtual string BareMetalAdminClusterId { get; set; }

        /// <summary>Required. This is the full resource name of this admin cluster's fleet membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for enrolling an existing bare metal cluster to the Anthos On-Prem API.</summary>
    public class EnrollBareMetalClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The admin cluster this bare metal user cluster belongs to. This is the full resource name of the
        /// admin cluster's fleet membership. In the future, references to other resource types might be allowed if
        /// admin clusters are modeled as their own resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminClusterMembership")]
        public virtual string AdminClusterMembership { get; set; }

        /// <summary>
        /// User provided OnePlatform identifier that is used as part of the resource name. This must be unique among
        /// all bare metal clusters within a project and location and will return a 409 if the cluster already exists.
        /// (https://tools.ietf.org/html/rfc1123) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bareMetalClusterId")]
        public virtual string BareMetalClusterId { get; set; }

        /// <summary>
        /// Optional. The object name of the bare metal cluster custom resource on the associated admin cluster. This
        /// field is used to support conflicting resource names when enrolling existing clusters to the API. When not
        /// provided, this field will resolve to the bare_metal_cluster_id. Otherwise, it must match the object name of
        /// the bare metal cluster custom resource. It is not modifiable outside / beyond the enrollment operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localName")]
        public virtual string LocalName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for enrolling an existing bare metal node pool to the GKE on-prem API.</summary>
    public class EnrollBareMetalNodePoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User provided OnePlatform identifier that is used as part of the resource name.
        /// (https://tools.ietf.org/html/rfc1123) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bareMetalNodePoolId")]
        public virtual string BareMetalNodePoolId { get; set; }

        /// <summary>If set, only validate the request, but do not actually enroll the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for enrolling an existing VMware admin cluster to the GKE on-prem API.</summary>
    public class EnrollVmwareAdminClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. This is the full resource name of this admin cluster's fleet membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>
        /// User provided OnePlatform identifier that is used as part of the resource name. This must be unique among
        /// all GKE on-prem clusters within a project and location and will return a 409 if the cluster already exists.
        /// (https://tools.ietf.org/html/rfc1123) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareAdminClusterId")]
        public virtual string VmwareAdminClusterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for enrolling an existing VMware cluster to the Anthos On-Prem API.</summary>
    public class EnrollVmwareClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The admin cluster this VMware user cluster belongs to. This is the full resource name of the admin
        /// cluster's fleet membership. In the future, references to other resource types might be allowed if admin
        /// clusters are modeled as their own resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminClusterMembership")]
        public virtual string AdminClusterMembership { get; set; }

        /// <summary>
        /// Optional. The object name of the VMware OnPremUserCluster custom resource on the associated admin cluster.
        /// This field is used to support conflicting resource names when enrolling existing clusters to the API. When
        /// not provided, this field will resolve to the vmware_cluster_id. Otherwise, it must match the object name of
        /// the VMware OnPremUserCluster custom resource. It is not modifiable outside / beyond the enrollment
        /// operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localName")]
        public virtual string LocalName { get; set; }

        /// <summary>Validate the request without actually doing any updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>
        /// User provided OnePlatform identifier that is used as part of the resource name. This must be unique among
        /// all GKE on-prem clusters within a project and location and will return a 409 if the cluster already exists.
        /// (https://tools.ietf.org/html/rfc1123) format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareClusterId")]
        public virtual string VmwareClusterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for enrolling a VMware node pool.</summary>
    public class EnrollVmwareNodePoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target node pool id to be enrolled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareNodePoolId")]
        public virtual string VmwareNodePoolId { get; set; }

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

    /// <summary>
    /// Fleet related configuration. Fleets are a Google Cloud concept for logically organizing clusters, letting you
    /// use and manage multi-cluster capabilities and apply consistent policies across your systems. See [Anthos
    /// Fleets](`https://cloud.google.com/anthos/multicluster-management/fleets`) for more details on Anthos
    /// multi-cluster capabilities using Fleets. ##
    /// </summary>
    public class Fleet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The name of the managed fleet Membership resource associated to this cluster. Membership names
        /// are formatted as `projects//locations//memberships/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing bare metal admin clusters.</summary>
    public class ListBareMetalAdminClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of bare metal admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bareMetalAdminClusters")]
        public virtual System.Collections.Generic.IList<BareMetalAdminCluster> BareMetalAdminClusters { get; set; }

        /// <summary>
        /// A token identifying a page of results the server should return. If the token is not empty this means that
        /// more results are available and should be retrieved by repeating the request with the provided page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing bare metal Clusters.</summary>
    public class ListBareMetalClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of bare metal Clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bareMetalClusters")]
        public virtual System.Collections.Generic.IList<BareMetalCluster> BareMetalClusters { get; set; }

        /// <summary>
        /// A token identifying a page of results the server should return. If the token is not empty this means that
        /// more results are available and should be retrieved by repeating the request with the provided page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing bare metal node pools.</summary>
    public class ListBareMetalNodePoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The node pools from the specified parent resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bareMetalNodePools")]
        public virtual System.Collections.Generic.IList<BareMetalNodePool> BareMetalNodePools { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing VMware admin clusters.</summary>
    public class ListVmwareAdminClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token identifying a page of results the server should return. If the token is not empty this means that
        /// more results are available and should be retrieved by repeating the request with the provided page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The list of VMware admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareAdminClusters")]
        public virtual System.Collections.Generic.IList<VmwareAdminCluster> VmwareAdminClusters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing VMware Clusters.</summary>
    public class ListVmwareClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token identifying a page of results the server should return. If the token is not empty this means that
        /// more results are available and should be retrieved by repeating the request with the provided page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The list of VMware Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareClusters")]
        public virtual System.Collections.Generic.IList<VmwareCluster> VmwareClusters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing VMware node pools.</summary>
    public class ListVmwareNodePoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The node pools from the specified parent resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmwareNodePools")]
        public virtual System.Collections.Generic.IList<VmwareNodePool> VmwareNodePools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents a Google Cloud location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-east1"}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The canonical id for this location. For example: `"us-east1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// `"projects/example-project/locations/us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Progress metric is (string, int|float|string) pair.</summary>
    public class Metric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For metrics with floating point value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>For metrics with integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Required. The metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string MetricValue { get; set; }

        /// <summary>For metrics with custom values (ratios, visual progress, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// NodeTaint applied to every Kubernetes node in a node pool. Kubernetes taints can be used together with
    /// tolerations to control how workloads are scheduled to your nodes. Node taints are permanent.
    /// </summary>
    public class NodeTaint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The taint effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effect")]
        public virtual string Effect { get; set; }

        /// <summary>Key associated with the effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value associated with the effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Output only. Denotes if the local managing cluster's control plane is currently disconnected. This is
        /// expected to occur temporarily during self-managed cluster upgrades.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneDisconnected")]
        public virtual System.Nullable<bool> ControlPlaneDisconnected { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Detailed progress information for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have [Operation.error] value with a [google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Type of operation being executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about operation progress.</summary>
    public class OperationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stages of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stages")]
        public virtual System.Collections.Generic.IList<OperationStage> Stages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a particular stage of an operation.</summary>
    public class OperationStage : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Time the stage ended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Progress metric bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<Metric> Metrics { get; set; }

        /// <summary>The high-level stage of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time the stage started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. State of the stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:**
    /// ```
    /// {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    /// ```
    /// **YAML
    /// example:**
    /// ```
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3
    /// ```
    /// For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
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

    /// <summary>Response message for querying bare metal admin cluster version config.</summary>
    public class QueryBareMetalAdminVersionConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of available versions to install or to upgrade to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<BareMetalVersionInfo> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for querying bare metal admin cluster version config.</summary>
    public class QueryBareMetalVersionConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of available versions to install or to upgrade to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<BareMetalVersionInfo> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for querying VMware user cluster version config.</summary>
    public class QueryVmwareVersionConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of available versions to install or to upgrade to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<VmwareVersionInfo> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ResourceCondition provides a standard mechanism for higher-level status reporting from controller.
    /// </summary>
    public class ResourceCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastTransitionTimeRaw;

        private object _lastTransitionTime;

        /// <summary>Last time the condition transit from one status to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransitionTime")]
        public virtual string LastTransitionTimeRaw
        {
            get => _lastTransitionTimeRaw;
            set
            {
                _lastTransitionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastTransitionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastTransitionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastTransitionTimeDateTimeOffset instead.")]
        public virtual object LastTransitionTime
        {
            get => _lastTransitionTime;
            set
            {
                _lastTransitionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastTransitionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastTransitionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastTransitionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastTransitionTimeRaw);
            set => LastTransitionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Human-readable message indicating details about last transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Machine-readable message indicating details about last transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>state of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Type of the condition. (e.g., ClusterRunning, NodePoolRunning or ServerSidePreflightReady)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ResourceStatus describes why a cluster or node pool has a certain status. (e.g., ERROR or DEGRADED).
    /// </summary>
    public class ResourceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ResourceCondition provide a standard mechanism for higher-level status reporting from controller.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<ResourceCondition> Conditions { get; set; }

        /// <summary>
        /// Human-friendly representation of the error message from controller. The error message can be temporary as
        /// the controller controller creates a cluster or node pool. If the error message persists for a longer period
        /// of time, it can be used to surface error message to indicate real problems requiring user intervention.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Reflect current version of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>Shows the mapping of a given version to the number of machines under this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual Versions Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
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

    /// <summary>UpgradeDependency represents a dependency when upgrading a resource.</summary>
    public class UpgradeDependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current version of the dependency e.g. 1.15.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentVersion")]
        public virtual string CurrentVersion { get; set; }

        /// <summary>Membership names are formatted as `projects//locations//memberships/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>Resource name of the dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Target version of the dependency e.g. 1.16.1. This is the version the dependency needs to be upgraded to
        /// before a resource can be upgraded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetVersion")]
        public virtual string TargetVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ValidationCheck represents the result of preflight check.</summary>
    public class ValidationCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Options used for the validation check</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("option")]
        public virtual string Option { get; set; }

        /// <summary>Output only. The scenario when the preflight checks were run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scenario")]
        public virtual string Scenario { get; set; }

        /// <summary>Output only. The detailed validation check status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ValidationCheckStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ValidationCheckResult defines the details about the validation check.</summary>
    public class ValidationCheckResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category of the validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The description of the validation check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Detailed failure information, which might be unformatted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>A human-readable message of the check failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The validation check state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ValidationCheckStatus defines the detailed validation check status.</summary>
    public class ValidationCheckStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Individual checks which failed as part of the Preflight check execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual System.Collections.Generic.IList<ValidationCheckResult> Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Version describes the number of nodes at a given version under a resource.</summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of machines under the above version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Resource version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string VersionValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Versions describes the mapping of a given version to the number of machines under this version.
    /// </summary>
    public class Versions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Shows the mapping of a given version to the number of machines under this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<Version> VersionsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies anti affinity group config for the VMware user cluster.</summary>
    public class VmwareAAGConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Spread nodes across at least three physical hosts (requires at least three hosts). Enabled by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aagConfigDisabled")]
        public virtual System.Nullable<bool> AagConfigDisabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an IP pool used by the load balancer.</summary>
    public class VmwareAddressPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The addresses that are part of this pool. Each address must be either in the CIDR form
        /// (1.2.3.0/24) or range form (1.2.3.1-1.2.3.5).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addresses")]
        public virtual System.Collections.Generic.IList<string> Addresses { get; set; }

        /// <summary>
        /// If true, avoid using IPs ending in .0 or .255. This avoids buggy consumer devices mistakenly dropping IPv4
        /// traffic for those special IP addresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avoidBuggyIps")]
        public virtual System.Nullable<bool> AvoidBuggyIps { get; set; }

        /// <summary>If true, prevent IP addresses from being automatically assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualAssign")]
        public virtual System.Nullable<bool> ManualAssign { get; set; }

        /// <summary>Required. The name of the address pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pool")]
        public virtual string Pool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareAdminAddonNodeConfig contains add-on node configurations for VMware admin cluster.</summary>
    public class VmwareAdminAddonNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>VmwareAutoResizeConfig config specifies auto resize config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoResizeConfig")]
        public virtual VmwareAutoResizeConfig AutoResizeConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareAdminAuthorizationConfig represents configuration for admin cluster authorization.</summary>
    public class VmwareAdminAuthorizationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For VMware admin clusters, users will be granted the cluster-viewer role on the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewerUsers")]
        public virtual System.Collections.Generic.IList<ClusterUser> ViewerUsers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that represents a VMware admin cluster.</summary>
    public class VmwareAdminCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The VMware admin cluster addon node configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addonNode")]
        public virtual VmwareAdminAddonNodeConfig AddonNode { get; set; }

        /// <summary>
        /// Annotations on the VMware admin cluster. This field has the same restrictions as Kubernetes annotations. The
        /// total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional)
        /// and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or
        /// less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics
        /// between.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>The VMware admin cluster anti affinity group configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("antiAffinityGroups")]
        public virtual VmwareAAGConfig AntiAffinityGroups { get; set; }

        /// <summary>The VMware admin cluster authorization configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorization")]
        public virtual VmwareAdminAuthorizationConfig Authorization { get; set; }

        /// <summary>The VMware admin cluster auto repair configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRepairConfig")]
        public virtual VmwareAutoRepairConfig AutoRepairConfig { get; set; }

        /// <summary>The bootstrap cluster this VMware admin cluster belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootstrapClusterMembership")]
        public virtual string BootstrapClusterMembership { get; set; }

        /// <summary>The VMware admin cluster control plane node configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneNode")]
        public virtual VmwareAdminControlPlaneNodeConfig ControlPlaneNode { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which VMware admin cluster was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A human readable description of this VMware admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Enable advanced cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAdvancedCluster")]
        public virtual System.Nullable<bool> EnableAdvancedCluster { get; set; }

        /// <summary>Output only. The DNS name of VMware admin cluster's API server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding. Allows clients to perform
        /// consistent read-modify-writes through optimistic concurrency control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Fleet configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleet")]
        public virtual Fleet Fleet { get; set; }

        /// <summary>The OS image type for the VMware admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>The VMware admin cluster load balancer configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancer")]
        public virtual VmwareAdminLoadBalancerConfig LoadBalancer { get; set; }

        /// <summary>
        /// Output only. The object name of the VMware OnPremAdminCluster custom resource. This field is used to support
        /// conflicting names when enrolling existing clusters to the API. When used as a part of cluster enrollment,
        /// this field will differ from the ID in the resource name. For new clusters, this field will match the user
        /// provided cluster name and be visible in the last component of the resource name. It is not modifiable. All
        /// users should use this name to access their cluster using gkectl or kubectl and should expect to see the
        /// local name when viewing admin cluster controller logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localName")]
        public virtual string LocalName { get; set; }

        /// <summary>Immutable. The VMware admin cluster resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The VMware admin cluster network configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual VmwareAdminNetworkConfig NetworkConfig { get; set; }

        /// <summary>The Anthos clusters on the VMware version for the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onPremVersion")]
        public virtual string OnPremVersion { get; set; }

        /// <summary>The VMware platform configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformConfig")]
        public virtual VmwarePlatformConfig PlatformConfig { get; set; }

        /// <summary>
        /// Output only. The VMware admin cluster prepared secrets configuration. It should always be enabled by the
        /// Central API, instead of letting users set it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preparedSecrets")]
        public virtual VmwareAdminPreparedSecretsConfig PreparedSecrets { get; set; }

        /// <summary>Output only. If set, there are currently changes in flight to the VMware admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. The current state of VMware admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. ResourceStatus representing detailed cluster state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ResourceStatus Status { get; set; }

        /// <summary>Output only. The unique identifier of the VMware admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which VMware admin cluster was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. ValidationCheck represents the result of the preflight check job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationCheck")]
        public virtual ValidationCheck ValidationCheck { get; set; }

        /// <summary>The VMware admin cluster VCenter configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenter")]
        public virtual VmwareAdminVCenterConfig Vcenter { get; set; }
    }

    /// <summary>
    /// VmwareAdminControlPlaneNodeConfig contains control plane node configuration for VMware admin cluster.
    /// </summary>
    public class VmwareAdminControlPlaneNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of vCPUs for the control-plane node of the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpus")]
        public virtual System.Nullable<long> Cpus { get; set; }

        /// <summary>The number of mebibytes of memory for the control-plane node of the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual System.Nullable<long> Memory { get; set; }

        /// <summary>The number of control plane nodes for this VMware admin cluster. (default: 1 replica).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicas")]
        public virtual System.Nullable<long> Replicas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareAdminF5BigIpConfig represents configuration parameters for an F5 BIG-IP load balancer.</summary>
    public class VmwareAdminF5BigIpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The load balancer's IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// The preexisting partition to be used by the load balancer. This partition is usually created for the admin
        /// cluster for example: 'my-f5-admin-partition'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual string Partition { get; set; }

        /// <summary>The pool name. Only necessary, if using SNAT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snatPool")]
        public virtual string SnatPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies HA admin control plane config.</summary>
    public class VmwareAdminHAControlPlaneConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Static IP addresses for the admin control plane nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneIpBlock")]
        public virtual VmwareIpBlock ControlPlaneIpBlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareAdminLoadBalancerConfig contains load balancer configuration for VMware admin cluster.</summary>
    public class VmwareAdminLoadBalancerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for F5 Big IP typed load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f5Config")]
        public virtual VmwareAdminF5BigIpConfig F5Config { get; set; }

        /// <summary>Manually configured load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualLbConfig")]
        public virtual VmwareAdminManualLbConfig ManualLbConfig { get; set; }

        /// <summary>MetalLB load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metalLbConfig")]
        public virtual VmwareAdminMetalLbConfig MetalLbConfig { get; set; }

        /// <summary>Output only. Configuration for Seesaw typed load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seesawConfig")]
        public virtual VmwareAdminSeesawConfig SeesawConfig { get; set; }

        /// <summary>The VIPs used by the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vipConfig")]
        public virtual VmwareAdminVipConfig VipConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VmwareAdminManualLbConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>NodePort for add-ons server in the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addonsNodePort")]
        public virtual System.Nullable<int> AddonsNodePort { get; set; }

        /// <summary>
        /// NodePort for control plane service. The Kubernetes API server in the admin cluster is implemented as a
        /// Service of type NodePort (ex. 30968).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneNodePort")]
        public virtual System.Nullable<int> ControlPlaneNodePort { get; set; }

        /// <summary>
        /// NodePort for ingress service's http. The ingress service in the admin cluster is implemented as a Service of
        /// type NodePort (ex. 32527).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressHttpNodePort")]
        public virtual System.Nullable<int> IngressHttpNodePort { get; set; }

        /// <summary>
        /// NodePort for ingress service's https. The ingress service in the admin cluster is implemented as a Service
        /// of type NodePort (ex. 30139).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressHttpsNodePort")]
        public virtual System.Nullable<int> IngressHttpsNodePort { get; set; }

        /// <summary>
        /// NodePort for konnectivity server service running as a sidecar in each kube-apiserver pod (ex. 30564).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("konnectivityServerNodePort")]
        public virtual System.Nullable<int> KonnectivityServerNodePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VmwareAdminMetalLbConfig represents configuration parameters for a MetalLB load balancer. For admin clusters,
    /// currently no configurations is needed.
    /// </summary>
    public class VmwareAdminMetalLbConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether MetalLB is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareAdminNetworkConfig contains network configuration for VMware admin cluster.</summary>
    public class VmwareAdminNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration settings for a DHCP IP configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dhcpIpConfig")]
        public virtual VmwareDhcpIpConfig DhcpIpConfig { get; set; }

        /// <summary>Configuration for HA admin cluster control plane.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("haControlPlaneConfig")]
        public virtual VmwareAdminHAControlPlaneConfig HaControlPlaneConfig { get; set; }

        /// <summary>Represents common network settings irrespective of the host's IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostConfig")]
        public virtual VmwareHostConfig HostConfig { get; set; }

        /// <summary>
        /// Required. All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges. Only a single
        /// range is supported. This field cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> PodAddressCidrBlocks { get; set; }

        /// <summary>
        /// Required. All services in the cluster are assigned an RFC1918 IPv4 address from these ranges. Only a single
        /// range is supported. This field cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> ServiceAddressCidrBlocks { get; set; }

        /// <summary>Configuration settings for a static IP configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticIpConfig")]
        public virtual VmwareStaticIpConfig StaticIpConfig { get; set; }

        /// <summary>vcenter_network specifies vCenter network name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenterNetwork")]
        public virtual string VcenterNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareAdminPreparedSecretsConfig represents configuration for admin cluster prepared secrets.</summary>
    public class VmwareAdminPreparedSecretsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether prepared secrets is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VmwareSeesawConfig represents configuration parameters for an already existing Seesaw load balancer. IMPORTANT:
    /// Please note that the Anthos On-Prem API will not generate or update Seesaw configurations it can only bind a
    /// pre-existing configuration to a new user cluster. IMPORTANT: When attempting to create a user cluster with a
    /// pre-existing Seesaw load balancer you will need to follow some preparation steps before calling the
    /// 'CreateVmwareCluster' API method. First you will need to create the user cluster's namespace via kubectl. The
    /// namespace will need to use the following naming convention : -gke-onprem-mgmt or -gke-onprem-mgmt depending on
    /// whether you used the 'VmwareCluster.local_name' to disambiguate collisions; for more context see the
    /// documentation of 'VmwareCluster.local_name'. Once the namespace is created you will need to create a secret
    /// resource via kubectl. This secret will contain copies of your Seesaw credentials. The Secret must be called
    /// 'user-cluster-creds' and contain Seesaw's SSH and Cert credentials. The credentials must be keyed with the
    /// following names: 'seesaw-ssh-private-key', 'seesaw-ssh-public-key', 'seesaw-ssh-ca-key', 'seesaw-ssh-ca-cert'.
    /// </summary>
    public class VmwareAdminSeesawConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable two load balancer VMs to achieve a highly-available Seesaw load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHa")]
        public virtual System.Nullable<bool> EnableHa { get; set; }

        /// <summary>
        /// In general the following format should be used for the Seesaw group name: seesaw-for-[cluster_name].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>The IP Blocks to be used by the Seesaw load balancer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipBlocks")]
        public virtual System.Collections.Generic.IList<VmwareIpBlock> IpBlocks { get; set; }

        /// <summary>MasterIP is the IP announced by the master of Seesaw group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterIp")]
        public virtual string MasterIp { get; set; }

        /// <summary>Name to be used by Stackdriver.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackdriverName")]
        public virtual string StackdriverName { get; set; }

        /// <summary>Names of the VMs created for this Seesaw group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vms")]
        public virtual System.Collections.Generic.IList<string> Vms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareAdminVCenterConfig contains VCenter configuration for VMware admin cluster.</summary>
    public class VmwareAdminVCenterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The vCenter IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Contains the vCenter CA certificate public key for SSL verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertData")]
        public virtual string CaCertData { get; set; }

        /// <summary>The name of the vCenter cluster for the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>The name of the virtual machine disk (VMDK) for the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisk")]
        public virtual string DataDisk { get; set; }

        /// <summary>The name of the vCenter datacenter for the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datacenter")]
        public virtual string Datacenter { get; set; }

        /// <summary>The name of the vCenter datastore for the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datastore")]
        public virtual string Datastore { get; set; }

        /// <summary>The name of the vCenter folder for the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual string Folder { get; set; }

        /// <summary>The name of the vCenter resource pool for the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePool")]
        public virtual string ResourcePool { get; set; }

        /// <summary>The name of the vCenter storage policy for the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePolicyName")]
        public virtual string StoragePolicyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareAdminVipConfig for VMware load balancer configurations.</summary>
    public class VmwareAdminVipConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The VIP to configure the load balancer for add-ons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addonsVip")]
        public virtual string AddonsVip { get; set; }

        /// <summary>The VIP which you previously set aside for the Kubernetes API of the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneVip")]
        public virtual string ControlPlaneVip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies config to enable/disable auto repair. The cluster-health-controller is deployed only if Enabled is
    /// true.
    /// </summary>
    public class VmwareAutoRepairConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether auto repair is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents auto resizing configurations for the VMware user cluster.</summary>
    public class VmwareAutoResizeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to enable controle plane node auto resizing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareBundleConfig represents configuration for the bundle.</summary>
    public class VmwareBundleConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Resource status for the bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ResourceStatus Status { get; set; }

        /// <summary>The version of the bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that represents a VMware user cluster. ##</summary>
    public class VmwareCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The admin cluster this VMware user cluster belongs to. This is the full resource name of the admin
        /// cluster's fleet membership. In the future, references to other resource types might be allowed if admin
        /// clusters are modeled as their own resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminClusterMembership")]
        public virtual string AdminClusterMembership { get; set; }

        /// <summary>Output only. The resource name of the VMware admin cluster hosting this user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminClusterName")]
        public virtual string AdminClusterName { get; set; }

        /// <summary>
        /// Annotations on the VMware user cluster. This field has the same restrictions as Kubernetes annotations. The
        /// total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional)
        /// and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or
        /// less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics
        /// between.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// AAGConfig specifies whether to spread VMware user cluster nodes across at least three physical hosts in the
        /// datacenter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("antiAffinityGroups")]
        public virtual VmwareAAGConfig AntiAffinityGroups { get; set; }

        /// <summary>RBAC policy that will be applied and managed by the Anthos On-Prem API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorization")]
        public virtual Authorization Authorization { get; set; }

        /// <summary>Configuration for auto repairing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRepairConfig")]
        public virtual VmwareAutoRepairConfig AutoRepairConfig { get; set; }

        /// <summary>Binary Authorization related configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>VMware user cluster control plane nodes must have either 1 or 3 replicas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneNode")]
        public virtual VmwareControlPlaneNodeConfig ControlPlaneNode { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which VMware user cluster was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>VmwareDataplaneV2Config specifies configuration for Dataplane V2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplaneV2")]
        public virtual VmwareDataplaneV2Config DataplaneV2 { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The time at which VMware user cluster was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>A human readable description of this VMware user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Disable bundled ingress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableBundledIngress")]
        public virtual System.Nullable<bool> DisableBundledIngress { get; set; }

        /// <summary>Enable advanced cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAdvancedCluster")]
        public virtual System.Nullable<bool> EnableAdvancedCluster { get; set; }

        /// <summary>Enable control plane V2. Default to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableControlPlaneV2")]
        public virtual System.Nullable<bool> EnableControlPlaneV2 { get; set; }

        /// <summary>Output only. The DNS name of VMware user cluster's API server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding. Allows clients to perform
        /// consistent read-modify-writes through optimistic concurrency control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Fleet configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleet")]
        public virtual Fleet Fleet { get; set; }

        /// <summary>Load balancer configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancer")]
        public virtual VmwareLoadBalancerConfig LoadBalancer { get; set; }

        /// <summary>
        /// Output only. The object name of the VMware OnPremUserCluster custom resource on the associated admin
        /// cluster. This field is used to support conflicting names when enrolling existing clusters to the API. When
        /// used as a part of cluster enrollment, this field will differ from the ID in the resource name. For new
        /// clusters, this field will match the user provided cluster name and be visible in the last component of the
        /// resource name. It is not modifiable. All users should use this name to access their cluster using gkectl or
        /// kubectl and should expect to see the local name when viewing admin cluster controller logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localName")]
        public virtual string LocalName { get; set; }

        /// <summary>Immutable. The VMware user cluster resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The VMware user cluster network configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual VmwareNetworkConfig NetworkConfig { get; set; }

        /// <summary>Required. The Anthos clusters on the VMware version for your user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onPremVersion")]
        public virtual string OnPremVersion { get; set; }

        /// <summary>Output only. If set, there are currently changes in flight to the VMware user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. The current state of VMware user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. ResourceStatus representing detailed cluster state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ResourceStatus Status { get; set; }

        /// <summary>Storage configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storage")]
        public virtual VmwareStorageConfig Storage { get; set; }

        /// <summary>Output only. The unique identifier of the VMware user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which VMware user cluster was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Specifies upgrade policy for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradePolicy")]
        public virtual VmwareClusterUpgradePolicy UpgradePolicy { get; set; }

        /// <summary>Output only. ValidationCheck represents the result of the preflight check job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationCheck")]
        public virtual ValidationCheck ValidationCheck { get; set; }

        /// <summary>
        /// VmwareVCenterConfig specifies vCenter config for the user cluster. If unspecified, it is inherited from the
        /// admin cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenter")]
        public virtual VmwareVCenterConfig Vcenter { get; set; }

        /// <summary>Enable VM tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmTrackingEnabled")]
        public virtual System.Nullable<bool> VmTrackingEnabled { get; set; }
    }

    /// <summary>VmwareClusterUpgradePolicy defines the cluster upgrade policy.</summary>
    public class VmwareClusterUpgradePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Controls whether the upgrade applies to the control plane only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneOnly")]
        public virtual System.Nullable<bool> ControlPlaneOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies control plane node config for the VMware user cluster.</summary>
    public class VmwareControlPlaneNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AutoResizeConfig provides auto resizing configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoResizeConfig")]
        public virtual VmwareAutoResizeConfig AutoResizeConfig { get; set; }

        /// <summary>
        /// The number of CPUs for each admin cluster node that serve as control planes for this VMware user cluster.
        /// (default: 4 CPUs)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpus")]
        public virtual System.Nullable<long> Cpus { get; set; }

        /// <summary>
        /// The megabytes of memory for each admin cluster node that serves as a control plane for this VMware user
        /// cluster (default: 8192 MB memory).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual System.Nullable<long> Memory { get; set; }

        /// <summary>The number of control plane nodes for this VMware user cluster. (default: 1 replica).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicas")]
        public virtual System.Nullable<long> Replicas { get; set; }

        /// <summary>Vsphere-specific config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vsphereConfig")]
        public virtual VmwareControlPlaneVsphereConfig VsphereConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies control plane V2 config.</summary>
    public class VmwareControlPlaneV2Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Static IP addresses for the control plane nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneIpBlock")]
        public virtual VmwareIpBlock ControlPlaneIpBlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies control plane node config.</summary>
    public class VmwareControlPlaneVsphereConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Vsphere datastore used by the control plane Node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datastore")]
        public virtual string Datastore { get; set; }

        /// <summary>The Vsphere storage policy used by the control plane Node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePolicyName")]
        public virtual string StoragePolicyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains configurations for Dataplane V2, which is optimized dataplane for Kubernetes networking. For more
    /// information, see: https://cloud.google.com/kubernetes-engine/docs/concepts/dataplane-v2
    /// </summary>
    public class VmwareDataplaneV2Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable advanced networking which requires dataplane_v2_enabled to be set true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedNetworking")]
        public virtual System.Nullable<bool> AdvancedNetworking { get; set; }

        /// <summary>Enables Dataplane V2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataplaneV2Enabled")]
        public virtual System.Nullable<bool> DataplaneV2Enabled { get; set; }

        /// <summary>Configure ForwardMode for Dataplane v2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardMode")]
        public virtual string ForwardMode { get; set; }

        /// <summary>Enable Dataplane V2 for clusters with Windows nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsDataplaneV2Enabled")]
        public virtual System.Nullable<bool> WindowsDataplaneV2Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the network configuration required for the VMware user clusters with DHCP IP configurations.
    /// </summary>
    public class VmwareDhcpIpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>enabled is a flag to mark if DHCP IP allocation is used for VMware user clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents configuration parameters for an F5 BIG-IP load balancer.</summary>
    public class VmwareF5BigIpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The load balancer's IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// The preexisting partition to be used by the load balancer. This partition is usually created for the admin
        /// cluster for example: 'my-f5-admin-partition'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual string Partition { get; set; }

        /// <summary>The pool name. Only necessary, if using SNAT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snatPool")]
        public virtual string SnatPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the common parameters for all the hosts irrespective of their IP address.</summary>
    public class VmwareHostConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DNS search domains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsSearchDomains")]
        public virtual System.Collections.Generic.IList<string> DnsSearchDomains { get; set; }

        /// <summary>DNS servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsServers")]
        public virtual System.Collections.Generic.IList<string> DnsServers { get; set; }

        /// <summary>NTP servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ntpServers")]
        public virtual System.Collections.Generic.IList<string> NtpServers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents VMware user cluster node's network configuration.</summary>
    public class VmwareHostIp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hostname of the machine. VM's name will be used if this field is empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>IP could be an IP address (like 1.2.3.4) or a CIDR (like 1.2.3.0/24).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public virtual string Ip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a collection of IP addresses to assign to nodes.</summary>
    public class VmwareIpBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The network gateway used by the VMware user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gateway")]
        public virtual string Gateway { get; set; }

        /// <summary>The node's network configurations used by the VMware user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ips")]
        public virtual System.Collections.Generic.IList<VmwareHostIp> Ips { get; set; }

        /// <summary>The netmask used by the VMware user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("netmask")]
        public virtual string Netmask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the locad balancer config for the VMware user cluster.</summary>
    public class VmwareLoadBalancerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for F5 Big IP typed load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("f5Config")]
        public virtual VmwareF5BigIpConfig F5Config { get; set; }

        /// <summary>Manually configured load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualLbConfig")]
        public virtual VmwareManualLbConfig ManualLbConfig { get; set; }

        /// <summary>Configuration for MetalLB typed load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metalLbConfig")]
        public virtual VmwareMetalLbConfig MetalLbConfig { get; set; }

        /// <summary>Output only. Configuration for Seesaw typed load balancers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seesawConfig")]
        public virtual VmwareSeesawConfig SeesawConfig { get; set; }

        /// <summary>The VIPs used by the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vipConfig")]
        public virtual VmwareVipConfig VipConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents configuration parameters for an already existing manual load balancer. Given the nature of manual
    /// load balancers it is expected that said load balancer will be fully managed by users. IMPORTANT: Please note
    /// that the Anthos On-Prem API will not generate or update ManualLB configurations it can only bind a pre-existing
    /// configuration to a new VMware user cluster.
    /// </summary>
    public class VmwareManualLbConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// NodePort for control plane service. The Kubernetes API server in the admin cluster is implemented as a
        /// Service of type NodePort (ex. 30968).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneNodePort")]
        public virtual System.Nullable<int> ControlPlaneNodePort { get; set; }

        /// <summary>
        /// NodePort for ingress service's http. The ingress service in the admin cluster is implemented as a Service of
        /// type NodePort (ex. 32527).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressHttpNodePort")]
        public virtual System.Nullable<int> IngressHttpNodePort { get; set; }

        /// <summary>
        /// NodePort for ingress service's https. The ingress service in the admin cluster is implemented as a Service
        /// of type NodePort (ex. 30139).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressHttpsNodePort")]
        public virtual System.Nullable<int> IngressHttpsNodePort { get; set; }

        /// <summary>
        /// NodePort for konnectivity server service running as a sidecar in each kube-apiserver pod (ex. 30564).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("konnectivityServerNodePort")]
        public virtual System.Nullable<int> KonnectivityServerNodePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents configuration parameters for the MetalLB load balancer.</summary>
    public class VmwareMetalLbConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. AddressPools is a list of non-overlapping IP pools used by load balancer typed services. All
        /// addresses must be routable to load balancer nodes. IngressVIP must be included in the pools.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressPools")]
        public virtual System.Collections.Generic.IList<VmwareAddressPool> AddressPools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies network config for the VMware user cluster.</summary>
    public class VmwareNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for control plane V2 mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneV2Config")]
        public virtual VmwareControlPlaneV2Config ControlPlaneV2Config { get; set; }

        /// <summary>Configuration settings for a DHCP IP configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dhcpIpConfig")]
        public virtual VmwareDhcpIpConfig DhcpIpConfig { get; set; }

        /// <summary>Represents common network settings irrespective of the host's IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostConfig")]
        public virtual VmwareHostConfig HostConfig { get; set; }

        /// <summary>
        /// Required. All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges. Only a single
        /// range is supported. This field cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> PodAddressCidrBlocks { get; set; }

        /// <summary>
        /// Required. All services in the cluster are assigned an RFC1918 IPv4 address from these ranges. Only a single
        /// range is supported. This field cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAddressCidrBlocks")]
        public virtual System.Collections.Generic.IList<string> ServiceAddressCidrBlocks { get; set; }

        /// <summary>Configuration settings for a static IP configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticIpConfig")]
        public virtual VmwareStaticIpConfig StaticIpConfig { get; set; }

        /// <summary>vcenter_network specifies vCenter network name. Inherited from the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcenterNetwork")]
        public virtual string VcenterNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters that describe the configuration of all nodes within a given node pool.</summary>
    public class VmwareNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>VMware disk size to be used during creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<long> BootDiskSizeGb { get; set; }

        /// <summary>The number of CPUs for each node in the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpus")]
        public virtual System.Nullable<long> Cpus { get; set; }

        /// <summary>
        /// Allow node pool traffic to be load balanced. Only works for clusters with MetalLB load balancers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableLoadBalancer")]
        public virtual System.Nullable<bool> EnableLoadBalancer { get; set; }

        /// <summary>The OS image name in vCenter, only valid when using Windows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// Required. The OS image to be used for each node in a node pool. Currently `cos`, `cos_cgv2`, `ubuntu`,
        /// `ubuntu_cgv2`, `ubuntu_containerd` and `windows` are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>
        /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to
        /// any default label(s) that Kubernetes may apply to the node. In case of conflict in label keys, the applied
        /// set may differ depending on the Kubernetes version -- it's best to assume the behavior is undefined and
        /// conflicts should be avoided. For more information, including usage and the valid values, see:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The megabytes of memory for each node in the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryMb")]
        public virtual System.Nullable<long> MemoryMb { get; set; }

        /// <summary>The number of nodes in the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicas")]
        public virtual System.Nullable<long> Replicas { get; set; }

        /// <summary>The initial taints assigned to nodes of this node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taints")]
        public virtual System.Collections.Generic.IList<NodeTaint> Taints { get; set; }

        /// <summary>Specifies the vSphere config for node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vsphereConfig")]
        public virtual VmwareVsphereConfig VsphereConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource VmwareNodePool represents a VMware node pool. ##</summary>
    public class VmwareNodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size
        /// of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional) and name
        /// (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less,
        /// begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Required. The node configuration of the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual VmwareNodeConfig Config { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this node pool was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. The time at which this node pool was deleted. If the resource is not deleted, this must be
        /// empty
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The display name for the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding. Allows clients to perform
        /// consistent read-modify-writes through optimistic concurrency control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Immutable. The resource name of this node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Node pool autoscaling config for the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolAutoscaling")]
        public virtual VmwareNodePoolAutoscalingConfig NodePoolAutoscaling { get; set; }

        /// <summary>Anthos version for the node pool. Defaults to the user cluster version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onPremVersion")]
        public virtual string OnPremVersion { get; set; }

        /// <summary>Output only. If set, there are currently changes in flight to the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. The current state of the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. ResourceStatus representing the detailed VMware node pool state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ResourceStatus Status { get; set; }

        /// <summary>Output only. The unique identifier of the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which this node pool was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }
    }

    /// <summary>NodePoolAutoscaling config for the NodePool to allow for the kubernetes to scale NodePool.</summary>
    public class VmwareNodePoolAutoscalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum number of replicas in the NodePool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReplicas")]
        public virtual System.Nullable<int> MaxReplicas { get; set; }

        /// <summary>Minimum number of replicas in the NodePool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minReplicas")]
        public virtual System.Nullable<int> MinReplicas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwarePlatformConfig represents configuration for the VMware platform.</summary>
    public class VmwarePlatformConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The list of bundles installed in the admin cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundles")]
        public virtual System.Collections.Generic.IList<VmwareBundleConfig> Bundles { get; set; }

        /// <summary>Output only. The platform version e.g. 1.13.2.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformVersion")]
        public virtual string PlatformVersion { get; set; }

        /// <summary>
        /// Input only. The required platform version e.g. 1.13.1. If the current platform version is lower than the
        /// target version, the platform version will be updated to the target version. If the target version is not
        /// installed in the platform (bundle versions), download the target version bundle.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredPlatformVersion")]
        public virtual string RequiredPlatformVersion { get; set; }

        /// <summary>Output only. Resource status for the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ResourceStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VmwareSeesawConfig represents configuration parameters for an already existing Seesaw load balancer. IMPORTANT:
    /// Please note that the Anthos On-Prem API will not generate or update Seesaw configurations it can only bind a
    /// pre-existing configuration to a new user cluster. IMPORTANT: When attempting to create a user cluster with a
    /// pre-existing Seesaw load balancer you will need to follow some preparation steps before calling the
    /// 'CreateVmwareCluster' API method. First you will need to create the user cluster's namespace via kubectl. The
    /// namespace will need to use the following naming convention : -gke-onprem-mgmt or -gke-onprem-mgmt depending on
    /// whether you used the 'VmwareCluster.local_name' to disambiguate collisions; for more context see the
    /// documentation of 'VmwareCluster.local_name'. Once the namespace is created you will need to create a secret
    /// resource via kubectl. This secret will contain copies of your Seesaw credentials. The Secret must be called
    /// 'user-cluster-creds' and contain Seesaw's SSH and Cert credentials. The credentials must be keyed with the
    /// following names: 'seesaw-ssh-private-key', 'seesaw-ssh-public-key', 'seesaw-ssh-ca-key', 'seesaw-ssh-ca-cert'.
    /// </summary>
    public class VmwareSeesawConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable two load balancer VMs to achieve a highly-available Seesaw load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHa")]
        public virtual System.Nullable<bool> EnableHa { get; set; }

        /// <summary>
        /// Required. In general the following format should be used for the Seesaw group name:
        /// seesaw-for-[cluster_name].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Required. The IP Blocks to be used by the Seesaw load balancer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipBlocks")]
        public virtual System.Collections.Generic.IList<VmwareIpBlock> IpBlocks { get; set; }

        /// <summary>Required. MasterIP is the IP announced by the master of Seesaw group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterIp")]
        public virtual string MasterIp { get; set; }

        /// <summary>Name to be used by Stackdriver.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackdriverName")]
        public virtual string StackdriverName { get; set; }

        /// <summary>Names of the VMs created for this Seesaw group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vms")]
        public virtual System.Collections.Generic.IList<string> Vms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the network configuration required for the VMware user clusters with Static IP configurations.
    /// </summary>
    public class VmwareStaticIpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents the configuration values for static IP allocation to nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipBlocks")]
        public virtual System.Collections.Generic.IList<VmwareIpBlock> IpBlocks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies vSphere CSI components deployment config in the VMware user cluster.</summary>
    public class VmwareStorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether or not to deploy vSphere CSI components in the VMware user cluster. Enabled by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vsphereCsiDisabled")]
        public virtual System.Nullable<bool> VsphereCsiDisabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents configuration for the VMware VCenter for the user cluster.</summary>
    public class VmwareVCenterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The vCenter IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Contains the vCenter CA certificate public key for SSL verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCertData")]
        public virtual string CaCertData { get; set; }

        /// <summary>The name of the vCenter cluster for the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>The name of the vCenter datacenter for the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datacenter")]
        public virtual string Datacenter { get; set; }

        /// <summary>The name of the vCenter datastore for the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datastore")]
        public virtual string Datastore { get; set; }

        /// <summary>The name of the vCenter folder for the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual string Folder { get; set; }

        /// <summary>The name of the vCenter resource pool for the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePool")]
        public virtual string ResourcePool { get; set; }

        /// <summary>The name of the vCenter storage policy for the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePolicyName")]
        public virtual string StoragePolicyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about a specific Anthos on VMware version.</summary>
    public class VmwareVersionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of upgrade dependencies for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<UpgradeDependency> Dependencies { get; set; }

        /// <summary>
        /// If set, the cluster dependencies (e.g. the admin cluster, other user clusters managed by the same admin
        /// cluster) must be upgraded before this version can be installed or upgraded to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDependencies")]
        public virtual System.Nullable<bool> HasDependencies { get; set; }

        /// <summary>
        /// If set, the version is installed in the admin cluster. Otherwise, the version bundle must be downloaded and
        /// installed before a user cluster can be created at or upgraded to this version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInstalled")]
        public virtual System.Nullable<bool> IsInstalled { get; set; }

        /// <summary>Version number e.g. 1.13.1-gke.1000.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the VIP config for the VMware user cluster load balancer.</summary>
    public class VmwareVipConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The VIP which you previously set aside for the Kubernetes API of this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneVip")]
        public virtual string ControlPlaneVip { get; set; }

        /// <summary>The VIP which you previously set aside for ingress traffic into this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressVip")]
        public virtual string IngressVip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VmwareVsphereConfig represents configuration for the VMware VCenter for node pool.</summary>
    public class VmwareVsphereConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the vCenter datastore. Inherited from the user cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datastore")]
        public virtual string Datastore { get; set; }

        /// <summary>Vsphere host groups to apply to all VMs in the node pool</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostGroups")]
        public virtual System.Collections.Generic.IList<string> HostGroups { get; set; }

        /// <summary>Tags to apply to VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<VmwareVsphereTag> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VmwareVsphereTag describes a vSphere tag to be placed on VMs in the node pool. For more information, see
    /// https://docs.vmware.com/en/VMware-vSphere/7.0/com.vmware.vsphere.vcenterhost.doc/GUID-E8E854DD-AA97-4E0C-8419-CE84F93C4058.html
    /// </summary>
    public class VmwareVsphereTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Vsphere tag category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The Vsphere tag name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
