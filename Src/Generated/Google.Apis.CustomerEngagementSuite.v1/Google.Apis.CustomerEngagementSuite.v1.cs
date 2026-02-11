// Copyright 2026 Google LLC
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

namespace Google.Apis.CustomerEngagementSuite.v1
{
    /// <summary>The CustomerEngagementSuite Service.</summary>
    public class CustomerEngagementSuiteService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CustomerEngagementSuiteService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CustomerEngagementSuiteService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://ces.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://ces.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "ces";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>
        /// Available OAuth 2.0 scopes for use with the Gemini Enterprise for Customer Experience API.
        /// </summary>
        public class Scope
        {
            /// <summary>Create, update, delete, and manage your Next Gen Agents</summary>
            public static string Ces = "https://www.googleapis.com/auth/ces";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Gemini Enterprise for Customer Experience API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>Create, update, delete, and manage your Next Gen Agents</summary>
            public const string Ces = "https://www.googleapis.com/auth/ces";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CustomerEngagementSuite requests.</summary>
    public abstract class CustomerEngagementSuiteBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CustomerEngagementSuiteBaseServiceRequest instance.</summary>
        protected CustomerEngagementSuiteBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CustomerEngagementSuite parameter list.</summary>
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
                Apps = new AppsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Apps resource.</summary>
            public virtual AppsResource Apps { get; }

            /// <summary>The "apps" collection of methods.</summary>
            public class AppsResource
            {
                private const string Resource = "apps";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AppsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Agents = new AgentsResource(service);
                    Changelogs = new ChangelogsResource(service);
                    Conversations = new ConversationsResource(service);
                    Deployments = new DeploymentsResource(service);
                    Examples = new ExamplesResource(service);
                    Guardrails = new GuardrailsResource(service);
                    Sessions = new SessionsResource(service);
                    Tools = new ToolsResource(service);
                    Toolsets = new ToolsetsResource(service);
                    Versions = new VersionsResource(service);
                }

                /// <summary>Gets the Agents resource.</summary>
                public virtual AgentsResource Agents { get; }

