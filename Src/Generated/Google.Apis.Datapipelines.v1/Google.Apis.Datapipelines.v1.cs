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
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://datapipelines.googleapis.com/";
        #else
            "https://datapipelines.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://datapipelines.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

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
                TransformDescriptions = new TransformDescriptionsResource(service);
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

            /// <summary>Gets the TransformDescriptions resource.</summary>
            public virtual TransformDescriptionsResource TransformDescriptions { get; }

            /// <summary>The "transformDescriptions" collection of methods.</summary>
            public class TransformDescriptionsResource
            {
                private const string Resource = "transformDescriptions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TransformDescriptionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets transform descriptions in a batch, associated with a list of provided uniform resource names.
                /// </summary>
                /// <param name="parent">
                /// Required. The project and location shared by all transform descriptions being retrieved, formatted
                /// as "projects/{project}/locations/{location}".
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(service, parent);
                }

                /// <summary>
                /// Gets transform descriptions in a batch, associated with a list of provided uniform resource names.
                /// </summary>
                public class BatchGetRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1BatchGetTransformDescriptionsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location shared by all transform descriptions being retrieved,
                    /// formatted as "projects/{project}/locations/{location}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The names of the transform descriptions being retrieved, formatted as
                    /// "projects/{project}/locations/{location}/transformdescriptions/{transform_description}". If no
                    /// name is provided, all of the transform descriptions will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/transformDescriptions:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
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
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the transform description associated with the provided uniform resource name.
                /// </summary>
                /// <param name="name">
                /// Required. The full name formatted as
                /// "projects/{your-project}/locations/{google-cloud-region}/transformdescriptions/{uniform-resource-name}".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the transform description associated with the provided uniform resource name.
                /// </summary>
                public class GetRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1TransformDescription>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name formatted as
                    /// "projects/{your-project}/locations/{google-cloud-region}/transformdescriptions/{uniform-resource-name}".
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/transformDescriptions/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Computes the schema for the transform. Computation from `raw_schema` will always occur if it is set.
            /// This requires that the transform supports that encoding. If no raw schema is provided and if the
            /// transform is for an IO, then this will attempt to connect to the resource using the details provided in
            /// `config` and infer the schema from that. If the transform is not an IO, is a sink that doesn't exist
            /// yet, or is a sink with no schema requirement, then this will fall back to basing the schema off the one
            /// provided in `input_schemas`. The computed schema will be validated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="location">
            /// Required. The full location formatted as "projects/{your-project}/locations/{google-cloud-region}". If
            /// attempting to infer the schema from an existing Google Cloud resource, the default Data Pipelines
            /// service account for this project will be used in making requests for the resource. If the region given
            /// for "{google-cloud-region}" is different than the region where the resource is stored, then the data
            /// will be transferred to and processed in the region specified here, but it will not be persistently
            /// stored in this region.
            /// </param>
            public virtual ComputeSchemaRequest ComputeSchema(Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1ComputeSchemaRequest body, string location)
            {
                return new ComputeSchemaRequest(service, body, location);
            }

            /// <summary>
            /// Computes the schema for the transform. Computation from `raw_schema` will always occur if it is set.
            /// This requires that the transform supports that encoding. If no raw schema is provided and if the
            /// transform is for an IO, then this will attempt to connect to the resource using the details provided in
            /// `config` and infer the schema from that. If the transform is not an IO, is a sink that doesn't exist
            /// yet, or is a sink with no schema requirement, then this will fall back to basing the schema off the one
            /// provided in `input_schemas`. The computed schema will be validated.
            /// </summary>
            public class ComputeSchemaRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1Schema>
            {
                /// <summary>Constructs a new ComputeSchema request.</summary>
                public ComputeSchemaRequest(Google.Apis.Services.IClientService service, Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1ComputeSchemaRequest body, string location) : base(service)
                {
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The full location formatted as "projects/{your-project}/locations/{google-cloud-region}".
                /// If attempting to infer the schema from an existing Google Cloud resource, the default Data Pipelines
                /// service account for this project will be used in making requests for the resource. If the region
                /// given for "{google-cloud-region}" is different than the region where the resource is stored, then
                /// the data will be transferred to and processed in the region specified here, but it will not be
                /// persistently stored in this region.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1ComputeSchemaRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "computeSchema";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+location}:computeSchema";

                /// <summary>Initializes ComputeSchema parameter list.</summary>
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

            /// <summary>
            /// Lists pipelines. Returns a "FORBIDDEN" error if the caller doesn't have permission to access it.
            /// </summary>
            /// <param name="parent">
            /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`.
            /// </param>
            public virtual ListPipelinesRequest ListPipelines(string parent)
            {
                return new ListPipelinesRequest(service, parent);
            }

            /// <summary>
            /// Lists pipelines. Returns a "FORBIDDEN" error if the caller doesn't have permission to access it.
            /// </summary>
            public class ListPipelinesRequest : DatapipelinesBaseServiceRequest<Google.Apis.Datapipelines.v1.Data.GoogleCloudDatapipelinesV1ListPipelinesResponse>
            {
                /// <summary>Constructs a new ListPipelines request.</summary>
                public ListPipelinesRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
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
                /// returned. Multiple filters can be applied and must be comma separated. Fields eligible for filtering
                /// are: + `type`: The type of the pipeline (streaming or batch). Allowed values are `ALL`, `BATCH`, and
                /// `STREAMING`. + `status`: The activity status of the pipeline. Allowed values are `ALL`, `ACTIVE`,
                /// `ARCHIVED`, and `PAUSED`. For example, to limit results to active batch processing pipelines:
                /// type:BATCH,status:ACTIVE
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
                /// A page token, received from a previous `ListPipelines` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListPipelines` must match the call that
                /// provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "listPipelines";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}";

                /// <summary>Initializes ListPipelines parameter list.</summary>
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
    }
}
namespace Google.Apis.Datapipelines.v1.Data
{
    /// <summary>Represents an array of values. The elements can be of any type.</summary>
    public class GoogleCloudDatapipelinesV1ArrayValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The elements of the array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elements")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1FieldValue> Elements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a non-dividable value.</summary>
    public class GoogleCloudDatapipelinesV1AtomicValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>An 8-bit signed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byteValue")]
        public virtual System.Nullable<int> ByteValue { get; set; }

