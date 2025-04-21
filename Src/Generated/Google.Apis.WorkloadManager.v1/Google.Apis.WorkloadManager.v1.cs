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

namespace Google.Apis.WorkloadManager.v1
{
    /// <summary>The WorkloadManager Service.</summary>
    public class WorkloadManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WorkloadManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WorkloadManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://workloadmanager.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://workloadmanager.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "workloadmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Workload Manager API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Workload Manager API.</summary>
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

    /// <summary>A base abstract class for WorkloadManager requests.</summary>
    public abstract class WorkloadManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new WorkloadManagerBaseServiceRequest instance.</summary>
        protected WorkloadManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes WorkloadManager parameter list.</summary>
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
                Discoveredprofiles = new DiscoveredprofilesResource(service);
                Evaluations = new EvaluationsResource(service);
                Insights = new InsightsResource(service);
                Operations = new OperationsResource(service);
                Rules = new RulesResource(service);
            }

            /// <summary>Gets the Discoveredprofiles resource.</summary>
            public virtual DiscoveredprofilesResource Discoveredprofiles { get; }

            /// <summary>The "discoveredprofiles" collection of methods.</summary>
            public class DiscoveredprofilesResource
            {
                private const string Resource = "discoveredprofiles";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DiscoveredprofilesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Healthes = new HealthesResource(service);
                }

                /// <summary>Gets the Healthes resource.</summary>
                public virtual HealthesResource Healthes { get; }

                /// <summary>The "healthes" collection of methods.</summary>
                public class HealthesResource
                {
                    private const string Resource = "healthes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public HealthesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Get the health of a discovered workload profile.</summary>
                    /// <param name="name">Required. The resource name</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Get the health of a discovered workload profile.</summary>
                    public class GetRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.WorkloadProfileHealth>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/discoveredprofiles/[^/]+/healthes/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets details of a discovered workload profile.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a discovered workload profile.</summary>
                public class GetRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.WorkloadProfile>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/discoveredprofiles/[^/]+$",
                        });
                    }
                }

                /// <summary>List discovered workload profiles</summary>
                /// <param name="parent">Required. Parent value for ListDiscoveredProfilesRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List discovered workload profiles</summary>
                public class ListRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.ListDiscoveredProfilesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListDiscoveredProfilesRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/discoveredprofiles";

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

            /// <summary>Gets the Evaluations resource.</summary>
            public virtual EvaluationsResource Evaluations { get; }

            /// <summary>The "evaluations" collection of methods.</summary>
            public class EvaluationsResource
            {
                private const string Resource = "evaluations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EvaluationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Executions = new ExecutionsResource(service);
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
                        Results = new ResultsResource(service);
                        ScannedResources = new ScannedResourcesResource(service);
                    }

                    /// <summary>Gets the Results resource.</summary>
                    public virtual ResultsResource Results { get; }

                    /// <summary>The "results" collection of methods.</summary>
                    public class ResultsResource
                    {
                        private const string Resource = "results";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ResultsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Lists the result of a single evaluation.</summary>
                        /// <param name="parent">
                        /// Required. The execution results. Format: {parent}/evaluations/*/executions/*/results
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists the result of a single evaluation.</summary>
                        public class ListRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.ListExecutionResultsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The execution results. Format: {parent}/evaluations/*/executions/*/results
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Filtering results</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Requested page size. Server may return fewer items than requested. If unspecified,
                            /// server will pick an appropriate default.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>A token identifying a page of results the server should return.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/results";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/evaluations/[^/]+/executions/[^/]+$",
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

                    /// <summary>Gets the ScannedResources resource.</summary>
                    public virtual ScannedResourcesResource ScannedResources { get; }

                    /// <summary>The "scannedResources" collection of methods.</summary>
                    public class ScannedResourcesResource
                    {
                        private const string Resource = "scannedResources";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ScannedResourcesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>List all scanned resources for a single Execution.</summary>
                        /// <param name="parent">Required. parent for ListScannedResourcesRequest</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>List all scanned resources for a single Execution.</summary>
                        public class ListRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.ListScannedResourcesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. parent for ListScannedResourcesRequest</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Filtering results</summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Field to sort by. See https://google.aip.dev/132#ordering for more details.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Requested page size. Server may return fewer items than requested. If unspecified,
                            /// server will pick an appropriate default.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>A token identifying a page of results the server should return.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>rule name</summary>
                            [Google.Apis.Util.RequestParameterAttribute("rule", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Rule { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/scannedResources";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/evaluations/[^/]+/executions/[^/]+$",
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
                                RequestParameters.Add("rule", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "rule",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>Deletes a single Execution.</summary>
                    /// <param name="name">Required. Name of the resource</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single Execution.</summary>
                    public class DeleteRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/evaluations/[^/]+/executions/[^/]+$",
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

                    /// <summary>Gets details of a single Execution.</summary>
                    /// <param name="name">Required. Name of the resource</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single Execution.</summary>
                    public class GetRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Execution>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/evaluations/[^/]+/executions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Executions in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The resource prefix of the Execution using the form:
                    /// 'projects/{project}/locations/{location}/evaluations/{evaluation}'
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Executions in a given project and location.</summary>
                    public class ListRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.ListExecutionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource prefix of the Execution using the form:
                        /// 'projects/{project}/locations/{location}/evaluations/{evaluation}'
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filtering results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Field to sort by. See https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Requested page size. Server may return fewer items than requested. If unspecified, server
                        /// will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/executions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/evaluations/[^/]+$",
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

                    /// <summary>Creates a new Execution in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the Execution using the form:
                    /// 'projects/{project}/locations/{location}/evaluations/{evaluation}/executions/{execution}'
                    /// </param>
                    public virtual RunRequest Run(Google.Apis.WorkloadManager.v1.Data.RunEvaluationRequest body, string name)
                    {
                        return new RunRequest(this.service, body, name);
                    }

                    /// <summary>Creates a new Execution in a given project and location.</summary>
                    public class RunRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Run request.</summary>
                        public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkloadManager.v1.Data.RunEvaluationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the Execution using the form:
                        /// 'projects/{project}/locations/{location}/evaluations/{evaluation}/executions/{execution}'
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.WorkloadManager.v1.Data.RunEvaluationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "run";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/executions:run";

                        /// <summary>Initializes Run parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/evaluations/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new Evaluation in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource prefix of the evaluation location using the form:
                /// `projects/{project_id}/locations/{location_id}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.WorkloadManager.v1.Data.Evaluation body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Evaluation in a given project and location.</summary>
                public class CreateRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkloadManager.v1.Data.Evaluation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource prefix of the evaluation location using the form:
                    /// `projects/{project_id}/locations/{location_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. Id of the requesting object</summary>
                    [Google.Apis.Util.RequestParameterAttribute("evaluationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EvaluationId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.WorkloadManager.v1.Data.Evaluation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/evaluations";

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
                        RequestParameters.Add("evaluationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "evaluationId",
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

                /// <summary>Deletes a single Evaluation.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Evaluation.</summary>
                public class DeleteRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Followed the best practice from https://aip.dev/135#cascading-delete
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/evaluations/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
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

                /// <summary>Gets details of a single Evaluation.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Evaluation.</summary>
                public class GetRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Evaluation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/evaluations/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Evaluations in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for ListEvaluationsRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Evaluations in a given project and location.</summary>
                public class ListRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.ListEvaluationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListEvaluationsRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter to be applied when listing the evaluation results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/evaluations";

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

            /// <summary>Gets the Insights resource.</summary>
            public virtual InsightsResource Insights { get; }

            /// <summary>The "insights" collection of methods.</summary>
            public class InsightsResource
            {
                private const string Resource = "insights";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InsightsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Delete the data insights from workload manager data warehouse.</summary>
                /// <param name="name">
                /// Required. The system id of the SAP system resource to delete. Formatted as
                /// projects/{project}/locations/{location}/sapSystems/{sap_system_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Delete the data insights from workload manager data warehouse.</summary>
                public class DeleteRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The system id of the SAP system resource to delete. Formatted as
                    /// projects/{project}/locations/{location}/sapSystems/{sap_system_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/insights/[^/]+$",
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

                /// <summary>Write the data insights to workload manager data warehouse.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="location">
                /// Required. The GCP location. The format is: projects/{project}/locations/{location}.
                /// </param>
                public virtual WriteInsightRequest WriteInsight(Google.Apis.WorkloadManager.v1.Data.WriteInsightRequest body, string location)
                {
                    return new WriteInsightRequest(this.service, body, location);
                }

                /// <summary>Write the data insights to workload manager data warehouse.</summary>
                public class WriteInsightRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.WriteInsightResponse>
                {
                    /// <summary>Constructs a new WriteInsight request.</summary>
                    public WriteInsightRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkloadManager.v1.Data.WriteInsightRequest body, string location) : base(service)
                    {
                        Location = location;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The GCP location. The format is: projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.WorkloadManager.v1.Data.WriteInsightRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "writeInsight";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+location}/insights:writeInsight";

                    /// <summary>Initializes WriteInsight parameter list.</summary>
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
                public virtual CancelRequest Cancel(Google.Apis.WorkloadManager.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkloadManager.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.WorkloadManager.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Empty>
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
                public class GetRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Operation>
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
                public class ListRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the Rules resource.</summary>
            public virtual RulesResource Rules { get; }

            /// <summary>The "rules" collection of methods.</summary>
            public class RulesResource
            {
                private const string Resource = "rules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists rules in a given project.</summary>
                /// <param name="parent">
                /// Required. The [project] on which to execute the request. The format is:
                /// projects/{project_id}/locations/{location} Currently, the pre-defined rules are global available to
                /// all projects and all regions
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists rules in a given project.</summary>
                public class ListRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.ListRulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The [project] on which to execute the request. The format is:
                    /// projects/{project_id}/locations/{location} Currently, the pre-defined rules are global available
                    /// to all projects and all regions
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The Cloud Storage bucket name for custom rules.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("customRulesBucket", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CustomRulesBucket { get; set; }

                    /// <summary>
                    /// Optional. The evaluation type of the rules will be applied to. The Cloud Storage bucket name for
                    /// custom rules.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("evaluationType", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<EvaluationTypeEnum> EvaluationType { get; set; }

                    /// <summary>
                    /// Optional. The evaluation type of the rules will be applied to. The Cloud Storage bucket name for
                    /// custom rules.
                    /// </summary>
                    public enum EvaluationTypeEnum
                    {
                        /// <summary>Not specified</summary>
                        [Google.Apis.Util.StringValueAttribute("EVALUATION_TYPE_UNSPECIFIED")]
                        EVALUATIONTYPEUNSPECIFIED = 0,

                        /// <summary>SAP best practices</summary>
                        [Google.Apis.Util.StringValueAttribute("SAP")]
                        SAP = 1,

                        /// <summary>SQL best practices</summary>
                        [Google.Apis.Util.StringValueAttribute("SQL_SERVER")]
                        SQLSERVER = 2,

                        /// <summary>Customized best practices</summary>
                        [Google.Apis.Util.StringValueAttribute("OTHER")]
                        OTHER = 3,

                        /// <summary>SCC IaC (Infra as Code) best practices</summary>
                        [Google.Apis.Util.StringValueAttribute("SCC_IAC")]
                        SCCIAC = 4,
                    }

                    /// <summary>Filter based on primary_category, secondary_category</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Requested page size. Server may return fewer items than requested. If unspecified, server will
                    /// pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/rules";

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
                        RequestParameters.Add("customRulesBucket", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customRulesBucket",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("evaluationType", new Google.Apis.Discovery.Parameter
                        {
                            Name = "evaluationType",
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.Location>
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
            public class ListRequest : WorkloadManagerBaseServiceRequest<Google.Apis.WorkloadManager.v1.Data.ListLocationsResponse>
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
namespace Google.Apis.WorkloadManager.v1.Data
{
    /// <summary>The API layer server</summary>
    public class APILayerServer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The api layer name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. OS information</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>Output only. resources in the component</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<CloudResource> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>* An AgentCommand specifies a one-time executable program for the agent to run.</summary>
    public class AgentCommand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>command is the name of the agent one-time executable that will be invoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        /// <summary>
        /// parameters is a map of key/value pairs that can be used to specify additional one-time executable settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The availability groups for sqlserver</summary>
    public class AvailabilityGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The databases</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databases")]
        public virtual System.Collections.Generic.IList<string> Databases { get; set; }

        /// <summary>Output only. The availability group name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The primary server</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryServer")]
        public virtual string PrimaryServer { get; set; }

        /// <summary>Output only. The secondary servers</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryServers")]
        public virtual System.Collections.Generic.IList<string> SecondaryServers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The backend server</summary>
    public class BackendServer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The backup file</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupFile")]
        public virtual string BackupFile { get; set; }

        /// <summary>Output only. The backup schedule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSchedule")]
        public virtual string BackupSchedule { get; set; }

        /// <summary>Output only. The backend name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. OS information</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>Output only. resources in the component</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<CloudResource> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup properties.</summary>
    public class BackupProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The state of the latest backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestBackupStatus")]
        public virtual string LatestBackupStatus { get; set; }

        private string _latestBackupTimeRaw;

        private object _latestBackupTime;

        /// <summary>The time when the latest backup was performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestBackupTime")]
        public virtual string LatestBackupTimeRaw
        {
            get => _latestBackupTimeRaw;
            set
            {
                _latestBackupTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _latestBackupTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LatestBackupTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LatestBackupTimeDateTimeOffset instead.")]
        public virtual object LatestBackupTime
        {
            get => _latestBackupTime;
            set
            {
                _latestBackupTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _latestBackupTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LatestBackupTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LatestBackupTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LatestBackupTimeRaw);
            set => LatestBackupTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing big query destination</summary>
    public class BigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. determine if results will be saved in a new table</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createNewResultsTable")]
        public virtual System.Nullable<bool> CreateNewResultsTable { get; set; }

        /// <summary>Optional. destination dataset to save evaluation results</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDataset")]
        public virtual string DestinationDataset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The resource on GCP</summary>
    public class CloudResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. All instance properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceProperties")]
        public virtual InstanceProperties InstanceProperties { get; set; }

        /// <summary>Output only. ComputeInstance, ComputeDisk, VPC, Bare Metal server, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. resource name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The cluster for sqlserver</summary>
    public class Cluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The nodes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<string> Nodes { get; set; }

        /// <summary>Output only. The witness server</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessServer")]
        public virtual string WitnessServer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>* Command specifies the type of command to execute.</summary>
    public class Command : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AgentCommand specifies a one-time executable program for the agent to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentCommand")]
        public virtual AgentCommand AgentCommand { get; set; }

        /// <summary>ShellCommand is invoked via the agent's command line executor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shellCommand")]
        public virtual ShellCommand ShellCommand { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HealthCondition contains the detailed health check of each component.</summary>
    public class ComponentHealth : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The component of a workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("component")]
        public virtual string Component { get; set; }

        /// <summary>The detailed health checks of the component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentHealthChecks")]
        public virtual System.Collections.Generic.IList<HealthCheck> ComponentHealthChecks { get; set; }

        /// <summary>Output only. The type of the component health.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentHealthType")]
        public virtual string ComponentHealthType { get; set; }

        /// <summary>Output only. The requirement of the component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRequired")]
        public virtual System.Nullable<bool> IsRequired { get; set; }

        /// <summary>Output only. The health state of the component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Sub component health.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subComponentHealthes")]
        public virtual System.Collections.Generic.IList<ComponentHealth> SubComponentHealthes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The database for sqlserver</summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The backup file</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupFile")]
        public virtual string BackupFile { get; set; }

        /// <summary>Output only. The backup schedule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSchedule")]
        public virtual string BackupSchedule { get; set; }

        /// <summary>Output only. The host VM</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostVm")]
        public virtual string HostVm { get; set; }

        /// <summary>Output only. The database name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database Properties.</summary>
    public class DatabaseProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Backup properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupProperties")]
        public virtual BackupProperties BackupProperties { get; set; }

        /// <summary>Output only. Type of the database. HANA, DB2, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseType")]
        public virtual string DatabaseType { get; set; }

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

    /// <summary>Message describing Evaluation object</summary>
    public class Evaluation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. BigQuery destination</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQueryDestination")]
        public virtual BigQueryDestination BigQueryDestination { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. [Output only] Create time stamp</summary>
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

        /// <summary>The Cloud Storage bucket name for custom rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customRulesBucket")]
        public virtual string CustomRulesBucket { get; set; }

        /// <summary>Description of the Evaluation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Evaluation type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationType")]
        public virtual string EvaluationType { get; set; }

        /// <summary>Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// name of resource names have the form
        /// 'projects/{project_id}/locations/{location_id}/evaluations/{evaluation_id}'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>annotations as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFilter")]
        public virtual ResourceFilter ResourceFilter { get; set; }

        /// <summary>Output only. [Output only] The updated rule ids if exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceStatus")]
        public virtual ResourceStatus ResourceStatus { get; set; }

        /// <summary>the name of the rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleNames")]
        public virtual System.Collections.Generic.IList<string> RuleNames { get; set; }

        /// <summary>Output only. [Output only] The updated rule ids if exist.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleVersions")]
        public virtual System.Collections.Generic.IList<string> RuleVersions { get; set; }

        /// <summary>
        /// crontab format schedule for scheduled evaluation, currently only support the following schedule: "0 */1 * *
        /// *", "0 */6 * * *", "0 */12 * * *", "0 0 */1 * *", "0 0 */7 * *",
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. [Output only] Update time stamp</summary>
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

    /// <summary>Message describing Execution object</summary>
    public class Execution : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. [Output only] End time stamp</summary>
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

        /// <summary>Output only. [Output only] Evaluation ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationId")]
        public virtual string EvaluationId { get; set; }

        /// <summary>Optional. External data sources</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDataSources")]
        public virtual System.Collections.Generic.IList<ExternalDataSources> ExternalDataSources { get; set; }

        private string _inventoryTimeRaw;

        private object _inventoryTime;

        /// <summary>Output only. [Output only] Inventory time stamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryTime")]
        public virtual string InventoryTimeRaw
        {
            get => _inventoryTimeRaw;
            set
            {
                _inventoryTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _inventoryTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="InventoryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InventoryTimeDateTimeOffset instead.")]
        public virtual object InventoryTime
        {
            get => _inventoryTime;
            set
            {
                _inventoryTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _inventoryTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="InventoryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? InventoryTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InventoryTimeRaw);
            set => InventoryTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The name of execution resource. The format is
        /// projects/{project}/locations/{location}/evaluations/{evaluation}/executions/{execution}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Additional information generated by the execution</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notices")]
        public virtual System.Collections.Generic.IList<Notice> Notices { get; set; }

        /// <summary>Output only. [Output only] Result summary for the execution</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultSummary")]
        public virtual Summary ResultSummary { get; set; }

        /// <summary>Output only. execution result summary per rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleResults")]
        public virtual System.Collections.Generic.IList<RuleExecutionResult> RuleResults { get; set; }

        /// <summary>
        /// type represent whether the execution executed directly by user or scheduled according evaluation.schedule
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runType")]
        public virtual string RunType { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. [Output only] Start time stamp</summary>
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

        /// <summary>Output only. [Output only] State</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing the result of an execution</summary>
    public class ExecutionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The commands to remediate the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<Command> Commands { get; set; }

        /// <summary>The URL for the documentation of the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUrl")]
        public virtual string DocumentationUrl { get; set; }

        /// <summary>The resource that violates the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>The rule that is violated in an evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual string Rule { get; set; }

        /// <summary>The severity of violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Execution result type of the scanned resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The details of violation in an evaluation result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violationDetails")]
        public virtual ViolationDetails ViolationDetails { get; set; }

        /// <summary>The violation message of an execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violationMessage")]
        public virtual string ViolationMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for external data sources</summary>
    public class ExternalDataSources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The asset type of the external data source this can be one of go/cai-asset-types to override the
        /// default asset type or it can be a custom type defined by the user custom type must match the asset type in
        /// the rule
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// Optional. Name of external data source. The name will be used inside the rego/sql to refer the external data
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Type of external data source</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Required. URI of external data source. example of bq table {project_ID}.{dataset_ID}.{table_ID}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The front end server</summary>
    public class FrontEndServer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The frontend name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. OS information</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; }

        /// <summary>Output only. resources in the component</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<CloudResource> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing compute engine instance filter</summary>
    public class GceInstanceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Service account of compute engine</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccounts")]
        public virtual System.Collections.Generic.IList<string> ServiceAccounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HealthCheck contains the detailed health check of a component based on asource.</summary>
    public class HealthCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The message of the health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Output only. The health check source metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>Output only. The resource the check performs on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual CloudResource Resource { get; set; }

        /// <summary>Output only. The source of the health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Output only. The state of the health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A presentation of host resource usage where the workload runs.</summary>
    public class Insight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The instance id where the insight is generated from</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>
        /// The insights data for SAP system discovery. This is a copy of SAP System proto and should get updated
        /// whenever that one changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sapDiscovery")]
        public virtual SapDiscovery SapDiscovery { get; set; }

        /// <summary>The insights data for the SAP workload validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sapValidation")]
        public virtual SapValidation SapValidation { get; set; }

        private string _sentTimeRaw;

        private object _sentTime;

        /// <summary>Output only. [Output only] Create time stamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentTime")]
        public virtual string SentTimeRaw
        {
            get => _sentTimeRaw;
            set
            {
                _sentTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _sentTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SentTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SentTimeDateTimeOffset instead.")]
        public virtual object SentTime
        {
            get => _sentTime;
            set
            {
                _sentTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _sentTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SentTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SentTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SentTimeRaw);
            set => SentTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The insights data for the sqlserver workload validation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlserverValidation")]
        public virtual SqlserverValidation SqlserverValidation { get; set; }

        /// <summary>The insights data for workload validation of torso workloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("torsoValidation")]
        public virtual TorsoValidation TorsoValidation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>a vm instance</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. name of the VM</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The location of the VM</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Output only. The state of the VM</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance Properties.</summary>
    public class InstanceProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Instance number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceNumber")]
        public virtual string InstanceNumber { get; set; }

        /// <summary>Optional. Instance machine type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Optional. Instance role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Optional. Instance roles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>Optional. SAP Instance properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sapInstanceProperties")]
        public virtual SapInstanceProperties SapInstanceProperties { get; set; }

        /// <summary>Optional. Instance status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Optional. the next maintenance event on VM</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upcomingMaintenanceEvent")]
        public virtual UpcomingMaintenanceEvent UpcomingMaintenanceEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The database layer</summary>
    public class Layer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>the application layer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationType")]
        public virtual string ApplicationType { get; set; }

        /// <summary>Optional. the database layer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseType")]
        public virtual string DatabaseType { get; set; }

        /// <summary>Optional. instances in a layer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>Output only. system identification of a layer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sid")]
        public virtual string Sid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List discovered profile Response returns discovered profiles from agents</summary>
    public class ListDiscoveredProfilesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A token identifying a page of results the server should return</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>Output only. The list of workload profiles</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadProfiles")]
        public virtual System.Collections.Generic.IList<WorkloadProfile> WorkloadProfiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing Evaluations</summary>
    public class ListEvaluationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Evaluation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluations")]
        public virtual System.Collections.Generic.IList<Evaluation> Evaluations { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response of list execution results</summary>
    public class ListExecutionResultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The versions from the specified publisher.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionResults")]
        public virtual System.Collections.Generic.IList<ExecutionResult> ExecutionResults { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing Executions</summary>
    public class ListExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Execution</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executions")]
        public virtual System.Collections.Generic.IList<Execution> Executions { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
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

    /// <summary>Mesesage of response of list rules</summary>
    public class ListRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>all rules in response</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<Rule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to list scanned resources</summary>
    public class ListScannedResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>All scanned resources in response</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scannedResources")]
        public virtual System.Collections.Generic.IList<ScannedResource> ScannedResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The load balancer for sqlserver</summary>
    public class LoadBalancerServer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The IP address</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public virtual string Ip { get; set; }

        /// <summary>Output only. The VM name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vm")]
        public virtual string Vm { get; set; }

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

    /// <summary>Message for additional information generated by the execution</summary>
    public class Notice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Message of the notice</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

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

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product contains the details of a product.</summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Name of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Version of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message represent resource in execution result</summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The service account associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The type of resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing resource filters</summary>
    public class ResourceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filter compute engine resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceInstanceFilter")]
        public virtual GceInstanceFilter GceInstanceFilter { get; set; }

        /// <summary>The label used for filter resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusionLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> InclusionLabels { get; set; }

        /// <summary>The id pattern for filter resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceIdPatterns")]
        public virtual System.Collections.Generic.IList<string> ResourceIdPatterns { get; set; }

        /// <summary>The scopes of evaluation resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing resource status</summary>
    public class ResourceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Historical: Used before 2023-05-22 the new version of rule id if exists</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rulesNewerVersions")]
        public virtual System.Collections.Generic.IList<string> RulesNewerVersions { get; set; }

        /// <summary>State of the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message represent a rule</summary>
    public class Rule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>descrite rule in plain language</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>the name display in UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>the message template for rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>rule name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>the primary category</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryCategory")]
        public virtual string PrimaryCategory { get; set; }

        /// <summary>the remediation for the rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediation")]
        public virtual string Remediation { get; set; }

        /// <summary>Output only. the version of the rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>the secondary category</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryCategory")]
        public virtual string SecondaryCategory { get; set; }

        /// <summary>the severity of the rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>List of user-defined tags</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>the docuement url for the rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for execution result summary per rule</summary>
    public class RuleExecutionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Execution message, if any</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Number of violations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultCount")]
        public virtual System.Nullable<long> ResultCount { get; set; }

        /// <summary>rule name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual string Rule { get; set; }

        /// <summary>Number of total scanned resources</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scannedResourceCount")]
        public virtual System.Nullable<long> ScannedResourceCount { get; set; }

        /// <summary>Output only. The execution status</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for creating a Execution</summary>
    public class RunEvaluationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource being created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("execution")]
        public virtual Execution Execution { get; set; }

        /// <summary>
        /// Required. Id of the requesting object If auto-generating Id server-side, remove this field and execution_id
        /// from the method_signature of Create RPC
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionId")]
        public virtual string ExecutionId { get; set; }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes since the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The component of sap workload</summary>
    public class SapComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. All instance properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseProperties")]
        public virtual DatabaseProperties DatabaseProperties { get; set; }

        /// <summary>
        /// A list of host URIs that are part of the HA configuration if present. An empty list indicates the component
        /// is not configured for HA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("haHosts")]
        public virtual System.Collections.Generic.IList<string> HaHosts { get; set; }

        /// <summary>Output only. resources in the component</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<CloudResource> Resources { get; set; }

        /// <summary>Output only. sid is the sap component identificator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sid")]
        public virtual string Sid { get; set; }

        /// <summary>The detected topology of the component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topologyType")]
        public virtual string TopologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The schema of SAP system discovery data.</summary>
    public class SapDiscovery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. An SAP system may run without an application layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationLayer")]
        public virtual SapDiscoveryComponent ApplicationLayer { get; set; }

        /// <summary>Required. An SAP System must have a database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseLayer")]
        public virtual SapDiscoveryComponent DatabaseLayer { get; set; }

        /// <summary>Optional. The metadata for SAP system discovery data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual SapDiscoveryMetadata Metadata { get; set; }

        /// <summary>Optional. The GCP project number that this SapSystem belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual string ProjectNumber { get; set; }

        /// <summary>
        /// Output only. A combination of database SID, database instance URI and tenant DB name to make a unique
        /// identifier per-system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemId")]
        public virtual string SystemId { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Required. Unix timestamp this system has been updated last.</summary>
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

        /// <summary>Optional. Whether to use DR reconciliation or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useDrReconciliation")]
        public virtual System.Nullable<bool> UseDrReconciliation { get; set; }

        /// <summary>Optional. The properties of the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadProperties")]
        public virtual SapDiscoveryWorkloadProperties WorkloadProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing the system component.</summary>
    public class SapDiscoveryComponent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The component is a SAP application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationProperties")]
        public virtual SapDiscoveryComponentApplicationProperties ApplicationProperties { get; set; }

        /// <summary>Optional. The component is a SAP database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseProperties")]
        public virtual SapDiscoveryComponentDatabaseProperties DatabaseProperties { get; set; }

        /// <summary>
        /// Optional. A list of host URIs that are part of the HA configuration if present. An empty list indicates the
        /// component is not configured for HA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("haHosts")]
        public virtual System.Collections.Generic.IList<string> HaHosts { get; set; }

        /// <summary>Required. Pantheon Project in which the resources reside.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostProject")]
        public virtual string HostProject { get; set; }

        /// <summary>Optional. The region this component's resources are primarily located in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Optional. A list of replication sites used in Disaster Recovery (DR) configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicationSites")]
        public virtual System.Collections.Generic.IList<SapDiscoveryComponentReplicationSite> ReplicationSites { get; set; }

        /// <summary>Optional. The resources in a component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<SapDiscoveryResource> Resources { get; set; }

        /// <summary>
        /// Optional. The SAP identifier, used by the SAP software and helps differentiate systems for customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sid")]
        public virtual string Sid { get; set; }

        /// <summary>Optional. The detected topology of the component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topologyType")]
        public virtual string TopologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of properties describing an SAP Application layer.</summary>
    public class SapDiscoveryComponentApplicationProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Deprecated: ApplicationType now tells you whether this is ABAP or Java.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abap")]
        public virtual System.Nullable<bool> Abap { get; set; }

        /// <summary>Optional. Instance number of the SAP application instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appInstanceNumber")]
        public virtual string AppInstanceNumber { get; set; }

        /// <summary>Required. Type of the application. Netweaver, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationType")]
        public virtual string ApplicationType { get; set; }

        /// <summary>Optional. Instance number of the ASCS instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ascsInstanceNumber")]
        public virtual string AscsInstanceNumber { get; set; }

        /// <summary>Optional. Resource URI of the recognized ASCS host of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ascsUri")]
        public virtual string AscsUri { get; set; }

        /// <summary>Optional. Instance number of the ERS instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ersInstanceNumber")]
        public virtual string ErsInstanceNumber { get; set; }

        /// <summary>Optional. Kernel version for Netweaver running in the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; }

        /// <summary>
        /// Optional. Resource URI of the recognized shared NFS of the application. May be empty if the application
        /// server has only a single node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsUri")]
        public virtual string NfsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of properties describing an SAP Database layer.</summary>
    public class SapDiscoveryComponentDatabaseProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. SID of the system database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseSid")]
        public virtual string DatabaseSid { get; set; }

        /// <summary>Required. Type of the database. HANA, DB2, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseType")]
        public virtual string DatabaseType { get; set; }

        /// <summary>Optional. The version of the database software running in the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseVersion")]
        public virtual string DatabaseVersion { get; set; }

        /// <summary>Optional. Instance number of the SAP instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceNumber")]
        public virtual string InstanceNumber { get; set; }

        /// <summary>Optional. Landscape ID from the HANA nameserver.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("landscapeId")]
        public virtual string LandscapeId { get; set; }

        /// <summary>Required. URI of the recognized primary instance of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryInstanceUri")]
        public virtual string PrimaryInstanceUri { get; set; }

        /// <summary>
        /// Optional. URI of the recognized shared NFS of the database. May be empty if the database has only a single
        /// node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedNfsUri")]
        public virtual string SharedNfsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A replication site used in Disaster Recovery (DR) configurations.</summary>
    public class SapDiscoveryComponentReplicationSite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The system component for the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("component")]
        public virtual SapDiscoveryComponent Component { get; set; }

        /// <summary>Optional. The name of the source site from which this one replicates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSite")]
        public virtual string SourceSite { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing SAP discovery system metadata</summary>
    public class SapDiscoveryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Customer region string for customer's use. Does not represent GCP region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerRegion")]
        public virtual string CustomerRegion { get; set; }

        /// <summary>Optional. Customer defined, something like "E-commerce pre prod"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definedSystem")]
        public virtual string DefinedSystem { get; set; }

        /// <summary>Optional. Should be "prod", "QA", "dev", "staging", etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentType")]
        public virtual string EnvironmentType { get; set; }

        /// <summary>Optional. This SAP product name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sapProduct")]
        public virtual string SapProduct { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing a resource.</summary>
    public class SapDiscoveryResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A set of properties only applying to instance type resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceProperties")]
        public virtual SapDiscoveryResourceInstanceProperties InstanceProperties { get; set; }

        /// <summary>Optional. A list of resource URIs related to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedResources")]
        public virtual System.Collections.Generic.IList<string> RelatedResources { get; set; }

        /// <summary>Required. ComputeInstance, ComputeDisk, VPC, Bare Metal server, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceKind")]
        public virtual string ResourceKind { get; set; }

        /// <summary>Required. The type of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Required. URI of the resource, includes project, location, and name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Required. Unix timestamp of when this resource last had its discovery data updated.</summary>
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

    /// <summary>A set of properties only present for an instance type resource</summary>
    public class SapDiscoveryResourceInstanceProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. App server instances on the host</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appInstances")]
        public virtual System.Collections.Generic.IList<SapDiscoveryResourceInstancePropertiesAppInstance> AppInstances { get; set; }

        /// <summary>Optional. A list of instance URIs that are part of a cluster with this one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterInstances")]
        public virtual System.Collections.Generic.IList<string> ClusterInstances { get; set; }

        /// <summary>Optional. Disk mounts on the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskMounts")]
        public virtual System.Collections.Generic.IList<SapDiscoveryResourceInstancePropertiesDiskMount> DiskMounts { get; set; }

        /// <summary>Optional. The VM's instance number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceNumber")]
        public virtual System.Nullable<long> InstanceNumber { get; set; }

        /// <summary>Optional. Bitmask of instance role, a resource may have multiple roles at once.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceRole")]
        public virtual string InstanceRole { get; set; }

        /// <summary>Optional. Instance is part of a DR site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDrSite")]
        public virtual System.Nullable<bool> IsDrSite { get; set; }

        /// <summary>Optional. A virtual hostname of the instance if it has one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualHostname")]
        public virtual string VirtualHostname { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fields to describe an SAP application server instance.</summary>
    public class SapDiscoveryResourceInstancePropertiesAppInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Instance name of the SAP application instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Instance number of the SAP application instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual string Number { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Disk mount on the instance.</summary>
    public class SapDiscoveryResourceInstancePropertiesDiskMount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Names of the disks providing this mount point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskNames")]
        public virtual System.Collections.Generic.IList<string> DiskNames { get; set; }

        /// <summary>Optional. Filesystem mount point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPoint")]
        public virtual string MountPoint { get; set; }

        /// <summary>Optional. Name of the disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of properties describing an SAP workload.</summary>
    public class SapDiscoveryWorkloadProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of SAP Products and their versions running on the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productVersions")]
        public virtual System.Collections.Generic.IList<SapDiscoveryWorkloadPropertiesProductVersion> ProductVersions { get; set; }

        /// <summary>Optional. A list of SAP software components and their versions running on the system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareComponentVersions")]
        public virtual System.Collections.Generic.IList<SapDiscoveryWorkloadPropertiesSoftwareComponentProperties> SoftwareComponentVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A product name and version.</summary>
    public class SapDiscoveryWorkloadPropertiesProductVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Name of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Version of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A SAP software component name, version, and type.</summary>
    public class SapDiscoveryWorkloadPropertiesSoftwareComponentProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The component's minor version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extVersion")]
        public virtual string ExtVersion { get; set; }

        /// <summary>Optional. Name of the component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The component's type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Optional. The component's major version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SAP instance properties.</summary>
    public class SapInstanceProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. SAP Instance numbers. They are from '00' to '99'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numbers")]
        public virtual System.Collections.Generic.IList<string> Numbers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A presentation of SAP workload insight. The schema of SAP workloads validation related data.</summary>
    public class SapValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The project_id of the cloud project that the Insight data comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Optional. A list of SAP validation metrics data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationDetails")]
        public virtual System.Collections.Generic.IList<SapValidationValidationDetail> ValidationDetails { get; set; }

        /// <summary>Optional. The zone of the instance that the Insight data comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing the SAP validation metrics.</summary>
    public class SapValidationValidationDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The pairs of metrics data: field name &amp; field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, string> Details { get; set; }

        /// <summary>Optional. Was there a SAP system detected for this validation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPresent")]
        public virtual System.Nullable<bool> IsPresent { get; set; }

        /// <summary>Optional. The SAP system that the validation data is from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sapValidationType")]
        public virtual string SapValidationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The body of sap workload</summary>
    public class SapWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. the acsc componment</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual SapComponent Application { get; set; }

        /// <summary>Output only. the architecture</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>Output only. the database componment</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual SapComponent Database { get; set; }

        /// <summary>Output only. The metadata for SAP workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>Output only. the products on this workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<Product> Products { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message of scanned resource</summary>
    public class ScannedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>resource name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>resource type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>* A ShellCommand is invoked via the agent's command line executor</summary>
    public class ShellCommand : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>args is a string of arguments to be passed to the command.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual string Args { get; set; }

        /// <summary>command is the name of the command to be executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        /// <summary>Optional. If not specified, the default timeout is 60 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<int> TimeoutSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A presentation of SQLServer workload insight. The schema of SqlServer workloads validation related data.
    /// </summary>
    public class SqlserverValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The agent version collected this data point</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentVersion")]
        public virtual string AgentVersion { get; set; }

        /// <summary>
        /// Required. The instance_name of the instance that the Insight data comes from. According to
        /// https://linter.aip.dev/122/name-suffix: field names should not use the _name suffix unless the field would
        /// be ambiguous without it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>Required. The project_id of the cloud project that the Insight data comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Optional. A list of SqlServer validation metrics data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationDetails")]
        public virtual System.Collections.Generic.IList<SqlserverValidationValidationDetail> ValidationDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message containing collected data names and values.</summary>
    public class SqlserverValidationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Collected data is in format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, string> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing the Sqlserver validation metrics.</summary>
    public class SqlserverValidationValidationDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Details wraps map that represents collected data names and values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<SqlserverValidationDetails> Details { get; set; }

        /// <summary>Optional. The Sqlserver system that the validation data is from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The body of sqlserver workload</summary>
    public class SqlserverWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The availability groups for sqlserver</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ags")]
        public virtual System.Collections.Generic.IList<AvailabilityGroup> Ags { get; set; }

        /// <summary>Output only. The cluster for sqlserver</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual Cluster Cluster { get; set; }

        /// <summary>Output only. The databases for sqlserver</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databases")]
        public virtual System.Collections.Generic.IList<Database> Databases { get; set; }

        /// <summary>Output only. The load balancer for sqlserver</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerServer")]
        public virtual LoadBalancerServer LoadBalancerServer { get; set; }

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

    /// <summary>Message for execution summary</summary>
    public class Summary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of failures</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failures")]
        public virtual System.Nullable<long> Failures { get; set; }

        /// <summary>Output only. Number of new failures compared to the previous execution</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newFailures")]
        public virtual System.Nullable<long> NewFailures { get; set; }

        /// <summary>Output only. Number of new fixes compared to the previous execution</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newFixes")]
        public virtual System.Nullable<long> NewFixes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The body of three tier workload</summary>
    public class ThreeTierWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The API layer for three tier workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiLayer")]
        public virtual APILayerServer ApiLayer { get; set; }

        /// <summary>Output only. The backend for three tier workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backend")]
        public virtual BackendServer Backend { get; set; }

        /// <summary>Output only. the workload endpoint</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>Output only. The frontend for three tier workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frontend")]
        public virtual FrontEndServer Frontend { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The schema of torso workload validation data.</summary>
    public class TorsoValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. agent_version lists the version of the agent that collected this data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentVersion")]
        public virtual string AgentVersion { get; set; }

        /// <summary>
        /// Required. instance_name lists the human readable name of the instance that the data comes from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceName")]
        public virtual string InstanceName { get; set; }

        /// <summary>Required. project_id lists the human readable cloud project that the data comes from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// Required. validation_details contains the pairs of validation data: field name &amp;amp; field value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationDetails")]
        public virtual System.Collections.Generic.IDictionary<string, string> ValidationDetails { get; set; }

        /// <summary>Required. workload_type specifies the type of torso workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadType")]
        public virtual string WorkloadType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maintenance Event</summary>
    public class UpcomingMaintenanceEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Optional. End time</summary>
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

        /// <summary>Optional. Maintenance status</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceStatus")]
        public virtual string MaintenanceStatus { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Optional. Start time</summary>
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

        /// <summary>Optional. Type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing the violation in an evaluation result.</summary>
    public class ViolationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>Details of the violation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observed")]
        public virtual System.Collections.Generic.IDictionary<string, string> Observed { get; set; }

        /// <summary>The service account associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>workload resource</summary>
    public class WorkloadProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The application layer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual Layer Application { get; set; }

        /// <summary>Optional. The ascs layer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ascs")]
        public virtual Layer Ascs { get; set; }

        /// <summary>Optional. The database layer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual Layer Database { get; set; }

        /// <summary>Optional. such as name, description, version. More example can be found in deployment</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. name of resource names have the form 'projects/{project_id}/workloads/{workload_id}'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _refreshedTimeRaw;

        private object _refreshedTime;

        /// <summary>Required. time when the workload data was refreshed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshedTime")]
        public virtual string RefreshedTimeRaw
        {
            get => _refreshedTimeRaw;
            set
            {
                _refreshedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _refreshedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RefreshedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RefreshedTimeDateTimeOffset instead.")]
        public virtual object RefreshedTime
        {
            get => _refreshedTime;
            set
            {
                _refreshedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _refreshedTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RefreshedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RefreshedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RefreshedTimeRaw);
            set => RefreshedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The sap workload content</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sapWorkload")]
        public virtual SapWorkload SapWorkload { get; set; }

        /// <summary>The sqlserver workload content</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlserverWorkload")]
        public virtual SqlserverWorkload SqlserverWorkload { get; set; }

        /// <summary>Output only. [output only] the current state if a a workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The 3 tier web app workload content</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threeTierWorkload")]
        public virtual ThreeTierWorkload ThreeTierWorkload { get; set; }

        /// <summary>Required. The type of the workload</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadType")]
        public virtual string WorkloadType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>WorkloadProfileHealth contains the detailed health check of workload.</summary>
    public class WorkloadProfileHealth : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _checkTimeRaw;

        private object _checkTime;

        /// <summary>The time when the health check was performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkTime")]
        public virtual string CheckTimeRaw
        {
            get => _checkTimeRaw;
            set
            {
                _checkTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _checkTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CheckTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CheckTimeDateTimeOffset instead.")]
        public virtual object CheckTime
        {
            get => _checkTime;
            set
            {
                _checkTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _checkTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CheckTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CheckTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CheckTimeRaw);
            set => CheckTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The detailed condition reports of each component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentHealthes")]
        public virtual System.Collections.Generic.IList<ComponentHealth> ComponentHealthes { get; set; }

        /// <summary>Output only. The health state of the workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for sending the data insights.</summary>
    public class WriteInsightRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The agent version collected this data point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentVersion")]
        public virtual string AgentVersion { get; set; }

        /// <summary>Required. The metrics data details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insight")]
        public virtual Insight Insight { get; set; }

        /// <summary>
        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if you must retry
        /// your request, the server will know to ignore the request if it has already been completed. The server will
        /// guarantee that for at least 60 minutes since the first request. For example, consider a situation where you
        /// make an initial request and the request times out. If you make the request again with the same request ID,
        /// the server can check if original operation with the same request ID was received, and if so, will ignore the
        /// second request. This prevents clients from accidentally creating duplicate commitments. The request ID must
        /// be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for write insights request.</summary>
    public class WriteInsightResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
