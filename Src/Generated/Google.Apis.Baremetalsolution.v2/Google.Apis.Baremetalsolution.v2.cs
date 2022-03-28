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

namespace Google.Apis.Baremetalsolution.v2
{
    /// <summary>The Baremetalsolution Service.</summary>
    public class BaremetalsolutionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BaremetalsolutionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BaremetalsolutionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "baremetalsolution";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://baremetalsolution.googleapis.com/";
        #else
            "https://baremetalsolution.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://baremetalsolution.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Bare Metal Solution API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Bare Metal Solution API.</summary>
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

    /// <summary>A base abstract class for Baremetalsolution requests.</summary>
    public abstract class BaremetalsolutionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BaremetalsolutionBaseServiceRequest instance.</summary>
        protected BaremetalsolutionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Baremetalsolution parameter list.</summary>
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
                Instances = new InstancesResource(service);
                Networks = new NetworksResource(service);
                NfsShares = new NfsSharesResource(service);
                ProvisioningConfigs = new ProvisioningConfigsResource(service);
                ProvisioningQuotas = new ProvisioningQuotasResource(service);
                SnapshotSchedulePolicies = new SnapshotSchedulePoliciesResource(service);
                Volumes = new VolumesResource(service);
            }

            /// <summary>Gets the Instances resource.</summary>
            public virtual InstancesResource Instances { get; }

            /// <summary>The "instances" collection of methods.</summary>
            public class InstancesResource
            {
                private const string Resource = "instances";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstancesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get details about a single server.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get details about a single server.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Instance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>List servers in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for ListInstancesRequest.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List servers in a given project and location.</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListInstancesRequest.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, the server
                    /// will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results from the server.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/instances";

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
                    }
                }

                /// <summary>Update details of a single server.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of this `Instance`. Resource names are schemeless URIs that follow
                /// the conventions in https://cloud.google.com/apis/design/resource_names. Format:
                /// `projects/{project}/locations/{location}/instances/{instance}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Baremetalsolution.v2.Data.Instance body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update details of a single server.</summary>
                public class PatchRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.Instance body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of this `Instance`. Resource names are schemeless URIs that
                    /// follow the conventions in https://cloud.google.com/apis/design/resource_names. Format:
                    /// `projects/{project}/locations/{location}/instances/{instance}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of fields to update. The only currently supported fields are: `labels`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.Instance Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the power off and then turning
                /// it back on.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual ResetRequest Reset(Google.Apis.Baremetalsolution.v2.Data.ResetInstanceRequest body, string name)
                {
                    return new ResetRequest(service, body, name);
                }

                /// <summary>
                /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the power off and then turning
                /// it back on.
                /// </summary>
                public class ResetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Reset request.</summary>
                    public ResetRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.ResetInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.ResetInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reset";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:reset";

                    /// <summary>Initializes Reset parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts a server that was shutdown.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual StartRequest Start(Google.Apis.Baremetalsolution.v2.Data.StartInstanceRequest body, string name)
                {
                    return new StartRequest(service, body, name);
                }

                /// <summary>Starts a server that was shutdown.</summary>
                public class StartRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Start request.</summary>
                    public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.StartInstanceRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.StartInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "start";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:start";

                    /// <summary>Initializes Start parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Networks resource.</summary>
            public virtual NetworksResource Networks { get; }

            /// <summary>The "networks" collection of methods.</summary>
            public class NetworksResource
            {
                private const string Resource = "networks";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NetworksResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get details of a single network.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get details of a single network.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Network>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networks/[^/]+$",
                        });
                    }
                }

                /// <summary>List network in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for ListNetworksRequest.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List network in a given project and location.</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListNetworksResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListNetworksRequest.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Requested page size. The server might return fewer items than requested. If unspecified, server
                    /// will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results from the server.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/networks";

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
                    }
                }

                /// <summary>
                /// List all Networks (and used IPs for each Network) in the vendor account associated with the
                /// specified project.
                /// </summary>
                /// <param name="location">Required. Parent value (project and location).</param>
                public virtual ListNetworkUsageRequest ListNetworkUsage(string location)
                {
                    return new ListNetworkUsageRequest(service, location);
                }

                /// <summary>
                /// List all Networks (and used IPs for each Network) in the vendor account associated with the
                /// specified project.
                /// </summary>
                public class ListNetworkUsageRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListNetworkUsageResponse>
                {
                    /// <summary>Constructs a new ListNetworkUsage request.</summary>
                    public ListNetworkUsageRequest(Google.Apis.Services.IClientService service, string location) : base(service)
                    {
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value (project and location).</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listNetworkUsage";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+location}/networks:listNetworkUsage";

                    /// <summary>Initializes ListNetworkUsage parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Update details of a single network.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of this `Network`. Resource names are schemeless URIs that follow the
                /// conventions in https://cloud.google.com/apis/design/resource_names. Format:
                /// `projects/{project}/locations/{location}/networks/{network}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Baremetalsolution.v2.Data.Network body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update details of a single network.</summary>
                public class PatchRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.Network body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of this `Network`. Resource names are schemeless URIs that follow
                    /// the conventions in https://cloud.google.com/apis/design/resource_names. Format:
                    /// `projects/{project}/locations/{location}/networks/{network}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of fields to update. The only currently supported fields are: `labels`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.Network Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/networks/[^/]+$",
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

            /// <summary>Gets the NfsShares resource.</summary>
            public virtual NfsSharesResource NfsShares { get; }

            /// <summary>The "nfsShares" collection of methods.</summary>
            public class NfsSharesResource
            {
                private const string Resource = "nfsShares";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public NfsSharesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get details of a single NFS share.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get details of a single NFS share.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.NfsShare>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/nfsShares/[^/]+$",
                        });
                    }
                }

                /// <summary>List NFS shares.</summary>
                /// <param name="parent">Required. Parent value for ListNfsSharesRequest.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List NFS shares.</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListNfsSharesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListNfsSharesRequest.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Requested page size. The server might return fewer items than requested. If unspecified, server
                    /// will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results from the server.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/nfsShares";

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
                    }
                }

                /// <summary>Update details of a single NFS share.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The name of the NFS share.</param>
                public virtual PatchRequest Patch(Google.Apis.Baremetalsolution.v2.Data.NfsShare body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update details of a single NFS share.</summary>
                public class PatchRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.NfsShare body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The name of the NFS share.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of fields to update. The only currently supported fields are: `labels`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.NfsShare Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/nfsShares/[^/]+$",
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

            /// <summary>Gets the ProvisioningConfigs resource.</summary>
            public virtual ProvisioningConfigsResource ProvisioningConfigs { get; }

            /// <summary>The "provisioningConfigs" collection of methods.</summary>
            public class ProvisioningConfigsResource
            {
                private const string Resource = "provisioningConfigs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ProvisioningConfigsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create new ProvisioningConfig.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent project and location containing the ProvisioningConfig.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Create new ProvisioningConfig.</summary>
                public class CreateRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent project and location containing the ProvisioningConfig.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Email provided to send a confirmation with provisioning config to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("email", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Email { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/provisioningConfigs";

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
                        RequestParameters.Add("email", new Google.Apis.Discovery.Parameter
                        {
                            Name = "email",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Get ProvisioningConfig by name.</summary>
                /// <param name="name">Required. Name of the ProvisioningConfig.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get ProvisioningConfig by name.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the ProvisioningConfig.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/provisioningConfigs/[^/]+$",
                        });
                    }
                }

                /// <summary>Update existing ProvisioningConfig.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The name of the provisioning config.</param>
                public virtual PatchRequest Patch(Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update existing ProvisioningConfig.</summary>
                public class PatchRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The name of the provisioning config.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. Email provided to send a confirmation with provisioning config to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("email", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Email { get; set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.ProvisioningConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/provisioningConfigs/[^/]+$",
                        });
                        RequestParameters.Add("email", new Google.Apis.Discovery.Parameter
                        {
                            Name = "email",
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

                /// <summary>Submit a provisiong configuration for a given project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent project and location containing the ProvisioningConfig.
                /// </param>
                public virtual SubmitRequest Submit(Google.Apis.Baremetalsolution.v2.Data.SubmitProvisioningConfigRequest body, string parent)
                {
                    return new SubmitRequest(service, body, parent);
                }

                /// <summary>Submit a provisiong configuration for a given project.</summary>
                public class SubmitRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.SubmitProvisioningConfigResponse>
                {
                    /// <summary>Constructs a new Submit request.</summary>
                    public SubmitRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.SubmitProvisioningConfigRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent project and location containing the ProvisioningConfig.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.SubmitProvisioningConfigRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "submit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/provisioningConfigs:submit";

                    /// <summary>Initializes Submit parameter list.</summary>
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

            /// <summary>Gets the ProvisioningQuotas resource.</summary>
            public virtual ProvisioningQuotasResource ProvisioningQuotas { get; }

            /// <summary>The "provisioningQuotas" collection of methods.</summary>
            public class ProvisioningQuotasResource
            {
                private const string Resource = "provisioningQuotas";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ProvisioningQuotasResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List the budget details to provision resources on a given project.</summary>
                /// <param name="parent">Required. Parent value for ListProvisioningQuotasRequest.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List the budget details to provision resources on a given project.</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListProvisioningQuotasResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListProvisioningQuotasRequest.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Requested page size. The server might return fewer items than requested. If unspecified, server
                    /// will pick an appropriate default. Notice that page_size field is not supported and won't be
                    /// respected in the API request for now, will be updated when pagination is supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results from the server.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/provisioningQuotas";

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

            /// <summary>Gets the SnapshotSchedulePolicies resource.</summary>
            public virtual SnapshotSchedulePoliciesResource SnapshotSchedulePolicies { get; }

            /// <summary>The "snapshotSchedulePolicies" collection of methods.</summary>
            public class SnapshotSchedulePoliciesResource
            {
                private const string Resource = "snapshotSchedulePolicies";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SnapshotSchedulePoliciesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Create a snapshot schedule policy in the specified project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent project and location containing the SnapshotSchedulePolicy.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Create a snapshot schedule policy in the specified project.</summary>
                public class CreateRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project and location containing the SnapshotSchedulePolicy.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Snapshot policy ID</summary>
                    [Google.Apis.Util.RequestParameterAttribute("snapshotSchedulePolicyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string SnapshotSchedulePolicyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/snapshotSchedulePolicies";

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
                        RequestParameters.Add("snapshotSchedulePolicyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "snapshotSchedulePolicyId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Delete a named snapshot schedule policy.</summary>
                /// <param name="name">Required. The name of the snapshot schedule policy to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Delete a named snapshot schedule policy.</summary>
                public class DeleteRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the snapshot schedule policy to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/snapshotSchedulePolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>Get details of a single snapshot schedule policy.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get details of a single snapshot schedule policy.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/snapshotSchedulePolicies/[^/]+$",
                        });
                    }
                }

                /// <summary>List snapshot schedule policies in a given project and location.</summary>
                /// <param name="parent">Required. The parent project containing the Snapshot Schedule Policies.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List snapshot schedule policies in a given project and location.</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListSnapshotSchedulePoliciesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent project containing the Snapshot Schedule Policies.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/snapshotSchedulePolicies";

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
                    }
                }

                /// <summary>Update a snapshot schedule policy in the specified project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The name of the snapshot schedule policy.</param>
                public virtual PatchRequest Patch(Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update a snapshot schedule policy in the specified project.</summary>
                public class PatchRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The name of the snapshot schedule policy.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.SnapshotSchedulePolicy Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/snapshotSchedulePolicies/[^/]+$",
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

            /// <summary>Gets the Volumes resource.</summary>
            public virtual VolumesResource Volumes { get; }

            /// <summary>The "volumes" collection of methods.</summary>
            public class VolumesResource
            {
                private const string Resource = "volumes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VolumesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Luns = new LunsResource(service);
                    Snapshots = new SnapshotsResource(service);
                }

                /// <summary>Gets the Luns resource.</summary>
                public virtual LunsResource Luns { get; }

                /// <summary>The "luns" collection of methods.</summary>
                public class LunsResource
                {
                    private const string Resource = "luns";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public LunsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Get details of a single storage logical unit number(LUN).</summary>
                    /// <param name="name">Required. Name of the resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get details of a single storage logical unit number(LUN).</summary>
                    public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Lun>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/luns/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List storage volume luns for given storage volume.</summary>
                    /// <param name="parent">Required. Parent value for ListLunsRequest.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List storage volume luns for given storage volume.</summary>
                    public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListLunsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value for ListLunsRequest.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Requested page size. The server might return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A token identifying a page of results from the server.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/luns";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

                /// <summary>Gets the Snapshots resource.</summary>
                public virtual SnapshotsResource Snapshots { get; }

                /// <summary>The "snapshots" collection of methods.</summary>
                public class SnapshotsResource
                {
                    private const string Resource = "snapshots";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SnapshotsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Create a storage volume snapshot in a containing volume.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The volume to snapshot.</param>
                    public virtual CreateRequest Create(Google.Apis.Baremetalsolution.v2.Data.VolumeSnapshot body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Create a storage volume snapshot in a containing volume.</summary>
                    public class CreateRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.VolumeSnapshot>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.VolumeSnapshot body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The volume to snapshot.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Baremetalsolution.v2.Data.VolumeSnapshot Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/snapshots";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a storage volume snapshot for a given volume.</summary>
                    /// <param name="name">Required. The name of the snapshot to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a storage volume snapshot for a given volume.</summary>
                    public class DeleteRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the snapshot to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Get details of a single storage volume snapshot.</summary>
                    /// <param name="name">Required. Name of the resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get details of a single storage volume snapshot.</summary>
                    public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.VolumeSnapshot>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List storage volume snapshots for given storage volume.</summary>
                    /// <param name="parent">Required. Parent value for ListVolumesRequest.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List storage volume snapshots for given storage volume.</summary>
                    public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListVolumeSnapshotsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value for ListVolumesRequest.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Requested page size. The server might return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A token identifying a page of results from the server.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/snapshots";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

                    /// <summary>Restore a storage volume snapshot to its containing volume.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="volumeSnapshot">Required. Name of the resource.</param>
                    public virtual RestoreVolumeSnapshotRequest RestoreVolumeSnapshot(Google.Apis.Baremetalsolution.v2.Data.RestoreVolumeSnapshotRequest body, string volumeSnapshot)
                    {
                        return new RestoreVolumeSnapshotRequest(service, body, volumeSnapshot);
                    }

                    /// <summary>Restore a storage volume snapshot to its containing volume.</summary>
                    public class RestoreVolumeSnapshotRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Operation>
                    {
                        /// <summary>Constructs a new RestoreVolumeSnapshot request.</summary>
                        public RestoreVolumeSnapshotRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.RestoreVolumeSnapshotRequest body, string volumeSnapshot) : base(service)
                        {
                            VolumeSnapshot = volumeSnapshot;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("volumeSnapshot", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string VolumeSnapshot { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Baremetalsolution.v2.Data.RestoreVolumeSnapshotRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "restoreVolumeSnapshot";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+volumeSnapshot}:restoreVolumeSnapshot";

                        /// <summary>Initializes RestoreVolumeSnapshot parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("volumeSnapshot", new Google.Apis.Discovery.Parameter
                            {
                                Name = "volumeSnapshot",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Get details of a single storage volume.</summary>
                /// <param name="name">Required. Name of the resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get details of a single storage volume.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Volume>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
                        });
                    }
                }

                /// <summary>List storage volumes in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for ListVolumesRequest.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List storage volumes in a given project and location.</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListVolumesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListVolumesRequest.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>List filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Requested page size. The server might return fewer items than requested. If unspecified, server
                    /// will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results from the server.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/volumes";

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
                    }
                }

                /// <summary>Update details of a single storage volume.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of this `Volume`. Resource names are schemeless URIs that follow the
                /// conventions in https://cloud.google.com/apis/design/resource_names. Format:
                /// `projects/{project}/locations/{location}/volumes/{volume}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Baremetalsolution.v2.Data.Volume body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update details of a single storage volume.</summary>
                public class PatchRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v2.Data.Volume body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of this `Volume`. Resource names are schemeless URIs that follow
                    /// the conventions in https://cloud.google.com/apis/design/resource_names. Format:
                    /// `projects/{project}/locations/{location}/volumes/{volume}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of fields to update. The only currently supported fields are:
                    /// `snapshot_auto_delete_behavior` `snapshot_schedule_policy_name` 'labels' 'requested_size_gib'
                    /// 'snapshot_enabled' 'snapshot_reservation_detail.reserved_space_percent'
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v2.Data.Volume Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.Location>
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
                public override string RestPath => "v2/{+name}";

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
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v2.Data.ListLocationsResponse>
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in [AIP-160](https://google.aip.dev/160).
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
                public override string RestPath => "v2/{+name}/locations";

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
namespace Google.Apis.Baremetalsolution.v2.Data
{
    /// <summary>Represents an 'access point' for the share.</summary>
    public class AllowedClient : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow dev flag. Which controls whether to allow creation of devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowDev")]
        public virtual System.Nullable<bool> AllowDev { get; set; }

        /// <summary>Allow the setuid flag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowSuid")]
        public virtual System.Nullable<bool> AllowSuid { get; set; }

        /// <summary>The subnet of IP addresses permitted to access the share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedClientsCidr")]
        public virtual string AllowedClientsCidr { get; set; }

        /// <summary>Mount permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPermissions")]
        public virtual string MountPermissions { get; set; }

        /// <summary>The network the access point sits on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Disable root squashing, which is a feature of NFS. Root squash is a special mapping of the remote superuser
        /// (root) identity when using identity authentication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noRootSquash")]
        public virtual System.Nullable<bool> NoRootSquash { get; set; }

        /// <summary>The IP address of the share on this network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareIp")]
        public virtual string ShareIp { get; set; }

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

    /// <summary>A server.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Create a time stamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// True if you enable hyperthreading for the server, otherwise false. The default value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreadingEnabled")]
        public virtual System.Nullable<bool> HyperthreadingEnabled { get; set; }

        /// <summary>An identifier for the `Instance`, generated by the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// True if the interactive serial console feature is enabled for the instance, false otherwise. The default
        /// value is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interactiveSerialConsoleEnabled")]
        public virtual System.Nullable<bool> InteractiveSerialConsoleEnabled { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>List of LUNs associated with this server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("luns")]
        public virtual System.Collections.Generic.IList<Lun> Luns { get; set; }

        /// <summary>
        /// The server type. [Available server
        /// types](https://cloud.google.com/bare-metal/docs/bms-planning#server_configurations)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Output only. The resource name of this `Instance`. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List of networks associated with this server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<Network> Networks { get; set; }

        /// <summary>The state of the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Update a time stamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration parameters for a new instance.</summary>
    public class InstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true networks can be from different projects of the same vendor account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountNetworksEnabled")]
        public virtual System.Nullable<bool> AccountNetworksEnabled { get; set; }

        /// <summary>Client network address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientNetwork")]
        public virtual NetworkAddress ClientNetwork { get; set; }

        /// <summary>Whether the instance should be provisioned with Hyperthreading enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreading")]
        public virtual System.Nullable<bool> Hyperthreading { get; set; }

        /// <summary>
        /// A transient unique identifier to idenfity an instance within an ProvisioningConfig request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Instance type. [Available
        /// types](https://cloud.google.com/bare-metal/docs/bms-planning#server_configurations)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>Output only. The name of the instance config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// OS image to initialize the instance. [Available
        /// images](https://cloud.google.com/bare-metal/docs/bms-planning#server_configurations)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osImage")]
        public virtual string OsImage { get; set; }

        /// <summary>Private network address, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateNetwork")]
        public virtual NetworkAddress PrivateNetwork { get; set; }

        /// <summary>
        /// User note field, it can be used by customers to add additional information for the BMS Ops team .
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userNote")]
        public virtual string UserNote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource budget.</summary>
    public class InstanceQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of machines than can be created for the given location and instance_type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableMachineCount")]
        public virtual System.Nullable<int> AvailableMachineCount { get; set; }

        /// <summary>Instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>Location where the quota applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Output only. The name of the instance quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A GCP vlan attachment.</summary>
    public class IntakeVlanAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the VLAN attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Attachment pairing key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairingKey")]
        public virtual string PairingKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the list of servers.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>A token identifying a page of results from the server.</summary>
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

    /// <summary>Response message containing the list of storage volume luns.</summary>
    public class ListLunsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of luns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("luns")]
        public virtual System.Collections.Generic.IList<Lun> Luns { get; set; }

        /// <summary>A token identifying a page of results from the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with Networks with IPs</summary>
    public class ListNetworkUsageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Networks with IPs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<NetworkUsage> Networks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing the list of networks.</summary>
    public class ListNetworksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of networks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<Network> Networks { get; set; }

        /// <summary>A token identifying a page of results from the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing the list of NFS shares.</summary>
    public class ListNfsSharesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results from the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of NFS shares.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsShares")]
        public virtual System.Collections.Generic.IList<NfsShare> NfsShares { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the list of provisioning quotas.</summary>
    public class ListProvisioningQuotasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The provisioning quotas registered in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningQuotas")]
        public virtual System.Collections.Generic.IList<ProvisioningQuota> ProvisioningQuotas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing the list of snapshot schedule policies.</summary>
    public class ListSnapshotSchedulePoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The snapshot schedule policies registered in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotSchedulePolicies")]
        public virtual System.Collections.Generic.IList<SnapshotSchedulePolicy> SnapshotSchedulePolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing the list of storage volume snapshots.</summary>
    public class ListVolumeSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results from the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The list of storage volumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeSnapshots")]
        public virtual System.Collections.Generic.IList<VolumeSnapshot> VolumeSnapshots { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing the list of storage volumes.</summary>
    public class ListVolumesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results from the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The list of storage volumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
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

    /// <summary>A storage volume logical unit number (LUN).</summary>
    public class Lun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display if this LUN is a boot LUN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootLun")]
        public virtual System.Nullable<bool> BootLun { get; set; }

        /// <summary>An identifier for the LUN, generated by the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The LUN multiprotocol type ensures the characteristics of the LUN are optimized for each operating system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiprotocolType")]
        public virtual string MultiprotocolType { get; set; }

        /// <summary>Output only. The name of the LUN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Display if this LUN can be shared between multiple physical servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareable")]
        public virtual System.Nullable<bool> Shareable { get; set; }

        /// <summary>The size of this LUN, in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<long> SizeGb { get; set; }

        /// <summary>The state of this storage volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The storage type for this LUN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageType")]
        public virtual string StorageType { get; set; }

        /// <summary>Display the storage volume for this LUN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageVolume")]
        public virtual string StorageVolume { get; set; }

        /// <summary>The WWID for this LUN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wwid")]
        public virtual string Wwid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A LUN(Logical Unit Number) range.</summary>
    public class LunRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of LUNs to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; }

        /// <summary>The requested size of each LUN, in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Network.</summary>
    public class Network : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cidr of the Network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        /// <summary>An identifier for the `Network`, generated by the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>IP address configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>List of physical interfaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macAddress")]
        public virtual System.Collections.Generic.IList<string> MacAddress { get; set; }

        /// <summary>
        /// Output only. The resource name of this `Network`. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. Format:
        /// `projects/{project}/locations/{location}/networks/{network}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>IP range for reserved for services (e.g. NFS).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesCidr")]
        public virtual string ServicesCidr { get; set; }

        /// <summary>The Network state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The type of this network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The vlan id of the Network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vlanId")]
        public virtual string VlanId { get; set; }

        /// <summary>The vrf for the Network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vrf")]
        public virtual VRF Vrf { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A network.</summary>
    public class NetworkAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IPv4 address to be assigned to the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Name of the existing network to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingNetworkId")]
        public virtual string ExistingNetworkId { get; set; }

        /// <summary>Id of the network to use, within the same ProvisioningConfig request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration parameters for a new network.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Interconnect bandwidth. Set only when type is CLIENT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandwidth")]
        public virtual string Bandwidth { get; set; }

        /// <summary>CIDR range of the network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        /// <summary>
        /// The GCP service of the network. Available gcp_service are in
        /// https://cloud.google.com/bare-metal/docs/bms-planning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpService")]
        public virtual string GcpService { get; set; }

        /// <summary>A transient unique identifier to identify a volume within an ProvisioningConfig request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. The name of the network config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Service CIDR, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceCidr")]
        public virtual string ServiceCidr { get; set; }

        /// <summary>The type of this network, either Client or Private.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// User note field, it can be used by customers to add additional information for the BMS Ops team
        /// (b/194021617).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userNote")]
        public virtual string UserNote { get; set; }

        /// <summary>
        /// List of VLAN attachments. As of now there are always 2 attachments, but it is going to change in the future
        /// (multi vlan).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vlanAttachments")]
        public virtual System.Collections.Generic.IList<IntakeVlanAttachment> VlanAttachments { get; set; }

        /// <summary>Whether the VLAN attachment pair is located in the same project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vlanSameProject")]
        public virtual System.Nullable<bool> VlanSameProject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Network with all used IP addresses.</summary>
    public class NetworkUsage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual Network Network { get; set; }

        /// <summary>All used IP addresses in this network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedIps")]
        public virtual System.Collections.Generic.IList<string> UsedIps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A NFS export entry.</summary>
    public class NfsExport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow dev flag in NfsShare AllowedClientsRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowDev")]
        public virtual System.Nullable<bool> AllowDev { get; set; }

        /// <summary>Allow the setuid flag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowSuid")]
        public virtual System.Nullable<bool> AllowSuid { get; set; }

        /// <summary>A CIDR range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        /// <summary>Either a single machine, identified by an ID, or a comma-separated list of machine IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineId")]
        public virtual string MachineId { get; set; }

        /// <summary>Network to use to publish the export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>
        /// Disable root squashing, which is a feature of NFS. Root squash is a special mapping of the remote superuser
        /// (root) identity when using identity authentication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noRootSquash")]
        public virtual System.Nullable<bool> NoRootSquash { get; set; }

        /// <summary>Export permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual string Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An NFS share.</summary>
    public class NfsShare : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of allowed access points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedClients")]
        public virtual System.Collections.Generic.IList<AllowedClient> AllowedClients { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The name of the NFS share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. An identifier for the NFS share, generated by the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsShareId")]
        public virtual string NfsShareId { get; set; }

        /// <summary>The state of the NFS share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The volume containing the share.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volume")]
        public virtual string Volume { get; set; }

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
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A provisioning configuration.</summary>
    public class ProvisioningConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. URI to Cloud Console UI view of this provisioning config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudConsoleUri")]
        public virtual string CloudConsoleUri { get; set; }

        /// <summary>
        /// Email provided to send a confirmation with provisioning config to. Deprecated in favour of email field in
        /// request messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>A service account to enable customers to access instance credentials upon handover.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handoverServiceAccount")]
        public virtual string HandoverServiceAccount { get; set; }

        /// <summary>Instances to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<InstanceConfig> Instances { get; set; }

        /// <summary>
        /// Optional. Location name of this ProvisioningConfig. It is optional only for Intake UI transition period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Output only. The name of the provisioning config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Networks to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<NetworkConfig> Networks { get; set; }

        /// <summary>Output only. State of ProvisioningConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A generated buganizer id to track provisioning request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketId")]
        public virtual string TicketId { get; set; }

        /// <summary>Output only. Last update timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Volumes to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<VolumeConfig> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A provisioning quota for a given project.</summary>
    public class ProvisioningQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The asset type of this provisioning quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>The available count of the provisioning quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableCount")]
        public virtual System.Nullable<int> AvailableCount { get; set; }

        /// <summary>The gcp service of the provisioning quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpService")]
        public virtual string GcpService { get; set; }

        /// <summary>Instance quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceQuota")]
        public virtual InstanceQuota InstanceQuota { get; set; }

        /// <summary>The specific location of the provisioining quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Output only. The name of the provisioning quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Network bandwidth, Gbps</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkBandwidth")]
        public virtual System.Nullable<long> NetworkBandwidth { get; set; }

        /// <summary>Server count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCount")]
        public virtual System.Nullable<long> ServerCount { get; set; }

        /// <summary>Storage size (GB).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageGib")]
        public virtual System.Nullable<long> StorageGib { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QOS policy parameters.</summary>
    public class QosPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bandwidth permitted by the QOS policy, in gbps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandwidthGbps")]
        public virtual System.Nullable<double> BandwidthGbps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message requesting to reset a server.</summary>
    public class ResetInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for restoring a volume snapshot.</summary>
    public class RestoreVolumeSnapshotRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A snapshot schedule.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A crontab-like specification that the schedule uses to take snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crontabSpec")]
        public virtual string CrontabSpec { get; set; }

        /// <summary>A list of snapshot names created in this schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefix")]
        public virtual string Prefix { get; set; }

        /// <summary>The maximum number of snapshots to retain in this schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionCount")]
        public virtual System.Nullable<int> RetentionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about snapshot space reservation and usage on the storage volume.</summary>
    public class SnapshotReservationDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The space on this storage volume reserved for snapshots, shown in GiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedSpaceGib")]
        public virtual System.Nullable<long> ReservedSpaceGib { get; set; }

        /// <summary>
        /// Percent of the total Volume size reserved for snapshot copies. Enabling snapshots requires reserving 20% or
        /// more of the storage volume space for snapshots. Maximum reserved space for snapshots is 40%. Setting this
        /// field will effectively set snapshot_enabled to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedSpacePercent")]
        public virtual System.Nullable<int> ReservedSpacePercent { get; set; }

        /// <summary>The amount, in GiB, of available space in this storage volume's reserved snapshot space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedSpaceRemainingGib")]
        public virtual System.Nullable<long> ReservedSpaceRemainingGib { get; set; }

        /// <summary>
        /// The percent of snapshot space on this storage volume actually being used by the snapshot copies. This value
        /// might be higher than 100% if the snapshot copies have overflowed into the data portion of the storage
        /// volume.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedSpaceUsedPercent")]
        public virtual System.Nullable<int> ReservedSpaceUsedPercent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A snapshot schedule policy.</summary>
    public class SnapshotSchedulePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the snapshot schedule policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>An identifier for the snapshot schedule policy, generated by the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. The name of the snapshot schedule policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The snapshot schedules contained in this policy. You can specify a maximum of 5 schedules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedules")]
        public virtual System.Collections.Generic.IList<Schedule> Schedules { get; set; }

        /// <summary>The state of the snapshot schedule policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message requesting to start a server.</summary>
    public class StartInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Request for SubmitProvisioningConfig.</summary>
    public class SubmitProvisioningConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Email provided to send a confirmation with provisioning config to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Required. The ProvisioningConfig to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningConfig")]
        public virtual ProvisioningConfig ProvisioningConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for SubmitProvisioningConfig.</summary>
    public class SubmitProvisioningConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The submitted provisioning config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningConfig")]
        public virtual ProvisioningConfig ProvisioningConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A network VRF.</summary>
    public class VRF : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the VRF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The QOS policy applied to this VRF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qosPolicy")]
        public virtual QosPolicy QosPolicy { get; set; }

        /// <summary>The possible state of VRF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The list of VLAN attachments for the VRF.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vlanAttachments")]
        public virtual System.Collections.Generic.IList<VlanAttachment> VlanAttachments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VLAN attachment details.</summary>
    public class VlanAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The peer IP of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerIp")]
        public virtual string PeerIp { get; set; }

        /// <summary>The peer vlan ID of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerVlanId")]
        public virtual System.Nullable<long> PeerVlanId { get; set; }

        /// <summary>The router IP of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routerIp")]
        public virtual string RouterIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A storage volume.</summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The size, in GiB, that this storage volume has expanded as a result of an auto grow policy. In the absence
        /// of auto-grow, the value is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoGrownSizeGib")]
        public virtual System.Nullable<long> AutoGrownSizeGib { get; set; }

        /// <summary>
        /// The current size of this storage volume, in GiB, including space reserved for snapshots. This size might be
        /// different than the requested size if the storage volume has been configured with auto grow or auto shrink.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSizeGib")]
        public virtual System.Nullable<long> CurrentSizeGib { get; set; }

        /// <summary>An identifier for the `Volume`, generated by the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Labels as key value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The resource name of this `Volume`. Resource names are schemeless URIs that follow the
        /// conventions in https://cloud.google.com/apis/design/resource_names. Format:
        /// `projects/{project}/locations/{location}/volumes/{volume}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The space remaining in the storage volume for new LUNs, in GiB, excluding space reserved for snapshots.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingSpaceGib")]
        public virtual System.Nullable<long> RemainingSpaceGib { get; set; }

        /// <summary>The requested size of this storage volume, in GiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedSizeGib")]
        public virtual System.Nullable<long> RequestedSizeGib { get; set; }

        /// <summary>The behavior to use when snapshot reserved space is full.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotAutoDeleteBehavior")]
        public virtual string SnapshotAutoDeleteBehavior { get; set; }

        /// <summary>Whether snapshots are enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotEnabled")]
        public virtual System.Nullable<bool> SnapshotEnabled { get; set; }

        /// <summary>Details about snapshot space reservation and usage on the storage volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotReservationDetail")]
        public virtual SnapshotReservationDetail SnapshotReservationDetail { get; set; }

        /// <summary>The name of the snapshot schedule policy in use for this volume, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotSchedulePolicy")]
        public virtual string SnapshotSchedulePolicy { get; set; }

        /// <summary>The state of this storage volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The storage type for this volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageType")]
        public virtual string StorageType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration parameters for a new volume.</summary>
    public class VolumeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The GCP service of the storage volume. Available gcp_service are in
        /// https://cloud.google.com/bare-metal/docs/bms-planning.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpService")]
        public virtual string GcpService { get; set; }

        /// <summary>A transient unique identifier to identify a volume within an ProvisioningConfig request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>LUN ranges to be configured. Set only when protocol is PROTOCOL_FC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lunRanges")]
        public virtual System.Collections.Generic.IList<LunRange> LunRanges { get; set; }

        /// <summary>Machine ids connected to this volume. Set only when protocol is PROTOCOL_FC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineIds")]
        public virtual System.Collections.Generic.IList<string> MachineIds { get; set; }

        /// <summary>Output only. The name of the volume config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>NFS exports. Set only when protocol is PROTOCOL_NFS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsExports")]
        public virtual System.Collections.Generic.IList<NfsExport> NfsExports { get; set; }

        /// <summary>Volume protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>The requested size of this volume, in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>Whether snapshots should be enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotsEnabled")]
        public virtual System.Nullable<bool> SnapshotsEnabled { get; set; }

        /// <summary>The type of this Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// User note field, it can be used by customers to add additional information for the BMS Ops team
        /// (b/194021617).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userNote")]
        public virtual string UserNote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Snapshot registered for a given storage volume.</summary>
    public class VolumeSnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation time of the storage volume snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The description of the storage volume snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>An identifier for the snapshot, generated by the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. The name of the storage volume snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The size of the storage volume snapshot, in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The storage volume this snapshot belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageVolume")]
        public virtual string StorageVolume { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