        /// <summary>An array of raw bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesValue")]
        public virtual string BytesValue { get; set; }

        /// <summary>A datetime value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datetimeValue")]
        public virtual GoogleTypeDateTime DatetimeValue { get; set; }

        /// <summary>A large decimal value, equivalent to Java BigDecimal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decimalValue")]
        public virtual GoogleTypeDecimal DecimalValue { get; set; }

        /// <summary>A 64-bit floating point value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>A 32-bit floating point value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>A 16-bit signed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int16Value")]
        public virtual System.Nullable<int> Int16Value { get; set; }

        /// <summary>A 32-bit signed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int32Value")]
        public virtual System.Nullable<int> Int32Value { get; set; }

        /// <summary>A 64-bit signed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>A string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchGetTransformDescriptions</summary>
    public class GoogleCloudDatapipelinesV1BatchGetTransformDescriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of requested transform descriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformDescriptions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1TransformDescription> TransformDescriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ComputeSchema</summary>
    public class GoogleCloudDatapipelinesV1ComputeSchemaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The configuration for the transform. If this is not a source, then each input with its schema must
        /// be set. It is not required to have any outputs set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudDatapipelinesV1ConfiguredTransform Config { get; set; }

        /// <summary>
        /// Optional. In relation to the full pipeline graph, the schemas of the transforms that are used as inputs to
        /// the one for `config`. If `config` represents a transform for reading from some resource, then this should be
        /// empty. For all other transforms, at least one value must be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputSchemas")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1Schema> InputSchemas { get; set; }

