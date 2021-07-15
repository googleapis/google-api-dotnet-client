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

namespace Google.Apis.Script.v1
{
    /// <summary>The Script Service.</summary>
    public class ScriptService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ScriptService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ScriptService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Processes = new ProcessesResource(this);
            Projects = new ProjectsResource(this);
            Scripts = new ScriptsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "script";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://script.googleapis.com/";
        #else
            "https://script.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://script.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Apps Script API.</summary>
        public class Scope
        {
            /// <summary>Read, compose, send, and permanently delete all your email from Gmail</summary>
            public static string MailGoogleCom = "https://mail.google.com/";

            /// <summary>
            /// See, edit, share, and permanently delete all the calendars you can access using Google Calendar
            /// </summary>
            public static string WwwGoogleComCalendarFeeds = "https://www.google.com/calendar/feeds";

            /// <summary>See, edit, download, and permanently delete your contacts</summary>
            public static string WwwGoogleComM8Feeds = "https://www.google.com/m8/feeds";

            /// <summary>View and manage the provisioning of groups on your domain</summary>
            public static string AdminDirectoryGroup = "https://www.googleapis.com/auth/admin.directory.group";

            /// <summary>View and manage the provisioning of users on your domain</summary>
            public static string AdminDirectoryUser = "https://www.googleapis.com/auth/admin.directory.user";

            /// <summary>See, edit, create, and delete all your Google Docs documents</summary>
            public static string Documents = "https://www.googleapis.com/auth/documents";

            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>View and manage your forms in Google Drive</summary>
            public static string Forms = "https://www.googleapis.com/auth/forms";

            /// <summary>View and manage forms that this application has been installed in</summary>
            public static string FormsCurrentonly = "https://www.googleapis.com/auth/forms.currentonly";

            /// <summary>View and manage your Google Groups</summary>
            public static string Groups = "https://www.googleapis.com/auth/groups";

            /// <summary>Create and update Google Apps Script deployments</summary>
            public static string ScriptDeployments = "https://www.googleapis.com/auth/script.deployments";

            /// <summary>View Google Apps Script deployments</summary>
            public static string ScriptDeploymentsReadonly = "https://www.googleapis.com/auth/script.deployments.readonly";

            /// <summary>View Google Apps Script project's metrics</summary>
            public static string ScriptMetrics = "https://www.googleapis.com/auth/script.metrics";

            /// <summary>View Google Apps Script processes</summary>
            public static string ScriptProcesses = "https://www.googleapis.com/auth/script.processes";

            /// <summary>Create and update Google Apps Script projects</summary>
            public static string ScriptProjects = "https://www.googleapis.com/auth/script.projects";

            /// <summary>View Google Apps Script projects</summary>
            public static string ScriptProjectsReadonly = "https://www.googleapis.com/auth/script.projects.readonly";

            /// <summary>See, edit, create, and delete all your Google Sheets spreadsheets</summary>
            public static string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>See your primary Google Account email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Apps Script API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Read, compose, send, and permanently delete all your email from Gmail</summary>
            public const string MailGoogleCom = "https://mail.google.com/";

            /// <summary>
            /// See, edit, share, and permanently delete all the calendars you can access using Google Calendar
            /// </summary>
            public const string WwwGoogleComCalendarFeeds = "https://www.google.com/calendar/feeds";

            /// <summary>See, edit, download, and permanently delete your contacts</summary>
            public const string WwwGoogleComM8Feeds = "https://www.google.com/m8/feeds";

            /// <summary>View and manage the provisioning of groups on your domain</summary>
            public const string AdminDirectoryGroup = "https://www.googleapis.com/auth/admin.directory.group";

            /// <summary>View and manage the provisioning of users on your domain</summary>
            public const string AdminDirectoryUser = "https://www.googleapis.com/auth/admin.directory.user";

            /// <summary>See, edit, create, and delete all your Google Docs documents</summary>
            public const string Documents = "https://www.googleapis.com/auth/documents";

            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public const string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>View and manage your forms in Google Drive</summary>
            public const string Forms = "https://www.googleapis.com/auth/forms";

            /// <summary>View and manage forms that this application has been installed in</summary>
            public const string FormsCurrentonly = "https://www.googleapis.com/auth/forms.currentonly";

            /// <summary>View and manage your Google Groups</summary>
            public const string Groups = "https://www.googleapis.com/auth/groups";

            /// <summary>Create and update Google Apps Script deployments</summary>
            public const string ScriptDeployments = "https://www.googleapis.com/auth/script.deployments";

            /// <summary>View Google Apps Script deployments</summary>
            public const string ScriptDeploymentsReadonly = "https://www.googleapis.com/auth/script.deployments.readonly";

            /// <summary>View Google Apps Script project's metrics</summary>
            public const string ScriptMetrics = "https://www.googleapis.com/auth/script.metrics";

            /// <summary>View Google Apps Script processes</summary>
            public const string ScriptProcesses = "https://www.googleapis.com/auth/script.processes";

            /// <summary>Create and update Google Apps Script projects</summary>
            public const string ScriptProjects = "https://www.googleapis.com/auth/script.projects";

            /// <summary>View Google Apps Script projects</summary>
            public const string ScriptProjectsReadonly = "https://www.googleapis.com/auth/script.projects.readonly";

            /// <summary>See, edit, create, and delete all your Google Sheets spreadsheets</summary>
            public const string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>See your primary Google Account email address</summary>
            public const string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";
        }

        /// <summary>Gets the Processes resource.</summary>
        public virtual ProcessesResource Processes { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Scripts resource.</summary>
        public virtual ScriptsResource Scripts { get; }
    }

    /// <summary>A base abstract class for Script requests.</summary>
    public abstract class ScriptBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ScriptBaseServiceRequest instance.</summary>
        protected ScriptBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Script parameter list.</summary>
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

