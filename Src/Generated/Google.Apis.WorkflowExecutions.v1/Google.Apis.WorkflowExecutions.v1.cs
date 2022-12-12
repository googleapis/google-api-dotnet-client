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

namespace Google.Apis.WorkflowExecutions.v1
{
    /// <summary>The WorkflowExecutions Service.</summary>
    public class WorkflowExecutionsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WorkflowExecutionsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WorkflowExecutionsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "workflowexecutions";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://workflowexecutions.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://workflowexecutions.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Workflow Executions API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Workflow Executions API.</summary>
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

    /// <summary>A base abstract class for WorkflowExecutions requests.</summary>
    public abstract class WorkflowExecutionsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new WorkflowExecutionsBaseServiceRequest instance.</summary>
        protected WorkflowExecutionsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes WorkflowExecutions parameter list.</summary>
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
                Workflows = new WorkflowsResource(service);
            }

            /// <summary>Gets the Workflows resource.</summary>
            public virtual WorkflowsResource Workflows { get; }

            /// <summary>The "workflows" collection of methods.</summary>
            public class WorkflowsResource
            {
                private const string Resource = "workflows";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkflowsResource(Google.Apis.Services.IClientService service)
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
                    }

                    /// <summary>Cancels an execution of the given name.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Name of the execution to be cancelled. Format:
                    /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
                    /// </param>
                    public virtual CancelRequest Cancel(Google.Apis.WorkflowExecutions.v1.Data.CancelExecutionRequest body, string name)
                    {
                        return new CancelRequest(service, body, name);
                    }

                    /// <summary>Cancels an execution of the given name.</summary>
                    public class CancelRequest : WorkflowExecutionsBaseServiceRequest<Google.Apis.WorkflowExecutions.v1.Data.Execution>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkflowExecutions.v1.Data.CancelExecutionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the execution to be cancelled. Format:
                        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.WorkflowExecutions.v1.Data.CancelExecutionRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workflows/[^/]+/executions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Creates a new execution using the latest revision of the given workflow.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Name of the workflow for which an execution should be created. Format:
                    /// projects/{project}/locations/{location}/workflows/{workflow} The latest revision of the workflow
                    /// will be used.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.WorkflowExecutions.v1.Data.Execution body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new execution using the latest revision of the given workflow.</summary>
                    public class CreateRequest : WorkflowExecutionsBaseServiceRequest<Google.Apis.WorkflowExecutions.v1.Data.Execution>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkflowExecutions.v1.Data.Execution body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the workflow for which an execution should be created. Format:
                        /// projects/{project}/locations/{location}/workflows/{workflow} The latest revision of the
                        /// workflow will be used.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.WorkflowExecutions.v1.Data.Execution Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/executions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workflows/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns an execution of the given name.</summary>
                    /// <param name="name">
                    /// Required. Name of the execution to be retrieved. Format:
                    /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns an execution of the given name.</summary>
                    public class GetRequest : WorkflowExecutionsBaseServiceRequest<Google.Apis.WorkflowExecutions.v1.Data.Execution>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the execution to be retrieved. Format:
                        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. A view defining which fields should be filled in the returned execution. The API
                        /// will default to the FULL view.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. A view defining which fields should be filled in the returned execution. The API
                        /// will default to the FULL view.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>The default / unset value.</summary>
                            [Google.Apis.Util.StringValueAttribute("EXECUTION_VIEW_UNSPECIFIED")]
                            EXECUTIONVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Includes only basic metadata about the execution. Following fields are returned: name,
                            /// start_time, end_time, duration, state and workflow_revision_id.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Includes all data.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workflows/[^/]+/executions/[^/]+$",
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
                    /// Returns a list of executions which belong to the workflow with the given name. The method
                    /// returns executions of all workflow revisions. Returned executions are ordered by their start
                    /// time (newest first).
                    /// </summary>
                    /// <param name="parent">
                    /// Required. Name of the workflow for which the executions should be listed. Format:
                    /// projects/{project}/locations/{location}/workflows/{workflow}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Returns a list of executions which belong to the workflow with the given name. The method
                    /// returns executions of all workflow revisions. Returned executions are ordered by their start
                    /// time (newest first).
                    /// </summary>
                    public class ListRequest : WorkflowExecutionsBaseServiceRequest<Google.Apis.WorkflowExecutions.v1.Data.ListExecutionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the workflow for which the executions should be listed. Format:
                        /// projects/{project}/locations/{location}/workflows/{workflow}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Maximum number of executions to return per call. Max supported value depends on the selected
                        /// Execution view: it's 1000 for BASIC and 100 for FULL. The default value used if the field is
                        /// not specified is 100, regardless of the selected view. Values greater than the max value
                        /// will be coerced down to it.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListExecutions` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListExecutions` must
                        /// match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. A view defining which fields should be filled in the returned executions. The API
                        /// will default to the BASIC view.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. A view defining which fields should be filled in the returned executions. The API
                        /// will default to the BASIC view.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>The default / unset value.</summary>
                            [Google.Apis.Util.StringValueAttribute("EXECUTION_VIEW_UNSPECIFIED")]
                            EXECUTIONVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Includes only basic metadata about the execution. Following fields are returned: name,
                            /// start_time, end_time, duration, state and workflow_revision_id.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Includes all data.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/workflows/[^/]+$",
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

                /// <summary>
                /// Triggers a new execution using the latest revision of the given workflow by a Pub/Sub push
                /// notification.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="workflow">
                /// Required. Name of the workflow for which an execution should be created. Format:
                /// projects/{project}/locations/{location}/workflows/{workflow}
                /// </param>
                public virtual TriggerPubsubExecutionRequest TriggerPubsubExecution(Google.Apis.WorkflowExecutions.v1.Data.TriggerPubsubExecutionRequest body, string workflow)
                {
                    return new TriggerPubsubExecutionRequest(service, body, workflow);
                }

                /// <summary>
                /// Triggers a new execution using the latest revision of the given workflow by a Pub/Sub push
                /// notification.
                /// </summary>
                public class TriggerPubsubExecutionRequest : WorkflowExecutionsBaseServiceRequest<Google.Apis.WorkflowExecutions.v1.Data.Execution>
                {
                    /// <summary>Constructs a new TriggerPubsubExecution request.</summary>
                    public TriggerPubsubExecutionRequest(Google.Apis.Services.IClientService service, Google.Apis.WorkflowExecutions.v1.Data.TriggerPubsubExecutionRequest body, string workflow) : base(service)
                    {
                        Workflow = workflow;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the workflow for which an execution should be created. Format:
                    /// projects/{project}/locations/{location}/workflows/{workflow}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("workflow", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Workflow { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.WorkflowExecutions.v1.Data.TriggerPubsubExecutionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "triggerPubsubExecution";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+workflow}:triggerPubsubExecution";

                    /// <summary>Initializes TriggerPubsubExecution parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("workflow", new Google.Apis.Discovery.Parameter
                        {
                            Name = "workflow",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/workflows/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.WorkflowExecutions.v1.Data
{
    /// <summary>Request for the CancelExecution method.</summary>
    public class CancelExecutionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error describes why the execution was abnormally terminated.</summary>
    public class Error : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human-readable stack trace string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual string Context { get; set; }

        /// <summary>Error message and data returned represented as a JSON string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual string Payload { get; set; }

        /// <summary>Stack trace with detailed information of where error was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A running instance of a [Workflow](/workflows/docs/reference/rest/v1/projects.locations.workflows).
    /// </summary>
    public class Execution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input parameters of the execution represented as a JSON string. The size limit is 32KB. *Note*: If you are
        /// using the REST API directly to run your workflow, you must escape any JSON string value of `argument`.
        /// Example: `'{"argument":"{\"firstName\":\"FIRST\",\"lastName\":\"LAST\"}"}'`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argument")]
        public virtual string Argument { get; set; }

        /// <summary>The call logging level associated to this execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callLogLevel")]
        public virtual string CallLogLevel { get; set; }

        /// <summary>Output only. Measures the duration of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Output only. Marks the end of execution, successful or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. The error which caused the execution to finish prematurely. The value is only present if the
        /// execution's state is `FAILED` or `CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Error Error { get; set; }

        /// <summary>
        /// Output only. The resource name of the execution. Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Output of the execution represented as a JSON string. The value can only be present if the
        /// execution's state is `SUCCEEDED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual string Result { get; set; }

        /// <summary>Output only. Marks the beginning of execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Output only. Current state of the execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. Status tracks the current steps and progress data of this execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>Output only. Revision of the workflow this execution is using.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowRevisionId")]
        public virtual string WorkflowRevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListExecutions method.</summary>
    public class ListExecutionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The executions which match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executions")]
        public virtual System.Collections.Generic.IList<Execution> Executions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Position contains source position information about the stack trace element such as line number, column number
    /// and length of the code block in bytes.
    /// </summary>
    public class Position : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source code column position (of the line) the current instruction was generated from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual System.Nullable<long> Column { get; set; }

        /// <summary>The number of bytes of source code making up this stack trace element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary>The source code line number the current instruction was generated from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<long> Line { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message that is published by publishers and consumed by subscribers. The message must contain either a
    /// non-empty data field or at least one attribute. Note that client libraries represent this object differently
    /// depending on the language. See the corresponding [client library
    /// documentation](https://cloud.google.com/pubsub/docs/reference/libraries) for more information. See [quotas and
    /// limits] (https://cloud.google.com/pubsub/quotas) for more information about message limits.
    /// </summary>
    public class PubsubMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Attributes for this message. If this field is empty, the message must contain non-empty data. This can be
        /// used to filter messages on the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// The message data field. If this field is empty, the message must contain at least one attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// ID of this message, assigned by the server when the message is published. Guaranteed to be unique within the
        /// topic. This value may be read by a subscriber that receives a `PubsubMessage` via a `Pull` call or a push
        /// delivery. It must not be populated by the publisher in a `Publish` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageId { get; set; }

        /// <summary>
        /// If non-empty, identifies related messages for which publish order should be respected. If a `Subscription`
        /// has `enable_message_ordering` set to `true`, messages published with the same non-empty `ordering_key` value
        /// will be delivered to subscribers in the order in which they are received by the Pub/Sub system. All
        /// `PubsubMessage`s published in a given `PublishRequest` must specify the same `ordering_key` value. For more
        /// information, see [ordering messages](https://cloud.google.com/pubsub/docs/ordering).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderingKey")]
        public virtual string OrderingKey { get; set; }

        /// <summary>
        /// The time at which the message was published, populated by the server when it receives the `Publish` call. It
        /// must not be populated by the publisher in a `Publish` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual object PublishTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of stack elements (frames) where an error occurred.</summary>
    public class StackTrace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An array of stack elements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elements")]
        public virtual System.Collections.Generic.IList<StackTraceElement> Elements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single stack element (frame) where an error occurred.</summary>
    public class StackTraceElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source position information of the stack trace element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual Position Position { get; set; }

        /// <summary>The routine where the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routine")]
        public virtual string Routine { get; set; }

        /// <summary>The step the error occurred at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("step")]
        public virtual string Step { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the current status of this execution.</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of currently executing or last executed step names for the workflow execution currently running. If
        /// the workflow has succeeded or failed, this is the last attempted or executed step. Presently, if the current
        /// step is inside a subworkflow, the list only includes that step. In the future, the list will contain items
        /// for each step in the call stack, starting with the outermost step in the `main` subworkflow, and ending with
        /// the most deeply nested step.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSteps")]
        public virtual System.Collections.Generic.IList<Step> CurrentSteps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a step of the workflow this execution is running.</summary>
    public class Step : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of a routine within the workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routine")]
        public virtual string Routine { get; set; }

        /// <summary>Name of a step within the routine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("step")]
        public virtual string StepValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the TriggerPubsubExecution method.</summary>
    public class TriggerPubsubExecutionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. LINT: LEGACY_NAMES The query parameter value for __GCP_CloudEventsMode, set by the Eventarc
        /// service when configuring triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("GCPCloudEventsMode")]
        public virtual string GCPCloudEventsMode { get; set; }

        /// <summary>Required. The message of the Pub/Sub push notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual PubsubMessage Message { get; set; }

        /// <summary>
        /// Required. The subscription of the Pub/Sub push notification. Format: projects/{project}/subscriptions/{sub}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