        /// <summary>
        /// Optional. If set, this will use the provided raw schema to compute the schema rather than connecting to any
        /// resources. Validation will still occur to make sure it is compatible with all input schemas. If the
        /// transform is an IO, the IO must support that schema type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawSchema")]
        public virtual GoogleCloudDatapipelinesV1RawSchemaInfo RawSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A fully configured transform that can be validated.</summary>
    public class GoogleCloudDatapipelinesV1ConfiguredTransform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration values provided. These must match the schema provided in the row's schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudDatapipelinesV1Row Config { get; set; }

        /// <summary>
        /// Unique resource name of the transform. This should be the same as the equivalent `TransformDescription`
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniformResourceName")]
        public virtual string UniformResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>Represents a selected value from an EnumerationType.</summary>
    public class GoogleCloudDatapipelinesV1EnumerationValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the enum option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Info for a single field in the schema.</summary>
    public class GoogleCloudDatapipelinesV1Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Type info for the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual GoogleCloudDatapipelinesV1FieldType Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Type info about a field.</summary>
    public class GoogleCloudDatapipelinesV1FieldType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If `type` is an array or iterable, this is the type contained in that array or iterable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionElementType")]
        public virtual GoogleCloudDatapipelinesV1FieldType CollectionElementType { get; set; }

        /// <summary>If `type` is a logical type, this is the info for the specific logical type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalType")]
        public virtual GoogleCloudDatapipelinesV1LogicalType LogicalType { get; set; }

        /// <summary>If `type` is a map, this is the key and value types for that map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapType")]
        public virtual GoogleCloudDatapipelinesV1MapType MapType { get; set; }

        /// <summary>Whether or not this field is nullable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>If `type` is a row, this is the schema of that row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowSchema")]
        public virtual GoogleCloudDatapipelinesV1Schema RowSchema { get; set; }

        /// <summary>
        /// Specific type of the field. For non-atomic types, the corresponding type info for that non-atomic must be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single value in a row. The value set must correspond to the correct type from the row's schema.
    /// </summary>
    public class GoogleCloudDatapipelinesV1FieldValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The array value of this field. Corresponds to TYPE_NAME_ARRAY in the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arrayValue")]
        public virtual GoogleCloudDatapipelinesV1ArrayValue ArrayValue { get; set; }

        /// <summary>The atomic value of this field. Must correspond to the correct atomic type in the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("atomicValue")]
        public virtual GoogleCloudDatapipelinesV1AtomicValue AtomicValue { get; set; }

        /// <summary>
        /// The enum value of this field. Corresponds to TYPE_NAME_LOGICAL_TYPE in the schema if that logical type
        /// represents an `EnumerationType` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValue")]
        public virtual GoogleCloudDatapipelinesV1EnumerationValue EnumValue { get; set; }

        /// <summary>
        /// The fixed-length byte collection of this field. Corresponds to TYPE_NAME_LOGICAL_TYPE in the schema if that
        /// logical type represents a `FixedBytes` type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedBytesValue")]
        public virtual GoogleCloudDatapipelinesV1FixedBytesValue FixedBytesValue { get; set; }

        /// <summary>The iterable value of this field. Corresponds to TYPE_NAME_ITERABLE in the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iterableValue")]
        public virtual GoogleCloudDatapipelinesV1IterableValue IterableValue { get; set; }

        /// <summary>The map value of this field. Corresponds to TYPE_NAME_MAP in the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapValue")]
        public virtual GoogleCloudDatapipelinesV1MapValue MapValue { get; set; }

        /// <summary>
        /// The row value of this field. Corresponds to TYPE_NAME_ROW in the schema. This row also holds to its own
        /// schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowValue")]
        public virtual GoogleCloudDatapipelinesV1Row RowValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a collection of bytes whose size is the same as the associated FixedBytes size value.
    /// </summary>
    public class GoogleCloudDatapipelinesV1FixedBytesValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The raw bytes. It must be exactly the size specified in the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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