    /// <summary>The "processes" collection of methods.</summary>
    public class ProcessesResource
    {
        private const string Resource = "processes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProcessesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// List information about processes made by or on behalf of a user, such as process type and current status.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// List information about processes made by or on behalf of a user, such as process type and current status.
        /// </summary>
        public class ListRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.ListUserProcessesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of returned processes per page of results. Defaults to 50.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// The token for continuing a previous list request on the next page. This should be set to the value of
            /// `nextPageToken` from a previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those originating from projects with a specific
            /// deployment ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.deploymentId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProcessFilterDeploymentId { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those that completed on or before the given
            /// timestamp.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.endTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UserProcessFilterEndTime { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those originating from a script function with the
            /// given function name.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.functionName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProcessFilterFunctionName { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those originating from projects with project names
            /// containing a specific string.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.projectName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProcessFilterProjectName { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those originating from projects with a specific
            /// script ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.scriptId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProcessFilterScriptId { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those that were started on or after the given
            /// timestamp.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.startTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UserProcessFilterStartTime { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified process statuses.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.statuses", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<UserProcessFilterStatusesEnum> UserProcessFilterStatuses { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified process statuses.
            /// </summary>
            public enum UserProcessFilterStatusesEnum
            {
                /// <summary>Unspecified status.</summary>
                [Google.Apis.Util.StringValueAttribute("PROCESS_STATUS_UNSPECIFIED")]
                PROCESSSTATUSUNSPECIFIED = 0,

                /// <summary>The process is currently running.</summary>
                [Google.Apis.Util.StringValueAttribute("RUNNING")]
                RUNNING = 1,

                /// <summary>The process has paused.</summary>
                [Google.Apis.Util.StringValueAttribute("PAUSED")]
                PAUSED = 2,

                /// <summary>The process has completed.</summary>
                [Google.Apis.Util.StringValueAttribute("COMPLETED")]
                COMPLETED = 3,

                /// <summary>The process was cancelled.</summary>
                [Google.Apis.Util.StringValueAttribute("CANCELED")]
                CANCELED = 4,

                /// <summary>The process failed.</summary>
                [Google.Apis.Util.StringValueAttribute("FAILED")]
                FAILED = 5,

                /// <summary>The process timed out.</summary>
                [Google.Apis.Util.StringValueAttribute("TIMED_OUT")]
                TIMEDOUT = 6,

                /// <summary>Process status unknown.</summary>
                [Google.Apis.Util.StringValueAttribute("UNKNOWN")]
                UNKNOWN = 7,

                /// <summary>The process is delayed, waiting for quota.</summary>
                [Google.Apis.Util.StringValueAttribute("DELAYED")]
                DELAYED = 8,
            }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified process types.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.types", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<UserProcessFilterTypesEnum> UserProcessFilterTypes { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified process types.
            /// </summary>
            public enum UserProcessFilterTypesEnum
            {
                /// <summary>Unspecified type.</summary>
                [Google.Apis.Util.StringValueAttribute("PROCESS_TYPE_UNSPECIFIED")]
                PROCESSTYPEUNSPECIFIED = 0,

                /// <summary>The process was started from an add-on entry point.</summary>
                [Google.Apis.Util.StringValueAttribute("ADD_ON")]
                ADDON = 1,

                /// <summary>The process was started using the Apps Script API.</summary>
                [Google.Apis.Util.StringValueAttribute("EXECUTION_API")]
                EXECUTIONAPI = 2,

                /// <summary>The process was started from a time-based trigger.</summary>
                [Google.Apis.Util.StringValueAttribute("TIME_DRIVEN")]
                TIMEDRIVEN = 3,

                /// <summary>The process was started from an event-based trigger.</summary>
                [Google.Apis.Util.StringValueAttribute("TRIGGER")]
                TRIGGER = 4,

                /// <summary>The process was started from a web app entry point.</summary>
                [Google.Apis.Util.StringValueAttribute("WEBAPP")]
                WEBAPP = 5,

                /// <summary>The process was started using the Apps Script IDE.</summary>
                [Google.Apis.Util.StringValueAttribute("EDITOR")]
                EDITOR = 6,

                /// <summary>The process was started from a G Suite simple trigger.</summary>
                [Google.Apis.Util.StringValueAttribute("SIMPLE_TRIGGER")]
                SIMPLETRIGGER = 7,

                /// <summary>The process was started from a G Suite menu item.</summary>
                [Google.Apis.Util.StringValueAttribute("MENU")]
                MENU = 8,

