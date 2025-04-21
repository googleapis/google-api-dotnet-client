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

namespace Google.Apis.Tasks.v1
{
    /// <summary>The Tasks Service.</summary>
    public class TasksService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TasksService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TasksService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Tasklists = new TasklistsResource(this);
            Tasks = new TasksResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://tasks.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://tasks.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "tasks";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Tasks API.</summary>
        public class Scope
        {
            /// <summary>Create, edit, organize, and delete all your tasks</summary>
            public static string Tasks = "https://www.googleapis.com/auth/tasks";

            /// <summary>View your tasks</summary>
            public static string TasksReadonly = "https://www.googleapis.com/auth/tasks.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Tasks API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Create, edit, organize, and delete all your tasks</summary>
            public const string Tasks = "https://www.googleapis.com/auth/tasks";

            /// <summary>View your tasks</summary>
            public const string TasksReadonly = "https://www.googleapis.com/auth/tasks.readonly";
        }

        /// <summary>Gets the Tasklists resource.</summary>
        public virtual TasklistsResource Tasklists { get; }

        /// <summary>Gets the Tasks resource.</summary>
        public virtual TasksResource Tasks { get; }
    }

    /// <summary>A base abstract class for Tasks requests.</summary>
    public abstract class TasksBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TasksBaseServiceRequest instance.</summary>
        protected TasksBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Tasks parameter list.</summary>
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

    /// <summary>The "tasklists" collection of methods.</summary>
    public class TasklistsResource
    {
        private const string Resource = "tasklists";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TasklistsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deletes the authenticated user's specified task list. If the list contains assigned tasks, both the assigned
        /// tasks and the original tasks in the assignment surface (Docs, Chat Spaces) are deleted.
        /// </summary>
        /// <param name="tasklist">Task list identifier.</param>
        public virtual DeleteRequest Delete(string tasklist)
        {
            return new DeleteRequest(this.service, tasklist);
        }

        /// <summary>
        /// Deletes the authenticated user's specified task list. If the list contains assigned tasks, both the assigned
        /// tasks and the original tasks in the assignment surface (Docs, Chat Spaces) are deleted.
        /// </summary>
        public class DeleteRequest : TasksBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string tasklist) : base(service)
            {
                Tasklist = tasklist;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/users/@me/lists/{tasklist}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the authenticated user's specified task list.</summary>
        /// <param name="tasklist">Task list identifier.</param>
        public virtual GetRequest Get(string tasklist)
        {
            return new GetRequest(this.service, tasklist);
        }

        /// <summary>Returns the authenticated user's specified task list.</summary>
        public class GetRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.TaskList>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string tasklist) : base(service)
            {
                Tasklist = tasklist;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/users/@me/lists/{tasklist}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates a new task list and adds it to the authenticated user's task lists. A user can have up to 2000 lists
        /// at a time.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Tasks.v1.Data.TaskList body)
        {
            return new InsertRequest(this.service, body);
        }

        /// <summary>
        /// Creates a new task list and adds it to the authenticated user's task lists. A user can have up to 2000 lists
        /// at a time.
        /// </summary>
        public class InsertRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.TaskList>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Tasks.v1.Data.TaskList body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Tasks.v1.Data.TaskList Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/users/@me/lists";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Returns all the authenticated user's task lists. A user can have up to 2000 lists at a time.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Returns all the authenticated user's task lists. A user can have up to 2000 lists at a time.
        /// </summary>
        public class ListRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.TaskLists>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Maximum number of task lists returned on one page. Optional. The default is 1000 (max allowed: 1000).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token specifying the result page to return. Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/users/@me/lists";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
        /// Updates the authenticated user's specified task list. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="tasklist">Task list identifier.</param>
        public virtual PatchRequest Patch(Google.Apis.Tasks.v1.Data.TaskList body, string tasklist)
        {
            return new PatchRequest(this.service, body, tasklist);
        }

        /// <summary>
        /// Updates the authenticated user's specified task list. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.TaskList>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Tasks.v1.Data.TaskList body, string tasklist) : base(service)
            {
                Tasklist = tasklist;
                Body = body;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Tasks.v1.Data.TaskList Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/users/@me/lists/{tasklist}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the authenticated user's specified task list.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="tasklist">Task list identifier.</param>
        public virtual UpdateRequest Update(Google.Apis.Tasks.v1.Data.TaskList body, string tasklist)
        {
            return new UpdateRequest(this.service, body, tasklist);
        }

        /// <summary>Updates the authenticated user's specified task list.</summary>
        public class UpdateRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.TaskList>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Tasks.v1.Data.TaskList body, string tasklist) : base(service)
            {
                Tasklist = tasklist;
                Body = body;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Tasks.v1.Data.TaskList Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/users/@me/lists/{tasklist}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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
        /// Clears all completed tasks from the specified task list. The affected tasks will be marked as 'hidden' and
        /// no longer be returned by default when retrieving all tasks for a task list.
        /// </summary>
        /// <param name="tasklist">Task list identifier.</param>
        public virtual ClearRequest Clear(string tasklist)
        {
            return new ClearRequest(this.service, tasklist);
        }

        /// <summary>
        /// Clears all completed tasks from the specified task list. The affected tasks will be marked as 'hidden' and
        /// no longer be returned by default when retrieving all tasks for a task list.
        /// </summary>
        public class ClearRequest : TasksBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Clear request.</summary>
            public ClearRequest(Google.Apis.Services.IClientService service, string tasklist) : base(service)
            {
                Tasklist = tasklist;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "clear";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/lists/{tasklist}/clear";

            /// <summary>Initializes Clear parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes the specified task from the task list. If the task is assigned, both the assigned task and the
        /// original task (in Docs, Chat Spaces) are deleted. To delete the assigned task only, navigate to the
        /// assignment surface and unassign the task from there.
        /// </summary>
        /// <param name="tasklist">Task list identifier.</param>
        /// <param name="task">Task identifier.</param>
        public virtual DeleteRequest Delete(string tasklist, string task)
        {
            return new DeleteRequest(this.service, tasklist, task);
        }

        /// <summary>
        /// Deletes the specified task from the task list. If the task is assigned, both the assigned task and the
        /// original task (in Docs, Chat Spaces) are deleted. To delete the assigned task only, navigate to the
        /// assignment surface and unassign the task from there.
        /// </summary>
        public class DeleteRequest : TasksBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string tasklist, string task) : base(service)
            {
                Tasklist = tasklist;
                Task = task;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Task identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("task", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Task { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/lists/{tasklist}/tasks/{task}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("task", new Google.Apis.Discovery.Parameter
                {
                    Name = "task",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the specified task.</summary>
        /// <param name="tasklist">Task list identifier.</param>
        /// <param name="task">Task identifier.</param>
        public virtual GetRequest Get(string tasklist, string task)
        {
            return new GetRequest(this.service, tasklist, task);
        }

        /// <summary>Returns the specified task.</summary>
        public class GetRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.Task>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string tasklist, string task) : base(service)
            {
                Tasklist = tasklist;
                Task = task;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Task identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("task", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Task { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/lists/{tasklist}/tasks/{task}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("task", new Google.Apis.Discovery.Parameter
                {
                    Name = "task",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates a new task on the specified task list. Tasks assigned from Docs or Chat Spaces cannot be inserted
        /// from Tasks Public API; they can only be created by assigning them from Docs or Chat Spaces. A user can have
        /// up to 20,000 non-hidden tasks per list and up to 100,000 tasks in total at a time.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="tasklist">Task list identifier.</param>
        public virtual InsertRequest Insert(Google.Apis.Tasks.v1.Data.Task body, string tasklist)
        {
            return new InsertRequest(this.service, body, tasklist);
        }

        /// <summary>
        /// Creates a new task on the specified task list. Tasks assigned from Docs or Chat Spaces cannot be inserted
        /// from Tasks Public API; they can only be created by assigning them from Docs or Chat Spaces. A user can have
        /// up to 20,000 non-hidden tasks per list and up to 100,000 tasks in total at a time.
        /// </summary>
        public class InsertRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.Task>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Tasks.v1.Data.Task body, string tasklist) : base(service)
            {
                Tasklist = tasklist;
                Body = body;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>
            /// Parent task identifier. If the task is created at the top level, this parameter is omitted. An assigned
            /// task cannot be a parent task, nor can it have a parent. Setting the parent to an assigned task results
            /// in failure of the request. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>
            /// Previous sibling task identifier. If the task is created at the first position among its siblings, this
            /// parameter is omitted. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("previous", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Previous { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Tasks.v1.Data.Task Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/lists/{tasklist}/tasks";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
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
                RequestParameters.Add("previous", new Google.Apis.Discovery.Parameter
                {
                    Name = "previous",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns all tasks in the specified task list. Doesn't return assigned tasks by default (from Docs, Chat
        /// Spaces). A user can have up to 20,000 non-hidden tasks per list and up to 100,000 tasks in total at a time.
        /// </summary>
        /// <param name="tasklist">Task list identifier.</param>
        public virtual ListRequest List(string tasklist)
        {
            return new ListRequest(this.service, tasklist);
        }

        /// <summary>
        /// Returns all tasks in the specified task list. Doesn't return assigned tasks by default (from Docs, Chat
        /// Spaces). A user can have up to 20,000 non-hidden tasks per list and up to 100,000 tasks in total at a time.
        /// </summary>
        public class ListRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.Tasks>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string tasklist) : base(service)
            {
                Tasklist = tasklist;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>
            /// Upper bound for a task's completion date (as a RFC 3339 timestamp) to filter by. Optional. The default
            /// is not to filter by completion date.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("completedMax", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CompletedMax { get; set; }

            /// <summary>
            /// Lower bound for a task's completion date (as a RFC 3339 timestamp) to filter by. Optional. The default
            /// is not to filter by completion date.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("completedMin", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CompletedMin { get; set; }

            /// <summary>
            /// Upper bound for a task's due date (as a RFC 3339 timestamp) to filter by. Optional. The default is not
            /// to filter by due date.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dueMax", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DueMax { get; set; }

            /// <summary>
            /// Lower bound for a task's due date (as a RFC 3339 timestamp) to filter by. Optional. The default is not
            /// to filter by due date.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dueMin", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DueMin { get; set; }

            /// <summary>
            /// Maximum number of tasks returned on one page. Optional. The default is 20 (max allowed: 100).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token specifying the result page to return. Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional. Flag indicating whether tasks assigned to the current user are returned in the result.
            /// Optional. The default is False.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showAssigned", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowAssigned { get; set; }

            /// <summary>
            /// Flag indicating whether completed tasks are returned in the result. Note that showHidden must also be
            /// True to show tasks completed in first party clients, such as the web UI and Google's mobile apps.
            /// Optional. The default is True.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showCompleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowCompleted { get; set; }

            /// <summary>
            /// Flag indicating whether deleted tasks are returned in the result. Optional. The default is False.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowDeleted { get; set; }

            /// <summary>
            /// Flag indicating whether hidden tasks are returned in the result. Optional. The default is False.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("showHidden", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ShowHidden { get; set; }

            /// <summary>
            /// Lower bound for a task's last modification time (as a RFC 3339 timestamp) to filter by. Optional. The
            /// default is not to filter by last modification time.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updatedMin", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UpdatedMin { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/lists/{tasklist}/tasks";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("completedMax", new Google.Apis.Discovery.Parameter
                {
                    Name = "completedMax",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("completedMin", new Google.Apis.Discovery.Parameter
                {
                    Name = "completedMin",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dueMax", new Google.Apis.Discovery.Parameter
                {
                    Name = "dueMax",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dueMin", new Google.Apis.Discovery.Parameter
                {
                    Name = "dueMin",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
                RequestParameters.Add("showAssigned", new Google.Apis.Discovery.Parameter
                {
                    Name = "showAssigned",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("showCompleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "showCompleted",
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
                RequestParameters.Add("showHidden", new Google.Apis.Discovery.Parameter
                {
                    Name = "showHidden",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("updatedMin", new Google.Apis.Discovery.Parameter
                {
                    Name = "updatedMin",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Moves the specified task to another position in the destination task list. If the destination list is not
        /// specified, the task is moved within its current list. This can include putting it as a child task under a
        /// new parent and/or move it to a different position among its sibling tasks. A user can have up to 2,000
        /// subtasks per task.
        /// </summary>
        /// <param name="tasklist">Task list identifier.</param>
        /// <param name="task">Task identifier.</param>
        public virtual MoveRequest Move(string tasklist, string task)
        {
            return new MoveRequest(this.service, tasklist, task);
        }

        /// <summary>
        /// Moves the specified task to another position in the destination task list. If the destination list is not
        /// specified, the task is moved within its current list. This can include putting it as a child task under a
        /// new parent and/or move it to a different position among its sibling tasks. A user can have up to 2,000
        /// subtasks per task.
        /// </summary>
        public class MoveRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.Task>
        {
            /// <summary>Constructs a new Move request.</summary>
            public MoveRequest(Google.Apis.Services.IClientService service, string tasklist, string task) : base(service)
            {
                Tasklist = tasklist;
                Task = task;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Task identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("task", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Task { get; private set; }

            /// <summary>
            /// Optional. Destination task list identifier. If set, the task is moved from tasklist to the
            /// destinationTasklist list. Otherwise the task is moved within its current list. Recurrent tasks cannot
            /// currently be moved between lists.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationTasklist", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DestinationTasklist { get; set; }

            /// <summary>
            /// Optional. New parent task identifier. If the task is moved to the top level, this parameter is omitted.
            /// The task set as parent must exist in the task list and can not be hidden. Exceptions: 1. Assigned tasks
            /// can not be set as parent task (have subtasks) or be moved under a parent task (become subtasks). 2.
            /// Tasks that are both completed and hidden cannot be nested, so the parent field must be empty.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>
            /// Optional. New previous sibling task identifier. If the task is moved to the first position among its
            /// siblings, this parameter is omitted. The task set as previous must exist in the task list and can not be
            /// hidden. Exceptions: 1. Tasks that are both completed and hidden can only be moved to position 0, so the
            /// previous field must be empty.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("previous", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Previous { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "move";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/lists/{tasklist}/tasks/{task}/move";

            /// <summary>Initializes Move parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("task", new Google.Apis.Discovery.Parameter
                {
                    Name = "task",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationTasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationTasklist",
                    IsRequired = false,
                    ParameterType = "query",
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
                RequestParameters.Add("previous", new Google.Apis.Discovery.Parameter
                {
                    Name = "previous",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the specified task. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="tasklist">Task list identifier.</param>
        /// <param name="task">Task identifier.</param>
        public virtual PatchRequest Patch(Google.Apis.Tasks.v1.Data.Task body, string tasklist, string task)
        {
            return new PatchRequest(this.service, body, tasklist, task);
        }

        /// <summary>Updates the specified task. This method supports patch semantics.</summary>
        public class PatchRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.Task>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Tasks.v1.Data.Task body, string tasklist, string task) : base(service)
            {
                Tasklist = tasklist;
                Task = task;
                Body = body;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Task identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("task", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Task { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Tasks.v1.Data.Task Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/lists/{tasklist}/tasks/{task}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("task", new Google.Apis.Discovery.Parameter
                {
                    Name = "task",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the specified task.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="tasklist">Task list identifier.</param>
        /// <param name="task">Task identifier.</param>
        public virtual UpdateRequest Update(Google.Apis.Tasks.v1.Data.Task body, string tasklist, string task)
        {
            return new UpdateRequest(this.service, body, tasklist, task);
        }

        /// <summary>Updates the specified task.</summary>
        public class UpdateRequest : TasksBaseServiceRequest<Google.Apis.Tasks.v1.Data.Task>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Tasks.v1.Data.Task body, string tasklist, string task) : base(service)
            {
                Tasklist = tasklist;
                Task = task;
                Body = body;
                InitParameters();
            }

            /// <summary>Task list identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("tasklist", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Tasklist { get; private set; }

            /// <summary>Task identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("task", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Task { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Tasks.v1.Data.Task Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tasks/v1/lists/{tasklist}/tasks/{task}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("tasklist", new Google.Apis.Discovery.Parameter
                {
                    Name = "tasklist",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("task", new Google.Apis.Discovery.Parameter
                {
                    Name = "task",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Tasks.v1.Data
{
    /// <summary>Information about the source of the task assignment (Document, Chat Space).</summary>
    public class AssignmentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Information about the Drive file where this task originates from. Currently, the Drive file can
        /// only be a document. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveResourceInfo")]
        public virtual DriveResourceInfo DriveResourceInfo { get; set; }

        /// <summary>
        /// Output only. An absolute link to the original task in the surface of assignment (Docs, Chat spaces, etc.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkToTask")]
        public virtual string LinkToTask { get; set; }

        /// <summary>
        /// Output only. Information about the Chat Space where this task originates from. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spaceInfo")]
        public virtual SpaceInfo SpaceInfo { get; set; }

        /// <summary>
        /// Output only. The type of surface this assigned task originates from. Currently limited to DOCUMENT or SPACE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surfaceType")]
        public virtual string SurfaceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the Drive resource where a task was assigned from (the document, sheet, etc.).
    /// </summary>
    public class DriveResourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Identifier of the file in the Drive API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFileId")]
        public virtual string DriveFileId { get; set; }

        /// <summary>
        /// Output only. Resource key required to access files shared via a shared link. Not required for all files. See
        /// also developers.google.com/drive/api/guides/resource-keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceKey")]
        public virtual string ResourceKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the Chat Space where a task was assigned from.</summary>
    public class SpaceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The Chat space where this task originates from. The format is "spaces/{space}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual string Space { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Task : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Context information for assigned tasks. A task can be assigned to a user, currently possible
        /// from surfaces like Docs and Chat Spaces. This field is populated for tasks assigned to the current user and
        /// identifies where the task was assigned from. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignmentInfo")]
        public virtual AssignmentInfo AssignmentInfo { get; set; }

        /// <summary>
        /// Completion date of the task (as a RFC 3339 timestamp). This field is omitted if the task has not been
        /// completed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completed")]
        public virtual string Completed { get; set; }

        /// <summary>
        /// Flag indicating whether the task has been deleted. For assigned tasks this field is read-only. They can only
        /// be deleted by calling tasks.delete, in which case both the assigned task and the original task (in Docs or
        /// Chat Spaces) are deleted. To delete the assigned task only, navigate to the assignment surface and unassign
        /// the task from there. The default is False.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// Due date of the task (as a RFC 3339 timestamp). Optional. The due date only records date information; the
        /// time portion of the timestamp is discarded when setting the due date. It isn't possible to read or write the
        /// time that a task is due via the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("due")]
        public virtual string Due { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Flag indicating whether the task is hidden. This is the case if the task had been marked completed when the
        /// task list was last cleared. The default is False. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hidden")]
        public virtual System.Nullable<bool> Hidden { get; set; }

        /// <summary>Task identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Type of the resource. This is always "tasks#task".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Output only. Collection of links. This collection is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("links")]
        public virtual System.Collections.Generic.IList<LinksData> Links { get; set; }

        /// <summary>
        /// Notes describing the task. Tasks assigned from Google Docs cannot have notes. Optional. Maximum length
        /// allowed: 8192 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>
        /// Output only. Parent task identifier. This field is omitted if it is a top-level task. Use the "move" method
        /// to move the task under a different parent or to the top level. A parent task can never be an assigned task
        /// (from Chat Spaces, Docs). This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Output only. String indicating the position of the task among its sibling tasks under the same parent task
        /// or at the top level. If this string is greater than another task's corresponding position string according
        /// to lexicographical ordering, the task is positioned after the other task under the same parent task (or at
        /// the top level). Use the "move" method to move the task to another position.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual string Position { get; set; }

        /// <summary>Output only. URL pointing to this task. Used to retrieve, update, or delete this task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Status of the task. This is either "needsAction" or "completed".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Title of the task. Maximum length allowed: 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. Last modification time of the task (as a RFC 3339 timestamp).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>Output only. An absolute link to the task in the Google Tasks Web UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webViewLink")]
        public virtual string WebViewLink { get; set; }

        /// <summary>Output only. Collection of links. This collection is read-only.</summary>
        public class LinksData
        {
            /// <summary>The description (might be empty).</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("description")]
            public virtual string Description { get; set; }

            /// <summary>The URL.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("link")]
            public virtual string Link { get; set; }

            /// <summary>Type of the link, e.g. "email", "generic", "chat_message", "keep_note".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }

    public class TaskList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Task list identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Type of the resource. This is always "tasks#taskList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. URL pointing to this task list. Used to retrieve, update, or delete this task list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Title of the task list. Maximum length allowed: 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. Last modification time of the task list (as a RFC 3339 timestamp).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }
    }

    public class TaskLists : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Collection of task lists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<TaskList> Items { get; set; }

        /// <summary>Type of the resource. This is always "tasks#taskLists".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token that can be used to request the next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    public class Tasks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Collection of tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Task> Items { get; set; }

        /// <summary>Type of the resource. This is always "tasks#tasks".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Token used to access the next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }
}