    /// <summary>Represents an iterable of values. The elements can be of any type.</summary>
    public class GoogleCloudDatapipelinesV1IterableValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The elements of the iterable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elements")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1FieldValue> Elements { get; set; }

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

    /// <summary>Represents the input for creating a specified logical type.</summary>
    public class GoogleCloudDatapipelinesV1LogicalType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The enum represented by this logical type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumerationType")]
        public virtual GoogleCloudDatapipelinesV1LogicalTypeEnumerationType EnumerationType { get; set; }

        /// <summary>The fixed-size byte collection represented by this logical type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedBytes")]
        public virtual GoogleCloudDatapipelinesV1LogicalTypeFixedBytes FixedBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the Beam EnumerationType logical type.</summary>
    public class GoogleCloudDatapipelinesV1LogicalTypeEnumerationType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Names of the values. The numeric value is the same as the index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the Beam FixedBytes logical type.</summary>
    public class GoogleCloudDatapipelinesV1LogicalTypeFixedBytes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of bytes to allocate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<int> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a map in a schema.</summary>
    public class GoogleCloudDatapipelinesV1MapType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key type of the map. Only atomic types are supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapKeyType")]
        public virtual GoogleCloudDatapipelinesV1FieldType MapKeyType { get; set; }

        /// <summary>Value type of the map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapValueType")]
        public virtual GoogleCloudDatapipelinesV1FieldType MapValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a key/value pairing.</summary>
    public class GoogleCloudDatapipelinesV1MapValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The entries in the map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1MapValueEntry> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single entry in the map. Each entry must have a unique key.</summary>
    public class GoogleCloudDatapipelinesV1MapValueEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key value. Only atomic values are supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual GoogleCloudDatapipelinesV1FieldValue Key { get; set; }

        /// <summary>The value associated with the key. It may be of any type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GoogleCloudDatapipelinesV1FieldValue Value { get; set; }

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

    /// <summary>The raw schema and its type.</summary>
    public class GoogleCloudDatapipelinesV1RawSchemaInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawSchema")]
        public virtual string RawSchema { get; set; }

        /// <summary>The type of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an Apache Beam row, though the `Any` nature of values is replaced with more concrete representations
    /// of valid values.
    /// </summary>
    public class GoogleCloudDatapipelinesV1Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The schema of the row's data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual GoogleCloudDatapipelinesV1SchemaSource Schema { get; set; }

        /// <summary>
        /// Required. The values of this Row. A fully built row is required to hold to the schema specified by `schema`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1FieldValue> Values { get; set; }

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

    /// <summary>Represents a simplified Apache Beam schema.</summary>
    public class GoogleCloudDatapipelinesV1Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fields in the schema. Every field within a schema must have a unique name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GoogleCloudDatapipelinesV1Field> Fields { get; set; }

        /// <summary>
        /// An identifier of the schema for looking it up in a repository. This only needs to be set if the schema is
        /// stored in a repository.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceId")]
        public virtual string ReferenceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds a schema or a reference to a schema in some repository.</summary>
    public class GoogleCloudDatapipelinesV1SchemaSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Schema located locally with the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localSchema")]
        public virtual GoogleCloudDatapipelinesV1Schema LocalSchema { get; set; }

        /// <summary>The `reference_id` value of a schema in a repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceId")]
        public virtual string ReferenceId { get; set; }

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

    /// <summary>Description of a schema-aware transform, which provides info on how it can be configured.</summary>
    public class GoogleCloudDatapipelinesV1TransformDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The full name of this resource formatted as:
        /// projects/{project}/locations/{location}/transformDescriptions/{transform_description}
        /// `transform_description` is the same as the `uniform_resource_name` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Available options for configuring the transform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GoogleCloudDatapipelinesV1Schema Options { get; set; }

        /// <summary>Unique resource name of the transform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniformResourceName")]
        public virtual string UniformResourceName { get; set; }

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