                /// <summary>The process was started as a task in a batch job.</summary>
                [Google.Apis.Util.StringValueAttribute("BATCH_TASK")]
                BATCHTASK = 9,
            }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified user access levels.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userProcessFilter.userAccessLevels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<UserProcessFilterUserAccessLevelsEnum> UserProcessFilterUserAccessLevels { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified user access levels.
            /// </summary>
            public enum UserProcessFilterUserAccessLevelsEnum
            {
                /// <summary>User access level unspecified</summary>
                [Google.Apis.Util.StringValueAttribute("USER_ACCESS_LEVEL_UNSPECIFIED")]
                USERACCESSLEVELUNSPECIFIED = 0,

                /// <summary>The user has no access.</summary>
                [Google.Apis.Util.StringValueAttribute("NONE")]
                NONE = 1,

                /// <summary>The user has read-only access.</summary>
                [Google.Apis.Util.StringValueAttribute("READ")]
                READ = 2,

                /// <summary>The user has write access.</summary>
                [Google.Apis.Util.StringValueAttribute("WRITE")]
                WRITE = 3,

                /// <summary>The user is an owner.</summary>
                [Google.Apis.Util.StringValueAttribute("OWNER")]
                OWNER = 4,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/processes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("userProcessFilter.deploymentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.deploymentId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProcessFilter.endTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.endTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProcessFilter.functionName", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.functionName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProcessFilter.projectName", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.projectName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProcessFilter.scriptId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.scriptId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProcessFilter.startTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.startTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProcessFilter.statuses", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.statuses",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProcessFilter.types", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.types",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProcessFilter.userAccessLevels", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProcessFilter.userAccessLevels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// List information about a script's executed processes, such as process type and current status.
        /// </summary>
        public virtual ListScriptProcessesRequest ListScriptProcesses()
        {
            return new ListScriptProcessesRequest(service);
        }

        /// <summary>
        /// List information about a script's executed processes, such as process type and current status.
        /// </summary>
        public class ListScriptProcessesRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.ListScriptProcessesResponse>
        {
            /// <summary>Constructs a new ListScriptProcesses request.</summary>
            public ListScriptProcessesRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of returned processes per page of results. Defaults to 50.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// The token for continuing a previous list request on the next page. This should be set to the value of
            /// `nextPageToken` from a previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The script ID of the project whose processes are listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ScriptId { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those originating from projects with a specific
            /// deployment ID.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptProcessFilter.deploymentId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ScriptProcessFilterDeploymentId { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those that completed on or before the given
            /// timestamp.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptProcessFilter.endTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ScriptProcessFilterEndTime { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those originating from a script function with the
            /// given function name.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptProcessFilter.functionName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ScriptProcessFilterFunctionName { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those that were started on or after the given
            /// timestamp.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptProcessFilter.startTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object ScriptProcessFilterStartTime { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified process statuses.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptProcessFilter.statuses", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ScriptProcessFilterStatusesEnum> ScriptProcessFilterStatuses { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified process statuses.
            /// </summary>
            public enum ScriptProcessFilterStatusesEnum
            {
                /// <summary>Unspecified status.</summary>
                [Google.Apis.Util.StringValueAttribute("PROCESS_STATUS_UNSPECIFIED")]
                PROCESSSTATUSUNSPECIFIED = 0,

                /// <summary>The process is currently running.</summary>
                [Google.Apis.Util.StringValueAttribute("RUNNING")]
                RUNNING = 1,

                /// <summary>The process has paused.</summary>
                [Google.Apis.Util.StringValueAttribute("PAUSED")]
                PAUSED = 2,

                /// <summary>The process has completed.</summary>
                [Google.Apis.Util.StringValueAttribute("COMPLETED")]
                COMPLETED = 3,

                /// <summary>The process was cancelled.</summary>
                [Google.Apis.Util.StringValueAttribute("CANCELED")]
                CANCELED = 4,

                /// <summary>The process failed.</summary>
                [Google.Apis.Util.StringValueAttribute("FAILED")]
                FAILED = 5,

                /// <summary>The process timed out.</summary>
                [Google.Apis.Util.StringValueAttribute("TIMED_OUT")]
                TIMEDOUT = 6,

                /// <summary>Process status unknown.</summary>
                [Google.Apis.Util.StringValueAttribute("UNKNOWN")]
                UNKNOWN = 7,

                /// <summary>The process is delayed, waiting for quota.</summary>
                [Google.Apis.Util.StringValueAttribute("DELAYED")]
                DELAYED = 8,
            }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified process types.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptProcessFilter.types", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ScriptProcessFilterTypesEnum> ScriptProcessFilterTypes { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified process types.
            /// </summary>
            public enum ScriptProcessFilterTypesEnum
            {
                /// <summary>Unspecified type.</summary>
                [Google.Apis.Util.StringValueAttribute("PROCESS_TYPE_UNSPECIFIED")]
                PROCESSTYPEUNSPECIFIED = 0,

                /// <summary>The process was started from an add-on entry point.</summary>
                [Google.Apis.Util.StringValueAttribute("ADD_ON")]
                ADDON = 1,

                /// <summary>The process was started using the Apps Script API.</summary>
                [Google.Apis.Util.StringValueAttribute("EXECUTION_API")]
                EXECUTIONAPI = 2,

                /// <summary>The process was started from a time-based trigger.</summary>
                [Google.Apis.Util.StringValueAttribute("TIME_DRIVEN")]
                TIMEDRIVEN = 3,

                /// <summary>The process was started from an event-based trigger.</summary>
                [Google.Apis.Util.StringValueAttribute("TRIGGER")]
                TRIGGER = 4,

                /// <summary>The process was started from a web app entry point.</summary>
                [Google.Apis.Util.StringValueAttribute("WEBAPP")]
                WEBAPP = 5,

                /// <summary>The process was started using the Apps Script IDE.</summary>
                [Google.Apis.Util.StringValueAttribute("EDITOR")]
                EDITOR = 6,

                /// <summary>The process was started from a G Suite simple trigger.</summary>
                [Google.Apis.Util.StringValueAttribute("SIMPLE_TRIGGER")]
                SIMPLETRIGGER = 7,

                /// <summary>The process was started from a G Suite menu item.</summary>
                [Google.Apis.Util.StringValueAttribute("MENU")]
                MENU = 8,

                /// <summary>The process was started as a task in a batch job.</summary>
                [Google.Apis.Util.StringValueAttribute("BATCH_TASK")]
                BATCHTASK = 9,
            }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified user access levels.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptProcessFilter.userAccessLevels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ScriptProcessFilterUserAccessLevelsEnum> ScriptProcessFilterUserAccessLevels { get; set; }

            /// <summary>
            /// Optional field used to limit returned processes to those having one of the specified user access levels.
            /// </summary>
            public enum ScriptProcessFilterUserAccessLevelsEnum
            {
                /// <summary>User access level unspecified</summary>
                [Google.Apis.Util.StringValueAttribute("USER_ACCESS_LEVEL_UNSPECIFIED")]
                USERACCESSLEVELUNSPECIFIED = 0,

                /// <summary>The user has no access.</summary>
                [Google.Apis.Util.StringValueAttribute("NONE")]
                NONE = 1,

                /// <summary>The user has read-only access.</summary>
                [Google.Apis.Util.StringValueAttribute("READ")]
                READ = 2,

                /// <summary>The user has write access.</summary>
                [Google.Apis.Util.StringValueAttribute("WRITE")]
                WRITE = 3,

                /// <summary>The user is an owner.</summary>
                [Google.Apis.Util.StringValueAttribute("OWNER")]
                OWNER = 4,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listScriptProcesses";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/processes:listScriptProcesses";

            /// <summary>Initializes ListScriptProcesses parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scriptProcessFilter.deploymentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptProcessFilter.deploymentId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scriptProcessFilter.endTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptProcessFilter.endTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scriptProcessFilter.functionName", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptProcessFilter.functionName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scriptProcessFilter.startTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptProcessFilter.startTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scriptProcessFilter.statuses", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptProcessFilter.statuses",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scriptProcessFilter.types", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptProcessFilter.types",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("scriptProcessFilter.userAccessLevels", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptProcessFilter.userAccessLevels",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
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
            Deployments = new DeploymentsResource(service);
            Versions = new VersionsResource(service);
        }

        /// <summary>Gets the Deployments resource.</summary>
        public virtual DeploymentsResource Deployments { get; }

        /// <summary>The "deployments" collection of methods.</summary>
        public class DeploymentsResource
        {
            private const string Resource = "deployments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DeploymentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a deployment of an Apps Script project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="scriptId">The script project's Drive ID.</param>
            public virtual CreateRequest Create(Google.Apis.Script.v1.Data.DeploymentConfig body, string scriptId)
            {
                return new CreateRequest(service, body, scriptId);
            }

            /// <summary>Creates a deployment of an Apps Script project.</summary>
            public class CreateRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Deployment>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Script.v1.Data.DeploymentConfig body, string scriptId) : base(service)
                {
                    ScriptId = scriptId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The script project's Drive ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ScriptId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Script.v1.Data.DeploymentConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{scriptId}/deployments";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a deployment of an Apps Script project.</summary>
            /// <param name="scriptId">The script project's Drive ID.</param>
            /// <param name="deploymentId">The deployment ID to be undeployed.</param>
            public virtual DeleteRequest Delete(string scriptId, string deploymentId)
            {
                return new DeleteRequest(service, scriptId, deploymentId);
            }

            /// <summary>Deletes a deployment of an Apps Script project.</summary>
            public class DeleteRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string scriptId, string deploymentId) : base(service)
                {
                    ScriptId = scriptId;
                    DeploymentId = deploymentId;
                    InitParameters();
                }

                /// <summary>The script project's Drive ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ScriptId { get; private set; }

                /// <summary>The deployment ID to be undeployed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deploymentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DeploymentId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{scriptId}/deployments/{deploymentId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("deploymentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deploymentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a deployment of an Apps Script project.</summary>
            /// <param name="scriptId">The script project's Drive ID.</param>
            /// <param name="deploymentId">The deployment ID.</param>
            public virtual GetRequest Get(string scriptId, string deploymentId)
            {
                return new GetRequest(service, scriptId, deploymentId);
            }

            /// <summary>Gets a deployment of an Apps Script project.</summary>
            public class GetRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Deployment>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string scriptId, string deploymentId) : base(service)
                {
                    ScriptId = scriptId;
                    DeploymentId = deploymentId;
                    InitParameters();
                }

                /// <summary>The script project's Drive ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ScriptId { get; private set; }

                /// <summary>The deployment ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deploymentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DeploymentId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{scriptId}/deployments/{deploymentId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("deploymentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deploymentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists the deployments of an Apps Script project.</summary>
            /// <param name="scriptId">The script project's Drive ID.</param>
            public virtual ListRequest List(string scriptId)
            {
                return new ListRequest(service, scriptId);
            }

            /// <summary>Lists the deployments of an Apps Script project.</summary>
            public class ListRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.ListDeploymentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string scriptId) : base(service)
                {
                    ScriptId = scriptId;
                    InitParameters();
                }

                /// <summary>The script project's Drive ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ScriptId { get; private set; }

                /// <summary>The maximum number of deployments on each returned page. Defaults to 50.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The token for continuing a previous list request on the next page. This should be set to the value
                /// of `nextPageToken` from a previous response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{scriptId}/deployments";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
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

            /// <summary>Updates a deployment of an Apps Script project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="scriptId">The script project's Drive ID.</param>
            /// <param name="deploymentId">The deployment ID for this deployment.</param>
            public virtual UpdateRequest Update(Google.Apis.Script.v1.Data.UpdateDeploymentRequest body, string scriptId, string deploymentId)
            {
                return new UpdateRequest(service, body, scriptId, deploymentId);
            }

            /// <summary>Updates a deployment of an Apps Script project.</summary>
            public class UpdateRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Deployment>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Script.v1.Data.UpdateDeploymentRequest body, string scriptId, string deploymentId) : base(service)
                {
                    ScriptId = scriptId;
                    DeploymentId = deploymentId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The script project's Drive ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ScriptId { get; private set; }

                /// <summary>The deployment ID for this deployment.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deploymentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DeploymentId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Script.v1.Data.UpdateDeploymentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{scriptId}/deployments/{deploymentId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("deploymentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deploymentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Versions resource.</summary>
        public virtual VersionsResource Versions { get; }

        /// <summary>The "versions" collection of methods.</summary>
        public class VersionsResource
        {
            private const string Resource = "versions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VersionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new immutable version using the current code, with a unique version number.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="scriptId">The script project's Drive ID.</param>
            public virtual CreateRequest Create(Google.Apis.Script.v1.Data.Version body, string scriptId)
            {
                return new CreateRequest(service, body, scriptId);
            }

            /// <summary>Creates a new immutable version using the current code, with a unique version number.</summary>
            public class CreateRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Version>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Script.v1.Data.Version body, string scriptId) : base(service)
                {
                    ScriptId = scriptId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The script project's Drive ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ScriptId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Script.v1.Data.Version Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{scriptId}/versions";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a version of a script project.</summary>
            /// <param name="scriptId">The script project's Drive ID.</param>
            /// <param name="versionNumber">The version number.</param>
            public virtual GetRequest Get(string scriptId, int versionNumber)
            {
                return new GetRequest(service, scriptId, versionNumber);
            }

            /// <summary>Gets a version of a script project.</summary>
            public class GetRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Version>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string scriptId, int versionNumber) : base(service)
                {
                    ScriptId = scriptId;
                    VersionNumber = versionNumber;
                    InitParameters();
                }

                /// <summary>The script project's Drive ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ScriptId { get; private set; }

                /// <summary>The version number.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionNumber", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int VersionNumber { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{scriptId}/versions/{versionNumber}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionNumber", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionNumber",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>List the versions of a script project.</summary>
            /// <param name="scriptId">The script project's Drive ID.</param>
            public virtual ListRequest List(string scriptId)
            {
                return new ListRequest(service, scriptId);
            }

            /// <summary>List the versions of a script project.</summary>
            public class ListRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.ListVersionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string scriptId) : base(service)
                {
                    ScriptId = scriptId;
                    InitParameters();
                }

                /// <summary>The script project's Drive ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ScriptId { get; private set; }

                /// <summary>The maximum number of versions on each returned page. Defaults to 50.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The token for continuing a previous list request on the next page. This should be set to the value
                /// of `nextPageToken` from a previous response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{scriptId}/versions";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scriptId",
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
        }