                /// <summary>The "agents" collection of methods.</summary>
                public class AgentsResource
                {
                    private const string Resource = "agents";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AgentsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new agent in the given app.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The resource name of the app to create an agent in.</param>
                    public virtual CreateRequest Create(Google.Apis.CustomerEngagementSuite.v1.Data.Agent body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new agent in the given app.</summary>
                    public class CreateRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Agent>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Agent body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to create an agent in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the agent, which will become the final component of the agent's
                        /// resource name. If not provided, a unique ID will be automatically assigned for the agent.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("agentId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string AgentId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Agent Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/agents";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                            });
                            RequestParameters.Add("agentId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "agentId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified agent.</summary>
                    /// <param name="name">Required. The resource name of the agent to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified agent.</summary>
                    public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the agent to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the agent. If an etag is not provided, the deletion will
                        /// overwrite any concurrent changes. If an etag is provided and does not match the current etag
                        /// of the agent, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. Indicates whether to forcefully delete the agent, even if it is still referenced
                        /// by other app/agents/examples. * If `force = false`, the deletion fails if other
                        /// agents/examples reference it. * If `force = true`, delete the agent and remove it from all
                        /// referencing apps/agents/examples.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/agents/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of the specified agent.</summary>
                    /// <param name="name">Required. The resource name of the agent to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified agent.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Agent>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the agent to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/agents/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists agents in the given app.</summary>
                    /// <param name="parent">Required. The resource name of the app to list agents from.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists agents in the given app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListAgentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to list agents from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter to be applied when listing the agents. See https://google.aip.dev/160 for
                        /// more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                        /// https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list AgentService.ListAgents
                        /// call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/agents";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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

                    /// <summary>Updates the specified agent.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The unique identifier of the agent. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CustomerEngagementSuite.v1.Data.Agent body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the specified agent.</summary>
                    public class PatchRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Agent>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Agent body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The unique identifier of the agent. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask is used to control which fields get updated. If the mask is not
                        /// present, all fields will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Agent Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/agents/[^/]+$",
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

                /// <summary>Gets the Changelogs resource.</summary>
                public virtual ChangelogsResource Changelogs { get; }

                /// <summary>The "changelogs" collection of methods.</summary>
                public class ChangelogsResource
                {
                    private const string Resource = "changelogs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ChangelogsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Gets the specified changelog.</summary>
                    /// <param name="name">Required. The resource name of the changelog to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the specified changelog.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Changelog>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the changelog to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/changelogs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the changelogs of the specified app.</summary>
                    /// <param name="parent">Required. The resource name of the app to list changelogs from.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the changelogs of the specified app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListChangelogsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to list changelogs from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter to be applied when listing the changelogs. See https://google.aip.dev/160
                        /// for more details. The filter string can be used to filter by `action`, `resource_type`,
                        /// `resource_name`, `author`, and `create_time`. The `:` comparator can be used for
                        /// case-insensitive partial matching on string fields, while `=` performs an exact
                        /// case-sensitive match. Examples: * `action:update` (case-insensitive partial match) *
                        /// `action="Create"` (case-sensitive exact match) * `resource_type:agent` *
                        /// `resource_name:my-agent` * `author:me@example.com` * `create_time &amp;gt;
                        /// "2025-01-01T00:00:00Z"` * `create_time &amp;lt;= "2025-01-01T00:00:00Z" AND
                        /// resource_type:tool`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                        /// https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list
                        /// AgentService.ListChangelogs call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/changelogs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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

                /// <summary>Gets the Conversations resource.</summary>
                public virtual ConversationsResource Conversations { get; }

                /// <summary>The "conversations" collection of methods.</summary>
                public class ConversationsResource
                {
                    private const string Resource = "conversations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConversationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Batch deletes the specified conversations.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The resource name of the app to delete conversations from. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}`
                    /// </param>
                    public virtual BatchDeleteRequest BatchDelete(Google.Apis.CustomerEngagementSuite.v1.Data.BatchDeleteConversationsRequest body, string parent)
                    {
                        return new BatchDeleteRequest(this.service, body, parent);
                    }

                    /// <summary>Batch deletes the specified conversations.</summary>
                    public class BatchDeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new BatchDelete request.</summary>
                        public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.BatchDeleteConversationsRequest body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the app to delete conversations from. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.BatchDeleteConversationsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchDelete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/conversations:batchDelete";

                        /// <summary>Initializes BatchDelete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes the specified conversation.</summary>
                    /// <param name="name">Required. The resource name of the conversation to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified conversation.</summary>
                    public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the conversation to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Indicate the source of the conversation. If not set, Source.Live will be applied
                        /// by default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<SourceEnum> Source { get; set; }

                        /// <summary>
                        /// Optional. Indicate the source of the conversation. If not set, Source.Live will be applied
                        /// by default.
                        /// </summary>
                        public enum SourceEnum
                        {
                            /// <summary>Unspecified source.</summary>
                            [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                            SOURCEUNSPECIFIED = 0,

                            /// <summary>The conversation is from the live end user.</summary>
                            [Google.Apis.Util.StringValueAttribute("LIVE")]
                            LIVE = 1,

                            /// <summary>The conversation is from the simulator.</summary>
                            [Google.Apis.Util.StringValueAttribute("SIMULATOR")]
                            SIMULATOR = 2,

                            /// <summary>The conversation is from the evaluation.</summary>
                            [Google.Apis.Util.StringValueAttribute("EVAL")]
                            EVAL = 3,
                        }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/conversations/[^/]+$",
                            });
                            RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                            {
                                Name = "source",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of the specified conversation.</summary>
                    /// <param name="name">Required. The resource name of the conversation to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified conversation.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Conversation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the conversation to retrieve.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Indicate the source of the conversation. If not set, all source will be searched.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<SourceEnum> Source { get; set; }

                        /// <summary>
                        /// Optional. Indicate the source of the conversation. If not set, all source will be searched.
                        /// </summary>
                        public enum SourceEnum
                        {
                            /// <summary>Unspecified source.</summary>
                            [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                            SOURCEUNSPECIFIED = 0,

                            /// <summary>The conversation is from the live end user.</summary>
                            [Google.Apis.Util.StringValueAttribute("LIVE")]
                            LIVE = 1,

                            /// <summary>The conversation is from the simulator.</summary>
                            [Google.Apis.Util.StringValueAttribute("SIMULATOR")]
                            SIMULATOR = 2,

                            /// <summary>The conversation is from the evaluation.</summary>
                            [Google.Apis.Util.StringValueAttribute("EVAL")]
                            EVAL = 3,
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/conversations/[^/]+$",
                            });
                            RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                            {
                                Name = "source",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists conversations in the given app.</summary>
                    /// <param name="parent">Required. The resource name of the app to list conversations from.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists conversations in the given app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListConversationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to list conversations from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter to be applied when listing the conversations. See
                        /// https://google.aip.dev/160 for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list
                        /// AgentService.ListConversations call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. Indicate the source of the conversation. If not set, Source.Live will be applied
                        /// by default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<SourceEnum> Source { get; set; }

                        /// <summary>
                        /// Optional. Indicate the source of the conversation. If not set, Source.Live will be applied
                        /// by default.
                        /// </summary>
                        public enum SourceEnum
                        {
                            /// <summary>Unspecified source.</summary>
                            [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                            SOURCEUNSPECIFIED = 0,

                            /// <summary>The conversation is from the live end user.</summary>
                            [Google.Apis.Util.StringValueAttribute("LIVE")]
                            LIVE = 1,

                            /// <summary>The conversation is from the simulator.</summary>
                            [Google.Apis.Util.StringValueAttribute("SIMULATOR")]
                            SIMULATOR = 2,

                            /// <summary>The conversation is from the evaluation.</summary>
                            [Google.Apis.Util.StringValueAttribute("EVAL")]
                            EVAL = 3,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/conversations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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
                            RequestParameters.Add("source", new Google.Apis.Discovery.Parameter
                            {
                                Name = "source",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
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

                    /// <summary>Creates a new deployment in the given app.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent app. Format: `projects/{project}/locations/{location}/apps/{app}`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CustomerEngagementSuite.v1.Data.Deployment body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new deployment in the given app.</summary>
                    public class CreateRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Deployment>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Deployment body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent app. Format: `projects/{project}/locations/{location}/apps/{app}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the deployment, which will become the final component of the
                        /// deployment's resource name. If not provided, a unique ID will be automatically assigned for
                        /// the deployment.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("deploymentId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DeploymentId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Deployment Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/deployments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                            });
                            RequestParameters.Add("deploymentId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "deploymentId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified deployment.</summary>
                    /// <param name="name">
                    /// Required. The name of the deployment to delete. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified deployment.</summary>
                    public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the deployment to delete. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The etag of the deployment. If an etag is provided and does not match the current
                        /// etag of the deployment, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/deployments/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of the specified deployment.</summary>
                    /// <param name="name">
                    /// Required. The name of the deployment. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified deployment.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Deployment>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the deployment. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/deployments/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists deployments in the given app.</summary>
                    /// <param name="parent">
                    /// Required. The parent app. Format: `projects/{project}/locations/{location}/apps/{app}`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists deployments in the given app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListDeploymentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent app. Format: `projects/{project}/locations/{location}/apps/{app}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                        /// https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of deployments to return. The service may return fewer than
                        /// this value. If unspecified, at most 50 deployments will be returned. The maximum value is
                        /// 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A page token, received from a previous `ListDeployments` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListDeployments` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/deployments";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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

                    /// <summary>Updates the specified deployment.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The resource name of the deployment. Format:
                    /// projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CustomerEngagementSuite.v1.Data.Deployment body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the specified deployment.</summary>
                    public class PatchRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Deployment>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Deployment body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The resource name of the deployment. Format:
                        /// projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. The list of fields to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Deployment Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/deployments/[^/]+$",
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

                /// <summary>Gets the Examples resource.</summary>
                public virtual ExamplesResource Examples { get; }

                /// <summary>The "examples" collection of methods.</summary>
                public class ExamplesResource
                {
                    private const string Resource = "examples";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExamplesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new example in the given app.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The resource name of the app to create an example in.</param>
                    public virtual CreateRequest Create(Google.Apis.CustomerEngagementSuite.v1.Data.Example body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new example in the given app.</summary>
                    public class CreateRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Example>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Example body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to create an example in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the example, which will become the final component of the
                        /// example's resource name. If not provided, a unique ID will be automatically assigned for the
                        /// example.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("exampleId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ExampleId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Example Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/examples";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                            });
                            RequestParameters.Add("exampleId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "exampleId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified example.</summary>
                    /// <param name="name">Required. The resource name of the example to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified example.</summary>
                    public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the example to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the example. If an etag is not provided, the deletion will
                        /// overwrite any concurrent changes. If an etag is provided and does not match the current etag
                        /// of the example, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/examples/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of the specified example.</summary>
                    /// <param name="name">Required. The resource name of the example to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified example.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Example>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the example to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/examples/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists examples in the given app.</summary>
                    /// <param name="parent">Required. The resource name of the app to list examples from.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists examples in the given app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListExamplesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to list examples from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter to be applied when listing the examples. See https://google.aip.dev/160 for
                        /// more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                        /// https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list AgentService.ListExamples
                        /// call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/examples";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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

                    /// <summary>Updates the specified example.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The unique identifier of the example. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}/examples/{example}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CustomerEngagementSuite.v1.Data.Example body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the specified example.</summary>
                    public class PatchRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Example>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Example body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The unique identifier of the example. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}/examples/{example}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask is used to control which fields get updated. If the mask is not
                        /// present, all fields will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Example Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/examples/[^/]+$",
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

                /// <summary>Gets the Guardrails resource.</summary>
                public virtual GuardrailsResource Guardrails { get; }

                /// <summary>The "guardrails" collection of methods.</summary>
                public class GuardrailsResource
                {
                    private const string Resource = "guardrails";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public GuardrailsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new guardrail in the given app.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The resource name of the app to create a guardrail in.</param>
                    public virtual CreateRequest Create(Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new guardrail in the given app.</summary>
                    public class CreateRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to create a guardrail in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the guardrail, which will become the final component of the
                        /// guardrail's resource name. If not provided, a unique ID will be automatically assigned for
                        /// the guardrail.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("guardrailId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string GuardrailId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/guardrails";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                            });
                            RequestParameters.Add("guardrailId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "guardrailId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified guardrail.</summary>
                    /// <param name="name">Required. The resource name of the guardrail to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified guardrail.</summary>
                    public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the guardrail to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the guardrail. If an etag is not provided, the deletion will
                        /// overwrite any concurrent changes. If an etag is provided and does not match the current etag
                        /// of the guardrail, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. Indicates whether to forcefully delete the guardrail, even if it is still
                        /// referenced by app/agents. * If `force = false`, the deletion fails if any apps/agents still
                        /// reference the guardrail. * If `force = true`, all existing references from apps/agents will
                        /// be removed and the guardrail will be deleted.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/guardrails/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of the specified guardrail.</summary>
                    /// <param name="name">Required. The resource name of the guardrail to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified guardrail.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the guardrail to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/guardrails/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists guardrails in the given app.</summary>
                    /// <param name="parent">Required. The resource name of the app to list guardrails from.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists guardrails in the given app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListGuardrailsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to list guardrails from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter to be applied when listing the guardrails. See https://google.aip.dev/160
                        /// for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                        /// https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list
                        /// AgentService.ListGuardrails call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/guardrails";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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

                    /// <summary>Updates the specified guardrail.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The unique identifier of the guardrail. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the specified guardrail.</summary>
                    public class PatchRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The unique identifier of the guardrail. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask is used to control which fields get updated. If the mask is not
                        /// present, all fields will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Guardrail Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/guardrails/[^/]+$",
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

                /// <summary>Gets the Sessions resource.</summary>
                public virtual SessionsResource Sessions { get; }

                /// <summary>The "sessions" collection of methods.</summary>
                public class SessionsResource
                {
                    private const string Resource = "sessions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SessionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Generates a session scoped token for chat widget to authenticate with Session APIs.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The session name to generate the chat token for. Format:
                    /// projects/{project}/locations/{location}/apps/{app}/sessions/{session}
                    /// </param>
                    public virtual GenerateChatTokenRequest GenerateChatToken(Google.Apis.CustomerEngagementSuite.v1.Data.GenerateChatTokenRequest body, string name)
                    {
                        return new GenerateChatTokenRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Generates a session scoped token for chat widget to authenticate with Session APIs.
                    /// </summary>
                    public class GenerateChatTokenRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.GenerateChatTokenResponse>
                    {
                        /// <summary>Constructs a new GenerateChatToken request.</summary>
                        public GenerateChatTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.GenerateChatTokenRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The session name to generate the chat token for. Format:
                        /// projects/{project}/locations/{location}/apps/{app}/sessions/{session}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.GenerateChatTokenRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "generateChatToken";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:generateChatToken";

                        /// <summary>Initializes GenerateChatToken parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Initiates a single turn interaction with the CES agent within a session.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">
                    /// Required. The unique identifier of the session. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}/sessions/{session}`
                    /// </param>
                    public virtual RunSessionRequest RunSession(Google.Apis.CustomerEngagementSuite.v1.Data.RunSessionRequest body, string session)
                    {
                        return new RunSessionRequest(this.service, body, session);
                    }

                    /// <summary>Initiates a single turn interaction with the CES agent within a session.</summary>
                    public class RunSessionRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.RunSessionResponse>
                    {
                        /// <summary>Constructs a new RunSession request.</summary>
                        public RunSessionRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.RunSessionRequest body, string session) : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The unique identifier of the session. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}/sessions/{session}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.RunSessionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "runSession";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+session}:runSession";

                        /// <summary>Initializes RunSession parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("session", new Google.Apis.Discovery.Parameter
                            {
                                Name = "session",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/sessions/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Tools resource.</summary>
                public virtual ToolsResource Tools { get; }

                /// <summary>The "tools" collection of methods.</summary>
                public class ToolsResource
                {
                    private const string Resource = "tools";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ToolsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new tool in the given app.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The resource name of the app to create a tool in.</param>
                    public virtual CreateRequest Create(Google.Apis.CustomerEngagementSuite.v1.Data.Tool body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new tool in the given app.</summary>
                    public class CreateRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Tool>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Tool body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to create a tool in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the tool, which will become the final component of the tool's
                        /// resource name. If not provided, a unique ID will be automatically assigned for the tool.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("toolId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ToolId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Tool Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/tools";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                            });
                            RequestParameters.Add("toolId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "toolId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified tool.</summary>
                    /// <param name="name">Required. The resource name of the tool to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified tool.</summary>
                    public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the tool to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the tool. If an etag is not provided, the deletion will
                        /// overwrite any concurrent changes. If an etag is provided and does not match the current etag
                        /// of the tool, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. Indicates whether to forcefully delete the tool, even if it is still referenced by
                        /// agents/examples. * If `force = false`, the deletion will fail if any agents still reference
                        /// the tool. * If `force = true`, all existing references from agents will be removed and the
                        /// tool will be deleted.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/tools/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of the specified tool.</summary>
                    /// <param name="name">Required. The resource name of the tool to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified tool.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Tool>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the tool to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/tools/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists tools in the given app.</summary>
                    /// <param name="parent">Required. The resource name of the app to list tools from.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists tools in the given app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListToolsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to list tools from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter to be applied when listing the tools. Use "include_system_tools=true" to
                        /// include system tools in the response. See https://google.aip.dev/160 for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                        /// https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list AgentService.ListTools
                        /// call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/tools";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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

                    /// <summary>Updates the specified tool.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The unique identifier of the tool. Format: -
                    /// `projects/{project}/locations/{location}/apps/{app}/tools/{tool}` for ## standalone tools.
                    /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}/tools/{tool}` for tools
                    /// retrieved from a toolset. These tools are dynamic and output-only, they cannot be referenced
                    /// directly where a tool is expected.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CustomerEngagementSuite.v1.Data.Tool body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the specified tool.</summary>
                    public class PatchRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Tool>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Tool body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The unique identifier of the tool. Format: -
                        /// `projects/{project}/locations/{location}/apps/{app}/tools/{tool}` for ## standalone tools.
                        /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}/tools/{tool}` for
                        /// tools retrieved from a toolset. These tools are dynamic and output-only, they cannot be
                        /// referenced directly where a tool is expected.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask is used to control which fields get updated. If the mask is not
                        /// present, all fields will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Tool Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/tools/[^/]+$",
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

                /// <summary>Gets the Toolsets resource.</summary>
                public virtual ToolsetsResource Toolsets { get; }

                /// <summary>The "toolsets" collection of methods.</summary>
                public class ToolsetsResource
                {
                    private const string Resource = "toolsets";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ToolsetsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new toolset in the given app.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The resource name of the app to create a toolset in.</param>
                    public virtual CreateRequest Create(Google.Apis.CustomerEngagementSuite.v1.Data.Toolset body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new toolset in the given app.</summary>
                    public class CreateRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Toolset>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Toolset body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to create a toolset in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the toolset, which will become the final component of the
                        /// toolset's resource name. If not provided, a unique ID will be automatically assigned for the
                        /// toolset.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("toolsetId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ToolsetId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Toolset Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/toolsets";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                            });
                            RequestParameters.Add("toolsetId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "toolsetId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified toolset.</summary>
                    /// <param name="name">Required. The resource name of the toolset to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified toolset.</summary>
                    public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the toolset to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the toolset. If an etag is not provided, the deletion will
                        /// overwrite any concurrent changes. If an etag is provided and does not match the current etag
                        /// of the toolset, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. Indicates whether to forcefully delete the toolset, even if it is still referenced
                        /// by app/agents. * If `force = false`, the deletion fails if any agents still reference the
                        /// toolset. * If `force = true`, all existing references from agents will be removed and the
                        /// toolset will be deleted.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/toolsets/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                            {
                                Name = "force",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of the specified toolset.</summary>
                    /// <param name="name">Required. The resource name of the toolset to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified toolset.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Toolset>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the toolset to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/toolsets/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists toolsets in the given app.</summary>
                    /// <param name="parent">Required. The resource name of the app to list toolsets from.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists toolsets in the given app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListToolsetsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to list toolsets from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter to be applied when listing the toolsets. See https://google.aip.dev/160 for
                        /// more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                        /// https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list AgentService.ListToolsets
                        /// call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/toolsets";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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

                    /// <summary>Updates the specified toolset.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. The unique identifier of the toolset. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}`
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CustomerEngagementSuite.v1.Data.Toolset body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the specified toolset.</summary>
                    public class PatchRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Toolset>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.Toolset body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. The unique identifier of the toolset. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. Field mask is used to control which fields get updated. If the mask is not
                        /// present, all fields will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.Toolset Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/toolsets/[^/]+$",
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

                    /// <summary>Retrieve the list of tools included in the specified toolset.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="toolset">
                    /// Required. The name of the toolset to retrieve the tools for. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}`
                    /// </param>
                    public virtual RetrieveToolsRequest RetrieveTools(Google.Apis.CustomerEngagementSuite.v1.Data.RetrieveToolsRequest body, string toolset)
                    {
                        return new RetrieveToolsRequest(this.service, body, toolset);
                    }

                    /// <summary>Retrieve the list of tools included in the specified toolset.</summary>
                    public class RetrieveToolsRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.RetrieveToolsResponse>
                    {
                        /// <summary>Constructs a new RetrieveTools request.</summary>
                        public RetrieveToolsRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.RetrieveToolsRequest body, string toolset) : base(service)
                        {
                            Toolset = toolset;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the toolset to retrieve the tools for. Format:
                        /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("toolset", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Toolset { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.RetrieveToolsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "retrieveTools";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+toolset}:retrieveTools";

                        /// <summary>Initializes RetrieveTools parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("toolset", new Google.Apis.Discovery.Parameter
                            {
                                Name = "toolset",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/toolsets/[^/]+$",
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

                    /// <summary>Creates a new app version in the given app.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The resource name of the app to create an app version in.</param>
                    public virtual CreateRequest Create(Google.Apis.CustomerEngagementSuite.v1.Data.AppVersion body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new app version in the given app.</summary>
                    public class CreateRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.AppVersion>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.AppVersion body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to create an app version in.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The ID to use for the app version, which will become the final component of the
                        /// app version's resource name. If not provided, a unique ID will be automatically assigned for
                        /// the app version.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("appVersionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string AppVersionId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.AppVersion Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/versions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                            });
                            RequestParameters.Add("appVersionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "appVersionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified app version.</summary>
                    /// <param name="name">Required. The resource name of the app version to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes the specified app version.</summary>
                    public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app version to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. The current etag of the app version. If an etag is not provided, the deletion will
                        /// overwrite any concurrent changes. If an etag is provided and does not match the current etag
                        /// of the app version, deletion will be blocked and an ABORTED error will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/versions/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of the specified app version.</summary>
                    /// <param name="name">Required. The resource name of the app version to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of the specified app version.</summary>
                    public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.AppVersion>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app version to retrieve.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/versions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all app versions in the given app.</summary>
                    /// <param name="parent">Required. The resource name of the app to list app versions from.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all app versions in the given app.</summary>
                    public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListAppVersionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app to list app versions from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter to be applied when listing the app versions. See https://google.aip.dev/160
                        /// for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                        /// https://google.aip.dev/132#ordering for more details.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list
                        /// AgentService.ListAppVersions call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/versions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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

                    /// <summary>
                    /// Restores the specified app version. This will create a new app version from the current draft
                    /// app and overwrite the current draft with the specified app version.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The resource name of the app version to restore.</param>
                    public virtual RestoreRequest Restore(Google.Apis.CustomerEngagementSuite.v1.Data.RestoreAppVersionRequest body, string name)
                    {
                        return new RestoreRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Restores the specified app version. This will create a new app version from the current draft
                    /// app and overwrite the current draft with the specified app version.
                    /// </summary>
                    public class RestoreRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Restore request.</summary>
                        public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.RestoreAppVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the app version to restore.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CustomerEngagementSuite.v1.Data.RestoreAppVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "restore";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:restore";

                        /// <summary>Initializes Restore parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+/versions/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new app in the given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The resource name of the location to create an app in.</param>
                public virtual CreateRequest Create(Google.Apis.CustomerEngagementSuite.v1.Data.App body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new app in the given project and location.</summary>
                public class CreateRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.App body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the location to create an app in.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The ID to use for the app, which will become the final component of the app's resource
                    /// name. If not provided, a unique ID will be automatically assigned for the app.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AppId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CustomerEngagementSuite.v1.Data.App Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apps";

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
                        RequestParameters.Add("appId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the specified app.</summary>
                /// <param name="name">Required. The resource name of the app to delete.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes the specified app.</summary>
                public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the app to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The current etag of the app. If an etag is not provided, the deletion will overwrite
                    /// any concurrent changes. If an etag is provided and does not match the current etag of the app,
                    /// deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Executes the given tool with the given arguments.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the app which the tool/toolset belongs to. Format:
                /// `projects/{project}/locations/{location}/apps/{app}`
                /// </param>
                public virtual ExecuteToolRequest ExecuteTool(Google.Apis.CustomerEngagementSuite.v1.Data.ExecuteToolRequest body, string parent)
                {
                    return new ExecuteToolRequest(this.service, body, parent);
                }

                /// <summary>Executes the given tool with the given arguments.</summary>
                public class ExecuteToolRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ExecuteToolResponse>
                {
                    /// <summary>Constructs a new ExecuteTool request.</summary>
                    public ExecuteToolRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.ExecuteToolRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the app which the tool/toolset belongs to. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CustomerEngagementSuite.v1.Data.ExecuteToolRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "executeTool";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:executeTool";

                    /// <summary>Initializes ExecuteTool parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                        });
                    }
                }

                /// <summary>Exports the specified app.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The resource name of the app to export.</param>
                public virtual ExportAppRequest ExportApp(Google.Apis.CustomerEngagementSuite.v1.Data.ExportAppRequest body, string name)
                {
                    return new ExportAppRequest(this.service, body, name);
                }

                /// <summary>Exports the specified app.</summary>
                public class ExportAppRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ExportApp request.</summary>
                    public ExportAppRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.ExportAppRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the app to export.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CustomerEngagementSuite.v1.Data.ExportAppRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "exportApp";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:exportApp";

                    /// <summary>Initializes ExportApp parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of the specified app.</summary>
                /// <param name="name">Required. The resource name of the app to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of the specified app.</summary>
                public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.App>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the app to retrieve.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
                        });
                    }
                }

                /// <summary>Imports the specified app.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name with the location of the app to import.
                /// </param>
                public virtual ImportAppRequest ImportApp(Google.Apis.CustomerEngagementSuite.v1.Data.ImportAppRequest body, string parent)
                {
                    return new ImportAppRequest(this.service, body, parent);
                }

                /// <summary>Imports the specified app.</summary>
                public class ImportAppRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ImportApp request.</summary>
                    public ImportAppRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.ImportAppRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent resource name with the location of the app to import.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CustomerEngagementSuite.v1.Data.ImportAppRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "importApp";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apps:importApp";

                    /// <summary>Initializes ImportApp parameter list.</summary>
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

                /// <summary>Lists apps in the given project and location.</summary>
                /// <param name="parent">Required. The resource name of the location to list apps from.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists apps in the given project and location.</summary>
                public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListAppsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the location to list apps from.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Filter to be applied when listing the apps. See https://google.aip.dev/160 for more
                    /// details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Field to sort by. Only "name" and "create_time" is supported. See
                    /// https://google.aip.dev/132#ordering for more details.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The next_page_token value returned from a previous list AgentService.ListApps call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/apps";

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

                /// <summary>Updates the specified app.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The unique identifier of the app. Format:
                /// `projects/{project}/locations/{location}/apps/{app}`
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CustomerEngagementSuite.v1.Data.App body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the specified app.</summary>
                public class PatchRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.App>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.App body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The unique identifier of the app. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Field mask is used to control which fields get updated. If the mask is not present,
                    /// all fields will be updated.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CustomerEngagementSuite.v1.Data.App Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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
                /// Retrieve the schema of the given tool. The schema is computed on the fly for the given instance of
                /// the tool.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the app which the tool/toolset belongs to. Format:
                /// `projects/{project}/locations/{location}/apps/{app}`
                /// </param>
                public virtual RetrieveToolSchemaRequest RetrieveToolSchema(Google.Apis.CustomerEngagementSuite.v1.Data.RetrieveToolSchemaRequest body, string parent)
                {
                    return new RetrieveToolSchemaRequest(this.service, body, parent);
                }

                /// <summary>
                /// Retrieve the schema of the given tool. The schema is computed on the fly for the given instance of
                /// the tool.
                /// </summary>
                public class RetrieveToolSchemaRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.RetrieveToolSchemaResponse>
                {
                    /// <summary>Constructs a new RetrieveToolSchema request.</summary>
                    public RetrieveToolSchemaRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.RetrieveToolSchemaRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the app which the tool/toolset belongs to. Format:
                    /// `projects/{project}/locations/{location}/apps/{app}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CustomerEngagementSuite.v1.Data.RetrieveToolSchemaRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retrieveToolSchema";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:retrieveToolSchema";

                    /// <summary>Initializes RetrieveToolSchema parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/apps/[^/]+$",
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
                public virtual CancelRequest Cancel(Google.Apis.CustomerEngagementSuite.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CustomerEngagementSuite.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CustomerEngagementSuite.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Empty>
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
                public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Operation>
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
                public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListOperationsResponse>
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

                    /// <summary>
                    /// When set to `true`, operations that are reachable are returned as normal, and those that are
                    /// unreachable are returned in the ListOperationsResponse.unreachable field. This can only be
                    /// `true` when reading across collections. For example, when `parent` is set to
                    /// `"projects/example/locations/-"`. This field is not supported by default and will result in an
                    /// `UNIMPLEMENTED` error if set unless explicitly documented otherwise in service or product
                    /// specific documentation.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

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
                        RequestParameters.Add("returnPartialSuccess", new Google.Apis.Discovery.Parameter
                        {
                            Name = "returnPartialSuccess",
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
            public class GetRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.Location>
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

            /// <summary>
            /// Lists information about the supported locations for this service. This method can be called in two ways:
            /// * **List all public locations:** Use the path `GET /v1/locations`. * **List project-visible locations:**
            /// Use the path `GET /v1/projects/{project_id}/locations`. This may include public locations as well as
            /// private or other locations specifically visible to the project.
            /// </summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists information about the supported locations for this service. This method can be called in two ways:
            /// * **List all public locations:** Use the path `GET /v1/locations`. * **List project-visible locations:**
            /// Use the path `GET /v1/projects/{project_id}/locations`. This may include public locations as well as
            /// private or other locations specifically visible to the project.
            /// </summary>
            public class ListRequest : CustomerEngagementSuiteBaseServiceRequest<Google.Apis.CustomerEngagementSuite.v1.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field. It is unsupported and is ignored unless explicitly documented
                /// otherwise. This is primarily for internal usage.
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
namespace Google.Apis.CustomerEngagementSuite.v1.Data
{
    /// <summary>
    /// Configuration of an Action for the tool to use. Note: This can be either an Action or an Operation. See
    /// https://cloud.google.com/integration-connectors/docs/entities-operation-action for details.
    /// </summary>
    public class Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of a Connection action for the tool to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionActionId")]
        public virtual string ConnectionActionId { get; set; }

        /// <summary>Entity operation configuration for the tool to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityOperation")]
        public virtual ActionEntityOperation EntityOperation { get; set; }

        /// <summary>
        /// Optional. Entity fields to use as inputs for the operation. If no fields are specified, all fields of the
        /// Entity will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFields")]
        public virtual System.Collections.Generic.IList<string> InputFields { get; set; }

        /// <summary>
        /// Optional. Entity fields to return from the operation. If no fields are specified, all fields of the Entity
        /// will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFields")]
        public virtual System.Collections.Generic.IList<string> OutputFields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entity CRUD operation specification.</summary>
    public class ActionEntityOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. ID of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>Required. Operation to perform on the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An agent acts as the fundamental building block that provides instructions to the Large Language Model (LLM) for
    /// executing specific tasks.
    /// </summary>
    public class Agent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The callbacks to execute after the agent is called. The provided callbacks are executed
        /// sequentially in the exact order they are given in the list. If a callback returns an overridden response,
        /// execution stops and any remaining callbacks are skipped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("afterAgentCallbacks")]
        public virtual System.Collections.Generic.IList<Callback> AfterAgentCallbacks { get; set; }

        /// <summary>
        /// Optional. The callbacks to execute after the model is called. If there are multiple calls to the model, the
        /// callback will be executed multiple times. The provided callbacks are executed sequentially in the exact
        /// order they are given in the list. If a callback returns an overridden response, execution stops and any
        /// remaining callbacks are skipped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("afterModelCallbacks")]
        public virtual System.Collections.Generic.IList<Callback> AfterModelCallbacks { get; set; }

        /// <summary>
        /// Optional. The callbacks to execute after the tool is invoked. If there are multiple tool invocations, the
        /// callback will be executed multiple times. The provided callbacks are executed sequentially in the exact
        /// order they are given in the list. If a callback returns an overridden response, execution stops and any
        /// remaining callbacks are skipped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("afterToolCallbacks")]
        public virtual System.Collections.Generic.IList<Callback> AfterToolCallbacks { get; set; }

        /// <summary>
        /// Optional. The callbacks to execute before the agent is called. The provided callbacks are executed
        /// sequentially in the exact order they are given in the list. If a callback returns an overridden response,
        /// execution stops and any remaining callbacks are skipped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beforeAgentCallbacks")]
        public virtual System.Collections.Generic.IList<Callback> BeforeAgentCallbacks { get; set; }

        /// <summary>
        /// Optional. The callbacks to execute before the model is called. If there are multiple calls to the model, the
        /// callback will be executed multiple times. The provided callbacks are executed sequentially in the exact
        /// order they are given in the list. If a callback returns an overridden response, execution stops and any
        /// remaining callbacks are skipped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beforeModelCallbacks")]
        public virtual System.Collections.Generic.IList<Callback> BeforeModelCallbacks { get; set; }

        /// <summary>
        /// Optional. The callbacks to execute before the tool is invoked. If there are multiple tool invocations, the
        /// callback will be executed multiple times. The provided callbacks are executed sequentially in the exact
        /// order they are given in the list. If a callback returns an overridden response, execution stops and any
        /// remaining callbacks are skipped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beforeToolCallbacks")]
        public virtual System.Collections.Generic.IList<Callback> BeforeToolCallbacks { get; set; }

        /// <summary>
        /// Optional. List of child agents in the agent tree. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childAgents")]
        public virtual System.Collections.Generic.IList<string> ChildAgents { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the agent was created.</summary>
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

        /// <summary>Optional. Human-readable description of the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Etag used to ensure the object hasn't changed during a read-modify-write operation. If the etag is empty,
        /// the update will overwrite any concurrent changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. If the agent is generated by the LLM assistant, this field contains a descriptive summary of
        /// the generation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedSummary")]
        public virtual string GeneratedSummary { get; set; }

        /// <summary>
        /// Optional. List of guardrails for the agent. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardrails")]
        public virtual System.Collections.Generic.IList<string> Guardrails { get; set; }

        /// <summary>Optional. Instructions for the LLM model to guide the agent's behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instruction")]
        public virtual string Instruction { get; set; }

        /// <summary>Optional. The default agent type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("llmAgent")]
        public virtual AgentLlmAgent LlmAgent { get; set; }

        /// <summary>Optional. Configurations for the LLM model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelSettings")]
        public virtual ModelSettings ModelSettings { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the agent. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The remote
        /// [Dialogflow](https://cloud.google.com/dialogflow/cx/docs/concept/console-conversational-agents) agent to be
        /// used for the agent execution. If this field is set, all other agent level properties will be ignored. Note:
        /// If the Dialogflow agent is in a different project from the app, you should grant `roles/dialogflow.client`
        /// to the CES service agent `service-@gcp-sa-ces.iam.gserviceaccount.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteDialogflowAgent")]
        public virtual AgentRemoteDialogflowAgent RemoteDialogflowAgent { get; set; }

        /// <summary>
        /// Optional. List of available tools for the agent. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/tools/{tool}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tools")]
        public virtual System.Collections.Generic.IList<string> Tools { get; set; }

        /// <summary>Optional. List of toolsets for the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsets")]
        public virtual System.Collections.Generic.IList<AgentAgentToolset> Toolsets { get; set; }

        /// <summary>
        /// Optional. Agent transfer rules. If multiple rules match, the first one in the list will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferRules")]
        public virtual System.Collections.Generic.IList<TransferRule> TransferRules { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the agent was last updated.</summary>
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

    /// <summary>A toolset with a selection of its tools.</summary>
    public class AgentAgentToolset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The tools IDs to filter the toolset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolIds")]
        public virtual System.Collections.Generic.IList<string> ToolIds { get; set; }

        /// <summary>
        /// Required. The resource name of the toolset. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolset")]
        public virtual string Toolset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Default agent type. The agent uses instructions and callbacks specified in the agent to perform the task using a
    /// large language model.
    /// </summary>
    public class AgentLlmAgent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The agent which will transfer execution to a remote [Dialogflow
    /// CX](https://docs.cloud.google.com/dialogflow/cx/docs/concept/agent) agent. The Dialogflow agent will process
    /// subsequent user queries until the session ends or flow ends, and the control is transferred back to the parent
    /// CES agent.
    /// </summary>
    public class AgentRemoteDialogflowAgent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The [Dialogflow](https://docs.cloud.google.com/dialogflow/cx/docs/concept/agent) agent resource
        /// name. Format: `projects/{project}/locations/{location}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agent")]
        public virtual string Agent { get; set; }

        /// <summary>
        /// Optional. The environment ID of the Dialogflow agent to be used for the agent execution. If not specified,
        /// the draft environment will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentId")]
        public virtual string EnvironmentId { get; set; }

        /// <summary>Optional. The flow ID of the flow in the Dialogflow agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flowId")]
        public virtual string FlowId { get; set; }

        /// <summary>
        /// Optional. The mapping of the app variables names to the Dialogflow session parameters names to be sent to
        /// the Dialogflow agent as input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputVariableMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> InputVariableMapping { get; set; }

        /// <summary>
        /// Optional. The mapping of the Dialogflow session parameters names to the app variables names to be sent back
        /// to the CES agent after the Dialogflow agent execution ends.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputVariableMapping")]
        public virtual System.Collections.Generic.IDictionary<string, string> OutputVariableMapping { get; set; }

        /// <summary>
        /// Optional. Indicates whether to respect the message-level interruption settings configured in the Dialogflow
        /// agent. * If false: all response messages from the Dialogflow agent follow the app-level barge-in settings. *
        /// If true: only response messages with
        /// [`allow_playback_interruption`](https://docs.cloud.google.com/dialogflow/cx/docs/reference/rpc/google.cloud.dialogflow.cx.v3#text)
        /// set to true will be interruptable, all other messages follow the app-level barge-in settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("respectResponseInterruptionSettings")]
        public virtual System.Nullable<bool> RespectResponseInterruptionSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an event indicating the transfer of a conversation to a different agent.</summary>
    public class AgentTransfer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Display name of the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. The agent to which the conversation is being transferred. The agent will handle the conversation
        /// from this point forward. Format: `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetAgent")]
        public virtual string TargetAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for the ambient sound to be played with the synthesized agent response, to enhance the naturalness
    /// of the conversation.
    /// </summary>
    public class AmbientSoundConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Ambient noise as a mono-channel, 16kHz WAV file stored in [Cloud
        /// Storage](https://cloud.google.com/storage). Note: Please make sure the CES service agent
        /// `service-@gcp-sa-ces.iam.gserviceaccount.com` has `storage.objects.get` permission to the Cloud Storage
        /// object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>
        /// Optional. Deprecated: `prebuilt_ambient_noise` is deprecated in favor of `prebuilt_ambient_sound`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prebuiltAmbientNoise")]
        public virtual string PrebuiltAmbientNoise { get; set; }

        /// <summary>
        /// Optional. Name of the prebuilt ambient sound. Valid values are: - "coffee_shop" - "keyboard" - "keypad" -
        /// "hum" - "office_1" - "office_2" - "office_3" - "room_1" - "room_2" - "room_3" - "room_4" - "room_5" -
        /// "air_conditioner"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prebuiltAmbientSound")]
        public virtual string PrebuiltAmbientSound { get; set; }

        /// <summary>
        /// Optional. Volume gain (in dB) of the normal native volume supported by ambient noise, in the range [-96.0,
        /// 16.0]. If unset, or set to a value of 0.0 (dB), will play at normal native signal amplitude. A value of -6.0
        /// (dB) will play at approximately half the amplitude of the normal native signal amplitude. A value of +6.0
        /// (dB) will play at approximately twice the amplitude of the normal native signal amplitude. We strongly
        /// recommend not to exceed +10 (dB) as there's usually no effective increase in loudness for any value greater
        /// than that.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeGainDb")]
        public virtual System.Nullable<double> VolumeGainDb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Authentication information required for API calls.</summary>
    public class ApiAuthentication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Config for API key auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeyConfig")]
        public virtual ApiKeyConfig ApiKeyConfig { get; set; }

        /// <summary>Optional. Config for bearer token auth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bearerTokenConfig")]
        public virtual BearerTokenConfig BearerTokenConfig { get; set; }

        /// <summary>Optional. Config for OAuth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthConfig")]
        public virtual OAuthConfig OauthConfig { get; set; }

        /// <summary>Optional. Config for service account authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountAuthConfig")]
        public virtual ServiceAccountAuthConfig ServiceAccountAuthConfig { get; set; }

        /// <summary>Optional. Config for ID token auth generated from CES service agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAgentIdTokenAuthConfig")]
        public virtual ServiceAgentIdTokenAuthConfig ServiceAgentIdTokenAuthConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for authentication with API key.</summary>
    public class ApiKeyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the SecretManager secret version resource storing the API key. Format:
        /// `projects/{project}/secrets/{secret}/versions/{version}` Note: You should grant
        /// `roles/secretmanager.secretAccessor` role to the CES service agent
        /// `service-@gcp-sa-ces.iam.gserviceaccount.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiKeySecretVersion")]
        public virtual string ApiKeySecretVersion { get; set; }

        /// <summary>
        /// Required. The parameter name or the header name of the API key. E.g., If the API request is
        /// "https://example.com/act?X-Api-Key=", "X-Api-Key" would be the parameter name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyName")]
        public virtual string KeyName { get; set; }

        /// <summary>Required. Key location in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestLocation")]
        public virtual string RequestLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An app serves as a top-level container for a group of agents, including the root agent and its sub-agents, along
    /// with their associated configurations. These agents work together to achieve specific goals within the app's
    /// context.
    /// </summary>
    public class App : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Audio processing configuration of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioProcessingConfig")]
        public virtual AudioProcessingConfig AudioProcessingConfig { get; set; }

        /// <summary>Optional. The default client certificate settings for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificateSettings")]
        public virtual ClientCertificateSettings ClientCertificateSettings { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the app was created.</summary>
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

        /// <summary>Optional. The data store settings for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStoreSettings")]
        public virtual DataStoreSettings DataStoreSettings { get; set; }

        /// <summary>Optional. The default channel profile used by the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultChannelProfile")]
        public virtual ChannelProfile DefaultChannelProfile { get; set; }

        /// <summary>Output only. Number of deployments in the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentCount")]
        public virtual System.Nullable<int> DeploymentCount { get; set; }

        /// <summary>Optional. Human-readable description of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Etag used to ensure the object hasn't changed during a read-modify-write operation. If the etag
        /// is empty, the update will overwrite any concurrent changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. The evaluation thresholds for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMetricsThresholds")]
        public virtual EvaluationMetricsThresholds EvaluationMetricsThresholds { get; set; }

        /// <summary>
        /// Optional. Instructions for all the agents in the app. You can use this instruction to set up a stable
        /// identity or personality across all the agents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("globalInstruction")]
        public virtual string GlobalInstruction { get; set; }

        /// <summary>
        /// Optional. List of guardrails for the app. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardrails")]
        public virtual System.Collections.Generic.IList<string> Guardrails { get; set; }

        /// <summary>Optional. Language settings of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageSettings")]
        public virtual LanguageSettings LanguageSettings { get; set; }

        /// <summary>
        /// Optional. Indicates whether the app is locked for changes. If the app is locked, modifications to the app
        /// resources will be rejected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locked")]
        public virtual System.Nullable<bool> Locked { get; set; }

        /// <summary>Optional. Logging settings of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loggingSettings")]
        public virtual LoggingSettings LoggingSettings { get; set; }

        /// <summary>
        /// Optional. Metadata about the app. This field can be used to store additional information relevant to the
        /// app's details or intended usages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Optional. The default LLM model settings for the app. Individual resources (e.g. agents, guardrails) can
        /// override these configurations as needed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelSettings")]
        public virtual ModelSettings ModelSettings { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the app. Format: `projects/{project}/locations/{location}/apps/{app}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Whether the app is pinned in the app list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pinned")]
        public virtual System.Nullable<bool> Pinned { get; set; }

        /// <summary>Output only. The declarations of predefined variables for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedVariableDeclarations")]
        public virtual System.Collections.Generic.IList<AppVariableDeclaration> PredefinedVariableDeclarations { get; set; }

        /// <summary>
        /// Optional. The root agent is the entry point of the app. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootAgent")]
        public virtual string RootAgent { get; set; }

        /// <summary>Optional. TimeZone settings of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneSettings")]
        public virtual TimeZoneSettings TimeZoneSettings { get; set; }

        /// <summary>Optional. The tool execution mode for the app. If not provided, will default to PARALLEL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolExecutionMode")]
        public virtual string ToolExecutionMode { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the app was last updated.</summary>
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

        /// <summary>Optional. The declarations of the variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variableDeclarations")]
        public virtual System.Collections.Generic.IList<AppVariableDeclaration> VariableDeclarations { get; set; }
    }

    /// <summary>A snapshot of the app.</summary>
    public class AppSnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of agents in the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agents")]
        public virtual System.Collections.Generic.IList<Agent> Agents { get; set; }

        /// <summary>Optional. The basic settings for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("app")]
        public virtual App App { get; set; }

        /// <summary>Optional. List of examples in the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("examples")]
        public virtual System.Collections.Generic.IList<Example> Examples { get; set; }

        /// <summary>Optional. List of guardrails in the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardrails")]
        public virtual System.Collections.Generic.IList<Guardrail> Guardrails { get; set; }

        /// <summary>Optional. List of tools in the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tools")]
        public virtual System.Collections.Generic.IList<Tool> Tools { get; set; }

        /// <summary>Optional. List of toolsets in the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsets")]
        public virtual System.Collections.Generic.IList<Toolset> Toolsets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the structure and metadata for a variable.</summary>
    public class AppVariableDeclaration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The description of the variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The name of the variable. The name must start with a letter or underscore and contain only
        /// letters, numbers, or underscores.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The schema of the variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual Schema Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// In Customer Engagement Suite (CES), an app version is a snapshot of the app at a specific point in time. It is
    /// immutable and cannot be modified once created.
    /// </summary>
    public class AppVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the app version was created.</summary>
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

        /// <summary>Output only. Email of the user who created the app version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        /// <summary>Optional. The description of the app version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. The display name of the app version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Etag used to ensure the object hasn't changed during a read-modify-write operation. If the etag
        /// is empty, the update will overwrite any concurrent changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the app version. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/versions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The snapshot of the app when the version is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual AppSnapshot Snapshot { get; set; }
    }

    /// <summary>Configuration for how the input and output audio should be processed and delivered.</summary>
    public class AudioProcessingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Configuration for the ambient sound to be played with the synthesized agent response, to enhance
        /// the naturalness of the conversation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ambientSoundConfig")]
        public virtual AmbientSoundConfig AmbientSoundConfig { get; set; }

        /// <summary>Optional. Configures the agent behavior for the user barge-in activities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bargeInConfig")]
        public virtual BargeInConfig BargeInConfig { get; set; }

        /// <summary>
        /// Optional. The duration of user inactivity (no speech or interaction) before the agent prompts the user for
        /// reengagement. If not set, the agent will not prompt the user for reengagement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inactivityTimeout")]
        public virtual object InactivityTimeout { get; set; }

        /// <summary>
        /// Optional. Configuration of how the agent response should be synthesized, mapping from the language code to
        /// SynthesizeSpeechConfig. If the configuration for the specified language code is not found, the configuration
        /// for the root language code will be used. For example, if the map contains "en-us" and "en", and the
        /// specified language code is "en-gb", then "en" configuration will be used. Note: Language code is
        /// case-insensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synthesizeSpeechConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, SynthesizeSpeechConfig> SynthesizeSpeechConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for how the audio interactions should be recorded.</summary>
    public class AudioRecordingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The [Cloud Storage](https://cloud.google.com/storage) bucket to store the session audio
        /// recordings. The URI must start with "gs://". Please choose a bucket location that meets your data residency
        /// requirements. Note: If the Cloud Storage bucket is in a different project from the app, you should grant
        /// `storage.objects.create` permission to the CES service agent `service-@gcp-sa-ces.iam.gserviceaccount.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsBucket")]
        public virtual string GcsBucket { get; set; }

        /// <summary>
        /// Optional. The Cloud Storage path prefix for audio recordings. This prefix can include the following
        /// placeholders, which will be dynamically substituted at serving time: - $project: project ID - $location: app
        /// location - $app: app ID - $date: session date in YYYY-MM-DD format - $session: session ID If the path prefix
        /// is not specified, the default prefix `$project/$location/$app/$date/$session/` will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsPathPrefix")]
        public virtual string GcsPathPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for how the user barge-in activities should be handled.</summary>
    public class BargeInConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If enabled, the agent will adapt its next response based on the assumption that the user hasn't
        /// heard the full preceding agent message. This should not be used in scenarios where agent responses are
        /// displayed visually.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bargeInAwareness")]
        public virtual System.Nullable<bool> BargeInAwareness { get; set; }

        /// <summary>
        /// Optional. Disables user barge-in while the agent is speaking. If true, user input during agent response
        /// playback will be ignored. Deprecated: `disable_barge_in` is deprecated in favor of
        /// `disable_barge_in_control` in ChannelProfile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableBargeIn")]
        public virtual System.Nullable<bool> DisableBargeIn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AgentService.BatchDeleteConversations.</summary>
    public class BatchDeleteConversationsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource names of the conversations to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversations")]
        public virtual System.Collections.Generic.IList<string> Conversations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for authentication with a bearer token.</summary>
    public class BearerTokenConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The bearer token. Must be in the format `$context.variables.`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to describe the BigQuery export behaviors for the app.</summary>
    public class BigQueryExportSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The BigQuery dataset to export the data to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>Optional. Indicates whether the BigQuery export is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Optional. The project ID of the BigQuery dataset to export the data to. Note: If the BigQuery dataset is in
        /// a different project from the app, you should grant `roles/bigquery.admin` role to the CES service agent
        /// `service-@gcp-sa-ces.iam.gserviceaccount.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a blob input or output in the conversation.</summary>
    public class Blob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Raw bytes of the blob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Required. The IANA standard MIME type of the source data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A callback defines the custom logic to be executed at various stages of agent interaction.</summary>
    public class Callback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Human-readable description of the callback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Whether the callback is disabled. Disabled callbacks are ignored by the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Required. The python code to execute for the callback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonCode")]
        public virtual string PythonCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Changelogs represent a change made to the app or to an resource within the app.</summary>
    public class Changelog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The action that was performed on the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Output only. Email address of the change author.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual string Author { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the change was made.</summary>
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

        /// <summary>Output only. The dependent resources that were changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependentResources")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> DependentResources { get; set; }

        /// <summary>
        /// Output only. Description of the change. which typically captures the changed fields in the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. Display name of the change. It typically should be the display name of the resource that was
        /// changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the changelog. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/changelogs/{changelog}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The new resource after the change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newResource")]
        public virtual System.Collections.Generic.IDictionary<string, object> NewResource { get; set; }

        /// <summary>Output only. The original resource before the change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalResource")]
        public virtual System.Collections.Generic.IDictionary<string, object> OriginalResource { get; set; }

        /// <summary>Output only. The resource that was changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Output only. The type of the resource that was changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Output only. The monotonically increasing sequence number of the changelog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sequenceNumber")]
        public virtual System.Nullable<long> SequenceNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A ChannelProfile configures the agent's behavior for a specific communication channel, such as web UI or
    /// telephony.
    /// </summary>
    public class ChannelProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The type of the channel profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelType")]
        public virtual string ChannelType { get; set; }

        /// <summary>
        /// Optional. Whether to disable user barge-in control in the conversation. - **true**: User interruptions are
        /// disabled while the agent is speaking. - **false**: The agent retains automatic control over when the user
        /// can interrupt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableBargeInControl")]
        public virtual System.Nullable<bool> DisableBargeInControl { get; set; }

        /// <summary>Optional. Whether to disable DTMF (dual-tone multi-frequency).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableDtmf")]
        public virtual System.Nullable<bool> DisableDtmf { get; set; }

        /// <summary>
        /// Optional. The noise suppression level of the channel profile. Available values are "low", "moderate",
        /// "high", "very_high".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noiseSuppressionLevel")]
        public virtual string NoiseSuppressionLevel { get; set; }

        /// <summary>Optional. The persona property of the channel profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("personaProperty")]
        public virtual ChannelProfilePersonaProperty PersonaProperty { get; set; }

        /// <summary>Optional. The unique identifier of the channel profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
        public virtual string ProfileId { get; set; }

        /// <summary>Optional. The configuration for the web widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webWidgetConfig")]
        public virtual ChannelProfileWebWidgetConfig WebWidgetConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the persona property of a channel.</summary>
    public class ChannelProfilePersonaProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The persona of the channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persona")]
        public virtual string Persona { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for configuration for the web widget.</summary>
    public class ChannelProfileWebWidgetConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The modality of the web widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modality")]
        public virtual string Modality { get; set; }

        /// <summary>Optional. The security settings of the web widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securitySettings")]
        public virtual ChannelProfileWebWidgetConfigSecuritySettings SecuritySettings { get; set; }

        /// <summary>Optional. The theme of the web widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("theme")]
        public virtual string Theme { get; set; }

        /// <summary>Optional. The title of the web widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webWidgetTitle")]
        public virtual string WebWidgetTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Security settings for the web widget.</summary>
    public class ChannelProfileWebWidgetConfigSecuritySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The origins that are allowed to host the web widget. An origin is defined by RFC 6454. If empty,
        /// all origins are allowed. A maximum of 100 origins is allowed. Example: "https://example.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedOrigins")]
        public virtual System.Collections.Generic.IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Optional. Indicates whether origin check for the web widget is enabled. If `true`, the web widget will check
        /// the origin of the website that loads the web widget and only allow it to be loaded in the same origin or any
        /// of the allowed origins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableOriginCheck")]
        public virtual System.Nullable<bool> EnableOriginCheck { get; set; }

        /// <summary>
        /// Optional. Indicates whether public access to the web widget is enabled. If `true`, the web widget will be
        /// publicly accessible. If `false`, the web widget must be integrated with your own authentication and
        /// authorization system to return valid credentials for accessing the CES agent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePublicAccess")]
        public virtual System.Nullable<bool> EnablePublicAccess { get; set; }

        /// <summary>Optional. Indicates whether reCAPTCHA verification for the web widget is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRecaptcha")]
        public virtual System.Nullable<bool> EnableRecaptcha { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A chunk of content within a message.</summary>
    public class Chunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Agent transfer event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentTransfer")]
        public virtual AgentTransfer AgentTransfer { get; set; }

        /// <summary>
        /// A struct represents default variables at the start of the conversation, keyed by variable names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultVariables")]
        public virtual System.Collections.Generic.IDictionary<string, object> DefaultVariables { get; set; }

        /// <summary>Optional. Image data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>Optional. Custom payload data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string, object> Payload { get; set; }

        /// <summary>Optional. Text data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Optional. Tool execution request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolCall")]
        public virtual ToolCall ToolCall { get; set; }

        /// <summary>Optional. Tool execution response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolResponse")]
        public virtual ToolResponse ToolResponse { get; set; }

        /// <summary>Optional. Transcript associated with the audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; }

        /// <summary>
        /// A struct represents variables that were updated in the conversation, keyed by variable names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedVariables")]
        public virtual System.Collections.Generic.IDictionary<string, object> UpdatedVariables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Citations associated with the agent response.</summary>
    public class Citations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of cited pieces of information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citedChunks")]
        public virtual System.Collections.Generic.IList<CitationsCitedChunk> CitedChunks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Piece of cited information.</summary>
    public class CitationsCitedChunk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text used for citaiton.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Title of the cited document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>URI used for citation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for custom client certificates.</summary>
    public class ClientCertificateSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the SecretManager secret version resource storing the passphrase to decrypt the
        /// private key. Should be left unset if the private key is not encrypted. Format:
        /// `projects/{project}/secrets/{secret}/versions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passphrase")]
        public virtual string Passphrase { get; set; }

        /// <summary>
        /// Required. The name of the SecretManager secret version resource storing the private key encoded in PEM
        /// format. Format: `projects/{project}/secrets/{secret}/versions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKey")]
        public virtual string PrivateKey { get; set; }

        /// <summary>
        /// Required. The TLS certificate encoded in PEM format. This string must include the begin header and end
        /// footer lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsCertificate")]
        public virtual string TlsCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a client-side function that the agent can invoke. When the tool is chosen by the agent, control is
    /// handed off to the client. The client is responsible for executing the function and returning the result as a
    /// ToolResponse to continue the interaction with the agent.
    /// </summary>
    public class ClientFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The function description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The function name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The schema of the function parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual Schema Parameters { get; set; }

        /// <summary>Optional. The schema of the function response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual Schema Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to describe the Cloud Logging behaviors for the app.</summary>
    public class CloudLoggingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether to enable Cloud Logging for the sessions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableCloudLogging")]
        public virtual System.Nullable<bool> EnableCloudLogging { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A code block to be executed instead of a real tool call.</summary>
    public class CodeBlock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Python code which will be invoked in tool fake mode. Expected Python function signature - To catch
        /// all tool calls: def fake_tool_call(tool: Tool, input: dict[str, Any], callback_context: CallbackContext)
        /// -&amp;gt; Optional[dict[str, Any]]: To catch a specific tool call: def fake_{tool_id}(tool: Tool, input:
        /// dict[str, Any], callback_context: CallbackContext) -&amp;gt; Optional[dict[str, Any]]: If the function
        /// returns None, the real tool will be invoked instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonCode")]
        public virtual string PythonCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A ConnectorTool allows connections to different integrations. See:
    /// https://cloud.google.com/integration-connectors/docs/overview.
    /// </summary>
    public class ConnectorTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Action for the tool to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual Action Action { get; set; }

        /// <summary>
        /// Optional. Configures how authentication is handled in Integration Connectors. By default, an admin
        /// authentication is passed in the Integration Connectors API requests. You can override it with a different
        /// end-user authentication config. **Note**: The Connection must have authentication override enabled in order
        /// to specify an EUC configuration here - otherwise, the ConnectorTool creation will fail. See
        /// https://cloud.google.com/application-integration/docs/configure-connectors-task#configure-authentication-override
        /// for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual EndUserAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// Required. The full resource name of the referenced Integration Connectors Connection. Format:
        /// `projects/{project}/locations/{location}/connections/{connection}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connection")]
        public virtual string Connection { get; set; }

        /// <summary>
        /// Optional. The description of the tool that can be used by the Agent to decide whether to call this
        /// ConnectorTool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. The name of the tool that can be used by the Agent to decide whether to call this ConnectorTool.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A toolset that generates tools from an Integration Connectors Connection.</summary>
    public class ConnectorToolset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Configures how authentication is handled in Integration Connectors. By default, an admin
        /// authentication is passed in the Integration Connectors API requests. You can override it with a different
        /// end-user authentication config. **Note**: The Connection must have authentication override enabled in order
        /// to specify an EUC configuration here - otherwise, the Toolset creation will fail. See:
        /// https://cloud.google.com/application-integration/docs/configure-connectors-task#configure-authentication-override
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual EndUserAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// Required. The full resource name of the referenced Integration Connectors Connection. Format:
        /// `projects/{project}/locations/{location}/connections/{connection}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connection")]
        public virtual string Connection { get; set; }

        /// <summary>Required. The list of connector actions/entity operations to generate tools for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorActions")]
        public virtual System.Collections.Generic.IList<Action> ConnectorActions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A conversation represents an interaction between an end user and the CES app.</summary>
    public class Conversation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The version of the app used for processing the conversation. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/versions/{version}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersion")]
        public virtual string AppVersion { get; set; }

        /// <summary>DEPRECATED. Please use input_types instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelType")]
        public virtual string ChannelType { get; set; }

        /// <summary>
        /// Output only. The deployment of the app used for processing the conversation. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. Timestamp when the conversation was completed.</summary>
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
        /// Output only. The agent that initially handles the conversation. If not specified, the conversation is
        /// handled by the root agent. Format: `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryAgent")]
        public virtual string EntryAgent { get; set; }

        /// <summary>Output only. The input types of the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputTypes")]
        public virtual System.Collections.Generic.IList<string> InputTypes { get; set; }

        /// <summary>Output only. The language code of the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Deprecated. Use turns instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the conversation. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/conversations/{conversation}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Indicate the source of the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Timestamp when the conversation was created.</summary>
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

        /// <summary>Output only. The number of turns in the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turnCount")]
        public virtual System.Nullable<int> TurnCount { get; set; }

        /// <summary>Required. The turns in the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turns")]
        public virtual System.Collections.Generic.IList<ConversationTurn> Turns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to describe the conversation logging behaviors for the app.</summary>
    public class ConversationLoggingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether to disable conversation logging for the sessions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableConversationLogging")]
        public virtual System.Nullable<bool> DisableConversationLogging { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All information about a single turn in the conversation.</summary>
    public class ConversationTurn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. List of messages in the conversation turn, including user input, agent responses and intermediate
        /// events during the processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>Optional. The root span of the action processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootSpan")]
        public virtual Span RootSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A DataStore resource in Vertex AI Search.</summary>
    public class DataStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The connector config for the data store connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorConfig")]
        public virtual DataStoreConnectorConfig ConnectorConfig { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the data store was created.</summary>
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

        /// <summary>Output only. The display name of the data store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The document processing mode for the data store connection. Only set for PUBLIC_WEB and
        /// UNSTRUCTURED data stores.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentProcessingMode")]
        public virtual string DocumentProcessingMode { get; set; }

        /// <summary>
        /// Required. Full resource name of the DataStore. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The type of the data store. This field is readonly and populated by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The connector config for the data store connection.</summary>
    public class DataStoreConnectorConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name of the collection the data store belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collection")]
        public virtual string Collection { get; set; }

        /// <summary>Display name of the collection the data store belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionDisplayName")]
        public virtual string CollectionDisplayName { get; set; }

        /// <summary>The name of the data source. Example: `salesforce`, `jira`, `confluence`, `bigquery`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data store related settings for the app.</summary>
    public class DataStoreSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The engines for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engines")]
        public virtual System.Collections.Generic.IList<DataStoreSettingsEngine> Engines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An engine to which the data stores are connected. See Vertex AI Search:
    /// https://cloud.google.com/generative-ai-app-builder/docs/enterprise-search-introduction.
    /// </summary>
    public class DataStoreSettingsEngine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The resource name of the engine. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The type of the engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Tool to retrieve from Vertex AI Search datastore or engine for grounding. Accepts either a datastore or an
    /// engine, but not both. See Vertex AI Search:
    /// https://cloud.google.com/generative-ai-app-builder/docs/enterprise-search-introduction.
    /// </summary>
    public class DataStoreTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Boost specification to boost certain documents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostSpecs")]
        public virtual System.Collections.Generic.IList<DataStoreToolBoostSpecs> BoostSpecs { get; set; }

        /// <summary>Optional. Search within a single specific DataStore.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStoreSource")]
        public virtual DataStoreToolDataStoreSource DataStoreSource { get; set; }

        /// <summary>Optional. The tool description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Search within an Engine (potentially across multiple DataStores).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engineSource")]
        public virtual DataStoreToolEngineSource EngineSource { get; set; }

        /// <summary>Optional. The filter parameter behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterParameterBehavior")]
        public virtual string FilterParameterBehavior { get; set; }

        /// <summary>Optional. The modality configs for the data store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modalityConfigs")]
        public virtual System.Collections.Generic.IList<DataStoreToolModalityConfig> ModalityConfigs { get; set; }

        /// <summary>Required. The data store tool name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Boost specification to boost certain documents.</summary>
    public class DataStoreToolBoostSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of boosting specifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionBoostSpecs")]
        public virtual System.Collections.Generic.IList<DataStoreToolBoostSpecConditionBoostSpec> ConditionBoostSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Boost specification for a condition.</summary>
    public class DataStoreToolBoostSpecConditionBoostSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Strength of the boost, which should be in [-1, 1]. Negative boost means demotion. Default is 0.0.
        /// Setting to 1.0 gives the suggestions a big promotion. However, it does not necessarily mean that the top
        /// result will be a boosted suggestion. Setting to -1.0 gives the suggestions a big demotion. However, other
        /// suggestions that are relevant might still be shown. Setting to 0.0 means no boost applied. The boosting
        /// condition is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boost")]
        public virtual System.Nullable<float> Boost { get; set; }

        /// <summary>
        /// Optional. Complex specification for custom ranking based on customer defined attribute value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostControlSpec")]
        public virtual DataStoreToolBoostSpecConditionBoostSpecBoostControlSpec BoostControlSpec { get; set; }

        /// <summary>
        /// Required. An expression which specifies a boost condition. The syntax is the same as filter expression
        /// syntax. Currently, the only supported condition is a list of BCP-47 lang codes. Example: To boost
        /// suggestions in languages en or fr: (lang_code: ANY("en", "fr"))
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification for custom ranking based on customer specified attribute value. It provides more controls for
    /// customized ranking than the simple (condition, boost) combination above.
    /// </summary>
    public class DataStoreToolBoostSpecConditionBoostSpecBoostControlSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The attribute type to be used to determine the boost amount. The attribute value can be derived
        /// from the field value of the specified field_name. In the case of numerical it is straightforward i.e.
        /// attribute_value = numerical_field_value. In the case of freshness however, attribute_value = (time.now() -
        /// datetime_field_value).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeType")]
        public virtual string AttributeType { get; set; }

        /// <summary>
        /// Optional. The control points used to define the curve. The monotonic function (defined through the
        /// interpolation_type above) passes through the control points listed here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPoints")]
        public virtual System.Collections.Generic.IList<DataStoreToolBoostSpecConditionBoostSpecBoostControlSpecControlPoint> ControlPoints { get; set; }

        /// <summary>Optional. The name of the field whose value will be used to determine the boost amount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>
        /// Optional. The interpolation type to be applied to connect the control points listed below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpolationType")]
        public virtual string InterpolationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The control points used to define the curve. The curve defined through these control points can only be
    /// monotonically increasing or decreasing(constant values are acceptable).
    /// </summary>
    public class DataStoreToolBoostSpecConditionBoostSpecBoostControlSpecControlPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Can be one of: 1. The numerical field value. 2. The duration spec for freshness: The value must be
        /// formatted as an XSD `dayTimeDuration` value (a restricted subset of an ISO 8601 duration value). The pattern
        /// for this is: `nDnM]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeValue")]
        public virtual string AttributeValue { get; set; }

        /// <summary>
        /// Optional. The value between -1 to 1 by which to boost the score if the attribute_value evaluates to the
        /// value specified above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boostAmount")]
        public virtual System.Nullable<float> BoostAmount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Boost specifications to boost certain documents. For more information, please refer to
    /// https://cloud.google.com/generative-ai-app-builder/docs/boosting.
    /// </summary>
    public class DataStoreToolBoostSpecs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Data Store where the boosting configuration is applied. Full resource name of DataStore, such
        /// as projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStores")]
        public virtual System.Collections.Generic.IList<string> DataStores { get; set; }

        /// <summary>Required. A list of boosting specifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual System.Collections.Generic.IList<DataStoreToolBoostSpec> Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for searching within a specific DataStore.</summary>
    public class DataStoreToolDataStoreSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The data store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStore")]
        public virtual DataStore DataStore { get; set; }

        /// <summary>
        /// Optional. Filter specification for the DataStore. See:
        /// https://cloud.google.com/generative-ai-app-builder/docs/filter-search-metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for searching within an Engine, potentially targeting specific DataStores.</summary>
    public class DataStoreToolEngineSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Use to target specific DataStores within the Engine. If empty, the search applies to all
        /// DataStores associated with the Engine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStoreSources")]
        public virtual System.Collections.Generic.IList<DataStoreToolDataStoreSource> DataStoreSources { get; set; }

        /// <summary>
        /// Required. Full resource name of the Engine. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>
        /// Optional. A filter applied to the search across the Engine. Not relevant and not used if
        /// 'data_store_sources' is provided. See:
        /// https://cloud.google.com/generative-ai-app-builder/docs/filter-search-metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Grounding configuration.</summary>
    public class DataStoreToolGroundingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether grounding is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Optional. The groundedness threshold of the answer based on the retrieved sources. The value has a
        /// configurable range of [1, 5]. The level is used to threshold the groundedness of the answer, meaning that
        /// all responses with a groundedness score below the threshold will fall back to returning relevant snippets
        /// only. For example, a level of 3 means that the groundedness score must be 3 or higher for the response to be
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingLevel")]
        public virtual System.Nullable<float> GroundingLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>If specified, will apply the given configuration for the specified modality.</summary>
    public class DataStoreToolModalityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The grounding configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groundingConfig")]
        public virtual DataStoreToolGroundingConfig GroundingConfig { get; set; }

        /// <summary>Required. The modality type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modalityType")]
        public virtual string ModalityType { get; set; }

        /// <summary>Optional. The rewriter config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rewriterConfig")]
        public virtual DataStoreToolRewriterConfig RewriterConfig { get; set; }

        /// <summary>Optional. The summarization config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summarizationConfig")]
        public virtual DataStoreToolSummarizationConfig SummarizationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rewriter configuration.</summary>
    public class DataStoreToolRewriterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether the rewriter is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Required. Configurations for the LLM model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelSettings")]
        public virtual ModelSettings ModelSettings { get; set; }

        /// <summary>Optional. The prompt definition. If not set, default prompt will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prompt")]
        public virtual string Prompt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summarization configuration.</summary>
    public class DataStoreToolSummarizationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether summarization is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Optional. Configurations for the LLM model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelSettings")]
        public virtual ModelSettings ModelSettings { get; set; }

        /// <summary>Optional. The prompt definition. If not set, default prompt will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prompt")]
        public virtual string Prompt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A deployment represents an immutable, queryable version of the app. It is used to deploy an app version with a
    /// specific channel profile.
    /// </summary>
    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the app version to deploy. Format:
        /// projects/{project}/locations/{location}/apps/{app}/versions/{version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersion")]
        public virtual string AppVersion { get; set; }

        /// <summary>Required. The channel profile used in the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelProfile")]
        public virtual ChannelProfile ChannelProfile { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when this deployment was created.</summary>
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

        /// <summary>Required. Display name of the deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Etag used to ensure the object hasn't changed during a read-modify-write operation. If the etag
        /// is empty, the update will overwrite any concurrent changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. The resource name of the deployment. Format:
        /// projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when this deployment was last updated.</summary>
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
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Indicates the session has terminated, due to either successful completion (e.g. user says "Good bye!" ) or an
    /// agent escalation. The agent will not process any further inputs after session is terminated and the client
    /// should half-close and disconnect after receiving all remaining responses from the agent.
    /// </summary>
    public class EndSession : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Provides additional information about the end session signal, such as the reason for ending the
        /// session.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// End-user authentication configuration used for Connection calls. The field values must be the names of context
    /// variables in the format `$context.variables.`.
    /// </summary>
    public class EndUserAuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Oauth 2.0 Authorization Code authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2AuthCodeConfig")]
        public virtual EndUserAuthConfigOauth2AuthCodeConfig Oauth2AuthCodeConfig { get; set; }

        /// <summary>JWT Profile Oauth 2.0 Authorization Grant authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2JwtBearerConfig")]
        public virtual EndUserAuthConfigOauth2JwtBearerConfig Oauth2JwtBearerConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Oauth 2.0 Authorization Code authentication configuration.</summary>
    public class EndUserAuthConfigOauth2AuthCodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Oauth token parameter name to pass through. Must be in the format `$context.variables.`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthToken")]
        public virtual string OauthToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JWT Profile Oauth 2.0 Authorization Grant authentication configuration.</summary>
    public class EndUserAuthConfigOauth2JwtBearerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Client parameter name to pass through. Must be in the format `$context.variables.`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual string ClientKey { get; set; }

        /// <summary>
        /// Required. Issuer parameter name to pass through. Must be in the format `$context.variables.`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        /// <summary>
        /// Required. Subject parameter name to pass through. Must be in the format `$context.variables.`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Threshold settings for metrics in an Evaluation.</summary>
    public class EvaluationMetricsThresholds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The golden evaluation metrics thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldenEvaluationMetricsThresholds")]
        public virtual EvaluationMetricsThresholdsGoldenEvaluationMetricsThresholds GoldenEvaluationMetricsThresholds { get; set; }

        /// <summary>Optional. The hallucination metric behavior for golden evaluations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldenHallucinationMetricBehavior")]
        public virtual string GoldenHallucinationMetricBehavior { get; set; }

        /// <summary>
        /// Optional. Deprecated: Use `golden_hallucination_metric_behavior` instead. The hallucination metric behavior
        /// is currently used for golden evaluations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hallucinationMetricBehavior")]
        public virtual string HallucinationMetricBehavior { get; set; }

        /// <summary>Optional. The hallucination metric behavior for scenario evaluations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scenarioHallucinationMetricBehavior")]
        public virtual string ScenarioHallucinationMetricBehavior { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings for golden evaluations.</summary>
    public class EvaluationMetricsThresholdsGoldenEvaluationMetricsThresholds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The expectation level metrics thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectationLevelMetricsThresholds")]
        public virtual EvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsExpectationLevelMetricsThresholds ExpectationLevelMetricsThresholds { get; set; }

        /// <summary>Optional. The turn level metrics thresholds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turnLevelMetricsThresholds")]
        public virtual EvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsTurnLevelMetricsThresholds TurnLevelMetricsThresholds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Expectation level metrics thresholds.</summary>
    public class EvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsExpectationLevelMetricsThresholds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The success threshold for individual tool invocation parameter correctness. Must be a float
        /// between 0 and 1. Default is 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolInvocationParameterCorrectnessThreshold")]
        public virtual System.Nullable<float> ToolInvocationParameterCorrectnessThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Turn level metrics thresholds.</summary>
    public class EvaluationMetricsThresholdsGoldenEvaluationMetricsThresholdsTurnLevelMetricsThresholds : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The success threshold for overall tool invocation correctness. Must be a float between 0 and 1.
        /// Default is 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overallToolInvocationCorrectnessThreshold")]
        public virtual System.Nullable<float> OverallToolInvocationCorrectnessThreshold { get; set; }

        /// <summary>Optional. The semantic similarity channel to use for evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("semanticSimilarityChannel")]
        public virtual string SemanticSimilarityChannel { get; set; }

        /// <summary>
        /// Optional. The success threshold for semantic similarity. Must be an integer between 0 and 4. Default is
        /// &amp;gt;= 3.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("semanticSimilaritySuccessThreshold")]
        public virtual System.Nullable<int> SemanticSimilaritySuccessThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Event input.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual string Event__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An example represents a sample conversation between the user and the agent(s).</summary>
    public class Example : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the example was created.</summary>
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

        /// <summary>Optional. Human-readable description of the example.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the example.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The agent that initially handles the conversation. If not specified, the example represents a
        /// conversation that is handled by the root agent. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryAgent")]
        public virtual string EntryAgent { get; set; }

        /// <summary>
        /// Etag used to ensure the object hasn't changed during a read-modify-write operation. If the etag is empty,
        /// the update will overwrite any concurrent changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. The example may become invalid if referencing resources are deleted. Invalid examples will not
        /// be used as few-shot examples.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalid")]
        public virtual System.Nullable<bool> Invalid { get; set; }

        /// <summary>Optional. The collection of messages that make up the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the example. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/examples/{example}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the example was last updated.</summary>
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

    /// <summary>Request message for ToolService.ExecuteTool.</summary>
    public class ExecuteToolRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The input parameters and values for the tool in JSON object format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// Optional. The name of the tool to execute. Format:
        /// projects/{project}/locations/{location}/apps/{app}/tools/{tool}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tool")]
        public virtual string Tool { get; set; }

        /// <summary>
        /// Optional. The toolset tool to execute. Only one tool should match the predicate from the toolset. Otherwise,
        /// an error will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsetTool")]
        public virtual ToolsetTool ToolsetTool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ToolService.ExecuteTool.</summary>
    public class ExecuteToolResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The tool execution result in JSON object format. Use "output" key to specify tool response and
        /// "error" key to specify error details (if any). If "output" and "error" keys are not specified, then whole
        /// "response" is treated as tool execution result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>
        /// The name of the tool that got executed. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/tools/{tool}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tool")]
        public virtual string Tool { get; set; }

        /// <summary>The toolset tool that got executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsetTool")]
        public virtual ToolsetTool ToolsetTool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AgentService.ExportApp.</summary>
    public class ExportAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The format to export the app in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportFormat")]
        public virtual string ExportFormat { get; set; }

        /// <summary>
        /// Optional. The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to which to export the app.
        /// The format of this URI must be `gs:///`. The exported app archive will be written directly to the specified
        /// GCS object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ExportApp.</summary>
    public class ExportAppResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App folder compressed as a zip file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appContent")]
        public virtual string AppContent { get; set; }

        /// <summary>
        /// The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to which the app was exported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appUri")]
        public virtual string AppUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Expression condition based on session state.</summary>
    public class ExpressionCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The string representation of cloud.api.Expression condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The file search tool allows the agent to search across the files uploaded by the app/agent developer. It has
    /// presets to give relatively good quality search over the uploaded files and summarization of the retrieved
    /// results.
    /// </summary>
    public class FileSearchTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The type of the corpus. Default is FULLY_MANAGED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corpusType")]
        public virtual string CorpusType { get; set; }

        /// <summary>Optional. The tool description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. The corpus where files are stored. Format:
        /// projects/{project}/locations/{location}/ragCorpora/{rag_corpus}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileCorpus")]
        public virtual string FileCorpus { get; set; }

        /// <summary>Required. The tool name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for WidgetService.GenerateChatToken.</summary>
    public class GenerateChatTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The deployment of the app to use for the session. Format:
        /// projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        /// <summary>Optional. The reCAPTCHA token generated by the client-side chat widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recaptchaToken")]
        public virtual string RecaptchaToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for WidgetService.GenerateChatToken.</summary>
    public class GenerateChatTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The session scoped token for chat widget to authenticate with Session APIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatToken")]
        public virtual string ChatToken { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>The time at which the chat token expires.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Search suggestions from Google Search Tool.</summary>
    public class GoogleSearchSuggestions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compliant HTML and CSS styling for search suggestions. The provided HTML and CSS automatically adapts to
        /// your device settings, displaying in either light or dark mode indicated by `@media(prefers-color-scheme)`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmls")]
        public virtual System.Collections.Generic.IList<string> Htmls { get; set; }

        /// <summary>
        /// List of queries used to perform the google search along with the search result URIs forming the search
        /// suggestions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webSearchQueries")]
        public virtual System.Collections.Generic.IList<WebSearchQuery> WebSearchQueries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a tool to perform Google web searches for grounding. See
    /// https://cloud.google.com/customer-engagement-ai/conversational-agents/ps/tool#google-search.
    /// </summary>
    public class GoogleSearchTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Content will be fetched directly from these URLs for context and grounding. Example:
        /// "https://example.com/path.html". A maximum of 20 URLs are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextUrls")]
        public virtual System.Collections.Generic.IList<string> ContextUrls { get; set; }

        /// <summary>Optional. Description of the tool's purpose.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. List of domains to be excluded from the search results. Example: "example.com". A maximum of 2000
        /// domains can be excluded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeDomains")]
        public virtual System.Collections.Generic.IList<string> ExcludeDomains { get; set; }

        /// <summary>Required. The name of the tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Specifies domains to restrict search results to. Example: "example.com", "another.site". A maximum
        /// of 20 domains can be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredDomains")]
        public virtual System.Collections.Generic.IList<string> PreferredDomains { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guardrail contains a list of checks and balances to keep the agents safe and secure.</summary>
    public class Guardrail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Action to take when the guardrail is triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual TriggerAction Action { get; set; }

        /// <summary>
        /// Optional. Guardrail that potentially blocks the conversation based on the result of the callback execution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeCallback")]
        public virtual GuardrailCodeCallback CodeCallback { get; set; }

        /// <summary>Optional. Guardrail that bans certain content from being used in the conversation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentFilter")]
        public virtual GuardrailContentFilter ContentFilter { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the guardrail was created.</summary>
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

        /// <summary>Optional. Description of the guardrail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the guardrail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Whether the guardrail is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Etag used to ensure the object hasn't changed during a read-modify-write operation. If the etag is empty,
        /// the update will overwrite any concurrent changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Guardrail that blocks the conversation if the LLM response is considered violating the policy
        /// based on the LLM classification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("llmPolicy")]
        public virtual GuardrailLlmPolicy LlmPolicy { get; set; }

        /// <summary>
        /// Optional. Guardrail that blocks the conversation if the prompt is considered unsafe based on the LLM
        /// classification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("llmPromptSecurity")]
        public virtual GuardrailLlmPromptSecurity LlmPromptSecurity { get; set; }

        /// <summary>
        /// Optional. Guardrail that blocks the conversation if the LLM response is considered unsafe based on the model
        /// safety settings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelSafety")]
        public virtual GuardrailModelSafety ModelSafety { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the guardrail. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/guardrails/{guardrail}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the guardrail was last updated.</summary>
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

    /// <summary>Guardrail that blocks the conversation based on the code callbacks provided.</summary>
    public class GuardrailCodeCallback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The callback to execute after the agent is called. Each callback function is expected to return a
        /// structure (e.g., a dict or object) containing at least: - 'decision': Either 'OK' or 'TRIGGER'. - 'reason':
        /// A string explaining the decision. A 'TRIGGER' decision may halt further processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("afterAgentCallback")]
        public virtual Callback AfterAgentCallback { get; set; }

        /// <summary>
        /// Optional. The callback to execute after the model is called. If there are multiple calls to the model, the
        /// callback will be executed multiple times. Each callback function is expected to return a structure (e.g., a
        /// dict or object) containing at least: - 'decision': Either 'OK' or 'TRIGGER'. - 'reason': A string explaining
        /// the decision. A 'TRIGGER' decision may halt further processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("afterModelCallback")]
        public virtual Callback AfterModelCallback { get; set; }

        /// <summary>
        /// Optional. The callback to execute before the agent is called. Each callback function is expected to return a
        /// structure (e.g., a dict or object) containing at least: - 'decision': Either 'OK' or 'TRIGGER'. - 'reason':
        /// A string explaining the decision. A 'TRIGGER' decision may halt further processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beforeAgentCallback")]
        public virtual Callback BeforeAgentCallback { get; set; }

        /// <summary>
        /// Optional. The callback to execute before the model is called. If there are multiple calls to the model, the
        /// callback will be executed multiple times. Each callback function is expected to return a structure (e.g., a
        /// dict or object) containing at least: - 'decision': Either 'OK' or 'TRIGGER'. - 'reason': A string explaining
        /// the decision. A 'TRIGGER' decision may halt further processing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beforeModelCallback")]
        public virtual Callback BeforeModelCallback { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Guardrail that bans certain content from being used in the conversation.</summary>
    public class GuardrailContentFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of banned phrases. Applies to both user inputs and agent responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannedContents")]
        public virtual System.Collections.Generic.IList<string> BannedContents { get; set; }

        /// <summary>Optional. List of banned phrases. Applies only to agent responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannedContentsInAgentResponse")]
        public virtual System.Collections.Generic.IList<string> BannedContentsInAgentResponse { get; set; }

        /// <summary>Optional. List of banned phrases. Applies only to user inputs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bannedContentsInUserInput")]
        public virtual System.Collections.Generic.IList<string> BannedContentsInUserInput { get; set; }

        /// <summary>Optional. If true, diacritics are ignored during matching.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disregardDiacritics")]
        public virtual System.Nullable<bool> DisregardDiacritics { get; set; }

        /// <summary>Required. Match type for the content filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Guardrail that blocks the conversation if the LLM response is considered violating the policy based on the LLM
    /// classification.
    /// </summary>
    public class GuardrailLlmPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. By default, the LLM policy check is bypassed for short utterances. Enabling this setting applies
        /// the policy check to all utterances, including those that would normally be skipped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowShortUtterance")]
        public virtual System.Nullable<bool> AllowShortUtterance { get; set; }

        /// <summary>
        /// Optional. If an error occurs during the policy check, fail open and do not trigger the guardrail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failOpen")]
        public virtual System.Nullable<bool> FailOpen { get; set; }

        /// <summary>
        /// Optional. When checking this policy, consider the last 'n' messages in the conversation. When not set a
        /// default value of 10 will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxConversationMessages")]
        public virtual System.Nullable<int> MaxConversationMessages { get; set; }

        /// <summary>Optional. Model settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelSettings")]
        public virtual ModelSettings ModelSettings { get; set; }

        /// <summary>
        /// Required. Defines when to apply the policy check during the conversation. If set to
        /// `POLICY_SCOPE_UNSPECIFIED`, the policy will be applied to the user input. When applying the policy to the
        /// agent response, additional latency will be introduced before the agent can respond.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyScope")]
        public virtual string PolicyScope { get; set; }

        /// <summary>Required. Policy prompt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prompt")]
        public virtual string Prompt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Guardrail that blocks the conversation if the input is considered unsafe based on the LLM classification.
    /// </summary>
    public class GuardrailLlmPromptSecurity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Use a user-defined LlmPolicy to configure the security guardrail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPolicy")]
        public virtual GuardrailLlmPolicy CustomPolicy { get; set; }

        /// <summary>
        /// Optional. Use the system's predefined default security settings. To select this mode, include an empty
        /// 'default_settings' message in the request. The 'default_prompt_template' field within will be populated by
        /// the server in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSettings")]
        public virtual GuardrailLlmPromptSecurityDefaultSecuritySettings DefaultSettings { get; set; }

        /// <summary>
        /// Optional. Determines the behavior when the guardrail encounters an LLM error. - If true: the guardrail is
        /// bypassed. - If false (default): the guardrail triggers/blocks. Note: If a custom policy is provided, this
        /// field is ignored in favor of the policy's 'fail_open' configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failOpen")]
        public virtual System.Nullable<bool> FailOpen { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for default system security settings.</summary>
    public class GuardrailLlmPromptSecurityDefaultSecuritySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The default prompt template used by the system. This field is for display purposes to show the
        /// user what prompt the system uses by default. It is OUTPUT_ONLY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPromptTemplate")]
        public virtual string DefaultPromptTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Model safety settings overrides. When this is set, it will override the default settings and trigger the
    /// guardrail if the response is considered unsafe.
    /// </summary>
    public class GuardrailModelSafety : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of safety settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetySettings")]
        public virtual System.Collections.Generic.IList<GuardrailModelSafetySafetySetting> SafetySettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Safety setting.</summary>
    public class GuardrailModelSafetySafetySetting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The harm category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Required. The harm block threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual string Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an image input or output in the conversation.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Raw bytes of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Required. The IANA standard MIME type of the source data. Supported image types includes: * image/png *
        /// image/jpeg * image/webp
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AgentService.ImportApp.</summary>
    public class ImportAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Raw bytes representing the compressed zip file with the app folder structure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appContent")]
        public virtual string AppContent { get; set; }

        /// <summary>
        /// Optional. The ID to use for the imported app. * If not specified, a unique ID will be automatically assigned
        /// for the app. * Otherwise, the imported app will use this ID as the final component of its resource name. If
        /// an app with the same ID already exists at the specified location in the project, the content of the existing
        /// app will be replaced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// Optional. The display name of the app to import. * If the app is created on import, and the display name is
        /// specified, the imported app will use this display name. If a conflict is detected with an existing app, a
        /// timestamp will be appended to the display name to make it unique. * If the app is a reimport, this field
        /// should not be set. Providing a display name during reimport will result in an INVALID_ARGUMENT error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI from which to import app. The format
        /// of this URI must be `gs:///`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>Optional. Options governing the import process for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importOptions")]
        public virtual ImportAppRequestImportOptions ImportOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration options for the app import process. These options control how the import behaves, particularly
    /// when conflicts arise with existing app data.
    /// </summary>
    public class ImportAppRequestImportOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The strategy to use when resolving conflicts during import.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conflictResolutionStrategy")]
        public virtual string ConflictResolutionStrategy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ImportApp.</summary>
    public class ImportAppResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the app that was imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Warning messages generated during the import process. If errors occur for specific resources, they will not
        /// be included in the imported app and the error will be mentioned here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<string> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>InputAudioConfig configures how the CES agent should interpret the incoming audio data.</summary>
    public class InputAudioConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The encoding of the input audio data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioEncoding")]
        public virtual string AudioEncoding { get; set; }

        /// <summary>
        /// Optional. Whether to enable noise suppression on the input audio. Available values are "low", "moderate",
        /// "high", "very_high".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noiseSuppressionLevel")]
        public virtual string NoiseSuppressionLevel { get; set; }

        /// <summary>Required. The sample rate (in Hertz) of the input audio data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Language settings of the app.</summary>
    public class LanguageSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The default language code of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguageCode")]
        public virtual string DefaultLanguageCode { get; set; }

        /// <summary>
        /// Optional. Enables multilingual support. If true, agents in the app will use pre-built instructions to
        /// improve handling of multilingual input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableMultilingualSupport")]
        public virtual System.Nullable<bool> EnableMultilingualSupport { get; set; }

        /// <summary>
        /// Optional. The action to perform when an agent receives input in an unsupported language. This can be a
        /// predefined action or a custom tool call. Valid values are: - A tool's full resource name, which triggers a
        /// specific tool execution. - A predefined system action, such as "escalate" or "exit", which triggers an
        /// EndSession signal with corresponding metadata to terminate the conversation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallbackAction")]
        public virtual string FallbackAction { get; set; }

        /// <summary>
        /// Optional. List of languages codes supported by the app, in addition to the `default_language_code`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedLanguageCodes")]
        public virtual System.Collections.Generic.IList<string> SupportedLanguageCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListAgents.</summary>
    public class ListAgentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of agents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agents")]
        public virtual System.Collections.Generic.IList<Agent> Agents { get; set; }

        /// <summary>
        /// A token that can be sent as ListAgentsRequest.page_token to retrieve the next page. Absence of this field
        /// indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListAppVersions.</summary>
    public class ListAppVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of app versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersions")]
        public virtual System.Collections.Generic.IList<AppVersion> AppVersions { get; set; }

        /// <summary>
        /// A token that can be sent as ListAppVersionsRequest.page_token to retrieve the next page. Absence of this
        /// field indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListApps.</summary>
    public class ListAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<App> Apps { get; set; }

        /// <summary>
        /// A token that can be sent as ListAppsRequest.page_token to retrieve the next page. Absence of this field
        /// indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unordered list. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListChangelogs.</summary>
    public class ListChangelogsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of changelogs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changelogs")]
        public virtual System.Collections.Generic.IList<Changelog> Changelogs { get; set; }

        /// <summary>
        /// A token that can be sent as ListChangelogsRequest.page_token to retrieve the next page. Absence of this
        /// field indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListConversations.</summary>
    public class ListConversationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of conversations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversations")]
        public virtual System.Collections.Generic.IList<Conversation> Conversations { get; set; }

        /// <summary>
        /// A token that can be sent as ListConversationsRequest.page_token to retrieve the next page. Absence of this
        /// field indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListDeployments.</summary>
    public class ListDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployments")]
        public virtual System.Collections.Generic.IList<Deployment> Deployments { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListExamples.</summary>
    public class ListExamplesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of examples.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("examples")]
        public virtual System.Collections.Generic.IList<Example> Examples { get; set; }

        /// <summary>
        /// A token that can be sent as ListExamplesRequest.page_token to retrieve the next page. Absence of this field
        /// indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListGuardrails.</summary>
    public class ListGuardrailsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of guardrails.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardrails")]
        public virtual System.Collections.Generic.IList<Guardrail> Guardrails { get; set; }

        /// <summary>
        /// A token that can be sent as ListGuardrailsRequest.page_token to retrieve the next page. Absence of this
        /// field indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

        /// <summary>
        /// Unordered list. Unreachable resources. Populated when the request sets
        /// `ListOperationsRequest.return_partial_success` and reads across collections. For example, when attempting to
        /// list all resources across all supported locations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListTools.</summary>
    public class ListToolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as ListToolsRequest.page_token to retrieve the next page. Absence of this field
        /// indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of tools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tools")]
        public virtual System.Collections.Generic.IList<Tool> Tools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AgentService.ListToolsets.</summary>
    public class ListToolsetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as ListToolsetsRequest.page_token to retrieve the next page. Absence of this field
        /// indicates there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of toolsets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsets")]
        public virtual System.Collections.Generic.IList<Toolset> Toolsets { get; set; }

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

    /// <summary>Settings to describe the logging behaviors for the app.</summary>
    public class LoggingSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Configuration for how audio interactions should be recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioRecordingConfig")]
        public virtual AudioRecordingConfig AudioRecordingConfig { get; set; }

        /// <summary>
        /// Optional. Settings to describe the BigQuery export behaviors for the app. The conversation data will be
        /// exported to BigQuery tables if it is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryExportSettings")]
        public virtual BigQueryExportSettings BigqueryExportSettings { get; set; }

        /// <summary>Optional. Settings to describe the Cloud Logging behaviors for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudLoggingSettings")]
        public virtual CloudLoggingSettings CloudLoggingSettings { get; set; }

        /// <summary>Optional. Settings to describe the conversation logging behaviors for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversationLoggingSettings")]
        public virtual ConversationLoggingSettings ConversationLoggingSettings { get; set; }

        /// <summary>
        /// Optional. Configuration for how audio interactions should be recorded for the evaluation. By default, audio
        /// recording is not enabled for evaluation sessions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationAudioRecordingConfig")]
        public virtual AudioRecordingConfig EvaluationAudioRecordingConfig { get; set; }

        /// <summary>
        /// Optional. Settings to describe the conversation data collection behaviors for the LLM analysis pipeline for
        /// the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricAnalysisSettings")]
        public virtual MetricAnalysisSettings MetricAnalysisSettings { get; set; }

        /// <summary>Optional. Configuration for how sensitive data should be redacted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redactionConfig")]
        public virtual RedactionConfig RedactionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An MCP tool. See https://modelcontextprotocol.io/specification/2025-06-18/server/tools for more details.
    /// </summary>
    public class McpTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Authentication information required to execute the tool against the MCP server. For bearer token
        /// authentication, the token applies only to tool execution, not to listing tools. This requires that tools can
        /// be listed without authentication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiAuthentication")]
        public virtual ApiAuthentication ApiAuthentication { get; set; }

        /// <summary>Optional. The description of the MCP tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. The schema of the input arguments of the MCP tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputSchema")]
        public virtual Schema InputSchema { get; set; }

        /// <summary>Required. The name of the MCP tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The schema of the output arguments of the MCP tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputSchema")]
        public virtual Schema OutputSchema { get; set; }

        /// <summary>
        /// Required. The server address of the MCP server, e.g., "https://example.com/mcp/". If the server is built
        /// with the MCP SDK, the url should be suffixed with "/mcp/". Only Streamable HTTP transport based servers are
        /// supported. This is the same as the server_address in the McpToolset. See
        /// https://modelcontextprotocol.io/specification/2025-03-26/basic/transports#streamable-http for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverAddress")]
        public virtual string ServerAddress { get; set; }

        /// <summary>
        /// Optional. Service Directory configuration for VPC-SC, used to resolve service names within a perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>
        /// Optional. The TLS configuration. Includes the custom server certificates that the client should trust.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsConfig")]
        public virtual TlsConfig TlsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A toolset that contains a list of tools that are offered by the MCP server.</summary>
    public class McpToolset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Authentication information required to access tools and execute a tool against the MCP server. For
        /// bearer token authentication, the token applies only to tool execution, not to listing tools. This requires
        /// that tools can be listed without authentication.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiAuthentication")]
        public virtual ApiAuthentication ApiAuthentication { get; set; }

        /// <summary>
        /// Required. The address of the MCP server, for example, "https://example.com/mcp/". If the server is built
        /// with the MCP SDK, the url should be suffixed with "/mcp/". Only Streamable HTTP transport based servers are
        /// supported. See https://modelcontextprotocol.io/specification/2025-03-26/basic/transports#streamable-http for
        /// more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverAddress")]
        public virtual string ServerAddress { get; set; }

        /// <summary>
        /// Optional. Service Directory configuration for VPC-SC, used to resolve service names within a perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>
        /// Optional. The TLS configuration. Includes the custom server certificates that the client should trust.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsConfig")]
        public virtual TlsConfig TlsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message within a conversation.</summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Content of the message as a series of chunks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunks")]
        public virtual System.Collections.Generic.IList<Chunk> Chunks { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// Optional. Timestamp when the message was sent or received. Should not be used if the message is part of an
        /// example.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. The role within the conversation, e.g., user, agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings to describe the conversation data collection behaviors for LLM analysis metrics pipeline.
    /// </summary>
    public class MetricAnalysisSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Whether to collect conversation data for llm analysis metrics. If true, conversation data will not
        /// be collected for llm analysis metrics; otherwise, conversation data will be collected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("llmMetricsOptedOut")]
        public virtual System.Nullable<bool> LlmMetricsOptedOut { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Model settings contains various configurations for the LLM model.</summary>
    public class ModelSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The LLM model that the agent should use. If not set, the agent will inherit the model from its
        /// parent agent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// Optional. If set, this temperature will be used for the LLM model. Temperature controls the randomness of
        /// the model's responses. Lower temperatures produce responses that are more predictable. Higher temperatures
        /// produce responses that are more creative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("temperature")]
        public virtual System.Nullable<double> Temperature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for authentication with OAuth.</summary>
    public class OAuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The client ID from the OAuth provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Required. The name of the SecretManager secret version resource storing the client secret. Format:
        /// `projects/{project}/secrets/{secret}/versions/{version}` Note: You should grant
        /// `roles/secretmanager.secretAccessor` role to the CES service agent
        /// `service-@gcp-sa-ces.iam.gserviceaccount.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecretVersion")]
        public virtual string ClientSecretVersion { get; set; }

        /// <summary>Required. OAuth grant types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthGrantType")]
        public virtual string OauthGrantType { get; set; }

        /// <summary>Optional. The OAuth scopes to grant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>Required. The token endpoint in the OAuth provider to exchange for an access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenEndpoint")]
        public virtual string TokenEndpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an Omnichannel resource.</summary>
    public class Omnichannel : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the omnichannel resource was created.</summary>
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

        /// <summary>Optional. Human-readable description of the omnichannel resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the omnichannel resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Etag used to ensure the object hasn't changed during a read-modify-write operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. The integration config for the omnichannel resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationConfig")]
        public virtual OmnichannelIntegrationConfig IntegrationConfig { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the omnichannel resource. Format:
        /// `projects/{project}/locations/{location}/omnichannels/{omnichannel}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the omnichannel resource was last updated.</summary>
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

    /// <summary>OmnichannelIntegrationConfig contains all App integration configs.</summary>
    public class OmnichannelIntegrationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Various of configuration for handling App events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, OmnichannelIntegrationConfigChannelConfig> ChannelConfigs { get; set; }

        /// <summary>
        /// Optional. The key of routing_configs is a key of `app_configs`, value is a `RoutingConfig`, which contains
        /// subscriber's key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, OmnichannelIntegrationConfigRoutingConfig> RoutingConfigs { get; set; }

        /// <summary>Optional. Various of subscribers configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, OmnichannelIntegrationConfigSubscriberConfig> SubscriberConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configs for CES app.</summary>
    public class OmnichannelIntegrationConfigCesAppConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique identifier of the CES app. Format: `projects/{project}/locations/{location}/apps/{app}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("app")]
        public virtual string App { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ChannelConfig contains config for various of app integration.</summary>
    public class OmnichannelIntegrationConfigChannelConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>WhatsApp config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whatsappConfig")]
        public virtual OmnichannelIntegrationConfigWhatsappConfig WhatsappConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Routing config specify how/who to route app events to a subscriber.</summary>
    public class OmnichannelIntegrationConfigRoutingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key of the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberKey")]
        public virtual string SubscriberKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configs of subscribers.</summary>
    public class OmnichannelIntegrationConfigSubscriberConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ces app config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cesAppConfig")]
        public virtual OmnichannelIntegrationConfigCesAppConfig CesAppConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>How Omnichannel should receive/reply events from WhatsApp.</summary>
    public class OmnichannelIntegrationConfigWhatsappConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Meta Business Portfolio (MBP) ID. https://www.facebook.com/business/help/1710077379203657
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metaBusinessPortfolioId")]
        public virtual string MetaBusinessPortfolioId { get; set; }

        /// <summary>The phone number used for sending/receiving messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>The Phone Number ID associated with the WhatsApp Business Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumberId")]
        public virtual string PhoneNumberId { get; set; }

        /// <summary>The verify token configured in the Meta App Dashboard for webhook verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookVerifyToken")]
        public virtual string WebhookVerifyToken { get; set; }

        /// <summary>The customer's WhatsApp Business Account (WABA) ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whatsappBusinessAccountId")]
        public virtual string WhatsappBusinessAccountId { get; set; }

        /// <summary>
        /// The access token for authenticating API calls to the WhatsApp Cloud API.
        /// https://developers.facebook.com/docs/whatsapp/business-management-api/get-started/#business-integration-system-user-access-tokens
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whatsappBusinessToken")]
        public virtual string WhatsappBusinessToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OmnichannelOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
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

        /// <summary>Output only. Identifies whether the user has requested cancellation of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A remote API tool defined by an OpenAPI schema.</summary>
    public class OpenApiTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authentication information required by the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiAuthentication")]
        public virtual ApiAuthentication ApiAuthentication { get; set; }

        /// <summary>
        /// Optional. The description of the tool. If not provided, the description of the tool will be derived from the
        /// OpenAPI schema, from `operation.description` or `operation.summary`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. If true, the agent will ignore unknown fields in the API response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnknownFields")]
        public virtual System.Nullable<bool> IgnoreUnknownFields { get; set; }

        /// <summary>
        /// Optional. The name of the tool. If not provided, the name of the tool will be derived from the OpenAPI
        /// schema, from `operation.operationId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The OpenAPI schema in JSON or YAML format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openApiSchema")]
        public virtual string OpenApiSchema { get; set; }

        /// <summary>Optional. Service Directory configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>
        /// Optional. The TLS configuration. Includes the custom server certificates that the client will trust.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsConfig")]
        public virtual TlsConfig TlsConfig { get; set; }

        /// <summary>
        /// Optional. The server URL of the Open API schema. This field is only set in tools in the environment
        /// dependencies during the export process if the schema contains a server url. During the import process, if
        /// this url is present in the environment dependencies and the schema has the $env_var placeholder, it will
        /// replace the placeholder in the schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A toolset that contains a list of tools that are defined by an OpenAPI schema.</summary>
    public class OpenApiToolset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authentication information required by the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiAuthentication")]
        public virtual ApiAuthentication ApiAuthentication { get; set; }

        /// <summary>
        /// Optional. If true, the agent will ignore unknown fields in the API response for all operations defined in
        /// the OpenAPI schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreUnknownFields")]
        public virtual System.Nullable<bool> IgnoreUnknownFields { get; set; }

        /// <summary>Required. The OpenAPI schema of the toolset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openApiSchema")]
        public virtual string OpenApiSchema { get; set; }

        /// <summary>Optional. Service Directory configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>Optional. The TLS configuration. Includes the custom server certificates</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsConfig")]
        public virtual TlsConfig TlsConfig { get; set; }

        /// <summary>
        /// Optional. The server URL of the Open API schema. This field is only set in toolsets in the environment
        /// dependencies during the export process if the schema contains a server url. During the import process, if
        /// this url is present in the environment dependencies and the schema has the $env_var placeholder, it will
        /// replace the placeholder in the schema.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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
        /// been cancelled successfully have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>OutputAudioConfig configures how the CES agent should synthesize outgoing audio responses.</summary>
    public class OutputAudioConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The encoding of the output audio data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioEncoding")]
        public virtual string AudioEncoding { get; set; }

        /// <summary>Required. The sample rate (in Hertz) of the output audio data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Python code block to evaluate the condition.</summary>
    public class PythonCodeCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The python code to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonCode")]
        public virtual string PythonCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Python function tool.</summary>
    public class PythonFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The description of the Python function, parsed from the python code's docstring.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. The name of the Python function to execute. Must match a Python function name defined in the
        /// python code. Case sensitive. If the name is not provided, the first function defined in the python code will
        /// be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The Python code to execute for the tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonCode")]
        public virtual string PythonCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration to instruct how sensitive data should be handled.</summary>
    public class RedactionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. [DLP](https://cloud.google.com/dlp/docs) deidentify template name to instruct on how to
        /// de-identify content. Format:
        /// `projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deidentifyTemplate")]
        public virtual string DeidentifyTemplate { get; set; }

        /// <summary>
        /// Optional. If true, redaction will be applied in various logging scenarios, including conversation history,
        /// Cloud Logging and audio recording.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRedaction")]
        public virtual System.Nullable<bool> EnableRedaction { get; set; }

        /// <summary>
        /// Optional. [DLP](https://cloud.google.com/dlp/docs) inspect template name to configure detection of sensitive
        /// data types. Format: `projects/{project}/locations/{location}/inspectTemplates/{inspect_template}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectTemplate")]
        public virtual string InspectTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AgentService.RestoreAppVersion</summary>
    public class RestoreAppVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ToolService.RetrieveToolSchema.</summary>
    public class RetrieveToolSchemaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the tool to retrieve the schema for. Format:
        /// projects/{project}/locations/{location}/apps/{app}/tools/{tool}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tool")]
        public virtual string Tool { get; set; }

        /// <summary>
        /// Optional. The toolset tool to retrieve the schema for. Only one tool should match the predicate from the
        /// toolset. Otherwise, an error will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsetTool")]
        public virtual ToolsetTool ToolsetTool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ToolService.RetrieveToolSchema.</summary>
    public class RetrieveToolSchemaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The schema of the tool input parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputSchema")]
        public virtual Schema InputSchema { get; set; }

        /// <summary>Required. The schema of the tool output parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputSchema")]
        public virtual Schema OutputSchema { get; set; }

        /// <summary>
        /// The name of the tool that the schema is for. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/tools/{tool}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tool")]
        public virtual string Tool { get; set; }

        /// <summary>The toolset tool that the schema is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsetTool")]
        public virtual ToolsetTool ToolsetTool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ToolService.RetrieveTools.</summary>
    public class RetrieveToolsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The identifiers of the tools to retrieve from the toolset. If empty, all tools in the toolset will
        /// be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolIds")]
        public virtual System.Collections.Generic.IList<string> ToolIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ToolService.RetrieveTools.</summary>
    public class RetrieveToolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of tools that are included in the specified toolset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tools")]
        public virtual System.Collections.Generic.IList<Tool> Tools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for SessionService.RunSession.</summary>
    public class RunSessionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The configuration for the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual SessionConfig Config { get; set; }

        /// <summary>Required. Inputs for the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputs")]
        public virtual System.Collections.Generic.IList<SessionInput> Inputs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SessionService.RunSession.</summary>
    public class RunSessionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Outputs for the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputs")]
        public virtual System.Collections.Generic.IList<SessionOutput> Outputs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a select subset of an OpenAPI 3.0 schema object.</summary>
    public class Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Can either be a boolean or an object, controls the presence of additional properties.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalProperties")]
        public virtual Schema AdditionalProperties { get; set; }

        /// <summary>
        /// Optional. The value should be validated against any (one or more) of the subschemas in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anyOf")]
        public virtual System.Collections.Generic.IList<Schema> AnyOf { get; set; }

        /// <summary>Optional. Default value of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual object Default__ { get; set; }

        /// <summary>Optional. A map of definitions for use by `ref`. Only allowed at the root of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defs")]
        public virtual System.Collections.Generic.IDictionary<string, Schema> Defs { get; set; }

        /// <summary>Optional. The description of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Possible values of the element of primitive type with enum format. Examples: 1. We can define
        /// direction as : {type:STRING, format:enum, enum:["EAST", NORTH", "SOUTH", "WEST"]} 2. We can define apartment
        /// number as : {type:INTEGER, format:enum, enum:["101", "201", "301"]}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enum")]
        public virtual System.Collections.Generic.IList<string> Enum__ { get; set; }

        /// <summary>Optional. Schema of the elements of Type.ARRAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual Schema Items { get; set; }

        /// <summary>Optional. Maximum number of the elements for Type.ARRAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxItems")]
        public virtual System.Nullable<long> MaxItems { get; set; }

        /// <summary>Optional. Maximum value for Type.INTEGER and Type.NUMBER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual System.Nullable<double> Maximum { get; set; }

        /// <summary>Optional. Minimum number of the elements for Type.ARRAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minItems")]
        public virtual System.Nullable<long> MinItems { get; set; }

        /// <summary>Optional. Minimum value for Type.INTEGER and Type.NUMBER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual System.Nullable<double> Minimum { get; set; }

        /// <summary>Optional. Indicates if the value may be null.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>Optional. Schemas of initial elements of Type.ARRAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixItems")]
        public virtual System.Collections.Generic.IList<Schema> PrefixItems { get; set; }

        /// <summary>Optional. Properties of Type.OBJECT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, Schema> Properties { get; set; }

        /// <summary>
        /// Optional. Allows indirect references between schema nodes. The value should be a valid reference to a child
        /// of the root `defs`. For example, the following schema defines a reference to a schema node named "Pet":
        /// type: object properties: pet: ref: #/defs/Pet defs: Pet: type: object properties: name: type: string The
        /// value of the "pet" property is a reference to the schema node named "Pet". See details in
        /// https://json-schema.org/understanding-json-schema/structuring.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ref")]
        public virtual string Ref__ { get; set; }

        /// <summary>Optional. Required properties of Type.OBJECT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Collections.Generic.IList<string> Required { get; set; }

        /// <summary>Optional. The title of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Required. The type of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Optional. Indicate the items in the array must be unique. Only applies to TYPE.ARRAY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueItems")]
        public virtual System.Nullable<bool> UniqueItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations for authentication using a custom service account.</summary>
    public class ServiceAccountAuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The OAuth scopes to grant. If not specified, the default scope
        /// `https://www.googleapis.com/auth/cloud-platform` is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Required. The email address of the service account used for authentication. CES uses this service account to
        /// exchange an access token and the access token is then sent in the `Authorization` header of the request. The
        /// service account must have the `roles/iam.serviceAccountTokenCreator` role granted to the CES service agent
        /// `service-@gcp-sa-ces.iam.gserviceaccount.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configurations for authentication with [ID token](https://cloud.google.com/docs/authentication/token-types#id)
    /// generated from service agent.
    /// </summary>
    public class ServiceAgentIdTokenAuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for tools using Service Directory.</summary>
    public class ServiceDirectoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of [Service Directory](https://cloud.google.com/service-directory) service. Format:
        /// `projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}`. Location of the service
        /// directory must be the same as the location of the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for the session.</summary>
    public class SessionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The deployment of the app to use for the session. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/deployments/{deployment}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        /// <summary>
        /// Optional. The entry agent to handle the session. If not specified, the session will be handled by the root
        /// agent of the app. Format: `projects/{project}/locations/{location}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryAgent")]
        public virtual string EntryAgent { get; set; }

        /// <summary>
        /// Optional. The historical context of the session, including user inputs, agent responses, and other messages.
        /// Typically, CES agent would manage session automatically so client doesn't need to explicitly populate this
        /// field. However, client can optionally override the historical contexts to force the session start from
        /// certain state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("historicalContexts")]
        public virtual System.Collections.Generic.IList<Message> HistoricalContexts { get; set; }

        /// <summary>Optional. Configuration for processing the input audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputAudioConfig")]
        public virtual InputAudioConfig InputAudioConfig { get; set; }

        /// <summary>Optional. Configuration for generating the output audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputAudioConfig")]
        public virtual OutputAudioConfig OutputAudioConfig { get; set; }

        /// <summary>
        /// Optional.
        /// [QueryParameters](https://cloud.google.com/dialogflow/cx/docs/reference/rpc/google.cloud.dialogflow.cx.v3#queryparameters)
        /// to send to the remote
        /// [Dialogflow](https://cloud.google.com/dialogflow/cx/docs/concept/console-conversational-agents) agent when
        /// the session control is transferred to the remote agent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteDialogflowQueryParameters")]
        public virtual SessionConfigRemoteDialogflowQueryParameters RemoteDialogflowQueryParameters { get; set; }

        /// <summary>
        /// Optional. The time zone of the user. If provided, the agent will use the time zone for date and time related
        /// variables. Otherwise, the agent will use the time zone specified in the App.time_zone_settings. The format
        /// is the IANA Time Zone Database time zone, e.g. "America/Los_Angeles".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// [QueryParameters](https://cloud.google.com/dialogflow/cx/docs/reference/rpc/google.cloud.dialogflow.cx.v3#queryparameters)
    /// to send to the remote
    /// [Dialogflow](https://cloud.google.com/dialogflow/cx/docs/concept/console-conversational-agents) agent when the
    /// session control is transferred to the remote agent.
    /// </summary>
    public class SessionConfigRemoteDialogflowQueryParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The end user metadata to be sent in
        /// [QueryParameters](https://cloud.google.com/dialogflow/cx/docs/reference/rpc/google.cloud.dialogflow.cx.v3#queryparameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUserMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> EndUserMetadata { get; set; }

        /// <summary>
        /// Optional. The payload to be sent in
        /// [QueryParameters](https://cloud.google.com/dialogflow/cx/docs/reference/rpc/google.cloud.dialogflow.cx.v3#queryparameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string, object> Payload { get; set; }

        /// <summary>
        /// Optional. The HTTP headers to be sent as webhook_headers in
        /// [QueryParameters](https://cloud.google.com/dialogflow/cx/docs/reference/rpc/google.cloud.dialogflow.cx.v3#queryparameters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookHeaders")]
        public virtual System.Collections.Generic.IDictionary<string, string> WebhookHeaders { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Input for the session.</summary>
    public class SessionInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Audio data from the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual string Audio { get; set; }

        /// <summary>Optional. Blob data from the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blob")]
        public virtual Blob Blob { get; set; }

        /// <summary>Optional. DTMF digits from the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dtmf")]
        public virtual string Dtmf { get; set; }

        /// <summary>Optional. Event input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual Event Event__ { get; set; }

        /// <summary>Optional. Image data from the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>Optional. Text data from the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Optional. Execution results for the tool calls from the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolResponses")]
        public virtual ToolResponses ToolResponses { get; set; }

        /// <summary>
        /// Optional. Contextual variables for the session, keyed by name. Only variables declared in the app will be
        /// used by the CES agent. Unrecognized variables will still be sent to the Dialogflow agent as additional
        /// session parameters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variables")]
        public virtual System.Collections.Generic.IDictionary<string, object> Variables { get; set; }

        /// <summary>
        /// Optional. A flag to indicate if the current message is a fragment of a larger input in the bidi streaming
        /// session. When `true`, the agent will defer processing until a subsequent message with `will_continue` set to
        /// `false` is received. Note: This flag has no effect on audio and DTMF inputs, which are always processed in
        /// real-time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("willContinue")]
        public virtual System.Nullable<bool> WillContinue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Output for the session.</summary>
    public class SessionOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output audio from the CES agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual string Audio { get; set; }

        /// <summary>Citations that provide the source information for the agent's generated text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citations")]
        public virtual Citations Citations { get; set; }

        /// <summary>
        /// Optional. Diagnostic information contains execution details during the processing of the input. Only
        /// populated in the last SessionOutput (with `turn_completed=true`) for each turn.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticInfo")]
        public virtual SessionOutputDiagnosticInfo DiagnosticInfo { get; set; }

        /// <summary>Indicates the session has ended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endSession")]
        public virtual EndSession EndSession { get; set; }

        /// <summary>The suggestions returned from Google Search as a result of invoking the GoogleSearchTool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSearchSuggestions")]
        public virtual GoogleSearchSuggestions GoogleSearchSuggestions { get; set; }

        /// <summary>Custom payload with structured output from the CES agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string, object> Payload { get; set; }

        /// <summary>Output text from the CES agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Request for the client to execute the tools.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolCalls")]
        public virtual ToolCalls ToolCalls { get; set; }

        /// <summary>
        /// If true, the CES agent has detected the end of the current conversation turn and will provide no further
        /// output for this turn.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turnCompleted")]
        public virtual System.Nullable<bool> TurnCompleted { get; set; }

        /// <summary>
        /// Indicates the sequential order of conversation turn to which this output belongs to, starting from 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turnIndex")]
        public virtual System.Nullable<int> TurnIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains execution details during the processing.</summary>
    public class SessionOutputDiagnosticInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the messages that happened during the processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<Message> Messages { get; set; }

        /// <summary>
        /// A trace of the entire request processing, represented as a root span. This span can contain nested child
        /// spans for specific operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootSpan")]
        public virtual Span RootSpan { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A span is a unit of work or a single operation during the request processing.</summary>
    public class Span : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Key-value attributes associated with the span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, object> Attributes { get; set; }

        /// <summary>Output only. The child spans that are nested under this span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childSpans")]
        public virtual System.Collections.Generic.IList<Span> ChildSpans { get; set; }

        /// <summary>Output only. The duration of the span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The end time of the span.</summary>
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

        /// <summary>Output only. The name of the span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The start time of the span.</summary>
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

    /// <summary>Configuration for how the agent response should be synthesized.</summary>
    public class SynthesizeSpeechConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The speaking rate/speed in the range [0.25, 2.0]. 1.0 is the normal native speed supported by the
        /// specific voice. 2.0 is twice as fast, and 0.5 is half as fast. Values outside of the range [0.25, 2.0] will
        /// return an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakingRate")]
        public virtual System.Nullable<double> SpeakingRate { get; set; }

        /// <summary>
        /// Optional. The name of the voice. If not set, the service will choose a voice based on the other parameters
        /// such as language_code. For the list of available voices, please refer to [Supported voices and
        /// languages](https://cloud.google.com/text-to-speech/docs/voices) from Cloud Text-to-Speech.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voice")]
        public virtual string Voice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pre-defined system tool.</summary>
    public class SystemTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The description of the system tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The name of the system tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TimeZone settings of the app.</summary>
    public class TimeZoneSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The time zone of the app from the [time zone database](https://www.iana.org/time-zones), e.g.,
        /// America/Los_Angeles, Europe/Paris.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The TLS configuration.</summary>
    public class TlsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies a list of allowed custom CA certificates for HTTPS verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caCerts")]
        public virtual System.Collections.Generic.IList<TlsConfigCaCert> CaCerts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The CA certificate.</summary>
    public class TlsConfigCaCert : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The allowed custom CA certificates (in DER format) for HTTPS verification. This overrides the
        /// default SSL trust store. If this is empty or unspecified, CES will use Google's default trust store to
        /// verify certificates. N.B. Make sure the HTTPS server certificates are signed with "subject alt name". For
        /// instance a certificate can be self-signed using the following command, openssl x509 -req -days 200 -in
        /// example.com.csr \ -signkey example.com.key \ -out example.com.crt \ -extfile &amp;lt;(printf
        /// "\nsubjectAltName='DNS:www.example.com'")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cert")]
        public virtual string Cert { get; set; }

        /// <summary>
        /// Required. The name of the allowed custom CA certificates. This can be used to disambiguate the custom CA
        /// certificates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A tool represents an action that the CES agent can take to achieve certain goals.</summary>
    public class Tool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The client function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientFunction")]
        public virtual ClientFunction ClientFunction { get; set; }

        /// <summary>Optional. The Integration Connector tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorTool")]
        public virtual ConnectorTool ConnectorTool { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the tool was created.</summary>
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

        /// <summary>Optional. The data store tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStoreTool")]
        public virtual DataStoreTool DataStoreTool { get; set; }

        /// <summary>
        /// Output only. The display name of the tool, derived based on the tool's type. For example, display name of a
        /// ClientFunction is derived from its `name` property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Etag used to ensure the object hasn't changed during a read-modify-write operation. If the etag is empty,
        /// the update will overwrite any concurrent changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. The execution type of the tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionType")]
        public virtual string ExecutionType { get; set; }

        /// <summary>Optional. The file search tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSearchTool")]
        public virtual FileSearchTool FileSearchTool { get; set; }

        /// <summary>
        /// Output only. If the tool is generated by the LLM assistant, this field contains a descriptive summary of the
        /// generation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedSummary")]
        public virtual string GeneratedSummary { get; set; }

        /// <summary>Optional. The google search tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSearchTool")]
        public virtual GoogleSearchTool GoogleSearchTool { get; set; }

        /// <summary>
        /// Optional. The MCP tool. An MCP tool cannot be created or updated directly and is managed by the MCP toolset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mcpTool")]
        public virtual McpTool McpTool { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the tool. Format: -
        /// `projects/{project}/locations/{location}/apps/{app}/tools/{tool}` for ## standalone tools.
        /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}/tools/{tool}` for tools retrieved
        /// from a toolset. These tools are dynamic and output-only, they cannot be referenced directly where a tool is
        /// expected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The open API tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openApiTool")]
        public virtual OpenApiTool OpenApiTool { get; set; }

        /// <summary>Optional. The python function tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonFunction")]
        public virtual PythonFunction PythonFunction { get; set; }

        /// <summary>Optional. The system tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemTool")]
        public virtual SystemTool SystemTool { get; set; }

        /// <summary>Optional. Configuration for tool behavior in fake mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolFakeConfig")]
        public virtual ToolFakeConfig ToolFakeConfig { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the tool was last updated.</summary>
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

        /// <summary>Optional. The widget tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgetTool")]
        public virtual WidgetTool WidgetTool { get; set; }
    }

    /// <summary>Request for the client or the agent to execute the specified tool.</summary>
    public class ToolCall : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The input parameters and values for the tool in JSON object format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IDictionary<string, object> Args { get; set; }

        /// <summary>Output only. Display name of the tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The unique identifier of the tool call. If populated, the client should return the execution
        /// result with the matching ID in ToolResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. The name of the tool to execute. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/tools/{tool}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tool")]
        public virtual string Tool { get; set; }

        /// <summary>Optional. The toolset tool to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsetTool")]
        public virtual ToolsetTool ToolsetTool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request for the client to execute the tools and return the execution results before continuing the session.
    /// </summary>
    public class ToolCalls : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of tool calls to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolCalls")]
        public virtual System.Collections.Generic.IList<ToolCall> ToolCallsValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for tool behavior in fake mode.</summary>
    public class ToolFakeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Code block which will be executed instead of a real tool call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeBlock")]
        public virtual CodeBlock CodeBlock { get; set; }

        /// <summary>Optional. Whether the tool is using fake mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFakeMode")]
        public virtual System.Nullable<bool> EnableFakeMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The execution result of a specific tool from the client or the agent.</summary>
    public class ToolResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Display name of the tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. The matching ID of the tool call the response is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Required. The tool execution result in JSON object format. Use "output" key to specify tool response and
        /// "error" key to specify error details (if any). If "output" and "error" keys are not specified, then whole
        /// "response" is treated as tool execution result.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>
        /// Optional. The name of the tool to execute. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/tools/{tool}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tool")]
        public virtual string Tool { get; set; }

        /// <summary>Optional. The toolset tool that got executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolsetTool")]
        public virtual ToolsetTool ToolsetTool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Execution results for the requested tool calls from the client.</summary>
    public class ToolResponses : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of tool execution results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolResponses")]
        public virtual System.Collections.Generic.IList<ToolResponse> ToolResponsesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A toolset represents a group of dynamically managed tools that can be used by the agent.</summary>
    public class Toolset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A toolset that generates tools from an Integration Connectors Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorToolset")]
        public virtual ConnectorToolset ConnectorToolset { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the toolset was created.</summary>
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

        /// <summary>Optional. The description of the toolset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. The display name of the toolset. Must be unique within the same app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// ETag used to ensure the object hasn't changed during a read-modify-write operation. If the etag is empty,
        /// the update will overwrite any concurrent changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. The execution type of the tools in the toolset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionType")]
        public virtual string ExecutionType { get; set; }

        /// <summary>Optional. A toolset that contains a list of tools that are offered by the MCP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mcpToolset")]
        public virtual McpToolset McpToolset { get; set; }

        /// <summary>
        /// Identifier. The unique identifier of the toolset. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. A toolset that contains a list of tools that are defined by an OpenAPI schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openApiToolset")]
        public virtual OpenApiToolset OpenApiToolset { get; set; }

        /// <summary>Optional. Configuration for tools behavior in fake mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolFakeConfig")]
        public virtual ToolFakeConfig ToolFakeConfig { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the toolset was last updated.</summary>
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

    /// <summary>A tool that is created from a toolset.</summary>
    public class ToolsetTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The tool ID to filter the tools to retrieve the schema for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolId")]
        public virtual string ToolId { get; set; }

        /// <summary>
        /// Required. The resource name of the Toolset from which this tool is derived. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toolset")]
        public virtual string Toolset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rule for transferring to a specific agent.</summary>
    public class TransferRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the child agent the rule applies to. Format:
        /// `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childAgent")]
        public virtual string ChildAgent { get; set; }

        /// <summary>
        /// Optional. A rule that immediately transfers to the target agent when the condition is met.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deterministicTransfer")]
        public virtual TransferRuleDeterministicTransfer DeterministicTransfer { get; set; }

        /// <summary>Required. The direction of the transfer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>Optional. Rule that prevents the planner from transferring to the target agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablePlannerTransfer")]
        public virtual TransferRuleDisablePlannerTransfer DisablePlannerTransfer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deterministic transfer rule. When the condition evaluates to true, the transfer occurs.</summary>
    public class TransferRuleDeterministicTransfer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A rule that evaluates a session state condition. If the condition evaluates to true, the transfer
        /// occurs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressionCondition")]
        public virtual ExpressionCondition ExpressionCondition { get; set; }

        /// <summary>
        /// Optional. A rule that uses Python code block to evaluate the conditions. If the condition evaluates to true,
        /// the transfer occurs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pythonCodeCondition")]
        public virtual PythonCodeCondition PythonCodeCondition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A rule that prevents the planner from transferring to the target agent.</summary>
    public class TransferRuleDisablePlannerTransfer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. If the condition evaluates to true, planner will not be allowed to transfer to the target agent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressionCondition")]
        public virtual ExpressionCondition ExpressionCondition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Action that is taken when a certain precondition is met.</summary>
    public class TriggerAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Respond with a generative answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generativeAnswer")]
        public virtual TriggerActionGenerativeAnswer GenerativeAnswer { get; set; }

        /// <summary>Optional. Immediately respond with a preconfigured response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("respondImmediately")]
        public virtual TriggerActionRespondImmediately RespondImmediately { get; set; }

        /// <summary>Optional. Transfer the conversation to a different agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferAgent")]
        public virtual TriggerActionTransferAgent TransferAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The agent will immediately respond with a generative answer.</summary>
    public class TriggerActionGenerativeAnswer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The prompt to use for the generative answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prompt")]
        public virtual string Prompt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The agent will immediately respond with a preconfigured response.</summary>
    public class TriggerActionRespondImmediately : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The canned responses for the agent to choose from. The response is chosen randomly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<TriggerActionResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a response from the agent.</summary>
    public class TriggerActionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether the response is disabled. Disabled responses are not used by the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Required. Text for the agent to respond with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The agent will transfer the conversation to a different agent.</summary>
    public class TriggerActionTransferAgent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the agent to transfer the conversation to. The agent must be in the same app as the
        /// current agent. Format: `projects/{project}/locations/{location}/apps/{app}/agents/{agent}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agent")]
        public virtual string Agent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single web search query and its associated search uri.</summary>
    public class WebSearchQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The search query text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The URI to the Google Search results page for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a widget tool that the agent can invoke. When the tool is chosen by the agent, agent will return the
    /// widget to the client. The client is responsible for processing the widget and generating the next user query to
    /// continue the interaction with the agent.
    /// </summary>
    public class WidgetTool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The description of the widget tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The display name of the widget tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The input parameters of the widget tool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual Schema Parameters { get; set; }

        /// <summary>
        /// Optional. The type of the widget tool. If not specified, the default type will be CUSTOMIZED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgetType")]
        public virtual string WidgetType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