    /// <summary>
    /// Represents civil time (or occasionally physical time). This type can represent a civil time in one of a few
    /// possible ways: * When utc_offset is set and time_zone is unset: a civil time on a calendar day with a particular
    /// offset from UTC. * When time_zone is set and utc_offset is unset: a civil time on a calendar day in a particular
    /// time zone. * When neither time_zone nor utc_offset is set: a civil time on a calendar day in local time. The
    /// date is relative to the Proleptic Gregorian Calendar. If year, month, or day are 0, the DateTime is considered
    /// not to have a specific year, month, or day respectively. This type may also be used to represent a physical time
    /// if all the date and time fields are set and either case of the `time_offset` oneof is set. Consider using
    /// `Timestamp` message for physical time instead. If your use case also would like to store the user's timezone,
    /// that can be done in another field. This type is more flexible than some applications may want. Make sure to
    /// document and validate your application's limitations.
    /// </summary>
    public class GoogleTypeDateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a datetime
        /// without a day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>
        /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An API may
        /// choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>
        /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API may allow the
        /// value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>Time zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual GoogleTypeTimeZone TimeZone { get; set; }

        /// <summary>
        /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of -4:00 would
        /// be represented as { seconds: -14400 }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>
        /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A representation of a decimal value, such as 2.5. Clients may convert values into language-native decimal
    /// formats, such as Java's BigDecimal or Python's decimal.Decimal. [BigDecimal]:
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html [decimal.Decimal]:
    /// https://docs.python.org/3/library/decimal.html
    /// </summary>
    public class GoogleTypeDecimal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The decimal value, as a string. The string representation consists of an optional sign, `+` (`U+002B`) or
        /// `-` (`U+002D`), followed by a sequence of zero or more decimal digits ("the integer"), optionally followed
        /// by a fraction, optionally followed by an exponent. An empty string **should** be interpreted as `0`. The
        /// fraction consists of a decimal point followed by zero or more decimal digits. The string must contain at
        /// least one digit in either the integer or the fraction. The number formed by the sign, the integer and the
        /// fraction is referred to as the significand. The exponent consists of the character `e` (`U+0065`) or `E`
        /// (`U+0045`) followed by one or more decimal digits. Services **should** normalize decimal values before
        /// storing them by: - Removing an explicitly-provided `+` sign (`+2.5` -&amp;gt; `2.5`). - Replacing a
        /// zero-length integer value with `0` (`.5` -&amp;gt; `0.5`). - Coercing the exponent character to upper-case,
        /// with explicit sign (`2.5e8` -&amp;gt; `2.5E+8`). - Removing an explicitly-provided zero exponent (`2.5E0`
        /// -&amp;gt; `2.5`). Services **may** perform additional normalization based on its own needs and the internal
        /// decimal implementation selected, such as shifting the decimal point and exponent value together (example:
        /// `2.5E-1` &amp;lt;-&amp;gt; `0.25`). Additionally, services **may** preserve trailing zeroes in the fraction
        /// to indicate increased precision, but are not required to do so. Note that only the `.` character is
        /// supported to divide the integer and the fraction; `,` **should not** be supported regardless of locale.
        /// Additionally, thousand separators **should not** be supported. If a service does support them, values
        /// **must** be normalized. The ENBF grammar is: DecimalString = '' | [Sign] Significand [Exponent]; Sign = '+'
        /// | '-'; Significand = Digits '.' | [Digits] '.' Digits; Exponent = ('e' | 'E') [Sign] Digits; Digits = { '0'
        /// | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' }; Services **should** clearly document the range of
        /// supported values, the maximum supported precision (total number of digits), and, if applicable, the scale
        /// (number of digits after the decimal point), as well as how it behaves when receiving out-of-bounds values.
        /// Services **may** choose to accept values passed as input even when the value has a higher precision or scale
        /// than the service supports, and **should** round the value to fit the supported scale. Alternatively, the
        /// service **may** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if precision would be lost.
        /// Services **should** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if the service receives a
        /// value outside of the supported range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class GoogleTypeTimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number, e.g. "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
