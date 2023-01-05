// Copyright 2023 Google LLC
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

namespace Google.Apis.Datapipelines.v1
{
    /// <summary>The Datapipelines Service.</summary>
    public class DatapipelinesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DatapipelinesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DatapipelinesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "datapipelines";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://datapipelines.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://datapipelines.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Data pipelines API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Data pipelines API.</summary>
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

    /// <summary>A base abstract class for Datapipelines requests.</summary>
    public abstract class DatapipelinesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DatapipelinesBaseServiceRequest instance.</summary>
        protected DatapipelinesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Datapipelines parameter list.</summary>
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
                Pipelines = new PipelinesResource(service);
            }

            /// <summary>Gets the Pipelines resource.</summary>
            public virtual PipelinesResource Pipelines { get; }

            /// <summary>The "pipelines" collection of methods.</summary>
            public class PipelinesResource
            {
                private const string Resource = "pipelines";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PipelinesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Jobs = new JobsResource(service);
                }

                /// <summary>Gets the Jobs resource.</summary>
                public virtual JobsResource Jobs { get; }

                /// <summary>The "jobs" collection of methods.</summary>
                public class JobsResource
                {
                    private const string Resource = "jobs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public JobsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists jobs for a given pipeline. Throws a "FORBIDDEN" error if the caller doesn't have
                    /// permission to access it.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The pipeline name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists jobs for a given pipeline. Throws a "FORBIDDEN" error if the caller doesn't have
                    /// permission to access it.
                    /// </summary>
                    public class ListRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1ListJobsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The pipeline name. For example:
                        /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of entities to return. The service may return fewer than this value, even
                        /// if there are additional pages. If unspecified, the max limit will be determined by the
                        /// backend implementation.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListJobs` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListJobs` must match the
                        /// call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/jobs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/pipelines/[^/]+$",
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
                /// Creates a pipeline. For a batch pipeline, you can pass scheduler information. Data Pipelines uses
                /// the scheduler information to create an internal scheduler that runs jobs periodically. If the
                /// internal scheduler is not configured, you can use RunPipeline to run jobs.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a pipeline. For a batch pipeline, you can pass scheduler information. Data Pipelines uses
                /// the scheduler information to create an internal scheduler that runs jobs periodically. If the
                /// internal scheduler is not configured, you can use RunPipeline to run jobs.
                /// </summary>
                public class CreateRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/pipelines";

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
                /// Deletes a pipeline. If a scheduler job is attached to the pipeline, it will be deleted.
                /// </summary>
                /// <param name="name">
                /// Required. The pipeline name. For example:
                /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a pipeline. If a scheduler job is attached to the pipeline, it will be deleted.
                /// </summary>
                public class DeleteRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The pipeline name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/pipelines/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Looks up a single pipeline. Returns a "NOT_FOUND" error if no such pipeline exists. Returns a
                /// "FORBIDDEN" error if the caller doesn't have permission to access it.
                /// </summary>
                /// <param name="name">
                /// Required. The pipeline name. For example:
                /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Looks up a single pipeline. Returns a "NOT_FOUND" error if no such pipeline exists. Returns a
                /// "FORBIDDEN" error if the caller doesn't have permission to access it.
                /// </summary>
                public class GetRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The pipeline name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/pipelines/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists pipelines. Returns a "FORBIDDEN" error if the caller doesn't have permission to access it.
                /// </summary>
                /// <param name="parent">
                /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists pipelines. Returns a "FORBIDDEN" error if the caller doesn't have permission to access it.
                /// </summary>
                public class ListRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1ListPipelinesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// An expression for filtering the results of the request. If unspecified, all pipelines will be
                    /// returned. Multiple filters can be applied and must be comma separated. Fields eligible for
                    /// filtering are: + `type`: The type of the pipeline (streaming or batch). Allowed values are
                    /// `ALL`, `BATCH`, and `STREAMING`. + `status`: The activity status of the pipeline. Allowed values
                    /// are `ALL`, `ACTIVE`, `ARCHIVED`, and `PAUSED`. For example, to limit results to active batch
                    /// processing pipelines: type:BATCH,status:ACTIVE
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of entities to return. The service may return fewer than this value, even if
                    /// there are additional pages. If unspecified, the max limit is yet to be determined by the backend
                    /// implementation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListPipelines` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListPipelines` must match
                    /// the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/pipelines";

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
                /// Updates a pipeline. If successful, the updated Pipeline is returned. Returns `NOT_FOUND` if the
                /// pipeline doesn't exist. If UpdatePipeline does not return successfully, you can retry the
                /// UpdatePipeline request until you receive a successful response.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The pipeline name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`. *
                /// `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), and periods
                /// (.). For more information, see [Identifying
                /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects).
                /// * `LOCATION_ID` is the canonical ID for the pipeline's location. The list of available locations can
                /// be obtained by calling `google.cloud.location.Locations.ListLocations`. Note that the Data Pipelines
                /// service is not available in all regions. It depends on Cloud Scheduler, an App Engine application,
                /// so it's only available in [App Engine regions](https://cloud.google.com/about/locations#region). *
                /// `PIPELINE_ID` is the ID of the pipeline. Must be unique for the selected project and location.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a pipeline. If successful, the updated Pipeline is returned. Returns `NOT_FOUND` if the
                /// pipeline doesn't exist. If UpdatePipeline does not return successfully, you can retry the
                /// UpdatePipeline request until you receive a successful response.
                /// </summary>
                public class PatchRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The pipeline name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`. * `PROJECT_ID` can contain
                    /// letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), and periods (.). For more
                    /// information, see [Identifying
                    /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects).
                    /// * `LOCATION_ID` is the canonical ID for the pipeline's location. The list of available locations
                    /// can be obtained by calling `google.cloud.location.Locations.ListLocations`. Note that the Data
                    /// Pipelines service is not available in all regions. It depends on Cloud Scheduler, an App Engine
                    /// application, so it's only available in [App Engine
                    /// regions](https://cloud.google.com/about/locations#region). * `PIPELINE_ID` is the ID of the
                    /// pipeline. Must be unique for the selected project and location.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/pipelines/[^/]+$",
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
                /// Creates a job for the specified pipeline directly. You can use this method when the internal
                /// scheduler is not configured and you want to trigger the job directly or through an external system.
                /// Returns a "NOT_FOUND" error if the pipeline doesn't exist. Returns a "FORBIDDEN" error if the user
                /// doesn't have permission to access the pipeline or run jobs for the pipeline.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The pipeline name. For example:
                /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
                /// </param>
                public virtual RunRequest Run(Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1RunPipelineRequest body, string name)
                {
                    return new RunRequest(service, body, name);
                }

                /// <summary>
                /// Creates a job for the specified pipeline directly. You can use this method when the internal
                /// scheduler is not configured and you want to trigger the job directly or through an external system.
                /// Returns a "NOT_FOUND" error if the pipeline doesn't exist. Returns a "FORBIDDEN" error if the user
                /// doesn't have permission to access the pipeline or run jobs for the pipeline.
                /// </summary>
                public class RunRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1RunPipelineResponse>
                {
                    /// <summary>Constructs a new Run request.</summary>
                    public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1RunPipelineRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The pipeline name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1RunPipelineRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "run";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:run";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/pipelines/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Freezes pipeline execution permanently. If there's a corresponding scheduler entry, it's deleted,
                /// and the pipeline state is changed to "ARCHIVED". However, pipeline metadata is retained.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The pipeline name. For example:
                /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
                /// </param>
                public virtual StopRequest Stop(Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1StopPipelineRequest body, string name)
                {
                    return new StopRequest(service, body, name);
                }

                /// <summary>
                /// Freezes pipeline execution permanently. If there's a corresponding scheduler entry, it's deleted,
                /// and the pipeline state is changed to "ARCHIVED". However, pipeline metadata is retained.
                /// </summary>
                public class StopRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Pipeline>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1StopPipelineRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The pipeline name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1StopPipelineRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "stop";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:stop";

                    /// <summary>Initializes Stop parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/pipelines/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.Datapipelines.v1.Data
{
    /// <summary>
    /// Pipeline job details specific to the Dataflow API. This is encapsulated here to allow for more executors to
    /// store their specific details separately.
    /// </summary>
    public class GoogleCloudDatapipelinesV1DataflowJobDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The current number of workers used to run the jobs. Only set to a value if the job is still
        /// running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentWorkers")]
        public virtual System.Nullable<int> CurrentWorkers { get; set; }

        /// <summary>
        /// Cached version of all the metrics of interest for the job. This value gets stored here when the job is
        /// terminated. As long as the job is running, this field is populated from the Dataflow API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceInfo")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<double>> ResourceInfo { get; set; }

        /// <summary>Output only. The SDK version used to run the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual GoogleCloudDatapipelinesV1SdkVersion SdkVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The environment values to be set at runtime for a Flex Template.</summary>
    public class GoogleCloudDatapipelinesV1FlexTemplateRuntimeEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional experiment flags for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalExperiments")]
        public virtual System.Collections.Generic.IList<string> AdditionalExperiments { get; set; }

        /// <summary>
        /// Additional user labels to be specified for the job. Keys and values must follow the restrictions specified
        /// in the [labeling restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions). An
        /// object containing a list of key/value pairs. Example: `{ "name": "wrench", "mass": "1kg", "count": "3" }`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalUserLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalUserLabels { get; set; }

        /// <summary>Whether to enable Streaming Engine for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableStreamingEngine")]
        public virtual System.Nullable<bool> EnableStreamingEngine { get; set; }

        /// <summary>Set FlexRS goal for the job. https://cloud.google.com/dataflow/docs/guides/flexrs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flexrsGoal")]
        public virtual string FlexrsGoal { get; set; }

        /// <summary>Configuration for VM IPs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipConfiguration")]
        public virtual string IpConfiguration { get; set; }

        /// <summary>
        /// Name for the Cloud KMS key for the job. Key format is: projects//locations//keyRings//cryptoKeys/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// The machine type to use for the job. Defaults to the value from the template if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// The maximum number of Compute Engine instances to be made available to your pipeline during execution, from
        /// 1 to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWorkers")]
        public virtual System.Nullable<int> MaxWorkers { get; set; }

        /// <summary>
        /// Network to which VMs will be assigned. If empty or unspecified, the service will use the network "default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The initial number of Compute Engine instances for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numWorkers")]
        public virtual System.Nullable<int> NumWorkers { get; set; }

        /// <summary>The email address of the service account to run the job as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Subnetwork to which VMs will be assigned, if desired. You can specify a subnetwork using either a complete
        /// URL or an abbreviated path. Expected to be of the form
        /// "https://www.googleapis.com/compute/v1/projects/HOST_PROJECT_ID/regions/REGION/subnetworks/SUBNETWORK" or
        /// "regions/REGION/subnetworks/SUBNETWORK". If the subnetwork is located in a Shared VPC network, you must use
        /// the complete URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// The Cloud Storage path to use for temporary files. Must be a valid Cloud Storage URL, beginning with
        /// `gs://`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tempLocation")]
        public virtual string TempLocation { get; set; }

        /// <summary>
        /// The Compute Engine region (https://cloud.google.com/compute/docs/regions-zones/regions-zones) in which
        /// worker processing should occur, e.g. "us-west1". Mutually exclusive with worker_zone. If neither
        /// worker_region nor worker_zone is specified, defaults to the control plane region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerRegion")]
        public virtual string WorkerRegion { get; set; }

        /// <summary>
        /// The Compute Engine zone (https://cloud.google.com/compute/docs/regions-zones/regions-zones) in which worker
        /// processing should occur, e.g. "us-west1-a". Mutually exclusive with worker_region. If neither worker_region
        /// nor worker_zone is specified, a zone in the control plane region is chosen based on available capacity. If
        /// both `worker_zone` and `zone` are set, `worker_zone` takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerZone")]
        public virtual string WorkerZone { get; set; }

        /// <summary>
        /// The Compute Engine [availability zone](https://cloud.google.com/compute/docs/regions-zones/regions-zones)
        /// for launching worker instances to run your pipeline. In the future, worker_zone will take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of the job information maintained by the pipeline. Fields in this entity are retrieved from the
    /// executor API (e.g. Dataflow API).
    /// </summary>
    public class GoogleCloudDatapipelinesV1Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time of job creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>All the details that are specific to a Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataflowJobDetails")]
        public virtual GoogleCloudDatapipelinesV1DataflowJobDetails DataflowJobDetails { get; set; }

        /// <summary>Output only. The time of job termination. This is absent if the job is still running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Output only. The internal ID for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. The fully qualified resource name for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The current state of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Status capturing any error code or message related to job creation or execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Launch Flex Template parameter.</summary>
    public class GoogleCloudDatapipelinesV1LaunchFlexTemplateParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage path to a file with a JSON-serialized ContainerSpec as content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerSpecGcsPath")]
        public virtual string ContainerSpecGcsPath { get; set; }

        /// <summary>The runtime environment for the Flex Template job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual GoogleCloudDatapipelinesV1FlexTemplateRuntimeEnvironment Environment { get; set; }

        /// <summary>
        /// Required. The job name to use for the created job. For an update job request, the job name should be the
        /// same as the existing running job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobName")]
        public virtual string JobName { get; set; }

        /// <summary>
        /// Launch options for this Flex Template job. This is a common set of options across languages and templates.
        /// This should not be used to pass job parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchOptions")]
        public virtual System.Collections.Generic.IDictionary<string, string> LaunchOptions { get; set; }

        /// <summary>The parameters for the Flex Template. Example: `{"num_workers":"5"}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Use this to pass transform name mappings for streaming update jobs. Example:
        /// `{"oldTransformName":"newTransformName",...}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformNameMappings")]
        public virtual System.Collections.Generic.IDictionary<string, string> TransformNameMappings { get; set; }

        /// <summary>
        /// Set this to true if you are sending a request to update a running streaming job. When set, the job name
        /// should be the same as the running job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual System.Nullable<bool> Update { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to launch a Dataflow job from a Flex Template.</summary>
    public class GoogleCloudDatapipelinesV1LaunchFlexTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Parameter to launch a job from a Flex Template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchParameter")]
        public virtual GoogleCloudDatapipelinesV1LaunchFlexTemplateParameter LaunchParameter { get; set; }

        /// <summary>
        /// Required. The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
        /// which to direct the request. For example, `us-central1`, `us-west1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>If true, the request is validated but not actually executed. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to provide to the template being launched.</summary>
    public class GoogleCloudDatapipelinesV1LaunchTemplateParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The runtime environment for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual GoogleCloudDatapipelinesV1RuntimeEnvironment Environment { get; set; }

        /// <summary>Required. The job name to use for the created job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobName")]
        public virtual string JobName { get; set; }

        /// <summary>The runtime parameters to pass to the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Map of transform name prefixes of the job to be replaced to the corresponding name prefixes of the new job.
        /// Only applicable when updating a pipeline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformNameMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> TransformNameMapping { get; set; }

        /// <summary>
        /// If set, replace the existing pipeline with the name specified by jobName with this pipeline, preserving
        /// state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("update")]
        public virtual System.Nullable<bool> Update { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to launch a template.</summary>
    public class GoogleCloudDatapipelinesV1LaunchTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A Cloud Storage path to the template from which to create the job. Must be a valid Cloud Storage URL,
        /// beginning with 'gs://'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPath")]
        public virtual string GcsPath { get; set; }

        /// <summary>
        /// The parameters of the template to launch. This should be part of the body of the POST request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchParameters")]
        public virtual GoogleCloudDatapipelinesV1LaunchTemplateParameters LaunchParameters { get; set; }

        /// <summary>
        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to which to
        /// direct the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>If true, the request is validated but not actually executed. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListJobs</summary>
    public class GoogleCloudDatapipelinesV1ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Results that were accessible to the caller. Results are always in descending order of job creation date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1Job> Jobs { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListPipelines.</summary>
    public class GoogleCloudDatapipelinesV1ListPipelinesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Results that matched the filter criteria and were accessible to the caller. Results are always in descending
        /// order of pipeline creation date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelines")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1Pipeline> Pipelines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The main pipeline entity and all the necessary metadata for launching and managing linked jobs.
    /// </summary>
    public class GoogleCloudDatapipelinesV1Pipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Immutable. The timestamp when the pipeline was initially created. Set by the Data Pipelines
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Required. The display name of the pipeline. It can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens
        /// (-), and underscores (_).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Number of jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobCount")]
        public virtual System.Nullable<int> JobCount { get; set; }

        /// <summary>
        /// Output only. Immutable. The timestamp when the pipeline was last modified. Set by the Data Pipelines
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; }

        /// <summary>
        /// The pipeline name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID`. *
        /// `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), and periods (.). For
        /// more information, see [Identifying
        /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects). *
        /// `LOCATION_ID` is the canonical ID for the pipeline's location. The list of available locations can be
        /// obtained by calling `google.cloud.location.Locations.ListLocations`. Note that the Data Pipelines service is
        /// not available in all regions. It depends on Cloud Scheduler, an App Engine application, so it's only
        /// available in [App Engine regions](https://cloud.google.com/about/locations#region). * `PIPELINE_ID` is the
        /// ID of the pipeline. Must be unique for the selected project and location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Immutable. The sources of the pipeline (for example, Dataplex). The keys and values are set by the
        /// corresponding sources during pipeline creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineSources")]
        public virtual System.Collections.Generic.IDictionary<string, string> PipelineSources { get; set; }

        /// <summary>
        /// Internal scheduling information for a pipeline. If this information is provided, periodic jobs will be
        /// created per the schedule. If not, users are responsible for creating jobs externally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleInfo")]
        public virtual GoogleCloudDatapipelinesV1ScheduleSpec ScheduleInfo { get; set; }

        /// <summary>
        /// Optional. A service account email to be used with the Cloud Scheduler job. If not specified, the default
        /// compute engine service account will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedulerServiceAccountEmail")]
        public virtual string SchedulerServiceAccountEmail { get; set; }

        /// <summary>
        /// Required. The state of the pipeline. When the pipeline is created, the state is set to
        /// 'PIPELINE_STATE_ACTIVE' by default. State changes can be requested by setting the state to stopping, paused,
        /// or resuming. State cannot be changed through UpdatePipeline requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Required. The type of the pipeline. This field affects the scheduling of the pipeline and the type of
        /// metrics to show for the pipeline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Workload information for creating new jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workload")]
        public virtual GoogleCloudDatapipelinesV1Workload Workload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for RunPipeline</summary>
    public class GoogleCloudDatapipelinesV1RunPipelineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for RunPipeline</summary>
    public class GoogleCloudDatapipelinesV1RunPipelineResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Job that was created as part of RunPipeline operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual GoogleCloudDatapipelinesV1Job Job { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The environment values to set at runtime.</summary>
    public class GoogleCloudDatapipelinesV1RuntimeEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional experiment flags for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalExperiments")]
        public virtual System.Collections.Generic.IList<string> AdditionalExperiments { get; set; }

        /// <summary>
        /// Additional user labels to be specified for the job. Keys and values should follow the restrictions specified
        /// in the [labeling restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions) page.
        /// An object containing a list of key/value pairs. Example: { "name": "wrench", "mass": "1kg", "count": "3" }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalUserLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalUserLabels { get; set; }

        /// <summary>Whether to bypass the safety checks for the job's temporary directory. Use with caution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bypassTempDirValidation")]
        public virtual System.Nullable<bool> BypassTempDirValidation { get; set; }

        /// <summary>Whether to enable Streaming Engine for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableStreamingEngine")]
        public virtual System.Nullable<bool> EnableStreamingEngine { get; set; }

        /// <summary>Configuration for VM IPs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipConfiguration")]
        public virtual string IpConfiguration { get; set; }

        /// <summary>
        /// Name for the Cloud KMS key for the job. The key format is: projects//locations//keyRings//cryptoKeys/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// The machine type to use for the job. Defaults to the value from the template if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// The maximum number of Compute Engine instances to be made available to your pipeline during execution, from
        /// 1 to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWorkers")]
        public virtual System.Nullable<int> MaxWorkers { get; set; }

        /// <summary>
        /// Network to which VMs will be assigned. If empty or unspecified, the service will use the network "default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The initial number of Compute Engine instances for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numWorkers")]
        public virtual System.Nullable<int> NumWorkers { get; set; }

        /// <summary>The email address of the service account to run the job as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// Subnetwork to which VMs will be assigned, if desired. You can specify a subnetwork using either a complete
        /// URL or an abbreviated path. Expected to be of the form
        /// "https://www.googleapis.com/compute/v1/projects/HOST_PROJECT_ID/regions/REGION/subnetworks/SUBNETWORK" or
        /// "regions/REGION/subnetworks/SUBNETWORK". If the subnetwork is located in a Shared VPC network, you must use
        /// the complete URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// The Cloud Storage path to use for temporary files. Must be a valid Cloud Storage URL, beginning with
        /// `gs://`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tempLocation")]
        public virtual string TempLocation { get; set; }

        /// <summary>
        /// The Compute Engine region (https://cloud.google.com/compute/docs/regions-zones/regions-zones) in which
        /// worker processing should occur, e.g. "us-west1". Mutually exclusive with worker_zone. If neither
        /// worker_region nor worker_zone is specified, default to the control plane's region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerRegion")]
        public virtual string WorkerRegion { get; set; }

        /// <summary>
        /// The Compute Engine zone (https://cloud.google.com/compute/docs/regions-zones/regions-zones) in which worker
        /// processing should occur, e.g. "us-west1-a". Mutually exclusive with worker_region. If neither worker_region
        /// nor worker_zone is specified, a zone in the control plane's region is chosen based on available capacity. If
        /// both `worker_zone` and `zone` are set, `worker_zone` takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerZone")]
        public virtual string WorkerZone { get; set; }

        /// <summary>
        /// The Compute Engine [availability zone](https://cloud.google.com/compute/docs/regions-zones/regions-zones)
        /// for launching worker instances to run your pipeline. In the future, worker_zone will take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the schedule the pipeline runs on.</summary>
    public class GoogleCloudDatapipelinesV1ScheduleSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. When the next Scheduler job is going to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextJobTime")]
        public virtual object NextJobTime { get; set; }

        /// <summary>
        /// Unix-cron format of the schedule. This information is retrieved from the linked Cloud Scheduler.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual string Schedule { get; set; }

        /// <summary>
        /// Timezone ID. This matches the timezone IDs used by the Cloud Scheduler API. If empty, UTC time is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The version of the SDK used to run the job.</summary>
    public class GoogleCloudDatapipelinesV1SdkVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The support status for this SDK version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkSupportStatus")]
        public virtual string SdkSupportStatus { get; set; }

        /// <summary>The version of the SDK used to run the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>A readable string describing the version of the SDK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionDisplayName")]
        public virtual string VersionDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for StopPipeline.</summary>
    public class GoogleCloudDatapipelinesV1StopPipelineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Workload details for creating the pipeline jobs.</summary>
    public class GoogleCloudDatapipelinesV1Workload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Template information and additional parameters needed to launch a Dataflow job using the flex launch API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataflowFlexTemplateRequest")]
        public virtual GoogleCloudDatapipelinesV1LaunchFlexTemplateRequest DataflowFlexTemplateRequest { get; set; }

        /// <summary>
        /// Template information and additional parameters needed to launch a Dataflow job using the standard launch
        /// API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataflowLaunchTemplateRequest")]
        public virtual GoogleCloudDatapipelinesV1LaunchTemplateRequest DataflowLaunchTemplateRequest { get; set; }

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

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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
}
