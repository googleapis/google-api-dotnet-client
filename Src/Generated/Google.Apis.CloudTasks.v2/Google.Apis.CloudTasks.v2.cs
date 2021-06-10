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

namespace Google.Apis.CloudTasks.v2
{
    /// <summary>The CloudTasks Service.</summary>
    public class CloudTasksService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudTasksService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudTasksService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudtasks";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudtasks.googleapis.com/";
        #else
            "https://cloudtasks.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudtasks.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Tasks API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Tasks API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudTasks requests.</summary>
    public abstract class CloudTasksBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudTasksBaseServiceRequest instance.</summary>
        protected CloudTasksBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudTasks parameter list.</summary>
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
                Queues = new QueuesResource(service);
            }

            /// <summary>Gets the Queues resource.</summary>
            public virtual QueuesResource Queues { get; }

            /// <summary>The "queues" collection of methods.</summary>
            public class QueuesResource
            {
                private const string Resource = "queues";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public QueuesResource(Google.Apis.Services.IClientService service)
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

                    /// <summary>
                    /// Creates a task and adds it to a queue. Tasks cannot be updated after creation; there is no
                    /// UpdateTask command. * The maximum task size is 100KB.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The queue name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID` The queue must already exist.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudTasks.v2.Data.CreateTaskRequest body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a task and adds it to a queue. Tasks cannot be updated after creation; there is no
                    /// UpdateTask command. * The maximum task size is 100KB.
                    /// </summary>
                    public class CreateRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Task>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.CreateTaskRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The queue name. For example:
                        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID` The queue must already exist.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudTasks.v2.Data.CreateTaskRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/tasks";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a task. A task can be deleted if it is scheduled or dispatched. A task cannot be deleted
                    /// if it has executed successfully or permanently failed.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The task name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a task. A task can be deleted if it is scheduled or dispatched. A task cannot be deleted
                    /// if it has executed successfully or permanently failed.
                    /// </summary>
                    public class DeleteRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The task name. For example:
                        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+/tasks/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets a task.</summary>
                    /// <param name="name">
                    /// Required. The task name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets a task.</summary>
                    public class GetRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Task>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The task name. For example:
                        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The response_view specifies which subset of the Task will be returned. By default
                        /// response_view is BASIC; not all information is retrieved by default because some data, such
                        /// as payloads, might be desirable to return only when needed because of its large size or
                        /// because of the sensitivity of data that it contains. Authorization for FULL requires
                        /// `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/) permission on the
                        /// Task resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("responseView", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ResponseViewEnum> ResponseView { get; set; }

                        /// <summary>
                        /// The response_view specifies which subset of the Task will be returned. By default
                        /// response_view is BASIC; not all information is retrieved by default because some data, such
                        /// as payloads, might be desirable to return only when needed because of its large size or
                        /// because of the sensitivity of data that it contains. Authorization for FULL requires
                        /// `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/) permission on the
                        /// Task resource.
                        /// </summary>
                        public enum ResponseViewEnum
                        {
                            /// <summary>Unspecified. Defaults to BASIC.</summary>
                            [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                            VIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// The basic view omits fields which can be large or can contain sensitive data. This view
                            /// does not include the body in AppEngineHttpRequest. Bodies are desirable to return only
                            /// when needed, because they can be large and because of the sensitivity of the data that
                            /// you choose to store in it.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>
                            /// All information is returned. Authorization for FULL requires `cloudtasks.tasks.fullView`
                            /// [Google IAM](https://cloud.google.com/iam/) permission on the Queue resource.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+/tasks/[^/]+$",
                            });
                            RequestParameters.Add("responseView", new Google.Apis.Discovery.Parameter
                            {
                                Name = "responseView",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Lists the tasks in a queue. By default, only the BASIC view is retrieved due to performance
                    /// considerations; response_view controls the subset of information which is returned. The tasks
                    /// may be returned in any order. The ordering may change at any time.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The queue name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists the tasks in a queue. By default, only the BASIC view is retrieved due to performance
                    /// considerations; response_view controls the subset of information which is returned. The tasks
                    /// may be returned in any order. The ordering may change at any time.
                    /// </summary>
                    public class ListRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.ListTasksResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The queue name. For example:
                        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Maximum page size. Fewer tasks than requested might be returned, even if more tasks exist;
                        /// use next_page_token in the response to determine if more tasks exist. The maximum page size
                        /// is 1000. If unspecified, the page size will be the maximum.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A token identifying the page of results to return. To request the first page results,
                        /// page_token must be empty. To request the next page of results, page_token must be the value
                        /// of next_page_token returned from the previous call to ListTasks method. The page token is
                        /// valid for only 2 hours.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// The response_view specifies which subset of the Task will be returned. By default
                        /// response_view is BASIC; not all information is retrieved by default because some data, such
                        /// as payloads, might be desirable to return only when needed because of its large size or
                        /// because of the sensitivity of data that it contains. Authorization for FULL requires
                        /// `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/) permission on the
                        /// Task resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("responseView", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ResponseViewEnum> ResponseView { get; set; }

                        /// <summary>
                        /// The response_view specifies which subset of the Task will be returned. By default
                        /// response_view is BASIC; not all information is retrieved by default because some data, such
                        /// as payloads, might be desirable to return only when needed because of its large size or
                        /// because of the sensitivity of data that it contains. Authorization for FULL requires
                        /// `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/) permission on the
                        /// Task resource.
                        /// </summary>
                        public enum ResponseViewEnum
                        {
                            /// <summary>Unspecified. Defaults to BASIC.</summary>
                            [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                            VIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// The basic view omits fields which can be large or can contain sensitive data. This view
                            /// does not include the body in AppEngineHttpRequest. Bodies are desirable to return only
                            /// when needed, because they can be large and because of the sensitivity of the data that
                            /// you choose to store in it.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>
                            /// All information is returned. Authorization for FULL requires `cloudtasks.tasks.fullView`
                            /// [Google IAM](https://cloud.google.com/iam/) permission on the Queue resource.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
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
                            RequestParameters.Add("responseView", new Google.Apis.Discovery.Parameter
                            {
                                Name = "responseView",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Forces a task to run now. When this method is called, Cloud Tasks will dispatch the task, even
                    /// if the task is already running, the queue has reached its RateLimits or is PAUSED. This command
                    /// is meant to be used for manual debugging. For example, RunTask can be used to retry a failed
                    /// task after a fix has been made or to manually force a task to be dispatched now. The dispatched
                    /// task is returned. That is, the task that is returned contains the status after the task is
                    /// dispatched but before the task is received by its target. If Cloud Tasks receives a successful
                    /// response from the task's target, then the task will be deleted; otherwise the task's
                    /// schedule_time will be reset to the time that RunTask was called plus the retry delay specified
                    /// in the queue's RetryConfig. RunTask returns NOT_FOUND when it is called on a task that has
                    /// already succeeded or permanently failed.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The task name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
                    /// </param>
                    public virtual RunRequest Run(Google.Apis.CloudTasks.v2.Data.RunTaskRequest body, string name)
                    {
                        return new RunRequest(service, body, name);
                    }

                    /// <summary>
                    /// Forces a task to run now. When this method is called, Cloud Tasks will dispatch the task, even
                    /// if the task is already running, the queue has reached its RateLimits or is PAUSED. This command
                    /// is meant to be used for manual debugging. For example, RunTask can be used to retry a failed
                    /// task after a fix has been made or to manually force a task to be dispatched now. The dispatched
                    /// task is returned. That is, the task that is returned contains the status after the task is
                    /// dispatched but before the task is received by its target. If Cloud Tasks receives a successful
                    /// response from the task's target, then the task will be deleted; otherwise the task's
                    /// schedule_time will be reset to the time that RunTask was called plus the retry delay specified
                    /// in the queue's RetryConfig. RunTask returns NOT_FOUND when it is called on a task that has
                    /// already succeeded or permanently failed.
                    /// </summary>
                    public class RunRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Task>
                    {
                        /// <summary>Constructs a new Run request.</summary>
                        public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.RunTaskRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The task name. For example:
                        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudTasks.v2.Data.RunTaskRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+/tasks/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>
                /// Creates a queue. Queues created with this method allow tasks to live for a maximum of 31 days. After
                /// a task is 31 days old, the task will be deleted regardless of whether it was dispatched or not.
                /// WARNING: Using this method may have unintended side effects if you are using an App Engine
                /// `queue.yaml` or `queue.xml` file to manage your queues. Read [Overview of Queue Management and
                /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using this method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The location name in which the queue will be created. For example:
                /// `projects/PROJECT_ID/locations/LOCATION_ID` The list of allowed locations can be obtained by calling
                /// Cloud Tasks' implementation of ListLocations.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudTasks.v2.Data.Queue body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a queue. Queues created with this method allow tasks to live for a maximum of 31 days. After
                /// a task is 31 days old, the task will be deleted regardless of whether it was dispatched or not.
                /// WARNING: Using this method may have unintended side effects if you are using an App Engine
                /// `queue.yaml` or `queue.xml` file to manage your queues. Read [Overview of Queue Management and
                /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using this method.
                /// </summary>
                public class CreateRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Queue>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.Queue body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location name in which the queue will be created. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID` The list of allowed locations can be obtained by
                    /// calling Cloud Tasks' implementation of ListLocations.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTasks.v2.Data.Queue Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/queues";

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
                /// Deletes a queue. This command will delete the queue even if it has tasks in it. Note: If you delete
                /// a queue, a queue with the same name can't be created for 7 days. WARNING: Using this method may have
                /// unintended side effects if you are using an App Engine `queue.yaml` or `queue.xml` file to manage
                /// your queues. Read [Overview of Queue Management and
                /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using this method.
                /// </summary>
                /// <param name="name">
                /// Required. The queue name. For example: `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a queue. This command will delete the queue even if it has tasks in it. Note: If you delete
                /// a queue, a queue with the same name can't be created for 7 days. WARNING: Using this method may have
                /// unintended side effects if you are using an App Engine `queue.yaml` or `queue.xml` file to manage
                /// your queues. Read [Overview of Queue Management and
                /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using this method.
                /// </summary>
                public class DeleteRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The queue name. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a queue.</summary>
                /// <param name="name">
                /// Required. The resource name of the queue. For example:
                /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a queue.</summary>
                public class GetRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Queue>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the queue. For example:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID`
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a Queue. Returns an empty policy if the resource exists and does
                /// not have a policy set. Authorization requires the following [Google
                /// IAM](https://cloud.google.com/iam) permission on the specified resource parent: *
                /// `cloudtasks.queues.getIamPolicy`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudTasks.v2.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a Queue. Returns an empty policy if the resource exists and does
                /// not have a policy set. Authorization requires the following [Google
                /// IAM](https://cloud.google.com/iam) permission on the specified resource parent: *
                /// `cloudtasks.queues.getIamPolicy`
                /// </summary>
                public class GetIamPolicyRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTasks.v2.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists queues. Queues are returned in lexicographical order.</summary>
                /// <param name="parent">
                /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists queues. Queues are returned in lexicographical order.</summary>
                public class ListRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.ListQueuesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The location name. For example: `projects/PROJECT_ID/locations/LOCATION_ID`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// `filter` can be used to specify a subset of queues. Any Queue field can be used as a filter and
                    /// several operators as supported. For example: `&amp;lt;=, &amp;lt;, &amp;gt;=, &amp;gt;, !=, =,
                    /// :`. The filter syntax is the same as described in [Stackdriver's Advanced Logs
                    /// Filters](https://cloud.google.com/logging/docs/view/advanced_filters). Sample filter "state:
                    /// PAUSED". Note that using filters might cause fewer queues than the requested page_size to be
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Requested page size. The maximum page size is 9800. If unspecified, the page size will be the
                    /// maximum. Fewer queues than requested might be returned, even if more queues exist; use the
                    /// next_page_token in the response to determine if more queues exist.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A token identifying the page of results to return. To request the first page results, page_token
                    /// must be empty. To request the next page of results, page_token must be the value of
                    /// next_page_token returned from the previous call to ListQueues method. It is an error to switch
                    /// the value of the filter while iterating through pages.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/queues";

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
                /// Updates a queue. This method creates the queue if it does not exist and updates the queue if it does
                /// exist. Queues created with this method allow tasks to live for a maximum of 31 days. After a task is
                /// 31 days old, the task will be deleted regardless of whether it was dispatched or not. WARNING: Using
                /// this method may have unintended side effects if you are using an App Engine `queue.yaml` or
                /// `queue.xml` file to manage your queues. Read [Overview of Queue Management and
                /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using this method.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Caller-specified and required in CreateQueue, after which it becomes output only. The queue name.
                /// The queue name must have the following format:
                /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID` * `PROJECT_ID` can contain letters
                /// ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see
                /// [Identifying
                /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects)
                /// * `LOCATION_ID` is the canonical ID for the queue's location. The list of available locations can be
                /// obtained by calling ListLocations. For more information, see
                /// https://cloud.google.com/about/locations/. * `QUEUE_ID` can contain letters ([A-Za-z]), numbers
                /// ([0-9]), or hyphens (-). The maximum length is 100 characters.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudTasks.v2.Data.Queue body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a queue. This method creates the queue if it does not exist and updates the queue if it does
                /// exist. Queues created with this method allow tasks to live for a maximum of 31 days. After a task is
                /// 31 days old, the task will be deleted regardless of whether it was dispatched or not. WARNING: Using
                /// this method may have unintended side effects if you are using an App Engine `queue.yaml` or
                /// `queue.xml` file to manage your queues. Read [Overview of Queue Management and
                /// queue.yaml](https://cloud.google.com/tasks/docs/queue-yaml) before using this method.
                /// </summary>
                public class PatchRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Queue>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.Queue body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Caller-specified and required in CreateQueue, after which it becomes output only. The queue
                    /// name. The queue name must have the following format:
                    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID` * `PROJECT_ID` can contain letters
                    /// ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see
                    /// [Identifying
                    /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects)
                    /// * `LOCATION_ID` is the canonical ID for the queue's location. The list of available locations
                    /// can be obtained by calling ListLocations. For more information, see
                    /// https://cloud.google.com/about/locations/. * `QUEUE_ID` can contain letters ([A-Za-z]), numbers
                    /// ([0-9]), or hyphens (-). The maximum length is 100 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// A mask used to specify which fields of the queue are being updated. If empty, then all fields
                    /// will be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTasks.v2.Data.Queue Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
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
                /// Pauses the queue. If a queue is paused then the system will stop dispatching tasks until the queue
                /// is resumed via ResumeQueue. Tasks can still be added when the queue is paused. A queue is paused if
                /// its state is PAUSED.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The queue name. For example: `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
                /// </param>
                public virtual PauseRequest Pause(Google.Apis.CloudTasks.v2.Data.PauseQueueRequest body, string name)
                {
                    return new PauseRequest(service, body, name);
                }

                /// <summary>
                /// Pauses the queue. If a queue is paused then the system will stop dispatching tasks until the queue
                /// is resumed via ResumeQueue. Tasks can still be added when the queue is paused. A queue is paused if
                /// its state is PAUSED.
                /// </summary>
                public class PauseRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Queue>
                {
                    /// <summary>Constructs a new Pause request.</summary>
                    public PauseRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.PauseQueueRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The queue name. For example:
                    /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTasks.v2.Data.PauseQueueRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "pause";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:pause";

                    /// <summary>Initializes Pause parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Purges a queue by deleting all of its tasks. All tasks created before this method is called are
                /// permanently deleted. Purge operations can take up to one minute to take effect. Tasks might be
                /// dispatched before the purge takes effect. A purge is irreversible.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The queue name. For example: `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
                /// </param>
                public virtual PurgeRequest Purge(Google.Apis.CloudTasks.v2.Data.PurgeQueueRequest body, string name)
                {
                    return new PurgeRequest(service, body, name);
                }

                /// <summary>
                /// Purges a queue by deleting all of its tasks. All tasks created before this method is called are
                /// permanently deleted. Purge operations can take up to one minute to take effect. Tasks might be
                /// dispatched before the purge takes effect. A purge is irreversible.
                /// </summary>
                public class PurgeRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Queue>
                {
                    /// <summary>Constructs a new Purge request.</summary>
                    public PurgeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.PurgeQueueRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The queue name. For example:
                    /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTasks.v2.Data.PurgeQueueRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "purge";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:purge";

                    /// <summary>Initializes Purge parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Resume a queue. This method resumes a queue after it has been PAUSED or DISABLED. The state of a
                /// queue is stored in the queue's state; after calling this method it will be set to RUNNING. WARNING:
                /// Resuming many high-QPS queues at the same time can lead to target overloading. If you are resuming
                /// high-QPS queues, follow the 500/50/5 pattern described in [Managing Cloud Tasks Scaling
                /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The queue name. For example: `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
                /// </param>
                public virtual ResumeRequest Resume(Google.Apis.CloudTasks.v2.Data.ResumeQueueRequest body, string name)
                {
                    return new ResumeRequest(service, body, name);
                }

                /// <summary>
                /// Resume a queue. This method resumes a queue after it has been PAUSED or DISABLED. The state of a
                /// queue is stored in the queue's state; after calling this method it will be set to RUNNING. WARNING:
                /// Resuming many high-QPS queues at the same time can lead to target overloading. If you are resuming
                /// high-QPS queues, follow the 500/50/5 pattern described in [Managing Cloud Tasks Scaling
                /// Risks](https://cloud.google.com/tasks/docs/manage-cloud-task-scaling).
                /// </summary>
                public class ResumeRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Queue>
                {
                    /// <summary>Constructs a new Resume request.</summary>
                    public ResumeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.ResumeQueueRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The queue name. For example:
                    /// `projects/PROJECT_ID/location/LOCATION_ID/queues/QUEUE_ID`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTasks.v2.Data.ResumeQueueRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resume";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:resume";

                    /// <summary>Initializes Resume parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy for a Queue. Replaces any existing policy. Note: The Cloud Console
                /// does not check queue-level IAM permissions yet. Project-level permissions are required to use the
                /// Cloud Console. Authorization requires the following [Google IAM](https://cloud.google.com/iam)
                /// permission on the specified resource parent: * `cloudtasks.queues.setIamPolicy`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudTasks.v2.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy for a Queue. Replaces any existing policy. Note: The Cloud Console
                /// does not check queue-level IAM permissions yet. Project-level permissions are required to use the
                /// Cloud Console. Authorization requires the following [Google IAM](https://cloud.google.com/iam)
                /// permission on the specified resource parent: * `cloudtasks.queues.setIamPolicy`
                /// </summary>
                public class SetIamPolicyRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTasks.v2.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on a Queue. If the resource does not exist, this will return
                /// an empty set of permissions, not a NOT_FOUND error. Note: This operation is designed to be used for
                /// building permission-aware UIs and command-line tools, not for authorization checking. This operation
                /// may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudTasks.v2.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on a Queue. If the resource does not exist, this will return
                /// an empty set of permissions, not a NOT_FOUND error. Note: This operation is designed to be used for
                /// building permission-aware UIs and command-line tools, not for authorization checking. This operation
                /// may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTasks.v2.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTasks.v2.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/queues/[^/]+$",
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
            public class GetRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.Location>
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
            public class ListRequest : CloudTasksBaseServiceRequest<Google.Apis.CloudTasks.v2.Data.ListLocationsResponse>
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
namespace Google.Apis.CloudTasks.v2.Data
{
    /// <summary>
    /// App Engine HTTP request. The message defines the HTTP request that is sent to an App Engine app when the task is
    /// dispatched. Using AppEngineHttpRequest requires
    /// [`appengine.applications.get`](https://cloud.google.com/appengine/docs/admin-api/access-control) Google IAM
    /// permission for the project and the following scope: `https://www.googleapis.com/auth/cloud-platform` The task
    /// will be delivered to the App Engine app which belongs to the same project as the queue. For more information,
    /// see [How Requests are Routed](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed)
    /// and how routing is affected by [dispatch
    /// files](https://cloud.google.com/appengine/docs/python/config/dispatchref). Traffic is encrypted during transport
    /// and never leaves Google datacenters. Because this traffic is carried over a communication mechanism internal to
    /// Google, you cannot explicitly set the protocol (for example, HTTP or HTTPS). The request to the handler,
    /// however, will appear to have used the HTTP protocol. The AppEngineRouting used to construct the URL that the
    /// task is delivered to can be set at the queue-level or task-level: * If app_engine_routing_override is set on the
    /// queue, this value is used for all tasks in the queue, no matter what the setting is for the task-level
    /// app_engine_routing. The `url` that the task will be sent to is: * `url =` host `+` relative_uri Tasks can be
    /// dispatched to secure app handlers, unsecure app handlers, and URIs restricted with [`login:
    /// admin`](https://cloud.google.com/appengine/docs/standard/python/config/appref). Because tasks are not run as any
    /// user, they cannot be dispatched to URIs restricted with [`login:
    /// required`](https://cloud.google.com/appengine/docs/standard/python/config/appref) Task dispatches also do not
    /// follow redirects. The task attempt has succeeded if the app's request handler returns an HTTP response code in
    /// the range [`200` - `299`]. The task attempt has failed if the app's handler returns a non-2xx response code or
    /// Cloud Tasks does not receive response before the deadline. Failed tasks will be retried according to the retry
    /// configuration. `503` (Service Unavailable) is considered an App Engine system error instead of an application
    /// error and will cause Cloud Tasks' traffic congestion control to temporarily throttle the queue's dispatches.
    /// Unlike other types of task targets, a `429` (Too Many Requests) response from an app handler does not cause
    /// traffic congestion control to throttle the queue.
    /// </summary>
    public class AppEngineHttpRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Task-level setting for App Engine routing. * If app_engine_routing_override is set on the queue, this value
        /// is used for all tasks in the queue, no matter what the setting is for the task-level app_engine_routing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineRouting")]
        public virtual AppEngineRouting AppEngineRouting { get; set; }

        /// <summary>
        /// HTTP request body. A request body is allowed only if the HTTP method is POST or PUT. It is an error to set a
        /// body on a task with an incompatible HttpMethod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// HTTP request headers. This map contains the header field names and values. Headers can be set when the task
        /// is created. Repeated headers are not supported but a header value can contain commas. Cloud Tasks sets some
        /// headers to default values: * `User-Agent`: By default, this header is `"AppEngine-Google;
        /// (+http://code.google.com/appengine)"`. This header can be modified, but Cloud Tasks will append
        /// `"AppEngine-Google; (+http://code.google.com/appengine)"` to the modified `User-Agent`. If the task has a
        /// body, Cloud Tasks sets the following headers: * `Content-Type`: By default, the `Content-Type` header is set
        /// to `"application/octet-stream"`. The default can be overridden by explicitly setting `Content-Type` to a
        /// particular media type when the task is created. For example, `Content-Type` can be set to
        /// `"application/json"`. * `Content-Length`: This is computed by Cloud Tasks. This value is output only. It
        /// cannot be changed. The headers below cannot be set or overridden: * `Host` * `X-Google-*` * `X-AppEngine-*`
        /// In addition, Cloud Tasks sets some headers when the task is dispatched, such as headers containing
        /// information about the task; see [request
        /// headers](https://cloud.google.com/tasks/docs/creating-appengine-handlers#reading_request_headers). These
        /// headers are set only when the task is dispatched, so they are not visible when the task is returned in a
        /// Cloud Tasks response. Although there is no specific limit for the maximum number of headers or the size,
        /// there is a limit on the maximum size of the Task. For more information, see the CreateTask documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// The HTTP method to use for the request. The default is POST. The app's request handler for the task's target
        /// URL must be able to handle HTTP requests with this http_method, otherwise the task attempt fails with error
        /// code 405 (Method Not Allowed). See [Writing a push task request
        /// handler](https://cloud.google.com/appengine/docs/java/taskqueue/push/creating-handlers#writing_a_push_task_request_handler)
        /// and the App Engine documentation for your runtime on [How Requests are
        /// Handled](https://cloud.google.com/appengine/docs/standard/python3/how-requests-are-handled).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpMethod")]
        public virtual string HttpMethod { get; set; }

        /// <summary>
        /// The relative URI. The relative URI must begin with "/" and must be a valid HTTP relative URI. It can contain
        /// a path and query string arguments. If the relative URI is empty, then the root path "/" will be used. No
        /// spaces are allowed, and the maximum length allowed is 2083 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeUri")]
        public virtual string RelativeUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// App Engine Routing. Defines routing characteristics specific to App Engine - service, version, and instance. For
    /// more information about services, versions, and instances see [An Overview of App
    /// Engine](https://cloud.google.com/appengine/docs/python/an-overview-of-app-engine), [Microservices Architecture
    /// on Google App Engine](https://cloud.google.com/appengine/docs/python/microservices-on-app-engine), [App Engine
    /// Standard request routing](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed), and
    /// [App Engine Flex request
    /// routing](https://cloud.google.com/appengine/docs/flexible/python/how-requests-are-routed). Using
    /// AppEngineRouting requires
    /// [`appengine.applications.get`](https://cloud.google.com/appengine/docs/admin-api/access-control) Google IAM
    /// permission for the project and the following scope: `https://www.googleapis.com/auth/cloud-platform`
    /// </summary>
    public class AppEngineRouting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The host that the task is sent to. The host is constructed from the domain name of the app
        /// associated with the queue's project ID (for example .appspot.com), and the service, version, and instance.
        /// Tasks which were created using the App Engine SDK might have a custom domain name. For more information, see
        /// [How Requests are Routed](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// App instance. By default, the task is sent to an instance which is available when the task is attempted.
        /// Requests can only be sent to a specific instance if [manual scaling is used in App Engine
        /// Standard](https://cloud.google.com/appengine/docs/python/an-overview-of-app-engine?hl=en_US#scaling_types_and_instance_classes).
        /// App Engine Flex does not support instances. For more information, see [App Engine Standard request
        /// routing](https://cloud.google.com/appengine/docs/standard/python/how-requests-are-routed) and [App Engine
        /// Flex request routing](https://cloud.google.com/appengine/docs/flexible/python/how-requests-are-routed).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>
        /// App service. By default, the task is sent to the service which is the default service when the task is
        /// attempted. For some queues or tasks which were created using the App Engine Task Queue API, host is not
        /// parsable into service, version, and instance. For example, some tasks which were created using the App
        /// Engine SDK use a custom domain name; custom domains are not parsed by Cloud Tasks. If host is not parsable,
        /// then service, version, and instance are the empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// App version. By default, the task is sent to the version which is the default version when the task is
        /// attempted. For some queues or tasks which were created using the App Engine Task Queue API, host is not
        /// parsable into service, version, and instance. For example, some tasks which were created using the App
        /// Engine SDK use a custom domain name; custom domains are not parsed by Cloud Tasks. If host is not parsable,
        /// then service, version, and instance are the empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of a task attempt.</summary>
    public class Attempt : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The time that this attempt was dispatched. `dispatch_time` will be truncated to the nearest
        /// microsecond.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dispatchTime")]
        public virtual object DispatchTime { get; set; }

        /// <summary>
        /// Output only. The response from the worker for this attempt. If `response_time` is unset, then the task has
        /// not been attempted or is currently running and the `response_status` field is meaningless.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseStatus")]
        public virtual Status ResponseStatus { get; set; }

        /// <summary>
        /// Output only. The time that this attempt response was received. `response_time` will be truncated to the
        /// nearest microsecond.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseTime")]
        public virtual object ResponseTime { get; set; }

        /// <summary>
        /// Output only. The time that this attempt was scheduled. `schedule_time` will be truncated to the nearest
        /// microsecond.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleTime")]
        public virtual object ScheduleTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateTask.</summary>
    public class CreateTaskRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The response_view specifies which subset of the Task will be returned. By default response_view is BASIC;
        /// not all information is retrieved by default because some data, such as payloads, might be desirable to
        /// return only when needed because of its large size or because of the sensitivity of data that it contains.
        /// Authorization for FULL requires `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/)
        /// permission on the Task resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseView")]
        public virtual string ResponseView { get; set; }

        /// <summary>
        /// Required. The task to add. Task names have the following format:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`. The user can optionally specify a
        /// task name. If a name is not specified then the system will generate a random unique task id, which will be
        /// set in the task returned in the response. If schedule_time is not set or is in the past then Cloud Tasks
        /// will set it to the current time. Task De-duplication: Explicitly specifying a task ID enables task
        /// de-duplication. If a task's ID is identical to that of an existing task or a task that was deleted or
        /// executed recently then the call will fail with ALREADY_EXISTS. If the task's queue was created using Cloud
        /// Tasks, then another task with the same name can't be created for ~1hour after the original task was deleted
        /// or executed. If the task's queue was created using queue.yaml or queue.xml, then another task with the same
        /// name can't be created for ~9days after the original task was deleted or executed. Because there is an extra
        /// lookup cost to identify duplicate task names, these CreateTask calls have significantly increased latency.
        /// Using hashed strings for the task id or for the prefix of the task id is recommended. Choosing task ids that
        /// are sequential or have sequential prefixes, for example using a timestamp, causes an increase in latency and
        /// error rates in all task commands. The infrastructure relies on an approximately uniform distribution of task
        /// ids to store and serve tasks efficiently.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("task")]
        public virtual Task Task { get; set; }

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

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// HTTP request. The task will be pushed to the worker as an HTTP request. If the worker or the redirected worker
    /// acknowledges the task by returning a successful HTTP response code ([`200` - `299`]), the task will be removed
    /// from the queue. If any other HTTP response code is returned or no response is received, the task will be retried
    /// according to the following: * User-specified throttling: retry configuration, rate limits, and the queue's
    /// state. * System throttling: To prevent the worker from overloading, Cloud Tasks may temporarily reduce the
    /// queue's effective rate. User-specified settings will not be changed. System throttling happens because: * Cloud
    /// Tasks backs off on all errors. Normally the backoff specified in rate limits will be used. But if the worker
    /// returns `429` (Too Many Requests), `503` (Service Unavailable), or the rate of errors is high, Cloud Tasks will
    /// use a higher backoff rate. The retry specified in the `Retry-After` HTTP response header is considered. * To
    /// prevent traffic spikes and to smooth sudden increases in traffic, dispatches ramp up slowly when the queue is
    /// newly created or idle and if large numbers of tasks suddenly become available to dispatch (due to spikes in
    /// create task rates, the queue being unpaused, or many tasks that are scheduled at the same time).
    /// </summary>
    public class HttpRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// HTTP request body. A request body is allowed only if the HTTP method is POST, PUT, or PATCH. It is an error
        /// to set body on a task with an incompatible HttpMethod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// HTTP request headers. This map contains the header field names and values. Headers can be set when the task
        /// is created. These headers represent a subset of the headers that will accompany the task's HTTP request.
        /// Some HTTP request headers will be ignored or replaced. A partial list of headers that will be ignored or
        /// replaced is: * Host: This will be computed by Cloud Tasks and derived from HttpRequest.url. *
        /// Content-Length: This will be computed by Cloud Tasks. * User-Agent: This will be set to
        /// `"Google-Cloud-Tasks"`. * X-Google-*: Google use only. * X-AppEngine-*: Google use only. `Content-Type`
        /// won't be set by Cloud Tasks. You can explicitly set `Content-Type` to a media type when the task is created.
        /// For example, `Content-Type` can be set to `"application/octet-stream"` or `"application/json"`. Headers
        /// which can have multiple values (according to RFC2616) can be specified using comma-separated values. The
        /// size of the headers must be less than 80KB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>The HTTP method to use for the request. The default is POST.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpMethod")]
        public virtual string HttpMethod { get; set; }

        /// <summary>
        /// If specified, an [OAuth token](https://developers.google.com/identity/protocols/OAuth2) will be generated
        /// and attached as an `Authorization` header in the HTTP request. This type of authorization should generally
        /// only be used when calling Google APIs hosted on *.googleapis.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthToken")]
        public virtual OAuthToken OauthToken { get; set; }

        /// <summary>
        /// If specified, an [OIDC](https://developers.google.com/identity/protocols/OpenIDConnect) token will be
        /// generated and attached as an `Authorization` header in the HTTP request. This type of authorization can be
        /// used for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token
        /// yourself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcToken")]
        public virtual OidcToken OidcToken { get; set; }

        /// <summary>
        /// Required. The full url path that the request will be sent to. This string must begin with either "http://"
        /// or "https://". Some examples are: `http://acme.com` and `https://acme.com/sales:8080`. Cloud Tasks will
        /// encode some characters for safety and compatibility. The maximum allowed URL length is 2083 characters after
        /// encoding. The `Location` header response from a redirect response [`300` - `399`] may be followed. The
        /// redirect is not counted as a separate attempt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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

    /// <summary>Response message for ListQueues.</summary>
    public class ListQueuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve next page of results. To return the next page of results, call ListQueues with this
        /// value as the page_token. If the next_page_token is empty, there are no more results. The page token is valid
        /// for only 2 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of queues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queues")]
        public virtual System.Collections.Generic.IList<Queue> Queues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing tasks using ListTasks.</summary>
    public class ListTasksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve next page of results. To return the next page of results, call ListTasks with this value
        /// as the page_token. If the next_page_token is empty, there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tasks")]
        public virtual System.Collections.Generic.IList<Task> Tasks { get; set; }

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

    /// <summary>
    /// Contains information needed for generating an [OAuth
    /// token](https://developers.google.com/identity/protocols/OAuth2). This type of authorization should generally
    /// only be used when calling Google APIs hosted on *.googleapis.com.
    /// </summary>
    public class OAuthToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// OAuth scope to be used for generating OAuth access token. If not specified,
        /// "https://www.googleapis.com/auth/cloud-platform" will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// [Service account email](https://cloud.google.com/iam/docs/service-accounts) to be used for generating OAuth
        /// token. The service account must be within the same project as the queue. The caller must have
        /// iam.serviceAccounts.actAs permission for the service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information needed for generating an [OpenID Connect
    /// token](https://developers.google.com/identity/protocols/OpenIDConnect). This type of authorization can be used
    /// for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token yourself.
    /// </summary>
    public class OidcToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Audience to be used when generating OIDC token. If not specified, the URI specified in target will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>
        /// [Service account email](https://cloud.google.com/iam/docs/service-accounts) to be used for generating OIDC
        /// token. The service account must be within the same project as the queue. The caller must have
        /// iam.serviceAccounts.actAs permission for the service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for PauseQueue.</summary>
    public class PauseQueueRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
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

    /// <summary>Request message for PurgeQueue.</summary>
    public class PurgeQueueRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A queue is a container of related tasks. Queues are configured to manage how those tasks are dispatched.
    /// Configurable properties include rate limits, retry options, queue types, and others.
    /// </summary>
    public class Queue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Overrides for task-level app_engine_routing. These settings apply only to App Engine tasks in this queue.
        /// Http tasks are not affected. If set, `app_engine_routing_override` is used for all App Engine tasks in the
        /// queue, no matter what the setting is for the task-level app_engine_routing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineRoutingOverride")]
        public virtual AppEngineRouting AppEngineRoutingOverride { get; set; }

        /// <summary>
        /// Caller-specified and required in CreateQueue, after which it becomes output only. The queue name. The queue
        /// name must have the following format: `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID` *
        /// `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For
        /// more information, see [Identifying
        /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) *
        /// `LOCATION_ID` is the canonical ID for the queue's location. The list of available locations can be obtained
        /// by calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `QUEUE_ID`
        /// can contain letters ([A-Za-z]), numbers ([0-9]), or hyphens (-). The maximum length is 100 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The last time this queue was purged. All tasks that were created before this time were purged.
        /// A queue can be purged using PurgeQueue, the [App Engine Task Queue SDK, or the Cloud
        /// Console](https://cloud.google.com/appengine/docs/standard/python/taskqueue/push/deleting-tasks-and-queues#purging_all_tasks_from_a_queue).
        /// Purge time will be truncated to the nearest microsecond. Purge time will be unset if the queue has never
        /// been purged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purgeTime")]
        public virtual object PurgeTime { get; set; }

        /// <summary>
        /// Rate limits for task dispatches. rate_limits and retry_config are related because they both control task
        /// attempts. However they control task attempts in different ways: * rate_limits controls the total rate of
        /// dispatches from a queue (i.e. all traffic dispatched from the queue, regardless of whether the dispatch is
        /// from a first attempt or a retry). * retry_config controls what happens to particular a task after its first
        /// attempt fails. That is, retry_config controls task retries (the second attempt, third attempt, etc). The
        /// queue's actual dispatch rate is the result of: * Number of tasks in the queue * User-specified throttling:
        /// rate_limits, retry_config, and the queue's state. * System throttling due to `429` (Too Many Requests) or
        /// `503` (Service Unavailable) responses from the worker, high error rates, or to smooth sudden large traffic
        /// spikes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateLimits")]
        public virtual RateLimits RateLimits { get; set; }

        /// <summary>
        /// Settings that determine the retry behavior. * For tasks created using Cloud Tasks: the queue-level retry
        /// settings apply to all tasks in the queue that were created using Cloud Tasks. Retry settings cannot be set
        /// on individual tasks. * For tasks created using the App Engine SDK: the queue-level retry settings apply to
        /// all tasks in the queue which do not have retry settings explicitly set on the task and were created by the
        /// App Engine SDK. See [App Engine
        /// documentation](https://cloud.google.com/appengine/docs/standard/python/taskqueue/push/retrying-tasks).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryConfig")]
        public virtual RetryConfig RetryConfig { get; set; }

        /// <summary>
        /// Configuration options for writing logs to [Stackdriver Logging](https://cloud.google.com/logging/docs/). If
        /// this field is unset, then no logs are written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackdriverLoggingConfig")]
        public virtual StackdriverLoggingConfig StackdriverLoggingConfig { get; set; }

        /// <summary>
        /// Output only. The state of the queue. `state` can only be changed by calling PauseQueue, ResumeQueue, or
        /// uploading [queue.yaml/xml](https://cloud.google.com/appengine/docs/python/config/queueref). UpdateQueue
        /// cannot be used to change `state`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Rate limits. This message determines the maximum rate that tasks can be dispatched by a queue, regardless of
    /// whether the dispatch is a first task attempt or a retry. Note: The debugging command, RunTask, will run a task
    /// even if the queue has reached its RateLimits.
    /// </summary>
    public class RateLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The max burst size. Max burst size limits how fast tasks in queue are processed when many tasks
        /// are in the queue and the rate is high. This field allows the queue to have a high rate so processing starts
        /// shortly after a task is enqueued, but still limits resource usage when many tasks are enqueued in a short
        /// period of time. The [token bucket](https://wikipedia.org/wiki/Token_Bucket) algorithm is used to control the
        /// rate of task dispatches. Each queue has a token bucket that holds tokens, up to the maximum specified by
        /// `max_burst_size`. Each time a task is dispatched, a token is removed from the bucket. Tasks will be
        /// dispatched until the queue's bucket runs out of tokens. The bucket will be continuously refilled with new
        /// tokens based on max_dispatches_per_second. Cloud Tasks will pick the value of `max_burst_size` based on the
        /// value of max_dispatches_per_second. For queues that were created or updated using `queue.yaml/xml`,
        /// `max_burst_size` is equal to
        /// [bucket_size](https://cloud.google.com/appengine/docs/standard/python/config/queueref#bucket_size). Since
        /// `max_burst_size` is output only, if UpdateQueue is called on a queue created by `queue.yaml/xml`,
        /// `max_burst_size` will be reset based on the value of max_dispatches_per_second, regardless of whether
        /// max_dispatches_per_second is updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBurstSize")]
        public virtual System.Nullable<int> MaxBurstSize { get; set; }

        /// <summary>
        /// The maximum number of concurrent tasks that Cloud Tasks allows to be dispatched for this queue. After this
        /// threshold has been reached, Cloud Tasks stops dispatching tasks until the number of concurrent requests
        /// decreases. If unspecified when the queue is created, Cloud Tasks will pick the default. The maximum allowed
        /// value is 5,000. This field has the same meaning as [max_concurrent_requests in
        /// queue.yaml/xml](https://cloud.google.com/appengine/docs/standard/python/config/queueref#max_concurrent_requests).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxConcurrentDispatches")]
        public virtual System.Nullable<int> MaxConcurrentDispatches { get; set; }

        /// <summary>
        /// The maximum rate at which tasks are dispatched from this queue. If unspecified when the queue is created,
        /// Cloud Tasks will pick the default. * The maximum allowed value is 500. This field has the same meaning as
        /// [rate in queue.yaml/xml](https://cloud.google.com/appengine/docs/standard/python/config/queueref#rate).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDispatchesPerSecond")]
        public virtual System.Nullable<double> MaxDispatchesPerSecond { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ResumeQueue.</summary>
    public class ResumeQueueRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Retry config. These settings determine when a failed task attempt is retried.</summary>
    public class RetryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of attempts per task. Cloud Tasks will attempt the task `max_attempts` times (that is, if the first
        /// attempt fails, then there will be `max_attempts - 1` retries). Must be &amp;gt;= -1. If unspecified when the
        /// queue is created, Cloud Tasks will pick the default. -1 indicates unlimited attempts. This field has the
        /// same meaning as [task_retry_limit in
        /// queue.yaml/xml](https://cloud.google.com/appengine/docs/standard/python/config/queueref#retry_parameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAttempts")]
        public virtual System.Nullable<int> MaxAttempts { get; set; }

        /// <summary>
        /// A task will be scheduled for retry between min_backoff and max_backoff duration after it fails, if the
        /// queue's RetryConfig specifies that the task should be retried. If unspecified when the queue is created,
        /// Cloud Tasks will pick the default. `max_backoff` will be truncated to the nearest second. This field has the
        /// same meaning as [max_backoff_seconds in
        /// queue.yaml/xml](https://cloud.google.com/appengine/docs/standard/python/config/queueref#retry_parameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBackoff")]
        public virtual object MaxBackoff { get; set; }

        /// <summary>
        /// The time between retries will double `max_doublings` times. A task's retry interval starts at min_backoff,
        /// then doubles `max_doublings` times, then increases linearly, and finally retries at intervals of max_backoff
        /// up to max_attempts times. For example, if min_backoff is 10s, max_backoff is 300s, and `max_doublings` is 3,
        /// then the a task will first be retried in 10s. The retry interval will double three times, and then increase
        /// linearly by 2^3 * 10s. Finally, the task will retry at intervals of max_backoff until the task has been
        /// attempted max_attempts times. Thus, the requests will retry at 10s, 20s, 40s, 80s, 160s, 240s, 300s, 300s,
        /// .... If unspecified when the queue is created, Cloud Tasks will pick the default. This field has the same
        /// meaning as [max_doublings in
        /// queue.yaml/xml](https://cloud.google.com/appengine/docs/standard/python/config/queueref#retry_parameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDoublings")]
        public virtual System.Nullable<int> MaxDoublings { get; set; }

        /// <summary>
        /// If positive, `max_retry_duration` specifies the time limit for retrying a failed task, measured from when
        /// the task was first attempted. Once `max_retry_duration` time has passed *and* the task has been attempted
        /// max_attempts times, no further attempts will be made and the task will be deleted. If zero, then the task
        /// age is unlimited. If unspecified when the queue is created, Cloud Tasks will pick the default.
        /// `max_retry_duration` will be truncated to the nearest second. This field has the same meaning as
        /// [task_age_limit in
        /// queue.yaml/xml](https://cloud.google.com/appengine/docs/standard/python/config/queueref#retry_parameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetryDuration")]
        public virtual object MaxRetryDuration { get; set; }

        /// <summary>
        /// A task will be scheduled for retry between min_backoff and max_backoff duration after it fails, if the
        /// queue's RetryConfig specifies that the task should be retried. If unspecified when the queue is created,
        /// Cloud Tasks will pick the default. `min_backoff` will be truncated to the nearest second. This field has the
        /// same meaning as [min_backoff_seconds in
        /// queue.yaml/xml](https://cloud.google.com/appengine/docs/standard/python/config/queueref#retry_parameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minBackoff")]
        public virtual object MinBackoff { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for forcing a task to run now using RunTask.</summary>
    public class RunTaskRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The response_view specifies which subset of the Task will be returned. By default response_view is BASIC;
        /// not all information is retrieved by default because some data, such as payloads, might be desirable to
        /// return only when needed because of its large size or because of the sensitivity of data that it contains.
        /// Authorization for FULL requires `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/)
        /// permission on the Task resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseView")]
        public virtual string ResponseView { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration options for writing logs to [Stackdriver Logging](https://cloud.google.com/logging/docs/).
    /// </summary>
    public class StackdriverLoggingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the fraction of operations to write to [Stackdriver
        /// Logging](https://cloud.google.com/logging/docs/). This field may contain any value between 0.0 and 1.0,
        /// inclusive. 0.0 is the default and means that no operations are logged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplingRatio")]
        public virtual System.Nullable<double> SamplingRatio { get; set; }

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

    /// <summary>A unit of scheduled work.</summary>
    public class Task : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// HTTP request that is sent to the App Engine app handler. An App Engine task is a task that has
        /// AppEngineHttpRequest set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineHttpRequest")]
        public virtual AppEngineHttpRequest AppEngineHttpRequest { get; set; }

        /// <summary>
        /// Output only. The time that the task was created. `create_time` will be truncated to the nearest second.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The number of attempts dispatched. This count includes attempts which have been dispatched but
        /// haven't received a response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dispatchCount")]
        public virtual System.Nullable<int> DispatchCount { get; set; }

        /// <summary>
        /// The deadline for requests sent to the worker. If the worker does not respond by this deadline then the
        /// request is cancelled and the attempt is marked as a `DEADLINE_EXCEEDED` failure. Cloud Tasks will retry the
        /// task according to the RetryConfig. Note that when the request is cancelled, Cloud Tasks will stop listening
        /// for the response, but whether the worker stops processing depends on the worker. For example, if the worker
        /// is stuck, it may not react to cancelled requests. The default and maximum values depend on the type of
        /// request: * For HTTP tasks, the default is 10 minutes. The deadline must be in the interval [15 seconds, 30
        /// minutes]. * For App Engine tasks, 0 indicates that the request has the default deadline. The default
        /// deadline depends on the [scaling
        /// type](https://cloud.google.com/appengine/docs/standard/go/how-instances-are-managed#instance_scaling) of the
        /// service: 10 minutes for standard apps with automatic scaling, 24 hours for standard apps with manual and
        /// basic scaling, and 60 minutes for flex apps. If the request deadline is set, it must be in the interval [15
        /// seconds, 24 hours 15 seconds]. Regardless of the task's `dispatch_deadline`, the app handler will not run
        /// for longer than than the service's timeout. We recommend setting the `dispatch_deadline` to at most a few
        /// seconds more than the app handler's timeout. For more information see
        /// [Timeouts](https://cloud.google.com/tasks/docs/creating-appengine-handlers#timeouts). `dispatch_deadline`
        /// will be truncated to the nearest millisecond. The deadline is an approximate deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dispatchDeadline")]
        public virtual object DispatchDeadline { get; set; }

        /// <summary>
        /// Output only. The status of the task's first attempt. Only dispatch_time will be set. The other Attempt
        /// information is not retained by Cloud Tasks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstAttempt")]
        public virtual Attempt FirstAttempt { get; set; }

        /// <summary>HTTP request that is sent to the worker. An HTTP task is a task that has HttpRequest set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRequest")]
        public virtual HttpRequest HttpRequest { get; set; }

        /// <summary>Output only. The status of the task's last attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAttempt")]
        public virtual Attempt LastAttempt { get; set; }

        /// <summary>
        /// Optionally caller-specified in CreateTask. The task name. The task name must have the following format:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID` * `PROJECT_ID` can contain letters
        /// ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), or periods (.). For more information, see [Identifying
        /// projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects) *
        /// `LOCATION_ID` is the canonical ID for the task's location. The list of available locations can be obtained
        /// by calling ListLocations. For more information, see https://cloud.google.com/about/locations/. * `QUEUE_ID`
        /// can contain letters ([A-Za-z]), numbers ([0-9]), or hyphens (-). The maximum length is 100 characters. *
        /// `TASK_ID` can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), or underscores (_). The maximum
        /// length is 500 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The number of attempts which have received a response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseCount")]
        public virtual System.Nullable<int> ResponseCount { get; set; }

        /// <summary>
        /// The time when the task is scheduled to be attempted or retried. `schedule_time` will be truncated to the
        /// nearest microsecond.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleTime")]
        public virtual object ScheduleTime { get; set; }

        /// <summary>Output only. The view specifies which subset of the Task has been returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual string View { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
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
}