        /// <summary>Creates a new, empty script project with no script files and a base manifest file.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Script.v1.Data.CreateProjectRequest body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a new, empty script project with no script files and a base manifest file.</summary>
        public class CreateRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Project>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Script.v1.Data.CreateProjectRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Script.v1.Data.CreateProjectRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Gets a script project's metadata.</summary>
        /// <param name="scriptId">The script project's Drive ID.</param>
        public virtual GetRequest Get(string scriptId)
        {
            return new GetRequest(service, scriptId);
        }

        /// <summary>Gets a script project's metadata.</summary>
        public class GetRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Project>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string scriptId) : base(service)
            {
                ScriptId = scriptId;
                InitParameters();
            }

            /// <summary>The script project's Drive ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ScriptId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{scriptId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets the content of the script project, including the code source and metadata for each script file.
        /// </summary>
        /// <param name="scriptId">The script project's Drive ID.</param>
        public virtual GetContentRequest GetContent(string scriptId)
        {
            return new GetContentRequest(service, scriptId);
        }

        /// <summary>
        /// Gets the content of the script project, including the code source and metadata for each script file.
        /// </summary>
        public class GetContentRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Content>
        {
            /// <summary>Constructs a new GetContent request.</summary>
            public GetContentRequest(Google.Apis.Services.IClientService service, string scriptId) : base(service)
            {
                ScriptId = scriptId;
                InitParameters();
            }

