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

namespace Google.Apis.OSConfig.v1alpha
{
    /// <summary>The OSConfig Service.</summary>
    public class OSConfigService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public OSConfigService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public OSConfigService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "osconfig";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://osconfig.googleapis.com/";
        #else
            "https://osconfig.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://osconfig.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the OS Config API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the OS Config API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for OSConfig requests.</summary>
    public abstract class OSConfigBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new OSConfigBaseServiceRequest instance.</summary>
        protected OSConfigBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes OSConfig parameter list.</summary>
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
                InstanceOSPoliciesCompliances = new InstanceOSPoliciesCompliancesResource(service);
                Instances = new InstancesResource(service);
                OsPolicyAssignments = new OsPolicyAssignmentsResource(service);
            }

            /// <summary>Gets the InstanceOSPoliciesCompliances resource.</summary>
            public virtual InstanceOSPoliciesCompliancesResource InstanceOSPoliciesCompliances { get; }

            /// <summary>The "instanceOSPoliciesCompliances" collection of methods.</summary>
            public class InstanceOSPoliciesCompliancesResource
            {
                private const string Resource = "instanceOSPoliciesCompliances";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstanceOSPoliciesCompliancesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get OS policies compliance data for the specified Compute Engine VM instance.</summary>
                /// <param name="name">
                /// Required. API resource name for instance OS policies compliance resource. Format:
                /// `projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}` For `{project}`,
                /// either Compute Engine project-number or project-id can be provided. For `{instance}`, either Compute
                /// Engine VM instance-id or instance-name can be provided.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get OS policies compliance data for the specified Compute Engine VM instance.</summary>
                public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.InstanceOSPoliciesCompliance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. API resource name for instance OS policies compliance resource. Format:
                    /// `projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}` For
                    /// `{project}`, either Compute Engine project-number or project-id can be provided. For
                    /// `{instance}`, either Compute Engine VM instance-id or instance-name can be provided.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instanceOSPoliciesCompliances/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// List OS policies compliance data for all Compute Engine VM instances in the specified zone.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent resource name. Format: `projects/{project}/locations/{location}` For
                /// `{project}`, either Compute Engine project-number or project-id can be provided.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// List OS policies compliance data for all Compute Engine VM instances in the specified zone.
                /// </summary>
                public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.ListInstanceOSPoliciesCompliancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name. Format: `projects/{project}/locations/{location}` For
                    /// `{project}`, either Compute Engine project-number or project-id can be provided.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// If provided, this field specifies the criteria that must be met by a
                    /// `InstanceOSPoliciesCompliance` API resource to be included in the response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The maximum number of results to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A pagination token returned from a previous call to `ListInstanceOSPoliciesCompliances` that
                    /// indicates where this listing should continue from.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/instanceOSPoliciesCompliances";

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
                    Inventories = new InventoriesResource(service);
                    VulnerabilityReports = new VulnerabilityReportsResource(service);
                }

                /// <summary>Gets the Inventories resource.</summary>
                public virtual InventoriesResource Inventories { get; }

                /// <summary>The "inventories" collection of methods.</summary>
                public class InventoriesResource
                {
                    private const string Resource = "inventories";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public InventoriesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Get inventory data for the specified VM instance. If the VM has no associated inventory, the
                    /// message `NOT_FOUND` is returned.
                    /// </summary>
                    /// <param name="name">
                    /// Required. API resource name for inventory resource. Format:
                    /// `projects/{project}/locations/{location}/instances/{instance}/inventory` For `{project}`, either
                    /// `project-number` or `project-id` can be provided. For `{instance}`, either Compute Engine
                    /// `instance-id` or `instance-name` can be provided.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Get inventory data for the specified VM instance. If the VM has no associated inventory, the
                    /// message `NOT_FOUND` is returned.
                    /// </summary>
                    public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.Inventory>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. API resource name for inventory resource. Format:
                        /// `projects/{project}/locations/{location}/instances/{instance}/inventory` For `{project}`,
                        /// either `project-number` or `project-id` can be provided. For `{instance}`, either Compute
                        /// Engine `instance-id` or `instance-name` can be provided.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Inventory view indicating what information should be included in the inventory resource. If
                        /// unspecified, the default view is BASIC.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Inventory view indicating what information should be included in the inventory resource. If
                        /// unspecified, the default view is BASIC.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>The default value. The API defaults to the BASIC view.</summary>
                            [Google.Apis.Util.StringValueAttribute("INVENTORY_VIEW_UNSPECIFIED")]
                            INVENTORYVIEWUNSPECIFIED = 0,

                            /// <summary>Returns the basic inventory information that includes `os_info`.</summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Returns all fields.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+/inventory$",
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

                    /// <summary>List inventory data for all VM instances in the specified zone.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource name. Format:
                    /// `projects/{project}/locations/{location}/instances/{instance}` For `{project}`, either
                    /// `project-number` or `project-id` can be provided. For `{instance}`, only hyphen or dash
                    /// character is supported to list inventories across VMs.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List inventory data for all VM instances in the specified zone.</summary>
                    public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.ListInventoriesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name. Format:
                        /// `projects/{project}/locations/{location}/instances/{instance}` For `{project}`, either
                        /// `project-number` or `project-id` can be provided. For `{instance}`, only hyphen or dash
                        /// character is supported to list inventories across VMs.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// If provided, this field specifies the criteria that must be met by a `Inventory` API
                        /// resource to be included in the response.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The maximum number of results to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A pagination token returned from a previous call to `ListInventories` that indicates where
                        /// this listing should continue from.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Inventory view indicating what information should be included in the inventory resource. If
                        /// unspecified, the default view is BASIC.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Inventory view indicating what information should be included in the inventory resource. If
                        /// unspecified, the default view is BASIC.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>The default value. The API defaults to the BASIC view.</summary>
                            [Google.Apis.Util.StringValueAttribute("INVENTORY_VIEW_UNSPECIFIED")]
                            INVENTORYVIEWUNSPECIFIED = 0,

                            /// <summary>Returns the basic inventory information that includes `os_info`.</summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Returns all fields.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/inventories";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                }

                /// <summary>Gets the VulnerabilityReports resource.</summary>
                public virtual VulnerabilityReportsResource VulnerabilityReports { get; }

                /// <summary>The "vulnerabilityReports" collection of methods.</summary>
                public class VulnerabilityReportsResource
                {
                    private const string Resource = "vulnerabilityReports";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public VulnerabilityReportsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the vulnerability report for the specified VM instance. Only VMs with inventory data have
                    /// vulnerability reports associated with them.
                    /// </summary>
                    /// <param name="name">
                    /// Required. API resource name for vulnerability resource. Format:
                    /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport` For
                    /// `{project}`, either `project-number` or `project-id` can be provided. For `{instance}`, either
                    /// Compute Engine `instance-id` or `instance-name` can be provided.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the vulnerability report for the specified VM instance. Only VMs with inventory data have
                    /// vulnerability reports associated with them.
                    /// </summary>
                    public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.VulnerabilityReport>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. API resource name for vulnerability resource. Format:
                        /// `projects/{project}/locations/{location}/instances/{instance}/vulnerabilityReport` For
                        /// `{project}`, either `project-number` or `project-id` can be provided. For `{instance}`,
                        /// either Compute Engine `instance-id` or `instance-name` can be provided.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+/vulnerabilityReport$",
                            });
                        }
                    }

                    /// <summary>List vulnerability reports for all VM instances in the specified zone.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource name. Format:
                    /// `projects/{project}/locations/{location}/instances/{instance}` For `{project}`, either
                    /// `project-number` or `project-id` can be provided. For `{instance}`, only `-` character is
                    /// supported to list vulnerability reports across VMs.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List vulnerability reports for all VM instances in the specified zone.</summary>
                    public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.ListVulnerabilityReportsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name. Format:
                        /// `projects/{project}/locations/{location}/instances/{instance}` For `{project}`, either
                        /// `project-number` or `project-id` can be provided. For `{instance}`, only `-` character is
                        /// supported to list vulnerability reports across VMs.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// If provided, this field specifies the criteria that must be met by a `vulnerabilityReport`
                        /// API resource to be included in the response.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The maximum number of results to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A pagination token returned from a previous call to `ListVulnerabilityReports` that
                        /// indicates where this listing should continue from.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/vulnerabilityReports";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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

            /// <summary>Gets the OsPolicyAssignments resource.</summary>
            public virtual OsPolicyAssignmentsResource OsPolicyAssignments { get; }

            /// <summary>The "osPolicyAssignments" collection of methods.</summary>
            public class OsPolicyAssignmentsResource
            {
                private const string Resource = "osPolicyAssignments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OsPolicyAssignmentsResource(Google.Apis.Services.IClientService service)
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
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(Google.Apis.OSConfig.v1alpha.Data.CancelOperationRequest body, string name)
                    {
                        return new CancelRequest(service, body, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.Empty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1alpha.Data.CancelOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.OSConfig.v1alpha.Data.CancelOperationRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/osPolicyAssignments/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.Operation>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/osPolicyAssignments/[^/]+/operations/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Create an OS policy assignment. This method also creates the first revision of the OS policy
                /// assignment. This method returns a long running operation (LRO) that contains the rollout details.
                /// The rollout can be cancelled by cancelling the LRO. For more information, see [Method:
                /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name in the form: projects/{project}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OSConfig.v1alpha.Data.OSPolicyAssignment body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Create an OS policy assignment. This method also creates the first revision of the OS policy
                /// assignment. This method returns a long running operation (LRO) that contains the rollout details.
                /// The rollout can be cancelled by cancelling the LRO. For more information, see [Method:
                /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
                /// </summary>
                public class CreateRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1alpha.Data.OSPolicyAssignment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name in the form: projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The logical name of the OS policy assignment in the project with the following
                    /// restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a
                    /// letter. * Must be between 1-63 characters. * Must end with a number or a letter. * Must be
                    /// unique within the project.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("osPolicyAssignmentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OsPolicyAssignmentId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OSConfig.v1alpha.Data.OSPolicyAssignment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/osPolicyAssignments";

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
                        RequestParameters.Add("osPolicyAssignmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "osPolicyAssignmentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Delete the OS policy assignment. This method creates a new revision of the OS policy assignment.
                /// This method returns a long running operation (LRO) that contains the rollout details. The rollout
                /// can be cancelled by cancelling the LRO. If the LRO completes and is not cancelled, all revisions
                /// associated with the OS policy assignment are deleted. For more information, see [Method:
                /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
                /// </summary>
                /// <param name="name">Required. The name of the OS policy assignment to be deleted</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Delete the OS policy assignment. This method creates a new revision of the OS policy assignment.
                /// This method returns a long running operation (LRO) that contains the rollout details. The rollout
                /// can be cancelled by cancelling the LRO. If the LRO completes and is not cancelled, all revisions
                /// associated with the OS policy assignment are deleted. For more information, see [Method:
                /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
                /// </summary>
                public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the OS policy assignment to be deleted</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/osPolicyAssignments/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Retrieve an existing OS policy assignment. This method always returns the latest revision. In order
                /// to retrieve a previous revision of the assignment, also provide the revision ID in the `name`
                /// parameter.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of OS policy assignment. Format:
                /// `projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}@{revisionId}`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Retrieve an existing OS policy assignment. This method always returns the latest revision. In order
                /// to retrieve a previous revision of the assignment, also provide the revision ID in the `name`
                /// parameter.
                /// </summary>
                public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.OSPolicyAssignment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of OS policy assignment. Format:
                    /// `projects/{project}/locations/{location}/osPolicyAssignments/{os_policy_assignment}@{revisionId}`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/osPolicyAssignments/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// List the OS policy assignments under the parent resource. For each OS policy assignment, the latest
                /// revision is returned.
                /// </summary>
                /// <param name="parent">Required. The parent resource name.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// List the OS policy assignments under the parent resource. For each OS policy assignment, the latest
                /// revision is returned.
                /// </summary>
                public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.ListOSPolicyAssignmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource name.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of assignments to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A pagination token returned from a previous call to `ListOSPolicyAssignments` that indicates
                    /// where this listing should continue from.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/osPolicyAssignments";

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

                /// <summary>List the OS policy assignment revisions for a given OS policy assignment.</summary>
                /// <param name="name">Required. The name of the OS policy assignment to list revisions for.</param>
                public virtual ListRevisionsRequest ListRevisions(string name)
                {
                    return new ListRevisionsRequest(service, name);
                }

                /// <summary>List the OS policy assignment revisions for a given OS policy assignment.</summary>
                public class ListRevisionsRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.ListOSPolicyAssignmentRevisionsResponse>
                {
                    /// <summary>Constructs a new ListRevisions request.</summary>
                    public ListRevisionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the OS policy assignment to list revisions for.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The maximum number of revisions to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A pagination token returned from a previous call to `ListOSPolicyAssignmentRevisions` that
                    /// indicates where this listing should continue from.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listRevisions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}:listRevisions";

                    /// <summary>Initializes ListRevisions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/osPolicyAssignments/[^/]+$",
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
                /// Update an existing OS policy assignment. This method creates a new revision of the OS policy
                /// assignment. This method returns a long running operation (LRO) that contains the rollout details.
                /// The rollout can be cancelled by cancelling the LRO. For more information, see [Method:
                /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Resource name. Format:
                /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id}` This
                /// field is ignored when you create an OS policy assignment.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.OSConfig.v1alpha.Data.OSPolicyAssignment body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Update an existing OS policy assignment. This method creates a new revision of the OS policy
                /// assignment. This method returns a long running operation (LRO) that contains the rollout details.
                /// The rollout can be cancelled by cancelling the LRO. For more information, see [Method:
                /// projects.locations.osPolicyAssignments.operations.cancel](https://cloud.google.com/compute/docs/osconfig/rest/v1alpha/projects.locations.osPolicyAssignments.operations/cancel).
                /// </summary>
                public class PatchRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1alpha.Data.OSPolicyAssignment body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Resource name. Format:
                    /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id}`
                    /// This field is ignored when you create an OS policy assignment.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask that controls which fields of the assignment should be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OSConfig.v1alpha.Data.OSPolicyAssignment Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/osPolicyAssignments/[^/]+$",
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
    }
}
namespace Google.Apis.OSConfig.v1alpha.Data
{
    /// <summary>
    /// Common Vulnerability Scoring System version 3. For details, see
    /// https://www.first.org/cvss/specification-document
    /// </summary>
    public class CVSSv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This metric describes the conditions beyond the attacker's control that must exist in order to exploit the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>This metric reflects the context by which vulnerability exploitation is possible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        /// <summary>
        /// This metric measures the impact to the availability of the impacted component resulting from a successfully
        /// exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>
        /// The base score is a function of the base metric scores.
        /// https://www.first.org/cvss/specification-document#Base-Metrics
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<float> BaseScore { get; set; }

        /// <summary>
        /// This metric measures the impact to the confidentiality of the information resources managed by a software
        /// component due to a successfully exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        /// <summary>
        /// The Exploitability sub-score equation is derived from the Base Exploitability metrics.
        /// https://www.first.org/cvss/specification-document#2-1-Exploitability-Metrics
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exploitabilityScore")]
        public virtual System.Nullable<float> ExploitabilityScore { get; set; }

        /// <summary>The Impact sub-score equation is derived from the Base Impact metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impactScore")]
        public virtual System.Nullable<float> ImpactScore { get; set; }

        /// <summary>This metric measures the impact to integrity of a successfully exploited vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        /// <summary>
        /// This metric describes the level of privileges an attacker must possess before successfully exploiting the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        /// <summary>
        /// The Scope metric captures whether a vulnerability in one vulnerable component impacts resources in
        /// components beyond its security scope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// This metric captures the requirement for a human user, other than the attacker, to participate in the
        /// successful compromise of the vulnerable component.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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
    /// Message encapsulating a value that can be either absolute ("fixed") or relative ("percent") to a value.
    /// </summary>
    public class FixedOrPercent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a fixed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixed")]
        public virtual System.Nullable<int> Fixed__ { get; set; }

        /// <summary>
        /// Specifies the relative value defined as a percentage, which will be multiplied by a reference value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This API resource represents the OS policies compliance data for a Compute Engine virtual machine (VM) instance
    /// at a given point in time. A Compute Engine VM can have multiple OS policy assignments, and each assignment can
    /// have multiple OS policies. As a result, multiple OS policies could be applied to a single VM. You can use this
    /// API resource to determine both the compliance state of your VM as well as the compliance state of an individual
    /// OS policy. For more information, see [View
    /// compliance](https://cloud.google.com/compute/docs/os-configuration-management/view-compliance).
    /// </summary>
    public class InstanceOSPoliciesCompliance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Detailed compliance state of the VM. This field is populated only when compliance state is
        /// `UNKNOWN`. It may contain one of the following values: * `no-compliance-data`: Compliance data is not
        /// available for this VM. * `no-agent-detected`: OS Config agent is not detected for this VM. *
        /// `config-not-supported-by-agent`: The version of the OS Config agent running on this VM does not support
        /// configuration management. * `inactive`: VM is not running. * `internal-service-errors`: There were internal
        /// service errors encountered while enforcing compliance. * `agent-errors`: OS config agent encountered errors
        /// while enforcing compliance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailedState")]
        public virtual string DetailedState { get; set; }

        /// <summary>Output only. The reason for the `detailed_state` of the VM (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailedStateReason")]
        public virtual string DetailedStateReason { get; set; }

        /// <summary>Output only. The Compute Engine VM instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>Output only. Timestamp of the last compliance check for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastComplianceCheckTime")]
        public virtual object LastComplianceCheckTime { get; set; }

        /// <summary>
        /// Output only. Unique identifier for the last compliance run. This id will be logged by the OS config agent
        /// during a compliance run and can be used for debugging and tracing purpose.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastComplianceRunId")]
        public virtual string LastComplianceRunId { get; set; }

        /// <summary>
        /// Output only. The `InstanceOSPoliciesCompliance` API resource name. Format:
        /// `projects/{project_number}/locations/{location}/instanceOSPoliciesCompliances/{instance_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Compliance data for each `OSPolicy` that is applied to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyCompliances")]
        public virtual System.Collections.Generic.IList<InstanceOSPoliciesComplianceOSPolicyCompliance> OsPolicyCompliances { get; set; }

        /// <summary>Output only. Compliance state of the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compliance data for an OS policy</summary>
    public class InstanceOSPoliciesComplianceOSPolicyCompliance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reference to the `OSPolicyAssignment` API resource that the `OSPolicy` belongs to. Format:
        /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id@revision_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignment")]
        public virtual string OsPolicyAssignment { get; set; }

        /// <summary>The OS policy id</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyId")]
        public virtual string OsPolicyId { get; set; }

        /// <summary>Compliance data for each `OSPolicyResource` that is applied to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyResourceCompliances")]
        public virtual System.Collections.Generic.IList<OSPolicyResourceCompliance> OsPolicyResourceCompliances { get; set; }

        /// <summary>Compliance state of the OS policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This API resource represents the available inventory data for a Compute Engine virtual machine (VM) instance at
    /// a given point in time. You can use this API resource to determine the inventory data of your VM. For more
    /// information, see [Information provided by OS inventory
    /// management](https://cloud.google.com/compute/docs/instances/os-inventory-management#data-collected).
    /// </summary>
    public class Inventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Inventory items related to the VM keyed by an opaque unique identifier for each inventory item.
        /// The identifier is unique to each distinct and addressable inventory item and will change, when there is a
        /// new package version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IDictionary<string, InventoryItem> Items { get; set; }

        /// <summary>
        /// Output only. The `Inventory` API resource name. Format:
        /// `projects/{project_number}/locations/{location}/instances/{instance_id}/inventory`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Base level operating system information for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osInfo")]
        public virtual InventoryOsInfo OsInfo { get; set; }

        /// <summary>Output only. Timestamp of the last reported inventory for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single piece of inventory on a VM.</summary>
    public class InventoryItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Software package available to be installed on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availablePackage")]
        public virtual InventorySoftwarePackage AvailablePackage { get; set; }

        /// <summary>When this inventory item was first detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Identifier for this item, unique across items for this VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Software package present on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedPackage")]
        public virtual InventorySoftwarePackage InstalledPackage { get; set; }

        /// <summary>The origin of this inventory item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originType")]
        public virtual string OriginType { get; set; }

        /// <summary>The specific type of inventory, correlating to its specific details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>When this inventory item was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operating system information for the VM.</summary>
    public class InventoryOsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The system architecture of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>The VM hostname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>The kernel release of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelRelease")]
        public virtual string KernelRelease { get; set; }

        /// <summary>The kernel version of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; }

        /// <summary>
        /// The operating system long name. For example 'Debian GNU/Linux 9' or 'Microsoft Window Server 2019
        /// Datacenter'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longName")]
        public virtual string LongName { get; set; }

        /// <summary>The current version of the OS Config agent running on the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osconfigAgentVersion")]
        public virtual string OsconfigAgentVersion { get; set; }

        /// <summary>The operating system short name. For example, 'windows' or 'debian'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>The version of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Software package information of the operating system.</summary>
    public class InventorySoftwarePackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Details of an APT package. For details about the apt package manager, see https://wiki.debian.org/Apt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aptPackage")]
        public virtual InventoryVersionedPackage AptPackage { get; set; }

        /// <summary>Details of a COS package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosPackage")]
        public virtual InventoryVersionedPackage CosPackage { get; set; }

        /// <summary>
        /// Details of a Googet package. For details about the googet package manager, see
        /// https://github.com/google/googet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googetPackage")]
        public virtual InventoryVersionedPackage GoogetPackage { get; set; }

        /// <summary>
        /// Details of a Windows Quick Fix engineering package. See
        /// https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-quickfixengineering for info in Windows
        /// Quick Fix Engineering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qfePackage")]
        public virtual InventoryWindowsQuickFixEngineeringPackage QfePackage { get; set; }

        /// <summary>
        /// Details of a Windows Update package. See https://docs.microsoft.com/en-us/windows/win32/api/_wua/ for
        /// information about Windows Update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wuaPackage")]
        public virtual InventoryWindowsUpdatePackage WuaPackage { get; set; }

        /// <summary>
        /// Yum package info. For details about the yum package manager, see
        /// https://access.redhat.com/documentation/en-us/red_hat_enterprise_linux/6/html/deployment_guide/ch-yum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yumPackage")]
        public virtual InventoryVersionedPackage YumPackage { get; set; }

        /// <summary>
        /// Details of a Zypper package. For details about the Zypper package manager, see
        /// https://en.opensuse.org/SDB:Zypper_manual.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypperPackage")]
        public virtual InventoryVersionedPackage ZypperPackage { get; set; }

        /// <summary>
        /// Details of a Zypper patch. For details about the Zypper package manager, see
        /// https://en.opensuse.org/SDB:Zypper_manual.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypperPatch")]
        public virtual InventoryZypperPatch ZypperPatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information related to the a standard versioned package. This includes package info for APT, Yum, Zypper, and
    /// Googet package managers.
    /// </summary>
    public class InventoryVersionedPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The system architecture this package is intended for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>The name of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The version of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information related to a Quick Fix Engineering package. Fields are taken from Windows QuickFixEngineering
    /// Interface and match the source names:
    /// https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-quickfixengineering
    /// </summary>
    public class InventoryWindowsQuickFixEngineeringPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short textual description of the QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>A textual description of the QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Unique identifier associated with a particular QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotFixId")]
        public virtual string HotFixId { get; set; }

        /// <summary>Date that the QFE update was installed. Mapped from installed_on field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installTime")]
        public virtual object InstallTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details related to a Windows Update package. Field data and names are taken from Windows Update API IUpdate
    /// Interface: https://docs.microsoft.com/en-us/windows/win32/api/_wua/ Descriptive fields like title, and
    /// description are localized based on the locale of the VM being updated.
    /// </summary>
    public class InventoryWindowsUpdatePackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The categories that are associated with this update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<InventoryWindowsUpdatePackageWindowsUpdateCategory> Categories { get; set; }

        /// <summary>The localized description of the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A collection of Microsoft Knowledge Base article IDs that are associated with the update package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kbArticleIds")]
        public virtual System.Collections.Generic.IList<string> KbArticleIds { get; set; }

        /// <summary>The last published date of the update, in (UTC) date and time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDeploymentChangeTime")]
        public virtual object LastDeploymentChangeTime { get; set; }

        /// <summary>A collection of URLs that provide more information about the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moreInfoUrls")]
        public virtual System.Collections.Generic.IList<string> MoreInfoUrls { get; set; }

        /// <summary>The revision number of this update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionNumber")]
        public virtual System.Nullable<int> RevisionNumber { get; set; }

        /// <summary>A hyperlink to the language-specific support information for the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportUrl")]
        public virtual string SupportUrl { get; set; }

        /// <summary>The localized title of the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Gets the identifier of an update package. Stays the same across revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateId")]
        public virtual string UpdateId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Categories specified by the Windows Update.</summary>
    public class InventoryWindowsUpdatePackageWindowsUpdateCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the windows update category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The name of the windows update category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details related to a Zypper Patch.</summary>
    public class InventoryZypperPatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category of the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The name of the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchName")]
        public virtual string PatchName { get; set; }

        /// <summary>The severity specified for this patch</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Any summary information provided about this patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual string Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response message for listing OS policies compliance data for all Compute Engine VMs in the given location.
    /// </summary>
    public class ListInstanceOSPoliciesCompliancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of instance OS policies compliance objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceOsPoliciesCompliances")]
        public virtual System.Collections.Generic.IList<InstanceOSPoliciesCompliance> InstanceOsPoliciesCompliances { get; set; }

        /// <summary>
        /// The pagination token to retrieve the next page of instance OS policies compliance objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for listing inventory data for all VMs in a specified location.</summary>
    public class ListInventoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of inventory objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventories")]
        public virtual System.Collections.Generic.IList<Inventory> Inventories { get; set; }

        /// <summary>The pagination token to retrieve the next page of inventory objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for listing all revisions for a OS policy assignment.</summary>
    public class ListOSPolicyAssignmentRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pagination token to retrieve the next page of OS policy assignment revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The OS policy assignment revisions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignments")]
        public virtual System.Collections.Generic.IList<OSPolicyAssignment> OsPolicyAssignments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for listing all assignments under given parent.</summary>
    public class ListOSPolicyAssignmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pagination token to retrieve the next page of OS policy assignments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of assignments</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignments")]
        public virtual System.Collections.Generic.IList<OSPolicyAssignment> OsPolicyAssignments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response message for listing vulnerability reports for all VM instances in the specified location.
    /// </summary>
    public class ListVulnerabilityReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pagination token to retrieve the next page of vulnerabilityReports object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of vulnerabilityReport objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerabilityReports")]
        public virtual System.Collections.Generic.IList<VulnerabilityReport> VulnerabilityReports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An OS policy defines the desired state configuration for a VM.</summary>
    public class OSPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This flag determines the OS policy compliance status when none of the resource groups within the policy are
        /// applicable for a VM. Set this value to `true` if the policy needs to be reported as compliant even if the
        /// policy has nothing to validate or enforce.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowNoResourceGroupMatch")]
        public virtual System.Nullable<bool> AllowNoResourceGroupMatch { get; set; }

        /// <summary>Policy description. Length of the description is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The id of the OS policy with the following restrictions: * Must contain only lowercase letters,
        /// numbers, and hyphens. * Must start with a letter. * Must be between 1-63 characters. * Must end with a
        /// number or a letter. * Must be unique within the assignment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. Policy mode</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>
        /// Required. List of resource groups for the policy. For a particular VM, resource groups are evaluated in the
        /// order specified and the first resource group that is applicable is selected and the rest are ignored. If
        /// none of the resource groups are applicable for a VM, the VM is considered to be non-compliant w.r.t this
        /// policy. This behavior can be toggled by the flag `allow_no_resource_group_match`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroups")]
        public virtual System.Collections.Generic.IList<OSPolicyResourceGroup> ResourceGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OS policy assignment is an API resource that is used to apply a set of OS policies to a dynamically targeted
    /// group of Compute Engine VM instances. An OS policy is used to define the desired state configuration for a
    /// Compute Engine VM instance through a set of configuration resources that provide capabilities such as installing
    /// or removing software packages, or executing a script. For more information, see [OS policy and OS policy
    /// assignment](https://cloud.google.com/compute/docs/os-configuration-management/working-with-os-policies).
    /// </summary>
    public class OSPolicyAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be
        /// assigned OS policies from this revision. For a given OS policy assignment, there is only one revision with a
        /// value of `true` for this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseline")]
        public virtual System.Nullable<bool> Baseline { get; set; }

        /// <summary>Output only. Indicates that this revision deletes the OS policy assignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// OS policy assignment description. Length of the description is limited to 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Filter to select VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceFilter")]
        public virtual OSPolicyAssignmentInstanceFilter InstanceFilter { get; set; }

        /// <summary>
        /// Resource name. Format:
        /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id}` This field is
        /// ignored when you create an OS policy assignment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. List of OS policies to be applied to the VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicies")]
        public virtual System.Collections.Generic.IList<OSPolicy> OsPolicies { get; set; }

        /// <summary>
        /// Output only. Indicates that reconciliation is in progress for the revision. This value is `true` when the
        /// `rollout_state` is one of: * IN_PROGRESS * CANCELLING
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. The timestamp that the revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual object RevisionCreateTime { get; set; }

        /// <summary>
        /// Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS
        /// policy assignment
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>
        /// Required. Rollout to deploy the OS policy assignment. A rollout is triggered in the following situations: 1)
        /// OSPolicyAssignment is created. 2) OSPolicyAssignment is updated and the update contains changes to one of
        /// the following fields: - instance_filter - os_policies 3) OSPolicyAssignment is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual OSPolicyAssignmentRollout Rollout { get; set; }

        /// <summary>Output only. OS policy assignment rollout state</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutState")]
        public virtual string RolloutState { get; set; }

        /// <summary>Output only. Server generated unique id for the OS policy assignment resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message to represent the filters to select VMs for an assignment</summary>
    public class OSPolicyAssignmentInstanceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target all VMs in the project. If true, no other criteria is permitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("all")]
        public virtual System.Nullable<bool> All { get; set; }

        /// <summary>
        /// List of label sets used for VM exclusion. If the list has more than one label set, the VM is excluded if any
        /// of the label sets are applicable for the VM. This filter is applied last in the filtering chain and
        /// therefore a VM is guaranteed to be excluded if it satisfies one of the below label sets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusionLabels")]
        public virtual System.Collections.Generic.IList<OSPolicyAssignmentLabelSet> ExclusionLabels { get; set; }

        /// <summary>
        /// List of label sets used for VM inclusion. If the list has more than one `LabelSet`, the VM is included if
        /// any of the label sets are applicable for the VM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusionLabels")]
        public virtual System.Collections.Generic.IList<OSPolicyAssignmentLabelSet> InclusionLabels { get; set; }

        /// <summary>
        /// A VM is included if it's OS short name matches with any of the values provided in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osShortNames")]
        public virtual System.Collections.Generic.IList<string> OsShortNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message representing label set. * A label is a key value pair set for a VM. * A LabelSet is a set of labels. *
    /// Labels within a LabelSet are ANDed. In other words, a LabelSet is applicable for a VM only if it matches all the
    /// labels in the LabelSet. * Example: A LabelSet with 2 labels: `env=prod` and `type=webserver` will only be
    /// applicable for those VMs with both labels present.
    /// </summary>
    public class OSPolicyAssignmentLabelSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified
        /// in this map to be selected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OS policy assignment operation metadata provided by OS policy assignment API methods that return long running
    /// operations.
    /// </summary>
    public class OSPolicyAssignmentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OS policy assignment API method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiMethod")]
        public virtual string ApiMethod { get; set; }

        /// <summary>
        /// Reference to the `OSPolicyAssignment` API resource. Format:
        /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id@revision_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignment")]
        public virtual string OsPolicyAssignment { get; set; }

        /// <summary>Rollout start time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutStartTime")]
        public virtual object RolloutStartTime { get; set; }

        /// <summary>State of the rollout</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutState")]
        public virtual string RolloutState { get; set; }

        /// <summary>Rollout update time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutUpdateTime")]
        public virtual object RolloutUpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message to configure the rollout at the zonal level for the OS policy assignment.</summary>
    public class OSPolicyAssignmentRollout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The maximum number (or percentage) of VMs per zone to disrupt at any given moment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disruptionBudget")]
        public virtual FixedOrPercent DisruptionBudget { get; set; }

        /// <summary>
        /// Required. This determines the minimum duration of time to wait after the configuration changes are applied
        /// through the current rollout. A VM continues to count towards the `disruption_budget` at least until this
        /// duration of time has passed after configuration changes are applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minWaitDuration")]
        public virtual object MinWaitDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The `OSFilter` is used to specify the OS filtering criteria for the resource group.</summary>
    public class OSPolicyOSFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This should match OS short name emitted by the OS inventory agent. An empty value matches any OS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osShortName")]
        public virtual string OsShortName { get; set; }

        /// <summary>
        /// This value should match the version emitted by the OS inventory agent. Prefix matches are supported if
        /// asterisk(*) is provided as the last character. For example, to match all versions with a major version of
        /// `7`, specify the following value for this field `7.*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An OS policy resource is used to define the desired state configuration and provides a specific functionality
    /// like installing/removing packages, executing a script etc. The system ensures that resources are always in their
    /// desired state by taking necessary actions if they have drifted from their desired state.
    /// </summary>
    public class OSPolicyResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Exec resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exec")]
        public virtual OSPolicyResourceExecResource Exec { get; set; }

        /// <summary>File resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual OSPolicyResourceFileResource File { get; set; }

        /// <summary>
        /// Required. The id of the resource with the following restrictions: * Must contain only lowercase letters,
        /// numbers, and hyphens. * Must start with a letter. * Must be between 1-63 characters. * Must end with a
        /// number or a letter. * Must be unique within the OS policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Package resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkg")]
        public virtual OSPolicyResourcePackageResource Pkg { get; set; }

        /// <summary>Package repository resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual OSPolicyResourceRepositoryResource Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compliance data for an OS policy resource.</summary>
    public class OSPolicyResourceCompliance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ordered list of configuration steps taken by the agent for the OS policy resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configSteps")]
        public virtual System.Collections.Generic.IList<OSPolicyResourceConfigStep> ConfigSteps { get; set; }

        /// <summary>ExecResource specific output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("execResourceOutput")]
        public virtual OSPolicyResourceComplianceExecResourceOutput ExecResourceOutput { get; set; }

        /// <summary>The id of the OS policy resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyResourceId")]
        public virtual string OsPolicyResourceId { get; set; }

        /// <summary>Compliance state of the OS policy resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExecResource specific output.</summary>
    public class OSPolicyResourceComplianceExecResourceOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output from Enforcement phase output file (if run). Output size is limited to 100K bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforcementOutput")]
        public virtual string EnforcementOutput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Step performed by the OS Config agent for configuring an `OSPolicyResource` to its desired state.
    /// </summary>
    public class OSPolicyResourceConfigStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An error message recorded during the execution of this step. Only populated when outcome is FAILED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Outcome of the configuration step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outcome")]
        public virtual string Outcome { get; set; }

        /// <summary>Configuration step type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource that allows executing scripts on the VM. The `ExecResource` has 2 stages: `validate` and `enforce`
    /// and both stages accept a script as an argument to execute. When the `ExecResource` is applied by the agent, it
    /// first executes the script in the `validate` stage. The `validate` stage can signal that the `ExecResource` is
    /// already in the desired state by returning an exit code of `100`. If the `ExecResource` is not in the desired
    /// state, it should return an exit code of `101`. Any other exit code returned by this stage is considered an
    /// error. If the `ExecResource` is not in the desired state based on the exit code from the `validate` stage, the
    /// agent proceeds to execute the script from the `enforce` stage. If the `ExecResource` is already in the desired
    /// state, the `enforce` stage will not be run. Similar to `validate` stage, the `enforce` stage should return an
    /// exit code of `100` to indicate that the resource in now in its desired state. Any other exit code is considered
    /// an error. NOTE: An exit code of `100` was chosen over `0` (and `101` vs `1`) to have an explicit indicator of
    /// `in desired state`, `not in desired state` and errors. Because, for example, Powershell will always return an
    /// exit code of `0` unless an `exit` statement is provided in the script. So, for reasons of consistency and being
    /// explicit, exit codes `100` and `101` were chosen.
    /// </summary>
    public class OSPolicyResourceExecResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// What to run to bring this resource into the desired state. An exit code of 100 indicates "success", any
        /// other exit code indicates a failure running enforce.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforce")]
        public virtual OSPolicyResourceExecResourceExec Enforce { get; set; }

        /// <summary>
        /// Required. What to run to validate this resource is in the desired state. An exit code of 100 indicates "in
        /// desired state", and exit code of 101 indicates "not in desired state". Any other exit code indicates a
        /// failure running validate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validate")]
        public virtual OSPolicyResourceExecResourceExec Validate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A file or script to execute.</summary>
    public class OSPolicyResourceExecResourceExec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional arguments to pass to the source during execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>A remote or local file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual OSPolicyResourceFile File { get; set; }

        /// <summary>Required. The script interpreter to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpreter")]
        public virtual string Interpreter { get; set; }

        /// <summary>
        /// Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be
        /// recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will
        /// result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFilePath")]
        public virtual string OutputFilePath { get; set; }

        /// <summary>An inline script. The size of the script is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A remote or local file.</summary>
    public class OSPolicyResourceFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum
        /// must be specified. Cloud Storage: An object generation number must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowInsecure")]
        public virtual System.Nullable<bool> AllowInsecure { get; set; }

        /// <summary>A Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcs")]
        public virtual OSPolicyResourceFileGcs Gcs { get; set; }

        /// <summary>A local path within the VM to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localPath")]
        public virtual string LocalPath { get; set; }

        /// <summary>A generic remote file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remote")]
        public virtual OSPolicyResourceFileRemote Remote { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a file available as a Cloud Storage Object.</summary>
    public class OSPolicyResourceFileGcs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Bucket of the Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>Generation number of the Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>Required. Name of the Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a file available via some URI.</summary>
    public class OSPolicyResourceFileRemote : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SHA256 checksum of the remote file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Checksum")]
        public virtual string Sha256Checksum { get; set; }

        /// <summary>
        /// Required. URI from which to fetch the object. It should contain both the protocol and path following the
        /// format `{protocol}://{location}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that manages the state of a file.</summary>
    public class OSPolicyResourceFileResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A a file with this content. The size of the content is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>A remote or local source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual OSPolicyResourceFile File { get; set; }

        /// <summary>Required. The absolute path of the file within the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Consists of three octal digits which represent, in order, the permissions of the owner, group, and other
        /// users for the file (similarly to the numeric mode used in the linux chmod utility). Each digit represents a
        /// three bit number with the 4 bit corresponding to the read permissions, the 2 bit corresponds to the write
        /// bit, and the one bit corresponds to the execute permission. Default behavior is 755. Below are some examples
        /// of permissions and their associated values: read, write, and execute: 7 read and execute: 5 read and write:
        /// 6 read only: 4
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual string Permissions { get; set; }

        /// <summary>Required. Desired state of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource groups provide a mechanism to group OS policy resources. Resource groups enable OS policy authors to
    /// create a single OS policy to be applied to VMs running different operating Systems. When the OS policy is
    /// applied to a target VM, the appropriate resource group within the OS policy is selected based on the `OSFilter`
    /// specified within the resource group.
    /// </summary>
    public class OSPolicyResourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Used to specify the OS filter for a resource group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osFilter")]
        public virtual OSPolicyOSFilter OsFilter { get; set; }

        /// <summary>
        /// Required. List of resources configured for this resource group. The resources are executed in the exact
        /// order specified here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<OSPolicyResource> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that manages a system package.</summary>
    public class OSPolicyResourcePackageResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A package managed by Apt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apt")]
        public virtual OSPolicyResourcePackageResourceAPT Apt { get; set; }

        /// <summary>A deb package file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deb")]
        public virtual OSPolicyResourcePackageResourceDeb Deb { get; set; }

        /// <summary>Required. The desired state the agent should maintain for this package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredState")]
        public virtual string DesiredState { get; set; }

        /// <summary>A package managed by GooGet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googet")]
        public virtual OSPolicyResourcePackageResourceGooGet Googet { get; set; }

        /// <summary>An MSI package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("msi")]
        public virtual OSPolicyResourcePackageResourceMSI Msi { get; set; }

        /// <summary>An rpm package file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rpm")]
        public virtual OSPolicyResourcePackageResourceRPM Rpm { get; set; }

        /// <summary>A package managed by YUM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yum")]
        public virtual OSPolicyResourcePackageResourceYUM Yum { get; set; }

        /// <summary>A package managed by Zypper.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypper")]
        public virtual OSPolicyResourcePackageResourceZypper Zypper { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A package managed by APT. - install: `apt-get update &amp;amp;&amp;amp; apt-get -y install [name]` - remove:
    /// `apt-get -y remove [name]`
    /// </summary>
    public class OSPolicyResourcePackageResourceAPT : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A deb package file. dpkg packages only support INSTALLED state.</summary>
    public class OSPolicyResourcePackageResourceDeb : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether dependencies should also be installed. - install when false: `dpkg -i package` - install when true:
        /// `apt-get update &amp;amp;&amp;amp; apt-get -y install package.deb`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullDeps")]
        public virtual System.Nullable<bool> PullDeps { get; set; }

        /// <summary>Required. A deb package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual OSPolicyResourceFile Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A package managed by GooGet. - install: `googet -noconfirm install package` - remove: `googet -noconfirm remove
    /// package`
    /// </summary>
    public class OSPolicyResourcePackageResourceGooGet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An MSI package. MSI packages only support INSTALLED state.</summary>
    public class OSPolicyResourcePackageResourceMSI : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional properties to use during installation. This should be in the format of Property=Setting. Appended
        /// to the defaults of `ACTION=INSTALL REBOOT=ReallySuppress`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<string> Properties { get; set; }

        /// <summary>Required. The MSI package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual OSPolicyResourceFile Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An RPM package file. RPM packages only support INSTALLED state.</summary>
    public class OSPolicyResourcePackageResourceRPM : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether dependencies should also be installed. - install when false: `rpm --upgrade --replacepkgs
        /// package.rpm` - install when true: `yum -y install package.rpm` or `zypper -y install package.rpm`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullDeps")]
        public virtual System.Nullable<bool> PullDeps { get; set; }

        /// <summary>Required. An rpm package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual OSPolicyResourceFile Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A package managed by YUM. - install: `yum -y install package` - remove: `yum -y remove package`
    /// </summary>
    public class OSPolicyResourcePackageResourceYUM : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A package managed by Zypper. - install: `zypper -y install package` - remove: `zypper -y rm package`
    /// </summary>
    public class OSPolicyResourcePackageResourceZypper : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that manages a package repository.</summary>
    public class OSPolicyResourceRepositoryResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An Apt Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apt")]
        public virtual OSPolicyResourceRepositoryResourceAptRepository Apt { get; set; }

        /// <summary>A Goo Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goo")]
        public virtual OSPolicyResourceRepositoryResourceGooRepository Goo { get; set; }

        /// <summary>A Yum Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yum")]
        public virtual OSPolicyResourceRepositoryResourceYumRepository Yum { get; set; }

        /// <summary>A Zypper Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypper")]
        public virtual OSPolicyResourceRepositoryResourceZypperRepository Zypper { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single apt package repository. These will be added to a repo file that will be managed at
    /// `/etc/apt/sources.list.d/google_osconfig.list`.
    /// </summary>
    public class OSPolicyResourceRepositoryResourceAptRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Type of archive files in this repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveType")]
        public virtual string ArchiveType { get; set; }

        /// <summary>Required. List of components for this repository. Must contain at least one item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        /// <summary>Required. Distribution of this repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual string Distribution { get; set; }

        /// <summary>
        /// URI of the key file for this repository. The agent maintains a keyring at
        /// `/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKey")]
        public virtual string GpgKey { get; set; }

        /// <summary>Required. URI for this repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Goo package repository. These are added to a repo file that is managed at
    /// `C:/ProgramData/GooGet/repos/google_osconfig.repo`.
    /// </summary>
    public class OSPolicyResourceRepositoryResourceGooRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The url of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single yum package repository. These are added to a repo file that is managed at
    /// `/etc/yum.repos.d/google_osconfig.repo`.
    /// </summary>
    public class OSPolicyResourceRepositoryResourceYumRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the repository directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUrl")]
        public virtual string BaseUrl { get; set; }

        /// <summary>The display name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URIs of GPG keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKeys")]
        public virtual System.Collections.Generic.IList<string> GpgKeys { get; set; }

        /// <summary>
        /// Required. A one word, unique name for this repository. This is the `repo id` in the yum config file and also
        /// the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when checking
        /// for resource conflicts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single zypper package repository. These are added to a repo file that is managed at
    /// `/etc/zypp/repos.d/google_osconfig.repo`.
    /// </summary>
    public class OSPolicyResourceRepositoryResourceZypperRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the repository directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUrl")]
        public virtual string BaseUrl { get; set; }

        /// <summary>The display name of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>URIs of GPG keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpgKeys")]
        public virtual System.Collections.Generic.IList<string> GpgKeys { get; set; }

        /// <summary>
        /// Required. A one word, unique name for this repository. This is the `repo id` in the zypper config file and
        /// also the `display_name` if `display_name` is omitted. This id is also used as the unique identifier when
        /// checking for GuestPolicy conflicts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

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
    /// This API resource represents the vulnerability report for a specified Compute Engine virtual machine (VM)
    /// instance at a given point in time. For more information, see [Vulnerability
    /// reports](https://cloud.google.com/compute/docs/instances/os-inventory-management#vulnerability-reports).
    /// </summary>
    public class VulnerabilityReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The `vulnerabilityReport` API resource name. Format:
        /// `projects/{project_number}/locations/{location}/instances/{instance_id}/vulnerabilityReport`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The timestamp for when the last vulnerability report was generated for the VM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Output only. List of vulnerabilities affecting the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerabilities")]
        public virtual System.Collections.Generic.IList<VulnerabilityReportVulnerability> Vulnerabilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A vulnerability affecting the VM instance.</summary>
    public class VulnerabilityReportVulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Corresponds to the `AVAILABLE_PACKAGE` inventory item on the VM. If the vulnerability report was not updated
        /// after the VM inventory update, these values might not display in VM inventory. If there is no available fix,
        /// the field is empty. The `inventory_item` value specifies the latest `SoftwarePackage` available to the VM
        /// that fixes the vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableInventoryItemIds")]
        public virtual System.Collections.Generic.IList<string> AvailableInventoryItemIds { get; set; }

        /// <summary>The timestamp for when the vulnerability was first detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Contains metadata as per the upstream feed of the operating system and NVD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual VulnerabilityReportVulnerabilityDetails Details { get; set; }

        /// <summary>
        /// Corresponds to the `INSTALLED_PACKAGE` inventory item on the VM. This field displays the inventory items
        /// affected by this vulnerability. If the vulnerability report was not updated after the VM inventory update,
        /// these values might not display in VM inventory. For some distros, this field may be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedInventoryItemIds")]
        public virtual System.Collections.Generic.IList<string> InstalledInventoryItemIds { get; set; }

        /// <summary>The timestamp for when the vulnerability was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains metadata information for the vulnerability. This information is collected from the upstream feed of the
    /// operating system.
    /// </summary>
    public class VulnerabilityReportVulnerabilityDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The CVE of the vulnerability. CVE cannot be empty and the combination of should be unique across
        /// vulnerabilities for a VM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual string Cve { get; set; }

        /// <summary>
        /// The CVSS V2 score of this vulnerability. CVSS V2 score is on a scale of 0 - 10 where 0 indicates low
        /// severity and 10 indicates high severity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssV2Score")]
        public virtual System.Nullable<float> CvssV2Score { get; set; }

        /// <summary>The full description of the CVSSv3 for this vulnerability from NVD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssV3")]
        public virtual CVSSv3 CvssV3 { get; set; }

        /// <summary>The note or description describing the vulnerability from the distro.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Corresponds to the references attached to the `VulnerabilityDetails`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<VulnerabilityReportVulnerabilityDetailsReference> References { get; set; }

        /// <summary>Assigned severity/impact ranking from the distro.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference for this vulnerability.</summary>
    public class VulnerabilityReportVulnerabilityDetailsReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The url of the reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
