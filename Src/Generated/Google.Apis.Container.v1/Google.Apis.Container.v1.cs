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

namespace Google.Apis.Container.v1
{
    /// <summary>The Container Service.</summary>
    public class ContainerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ContainerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ContainerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "container";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://container.googleapis.com/";
        #else
            "https://container.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://container.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Kubernetes Engine API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Kubernetes Engine API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Container requests.</summary>
    public abstract class ContainerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ContainerBaseServiceRequest instance.</summary>
        protected ContainerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Container parameter list.</summary>
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
            Aggregated = new AggregatedResource(service);
            Locations = new LocationsResource(service);
            Zones = new ZonesResource(service);
        }

        /// <summary>Gets the Aggregated resource.</summary>
        public virtual AggregatedResource Aggregated { get; }

        /// <summary>The "aggregated" collection of methods.</summary>
        public class AggregatedResource
        {
            private const string Resource = "aggregated";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AggregatedResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                UsableSubnetworks = new UsableSubnetworksResource(service);
            }

            /// <summary>Gets the UsableSubnetworks resource.</summary>
            public virtual UsableSubnetworksResource UsableSubnetworks { get; }

            /// <summary>The "usableSubnetworks" collection of methods.</summary>
            public class UsableSubnetworksResource
            {
                private const string Resource = "usableSubnetworks";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public UsableSubnetworksResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists subnetworks that are usable for creating clusters in a project.</summary>
                /// <param name="parent">
                /// The parent project where subnetworks are usable. Specified in the format `projects/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists subnetworks that are usable for creating clusters in a project.</summary>
                public class ListRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ListUsableSubnetworksResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent project where subnetworks are usable. Specified in the format `projects/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filtering currently only supports equality on the networkProjectId and must be in the form:
                    /// "networkProjectId=[PROJECTID]", where `networkProjectId` is the project which owns the listed
                    /// subnetworks. This defaults to the parent project ID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The max number of results per page that should be returned. If the number of available results
                    /// is larger than `page_size`, a `next_page_token` is returned which can be used to get the next
                    /// page of results in subsequent requests. Acceptable values are 0 to 500, inclusive. (Default:
                    /// 500)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Specifies a page token to use. Set this to the nextPageToken returned by previous list requests
                    /// to get the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/aggregated/usableSubnetworks";

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
                Clusters = new ClustersResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Clusters resource.</summary>
            public virtual ClustersResource Clusters { get; }

            /// <summary>The "clusters" collection of methods.</summary>
            public class ClustersResource
            {
                private const string Resource = "clusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    NodePools = new NodePoolsResource(service);
                    WellKnown = new WellKnownResource(service);
                }

                /// <summary>Gets the NodePools resource.</summary>
                public virtual NodePoolsResource NodePools { get; }

                /// <summary>The "nodePools" collection of methods.</summary>
                public class NodePoolsResource
                {
                    private const string Resource = "nodePools";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public NodePoolsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a node pool for a cluster.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The parent (project, location, cluster id) where the node pool will be created. Specified in the
                    /// format `projects/*/locations/*/clusters/*`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Container.v1.Data.CreateNodePoolRequest body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a node pool for a cluster.</summary>
                    public class CreateRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.CreateNodePoolRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The parent (project, location, cluster id) where the node pool will be created. Specified in
                        /// the format `projects/*/locations/*/clusters/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.CreateNodePoolRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/nodePools";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a node pool from a cluster.</summary>
                    /// <param name="name">
                    /// The name (project, location, cluster, node pool id) of the node pool to delete. Specified in the
                    /// format `projects/*/locations/*/clusters/*/nodePools/*`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a node pool from a cluster.</summary>
                    public class DeleteRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name (project, location, cluster, node pool id) of the node pool to delete. Specified in
                        /// the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClusterId { get; set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool to delete. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string NodePoolId { get; set; }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                        /// deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ProjectId { get; set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Zone { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/nodePools/[^/]+$",
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Retrieves the requested node pool.</summary>
                    /// <param name="name">
                    /// The name (project, location, cluster, node pool id) of the node pool to get. Specified in the
                    /// format `projects/*/locations/*/clusters/*/nodePools/*`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieves the requested node pool.</summary>
                    public class GetRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.NodePool>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name (project, location, cluster, node pool id) of the node pool to get. Specified in
                        /// the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClusterId { get; set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool. This field has been deprecated and replaced by the
                        /// name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string NodePoolId { get; set; }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                        /// deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ProjectId { get; set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Zone { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/nodePools/[^/]+$",
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists the node pools for a cluster.</summary>
                    /// <param name="parent">
                    /// The parent (project, location, cluster id) where the node pools will be listed. Specified in the
                    /// format `projects/*/locations/*/clusters/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the node pools for a cluster.</summary>
                    public class ListRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ListNodePoolsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// The parent (project, location, cluster id) where the node pools will be listed. Specified in
                        /// the format `projects/*/locations/*/clusters/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the
                        /// parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ClusterId { get; set; }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                        /// deprecated and replaced by the parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ProjectId { get; set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Zone { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/nodePools";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Rolls back a previously Aborted or Failed NodePool upgrade. This makes no changes if the last
                    /// upgrade successfully completed.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name (project, location, cluster, node pool id) of the node poll to rollback upgrade.
                    /// Specified in the format `projects/*/locations/*/clusters/*/nodePools/*`.
                    /// </param>
                    public virtual RollbackRequest Rollback(Google.Apis.Container.v1.Data.RollbackNodePoolUpgradeRequest body, string name)
                    {
                        return new RollbackRequest(service, body, name);
                    }

                    /// <summary>
                    /// Rolls back a previously Aborted or Failed NodePool upgrade. This makes no changes if the last
                    /// upgrade successfully completed.
                    /// </summary>
                    public class RollbackRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Rollback request.</summary>
                        public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.RollbackNodePoolUpgradeRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name (project, location, cluster, node pool id) of the node poll to rollback upgrade.
                        /// Specified in the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.RollbackNodePoolUpgradeRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rollback";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:rollback";

                        /// <summary>Initializes Rollback parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/nodePools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Sets the autoscaling settings for the specified node pool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name (project, location, cluster, node pool) of the node pool to set autoscaler settings.
                    /// Specified in the format `projects/*/locations/*/clusters/*/nodePools/*`.
                    /// </param>
                    public virtual SetAutoscalingRequest SetAutoscaling(Google.Apis.Container.v1.Data.SetNodePoolAutoscalingRequest body, string name)
                    {
                        return new SetAutoscalingRequest(service, body, name);
                    }

                    /// <summary>Sets the autoscaling settings for the specified node pool.</summary>
                    public class SetAutoscalingRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new SetAutoscaling request.</summary>
                        public SetAutoscalingRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetNodePoolAutoscalingRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name (project, location, cluster, node pool) of the node pool to set autoscaler
                        /// settings. Specified in the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.SetNodePoolAutoscalingRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setAutoscaling";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:setAutoscaling";

                        /// <summary>Initializes SetAutoscaling parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/nodePools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Sets the NodeManagement options for a node pool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name (project, location, cluster, node pool id) of the node pool to set management
                    /// properties. Specified in the format `projects/*/locations/*/clusters/*/nodePools/*`.
                    /// </param>
                    public virtual SetManagementRequest SetManagement(Google.Apis.Container.v1.Data.SetNodePoolManagementRequest body, string name)
                    {
                        return new SetManagementRequest(service, body, name);
                    }

                    /// <summary>Sets the NodeManagement options for a node pool.</summary>
                    public class SetManagementRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new SetManagement request.</summary>
                        public SetManagementRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetNodePoolManagementRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name (project, location, cluster, node pool id) of the node pool to set management
                        /// properties. Specified in the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.SetNodePoolManagementRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setManagement";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:setManagement";

                        /// <summary>Initializes SetManagement parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/nodePools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the size for a specific node pool. The new size will be used for all replicas, including
                    /// future replicas created by modifying NodePool.locations.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name (project, location, cluster, node pool id) of the node pool to set size. Specified in
                    /// the format `projects/*/locations/*/clusters/*/nodePools/*`.
                    /// </param>
                    public virtual SetSizeRequest SetSize(Google.Apis.Container.v1.Data.SetNodePoolSizeRequest body, string name)
                    {
                        return new SetSizeRequest(service, body, name);
                    }

                    /// <summary>
                    /// Sets the size for a specific node pool. The new size will be used for all replicas, including
                    /// future replicas created by modifying NodePool.locations.
                    /// </summary>
                    public class SetSizeRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new SetSize request.</summary>
                        public SetSizeRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetNodePoolSizeRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name (project, location, cluster, node pool id) of the node pool to set size. Specified
                        /// in the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.SetNodePoolSizeRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setSize";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:setSize";

                        /// <summary>Initializes SetSize parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/nodePools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Updates the version and/or image type for the specified node pool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name (project, location, cluster, node pool) of the node pool to update. Specified in the
                    /// format `projects/*/locations/*/clusters/*/nodePools/*`.
                    /// </param>
                    public virtual UpdateRequest Update(Google.Apis.Container.v1.Data.UpdateNodePoolRequest body, string name)
                    {
                        return new UpdateRequest(service, body, name);
                    }

                    /// <summary>Updates the version and/or image type for the specified node pool.</summary>
                    public class UpdateRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.UpdateNodePoolRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name (project, location, cluster, node pool) of the node pool to update. Specified in
                        /// the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.UpdateNodePoolRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/nodePools/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the WellKnown resource.</summary>
                public virtual WellKnownResource WellKnown { get; }

                /// <summary>The "well-known" collection of methods.</summary>
                public class WellKnownResource
                {
                    private const string Resource = "wellKnown";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public WellKnownResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the OIDC discovery document for the cluster. See the [OpenID Connect Discovery 1.0
                    /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html) for details. This API
                    /// is not yet intended for general use, and is not available for all clusters.
                    /// </summary>
                    /// <param name="parent">
                    /// The cluster (project, location, cluster id) to get the discovery document for. Specified in the
                    /// format `projects/*/locations/*/clusters/*`.
                    /// </param>
                    public virtual GetOpenidConfigurationRequest GetOpenidConfiguration(string parent)
                    {
                        return new GetOpenidConfigurationRequest(service, parent);
                    }

                    /// <summary>
                    /// Gets the OIDC discovery document for the cluster. See the [OpenID Connect Discovery 1.0
                    /// specification](https://openid.net/specs/openid-connect-discovery-1_0.html) for details. This API
                    /// is not yet intended for general use, and is not available for all clusters.
                    /// </summary>
                    public class GetOpenidConfigurationRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.GetOpenIDConfigResponse>
                    {
                        /// <summary>Constructs a new GetOpenidConfiguration request.</summary>
                        public GetOpenidConfigurationRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// The cluster (project, location, cluster id) to get the discovery document for. Specified in
                        /// the format `projects/*/locations/*/clusters/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getOpenid-configuration";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/.well-known/openid-configuration";

                        /// <summary>Initializes GetOpenidConfiguration parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Completes master IP rotation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster id) of the cluster to complete IP rotation. Specified in the
                /// format `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual CompleteIpRotationRequest CompleteIpRotation(Google.Apis.Container.v1.Data.CompleteIPRotationRequest body, string name)
                {
                    return new CompleteIpRotationRequest(service, body, name);
                }

                /// <summary>Completes master IP rotation.</summary>
                public class CompleteIpRotationRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new CompleteIpRotation request.</summary>
                    public CompleteIpRotationRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.CompleteIPRotationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster id) of the cluster to complete IP rotation. Specified in
                    /// the format `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.CompleteIPRotationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "completeIpRotation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:completeIpRotation";

                    /// <summary>Initializes CompleteIpRotation parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a cluster, consisting of the specified number and type of Google Compute Engine instances.
                /// By default, the cluster is created in the project's [default
                /// network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks). One firewall is
                /// added for the cluster. After cluster creation, the Kubelet creates routes for each node to allow the
                /// containers on that node to communicate with all other instances in the cluster. Finally, an entry is
                /// added to the project's global metadata indicating which CIDR range the cluster is using.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The parent (project and location) where the cluster will be created. Specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Container.v1.Data.CreateClusterRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a cluster, consisting of the specified number and type of Google Compute Engine instances.
                /// By default, the cluster is created in the project's [default
                /// network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks). One firewall is
                /// added for the cluster. After cluster creation, the Kubelet creates routes for each node to allow the
                /// containers on that node to communicate with all other instances in the cluster. Finally, an entry is
                /// added to the project's global metadata indicating which CIDR range the cluster is using.
                /// </summary>
                public class CreateRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.CreateClusterRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent (project and location) where the cluster will be created. Specified in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.CreateClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/clusters";

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

                /// <summary>
                /// Deletes the cluster, including the Kubernetes endpoint and all worker nodes. Firewalls and routes
                /// that were configured during cluster creation are also deleted. Other Google Compute Engine resources
                /// that might be in use by the cluster, such as load balancer resources, are not deleted if they
                /// weren't present when the cluster was initially created.
                /// </summary>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to delete. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the cluster, including the Kubernetes endpoint and all worker nodes. Firewalls and routes
                /// that were configured during cluster creation are also deleted. Other Google Compute Engine resources
                /// that might be in use by the cluster, such as load balancer resources, are not deleted if they
                /// weren't present when the cluster was initially created.
                /// </summary>
                public class DeleteRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to delete. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to delete. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterId { get; set; }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Zone { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the details of a specific cluster.</summary>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to retrieve. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the details of a specific cluster.</summary>
                public class GetRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Cluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to retrieve. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to retrieve. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterId { get; set; }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Zone { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the public component of the cluster signing keys in JSON Web Key format. This API is not yet
                /// intended for general use, and is not available for all clusters.
                /// </summary>
                /// <param name="parent">
                /// The cluster (project, location, cluster id) to get keys for. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual GetJwksRequest GetJwks(string parent)
                {
                    return new GetJwksRequest(service, parent);
                }

                /// <summary>
                /// Gets the public component of the cluster signing keys in JSON Web Key format. This API is not yet
                /// intended for general use, and is not available for all clusters.
                /// </summary>
                public class GetJwksRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.GetJSONWebKeysResponse>
                {
                    /// <summary>Constructs a new GetJwks request.</summary>
                    public GetJwksRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The cluster (project, location, cluster id) to get keys for. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getJwks";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/jwks";

                    /// <summary>Initializes GetJwks parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all clusters owned by a project in either the specified zone or all zones.</summary>
                /// <param name="parent">
                /// The parent (project and location) where the clusters will be listed. Specified in the format
                /// `projects/*/locations/*`. Location "-" matches all zones and all regions.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all clusters owned by a project in either the specified zone or all zones.</summary>
                public class ListRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ListClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent (project and location) where the clusters will be listed. Specified in the format
                    /// `projects/*/locations/*`. Location "-" matches all zones and all regions.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides, or
                    /// "-" for all zones. This field has been deprecated and replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Zone { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/clusters";

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
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Sets the addons for a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to set addons. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetAddonsRequest SetAddons(Google.Apis.Container.v1.Data.SetAddonsConfigRequest body, string name)
                {
                    return new SetAddonsRequest(service, body, name);
                }

                /// <summary>Sets the addons for a specific cluster.</summary>
                public class SetAddonsRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetAddons request.</summary>
                    public SetAddonsRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetAddonsConfigRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to set addons. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetAddonsConfigRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setAddons";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setAddons";

                    /// <summary>Initializes SetAddons parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Enables or disables the ABAC authorization mechanism on a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster id) of the cluster to set legacy abac. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetLegacyAbacRequest SetLegacyAbac(Google.Apis.Container.v1.Data.SetLegacyAbacRequest body, string name)
                {
                    return new SetLegacyAbacRequest(service, body, name);
                }

                /// <summary>Enables or disables the ABAC authorization mechanism on a cluster.</summary>
                public class SetLegacyAbacRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetLegacyAbac request.</summary>
                    public SetLegacyAbacRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetLegacyAbacRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster id) of the cluster to set legacy abac. Specified in the
                    /// format `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetLegacyAbacRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setLegacyAbac";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setLegacyAbac";

                    /// <summary>Initializes SetLegacyAbac parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the locations for a specific cluster. Deprecated. Use
                /// [projects.locations.clusters.update](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters/update)
                /// instead.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to set locations. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetLocationsRequest SetLocations(Google.Apis.Container.v1.Data.SetLocationsRequest body, string name)
                {
                    return new SetLocationsRequest(service, body, name);
                }

                /// <summary>
                /// Sets the locations for a specific cluster. Deprecated. Use
                /// [projects.locations.clusters.update](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters/update)
                /// instead.
                /// </summary>
                public class SetLocationsRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetLocations request.</summary>
                    public SetLocationsRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetLocationsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to set locations. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetLocationsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setLocations";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setLocations";

                    /// <summary>Initializes SetLocations parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Sets the logging service for a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to set logging. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetLoggingRequest SetLogging(Google.Apis.Container.v1.Data.SetLoggingServiceRequest body, string name)
                {
                    return new SetLoggingRequest(service, body, name);
                }

                /// <summary>Sets the logging service for a specific cluster.</summary>
                public class SetLoggingRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetLogging request.</summary>
                    public SetLoggingRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetLoggingServiceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to set logging. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetLoggingServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setLogging";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setLogging";

                    /// <summary>Initializes SetLogging parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Sets the maintenance policy for a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster id) of the cluster to set maintenance policy. Specified in the
                /// format `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetMaintenancePolicyRequest SetMaintenancePolicy(Google.Apis.Container.v1.Data.SetMaintenancePolicyRequest body, string name)
                {
                    return new SetMaintenancePolicyRequest(service, body, name);
                }

                /// <summary>Sets the maintenance policy for a cluster.</summary>
                public class SetMaintenancePolicyRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetMaintenancePolicy request.</summary>
                    public SetMaintenancePolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetMaintenancePolicyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster id) of the cluster to set maintenance policy. Specified in
                    /// the format `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetMaintenancePolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMaintenancePolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setMaintenancePolicy";

                    /// <summary>Initializes SetMaintenancePolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets master auth materials. Currently supports changing the admin password or a specific cluster,
                /// either via password generation or explicitly setting the password.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to set auth. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetMasterAuthRequest SetMasterAuth(Google.Apis.Container.v1.Data.SetMasterAuthRequest body, string name)
                {
                    return new SetMasterAuthRequest(service, body, name);
                }

                /// <summary>
                /// Sets master auth materials. Currently supports changing the admin password or a specific cluster,
                /// either via password generation or explicitly setting the password.
                /// </summary>
                public class SetMasterAuthRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetMasterAuth request.</summary>
                    public SetMasterAuthRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetMasterAuthRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to set auth. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetMasterAuthRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMasterAuth";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setMasterAuth";

                    /// <summary>Initializes SetMasterAuth parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Sets the monitoring service for a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to set monitoring. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetMonitoringRequest SetMonitoring(Google.Apis.Container.v1.Data.SetMonitoringServiceRequest body, string name)
                {
                    return new SetMonitoringRequest(service, body, name);
                }

                /// <summary>Sets the monitoring service for a specific cluster.</summary>
                public class SetMonitoringRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetMonitoring request.</summary>
                    public SetMonitoringRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetMonitoringServiceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to set monitoring. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetMonitoringServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMonitoring";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setMonitoring";

                    /// <summary>Initializes SetMonitoring parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Enables or disables Network Policy for a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster id) of the cluster to set networking policy. Specified in the
                /// format `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetNetworkPolicyRequest SetNetworkPolicy(Google.Apis.Container.v1.Data.SetNetworkPolicyRequest body, string name)
                {
                    return new SetNetworkPolicyRequest(service, body, name);
                }

                /// <summary>Enables or disables Network Policy for a cluster.</summary>
                public class SetNetworkPolicyRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetNetworkPolicy request.</summary>
                    public SetNetworkPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetNetworkPolicyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster id) of the cluster to set networking policy. Specified in
                    /// the format `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetNetworkPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setNetworkPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setNetworkPolicy";

                    /// <summary>Initializes SetNetworkPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Sets labels on a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster id) of the cluster to set labels. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual SetResourceLabelsRequest SetResourceLabels(Google.Apis.Container.v1.Data.SetLabelsRequest body, string name)
                {
                    return new SetResourceLabelsRequest(service, body, name);
                }

                /// <summary>Sets labels on a cluster.</summary>
                public class SetResourceLabelsRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetResourceLabels request.</summary>
                    public SetResourceLabelsRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetLabelsRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster id) of the cluster to set labels. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetLabelsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setResourceLabels";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setResourceLabels";

                    /// <summary>Initializes SetResourceLabels parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts master IP rotation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster id) of the cluster to start IP rotation. Specified in the
                /// format `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual StartIpRotationRequest StartIpRotation(Google.Apis.Container.v1.Data.StartIPRotationRequest body, string name)
                {
                    return new StartIpRotationRequest(service, body, name);
                }

                /// <summary>Starts master IP rotation.</summary>
                public class StartIpRotationRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new StartIpRotation request.</summary>
                    public StartIpRotationRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.StartIPRotationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster id) of the cluster to start IP rotation. Specified in the
                    /// format `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.StartIPRotationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "startIpRotation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:startIpRotation";

                    /// <summary>Initializes StartIpRotation parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the settings of a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to update. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.Container.v1.Data.UpdateClusterRequest body, string name)
                {
                    return new UpdateRequest(service, body, name);
                }

                /// <summary>Updates the settings of a specific cluster.</summary>
                public class UpdateRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.UpdateClusterRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to update. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.UpdateClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the master for a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, cluster) of the cluster to update. Specified in the format
                /// `projects/*/locations/*/clusters/*`.
                /// </param>
                public virtual UpdateMasterRequest UpdateMaster(Google.Apis.Container.v1.Data.UpdateMasterRequest body, string name)
                {
                    return new UpdateMasterRequest(service, body, name);
                }

                /// <summary>Updates the master for a specific cluster.</summary>
                public class UpdateMasterRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new UpdateMaster request.</summary>
                    public UpdateMasterRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.UpdateMasterRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to update. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.UpdateMasterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateMaster";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:updateMaster";

                    /// <summary>Initializes UpdateMaster parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
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

                /// <summary>Cancels the specified operation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The name (project, location, operation id) of the operation to cancel. Specified in the format
                /// `projects/*/locations/*/operations/*`.
                /// </param>
                public virtual CancelRequest Cancel(Google.Apis.Container.v1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>Cancels the specified operation.</summary>
                public class CancelRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, operation id) of the operation to cancel. Specified in the format
                    /// `projects/*/locations/*/operations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.CancelOperationRequest Body { get; set; }

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

                /// <summary>Gets the specified operation.</summary>
                /// <param name="name">
                /// The name (project, location, operation id) of the operation to get. Specified in the format
                /// `projects/*/locations/*/operations/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the specified operation.</summary>
                public class GetRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name (project, location, operation id) of the operation to get. Specified in the format
                    /// `projects/*/locations/*/operations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Deprecated. The server-assigned `name` of the operation. This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OperationId { get; set; }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Zone { get; set; }

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
                        RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "operationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all operations in a project in a specific zone or all zones.</summary>
                /// <param name="parent">
                /// The parent (project and location) where the operations will be listed. Specified in the format
                /// `projects/*/locations/*`. Location "-" matches all zones and all regions.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all operations in a project in a specific zone or all zones.</summary>
                public class ListRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The parent (project and location) where the operations will be listed. Specified in the format
                    /// `projects/*/locations/*`. Location "-" matches all zones and all regions.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ProjectId { get; set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for, or `-`
                    /// for all zones. This field has been deprecated and replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Zone { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/operations";

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
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Returns configuration info about the Google Kubernetes Engine service.</summary>
            /// <param name="name">
            /// The name (project and location) of the server config to get, specified in the format
            /// `projects/*/locations/*`.
            /// </param>
            public virtual GetServerConfigRequest GetServerConfig(string name)
            {
                return new GetServerConfigRequest(service, name);
            }

            /// <summary>Returns configuration info about the Google Kubernetes Engine service.</summary>
            public class GetServerConfigRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ServerConfig>
            {
                /// <summary>Constructs a new GetServerConfig request.</summary>
                public GetServerConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name (project and location) of the server config to get, specified in the format
                /// `projects/*/locations/*`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ProjectId { get; set; }

                /// <summary>
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for. This field
                /// has been deprecated and replaced by the name field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Zone { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getServerConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/serverConfig";

                /// <summary>Initializes GetServerConfig parameter list.</summary>
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
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                    {
                        Name = "zone",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Zones resource.</summary>
        public virtual ZonesResource Zones { get; }

        /// <summary>The "zones" collection of methods.</summary>
        public class ZonesResource
        {
            private const string Resource = "zones";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ZonesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Clusters = new ClustersResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Clusters resource.</summary>
            public virtual ClustersResource Clusters { get; }

            /// <summary>The "clusters" collection of methods.</summary>
            public class ClustersResource
            {
                private const string Resource = "clusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    NodePools = new NodePoolsResource(service);
                }

                /// <summary>Gets the NodePools resource.</summary>
                public virtual NodePoolsResource NodePools { get; }

                /// <summary>The "nodePools" collection of methods.</summary>
                public class NodePoolsResource
                {
                    private const string Resource = "nodePools";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public NodePoolsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Sets the autoscaling settings for the specified node pool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    /// <param name="nodePoolId">
                    /// Deprecated. The name of the node pool to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    public virtual AutoscalingRequest Autoscaling(Google.Apis.Container.v1.Data.SetNodePoolAutoscalingRequest body, string projectId, string zone, string clusterId, string nodePoolId)
                    {
                        return new AutoscalingRequest(service, body, projectId, zone, clusterId, nodePoolId);
                    }

                    /// <summary>Sets the autoscaling settings for the specified node pool.</summary>
                    public class AutoscalingRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Autoscaling request.</summary>
                        public AutoscalingRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetNodePoolAutoscalingRequest body, string projectId, string zone, string clusterId, string nodePoolId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            NodePoolId = nodePoolId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                        /// replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool to upgrade. This field has been deprecated and
                        /// replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string NodePoolId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.SetNodePoolAutoscalingRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "autoscaling";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools/{nodePoolId}/autoscaling";

                        /// <summary>Initializes Autoscaling parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Creates a node pool for a cluster.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                    /// deprecated and replaced by the parent field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the parent field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the parent
                    /// field.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Container.v1.Data.CreateNodePoolRequest body, string projectId, string zone, string clusterId)
                    {
                        return new CreateRequest(service, body, projectId, zone, clusterId);
                    }

                    /// <summary>Creates a node pool for a cluster.</summary>
                    public class CreateRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.CreateNodePoolRequest body, string projectId, string zone, string clusterId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                        /// deprecated and replaced by the parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the
                        /// parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.CreateNodePoolRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a node pool from a cluster.</summary>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                    /// deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                    /// field.
                    /// </param>
                    /// <param name="nodePoolId">
                    /// Deprecated. The name of the node pool to delete. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    public virtual DeleteRequest Delete(string projectId, string zone, string clusterId, string nodePoolId)
                    {
                        return new DeleteRequest(service, projectId, zone, clusterId, nodePoolId);
                    }

                    /// <summary>Deletes a node pool from a cluster.</summary>
                    public class DeleteRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string zone, string clusterId, string nodePoolId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            NodePoolId = nodePoolId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                        /// deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool to delete. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string NodePoolId { get; private set; }

                        /// <summary>
                        /// The name (project, location, cluster, node pool id) of the node pool to delete. Specified in
                        /// the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Name { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools/{nodePoolId}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Retrieves the requested node pool.</summary>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                    /// deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                    /// field.
                    /// </param>
                    /// <param name="nodePoolId">
                    /// Deprecated. The name of the node pool. This field has been deprecated and replaced by the name
                    /// field.
                    /// </param>
                    public virtual GetRequest Get(string projectId, string zone, string clusterId, string nodePoolId)
                    {
                        return new GetRequest(service, projectId, zone, clusterId, nodePoolId);
                    }

                    /// <summary>Retrieves the requested node pool.</summary>
                    public class GetRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.NodePool>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string projectId, string zone, string clusterId, string nodePoolId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            NodePoolId = nodePoolId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                        /// deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                        /// field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool. This field has been deprecated and replaced by the
                        /// name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string NodePoolId { get; private set; }

                        /// <summary>
                        /// The name (project, location, cluster, node pool id) of the node pool to get. Specified in
                        /// the format `projects/*/locations/*/clusters/*/nodePools/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Name { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools/{nodePoolId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists the node pools for a cluster.</summary>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                    /// deprecated and replaced by the parent field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the parent field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the parent
                    /// field.
                    /// </param>
                    public virtual ListRequest List(string projectId, string zone, string clusterId)
                    {
                        return new ListRequest(service, projectId, zone, clusterId);
                    }

                    /// <summary>Lists the node pools for a cluster.</summary>
                    public class ListRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ListNodePoolsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string projectId, string zone, string clusterId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                        /// deprecated and replaced by the parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the
                        /// parent field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>
                        /// The parent (project, location, cluster id) where the node pools will be listed. Specified in
                        /// the format `projects/*/locations/*/clusters/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Parent { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Rolls back a previously Aborted or Failed NodePool upgrade. This makes no changes if the last
                    /// upgrade successfully completed.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster to rollback. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    /// <param name="nodePoolId">
                    /// Deprecated. The name of the node pool to rollback. This field has been deprecated and replaced
                    /// by the name field.
                    /// </param>
                    public virtual RollbackRequest Rollback(Google.Apis.Container.v1.Data.RollbackNodePoolUpgradeRequest body, string projectId, string zone, string clusterId, string nodePoolId)
                    {
                        return new RollbackRequest(service, body, projectId, zone, clusterId, nodePoolId);
                    }

                    /// <summary>
                    /// Rolls back a previously Aborted or Failed NodePool upgrade. This makes no changes if the last
                    /// upgrade successfully completed.
                    /// </summary>
                    public class RollbackRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Rollback request.</summary>
                        public RollbackRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.RollbackNodePoolUpgradeRequest body, string projectId, string zone, string clusterId, string nodePoolId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            NodePoolId = nodePoolId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                        /// replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster to rollback. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool to rollback. This field has been deprecated and
                        /// replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string NodePoolId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.RollbackNodePoolUpgradeRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "rollback";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools/{nodePoolId}:rollback";

                        /// <summary>Initializes Rollback parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Sets the NodeManagement options for a node pool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    /// <param name="nodePoolId">
                    /// Deprecated. The name of the node pool to update. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    public virtual SetManagementRequest SetManagement(Google.Apis.Container.v1.Data.SetNodePoolManagementRequest body, string projectId, string zone, string clusterId, string nodePoolId)
                    {
                        return new SetManagementRequest(service, body, projectId, zone, clusterId, nodePoolId);
                    }

                    /// <summary>Sets the NodeManagement options for a node pool.</summary>
                    public class SetManagementRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new SetManagement request.</summary>
                        public SetManagementRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetNodePoolManagementRequest body, string projectId, string zone, string clusterId, string nodePoolId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            NodePoolId = nodePoolId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                        /// replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool to update. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string NodePoolId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.SetNodePoolManagementRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setManagement";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools/{nodePoolId}/setManagement";

                        /// <summary>Initializes SetManagement parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the size for a specific node pool. The new size will be used for all replicas, including
                    /// future replicas created by modifying NodePool.locations.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    /// <param name="nodePoolId">
                    /// Deprecated. The name of the node pool to update. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    public virtual SetSizeRequest SetSize(Google.Apis.Container.v1.Data.SetNodePoolSizeRequest body, string projectId, string zone, string clusterId, string nodePoolId)
                    {
                        return new SetSizeRequest(service, body, projectId, zone, clusterId, nodePoolId);
                    }

                    /// <summary>
                    /// Sets the size for a specific node pool. The new size will be used for all replicas, including
                    /// future replicas created by modifying NodePool.locations.
                    /// </summary>
                    public class SetSizeRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new SetSize request.</summary>
                        public SetSizeRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetNodePoolSizeRequest body, string projectId, string zone, string clusterId, string nodePoolId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            NodePoolId = nodePoolId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                        /// replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool to update. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string NodePoolId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.SetNodePoolSizeRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setSize";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools/{nodePoolId}/setSize";

                        /// <summary>Initializes SetSize parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Updates the version and/or image type for the specified node pool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </param>
                    /// <param name="zone">
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </param>
                    /// <param name="clusterId">
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    /// <param name="nodePoolId">
                    /// Deprecated. The name of the node pool to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </param>
                    public virtual UpdateRequest Update(Google.Apis.Container.v1.Data.UpdateNodePoolRequest body, string projectId, string zone, string clusterId, string nodePoolId)
                    {
                        return new UpdateRequest(service, body, projectId, zone, clusterId, nodePoolId);
                    }

                    /// <summary>Updates the version and/or image type for the specified node pool.</summary>
                    public class UpdateRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.UpdateNodePoolRequest body, string projectId, string zone, string clusterId, string nodePoolId) : base(service)
                        {
                            ProjectId = projectId;
                            Zone = zone;
                            ClusterId = clusterId;
                            NodePoolId = nodePoolId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Deprecated. The Google Developers Console [project ID or project
                        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                        /// replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the Google Compute Engine
                        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                        /// This field has been deprecated and replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Zone { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced
                        /// by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ClusterId { get; private set; }

                        /// <summary>
                        /// Deprecated. The name of the node pool to upgrade. This field has been deprecated and
                        /// replaced by the name field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("nodePoolId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string NodePoolId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Container.v1.Data.UpdateNodePoolRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/nodePools/{nodePoolId}/update";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                            {
                                Name = "zone",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "clusterId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("nodePoolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "nodePoolId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Sets the addons for a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual AddonsRequest Addons(Google.Apis.Container.v1.Data.SetAddonsConfigRequest body, string projectId, string zone, string clusterId)
                {
                    return new AddonsRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Sets the addons for a specific cluster.</summary>
                public class AddonsRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Addons request.</summary>
                    public AddonsRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetAddonsConfigRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetAddonsConfigRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "addons";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/addons";

                    /// <summary>Initializes Addons parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Completes master IP rotation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                /// deprecated and replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name field.
                /// </param>
                public virtual CompleteIpRotationRequest CompleteIpRotation(Google.Apis.Container.v1.Data.CompleteIPRotationRequest body, string projectId, string zone, string clusterId)
                {
                    return new CompleteIpRotationRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Completes master IP rotation.</summary>
                public class CompleteIpRotationRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new CompleteIpRotation request.</summary>
                    public CompleteIpRotationRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.CompleteIPRotationRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                    /// deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.CompleteIPRotationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "completeIpRotation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}:completeIpRotation";

                    /// <summary>Initializes CompleteIpRotation parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates a cluster, consisting of the specified number and type of Google Compute Engine instances.
                /// By default, the cluster is created in the project's [default
                /// network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks). One firewall is
                /// added for the cluster. After cluster creation, the Kubelet creates routes for each node to allow the
                /// containers on that node to communicate with all other instances in the cluster. Finally, an entry is
                /// added to the project's global metadata indicating which CIDR range the cluster is using.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the parent field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the parent field.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Container.v1.Data.CreateClusterRequest body, string projectId, string zone)
                {
                    return new CreateRequest(service, body, projectId, zone);
                }

                /// <summary>
                /// Creates a cluster, consisting of the specified number and type of Google Compute Engine instances.
                /// By default, the cluster is created in the project's [default
                /// network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks). One firewall is
                /// added for the cluster. After cluster creation, the Kubelet creates routes for each node to allow the
                /// containers on that node to communicate with all other instances in the cluster. Finally, an entry is
                /// added to the project's global metadata indicating which CIDR range the cluster is using.
                /// </summary>
                public class CreateRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.CreateClusterRequest body, string projectId, string zone) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.CreateClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes the cluster, including the Kubernetes endpoint and all worker nodes. Firewalls and routes
                /// that were configured during cluster creation are also deleted. Other Google Compute Engine resources
                /// that might be in use by the cluster, such as load balancer resources, are not deleted if they
                /// weren't present when the cluster was initially created.
                /// </summary>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to delete. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual DeleteRequest Delete(string projectId, string zone, string clusterId)
                {
                    return new DeleteRequest(service, projectId, zone, clusterId);
                }

                /// <summary>
                /// Deletes the cluster, including the Kubernetes endpoint and all worker nodes. Firewalls and routes
                /// that were configured during cluster creation are also deleted. Other Google Compute Engine resources
                /// that might be in use by the cluster, such as load balancer resources, are not deleted if they
                /// weren't present when the cluster was initially created.
                /// </summary>
                public class DeleteRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to delete. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to delete. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Name { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the details of a specific cluster.</summary>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to retrieve. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual GetRequest Get(string projectId, string zone, string clusterId)
                {
                    return new GetRequest(service, projectId, zone, clusterId);
                }

                /// <summary>Gets the details of a specific cluster.</summary>
                public class GetRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Cluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to retrieve. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>
                    /// The name (project, location, cluster) of the cluster to retrieve. Specified in the format
                    /// `projects/*/locations/*/clusters/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Name { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Enables or disables the ABAC authorization mechanism on a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual LegacyAbacRequest LegacyAbac(Google.Apis.Container.v1.Data.SetLegacyAbacRequest body, string projectId, string zone, string clusterId)
                {
                    return new LegacyAbacRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Enables or disables the ABAC authorization mechanism on a cluster.</summary>
                public class LegacyAbacRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new LegacyAbac request.</summary>
                    public LegacyAbacRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetLegacyAbacRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetLegacyAbacRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "legacyAbac";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/legacyAbac";

                    /// <summary>Initializes LegacyAbac parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all clusters owned by a project in either the specified zone or all zones.</summary>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the parent field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides, or "-"
                /// for all zones. This field has been deprecated and replaced by the parent field.
                /// </param>
                public virtual ListRequest List(string projectId, string zone)
                {
                    return new ListRequest(service, projectId, zone);
                }

                /// <summary>Lists all clusters owned by a project in either the specified zone or all zones.</summary>
                public class ListRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ListClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectId, string zone) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides, or
                    /// "-" for all zones. This field has been deprecated and replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// The parent (project and location) where the clusters will be listed. Specified in the format
                    /// `projects/*/locations/*`. Location "-" matches all zones and all regions.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Parent { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets the locations for a specific cluster. Deprecated. Use
                /// [projects.locations.clusters.update](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters/update)
                /// instead.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual LocationsRequest Locations(Google.Apis.Container.v1.Data.SetLocationsRequest body, string projectId, string zone, string clusterId)
                {
                    return new LocationsRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>
                /// Sets the locations for a specific cluster. Deprecated. Use
                /// [projects.locations.clusters.update](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters/update)
                /// instead.
                /// </summary>
                public class LocationsRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Locations request.</summary>
                    public LocationsRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetLocationsRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetLocationsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "locations";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/locations";

                    /// <summary>Initializes Locations parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Sets the logging service for a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual LoggingRequest Logging(Google.Apis.Container.v1.Data.SetLoggingServiceRequest body, string projectId, string zone, string clusterId)
                {
                    return new LoggingRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Sets the logging service for a specific cluster.</summary>
                public class LoggingRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Logging request.</summary>
                    public LoggingRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetLoggingServiceRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetLoggingServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "logging";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/logging";

                    /// <summary>Initializes Logging parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates the master for a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual MasterRequest Master(Google.Apis.Container.v1.Data.UpdateMasterRequest body, string projectId, string zone, string clusterId)
                {
                    return new MasterRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Updates the master for a specific cluster.</summary>
                public class MasterRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Master request.</summary>
                    public MasterRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.UpdateMasterRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.UpdateMasterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "master";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/master";

                    /// <summary>Initializes Master parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Sets the monitoring service for a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual MonitoringRequest Monitoring(Google.Apis.Container.v1.Data.SetMonitoringServiceRequest body, string projectId, string zone, string clusterId)
                {
                    return new MonitoringRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Sets the monitoring service for a specific cluster.</summary>
                public class MonitoringRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Monitoring request.</summary>
                    public MonitoringRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetMonitoringServiceRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetMonitoringServiceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "monitoring";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/monitoring";

                    /// <summary>Initializes Monitoring parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Sets labels on a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                /// deprecated and replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name field.
                /// </param>
                public virtual ResourceLabelsRequest ResourceLabels(Google.Apis.Container.v1.Data.SetLabelsRequest body, string projectId, string zone, string clusterId)
                {
                    return new ResourceLabelsRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Sets labels on a cluster.</summary>
                public class ResourceLabelsRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ResourceLabels request.</summary>
                    public ResourceLabelsRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetLabelsRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                    /// deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetLabelsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resourceLabels";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}/resourceLabels";

                    /// <summary>Initializes ResourceLabels parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Sets the maintenance policy for a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840).
                /// </param>
                /// <param name="zone">
                /// Required. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                /// </param>
                /// <param name="clusterId">Required. The name of the cluster to update.</param>
                public virtual SetMaintenancePolicyRequest SetMaintenancePolicy(Google.Apis.Container.v1.Data.SetMaintenancePolicyRequest body, string projectId, string zone, string clusterId)
                {
                    return new SetMaintenancePolicyRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Sets the maintenance policy for a cluster.</summary>
                public class SetMaintenancePolicyRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetMaintenancePolicy request.</summary>
                    public SetMaintenancePolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetMaintenancePolicyRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Required. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>Required. The name of the cluster to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetMaintenancePolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMaintenancePolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}:setMaintenancePolicy";

                    /// <summary>Initializes SetMaintenancePolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets master auth materials. Currently supports changing the admin password or a specific cluster,
                /// either via password generation or explicitly setting the password.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual SetMasterAuthRequest SetMasterAuth(Google.Apis.Container.v1.Data.SetMasterAuthRequest body, string projectId, string zone, string clusterId)
                {
                    return new SetMasterAuthRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>
                /// Sets master auth materials. Currently supports changing the admin password or a specific cluster,
                /// either via password generation or explicitly setting the password.
                /// </summary>
                public class SetMasterAuthRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetMasterAuth request.</summary>
                    public SetMasterAuthRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetMasterAuthRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetMasterAuthRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMasterAuth";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}:setMasterAuth";

                    /// <summary>Initializes SetMasterAuth parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Enables or disables Network Policy for a cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                /// deprecated and replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name field.
                /// </param>
                public virtual SetNetworkPolicyRequest SetNetworkPolicy(Google.Apis.Container.v1.Data.SetNetworkPolicyRequest body, string projectId, string zone, string clusterId)
                {
                    return new SetNetworkPolicyRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Enables or disables Network Policy for a cluster.</summary>
                public class SetNetworkPolicyRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new SetNetworkPolicy request.</summary>
                    public SetNetworkPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.SetNetworkPolicyRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                    /// deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.SetNetworkPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setNetworkPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}:setNetworkPolicy";

                    /// <summary>Initializes SetNetworkPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Starts master IP rotation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                /// deprecated and replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name field.
                /// </param>
                public virtual StartIpRotationRequest StartIpRotation(Google.Apis.Container.v1.Data.StartIPRotationRequest body, string projectId, string zone, string clusterId)
                {
                    return new StartIpRotationRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Starts master IP rotation.</summary>
                public class StartIpRotationRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new StartIpRotation request.</summary>
                    public StartIpRotationRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.StartIPRotationRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been
                    /// deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.StartIPRotationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "startIpRotation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}:startIpRotation";

                    /// <summary>Initializes StartIpRotation parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates the settings of a specific cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="clusterId">
                /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the
                /// name field.
                /// </param>
                public virtual UpdateRequest Update(Google.Apis.Container.v1.Data.UpdateClusterRequest body, string projectId, string zone, string clusterId)
                {
                    return new UpdateRequest(service, body, projectId, zone, clusterId);
                }

                /// <summary>Updates the settings of a specific cluster.</summary>
                public class UpdateRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.UpdateClusterRequest body, string projectId, string zone, string clusterId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        ClusterId = clusterId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by
                    /// the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ClusterId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.UpdateClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/clusters/{clusterId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = true,
                            ParameterType = "path",
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

                /// <summary>Cancels the specified operation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the operation resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="operationId">
                /// Deprecated. The server-assigned `name` of the operation. This field has been deprecated and replaced
                /// by the name field.
                /// </param>
                public virtual CancelRequest Cancel(Google.Apis.Container.v1.Data.CancelOperationRequest body, string projectId, string zone, string operationId)
                {
                    return new CancelRequest(service, body, projectId, zone, operationId);
                }

                /// <summary>Cancels the specified operation.</summary>
                public class CancelRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Container.v1.Data.CancelOperationRequest body, string projectId, string zone, string operationId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        OperationId = operationId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the operation resides.
                    /// This field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The server-assigned `name` of the operation. This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string OperationId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Container.v1.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/operations/{operationId}:cancel";

                    /// <summary>Initializes Cancel parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "operationId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the specified operation.</summary>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                /// field has been deprecated and replaced by the name field.
                /// </param>
                /// <param name="operationId">
                /// Deprecated. The server-assigned `name` of the operation. This field has been deprecated and replaced
                /// by the name field.
                /// </param>
                public virtual GetRequest Get(string projectId, string zone, string operationId)
                {
                    return new GetRequest(service, projectId, zone, operationId);
                }

                /// <summary>Gets the specified operation.</summary>
                public class GetRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectId, string zone, string operationId) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        OperationId = operationId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This
                    /// field has been deprecated and replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// Deprecated. The server-assigned `name` of the operation. This field has been deprecated and
                    /// replaced by the name field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string OperationId { get; private set; }

                    /// <summary>
                    /// The name (project, location, operation id) of the operation to get. Specified in the format
                    /// `projects/*/locations/*/operations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Name { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/operations/{operationId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "operationId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all operations in a project in a specific zone or all zones.</summary>
                /// <param name="projectId">
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the parent field.
                /// </param>
                /// <param name="zone">
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for, or `-` for
                /// all zones. This field has been deprecated and replaced by the parent field.
                /// </param>
                public virtual ListRequest List(string projectId, string zone)
                {
                    return new ListRequest(service, projectId, zone);
                }

                /// <summary>Lists all operations in a project in a specific zone or all zones.</summary>
                public class ListRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectId, string zone) : base(service)
                    {
                        ProjectId = projectId;
                        Zone = zone;
                        InitParameters();
                    }

                    /// <summary>
                    /// Deprecated. The Google Developers Console [project ID or project
                    /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                    /// replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Deprecated. The name of the Google Compute Engine
                    /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for, or `-`
                    /// for all zones. This field has been deprecated and replaced by the parent field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Zone { get; private set; }

                    /// <summary>
                    /// The parent (project and location) where the operations will be listed. Specified in the format
                    /// `projects/*/locations/*`. Location "-" matches all zones and all regions.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Parent { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/projects/{projectId}/zones/{zone}/operations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                        {
                            Name = "zone",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Returns configuration info about the Google Kubernetes Engine service.</summary>
            /// <param name="projectId">
            /// Deprecated. The Google Developers Console [project ID or project
            /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by
            /// the name field.
            /// </param>
            /// <param name="zone">
            /// Deprecated. The name of the Google Compute Engine
            /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for. This field has
            /// been deprecated and replaced by the name field.
            /// </param>
            public virtual GetServerconfigRequest GetServerconfig(string projectId, string zone)
            {
                return new GetServerconfigRequest(service, projectId, zone);
            }

            /// <summary>Returns configuration info about the Google Kubernetes Engine service.</summary>
            public class GetServerconfigRequest : ContainerBaseServiceRequest<Google.Apis.Container.v1.Data.ServerConfig>
            {
                /// <summary>Constructs a new GetServerconfig request.</summary>
                public GetServerconfigRequest(Google.Apis.Services.IClientService service, string projectId, string zone) : base(service)
                {
                    ProjectId = projectId;
                    Zone = zone;
                    InitParameters();
                }

                /// <summary>
                /// Deprecated. The Google Developers Console [project ID or project
                /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and
                /// replaced by the name field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// Deprecated. The name of the Google Compute Engine
                /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for. This field
                /// has been deprecated and replaced by the name field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("zone", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Zone { get; private set; }

                /// <summary>
                /// The name (project and location) of the server config to get, specified in the format
                /// `projects/*/locations/*`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Name { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getServerconfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/zones/{zone}/serverconfig";

                /// <summary>Initializes GetServerconfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("zone", new Google.Apis.Discovery.Parameter
                    {
                        Name = "zone",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
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
namespace Google.Apis.Container.v1.Data
{
    /// <summary>AcceleratorConfig represents a Hardware Accelerator request.</summary>
    public class AcceleratorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of the accelerator cards exposed to an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorCount")]
        public virtual System.Nullable<long> AcceleratorCount { get; set; }

        /// <summary>
        /// The accelerator type resource name. List of supported accelerators
        /// [here](https://cloud.google.com/compute/docs/gpus)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceleratorType")]
        public virtual string AcceleratorType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for the addons that can be automatically spun up in the cluster, enabling additional
    /// functionality.
    /// </summary>
    public class AddonsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Configuration for the Cloud Run addon, which allows the user to use a managed Knative service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRunConfig")]
        public virtual CloudRunConfig CloudRunConfig { get; set; }

        /// <summary>
        /// Configuration for the ConfigConnector add-on, a Kubernetes extension to manage hosted GCP services through
        /// the Kubernetes API
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configConnectorConfig")]
        public virtual ConfigConnectorConfig ConfigConnectorConfig { get; set; }

        /// <summary>Configuration for NodeLocalDNS, a dns cache running on cluster nodes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsCacheConfig")]
        public virtual DnsCacheConfig DnsCacheConfig { get; set; }

        /// <summary>Configuration for the Compute Engine Persistent Disk CSI driver.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcePersistentDiskCsiDriverConfig")]
        public virtual GcePersistentDiskCsiDriverConfig GcePersistentDiskCsiDriverConfig { get; set; }

        /// <summary>
        /// Configuration for the horizontal pod autoscaling feature, which increases or decreases the number of replica
        /// pods a replication controller has based on the resource usage of the existing pods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalPodAutoscaling")]
        public virtual HorizontalPodAutoscaling HorizontalPodAutoscaling { get; set; }

        /// <summary>
        /// Configuration for the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load
        /// balancers for services in a cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpLoadBalancing")]
        public virtual HttpLoadBalancing HttpLoadBalancing { get; set; }

        /// <summary>
        /// Configuration for the Kubernetes Dashboard. This addon is deprecated, and will be disabled in 1.15. It is
        /// recommended to use the Cloud Console to manage and monitor your Kubernetes clusters, workloads and
        /// applications. For more information, see: https://cloud.google.com/kubernetes-engine/docs/concepts/dashboards
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesDashboard")]
        public virtual KubernetesDashboard KubernetesDashboard { get; set; }

        /// <summary>
        /// Configuration for NetworkPolicy. This only tracks whether the addon is enabled or not on the Master, it does
        /// not track whether network policy is enabled for the nodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkPolicyConfig")]
        public virtual NetworkPolicyConfig NetworkPolicyConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for returning group information from authenticators.</summary>
    public class AuthenticatorGroupsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether this cluster should return group membership lookups during authentication using a group of security
        /// groups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The name of the security group-of-groups to be used. Only relevant if enabled = true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityGroup")]
        public virtual string SecurityGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AutoUpgradeOptions defines the set of options for the user to control how the Auto Upgrades will proceed.
    /// </summary>
    public class AutoUpgradeOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output only] This field is set when upgrades are about to commence with the approximate start time for the
        /// upgrades, in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoUpgradeStartTime")]
        public virtual string AutoUpgradeStartTime { get; set; }

        /// <summary>
        /// [Output only] This field is set when upgrades are about to commence with the description of the upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Autopilot is the configuration for Autopilot settings on the cluster.</summary>
    public class Autopilot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable Autopilot</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AutoprovisioningNodePoolDefaults contains defaults for a node pool created by NAP.</summary>
    public class AutoprovisioningNodePoolDefaults : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
        /// This should be of the form
        /// projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more
        /// information about protecting resources with Cloud KMS Keys please see:
        /// https://cloud.google.com/compute/docs/disks/customer-managed-encryption
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskKmsKey")]
        public virtual string BootDiskKmsKey { get; set; }

        /// <summary>
        /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. If
        /// unspecified, the default disk size is 100GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<int> DiskSizeGb { get; set; }

        /// <summary>
        /// Type of the disk attached to each node (e.g. 'pd-standard', 'pd-ssd' or 'pd-balanced') If unspecified, the
        /// default disk type is 'pd-standard'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>The image type to use for NAP created node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>Specifies the node management options for NAP created node-pools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("management")]
        public virtual NodeManagement Management { get; set; }

        /// <summary>
        /// Minimum CPU platform to be used for NAP created node pools. The instance may be scheduled on the specified
        /// or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as minCpuPlatform:
        /// Intel Haswell or minCpuPlatform: Intel Sandy Bridge. For more information, read [how to specify min CPU
        /// platform](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform) To unset the min cpu
        /// platform field pass "automatic" as field value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuPlatform")]
        public virtual string MinCpuPlatform { get; set; }

        /// <summary>Scopes that are used by NAP when creating node pools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthScopes")]
        public virtual System.Collections.Generic.IList<string> OauthScopes { get; set; }

        /// <summary>The Google Cloud Platform Service Account to be used by the node VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Shielded Instance options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual ShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>Specifies the upgrade settings for NAP created node pools</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeSettings")]
        public virtual UpgradeSettings UpgradeSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
    public class BigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of a BigQuery Dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for Binary Authorization.</summary>
    public class BinaryAuthorization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enable Binary Authorization for this cluster. If enabled, all container images will be validated by Binary
        /// Authorization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CancelOperationRequest cancels a single operation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name (project, location, operation id) of the operation to cancel. Specified in the format
        /// `projects/*/locations/*/operations/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The server-assigned `name` of the operation. This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the operation resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CidrBlock contains an optional name and one CIDR block.</summary>
    public class CidrBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>cidr_block must be specified in CIDR notation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidrBlock")]
        public virtual string CidrBlockValue { get; set; }

        /// <summary>display_name is an optional field for users to identify CIDR blocks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for client certificates on the cluster.</summary>
    public class ClientCertificateConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Issue a client certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueClientCertificate")]
        public virtual System.Nullable<bool> IssueClientCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for the Cloud Run feature.</summary>
    public class CloudRunConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Cloud Run addon is enabled for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Which load balancer type is installed for Cloud Run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerType")]
        public virtual string LoadBalancerType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Google Kubernetes Engine cluster.</summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configurations for the various addons available to run in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addonsConfig")]
        public virtual AddonsConfig AddonsConfig { get; set; }

        /// <summary>Configuration controlling RBAC group membership information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticatorGroupsConfig")]
        public virtual AuthenticatorGroupsConfig AuthenticatorGroupsConfig { get; set; }

        /// <summary>Autopilot configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autopilot")]
        public virtual Autopilot Autopilot { get; set; }

        /// <summary>Cluster-level autoscaling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscaling")]
        public virtual ClusterAutoscaling Autoscaling { get; set; }

        /// <summary>Configuration for Binary Authorization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>
        /// The IP address range of the container pods in this cluster, in
        /// [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g. `10.96.0.0/14`). Leave
        /// blank to have one automatically chosen or specify a `/14` block in `10.0.0.0/8`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterIpv4Cidr")]
        public virtual string ClusterIpv4Cidr { get; set; }

        /// <summary>Which conditions caused the current cluster state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<StatusCondition> Conditions { get; set; }

        /// <summary>Configuration of Confidential Nodes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialNodes")]
        public virtual ConfidentialNodes ConfidentialNodes { get; set; }

        /// <summary>
        /// [Output only] The time the cluster was created, in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTime { get; set; }

        /// <summary>[Output only] The current software version of the master endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentMasterVersion")]
        public virtual string CurrentMasterVersion { get; set; }

        /// <summary>
        /// [Output only] The number of nodes currently in the cluster. Deprecated. Call Kubernetes API directly to
        /// retrieve node information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentNodeCount")]
        public virtual System.Nullable<int> CurrentNodeCount { get; set; }

        /// <summary>
        /// [Output only] Deprecated, use
        /// [NodePools.version](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters.nodePools)
        /// instead. The current version of the node software components. If they are currently at multiple versions
        /// because they're in the process of being upgraded, this reflects the minimum version of all nodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentNodeVersion")]
        public virtual string CurrentNodeVersion { get; set; }

        /// <summary>Configuration of etcd encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseEncryption")]
        public virtual DatabaseEncryption DatabaseEncryption { get; set; }

        /// <summary>
        /// The default constraint on the maximum number of pods that can be run simultaneously on a node in the node
        /// pool of this cluster. Only honored if cluster created with IP Alias support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMaxPodsConstraint")]
        public virtual MaxPodsConstraint DefaultMaxPodsConstraint { get; set; }

        /// <summary>An optional description of this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Kubernetes alpha features are enabled on this cluster. This includes alpha API groups (e.g. v1alpha1) and
        /// features that may not be production ready in the kubernetes version of the master and nodes. The cluster has
        /// no SLA for uptime and master/node upgrades are disabled. Alpha enabled clusters are automatically deleted
        /// thirty days after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableKubernetesAlpha")]
        public virtual System.Nullable<bool> EnableKubernetesAlpha { get; set; }

        /// <summary>Enable the ability to use Cloud TPUs in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableTpu")]
        public virtual System.Nullable<bool> EnableTpu { get; set; }

        /// <summary>
        /// [Output only] The IP address of this cluster's master endpoint. The endpoint can be accessed from the
        /// internet at `https://username:password@endpoint/`. See the `masterAuth` property of this resource for
        /// username and password information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// [Output only] The time the cluster will be automatically deleted in
        /// [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTime { get; set; }

        /// <summary>Output only. Unique id for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The initial Kubernetes version for this cluster. Valid versions are those found in validMasterVersions
        /// returned by getServerConfig. The version can be upgraded over time; such upgrades are reflected in
        /// currentMasterVersion and currentNodeVersion. Users may specify either explicit versions offered by
        /// Kubernetes Engine or version aliases, which have the following behavior: - "latest": picks the highest valid
        /// Kubernetes version - "1.X": picks the highest valid patch+gke.N patch in the 1.X version - "1.X.Y": picks
        /// the highest valid gke.N patch in the 1.X.Y version - "1.X.Y-gke.N": picks an explicit Kubernetes version -
        /// "","-": picks the default Kubernetes version
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialClusterVersion")]
        public virtual string InitialClusterVersion { get; set; }

        /// <summary>
        /// The number of nodes to create in this cluster. You must ensure that your Compute Engine [resource
        /// quota](https://cloud.google.com/compute/quotas) is sufficient for this number of instances. You must also
        /// have available firewall and routes quota. For requests, this field should only be used in lieu of a
        /// "node_pool" object, since this configuration (along with the "node_config") will be used to create a
        /// "NodePool" object with an auto-generated name. Do not use this and a node_pool at the same time. This field
        /// is deprecated, use node_pool.initial_node_count instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialNodeCount")]
        public virtual System.Nullable<int> InitialNodeCount { get; set; }

        /// <summary>Deprecated. Use node_pools.instance_group_urls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceGroupUrls")]
        public virtual System.Collections.Generic.IList<string> InstanceGroupUrls { get; set; }

        /// <summary>Configuration for cluster IP allocation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAllocationPolicy")]
        public virtual IPAllocationPolicy IpAllocationPolicy { get; set; }

        /// <summary>The fingerprint of the set of labels for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelFingerprint")]
        public virtual string LabelFingerprint { get; set; }

        /// <summary>Configuration for the legacy ABAC authorization mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyAbac")]
        public virtual LegacyAbac LegacyAbac { get; set; }

        /// <summary>
        /// [Output only] The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/regions-zones/regions-zones#available) or
        /// [region](https://cloud.google.com/compute/docs/regions-zones/regions-zones#available) in which the cluster
        /// resides.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The list of Google Compute Engine [zones](https://cloud.google.com/compute/docs/zones#available) in which
        /// the cluster's nodes should be located. This field provides a default value if
        /// [NodePool.Locations](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters.nodePools#NodePool.FIELDS.locations)
        /// are not specified during node pool creation. Warning: changing cluster locations will update the
        /// [NodePool.Locations](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters.nodePools#NodePool.FIELDS.locations)
        /// of all node pools and will result in nodes being added and/or removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<string> Locations { get; set; }

        /// <summary>
        /// The logging service the cluster should use to write logs. Currently available options: *
        /// `logging.googleapis.com/kubernetes` - The Cloud Logging service with a Kubernetes-native resource model *
        /// `logging.googleapis.com` - The legacy Cloud Logging service (no longer available as of GKE 1.15). * `none` -
        /// no logs will be exported from the cluster. If left as an empty string,`logging.googleapis.com/kubernetes`
        /// will be used for GKE 1.14+ or `logging.googleapis.com` for earlier versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingService")]
        public virtual string LoggingService { get; set; }

        /// <summary>Configure the maintenance policy for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicy")]
        public virtual MaintenancePolicy MaintenancePolicy { get; set; }

        /// <summary>
        /// The authentication information for accessing the master endpoint. If unspecified, the defaults are used: For
        /// clusters before v1.12, if master_auth is unspecified, `username` will be set to "admin", a random password
        /// will be generated, and a client certificate will be issued.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterAuth")]
        public virtual MasterAuth MasterAuth { get; set; }

        /// <summary>The configuration options for master authorized networks feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterAuthorizedNetworksConfig")]
        public virtual MasterAuthorizedNetworksConfig MasterAuthorizedNetworksConfig { get; set; }

        /// <summary>
        /// The monitoring service the cluster should use to write metrics. Currently available options: *
        /// "monitoring.googleapis.com/kubernetes" - The Cloud Monitoring service with a Kubernetes-native resource
        /// model * `monitoring.googleapis.com` - The legacy Cloud Monitoring service (no longer available as of GKE
        /// 1.15). * `none` - No metrics will be exported from the cluster. If left as an empty
        /// string,`monitoring.googleapis.com/kubernetes` will be used for GKE 1.14+ or `monitoring.googleapis.com` for
        /// earlier versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoringService")]
        public virtual string MonitoringService { get; set; }

        /// <summary>
        /// The name of this cluster. The name must be unique within this project and location (e.g. zone or region),
        /// and can be up to 40 characters with the following restrictions: * Lowercase letters, numbers, and hyphens
        /// only. * Must start with a letter. * Must end with a number or a letter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the Google Compute Engine
        /// [network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks) to which the cluster is
        /// connected. If left unspecified, the `default` network will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Configuration for cluster networking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual NetworkConfig NetworkConfig { get; set; }

        /// <summary>Configuration options for the NetworkPolicy feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkPolicy")]
        public virtual NetworkPolicy NetworkPolicy { get; set; }

        /// <summary>
        /// Parameters used in creating the cluster's nodes. For requests, this field should only be used in lieu of a
        /// "node_pool" object, since this configuration (along with the "initial_node_count") will be used to create a
        /// "NodePool" object with an auto-generated name. Do not use this and a node_pool at the same time. For
        /// responses, this field will be populated with the node configuration of the first node pool. (For
        /// configuration of each node pool, see `node_pool.config`) If unspecified, the defaults are used. This field
        /// is deprecated, use node_pool.config instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeConfig")]
        public virtual NodeConfig NodeConfig { get; set; }

        /// <summary>
        /// [Output only] The size of the address space on each node for hosting containers. This is provisioned from
        /// within the `container_ipv4_cidr` range. This field will only be set when cluster is in route-based network
        /// mode.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeIpv4CidrSize")]
        public virtual System.Nullable<int> NodeIpv4CidrSize { get; set; }

        /// <summary>
        /// The node pools associated with this cluster. This field should not be set if "node_config" or
        /// "initial_node_count" are specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePools")]
        public virtual System.Collections.Generic.IList<NodePool> NodePools { get; set; }

        /// <summary>Notification configuration of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfig")]
        public virtual NotificationConfig NotificationConfig { get; set; }

        /// <summary>Configuration for private cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateClusterConfig")]
        public virtual PrivateClusterConfig PrivateClusterConfig { get; set; }

        /// <summary>Release channel configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseChannel")]
        public virtual ReleaseChannel ReleaseChannel { get; set; }

        /// <summary>
        /// The resource labels for the cluster to use to annotate any related Google Compute Engine resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceLabels { get; set; }

        /// <summary>
        /// Configuration for exporting resource usages. Resource usage export is disabled when this config is
        /// unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUsageExportConfig")]
        public virtual ResourceUsageExportConfig ResourceUsageExportConfig { get; set; }

        /// <summary>[Output only] Server-defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// [Output only] The IP address range of the Kubernetes services in this cluster, in
        /// [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g. `1.2.3.4/29`). Service
        /// addresses are typically put in the last `/16` from the container CIDR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesIpv4Cidr")]
        public virtual string ServicesIpv4Cidr { get; set; }

        /// <summary>Shielded Nodes configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedNodes")]
        public virtual ShieldedNodes ShieldedNodes { get; set; }

        /// <summary>[Output only] The current status of this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// [Output only] Deprecated. Use conditions instead. Additional information about the current status of this
        /// cluster, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>
        /// The name of the Google Compute Engine [subnetwork](https://cloud.google.com/compute/docs/subnetworks) to
        /// which the cluster is connected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// [Output only] The IP address range of the Cloud TPUs in this cluster, in
        /// [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g. `1.2.3.4/29`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpuIpv4CidrBlock")]
        public virtual string TpuIpv4CidrBlock { get; set; }

        /// <summary>Cluster-level Vertical Pod Autoscaling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticalPodAutoscaling")]
        public virtual VerticalPodAutoscaling VerticalPodAutoscaling { get; set; }

        /// <summary>Configuration for the use of Kubernetes Service Accounts in GCP IAM policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadIdentityConfig")]
        public virtual WorkloadIdentityConfig WorkloadIdentityConfig { get; set; }

        /// <summary>
        /// [Output only] The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field is
        /// deprecated, use location instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ClusterAutoscaling contains global, per-cluster information required by Cluster Autoscaler to automatically
    /// adjust the size of the cluster and create/delete node pools based on the current needs.
    /// </summary>
    public class ClusterAutoscaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of Google Compute Engine [zones](https://cloud.google.com/compute/docs/zones#available) in which
        /// the NodePool's nodes can be created by NAP.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoprovisioningLocations")]
        public virtual System.Collections.Generic.IList<string> AutoprovisioningLocations { get; set; }

        /// <summary>AutoprovisioningNodePoolDefaults contains defaults for a node pool created by NAP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoprovisioningNodePoolDefaults")]
        public virtual AutoprovisioningNodePoolDefaults AutoprovisioningNodePoolDefaults { get; set; }

        /// <summary>Enables automatic node pool creation and deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableNodeAutoprovisioning")]
        public virtual System.Nullable<bool> EnableNodeAutoprovisioning { get; set; }

        /// <summary>
        /// Contains global constraints regarding minimum and maximum amount of resources in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLimits")]
        public virtual System.Collections.Generic.IList<ResourceLimit> ResourceLimits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ClusterUpdate describes an update to the cluster. Exactly one update can be applied to a cluster with each
    /// request, so at most one field can be provided.
    /// </summary>
    public class ClusterUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configurations for the various addons available to run in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredAddonsConfig")]
        public virtual AddonsConfig DesiredAddonsConfig { get; set; }

        /// <summary>The desired authenticator groups config for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredAuthenticatorGroupsConfig")]
        public virtual AuthenticatorGroupsConfig DesiredAuthenticatorGroupsConfig { get; set; }

        /// <summary>The desired Autopilot configuration for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredAutopilot")]
        public virtual Autopilot DesiredAutopilot { get; set; }

        /// <summary>The desired configuration options for the Binary Authorization feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredBinaryAuthorization")]
        public virtual BinaryAuthorization DesiredBinaryAuthorization { get; set; }

        /// <summary>Cluster-level autoscaling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredClusterAutoscaling")]
        public virtual ClusterAutoscaling DesiredClusterAutoscaling { get; set; }

        /// <summary>Configuration of etcd encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredDatabaseEncryption")]
        public virtual DatabaseEncryption DesiredDatabaseEncryption { get; set; }

        /// <summary>The desired datapath provider for the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredDatapathProvider")]
        public virtual string DesiredDatapathProvider { get; set; }

        /// <summary>The desired status of whether to disable default sNAT for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredDefaultSnatStatus")]
        public virtual DefaultSnatStatus DesiredDefaultSnatStatus { get; set; }

        /// <summary>
        /// The desired image type for the node pool. NOTE: Set the "desired_node_pool" field as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredImageType")]
        public virtual string DesiredImageType { get; set; }

        /// <summary>The desired config of Intra-node visibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredIntraNodeVisibilityConfig")]
        public virtual IntraNodeVisibilityConfig DesiredIntraNodeVisibilityConfig { get; set; }

        /// <summary>The desired L4 Internal Load Balancer Subsetting configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredL4ilbSubsettingConfig")]
        public virtual ILBSubsettingConfig DesiredL4ilbSubsettingConfig { get; set; }

        /// <summary>
        /// The desired list of Google Compute Engine [zones](https://cloud.google.com/compute/docs/zones#available) in
        /// which the cluster's nodes should be located. This list must always include the cluster's primary zone.
        /// Warning: changing cluster locations will update the locations of all node pools and will result in nodes
        /// being added and/or removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredLocations")]
        public virtual System.Collections.Generic.IList<string> DesiredLocations { get; set; }

        /// <summary>
        /// The logging service the cluster should use to write logs. Currently available options: *
        /// `logging.googleapis.com/kubernetes` - The Cloud Logging service with a Kubernetes-native resource model *
        /// `logging.googleapis.com` - The legacy Cloud Logging service (no longer available as of GKE 1.15). * `none` -
        /// no logs will be exported from the cluster. If left as an empty string,`logging.googleapis.com/kubernetes`
        /// will be used for GKE 1.14+ or `logging.googleapis.com` for earlier versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredLoggingService")]
        public virtual string DesiredLoggingService { get; set; }

        /// <summary>The desired configuration options for master authorized networks feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredMasterAuthorizedNetworksConfig")]
        public virtual MasterAuthorizedNetworksConfig DesiredMasterAuthorizedNetworksConfig { get; set; }

        /// <summary>
        /// The Kubernetes version to change the master to. Users may specify either explicit versions offered by
        /// Kubernetes Engine or version aliases, which have the following behavior: - "latest": picks the highest valid
        /// Kubernetes version - "1.X": picks the highest valid patch+gke.N patch in the 1.X version - "1.X.Y": picks
        /// the highest valid gke.N patch in the 1.X.Y version - "1.X.Y-gke.N": picks an explicit Kubernetes version -
        /// "-": picks the default Kubernetes version
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredMasterVersion")]
        public virtual string DesiredMasterVersion { get; set; }

        /// <summary>
        /// The monitoring service the cluster should use to write metrics. Currently available options: *
        /// "monitoring.googleapis.com/kubernetes" - The Cloud Monitoring service with a Kubernetes-native resource
        /// model * `monitoring.googleapis.com` - The legacy Cloud Monitoring service (no longer available as of GKE
        /// 1.15). * `none` - No metrics will be exported from the cluster. If left as an empty
        /// string,`monitoring.googleapis.com/kubernetes` will be used for GKE 1.14+ or `monitoring.googleapis.com` for
        /// earlier versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredMonitoringService")]
        public virtual string DesiredMonitoringService { get; set; }

        /// <summary>
        /// Autoscaler configuration for the node pool specified in desired_node_pool_id. If there is only one pool in
        /// the cluster and desired_node_pool_id is not provided then the change applies to that single node pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredNodePoolAutoscaling")]
        public virtual NodePoolAutoscaling DesiredNodePoolAutoscaling { get; set; }

        /// <summary>
        /// The node pool to be upgraded. This field is mandatory if "desired_node_version", "desired_image_family" or
        /// "desired_node_pool_autoscaling" is specified and there is more than one node pool on the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredNodePoolId")]
        public virtual string DesiredNodePoolId { get; set; }

        /// <summary>
        /// The Kubernetes version to change the nodes to (typically an upgrade). Users may specify either explicit
        /// versions offered by Kubernetes Engine or version aliases, which have the following behavior: - "latest":
        /// picks the highest valid Kubernetes version - "1.X": picks the highest valid patch+gke.N patch in the 1.X
        /// version - "1.X.Y": picks the highest valid gke.N patch in the 1.X.Y version - "1.X.Y-gke.N": picks an
        /// explicit Kubernetes version - "-": picks the Kubernetes master version
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredNodeVersion")]
        public virtual string DesiredNodeVersion { get; set; }

        /// <summary>The desired notification configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredNotificationConfig")]
        public virtual NotificationConfig DesiredNotificationConfig { get; set; }

        /// <summary>The desired private cluster configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredPrivateClusterConfig")]
        public virtual PrivateClusterConfig DesiredPrivateClusterConfig { get; set; }

        /// <summary>The desired state of IPv6 connectivity to Google Services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredPrivateIpv6GoogleAccess")]
        public virtual string DesiredPrivateIpv6GoogleAccess { get; set; }

        /// <summary>The desired release channel configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredReleaseChannel")]
        public virtual ReleaseChannel DesiredReleaseChannel { get; set; }

        /// <summary>The desired configuration for exporting resource usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredResourceUsageExportConfig")]
        public virtual ResourceUsageExportConfig DesiredResourceUsageExportConfig { get; set; }

        /// <summary>Configuration for Shielded Nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredShieldedNodes")]
        public virtual ShieldedNodes DesiredShieldedNodes { get; set; }

        /// <summary>Cluster-level Vertical Pod Autoscaling configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredVerticalPodAutoscaling")]
        public virtual VerticalPodAutoscaling DesiredVerticalPodAutoscaling { get; set; }

        /// <summary>Configuration for Workload Identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredWorkloadIdentityConfig")]
        public virtual WorkloadIdentityConfig DesiredWorkloadIdentityConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CompleteIPRotationRequest moves the cluster master back into single-IP mode.</summary>
    public class CompleteIPRotationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster id) of the cluster to complete IP rotation. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been deprecated and
        /// replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ConfidentialNodes is configuration for the confidential nodes feature, which makes nodes run on confidential
    /// VMs.
    /// </summary>
    public class ConfidentialNodes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Confidential Nodes feature is enabled for all nodes in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for the Config Connector add-on.</summary>
    public class ConfigConnectorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Cloud Connector is enabled for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters for controlling consumption metering.</summary>
    public class ConsumptionMeteringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to enable consumption metering for this cluster. If enabled, a second BigQuery table will be created
        /// to hold resource consumption records.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CreateClusterRequest creates a cluster.</summary>
    public class CreateClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A [cluster
        /// resource](https://cloud.google.com/container-engine/reference/rest/v1/projects.locations.clusters)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual Cluster Cluster { get; set; }

        /// <summary>
        /// The parent (project and location) where the cluster will be created. Specified in the format
        /// `projects/*/locations/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// parent field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the parent field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CreateNodePoolRequest creates a node pool for a cluster.</summary>
    public class CreateNodePoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the parent field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>Required. The node pool to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePool")]
        public virtual NodePool NodePool { get; set; }

        /// <summary>
        /// The parent (project, location, cluster id) where the node pool will be created. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been deprecated and
        /// replaced by the parent field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the parent field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time window specified for daily maintenance operations.</summary>
    public class DailyMaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output only] Duration of the time window, automatically chosen to be smallest possible in the given
        /// scenario. Duration will be in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) format "PTnHnMnS".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual string Duration { get; set; }

        /// <summary>
        /// Time within the maintenance window to start the maintenance operations. Time format should be in
        /// [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) format "HH:MM", where HH : [00-23] and MM : [00-59] GMT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of etcd encryption.</summary>
    public class DatabaseEncryption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of CloudKMS key to use for the encryption of secrets in etcd. Ex.
        /// projects/my-project/locations/global/keyRings/my-ring/cryptoKeys/my-key
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyName")]
        public virtual string KeyName { get; set; }

        /// <summary>Denotes the state of etcd encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DefaultSnatStatus contains the desired state of whether default sNAT should be disabled on the cluster.
    /// </summary>
    public class DefaultSnatStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Disables cluster default sNAT rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for NodeLocal DNSCache</summary>
    public class DnsCacheConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether NodeLocal DNSCache is enabled for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

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

    /// <summary>Configuration for the Compute Engine PD CSI driver.</summary>
    public class GcePersistentDiskCsiDriverConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the Compute Engine PD CSI driver is enabled for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GetJSONWebKeysResponse is a valid JSON Web Key Set as specififed in rfc 7517</summary>
    public class GetJSONWebKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// OnePlatform automatically extracts this field and uses it to set the HTTP Cache-Control header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHeader")]
        public virtual HttpCacheControlResponseHeader CacheHeader { get; set; }

        /// <summary>The public component of the keys used by the cluster to sign token requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<Jwk> Keys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GetOpenIDConfigResponse is an OIDC discovery document for the cluster. See the OpenID Connect Discovery 1.0
    /// specification for details.
    /// </summary>
    public class GetOpenIDConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// OnePlatform automatically extracts this field and uses it to set the HTTP Cache-Control header.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHeader")]
        public virtual HttpCacheControlResponseHeader CacheHeader { get; set; }

        /// <summary>Supported claims.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claims_supported")]
        public virtual System.Collections.Generic.IList<string> ClaimsSupported { get; set; }

        /// <summary>Supported grant types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grant_types")]
        public virtual System.Collections.Generic.IList<string> GrantTypes { get; set; }

        /// <summary>supported ID Token signing Algorithms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id_token_signing_alg_values_supported")]
        public virtual System.Collections.Generic.IList<string> IdTokenSigningAlgValuesSupported { get; set; }

        /// <summary>OIDC Issuer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        /// <summary>JSON Web Key uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwks_uri")]
        public virtual string JwksUri { get; set; }

        /// <summary>Supported response types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response_types_supported")]
        public virtual System.Collections.Generic.IList<string> ResponseTypesSupported { get; set; }

        /// <summary>Supported subject types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject_types_supported")]
        public virtual System.Collections.Generic.IList<string> SubjectTypesSupported { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration options for the horizontal pod autoscaling feature, which increases or decreases the number of
    /// replica pods a replication controller has based on the resource usage of the existing pods.
    /// </summary>
    public class HorizontalPodAutoscaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the Horizontal Pod Autoscaling feature is enabled in the cluster. When enabled, it ensures that
        /// metrics are collected into Stackdriver Monitoring.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RFC-2616: cache control support</summary>
    public class HttpCacheControlResponseHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>14.6 response cache age, in seconds since the response is generated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("age")]
        public virtual System.Nullable<long> Age { get; set; }

        /// <summary>14.9 request and response directives</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directive")]
        public virtual string Directive { get; set; }

        /// <summary>14.21 response cache expires, in RFC 1123 date format</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expires")]
        public virtual string Expires { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration options for the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load
    /// balancers for services in a cluster.
    /// </summary>
    public class HttpLoadBalancing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the HTTP Load Balancing controller is enabled in the cluster. When enabled, it runs a small pod in
        /// the cluster that manages the load balancers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ILBSubsettingConfig contains the desired config of L4 Internal LoadBalancer subsetting on this cluster.
    /// </summary>
    public class ILBSubsettingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enables l4 ILB subsetting for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for controlling how IPs are allocated in the cluster.</summary>
    public class IPAllocationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field is deprecated, use cluster_ipv4_cidr_block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterIpv4Cidr")]
        public virtual string ClusterIpv4Cidr { get; set; }

        /// <summary>
        /// The IP address range for the cluster pod IPs. If this field is set, then `cluster.cluster_ipv4_cidr` must be
        /// left blank. This field is only applicable when `use_ip_aliases` is true. Set to blank to have a range chosen
        /// with the default size. Set to /netmask (e.g. `/14`) to have a range chosen with a specific netmask. Set to a
        /// [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g. `10.96.0.0/14`) from the
        /// RFC-1918 private networks (e.g. `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to pick a specific range to
        /// use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterIpv4CidrBlock")]
        public virtual string ClusterIpv4CidrBlock { get; set; }

        /// <summary>
        /// The name of the secondary range to be used for the cluster CIDR block. The secondary range will be used for
        /// pod IP addresses. This must be an existing secondary range associated with the cluster subnetwork. This
        /// field is only applicable with use_ip_aliases is true and create_subnetwork is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterSecondaryRangeName")]
        public virtual string ClusterSecondaryRangeName { get; set; }

        /// <summary>
        /// Whether a new subnetwork will be created automatically for the cluster. This field is only applicable when
        /// `use_ip_aliases` is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createSubnetwork")]
        public virtual System.Nullable<bool> CreateSubnetwork { get; set; }

        /// <summary>This field is deprecated, use node_ipv4_cidr_block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeIpv4Cidr")]
        public virtual string NodeIpv4Cidr { get; set; }

        /// <summary>
        /// The IP address range of the instance IPs in this cluster. This is applicable only if `create_subnetwork` is
        /// true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. `/14`) to have a
        /// range chosen with a specific netmask. Set to a
        /// [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g. `10.96.0.0/14`) from the
        /// RFC-1918 private networks (e.g. `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to pick a specific range to
        /// use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeIpv4CidrBlock")]
        public virtual string NodeIpv4CidrBlock { get; set; }

        /// <summary>This field is deprecated, use services_ipv4_cidr_block.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesIpv4Cidr")]
        public virtual string ServicesIpv4Cidr { get; set; }

        /// <summary>
        /// The IP address range of the services IPs in this cluster. If blank, a range will be automatically chosen
        /// with the default size. This field is only applicable when `use_ip_aliases` is true. Set to blank to have a
        /// range chosen with the default size. Set to /netmask (e.g. `/14`) to have a range chosen with a specific
        /// netmask. Set to a [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g.
        /// `10.96.0.0/14`) from the RFC-1918 private networks (e.g. `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to
        /// pick a specific range to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesIpv4CidrBlock")]
        public virtual string ServicesIpv4CidrBlock { get; set; }

        /// <summary>
        /// The name of the secondary range to be used as for the services CIDR block. The secondary range will be used
        /// for service ClusterIPs. This must be an existing secondary range associated with the cluster subnetwork.
        /// This field is only applicable with use_ip_aliases is true and create_subnetwork is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesSecondaryRangeName")]
        public virtual string ServicesSecondaryRangeName { get; set; }

        /// <summary>
        /// A custom subnetwork name to be used if `create_subnetwork` is true. If this field is empty, then an
        /// automatic name will be chosen for the new subnetwork.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetworkName")]
        public virtual string SubnetworkName { get; set; }

        /// <summary>
        /// The IP address range of the Cloud TPUs in this cluster. If unspecified, a range will be automatically chosen
        /// with the default size. This field is only applicable when `use_ip_aliases` is true. If unspecified, the
        /// range will use the default size. Set to /netmask (e.g. `/14`) to have a range chosen with a specific
        /// netmask. Set to a [CIDR](http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notation (e.g.
        /// `10.96.0.0/14`) from the RFC-1918 private networks (e.g. `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to
        /// pick a specific range to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpuIpv4CidrBlock")]
        public virtual string TpuIpv4CidrBlock { get; set; }

        /// <summary>
        /// Whether alias IPs will be used for pod IPs in the cluster. This is used in conjunction with use_routes. It
        /// cannot be true if use_routes is true. If both use_ip_aliases and use_routes are false, then the server picks
        /// the default IP allocation mode
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useIpAliases")]
        public virtual System.Nullable<bool> UseIpAliases { get; set; }

        /// <summary>
        /// Whether routes will be used for pod IPs in the cluster. This is used in conjunction with use_ip_aliases. It
        /// cannot be true if use_ip_aliases is true. If both use_ip_aliases and use_routes are false, then the server
        /// picks the default IP allocation mode
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useRoutes")]
        public virtual System.Nullable<bool> UseRoutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// IntraNodeVisibilityConfig contains the desired config of the intra-node visibility on this cluster.
    /// </summary>
    public class IntraNodeVisibilityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enables intra node visibility for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Jwk is a JSON Web Key as specified in RFC 7517</summary>
    public class Jwk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alg")]
        public virtual string Alg { get; set; }

        /// <summary>Used for ECDSA keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crv")]
        public virtual string Crv { get; set; }

        /// <summary>Used for RSA keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("e")]
        public virtual string E { get; set; }

        /// <summary>Key ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kid")]
        public virtual string Kid { get; set; }

        /// <summary>Key Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kty")]
        public virtual string Kty { get; set; }

        /// <summary>Used for RSA keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("n")]
        public virtual string N { get; set; }

        /// <summary>Permitted uses for the public keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("use")]
        public virtual string Use { get; set; }

        /// <summary>Used for ECDSA keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x")]
        public virtual string X { get; set; }

        /// <summary>Used for ECDSA keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("y")]
        public virtual string Y { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the Kubernetes Dashboard.</summary>
    public class KubernetesDashboard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the Kubernetes Dashboard is enabled for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the legacy Attribute Based Access Control authorization mode.</summary>
    public class LegacyAbac : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including
        /// service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by
        /// the RBAC configuration or IAM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters that can be configured on Linux nodes.</summary>
    public class LinuxNodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Linux kernel parameters to be applied to the nodes and all pods running on the nodes. The following
        /// parameters are supported. net.core.netdev_max_backlog net.core.rmem_max net.core.wmem_default
        /// net.core.wmem_max net.core.optmem_max net.core.somaxconn net.ipv4.tcp_rmem net.ipv4.tcp_wmem
        /// net.ipv4.tcp_tw_reuse
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sysctls")]
        public virtual System.Collections.Generic.IDictionary<string, string> Sysctls { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListClustersResponse is the result of ListClustersRequest.</summary>
    public class ListClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of clusters in the project in the specified zone, or across all ones.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>If any zones are listed here, the list of clusters returned may be missing those zones.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingZones")]
        public virtual System.Collections.Generic.IList<string> MissingZones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListNodePoolsResponse is the result of ListNodePoolsRequest.</summary>
    public class ListNodePoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of node pools for a cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePools")]
        public virtual System.Collections.Generic.IList<NodePool> NodePools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListOperationsResponse is the result of ListOperationsRequest.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If any zones are listed here, the list of operations returned may be missing the operations from those
        /// zones.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missingZones")]
        public virtual System.Collections.Generic.IList<string> MissingZones { get; set; }

        /// <summary>A list of operations in the project in the specified zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListUsableSubnetworksResponse is the response of ListUsableSubnetworksRequest.</summary>
    public class ListUsableSubnetworksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This token allows you to get the next page of results for list requests. If the number of results is larger
        /// than `page_size`, use the `next_page_token` as a value for the query parameter `page_token` in the next
        /// request. The value will become empty when there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of usable subnetworks in the specified network project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetworks")]
        public virtual System.Collections.Generic.IList<UsableSubnetwork> Subnetworks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MaintenancePolicy defines the maintenance policy to be used for the cluster.</summary>
    public class MaintenancePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A hash identifying the version of this policy, so that updates to fields of the policy won't accidentally
        /// undo intermediate changes (and so that users of the API unaware of some fields won't accidentally remove
        /// other fields). Make a `get()` request to the cluster to get the current resource version and include it with
        /// requests to set the policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>Specifies the maintenance window in which maintenance may be performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("window")]
        public virtual MaintenanceWindow Window { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MaintenanceWindow defines the maintenance window to be used for the cluster.</summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DailyMaintenanceWindow specifies a daily maintenance operation window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyMaintenanceWindow")]
        public virtual DailyMaintenanceWindow DailyMaintenanceWindow { get; set; }

        /// <summary>
        /// Exceptions to maintenance window. Non-emergency maintenance should not occur in these windows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceExclusions")]
        public virtual System.Collections.Generic.IDictionary<string, TimeWindow> MaintenanceExclusions { get; set; }

        /// <summary>
        /// RecurringWindow specifies some number of recurring time periods for maintenance to occur. The time windows
        /// may be overlapping. If no maintenance windows are set, maintenance can occur at any time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurringWindow")]
        public virtual RecurringTimeWindow RecurringWindow { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The authentication information for accessing the master endpoint. Authentication can be done using HTTP basic
    /// auth or using client certificates.
    /// </summary>
    public class MasterAuth : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Output only] Base64-encoded public certificate used by clients to authenticate to the cluster endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual string ClientCertificate { get; set; }

        /// <summary>
        /// Configuration for client certificate authentication on the cluster. For clusters before v1.12, if no
        /// configuration is specified, a client certificate is issued.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificateConfig")]
        public virtual ClientCertificateConfig ClientCertificateConfig { get; set; }

        /// <summary>
        /// [Output only] Base64-encoded private key used by clients to authenticate to the cluster endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>
        /// [Output only] Base64-encoded public certificate that is the root of trust for the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterCaCertificate")]
        public virtual string ClusterCaCertificate { get; set; }

        /// <summary>
        /// The password to use for HTTP basic authentication to the master endpoint. Because the master endpoint is
        /// open to the Internet, you should create a strong password. If a password is provided for cluster creation,
        /// username must be non-empty. Warning: basic authentication is deprecated, and will be removed in GKE control
        /// plane versions 1.19 and newer. For a list of recommended authentication methods, see:
        /// https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// The username to use for HTTP basic authentication to the master endpoint. For clusters v1.6.0 and later,
        /// basic authentication can be disabled by leaving username unspecified (or setting it to the empty string).
        /// Warning: basic authentication is deprecated, and will be removed in GKE control plane versions 1.19 and
        /// newer. For a list of recommended authentication methods, see:
        /// https://cloud.google.com/kubernetes-engine/docs/how-to/api-server-authentication
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration options for the master authorized networks feature. Enabled master authorized networks will
    /// disallow all external traffic to access Kubernetes master through HTTPS except traffic from the given CIDR
    /// blocks, Google Compute Engine Public IPs and Google Prod IPs.
    /// </summary>
    public class MasterAuthorizedNetworksConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// cidr_blocks define up to 50 external networks that could access Kubernetes master through HTTPS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidrBlocks")]
        public virtual System.Collections.Generic.IList<CidrBlock> CidrBlocks { get; set; }

        /// <summary>Whether or not master authorized networks is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Constraints applied to pods.</summary>
    public class MaxPodsConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Constraint enforced on the max num of pods per node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPodsPerNode")]
        public virtual System.Nullable<long> MaxPodsPerNode { get; set; }

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

        /// <summary>Required. Metric name, e.g., "nodes total", "percent done".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>For metrics with custom values (ratios, visual progress, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NetworkConfig reports the relative names of network &amp; subnetwork.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy
        /// implementation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datapathProvider")]
        public virtual string DatapathProvider { get; set; }

        /// <summary>
        /// Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when
        /// default_snat_status is disabled. When disabled is set to false, default IP masquerade rules will be applied
        /// to the nodes to prevent sNAT on cluster internal traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSnatStatus")]
        public virtual DefaultSnatStatus DefaultSnatStatus { get; set; }

        /// <summary>
        /// Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible
        /// for VPC network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntraNodeVisibility")]
        public virtual System.Nullable<bool> EnableIntraNodeVisibility { get; set; }

        /// <summary>Whether L4ILB Subsetting is enabled for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableL4ilbSubsetting")]
        public virtual System.Nullable<bool> EnableL4ilbSubsetting { get; set; }

        /// <summary>
        /// Output only. The relative name of the Google Compute Engine
        /// network(https://cloud.google.com/compute/docs/networks-and-firewalls#networks) to which the cluster is
        /// connected. Example: projects/my-project/global/networks/my-network
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from
        /// Google Services (all access will be via IPv4)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateIpv6GoogleAccess")]
        public virtual string PrivateIpv6GoogleAccess { get; set; }

        /// <summary>
        /// Output only. The relative name of the Google Compute Engine
        /// [subnetwork](https://cloud.google.com/compute/docs/vpc) to which the cluster is connected. Example:
        /// projects/my-project/regions/us-central1/subnetworks/my-subnet
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration options for the NetworkPolicy feature.
    /// https://kubernetes.io/docs/concepts/services-networking/networkpolicies/
    /// </summary>
    public class NetworkPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether network policy is enabled on the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The selected network policy provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for NetworkPolicy. This only tracks whether the addon is enabled or not on the Master, it does not
    /// track whether network policy is enabled for the nodes.
    /// </summary>
    public class NetworkPolicyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether NetworkPolicy is enabled for this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters that describe the nodes in a cluster.</summary>
    public class NodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of hardware accelerators to be attached to each node. See https://cloud.google.com/compute/docs/gpus
        /// for more information about support for GPUs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerators")]
        public virtual System.Collections.Generic.IList<AcceleratorConfig> Accelerators { get; set; }

        /// <summary>
        ///  The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.
        /// This should be of the form
        /// projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more
        /// information about protecting resources with Cloud KMS Keys please see:
        /// https://cloud.google.com/compute/docs/disks/customer-managed-encryption
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskKmsKey")]
        public virtual string BootDiskKmsKey { get; set; }

        /// <summary>
        /// Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. If
        /// unspecified, the default disk size is 100GB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<int> DiskSizeGb { get; set; }

        /// <summary>
        /// Type of the disk attached to each node (e.g. 'pd-standard', 'pd-ssd' or 'pd-balanced') If unspecified, the
        /// default disk type is 'pd-standard'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>
        /// The image type to use for this node. Note that for a given image type, the latest version of it will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>Node kubelet configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubeletConfig")]
        public virtual NodeKubeletConfig KubeletConfig { get; set; }

        /// <summary>
        /// The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to
        /// any default label(s) that Kubernetes may apply to the node. In case of conflict in label keys, the applied
        /// set may differ depending on the Kubernetes version -- it's best to assume the behavior is undefined and
        /// conflicts should be avoided. For more information, including usage and the valid values, see:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Parameters that can be configured on Linux nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linuxNodeConfig")]
        public virtual LinuxNodeConfig LinuxNodeConfig { get; set; }

        /// <summary>
        /// The number of local SSD disks to be attached to the node. The limit for this value is dependent upon the
        /// maximum number of disks available on a machine per zone. See:
        /// https://cloud.google.com/compute/docs/disks/local-ssd for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localSsdCount")]
        public virtual System.Nullable<int> LocalSsdCount { get; set; }

        /// <summary>
        /// The name of a Google Compute Engine [machine type](https://cloud.google.com/compute/docs/machine-types) If
        /// unspecified, the default machine type is `e2-medium`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// The metadata key/value pairs assigned to instances in the cluster. Keys must conform to the regexp
        /// `[a-zA-Z0-9-_]+` and be less than 128 bytes in length. These are reflected as part of a URL in the metadata
        /// server. Additionally, to avoid ambiguity, keys must not conflict with any other metadata keys for the
        /// project or be one of the reserved keys: - "cluster-location" - "cluster-name" - "cluster-uid" -
        /// "configure-sh" - "containerd-configure-sh" - "enable-os-login" - "gci-ensure-gke-docker" -
        /// "gci-metrics-enabled" - "gci-update-strategy" - "instance-template" - "kube-env" - "startup-script" -
        /// "user-data" - "disable-address-manager" - "windows-startup-script-ps1" - "common-psm1" -
        /// "k8s-node-setup-psm1" - "install-ssh-psm1" - "user-profile-psm1" The following keys are reserved for Windows
        /// nodes: - "serial-port-logging-enable" Values are free-form strings, and only have meaning as interpreted by
        /// the image running in the instance. The only restriction placed on them is that each value's size must be
        /// less than or equal to 32 KB. The total size of all keys and values must be less than 512 KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer
        /// CPU platform. Applicable values are the friendly names of CPU platforms, such as `minCpuPlatform: "Intel
        /// Haswell"` or `minCpuPlatform: "Intel Sandy Bridge"`. For more information, read [how to specify min CPU
        /// platform](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuPlatform")]
        public virtual string MinCpuPlatform { get; set; }

        /// <summary>
        /// Setting this field will assign instances of this pool to run on the specified node group. This is useful for
        /// running workloads on [sole tenant nodes](https://cloud.google.com/compute/docs/nodes/sole-tenant-nodes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeGroup")]
        public virtual string NodeGroup { get; set; }

        /// <summary>
        /// The set of Google API scopes to be made available on all of the node VMs under the "default" service
        /// account. The following scopes are recommended, but not required, and by default are not included: *
        /// `https://www.googleapis.com/auth/compute` is required for mounting persistent storage on your nodes. *
        /// `https://www.googleapis.com/auth/devstorage.read_only` is required for communicating with **gcr.io** (the
        /// [Google Container Registry](https://cloud.google.com/container-registry/)). If unspecified, no scopes are
        /// added, unless Cloud Logging or Cloud Monitoring are enabled, in which case their required scopes will be
        /// added.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthScopes")]
        public virtual System.Collections.Generic.IList<string> OauthScopes { get; set; }

        /// <summary>
        /// Whether the nodes are created as preemptible VM instances. See:
        /// https://cloud.google.com/compute/docs/instances/preemptible for more information about preemptible VM
        /// instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preemptible")]
        public virtual System.Nullable<bool> Preemptible { get; set; }

        /// <summary>
        /// The optional reservation affinity. Setting this field will apply the specified [Zonal Compute
        /// Reservation](https://cloud.google.com/compute/docs/instances/reserving-zonal-resources) to this node pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationAffinity")]
        public virtual ReservationAffinity ReservationAffinity { get; set; }

        /// <summary>Sandbox configuration for this node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sandboxConfig")]
        public virtual SandboxConfig SandboxConfig { get; set; }

        /// <summary>
        /// The Google Cloud Platform Service Account to be used by the node VMs. Specify the email address of the
        /// Service Account; otherwise, if no Service Account is specified, the "default" service account is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Shielded Instance options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shieldedInstanceConfig")]
        public virtual ShieldedInstanceConfig ShieldedInstanceConfig { get; set; }

        /// <summary>
        /// The list of instance tags applied to all nodes. Tags are used to identify valid sources or targets for
        /// network firewalls and are specified by the client during cluster or node pool creation. Each tag within the
        /// list must comply with RFC1035.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// List of kubernetes taints to be applied to each node. For more information, including usage and the valid
        /// values, see: https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taints")]
        public virtual System.Collections.Generic.IList<NodeTaint> Taints { get; set; }

        /// <summary>The workload metadata configuration for this node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadMetadataConfig")]
        public virtual WorkloadMetadataConfig WorkloadMetadataConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Node kubelet configs.</summary>
    public class NodeKubeletConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enable CPU CFS quota enforcement for containers that specify CPU limits. This option is enabled by default
        /// which makes kubelet use CFS quota (https://www.kernel.org/doc/Documentation/scheduler/sched-bwc.txt) to
        /// enforce container CPU limits. Otherwise, CPU limits will not be enforced at all. Disable this option to
        /// mitigate CPU throttling problems while still having your pods to be in Guaranteed QoS class by specifying
        /// the CPU limits. The default value is 'true' if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCfsQuota")]
        public virtual System.Nullable<bool> CpuCfsQuota { get; set; }

        /// <summary>
        /// Set the CPU CFS quota period value 'cpu.cfs_period_us'. The string must be a sequence of decimal numbers,
        /// each with optional fraction and a unit suffix, such as "300ms". Valid time units are "ns", "us" (or "µs"),
        /// "ms", "s", "m", "h". The value must be a positive duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCfsQuotaPeriod")]
        public virtual string CpuCfsQuotaPeriod { get; set; }

        /// <summary>
        /// Control the CPU management policy on the node. See
        /// https://kubernetes.io/docs/tasks/administer-cluster/cpu-management-policies/ The following values are
        /// allowed. - "none": the default, which represents the existing scheduling behavior. - "static": allows pods
        /// with certain resource characteristics to be granted increased CPU affinity and exclusivity on the node. The
        /// default value is 'none' if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuManagerPolicy")]
        public virtual string CpuManagerPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NodeManagement defines the set of node management services turned on for the node pool.</summary>
    public class NodeManagement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A flag that specifies whether the node auto-repair is enabled for the node pool. If enabled, the nodes in
        /// this node pool will be monitored and, if they fail health checks too many times, an automatic repair action
        /// will be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRepair")]
        public virtual System.Nullable<bool> AutoRepair { get; set; }

        /// <summary>
        /// A flag that specifies whether node auto-upgrade is enabled for the node pool. If enabled, node auto-upgrade
        /// helps keep the nodes in your node pool up to date with the latest release version of Kubernetes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoUpgrade")]
        public virtual System.Nullable<bool> AutoUpgrade { get; set; }

        /// <summary>Specifies the Auto Upgrade knobs for the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeOptions")]
        public virtual AutoUpgradeOptions UpgradeOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// NodePool contains the name and configuration for a cluster's node pool. Node pools are a set of nodes (i.e.
    /// VM's), with a common configuration and specification, under the control of the cluster master. They may have a
    /// set of Kubernetes labels applied to them, which may be used to reference them during pod scheduling. They may
    /// also be resized up or down, to accommodate the workload.
    /// </summary>
    public class NodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Autoscaler configuration for this NodePool. Autoscaler is enabled only if a valid configuration is present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscaling")]
        public virtual NodePoolAutoscaling Autoscaling { get; set; }

        /// <summary>Which conditions caused the current node pool state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<StatusCondition> Conditions { get; set; }

        /// <summary>The node configuration of the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual NodeConfig Config { get; set; }

        /// <summary>
        /// The initial node count for the pool. You must ensure that your Compute Engine [resource
        /// quota](https://cloud.google.com/compute/quotas) is sufficient for this number of instances. You must also
        /// have available firewall and routes quota.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialNodeCount")]
        public virtual System.Nullable<int> InitialNodeCount { get; set; }

        /// <summary>
        /// [Output only] The resource URLs of the [managed instance
        /// groups](https://cloud.google.com/compute/docs/instance-groups/creating-groups-of-managed-instances)
        /// associated with this node pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceGroupUrls")]
        public virtual System.Collections.Generic.IList<string> InstanceGroupUrls { get; set; }

        /// <summary>
        /// The list of Google Compute Engine [zones](https://cloud.google.com/compute/docs/zones#available) in which
        /// the NodePool's nodes should be located. If this value is unspecified during node pool creation, the
        /// [Cluster.Locations](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1/projects.locations.clusters#Cluster.FIELDS.locations)
        /// value will be used, instead. Warning: changing node pool locations will result in nodes being added and/or
        /// removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<string> Locations { get; set; }

        /// <summary>NodeManagement configuration for this NodePool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("management")]
        public virtual NodeManagement Management { get; set; }

        /// <summary>
        /// The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPodsConstraint")]
        public virtual MaxPodsConstraint MaxPodsConstraint { get; set; }

        /// <summary>The name of the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>[Output only] The pod CIDR block size per node in this node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("podIpv4CidrSize")]
        public virtual System.Nullable<int> PodIpv4CidrSize { get; set; }

        /// <summary>[Output only] Server-defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>[Output only] The status of the nodes in this pool instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// [Output only] Deprecated. Use conditions instead. Additional information about the current status of this
        /// node pool instance, if available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Upgrade settings control disruption and speed of the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeSettings")]
        public virtual UpgradeSettings UpgradeSettings { get; set; }

        /// <summary>The version of the Kubernetes of this node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// NodePoolAutoscaling contains information required by cluster autoscaler to adjust the size of the node pool to
    /// the current cluster usage.
    /// </summary>
    public class NodePoolAutoscaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Can this node pool be deleted automatically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoprovisioned")]
        public virtual System.Nullable<bool> Autoprovisioned { get; set; }

        /// <summary>Is autoscaling enabled for this node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Maximum number of nodes in the NodePool. Must be &amp;gt;= min_node_count. There has to enough quota to
        /// scale up the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNodeCount")]
        public virtual System.Nullable<int> MaxNodeCount { get; set; }

        /// <summary>Minimum number of nodes in the NodePool. Must be &gt;= 1 and &lt;= max_node_count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minNodeCount")]
        public virtual System.Nullable<int> MinNodeCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Kubernetes taint is comprised of three fields: key, value, and effect. Effect can only be one of three types:
    /// NoSchedule, PreferNoSchedule or NoExecute. See
    /// [here](https://kubernetes.io/docs/concepts/configuration/taint-and-toleration) for more information, including
    /// usage and the valid values.
    /// </summary>
    public class NodeTaint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Effect for taint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effect")]
        public virtual string Effect { get; set; }

        /// <summary>Key for taint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value for taint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NotificationConfig is the configuration of notifications.</summary>
    public class NotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Notification config for Pub/Sub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsub")]
        public virtual PubSub Pubsub { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This operation resource represents operations that may have happened or are happening on the cluster. All fields
    /// are output only.
    /// </summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Which conditions caused the current cluster state. Deprecated. Use field error instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterConditions")]
        public virtual System.Collections.Generic.IList<StatusCondition> ClusterConditions { get; set; }

        /// <summary>Detailed operation progress, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>
        /// [Output only] The time the operation completed, in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTime { get; set; }

        /// <summary>The error result of the operation in case of failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// [Output only] The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/regions-zones/regions-zones#available) or
        /// [region](https://cloud.google.com/compute/docs/regions-zones/regions-zones#available) in which the cluster
        /// resides.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The server-assigned ID for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Which conditions caused the current node pool state. Deprecated. Use field error instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodepoolConditions")]
        public virtual System.Collections.Generic.IList<StatusCondition> NodepoolConditions { get; set; }

        /// <summary>The operation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationType")]
        public virtual string OperationType { get; set; }

        /// <summary>Output only. [Output only] Progress information for an operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>Server-defined URL for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// [Output only] The time the operation started, in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTime { get; set; }

        /// <summary>The current status of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Output only. If an error has occurred, a textual description of the error. Deprecated. Use the field error
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Server-defined URL for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetLink")]
        public virtual string TargetLink { get; set; }

        /// <summary>
        /// The name of the Google Compute Engine [zone](https://cloud.google.com/compute/docs/zones#available) in which
        /// the operation is taking place. This field is deprecated, use location instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about operation (or operation stage) progress.</summary>
    public class OperationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Progress metric bundle, for example: metrics: [{name: "nodes done", int_value: 15}, {name: "nodes total",
        /// int_value: 32}] or metrics: [{name: "progress", double_value: 0.56}, {name: "progress scale", double_value:
        /// 1.0}]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<Metric> Metrics { get; set; }

        /// <summary>
        /// A non-parameterized string describing an operation stage. Unset for single-stage operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Substages of an operation or a stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stages")]
        public virtual System.Collections.Generic.IList<OperationProgress> Stages { get; set; }

        /// <summary>Status of an operation stage. Unset for single-stage operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration options for private clusters.</summary>
    public class PrivateClusterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the master's internal IP address is used as the cluster endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivateEndpoint")]
        public virtual System.Nullable<bool> EnablePrivateEndpoint { get; set; }

        /// <summary>
        /// Whether nodes have internal IP addresses only. If enabled, all nodes are given only RFC 1918 private
        /// addresses and communicate with the master via private networking.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePrivateNodes")]
        public virtual System.Nullable<bool> EnablePrivateNodes { get; set; }

        /// <summary>Controls master global access settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterGlobalAccessConfig")]
        public virtual PrivateClusterMasterGlobalAccessConfig MasterGlobalAccessConfig { get; set; }

        /// <summary>
        /// The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning
        /// internal IP addresses to the master or set of masters, as well as the ILB VIP. This range must not overlap
        /// with any other ranges in use within the cluster's network.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterIpv4CidrBlock")]
        public virtual string MasterIpv4CidrBlock { get; set; }

        /// <summary>Output only. The peering name in the customer VPC used by this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peeringName")]
        public virtual string PeeringName { get; set; }

        /// <summary>Output only. The internal IP address of this cluster's master endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateEndpoint")]
        public virtual string PrivateEndpoint { get; set; }

        /// <summary>Output only. The external IP address of this cluster's master endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicEndpoint")]
        public virtual string PublicEndpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for controlling master global access settings.</summary>
    public class PrivateClusterMasterGlobalAccessConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whenever master is accessible globally or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pub/Sub specific notification config.</summary>
    public class PubSub : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable notifications for Pub/Sub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// The desired Pub/Sub topic to which notifications will be sent by GKE. Format is
        /// `projects/{project}/topics/{topic}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an arbitrary window of time that recurs.</summary>
    public class RecurringTimeWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An RRULE (https://tools.ietf.org/html/rfc5545#section-3.8.5.3) for how this window reccurs. They go on for
        /// the span of time between the start and end time. For example, to have something repeat every weekday, you'd
        /// use: `FREQ=WEEKLY;BYDAY=MO,TU,WE,TH,FR` To repeat some window daily (equivalent to the
        /// DailyMaintenanceWindow): `FREQ=DAILY` For the first weekend of every month:
        /// `FREQ=MONTHLY;BYSETPOS=1;BYDAY=SA,SU` This specifies how frequently the window starts. Eg, if you wanted to
        /// have a 9-5 UTC-4 window every weekday, you'd use something like: ``` start time = 2019-01-01T09:00:00-0400
        /// end time = 2019-01-01T17:00:00-0400 recurrence = FREQ=WEEKLY;BYDAY=MO,TU,WE,TH,FR ``` Windows can span
        /// multiple days. Eg, to make the window encompass every weekend from midnight Saturday till the last minute of
        /// Sunday UTC: ``` start time = 2019-01-05T00:00:00Z end time = 2019-01-07T23:59:00Z recurrence =
        /// FREQ=WEEKLY;BYDAY=SA ``` Note the start and end time's specific dates are largely arbitrary except to
        /// specify duration of the window and when it first starts. The FREQ values of HOURLY, MINUTELY, and SECONDLY
        /// are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurrence")]
        public virtual string Recurrence { get; set; }

        /// <summary>The window of the first recurrence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("window")]
        public virtual TimeWindow Window { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ReleaseChannel indicates which release channel a cluster is subscribed to. Release channels are arranged in
    /// order of risk. When a cluster is subscribed to a release channel, Google maintains both the master version and
    /// the node version. Node auto-upgrade defaults to true and cannot be disabled.
    /// </summary>
    public class ReleaseChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>channel specifies which release channel the cluster is subscribed to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ReleaseChannelConfig exposes configuration for a release channel.</summary>
    public class ReleaseChannelConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The release channel this configuration applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>The default version for newly created clusters on the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultVersion")]
        public virtual string DefaultVersion { get; set; }

        /// <summary>List of valid versions for the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validVersions")]
        public virtual System.Collections.Generic.IList<string> ValidVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [ReservationAffinity](https://cloud.google.com/compute/docs/instances/reserving-zonal-resources) is the
    /// configuration of desired reservation which instances could take capacity from.
    /// </summary>
    public class ReservationAffinity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Corresponds to the type of reservation consumption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumeReservationType")]
        public virtual string ConsumeReservationType { get; set; }

        /// <summary>
        /// Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify
        /// "googleapis.com/reservation-name" as the key and specify the name of your reservation as its value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Corresponds to the label value(s) of reservation resource(s).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information about amount of some resource in the cluster. For memory, value should be in GB.
    /// </summary>
    public class ResourceLimit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum amount of the resource in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual System.Nullable<long> Maximum { get; set; }

        /// <summary>Minimum amount of the resource in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual System.Nullable<long> Minimum { get; set; }

        /// <summary>Resource name "cpu", "memory" or gpu-specific string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for exporting cluster resource usages.</summary>
    public class ResourceUsageExportConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration to use BigQuery as usage export destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDestination")]
        public virtual BigQueryDestination BigqueryDestination { get; set; }

        /// <summary>Configuration to enable resource consumption metering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumptionMeteringConfig")]
        public virtual ConsumptionMeteringConfig ConsumptionMeteringConfig { get; set; }

        /// <summary>
        /// Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the
        /// cluster to meter network egress traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableNetworkEgressMetering")]
        public virtual System.Nullable<bool> EnableNetworkEgressMetering { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RollbackNodePoolUpgradeRequest rollbacks the previously Aborted or Failed NodePool upgrade. This will be an
    /// no-op if the last upgrade successfully completed.
    /// </summary>
    public class RollbackNodePoolUpgradeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to rollback. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster, node pool id) of the node poll to rollback upgrade. Specified in the
        /// format `projects/*/locations/*/clusters/*/nodePools/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The name of the node pool to rollback. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolId")]
        public virtual string NodePoolId { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SandboxConfig contains configurations of the sandbox to use for the node.</summary>
    public class SandboxConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the sandbox to use for the node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes Engine service configuration.</summary>
    public class ServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of release channel configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channels")]
        public virtual System.Collections.Generic.IList<ReleaseChannelConfig> Channels { get; set; }

        /// <summary>Version of Kubernetes the service deploys by default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultClusterVersion")]
        public virtual string DefaultClusterVersion { get; set; }

        /// <summary>Default image type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultImageType")]
        public virtual string DefaultImageType { get; set; }

        /// <summary>List of valid image types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validImageTypes")]
        public virtual System.Collections.Generic.IList<string> ValidImageTypes { get; set; }

        /// <summary>List of valid master versions, in descending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validMasterVersions")]
        public virtual System.Collections.Generic.IList<string> ValidMasterVersions { get; set; }

        /// <summary>List of valid node upgrade target versions, in descending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validNodeVersions")]
        public virtual System.Collections.Generic.IList<string> ValidNodeVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetAddonsConfigRequest sets the addons associated with the cluster.</summary>
    public class SetAddonsConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The desired configurations for the various addons available to run in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addonsConfig")]
        public virtual AddonsConfig AddonsConfig { get; set; }

        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster) of the cluster to set addons. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SetLabelsRequest sets the Google Cloud Platform labels on a Google Container Engine cluster, which will in turn
    /// set them for Google Compute Engine resources used by that cluster
    /// </summary>
    public class SetLabelsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The fingerprint of the previous set of labels for this resource, used to detect conflicts. The
        /// fingerprint is initially generated by Kubernetes Engine and changes after every request to modify or update
        /// labels. You must always provide an up-to-date fingerprint hash when updating or changing labels. Make a
        /// `get()` request to the resource to get the latest fingerprint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelFingerprint")]
        public virtual string LabelFingerprint { get; set; }

        /// <summary>
        /// The name (project, location, cluster id) of the cluster to set labels. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been deprecated and
        /// replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. The labels to set for that cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceLabels { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetLegacyAbacRequest enables or disables the ABAC authorization mechanism for a cluster.</summary>
    public class SetLegacyAbacRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>Required. Whether ABAC authorization will be enabled in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// The name (project, location, cluster id) of the cluster to set legacy abac. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetLocationsRequest sets the locations of the cluster.</summary>
    public class SetLocationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The desired list of Google Compute Engine
        /// [zones](https://cloud.google.com/compute/docs/zones#available) in which the cluster's nodes should be
        /// located. Changing the locations a cluster is in will result in nodes being either created or removed from
        /// the cluster, depending on whether locations are being added or removed. This list must always include the
        /// cluster's primary zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<string> Locations { get; set; }

        /// <summary>
        /// The name (project, location, cluster) of the cluster to set locations. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetLoggingServiceRequest sets the logging service of a cluster.</summary>
    public class SetLoggingServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The logging service the cluster should use to write logs. Currently available options: *
        /// `logging.googleapis.com/kubernetes` - The Cloud Logging service with a Kubernetes-native resource model *
        /// `logging.googleapis.com` - The legacy Cloud Logging service (no longer available as of GKE 1.15). * `none` -
        /// no logs will be exported from the cluster. If left as an empty string,`logging.googleapis.com/kubernetes`
        /// will be used for GKE 1.14+ or `logging.googleapis.com` for earlier versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingService")]
        public virtual string LoggingService { get; set; }

        /// <summary>
        /// The name (project, location, cluster) of the cluster to set logging. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetMaintenancePolicyRequest sets the maintenance policy for a cluster.</summary>
    public class SetMaintenancePolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the cluster to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The maintenance policy to be set for the cluster. An empty field clears the existing maintenance
        /// policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicy")]
        public virtual MaintenancePolicy MaintenancePolicy { get; set; }

        /// <summary>
        /// The name (project, location, cluster id) of the cluster to set maintenance policy. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Required. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetMasterAuthRequest updates the admin password of a cluster.</summary>
    public class SetMasterAuthRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The exact form of action to be taken on the master auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster) of the cluster to set auth. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. A description of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual MasterAuth Update { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetMonitoringServiceRequest sets the monitoring service of a cluster.</summary>
    public class SetMonitoringServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The monitoring service the cluster should use to write metrics. Currently available options: *
        /// "monitoring.googleapis.com/kubernetes" - The Cloud Monitoring service with a Kubernetes-native resource
        /// model * `monitoring.googleapis.com` - The legacy Cloud Monitoring service (no longer available as of GKE
        /// 1.15). * `none` - No metrics will be exported from the cluster. If left as an empty
        /// string,`monitoring.googleapis.com/kubernetes` will be used for GKE 1.14+ or `monitoring.googleapis.com` for
        /// earlier versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoringService")]
        public virtual string MonitoringService { get; set; }

        /// <summary>
        /// The name (project, location, cluster) of the cluster to set monitoring. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetNetworkPolicyRequest enables/disables network policy for a cluster.</summary>
    public class SetNetworkPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster id) of the cluster to set networking policy. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Configuration options for the NetworkPolicy feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkPolicy")]
        public virtual NetworkPolicy NetworkPolicy { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been deprecated and
        /// replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetNodePoolAutoscalingRequest sets the autoscaler settings of a node pool.</summary>
    public class SetNodePoolAutoscalingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Autoscaling configuration for the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscaling")]
        public virtual NodePoolAutoscaling Autoscaling { get; set; }

        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster, node pool) of the node pool to set autoscaler settings. Specified in
        /// the format `projects/*/locations/*/clusters/*/nodePools/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The name of the node pool to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolId")]
        public virtual string NodePoolId { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetNodePoolManagementRequest sets the node management properties of a node pool.</summary>
    public class SetNodePoolManagementRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>Required. NodeManagement configuration for the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("management")]
        public virtual NodeManagement Management { get; set; }

        /// <summary>
        /// The name (project, location, cluster, node pool id) of the node pool to set management properties. Specified
        /// in the format `projects/*/locations/*/clusters/*/nodePools/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The name of the node pool to update. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolId")]
        public virtual string NodePoolId { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SetNodePoolSizeRequest sets the size of a node pool.</summary>
    public class SetNodePoolSizeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to update. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster, node pool id) of the node pool to set size. Specified in the format
        /// `projects/*/locations/*/clusters/*/nodePools/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The desired node count for the pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>
        /// Deprecated. The name of the node pool to update. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolId")]
        public virtual string NodePoolId { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of Shielded Instance options.</summary>
    public class ShieldedInstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the
        /// boot integrity of the instance. The attestation is performed against the integrity policy baseline. This
        /// baseline is initially derived from the implicitly trusted boot image when the instance is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableIntegrityMonitoring")]
        public virtual System.Nullable<bool> EnableIntegrityMonitoring { get; set; }

        /// <summary>
        /// Defines whether the instance has Secure Boot enabled. Secure Boot helps ensure that the system only runs
        /// authentic software by verifying the digital signature of all boot components, and halting the boot process
        /// if signature verification fails.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSecureBoot")]
        public virtual System.Nullable<bool> EnableSecureBoot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of Shielded Nodes feature.</summary>
    public class ShieldedNodes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Shielded Nodes features are enabled on all nodes in this cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// StartIPRotationRequest creates a new IP for the cluster and then performs a node upgrade on each node pool to
    /// point to the new IP.
    /// </summary>
    public class StartIPRotationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster. This field has been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster id) of the cluster to start IP rotation. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber). This field has been deprecated and
        /// replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Whether to rotate credentials during IP rotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotateCredentials")]
        public virtual System.Nullable<bool> RotateCredentials { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

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

    /// <summary>
    /// StatusCondition describes why a cluster or a node pool has a certain status (e.g., ERROR or DEGRADED).
    /// </summary>
    public class StatusCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canonical code of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalCode")]
        public virtual string CanonicalCode { get; set; }

        /// <summary>Machine-friendly representation of the condition Deprecated. Use canonical_code instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Human-friendly representation of the condition</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an arbitrary window of time.</summary>
    public class TimeWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time that the window ends. The end time should take place after the start time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The time that the window first starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UpdateClusterRequest updates the settings of a cluster.</summary>
    public class UpdateClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// The name (project, location, cluster) of the cluster to update. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. A description of the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual ClusterUpdate Update { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UpdateMasterRequest updates the master of the cluster.</summary>
    public class UpdateMasterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>
        /// Required. The Kubernetes version to change the master to. Users may specify either explicit versions offered
        /// by Kubernetes Engine or version aliases, which have the following behavior: - "latest": picks the highest
        /// valid Kubernetes version - "1.X": picks the highest valid patch+gke.N patch in the 1.X version - "1.X.Y":
        /// picks the highest valid gke.N patch in the 1.X.Y version - "1.X.Y-gke.N": picks an explicit Kubernetes
        /// version - "-": picks the default Kubernetes version
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("masterVersion")]
        public virtual string MasterVersion { get; set; }

        /// <summary>
        /// The name (project, location, cluster) of the cluster to update. Specified in the format
        /// `projects/*/locations/*/clusters/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>UpdateNodePoolRequests update a node pool's image and/or version.</summary>
    public class UpdateNodePoolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deprecated. The name of the cluster to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>Required. The desired image type for the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageType")]
        public virtual string ImageType { get; set; }

        /// <summary>Node kubelet configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubeletConfig")]
        public virtual NodeKubeletConfig KubeletConfig { get; set; }

        /// <summary>Parameters that can be configured on Linux nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linuxNodeConfig")]
        public virtual LinuxNodeConfig LinuxNodeConfig { get; set; }

        /// <summary>
        /// The desired list of Google Compute Engine [zones](https://cloud.google.com/compute/docs/zones#available) in
        /// which the node pool's nodes should be located. Changing the locations for a node pool will result in nodes
        /// being either created or removed from the node pool, depending on whether locations are being added or
        /// removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<string> Locations { get; set; }

        /// <summary>
        /// The name (project, location, cluster, node pool) of the node pool to update. Specified in the format
        /// `projects/*/locations/*/clusters/*/nodePools/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Deprecated. The name of the node pool to upgrade. This field has been deprecated and replaced by the name
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePoolId")]
        public virtual string NodePoolId { get; set; }

        /// <summary>
        /// Required. The Kubernetes version to change the nodes to (typically an upgrade). Users may specify either
        /// explicit versions offered by Kubernetes Engine or version aliases, which have the following behavior: -
        /// "latest": picks the highest valid Kubernetes version - "1.X": picks the highest valid patch+gke.N patch in
        /// the 1.X version - "1.X.Y": picks the highest valid gke.N patch in the 1.X.Y version - "1.X.Y-gke.N": picks
        /// an explicit Kubernetes version - "-": picks the Kubernetes master version
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeVersion")]
        public virtual string NodeVersion { get; set; }

        /// <summary>
        /// Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840). This field has been deprecated and replaced by the
        /// name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Upgrade settings control disruption and speed of the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeSettings")]
        public virtual UpgradeSettings UpgradeSettings { get; set; }

        /// <summary>The desired workload metadata config for the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadMetadataConfig")]
        public virtual WorkloadMetadataConfig WorkloadMetadataConfig { get; set; }

        /// <summary>
        /// Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster resides. This field has
        /// been deprecated and replaced by the name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// UpgradeAvailableEvent is a notification sent to customers when a new available version is released.
    /// </summary>
    public class UpgradeAvailableEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The release channel of the version. If empty, it means a non-channel release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseChannel")]
        public virtual ReleaseChannel ReleaseChannel { get; set; }

        /// <summary>Optional relative path to the resource. For example, the relative path of the node pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The resource type of the release version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The release version available for upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// UpgradeEvent is a notification sent to customers by the cluster server when a resource is upgrading.
    /// </summary>
    public class UpgradeEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current version before the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentVersion")]
        public virtual string CurrentVersion { get; set; }

        /// <summary>The operation associated with this upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>The time when the operation was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationStartTime")]
        public virtual object OperationStartTime { get; set; }

        /// <summary>
        /// Optional relative path to the resource. For example in node pool upgrades, the relative path of the node
        /// pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The resource type that is upgrading.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The target version for the upgrade.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetVersion")]
        public virtual string TargetVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// These upgrade settings control the level of parallelism and the level of disruption caused by an upgrade.
    /// maxUnavailable controls the number of nodes that can be simultaneously unavailable. maxSurge controls the number
    /// of additional nodes that can be added to the node pool temporarily for the time of the upgrade to increase the
    /// number of available nodes. (maxUnavailable + maxSurge) determines the level of parallelism (how many nodes are
    /// being upgraded at the same time). Note: upgrades inevitably introduce some disruption since workloads need to be
    /// moved from old nodes to new, upgraded ones. Even if maxUnavailable=0, this holds true. (Disruption stays within
    /// the limits of PodDisruptionBudget, if it is configured.) Consider a hypothetical node pool with 5 nodes having
    /// maxSurge=2, maxUnavailable=1. This means the upgrade process upgrades 3 nodes simultaneously. It creates 2
    /// additional (upgraded) nodes, then it brings down 3 old (not yet upgraded) nodes at the same time. This ensures
    /// that there are always at least 4 nodes available.
    /// </summary>
    public class UpgradeSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of nodes that can be created beyond the current size of the node pool during the upgrade
        /// process.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSurge")]
        public virtual System.Nullable<int> MaxSurge { get; set; }

        /// <summary>
        /// The maximum number of nodes that can be simultaneously unavailable during the upgrade process. A node is
        /// considered available if its status is Ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxUnavailable")]
        public virtual System.Nullable<int> MaxUnavailable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// UsableSubnetwork resource returns the subnetwork name, its associated network and the primary CIDR range.
    /// </summary>
    public class UsableSubnetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range of internal addresses that are owned by this subnetwork.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipCidrRange")]
        public virtual string IpCidrRange { get; set; }

        /// <summary>Network Name. Example: projects/my-project/global/networks/my-network</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Secondary IP ranges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryIpRanges")]
        public virtual System.Collections.Generic.IList<UsableSubnetworkSecondaryRange> SecondaryIpRanges { get; set; }

        /// <summary>
        /// A human readable status message representing the reasons for cases where the caller cannot use the secondary
        /// ranges under the subnet. For example if the secondary_ip_ranges is empty due to a permission issue, an
        /// insufficient permission message will be given by status_message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Subnetwork Name. Example: projects/my-project/regions/us-central1/subnetworks/my-subnet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Secondary IP range of a usable subnetwork.</summary>
    public class UsableSubnetworkSecondaryRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range of IP addresses belonging to this subnetwork secondary range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipCidrRange")]
        public virtual string IpCidrRange { get; set; }

        /// <summary>
        /// The name associated with this subnetwork secondary range, used when adding an alias IP range to a VM
        /// instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeName")]
        public virtual string RangeName { get; set; }

        /// <summary>This field is to determine the status of the secondary range programmably.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VerticalPodAutoscaling contains global, per-cluster information required by Vertical Pod Autoscaler to
    /// automatically adjust the resources of pods controlled by it.
    /// </summary>
    public class VerticalPodAutoscaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enables vertical pod autoscaling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the use of Kubernetes Service Accounts in GCP IAM policies.</summary>
    public class WorkloadIdentityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The workload pool to attach all Kubernetes service accounts to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadPool")]
        public virtual string WorkloadPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// WorkloadMetadataConfig defines the metadata configuration to expose to workloads on the node pool.
    /// </summary>
    public class WorkloadMetadataConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mode is the configuration for how to expose metadata to workloads running on the node pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