            /// <summary>The script project's Drive ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ScriptId { get; private set; }

            /// <summary>
            /// The version number of the project to retrieve. If not provided, the project's HEAD version is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("versionNumber", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> VersionNumber { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getContent";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{scriptId}/content";

            /// <summary>Initializes GetContent parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("versionNumber", new Google.Apis.Discovery.Parameter
                {
                    Name = "versionNumber",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get metrics data for scripts, such as number of executions and active users.</summary>
        /// <param name="scriptId">Required field indicating the script to get metrics for.</param>
        public virtual GetMetricsRequest GetMetrics(string scriptId)
        {
            return new GetMetricsRequest(service, scriptId);
        }

        /// <summary>Get metrics data for scripts, such as number of executions and active users.</summary>
        public class GetMetricsRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Metrics>
        {
            /// <summary>Constructs a new GetMetrics request.</summary>
            public GetMetricsRequest(Google.Apis.Services.IClientService service, string scriptId) : base(service)
            {
                ScriptId = scriptId;
                InitParameters();
            }

            /// <summary>Required field indicating the script to get metrics for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ScriptId { get; private set; }

            /// <summary>Optional field indicating a specific deployment to retrieve metrics from.</summary>
            [Google.Apis.Util.RequestParameterAttribute("metricsFilter.deploymentId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string MetricsFilterDeploymentId { get; set; }

            /// <summary>Required field indicating what granularity of metrics are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("metricsGranularity", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<MetricsGranularityEnum> MetricsGranularity { get; set; }

            /// <summary>Required field indicating what granularity of metrics are returned.</summary>
            public enum MetricsGranularityEnum
            {
                /// <summary>Default metric granularity used to query no metrics.</summary>
                [Google.Apis.Util.StringValueAttribute("UNSPECIFIED_GRANULARITY")]
                UNSPECIFIEDGRANULARITY = 0,

                /// <summary>Represents weekly metrics.</summary>
                [Google.Apis.Util.StringValueAttribute("WEEKLY")]
                WEEKLY = 1,

                /// <summary>Represents daily metrics over a period of 7 days.</summary>
                [Google.Apis.Util.StringValueAttribute("DAILY")]
                DAILY = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getMetrics";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{scriptId}/metrics";

            /// <summary>Initializes GetMetrics parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("metricsFilter.deploymentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "metricsFilter.deploymentId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("metricsGranularity", new Google.Apis.Discovery.Parameter
                {
                    Name = "metricsGranularity",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the content of the specified script project. This content is stored as the HEAD version, and is used
        /// when the script is executed as a trigger, in the script editor, in add-on preview mode, or as a web app or
        /// Apps Script API in development mode. This clears all the existing files in the project.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="scriptId">The script project's Drive ID.</param>
        public virtual UpdateContentRequest UpdateContent(Google.Apis.Script.v1.Data.Content body, string scriptId)
        {
            return new UpdateContentRequest(service, body, scriptId);
        }

        /// <summary>
        /// Updates the content of the specified script project. This content is stored as the HEAD version, and is used
        /// when the script is executed as a trigger, in the script editor, in add-on preview mode, or as a web app or
        /// Apps Script API in development mode. This clears all the existing files in the project.
        /// </summary>
        public class UpdateContentRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Content>
        {
            /// <summary>Constructs a new UpdateContent request.</summary>
            public UpdateContentRequest(Google.Apis.Services.IClientService service, Google.Apis.Script.v1.Data.Content body, string scriptId) : base(service)
            {
                ScriptId = scriptId;
                Body = body;
                InitParameters();
            }

            /// <summary>The script project's Drive ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ScriptId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Script.v1.Data.Content Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContent";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{scriptId}/content";

            /// <summary>Initializes UpdateContent parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "scripts" collection of methods.</summary>
    public class ScriptsResource
    {
        private const string Resource = "scripts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ScriptsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Runs a function in an Apps Script project. The script project must be deployed for use with the Apps Script
        /// API and the calling application must share the same Cloud Platform project. This method requires
        /// authorization with an OAuth 2.0 token that includes at least one of the scopes listed in the
        /// [Authorization](#authorization-scopes) section; script projects that do not require authorization cannot be
        /// executed through this API. To find the correct scopes to include in the authentication token, open the
        /// script project **Overview** page and scroll down to "Project OAuth Scopes." The error `403,
        /// PERMISSION_DENIED: The caller does not have permission` indicates that the Cloud Platform project used to
        /// authorize the request is not the same as the one used by the script.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="scriptId">
        /// The script ID of the script to be executed. Find the script ID on the **Project settings** page under "IDs."
        /// </param>
        public virtual RunRequest Run(Google.Apis.Script.v1.Data.ExecutionRequest body, string scriptId)
        {
            return new RunRequest(service, body, scriptId);
        }

        /// <summary>
        /// Runs a function in an Apps Script project. The script project must be deployed for use with the Apps Script
        /// API and the calling application must share the same Cloud Platform project. This method requires
        /// authorization with an OAuth 2.0 token that includes at least one of the scopes listed in the
        /// [Authorization](#authorization-scopes) section; script projects that do not require authorization cannot be
        /// executed through this API. To find the correct scopes to include in the authentication token, open the
        /// script project **Overview** page and scroll down to "Project OAuth Scopes." The error `403,
        /// PERMISSION_DENIED: The caller does not have permission` indicates that the Cloud Platform project used to
        /// authorize the request is not the same as the one used by the script.
        /// </summary>
        public class RunRequest : ScriptBaseServiceRequest<Google.Apis.Script.v1.Data.Operation>
        {
            /// <summary>Constructs a new Run request.</summary>
            public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.Script.v1.Data.ExecutionRequest body, string scriptId) : base(service)
            {
                ScriptId = scriptId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The script ID of the script to be executed. Find the script ID on the **Project settings** page under
            /// "IDs."
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("scriptId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ScriptId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Script.v1.Data.ExecutionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "run";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/scripts/{scriptId}:run";

            /// <summary>Initializes Run parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("scriptId", new Google.Apis.Discovery.Parameter
                {
                    Name = "scriptId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Script.v1.Data
{
    /// <summary>The Content resource.</summary>
    public class Content : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of script project files. One of the files is a script manifest; it must be named "appsscript", must
        /// have type of JSON, and include the manifest configurations for the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<File> Files { get; set; }

        /// <summary>The script project's Drive ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptId")]
        public virtual string ScriptId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a script project. Request to create a script project.</summary>
    public class CreateProjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Drive ID of a parent file that the created script project is bound to. This is usually the ID of a
        /// Google Doc, Google Sheet, Google Form, or Google Slides file. If not set, a standalone script project is
        /// created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentId")]
        public virtual string ParentId { get; set; }

        /// <summary>The title for the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a single script deployment.</summary>
    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deployment configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentConfig")]
        public virtual DeploymentConfig DeploymentConfig { get; set; }

        /// <summary>The deployment ID for this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentId")]
        public virtual string DeploymentId { get; set; }

        /// <summary>The deployment's entry points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryPoints")]
        public virtual System.Collections.Generic.IList<EntryPoint> EntryPoints { get; set; }

        /// <summary>Last modified date time stamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata the defines how a deployment is configured.</summary>
    public class DeploymentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description for this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The manifest file name for this deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manifestFileName")]
        public virtual string ManifestFileName { get; set; }

        /// <summary>The script project's Drive ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptId")]
        public virtual string ScriptId { get; set; }

        /// <summary>The version number on which this deployment is based.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionNumber")]
        public virtual System.Nullable<int> VersionNumber { get; set; }

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

    /// <summary>A configuration that defines how a deployment is accessed externally.</summary>
    public class EntryPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Add-on properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addOn")]
        public virtual GoogleAppsScriptTypeAddOnEntryPoint AddOn { get; set; }

        /// <summary>The type of the entry point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryPointType")]
        public virtual string EntryPointType { get; set; }

        /// <summary>An entry point specification for Apps Script API execution calls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionApi")]
        public virtual GoogleAppsScriptTypeExecutionApiEntryPoint ExecutionApi { get; set; }

        /// <summary>An entry point specification for web apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webApp")]
        public virtual GoogleAppsScriptTypeWebAppEntryPoint WebApp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for executing or debugging a function in an Apps Script project.</summary>
    public class ExecuteStreamResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual ScriptExecutionResult Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that provides information about the nature of an error resulting from an attempted execution of a
    /// script function using the Apps Script API. If a run call succeeds but the script function (or Apps Script
    /// itself) throws an exception, the response body's error field contains a Status object. The `Status` object's
    /// `details` field contains an array with a single one of these `ExecutionError` objects.
    /// </summary>
    public class ExecutionError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error message thrown by Apps Script, usually localized into the user's language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// The error type, for example `TypeError` or `ReferenceError`. If the error type is unavailable, this field is
        /// not included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorType")]
        public virtual string ErrorType { get; set; }

        /// <summary>
        /// An array of objects that provide a stack trace through the script to show where the execution failed, with
        /// the deepest call first.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptStackTraceElements")]
        public virtual System.Collections.Generic.IList<ScriptStackTraceElement> ScriptStackTraceElements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A request to run the function in a script. The script is identified by the specified `script_id`. Executing a
    /// function on a script returns results based on the implementation of the script.
    /// </summary>
    public class ExecutionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `true` and the user is an owner of the script, the script runs at the most recently saved version rather
        /// than the version deployed for use with the Apps Script API. Optional; default is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devMode")]
        public virtual System.Nullable<bool> DevMode { get; set; }

        /// <summary>
        /// The name of the function to execute in the given script. The name does not include parentheses or
        /// parameters. It can reference a function in an included library such as `Library.libFunction1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>
        /// The parameters to be passed to the function being executed. The object type for each parameter should match
        /// the expected type in Apps Script. Parameters cannot be Apps Script-specific object types (such as a
        /// `Document` or a `Calendar`); they can only be primitive types such as `string`, `number`, `array`, `object`,
        /// or `boolean`. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<object> Parameters { get; set; }

        /// <summary>
        /// *Deprecated*. For use with Android add-ons only. An ID that represents the user's current session in the
        /// Android app for Google Docs or Sheets, included as extra data in the
        /// [Intent](https://developer.android.com/guide/components/intents-filters.html) that launches the add-on. When
        /// an Android add-on is run with a session state, it gains the privileges of a
        /// [bound](https://developers.google.com/apps-script/guides/bound) script—that is, it can access information
        /// like the user's current cursor position (in Docs) or selected cell (in Sheets). To retrieve the state, call
        /// `Intent.getStringExtra("com.google.android.apps.docs.addons.SessionState")`. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionState")]
        public virtual string SessionState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that provides the return value of a function executed using the Apps Script API. If the script
    /// function returns successfully, the response body's response field contains this `ExecutionResponse` object.
    /// </summary>
    public class ExecutionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The return value of the script function. The type matches the object type returned in Apps Script. Functions
        /// called using the Apps Script API cannot return Apps Script-specific objects (such as a `Document` or a
        /// `Calendar`); they can only return primitive types such as a `string`, `number`, `array`, `object`, or
        /// `boolean`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual object Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An individual file within a script project. A file is a third-party source code created by one or more
    /// developers. It can be a server-side JS code, HTML, or a configuration file. Each script project can contain
    /// multiple files.
    /// </summary>
    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Creation date timestamp. This read-only field is only visible to users who have WRITER permission for the
        /// script project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The defined set of functions in the script file, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionSet")]
        public virtual GoogleAppsScriptTypeFunctionSet FunctionSet { get; set; }

        /// <summary>
        /// The user who modified the file most recently. This read-only field is only visible to users who have WRITER
        /// permission for the script project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifyUser")]
        public virtual GoogleAppsScriptTypeUser LastModifyUser { get; set; }

        /// <summary>
        /// The name of the file. The file extension is not part of the file name, which can be identified from the type
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The file content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The type of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Last modified date timestamp. This read-only field is only visible to users who have WRITER permission for
        /// the script project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An add-on entry point.</summary>
    public class GoogleAppsScriptTypeAddOnEntryPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The add-on's required list of supported container types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addOnType")]
        public virtual string AddOnType { get; set; }

        /// <summary>The add-on's optional description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The add-on's optional help URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helpUrl")]
        public virtual string HelpUrl { get; set; }

        /// <summary>The add-on's required post install tip URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postInstallTipUrl")]
        public virtual string PostInstallTipUrl { get; set; }

        /// <summary>The add-on's optional report issue URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportIssueUrl")]
        public virtual string ReportIssueUrl { get; set; }

        /// <summary>The add-on's required title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>API executable entry point configuration.</summary>
    public class GoogleAppsScriptTypeExecutionApiConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Who has permission to run the API executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual string Access { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An API executable entry point.</summary>
    public class GoogleAppsScriptTypeExecutionApiEntryPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The entry point's configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryPointConfig")]
        public virtual GoogleAppsScriptTypeExecutionApiConfig EntryPointConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a function in a script project.</summary>
    public class GoogleAppsScriptTypeFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The function name in the script project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of functions. No duplicates are permitted.</summary>
    public class GoogleAppsScriptTypeFunctionSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of functions composing the set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GoogleAppsScriptTypeFunction> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of a single script process execution that was started from the script editor, a trigger, an
    /// application, or using the Apps Script API. This is distinct from the `Operation` resource, which only represents
    /// executions started via the Apps Script API.
    /// </summary>
    public class GoogleAppsScriptTypeProcess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Duration the execution spent executing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Name of the function the started the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual string FunctionName { get; set; }

        /// <summary>The executions status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processStatus")]
        public virtual string ProcessStatus { get; set; }

        /// <summary>The executions type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processType")]
        public virtual string ProcessType { get; set; }

        /// <summary>Name of the script being executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectName")]
        public virtual string ProjectName { get; set; }

        /// <summary>Time the execution started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The executing users access level to the script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAccessLevel")]
        public virtual string UserAccessLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A simple user profile resource.</summary>
    public class GoogleAppsScriptTypeUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The user's identifying email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The user's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The user's photo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUrl")]
        public virtual string PhotoUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Web app entry point configuration.</summary>
    public class GoogleAppsScriptTypeWebAppConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Who has permission to run the web app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual string Access { get; set; }

        /// <summary>Who to execute the web app as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executeAs")]
        public virtual string ExecuteAs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A web application entry point.</summary>
    public class GoogleAppsScriptTypeWebAppEntryPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The entry point's configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryPointConfig")]
        public virtual GoogleAppsScriptTypeWebAppConfig EntryPointConfig { get; set; }

        /// <summary>The URL for the web application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with the list of deployments for the specified Apps Script project.</summary>
    public class ListDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployments")]
        public virtual System.Collections.Generic.IList<Deployment> Deployments { get; set; }

        /// <summary>The token that can be used in the next call to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with the list of Process resources.</summary>
    public class ListScriptProcessesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token for the next page of results. If empty, there are no more pages remaining.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of processes matching request parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual System.Collections.Generic.IList<GoogleAppsScriptTypeProcess> Processes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with the list of Process resources.</summary>
    public class ListUserProcessesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token for the next page of results. If empty, there are no more pages remaining.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of processes matching request parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual System.Collections.Generic.IList<GoogleAppsScriptTypeProcess> Processes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ListValue` is a wrapper around a repeated field of values.</summary>
    public class ListValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Repeated field of dynamically typed values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<Value> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with the list of the versions for the specified script project.</summary>
    public class ListVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The token use to fetch the next page of records. if not exist in the response, that means no more versions
        /// to list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<Version> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource containing usage stats for a given script, based on the supplied filter and mask present in the
    /// request.
    /// </summary>
    public class Metrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of active users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeUsers")]
        public virtual System.Collections.Generic.IList<MetricsValue> ActiveUsers { get; set; }

        /// <summary>Number of failed executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedExecutions")]
        public virtual System.Collections.Generic.IList<MetricsValue> FailedExecutions { get; set; }

        /// <summary>Number of total executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalExecutions")]
        public virtual System.Collections.Generic.IList<MetricsValue> TotalExecutions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics value that holds number of executions counted.</summary>
    public class MetricsValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required field indicating the end time of the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Required field indicating the start time of the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Indicates the number of executions counted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<ulong> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A representation of an execution of an Apps Script function started with run. The execution response does not
    /// arrive until the function finishes executing. The maximum execution runtime is listed in the [Apps Script quotas
    /// guide](/apps-script/guides/services/quotas#current_limitations). After execution has started, it can have one of
    /// four outcomes: - If the script function returns successfully, the response field contains an ExecutionResponse
    /// object with the function's return value in the object's `result` field. - If the script function (or Apps Script
    /// itself) throws an exception, the error field contains a Status object. The `Status` object's `details` field
    /// contains an array with a single ExecutionError object that provides information about the nature of the error. -
    /// If the execution has not yet completed, the done field is `false` and the neither the `response` nor `error`
    /// fields are present. - If the `run` call itself fails (for example, because of a malformed request or an
    /// authorization error), the method returns an HTTP response code in the 4XX range with a different format for the
    /// response body. Client libraries automatically convert a 4XX response into an exception class.
    /// </summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field indicates whether the script execution has completed. A completed execution has a populated
        /// `response` field containing the ExecutionResponse from function that was executed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>
        /// If a `run` call succeeds but the script function (or Apps Script itself) throws an exception, this field
        /// contains a Status object. The `Status` object's `details` field contains an array with a single
        /// ExecutionError object that provides information about the nature of the error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// If the script function returns successfully, this field contains an ExecutionResponse object with the
        /// function's return value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The script project resource.</summary>
    public class Project : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>When the script was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>User who originally created the script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual GoogleAppsScriptTypeUser Creator { get; set; }

        /// <summary>User who last modified the script.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModifyUser")]
        public virtual GoogleAppsScriptTypeUser LastModifyUser { get; set; }

        /// <summary>
        /// The parent's Drive ID that the script will be attached to. This is usually the ID of a Google Document or
        /// Google Sheet. This filed is optional, and if not set, a stand-alone script will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentId")]
        public virtual string ParentId { get; set; }

        /// <summary>The script project's Drive ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptId")]
        public virtual string ScriptId { get; set; }

        /// <summary>The title for the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>When the script was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of an execution.</summary>
    public class ScriptExecutionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned value of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnValue")]
        public virtual Value ReturnValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A stack trace through the script that shows where the execution failed.</summary>
    public class ScriptStackTraceElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the function that failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>The line number where the script failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual System.Nullable<int> LineNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If a `run` call succeeds but the script function (or Apps Script itself) throws an exception, the response
    /// body's error field contains this `Status` object.
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The status code. For this API, this value either: - 10, indicating a `SCRIPT_TIMEOUT` error, - 3, indicating
        /// an `INVALID_ARGUMENT` error, or - 1, indicating a `CANCELLED` execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// An array that contains a single ExecutionError object that provides information about the nature of the
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which is in English. Any user-facing error message is localized and sent
        /// in the details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `Struct` represents a structured data value, consisting of fields which map to dynamically typed values.
    /// </summary>
    public class Struct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unordered map of dynamically typed values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, Value> Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request with deployment information to update an existing deployment.</summary>
    public class UpdateDeploymentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deployment configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentConfig")]
        public virtual DeploymentConfig DeploymentConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`Value` represents a dynamically typed value which is the outcome of an executed script.</summary>
    public class Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Represents raw byte values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesValue")]
        public virtual string BytesValue { get; set; }

        /// <summary>Represents a date in ms since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateValue")]
        public virtual System.Nullable<long> DateValue { get; set; }

        /// <summary>Represents a repeated `Value`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listValue")]
        public virtual ListValue ListValue { get; set; }

        /// <summary>Represents a null value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullValue")]
        public virtual string NullValue { get; set; }

        /// <summary>Represents a double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberValue")]
        public virtual System.Nullable<double> NumberValue { get; set; }

        /// <summary>Represents a structured proto value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoValue")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoValue { get; set; }

        /// <summary>Represents a string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>Represents a structured value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structValue")]
        public virtual Struct StructValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource representing a script project version. A version is a "snapshot" of a script project and is similar
    /// to a read-only branched release. When creating deployments, the version to use must be specified.
    /// </summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>When the version was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The description for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The script project's Drive ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptId")]
        public virtual string ScriptId { get; set; }

        /// <summary>
        /// The incremental ID that is created by Apps Script when a version is created. This is system assigned number
        /// and is immutable once created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionNumber")]
        public virtual System.Nullable<int> VersionNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
