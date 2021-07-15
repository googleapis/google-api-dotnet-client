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

namespace Google.Apis.Dataflow.v1b3
{
    /// <summary>The Dataflow Service.</summary>
    public class DataflowService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1b3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DataflowService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DataflowService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dataflow";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://dataflow.googleapis.com/";
        #else
            "https://dataflow.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dataflow.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Dataflow API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Compute Engine resources</summary>
            public static string Compute = "https://www.googleapis.com/auth/compute";

            /// <summary>View your Google Compute Engine resources</summary>
            public static string ComputeReadonly = "https://www.googleapis.com/auth/compute.readonly";

            /// <summary>See your primary Google Account email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Dataflow API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your Google Compute Engine resources</summary>
            public const string Compute = "https://www.googleapis.com/auth/compute";

            /// <summary>View your Google Compute Engine resources</summary>
            public const string ComputeReadonly = "https://www.googleapis.com/auth/compute.readonly";

            /// <summary>See your primary Google Account email address</summary>
            public const string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Dataflow requests.</summary>
    public abstract class DataflowBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DataflowBaseServiceRequest instance.</summary>
        protected DataflowBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Dataflow parameter list.</summary>
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
            Jobs = new JobsResource(service);
            Locations = new LocationsResource(service);
            Snapshots = new SnapshotsResource(service);
            Templates = new TemplatesResource(service);
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
                Debug = new DebugResource(service);
                Messages = new MessagesResource(service);
                WorkItems = new WorkItemsResource(service);
            }

            /// <summary>Gets the Debug resource.</summary>
            public virtual DebugResource Debug { get; }

            /// <summary>The "debug" collection of methods.</summary>
            public class DebugResource
            {
                private const string Resource = "debug";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DebugResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get encoded debug configuration for component. Not cacheable.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">The project id.</param>
                /// <param name="jobId">The job id.</param>
                public virtual GetConfigRequest GetConfig(Google.Apis.Dataflow.v1b3.Data.GetDebugConfigRequest body, string projectId, string jobId)
                {
                    return new GetConfigRequest(service, body, projectId, jobId);
                }

                /// <summary>Get encoded debug configuration for component. Not cacheable.</summary>
                public class GetConfigRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.GetDebugConfigResponse>
                {
                    /// <summary>Constructs a new GetConfig request.</summary>
                    public GetConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.GetDebugConfigRequest body, string projectId, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        JobId = jobId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The project id.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>The job id.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.GetDebugConfigRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}/debug/getConfig";

                    /// <summary>Initializes GetConfig parameter list.</summary>
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
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Send encoded debug capture data for component.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">The project id.</param>
                /// <param name="jobId">The job id.</param>
                public virtual SendCaptureRequest SendCapture(Google.Apis.Dataflow.v1b3.Data.SendDebugCaptureRequest body, string projectId, string jobId)
                {
                    return new SendCaptureRequest(service, body, projectId, jobId);
                }

                /// <summary>Send encoded debug capture data for component.</summary>
                public class SendCaptureRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.SendDebugCaptureResponse>
                {
                    /// <summary>Constructs a new SendCapture request.</summary>
                    public SendCaptureRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.SendDebugCaptureRequest body, string projectId, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        JobId = jobId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The project id.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>The job id.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.SendDebugCaptureRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "sendCapture";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}/debug/sendCapture";

                    /// <summary>Initializes SendCapture parameter list.</summary>
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
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Messages resource.</summary>
            public virtual MessagesResource Messages { get; }

            /// <summary>The "messages" collection of methods.</summary>
            public class MessagesResource
            {
                private const string Resource = "messages";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MessagesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Request the job status. To request the status of a job, we recommend using
                /// `projects.locations.jobs.messages.list` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
                /// `projects.jobs.messages.list` is not recommended, as you can only request the status of jobs that
                /// are running in `us-central1`.
                /// </summary>
                /// <param name="projectId">A project id.</param>
                /// <param name="jobId">The job to get messages about.</param>
                public virtual ListRequest List(string projectId, string jobId)
                {
                    return new ListRequest(service, projectId, jobId);
                }

                /// <summary>
                /// Request the job status. To request the status of a job, we recommend using
                /// `projects.locations.jobs.messages.list` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
                /// `projects.jobs.messages.list` is not recommended, as you can only request the status of jobs that
                /// are running in `us-central1`.
                /// </summary>
                public class ListRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ListJobMessagesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectId, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        JobId = jobId;
                        InitParameters();
                    }

                    /// <summary>A project id.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>The job to get messages about.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>
                    /// Return only messages with timestamps &amp;lt; end_time. The default is now (i.e. return up to
                    /// the latest messages available).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object EndTime { get; set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the job specified by job_id.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Location { get; set; }

                    /// <summary>Filter to only get messages with importance &gt;= level</summary>
                    [Google.Apis.Util.RequestParameterAttribute("minimumImportance", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<MinimumImportanceEnum> MinimumImportance { get; set; }

                    /// <summary>Filter to only get messages with importance &gt;= level</summary>
                    public enum MinimumImportanceEnum
                    {
                        /// <summary>The message importance isn't specified, or is unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_IMPORTANCE_UNKNOWN")]
                        JOBMESSAGEIMPORTANCEUNKNOWN = 0,

                        /// <summary>
                        /// The message is at the 'debug' level: typically only useful for software engineers working on
                        /// the code the job is running. Typically, Dataflow pipeline runners do not display log
                        /// messages at this level by default.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_DEBUG")]
                        JOBMESSAGEDEBUG = 1,

                        /// <summary>
                        /// The message is at the 'detailed' level: somewhat verbose, but potentially useful to users.
                        /// Typically, Dataflow pipeline runners do not display log messages at this level by default.
                        /// These messages are displayed by default in the Dataflow monitoring UI.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_DETAILED")]
                        JOBMESSAGEDETAILED = 2,

                        /// <summary>
                        /// The message is at the 'basic' level: useful for keeping track of the execution of a Dataflow
                        /// pipeline. Typically, Dataflow pipeline runners display log messages at this level by
                        /// default, and these messages are displayed by default in the Dataflow monitoring UI.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_BASIC")]
                        JOBMESSAGEBASIC = 3,

                        /// <summary>
                        /// The message is at the 'warning' level: indicating a condition pertaining to a job which may
                        /// require human intervention. Typically, Dataflow pipeline runners display log messages at
                        /// this level by default, and these messages are displayed by default in the Dataflow
                        /// monitoring UI.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_WARNING")]
                        JOBMESSAGEWARNING = 4,

                        /// <summary>
                        /// The message is at the 'error' level: indicating a condition preventing a job from
                        /// succeeding. Typically, Dataflow pipeline runners display log messages at this level by
                        /// default, and these messages are displayed by default in the Dataflow monitoring UI.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_ERROR")]
                        JOBMESSAGEERROR = 5,
                    }

                    /// <summary>
                    /// If specified, determines the maximum number of messages to return. If unspecified, the service
                    /// may choose an appropriate default, or may return an arbitrarily large number of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// If supplied, this should be the value of next_page_token returned by an earlier call. This will
                    /// cause the next page of results to be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// If specified, return only messages with timestamps &amp;gt;= start_time. The default is the job
                    /// creation time (i.e. beginning of messages).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}/messages";

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
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("minimumImportance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "minimumImportance",
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
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the WorkItems resource.</summary>
            public virtual WorkItemsResource WorkItems { get; }

            /// <summary>The "workItems" collection of methods.</summary>
            public class WorkItemsResource
            {
                private const string Resource = "workItems";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkItemsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Leases a dataflow WorkItem to run.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">Identifies the project this worker belongs to.</param>
                /// <param name="jobId">Identifies the workflow job this worker belongs to.</param>
                public virtual LeaseRequest Lease(Google.Apis.Dataflow.v1b3.Data.LeaseWorkItemRequest body, string projectId, string jobId)
                {
                    return new LeaseRequest(service, body, projectId, jobId);
                }

                /// <summary>Leases a dataflow WorkItem to run.</summary>
                public class LeaseRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.LeaseWorkItemResponse>
                {
                    /// <summary>Constructs a new Lease request.</summary>
                    public LeaseRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.LeaseWorkItemRequest body, string projectId, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        JobId = jobId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Identifies the project this worker belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>Identifies the workflow job this worker belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.LeaseWorkItemRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "lease";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}/workItems:lease";

                    /// <summary>Initializes Lease parameter list.</summary>
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
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Reports the status of dataflow WorkItems leased by a worker.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">The project which owns the WorkItem's job.</param>
                /// <param name="jobId">The job which the WorkItem is part of.</param>
                public virtual ReportStatusRequest ReportStatus(Google.Apis.Dataflow.v1b3.Data.ReportWorkItemStatusRequest body, string projectId, string jobId)
                {
                    return new ReportStatusRequest(service, body, projectId, jobId);
                }

                /// <summary>Reports the status of dataflow WorkItems leased by a worker.</summary>
                public class ReportStatusRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ReportWorkItemStatusResponse>
                {
                    /// <summary>Constructs a new ReportStatus request.</summary>
                    public ReportStatusRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.ReportWorkItemStatusRequest body, string projectId, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        JobId = jobId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The project which owns the WorkItem's job.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>The job which the WorkItem is part of.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.ReportWorkItemStatusRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reportStatus";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}/workItems:reportStatus";

                    /// <summary>Initializes ReportStatus parameter list.</summary>
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
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>List the jobs of a project across all regions.</summary>
            /// <param name="projectId">The project which owns the jobs.</param>
            public virtual AggregatedRequest Aggregated(string projectId)
            {
                return new AggregatedRequest(service, projectId);
            }

            /// <summary>List the jobs of a project across all regions.</summary>
            public class AggregatedRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ListJobsResponse>
            {
                /// <summary>Constructs a new Aggregated request.</summary>
                public AggregatedRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>The project which owns the jobs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The kind of filter to use.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<FilterEnum> Filter { get; set; }

                /// <summary>The kind of filter to use.</summary>
                public enum FilterEnum
                {
                    /// <summary>
                    /// The filter isn't specified, or is unknown. This returns all jobs ordered on descending
                    /// `JobUuid`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("UNKNOWN")]
                    UNKNOWN = 0,

                    /// <summary>
                    /// Returns all running jobs first ordered on creation timestamp, then returns all terminated jobs
                    /// ordered on the termination timestamp.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALL")]
                    ALL = 1,

                    /// <summary>
                    /// Filters the jobs that have a terminated state, ordered on the termination timestamp. Example
                    /// terminated states: `JOB_STATE_STOPPED`, `JOB_STATE_UPDATED`, `JOB_STATE_DRAINED`, etc.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TERMINATED")]
                    TERMINATED = 2,

                    /// <summary>Filters the jobs that are running ordered on the creation timestamp.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACTIVE")]
                    ACTIVE = 3,
                }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>
                /// If there are many jobs, limit response to at most this many. The actual number of jobs returned will
                /// be the lesser of max_responses and an unspecified server-defined limit.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Set this to the 'next_page_token' field of a previous response to request additional results in a
                /// long list.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Deprecated. ListJobs always returns summaries now. Use GetJob for other JobViews.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Deprecated. ListJobs always returns summaries now. Use GetJob for other JobViews.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The job view to return isn't specified, or is unknown. Responses will contain at least the
                    /// `JOB_VIEW_SUMMARY` information, and may contain additional information.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_UNKNOWN")]
                    JOBVIEWUNKNOWN = 0,

                    /// <summary>
                    /// Request summary information only: Project ID, Job ID, job name, job type, job status, start/end
                    /// time, and Cloud SDK version details.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_SUMMARY")]
                    JOBVIEWSUMMARY = 1,

                    /// <summary>Request all information available for this job.</summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_ALL")]
                    JOBVIEWALL = 2,

                    /// <summary>
                    /// Request summary info and limited job description data for steps, labels and environment.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_DESCRIPTION")]
                    JOBVIEWDESCRIPTION = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "aggregated";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/jobs:aggregated";

                /// <summary>Initializes Aggregated parameter list.</summary>
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
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
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

            /// <summary>
            /// Creates a Cloud Dataflow job. To create a job, we recommend using `projects.locations.jobs.create` with
            /// a [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
            /// `projects.jobs.create` is not recommended, as your job will always start in `us-central1`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">The ID of the Cloud Platform project that the job belongs to.</param>
            public virtual CreateRequest Create(Google.Apis.Dataflow.v1b3.Data.Job body, string projectId)
            {
                return new CreateRequest(service, body, projectId);
            }

            /// <summary>
            /// Creates a Cloud Dataflow job. To create a job, we recommend using `projects.locations.jobs.create` with
            /// a [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
            /// `projects.jobs.create` is not recommended, as your job will always start in `us-central1`.
            /// </summary>
            public class CreateRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Job>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.Job body, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the Cloud Platform project that the job belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>Deprecated. This field is now in the Job message.</summary>
                [Google.Apis.Util.RequestParameterAttribute("replaceJobId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ReplaceJobId { get; set; }

                /// <summary>The level of information requested in response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The level of information requested in response.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The job view to return isn't specified, or is unknown. Responses will contain at least the
                    /// `JOB_VIEW_SUMMARY` information, and may contain additional information.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_UNKNOWN")]
                    JOBVIEWUNKNOWN = 0,

                    /// <summary>
                    /// Request summary information only: Project ID, Job ID, job name, job type, job status, start/end
                    /// time, and Cloud SDK version details.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_SUMMARY")]
                    JOBVIEWSUMMARY = 1,

                    /// <summary>Request all information available for this job.</summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_ALL")]
                    JOBVIEWALL = 2,

                    /// <summary>
                    /// Request summary info and limited job description data for steps, labels and environment.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_DESCRIPTION")]
                    JOBVIEWDESCRIPTION = 3,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Dataflow.v1b3.Data.Job Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/jobs";

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
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("replaceJobId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "replaceJobId",
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
            /// Gets the state of the specified Cloud Dataflow job. To get the state of a job, we recommend using
            /// `projects.locations.jobs.get` with a [regional endpoint]
            /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.get` is not
            /// recommended, as you can only get the state of jobs that are running in `us-central1`.
            /// </summary>
            /// <param name="projectId">The ID of the Cloud Platform project that the job belongs to.</param>
            /// <param name="jobId">The job ID.</param>
            public virtual GetRequest Get(string projectId, string jobId)
            {
                return new GetRequest(service, projectId, jobId);
            }

            /// <summary>
            /// Gets the state of the specified Cloud Dataflow job. To get the state of a job, we recommend using
            /// `projects.locations.jobs.get` with a [regional endpoint]
            /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.get` is not
            /// recommended, as you can only get the state of jobs that are running in `us-central1`.
            /// </summary>
            public class GetRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Job>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string jobId) : base(service)
                {
                    ProjectId = projectId;
                    JobId = jobId;
                    InitParameters();
                }

                /// <summary>The ID of the Cloud Platform project that the job belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The job ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string JobId { get; private set; }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>The level of information requested in response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The level of information requested in response.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The job view to return isn't specified, or is unknown. Responses will contain at least the
                    /// `JOB_VIEW_SUMMARY` information, and may contain additional information.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_UNKNOWN")]
                    JOBVIEWUNKNOWN = 0,

                    /// <summary>
                    /// Request summary information only: Project ID, Job ID, job name, job type, job status, start/end
                    /// time, and Cloud SDK version details.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_SUMMARY")]
                    JOBVIEWSUMMARY = 1,

                    /// <summary>Request all information available for this job.</summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_ALL")]
                    JOBVIEWALL = 2,

                    /// <summary>
                    /// Request summary info and limited job description data for steps, labels and environment.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_DESCRIPTION")]
                    JOBVIEWDESCRIPTION = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}";

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
                    RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "jobId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
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
            /// Request the job status. To request the status of a job, we recommend using
            /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
            /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.getMetrics`
            /// is not recommended, as you can only request the status of jobs that are running in `us-central1`.
            /// </summary>
            /// <param name="projectId">A project id.</param>
            /// <param name="jobId">The job to get metrics for.</param>
            public virtual GetMetricsRequest GetMetrics(string projectId, string jobId)
            {
                return new GetMetricsRequest(service, projectId, jobId);
            }

            /// <summary>
            /// Request the job status. To request the status of a job, we recommend using
            /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
            /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.getMetrics`
            /// is not recommended, as you can only request the status of jobs that are running in `us-central1`.
            /// </summary>
            public class GetMetricsRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.JobMetrics>
            {
                /// <summary>Constructs a new GetMetrics request.</summary>
                public GetMetricsRequest(Google.Apis.Services.IClientService service, string projectId, string jobId) : base(service)
                {
                    ProjectId = projectId;
                    JobId = jobId;
                    InitParameters();
                }

                /// <summary>A project id.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The job to get metrics for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string JobId { get; private set; }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains the job specified by job_id.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>
                /// Return only metric data that has changed since this time. Default is to return all information about
                /// all metrics for the job.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object StartTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getMetrics";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}/metrics";

                /// <summary>Initializes GetMetrics parameter list.</summary>
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
                    RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "jobId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// List the jobs of a project. To list the jobs of a project in a region, we recommend using
            /// `projects.locations.jobs.list` with a [regional endpoint]
            /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). To list the all jobs across all
            /// regions, use `projects.jobs.aggregated`. Using `projects.jobs.list` is not recommended, as you can only
            /// get the list of jobs that are running in `us-central1`.
            /// </summary>
            /// <param name="projectId">The project which owns the jobs.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(service, projectId);
            }

            /// <summary>
            /// List the jobs of a project. To list the jobs of a project in a region, we recommend using
            /// `projects.locations.jobs.list` with a [regional endpoint]
            /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). To list the all jobs across all
            /// regions, use `projects.jobs.aggregated`. Using `projects.jobs.list` is not recommended, as you can only
            /// get the list of jobs that are running in `us-central1`.
            /// </summary>
            public class ListRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ListJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>The project which owns the jobs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The kind of filter to use.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<FilterEnum> Filter { get; set; }

                /// <summary>The kind of filter to use.</summary>
                public enum FilterEnum
                {
                    /// <summary>
                    /// The filter isn't specified, or is unknown. This returns all jobs ordered on descending
                    /// `JobUuid`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("UNKNOWN")]
                    UNKNOWN = 0,

                    /// <summary>
                    /// Returns all running jobs first ordered on creation timestamp, then returns all terminated jobs
                    /// ordered on the termination timestamp.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALL")]
                    ALL = 1,

                    /// <summary>
                    /// Filters the jobs that have a terminated state, ordered on the termination timestamp. Example
                    /// terminated states: `JOB_STATE_STOPPED`, `JOB_STATE_UPDATED`, `JOB_STATE_DRAINED`, etc.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("TERMINATED")]
                    TERMINATED = 2,

                    /// <summary>Filters the jobs that are running ordered on the creation timestamp.</summary>
                    [Google.Apis.Util.StringValueAttribute("ACTIVE")]
                    ACTIVE = 3,
                }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>
                /// If there are many jobs, limit response to at most this many. The actual number of jobs returned will
                /// be the lesser of max_responses and an unspecified server-defined limit.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Set this to the 'next_page_token' field of a previous response to request additional results in a
                /// long list.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Deprecated. ListJobs always returns summaries now. Use GetJob for other JobViews.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Deprecated. ListJobs always returns summaries now. Use GetJob for other JobViews.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The job view to return isn't specified, or is unknown. Responses will contain at least the
                    /// `JOB_VIEW_SUMMARY` information, and may contain additional information.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_UNKNOWN")]
                    JOBVIEWUNKNOWN = 0,

                    /// <summary>
                    /// Request summary information only: Project ID, Job ID, job name, job type, job status, start/end
                    /// time, and Cloud SDK version details.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_SUMMARY")]
                    JOBVIEWSUMMARY = 1,

                    /// <summary>Request all information available for this job.</summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_ALL")]
                    JOBVIEWALL = 2,

                    /// <summary>
                    /// Request summary info and limited job description data for steps, labels and environment.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("JOB_VIEW_DESCRIPTION")]
                    JOBVIEWDESCRIPTION = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/jobs";

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
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
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

            /// <summary>Snapshot the state of a streaming job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">The project which owns the job to be snapshotted.</param>
            /// <param name="jobId">The job to be snapshotted.</param>
            public virtual SnapshotRequest Snapshot(Google.Apis.Dataflow.v1b3.Data.SnapshotJobRequest body, string projectId, string jobId)
            {
                return new SnapshotRequest(service, body, projectId, jobId);
            }

            /// <summary>Snapshot the state of a streaming job.</summary>
            public class SnapshotRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Snapshot>
            {
                /// <summary>Constructs a new Snapshot request.</summary>
                public SnapshotRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.SnapshotJobRequest body, string projectId, string jobId) : base(service)
                {
                    ProjectId = projectId;
                    JobId = jobId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The project which owns the job to be snapshotted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The job to be snapshotted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string JobId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Dataflow.v1b3.Data.SnapshotJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "snapshot";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}:snapshot";

                /// <summary>Initializes Snapshot parameter list.</summary>
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
                    RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "jobId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates the state of an existing Cloud Dataflow job. To update the state of an existing job, we
            /// recommend using `projects.locations.jobs.update` with a [regional endpoint]
            /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.update` is
            /// not recommended, as you can only update the state of jobs that are running in `us-central1`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">The ID of the Cloud Platform project that the job belongs to.</param>
            /// <param name="jobId">The job ID.</param>
            public virtual UpdateRequest Update(Google.Apis.Dataflow.v1b3.Data.Job body, string projectId, string jobId)
            {
                return new UpdateRequest(service, body, projectId, jobId);
            }

            /// <summary>
            /// Updates the state of an existing Cloud Dataflow job. To update the state of an existing job, we
            /// recommend using `projects.locations.jobs.update` with a [regional endpoint]
            /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.update` is
            /// not recommended, as you can only update the state of jobs that are running in `us-central1`.
            /// </summary>
            public class UpdateRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Job>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.Job body, string projectId, string jobId) : base(service)
                {
                    ProjectId = projectId;
                    JobId = jobId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the Cloud Platform project that the job belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The job ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string JobId { get; private set; }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Dataflow.v1b3.Data.Job Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/jobs/{jobId}";

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
                    RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "jobId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
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
                FlexTemplates = new FlexTemplatesResource(service);
                Jobs = new JobsResource(service);
                Snapshots = new SnapshotsResource(service);
                Sql = new SqlResource(service);
                Templates = new TemplatesResource(service);
            }

            /// <summary>Gets the FlexTemplates resource.</summary>
            public virtual FlexTemplatesResource FlexTemplates { get; }

            /// <summary>The "flexTemplates" collection of methods.</summary>
            public class FlexTemplatesResource
            {
                private const string Resource = "flexTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FlexTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Launch a job with a FlexTemplate.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="location">
                /// Required. The [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to which to direct the request.
                /// E.g., us-central1, us-west1.
                /// </param>
                public virtual LaunchRequest Launch(Google.Apis.Dataflow.v1b3.Data.LaunchFlexTemplateRequest body, string projectId, string location)
                {
                    return new LaunchRequest(service, body, projectId, location);
                }

                /// <summary>Launch a job with a FlexTemplate.</summary>
                public class LaunchRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.LaunchFlexTemplateResponse>
                {
                    /// <summary>Constructs a new Launch request.</summary>
                    public LaunchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.LaunchFlexTemplateRequest body, string projectId, string location) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// Required. The [regional endpoint]
                    /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to which to direct the
                    /// request. E.g., us-central1, us-west1.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.LaunchFlexTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "launch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/flexTemplates:launch";

                    /// <summary>Initializes Launch parameter list.</summary>
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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
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
                    Debug = new DebugResource(service);
                    Messages = new MessagesResource(service);
                    Snapshots = new SnapshotsResource(service);
                    Stages = new StagesResource(service);
                    WorkItems = new WorkItemsResource(service);
                }

                /// <summary>Gets the Debug resource.</summary>
                public virtual DebugResource Debug { get; }

                /// <summary>The "debug" collection of methods.</summary>
                public class DebugResource
                {
                    private const string Resource = "debug";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DebugResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Get encoded debug configuration for component. Not cacheable.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">The project id.</param>
                    /// <param name="location">
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the job specified by job_id.
                    /// </param>
                    /// <param name="jobId">The job id.</param>
                    public virtual GetConfigRequest GetConfig(Google.Apis.Dataflow.v1b3.Data.GetDebugConfigRequest body, string projectId, string location, string jobId)
                    {
                        return new GetConfigRequest(service, body, projectId, location, jobId);
                    }

                    /// <summary>Get encoded debug configuration for component. Not cacheable.</summary>
                    public class GetConfigRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.GetDebugConfigResponse>
                    {
                        /// <summary>Constructs a new GetConfig request.</summary>
                        public GetConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.GetDebugConfigRequest body, string projectId, string location, string jobId) : base(service)
                        {
                            ProjectId = projectId;
                            Location = location;
                            JobId = jobId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The project id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                        /// that contains the job specified by job_id.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Location { get; private set; }

                        /// <summary>The job id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string JobId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataflow.v1b3.Data.GetDebugConfigRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getConfig";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/debug/getConfig";

                        /// <summary>Initializes GetConfig parameter list.</summary>
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
                            RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                            {
                                Name = "location",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "jobId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Send encoded debug capture data for component.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">The project id.</param>
                    /// <param name="location">
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the job specified by job_id.
                    /// </param>
                    /// <param name="jobId">The job id.</param>
                    public virtual SendCaptureRequest SendCapture(Google.Apis.Dataflow.v1b3.Data.SendDebugCaptureRequest body, string projectId, string location, string jobId)
                    {
                        return new SendCaptureRequest(service, body, projectId, location, jobId);
                    }

                    /// <summary>Send encoded debug capture data for component.</summary>
                    public class SendCaptureRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.SendDebugCaptureResponse>
                    {
                        /// <summary>Constructs a new SendCapture request.</summary>
                        public SendCaptureRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.SendDebugCaptureRequest body, string projectId, string location, string jobId) : base(service)
                        {
                            ProjectId = projectId;
                            Location = location;
                            JobId = jobId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The project id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                        /// that contains the job specified by job_id.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Location { get; private set; }

                        /// <summary>The job id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string JobId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataflow.v1b3.Data.SendDebugCaptureRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "sendCapture";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/debug/sendCapture";

                        /// <summary>Initializes SendCapture parameter list.</summary>
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
                            RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                            {
                                Name = "location",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "jobId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Messages resource.</summary>
                public virtual MessagesResource Messages { get; }

                /// <summary>The "messages" collection of methods.</summary>
                public class MessagesResource
                {
                    private const string Resource = "messages";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MessagesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Request the job status. To request the status of a job, we recommend using
                    /// `projects.locations.jobs.messages.list` with a [regional endpoint]
                    /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
                    /// `projects.jobs.messages.list` is not recommended, as you can only request the status of jobs
                    /// that are running in `us-central1`.
                    /// </summary>
                    /// <param name="projectId">A project id.</param>
                    /// <param name="location">
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the job specified by job_id.
                    /// </param>
                    /// <param name="jobId">The job to get messages about.</param>
                    public virtual ListRequest List(string projectId, string location, string jobId)
                    {
                        return new ListRequest(service, projectId, location, jobId);
                    }

                    /// <summary>
                    /// Request the job status. To request the status of a job, we recommend using
                    /// `projects.locations.jobs.messages.list` with a [regional endpoint]
                    /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
                    /// `projects.jobs.messages.list` is not recommended, as you can only request the status of jobs
                    /// that are running in `us-central1`.
                    /// </summary>
                    public class ListRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ListJobMessagesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string projectId, string location, string jobId) : base(service)
                        {
                            ProjectId = projectId;
                            Location = location;
                            JobId = jobId;
                            InitParameters();
                        }

                        /// <summary>A project id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                        /// that contains the job specified by job_id.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Location { get; private set; }

                        /// <summary>The job to get messages about.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string JobId { get; private set; }

                        /// <summary>
                        /// Return only messages with timestamps &amp;lt; end_time. The default is now (i.e. return up
                        /// to the latest messages available).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object EndTime { get; set; }

                        /// <summary>Filter to only get messages with importance &gt;= level</summary>
                        [Google.Apis.Util.RequestParameterAttribute("minimumImportance", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<MinimumImportanceEnum> MinimumImportance { get; set; }

                        /// <summary>Filter to only get messages with importance &gt;= level</summary>
                        public enum MinimumImportanceEnum
                        {
                            /// <summary>The message importance isn't specified, or is unknown.</summary>
                            [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_IMPORTANCE_UNKNOWN")]
                            JOBMESSAGEIMPORTANCEUNKNOWN = 0,

                            /// <summary>
                            /// The message is at the 'debug' level: typically only useful for software engineers
                            /// working on the code the job is running. Typically, Dataflow pipeline runners do not
                            /// display log messages at this level by default.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_DEBUG")]
                            JOBMESSAGEDEBUG = 1,

                            /// <summary>
                            /// The message is at the 'detailed' level: somewhat verbose, but potentially useful to
                            /// users. Typically, Dataflow pipeline runners do not display log messages at this level by
                            /// default. These messages are displayed by default in the Dataflow monitoring UI.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_DETAILED")]
                            JOBMESSAGEDETAILED = 2,

                            /// <summary>
                            /// The message is at the 'basic' level: useful for keeping track of the execution of a
                            /// Dataflow pipeline. Typically, Dataflow pipeline runners display log messages at this
                            /// level by default, and these messages are displayed by default in the Dataflow monitoring
                            /// UI.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_BASIC")]
                            JOBMESSAGEBASIC = 3,

                            /// <summary>
                            /// The message is at the 'warning' level: indicating a condition pertaining to a job which
                            /// may require human intervention. Typically, Dataflow pipeline runners display log
                            /// messages at this level by default, and these messages are displayed by default in the
                            /// Dataflow monitoring UI.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_WARNING")]
                            JOBMESSAGEWARNING = 4,

                            /// <summary>
                            /// The message is at the 'error' level: indicating a condition preventing a job from
                            /// succeeding. Typically, Dataflow pipeline runners display log messages at this level by
                            /// default, and these messages are displayed by default in the Dataflow monitoring UI.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("JOB_MESSAGE_ERROR")]
                            JOBMESSAGEERROR = 5,
                        }

                        /// <summary>
                        /// If specified, determines the maximum number of messages to return. If unspecified, the
                        /// service may choose an appropriate default, or may return an arbitrarily large number of
                        /// results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// If supplied, this should be the value of next_page_token returned by an earlier call. This
                        /// will cause the next page of results to be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// If specified, return only messages with timestamps &amp;gt;= start_time. The default is the
                        /// job creation time (i.e. beginning of messages).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object StartTime { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/messages";

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
                            RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                            {
                                Name = "location",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "jobId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "endTime",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("minimumImportance", new Google.Apis.Discovery.Parameter
                            {
                                Name = "minimumImportance",
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
                            RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "startTime",
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

                    /// <summary>Lists snapshots.</summary>
                    /// <param name="projectId">The project ID to list snapshots for.</param>
                    /// <param name="location">The location to list snapshots in.</param>
                    /// <param name="jobId">If specified, list snapshots created from this job.</param>
                    public virtual ListRequest List(string projectId, string location, string jobId)
                    {
                        return new ListRequest(service, projectId, location, jobId);
                    }

                    /// <summary>Lists snapshots.</summary>
                    public class ListRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ListSnapshotsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string projectId, string location, string jobId) : base(service)
                        {
                            ProjectId = projectId;
                            Location = location;
                            JobId = jobId;
                            InitParameters();
                        }

                        /// <summary>The project ID to list snapshots for.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>The location to list snapshots in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Location { get; private set; }

                        /// <summary>If specified, list snapshots created from this job.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string JobId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/snapshots";

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
                            RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                            {
                                Name = "location",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "jobId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Stages resource.</summary>
                public virtual StagesResource Stages { get; }

                /// <summary>The "stages" collection of methods.</summary>
                public class StagesResource
                {
                    private const string Resource = "stages";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public StagesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Request detailed information about the execution status of a stage of the job. EXPERIMENTAL.
                    /// This API is subject to change or removal without notice.
                    /// </summary>
                    /// <param name="projectId">A project id.</param>
                    /// <param name="location">
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the job specified by job_id.
                    /// </param>
                    /// <param name="jobId">The job to get execution details for.</param>
                    /// <param name="stageId">The stage for which to fetch information.</param>
                    public virtual GetExecutionDetailsRequest GetExecutionDetails(string projectId, string location, string jobId, string stageId)
                    {
                        return new GetExecutionDetailsRequest(service, projectId, location, jobId, stageId);
                    }

                    /// <summary>
                    /// Request detailed information about the execution status of a stage of the job. EXPERIMENTAL.
                    /// This API is subject to change or removal without notice.
                    /// </summary>
                    public class GetExecutionDetailsRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.StageExecutionDetails>
                    {
                        /// <summary>Constructs a new GetExecutionDetails request.</summary>
                        public GetExecutionDetailsRequest(Google.Apis.Services.IClientService service, string projectId, string location, string jobId, string stageId) : base(service)
                        {
                            ProjectId = projectId;
                            Location = location;
                            JobId = jobId;
                            StageId = stageId;
                            InitParameters();
                        }

                        /// <summary>A project id.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                        /// that contains the job specified by job_id.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Location { get; private set; }

                        /// <summary>The job to get execution details for.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string JobId { get; private set; }

                        /// <summary>The stage for which to fetch information.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("stageId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string StageId { get; private set; }

                        /// <summary>Upper time bound of work items to include, by start time.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object EndTime { get; set; }

                        /// <summary>
                        /// If specified, determines the maximum number of work items to return. If unspecified, the
                        /// service may choose an appropriate default, or may return an arbitrarily large number of
                        /// results.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// If supplied, this should be the value of next_page_token returned by an earlier call. This
                        /// will cause the next page of results to be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Lower time bound of work items to include, by start time.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object StartTime { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getExecutionDetails";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/stages/{stageId}/executionDetails";

                        /// <summary>Initializes GetExecutionDetails parameter list.</summary>
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
                            RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                            {
                                Name = "location",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "jobId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("stageId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "stageId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "endTime",
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
                            RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "startTime",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the WorkItems resource.</summary>
                public virtual WorkItemsResource WorkItems { get; }

                /// <summary>The "workItems" collection of methods.</summary>
                public class WorkItemsResource
                {
                    private const string Resource = "workItems";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public WorkItemsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Leases a dataflow WorkItem to run.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">Identifies the project this worker belongs to.</param>
                    /// <param name="location">
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the WorkItem's job.
                    /// </param>
                    /// <param name="jobId">Identifies the workflow job this worker belongs to.</param>
                    public virtual LeaseRequest Lease(Google.Apis.Dataflow.v1b3.Data.LeaseWorkItemRequest body, string projectId, string location, string jobId)
                    {
                        return new LeaseRequest(service, body, projectId, location, jobId);
                    }

                    /// <summary>Leases a dataflow WorkItem to run.</summary>
                    public class LeaseRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.LeaseWorkItemResponse>
                    {
                        /// <summary>Constructs a new Lease request.</summary>
                        public LeaseRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.LeaseWorkItemRequest body, string projectId, string location, string jobId) : base(service)
                        {
                            ProjectId = projectId;
                            Location = location;
                            JobId = jobId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Identifies the project this worker belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                        /// that contains the WorkItem's job.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Location { get; private set; }

                        /// <summary>Identifies the workflow job this worker belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string JobId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataflow.v1b3.Data.LeaseWorkItemRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "lease";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/workItems:lease";

                        /// <summary>Initializes Lease parameter list.</summary>
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
                            RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                            {
                                Name = "location",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "jobId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Reports the status of dataflow WorkItems leased by a worker.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectId">The project which owns the WorkItem's job.</param>
                    /// <param name="location">
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the WorkItem's job.
                    /// </param>
                    /// <param name="jobId">The job which the WorkItem is part of.</param>
                    public virtual ReportStatusRequest ReportStatus(Google.Apis.Dataflow.v1b3.Data.ReportWorkItemStatusRequest body, string projectId, string location, string jobId)
                    {
                        return new ReportStatusRequest(service, body, projectId, location, jobId);
                    }

                    /// <summary>Reports the status of dataflow WorkItems leased by a worker.</summary>
                    public class ReportStatusRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ReportWorkItemStatusResponse>
                    {
                        /// <summary>Constructs a new ReportStatus request.</summary>
                        public ReportStatusRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.ReportWorkItemStatusRequest body, string projectId, string location, string jobId) : base(service)
                        {
                            ProjectId = projectId;
                            Location = location;
                            JobId = jobId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The project which owns the WorkItem's job.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectId { get; private set; }

                        /// <summary>
                        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                        /// that contains the WorkItem's job.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Location { get; private set; }

                        /// <summary>The job which the WorkItem is part of.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string JobId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dataflow.v1b3.Data.ReportWorkItemStatusRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "reportStatus";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/workItems:reportStatus";

                        /// <summary>Initializes ReportStatus parameter list.</summary>
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
                            RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                            {
                                Name = "location",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "jobId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a Cloud Dataflow job. To create a job, we recommend using `projects.locations.jobs.create`
                /// with a [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints).
                /// Using `projects.jobs.create` is not recommended, as your job will always start in `us-central1`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">The ID of the Cloud Platform project that the job belongs to.</param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Dataflow.v1b3.Data.Job body, string projectId, string location)
                {
                    return new CreateRequest(service, body, projectId, location);
                }

                /// <summary>
                /// Creates a Cloud Dataflow job. To create a job, we recommend using `projects.locations.jobs.create`
                /// with a [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints).
                /// Using `projects.jobs.create` is not recommended, as your job will always start in `us-central1`.
                /// </summary>
                public class CreateRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Job>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.Job body, string projectId, string location) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The ID of the Cloud Platform project that the job belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains this job.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>Deprecated. This field is now in the Job message.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("replaceJobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReplaceJobId { get; set; }

                    /// <summary>The level of information requested in response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>The level of information requested in response.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The job view to return isn't specified, or is unknown. Responses will contain at least the
                        /// `JOB_VIEW_SUMMARY` information, and may contain additional information.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_UNKNOWN")]
                        JOBVIEWUNKNOWN = 0,

                        /// <summary>
                        /// Request summary information only: Project ID, Job ID, job name, job type, job status,
                        /// start/end time, and Cloud SDK version details.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_SUMMARY")]
                        JOBVIEWSUMMARY = 1,

                        /// <summary>Request all information available for this job.</summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_ALL")]
                        JOBVIEWALL = 2,

                        /// <summary>
                        /// Request summary info and limited job description data for steps, labels and environment.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_DESCRIPTION")]
                        JOBVIEWDESCRIPTION = 3,
                    }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.Job Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("replaceJobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "replaceJobId",
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
                /// Gets the state of the specified Cloud Dataflow job. To get the state of a job, we recommend using
                /// `projects.locations.jobs.get` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.get` is
                /// not recommended, as you can only get the state of jobs that are running in `us-central1`.
                /// </summary>
                /// <param name="projectId">The ID of the Cloud Platform project that the job belongs to.</param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </param>
                /// <param name="jobId">The job ID.</param>
                public virtual GetRequest Get(string projectId, string location, string jobId)
                {
                    return new GetRequest(service, projectId, location, jobId);
                }

                /// <summary>
                /// Gets the state of the specified Cloud Dataflow job. To get the state of a job, we recommend using
                /// `projects.locations.jobs.get` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.get` is
                /// not recommended, as you can only get the state of jobs that are running in `us-central1`.
                /// </summary>
                public class GetRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Job>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectId, string location, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        JobId = jobId;
                        InitParameters();
                    }

                    /// <summary>The ID of the Cloud Platform project that the job belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains this job.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The job ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>The level of information requested in response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>The level of information requested in response.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The job view to return isn't specified, or is unknown. Responses will contain at least the
                        /// `JOB_VIEW_SUMMARY` information, and may contain additional information.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_UNKNOWN")]
                        JOBVIEWUNKNOWN = 0,

                        /// <summary>
                        /// Request summary information only: Project ID, Job ID, job name, job type, job status,
                        /// start/end time, and Cloud SDK version details.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_SUMMARY")]
                        JOBVIEWSUMMARY = 1,

                        /// <summary>Request all information available for this job.</summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_ALL")]
                        JOBVIEWALL = 2,

                        /// <summary>
                        /// Request summary info and limited job description data for steps, labels and environment.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_DESCRIPTION")]
                        JOBVIEWDESCRIPTION = 3,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
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
                /// Request detailed information about the execution status of the job. EXPERIMENTAL. This API is
                /// subject to change or removal without notice.
                /// </summary>
                /// <param name="projectId">A project id.</param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains the job specified by job_id.
                /// </param>
                /// <param name="jobId">The job to get execution details for.</param>
                public virtual GetExecutionDetailsRequest GetExecutionDetails(string projectId, string location, string jobId)
                {
                    return new GetExecutionDetailsRequest(service, projectId, location, jobId);
                }

                /// <summary>
                /// Request detailed information about the execution status of the job. EXPERIMENTAL. This API is
                /// subject to change or removal without notice.
                /// </summary>
                public class GetExecutionDetailsRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.JobExecutionDetails>
                {
                    /// <summary>Constructs a new GetExecutionDetails request.</summary>
                    public GetExecutionDetailsRequest(Google.Apis.Services.IClientService service, string projectId, string location, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        JobId = jobId;
                        InitParameters();
                    }

                    /// <summary>A project id.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the job specified by job_id.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The job to get execution details for.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>
                    /// If specified, determines the maximum number of stages to return. If unspecified, the service may
                    /// choose an appropriate default, or may return an arbitrarily large number of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// If supplied, this should be the value of next_page_token returned by an earlier call. This will
                    /// cause the next page of results to be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getExecutionDetails";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/executionDetails";

                    /// <summary>Initializes GetExecutionDetails parameter list.</summary>
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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
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
                /// Request the job status. To request the status of a job, we recommend using
                /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
                /// `projects.jobs.getMetrics` is not recommended, as you can only request the status of jobs that are
                /// running in `us-central1`.
                /// </summary>
                /// <param name="projectId">A project id.</param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains the job specified by job_id.
                /// </param>
                /// <param name="jobId">The job to get metrics for.</param>
                public virtual GetMetricsRequest GetMetrics(string projectId, string location, string jobId)
                {
                    return new GetMetricsRequest(service, projectId, location, jobId);
                }

                /// <summary>
                /// Request the job status. To request the status of a job, we recommend using
                /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
                /// `projects.jobs.getMetrics` is not recommended, as you can only request the status of jobs that are
                /// running in `us-central1`.
                /// </summary>
                public class GetMetricsRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.JobMetrics>
                {
                    /// <summary>Constructs a new GetMetrics request.</summary>
                    public GetMetricsRequest(Google.Apis.Services.IClientService service, string projectId, string location, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        JobId = jobId;
                        InitParameters();
                    }

                    /// <summary>A project id.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains the job specified by job_id.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The job to get metrics for.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>
                    /// Return only metric data that has changed since this time. Default is to return all information
                    /// about all metrics for the job.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getMetrics";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}/metrics";

                    /// <summary>Initializes GetMetrics parameter list.</summary>
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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// List the jobs of a project. To list the jobs of a project in a region, we recommend using
                /// `projects.locations.jobs.list` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). To list the all jobs across
                /// all regions, use `projects.jobs.aggregated`. Using `projects.jobs.list` is not recommended, as you
                /// can only get the list of jobs that are running in `us-central1`.
                /// </summary>
                /// <param name="projectId">The project which owns the jobs.</param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </param>
                public virtual ListRequest List(string projectId, string location)
                {
                    return new ListRequest(service, projectId, location);
                }

                /// <summary>
                /// List the jobs of a project. To list the jobs of a project in a region, we recommend using
                /// `projects.locations.jobs.list` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). To list the all jobs across
                /// all regions, use `projects.jobs.aggregated`. Using `projects.jobs.list` is not recommended, as you
                /// can only get the list of jobs that are running in `us-central1`.
                /// </summary>
                public class ListRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ListJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectId, string location) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>The project which owns the jobs.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains this job.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The kind of filter to use.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterEnum> Filter { get; set; }

                    /// <summary>The kind of filter to use.</summary>
                    public enum FilterEnum
                    {
                        /// <summary>
                        /// The filter isn't specified, or is unknown. This returns all jobs ordered on descending
                        /// `JobUuid`.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("UNKNOWN")]
                        UNKNOWN = 0,

                        /// <summary>
                        /// Returns all running jobs first ordered on creation timestamp, then returns all terminated
                        /// jobs ordered on the termination timestamp.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("ALL")]
                        ALL = 1,

                        /// <summary>
                        /// Filters the jobs that have a terminated state, ordered on the termination timestamp. Example
                        /// terminated states: `JOB_STATE_STOPPED`, `JOB_STATE_UPDATED`, `JOB_STATE_DRAINED`, etc.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("TERMINATED")]
                        TERMINATED = 2,

                        /// <summary>Filters the jobs that are running ordered on the creation timestamp.</summary>
                        [Google.Apis.Util.StringValueAttribute("ACTIVE")]
                        ACTIVE = 3,
                    }

                    /// <summary>
                    /// If there are many jobs, limit response to at most this many. The actual number of jobs returned
                    /// will be the lesser of max_responses and an unspecified server-defined limit.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Set this to the 'next_page_token' field of a previous response to request additional results in
                    /// a long list.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Deprecated. ListJobs always returns summaries now. Use GetJob for other JobViews.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Deprecated. ListJobs always returns summaries now. Use GetJob for other JobViews.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// The job view to return isn't specified, or is unknown. Responses will contain at least the
                        /// `JOB_VIEW_SUMMARY` information, and may contain additional information.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_UNKNOWN")]
                        JOBVIEWUNKNOWN = 0,

                        /// <summary>
                        /// Request summary information only: Project ID, Job ID, job name, job type, job status,
                        /// start/end time, and Cloud SDK version details.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_SUMMARY")]
                        JOBVIEWSUMMARY = 1,

                        /// <summary>Request all information available for this job.</summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_ALL")]
                        JOBVIEWALL = 2,

                        /// <summary>
                        /// Request summary info and limited job description data for steps, labels and environment.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("JOB_VIEW_DESCRIPTION")]
                        JOBVIEWDESCRIPTION = 3,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
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

                /// <summary>Snapshot the state of a streaming job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">The project which owns the job to be snapshotted.</param>
                /// <param name="location">The location that contains this job.</param>
                /// <param name="jobId">The job to be snapshotted.</param>
                public virtual SnapshotRequest Snapshot(Google.Apis.Dataflow.v1b3.Data.SnapshotJobRequest body, string projectId, string location, string jobId)
                {
                    return new SnapshotRequest(service, body, projectId, location, jobId);
                }

                /// <summary>Snapshot the state of a streaming job.</summary>
                public class SnapshotRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Snapshot>
                {
                    /// <summary>Constructs a new Snapshot request.</summary>
                    public SnapshotRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.SnapshotJobRequest body, string projectId, string location, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        JobId = jobId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The project which owns the job to be snapshotted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>The location that contains this job.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The job to be snapshotted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.SnapshotJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "snapshot";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}:snapshot";

                    /// <summary>Initializes Snapshot parameter list.</summary>
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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates the state of an existing Cloud Dataflow job. To update the state of an existing job, we
                /// recommend using `projects.locations.jobs.update` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.update`
                /// is not recommended, as you can only update the state of jobs that are running in `us-central1`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">The ID of the Cloud Platform project that the job belongs to.</param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains this job.
                /// </param>
                /// <param name="jobId">The job ID.</param>
                public virtual UpdateRequest Update(Google.Apis.Dataflow.v1b3.Data.Job body, string projectId, string location, string jobId)
                {
                    return new UpdateRequest(service, body, projectId, location, jobId);
                }

                /// <summary>
                /// Updates the state of an existing Cloud Dataflow job. To update the state of an existing job, we
                /// recommend using `projects.locations.jobs.update` with a [regional endpoint]
                /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using `projects.jobs.update`
                /// is not recommended, as you can only update the state of jobs that are running in `us-central1`.
                /// </summary>
                public class UpdateRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Job>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.Job body, string projectId, string location, string jobId) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        JobId = jobId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The ID of the Cloud Platform project that the job belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
                    /// that contains this job.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The job ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string JobId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.Job Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/jobs/{jobId}";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = true,
                            ParameterType = "path",
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

                /// <summary>Deletes a snapshot.</summary>
                /// <param name="projectId">The ID of the Cloud Platform project that the snapshot belongs to.</param>
                /// <param name="location">The location that contains this snapshot.</param>
                /// <param name="snapshotId">The ID of the snapshot.</param>
                public virtual DeleteRequest Delete(string projectId, string location, string snapshotId)
                {
                    return new DeleteRequest(service, projectId, location, snapshotId);
                }

                /// <summary>Deletes a snapshot.</summary>
                public class DeleteRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.DeleteSnapshotResponse>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string location, string snapshotId) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        SnapshotId = snapshotId;
                        InitParameters();
                    }

                    /// <summary>The ID of the Cloud Platform project that the snapshot belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>The location that contains this snapshot.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The ID of the snapshot.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("snapshotId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string SnapshotId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/snapshots/{snapshotId}";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("snapshotId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "snapshotId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets information about a snapshot.</summary>
                /// <param name="projectId">The ID of the Cloud Platform project that the snapshot belongs to.</param>
                /// <param name="location">The location that contains this snapshot.</param>
                /// <param name="snapshotId">The ID of the snapshot.</param>
                public virtual GetRequest Get(string projectId, string location, string snapshotId)
                {
                    return new GetRequest(service, projectId, location, snapshotId);
                }

                /// <summary>Gets information about a snapshot.</summary>
                public class GetRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Snapshot>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectId, string location, string snapshotId) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        SnapshotId = snapshotId;
                        InitParameters();
                    }

                    /// <summary>The ID of the Cloud Platform project that the snapshot belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>The location that contains this snapshot.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The ID of the snapshot.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("snapshotId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string SnapshotId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/snapshots/{snapshotId}";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("snapshotId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "snapshotId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists snapshots.</summary>
                /// <param name="projectId">The project ID to list snapshots for.</param>
                /// <param name="location">The location to list snapshots in.</param>
                public virtual ListRequest List(string projectId, string location)
                {
                    return new ListRequest(service, projectId, location);
                }

                /// <summary>Lists snapshots.</summary>
                public class ListRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ListSnapshotsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectId, string location) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>The project ID to list snapshots for.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>The location to list snapshots in.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>If specified, list snapshots created from this job.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string JobId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/snapshots";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Sql resource.</summary>
            public virtual SqlResource Sql { get; }

            /// <summary>The "sql" collection of methods.</summary>
            public class SqlResource
            {
                private const string Resource = "sql";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SqlResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Validates a GoogleSQL query for Cloud Dataflow syntax. Will always confirm the given query parses
                /// correctly, and if able to look up schema information from DataCatalog, will validate that the query
                /// analyzes properly as well.
                /// </summary>
                /// <param name="projectId">
                /// Required. The ID of the Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                /// which to direct the request.
                /// </param>
                public virtual ValidateRequest Validate(string projectId, string location)
                {
                    return new ValidateRequest(service, projectId, location);
                }

                /// <summary>
                /// Validates a GoogleSQL query for Cloud Dataflow syntax. Will always confirm the given query parses
                /// correctly, and if able to look up schema information from DataCatalog, will validate that the query
                /// analyzes properly as well.
                /// </summary>
                public class ValidateRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ValidateResponse>
                {
                    /// <summary>Constructs a new Validate request.</summary>
                    public ValidateRequest(Google.Apis.Services.IClientService service, string projectId, string location) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                    /// which to direct the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>The sql query to validate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Query { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "validate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/sql:validate";

                    /// <summary>Initializes Validate parameter list.</summary>
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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                        {
                            Name = "query",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Templates resource.</summary>
            public virtual TemplatesResource Templates { get; }

            /// <summary>The "templates" collection of methods.</summary>
            public class TemplatesResource
            {
                private const string Resource = "templates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public TemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a Cloud Dataflow job from a template.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                /// which to direct the request.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Dataflow.v1b3.Data.CreateJobFromTemplateRequest body, string projectId, string location)
                {
                    return new CreateRequest(service, body, projectId, location);
                }

                /// <summary>Creates a Cloud Dataflow job from a template.</summary>
                public class CreateRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Job>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.CreateJobFromTemplateRequest body, string projectId, string location) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                    /// which to direct the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.CreateJobFromTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/templates";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Get the template associated with a template.</summary>
                /// <param name="projectId">
                /// Required. The ID of the Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                /// which to direct the request.
                /// </param>
                public virtual GetRequest Get(string projectId, string location)
                {
                    return new GetRequest(service, projectId, location);
                }

                /// <summary>Get the template associated with a template.</summary>
                public class GetRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.GetTemplateResponse>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectId, string location) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                    /// which to direct the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>
                    /// Required. A Cloud Storage path to the template from which to create the job. Must be valid Cloud
                    /// Storage URL, beginning with 'gs://'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("gcsPath", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GcsPath { get; set; }

                    /// <summary>The view to retrieve. Defaults to METADATA_ONLY.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>The view to retrieve. Defaults to METADATA_ONLY.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// Template view that retrieves only the metadata associated with the template.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("METADATA_ONLY")]
                        METADATAONLY = 0,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/templates:get";

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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("gcsPath", new Google.Apis.Discovery.Parameter
                        {
                            Name = "gcsPath",
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

                /// <summary>Launch a template.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectId">
                /// Required. The ID of the Cloud Platform project that the job belongs to.
                /// </param>
                /// <param name="location">
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                /// which to direct the request.
                /// </param>
                public virtual LaunchRequest Launch(Google.Apis.Dataflow.v1b3.Data.LaunchTemplateParameters body, string projectId, string location)
                {
                    return new LaunchRequest(service, body, projectId, location);
                }

                /// <summary>Launch a template.</summary>
                public class LaunchRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.LaunchTemplateResponse>
                {
                    /// <summary>Constructs a new Launch request.</summary>
                    public LaunchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.LaunchTemplateParameters body, string projectId, string location) : base(service)
                    {
                        ProjectId = projectId;
                        Location = location;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectId { get; private set; }

                    /// <summary>
                    /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                    /// which to direct the request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>
                    /// Path to dynamic template spec file on Cloud Storage. The file must be a Json serialized
                    /// DynamicTemplateFieSpec object.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dynamicTemplate.gcsPath", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DynamicTemplateGcsPath { get; set; }

                    /// <summary>
                    /// Cloud Storage path for staging dependencies. Must be a valid Cloud Storage URL, beginning with
                    /// `gs://`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dynamicTemplate.stagingLocation", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DynamicTemplateStagingLocation { get; set; }

                    /// <summary>
                    /// A Cloud Storage path to the template from which to create the job. Must be valid Cloud Storage
                    /// URL, beginning with 'gs://'.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("gcsPath", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GcsPath { get; set; }

                    /// <summary>
                    /// If true, the request is validated but not actually executed. Defaults to false.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dataflow.v1b3.Data.LaunchTemplateParameters Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "launch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/templates:launch";

                    /// <summary>Initializes Launch parameter list.</summary>
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
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("dynamicTemplate.gcsPath", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dynamicTemplate.gcsPath",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("dynamicTemplate.stagingLocation", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dynamicTemplate.stagingLocation",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("gcsPath", new Google.Apis.Discovery.Parameter
                        {
                            Name = "gcsPath",
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

            /// <summary>Send a worker_message to the service.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">The project to send the WorkerMessages to.</param>
            /// <param name="location">
            /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
            /// contains the job.
            /// </param>
            public virtual WorkerMessagesRequest WorkerMessages(Google.Apis.Dataflow.v1b3.Data.SendWorkerMessagesRequest body, string projectId, string location)
            {
                return new WorkerMessagesRequest(service, body, projectId, location);
            }

            /// <summary>Send a worker_message to the service.</summary>
            public class WorkerMessagesRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.SendWorkerMessagesResponse>
            {
                /// <summary>Constructs a new WorkerMessages request.</summary>
                public WorkerMessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.SendWorkerMessagesRequest body, string projectId, string location) : base(service)
                {
                    ProjectId = projectId;
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The project to send the WorkerMessages to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that
                /// contains the job.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Dataflow.v1b3.Data.SendWorkerMessagesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "workerMessages";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/locations/{location}/WorkerMessages";

                /// <summary>Initializes WorkerMessages parameter list.</summary>
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
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
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

            /// <summary>Gets information about a snapshot.</summary>
            /// <param name="projectId">The ID of the Cloud Platform project that the snapshot belongs to.</param>
            /// <param name="snapshotId">The ID of the snapshot.</param>
            public virtual GetRequest Get(string projectId, string snapshotId)
            {
                return new GetRequest(service, projectId, snapshotId);
            }

            /// <summary>Gets information about a snapshot.</summary>
            public class GetRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Snapshot>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string snapshotId) : base(service)
                {
                    ProjectId = projectId;
                    SnapshotId = snapshotId;
                    InitParameters();
                }

                /// <summary>The ID of the Cloud Platform project that the snapshot belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The ID of the snapshot.</summary>
                [Google.Apis.Util.RequestParameterAttribute("snapshotId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SnapshotId { get; private set; }

                /// <summary>The location that contains this snapshot.</summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/snapshots/{snapshotId}";

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
                    RequestParameters.Add("snapshotId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "snapshotId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists snapshots.</summary>
            /// <param name="projectId">The project ID to list snapshots for.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(service, projectId);
            }

            /// <summary>Lists snapshots.</summary>
            public class ListRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.ListSnapshotsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>The project ID to list snapshots for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>If specified, list snapshots created from this job.</summary>
                [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string JobId { get; set; }

                /// <summary>The location to list snapshots in.</summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/snapshots";

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
                    RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "jobId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Templates resource.</summary>
        public virtual TemplatesResource Templates { get; }

        /// <summary>The "templates" collection of methods.</summary>
        public class TemplatesResource
        {
            private const string Resource = "templates";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TemplatesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a Cloud Dataflow job from a template.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. The ID of the Cloud Platform project that the job belongs to.</param>
            public virtual CreateRequest Create(Google.Apis.Dataflow.v1b3.Data.CreateJobFromTemplateRequest body, string projectId)
            {
                return new CreateRequest(service, body, projectId);
            }

            /// <summary>Creates a Cloud Dataflow job from a template.</summary>
            public class CreateRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.Job>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.CreateJobFromTemplateRequest body, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Dataflow.v1b3.Data.CreateJobFromTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/templates";

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
                }
            }

            /// <summary>Get the template associated with a template.</summary>
            /// <param name="projectId">Required. The ID of the Cloud Platform project that the job belongs to.</param>
            public virtual GetRequest Get(string projectId)
            {
                return new GetRequest(service, projectId);
            }

            /// <summary>Get the template associated with a template.</summary>
            public class GetRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.GetTemplateResponse>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// Required. A Cloud Storage path to the template from which to create the job. Must be valid Cloud
                /// Storage URL, beginning with 'gs://'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("gcsPath", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string GcsPath { get; set; }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                /// which to direct the request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>The view to retrieve. Defaults to METADATA_ONLY.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The view to retrieve. Defaults to METADATA_ONLY.</summary>
                public enum ViewEnum
                {
                    /// <summary>Template view that retrieves only the metadata associated with the template.</summary>
                    [Google.Apis.Util.StringValueAttribute("METADATA_ONLY")]
                    METADATAONLY = 0,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/templates:get";

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
                    RequestParameters.Add("gcsPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "gcsPath",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
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

            /// <summary>Launch a template.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Required. The ID of the Cloud Platform project that the job belongs to.</param>
            public virtual LaunchRequest Launch(Google.Apis.Dataflow.v1b3.Data.LaunchTemplateParameters body, string projectId)
            {
                return new LaunchRequest(service, body, projectId);
            }

            /// <summary>Launch a template.</summary>
            public class LaunchRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.LaunchTemplateResponse>
            {
                /// <summary>Constructs a new Launch request.</summary>
                public LaunchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.LaunchTemplateParameters body, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the Cloud Platform project that the job belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// Path to dynamic template spec file on Cloud Storage. The file must be a Json serialized
                /// DynamicTemplateFieSpec object.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dynamicTemplate.gcsPath", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DynamicTemplateGcsPath { get; set; }

                /// <summary>
                /// Cloud Storage path for staging dependencies. Must be a valid Cloud Storage URL, beginning with
                /// `gs://`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dynamicTemplate.stagingLocation", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DynamicTemplateStagingLocation { get; set; }

                /// <summary>
                /// A Cloud Storage path to the template from which to create the job. Must be valid Cloud Storage URL,
                /// beginning with 'gs://'.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("gcsPath", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string GcsPath { get; set; }

                /// <summary>
                /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to
                /// which to direct the request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Location { get; set; }

                /// <summary>If true, the request is validated but not actually executed. Defaults to false.</summary>
                [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ValidateOnly { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Dataflow.v1b3.Data.LaunchTemplateParameters Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "launch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1b3/projects/{projectId}/templates:launch";

                /// <summary>Initializes Launch parameter list.</summary>
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
                    RequestParameters.Add("dynamicTemplate.gcsPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dynamicTemplate.gcsPath",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dynamicTemplate.stagingLocation", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dynamicTemplate.stagingLocation",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("gcsPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "gcsPath",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
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

        /// <summary>Deletes a snapshot.</summary>
        /// <param name="projectId">The ID of the Cloud Platform project that the snapshot belongs to.</param>
        public virtual DeleteSnapshotsRequest DeleteSnapshots(string projectId)
        {
            return new DeleteSnapshotsRequest(service, projectId);
        }

        /// <summary>Deletes a snapshot.</summary>
        public class DeleteSnapshotsRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.DeleteSnapshotResponse>
        {
            /// <summary>Constructs a new DeleteSnapshots request.</summary>
            public DeleteSnapshotsRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
            {
                ProjectId = projectId;
                InitParameters();
            }

            /// <summary>The ID of the Cloud Platform project that the snapshot belongs to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>The location that contains this snapshot.</summary>
            [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Location { get; set; }

            /// <summary>The ID of the snapshot.</summary>
            [Google.Apis.Util.RequestParameterAttribute("snapshotId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SnapshotId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deleteSnapshots";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1b3/projects/{projectId}/snapshots";

            /// <summary>Initializes DeleteSnapshots parameter list.</summary>
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
                RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                {
                    Name = "location",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("snapshotId", new Google.Apis.Discovery.Parameter
                {
                    Name = "snapshotId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Send a worker_message to the service.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">The project to send the WorkerMessages to.</param>
        public virtual WorkerMessagesRequest WorkerMessages(Google.Apis.Dataflow.v1b3.Data.SendWorkerMessagesRequest body, string projectId)
        {
            return new WorkerMessagesRequest(service, body, projectId);
        }

        /// <summary>Send a worker_message to the service.</summary>
        public class WorkerMessagesRequest : DataflowBaseServiceRequest<Google.Apis.Dataflow.v1b3.Data.SendWorkerMessagesResponse>
        {
            /// <summary>Constructs a new WorkerMessages request.</summary>
            public WorkerMessagesRequest(Google.Apis.Services.IClientService service, Google.Apis.Dataflow.v1b3.Data.SendWorkerMessagesRequest body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>The project to send the WorkerMessages to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Dataflow.v1b3.Data.SendWorkerMessagesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "workerMessages";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1b3/projects/{projectId}/WorkerMessages";

            /// <summary>Initializes WorkerMessages parameter list.</summary>
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
            }
        }
    }
}
namespace Google.Apis.Dataflow.v1b3.Data
{
    /// <summary>Obsolete in favor of ApproximateReportedProgress and ApproximateSplitRequest.</summary>
    public class ApproximateProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Obsolete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentComplete")]
        public virtual System.Nullable<float> PercentComplete { get; set; }

        /// <summary>Obsolete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual Position Position { get; set; }

        /// <summary>Obsolete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingTime")]
        public virtual object RemainingTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A progress measurement of a WorkItem by a worker.</summary>
    public class ApproximateReportedProgress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Total amount of parallelism in the portion of input of this task that has already been consumed and is no
        /// longer active. In the first two examples above (see remaining_parallelism), the value should be 29 or 2
        /// respectively. The sum of remaining_parallelism and consumed_parallelism should equal the total amount of
        /// parallelism in this work item. If specified, must be finite.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumedParallelism")]
        public virtual ReportedParallelism ConsumedParallelism { get; set; }

        /// <summary>
        /// Completion as fraction of the input consumed, from 0.0 (beginning, nothing consumed), to 1.0 (end of the
        /// input, entire input consumed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fractionConsumed")]
        public virtual System.Nullable<double> FractionConsumed { get; set; }

        /// <summary>A Position within the work to represent a progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual Position Position { get; set; }

        /// <summary>
        /// Total amount of parallelism in the input of this task that remains, (i.e. can be delegated to this task and
        /// any new tasks via dynamic splitting). Always at least 1 for non-finished work items and 0 for finished.
        /// "Amount of parallelism" refers to how many non-empty parts of the input can be read in parallel. This does
        /// not necessarily equal number of records. An input that can be read in parallel down to the individual
        /// records is called "perfectly splittable". An example of non-perfectly parallelizable input is a
        /// block-compressed file format where a block of records has to be read as a whole, but different blocks can be
        /// read in parallel. Examples: * If we are processing record #30 (starting at 1) out of 50 in a perfectly
        /// splittable 50-record input, this value should be 21 (20 remaining + 1 current). * If we are reading through
        /// block 3 in a block-compressed file consisting of 5 blocks, this value should be 3 (since blocks 4 and 5 can
        /// be processed in parallel by new tasks via dynamic splitting and the current task remains processing block
        /// 3). * If we are reading through the last block in a block-compressed file, or reading or processing the last
        /// record in a perfectly splittable input, this value should be 1, because apart from the current task, no
        /// additional remainder can be split off.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingParallelism")]
        public virtual ReportedParallelism RemainingParallelism { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A suggestion by the service to the worker to dynamically split the WorkItem.</summary>
    public class ApproximateSplitRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A fraction at which to split the work item, from 0.0 (beginning of the input) to 1.0 (end of the input).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fractionConsumed")]
        public virtual System.Nullable<double> FractionConsumed { get; set; }

        /// <summary>
        /// The fraction of the remainder of work to split the work item at, from 0.0 (split at the current position) to
        /// 1.0 (end of the input).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fractionOfRemainder")]
        public virtual System.Nullable<double> FractionOfRemainder { get; set; }

        /// <summary>A Position at which to split the work item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual Position Position { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A structured message reporting an autoscaling decision made by the Dataflow service.</summary>
    public class AutoscalingEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current number of workers the job has.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentNumWorkers")]
        public virtual System.Nullable<long> CurrentNumWorkers { get; set; }

        /// <summary>
        /// A message describing why the system decided to adjust the current number of workers, why it failed, or why
        /// the system decided to not make any changes to the number of workers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual StructuredMessage Description { get; set; }

        /// <summary>The type of autoscaling event to report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>The target number of workers the worker pool wants to resize to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNumWorkers")]
        public virtual System.Nullable<long> TargetNumWorkers { get; set; }

        /// <summary>The time this event was emitted to indicate a new target or current num_workers value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual object Time { get; set; }

        /// <summary>A short and friendly name for the worker pool this event refers to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for WorkerPool autoscaling.</summary>
    public class AutoscalingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The algorithm to use for autoscaling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>The maximum number of workers to cap scaling at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNumWorkers")]
        public virtual System.Nullable<int> MaxNumWorkers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a BigQuery connector used by the job.</summary>
    public class BigQueryIODetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dataset accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Project accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Query used to access data in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>Table accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a Cloud BigTable connector used by the job.</summary>
    public class BigTableIODetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>InstanceId accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>ProjectId accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>TableId accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Modeled after information exposed by /proc/stat.</summary>
    public class CPUTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average CPU utilization rate (% non-idle cpu / second) since previous sample.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rate")]
        public virtual System.Nullable<double> Rate { get; set; }

        /// <summary>Timestamp of the measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>Total active CPU time across all cores (ie., non-idle) in milliseconds since start-up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalMs")]
        public virtual System.Nullable<ulong> TotalMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of an interstitial value between transforms in an execution stage.</summary>
    public class ComponentSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dataflow service generated name for this source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// User name for the original user transform or collection with which this source is most closely associated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalTransformOrCollection")]
        public virtual string OriginalTransformOrCollection { get; set; }

        /// <summary>Human-readable name for this transform; may be user or system generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of a transform executed as part of an execution stage.</summary>
    public class ComponentTransform : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dataflow service generated name for this source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// User name for the original user transform with which this transform is most closely associated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalTransform")]
        public virtual string OriginalTransform { get; set; }

        /// <summary>Human-readable name for this transform; may be user or system generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All configuration data for a particular Computation.</summary>
    public class ComputationTopology : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computationId")]
        public virtual string ComputationId { get; set; }

        /// <summary>The inputs to the computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<StreamLocation> Inputs { get; set; }

        /// <summary>The key ranges processed by the computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyRanges")]
        public virtual System.Collections.Generic.IList<KeyRangeLocation> KeyRanges { get; set; }

        /// <summary>The outputs from the computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual System.Collections.Generic.IList<StreamLocation> Outputs { get; set; }

        /// <summary>The state family values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateFamilies")]
        public virtual System.Collections.Generic.IList<StateFamilyConfig> StateFamilies { get; set; }

        /// <summary>The system stage name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemStageName")]
        public virtual string SystemStageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A position that encapsulates an inner position and an index for the inner position. A ConcatPosition can be used
    /// by a reader of a source that encapsulates a set of other sources.
    /// </summary>
    public class ConcatPosition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Index of the inner source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Position within the inner source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual Position Position { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container Spec.</summary>
    public class ContainerSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default runtime environment for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultEnvironment")]
        public virtual FlexTemplateRuntimeEnvironment DefaultEnvironment { get; set; }

        /// <summary>Name of the docker container image. E.g., gcr.io/project/some-image</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>Metadata describing a template including description and validation rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual TemplateMetadata Metadata { get; set; }

        /// <summary>Required. SDK info of the Flex Template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkInfo")]
        public virtual SDKInfo SdkInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CounterMetadata includes all static non-name non-value counter attributes.</summary>
    public class CounterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human-readable description of the counter semantics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Counter aggregation kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>A string referring to the unit type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherUnits")]
        public virtual string OtherUnits { get; set; }

        /// <summary>System defined Units, see above enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardUnits")]
        public virtual string StandardUnits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a counter within a per-job namespace. Counters whose structured names are the same get merged into a
    /// single value for the job.
    /// </summary>
    public class CounterStructuredName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the optimized step being executed by the workers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentStepName")]
        public virtual string ComponentStepName { get; set; }

        /// <summary>Name of the stage. An execution step contains multiple component steps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStepName")]
        public virtual string ExecutionStepName { get; set; }

        /// <summary>
        /// Index of an input collection that's being read from/written to as a side input. The index identifies a
        /// step's side inputs starting by 1 (e.g. the first side input has input_index 1, the third has input_index 3).
        /// Side inputs are identified by a pair of (original_step_name, input_index). This field helps uniquely
        /// identify them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputIndex")]
        public virtual System.Nullable<int> InputIndex { get; set; }

        /// <summary>
        /// Counter name. Not necessarily globally-unique, but unique within the context of the other fields. Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>One of the standard Origins defined above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>A string containing a more specific namespace of the counter's origin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originNamespace")]
        public virtual string OriginNamespace { get; set; }

        /// <summary>
        /// The step name requesting an operation, such as GBK. I.e. the ParDo causing a read/write from shuffle to
        /// occur, or a read from side inputs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalRequestingStepName")]
        public virtual string OriginalRequestingStepName { get; set; }

        /// <summary>System generated name of the original step in the user's graph, before optimization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalStepName")]
        public virtual string OriginalStepName { get; set; }

        /// <summary>Portion of this counter, either key or value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portion")]
        public virtual string Portion { get; set; }

        /// <summary>ID of a particular worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerId")]
        public virtual string WorkerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single message which encapsulates structured name and metadata for a given counter.</summary>
    public class CounterStructuredNameAndMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata associated with a counter</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual CounterMetadata Metadata { get; set; }

        /// <summary>Structured name of the counter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual CounterStructuredName Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An update to a Counter sent from a worker.</summary>
    public class CounterUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Boolean value for And, Or.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolean")]
        public virtual System.Nullable<bool> Boolean { get; set; }

        /// <summary>
        /// True if this counter is reported as the total cumulative aggregate value accumulated since the worker
        /// started working on this WorkItem. By default this is false, indicating that this counter is reported as a
        /// delta.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cumulative")]
        public virtual System.Nullable<bool> Cumulative { get; set; }

        /// <summary>Distribution data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual DistributionUpdate Distribution { get; set; }

        /// <summary>Floating point value for Sum, Max, Min.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatingPoint")]
        public virtual System.Nullable<double> FloatingPoint { get; set; }

        /// <summary>List of floating point numbers, for Set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatingPointList")]
        public virtual FloatingPointList FloatingPointList { get; set; }

        /// <summary>Floating point mean aggregation value for Mean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatingPointMean")]
        public virtual FloatingPointMean FloatingPointMean { get; set; }

        /// <summary>Integer value for Sum, Max, Min.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integer")]
        public virtual SplitInt64 Integer { get; set; }

        /// <summary>Gauge data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerGauge")]
        public virtual IntegerGauge IntegerGauge { get; set; }

        /// <summary>List of integers, for Set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerList")]
        public virtual IntegerList IntegerList { get; set; }

        /// <summary>Integer mean aggregation value for Mean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerMean")]
        public virtual IntegerMean IntegerMean { get; set; }

        /// <summary>Value for internally-defined counters used by the Dataflow service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internal")]
        public virtual object Internal__ { get; set; }

        /// <summary>Counter name and aggregation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameAndKind")]
        public virtual NameAndKind NameAndKind { get; set; }

        /// <summary>
        /// The service-generated short identifier for this counter. The short_id -&amp;gt; (name, metadata) mapping is
        /// constant for the lifetime of a job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortId")]
        public virtual System.Nullable<long> ShortId { get; set; }

        /// <summary>List of strings, for Set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringList")]
        public virtual StringList StringList { get; set; }

        /// <summary>Counter structured name and metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structuredNameAndMetadata")]
        public virtual CounterStructuredNameAndMetadata StructuredNameAndMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to create a Cloud Dataflow job from a template.</summary>
    public class CreateJobFromTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The runtime environment for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual RuntimeEnvironment Environment { get; set; }

        /// <summary>
        /// Required. A Cloud Storage path to the template from which to create the job. Must be a valid Cloud Storage
        /// URL, beginning with `gs://`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPath")]
        public virtual string GcsPath { get; set; }

        /// <summary>Required. The job name to use for the created job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobName")]
        public virtual string JobName { get; set; }

        /// <summary>
        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) to which to
        /// direct the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The runtime parameters to pass to the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies the location of a custom souce.</summary>
    public class CustomSourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether this source is stateful.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateful")]
        public virtual System.Nullable<bool> Stateful { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data disk assignment for a given VM instance.</summary>
    public class DataDiskAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mounted data disks. The order is important a data disk's 0-based index in this list defines which persistent
        /// directory the disk is mounted to, for example the list of { "myproject-1014-104817-4c2-harness-0-disk-0" },
        /// { "myproject-1014-104817-4c2-harness-0-disk-1" }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisks")]
        public virtual System.Collections.Generic.IList<string> DataDisks { get; set; }

        /// <summary>
        /// VM instance name the data disks mounted to, for example "myproject-1014-104817-4c2-harness-0".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmInstance")]
        public virtual string VmInstance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a Datastore connector used by the job.</summary>
    public class DatastoreIODetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Namespace used in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>ProjectId accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes any options that have an effect on the debugging of pipelines.</summary>
    public class DebugOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>When true, enables the logging of the literal hot key to the user's Cloud Logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableHotKeyLogging")]
        public virtual System.Nullable<bool> EnableHotKeyLogging { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from deleting a snapshot.</summary>
    public class DeleteSnapshotResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of one of the bundles produced as a result of splitting a Source (e.g. when executing a
    /// SourceSplitRequest, or when splitting an active task using WorkItemStatus.dynamic_source_split), relative to the
    /// source being split.
    /// </summary>
    public class DerivedSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>What source to base the produced source on (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivationMode")]
        public virtual string DerivationMode { get; set; }

        /// <summary>Specification of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the data disk used by a workflow job.</summary>
    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Disk storage type, as defined by Google Compute Engine. This must be a disk type appropriate to the project
        /// and zone in which the workers will run. If unknown or unspecified, the service will attempt to choose a
        /// reasonable default. For example, the standard persistent disk type is a resource name typically ending in
        /// "pd-standard". If SSD persistent disks are available, the resource name typically ends with "pd-ssd". The
        /// actual valid values are defined the Google Compute Engine API, not by the Cloud Dataflow API; consult the
        /// Google Compute Engine documentation for more information about determining the set of available disk types
        /// for a particular project and zone. Google Compute Engine Disk types are local to a particular project in a
        /// particular zone, and so the resource name will typically look something like this:
        /// compute.googleapis.com/projects/project-id/zones/zone/diskTypes/pd-standard
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>Directory in a VM where disk is mounted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPoint")]
        public virtual string MountPoint { get; set; }

        /// <summary>
        /// Size of disk in GB. If zero or unspecified, the service will attempt to choose a reasonable default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data provided with a pipeline or transform to provide descriptive info.</summary>
    public class DisplayData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains value if the data is of a boolean type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Contains value if the data is of duration type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationValue")]
        public virtual object DurationValue { get; set; }

        /// <summary>Contains value if the data is of float type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>Contains value if the data is of int64 type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>Contains value if the data is of java class type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("javaClassValue")]
        public virtual string JavaClassValue { get; set; }

        /// <summary>
        /// The key identifying the display data. This is intended to be used as a label for the display data when
        /// viewed in a dax monitoring system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>An optional label to display in a dax UI for the element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The namespace for the key. This is usually a class name or programming language namespace (i.e. python
        /// module) which defines the display data. This allows a dax monitoring system to specially handle the data and
        /// perform custom rendering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>
        /// A possible additional shorter value to display. For example a java_class_name_value of com.mypackage.MyDoFn
        /// will be stored with MyDoFn as the short_str_value and com.mypackage.MyDoFn as the java_class_name value.
        /// short_str_value can be displayed and java_class_name_value will be displayed as a tooltip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortStrValue")]
        public virtual string ShortStrValue { get; set; }

        /// <summary>Contains value if the data is of string type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strValue")]
        public virtual string StrValue { get; set; }

        /// <summary>Contains value if the data is of timestamp type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual object TimestampValue { get; set; }

        /// <summary>An optional full URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A metric value representing a distribution.</summary>
    public class DistributionUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The count of the number of elements present in the distribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual SplitInt64 Count { get; set; }

        /// <summary>(Optional) Histogram of value counts for the distribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogram")]
        public virtual Histogram Histogram { get; set; }

        /// <summary>The maximum value present in the distribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual SplitInt64 Max { get; set; }

        /// <summary>The minimum value present in the distribution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual SplitInt64 Min { get; set; }

        /// <summary>
        /// Use an int64 since we'd prefer the added precision. If overflow is a common problem we can detect it and use
        /// an additional int64 or a double.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sum")]
        public virtual SplitInt64 Sum { get; set; }

        /// <summary>Use a double since the sum of squares is likely to overflow int64.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sumOfSquares")]
        public virtual System.Nullable<double> SumOfSquares { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When a task splits using WorkItemStatus.dynamic_source_split, this message describes the two parts of the split
    /// relative to the description of the current task's input.
    /// </summary>
    public class DynamicSourceSplit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Primary part (continued to be processed by worker). Specified relative to the previously-current source.
        /// Becomes current.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual DerivedSource Primary { get; set; }

        /// <summary>
        /// Residual part (returned to the pool of work). Specified relative to the previously-current source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("residual")]
        public virtual DerivedSource Residual { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the environment in which a Dataflow Job runs.</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of cluster manager API to use. If unknown or unspecified, the service will attempt to choose a
        /// reasonable default. This should be in the form of the API service name, e.g. "compute.googleapis.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterManagerApiService")]
        public virtual string ClusterManagerApiService { get; set; }

        /// <summary>
        /// The dataset for the current project where various workflow related tables are stored. The supported resource
        /// type is: Google BigQuery: bigquery.googleapis.com/{dataset}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Any debugging options to be supplied to the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugOptions")]
        public virtual DebugOptions DebugOptions { get; set; }

        /// <summary>
        /// The list of experiments to enable. This field should be used for SDK related experiments and not for service
        /// related experiments. The proper field for service related experiments is service_options.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("experiments")]
        public virtual System.Collections.Generic.IList<string> Experiments { get; set; }

        /// <summary>Which Flexible Resource Scheduling mode to run in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flexResourceSchedulingGoal")]
        public virtual string FlexResourceSchedulingGoal { get; set; }

        /// <summary>Experimental settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalExperiments")]
        public virtual System.Collections.Generic.IDictionary<string, object> InternalExperiments { get; set; }

        /// <summary>
        /// The Cloud Dataflow SDK pipeline options specified by the user. These options are passed through the service
        /// and are used to recreate the SDK pipeline options on the worker in a language agnostic and platform
        /// independent way.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkPipelineOptions")]
        public virtual System.Collections.Generic.IDictionary<string, object> SdkPipelineOptions { get; set; }

        /// <summary>Identity to run virtual machines as. Defaults to the default account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// If set, contains the Cloud KMS key identifier used to encrypt data at rest, AKA a Customer Managed
        /// Encryption Key (CMEK). Format: projects/PROJECT_ID/locations/LOCATION/keyRings/KEY_RING/cryptoKeys/KEY
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceKmsKeyName")]
        public virtual string ServiceKmsKeyName { get; set; }

        /// <summary>
        /// The list of service options to enable. This field should be used for service related experiments only. These
        /// experiments, when graduating to GA, should be replaced by dedicated fields or become default (i.e. always
        /// on).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceOptions")]
        public virtual System.Collections.Generic.IList<string> ServiceOptions { get; set; }

        /// <summary>Output only. The shuffle mode used for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shuffleMode")]
        public virtual string ShuffleMode { get; set; }

        /// <summary>
        /// The prefix of the resources the system should use for temporary storage. The system will append the suffix
        /// "/temp-{JOBNAME} to this resource prefix, where {JOBNAME} is the value of the job_name field. The resulting
        /// bucket and object prefix is used as the prefix of the resources used to store temporary data needed during
        /// the job execution. NOTE: This will override the value in taskrunner_settings. The supported resource type
        /// is: Google Cloud Storage: storage.googleapis.com/{bucket}/{object} bucket.storage.googleapis.com/{object}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tempStoragePrefix")]
        public virtual string TempStoragePrefix { get; set; }

        /// <summary>A description of the process that generated the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual System.Collections.Generic.IDictionary<string, object> UserAgent { get; set; }

        /// <summary>
        /// A structure describing which components and their versions of the service are required in order to run the
        /// job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Collections.Generic.IDictionary<string, object> Version { get; set; }

        /// <summary>
        /// The worker pools. At least one "harness" worker pool must be specified in order for the job to have workers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPools")]
        public virtual System.Collections.Generic.IList<WorkerPool> WorkerPools { get; set; }

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
        /// nor worker_zone is specified, a zone in the control plane's region is chosen based on available capacity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerZone")]
        public virtual string WorkerZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message describing the state of a particular execution stage.</summary>
    public class ExecutionStageState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the stage transitioned to this state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentStateTime")]
        public virtual object CurrentStateTime { get; set; }

        /// <summary>The name of the execution stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStageName")]
        public virtual string ExecutionStageName { get; set; }

        /// <summary>Executions stage states allow the same set of values as JobState.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionStageState")]
        public virtual string ExecutionStageStateValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Description of the composing transforms, names/ids, and input/outputs of a stage of execution. Some composing
    /// transforms and sources may have been generated by the Dataflow service during execution planning.
    /// </summary>
    public class ExecutionStageSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collections produced and consumed by component transforms of this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentSource")]
        public virtual System.Collections.Generic.IList<ComponentSource> ComponentSource { get; set; }

        /// <summary>Transforms that comprise this execution stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentTransform")]
        public virtual System.Collections.Generic.IList<ComponentTransform> ComponentTransform { get; set; }

        /// <summary>Dataflow service generated id for this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Input sources for this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputSource")]
        public virtual System.Collections.Generic.IList<StageSource> InputSource { get; set; }

        /// <summary>Type of transform this stage is executing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Dataflow service generated name for this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output sources for this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputSource")]
        public virtual System.Collections.Generic.IList<StageSource> OutputSource { get; set; }

        /// <summary>Other stages that must complete before this stage can run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prerequisiteStage")]
        public virtual System.Collections.Generic.IList<string> PrerequisiteStage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates which [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) failed
    /// to respond to a request for data.
    /// </summary>
    public class FailedLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints)
        /// that failed to respond.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a File connector used by the job.</summary>
    public class FileIODetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>File Pattern used to access files by the connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filePattern")]
        public virtual string FilePattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instruction that copies its inputs (zero or more) to its (single) output.</summary>
    public class FlattenInstruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the inputs to the flatten instruction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<InstructionInput> Inputs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The environment values to be set at runtime for flex template.</summary>
    public class FlexTemplateRuntimeEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional experiment flags for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalExperiments")]
        public virtual System.Collections.Generic.IList<string> AdditionalExperiments { get; set; }

        /// <summary>
        /// Additional user labels to be specified for the job. Keys and values must follow the restrictions specified
        /// in the [labeling restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions) page.
        /// An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1kg", "count": "3"
        /// }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalUserLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalUserLabels { get; set; }

        /// <summary>Worker disk size, in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<int> DiskSizeGb { get; set; }

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

        /// <summary>The maximum number of workers to cap scaling at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNumWorkers")]
        public virtual System.Nullable<int> MaxNumWorkers { get; set; }

        /// <summary>
        /// The maximum number of Google Compute Engine instances to be made available to your pipeline during
        /// execution, from 1 to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWorkers")]
        public virtual System.Nullable<int> MaxWorkers { get; set; }

        /// <summary>
        /// Network to which VMs will be assigned. If empty or unspecified, the service will use the network "default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The initial number of Google Compute Engine instances for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numWorkers")]
        public virtual System.Nullable<int> NumWorkers { get; set; }

        /// <summary>
        /// Docker registry location of container image to use for the 'worker harness. Default is the container for the
        /// version of the SDK. Note this field is only valid for portable pipelines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkContainerImage")]
        public virtual string SdkContainerImage { get; set; }

        /// <summary>The email address of the service account to run the job as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>
        /// The Cloud Storage path for staging local files. Must be a valid Cloud Storage URL, beginning with `gs://`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stagingLocation")]
        public virtual string StagingLocation { get; set; }

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

    /// <summary>A metric value representing a list of floating point numbers.</summary>
    public class FloatingPointList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Elements of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elements")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Elements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a floating point mean metric contribution.</summary>
    public class FloatingPointMean : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of values being aggregated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual SplitInt64 Count { get; set; }

        /// <summary>The sum of all values being aggregated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sum")]
        public virtual System.Nullable<double> Sum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to get updated debug configuration for component.</summary>
    public class GetDebugConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The internal component id for which debug configuration is requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentId")]
        public virtual string ComponentId { get; set; }

        /// <summary>
        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that contains
        /// the job specified by job_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The worker id, i.e., VM hostname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerId")]
        public virtual string WorkerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a get debug configuration request.</summary>
    public class GetDebugConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoded debug configuration for the requested component.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual string Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a GetTemplate request.</summary>
    public class GetTemplateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The template metadata describing the template name, available parameters, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual TemplateMetadata Metadata { get; set; }

        /// <summary>Describes the runtime metadata with SDKInfo and available parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeMetadata")]
        public virtual RuntimeMetadata RuntimeMetadata { get; set; }

        /// <summary>
        /// The status of the get template request. Any problems with the request will be indicated in the
        /// error_details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>Template Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateType")]
        public virtual string TemplateType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Histogram of value counts for a distribution. Buckets have an inclusive lower bound and exclusive upper bound
    /// and use "1,2,5 bucketing": The first bucket range is from [0,1) and all subsequent bucket boundaries are powers
    /// of ten multiplied by 1, 2, or 5. Thus, bucket boundaries are 0, 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000, ...
    /// Negative values are not supported.
    /// </summary>
    public class Histogram : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Counts of values in each bucket. For efficiency, prefix and trailing buckets with count = 0 are elided.
        /// Buckets can store the full range of values of an unsigned long, with ULLONG_MAX falling into the 59th bucket
        /// with range [1e19, 2e19).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketCounts")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> BucketCounts { get; set; }

        /// <summary>
        /// Starting index of first stored bucket. The non-inclusive upper-bound of the ith bucket is given by:
        /// pow(10,(i-first_bucket_offset)/3) * (1,2,5)[(i-first_bucket_offset)%3]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstBucketOffset")]
        public virtual System.Nullable<int> FirstBucketOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Proto describing a hot key detected on a given WorkItem.</summary>
    public class HotKeyDetection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The age of the hot key measured from when it was first detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotKeyAge")]
        public virtual object HotKeyAge { get; set; }

        /// <summary>System-defined name of the step containing this hot key. Unique across the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemName")]
        public virtual string SystemName { get; set; }

        /// <summary>User-provided name of the step that contains this hot key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userStepName")]
        public virtual string UserStepName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An input of an instruction, as a reference to an output of a producer instruction.</summary>
    public class InstructionInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The output index (origin zero) within the producer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputNum")]
        public virtual System.Nullable<int> OutputNum { get; set; }

        /// <summary>
        /// The index (origin zero) of the parallel instruction that produces the output to be consumed by this input.
        /// This index is relative to the list of instructions in this input's instruction's containing MapTask.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerInstructionIndex")]
        public virtual System.Nullable<int> ProducerInstructionIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An output of an instruction.</summary>
    public class InstructionOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The codec to use to encode data being written via this output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codec")]
        public virtual System.Collections.Generic.IDictionary<string, object> Codec { get; set; }

        /// <summary>The user-provided name of this output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// For system-generated byte and mean byte metrics, certain instructions should only report the key size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyCountKeyBytes")]
        public virtual System.Nullable<bool> OnlyCountKeyBytes { get; set; }

        /// <summary>
        /// For system-generated byte and mean byte metrics, certain instructions should only report the value size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onlyCountValueBytes")]
        public virtual System.Nullable<bool> OnlyCountValueBytes { get; set; }

        /// <summary>
        /// System-defined name for this output in the original workflow graph. Outputs that do not contribute to an
        /// original instruction do not set this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalName")]
        public virtual string OriginalName { get; set; }

        /// <summary>System-defined name of this output. Unique across the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemName")]
        public virtual string SystemName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A metric value representing temporal values of a variable.</summary>
    public class IntegerGauge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which this value was measured. Measured as msecs from epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>The value of the variable represented by this gauge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual SplitInt64 Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A metric value representing a list of integers.</summary>
    public class IntegerList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Elements of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elements")]
        public virtual System.Collections.Generic.IList<SplitInt64> Elements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of an integer mean metric contribution.</summary>
    public class IntegerMean : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of values being aggregated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual SplitInt64 Count { get; set; }

        /// <summary>The sum of all values being aggregated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sum")]
        public virtual SplitInt64 Sum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a job to be run by the Cloud Dataflow service. nextID: 26</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The client's unique identifier of the job, re-used across retried attempts. If this field is set, the
        /// service will ensure its uniqueness. The request to create a job will fail if the service has knowledge of a
        /// previously submitted job with the same client's ID and job name. The caller may use this field to ensure
        /// idempotence of job creation across retried attempts to create a job. By default, the field is empty and, in
        /// that case, the service ignores it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientRequestId")]
        public virtual string ClientRequestId { get; set; }

        /// <summary>
        /// The timestamp when the job was initially created. Immutable and set by the Cloud Dataflow service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>If this is specified, the job's initial state is populated from the given snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdFromSnapshotId")]
        public virtual string CreatedFromSnapshotId { get; set; }

        /// <summary>
        /// The current state of the job. Jobs are created in the `JOB_STATE_STOPPED` state unless otherwise specified.
        /// A job in the `JOB_STATE_RUNNING` state may asynchronously enter a terminal state. After a job has reached a
        /// terminal state, no further state updates may be made. This field may be mutated by the Cloud Dataflow
        /// service; callers cannot mutate it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentState")]
        public virtual string CurrentState { get; set; }

        /// <summary>The timestamp associated with the current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentStateTime")]
        public virtual object CurrentStateTime { get; set; }

        /// <summary>The environment for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual Environment Environment { get; set; }

        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionInfo")]
        public virtual JobExecutionInfo ExecutionInfo { get; set; }

        /// <summary>
        /// The unique ID of this job. This field is set by the Cloud Dataflow service when the Job is created, and is
        /// immutable for the life of the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// This field is populated by the Dataflow service to support filtering jobs by the metadata values provided
        /// here. Populated for ListJobs and all GetJob views SUMMARY and higher.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobMetadata")]
        public virtual JobMetadata JobMetadata { get; set; }

        /// <summary>
        /// User-defined labels for this job. The labels map can contain no more than 64 entries. Entries of the labels
        /// map are UTF8 strings that comply with the following restrictions: * Keys must conform to regexp:
        /// \p{Ll}\p{Lo}{0,62} * Values must conform to regexp: [\p{Ll}\p{Lo}\p{N}_-]{0,63} * Both keys and values are
        /// additionally constrained to be &amp;lt;= 128 bytes in size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that contains
        /// this job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The user-specified Cloud Dataflow job name. Only one Job with a given name may exist in a project at any
        /// given time. If a caller attempts to create a Job with the same name as an already-existing Job, the attempt
        /// returns the existing Job. The name must match the regular expression `[a-z]([-a-z0-9]{0,38}[a-z0-9])?`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Preliminary field: The format of this data may change at any time. A description of the user pipeline and
        /// stages through which it is executed. Created by Cloud Dataflow service. Only retrieved with
        /// JOB_VIEW_DESCRIPTION or JOB_VIEW_ALL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipelineDescription")]
        public virtual PipelineDescription PipelineDescription { get; set; }

        /// <summary>The ID of the Cloud Platform project that the job belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// If this job is an update of an existing job, this field is the job ID of the job it replaced. When sending a
        /// `CreateJobRequest`, you can update a job by specifying it here. The job named here is stopped, and its
        /// intermediate state is transferred to this job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceJobId")]
        public virtual string ReplaceJobId { get; set; }

        /// <summary>
        /// If another job is an update of this job (and thus, this job is in `JOB_STATE_UPDATED`), this field contains
        /// the ID of that job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacedByJobId")]
        public virtual string ReplacedByJobId { get; set; }

        /// <summary>
        /// The job's requested state. `UpdateJob` may be used to switch between the `JOB_STATE_STOPPED` and
        /// `JOB_STATE_RUNNING` states, by setting requested_state. `UpdateJob` may also be used to directly set a job's
        /// requested state to `JOB_STATE_CANCELLED` or `JOB_STATE_DONE`, irrevocably terminating the job if it has not
        /// already reached a terminal state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedState")]
        public virtual string RequestedState { get; set; }

        /// <summary>
        /// Reserved for future use. This field is set only in responses from the server; it is ignored if it is set in
        /// any requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>This field may be mutated by the Cloud Dataflow service; callers cannot mutate it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageStates")]
        public virtual System.Collections.Generic.IList<ExecutionStageState> StageStates { get; set; }

        /// <summary>
        /// The timestamp when the job was started (transitioned to JOB_STATE_PENDING). Flexible resource scheduling
        /// jobs are started with some delay after job creation, so start_time is unset before start and is updated when
        /// the job is started by the Cloud Dataflow service. For other jobs, start_time always equals to create_time
        /// and is immutable and set by the Cloud Dataflow service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>
        /// Exactly one of step or steps_location should be specified. The top-level steps that constitute the entire
        /// job. Only retrieved with JOB_VIEW_ALL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<Step> Steps { get; set; }

        /// <summary>The Cloud Storage location where the steps are stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepsLocation")]
        public virtual string StepsLocation { get; set; }

        /// <summary>
        /// A set of files the system should be aware of that are used for temporary storage. These temporary files will
        /// be removed on job completion. No duplicates are allowed. No file patterns are supported. The supported files
        /// are: Google Cloud Storage: storage.googleapis.com/{bucket}/{object} bucket.storage.googleapis.com/{object}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tempFiles")]
        public virtual System.Collections.Generic.IList<string> TempFiles { get; set; }

        /// <summary>
        /// The map of transform name prefixes of the job to be replaced to the corresponding name prefixes of the new
        /// job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformNameMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> TransformNameMapping { get; set; }

        /// <summary>The type of Cloud Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the execution of a job.</summary>
    public class JobExecutionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, this response does not contain all requested tasks. To obtain the next page of results, repeat
        /// the request with page_token set to this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The stages of the job execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stages")]
        public virtual System.Collections.Generic.IList<StageSummary> Stages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Additional information about how a Cloud Dataflow job will be executed that isn't contained in the submitted
    /// job.
    /// </summary>
    public class JobExecutionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A mapping from each stage to the information about that stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stages")]
        public virtual System.Collections.Generic.IDictionary<string, JobExecutionStageInfo> Stages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about how a particular google.dataflow.v1beta3.Step will be executed.</summary>
    public class JobExecutionStageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The steps associated with the execution stage. Note that stages may have several steps, and that a given
        /// step might be run by more than one stage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stepName")]
        public virtual System.Collections.Generic.IList<string> StepName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A particular message pertaining to a Dataflow job.</summary>
    public class JobMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Importance level of the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageImportance")]
        public virtual string MessageImportance { get; set; }

        /// <summary>The text of the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageText")]
        public virtual string MessageText { get; set; }

        /// <summary>The timestamp of the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual object Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata available primarily for filtering jobs. Will be included in the ListJob response and Job SUMMARY view.
    /// </summary>
    public class JobMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identification of a Cloud BigTable source used in the Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigTableDetails")]
        public virtual System.Collections.Generic.IList<BigTableIODetails> BigTableDetails { get; set; }

        /// <summary>Identification of a BigQuery source used in the Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDetails")]
        public virtual System.Collections.Generic.IList<BigQueryIODetails> BigqueryDetails { get; set; }

        /// <summary>Identification of a Datastore source used in the Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datastoreDetails")]
        public virtual System.Collections.Generic.IList<DatastoreIODetails> DatastoreDetails { get; set; }

        /// <summary>Identification of a File source used in the Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileDetails")]
        public virtual System.Collections.Generic.IList<FileIODetails> FileDetails { get; set; }

        /// <summary>Identification of a PubSub source used in the Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubDetails")]
        public virtual System.Collections.Generic.IList<PubSubIODetails> PubsubDetails { get; set; }

        /// <summary>The SDK version used to run the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersion")]
        public virtual SdkVersion SdkVersion { get; set; }

        /// <summary>Identification of a Spanner source used in the Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spannerDetails")]
        public virtual System.Collections.Generic.IList<SpannerIODetails> SpannerDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JobMetrics contains a collection of metrics describing the detailed progress of a Dataflow job. Metrics
    /// correspond to user-defined and system-defined metrics in the job. This resource captures only the most recent
    /// values of each metric; time-series data can be queried for them (under the same metric names) from Cloud
    /// Monitoring.
    /// </summary>
    public class JobMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp as of which metric values are current.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricTime")]
        public virtual object MetricTime { get; set; }

        /// <summary>All metrics for this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<MetricUpdate> Metrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data disk assignment information for a specific key-range of a sharded computation. Currently we only support
    /// UTF-8 character splits to simplify encoding into JSON.
    /// </summary>
    public class KeyRangeDataDiskAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the data disk where data for this range is stored. This name is local to the Google Cloud
        /// Platform project and uniquely identifies the disk within that project, for example
        /// "myproject-1014-104817-4c2-harness-0-disk-1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisk")]
        public virtual string DataDisk { get; set; }

        /// <summary>The end (exclusive) of the key range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual string End { get; set; }

        /// <summary>The start (inclusive) of the key range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual string Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Location information for a specific key-range of a sharded computation. Currently we only support UTF-8
    /// character splits to simplify encoding into JSON.
    /// </summary>
    public class KeyRangeLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the data disk where data for this range is stored. This name is local to the Google Cloud
        /// Platform project and uniquely identifies the disk within that project, for example
        /// "myproject-1014-104817-4c2-harness-0-disk-1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisk")]
        public virtual string DataDisk { get; set; }

        /// <summary>
        /// The physical location of this range assignment to be used for streaming computation cross-worker message
        /// delivery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryEndpoint")]
        public virtual string DeliveryEndpoint { get; set; }

        /// <summary>
        /// DEPRECATED. The location of the persistent state for this range, as a persistent directory in the worker
        /// local filesystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecatedPersistentDirectory")]
        public virtual string DeprecatedPersistentDirectory { get; set; }

        /// <summary>The end (exclusive) of the key range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual string End { get; set; }

        /// <summary>The start (inclusive) of the key range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual string Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Launch FlexTemplate Parameter.</summary>
    public class LaunchFlexTemplateParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Spec about the container image to launch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerSpec")]
        public virtual ContainerSpec ContainerSpec { get; set; }

        /// <summary>Cloud Storage path to a file with json serialized ContainerSpec as content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerSpecGcsPath")]
        public virtual string ContainerSpecGcsPath { get; set; }

        /// <summary>The runtime environment for the FlexTemplate job</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual FlexTemplateRuntimeEnvironment Environment { get; set; }

        /// <summary>
        /// Required. The job name to use for the created job. For update job request, job name should be same as the
        /// existing running job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobName")]
        public virtual string JobName { get; set; }

        /// <summary>
        /// Launch options for this flex template job. This is a common set of options across languages and templates.
        /// This should not be used to pass job parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchOptions")]
        public virtual System.Collections.Generic.IDictionary<string, string> LaunchOptions { get; set; }

        /// <summary>The parameters for FlexTemplate. Ex. {"num_workers":"5"}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Use this to pass transform_name_mappings for streaming update jobs.
        /// Ex:{"oldTransformName":"newTransformName",...}'
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

    /// <summary>A request to launch a Cloud Dataflow job from a FlexTemplate.</summary>
    public class LaunchFlexTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Parameter to launch a job form Flex Template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchParameter")]
        public virtual LaunchFlexTemplateParameter LaunchParameter { get; set; }

        /// <summary>If true, the request is validated but not actually executed. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to the request to launch a job from Flex Template.</summary>
    public class LaunchFlexTemplateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The job that was launched, if the request was not a dry run and the job was successfully launched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to provide to the template being launched.</summary>
    public class LaunchTemplateParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The runtime environment for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual RuntimeEnvironment Environment { get; set; }

        /// <summary>Required. The job name to use for the created job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobName")]
        public virtual string JobName { get; set; }

        /// <summary>The runtime parameters to pass to the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Only applicable when updating a pipeline. Map of transform name prefixes of the job to be replaced to the
        /// corresponding name prefixes of the new job.
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

    /// <summary>Response to the request to launch a template.</summary>
    public class LaunchTemplateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The job that was launched, if the request was not a dry run and the job was successfully launched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to lease WorkItems.</summary>
    public class LeaseWorkItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current timestamp at the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentWorkerTime")]
        public virtual object CurrentWorkerTime { get; set; }

        /// <summary>
        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that contains
        /// the WorkItem's job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The initial lease period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedLeaseDuration")]
        public virtual object RequestedLeaseDuration { get; set; }

        /// <summary>Untranslated bag-of-bytes WorkRequest from UnifiedWorker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unifiedWorkerRequest")]
        public virtual System.Collections.Generic.IDictionary<string, object> UnifiedWorkerRequest { get; set; }

        /// <summary>Filter for WorkItem type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workItemTypes")]
        public virtual System.Collections.Generic.IList<string> WorkItemTypes { get; set; }

        /// <summary>Worker capabilities. WorkItems might be limited to workers with specific capabilities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerCapabilities")]
        public virtual System.Collections.Generic.IList<string> WorkerCapabilities { get; set; }

        /// <summary>
        /// Identifies the worker leasing work -- typically the ID of the virtual machine running the worker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerId")]
        public virtual string WorkerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a request to lease WorkItems.</summary>
    public class LeaseWorkItemResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Untranslated bag-of-bytes WorkResponse for UnifiedWorker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unifiedWorkerResponse")]
        public virtual System.Collections.Generic.IDictionary<string, object> UnifiedWorkerResponse { get; set; }

        /// <summary>A list of the leased WorkItems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workItems")]
        public virtual System.Collections.Generic.IList<WorkItem> WorkItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a request to list job messages.</summary>
    public class ListJobMessagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Autoscaling events in ascending timestamp order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingEvents")]
        public virtual System.Collections.Generic.IList<AutoscalingEvent> AutoscalingEvents { get; set; }

        /// <summary>Messages in ascending timestamp order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobMessages")]
        public virtual System.Collections.Generic.IList<JobMessage> JobMessages { get; set; }

        /// <summary>The token to obtain the next page of results if there are more.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response to a request to list Cloud Dataflow jobs in a project. This might be a partial response, depending on
    /// the page size in the ListJobsRequest. However, if the project does not have any jobs, an instance of
    /// ListJobsResponse is not returned and the requests's response body is empty {}.
    /// </summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Zero or more messages describing the [regional endpoints]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that failed to respond.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedLocation")]
        public virtual System.Collections.Generic.IList<FailedLocation> FailedLocation { get; set; }

        /// <summary>A subset of the requested job information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<Job> Jobs { get; set; }

        /// <summary>Set if there may be more results than fit in this response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of snapshots.</summary>
    public class ListSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Returned snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshots")]
        public virtual System.Collections.Generic.IList<Snapshot> Snapshots { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MapTask consists of an ordered set of instructions, each of which describes one particular low-level operation
    /// for the worker to perform in order to accomplish the MapTask's WorkItem. Each instruction must appear in the
    /// list before any instructions which depends on its output.
    /// </summary>
    public class MapTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Counter prefix that can be used to prefix counters. Not currently used in Dataflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counterPrefix")]
        public virtual string CounterPrefix { get; set; }

        /// <summary>The instructions in the MapTask.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructions")]
        public virtual System.Collections.Generic.IList<ParallelInstruction> Instructions { get; set; }

        /// <summary>System-defined name of the stage containing this MapTask. Unique across the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageName")]
        public virtual string StageName { get; set; }

        /// <summary>System-defined name of this MapTask. Unique across the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemName")]
        public virtual string SystemName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the memory usage of a worker or a container within a worker.</summary>
    public class MemInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Instantenous memory limit in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentLimitBytes")]
        public virtual System.Nullable<ulong> CurrentLimitBytes { get; set; }

        /// <summary>Instantenous memory (RSS) size in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentRssBytes")]
        public virtual System.Nullable<ulong> CurrentRssBytes { get; set; }

        /// <summary>Timestamp of the measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>Total memory (RSS) usage since start up in GB * ms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalGbMs")]
        public virtual System.Nullable<ulong> TotalGbMs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The metric short id is returned to the user alongside an offset into ReportWorkItemStatusRequest
    /// </summary>
    public class MetricShortId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The index of the corresponding metric in the ReportWorkItemStatusRequest. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricIndex")]
        public virtual System.Nullable<int> MetricIndex { get; set; }

        /// <summary>The service-generated short identifier for the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortId")]
        public virtual System.Nullable<long> ShortId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies a metric, by describing the source which generated the metric.</summary>
    public class MetricStructuredName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Zero or more labeled fields which identify the part of the job this metric is associated with, such as the
        /// name of a step or collection. For example, built-in counters associated with steps will have context['step']
        /// = . Counters associated with PCollections in the SDK will have context['pcollection'] = .
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual System.Collections.Generic.IDictionary<string, string> Context { get; set; }

        /// <summary>Worker-defined metric name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Origin (namespace) of metric name. May be blank for user-define metrics; will be "dataflow" for metrics
        /// defined by the Dataflow service or SDK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the state of a metric.</summary>
    public class MetricUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if this metric is reported as the total cumulative aggregate value accumulated since the worker started
        /// working on this WorkItem. By default this is false, indicating that this metric is reported as a delta that
        /// is not associated with any WorkItem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cumulative")]
        public virtual System.Nullable<bool> Cumulative { get; set; }

        /// <summary>A struct value describing properties of a distribution of numeric values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distribution")]
        public virtual object Distribution { get; set; }

        /// <summary>
        /// A struct value describing properties of a Gauge. Metrics of gauge type show the value of a metric across
        /// time, and is aggregated based on the newest value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gauge")]
        public virtual object Gauge { get; set; }

        /// <summary>Worker-computed aggregate value for internal use by the Dataflow service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internal")]
        public virtual object Internal__ { get; set; }

        /// <summary>
        /// Metric aggregation kind. The possible metric aggregation kinds are "Sum", "Max", "Min", "Mean", "Set",
        /// "And", "Or", and "Distribution". The specified aggregation kind is case-insensitive. If omitted, this is not
        /// an aggregated value but instead a single metric sample value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Worker-computed aggregate value for the "Mean" aggregation kind. This holds the count of the aggregated
        /// values and is used in combination with mean_sum above to obtain the actual mean aggregate value. The only
        /// possible value type is Long.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanCount")]
        public virtual object MeanCount { get; set; }

        /// <summary>
        /// Worker-computed aggregate value for the "Mean" aggregation kind. This holds the sum of the aggregated values
        /// and is used in combination with mean_count below to obtain the actual mean aggregate value. The only
        /// possible value types are Long and Double.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meanSum")]
        public virtual object MeanSum { get; set; }

        /// <summary>Name of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual MetricStructuredName Name { get; set; }

        /// <summary>
        /// Worker-computed aggregate value for aggregation kinds "Sum", "Max", "Min", "And", and "Or". The possible
        /// value types are Long, Double, and Boolean.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalar")]
        public virtual object Scalar { get; set; }

        /// <summary>
        /// Worker-computed aggregate value for the "Set" aggregation kind. The only possible value type is a list of
        /// Values whose type can be Long, Double, or String, according to the metric's type. All Values in the list
        /// must be of the same type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("set")]
        public virtual object Set { get; set; }

        /// <summary>
        /// Timestamp associated with the metric value. Optional when workers are reporting work progress; it will be
        /// filled in responses from the metrics API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes mounted data disk.</summary>
    public class MountedDataDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the data disk. This name is local to the Google Cloud Platform project and uniquely identifies
        /// the disk within that project, for example "myproject-1014-104817-4c2-harness-0-disk-1".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisk")]
        public virtual string DataDisk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an output of a multi-output DoFn.</summary>
    public class MultiOutputInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The id of the tag the user code will emit to this output by; this should correspond to the tag of some
        /// SideInputInfo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Basic metadata about a counter.</summary>
    public class NameAndKind : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Counter aggregation kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of the counter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The packages that must be installed in order for a worker to run the steps of the Cloud Dataflow job that will
    /// be assigned to its worker pool. This is the mechanism by which the Cloud Dataflow SDK causes code to be loaded
    /// onto the workers. For example, the Cloud Dataflow Java SDK might use this to install jars containing the user's
    /// code and all of the various dependencies (libraries, data files, etc.) required in order for that code to run.
    /// </summary>
    public class Package : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource to read the package from. The supported resource type is: Google Cloud Storage:
        /// storage.googleapis.com/{bucket} bucket.storage.googleapis.com/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The name of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An instruction that does a ParDo operation. Takes one main input and zero or more side inputs, and produces zero
    /// or more outputs. Runs user code.
    /// </summary>
    public class ParDoInstruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual InstructionInput Input { get; set; }

        /// <summary>Information about each of the outputs, if user_fn is a MultiDoFn.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiOutputInfos")]
        public virtual System.Collections.Generic.IList<MultiOutputInfo> MultiOutputInfos { get; set; }

        /// <summary>The number of outputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numOutputs")]
        public virtual System.Nullable<int> NumOutputs { get; set; }

        /// <summary>Zero or more side inputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sideInputs")]
        public virtual System.Collections.Generic.IList<SideInputInfo> SideInputs { get; set; }

        /// <summary>The user function to invoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userFn")]
        public virtual System.Collections.Generic.IDictionary<string, object> UserFn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a particular operation comprising a MapTask.</summary>
    public class ParallelInstruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional information for Flatten instructions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flatten")]
        public virtual FlattenInstruction Flatten { get; set; }

        /// <summary>User-provided name of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>System-defined name for the operation in the original workflow graph.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalName")]
        public virtual string OriginalName { get; set; }

        /// <summary>Describes the outputs of the instruction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual System.Collections.Generic.IList<InstructionOutput> Outputs { get; set; }

        /// <summary>Additional information for ParDo instructions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parDo")]
        public virtual ParDoInstruction ParDo { get; set; }

        /// <summary>Additional information for PartialGroupByKey instructions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialGroupByKey")]
        public virtual PartialGroupByKeyInstruction PartialGroupByKey { get; set; }

        /// <summary>Additional information for Read instructions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("read")]
        public virtual ReadInstruction Read { get; set; }

        /// <summary>System-defined name of this operation. Unique across the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemName")]
        public virtual string SystemName { get; set; }

        /// <summary>Additional information for Write instructions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("write")]
        public virtual WriteInstruction Write { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured data associated with this message.</summary>
    public class Parameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key or name for this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value for this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a specific parameter.</summary>
    public class ParameterMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Additional metadata for describing this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomMetadata { get; set; }

        /// <summary>Required. The help text to display for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpText")]
        public virtual string HelpText { get; set; }

        /// <summary>Optional. Whether the parameter is optional. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isOptional")]
        public virtual System.Nullable<bool> IsOptional { get; set; }

        /// <summary>Required. The label to display for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Required. The name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The type of the parameter. Used for selecting input picker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paramType")]
        public virtual string ParamType { get; set; }

        /// <summary>Optional. Regexes that the parameter must match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexes")]
        public virtual System.Collections.Generic.IList<string> Regexes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instruction that does a partial group-by-key. One input and one output.</summary>
    public class PartialGroupByKeyInstruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes the input to the partial group-by-key instruction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual InstructionInput Input { get; set; }

        /// <summary>The codec to use for interpreting an element in the input PTable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputElementCodec")]
        public virtual System.Collections.Generic.IDictionary<string, object> InputElementCodec { get; set; }

        /// <summary>
        /// If this instruction includes a combining function this is the name of the intermediate store between the GBK
        /// and the CombineValues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalCombineValuesInputStoreName")]
        public virtual string OriginalCombineValuesInputStoreName { get; set; }

        /// <summary>
        /// If this instruction includes a combining function, this is the name of the CombineValues instruction lifted
        /// into this instruction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalCombineValuesStepName")]
        public virtual string OriginalCombineValuesStepName { get; set; }

        /// <summary>Zero or more side inputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sideInputs")]
        public virtual System.Collections.Generic.IList<SideInputInfo> SideInputs { get; set; }

        /// <summary>The value combining function to invoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueCombiningFn")]
        public virtual System.Collections.Generic.IDictionary<string, object> ValueCombiningFn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A descriptive representation of submitted pipeline as well as the executed form. This data is provided by the
    /// Dataflow service for ease of visualizing the pipeline and interpreting Dataflow provided metrics.
    /// </summary>
    public class PipelineDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pipeline level display data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayData")]
        public virtual System.Collections.Generic.IList<DisplayData> DisplayData { get; set; }

        /// <summary>Description of each stage of execution of the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionPipelineStage")]
        public virtual System.Collections.Generic.IList<ExecutionStageSummary> ExecutionPipelineStage { get; set; }

        /// <summary>Description of each transform in the pipeline and collections between them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPipelineTransform")]
        public virtual System.Collections.Generic.IList<TransformSummary> OriginalPipelineTransform { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A point in the timeseries.</summary>
    public class Point : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp of the point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual object Time { get; set; }

        /// <summary>The value of the point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Position defines a position within a collection of data. The value can be either the end position, a key (used
    /// with ordered collections), a byte offset, or a record index.
    /// </summary>
    public class Position : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Position is a byte offset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byteOffset")]
        public virtual System.Nullable<long> ByteOffset { get; set; }

        /// <summary>CloudPosition is a concat position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concatPosition")]
        public virtual ConcatPosition ConcatPosition { get; set; }

        /// <summary>
        /// Position is past all other positions. Also useful for the end position of an unbounded range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<bool> End { get; set; }

        /// <summary>Position is a string key, ordered lexicographically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Position is a record index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordIndex")]
        public virtual System.Nullable<long> RecordIndex { get; set; }

        /// <summary>CloudPosition is a base64 encoded BatchShufflePosition (with FIXED sharding).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shufflePosition")]
        public virtual string ShufflePosition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the progress of some component of job execution.</summary>
    public class ProgressTimeseries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current progress of the component, in the range [0,1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentProgress")]
        public virtual System.Nullable<double> CurrentProgress { get; set; }

        /// <summary>History of progress for the component. Points are sorted by time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPoints")]
        public virtual System.Collections.Generic.IList<Point> DataPoints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a Pub/Sub connector used by the job.</summary>
    public class PubSubIODetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Subscription used in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>Topic accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a pubsub location to use for transferring data into or out of a streaming Dataflow job.
    /// </summary>
    public class PubsubLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the pipeline allows late-arriving data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dropLateData")]
        public virtual System.Nullable<bool> DropLateData { get; set; }

        /// <summary>
        /// If set, contains a pubsub label from which to extract record ids. If left empty, record deduplication will
        /// be strictly best effort.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idLabel")]
        public virtual string IdLabel { get; set; }

        /// <summary>A pubsub subscription, in the form of "pubsub.googleapis.com/subscriptions//"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>
        /// If set, contains a pubsub label from which to extract record timestamps. If left empty, record timestamps
        /// will be generated upon arrival.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampLabel")]
        public virtual string TimestampLabel { get; set; }

        /// <summary>A pubsub topic, in the form of "pubsub.googleapis.com/topics//"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>
        /// If set, specifies the pubsub subscription that will be used for tracking custom time timestamps for
        /// watermark estimation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trackingSubscription")]
        public virtual string TrackingSubscription { get; set; }

        /// <summary>If true, then the client has requested to get pubsub attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("withAttributes")]
        public virtual System.Nullable<bool> WithAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Pubsub snapshot.</summary>
    public class PubsubSnapshotMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The expire time of the Pubsub snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The name of the Pubsub snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotName")]
        public virtual string SnapshotName { get; set; }

        /// <summary>The name of the Pubsub topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a validated query.</summary>
    public class QueryInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Includes an entry for each satisfied QueryProperty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryProperty")]
        public virtual System.Collections.Generic.IList<string> QueryProperty { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instruction that reads records. Takes no inputs, produces one output.</summary>
    public class ReadInstruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source to read from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to report the status of WorkItems.</summary>
    public class ReportWorkItemStatusRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current timestamp at the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentWorkerTime")]
        public virtual object CurrentWorkerTime { get; set; }

        /// <summary>
        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that contains
        /// the WorkItem's job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Untranslated bag-of-bytes WorkProgressUpdateRequest from UnifiedWorker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unifiedWorkerRequest")]
        public virtual System.Collections.Generic.IDictionary<string, object> UnifiedWorkerRequest { get; set; }

        /// <summary>
        /// The order is unimportant, except that the order of the WorkItemServiceState messages in the
        /// ReportWorkItemStatusResponse corresponds to the order of WorkItemStatus messages here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workItemStatuses")]
        public virtual System.Collections.Generic.IList<WorkItemStatus> WorkItemStatuses { get; set; }

        /// <summary>
        /// The ID of the worker reporting the WorkItem status. If this does not match the ID of the worker which the
        /// Dataflow service believes currently has the lease on the WorkItem, the report will be dropped (with an error
        /// response).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerId")]
        public virtual string WorkerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response from a request to report the status of WorkItems.</summary>
    public class ReportWorkItemStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Untranslated bag-of-bytes WorkProgressUpdateResponse for UnifiedWorker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unifiedWorkerResponse")]
        public virtual System.Collections.Generic.IDictionary<string, object> UnifiedWorkerResponse { get; set; }

        /// <summary>
        /// A set of messages indicating the service-side state for each WorkItem whose status was reported, in the same
        /// order as the WorkItemStatus messages in the ReportWorkItemStatusRequest which resulting in this response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workItemServiceStates")]
        public virtual System.Collections.Generic.IList<WorkItemServiceState> WorkItemServiceStates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the level of parallelism in a WorkItem's input, reported by the worker.</summary>
    public class ReportedParallelism : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies whether the parallelism is infinite. If true, "value" is ignored. Infinite parallelism means the
        /// service will assume that the work item can always be split into more non-empty work items by dynamic
        /// splitting. This is a work-around for lack of support for infinity by the current JSON-based Java RPC stack.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInfinite")]
        public virtual System.Nullable<bool> IsInfinite { get; set; }

        /// <summary>Specifies the level of parallelism in case it is finite.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Worker metrics exported from workers. This contains resource utilization metrics accumulated from a variety of
    /// sources. For more information, see go/df-resource-signals.
    /// </summary>
    public class ResourceUtilizationReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Per container information. Key: container name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IDictionary<string, ResourceUtilizationReport> Containers { get; set; }

        /// <summary>CPU utilization samples.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuTime")]
        public virtual System.Collections.Generic.IList<CPUTime> CpuTime { get; set; }

        /// <summary>Memory utilization samples.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryInfo")]
        public virtual System.Collections.Generic.IList<MemInfo> MemoryInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Service-side response to WorkerMessage reporting resource utilization.</summary>
    public class ResourceUtilizationReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The environment values to set at runtime.</summary>
    public class RuntimeEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional experiment flags for the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalExperiments")]
        public virtual System.Collections.Generic.IList<string> AdditionalExperiments { get; set; }

        /// <summary>
        /// Additional user labels to be specified for the job. Keys and values should follow the restrictions specified
        /// in the [labeling restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions) page.
        /// An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1kg", "count": "3"
        /// }.
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
        /// The maximum number of Google Compute Engine instances to be made available to your pipeline during
        /// execution, from 1 to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWorkers")]
        public virtual System.Nullable<int> MaxWorkers { get; set; }

        /// <summary>
        /// Network to which VMs will be assigned. If empty or unspecified, the service will use the network "default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>The initial number of Google Compute Engine instnaces for the job.</summary>
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

    /// <summary>RuntimeMetadata describing a runtime environment.</summary>
    public class RuntimeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The parameters for the template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<ParameterMetadata> Parameters { get; set; }

        /// <summary>SDK Info for the template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkInfo")]
        public virtual SDKInfo SdkInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SDK Information.</summary>
    public class SDKInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The SDK Language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>Optional. The SDK version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a SDK harness container for executing Dataflow pipelines.</summary>
    public class SdkHarnessContainerImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A docker container image that resides in Google Container Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerImage")]
        public virtual string ContainerImage { get; set; }

        /// <summary>
        /// Environment ID for the Beam runner API proto Environment that corresponds to the current SDK Harness.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentId")]
        public virtual string EnvironmentId { get; set; }

        /// <summary>
        /// If true, recommends the Dataflow service to use only one core per SDK container instance with this image. If
        /// false (or unset) recommends using more than one core per SDK container instance with this image for
        /// efficiency. Note that Dataflow service may choose to override this property if needed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSingleCorePerContainer")]
        public virtual System.Nullable<bool> UseSingleCorePerContainer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The version of the SDK used to run the job.</summary>
    public class SdkVersion : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Request to send encoded debug information.</summary>
    public class SendDebugCaptureRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The internal component id for which debug information is sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentId")]
        public virtual string ComponentId { get; set; }

        /// <summary>The encoded debug information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that contains
        /// the job specified by job_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The worker id, i.e., VM hostname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerId")]
        public virtual string WorkerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a send capture request. nothing</summary>
    public class SendDebugCaptureResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request for sending worker messages to the service.</summary>
    public class SendWorkerMessagesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [regional endpoint] (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints) that contains
        /// the job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The WorkerMessages to send.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerMessages")]
        public virtual System.Collections.Generic.IList<WorkerMessage> WorkerMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to the worker messages.</summary>
    public class SendWorkerMessagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The servers response to the worker messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerMessageResponses")]
        public virtual System.Collections.Generic.IList<WorkerMessageResponse> WorkerMessageResponses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a particular function to invoke.</summary>
    public class SeqMapTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about each of the inputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<SideInputInfo> Inputs { get; set; }

        /// <summary>The user-provided name of the SeqDo operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Information about each of the outputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputInfos")]
        public virtual System.Collections.Generic.IList<SeqMapTaskOutputInfo> OutputInfos { get; set; }

        /// <summary>
        /// System-defined name of the stage containing the SeqDo operation. Unique across the workflow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageName")]
        public virtual string StageName { get; set; }

        /// <summary>System-defined name of the SeqDo operation. Unique across the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemName")]
        public virtual string SystemName { get; set; }

        /// <summary>The user function to invoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userFn")]
        public virtual System.Collections.Generic.IDictionary<string, object> UserFn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an output of a SeqMapTask.</summary>
    public class SeqMapTaskOutputInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sink to write the output value to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sink")]
        public virtual Sink Sink { get; set; }

        /// <summary>The id of the TupleTag the user code will tag the output value by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A task which consists of a shell command for the worker to execute.</summary>
    public class ShellTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The shell command to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual string Command { get; set; }

        /// <summary>Exit code for the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a side input of a DoFn or an input of a SeqDoFn.</summary>
    public class SideInputInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How to interpret the source element(s) as a side input value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual System.Collections.Generic.IDictionary<string, object> Kind { get; set; }

        /// <summary>
        /// The source(s) to read element(s) from to get the value of this side input. If more than one source, then the
        /// elements are taken from the sources, in the specified order if order matters. At least one source is
        /// required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<Source> Sources { get; set; }

        /// <summary>
        /// The id of the tag the user code will access this side input by; this should correspond to the tag of some
        /// MultiOutputInfo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A sink that records can be encoded and written to.</summary>
    public class Sink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The codec to use to encode data written to the sink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codec")]
        public virtual System.Collections.Generic.IDictionary<string, object> Codec { get; set; }

        /// <summary>The sink to write to, plus its parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual System.Collections.Generic.IDictionary<string, object> Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a snapshot of a job.</summary>
    public class Snapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time this snapshot was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>User specified description of the snapshot. Maybe empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The disk byte size of the snapshot. Only available for snapshots in READY state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeBytes")]
        public virtual System.Nullable<long> DiskSizeBytes { get; set; }

        /// <summary>The unique ID of this snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The project this snapshot belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>PubSub snapshot metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubMetadata")]
        public virtual System.Collections.Generic.IList<PubsubSnapshotMetadata> PubsubMetadata { get; set; }

        /// <summary>Cloud region where this snapshot lives in, e.g., "us-central1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The job this snapshot was created from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceJobId")]
        public virtual string SourceJobId { get; set; }

        /// <summary>State of the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time after which this snapshot will be automatically deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a snapshot of a job.</summary>
    public class SnapshotJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User specified description of the snapshot. Maybe empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The location that contains this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>If true, perform snapshots for sources which support this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotSources")]
        public virtual System.Nullable<bool> SnapshotSources { get; set; }

        /// <summary>TTL for the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A source that records can be read and decoded from.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// While splitting, sources may specify the produced bundles as differences against another source, in order to
        /// save backend-side memory and allow bigger jobs. For details, see SourceSplitRequest. To support this use
        /// case, the full set of parameters of the source is logically obtained by taking the latest explicitly
        /// specified value of each parameter in the order: base_specs (later items win), spec (overrides anything in
        /// base_specs).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseSpecs")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> BaseSpecs { get; set; }

        /// <summary>The codec to use to decode data read from the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codec")]
        public virtual System.Collections.Generic.IDictionary<string, object> Codec { get; set; }

        /// <summary>
        /// Setting this value to true hints to the framework that the source doesn't need splitting, and using
        /// SourceSplitRequest on it would yield SOURCE_SPLIT_OUTCOME_USE_CURRENT. E.g. a file splitter may set this to
        /// true when splitting a single file into a set of byte ranges of appropriate size, and set this to false when
        /// splitting a filepattern into individual files. However, for efficiency, a file splitter may decide to
        /// produce file subranges directly from the filepattern to avoid a splitting round-trip. See SourceSplitRequest
        /// for an overview of the splitting process. This field is meaningful only in the Source objects populated by
        /// the user (e.g. when filling in a DerivedSource). Source objects supplied by the framework to the user don't
        /// have this field populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doesNotNeedSplitting")]
        public virtual System.Nullable<bool> DoesNotNeedSplitting { get; set; }

        /// <summary>
        /// Optionally, metadata for this source can be supplied right away, avoiding a SourceGetMetadataOperation
        /// roundtrip (see SourceOperationRequest). This field is meaningful only in the Source objects populated by the
        /// user (e.g. when filling in a DerivedSource). Source objects supplied by the framework to the user don't have
        /// this field populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual SourceMetadata Metadata { get; set; }

        /// <summary>The source to read from, plus its parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual System.Collections.Generic.IDictionary<string, object> Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DEPRECATED in favor of DynamicSourceSplit.</summary>
    public class SourceFork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DEPRECATED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual SourceSplitShard Primary { get; set; }

        /// <summary>DEPRECATED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primarySource")]
        public virtual DerivedSource PrimarySource { get; set; }

        /// <summary>DEPRECATED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("residual")]
        public virtual SourceSplitShard Residual { get; set; }

        /// <summary>DEPRECATED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("residualSource")]
        public virtual DerivedSource ResidualSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to compute the SourceMetadata of a Source.</summary>
    public class SourceGetMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specification of the source whose metadata should be computed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a SourceGetMetadataOperation.</summary>
    public class SourceGetMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The computed metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual SourceMetadata Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a Source useful for automatically optimizing and tuning the pipeline, etc.</summary>
    public class SourceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An estimate of the total size (in bytes) of the data that would be read from this source. This estimate is
        /// in terms of external storage size, before any decompression or other processing done by the reader.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedSizeBytes")]
        public virtual System.Nullable<long> EstimatedSizeBytes { get; set; }

        /// <summary>
        /// Specifies that the size of this source is known to be infinite (this is a streaming source).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infinite")]
        public virtual System.Nullable<bool> Infinite { get; set; }

        /// <summary>
        /// Whether this source is known to produce key/value pairs with the (encoded) keys in lexicographically sorted
        /// order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producesSortedKeys")]
        public virtual System.Nullable<bool> ProducesSortedKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A work item that represents the different operations that can be performed on a user-defined Source
    /// specification.
    /// </summary>
    public class SourceOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about a request to get metadata about a source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("getMetadata")]
        public virtual SourceGetMetadataRequest GetMetadata { get; set; }

        /// <summary>User-provided name of the Read instruction for this source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// System-defined name for the Read instruction for this source in the original workflow graph.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalName")]
        public virtual string OriginalName { get; set; }

        /// <summary>Information about a request to split a source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("split")]
        public virtual SourceSplitRequest Split { get; set; }

        /// <summary>
        /// System-defined name of the stage containing the source operation. Unique across the workflow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageName")]
        public virtual string StageName { get; set; }

        /// <summary>System-defined name of the Read instruction for this source. Unique across the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemName")]
        public virtual string SystemName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The result of a SourceOperationRequest, specified in ReportWorkItemStatusRequest.source_operation when the work
    /// item is completed.
    /// </summary>
    public class SourceOperationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A response to a request to get metadata about a source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("getMetadata")]
        public virtual SourceGetMetadataResponse GetMetadata { get; set; }

        /// <summary>A response to a request to split a source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("split")]
        public virtual SourceSplitResponse Split { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Hints for splitting a Source into bundles (parts for parallel processing) using SourceSplitRequest.
    /// </summary>
    public class SourceSplitOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The source should be split into a set of bundles where the estimated size of each is approximately this many
        /// bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredBundleSizeBytes")]
        public virtual System.Nullable<long> DesiredBundleSizeBytes { get; set; }

        /// <summary>DEPRECATED in favor of desired_bundle_size_bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredShardSizeBytes")]
        public virtual System.Nullable<long> DesiredShardSizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the operation to split a high-level Source specification into bundles (parts for parallel
    /// processing). At a high level, splitting of a source into bundles happens as follows: SourceSplitRequest is
    /// applied to the source. If it returns SOURCE_SPLIT_OUTCOME_USE_CURRENT, no further splitting happens and the
    /// source is used "as is". Otherwise, splitting is applied recursively to each produced DerivedSource. As an
    /// optimization, for any Source, if its does_not_need_splitting is true, the framework assumes that splitting this
    /// source would return SOURCE_SPLIT_OUTCOME_USE_CURRENT, and doesn't initiate a SourceSplitRequest. This applies
    /// both to the initial source being split and to bundles produced from it.
    /// </summary>
    public class SourceSplitRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hints for tuning the splitting process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual SourceSplitOptions Options { get; set; }

        /// <summary>Specification of the source to be split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a SourceSplitRequest.</summary>
    public class SourceSplitResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If outcome is SPLITTING_HAPPENED, then this is a list of bundles into which the source was split. Otherwise
        /// this field is ignored. This list can be empty, which means the source represents an empty input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundles")]
        public virtual System.Collections.Generic.IList<DerivedSource> Bundles { get; set; }

        /// <summary>
        /// Indicates whether splitting happened and produced a list of bundles. If this is USE_CURRENT_SOURCE_AS_IS,
        /// the current source should be processed "as is" without splitting. "bundles" is ignored in this case. If this
        /// is SPLITTING_HAPPENED, then "bundles" contains a list of bundles into which the source was split.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outcome")]
        public virtual string Outcome { get; set; }

        /// <summary>DEPRECATED in favor of bundles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shards")]
        public virtual System.Collections.Generic.IList<SourceSplitShard> Shards { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DEPRECATED in favor of DerivedSource.</summary>
    public class SourceSplitShard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DEPRECATED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("derivationMode")]
        public virtual string DerivationMode { get; set; }

        /// <summary>DEPRECATED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a Spanner connector used by the job.</summary>
    public class SpannerIODetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DatabaseId accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseId")]
        public virtual string DatabaseId { get; set; }

        /// <summary>InstanceId accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceId")]
        public virtual string InstanceId { get; set; }

        /// <summary>ProjectId accessed in the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of an int64, n, that is immune to precision loss when encoded in JSON.</summary>
    public class SplitInt64 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The high order bits, including the sign: n &gt;&gt; 32.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highBits")]
        public virtual System.Nullable<int> HighBits { get; set; }

        /// <summary>The low order bits: n &amp; 0xffffffff.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowBits")]
        public virtual System.Nullable<long> LowBits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the workers and work items within a stage.</summary>
    public class StageExecutionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, this response does not contain all requested tasks. To obtain the next page of results, repeat
        /// the request with page_token set to this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Workers that have done work on the stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workers")]
        public virtual System.Collections.Generic.IList<WorkerDetails> Workers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of an input or output of an execution stage.</summary>
    public class StageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dataflow service generated name for this source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// User name for the original user transform or collection with which this source is most closely associated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalTransformOrCollection")]
        public virtual string OriginalTransformOrCollection { get; set; }

        /// <summary>Size of the source, if measurable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>Human-readable name for this source; may be user or system generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a particular execution stage of a job.</summary>
    public class StageSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// End time of this stage. If the work item is completed, this is the actual end time of the stage. Otherwise,
        /// it is the predicted end time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Metrics for this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<MetricUpdate> Metrics { get; set; }

        /// <summary>Progress for this stage. Only applicable to Batch jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual ProgressTimeseries Progress { get; set; }

        /// <summary>ID of this stage</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageId")]
        public virtual string StageId { get; set; }

        /// <summary>Start time of this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>State of this stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>State family configuration.</summary>
    public class StateFamilyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, this family corresponds to a read operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRead")]
        public virtual System.Nullable<bool> IsRead { get; set; }

        /// <summary>The state family value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateFamily")]
        public virtual string StateFamily { get; set; }

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
    /// Defines a particular step within a Cloud Dataflow job. A job consists of multiple steps, each of which performs
    /// some specific operation as part of the overall job. Data is typically passed from one step to another as part of
    /// the job. Here's an example of a sequence of steps which together implement a Map-Reduce job: * Read a collection
    /// of data from some source, parsing the collection's elements. * Validate the elements. * Apply a user-defined
    /// function to map each element to some value and extract an element-specific key value. * Group elements with the
    /// same key into a single element with that key, transforming a multiply-keyed collection into a uniquely-keyed
    /// collection. * Write the elements out to some data sink. Note that the Cloud Dataflow service may be used to run
    /// many different types of jobs, not just Map-Reduce.
    /// </summary>
    public class Step : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of step in the Cloud Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The name that identifies the step. This must be unique for each step with respect to all other steps in the
        /// Cloud Dataflow job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Named properties associated with the step. Each kind of predefined step has its own required set of
        /// properties. Must be provided on Create. Only retrieved with JOB_VIEW_ALL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, object> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a stream of data, either as input to be processed or as output of a streaming Dataflow job.
    /// </summary>
    public class StreamLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stream is a custom source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSourceLocation")]
        public virtual CustomSourceLocation CustomSourceLocation { get; set; }

        /// <summary>The stream is a pubsub stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubLocation")]
        public virtual PubsubLocation PubsubLocation { get; set; }

        /// <summary>The stream is a streaming side input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sideInputLocation")]
        public virtual StreamingSideInputLocation SideInputLocation { get; set; }

        /// <summary>The stream is part of another computation within the current streaming Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingStageLocation")]
        public virtual StreamingStageLocation StreamingStageLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Streaming appliance snapshot configuration.</summary>
    public class StreamingApplianceSnapshotConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates which endpoint is used to import appliance state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importStateEndpoint")]
        public virtual string ImportStateEndpoint { get; set; }

        /// <summary>If set, indicates the snapshot id for the snapshot being performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotId")]
        public virtual string SnapshotId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration information for a single streaming computation.</summary>
    public class StreamingComputationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier for this computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computationId")]
        public virtual string ComputationId { get; set; }

        /// <summary>Instructions that comprise the computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instructions")]
        public virtual System.Collections.Generic.IList<ParallelInstruction> Instructions { get; set; }

        /// <summary>Stage name of this computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stageName")]
        public virtual string StageName { get; set; }

        /// <summary>System defined name for this computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemName")]
        public virtual string SystemName { get; set; }

        /// <summary>Map from user name of stateful transforms in this stage to their state family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformUserNameToStateFamily")]
        public virtual System.Collections.Generic.IDictionary<string, string> TransformUserNameToStateFamily { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes full or partial data disk assignment information of the computation ranges.</summary>
    public class StreamingComputationRanges : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computationId")]
        public virtual string ComputationId { get; set; }

        /// <summary>Data disk assignments for ranges from this computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rangeAssignments")]
        public virtual System.Collections.Generic.IList<KeyRangeDataDiskAssignment> RangeAssignments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A task which describes what action should be performed for the specified streaming computation ranges.
    /// </summary>
    public class StreamingComputationTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains ranges of a streaming computation this task should apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computationRanges")]
        public virtual System.Collections.Generic.IList<StreamingComputationRanges> ComputationRanges { get; set; }

        /// <summary>Describes the set of data disks this task should apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisks")]
        public virtual System.Collections.Generic.IList<MountedDataDisk> DataDisks { get; set; }

        /// <summary>A type of streaming computation task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskType")]
        public virtual string TaskType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A task that carries configuration information for streaming computations.</summary>
    public class StreamingConfigTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Chunk size for commit streams from the harness to windmill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitStreamChunkSizeBytes")]
        public virtual System.Nullable<long> CommitStreamChunkSizeBytes { get; set; }

        /// <summary>Chunk size for get data streams from the harness to windmill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("getDataStreamChunkSizeBytes")]
        public virtual System.Nullable<long> GetDataStreamChunkSizeBytes { get; set; }

        /// <summary>Maximum size for work item commit supported windmill storage layer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxWorkItemCommitBytes")]
        public virtual System.Nullable<long> MaxWorkItemCommitBytes { get; set; }

        /// <summary>Set of computation configuration information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingComputationConfigs")]
        public virtual System.Collections.Generic.IList<StreamingComputationConfig> StreamingComputationConfigs { get; set; }

        /// <summary>Map from user step names to state families.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userStepToStateFamilyNameMap")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserStepToStateFamilyNameMap { get; set; }

        /// <summary>
        /// If present, the worker must use this endpoint to communicate with Windmill Service dispatchers, otherwise
        /// the worker must continue to use whatever endpoint it had been using.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windmillServiceEndpoint")]
        public virtual string WindmillServiceEndpoint { get; set; }

        /// <summary>
        /// If present, the worker must use this port to communicate with Windmill Service dispatchers. Only applicable
        /// when windmill_service_endpoint is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windmillServicePort")]
        public virtual System.Nullable<long> WindmillServicePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A task which initializes part of a streaming Dataflow job.</summary>
    public class StreamingSetupTask : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user has requested drain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drain")]
        public virtual System.Nullable<bool> Drain { get; set; }

        /// <summary>
        /// The TCP port on which the worker should listen for messages from other streaming computation workers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receiveWorkPort")]
        public virtual System.Nullable<int> ReceiveWorkPort { get; set; }

        /// <summary>Configures streaming appliance snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotConfig")]
        public virtual StreamingApplianceSnapshotConfig SnapshotConfig { get; set; }

        /// <summary>The global topology of the streaming Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingComputationTopology")]
        public virtual TopologyConfig StreamingComputationTopology { get; set; }

        /// <summary>The TCP port used by the worker to communicate with the Dataflow worker harness.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerHarnessPort")]
        public virtual System.Nullable<int> WorkerHarnessPort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies the location of a streaming side input.</summary>
    public class StreamingSideInputLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies the state family where this side input is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateFamily")]
        public virtual string StateFamily { get; set; }

        /// <summary>Identifies the particular side input within the streaming Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies the location of a streaming computation stage, for stage-to-stage communication.</summary>
    public class StreamingStageLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies the particular stream within the streaming Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamId")]
        public virtual string StreamId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A metric value representing a list of strings.</summary>
    public class StringList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Elements of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elements")]
        public virtual System.Collections.Generic.IList<string> Elements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A rich message format, including a human readable string, a key for identifying the message, and structured data
    /// associated with the message for programmatic consumption.
    /// </summary>
    public class StructuredMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier for this message type. Used by external systems to internationalize or personalize message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageKey")]
        public virtual string MessageKey { get; set; }

        /// <summary>Human-readable version of message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageText")]
        public virtual string MessageText { get; set; }

        /// <summary>The structured data associated with this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<Parameter> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Taskrunner configuration settings.</summary>
    public class TaskRunnerSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to also send taskrunner log info to stderr.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alsologtostderr")]
        public virtual System.Nullable<bool> Alsologtostderr { get; set; }

        /// <summary>The location on the worker for task-specific subdirectories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseTaskDir")]
        public virtual string BaseTaskDir { get; set; }

        /// <summary>
        /// The base URL for the taskrunner to use when accessing Google Cloud APIs. When workers access Google Cloud
        /// APIs, they logically do so via relative URLs. If this field is specified, it supplies the base URL to use
        /// for resolving these relative URLs. The normative algorithm used is defined by RFC 1808, "Relative Uniform
        /// Resource Locators". If not specified, the default value is "http://www.googleapis.com/"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUrl")]
        public virtual string BaseUrl { get; set; }

        /// <summary>The file to store preprocessing commands in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commandlinesFileName")]
        public virtual string CommandlinesFileName { get; set; }

        /// <summary>Whether to continue taskrunner if an exception is hit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continueOnException")]
        public virtual System.Nullable<bool> ContinueOnException { get; set; }

        /// <summary>The API version of endpoint, e.g. "v1b3"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataflowApiVersion")]
        public virtual string DataflowApiVersion { get; set; }

        /// <summary>The command to launch the worker harness.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("harnessCommand")]
        public virtual string HarnessCommand { get; set; }

        /// <summary>The suggested backend language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageHint")]
        public virtual string LanguageHint { get; set; }

        /// <summary>The directory on the VM to store logs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logDir")]
        public virtual string LogDir { get; set; }

        /// <summary>Whether to send taskrunner log info to Google Compute Engine VM serial console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logToSerialconsole")]
        public virtual System.Nullable<bool> LogToSerialconsole { get; set; }

        /// <summary>
        /// Indicates where to put logs. If this is not specified, the logs will not be uploaded. The supported resource
        /// type is: Google Cloud Storage: storage.googleapis.com/{bucket}/{object}
        /// bucket.storage.googleapis.com/{object}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUploadLocation")]
        public virtual string LogUploadLocation { get; set; }

        /// <summary>
        /// The OAuth2 scopes to be requested by the taskrunner in order to access the Cloud Dataflow API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthScopes")]
        public virtual System.Collections.Generic.IList<string> OauthScopes { get; set; }

        /// <summary>The settings to pass to the parallel worker harness.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelWorkerSettings")]
        public virtual WorkerSettings ParallelWorkerSettings { get; set; }

        /// <summary>The streaming worker main class name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingWorkerMainClass")]
        public virtual string StreamingWorkerMainClass { get; set; }

        /// <summary>The UNIX group ID on the worker VM to use for tasks launched by taskrunner; e.g. "wheel".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskGroup")]
        public virtual string TaskGroup { get; set; }

        /// <summary>The UNIX user ID on the worker VM to use for tasks launched by taskrunner; e.g. "root".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskUser")]
        public virtual string TaskUser { get; set; }

        /// <summary>
        /// The prefix of the resources the taskrunner should use for temporary storage. The supported resource type is:
        /// Google Cloud Storage: storage.googleapis.com/{bucket}/{object} bucket.storage.googleapis.com/{object}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tempStoragePrefix")]
        public virtual string TempStoragePrefix { get; set; }

        /// <summary>The ID string of the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>The file to store the workflow in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowFileName")]
        public virtual string WorkflowFileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing a template.</summary>
    public class TemplateMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A description of the template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The name of the template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The parameters for the template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<ParameterMetadata> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Global topology of the streaming Dataflow job, including all computations and their sharded locations.
    /// </summary>
    public class TopologyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The computations associated with a streaming Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computations")]
        public virtual System.Collections.Generic.IList<ComputationTopology> Computations { get; set; }

        /// <summary>The disks assigned to a streaming Dataflow job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDiskAssignments")]
        public virtual System.Collections.Generic.IList<DataDiskAssignment> DataDiskAssignments { get; set; }

        /// <summary>The size (in bits) of keys that will be assigned to source messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardingKeyBits")]
        public virtual System.Nullable<int> ForwardingKeyBits { get; set; }

        /// <summary>Version number for persistent state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistentStateVersion")]
        public virtual System.Nullable<int> PersistentStateVersion { get; set; }

        /// <summary>Maps user stage names to stable computation names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userStageToComputationNameMap")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserStageToComputationNameMap { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of the type, names/ids, and input/outputs for a transform.</summary>
    public class TransformSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Transform-specific display data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayData")]
        public virtual System.Collections.Generic.IList<DisplayData> DisplayData { get; set; }

        /// <summary>SDK generated id of this transform instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>User names for all collection inputs to this transform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputCollectionName")]
        public virtual System.Collections.Generic.IList<string> InputCollectionName { get; set; }

        /// <summary>Type of transform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>User provided name for this transform instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User names for all collection outputs to this transform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputCollectionName")]
        public virtual System.Collections.Generic.IList<string> OutputCollectionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to the validation request.</summary>
    public class ValidateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Will be empty if validation succeeds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Information about the validated query. Not defined if validation fails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInfo")]
        public virtual QueryInfo QueryInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>WorkItem represents basic information about a WorkItem to be executed in the cloud.</summary>
    public class WorkItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Work item-specific configuration as an opaque blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configuration")]
        public virtual string Configuration { get; set; }

        /// <summary>Identifies this WorkItem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>The initial index to use when reporting the status of the WorkItem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialReportIndex")]
        public virtual System.Nullable<long> InitialReportIndex { get; set; }

        /// <summary>Identifies the workflow job this WorkItem belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>Time when the lease on this Work will expire.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaseExpireTime")]
        public virtual object LeaseExpireTime { get; set; }

        /// <summary>Additional information for MapTask WorkItems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapTask")]
        public virtual MapTask MapTask { get; set; }

        /// <summary>Any required packages that need to be fetched in order to execute this WorkItem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packages")]
        public virtual System.Collections.Generic.IList<Package> Packages { get; set; }

        /// <summary>Identifies the cloud project this WorkItem belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Recommended reporting interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportStatusInterval")]
        public virtual object ReportStatusInterval { get; set; }

        /// <summary>Additional information for SeqMapTask WorkItems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seqMapTask")]
        public virtual SeqMapTask SeqMapTask { get; set; }

        /// <summary>Additional information for ShellTask WorkItems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shellTask")]
        public virtual ShellTask ShellTask { get; set; }

        /// <summary>Additional information for source operation WorkItems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceOperationTask")]
        public virtual SourceOperationRequest SourceOperationTask { get; set; }

        /// <summary>Additional information for StreamingComputationTask WorkItems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingComputationTask")]
        public virtual StreamingComputationTask StreamingComputationTask { get; set; }

        /// <summary>Additional information for StreamingConfigTask WorkItems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingConfigTask")]
        public virtual StreamingConfigTask StreamingConfigTask { get; set; }

        /// <summary>Additional information for StreamingSetupTask WorkItems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingSetupTask")]
        public virtual StreamingSetupTask StreamingSetupTask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an individual work item execution.</summary>
    public class WorkItemDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Attempt ID of this work item</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attemptId")]
        public virtual string AttemptId { get; set; }

        /// <summary>
        /// End time of this work item attempt. If the work item is completed, this is the actual end time of the work
        /// item. Otherwise, it is the predicted end time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Metrics for this work item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<MetricUpdate> Metrics { get; set; }

        /// <summary>Progress of this work item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual ProgressTimeseries Progress { get; set; }

        /// <summary>Start time of this work item attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>State of this work item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Name of this work item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskId")]
        public virtual string TaskId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Dataflow service's idea of the current state of a WorkItem being processed by a worker.</summary>
    public class WorkItemServiceState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, a request to complete the work item with the given status. This will not be set to OK, unless
        /// supported by the specific kind of WorkItem. It can be used for the backend to indicate a WorkItem must
        /// terminate, e.g., for aborting work.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completeWorkStatus")]
        public virtual Status CompleteWorkStatus { get; set; }

        /// <summary>Other data returned by the service, specific to the particular worker harness.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("harnessData")]
        public virtual System.Collections.Generic.IDictionary<string, object> HarnessData { get; set; }

        /// <summary>
        /// A hot key is a symptom of poor data distribution in which there are enough elements mapped to a single key
        /// to impact pipeline performance. When present, this field includes metadata associated with any hot key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotKeyDetection")]
        public virtual HotKeyDetection HotKeyDetection { get; set; }

        /// <summary>Time at which the current lease will expire.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaseExpireTime")]
        public virtual object LeaseExpireTime { get; set; }

        /// <summary>
        /// The short ids that workers should use in subsequent metric updates. Workers should strive to use short ids
        /// whenever possible, but it is ok to request the short_id again if a worker lost track of it (e.g. if the
        /// worker is recovering from a crash). NOTE: it is possible that the response may have short ids for a subset
        /// of the metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricShortId")]
        public virtual System.Collections.Generic.IList<MetricShortId> MetricShortId { get; set; }

        /// <summary>
        /// The index value to use for the next report sent by the worker. Note: If the report call fails for whatever
        /// reason, the worker should reuse this index for subsequent report attempts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextReportIndex")]
        public virtual System.Nullable<long> NextReportIndex { get; set; }

        /// <summary>New recommended reporting interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportStatusInterval")]
        public virtual object ReportStatusInterval { get; set; }

        /// <summary>
        /// The progress point in the WorkItem where the Dataflow service suggests that the worker truncate the task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitRequest")]
        public virtual ApproximateSplitRequest SplitRequest { get; set; }

        /// <summary>DEPRECATED in favor of split_request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedStopPoint")]
        public virtual ApproximateProgress SuggestedStopPoint { get; set; }

        /// <summary>Obsolete, always empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedStopPosition")]
        public virtual Position SuggestedStopPosition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Conveys a worker's progress through the work described by a WorkItem.</summary>
    public class WorkItemStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the WorkItem was completed (successfully or unsuccessfully).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completed")]
        public virtual System.Nullable<bool> Completed { get; set; }

        /// <summary>Worker output counters for this WorkItem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counterUpdates")]
        public virtual System.Collections.Generic.IList<CounterUpdate> CounterUpdates { get; set; }

        /// <summary>See documentation of stop_position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicSourceSplit")]
        public virtual DynamicSourceSplit DynamicSourceSplit { get; set; }

        /// <summary>
        /// Specifies errors which occurred during processing. If errors are provided, and completed = true, then the
        /// WorkItem is considered to have failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Status> Errors { get; set; }

        /// <summary>DEPRECATED in favor of counter_updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricUpdates")]
        public virtual System.Collections.Generic.IList<MetricUpdate> MetricUpdates { get; set; }

        /// <summary>DEPRECATED in favor of reported_progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progress")]
        public virtual ApproximateProgress Progress { get; set; }

        /// <summary>
        /// The report index. When a WorkItem is leased, the lease will contain an initial report index. When a
        /// WorkItem's status is reported to the system, the report should be sent with that report index, and the
        /// response will contain the index the worker should use for the next report. Reports received with unexpected
        /// index values will be rejected by the service. In order to preserve idempotency, the worker should not alter
        /// the contents of a report, even if the worker must submit the same report multiple times before getting back
        /// a response. The worker should not submit a subsequent report until the response for the previous report had
        /// been received from the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportIndex")]
        public virtual System.Nullable<long> ReportIndex { get; set; }

        /// <summary>The worker's progress through this WorkItem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportedProgress")]
        public virtual ApproximateReportedProgress ReportedProgress { get; set; }

        /// <summary>Amount of time the worker requests for its lease.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedLeaseDuration")]
        public virtual object RequestedLeaseDuration { get; set; }

        /// <summary>DEPRECATED in favor of dynamic_source_split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFork")]
        public virtual SourceFork SourceFork { get; set; }

        /// <summary>
        /// If the work item represented a SourceOperationRequest, and the work is completed, contains the result of the
        /// operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceOperationResponse")]
        public virtual SourceOperationResponse SourceOperationResponse { get; set; }

        /// <summary>
        /// A worker may split an active map task in two parts, "primary" and "residual", continuing to process the
        /// primary part and returning the residual part into the pool of available work. This event is called a
        /// "dynamic split" and is critical to the dynamic work rebalancing feature. The two obtained sub-tasks are
        /// called "parts" of the split. The parts, if concatenated, must represent the same input as would be read by
        /// the current task if the split did not happen. The exact way in which the original task is decomposed into
        /// the two parts is specified either as a position demarcating them (stop_position), or explicitly as two
        /// DerivedSources, if this task consumes a user-defined source type (dynamic_source_split). The "current" task
        /// is adjusted as a result of the split: after a task with range [A, B) sends a stop_position update at C, its
        /// range is considered to be [A, C), e.g.: * Progress should be interpreted relative to the new range, e.g.
        /// "75% completed" means "75% of [A, C) completed" * The worker should interpret proposed_stop_position
        /// relative to the new range, e.g. "split at 68%" should be interpreted as "split at 68% of [A, C)". * If the
        /// worker chooses to split again using stop_position, only stop_positions in [A, C) will be accepted. * Etc.
        /// dynamic_source_split has similar semantics: e.g., if a task with source S splits using dynamic_source_split
        /// into {P, R} (where P and R must be together equivalent to S), then subsequent progress and
        /// proposed_stop_position should be interpreted relative to P, and in a potential subsequent
        /// dynamic_source_split into {P', R'}, P' and R' must be together equivalent to P, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopPosition")]
        public virtual Position StopPosition { get; set; }

        /// <summary>Total time the worker spent being throttled by external systems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalThrottlerWaitTimeSeconds")]
        public virtual System.Nullable<double> TotalThrottlerWaitTimeSeconds { get; set; }

        /// <summary>Identifies the WorkItem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workItemId")]
        public virtual string WorkItemId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a worker</summary>
    public class WorkerDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Work items processed by this worker, sorted by time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workItems")]
        public virtual System.Collections.Generic.IList<WorkItemDetails> WorkItems { get; set; }

        /// <summary>Name of this worker</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerName")]
        public virtual string WorkerName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// WorkerHealthReport contains information about the health of a worker. The VM should be identified by the labels
    /// attached to the WorkerMessage that this health ping belongs to.
    /// </summary>
    public class WorkerHealthReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Message describing any unusual health reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("msg")]
        public virtual string Msg { get; set; }

        /// <summary>
        /// The pods running on the worker. See:
        /// http://kubernetes.io/v1.1/docs/api-reference/v1/definitions.html#_v1_pod This field is used by the worker to
        /// send the status of the indvidual containers running on each worker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pods")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Pods { get; set; }

        /// <summary>
        /// The interval at which the worker is sending health reports. The default value of 0 should be interpreted as
        /// the field is not being explicitly set by the worker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportInterval")]
        public virtual object ReportInterval { get; set; }

        /// <summary>Code to describe a specific reason, if known, that a VM has reported broken state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmBrokenCode")]
        public virtual string VmBrokenCode { get; set; }

        /// <summary>
        /// Whether the VM is in a permanently broken state. Broken VMs should be abandoned or deleted ASAP to avoid
        /// assigning or completing any work.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmIsBroken")]
        public virtual System.Nullable<bool> VmIsBroken { get; set; }

        /// <summary>Whether the VM is currently healthy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmIsHealthy")]
        public virtual System.Nullable<bool> VmIsHealthy { get; set; }

        /// <summary>The time the VM was booted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmStartupTime")]
        public virtual object VmStartupTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// WorkerHealthReportResponse contains information returned to the worker in response to a health ping.
    /// </summary>
    public class WorkerHealthReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A positive value indicates the worker should change its reporting interval to the specified value. The
        /// default value of zero means no change in report rate is requested by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportInterval")]
        public virtual object ReportInterval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A report of an event in a worker's lifecycle. The proto contains one event, because the worker is expected to
    /// asynchronously send each message immediately after the event. Due to this asynchrony, messages may arrive out of
    /// order (or missing), and it is up to the consumer to interpret. The timestamp of the event is in the enclosing
    /// WorkerMessage proto.
    /// </summary>
    public class WorkerLifecycleEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The start time of this container. All events will report this so that events can be grouped together across
        /// container/VM restarts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerStartTime")]
        public virtual object ContainerStartTime { get; set; }

        /// <summary>The event being reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual string Event__ { get; set; }

        /// <summary>Other stats that can accompany an event. E.g. { "downloaded_bytes" : "123456" }</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>WorkerMessage provides information to the backend about a worker.</summary>
    public class WorkerMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Labels are used to group WorkerMessages. For example, a worker_message about a particular container might
        /// have the labels: { "JOB_ID": "2015-04-22", "WORKER_ID": "wordcount-vm-2015…" "CONTAINER_TYPE": "worker",
        /// "CONTAINER_ID": "ac1234def"} Label tags typically correspond to Label enum values. However, for ease of
        /// development other strings can be used as tags. LABEL_UNSPECIFIED should not be used here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The timestamp of the worker_message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual object Time { get; set; }

        /// <summary>The health of a worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerHealthReport")]
        public virtual WorkerHealthReport WorkerHealthReport { get; set; }

        /// <summary>Record of worker lifecycle events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerLifecycleEvent")]
        public virtual WorkerLifecycleEvent WorkerLifecycleEvent { get; set; }

        /// <summary>A worker message code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerMessageCode")]
        public virtual WorkerMessageCode WorkerMessageCode { get; set; }

        /// <summary>Resource metrics reported by workers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerMetrics")]
        public virtual ResourceUtilizationReport WorkerMetrics { get; set; }

        /// <summary>Shutdown notice by workers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerShutdownNotice")]
        public virtual WorkerShutdownNotice WorkerShutdownNotice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message code is used to report status and error messages to the service. The message codes are intended to be
    /// machine readable. The service will take care of translating these into user understandable messages if
    /// necessary. Example use cases: 1. Worker processes reporting successful startup. 2. Worker processes reporting
    /// specific errors (e.g. package staging failure).
    /// </summary>
    public class WorkerMessageCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The code is a string intended for consumption by a machine that identifies the type of message being sent.
        /// Examples: 1. "HARNESS_STARTED" might be used to indicate the worker harness has started. 2.
        /// "GCS_DOWNLOAD_ERROR" might be used to indicate an error downloading a Cloud Storage file as part of the boot
        /// process of one of the worker containers. This is a string and not an enum to make it easy to add new codes
        /// without waiting for an API change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// Parameters contains specific information about the code. This is a struct to allow parameters of different
        /// types. Examples: 1. For a "HARNESS_STARTED" message parameters might provide the name of the worker and
        /// additional data like timing information. 2. For a "GCS_DOWNLOAD_ERROR" parameters might contain fields
        /// listing the Cloud Storage objects being downloaded and fields containing errors. In general complex data
        /// structures should be avoided. If a worker needs to send a specific and complicated data structure then
        /// please consider defining a new proto and adding it to the data oneof in WorkerMessageResponse. Conventions:
        /// Parameters should only be used for information that isn't typically passed as a label. hostname and other
        /// worker identifiers should almost always be passed as labels since they will be included on most messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A worker_message response allows the server to pass information to the sender.</summary>
    public class WorkerMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The service's response to a worker's health report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerHealthReportResponse")]
        public virtual WorkerHealthReportResponse WorkerHealthReportResponse { get; set; }

        /// <summary>Service's response to reporting worker metrics (currently empty).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerMetricsResponse")]
        public virtual ResourceUtilizationReportResponse WorkerMetricsResponse { get; set; }

        /// <summary>Service's response to shutdown notice (currently empty).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerShutdownNoticeResponse")]
        public virtual WorkerShutdownNoticeResponse WorkerShutdownNoticeResponse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes one particular pool of Cloud Dataflow workers to be instantiated by the Cloud Dataflow service in
    /// order to perform the computations required by a job. Note that a workflow job may use multiple pools, in order
    /// to match the various computational requirements of the various stages of the job.
    /// </summary>
    public class WorkerPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Settings for autoscaling of this WorkerPool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscalingSettings")]
        public virtual AutoscalingSettings AutoscalingSettings { get; set; }

        /// <summary>Data disks that are used by a VM in this workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataDisks")]
        public virtual System.Collections.Generic.IList<Disk> DataDisks { get; set; }

        /// <summary>
        /// The default package set to install. This allows the service to select a default set of packages which are
        /// useful to worker harnesses written in a particular language.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPackageSet")]
        public virtual string DefaultPackageSet { get; set; }

        /// <summary>
        /// Size of root disk for VMs, in GB. If zero or unspecified, the service will attempt to choose a reasonable
        /// default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<int> DiskSizeGb { get; set; }

        /// <summary>Fully qualified source image for disks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSourceImage")]
        public virtual string DiskSourceImage { get; set; }

        /// <summary>
        /// Type of root disk for VMs. If empty or unspecified, the service will attempt to choose a reasonable default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskType")]
        public virtual string DiskType { get; set; }

        /// <summary>Configuration for VM IPs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipConfiguration")]
        public virtual string IpConfiguration { get; set; }

        /// <summary>The kind of the worker pool; currently only `harness` and `shuffle` are supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Machine type (e.g. "n1-standard-1"). If empty or unspecified, the service will attempt to choose a
        /// reasonable default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>Metadata to set on the Google Compute Engine VMs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Network to which VMs will be assigned. If empty or unspecified, the service will use the network "default".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// The number of threads per worker harness. If empty or unspecified, the service will choose a number of
        /// threads (according to the number of cores on the selected machine type for batch, or 1 by convention for
        /// streaming).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numThreadsPerWorker")]
        public virtual System.Nullable<int> NumThreadsPerWorker { get; set; }

        /// <summary>
        /// Number of Google Compute Engine workers in this pool needed to execute the job. If zero or unspecified, the
        /// service will attempt to choose a reasonable default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numWorkers")]
        public virtual System.Nullable<int> NumWorkers { get; set; }

        /// <summary>The action to take on host maintenance, as defined by the Google Compute Engine API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onHostMaintenance")]
        public virtual string OnHostMaintenance { get; set; }

        /// <summary>Packages to be installed on workers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packages")]
        public virtual System.Collections.Generic.IList<Package> Packages { get; set; }

        /// <summary>Extra arguments for this worker pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolArgs")]
        public virtual System.Collections.Generic.IDictionary<string, object> PoolArgs { get; set; }

        /// <summary>
        /// Set of SDK harness containers needed to execute this pipeline. This will only be set in the Fn API path. For
        /// non-cross-language pipelines this should have only one entry. Cross-language pipelines will have two or more
        /// entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkHarnessContainerImages")]
        public virtual System.Collections.Generic.IList<SdkHarnessContainerImage> SdkHarnessContainerImages { get; set; }

        /// <summary>
        /// Subnetwork to which VMs will be assigned, if desired. Expected to be of the form
        /// "regions/REGION/subnetworks/SUBNETWORK".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// Settings passed through to Google Compute Engine workers when using the standard Dataflow task runner. Users
        /// should ignore this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskrunnerSettings")]
        public virtual TaskRunnerSettings TaskrunnerSettings { get; set; }

        /// <summary>
        /// Sets the policy for determining when to turndown worker pool. Allowed values are: `TEARDOWN_ALWAYS`,
        /// `TEARDOWN_ON_SUCCESS`, and `TEARDOWN_NEVER`. `TEARDOWN_ALWAYS` means workers are always torn down regardless
        /// of whether the job succeeds. `TEARDOWN_ON_SUCCESS` means workers are torn down if the job succeeds.
        /// `TEARDOWN_NEVER` means the workers are never torn down. If the workers are not torn down by the service,
        /// they will continue to run and use Google Compute Engine VM resources in the user's project until they are
        /// explicitly terminated by the user. Because of this, Google recommends using the `TEARDOWN_ALWAYS` policy
        /// except for small, manually supervised test jobs. If unknown or unspecified, the service will attempt to
        /// choose a reasonable default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teardownPolicy")]
        public virtual string TeardownPolicy { get; set; }

        /// <summary>
        /// Required. Docker container image that executes the Cloud Dataflow worker harness, residing in Google
        /// Container Registry. Deprecated for the Fn API path. Use sdk_harness_container_images instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerHarnessContainerImage")]
        public virtual string WorkerHarnessContainerImage { get; set; }

        /// <summary>
        /// Zone to run the worker pools in. If empty or unspecified, the service will attempt to choose a reasonable
        /// default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides data to pass through to the worker harness.</summary>
    public class WorkerSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The base URL for accessing Google Cloud APIs. When workers access Google Cloud APIs, they logically do so
        /// via relative URLs. If this field is specified, it supplies the base URL to use for resolving these relative
        /// URLs. The normative algorithm used is defined by RFC 1808, "Relative Uniform Resource Locators". If not
        /// specified, the default value is "http://www.googleapis.com/"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUrl")]
        public virtual string BaseUrl { get; set; }

        /// <summary>Whether to send work progress updates to the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingEnabled")]
        public virtual System.Nullable<bool> ReportingEnabled { get; set; }

        /// <summary>
        /// The Cloud Dataflow service path relative to the root URL, for example, "dataflow/v1b3/projects".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePath")]
        public virtual string ServicePath { get; set; }

        /// <summary>The Shuffle service path relative to the root URL, for example, "shuffle/v1beta1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shuffleServicePath")]
        public virtual string ShuffleServicePath { get; set; }

        /// <summary>
        /// The prefix of the resources the system should use for temporary storage. The supported resource type is:
        /// Google Cloud Storage: storage.googleapis.com/{bucket}/{object} bucket.storage.googleapis.com/{object}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tempStoragePrefix")]
        public virtual string TempStoragePrefix { get; set; }

        /// <summary>The ID of the worker running this pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerId")]
        public virtual string WorkerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Shutdown notification from workers. This is to be sent by the shutdown script of the worker VM so that the
    /// backend knows that the VM is being shut down.
    /// </summary>
    public class WorkerShutdownNotice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reason for the worker shutdown. Current possible values are: "UNKNOWN": shutdown reason is unknown.
        /// "PREEMPTION": shutdown reason is preemption. Other possible reasons may be added in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Service-side response to WorkerMessage issuing shutdown notice.</summary>
    public class WorkerShutdownNoticeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An instruction that writes records. Takes one input, produces no outputs.</summary>
    public class WriteInstruction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual InstructionInput Input { get; set; }

        /// <summary>The sink to write to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sink")]
        public virtual Sink Sink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
