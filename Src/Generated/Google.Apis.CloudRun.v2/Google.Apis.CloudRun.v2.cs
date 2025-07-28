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

namespace Google.Apis.CloudRun.v2
{
    /// <summary>The CloudRun Service.</summary>
    public class CloudRunService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRunService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRunService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://run.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://run.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "run";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Run Admin API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Run Admin API.</summary>
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

    /// <summary>A base abstract class for CloudRun requests.</summary>
    public abstract class CloudRunBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudRunBaseServiceRequest instance.</summary>
        protected CloudRunBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudRun parameter list.</summary>
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
                Builds = new BuildsResource(service);
                Jobs = new JobsResource(service);
                Operations = new OperationsResource(service);
                Services = new ServicesResource(service);
                WorkerPools = new WorkerPoolsResource(service);
            }

            /// <summary>Gets the Builds resource.</summary>
            public virtual BuildsResource Builds { get; }

            /// <summary>The "builds" collection of methods.</summary>
            public class BuildsResource
            {
                private const string Resource = "builds";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BuildsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Submits a build in a given project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The project and location to build in. Location must be a region, e.g., 'us-central1' or
                /// 'global' if the global builder is to be used. Format: `projects/{project}/locations/{location}`
                /// </param>
                public virtual SubmitRequest Submit(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2SubmitBuildRequest body, string parent)
                {
                    return new SubmitRequest(this.service, body, parent);
                }

                /// <summary>Submits a build in a given project.</summary>
                public class SubmitRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2SubmitBuildResponse>
                {
                    /// <summary>Constructs a new Submit request.</summary>
                    public SubmitRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2SubmitBuildRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location to build in. Location must be a region, e.g., 'us-central1'
                    /// or 'global' if the global builder is to be used. Format:
                    /// `projects/{project}/locations/{location}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2SubmitBuildRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "submit";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/builds:submit";

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
                        Tasks = new TasksResource(service);
                    }

                    /// <summary>Gets the Tasks resource.</summary>
                    public virtual TasksResource Tasks { get; }

                    /// <summary>The "tasks" collection of methods.</summary>
                    public class TasksResource
                    {
                        private const string Resource = "tasks";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TasksResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Gets information about a Task.</summary>
                        /// <param name="name">
                        /// Required. The full name of the Task. Format:
                        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets information about a Task.</summary>
                        public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Task>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The full name of the Task. Format:
                            /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
                            /// </summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+/tasks/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists Tasks from an Execution of a Job.</summary>
                        /// <param name="parent">
                        /// Required. The Execution from which the Tasks should be listed. To list all Tasks across
                        /// Executions of a Job, use "-" instead of Execution name. To list all Tasks across Jobs, use
                        /// "-" instead of Job name. Format:
                        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists Tasks from an Execution of a Job.</summary>
                        public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListTasksResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The Execution from which the Tasks should be listed. To list all Tasks across
                            /// Executions of a Job, use "-" instead of Execution name. To list all Tasks across Jobs,
                            /// use "-" instead of Job name. Format:
                            /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Maximum number of Tasks to return in this call.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token received from a previous call to ListTasks. All other parameters must
                            /// match.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// If true, returns deleted (but unexpired) resources along with active ones.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> ShowDeleted { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+parent}/tasks";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+$",
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
                                RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "showDeleted",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>Cancels an Execution.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the Execution to cancel. Format:
                    /// `projects/{project}/locations/{location}/jobs/{job}/executions/{execution}`, where `{project}`
                    /// can be project id or number.
                    /// </param>
                    public virtual CancelRequest Cancel(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2CancelExecutionRequest body, string name)
                    {
                        return new CancelRequest(this.service, body, name);
                    }

                    /// <summary>Cancels an Execution.</summary>
                    public class CancelRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2CancelExecutionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Execution to cancel. Format:
                        /// `projects/{project}/locations/{location}/jobs/{job}/executions/{execution}`, where
                        /// `{project}` can be project id or number.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2CancelExecutionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "cancel";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}:cancel";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes an Execution.</summary>
                    /// <param name="name">
                    /// Required. The name of the Execution to delete. Format:
                    /// `projects/{project}/locations/{location}/jobs/{job}/executions/{execution}`, where `{project}`
                    /// can be project id or number.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes an Execution.</summary>
                    public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Execution to delete. Format:
                        /// `projects/{project}/locations/{location}/jobs/{job}/executions/{execution}`, where
                        /// `{project}` can be project id or number.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// A system-generated fingerprint for this version of the resource. This may be used to detect
                        /// modification conflict during updates.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Indicates that the request should be validated without actually deleting any resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+$",
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

                    /// <summary>Read the status of an image export operation.</summary>
                    /// <param name="name">
                    /// Required. The name of the resource of which image export operation status has to be fetched.
                    /// Format:
                    /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}`
                    /// for Revision
                    /// `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}` for
                    /// Execution
                    /// </param>
                    /// <param name="operationId">Required. The operation id returned from ExportImage.</param>
                    public virtual ExportStatusRequest ExportStatus(string name, string operationId)
                    {
                        return new ExportStatusRequest(this.service, name, operationId);
                    }

                    /// <summary>Read the status of an image export operation.</summary>
                    public class ExportStatusRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ExportStatusResponse>
                    {
                        /// <summary>Constructs a new ExportStatus request.</summary>
                        public ExportStatusRequest(Google.Apis.Services.IClientService service, string name, string operationId) : base(service)
                        {
                            Name = name;
                            OperationId = operationId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource of which image export operation status has to be fetched.
                        /// Format:
                        /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}`
                        /// for Revision
                        /// `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}` for
                        /// Execution
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The operation id returned from ExportImage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string OperationId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "exportStatus";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}/{+operationId}:exportStatus";

                        /// <summary>Initializes ExportStatus parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+$",
                            });
                            RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "operationId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets information about an Execution.</summary>
                    /// <param name="name">
                    /// Required. The full name of the Execution. Format:
                    /// `projects/{project}/locations/{location}/jobs/{job}/executions/{execution}`, where `{project}`
                    /// can be project id or number.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets information about an Execution.</summary>
                    public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Execution>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full name of the Execution. Format:
                        /// `projects/{project}/locations/{location}/jobs/{job}/executions/{execution}`, where
                        /// `{project}` can be project id or number.
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+/executions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Executions from a Job. Results are sorted by creation time, descending.</summary>
                    /// <param name="parent">
                    /// Required. The Execution from which the Executions should be listed. To list all Executions
                    /// across Jobs, use "-" instead of Job name. Format:
                    /// `projects/{project}/locations/{location}/jobs/{job}`, where `{project}` can be project id or
                    /// number.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Executions from a Job. Results are sorted by creation time, descending.</summary>
                    public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListExecutionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Execution from which the Executions should be listed. To list all Executions
                        /// across Jobs, use "-" instead of Job name. Format:
                        /// `projects/{project}/locations/{location}/jobs/{job}`, where `{project}` can be project id or
                        /// number.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Maximum number of Executions to return in this call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token received from a previous call to ListExecutions. All other parameters must
                        /// match.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// If true, returns deleted (but unexpired) resources along with active ones.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/executions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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
                            RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                            {
                                Name = "showDeleted",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Creates a Job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location and project in which this Job should be created. Format:
                /// projects/{project}/locations/{location}, where {project} can be project id or number.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a Job.</summary>
                public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project in which this Job should be created. Format:
                    /// projects/{project}/locations/{location}, where {project} can be project id or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The unique identifier for the Job. The name of the job becomes {parent}/jobs/{job_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("jobId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string JobId { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated and default values populated, without persisting
                    /// the request or creating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/jobs";

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
                        RequestParameters.Add("jobId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "jobId",
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

                /// <summary>Deletes a Job.</summary>
                /// <param name="name">
                /// Required. The full name of the Job. Format: projects/{project}/locations/{location}/jobs/{job},
                /// where {project} can be project id or number.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a Job.</summary>
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Job. Format: projects/{project}/locations/{location}/jobs/{job},
                    /// where {project} can be project id or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A system-generated fingerprint for this version of the resource. May be used to detect
                    /// modification conflict during updates.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated without actually deleting any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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

                /// <summary>Gets information about a Job.</summary>
                /// <param name="name">
                /// Required. The full name of the Job. Format: projects/{project}/locations/{location}/jobs/{job},
                /// where {project} can be project id or number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a Job.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Job. Format: projects/{project}/locations/{location}/jobs/{job},
                    /// where {project} can be project id or number.
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the IAM Access Control policy currently in effect for the given Job. This result does not
                /// include any inherited policies.
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
                /// Gets the IAM Access Control policy currently in effect for the given Job. This result does not
                /// include any inherited policies.
                /// </summary>
                public class GetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
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
                    public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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

                /// <summary>Lists Jobs. Results are sorted by creation time, descending.</summary>
                /// <param name="parent">
                /// Required. The location and project to list resources on. Format:
                /// projects/{project}/locations/{location}, where {project} can be project id or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Jobs. Results are sorted by creation time, descending.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project to list resources on. Format:
                    /// projects/{project}/locations/{location}, where {project} can be project id or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Jobs to return in this call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token received from a previous call to ListJobs. All other parameters must match.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>If true, returns deleted (but unexpired) resources along with active ones.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/jobs";

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
                        RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                        {
                            Name = "showDeleted",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a Job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully qualified name of this Job. Format: projects/{project}/locations/{location}/jobs/{job}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a Job.</summary>
                public class PatchRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified name of this Job. Format: projects/{project}/locations/{location}/jobs/{job}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, and if the Job does not exist, it will create a new one. Caller must
                    /// have both create and update permissions for this call if this is set to true.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated and default values populated, without persisting
                    /// the request or updating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Job Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
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

                /// <summary>Triggers creation of a new Execution of this Job.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The full name of the Job. Format: projects/{project}/locations/{location}/jobs/{job},
                /// where {project} can be project id or number.
                /// </param>
                public virtual RunRequest Run(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2RunJobRequest body, string name)
                {
                    return new RunRequest(this.service, body, name);
                }

                /// <summary>Triggers creation of a new Execution of this Job.</summary>
                public class RunRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Run request.</summary>
                    public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2RunJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Job. Format: projects/{project}/locations/{location}/jobs/{job},
                    /// where {project} can be project id or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2RunJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "run";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:run";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified Job. Overwrites any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified Job. Overwrites any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobs/[^/]+$",
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
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleProtobufEmpty>
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
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">Required. To query for all of the operations for a project.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. To query for all of the operations for a project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. A filter for matching the completed or in-progress operations. The supported formats
                    /// of *filter* are: To query for only completed operations: done:true To query for only ongoing
                    /// operations: done:false Must be empty to query for all of the latest operations for the given
                    /// parent project.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// The maximum number of records that should be returned. Requested page size cannot exceed 100. If
                    /// not set or set to less than or equal to 0, the default page size is 100. .
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Token identifying which result to start with, which is returned by a previous list call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}/operations";

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

                /// <summary>
                /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                /// returning the latest state. If the operation is already done, the latest state is immediately
                /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                /// timeout is used. If the server does not support this method, it returns
                /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return the
                /// latest state before the specified timeout (including immediately), meaning even an immediate
                /// response is no guarantee that the operation is done.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to wait on.</param>
                public virtual WaitRequest Wait(Google.Apis.CloudRun.v2.Data.GoogleLongrunningWaitOperationRequest body, string name)
                {
                    return new WaitRequest(this.service, body, name);
                }

                /// <summary>
                /// Waits until the specified long-running operation is done or reaches at most a specified timeout,
                /// returning the latest state. If the operation is already done, the latest state is immediately
                /// returned. If the timeout specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
                /// timeout is used. If the server does not support this method, it returns
                /// `google.rpc.Code.UNIMPLEMENTED`. Note that this method is on a best-effort basis. It may return the
                /// latest state before the specified timeout (including immediately), meaning even an immediate
                /// response is no guarantee that the operation is done.
                /// </summary>
                public class WaitRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Wait request.</summary>
                    public WaitRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleLongrunningWaitOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to wait on.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleLongrunningWaitOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "wait";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:wait";

                    /// <summary>Initializes Wait parameter list.</summary>
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
            }

            /// <summary>Gets the Services resource.</summary>
            public virtual ServicesResource Services { get; }

            /// <summary>The "services" collection of methods.</summary>
            public class ServicesResource
            {
                private const string Resource = "services";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ServicesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Revisions = new RevisionsResource(service);
                }

                /// <summary>Gets the Revisions resource.</summary>
                public virtual RevisionsResource Revisions { get; }

                /// <summary>The "revisions" collection of methods.</summary>
                public class RevisionsResource
                {
                    private const string Resource = "revisions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RevisionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a Revision.</summary>
                    /// <param name="name">
                    /// Required. The name of the Revision to delete. Format:
                    /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a Revision.</summary>
                    public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Revision to delete. Format:
                        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// A system-generated fingerprint for this version of the resource. This may be used to detect
                        /// modification conflict during updates.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Indicates that the request should be validated without actually deleting any resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/revisions/[^/]+$",
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

                    /// <summary>Read the status of an image export operation.</summary>
                    /// <param name="name">
                    /// Required. The name of the resource of which image export operation status has to be fetched.
                    /// Format:
                    /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}`
                    /// for Revision
                    /// `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}` for
                    /// Execution
                    /// </param>
                    /// <param name="operationId">Required. The operation id returned from ExportImage.</param>
                    public virtual ExportStatusRequest ExportStatus(string name, string operationId)
                    {
                        return new ExportStatusRequest(this.service, name, operationId);
                    }

                    /// <summary>Read the status of an image export operation.</summary>
                    public class ExportStatusRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ExportStatusResponse>
                    {
                        /// <summary>Constructs a new ExportStatus request.</summary>
                        public ExportStatusRequest(Google.Apis.Services.IClientService service, string name, string operationId) : base(service)
                        {
                            Name = name;
                            OperationId = operationId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource of which image export operation status has to be fetched.
                        /// Format:
                        /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}`
                        /// for Revision
                        /// `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}` for
                        /// Execution
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The operation id returned from ExportImage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string OperationId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "exportStatus";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}/{+operationId}:exportStatus";

                        /// <summary>Initializes ExportStatus parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/revisions/[^/]+$",
                            });
                            RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "operationId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets information about a Revision.</summary>
                    /// <param name="name">
                    /// Required. The full name of the Revision. Format:
                    /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets information about a Revision.</summary>
                    public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Revision>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full name of the Revision. Format:
                        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+/revisions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists Revisions from a given Service, or from a given location. Results are sorted by creation
                    /// time, descending.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The Service from which the Revisions should be listed. To list all Revisions across
                    /// Services, use "-" instead of Service name. Format:
                    /// projects/{project}/locations/{location}/services/{service}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists Revisions from a given Service, or from a given location. Results are sorted by creation
                    /// time, descending.
                    /// </summary>
                    public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListRevisionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Service from which the Revisions should be listed. To list all Revisions
                        /// across Services, use "-" instead of Service name. Format:
                        /// projects/{project}/locations/{location}/services/{service}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Maximum number of revisions to return in this call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token received from a previous call to ListRevisions. All other parameters must
                        /// match.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// If true, returns deleted (but unexpired) resources along with active ones.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/revisions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
                            RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                            {
                                Name = "showDeleted",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Creates a new Service in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location and project in which this service should be created. Format:
                /// projects/{project}/locations/{location}, where {project} can be project id or number. Only lowercase
                /// characters, digits, and hyphens.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Service in a given project and location.</summary>
                public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project in which this service should be created. Format:
                    /// projects/{project}/locations/{location}, where {project} can be project id or number. Only
                    /// lowercase characters, digits, and hyphens.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The unique identifier for the Service. It must begin with letter, and cannot end with
                    /// hyphen; must contain fewer than 50 characters. The name of the service becomes
                    /// {parent}/services/{service_id}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("serviceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ServiceId { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated and default values populated, without persisting
                    /// the request or creating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/services";

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
                        RequestParameters.Add("serviceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "serviceId",
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
                /// Deletes a Service. This will cause the Service to stop serving traffic and will delete all
                /// revisions.
                /// </summary>
                /// <param name="name">
                /// Required. The full name of the Service. Format:
                /// projects/{project}/locations/{location}/services/{service}, where {project} can be project id or
                /// number.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a Service. This will cause the Service to stop serving traffic and will delete all
                /// revisions.
                /// </summary>
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Service. Format:
                    /// projects/{project}/locations/{location}/services/{service}, where {project} can be project id or
                    /// number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A system-generated fingerprint for this version of the resource. May be used to detect
                    /// modification conflict during updates.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated without actually deleting any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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

                /// <summary>Gets information about a Service.</summary>
                /// <param name="name">
                /// Required. The full name of the Service. Format:
                /// projects/{project}/locations/{location}/services/{service}, where {project} can be project id or
                /// number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a Service.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the Service. Format:
                    /// projects/{project}/locations/{location}/services/{service}, where {project} can be project id or
                    /// number.
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the IAM Access Control policy currently in effect for the given Cloud Run Service. This result
                /// does not include any inherited policies.
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
                /// Gets the IAM Access Control policy currently in effect for the given Cloud Run Service. This result
                /// does not include any inherited policies.
                /// </summary>
                public class GetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
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
                    public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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

                /// <summary>Lists Services. Results are sorted by creation time, descending.</summary>
                /// <param name="parent">
                /// Required. The location and project to list resources on. Location must be a valid Google Cloud
                /// region, and cannot be the "-" wildcard. Format: projects/{project}/locations/{location}, where
                /// {project} can be project id or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Services. Results are sorted by creation time, descending.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListServicesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project to list resources on. Location must be a valid Google Cloud
                    /// region, and cannot be the "-" wildcard. Format: projects/{project}/locations/{location}, where
                    /// {project} can be project id or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of Services to return in this call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token received from a previous call to ListServices. All other parameters must match.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>If true, returns deleted (but unexpired) resources along with active ones.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/services";

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
                        RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                        {
                            Name = "showDeleted",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a Service.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully qualified name of this Service. In CreateServiceRequest, this field is ignored, and
                /// instead composed from CreateServiceRequest.parent and CreateServiceRequest.service_id. Format:
                /// projects/{project}/locations/{location}/services/{service_id}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a Service.</summary>
                public class PatchRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified name of this Service. In CreateServiceRequest, this field is ignored, and
                    /// instead composed from CreateServiceRequest.parent and CreateServiceRequest.service_id. Format:
                    /// projects/{project}/locations/{location}/services/{service_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, and if the Service does not exist, it will create a new one. The
                    /// caller must have 'run.services.create' permissions if this is set to true and the Service does
                    /// not exist.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>Optional. The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Indicates that the request should be validated and default values populated, without persisting
                    /// the request or updating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Service Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
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
                /// Sets the IAM Access control policy for the specified Service. Overwrites any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified Service. Overwrites any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/services/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the WorkerPools resource.</summary>
            public virtual WorkerPoolsResource WorkerPools { get; }

            /// <summary>The "workerPools" collection of methods.</summary>
            public class WorkerPoolsResource
            {
                private const string Resource = "workerPools";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkerPoolsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Revisions = new RevisionsResource(service);
                }

                /// <summary>Gets the Revisions resource.</summary>
                public virtual RevisionsResource Revisions { get; }

                /// <summary>The "revisions" collection of methods.</summary>
                public class RevisionsResource
                {
                    private const string Resource = "revisions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RevisionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a Revision.</summary>
                    /// <param name="name">
                    /// Required. The name of the Revision to delete. Format:
                    /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a Revision.</summary>
                    public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the Revision to delete. Format:
                        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// A system-generated fingerprint for this version of the resource. This may be used to detect
                        /// modification conflict during updates.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Indicates that the request should be validated without actually deleting any resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+/revisions/[^/]+$",
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

                    /// <summary>Gets information about a Revision.</summary>
                    /// <param name="name">
                    /// Required. The full name of the Revision. Format:
                    /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets information about a Revision.</summary>
                    public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Revision>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The full name of the Revision. Format:
                        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+/revisions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists Revisions from a given Service, or from a given location. Results are sorted by creation
                    /// time, descending.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The Service from which the Revisions should be listed. To list all Revisions across
                    /// Services, use "-" instead of Service name. Format:
                    /// projects/{project}/locations/{location}/services/{service}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists Revisions from a given Service, or from a given location. Results are sorted by creation
                    /// time, descending.
                    /// </summary>
                    public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListRevisionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The Service from which the Revisions should be listed. To list all Revisions
                        /// across Services, use "-" instead of Service name. Format:
                        /// projects/{project}/locations/{location}/services/{service}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Maximum number of revisions to return in this call.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token received from a previous call to ListRevisions. All other parameters must
                        /// match.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// If true, returns deleted (but unexpired) resources along with active ones.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowDeleted { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/revisions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
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
                            RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                            {
                                Name = "showDeleted",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Creates a new WorkerPool in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location and project in which this worker pool should be created. Format:
                /// `projects/{project}/locations/{location}`, where `{project}` can be project id or number. Only
                /// lowercase characters, digits, and hyphens.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2WorkerPool body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new WorkerPool in a given project and location.</summary>
                public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2WorkerPool body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project in which this worker pool should be created. Format:
                    /// `projects/{project}/locations/{location}`, where `{project}` can be project id or number. Only
                    /// lowercase characters, digits, and hyphens.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Indicates that the request should be validated and default values populated, without
                    /// persisting the request or creating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>
                    /// Required. The unique identifier for the WorkerPool. It must begin with letter, and cannot end
                    /// with hyphen; must contain fewer than 50 characters. The name of the worker pool becomes
                    /// `{parent}/workerPools/{worker_pool_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("workerPoolId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string WorkerPoolId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2WorkerPool Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/workerPools";

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
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("workerPoolId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "workerPoolId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a WorkerPool.</summary>
                /// <param name="name">
                /// Required. The full name of the WorkerPool. Format:
                /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where `{project}` can be
                /// project id or number.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a WorkerPool.</summary>
                public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the WorkerPool. Format:
                    /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where `{project}` can be
                    /// project id or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A system-generated fingerprint for this version of the resource. May be used to detect
                    /// modification conflict during updates.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. Indicates that the request should be validated without actually deleting any
                    /// resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
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

                /// <summary>Gets information about a WorkerPool.</summary>
                /// <param name="name">
                /// Required. The full name of the WorkerPool. Format:
                /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where `{project}` can be
                /// project id or number.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets information about a WorkerPool.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2WorkerPool>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The full name of the WorkerPool. Format:
                    /// `projects/{project}/locations/{location}/workerPools/{worker_pool}`, where `{project}` can be
                    /// project id or number.
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the IAM Access Control policy currently in effect for the given Cloud Run WorkerPool. This
                /// result does not include any inherited policies.
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
                /// Gets the IAM Access Control policy currently in effect for the given Cloud Run WorkerPool. This
                /// result does not include any inherited policies.
                /// </summary>
                public class GetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
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
                    public override string RestPath => "v2/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
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

                /// <summary>Lists WorkerPools. Results are sorted by creation time, descending.</summary>
                /// <param name="parent">
                /// Required. The location and project to list resources on. Location must be a valid Google Cloud
                /// region, and cannot be the "-" wildcard. Format: `projects/{project}/locations/{location}`, where
                /// `{project}` can be project id or number.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists WorkerPools. Results are sorted by creation time, descending.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ListWorkerPoolsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location and project to list resources on. Location must be a valid Google Cloud
                    /// region, and cannot be the "-" wildcard. Format: `projects/{project}/locations/{location}`, where
                    /// `{project}` can be project id or number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Maximum number of WorkerPools to return in this call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token received from a previous call to ListWorkerPools. All other parameters must match.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>If true, returns deleted (but unexpired) resources along with active ones.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/workerPools";

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
                        RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                        {
                            Name = "showDeleted",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a WorkerPool.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The fully qualified name of this WorkerPool. In CreateWorkerPoolRequest, this field is ignored, and
                /// instead composed from CreateWorkerPoolRequest.parent and CreateWorkerPoolRequest.worker_id. Format:
                /// `projects/{project}/locations/{location}/workerPools/{worker_id}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2WorkerPool body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates a WorkerPool.</summary>
                public class PatchRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2WorkerPool body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The fully qualified name of this WorkerPool. In CreateWorkerPoolRequest, this field is ignored,
                    /// and instead composed from CreateWorkerPoolRequest.parent and CreateWorkerPoolRequest.worker_id.
                    /// Format: `projects/{project}/locations/{location}/workerPools/{worker_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, and if the WorkerPool does not exist, it will create a new one. The
                    /// caller must have 'run.workerpools.create' permissions if this is set to true and the WorkerPool
                    /// does not exist.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. If set to true, a new revision will be created from the template even if the system
                    /// doesn't detect any changes from the previously deployed revision. This may be useful for cases
                    /// where the underlying resources need to be recreated or reinitialized. For example if the image
                    /// is specified by label, but the underlying image digest has changed) or if the container performs
                    /// deployment initialization work that needs to be performed again.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("forceNewRevision", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ForceNewRevision { get; set; }

                    /// <summary>Optional. The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>
                    /// Optional. Indicates that the request should be validated and default values populated, without
                    /// persisting the request or updating any resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2WorkerPool Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("forceNewRevision", new Google.Apis.Discovery.Parameter
                        {
                            Name = "forceNewRevision",
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
                /// Sets the IAM Access control policy for the specified WorkerPool. Overwrites any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the IAM Access control policy for the specified WorkerPool. Overwrites any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified Project. There are no permissions required
                /// for making this API call.
                /// </summary>
                public class TestIamPermissionsRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudRun.v2.Data.GoogleIamV1TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workerPools/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Export image for a given resource.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the resource of which image metadata should be exported. Format:
            /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}` for
            /// Revision `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}` for
            /// Execution
            /// </param>
            public virtual ExportImageRequest ExportImage(Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ExportImageRequest body, string name)
            {
                return new ExportImageRequest(this.service, body, name);
            }

            /// <summary>Export image for a given resource.</summary>
            public class ExportImageRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ExportImageResponse>
            {
                /// <summary>Constructs a new ExportImage request.</summary>
                public ExportImageRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ExportImageRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource of which image metadata should be exported. Format:
                /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}` for
                /// Revision `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}`
                /// for Execution
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2ExportImageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exportImage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:exportImage";

                /// <summary>Initializes ExportImage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/.*$",
                    });
                }
            }

            /// <summary>Export image metadata for a given resource.</summary>
            /// <param name="name">
            /// Required. The name of the resource of which image metadata should be exported. Format:
            /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}` for
            /// Revision `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}` for
            /// Execution
            /// </param>
            public virtual ExportImageMetadataRequest ExportImageMetadata(string name)
            {
                return new ExportImageMetadataRequest(this.service, name);
            }

            /// <summary>Export image metadata for a given resource.</summary>
            public class ExportImageMetadataRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Metadata>
            {
                /// <summary>Constructs a new ExportImageMetadata request.</summary>
                public ExportImageMetadataRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource of which image metadata should be exported. Format:
                /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}` for
                /// Revision `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}`
                /// for Execution
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exportImageMetadata";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:exportImageMetadata";

                /// <summary>Initializes ExportImageMetadata parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/.*$",
                    });
                }
            }

            /// <summary>Export generated customer metadata for a given resource.</summary>
            /// <param name="name">
            /// Required. The name of the resource of which metadata should be exported. Format:
            /// `projects/{project_id_or_number}/locations/{location}/services/{service}` for Service
            /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}` for
            /// Revision `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}` for
            /// Execution {project_id_or_number} may contains domain-scoped project IDs
            /// </param>
            public virtual ExportMetadataRequest ExportMetadata(string name)
            {
                return new ExportMetadataRequest(this.service, name);
            }

            /// <summary>Export generated customer metadata for a given resource.</summary>
            public class ExportMetadataRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Metadata>
            {
                /// <summary>Constructs a new ExportMetadata request.</summary>
                public ExportMetadataRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the resource of which metadata should be exported. Format:
                /// `projects/{project_id_or_number}/locations/{location}/services/{service}` for Service
                /// `projects/{project_id_or_number}/locations/{location}/services/{service}/revisions/{revision}` for
                /// Revision `projects/{project_id_or_number}/locations/{location}/jobs/{job}/executions/{execution}`
                /// for Execution {project_id_or_number} may contains domain-scoped project IDs
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exportMetadata";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:exportMetadata";

                /// <summary>Initializes ExportMetadata parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/.*$",
                    });
                }
            }

            /// <summary>Export generated customer metadata for a given project.</summary>
            /// <param name="name">
            /// Required. The name of the project of which metadata should be exported. Format:
            /// `projects/{project_id_or_number}/locations/{location}` for Project in a given location.
            /// </param>
            public virtual ExportProjectMetadataRequest ExportProjectMetadata(string name)
            {
                return new ExportProjectMetadataRequest(this.service, name);
            }

            /// <summary>Export generated customer metadata for a given project.</summary>
            public class ExportProjectMetadataRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v2.Data.GoogleCloudRunV2Metadata>
            {
                /// <summary>Constructs a new ExportProjectMetadata request.</summary>
                public ExportProjectMetadataRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project of which metadata should be exported. Format:
                /// `projects/{project_id_or_number}/locations/{location}` for Project in a given location.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exportProjectMetadata";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:exportProjectMetadata";

                /// <summary>Initializes ExportProjectMetadata parameter list.</summary>
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
        }
    }
}
namespace Google.Apis.CloudRun.v2.Data
{
    /// <summary>Settings for Binary Authorization feature.</summary>
    public class GoogleCloudRunV2BinaryAuthorization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If present, indicates to use Breakglass using this justification. If use_default is False, then it
        /// must be empty. For more information on breakglass, see
        /// https://cloud.google.com/binary-authorization/docs/using-breakglass
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breakglassJustification")]
        public virtual string BreakglassJustification { get; set; }

        /// <summary>
        /// Optional. The path to a binary authorization policy. Format:
        /// `projects/{project}/platforms/cloudRun/{policy-name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>
        /// Optional. If True, indicates to use the default project's binary authorization policy. If False, binary
        /// authorization will be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useDefault")]
        public virtual System.Nullable<bool> UseDefault { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the Build step of the function that builds a container from the given source.</summary>
    public class GoogleCloudRunV2BuildConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The base image used to build the function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseImage")]
        public virtual string BaseImage { get; set; }

        /// <summary>Optional. Sets whether the function will receive automatic base image updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAutomaticUpdates")]
        public virtual System.Nullable<bool> EnableAutomaticUpdates { get; set; }

        /// <summary>Optional. User-provided build-time environment variables for the function</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// Optional. The name of the function (as defined in source code) that will be executed. Defaults to the
        /// resource name suffix, if not specified. For backward compatibility, if function with given name is not
        /// found, then the system will try to use function named "function".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionTarget")]
        public virtual string FunctionTarget { get; set; }

        /// <summary>Optional. Artifact Registry URI to store the built image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>Output only. The Cloud Build name of the latest successful deployment of the function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Service account to be used for building the container. The format of this field is
        /// `projects/{projectId}/serviceAccounts/{serviceAccountEmail}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The Cloud Storage bucket URI where the function source code is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLocation")]
        public virtual string SourceLocation { get; set; }

        /// <summary>
        /// Optional. Name of the Cloud Build Custom Worker Pool that should be used to build the Cloud Run function.
        /// The format of this field is `projects/{project}/locations/{region}/workerPools/{workerPool}` where
        /// `{project}` and `{region}` are the project id and region respectively where the worker pool is defined and
        /// `{workerPool}` is the short name of the worker pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Build information of the image.</summary>
    public class GoogleCloudRunV2BuildInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Entry point of the function when the image is a Cloud Run function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionTarget")]
        public virtual string FunctionTarget { get; set; }

        /// <summary>Output only. Source code location of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLocation")]
        public virtual string SourceLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Build the source using Buildpacks.</summary>
    public class GoogleCloudRunV2BuildpacksBuild : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The base image to use for the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseImage")]
        public virtual string BaseImage { get; set; }

        /// <summary>
        /// Optional. cache_image_uri is the GCR/AR URL where the cache image will be stored. cache_image_uri is
        /// optional and omitting it will disable caching. This URL must be stable across builds. It is used to derive a
        /// build-specific temporary URL by substituting the tag with the build ID. The build will clean up the
        /// temporary image on a best-effort basis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheImageUri")]
        public virtual string CacheImageUri { get; set; }

        /// <summary>
        /// Optional. Whether or not the application container will be enrolled in automatic base image updates. When
        /// true, the application will be built on a scratch base image, so the base layers can be appended at run time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAutomaticUpdates")]
        public virtual System.Nullable<bool> EnableAutomaticUpdates { get; set; }

        /// <summary>Optional. User-provided build-time environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// Optional. Name of the function target if the source is a function source. Required for function builds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionTarget")]
        public virtual string FunctionTarget { get; set; }

        /// <summary>
        /// Optional. project_descriptor stores the path to the project descriptor file. When empty, it means that there
        /// is no project descriptor file in the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDescriptor")]
        public virtual string ProjectDescriptor { get; set; }

        /// <summary>The runtime name, e.g. 'go113'. Leave blank for generic builds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtime")]
        public virtual string Runtime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for deleting an Execution.</summary>
    public class GoogleCloudRunV2CancelExecutionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A system-generated fingerprint for this version of the resource. This may be used to detect modification
        /// conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Indicates that the request should be validated without actually cancelling any resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    /// <summary>
    /// Represents a set of Cloud SQL instances. Each one will be available under /cloudsql/[instance]. Visit
    /// https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud
    /// Run.
    /// </summary>
    public class GoogleCloudRunV2CloudSqlInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances.
        /// Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL
        /// and Cloud Run. Format: {project}:{location}:{instance}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<string> Instances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a status condition for a resource.</summary>
    public class GoogleCloudRunV2Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A reason for the execution condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionReason")]
        public virtual string ExecutionReason { get; set; }

        private string _lastTransitionTimeRaw;

        private object _lastTransitionTime;

        /// <summary>Last time the condition transitioned from one status to another.</summary>
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

        /// <summary>Human readable message indicating details about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Output only. A common (service-level) reason for this condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Output only. A reason for the revision condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionReason")]
        public virtual string RevisionReason { get; set; }

        /// <summary>How to interpret failures of this condition, one of Error, Warning, Info</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>State of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// type is used to communicate the status of the reconciliation process. See also:
        /// https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common
        /// to all resources include: * "Ready": True when the Resource is ready.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single application container. This specifies both the container to run, the command to run in the container
    /// and the arguments to supply to it. Note that additional arguments can be supplied by the system to the container
    /// at runtime.
    /// </summary>
    public class GoogleCloudRunV2Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Base image for this container. Only supported for services. If set, it indicates that the service is
        /// enrolled into automatic base image update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseImageUri")]
        public virtual string BaseImageUri { get; set; }

        /// <summary>Output only. The build info of the container image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildInfo")]
        public virtual GoogleCloudRunV2BuildInfo BuildInfo { get; set; }

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not
        /// provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>Names of the containers that must start before this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependsOn")]
        public virtual System.Collections.Generic.IList<string> DependsOn { get; set; }

        /// <summary>List of environment variables to set in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2EnvVar> Env { get; set; }

        /// <summary>
        /// Required. Name of the container image in Dockerhub, Google Artifact Registry, or Google Container Registry.
        /// If the host is not provided, Dockerhub is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("livenessProbe")]
        public virtual GoogleCloudRunV2Probe LivenessProbe { get; set; }

        /// <summary>Name of the container specified as a DNS_LABEL (RFC 1123).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// List of ports to expose from the container. Only a single port can be specified. The specified ports must be
        /// listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a port number will
        /// be chosen and passed to the container through the PORT environment variable for the container to listen on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2ContainerPort> Ports { get; set; }

        /// <summary>Compute Resource requirements by this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual GoogleCloudRunV2ResourceRequirements Resources { get; set; }

        /// <summary>
        /// Startup probe of application within the container. All other probes are disabled if a startup probe is
        /// provided, until it succeeds. Container will not be added to service endpoints if the probe fails.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startupProbe")]
        public virtual GoogleCloudRunV2Probe StartupProbe { get; set; }

        /// <summary>Volume to mount into the container's filesystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeMounts")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// Container's working directory. If not specified, the container runtime's default will be used, which might
        /// be configured in the container image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workingDir")]
        public virtual string WorkingDir { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Per-container override specification.</summary>
    public class GoogleCloudRunV2ContainerOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Arguments to the entrypoint. Will replace existing args for override.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>Optional. True if the intention is to clear out existing args list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clearArgs")]
        public virtual System.Nullable<bool> ClearArgs { get; set; }

        /// <summary>
        /// List of environment variables to set in the container. Will be merged with existing env for override.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2EnvVar> Env { get; set; }

        /// <summary>The name of the container specified as a DNS_LABEL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ContainerPort represents a network port in a single container.</summary>
    public class GoogleCloudRunV2ContainerPort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Port number the container listens on. This must be a valid TCP port number, 0 &amp;lt; container_port
        /// &amp;lt; 65536.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerPort")]
        public virtual System.Nullable<int> ContainerPort { get; set; }

        /// <summary>
        /// If specified, used to specify which protocol to use. Allowed values are "http1" and "h2c".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Build the source using Docker. This means the source has a Dockerfile.</summary>
    public class GoogleCloudRunV2DockerBuild : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// In memory (tmpfs) ephemeral storage. It is ephemeral in the sense that when the sandbox is taken down, the data
    /// is destroyed with it (it does not persist across sandbox runs).
    /// </summary>
    public class GoogleCloudRunV2EmptyDirVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The medium on which the data is stored. Acceptable values today is only MEMORY or none. When none, the
        /// default will currently be backed by memory but could change over time. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>
        /// Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium.
        /// The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here
        /// and the sum of memory limits of all containers. The default is nil which means that the limit is undefined.
        /// More info: https://cloud.google.com/run/docs/configuring/in-memory-volumes#configure-volume. Info in
        /// Kubernetes: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeLimit")]
        public virtual string SizeLimit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVar represents an environment variable present in a Container.</summary>
    public class GoogleCloudRunV2EnvVar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Name of the environment variable. Must not exceed 32768 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Literal value of the environment variable. Defaults to "", and the maximum length is 32768 bytes. Variable
        /// references are not supported in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>Source for the environment variable's value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueSource")]
        public virtual GoogleCloudRunV2EnvVarSource ValueSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>
    public class GoogleCloudRunV2EnvVarSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretKeyRef")]
        public virtual GoogleCloudRunV2SecretKeySelector SecretKeyRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Execution represents the configuration of a single execution. A execution an immutable resource that references
    /// a container image which is run to completion.
    /// </summary>
    public class GoogleCloudRunV2Execution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Unstructured key value map that may be set by external tools to store and arbitrary metadata.
        /// They are not queryable and should be preserved when modifying objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. The number of tasks which reached phase Cancelled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelledCount")]
        public virtual System.Nullable<int> CancelledCount { get; set; }

        private string _completionTimeRaw;

        private object _completionTime;

        /// <summary>
        /// Output only. Represents time when the execution was completed. It is not guaranteed to be set in
        /// happens-before order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual string CompletionTimeRaw
        {
            get => _completionTimeRaw;
            set
            {
                _completionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletionTimeDateTimeOffset instead.")]
        public virtual object CompletionTime
        {
            get => _completionTime;
            set
            {
                _completionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CompletionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletionTimeRaw);
            set => CompletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The Condition of this Execution, containing its readiness status, and detailed error
        /// information in case it did not reach the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. Represents time when the execution was acknowledged by the execution controller. It is not
        /// guaranteed to be set in happens-before order across separate operations.
        /// </summary>
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

        /// <summary>Output only. Email address of the authenticated creator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. For a deleted resource, the deletion time. It is only populated as a response to a Delete
        /// request.
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

        /// <summary>
        /// Output only. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. For a deleted resource, the time after which it will be permamently deleted. It is only
        /// populated as a response to a Delete request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The number of tasks which reached phase Failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedCount")]
        public virtual System.Nullable<int> FailedCount { get; set; }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>Output only. The name of the parent Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual string Job { get; set; }

        /// <summary>
        /// Output only. Unstructured key value map that can be used to organize and categorize objects. User-provided
        /// labels are shared with Google's billing system, so they can be used to filter, or break down billing charges
        /// by team, component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The least stable launch stage needed to create this resource, as defined by [Google Cloud Platform Launch
        /// Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. Note
        /// that this value might not be what was used as input. For example, if ALPHA was provided as input in the
        /// parent resource, but only BETA and GA-level features are were, this field will be BETA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Output only. URI where logs for this execution can be found in Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUri")]
        public virtual string LogUri { get; set; }

        /// <summary>Output only. The unique name of this Execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this Execution. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Specifies the maximum desired number of tasks the execution should run at any given time. Must
        /// be &amp;lt;= task_count. The actual number of tasks running in steady state will be less than this number
        /// when ((.spec.task_count - .status.successful) &amp;lt; .spec.parallelism), i.e. when the work left to do is
        /// less than max parallelism.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelism")]
        public virtual System.Nullable<int> Parallelism { get; set; }

        /// <summary>
        /// Output only. Indicates whether the resource's reconciliation is still in progress. See comments in
        /// `Job.reconciling` for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. The number of tasks which have retried at least once.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retriedCount")]
        public virtual System.Nullable<int> RetriedCount { get; set; }

        /// <summary>Output only. The number of actively running tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runningCount")]
        public virtual System.Nullable<int> RunningCount { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Output only. Represents time when the execution started to run. It is not guaranteed to be set in
        /// happens-before order across separate operations.
        /// </summary>
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

        /// <summary>Output only. The number of tasks which reached phase Succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeededCount")]
        public virtual System.Nullable<int> SucceededCount { get; set; }

        /// <summary>
        /// Output only. Specifies the desired number of tasks the execution should run. Setting to 1 means that
        /// parallelism is limited to 1 and the success of that task signals the success of the execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCount")]
        public virtual System.Nullable<int> TaskCount { get; set; }

        /// <summary>Output only. The template used to create tasks for this execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2TaskTemplate Template { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last-modified time.</summary>
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

    /// <summary>
    /// Reference to an Execution. Use /Executions.GetExecution with the given name to get full execution including the
    /// latest status.
    /// </summary>
    public class GoogleCloudRunV2ExecutionReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Status for the execution completion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionStatus")]
        public virtual string CompletionStatus { get; set; }

        private string _completionTimeRaw;

        private object _completionTime;

        /// <summary>Creation timestamp of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual string CompletionTimeRaw
        {
            get => _completionTimeRaw;
            set
            {
                _completionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletionTimeDateTimeOffset instead.")]
        public virtual object CompletionTime
        {
            get => _completionTime;
            set
            {
                _completionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CompletionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletionTimeRaw);
            set => CompletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Creation timestamp of the execution.</summary>
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
        /// The deletion time of the execution. It is only populated as a response to a Delete request.
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

        /// <summary>Name of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExecutionTemplate describes the data an execution should have when created from a template.</summary>
    public class GoogleCloudRunV2ExecutionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not
        /// queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with
        /// `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
        /// namespaces, and they will be rejected. All system annotations in v1 now have a corresponding field in v2
        /// ExecutionTemplate. This field follows Kubernetes annotations' namespacing, limits, and rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are
        /// shared with Google's billing system, so they can be used to filter, or break down billing charges by team,
        /// component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with
        /// `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
        /// namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2
        /// ExecutionTemplate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Specifies the maximum desired number of tasks the execution should run at given time. When the job
        /// is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual
        /// number of tasks running in steady state will be less than this number when there are fewer tasks waiting to
        /// be completed remaining, i.e. when the work left to do is less than max parallelism.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelism")]
        public virtual System.Nullable<int> Parallelism { get; set; }

        /// <summary>
        /// Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is
        /// limited to 1 and the success of that task signals the success of the execution. Defaults to 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCount")]
        public virtual System.Nullable<int> TaskCount { get; set; }

        /// <summary>Required. Describes the task(s) that will be created when executing an execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2TaskTemplate Template { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for exporting Cloud Run image.</summary>
    public class GoogleCloudRunV2ExportImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The export destination url (the Artifact Registry repo).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationRepo")]
        public virtual string DestinationRepo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExportImageResponse contains an operation Id to track the image export operation.</summary>
    public class GoogleCloudRunV2ExportImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An operation ID used to track the status of image exports tied to the original pod ID in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ExportStatusResponse contains the status of image export operation, with the status of each image export job.
    /// </summary>
    public class GoogleCloudRunV2ExportStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status of each image export job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageExportStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2ImageExportStatus> ImageExportStatuses { get; set; }

        /// <summary>The operation id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>Output only. The state of the overall export operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationState")]
        public virtual string OperationState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a volume backed by a Cloud Storage bucket using Cloud Storage FUSE.</summary>
    public class GoogleCloudRunV2GCSVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage Bucket name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// A list of additional flags to pass to the gcsfuse CLI. Options should be specified without the leading "--".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountOptions")]
        public virtual System.Collections.Generic.IList<string> MountOptions { get; set; }

        /// <summary>If true, the volume will be mounted as read only for all mounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GRPCAction describes an action involving a GRPC port.</summary>
    public class GoogleCloudRunV2GRPCAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Port number of the gRPC service. Number must be in the range 1 to 65535. If not specified,
        /// defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Optional. Service is the name of the service to place in the gRPC HealthCheckRequest (see
        /// https://github.com/grpc/grpc/blob/master/doc/health-checking.md ). If this is not specified, the default
        /// behavior is defined by gRPC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTPGetAction describes an action based on HTTP Get requests.</summary>
    public class GoogleCloudRunV2HTTPGetAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Custom headers to set in the request. HTTP allows repeated headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpHeaders")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2HTTPHeader> HttpHeaders { get; set; }

        /// <summary>Optional. Path to access on the HTTP server. Defaults to '/'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified,
        /// defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>
    public class GoogleCloudRunV2HTTPHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The header field name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The header field value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of an image export job.</summary>
    public class GoogleCloudRunV2ImageExportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Has the image export job finished (regardless of successful or failure).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportJobState")]
        public virtual string ExportJobState { get; set; }

        /// <summary>The exported image ID as it will appear in Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportedImageDigest")]
        public virtual string ExportedImageDigest { get; set; }

        /// <summary>The status of the export task if done.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual UtilStatusProto Status { get; set; }

        /// <summary>The image tag as it will appear in Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Holds a single instance split entry for the Worker. Allocations can be done to a specific Revision name, or
    /// pointing to the latest Ready Revision.
    /// </summary>
    public class GoogleCloudRunV2InstanceSplit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies percent of the instance split to this Revision. This defaults to zero if unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>
        /// Revision to which to assign this portion of instances, if split allocation is by revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The allocation type for this instance split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the observed state of a single `InstanceSplit` entry.</summary>
    public class GoogleCloudRunV2InstanceSplitStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies percent of the instance split to this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>Revision to which this instance split is assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The allocation type for this instance split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Job represents the configuration of a single job, which references a container image that is run to completion.
    /// </summary>
    public class GoogleCloudRunV2Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured key value map that may be set by external tools to store and arbitrary metadata. They are not
        /// queryable and should be preserved when modifying objects. Cloud Run API v2 does not support annotations with
        /// `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
        /// namespaces, and they will be rejected on new resources. All system annotations in v1 now have a
        /// corresponding field in v2 Job. This field follows Kubernetes annotations' namespacing, limits, and rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Settings for the Binary Authorization feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual GoogleCloudRunV2BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>Arbitrary identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Arbitrary version identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientVersion")]
        public virtual string ClientVersion { get; set; }

        /// <summary>
        /// Output only. The Conditions of all other associated sub-resources. They contain additional diagnostics
        /// information in case the Job does not reach its desired state. See comments in `reconciling` for additional
        /// information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation time.</summary>
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

        /// <summary>Output only. Email address of the authenticated creator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The deletion time. It is only populated as a response to a Delete request.</summary>
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

        /// <summary>
        /// Optional. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Number of executions created for this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionCount")]
        public virtual System.Nullable<int> ExecutionCount { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. For a deleted resource, the time after which it will be permamently deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Unstructured key value map that can be used to organize and categorize objects. User-provided labels are
        /// shared with Google's billing system, so they can be used to filter, or break down billing charges by team,
        /// component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with
        /// `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
        /// namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 Job.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Email address of the last authenticated modifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifier")]
        public virtual string LastModifier { get; set; }

        /// <summary>Output only. Name of the last created execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedExecution")]
        public virtual GoogleCloudRunV2ExecutionReference LatestCreatedExecution { get; set; }

        /// <summary>
        /// The launch stage as defined by [Google Cloud Platform Launch
        /// Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no
        /// value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview
        /// features in that stage. On read (or output), describes whether the resource uses preview features. For
        /// example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be
        /// BETA on output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The fully qualified name of this Job. Format: projects/{project}/locations/{location}/jobs/{job}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this Job. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Returns true if the Job is currently being acted upon by the system to bring it into the
        /// desired state. When a new Job is created, or an existing one is updated, Cloud Run will asynchronously
        /// perform all necessary steps to bring the Job to the desired state. This process is called reconciliation.
        /// While reconciliation is in process, `observed_generation` and `latest_succeeded_execution`, will have
        /// transient values that might mismatch the intended state: Once reconciliation is over (and this field is
        /// false), there are two possible outcomes: reconciliation succeeded and the state matches the Job, or there
        /// was an error, and reconciliation failed. This state can be found in `terminal_condition.state`. If
        /// reconciliation succeeded, the following fields will match: `observed_generation` and `generation`,
        /// `latest_succeeded_execution` and `latest_created_execution`. If reconciliation failed, `observed_generation`
        /// and `latest_succeeded_execution` will have the state of the last succeeded execution or empty for newly
        /// created Job. Additional information on the failure can be found in `terminal_condition` and `conditions`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// A unique string used as a suffix for creating a new execution. The Job will become ready when the execution
        /// is successfully completed. The sum of job name and token length must be fewer than 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runExecutionToken")]
        public virtual string RunExecutionToken { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>
        /// A unique string used as a suffix creating a new execution. The Job will become ready when the execution is
        /// successfully started. The sum of job name and token length must be fewer than 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startExecutionToken")]
        public virtual string StartExecutionToken { get; set; }

        /// <summary>Required. The template used to create executions for this Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2ExecutionTemplate Template { get; set; }

        /// <summary>
        /// Output only. The Condition of this Job, containing its readiness status, and detailed error information in
        /// case it did not reach the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminalCondition")]
        public virtual GoogleCloudRunV2Condition TerminalCondition { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last-modified time.</summary>
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

    /// <summary>Response message containing a list of Executions.</summary>
    public class GoogleCloudRunV2ListExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting list of Executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Execution> Executions { get; set; }

        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListExecutions request to
        /// continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of Jobs.</summary>
    public class GoogleCloudRunV2ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resulting list of Jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Job> Jobs { get; set; }

        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListJobs request to continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of Revisions.</summary>
    public class GoogleCloudRunV2ListRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListRevisions request to
        /// continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting list of Revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Revision> Revisions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of Services.</summary>
    public class GoogleCloudRunV2ListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListServices request to continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting list of Services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Service> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of Tasks.</summary>
    public class GoogleCloudRunV2ListTasksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListTasks request to continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting list of Tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tasks")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Task> Tasks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message containing a list of WorkerPools.</summary>
    public class GoogleCloudRunV2ListWorkerPoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token indicating there are more items than page_size. Use it in the next ListWorkerPools request to
        /// continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting list of WorkerPools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPools")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2WorkerPool> WorkerPools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata represents the JSON encoded generated customer metadata.</summary>
    public class GoogleCloudRunV2Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>JSON encoded Google-generated Customer Metadata for a given resource/project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual string Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for multi-region deployment.</summary>
    public class GoogleCloudRunV2MultiRegionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. System-generated unique id for the multi-region Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionId")]
        public virtual string MultiRegionId { get; set; }

        /// <summary>Required. List of regions to deploy to, including primary region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an NFS mount.</summary>
    public class GoogleCloudRunV2NFSVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path that is exported by the NFS server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>If true, the volume will be mounted as read only for all mounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>Hostname or IP address of the NFS server</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("server")]
        public virtual string Server { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Direct VPC egress settings.</summary>
    public class GoogleCloudRunV2NetworkInterface : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The VPC network that the Cloud Run resource will be able to send traffic to. At least one of
        /// network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC
        /// subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the
        /// subnetwork.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or
        /// subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must
        /// belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the
        /// network will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>Optional. Network tags applied to this Cloud Run resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Hardware constraints configuration.</summary>
    public class GoogleCloudRunV2NodeSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. GPU accelerator type to attach to an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerator")]
        public virtual string Accelerator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RunJob Overrides that contains Execution fields to be overridden.</summary>
    public class GoogleCloudRunV2Overrides : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Per container override specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerOverrides")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2ContainerOverride> ContainerOverrides { get; set; }

        /// <summary>
        /// Optional. The desired number of tasks the execution should run. Will replace existing task_count value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taskCount")]
        public virtual System.Nullable<int> TaskCount { get; set; }

        /// <summary>
        /// Duration in seconds the task may be active before the system will actively try to mark it failed and kill
        /// associated containers. Will replace existing timeout_seconds value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Probe describes a health check to be performed against a container to determine whether it is alive or ready to
    /// receive traffic.
    /// </summary>
    public class GoogleCloudRunV2Probe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Minimum consecutive failures for the probe to be considered failed after having succeeded.
        /// Defaults to 3. Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureThreshold")]
        public virtual System.Nullable<int> FailureThreshold { get; set; }

        /// <summary>
        /// Optional. GRPC specifies an action involving a gRPC port. Exactly one of httpGet, tcpSocket, or grpc must be
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grpc")]
        public virtual GoogleCloudRunV2GRPCAction Grpc { get; set; }

        /// <summary>
        /// Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpGet")]
        public virtual GoogleCloudRunV2HTTPGetAction HttpGet { get; set; }

        /// <summary>
        /// Optional. Number of seconds after the container has started before the probe is initiated. Defaults to 0
        /// seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is
        /// 240.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialDelaySeconds")]
        public virtual System.Nullable<int> InitialDelaySeconds { get; set; }

        /// <summary>
        /// Optional. How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum
        /// value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than
        /// timeout_seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodSeconds")]
        public virtual System.Nullable<int> PeriodSeconds { get; set; }

        /// <summary>
        /// Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc
        /// must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcpSocket")]
        public virtual GoogleCloudRunV2TCPSocketAction TcpSocket { get; set; }

        /// <summary>
        /// Optional. Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1.
        /// Maximum value is 3600. Must be smaller than period_seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<int> TimeoutSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    public class GoogleCloudRunV2ResourceRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Determines whether CPU is only allocated during requests (true by default). However, if ResourceRequirements
        /// is set, the caller must explicitly set this field to true to preserve the default behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuIdle")]
        public virtual System.Nullable<bool> CpuIdle { get; set; }

        /// <summary>
        /// Only `memory` and `cpu` keys in the map are supported. Notes: * The only supported values for CPU are '1',
        /// '2', '4', and '8'. Setting 4 CPU requires at least 2Gi of memory. For more information, go to
        /// https://cloud.google.com/run/docs/configuring/cpu. * For supported 'memory' values and syntax, go to
        /// https://cloud.google.com/run/docs/configuring/memory-limits
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual System.Collections.Generic.IDictionary<string, string> Limits { get; set; }

        /// <summary>
        /// Determines whether CPU should be boosted on startup of a new container instance above the requested CPU
        /// threshold, this can help reduce cold-start latency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startupCpuBoost")]
        public virtual System.Nullable<bool> StartupCpuBoost { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Revision is an immutable snapshot of code and configuration. A Revision references a container image.
    /// Revisions are only created by updates to its parent Service.
    /// </summary>
    public class GoogleCloudRunV2Revision : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Unstructured key value map that may be set by external tools to store and arbitrary metadata.
        /// They are not queryable and should be preserved when modifying objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Output only. The Condition of this Revision, containing its readiness status, and detailed error information
        /// in case it did not reach a serving state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        /// <summary>Holds the single container that defines the unit of execution for this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation time.</summary>
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

        /// <summary>Output only. Email address of the authenticated creator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. For a deleted resource, the deletion time. It is only populated as a response to a Delete
        /// request.
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

        /// <summary>
        /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more
        /// information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>The action to take if the encryption key is revoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyRevocationAction")]
        public virtual string EncryptionKeyRevocationAction { get; set; }

        /// <summary>
        /// If encryption_key_revocation_action is SHUTDOWN, the duration before shutting down all instances. The
        /// minimum increment is 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyShutdownDuration")]
        public virtual object EncryptionKeyShutdownDuration { get; set; }

        /// <summary>
        /// Output only. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The execution environment being used to host this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionEnvironment")]
        public virtual string ExecutionEnvironment { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. For a deleted resource, the time after which it will be permamently deleted. It is only
        /// populated as a response to a Delete request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>Optional. Output only. True if GPU zonal redundancy is disabled on this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuZonalRedundancyDisabled")]
        public virtual System.Nullable<bool> GpuZonalRedundancyDisabled { get; set; }

        /// <summary>
        /// Output only. Unstructured key value map that can be used to organize and categorize objects. User-provided
        /// labels are shared with Google's billing system, so they can be used to filter, or break down billing charges
        /// by team, component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The least stable launch stage needed to create this resource, as defined by [Google Cloud Platform Launch
        /// Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. Note
        /// that this value might not be what was used as input. For example, if ALPHA was provided as input in the
        /// parent resource, but only BETA and GA-level features are were, this field will be BETA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Output only. The Google Console URI to obtain logs for the Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUri")]
        public virtual string LogUri { get; set; }

        /// <summary>Sets the maximum number of requests that each serving instance can receive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceRequestConcurrency")]
        public virtual System.Nullable<int> MaxInstanceRequestConcurrency { get; set; }

        /// <summary>Output only. The unique name of this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The node selector for the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSelector")]
        public virtual GoogleCloudRunV2NodeSelector NodeSelector { get; set; }

        /// <summary>
        /// Output only. The generation of this Revision currently serving traffic. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Indicates whether the resource's reconciliation is still in progress. See comments in
        /// `Service.reconciling` for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Scaling settings for this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaling")]
        public virtual GoogleCloudRunV2RevisionScaling Scaling { get; set; }

        /// <summary>Output only. The current effective scaling settings for the revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalingStatus")]
        public virtual GoogleCloudRunV2RevisionScalingStatus ScalingStatus { get; set; }

        /// <summary>Output only. The name of the parent service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// Email address of the IAM service account associated with the revision of the service. The service account
        /// represents the identity of the running revision, and determines what permissions the revision has.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Enables service mesh connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceMesh")]
        public virtual GoogleCloudRunV2ServiceMesh ServiceMesh { get; set; }

        /// <summary>Enable session affinity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionAffinity")]
        public virtual System.Nullable<bool> SessionAffinity { get; set; }

        /// <summary>Max allowed time for an instance to respond to a request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the Revision. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last-modified time.</summary>
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

        /// <summary>A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// VPC Access configuration for this Revision. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }
    }

    /// <summary>Settings for revision-level scaling settings.</summary>
    public class GoogleCloudRunV2RevisionScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Maximum number of serving instances that this resource should have. When unspecified, the field is
        /// set to the server default value of 100. For more information see
        /// https://cloud.google.com/run/docs/configuring/max-instances
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceCount")]
        public virtual System.Nullable<int> MaxInstanceCount { get; set; }

        /// <summary>Optional. Minimum number of serving instances that this resource should have.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minInstanceCount")]
        public virtual System.Nullable<int> MinInstanceCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Effective settings for the current revision</summary>
    public class GoogleCloudRunV2RevisionScalingStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current number of min instances provisioned for this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredMinInstanceCount")]
        public virtual System.Nullable<int> DesiredMinInstanceCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RevisionTemplate describes the data a revision should have when created from a template.</summary>
    public class GoogleCloudRunV2RevisionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Unstructured key value map that may be set by external tools to store and arbitrary metadata. They
        /// are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support
        /// annotations with `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or
        /// `autoscaling.knative.dev` namespaces, and they will be rejected. All system annotations in v1 now have a
        /// corresponding field in v2 RevisionTemplate. This field follows Kubernetes annotations' namespacing, limits,
        /// and rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Holds the single container that defines the unit of execution for this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        /// <summary>
        /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more
        /// information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>Optional. The action to take if the encryption key is revoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyRevocationAction")]
        public virtual string EncryptionKeyRevocationAction { get; set; }

        /// <summary>
        /// Optional. If encryption_key_revocation_action is SHUTDOWN, the duration before shutting down all instances.
        /// The minimum increment is 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyShutdownDuration")]
        public virtual object EncryptionKeyShutdownDuration { get; set; }

        /// <summary>Optional. The sandbox environment to host this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionEnvironment")]
        public virtual string ExecutionEnvironment { get; set; }

        /// <summary>Optional. True if GPU zonal redundancy is disabled on this revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuZonalRedundancyDisabled")]
        public virtual System.Nullable<bool> GpuZonalRedundancyDisabled { get; set; }

        /// <summary>Optional. Disables health checking containers during deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckDisabled")]
        public virtual System.Nullable<bool> HealthCheckDisabled { get; set; }

        /// <summary>
        /// Optional. Unstructured key value map that can be used to organize and categorize objects. User-provided
        /// labels are shared with Google's billing system, so they can be used to filter, or break down billing charges
        /// by team, component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with
        /// `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
        /// namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2
        /// RevisionTemplate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. Sets the maximum number of requests that each serving instance can receive. If not specified or 0,
        /// concurrency defaults to 80 when requested `CPU &amp;gt;= 1` and defaults to 1 when requested `CPU &amp;lt;
        /// 1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceRequestConcurrency")]
        public virtual System.Nullable<int> MaxInstanceRequestConcurrency { get; set; }

        /// <summary>Optional. The node selector for the revision template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSelector")]
        public virtual GoogleCloudRunV2NodeSelector NodeSelector { get; set; }

        /// <summary>
        /// Optional. The unique name for the revision. If this field is omitted, it will be automatically generated
        /// based on the Service name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>Optional. Scaling settings for this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaling")]
        public virtual GoogleCloudRunV2RevisionScaling Scaling { get; set; }

        /// <summary>
        /// Optional. Email address of the IAM service account associated with the revision of the service. The service
        /// account represents the identity of the running revision, and determines what permissions the revision has.
        /// If not provided, the revision will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Optional. Enables service mesh connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceMesh")]
        public virtual GoogleCloudRunV2ServiceMesh ServiceMesh { get; set; }

        /// <summary>Optional. Enable session affinity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionAffinity")]
        public virtual System.Nullable<bool> SessionAffinity { get; set; }

        /// <summary>Optional. Max allowed time for an instance to respond to a request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>Optional. A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// Optional. VPC Access configuration to use for this Revision. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to create a new Execution of a Job.</summary>
    public class GoogleCloudRunV2RunJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A system-generated fingerprint for this version of the resource. May be used to detect modification conflict
        /// during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Overrides specification for a given execution of a job. If provided, overrides will be applied to update the
        /// execution or task spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrides")]
        public virtual GoogleCloudRunV2Overrides Overrides { get; set; }

        /// <summary>Indicates that the request should be validated without actually deleting any resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }
    }

    /// <summary>SecretEnvVarSource represents a source for the value of an EnvVar.</summary>
    public class GoogleCloudRunV2SecretKeySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the secret in Cloud Secret Manager. Format: {secret_name} if the secret is in the same
        /// project. projects/{project}/secrets/{secret_name} if the secret is in a different project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>
        /// The Cloud Secret Manager secret version. Can be 'latest' for the latest version, an integer for a specific
        /// version, or a version alias.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The secret's value will be presented as the content of a file whose name is defined in the item path. If no
    /// items are defined, the name of the file is the secret.
    /// </summary>
    public class GoogleCloudRunV2SecretVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integer representation of mode bits to use on created files by default. Must be a value between 0000 and
        /// 0777 (octal), defaulting to 0444. Directories within the path are not affected by this setting. Notes *
        /// Internally, a umask of 0222 will be applied to any non-zero value. * This is an integer representation of
        /// the mode bits. So, the octal integer value should look exactly as the chmod numeric notation with a leading
        /// zero. Some examples: for chmod 640 (u=rw,g=r), set to 0640 (octal) or 416 (base-10). For chmod 755
        /// (u=rwx,g=rx,o=rx), set to 0755 (octal) or 493 (base-10). * This might be in conflict with other options that
        /// affect the file mode, like fsGroup, and the result can be other mode bits set. This might be in conflict
        /// with other options that affect the file mode, like fsGroup, and as a result, other mode bits could be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMode")]
        public virtual System.Nullable<int> DefaultMode { get; set; }

        /// <summary>
        /// If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path.
        /// If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be
        /// the name of the file exposed in the volume. When items are defined, they must specify a path and a version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2VersionToPath> Items { get; set; }

        /// <summary>
        /// Required. The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same
        /// project. projects/{project}/secrets/{secret} if the secret is in a different project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Service acts as a top-level container that manages a set of configurations and revision templates which
    /// implement a network service. Service exists to provide a singular abstraction which can be access controlled,
    /// reasoned about, and which encapsulates software lifecycle decisions such as rollout policy and team resource
    /// ownership.
    /// </summary>
    public class GoogleCloudRunV2Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Unstructured key value map that may be set by external tools to store and arbitrary metadata. They
        /// are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support
        /// annotations with `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or
        /// `autoscaling.knative.dev` namespaces, and they will be rejected in new resources. All system annotations in
        /// v1 now have a corresponding field in v2 Service. This field follows Kubernetes annotations' namespacing,
        /// limits, and rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Optional. Settings for the Binary Authorization feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual GoogleCloudRunV2BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>Optional. Configuration for building a Cloud Run function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildConfig")]
        public virtual GoogleCloudRunV2BuildConfig BuildConfig { get; set; }

        /// <summary>Arbitrary identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Arbitrary version identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientVersion")]
        public virtual string ClientVersion { get; set; }

        /// <summary>
        /// Output only. The Conditions of all other associated sub-resources. They contain additional diagnostics
        /// information in case the Service does not reach its Serving state. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation time.</summary>
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

        /// <summary>Output only. Email address of the authenticated creator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>
        /// One or more custom audiences that you want this service to support. Specify each custom audience as the full
        /// URL in a string. The custom audiences are encoded in the token and used to authenticate requests. For more
        /// information, see https://cloud.google.com/run/docs/configuring/custom-audiences.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAudiences")]
        public virtual System.Collections.Generic.IList<string> CustomAudiences { get; set; }

        /// <summary>Optional. Disables public resolution of the default URI of this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultUriDisabled")]
        public virtual System.Nullable<bool> DefaultUriDisabled { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The deletion time. It is only populated as a response to a Delete request.</summary>
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

        /// <summary>User-provided description of the Service. This field currently has a 512-character limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. For a deleted resource, the time after which it will be permanently deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state. Please
        /// note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a
        /// `string` instead of an `integer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>Optional. IAP settings on the Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iapEnabled")]
        public virtual System.Nullable<bool> IapEnabled { get; set; }

        /// <summary>
        /// Optional. Provides the ingress settings for this Service. On output, returns the currently observed ingress
        /// settings, or INGRESS_TRAFFIC_UNSPECIFIED if no revision is active.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingress")]
        public virtual string Ingress { get; set; }

        /// <summary>
        /// Optional. Disables IAM permission check for run.routes.invoke for callers of this service. For more
        /// information, visit https://cloud.google.com/run/docs/securing/managing-access#invoker_check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invokerIamDisabled")]
        public virtual System.Nullable<bool> InvokerIamDisabled { get; set; }

        /// <summary>
        /// Optional. Unstructured key value map that can be used to organize and categorize objects. User-provided
        /// labels are shared with Google's billing system, so they can be used to filter, or break down billing charges
        /// by team, component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with
        /// `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
        /// namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2 Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Email address of the last authenticated modifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifier")]
        public virtual string LastModifier { get; set; }

        /// <summary>
        /// Output only. Name of the last created revision. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedRevision")]
        public virtual string LatestCreatedRevision { get; set; }

        /// <summary>
        /// Output only. Name of the latest revision that is serving traffic. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReadyRevision")]
        public virtual string LatestReadyRevision { get; set; }

        /// <summary>
        /// Optional. The launch stage as defined by [Google Cloud Platform Launch
        /// Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no
        /// value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview
        /// features in that stage. On read (or output), describes whether the resource uses preview features. For
        /// example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be
        /// BETA on output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Optional. Settings for multi-region deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiRegionSettings")]
        public virtual GoogleCloudRunV2MultiRegionSettings MultiRegionSettings { get; set; }

        /// <summary>
        /// The fully qualified name of this Service. In CreateServiceRequest, this field is ignored, and instead
        /// composed from CreateServiceRequest.parent and CreateServiceRequest.service_id. Format:
        /// projects/{project}/locations/{location}/services/{service_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this Service currently serving traffic. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64
        /// value. As with most Google APIs, its JSON representation will be a `string` instead of an `integer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Returns true if the Service is currently being acted upon by the system to bring it into the
        /// desired state. When a new Service is created, or an existing one is updated, Cloud Run will asynchronously
        /// perform all necessary steps to bring the Service to the desired serving state. This process is called
        /// reconciliation. While reconciliation is in process, `observed_generation`, `latest_ready_revision`,
        /// `traffic_statuses`, and `uri` will have transient values that might mismatch the intended state: Once
        /// reconciliation is over (and this field is false), there are two possible outcomes: reconciliation succeeded
        /// and the serving state matches the Service, or there was an error, and reconciliation failed. This state can
        /// be found in `terminal_condition.state`. If reconciliation succeeded, the following fields will match:
        /// `traffic` and `traffic_statuses`, `observed_generation` and `generation`, `latest_ready_revision` and
        /// `latest_created_revision`. If reconciliation failed, `traffic_statuses`, `observed_generation`, and
        /// `latest_ready_revision` will have the state of the last serving revision, or empty for newly created
        /// Services. Additional information on the failure can be found in `terminal_condition` and `conditions`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Optional. Specifies service-level scaling settings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaling")]
        public virtual GoogleCloudRunV2ServiceScaling Scaling { get; set; }

        /// <summary>Required. The template used to create revisions for this Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2RevisionTemplate Template { get; set; }

        /// <summary>
        /// Output only. The Condition of this Service, containing its readiness status, and detailed error information
        /// in case it did not reach a serving state. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminalCondition")]
        public virtual GoogleCloudRunV2Condition TerminalCondition { get; set; }

        /// <summary>
        /// Output only. True if Cloud Run Threat Detection monitoring is enabled for the parent project of this
        /// Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatDetectionEnabled")]
        public virtual System.Nullable<bool> ThreatDetectionEnabled { get; set; }

        /// <summary>
        /// Optional. Specifies how to distribute traffic over a collection of Revisions belonging to the Service. If
        /// traffic is empty or not provided, defaults to 100% traffic to the latest `Ready` Revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traffic")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2TrafficTarget> Traffic { get; set; }

        /// <summary>
        /// Output only. Detailed status information for corresponding traffic targets. See comments in `reconciling`
        /// for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2TrafficTargetStatus> TrafficStatuses { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last-modified time.</summary>
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

        /// <summary>Output only. The main URI in which this Service is serving traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>Output only. All URLs serving traffic for this Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urls")]
        public virtual System.Collections.Generic.IList<string> Urls { get; set; }
    }

    /// <summary>
    /// Settings for Cloud Service Mesh. For more information see https://cloud.google.com/service-mesh/docs/overview.
    /// </summary>
    public class GoogleCloudRunV2ServiceMesh : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Mesh resource name. Format: `projects/{project}/locations/global/meshes/{mesh}`, where `{project}` can
        /// be project id or number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mesh")]
        public virtual string Mesh { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Scaling settings applied at the service level rather than at the revision level.</summary>
    public class GoogleCloudRunV2ServiceScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. total instance count for the service in manual scaling mode. This number of instances is divided
        /// among all revisions with specified traffic based on the percent of traffic they are receiving.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualInstanceCount")]
        public virtual System.Nullable<int> ManualInstanceCount { get; set; }

        /// <summary>
        /// Optional. total max instances for the service. This number of instances is divided among all revisions with
        /// specified traffic based on the percent of traffic they are receiving.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceCount")]
        public virtual System.Nullable<int> MaxInstanceCount { get; set; }

        /// <summary>
        /// Optional. total min instances for the service. This number of instances is divided among all revisions with
        /// specified traffic based on the percent of traffic they are receiving.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minInstanceCount")]
        public virtual System.Nullable<int> MinInstanceCount { get; set; }

        /// <summary>Optional. The scaling mode for the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalingMode")]
        public virtual string ScalingMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in an archive file in Google Cloud Storage.</summary>
    public class GoogleCloudRunV2StorageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Google Cloud Storage bucket containing the source (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Optional. Google Cloud Storage generation for the object. If the generation is omitted, the latest
        /// generation will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Required. Google Cloud Storage object containing the source. This object must be a gzipped archive file
        /// (`.tar.gz`) containing source to build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for submitting a Build.</summary>
    public class GoogleCloudRunV2SubmitBuildRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Build the source using Buildpacks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildpackBuild")]
        public virtual GoogleCloudRunV2BuildpacksBuild BuildpackBuild { get; set; }

        /// <summary>Build the source using Docker. This means the source has a Dockerfile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerBuild")]
        public virtual GoogleCloudRunV2DockerBuild DockerBuild { get; set; }

        /// <summary>Required. Artifact Registry URI to store the built image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>
        /// Optional. The service account to use for the build. If not set, the default Cloud Build service account for
        /// the project will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Required. Source for the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSource")]
        public virtual GoogleCloudRunV2StorageSource StorageSource { get; set; }

        /// <summary>Optional. Additional tags to annotate the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Optional. Name of the Cloud Build Custom Worker Pool that should be used to build the function. The format
        /// of this field is `projects/{project}/locations/{region}/workerPools/{workerPool}` where `{project}` and
        /// `{region}` are the project id and region respectively where the worker pool is defined and `{workerPool}` is
        /// the short name of the worker pool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for submitting a Build.</summary>
    public class GoogleCloudRunV2SubmitBuildResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// URI of the base builder image in Artifact Registry being used in the build. Used to opt into automatic base
        /// image updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseImageUri")]
        public virtual string BaseImageUri { get; set; }

        /// <summary>Warning message for the base image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseImageWarning")]
        public virtual string BaseImageWarning { get; set; }

        /// <summary>Cloud Build operation to be polled via CloudBuild API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildOperation")]
        public virtual GoogleLongrunningOperation BuildOperation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TCPSocketAction describes an action based on opening a socket</summary>
    public class GoogleCloudRunV2TCPSocketAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified,
        /// defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Task represents a single run of a container to completion.</summary>
    public class GoogleCloudRunV2Task : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Unstructured key value map that may be set by external tools to store and arbitrary metadata.
        /// They are not queryable and should be preserved when modifying objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _completionTimeRaw;

        private object _completionTime;

        /// <summary>
        /// Output only. Represents time when the Task was completed. It is not guaranteed to be set in happens-before
        /// order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual string CompletionTimeRaw
        {
            get => _completionTimeRaw;
            set
            {
                _completionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _completionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CompletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CompletionTimeDateTimeOffset instead.")]
        public virtual object CompletionTime
        {
            get => _completionTime;
            set
            {
                _completionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _completionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CompletionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CompletionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CompletionTimeRaw);
            set => CompletionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The Condition of this Task, containing its readiness status, and detailed error information in
        /// case it did not reach the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        /// <summary>Holds the single container that defines the unit of execution for this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. Represents time when the task was created by the system. It is not guaranteed to be set in
        /// happens-before order across separate operations.
        /// </summary>
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
        /// Output only. For a deleted resource, the deletion time. It is only populated as a response to a Delete
        /// request.
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

        /// <summary>
        /// Output only. A reference to a customer managed encryption key (CMEK) to use to encrypt this container image.
        /// For more information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>
        /// Output only. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. The name of the parent Execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("execution")]
        public virtual string Execution { get; set; }

        /// <summary>The execution environment being used to host this Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionEnvironment")]
        public virtual string ExecutionEnvironment { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. For a deleted resource, the time after which it will be permamently deleted. It is only
        /// populated as a response to a Delete request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>Optional. Output only. True if GPU zonal redundancy is disabled on this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuZonalRedundancyDisabled")]
        public virtual System.Nullable<bool> GpuZonalRedundancyDisabled { get; set; }

        /// <summary>Output only. Index of the Task, unique per execution, and beginning at 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Output only. The name of the parent Job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual string Job { get; set; }

        /// <summary>
        /// Output only. Unstructured key value map that can be used to organize and categorize objects. User-provided
        /// labels are shared with Google's billing system, so they can be used to filter, or break down billing charges
        /// by team, component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Result of the last attempt of this Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAttemptResult")]
        public virtual GoogleCloudRunV2TaskAttemptResult LastAttemptResult { get; set; }

        /// <summary>Output only. URI where logs for this execution can be found in Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUri")]
        public virtual string LogUri { get; set; }

        /// <summary>Number of retries allowed per Task, before marking this Task failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetries")]
        public virtual System.Nullable<int> MaxRetries { get; set; }

        /// <summary>Output only. The unique name of this Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The node selector for the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSelector")]
        public virtual GoogleCloudRunV2NodeSelector NodeSelector { get; set; }

        /// <summary>
        /// Output only. The generation of this Task. See comments in `Job.reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Indicates whether the resource's reconciliation is still in progress. See comments in
        /// `Job.reconciling` for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>
        /// Output only. The number of times this Task was retried. Tasks are retried when they fail up to the
        /// maxRetries limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retried")]
        public virtual System.Nullable<int> Retried { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        private string _scheduledTimeRaw;

        private object _scheduledTime;

        /// <summary>
        /// Output only. Represents time when the task was scheduled to run by the system. It is not guaranteed to be
        /// set in happens-before order across separate operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledTime")]
        public virtual string ScheduledTimeRaw
        {
            get => _scheduledTimeRaw;
            set
            {
                _scheduledTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _scheduledTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ScheduledTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ScheduledTimeDateTimeOffset instead.")]
        public virtual object ScheduledTime
        {
            get => _scheduledTime;
            set
            {
                _scheduledTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _scheduledTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ScheduledTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ScheduledTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ScheduledTimeRaw);
            set => ScheduledTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Email address of the IAM service account associated with the Task of a Job. The service account represents
        /// the identity of the running task, and determines what permissions the task has. If not provided, the task
        /// will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Output only. Represents time when the task started to run. It is not guaranteed to be set in happens-before
        /// order across separate operations.
        /// </summary>
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

        /// <summary>
        /// Max allowed time duration the Task may be active before the system will actively try to mark it failed and
        /// kill associated containers. This applies per attempt of a task, meaning each retry can run for the full
        /// timeout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the Task. The value is a UUID4 string and guaranteed to
        /// remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last-modified time.</summary>
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

        /// <summary>A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// Output only. VPC Access configuration to use for this Task. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }
    }

    /// <summary>Result of a task attempt.</summary>
    public class GoogleCloudRunV2TaskAttemptResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The exit code of this attempt. This may be unset if the container was unable to exit cleanly
        /// with a code due to some other failure. See status field for possible failure details. At most one of
        /// exit_code or term_signal will be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Output only. The status of this attempt. If the status code is OK, then the attempt succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>
        /// Output only. Termination signal of the container. This is set to non-zero if the container is terminated by
        /// the system. At most one of exit_code or term_signal will be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("termSignal")]
        public virtual System.Nullable<int> TermSignal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TaskTemplate describes the data a task should have when created from a template.</summary>
    public class GoogleCloudRunV2TaskTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Holds the single container that defines the unit of execution for this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        /// <summary>
        /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more
        /// information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>Optional. The execution environment being used to host this Task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionEnvironment")]
        public virtual string ExecutionEnvironment { get; set; }

        /// <summary>Optional. True if GPU zonal redundancy is disabled on this task template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuZonalRedundancyDisabled")]
        public virtual System.Nullable<bool> GpuZonalRedundancyDisabled { get; set; }

        /// <summary>Number of retries allowed per Task, before marking this Task failed. Defaults to 3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetries")]
        public virtual System.Nullable<int> MaxRetries { get; set; }

        /// <summary>Optional. The node selector for the task template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSelector")]
        public virtual GoogleCloudRunV2NodeSelector NodeSelector { get; set; }

        /// <summary>
        /// Optional. Email address of the IAM service account associated with the Task of a Job. The service account
        /// represents the identity of the running task, and determines what permissions the task has. If not provided,
        /// the task will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Optional. Max allowed time duration the Task may be active before the system will actively try to mark it
        /// failed and kill associated containers. This applies per attempt of a task, meaning each retry can run for
        /// the full timeout. Defaults to 600 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>Optional. A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// Optional. VPC Access configuration to use for this Task. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Holds a single traffic routing entry for the Service. Allocations can be done to a specific Revision name, or
    /// pointing to the latest Ready Revision.
    /// </summary>
    public class GoogleCloudRunV2TrafficTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies percent of the traffic to this Revision. This defaults to zero if unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>Revision to which to send this portion of traffic, if traffic allocation is by revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>Indicates a string to be part of the URI to exclusively reference this target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The allocation type for this traffic target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the observed state of a single `TrafficTarget` entry.</summary>
    public class GoogleCloudRunV2TrafficTargetStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies percent of the traffic to this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>Revision to which this traffic is sent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>Indicates the string used in the URI to exclusively reference this target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The allocation type for this traffic target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Displays the target URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VersionToPath maps a specific version of a secret to a relative file to mount to, relative to VolumeMount's
    /// mount_path.
    /// </summary>
    public class GoogleCloudRunV2VersionToPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integer octal mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set,
        /// the Volume's default mode will be used. Notes * Internally, a umask of 0222 will be applied to any non-zero
        /// value. * This is an integer representation of the mode bits. So, the octal integer value should look exactly
        /// as the chmod numeric notation with a leading zero. Some examples: for chmod 640 (u=rw,g=r), set to 0640
        /// (octal) or 416 (base-10). For chmod 755 (u=rwx,g=rx,o=rx), set to 0755 (octal) or 493 (base-10). * This
        /// might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other
        /// mode bits set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual System.Nullable<int> Mode { get; set; }

        /// <summary>Required. The relative path of the secret in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// The Cloud Secret Manager secret version. Can be 'latest' for the latest value, or an integer or a secret
        /// alias for a specific version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Volume represents a named volume in a container.</summary>
    public class GoogleCloudRunV2Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For Cloud SQL volumes, contains the specific instances that should be mounted. Visit
        /// https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and
        /// Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudSqlInstance")]
        public virtual GoogleCloudRunV2CloudSqlInstance CloudSqlInstance { get; set; }

        /// <summary>Ephemeral storage used as a shared volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emptyDir")]
        public virtual GoogleCloudRunV2EmptyDirVolumeSource EmptyDir { get; set; }

        /// <summary>Persistent storage backed by a Google Cloud Storage bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcs")]
        public virtual GoogleCloudRunV2GCSVolumeSource Gcs { get; set; }

        /// <summary>Required. Volume's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>For NFS Voumes, contains the path to the nfs Volume</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfs")]
        public virtual GoogleCloudRunV2NFSVolumeSource Nfs { get; set; }

        /// <summary>Secret represents a secret that should populate this volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual GoogleCloudRunV2SecretVolumeSource Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
    public class GoogleCloudRunV2VolumeMount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Path within the container at which the volume should be mounted. Must not contain ':'. For Cloud
        /// SQL volumes, it can be left empty, or must otherwise be `/cloudsql`. All instances defined in the Volume
        /// will be available as `/cloudsql/[instance]`. For more information on Cloud SQL volumes, visit
        /// https://cloud.google.com/sql/docs/mysql/connect-run
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPath")]
        public virtual string MountPath { get; set; }

        /// <summary>Required. This must match the Name of a Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// VPC Access settings. For more information on sending traffic to a VPC network, visit
    /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
    /// </summary>
    public class GoogleCloudRunV2VpcAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// VPC Access connector name. Format: `projects/{project}/locations/{location}/connectors/{connector}`, where
        /// `{project}` can be project id or number. For more information on sending traffic to a VPC network via a
        /// connector, visit https://cloud.google.com/run/docs/configuring/vpc-connectors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connector")]
        public virtual string Connector { get; set; }

        /// <summary>
        /// Optional. Traffic VPC egress settings. If not provided, it defaults to PRIVATE_RANGES_ONLY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egress")]
        public virtual string Egress { get; set; }

        /// <summary>
        /// Optional. Direct VPC egress settings. Currently only single network interface is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInterfaces")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2NetworkInterface> NetworkInterfaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// WorkerPool acts as a top-level container that manages a set of configurations and revision templates which
    /// implement a pull-based workload. WorkerPool exists to provide a singular abstraction which can be access
    /// controlled, reasoned about, and which encapsulates software lifecycle decisions such as rollout policy and team
    /// resource ownership.
    /// </summary>
    public class GoogleCloudRunV2WorkerPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Unstructured key value map that may be set by external tools to store and arbitrary metadata. They
        /// are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support
        /// annotations with `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or
        /// `autoscaling.knative.dev` namespaces, and they will be rejected in new resources. All system annotations in
        /// v1 now have a corresponding field in v2 WorkerPool. This field follows Kubernetes annotations' namespacing,
        /// limits, and rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Optional. Settings for the Binary Authorization feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryAuthorization")]
        public virtual GoogleCloudRunV2BinaryAuthorization BinaryAuthorization { get; set; }

        /// <summary>Arbitrary identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Arbitrary version identifier for the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientVersion")]
        public virtual string ClientVersion { get; set; }

        /// <summary>
        /// Output only. The Conditions of all other associated sub-resources. They contain additional diagnostics
        /// information in case the WorkerPool does not reach its Serving state. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Condition> Conditions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation time.</summary>
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

        /// <summary>Output only. Email address of the authenticated creator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>
        /// One or more custom audiences that you want this worker pool to support. Specify each custom audience as the
        /// full URL in a string. The custom audiences are encoded in the token and used to authenticate requests. For
        /// more information, see https://cloud.google.com/run/docs/configuring/custom-audiences.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAudiences")]
        public virtual System.Collections.Generic.IList<string> CustomAudiences { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The deletion time. It is only populated as a response to a Delete request.</summary>
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

        /// <summary>
        /// User-provided description of the WorkerPool. This field currently has a 512-character limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A system-generated fingerprint for this version of the resource. May be used to detect
        /// modification conflict during updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. For a deleted resource, the time after which it will be permamently deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. A number that monotonically increases every time the user modifies the desired state. Please
        /// note that unlike v1, this is an int64 value. As with most Google APIs, its JSON representation will be a
        /// `string` instead of an `integer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Output only. Detailed status information for corresponding instance splits. See comments in `reconciling`
        /// for additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSplitStatuses")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2InstanceSplitStatus> InstanceSplitStatuses { get; set; }

        /// <summary>
        /// Optional. Specifies how to distribute instances over a collection of Revisions belonging to the WorkerPool.
        /// If instance split is empty or not provided, defaults to 100% instances assigned to the latest `Ready`
        /// Revision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSplits")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2InstanceSplit> InstanceSplits { get; set; }

        /// <summary>
        /// Optional. Unstructured key value map that can be used to organize and categorize objects. User-provided
        /// labels are shared with Google's billing system, so they can be used to filter, or break down billing charges
        /// by team, component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with
        /// `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
        /// namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2
        /// WorkerPool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Email address of the last authenticated modifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifier")]
        public virtual string LastModifier { get; set; }

        /// <summary>
        /// Output only. Name of the last created revision. See comments in `reconciling` for additional information on
        /// reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCreatedRevision")]
        public virtual string LatestCreatedRevision { get; set; }

        /// <summary>
        /// Output only. Name of the latest revision that is serving traffic. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReadyRevision")]
        public virtual string LatestReadyRevision { get; set; }

        /// <summary>
        /// Optional. The launch stage as defined by [Google Cloud Platform Launch
        /// Stages](https://cloud.google.com/terms/launch-stages). Cloud Run supports `ALPHA`, `BETA`, and `GA`. If no
        /// value is specified, GA is assumed. Set the launch stage to a preview stage on input to allow use of preview
        /// features in that stage. On read (or output), describes whether the resource uses preview features. For
        /// example, if ALPHA is provided as input, but only BETA and GA-level features are used, this field will be
        /// BETA on output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The fully qualified name of this WorkerPool. In CreateWorkerPoolRequest, this field is ignored, and instead
        /// composed from CreateWorkerPoolRequest.parent and CreateWorkerPoolRequest.worker_id. Format:
        /// `projects/{project}/locations/{location}/workerPools/{worker_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The generation of this WorkerPool currently serving traffic. See comments in `reconciling` for
        /// additional information on reconciliation process in Cloud Run. Please note that unlike v1, this is an int64
        /// value. As with most Google APIs, its JSON representation will be a `string` instead of an `integer`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<long> ObservedGeneration { get; set; }

        /// <summary>
        /// Output only. Returns true if the WorkerPool is currently being acted upon by the system to bring it into the
        /// desired state. When a new WorkerPool is created, or an existing one is updated, Cloud Run will
        /// asynchronously perform all necessary steps to bring the WorkerPool to the desired serving state. This
        /// process is called reconciliation. While reconciliation is in process, `observed_generation`,
        /// `latest_ready_revison`, `traffic_statuses`, and `uri` will have transient values that might mismatch the
        /// intended state: Once reconciliation is over (and this field is false), there are two possible outcomes:
        /// reconciliation succeeded and the serving state matches the WorkerPool, or there was an error, and
        /// reconciliation failed. This state can be found in `terminal_condition.state`. If reconciliation succeeded,
        /// the following fields will match: `traffic` and `traffic_statuses`, `observed_generation` and `generation`,
        /// `latest_ready_revision` and `latest_created_revision`. If reconciliation failed, `traffic_statuses`,
        /// `observed_generation`, and `latest_ready_revision` will have the state of the last serving revision, or
        /// empty for newly created WorkerPools. Additional information on the failure can be found in
        /// `terminal_condition` and `conditions`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPzs")]
        public virtual System.Nullable<bool> SatisfiesPzs { get; set; }

        /// <summary>Optional. Specifies worker-pool-level scaling settings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaling")]
        public virtual GoogleCloudRunV2WorkerPoolScaling Scaling { get; set; }

        /// <summary>Required. The template used to create revisions for this WorkerPool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual GoogleCloudRunV2WorkerPoolRevisionTemplate Template { get; set; }

        /// <summary>
        /// Output only. The Condition of this WorkerPool, containing its readiness status, and detailed error
        /// information in case it did not reach a serving state. See comments in `reconciling` for additional
        /// information on reconciliation process in Cloud Run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminalCondition")]
        public virtual GoogleCloudRunV2Condition TerminalCondition { get; set; }

        /// <summary>
        /// Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed
        /// to remain unchanged until the resource is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last-modified time.</summary>
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

    /// <summary>
    /// WorkerPoolRevisionTemplate describes the data a worker pool revision should have when created from a template.
    /// </summary>
    public class GoogleCloudRunV2WorkerPoolRevisionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Unstructured key value map that may be set by external tools to store and arbitrary metadata. They
        /// are not queryable and should be preserved when modifying objects. Cloud Run API v2 does not support
        /// annotations with `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or
        /// `autoscaling.knative.dev` namespaces, and they will be rejected. All system annotations in v1 now have a
        /// corresponding field in v2 WorkerPoolRevisionTemplate. This field follows Kubernetes annotations'
        /// namespacing, limits, and rules.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Holds list of the containers that defines the unit of execution for this Revision.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Container> Containers { get; set; }

        /// <summary>
        /// A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more
        /// information, go to https://cloud.google.com/run/docs/securing/using-cmek
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual string EncryptionKey { get; set; }

        /// <summary>Optional. The action to take if the encryption key is revoked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyRevocationAction")]
        public virtual string EncryptionKeyRevocationAction { get; set; }

        /// <summary>
        /// Optional. If encryption_key_revocation_action is SHUTDOWN, the duration before shutting down all instances.
        /// The minimum increment is 1 hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyShutdownDuration")]
        public virtual object EncryptionKeyShutdownDuration { get; set; }

        /// <summary>Optional. True if GPU zonal redundancy is disabled on this worker pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gpuZonalRedundancyDisabled")]
        public virtual System.Nullable<bool> GpuZonalRedundancyDisabled { get; set; }

        /// <summary>
        /// Optional. Unstructured key value map that can be used to organize and categorize objects. User-provided
        /// labels are shared with Google's billing system, so they can be used to filter, or break down billing charges
        /// by team, component, environment, state, etc. For more information, visit
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels or
        /// https://cloud.google.com/run/docs/configuring/labels. Cloud Run API v2 does not support labels with
        /// `run.googleapis.com`, `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
        /// namespaces, and they will be rejected. All system labels in v1 now have a corresponding field in v2
        /// WorkerPoolRevisionTemplate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. The node selector for the revision template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSelector")]
        public virtual GoogleCloudRunV2NodeSelector NodeSelector { get; set; }

        /// <summary>
        /// Optional. The unique name for the revision. If this field is omitted, it will be automatically generated
        /// based on the WorkerPool name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>
        /// Optional. Email address of the IAM service account associated with the revision of the service. The service
        /// account represents the identity of the running revision, and determines what permissions the revision has.
        /// If not provided, the revision will use the project's default service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Optional. Enables service mesh connectivity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceMesh")]
        public virtual GoogleCloudRunV2ServiceMesh ServiceMesh { get; set; }

        /// <summary>Optional. A list of Volumes to make available to containers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleCloudRunV2Volume> Volumes { get; set; }

        /// <summary>
        /// Optional. VPC Access configuration to use for this Revision. For more information, visit
        /// https://cloud.google.com/run/docs/configuring/connecting-vpc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccess")]
        public virtual GoogleCloudRunV2VpcAccess VpcAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Worker pool scaling settings.</summary>
    public class GoogleCloudRunV2WorkerPoolScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The total number of instances in manual scaling mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualInstanceCount")]
        public virtual System.Nullable<int> ManualInstanceCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ApprovalConfig describes configuration for manual approval of a build.</summary>
    public class GoogleDevtoolsCloudbuildV1ApprovalConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether or not approval is needed. If this is set on a build, it will become pending when created, and will
        /// need to be explicitly approved to start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalRequired")]
        public virtual System.Nullable<bool> ApprovalRequired { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ApprovalResult describes the decision and associated metadata of a manual approval of a build.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1ApprovalResult : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _approvalTimeRaw;

        private object _approvalTime;

        /// <summary>Output only. The time when the approval decision was made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approvalTime")]
        public virtual string ApprovalTimeRaw
        {
            get => _approvalTimeRaw;
            set
            {
                _approvalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _approvalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ApprovalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ApprovalTimeDateTimeOffset instead.")]
        public virtual object ApprovalTime
        {
            get => _approvalTime;
            set
            {
                _approvalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _approvalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ApprovalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ApprovalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ApprovalTimeRaw);
            set => ApprovalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Email of the user that called the ApproveBuild API to approve or reject a build at the time
        /// that the API was called.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approverAccount")]
        public virtual string ApproverAccount { get; set; }

        /// <summary>Optional. An optional comment for this manual approval result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comment")]
        public virtual string Comment { get; set; }

        /// <summary>Required. The decision of this manual approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decision")]
        public virtual string Decision { get; set; }

        /// <summary>
        /// Optional. An optional URL tied to this manual approval result. This field is essentially the same as
        /// comment, except that it will be rendered by the UI differently. An example use case is a link to an external
        /// job that approved this Build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Files in the workspace to upload to Cloud Storage upon successful completion of all build steps.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1ArtifactObjects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage bucket and optional object path, in the form "gs://bucket/path/to/somewhere/". (see [Bucket
        /// Name Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Files in the
        /// workspace matching any path pattern will be uploaded to Cloud Storage with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Path globs used to match files in the build's workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>Output only. Stores timing information for pushing all artifact objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan Timing { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Artifacts produced by a build that should be uploaded upon successful completion of all build steps.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1Artifacts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A list of Go modules to be uploaded to Artifact Registry upon successful completion of all build
        /// steps. If any objects fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goModules")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1GoModule> GoModules { get; set; }

        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images will be pushed
        /// using the builder service account's credentials. The digests of the pushed images will be stored in the
        /// Build resource's results field. If any of the images fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>
        /// A list of Maven artifacts to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// Artifacts in the workspace matching specified paths globs will be uploaded to the specified Artifact
        /// Registry repository using the builder service account's credentials. If any artifacts fail to be pushed, the
        /// build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1MavenArtifact> MavenArtifacts { get; set; }

        /// <summary>
        /// A list of npm packages to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// Npm packages in the specified paths will be uploaded to the specified Artifact Registry repository using the
        /// builder service account's credentials. If any packages fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmPackages")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1NpmPackage> NpmPackages { get; set; }

        /// <summary>
        /// A list of objects to be uploaded to Cloud Storage upon successful completion of all build steps. Files in
        /// the workspace matching specified paths globs will be uploaded to the specified Cloud Storage location using
        /// the builder service account's credentials. The location and generation of the uploaded objects will be
        /// stored in the Build resource's results field. If any objects fail to be pushed, the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual GoogleDevtoolsCloudbuildV1ArtifactObjects Objects { get; set; }

        /// <summary>
        /// A list of Python packages to be uploaded to Artifact Registry upon successful completion of all build steps.
        /// The build service account credentials will be used to perform the upload. If any objects fail to be pushed,
        /// the build is marked FAILURE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1PythonPackage> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A build resource in the Cloud Build API. At a high level, a `Build` describes where to find source code, how to
    /// build it (for example, the builder image to run on the source), and where to store the built artifacts. Fields
    /// can include the following variables, which will be expanded when the build is created: - $PROJECT_ID: the
    /// project ID of the build. - $PROJECT_NUMBER: the project number of the build. - $LOCATION: the location/region of
    /// the build. - $BUILD_ID: the autogenerated ID of the build. - $REPO_NAME: the source repository name specified by
    /// RepoSource. - $BRANCH_NAME: the branch name specified by RepoSource. - $TAG_NAME: the tag name specified by
    /// RepoSource. - $REVISION_ID or $COMMIT_SHA: the commit SHA specified by RepoSource or resolved from the specified
    /// branch or tag. - $SHORT_SHA: first 7 characters of $REVISION_ID or $COMMIT_SHA.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1Build : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Describes this build's approval configuration, status, and result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approval")]
        public virtual GoogleDevtoolsCloudbuildV1BuildApproval Approval { get; set; }

        /// <summary>
        /// Artifacts produced by the build that should be uploaded upon successful completion of all build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifacts")]
        public virtual GoogleDevtoolsCloudbuildV1Artifacts Artifacts { get; set; }

        /// <summary>Secrets and secret environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableSecrets")]
        public virtual GoogleDevtoolsCloudbuildV1Secrets AvailableSecrets { get; set; }

        /// <summary>
        /// Output only. The ID of the `BuildTrigger` that triggered this build, if it was triggered automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildTriggerId")]
        public virtual string BuildTriggerId { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time at which the request to create the build was received.</summary>
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

        /// <summary>
        /// Optional. Dependencies that the Cloud Build worker will fetch before executing user steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Dependency> Dependencies { get; set; }

        /// <summary>Output only. Contains information about the build when status=FAILURE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureInfo")]
        public virtual GoogleDevtoolsCloudbuildV1FailureInfo FailureInfo { get; set; }

        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>
        /// Output only. Time at which execution of the build was finished. The difference between finish_time and
        /// start_time is the duration of the build's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Configuration for git operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitConfig")]
        public virtual GoogleDevtoolsCloudbuildV1GitConfig GitConfig { get; set; }

        /// <summary>Output only. Unique identifier of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A list of images to be pushed upon the successful completion of all build steps. The images are pushed using
        /// the builder service account's credentials. The digests of the pushed images will be stored in the `Build`
        /// resource's results field. If any of the images fail to be pushed, the build status is marked `FAILURE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>Output only. URL to logs for this build in Google Cloud Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logUrl")]
        public virtual string LogUrl { get; set; }

        /// <summary>
        /// Cloud Storage bucket where logs should be written (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)). Logs file names will be of
        /// the format `${logs_bucket}/log-${build_id}.txt`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsBucket")]
        public virtual string LogsBucket { get; set; }

        /// <summary>
        /// Output only. The 'Build' name with format: `projects/{project}/locations/{location}/builds/{build}`, where
        /// {build} is a unique identifier generated by the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Special options for this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GoogleDevtoolsCloudbuildV1BuildOptions Options { get; set; }

        /// <summary>Output only. ID of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// TTL in queue for this build. If provided and the build is enqueued longer than this value, the build will
        /// expire and the build status will be `EXPIRED`. The TTL starts ticking from create_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queueTtl")]
        public virtual object QueueTtl { get; set; }

        /// <summary>Output only. Results of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual GoogleDevtoolsCloudbuildV1Results Results { get; set; }

        /// <summary>
        /// Secrets to decrypt using Cloud Key Management Service. Note: Secret Manager is the recommended technique for
        /// managing sensitive data with Cloud Build. Use `available_secrets` to configure builds to access secrets from
        /// Secret Manager. For instructions, see: https://cloud.google.com/cloud-build/docs/securing-builds/use-secrets
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secrets")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Secret> Secrets { get; set; }

        /// <summary>
        /// IAM service account whose credentials will be used at build runtime. Must be of the format
        /// `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. ACCOUNT can be email address or uniqueId of the service
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Optional. The location of the source files to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual GoogleDevtoolsCloudbuildV1Source Source { get; set; }

        /// <summary>Output only. A permanent fixed identifier for source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenance")]
        public virtual GoogleDevtoolsCloudbuildV1SourceProvenance SourceProvenance { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Time at which execution of the build was started.</summary>
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

        /// <summary>Output only. Status of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Customer-readable message about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Required. The operations to be performed on the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1BuildStep> Steps { get; set; }

        /// <summary>Substitutions data for `Build` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>Tags for annotation of a `Build`. These are not docker tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Amount of time that this build should be allowed to run, to second granularity. If this amount of time
        /// elapses, work on the build will cease and the build status will be `TIMEOUT`. `timeout` starts ticking from
        /// `startTime`. Default time is 60 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// Output only. Stores timing information for phases of the build. Valid keys are: * BUILD: time to execute all
        /// build steps. * PUSH: time to push all artifacts including docker images and non docker artifacts. *
        /// FETCHSOURCE: time to fetch source. * SETUPBUILD: time to set up build. If the build does not specify source
        /// or images, these keys will not be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleDevtoolsCloudbuildV1TimeSpan> Timing { get; set; }

        /// <summary>Output only. Non-fatal problems encountered during the execution of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Warning> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BuildApproval describes a build's approval configuration, state, and result.</summary>
    public class GoogleDevtoolsCloudbuildV1BuildApproval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Configuration for manual approval of this build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleDevtoolsCloudbuildV1ApprovalConfig Config { get; set; }

        /// <summary>Output only. Result of manual approval for this Build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual GoogleDevtoolsCloudbuildV1ApprovalResult Result { get; set; }

        /// <summary>Output only. The state of this build's approval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for build operations.</summary>
    public class GoogleDevtoolsCloudbuildV1BuildOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The build that the operation is tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual GoogleDevtoolsCloudbuildV1Build Build { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Optional arguments to enable specific features of builds.</summary>
    public class GoogleDevtoolsCloudbuildV1BuildOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Option to include built-in and custom substitutions as env variables for all build steps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automapSubstitutions")]
        public virtual System.Nullable<bool> AutomapSubstitutions { get; set; }

        /// <summary>Optional. Option to specify how default logs buckets are setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLogsBucketBehavior")]
        public virtual string DefaultLogsBucketBehavior { get; set; }

        /// <summary>
        /// Requested disk size for the VM that runs the build. Note that this is *NOT* "disk free"; some of the space
        /// will be used by the operating system and build utilities. Also note that this is the minimum disk size that
        /// will be allocated for the build -- the build may run with a larger disk than requested. At present, the
        /// maximum disk size is 4000GB; builds that request more than the maximum are rejected with an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskSizeGb")]
        public virtual System.Nullable<long> DiskSizeGb { get; set; }

        /// <summary>
        /// Option to specify whether or not to apply bash style string operations to the substitutions. NOTE: this is
        /// always enabled for triggered builds and cannot be overridden in the build configuration file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicSubstitutions")]
        public virtual System.Nullable<bool> DynamicSubstitutions { get; set; }

        /// <summary>
        /// Optional. Option to specify whether structured logging is enabled. If true, JSON-formatted logs are parsed
        /// as structured logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableStructuredLogging")]
        public virtual System.Nullable<bool> EnableStructuredLogging { get; set; }

        /// <summary>
        /// A list of global environment variable definitions that will exist for all build steps in this build. If a
        /// variable is defined in both globally and in a build step, the variable will use the build step value. The
        /// elements are of the form "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Option to define build log streaming behavior to Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logStreamingOption")]
        public virtual string LogStreamingOption { get; set; }

        /// <summary>Option to specify the logging mode, which determines if and where build logs are stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logging")]
        public virtual string Logging { get; set; }

        /// <summary>Compute Engine machine type on which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>
        /// Optional. Specification for execution on a `WorkerPool`. See [running builds in a private
        /// pool](https://cloud.google.com/build/docs/private-pools/run-builds-in-private-pool) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pool")]
        public virtual GoogleDevtoolsCloudbuildV1PoolOption Pool { get; set; }

        /// <summary>Optional. Option to specify the Pub/Sub topic to receive build status updates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>Requested verifiability options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedVerifyOption")]
        public virtual string RequestedVerifyOption { get; set; }

        /// <summary>
        /// A list of global environment variables, which are encrypted using a Cloud Key Management Service crypto key.
        /// These values must be specified in the build's `Secret`. These variables will be available to all build steps
        /// in this build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>Requested hash for SourceProvenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProvenanceHash")]
        public virtual System.Collections.Generic.IList<string> SourceProvenanceHash { get; set; }

        /// <summary>
        /// Option to specify behavior when there is an error in the substitution checks. NOTE: this is always set to
        /// ALLOW_LOOSE for triggered builds and cannot be overridden in the build configuration file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutionOption")]
        public virtual string SubstitutionOption { get; set; }

        /// <summary>
        /// Global list of volumes to mount for ALL build steps Each volume is created as an empty volume prior to
        /// starting the build process. Upon completion of the build, volumes and their contents are discarded. Global
        /// volume names and paths cannot conflict with the volumes defined a build step. Using a global volume in a
        /// build with only one step is not valid as it is indicative of a build request with an incorrect
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Volume> Volumes { get; set; }

        /// <summary>This field deprecated; please use `pool.name` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workerPool")]
        public virtual string WorkerPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A step in the build pipeline.</summary>
    public class GoogleDevtoolsCloudbuildV1BuildStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Allow this build step to fail without failing the entire build if and only if the exit code is one of the
        /// specified codes. If allow_failure is also specified, this field will take precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExitCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowExitCodes { get; set; }

        /// <summary>
        /// Allow this build step to fail without failing the entire build. If false, the entire build will fail if this
        /// step fails. Otherwise, the build will succeed, but this step will still have a failure status. Error
        /// information will be reported in the failure_detail field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowFailure")]
        public virtual System.Nullable<bool> AllowFailure { get; set; }

        /// <summary>
        /// A list of arguments that will be presented to the step when it is started. If the image used to run the
        /// step's container has an entrypoint, the `args` are used as arguments to that entrypoint. If the image does
        /// not define an entrypoint, the first element in args is used as the entrypoint, and the remainder will be
        /// used as arguments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// Option to include built-in and custom substitutions as env variables for this build step. This option will
        /// override the global option in BuildOption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automapSubstitutions")]
        public virtual System.Nullable<bool> AutomapSubstitutions { get; set; }

        /// <summary>
        /// Working directory to use when running this step's container. If this value is a relative path, it is
        /// relative to the build's working directory. If this value is absolute, it may be outside the build's working
        /// directory, in which case the contents of the path may not be persisted across build step executions, unless
        /// a `volume` for that path is specified. If the build specifies a `RepoSource` with `dir` and a step with a
        /// `dir`, which specifies an absolute path, the `RepoSource` `dir` is ignored for the step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Entrypoint to be used instead of the build step image's default entrypoint. If unset, the image's default
        /// entrypoint is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>
        /// A list of environment variable definitions to be used when running a step. The elements are of the form
        /// "KEY=VALUE" for the environment variable "KEY" being given the value "VALUE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>Output only. Return code from running the step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Unique identifier for this build step, used in `wait_for` to reference this build step as a dependency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. The name of the container image that will run this particular build step. If the image is
        /// available in the host's Docker daemon's cache, it will be run directly. If not, the host will attempt to
        /// pull the image first, using the builder service account's credentials if necessary. The Docker daemon's
        /// cache will already have the latest versions of all of the officially supported build steps
        /// ([https://github.com/GoogleCloudPlatform/cloud-builders](https://github.com/GoogleCloudPlatform/cloud-builders)).
        /// The Docker daemon will also have cached many of the layers for some popular images, like "ubuntu", "debian",
        /// but they will be refreshed at the time you attempt to use them. If you built an image in a previous build
        /// step, it will be stored in the host's Docker daemon's cache and is available to use as the name for a later
        /// build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pulling this build step's builder image only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PullTiming { get; set; }

        /// <summary>
        /// A shell script to be executed in the step. When script is provided, the user cannot specify the entrypoint
        /// or args.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>
        /// A list of environment variables which are encrypted using a Cloud Key Management Service crypto key. These
        /// values must be specified in the build's `Secret`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IList<string> SecretEnv { get; set; }

        /// <summary>
        /// Output only. Status of the build step. At this time, build step status is only updated on build completion;
        /// step status is not updated in real-time as the build progresses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Time limit for executing this build step. If not defined, the step has no time limit and will be allowed to
        /// continue to run until either it completes or the build itself times out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>Output only. Stores timing information for executing this build step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timing")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan Timing { get; set; }

        /// <summary>
        /// List of volumes to mount into the build step. Each volume is created as an empty volume prior to execution
        /// of the build step. Upon completion of the build, volumes and their contents are discarded. Using a named
        /// volume in only one step is not valid as it is indicative of a build request with an incorrect configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Volume> Volumes { get; set; }

        /// <summary>
        /// The ID(s) of the step(s) that this build step depends on. This build step will not start until all the build
        /// steps in `wait_for` have completed successfully. If `wait_for` is empty, this build step will start when all
        /// previous build steps in the `Build.Steps` list have completed successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitFor")]
        public virtual System.Collections.Generic.IList<string> WaitFor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An image built by the pipeline.</summary>
    public class GoogleDevtoolsCloudbuildV1BuiltImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Docker Registry 2.0 digest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual string Digest { get; set; }

        /// <summary>
        /// Name used to push the container image to Google Container Registry, as presented to `docker push`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a 2nd-gen Google Cloud Build repository resource.</summary>
    public class GoogleDevtoolsCloudbuildV1ConnectedRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Directory, relative to the source root, in which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Required. Name of the Google Cloud Build repository, formatted as
        /// `projects/*/locations/*/connections/*/repositories/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>
        /// Required. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A dependency that the Cloud Build worker will fetch before executing user steps.</summary>
    public class GoogleDevtoolsCloudbuildV1Dependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set to true disable all dependency fetching (ignoring the default source as well).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("empty")]
        public virtual System.Nullable<bool> Empty { get; set; }

        /// <summary>Represents a git repository as a build dependency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSource")]
        public virtual GoogleDevtoolsCloudbuildV1GitSourceDependency GitSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This config defines the location of a source through Developer Connect.</summary>
    public class GoogleDevtoolsCloudbuildV1DeveloperConnectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Directory, relative to the source root, in which to run the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Required. The Developer Connect Git repository link, formatted as
        /// `projects/*/locations/*/connections/*/gitRepositoryLink/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitRepositoryLink")]
        public virtual string GitRepositoryLink { get; set; }

        /// <summary>
        /// Required. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A fatal problem encountered during the execution of the build.</summary>
    public class GoogleDevtoolsCloudbuildV1FailureInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Explains the failure issue in more detail using hard-coded text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>The name of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Container message for hashes of byte content of files, used in SourceProvenance messages to verify integrity of
    /// source input to the build.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1FileHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of file hashes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHash")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1Hash> FileHash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GitConfig is a configuration for git operations.</summary>
    public class GoogleDevtoolsCloudbuildV1GitConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for HTTP related git operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("http")]
        public virtual GoogleDevtoolsCloudbuildV1HttpConfig Http { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in any accessible Git repository.</summary>
    public class GoogleDevtoolsCloudbuildV1GitSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Directory, relative to the source root, in which to run the build. This must be a relative path.
        /// If a step's `dir` is specified and is an absolute path, this value is ignored for that step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>
        /// Optional. The revision to fetch from the Git repository such as a branch, a tag, a commit SHA, or any Git
        /// ref. Cloud Build uses `git fetch` to fetch the revision from the Git repository; therefore make sure that
        /// the string you provide for `revision` is parsable by the command. For information on string values accepted
        /// by `git fetch`, see https://git-scm.com/docs/gitrevisions#_specifying_revisions. For information on `git
        /// fetch`, see https://git-scm.com/docs/git-fetch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>
        /// Required. Location of the Git repo to build. This will be used as a `git remote`, see
        /// https://git-scm.com/docs/git-remote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a git repository as a build dependency.</summary>
    public class GoogleDevtoolsCloudbuildV1GitSourceDependency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. How much history should be fetched for the build (default 1, -1 for all history).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("depth")]
        public virtual System.Nullable<long> Depth { get; set; }

        /// <summary>Required. Where should the files be placed on the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destPath")]
        public virtual string DestPath { get; set; }

        /// <summary>Optional. True if submodules should be fetched too (default false).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurseSubmodules")]
        public virtual System.Nullable<bool> RecurseSubmodules { get; set; }

        /// <summary>Required. The kind of repo (url or dev connect).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual GoogleDevtoolsCloudbuildV1GitSourceRepository Repository { get; set; }

        /// <summary>Required. The revision that we will fetch the repo at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual string Revision { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A repository for a git source.</summary>
    public class GoogleDevtoolsCloudbuildV1GitSourceRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Developer Connect Git repository link formatted as
        /// `projects/*/locations/*/connections/*/gitRepositoryLink/*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerConnect")]
        public virtual string DeveloperConnect { get; set; }

        /// <summary>Location of the Git repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Go module to upload to Artifact Registry upon successful completion of all build steps. A module refers to all
    /// dependencies in a go.mod file.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1GoModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Go module's "module path". e.g. example.com/foo/v2</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modulePath")]
        public virtual string ModulePath { get; set; }

        /// <summary>
        /// Optional. The Go module's semantic version in the form vX.Y.Z. e.g. v0.1.1 Pre-release identifiers can also
        /// be added by appending a dash and dot separated ASCII alphanumeric characters and hyphens. e.g.
        /// v0.2.3-alpha.x.12m.5
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleVersion")]
        public virtual string ModuleVersion { get; set; }

        /// <summary>
        /// Optional. Location of the Artifact Registry repository. i.e. us-east1 Defaults to the build’s location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryLocation")]
        public virtual string RepositoryLocation { get; set; }

        /// <summary>
        /// Optional. Artifact Registry repository name. Specified Go modules will be zipped and uploaded to Artifact
        /// Registry with this location as a prefix. e.g. my-go-repo
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryName")]
        public virtual string RepositoryName { get; set; }

        /// <summary>Optional. Project ID of the Artifact Registry repository. Defaults to the build project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repositoryProjectId")]
        public virtual string RepositoryProjectId { get; set; }

        /// <summary>
        /// Optional. Source path of the go.mod file in the build's workspace. If not specified, this will default to
        /// the current directory. e.g. ~/code/go/mypackage
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePath")]
        public virtual string SourcePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container message for hash values.</summary>
    public class GoogleDevtoolsCloudbuildV1Hash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of hash that was performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The hash value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>HttpConfig is a configuration for HTTP related git operations.</summary>
    public class GoogleDevtoolsCloudbuildV1HttpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// SecretVersion resource of the HTTP proxy URL. The Service Account used in the build (either the default
        /// Service Account or user-specified Service Account) should have `secretmanager.versions.access` permissions
        /// on this secret. The proxy URL should be in format `protocol://@]proxyhost[:port]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxySecretVersionName")]
        public virtual string ProxySecretVersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pairs a set of secret environment variables mapped to encrypted values with the Cloud KMS key to use to decrypt
    /// the value.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1InlineSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map of environment variable name to its encrypted value. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size.
        /// There can be at most 100 secret values across all of a build's secrets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envMap")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvMap { get; set; }

        /// <summary>
        /// Resource name of Cloud KMS crypto key to decrypt the encrypted value. In format:
        /// projects/*/locations/*/keyRings/*/cryptoKeys/*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Maven artifact to upload to Artifact Registry upon successful completion of all build steps.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1MavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maven `artifactId` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactId")]
        public virtual string ArtifactId { get; set; }

        /// <summary>Maven `groupId` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>
        /// Optional. Path to an artifact in the build's workspace to be uploaded to Artifact Registry. This can be
        /// either an absolute path, e.g. /workspace/my-app/target/my-app-1.0.SNAPSHOT.jar or a relative path from
        /// /workspace, e.g. my-app/target/my-app-1.0.SNAPSHOT.jar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-maven.pkg.dev/$PROJECT/$REPOSITORY" Artifact in
        /// the workspace specified by path will be uploaded to Artifact Registry with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>Maven `version` value used when uploading the artifact to Artifact Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Npm package to upload to Artifact Registry upon successful completion of all build steps.</summary>
    public class GoogleDevtoolsCloudbuildV1NpmPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path to the package.json. e.g. workspace/path/to/package</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packagePath")]
        public virtual string PackagePath { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-npm.pkg.dev/$PROJECT/$REPOSITORY" Npm package in
        /// the workspace specified by path will be zipped and uploaded to Artifact Registry with this location as a
        /// prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about how a build should be executed on a `WorkerPool`. See [running builds in a private
    /// pool](https://cloud.google.com/build/docs/private-pools/run-builds-in-private-pool) for more information.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1PoolOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The `WorkerPool` resource to execute the build on. You must have `cloudbuild.workerpools.use` on the project
        /// hosting the WorkerPool. Format projects/{project}/locations/{location}/workerPools/{workerPoolId}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Python package to upload to Artifact Registry upon successful completion of all build steps. A package can
    /// encapsulate multiple objects to be uploaded to a single repository.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1PythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path globs used to match files in the build's workspace. For Python/ Twine, this is usually `dist/*`, and
        /// sometimes additionally an `.asc` file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>
        /// Artifact Registry repository, in the form "https://$REGION-python.pkg.dev/$PROJECT/$REPOSITORY" Files in the
        /// workspace matching any path pattern will be uploaded to Artifact Registry with this location as a prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a Google Cloud Source Repository.</summary>
    public class GoogleDevtoolsCloudbuildV1RepoSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regex matching branches to build. The syntax of the regular expressions accepted is the syntax accepted by
        /// RE2 and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branchName")]
        public virtual string BranchName { get; set; }

        /// <summary>Explicit commit SHA to build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitSha")]
        public virtual string CommitSha { get; set; }

        /// <summary>
        /// Optional. Directory, relative to the source root, in which to run the build. This must be a relative path.
        /// If a step's `dir` is specified and is an absolute path, this value is ignored for that step's execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dir")]
        public virtual string Dir { get; set; }

        /// <summary>Optional. Only trigger a build if the revision regex does NOT match the revision regex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invertRegex")]
        public virtual System.Nullable<bool> InvertRegex { get; set; }

        /// <summary>
        /// Optional. ID of the project that owns the Cloud Source Repository. If omitted, the project ID requesting the
        /// build is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. Name of the Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoName")]
        public virtual string RepoName { get; set; }

        /// <summary>
        /// Optional. Substitutions to use in a triggered build. Should only be used with RunBuildTrigger
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitutions")]
        public virtual System.Collections.Generic.IDictionary<string, string> Substitutions { get; set; }

        /// <summary>
        /// Regex matching tags to build. The syntax of the regular expressions accepted is the syntax accepted by RE2
        /// and described at https://github.com/google/re2/wiki/Syntax
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagName")]
        public virtual string TagName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifacts created by the build pipeline.</summary>
    public class GoogleDevtoolsCloudbuildV1Results : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path to the artifact manifest for non-container artifacts uploaded to Cloud Storage. Only populated when
        /// artifacts are uploaded to Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactManifest")]
        public virtual string ArtifactManifest { get; set; }

        /// <summary>Time to push all non-container artifacts to Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifactTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan ArtifactTiming { get; set; }

        /// <summary>List of build step digests, in the order corresponding to build step indices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepImages")]
        public virtual System.Collections.Generic.IList<string> BuildStepImages { get; set; }

        /// <summary>
        /// List of build step outputs, produced by builder images, in the order corresponding to build step indices.
        /// [Cloud Builders](https://cloud.google.com/cloud-build/docs/cloud-builders) can produce this output by
        /// writing to `$BUILDER_OUTPUT/output`. Only the first 50KB of data is stored. Note that the `$BUILDER_OUTPUT`
        /// variable is read-only and can't be substituted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStepOutputs")]
        public virtual System.Collections.Generic.IList<string> BuildStepOutputs { get; set; }

        /// <summary>Optional. Go module artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goModules")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1UploadedGoModule> GoModules { get; set; }

        /// <summary>Container images that were built as a part of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1BuiltImage> Images { get; set; }

        /// <summary>Maven artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mavenArtifacts")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1UploadedMavenArtifact> MavenArtifacts { get; set; }

        /// <summary>Npm packages uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("npmPackages")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1UploadedNpmPackage> NpmPackages { get; set; }

        /// <summary>
        /// Number of non-container artifacts uploaded to Cloud Storage. Only populated when artifacts are uploaded to
        /// Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numArtifacts")]
        public virtual System.Nullable<long> NumArtifacts { get; set; }

        /// <summary>Python artifacts uploaded to Artifact Registry at the end of the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonPackages")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1UploadedPythonPackage> PythonPackages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pairs a set of secret environment variables containing encrypted values with the Cloud KMS key to use to decrypt
    /// the value. Note: Use `kmsKeyName` with `available_secrets` instead of using `kmsKeyName` with `secret`. For
    /// instructions see: https://cloud.google.com/cloud-build/docs/securing-builds/use-encrypted-credentials.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud KMS key name to use to decrypt these envs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// Map of environment variable name to its encrypted value. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step. Values can be at most 64 KB in size.
        /// There can be at most 100 secret values across all of a build's secrets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretEnv")]
        public virtual System.Collections.Generic.IDictionary<string, string> SecretEnv { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pairs a secret environment variable with a SecretVersion in Secret Manager.</summary>
    public class GoogleDevtoolsCloudbuildV1SecretManagerSecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Environment variable name to associate with the secret. Secret environment variables must be unique across
        /// all of a build's secrets, and must be used by at least one build step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual string Env { get; set; }

        /// <summary>Resource name of the SecretVersion. In format: projects/*/secrets/*/versions/*</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Secrets and secret environment variables.</summary>
    public class GoogleDevtoolsCloudbuildV1Secrets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Secrets encrypted with KMS key and the associated secret environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1InlineSecret> Inline { get; set; }

        /// <summary>Secrets in Secret Manager and associated secret environment variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretManager")]
        public virtual System.Collections.Generic.IList<GoogleDevtoolsCloudbuildV1SecretManagerSecret> SecretManager { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in a supported storage service.</summary>
    public class GoogleDevtoolsCloudbuildV1Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If provided, get the source from this 2nd-gen Google Cloud Build repository resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectedRepository")]
        public virtual GoogleDevtoolsCloudbuildV1ConnectedRepository ConnectedRepository { get; set; }

        /// <summary>If provided, get the source from this Developer Connect config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerConnectConfig")]
        public virtual GoogleDevtoolsCloudbuildV1DeveloperConnectConfig DeveloperConnectConfig { get; set; }

        /// <summary>If provided, get the source from this Git repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitSource")]
        public virtual GoogleDevtoolsCloudbuildV1GitSource GitSource { get; set; }

        /// <summary>If provided, get the source from this location in a Cloud Source Repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repoSource")]
        public virtual GoogleDevtoolsCloudbuildV1RepoSource RepoSource { get; set; }

        /// <summary>If provided, get the source from this location in Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSource")]
        public virtual GoogleDevtoolsCloudbuildV1StorageSource StorageSource { get; set; }

        /// <summary>
        /// If provided, get the source from this manifest in Cloud Storage. This feature is in Preview; see description
        /// [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSourceManifest")]
        public virtual GoogleDevtoolsCloudbuildV1StorageSourceManifest StorageSourceManifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provenance of the source. Ways to find the original source, or verify that some source was used for this build.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1SourceProvenance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Hash(es) of the build source, which can be used to verify that the original source integrity
        /// was maintained in the build. Note that `FileHashes` will only be populated if `BuildOptions` has requested a
        /// `SourceProvenanceHash`. The keys to this map are file paths used as build source and the values contain the
        /// hash values for those files. If the build source came in a single package such as a gzipped tarfile
        /// (`.tar.gz`), the `FileHash` will be for the single path to that file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleDevtoolsCloudbuildV1FileHashes> FileHashes { get; set; }

        /// <summary>
        /// Output only. A copy of the build's `source.connected_repository`, if exists, with any revisions resolved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedConnectedRepository")]
        public virtual GoogleDevtoolsCloudbuildV1ConnectedRepository ResolvedConnectedRepository { get; set; }

        /// <summary>
        /// Output only. A copy of the build's `source.git_source`, if exists, with any revisions resolved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedGitSource")]
        public virtual GoogleDevtoolsCloudbuildV1GitSource ResolvedGitSource { get; set; }

        /// <summary>A copy of the build's `source.repo_source`, if exists, with any revisions resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedRepoSource")]
        public virtual GoogleDevtoolsCloudbuildV1RepoSource ResolvedRepoSource { get; set; }

        /// <summary>A copy of the build's `source.storage_source`, if exists, with any generations resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSource")]
        public virtual GoogleDevtoolsCloudbuildV1StorageSource ResolvedStorageSource { get; set; }

        /// <summary>
        /// A copy of the build's `source.storage_source_manifest`, if exists, with any revisions resolved. This feature
        /// is in Preview.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedStorageSourceManifest")]
        public virtual GoogleDevtoolsCloudbuildV1StorageSourceManifest ResolvedStorageSourceManifest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the source in an archive file in Cloud Storage.</summary>
    public class GoogleDevtoolsCloudbuildV1StorageSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage bucket containing the source (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Optional. Cloud Storage generation for the object. If the generation is omitted, the latest generation will
        /// be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Required. Cloud Storage object containing the source. This object must be a zipped (`.zip`) or gzipped
        /// archive file (`.tar.gz`) containing source to build.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>Optional. Option to specify the tool to fetch the source file for the build.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFetcher")]
        public virtual string SourceFetcher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Location of the source manifest in Cloud Storage. This feature is in Preview; see description
    /// [here](https://github.com/GoogleCloudPlatform/cloud-builders/tree/master/gcs-fetcher).
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1StorageSourceManifest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Cloud Storage bucket containing the source manifest (see [Bucket Name
        /// Requirements](https://cloud.google.com/storage/docs/bucket-naming#requirements)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Cloud Storage generation for the object. If the generation is omitted, the latest generation will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// Required. Cloud Storage object containing the source manifest. This object must be a JSON file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Start and end times for a build execution phase.</summary>
    public class GoogleDevtoolsCloudbuildV1TimeSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>End of time span.</summary>
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Start of time span.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Go module artifact uploaded to Artifact Registry using the GoModule directive.</summary>
    public class GoogleDevtoolsCloudbuildV1UploadedGoModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Go Module Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual GoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Maven artifact uploaded using the MavenArtifact directive.</summary>
    public class GoogleDevtoolsCloudbuildV1UploadedMavenArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Maven Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual GoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An npm package uploaded to Artifact Registry using the NpmPackage directive.</summary>
    public class GoogleDevtoolsCloudbuildV1UploadedNpmPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the npm package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual GoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded npm package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Artifact uploaded using the PythonPackage directive.</summary>
    public class GoogleDevtoolsCloudbuildV1UploadedPythonPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hash types and values of the Python Artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileHashes")]
        public virtual GoogleDevtoolsCloudbuildV1FileHashes FileHashes { get; set; }

        /// <summary>Output only. Stores timing information for pushing the specified artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushTiming")]
        public virtual GoogleDevtoolsCloudbuildV1TimeSpan PushTiming { get; set; }

        /// <summary>URI of the uploaded artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Volume describes a Docker container volume which is mounted into build steps in order to persist files across
    /// build step execution.
    /// </summary>
    public class GoogleDevtoolsCloudbuildV1Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the volume to mount. Volume names must be unique per build step and must be valid names for Docker
        /// volumes. Each named volume must be used by at least two build steps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Path at which to mount the volume. Paths must be absolute and cannot conflict with other volume paths on the
        /// same build step or with certain reserved volume paths.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A non-fatal problem encountered during the execution of the build.</summary>
    public class GoogleDevtoolsCloudbuildV1Warning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The priority for this warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>Explanation of the warning generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
    /// </summary>
    public class GoogleIamV1AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class GoogleIamV1AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class GoogleIamV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GoogleTypeExpr Condition { get; set; }

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
    public class GoogleIamV1Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<GoogleIamV1AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleIamV1Binding> Bindings { get; set; }

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

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class GoogleIamV1SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual GoogleIamV1Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class GoogleIamV1TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleIamV1TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

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

    /// <summary>The request message for Operations.WaitOperation.</summary>
    public class GoogleLongrunningWaitOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum duration to wait before timing out. If left blank, the wait will be at most the time permitted
        /// by the underlying HTTP/RPC protocol. If RPC context deadline is also specified, the shorter one will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

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
    public class GoogleTypeExpr : Google.Apis.Requests.IDirectResponseSchema
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
    /// This is proto2's version of MessageSet. DEPRECATED: DO NOT USE FOR NEW FIELDS. If you are using editions or
    /// proto2, please make your own extendable messages for your use case. If you are using proto3, please use `Any`
    /// instead. MessageSet was the implementation of extensions for proto1. When proto2 was introduced, extensions were
    /// implemented as a first-class feature. This schema for MessageSet was meant to be a "bridge" solution to migrate
    /// MessageSet-bearing messages from proto1 to proto2. This schema has been open-sourced only to facilitate the
    /// migration of Google products with MessageSet-bearing messages to open-source environments.
    /// </summary>
    public class Proto2BridgeMessageSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wire-format for a Status object</summary>
    public class UtilStatusProto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// copybara:strip_begin(b/383363683) copybara:strip_end_and_replace optional int32 canonical_code = 6;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalCode")]
        public virtual System.Nullable<int> CanonicalCode { get; set; }

        /// <summary>
        /// Numeric code drawn from the space specified below. Often, this is the canonical error space, and code is
        /// drawn from google3/util/task/codes.proto copybara:strip_begin(b/383363683) copybara:strip_end_and_replace
        /// optional int32 code = 1;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// Detail message copybara:strip_begin(b/383363683) copybara:strip_end_and_replace optional string message = 3;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>
        /// message_set associates an arbitrary proto message with the status. copybara:strip_begin(b/383363683)
        /// copybara:strip_end_and_replace optional proto2.bridge.MessageSet message_set = 5;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageSet")]
        public virtual Proto2BridgeMessageSet MessageSet { get; set; }

        /// <summary>
        /// copybara:strip_begin(b/383363683) Space to which this status belongs copybara:strip_end_and_replace optional
        /// string space = 2; // Space to which this status belongs
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual string Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
