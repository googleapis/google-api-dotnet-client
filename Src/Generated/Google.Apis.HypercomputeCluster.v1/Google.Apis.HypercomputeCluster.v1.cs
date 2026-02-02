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

namespace Google.Apis.HypercomputeCluster.v1
{
    /// <summary>The HypercomputeCluster Service.</summary>
    public class HypercomputeClusterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public HypercomputeClusterService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public HypercomputeClusterService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://hypercomputecluster.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://hypercomputecluster.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "hypercomputecluster";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cluster Director API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cluster Director API.</summary>
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

    /// <summary>A base abstract class for HypercomputeCluster requests.</summary>
    public abstract class HypercomputeClusterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new HypercomputeClusterBaseServiceRequest instance.</summary>
        protected HypercomputeClusterBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes HypercomputeCluster parameter list.</summary>
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
                }

                /// <summary>Creates a new Cluster in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent location in which the cluster should be created, in the format
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.HypercomputeCluster.v1.Data.Cluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Cluster in a given project and location.</summary>
                public class CreateRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.HypercomputeCluster.v1.Data.Cluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent location in which the cluster should be created, in the format
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. ID of the cluster to create. Must conform to
                    /// [RFC-1034](https://datatracker.ietf.org/doc/html/rfc1034) (lower-case, alphanumeric, and at most
                    /// 63 characters).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("clusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ClusterId { get; set; }

                    /// <summary>
                    /// Optional. A unique identifier for this request. A random UUID is recommended. This request is
                    /// idempotent if and only if `request_id` is provided.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.HypercomputeCluster.v1.Data.Cluster Body { get; set; }

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
                        RequestParameters.Add("clusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "clusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Cluster.</summary>
                /// <param name="name">
                /// Required. Name of the cluster to delete, in the format
                /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Cluster.</summary>
                public class DeleteRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the cluster to delete, in the format
                    /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A unique identifier for this request. A random UUID is recommended. This request is
                    /// idempotent if and only if `request_id` is provided.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single Cluster.</summary>
                /// <param name="name">
                /// Required. Name of the cluster to retrieve, in the format
                /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Cluster.</summary>
                public class GetRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.Cluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the cluster to retrieve, in the format
                    /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent location of the clusters to list, in the format
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Clusters in a given project and location.</summary>
                public class ListRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.ListClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent location of the clusters to list, in the format
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. [Filter](https://google.aip.dev/160) to apply to the returned results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. How to order the resulting clusters. Must be one of the following strings: * `name` *
                    /// `name desc` * `create_time` * `create_time desc` If not specified, clusters will be returned in
                    /// an arbitrary order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Maximum number of clusters to return. The service may return fewer than this value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token received from a previous `ListClusters` call. Provide this to retrieve
                    /// the subsequent page. When paginating, all other parameters provided to `ListClusters` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

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

                /// <summary>Updates the parameters of a single Cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. [Relative resource name](https://google.aip.dev/122) of the cluster, in the format
                /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.HypercomputeCluster.v1.Data.Cluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Cluster.</summary>
                public class PatchRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.HypercomputeCluster.v1.Data.Cluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. [Relative resource name](https://google.aip.dev/122) of the cluster, in the format
                    /// `projects/{project}/locations/{location}/clusters/{cluster}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A unique identifier for this request. A random UUID is recommended. This request is
                    /// idempotent if and only if `request_id` is provided.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Mask specifying which fields in the cluster to update. All paths must be specified
                    /// explicitly - wildcards are not supported. At least one path must be provided.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.HypercomputeCluster.v1.Data.Cluster Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
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
                public virtual CancelRequest Cancel(Google.Apis.HypercomputeCluster.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.HypercomputeCluster.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.HypercomputeCluster.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.Empty>
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
                public class GetRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.Operation>
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
                public class ListRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.ListOperationsResponse>
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

                    /// <summary>
                    /// When set to `true`, operations that are reachable are returned as normal, and those that are
                    /// unreachable are returned in the ListOperationsResponse.unreachable field. This can only be
                    /// `true` when reading across collections. For example, when `parent` is set to
                    /// `"projects/example/locations/-"`. This field is not supported by default and will result in an
                    /// `UNIMPLEMENTED` error if set unless explicitly documented otherwise in service or product
                    /// specific documentation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

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
                        RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "returnPartialSuccess",
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
            public class GetRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.Location>
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
            public class ListRequest : HypercomputeClusterBaseServiceRequest<Google.Apis.HypercomputeCluster.v1.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field. It is unsupported and is ignored unless explicitly documented
                /// otherwise. This is primarily for internal usage.
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
namespace Google.Apis.HypercomputeCluster.v1.Data
{
    /// <summary>
    /// A [Persistent disk](https://cloud.google.com/compute/docs/disks) used as the boot disk for a Compute Engine VM
    /// instance.
    /// </summary>
    public class BootDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. Size of the disk in gigabytes. Must be at least 10GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<long> SizeGb { get; set; }

        /// <summary>
        /// Required. Immutable. [Persistent disk type](https://cloud.google.com/compute/docs/disks#disk-types), in the
        /// format `projects/{project}/zones/{zone}/diskTypes/{disk_type}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a [Google Cloud Storage](https://cloud.google.com/storage) bucket.</summary>
    public class BucketReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that cluster health check should be performed.</summary>
    public class CheckClusterHealth : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of virtual machines and connected resources forming a high-performance computing cluster capable of
    /// running large-scale, tightly coupled workloads. A cluster combines a set a compute resources that perform
    /// computations, storage resources that contain inputs and store outputs, an orchestrator that is responsible for
    /// assigning jobs to compute resources, and network resources that connect everything together.
    /// </summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Compute resources available to the cluster. Keys specify the ID of the compute resource by which
        /// it can be referenced elsewhere, and must conform to
        /// [RFC-1034](https://datatracker.ietf.org/doc/html/rfc1034) (lower-case, alphanumeric, and at most 63
        /// characters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeResources")]
        public virtual System.Collections.Generic.IDictionary<string, ComputeResource> ComputeResources { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time that the cluster was originally created.</summary>
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

        /// <summary>Optional. User-provided description of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. [Labels](https://cloud.google.com/compute/docs/labeling-resources) applied to the cluster. Labels
        /// can be used to organize clusters and to filter them in queries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. [Relative resource name](https://google.aip.dev/122) of the cluster, in the format
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Network resources available to the cluster. Must contain at most one value. Keys specify the ID of
        /// the network resource by which it can be referenced elsewhere, and must conform to
        /// [RFC-1034](https://datatracker.ietf.org/doc/html/rfc1034) (lower-case, alphanumeric, and at most 63
        /// characters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkResources")]
        public virtual System.Collections.Generic.IDictionary<string, NetworkResource> NetworkResources { get; set; }

        /// <summary>
        /// Optional. Orchestrator that is responsible for scheduling and running jobs on the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orchestrator")]
        public virtual Orchestrator Orchestrator { get; set; }

        /// <summary>
        /// Output only. Indicates whether changes to the cluster are currently in flight. If this is `true`, then the
        /// current state might not match the cluster's intended state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// Optional. Storage resources available to the cluster. Keys specify the ID of the storage resource by which
        /// it can be referenced elsewhere, and must conform to
        /// [RFC-1034](https://datatracker.ietf.org/doc/html/rfc1034) (lower-case, alphanumeric, and at most 63
        /// characters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageResources")]
        public virtual System.Collections.Generic.IDictionary<string, StorageResource> StorageResources { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time that the cluster was most recently updated.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a Compute Engine [instance](https://cloud.google.com/compute/docs/instances).</summary>
    public class ComputeInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the VM instance, in the format `projects/{project}/zones/{zone}/instances/{instance}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a SlurmNodeSet, indicates that the nodeset should be backed by Compute Engine VM instances.
    /// </summary>
    public class ComputeInstanceSlurmNodeSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Boot disk for the compute instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDisk")]
        public virtual BootDisk BootDisk { get; set; }

        /// <summary>
        /// Optional. [Labels](https://cloud.google.com/compute/docs/labeling-resources) that should be applied to each
        /// VM instance in the nodeset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. [Startup script](https://cloud.google.com/compute/docs/instances/startup-scripts/linux) to be run
        /// on each VM instance in the nodeset. Max 256KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startupScript")]
        public virtual string StartupScript { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource defining how virtual machines and accelerators should be provisioned for the cluster.
    /// </summary>
    public class ComputeResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Configuration for this compute resource, which describes how it should be created at
        /// runtime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual ComputeResourceConfig Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes how a compute resource should be created at runtime.</summary>
    public class ComputeResourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Immutable. If set, indicates that this resource should use flex-start VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newFlexStartInstances")]
        public virtual NewFlexStartInstancesConfig NewFlexStartInstances { get; set; }

        /// <summary>Optional. Immutable. If set, indicates that this resource should use on-demand VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newOnDemandInstances")]
        public virtual NewOnDemandInstancesConfig NewOnDemandInstances { get; set; }

        /// <summary>Optional. Immutable. If set, indicates that this resource should use reserved VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newReservedInstances")]
        public virtual NewReservedInstancesConfig NewReservedInstances { get; set; }

        /// <summary>Optional. Immutable. If set, indicates that this resource should use spot VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSpotInstances")]
        public virtual NewSpotInstancesConfig NewSpotInstances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a new filestore instance should be created.</summary>
    public class CreateFilestoreInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the Filestore instance, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filestore")]
        public virtual string Filestore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a login node should be created.</summary>
    public class CreateLoginNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a new lustre instance should be created.</summary>
    public class CreateLustreInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the Managed Lustre instance, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lustre")]
        public virtual string Lustre { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a new network should be created.</summary>
    public class CreateNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the network to create, in the format `projects/{project}/global/networks/{network}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a nodeset should be created.</summary>
    public class CreateNodeset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the nodeset to create</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodesets")]
        public virtual System.Collections.Generic.IList<string> Nodesets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that an orchestrator should be created.</summary>
    public class CreateOrchestrator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a partition should be created.</summary>
    public class CreatePartition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the partition to create</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IList<string> Partitions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a new private service access should be created.</summary>
    public class CreatePrivateServiceAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a new storage bucket should be created.</summary>
    public class CreateStorageBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a Filestore instance should be deleted.</summary>
    public class DeleteFilestoreInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the Filestore instance, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filestore")]
        public virtual string Filestore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a login node should be deleted.</summary>
    public class DeleteLoginNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a Lustre instance should be deleted.</summary>
    public class DeleteLustreInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the Managed Lustre instance, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lustre")]
        public virtual string Lustre { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates network deletion step with the resource name.</summary>
    public class DeleteNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the network to delete, in the format `projects/{project}/global/networks/{network}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a nodeset should be deleted.</summary>
    public class DeleteNodeset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the nodeset to delete</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodesets")]
        public virtual System.Collections.Generic.IList<string> Nodesets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that an orchestrator should be deleted.</summary>
    public class DeleteOrchestrator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a partition should be deleted.</summary>
    public class DeletePartition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the partition to delete</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IList<string> Partitions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates private service access deletion step.</summary>
    public class DeletePrivateServiceAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that Cloud Storage bucket should be deleted.</summary>
    public class DeleteStorageBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

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

    /// <summary>
    /// When set in a StorageResourceConfig, indicates that an existing [Google Cloud
    /// Storage](https://cloud.google.com/storage) bucket should be imported.
    /// </summary>
    public class ExistingBucketConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. Name of the Cloud Storage bucket to import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a StorageResourceConfig, indicates that an existing [Filestore](https://cloud.google.com/filestore)
    /// instance should be imported.
    /// </summary>
    public class ExistingFilestoreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Name of the Filestore instance to import, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filestore")]
        public virtual string Filestore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a StorageResourceConfig, indicates that an existing [Managed
    /// Lustre](https://cloud.google.com/products/managed-lustre) instance should be imported.
    /// </summary>
    public class ExistingLustreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Name of the Managed Lustre instance to import, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lustre")]
        public virtual string Lustre { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in a NetworkResourceConfig, indicates that an existing network should be imported.</summary>
    public class ExistingNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Name of the network to import, in the format
        /// `projects/{project}/global/networks/{network}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Required. Immutable. Particular subnetwork to use, in the format
        /// `projects/{project}/regions/{region}/subnetworks/{subnetwork}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing filestore configuration</summary>
    public class FileShareConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Size of the filestore in GB. Must be between 1024 and 102400, and must meet scalability
        /// requirements described at https://cloud.google.com/filestore/docs/service-tiers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityGb")]
        public virtual System.Nullable<long> CapacityGb { get; set; }

        /// <summary>Required. Filestore share location</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileShare")]
        public virtual string FileShare { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a [Filestore](https://cloud.google.com/filestore) instance.</summary>
    public class FilestoreReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the Filestore instance, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filestore")]
        public virtual string Filestore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing Google Cloud Storage autoclass configuration</summary>
    public class GcsAutoclassConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Enables Auto-class feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Optional. Terminal storage class of the autoclass bucket</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminalStorageClass")]
        public virtual string TerminalStorageClass { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing Google Cloud Storage hierarchical namespace configuration</summary>
    public class GcsHierarchicalNamespaceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Enables hierarchical namespace setup for the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListClusters.</summary>
    public class ListClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Clusters in the specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusters")]
        public virtual System.Collections.Generic.IList<Cluster> Clusters { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is absent, there are no
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

        /// <summary>
        /// Unordered list. Unreachable resources. Populated when the request sets
        /// `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to
        /// list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>A reference to a [Managed Lustre](https://cloud.google.com/products/managed-lustre) instance.</summary>
    public class LustreReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the Managed Lustre instance, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lustre")]
        public virtual string Lustre { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A reference to a [VPC network](https://cloud.google.com/vpc/docs/vpc) in Google Compute Engine.
    /// </summary>
    public class NetworkReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of the network, in the format `projects/{project}/global/networks/{network}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Output only. Name of the particular subnetwork being used by the cluster, in the format
        /// `projects/{project}/regions/{region}/subnetworks/{subnetwork}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource representing a network that connects the various components of a cluster together.</summary>
    public class NetworkResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Immutable. Configuration for this network resource, which describes how it should be created or imported.
        /// This field only controls how the network resource is initially created or imported. Subsequent changes to
        /// the network resource should be made via the resource's API and will not be reflected in the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual NetworkResourceConfig Config { get; set; }

        /// <summary>Reference to a network in Google Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual NetworkReference Network { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes how a network resource should be initialized. Each network resource can either be imported from an
    /// existing Google Cloud resource or initialized when the cluster is created.
    /// </summary>
    public class NetworkResourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Immutable. If set, indicates that an existing network should be imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingNetwork")]
        public virtual ExistingNetworkConfig ExistingNetwork { get; set; }

        /// <summary>Optional. Immutable. If set, indicates that a new network should be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newNetwork")]
        public virtual NewNetworkConfig NewNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a StorageResourceConfig, indicates that a new [Google Cloud
    /// Storage](https://cloud.google.com/storage) bucket should be created.
    /// </summary>
    public class NewBucketConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. If set, indicates that the bucket should use
        /// [Autoclass](https://cloud.google.com/storage/docs/autoclass).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoclass")]
        public virtual GcsAutoclassConfig Autoclass { get; set; }

        /// <summary>Required. Immutable. Name of the Cloud Storage bucket to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Optional. Immutable. If set, indicates that the bucket should use [hierarchical
        /// namespaces](https://cloud.google.com/storage/docs/hns-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hierarchicalNamespace")]
        public virtual GcsHierarchicalNamespaceConfig HierarchicalNamespace { get; set; }

        /// <summary>
        /// Optional. Immutable. If set, uses the provided storage class as the bucket's default storage class.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageClass")]
        public virtual string StorageClass { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a StorageResourceConfig, indicates that a new [Filestore](https://cloud.google.com/filestore)
    /// instance should be created.
    /// </summary>
    public class NewFilestoreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Immutable. Description of the instance. Maximum of 2048 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Immutable. File system shares on the instance. Exactly one file share must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileShares")]
        public virtual System.Collections.Generic.IList<FileShareConfig> FileShares { get; set; }

        /// <summary>
        /// Required. Immutable. Name of the Filestore instance to create, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filestore")]
        public virtual string Filestore { get; set; }

        /// <summary>
        /// Optional. Immutable. Access protocol to use for all file shares in the instance. Defaults to NFS V3 if not
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Required. Immutable. Service tier to use for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a ComputeResourceConfig, indicates that VM instances should be created using [Flex
    /// Start](https://cloud.google.com/compute/docs/instances/provisioning-models).
    /// </summary>
    public class NewFlexStartInstancesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Name of the Compute Engine [machine
        /// type](https://cloud.google.com/compute/docs/machine-resource) to use, e.g. `n2-standard-2`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Required. Immutable. Specifies the time limit for created instances. Instances will be terminated at the end
        /// of this duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDuration")]
        public virtual object MaxDuration { get; set; }

        /// <summary>
        /// Required. Immutable. Name of the zone in which VM instances should run, e.g., `us-central1-a`. Must be in
        /// the same region as the cluster, and must match the zone of any other resources specified in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a StorageResourceConfig, indicates that a new [Managed
    /// Lustre](https://cloud.google.com/products/managed-lustre) instance should be created.
    /// </summary>
    public class NewLustreConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Storage capacity of the instance in gibibytes (GiB). Allowed values are between 18000
        /// and 7632000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacityGb")]
        public virtual System.Nullable<long> CapacityGb { get; set; }

        /// <summary>
        /// Optional. Immutable. Description of the Managed Lustre instance. Maximum of 2048 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Immutable. Filesystem name for this instance. This name is used by client-side tools, including
        /// when mounting the instance. Must be 8 characters or less and can only contain letters and numbers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesystem")]
        public virtual string Filesystem { get; set; }

        /// <summary>
        /// Required. Immutable. Name of the Managed Lustre instance to create, in the format
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lustre")]
        public virtual string Lustre { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in a NetworkResourceConfig, indicates that a new network should be created.</summary>
    public class NewNetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Immutable. Description of the network. Maximum of 2048 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Immutable. Name of the network to create, in the format
        /// `projects/{project}/global/networks/{network}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a ComputeResourceConfig, indicates that on-demand (i.e., using the standard provisioning model) VM
    /// instances should be created.
    /// </summary>
    public class NewOnDemandInstancesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Name of the Compute Engine [machine
        /// type](https://cloud.google.com/compute/docs/machine-resource) to use, e.g. `n2-standard-2`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Required. Immutable. Name of the zone in which VM instances should run, e.g., `us-central1-a`. Must be in
        /// the same region as the cluster, and must match the zone of any other resources specified in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a ComputeResourceConfig, indicates that VM instances should be created from a
    /// [reservation](https://cloud.google.com/compute/docs/instances/reservations-overview).
    /// </summary>
    public class NewReservedInstancesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. Name of the reservation from which VM instances should be created, in the format
        /// `projects/{project}/zones/{zone}/reservations/{reservation}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservation")]
        public virtual string Reservation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in a ComputeResourceConfig, indicates that [spot
    /// VM](https://cloud.google.com/compute/docs/instances/spot) instances should be created.
    /// </summary>
    public class NewSpotInstancesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Name of the Compute Engine [machine
        /// type](https://cloud.google.com/compute/docs/machine-resource) to use, e.g. `n2-standard-2`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Optional. Specifies the termination action of the instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminationAction")]
        public virtual string TerminationAction { get; set; }

        /// <summary>
        /// Required. Immutable. Name of the zone in which VM instances should run, e.g., `us-central1-a`. Must be in
        /// the same region as the cluster, and must match the zone of any other resources specified in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

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

        /// <summary>Output only. Progress of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual OperationProgress Progress { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing the progress of a cluster mutation long-running operation. operation.</summary>
    public class OperationProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Steps and status of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<OperationStep> Steps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing the status of a single step in a cluster mutation long-running operation.</summary>
    public class OperationStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. If set, indicates that cluster health check is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkClusterHealth")]
        public virtual CheckClusterHealth CheckClusterHealth { get; set; }

        /// <summary>
        /// Output only. If set, indicates that new Filestore instance creation is part of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createFilestoreInstance")]
        public virtual CreateFilestoreInstance CreateFilestoreInstance { get; set; }

        /// <summary>Output only. If set, indicates that new login node creation is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createLoginNode")]
        public virtual CreateLoginNode CreateLoginNode { get; set; }

        /// <summary>
        /// Output only. If set, indicates that new Lustre instance creation is part of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createLustreInstance")]
        public virtual CreateLustreInstance CreateLustreInstance { get; set; }

        /// <summary>Output only. If set, indicates that new network creation is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createNetwork")]
        public virtual CreateNetwork CreateNetwork { get; set; }

        /// <summary>Output only. If set, indicates that new nodeset creation is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createNodeset")]
        public virtual CreateNodeset CreateNodeset { get; set; }

        /// <summary>Output only. If set, indicates that orchestrator creation is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createOrchestrator")]
        public virtual CreateOrchestrator CreateOrchestrator { get; set; }

        /// <summary>Output only. If set, indicates that new partition creation is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createPartition")]
        public virtual CreatePartition CreatePartition { get; set; }

        /// <summary>
        /// Output only. If set, indicates that new private service access creation is part of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createPrivateServiceAccess")]
        public virtual CreatePrivateServiceAccess CreatePrivateServiceAccess { get; set; }

        /// <summary>
        /// Output only. If set, indicates that new Cloud Storage bucket creation is part of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createStorageBucket")]
        public virtual CreateStorageBucket CreateStorageBucket { get; set; }

        /// <summary>Output only. If set, indicates that Filestore instance deletion is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteFilestoreInstance")]
        public virtual DeleteFilestoreInstance DeleteFilestoreInstance { get; set; }

        /// <summary>Output only. If set, indicates that login node deletion is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteLoginNode")]
        public virtual DeleteLoginNode DeleteLoginNode { get; set; }

        /// <summary>Output only. If set, indicates that Lustre instance deletion is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteLustreInstance")]
        public virtual DeleteLustreInstance DeleteLustreInstance { get; set; }

        /// <summary>Output only. If set, indicates that network deletion is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteNetwork")]
        public virtual DeleteNetwork DeleteNetwork { get; set; }

        /// <summary>Output only. If set, indicates that nodeset deletion is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteNodeset")]
        public virtual DeleteNodeset DeleteNodeset { get; set; }

        /// <summary>Output only. If set, indicates that orchestrator deletion is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteOrchestrator")]
        public virtual DeleteOrchestrator DeleteOrchestrator { get; set; }

        /// <summary>Output only. If set, indicates that partition deletion is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletePartition")]
        public virtual DeletePartition DeletePartition { get; set; }

        /// <summary>
        /// Output only. If set, indicates that private service access deletion is part of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletePrivateServiceAccess")]
        public virtual DeletePrivateServiceAccess DeletePrivateServiceAccess { get; set; }

        /// <summary>
        /// Output only. If set, indicates that Cloud Storage bucket deletion is part of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteStorageBucket")]
        public virtual DeleteStorageBucket DeleteStorageBucket { get; set; }

        /// <summary>Output only. State of the operation step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. If set, indicates that login node update is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateLoginNode")]
        public virtual UpdateLoginNode UpdateLoginNode { get; set; }

        /// <summary>Output only. If set, indicates that nodeset update is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateNodeset")]
        public virtual UpdateNodeset UpdateNodeset { get; set; }

        /// <summary>Output only. If set, indicates that an orchestrator update is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateOrchestrator")]
        public virtual UpdateOrchestrator UpdateOrchestrator { get; set; }

        /// <summary>Output only. If set, indicates that partition update is part of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePartition")]
        public virtual UpdatePartition UpdatePartition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The component responsible for scheduling and running workloads on the cluster as well as providing the user
    /// interface for interacting with the cluster at runtime.
    /// </summary>
    public class Orchestrator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set, indicates that the cluster should use Slurm as the orchestrator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slurm")]
        public virtual SlurmOrchestrator Slurm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for Slurm [login nodes](https://slurm.schedmd.com/quickstart_admin.html#login) in the cluster.
    /// Login nodes are Compute Engine VM instances that allow users to access the cluster over SSH.
    /// </summary>
    public class SlurmLoginNodes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Boot disk for the login node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDisk")]
        public virtual BootDisk BootDisk { get; set; }

        /// <summary>Required. Number of login node instances to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// Optional. Whether [OS Login](https://cloud.google.com/compute/docs/oslogin) should be enabled on login node
        /// instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableOsLogin")]
        public virtual System.Nullable<bool> EnableOsLogin { get; set; }

        /// <summary>
        /// Optional. Whether login node instances should be assigned [external IP
        /// addresses](https://cloud.google.com/compute/docs/ip-addresses#externaladdresses).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePublicIps")]
        public virtual System.Nullable<bool> EnablePublicIps { get; set; }

        /// <summary>
        /// Output only. Information about the login node instances that were created in Compute Engine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<ComputeInstance> Instances { get; set; }

        /// <summary>
        /// Optional. [Labels](https://cloud.google.com/compute/docs/labeling-resources) that should be applied to each
        /// login node instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. Name of the Compute Engine [machine type](https://cloud.google.com/compute/docs/machine-resource)
        /// to use for login nodes, e.g. `n2-standard-2`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. [Startup script](https://cloud.google.com/compute/docs/instances/startup-scripts/linux) to be run
        /// on each login node instance. Max 256KB. The script must complete within the system-defined default timeout
        /// of 5 minutes. For tasks that require more time, consider running them in the background using methods such
        /// as `&amp;amp;` or `nohup`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startupScript")]
        public virtual string StartupScript { get; set; }

        /// <summary>Optional. How storage resources should be mounted on each login node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageConfigs")]
        public virtual System.Collections.Generic.IList<StorageConfig> StorageConfigs { get; set; }

        /// <summary>
        /// Required. Name of the zone in which login nodes should run, e.g., `us-central1-a`. Must be in the same
        /// region as the cluster, and must match the zone of any other resources specified in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for Slurm nodesets in the cluster. Nodesets are groups of compute nodes used by Slurm that are
    /// responsible for running workloads submitted to the cluster.
    /// </summary>
    public class SlurmNodeSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. ID of the compute resource on which this nodeset will run. Must match a key in the cluster's
        /// [compute_resources](Cluster.compute_resources).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeId")]
        public virtual string ComputeId { get; set; }

        /// <summary>
        /// Optional. If set, indicates that the nodeset should be backed by Compute Engine instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeInstance")]
        public virtual ComputeInstanceSlurmNodeSet ComputeInstance { get; set; }

        /// <summary>
        /// Required. Identifier for the nodeset, which allows it to be referenced by partitions. Must conform to
        /// [RFC-1034](https://datatracker.ietf.org/doc/html/rfc1034) (lower-case, alphanumeric, and at most 63
        /// characters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. Controls how many additional nodes a cluster can bring online to handle workloads. Set this value
        /// to enable dynamic node creation and limit the number of additional nodes the cluster can bring online. Leave
        /// empty if you do not want the cluster to create nodes dynamically, and instead rely only on static nodes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDynamicNodeCount")]
        public virtual System.Nullable<long> MaxDynamicNodeCount { get; set; }

        /// <summary>
        /// Optional. Number of nodes to be statically created for this nodeset. The cluster will attempt to ensure that
        /// at least this many nodes exist at all times.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticNodeCount")]
        public virtual System.Nullable<long> StaticNodeCount { get; set; }

        /// <summary>Optional. How storage resources should be mounted on each compute node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageConfigs")]
        public virtual System.Collections.Generic.IList<StorageConfig> StorageConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When set in Orchestrator, indicates that the cluster should use [Slurm](https://slurm.schedmd.com/) as the
    /// orchestrator.
    /// </summary>
    public class SlurmOrchestrator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Default partition to use for submitted jobs that do not explicitly specify a partition. Required
        /// if and only if there is more than one partition, in which case it must match the id of one of the
        /// partitions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPartition")]
        public virtual string DefaultPartition { get; set; }

        /// <summary>
        /// Optional. Slurm [epilog scripts](https://slurm.schedmd.com/prolog_epilog.html), which will be executed by
        /// compute nodes whenever a node finishes running a job. Values must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("epilogBashScripts")]
        public virtual System.Collections.Generic.IList<string> EpilogBashScripts { get; set; }

        /// <summary>
        /// Required. Configuration for login nodes, which allow users to access the cluster over SSH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginNodes")]
        public virtual SlurmLoginNodes LoginNodes { get; set; }

        /// <summary>
        /// Required. Configuration of Slurm nodesets, which define groups of compute resources that can be used by
        /// Slurm. At least one compute node is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSets")]
        public virtual System.Collections.Generic.IList<SlurmNodeSet> NodeSets { get; set; }

        /// <summary>
        /// Required. Configuration of Slurm partitions, which group one or more nodesets. Acts as a queue against which
        /// jobs can be submitted. At least one partition is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IList<SlurmPartition> Partitions { get; set; }

        /// <summary>
        /// Optional. Slurm [prolog scripts](https://slurm.schedmd.com/prolog_epilog.html), which will be executed by
        /// compute nodes before a node begins running a new job. Values must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prologBashScripts")]
        public virtual System.Collections.Generic.IList<string> PrologBashScripts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for Slurm partitions in the cluster. Partitions are groups of nodesets, and are how clients
    /// specify where their workloads should be run.
    /// </summary>
    public class SlurmPartition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. ID of the partition, which is how users will identify it. Must conform to
        /// [RFC-1034](https://datatracker.ietf.org/doc/html/rfc1034) (lower-case, alphanumeric, and at most 63
        /// characters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. IDs of the nodesets that make up this partition. Values must match SlurmNodeSet.id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSetIds")]
        public virtual System.Collections.Generic.IList<string> NodeSetIds { get; set; }

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

    /// <summary>Description of how a storage resource should be mounted on a VM instance.</summary>
    public class StorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. ID of the storage resource to mount, which must match a key in the cluster's
        /// [storage_resources](Cluster.storage_resources).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. A directory inside the VM instance's file system where the storage resource should be mounted
        /// (e.g., `/mnt/share`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localMount")]
        public virtual string LocalMount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource representing a form of persistent storage that is accessible to compute resources in the cluster.
    /// </summary>
    public class StorageResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reference to a Google Cloud Storage bucket. Populated if and only if the storage resource was configured to
        /// use Google Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual BucketReference Bucket { get; set; }

        /// <summary>
        /// Required. Immutable. Configuration for this storage resource, which describes how it should be created or
        /// imported. This field only controls how the storage resource is initially created or imported. Subsequent
        /// changes to the storage resource should be made via the resource's API and will not be reflected in the
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual StorageResourceConfig Config { get; set; }

        /// <summary>
        /// Reference to a Filestore instance. Populated if and only if the storage resource was configured to use
        /// Filestore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filestore")]
        public virtual FilestoreReference Filestore { get; set; }

        /// <summary>
        /// Reference to a Managed Lustre instance. Populated if and only if the storage resource was configured to use
        /// Managed Lustre.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lustre")]
        public virtual LustreReference Lustre { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes how a storage resource should be initialized. Each storage resource can either be imported from an
    /// existing Google Cloud resource or initialized when the cluster is created.
    /// </summary>
    public class StorageResourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. If set, indicates that an existing Cloud Storage bucket should be imported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingBucket")]
        public virtual ExistingBucketConfig ExistingBucket { get; set; }

        /// <summary>
        /// Optional. Immutable. If set, indicates that an existing Filestore instance should be imported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingFilestore")]
        public virtual ExistingFilestoreConfig ExistingFilestore { get; set; }

        /// <summary>
        /// Optional. Immutable. If set, indicates that an existing Managed Lustre instance should be imported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingLustre")]
        public virtual ExistingLustreConfig ExistingLustre { get; set; }

        /// <summary>Optional. Immutable. If set, indicates that a new Cloud Storage bucket should be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newBucket")]
        public virtual NewBucketConfig NewBucket { get; set; }

        /// <summary>Optional. Immutable. If set, indicates that a new Filestore instance should be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newFilestore")]
        public virtual NewFilestoreConfig NewFilestore { get; set; }

        /// <summary>
        /// Optional. Immutable. If set, indicates that a new Managed Lustre instance should be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newLustre")]
        public virtual NewLustreConfig NewLustre { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a login node should be updated.</summary>
    public class UpdateLoginNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a nodeset should be updated.</summary>
    public class UpdateNodeset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the nodeset to update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodesets")]
        public virtual System.Collections.Generic.IList<string> Nodesets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that an orchestrator should be updated.</summary>
    public class UpdateOrchestrator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>When set in OperationStep, indicates that a partition should be updated.</summary>
    public class UpdatePartition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the partition to update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitions")]
        public virtual System.Collections.Generic.IList<string> Partitions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
