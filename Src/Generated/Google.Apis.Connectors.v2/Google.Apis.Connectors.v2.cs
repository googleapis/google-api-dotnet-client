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

namespace Google.Apis.Connectors.v2
{
    /// <summary>The Connectors Service.</summary>
    public class ConnectorsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ConnectorsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ConnectorsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://connectors.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://connectors.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "connectors";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Connectors API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Connectors API.</summary>
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

    /// <summary>A base abstract class for Connectors requests.</summary>
    public abstract class ConnectorsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ConnectorsBaseServiceRequest instance.</summary>
        protected ConnectorsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Connectors parameter list.</summary>
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
                Connections = new ConnectionsResource(service);
            }

            /// <summary>Gets the Connections resource.</summary>
            public virtual ConnectionsResource Connections { get; }

            /// <summary>The "connections" collection of methods.</summary>
            public class ConnectionsResource
            {
                private const string Resource = "connections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConnectionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Actions = new ActionsResource(service);
                    EntityTypes = new EntityTypesResource(service);
                }

                /// <summary>Gets the Actions resource.</summary>
                public virtual ActionsResource Actions { get; }

                /// <summary>The "actions" collection of methods.</summary>
                public class ActionsResource
                {
                    private const string Resource = "actions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ActionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Executes an action with the name specified in the request. The input parameters for executing
                    /// the action are passed through the body of the ExecuteAction request.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Resource name of the Action. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}/actions/{action}
                    /// </param>
                    public virtual ExecuteRequest Execute(Google.Apis.Connectors.v2.Data.ExecuteActionRequest body, string name)
                    {
                        return new ExecuteRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Executes an action with the name specified in the request. The input parameters for executing
                    /// the action are passed through the body of the ExecuteAction request.
                    /// </summary>
                    public class ExecuteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.ExecuteActionResponse>
                    {
                        /// <summary>Constructs a new Execute request.</summary>
                        public ExecuteRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v2.Data.ExecuteActionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the Action. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/actions/{action}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v2.Data.ExecuteActionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "execute";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+name}:execute";

                        /// <summary>Initializes Execute parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/actions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the schema of the given action.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the Action. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}/actions/{action}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets the schema of the given action.</summary>
                    public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.Action>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the Action. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/actions/{action}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Specified view of the action schema.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Specified view of the action schema.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>VIEW_UNSPECIFIED. The unset value. Defaults to BASIC View.</summary>
                            [Google.Apis.Util.StringValueAttribute("ACTION_SCHEMA_VIEW_UNSPECIFIED")]
                            ACTIONSCHEMAVIEWUNSPECIFIED = 0,

                            /// <summary>Return basic action schema.</summary>
                            [Google.Apis.Util.StringValueAttribute("ACTION_SCHEMA_VIEW_BASIC")]
                            ACTIONSCHEMAVIEWBASIC = 1,

                            /// <summary>Return enriched action schema.</summary>
                            [Google.Apis.Util.StringValueAttribute("ACTION_SCHEMA_VIEW_ENRICHED")]
                            ACTIONSCHEMAVIEWENRICHED = 2,
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/actions/[^/]+$",
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

                    /// <summary>Gets the schema of all the actions supported by the connector.</summary>
                    /// <param name="parent">
                    /// Required. Parent resource name of the Action. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Gets the schema of all the actions supported by the connector.</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.ListActionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource name of the Action. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Number of Actions to return. Defaults to 25.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Page token, return from a previous ListActions call, that can be used retrieve the next page
                        /// of content. If unspecified, the request returns the first page of actions.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Specifies which fields of the Action are returned in the response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Specifies which fields of the Action are returned in the response.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>VIEW_UNSPECIFIED. The unset value Defaults to FULL View.</summary>
                            [Google.Apis.Util.StringValueAttribute("ACTION_VIEW_UNSPECIFIED")]
                            ACTIONVIEWUNSPECIFIED = 0,

                            /// <summary>Return only action names.</summary>
                            [Google.Apis.Util.StringValueAttribute("ACTION_VIEW_BASIC")]
                            ACTIONVIEWBASIC = 1,

                            /// <summary>Return actions with schema.</summary>
                            [Google.Apis.Util.StringValueAttribute("ACTION_VIEW_FULL")]
                            ACTIONVIEWFULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/actions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
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

                /// <summary>Gets the EntityTypes resource.</summary>
                public virtual EntityTypesResource EntityTypes { get; }

                /// <summary>The "entityTypes" collection of methods.</summary>
                public class EntityTypesResource
                {
                    private const string Resource = "entityTypes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EntityTypesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Entities = new EntitiesResource(service);
                    }

                    /// <summary>Gets the Entities resource.</summary>
                    public virtual EntitiesResource Entities { get; }

                    /// <summary>The "entities" collection of methods.</summary>
                    public class EntitiesResource
                    {
                        private const string Resource = "entities";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public EntitiesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Creates a new entity row of the specified entity type in the external system. The field
                        /// values for creating the row are contained in the body of the request. The response message
                        /// contains a `Entity` message object returned as a response by the external system.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. Resource name of the Entity Type. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.Connectors.v2.Data.Entity body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Creates a new entity row of the specified entity type in the external system. The field
                        /// values for creating the row are contained in the body of the request. The response message
                        /// contains a `Entity` message object returned as a response by the external system.
                        /// </summary>
                        public class CreateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.Entity>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v2.Data.Entity body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Resource name of the Entity Type. Format:
                            /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Connectors.v2.Data.Entity Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+parent}/entities";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/entityTypes/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes an existing entity row matching the entity type and entity id specified in the
                        /// request.
                        /// </summary>
                        /// <param name="name">
                        /// Required. Resource name of the Entity Type. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}/entities/{id}
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(this.service, name);
                        }

                        /// <summary>
                        /// Deletes an existing entity row matching the entity type and entity id specified in the
                        /// request.
                        /// </summary>
                        public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Resource name of the Entity Type. Format:
                            /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}/entities/{id}
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/entityTypes/[^/]+/entities/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes entities based on conditions specified in the request and not on entity id.
                        /// </summary>
                        /// <param name="entityType">
                        /// Required. Resource name of the Entity Type. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}
                        /// </param>
                        public virtual DeleteEntitiesWithConditionsRequest DeleteEntitiesWithConditions(string entityType)
                        {
                            return new DeleteEntitiesWithConditionsRequest(this.service, entityType);
                        }

                        /// <summary>
                        /// Deletes entities based on conditions specified in the request and not on entity id.
                        /// </summary>
                        public class DeleteEntitiesWithConditionsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.Empty>
                        {
                            /// <summary>Constructs a new DeleteEntitiesWithConditions request.</summary>
                            public DeleteEntitiesWithConditionsRequest(Google.Apis.Services.IClientService service, string entityType) : base(service)
                            {
                                EntityType = entityType;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Resource name of the Entity Type. Format:
                            /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("entityType", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string EntityType { get; private set; }

                            /// <summary>
                            /// Required. Conditions to be used when deleting entities. From a proto standpoint, There
                            /// are no restrictions on what can be passed using this field. The connector documentation
                            /// should have information about what format of filters/conditions are supported. Note: If
                            /// this conditions field is left empty, an exception is thrown. We don't want to consider
                            /// 'empty conditions' to be a match-all case. Connector developers can determine and
                            /// document what a match-all case constraint would be.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("conditions", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Conditions { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "deleteEntitiesWithConditions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+entityType}/entities:deleteEntitiesWithConditions";

                            /// <summary>Initializes DeleteEntitiesWithConditions parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("entityType", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "entityType",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/entityTypes/[^/]+$",
                                });
                                RequestParameters.Add("conditions", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "conditions",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Gets a single entity row matching the entity type and entity id specified in the request.
                        /// </summary>
                        /// <param name="name">
                        /// Required. Resource name of the Entity Type. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}/entities/{id}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>
                        /// Gets a single entity row matching the entity type and entity id specified in the request.
                        /// </summary>
                        public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.Entity>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Resource name of the Entity Type. Format:
                            /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}/entities/{id}
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/entityTypes/[^/]+/entities/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists entity rows of a particular entity type contained in the request. Note: 1. Currently,
                        /// only max of one 'sort_by' column is supported. 2. If no 'sort_by' column is provided, the
                        /// primary key of the table is used. If zero or more than one primary key is available, we
                        /// default to the unpaginated list entities logic which only returns the first page. 3. The
                        /// values of the 'sort_by' columns must uniquely identify an entity row, otherwise undefined
                        /// behaviors may be observed during pagination. 4. Since transactions are not supported, any
                        /// updates, inserts or deletes during pagination can lead to stale data being returned or other
                        /// unexpected behaviors.
                        /// </summary>
                        /// <param name="parent">
                        /// Required. Resource name of the Entity Type. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>
                        /// Lists entity rows of a particular entity type contained in the request. Note: 1. Currently,
                        /// only max of one 'sort_by' column is supported. 2. If no 'sort_by' column is provided, the
                        /// primary key of the table is used. If zero or more than one primary key is available, we
                        /// default to the unpaginated list entities logic which only returns the first page. 3. The
                        /// values of the 'sort_by' columns must uniquely identify an entity row, otherwise undefined
                        /// behaviors may be observed during pagination. 4. Since transactions are not supported, any
                        /// updates, inserts or deletes during pagination can lead to stale data being returned or other
                        /// unexpected behaviors.
                        /// </summary>
                        public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.ListEntitiesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Resource name of the Entity Type. Format:
                            /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Conditions to be used when listing entities. From a proto standpoint, There are no
                            /// restrictions on what can be passed using this field. The connector documentation should
                            /// have information about what format of filters/conditions are supported.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("conditions", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Conditions { get; set; }

                            /// <summary>
                            /// Number of entity rows to return. Defaults page size = 25. Max page size = 200.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>Page token value if available from a previous request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>List of 'sort_by' columns to use when returning the results.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("sortBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual Google.Apis.Util.Repeatable<string> SortBy { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+parent}/entities";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/entityTypes/[^/]+$",
                                });
                                RequestParameters.Add("conditions", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "conditions",
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
                                RequestParameters.Add("sortBy", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "sortBy",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Updates an existing entity row matching the entity type and entity id specified in the
                        /// request. The fields in the entity row that need to be modified are contained in the body of
                        /// the request. All unspecified fields are left unchanged. The response message contains a
                        /// `Entity` message object returned as a response by the external system.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Output only. Resource name of the Entity. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}/entities/{id}
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.Connectors.v2.Data.Entity body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Updates an existing entity row matching the entity type and entity id specified in the
                        /// request. The fields in the entity row that need to be modified are contained in the body of
                        /// the request. All unspecified fields are left unchanged. The response message contains a
                        /// `Entity` message object returned as a response by the external system.
                        /// </summary>
                        public class PatchRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.Entity>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v2.Data.Entity body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Output only. Resource name of the Entity. Format:
                            /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}/entities/{id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Connectors.v2.Data.Entity Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/entityTypes/[^/]+/entities/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Updates entities based on conditions specified in the request and not on entity id.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="entityType">
                        /// Required. Resource name of the Entity Type. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}
                        /// </param>
                        public virtual UpdateEntitiesWithConditionsRequest UpdateEntitiesWithConditions(Google.Apis.Connectors.v2.Data.Entity body, string entityType)
                        {
                            return new UpdateEntitiesWithConditionsRequest(this.service, body, entityType);
                        }

                        /// <summary>
                        /// Updates entities based on conditions specified in the request and not on entity id.
                        /// </summary>
                        public class UpdateEntitiesWithConditionsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.UpdateEntitiesWithConditionsResponse>
                        {
                            /// <summary>Constructs a new UpdateEntitiesWithConditions request.</summary>
                            public UpdateEntitiesWithConditionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v2.Data.Entity body, string entityType) : base(service)
                            {
                                EntityType = entityType;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Resource name of the Entity Type. Format:
                            /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("entityType", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string EntityType { get; private set; }

                            /// <summary>
                            /// Required. Conditions to be used when updating entities. From a proto standpoint, There
                            /// are no restrictions on what can be passed using this field. The connector documentation
                            /// should have information about what format of filters/conditions are supported. Note: If
                            /// this conditions field is left empty, an exception is thrown. We don't want to consider
                            /// 'empty conditions' to be a match-all case. Connector developers can determine and
                            /// document what a match-all case constraint would be.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("conditions", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Conditions { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Connectors.v2.Data.Entity Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "updateEntitiesWithConditions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v2/{+entityType}/entities:updateEntitiesWithConditions";

                            /// <summary>Initializes UpdateEntitiesWithConditions parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("entityType", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "entityType",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/entityTypes/[^/]+$",
                                });
                                RequestParameters.Add("conditions", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "conditions",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>Gets metadata of given entity type</summary>
                    /// <param name="name">
                    /// Required. Resource name of the Entity Type. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{entityType}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets metadata of given entity type</summary>
                    public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.EntityType>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the Entity Type. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{entityType}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Specifies view for entity type schema.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Specifies view for entity type schema.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>VIEW_UNSPECIFIED. The unset value. Defaults to BASIC View.</summary>
                            [Google.Apis.Util.StringValueAttribute("ENTITY_TYPE_SCHEMA_VIEW_UNSPECIFIED")]
                            ENTITYTYPESCHEMAVIEWUNSPECIFIED = 0,

                            /// <summary>Return basic entity type schema.</summary>
                            [Google.Apis.Util.StringValueAttribute("ENTITY_TYPE_SCHEMA_VIEW_BASIC")]
                            ENTITYTYPESCHEMAVIEWBASIC = 1,

                            /// <summary>Return enriched entity types schema.</summary>
                            [Google.Apis.Util.StringValueAttribute("ENTITY_TYPE_SCHEMA_VIEW_ENRICHED")]
                            ENTITYTYPESCHEMAVIEWENRICHED = 2,
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/entityTypes/[^/]+$",
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

                    /// <summary>Lists metadata related to all entity types present in the external system.</summary>
                    /// <param name="parent">
                    /// Required. Resource name of the Entity Type. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists metadata related to all entity types present in the external system.</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.ListEntityTypesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the Entity Type. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Number of entity types to return. Defaults to 25.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Page token, return from a previous ListEntityTypes call, that can be used retrieve the next
                        /// page of content. If unspecified, the request returns the first page of entity types.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Specifies which fields of the Entity Type are returned in the response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Specifies which fields of the Entity Type are returned in the response.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>VIEW_UNSPECIFIED. The unset value. Defaults to FULL View.</summary>
                            [Google.Apis.Util.StringValueAttribute("ENTITY_TYPE_VIEW_UNSPECIFIED")]
                            ENTITYTYPEVIEWUNSPECIFIED = 0,

                            /// <summary>Return only entity type names.</summary>
                            [Google.Apis.Util.StringValueAttribute("ENTITY_TYPE_VIEW_BASIC")]
                            ENTITYTYPEVIEWBASIC = 1,

                            /// <summary>Return entity types with schema</summary>
                            [Google.Apis.Util.StringValueAttribute("ENTITY_TYPE_VIEW_FULL")]
                            ENTITYTYPEVIEWFULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v2/{+parent}/entityTypes";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
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
                /// Reports readiness status of the connector. Similar logic to GetStatus but modified for kubernetes
                /// health check to understand.
                /// </summary>
                /// <param name="name"><c>null</c></param>
                public virtual CheckReadinessRequest CheckReadiness(string name)
                {
                    return new CheckReadinessRequest(this.service, name);
                }

                /// <summary>
                /// Reports readiness status of the connector. Similar logic to GetStatus but modified for kubernetes
                /// health check to understand.
                /// </summary>
                public class CheckReadinessRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.CheckReadinessResponse>
                {
                    /// <summary>Constructs a new CheckReadiness request.</summary>
                    public CheckReadinessRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "checkReadiness";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:checkReadiness";

                    /// <summary>Initializes CheckReadiness parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Reports the status of the connection. Note that when the connection is in a state that is not
                /// ACTIVE, the implementation of this RPC method must return a Status with the corresponding State
                /// instead of returning a gRPC status code that is not "OK", which indicates that ConnectionStatus
                /// itself, not the connection, failed.
                /// </summary>
                /// <param name="name"><c>null</c></param>
                public virtual CheckStatusRequest CheckStatus(string name)
                {
                    return new CheckStatusRequest(this.service, name);
                }

                /// <summary>
                /// Reports the status of the connection. Note that when the connection is in a state that is not
                /// ACTIVE, the implementation of this RPC method must return a Status with the corresponding State
                /// instead of returning a gRPC status code that is not "OK", which indicates that ConnectionStatus
                /// itself, not the connection, failed.
                /// </summary>
                public class CheckStatusRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.CheckStatusResponse>
                {
                    /// <summary>Constructs a new CheckStatus request.</summary>
                    public CheckStatusRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "checkStatus";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:checkStatus";

                    /// <summary>Initializes CheckStatus parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// ExchangeAuthCode exchanges the OAuth authorization code (and other necessary data) for an access
                /// token (and associated credentials).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name"><c>null</c></param>
                public virtual ExchangeAuthCodeRequest ExchangeAuthCode(Google.Apis.Connectors.v2.Data.ExchangeAuthCodeRequest body, string name)
                {
                    return new ExchangeAuthCodeRequest(this.service, body, name);
                }

                /// <summary>
                /// ExchangeAuthCode exchanges the OAuth authorization code (and other necessary data) for an access
                /// token (and associated credentials).
                /// </summary>
                public class ExchangeAuthCodeRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.ExchangeAuthCodeResponse>
                {
                    /// <summary>Constructs a new ExchangeAuthCode request.</summary>
                    public ExchangeAuthCodeRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v2.Data.ExchangeAuthCodeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v2.Data.ExchangeAuthCodeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "exchangeAuthCode";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:exchangeAuthCode";

                    /// <summary>Initializes ExchangeAuthCode parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Executes a SQL statement specified in the body of the request. An example of this SQL statement in
                /// the case of Salesforce connector would be 'select * from Account a, Order o where a.Id =
                /// o.AccountId'.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="connection">
                /// Required. Resource name of the Connection. Format:
                /// projects/{project}/locations/{location}/connections/{connection}
                /// </param>
                public virtual ExecuteSqlQueryRequest ExecuteSqlQuery(Google.Apis.Connectors.v2.Data.ExecuteSqlQueryRequest body, string connection)
                {
                    return new ExecuteSqlQueryRequest(this.service, body, connection);
                }

                /// <summary>
                /// Executes a SQL statement specified in the body of the request. An example of this SQL statement in
                /// the case of Salesforce connector would be 'select * from Account a, Order o where a.Id =
                /// o.AccountId'.
                /// </summary>
                public class ExecuteSqlQueryRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.ExecuteSqlQueryResponse>
                {
                    /// <summary>Constructs a new ExecuteSqlQuery request.</summary>
                    public ExecuteSqlQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v2.Data.ExecuteSqlQueryRequest body, string connection) : base(service)
                    {
                        Connection = connection;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the Connection. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connection", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Connection { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v2.Data.ExecuteSqlQueryRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "executeSqlQuery";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+connection}:executeSqlQuery";

                    /// <summary>Initializes ExecuteSqlQuery parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("connection", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connection",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// RefreshAccessToken exchanges the OAuth refresh token (and other necessary data) for a new access
                /// token (and new associated credentials).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name"><c>null</c></param>
                public virtual RefreshAccessTokenRequest RefreshAccessToken(Google.Apis.Connectors.v2.Data.RefreshAccessTokenRequest body, string name)
                {
                    return new RefreshAccessTokenRequest(this.service, body, name);
                }

                /// <summary>
                /// RefreshAccessToken exchanges the OAuth refresh token (and other necessary data) for a new access
                /// token (and new associated credentials).
                /// </summary>
                public class RefreshAccessTokenRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v2.Data.RefreshAccessTokenResponse>
                {
                    /// <summary>Constructs a new RefreshAccessToken request.</summary>
                    public RefreshAccessTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v2.Data.RefreshAccessTokenRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v2.Data.RefreshAccessTokenRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "refreshAccessToken";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:refreshAccessToken";

                    /// <summary>Initializes RefreshAccessToken parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.Connectors.v2.Data
{
    /// <summary>
    /// AccessCredentials includes the OAuth access token, and the other fields returned along with it.
    /// </summary>
    public class AccessCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OAuth access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual string AccessToken { get; set; }

        /// <summary>Duration till the access token expires.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiresIn")]
        public virtual object ExpiresIn { get; set; }

        /// <summary>OAuth refresh token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshToken")]
        public virtual string RefreshToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Action message contains metadata information about a single action present in the external system.
    /// </summary>
    public class Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Brief Description of action</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display Name of action to be shown on client side</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>JsonSchema representation of this actions's input schema</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputJsonSchema")]
        public virtual JsonSchema InputJsonSchema { get; set; }

        /// <summary>List containing input parameter metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputParameters")]
        public virtual System.Collections.Generic.IList<InputParameter> InputParameters { get; set; }

        /// <summary>Name of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>JsonSchema representation of this actions's result schema</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultJsonSchema")]
        public virtual JsonSchema ResultJsonSchema { get; set; }

        /// <summary>List containing the metadata of result fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultMetadata")]
        public virtual System.Collections.Generic.IList<ResultMetadata> ResultMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AuthCodeData contains the data the runtime plane will give the connector backend in exchange for access and
    /// refresh tokens.
    /// </summary>
    public class AuthCodeData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OAuth authorization code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authCode")]
        public virtual string AuthCode { get; set; }

        /// <summary>OAuth PKCE verifier, needed if PKCE is enabled for this particular connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkceVerifier")]
        public virtual string PkceVerifier { get; set; }

        /// <summary>OAuth redirect URI passed in during the auth code flow, required by some OAuth backends.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>Scopes the connection will request when the user performs the auth code flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing status of the connector for readiness prober.</summary>
    public class CheckReadinessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of the connector.</summary>
    public class CheckStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When the connector is not in ACTIVE state, the description must be populated to specify the reason why it's
        /// not in ACTIVE state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>State of the connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time window specified for daily operations.</summary>
    public class DailyCycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Duration of the time window, set by service producer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Time within the day to start the operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DenyMaintenancePeriod definition. Maintenance is forbidden within the deny period. The start_date must be less
    /// than the end_date.
    /// </summary>
    public class DenyMaintenancePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Deny period end date. This can be: * A full date, with non-zero year, month and day values. * A month and
        /// day value, with a zero year. Allows recurring deny periods each year. Date matching this period will have to
        /// be before the end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// Deny period start date. This can be: * A full date, with non-zero year, month and day values. * A month and
        /// day value, with a zero year. Allows recurring deny periods each year. Date matching this period will have to
        /// be the same or after the start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>
        /// Time in UTC when the Blackout period starts on start_date and ends on end_date. This can be: * Full time. *
        /// All zeros for 00:00:00 UTC
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual TimeOfDay Time { get; set; }

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

    /// <summary>'Entity row'/ 'Entity' refers to a single row of an entity type.</summary>
    public class Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Fields of the entity. The key is name of the field and the value contains the applicable
        /// `google.protobuf.Value` entry for this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, object> Fields { get; set; }

        /// <summary>
        /// Output only. Resource name of the Entity. Format:
        /// projects/{project}/locations/{location}/connections/{connection}/entityTypes/{type}/entities/{id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EntityType message contains metadata information about a single entity type present in the external system.
    /// </summary>
    public class EntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List containing metadata information about each field of the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<Field> Fields { get; set; }

        /// <summary>JsonSchema representation of this entity's schema</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonSchema JsonSchema { get; set; }

        /// <summary>The name of the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<string> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExchangeAuthCodeRequest currently includes the auth code data.</summary>
    public class ExchangeAuthCodeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. AuthCodeData contains the data the runtime requires to exchange for access and refresh tokens. If
        /// the data is not provided, the runtime will read the data from the secret manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authCodeData")]
        public virtual AuthCodeData AuthCodeData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExchangeAuthCodeResponse includes the returned access token and its associated credentials.</summary>
    public class ExchangeAuthCodeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accessCredentials")]
        public virtual AccessCredentials AccessCredentials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ActionService.ExecuteAction</summary>
    public class ExecuteActionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Parameters for executing the action. The parameters can be key/value pairs or nested structs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, object> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ActionService.ExecuteAction</summary>
    public class ExecuteActionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// In the case of successful invocation of the specified action, the results Struct contains values based on
        /// the response of the action invoked. 1. If the action execution produces any entities as a result, they are
        /// returned as an array of Structs with the 'key' being the field name and the 'value' being the value of that
        /// field in each result row. { 'results': [{'key': 'value'}, ...] }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An execute sql query request containing the query and the connection to execute it on.</summary>
    public class ExecuteSqlQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. SQL statement passed by clients like Integration Platform, the query is passed as-is to the driver
        /// used for interfacing with external systems.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual Query Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response returned by the connection after executing the sql query.</summary>
    public class ExecuteSqlQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// In the case of successful execution of the query the response contains results returned by the external
        /// system. For example, the result rows of the query are contained in the 'results' Struct list - "results": [
        /// { "field1": "val1", "field2": "val2",.. },.. ] Each Struct row can contain fields any type of like nested
        /// Structs or lists.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message contains EntityType's Field metadata.</summary>
    public class Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The following map contains fields that are not explicitly mentioned above,this give connectors the
        /// flexibility to add new metadata fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalDetails")]
        public virtual System.Collections.Generic.IDictionary<string, object> AdditionalDetails { get; set; }

        /// <summary>The data type of the Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// The following field specifies the default value of the Field provided by the external system if a value is
        /// not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual object DefaultValue { get; set; }

        /// <summary>A brief description of the Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>JsonSchema of the field, applicable only if field is of type `STRUCT`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonSchema JsonSchema { get; set; }

        /// <summary>
        /// The following boolean field specifies if the current Field acts as a primary key or id if the parent is of
        /// type entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual System.Nullable<bool> Key { get; set; }

        /// <summary>Name of the Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Specifies whether a null value is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>
        /// Reference captures the association between two different entity types. Value links to the reference of
        /// another entity type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reference")]
        public virtual Reference Reference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Input Parameter message contains metadata about the parameters required for executing an Action.
    /// </summary>
    public class InputParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The following map contains fields that are not explicitly mentioned above,this give connectors the
        /// flexibility to add new metadata fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalDetails")]
        public virtual System.Collections.Generic.IDictionary<string, object> AdditionalDetails { get; set; }

        /// <summary>The data type of the Parameter</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// The following field specifies the default value of the Parameter provided by the external system if a value
        /// is not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual object DefaultValue { get; set; }

        /// <summary>A brief description of the Parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>JsonSchema of the parameter, applicable only if parameter is of type `STRUCT`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonSchema JsonSchema { get; set; }

        /// <summary>Name of the Parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Specifies whether a null value is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Instance represents the interface for SLM services to actuate the state of control plane resources. Example
    /// Instance in JSON, where consumer-project-number=123456, producer-project-id=cloud-sql:
    /// ```
    /// json Instance: {
    /// "name": "projects/123456/locations/us-east1/instances/prod-instance", "create_time": { "seconds": 1526406431, },
    /// "labels": { "env": "prod", "foo": "bar" }, "state": READY, "software_versions": { "software_update":
    /// "cloud-sql-09-28-2018", }, "maintenance_policy_names": { "UpdatePolicy":
    /// "projects/123456/locations/us-east1/maintenancePolicies/prod-update-policy", } "tenant_project_id":
    /// "cloud-sql-test-tenant", "producer_metadata": { "cloud-sql-tier": "basic", "cloud-sql-instance-size": "1G", },
    /// "provisioned_resources": [ { "resource-type": "compute-instance", "resource-url":
    /// "https://www.googleapis.com/compute/v1/projects/cloud-sql/zones/us-east1-b/instances/vm-1", } ],
    /// "maintenance_schedules": { "csa_rollout": { "start_time": { "seconds": 1526406431, }, "end_time": { "seconds":
    /// 1535406431, }, }, "ncsa_rollout": { "start_time": { "seconds": 1526406431, }, "end_time": { "seconds":
    /// 1535406431, }, } }, "consumer_defined_name": "my-sql-instance1", }
    /// ```
    /// LINT.IfChange
    /// </summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// consumer_defined_name is the name of the instance set by the service consumers. Generally this is different
        /// from the `name` field which reperesents the system-assigned id of the instance which the service consumers
        /// do not recognize. This is a required field for tenants onboarding to Maintenance Window notifications
        /// (go/slm-rollout-maintenance-policies#prerequisites).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerDefinedName")]
        public virtual string ConsumerDefinedName { get; set; }

        /// <summary>
        /// Optional. The consumer_project_number associated with this Apigee instance. This field is added specifically
        /// to support Apigee integration with SLM Rollout and UMM. It represents the numerical project ID of the GCP
        /// project that consumes this Apigee instance. It is used for SLM rollout notifications and UMM integration,
        /// enabling proper mapping to customer projects and log delivery for Apigee instances. This field complements
        /// consumer_project_id and may be used for specific Apigee scenarios where the numerical ID is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerProjectNumber")]
        public virtual string ConsumerProjectNumber { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the resource was created.</summary>
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
        /// Optional. The instance_type of this instance of format:
        /// projects/{project_number}/locations/{location_id}/instanceTypes/{instance_type_id}. Instance Type represents
        /// a high-level tier or SKU of the service that this instance belong to. When enabled(eg: Maintenance Rollout),
        /// Rollout uses 'instance_type' along with 'software_versions' to determine whether instance needs an update or
        /// not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. Each label is a key-value pair, where both
        /// the key and the value are arbitrary strings provided by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Optional. The MaintenancePolicies that have been attached to the instance. The key must be of the type name
        /// of the oneof policy name defined in MaintenancePolicy, and the referenced policy must define the same policy
        /// type. For details, please refer to go/mr-user-guide. Should not be set if
        /// maintenance_settings.maintenance_policies is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicyNames")]
        public virtual System.Collections.Generic.IDictionary<string, string> MaintenancePolicyNames { get; set; }

        /// <summary>
        /// The MaintenanceSchedule contains the scheduling information of published maintenance schedule with same key
        /// as software_versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSchedules")]
        public virtual System.Collections.Generic.IDictionary<string, MaintenanceSchedule> MaintenanceSchedules { get; set; }

        /// <summary>Optional. The MaintenanceSettings associated with instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSettings")]
        public virtual MaintenanceSettings MaintenanceSettings { get; set; }

        /// <summary>
        /// Unique name of the resource. It uses the form:
        /// `projects/{project_number}/locations/{location_id}/instances/{instance_id}` Note: This name is passed,
        /// stored and logged across the rollout system. So use of consumer project_id or any other consumer PII in the
        /// name is strongly discouraged for wipeout (go/wipeout) compliance. See
        /// go/elysium/project_ids#storage-guidance for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. notification_parameter are information that service producers may like to include that is not
        /// relevant to Rollout. This parameter will only be passed to Gamma and Cloud Logging for notification/logging
        /// purpose.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationParameters")]
        public virtual System.Collections.Generic.IDictionary<string, NotificationParameter> NotificationParameters { get; set; }

        /// <summary>
        /// Output only. Custom string attributes used primarily to expose producer-specific information in monitoring
        /// dashboards. See go/get-instance-metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> ProducerMetadata { get; set; }

        /// <summary>
        /// Output only. The list of data plane resources provisioned for this instance, e.g. compute VMs. See
        /// go/get-instance-metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedResources")]
        public virtual System.Collections.Generic.IList<ProvisionedResource> ProvisionedResources { get; set; }

        /// <summary>
        /// Link to the SLM instance template. Only populated when updating SLM instances via SSA's Actuation service
        /// adaptor. Service producers with custom control plane (e.g. Cloud SQL) doesn't need to populate this field.
        /// Instead they should use software_versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slmInstanceTemplate")]
        public virtual string SlmInstanceTemplate { get; set; }

        /// <summary>
        /// Output only. SLO metadata for instance classification in the Standardized dataplane SLO platform. See
        /// go/cloud-ssa-standard-slo for feature description.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sloMetadata")]
        public virtual SloMetadata SloMetadata { get; set; }

        /// <summary>
        /// Software versions that are used to deploy this instance. This can be mutated by rollout services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareVersions")]
        public virtual System.Collections.Generic.IDictionary<string, string> SoftwareVersions { get; set; }

        /// <summary>
        /// Output only. Current lifecycle state of the resource (e.g. if it's being created or ready to use).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. ID of the associated GCP tenant project. See go/get-instance-metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectId")]
        public virtual string TenantProjectId { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the resource was last modified.</summary>
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

    /// <summary>JsonSchema representation of schema metadata</summary>
    public class JsonSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional details apart from standard json schema fields, this gives flexibility to store metadata about
        /// the schema
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalDetails")]
        public virtual System.Collections.Generic.IDictionary<string, object> AdditionalDetails { get; set; }

        /// <summary>The default value of the field or object described by this schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual object Default__ { get; set; }

        /// <summary>A description of this schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Possible values for an enumeration. This works in conjunction with `type` to represent types with a fixed
        /// set of legal values
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enum")]
        public virtual System.Collections.Generic.IList<object> Enum__ { get; set; }

        /// <summary>
        /// Format of the value as per https://json-schema.org/understanding-json-schema/reference/string.html#format
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Schema that applies to array values, applicable only if this is of type `array`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual JsonSchema Items { get; set; }

        /// <summary>JDBC datatype of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jdbcType")]
        public virtual string JdbcType { get; set; }

        /// <summary>
        /// The child schemas, applicable only if this is of type `object`. The key is the name of the property and the
        /// value is the json schema that describes that property
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, JsonSchema> Properties { get; set; }

        /// <summary>Whether this property is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Collections.Generic.IList<string> Required { get; set; }

        /// <summary>JSON Schema Validation: A Vocabulary for Structural Validation of JSON</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Collections.Generic.IList<string> Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ActionService.ListActions</summary>
    public class ListActionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of action metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<Action> Actions { get; set; }

        /// <summary>Next page token if more actions available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// List of actions which contain unsupported Datatypes. Check datatype.proto for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsupportedActionNames")]
        public virtual System.Collections.Generic.IList<string> UnsupportedActionNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for EntityService.ListEntities</summary>
    public class ListEntitiesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List containing entity rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<Entity> Entities { get; set; }

        /// <summary>Next page token if more records are available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for EntityService.ListEntityTypes</summary>
    public class ListEntityTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token if more entity types available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of metadata related to all entity types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<EntityType> Types { get; set; }

        /// <summary>
        /// List of entity type names which contain unsupported Datatypes. Check datatype.proto for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsupportedTypeNames")]
        public virtual System.Collections.Generic.IList<string> UnsupportedTypeNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines policies to service maintenance events.</summary>
    public class MaintenancePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the resource was created.</summary>
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
        /// Optional. Description of what this policy is for. Create/Update methods return INVALID_ARGUMENT if the
        /// length is greater than 512.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user provided metadata. Each label is a key-value pair, where both
        /// the key and the value are arbitrary strings provided by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. MaintenancePolicy name using the form:
        /// `projects/{project_id}/locations/{location_id}/maintenancePolicies/{maintenance_policy_id}` where
        /// {project_id} refers to a GCP consumer project ID, {location_id} refers to a GCP region/zone,
        /// {maintenance_policy_id} must be 1-63 characters long and match the regular expression
        /// `[a-z0-9]([-a-z0-9]*[a-z0-9])?`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The state of the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Maintenance policy applicable to instance update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatePolicy")]
        public virtual UpdatePolicy UpdatePolicy { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time when the resource was updated.</summary>
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

    /// <summary>
    /// Maintenance schedule which is exposed to customer and potentially end user, indicating published upcoming future
    /// maintenance schedule
    /// </summary>
    public class MaintenanceSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field is deprecated, and will be always set to true since reschedule can happen multiple times now.
        /// This field should not be removed until all service producers remove this for their customers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReschedule")]
        public virtual System.Nullable<bool> CanReschedule { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The scheduled end time for the maintenance.</summary>
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
        /// The rollout management policy this maintenance schedule is associated with. When doing reschedule update
        /// request, the reschedule should be against this given policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutManagementPolicy")]
        public virtual string RolloutManagementPolicy { get; set; }

        private string _scheduleDeadlineTimeRaw;

        private object _scheduleDeadlineTime;

        /// <summary>
        /// schedule_deadline_time is the time deadline any schedule start time cannot go beyond, including reschedule.
        /// It's normally the initial schedule start time plus maintenance window length (1 day or 1 week). Maintenance
        /// cannot be scheduled to start beyond this deadline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleDeadlineTime")]
        public virtual string ScheduleDeadlineTimeRaw
        {
            get => _scheduleDeadlineTimeRaw;
            set
            {
                _scheduleDeadlineTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _scheduleDeadlineTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ScheduleDeadlineTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ScheduleDeadlineTimeDateTimeOffset instead.")]
        public virtual object ScheduleDeadlineTime
        {
            get => _scheduleDeadlineTime;
            set
            {
                _scheduleDeadlineTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _scheduleDeadlineTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ScheduleDeadlineTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ScheduleDeadlineTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ScheduleDeadlineTimeRaw);
            set => ScheduleDeadlineTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The scheduled start time for the maintenance.</summary>
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
    /// Maintenance settings associated with instance. Allows service producers and end users to assign settings that
    /// controls maintenance on this instance.
    /// </summary>
    public class MaintenanceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Exclude instance from maintenance. When true, rollout service will not attempt maintenance on the
        /// instance. Rollout service will include the instance in reported rollout progress as not attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclude")]
        public virtual System.Nullable<bool> Exclude { get; set; }

        /// <summary>Optional. If the update call is triggered from rollback, set the value as true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRollback")]
        public virtual System.Nullable<bool> IsRollback { get; set; }

        /// <summary>
        /// Optional. The MaintenancePolicies that have been attached to the instance. The key must be of the type name
        /// of the oneof policy name defined in MaintenancePolicy, and the embedded policy must define the same policy
        /// type. For details, please refer to go/mr-user-guide. Should not be set if maintenance_policy_names is set.
        /// If only the name is needed, then only populate MaintenancePolicy.name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicies")]
        public virtual System.Collections.Generic.IDictionary<string, MaintenancePolicy> MaintenancePolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MaintenanceWindow definition.</summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Daily cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyCycle")]
        public virtual DailyCycle DailyCycle { get; set; }

        /// <summary>Weekly cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklyCycle")]
        public virtual WeeklyCycle WeeklyCycle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Node information for custom per-node SLO implementations. SSA does not support per-node SLO, but producers can
    /// populate per-node information in SloMetadata for custom precomputations. SSA Eligibility Exporter will emit
    /// per-node metric based on this information.
    /// </summary>
    public class NodeSloMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The location of the node, if different from instance location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The id of the node. This should be equal to SaasInstanceNode.node_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeId")]
        public virtual string NodeId { get; set; }

        /// <summary>
        /// If present, this will override eligibility for the node coming from instance or exclusions for specified
        /// SLIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perSliEligibility")]
        public virtual PerSliSloEligibility PerSliEligibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains notification related data.</summary>
    public class NotificationParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Array of string values. e.g. instance's replica information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>PerSliSloEligibility is a mapping from an SLI name to eligibility.</summary>
    public class PerSliSloEligibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An entry in the eligibilities map specifies an eligibility for a particular SLI for the given instance. The
        /// SLI key in the name must be a valid SLI name specified in the Eligibility Exporter binary flags otherwise an
        /// error will be emitted by Eligibility Exporter and the oncaller will be alerted. If an SLI has been defined
        /// in the binary flags but the eligibilities map does not contain it, the corresponding SLI time series will
        /// not be emitted by the Eligibility Exporter. This ensures a smooth rollout and compatibility between the data
        /// produced by different versions of the Eligibility Exporters. If eligibilities map contains a key for an SLI
        /// which has not been declared in the binary flags, there will be an error message emitted in the Eligibility
        /// Exporter log and the metric for the SLI in question will not be emitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibilities")]
        public virtual System.Collections.Generic.IDictionary<string, SloEligibility> Eligibilities { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes provisioned dataplane resources.</summary>
    public class ProvisionedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type of the resource. This can be either a GCP resource or a custom one (e.g. another cloud provider's VM).
        /// For GCP compute resources use singular form of the names listed in GCP compute API documentation
        /// (https://cloud.google.com/compute/docs/reference/rest/v1/), prefixed with 'compute-', for example:
        /// 'compute-instance', 'compute-disk', 'compute-autoscaler'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>URL identifying the resource, e.g. "https://www.googleapis.com/compute/v1/projects/...)".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A wrapper around the SQL query statement. This is needed so that the JSON representation of
    /// ExecuteSqlQueryRequest has the following format: `{"query":"select *"}`.
    /// </summary>
    public class Query : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sets the limit for the maximum number of rows returned after the query execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRows")]
        public virtual System.Nullable<long> MaxRows { get; set; }

        /// <summary>Required. Sql query to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string QueryValue { get; set; }

        /// <summary>
        /// In the struct, the value corresponds to the value of query parameter and date type corresponds to the date
        /// type of the query parameter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParameters")]
        public virtual System.Collections.Generic.IList<QueryParameter> QueryParameters { get; set; }

        /// <summary>Sets the number of seconds the driver will wait for a query to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual System.Nullable<long> Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Query parameter definition</summary>
    public class QueryParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Reference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the reference field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Name of reference entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RefreshAccessTokenRequest includes the refresh token.</summary>
    public class RefreshAccessTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Refresh Token String. If the Refresh Token is not provided, the runtime will read the data from
        /// the secret manager.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshToken")]
        public virtual string RefreshToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RefreshAccessTokenResponse includes the returned access token and its associated credentials.</summary>
    public class RefreshAccessTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accessCredentials")]
        public virtual AccessCredentials AccessCredentials { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Result Metadata message contains metadata about the result returned after executing an Action.
    /// </summary>
    public class ResultMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data type of the metadata field</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// The following field specifies the default value of the Parameter provided by the external system if a value
        /// is not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual object DefaultValue { get; set; }

        /// <summary>A brief description of the metadata field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>JsonSchema of the result, applicable only if parameter is of type `STRUCT`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonSchema JsonSchema { get; set; }

        /// <summary>Name of the metadata field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Specifies whether a null value is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configure the schedule.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allows to define schedule that runs specified day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>Output only. Duration of the time window, set by service producer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Time within the window to start the operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SloEligibility is a tuple containing eligibility value: true if an instance is eligible for SLO calculation or
    /// false if it should be excluded from all SLO-related calculations along with a user-defined reason.
    /// </summary>
    public class SloEligibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether an instance is eligible or ineligible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligible")]
        public virtual System.Nullable<bool> Eligible { get; set; }

        /// <summary>
        /// User-defined reason for the current value of instance eligibility. Usually, this can be directly mapped to
        /// the internal state. An empty reason is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SloMetadata contains resources required for proper SLO classification of the instance.</summary>
    public class SloMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. List of nodes. Some producers need to use per-node metadata to calculate SLO. This field allows
        /// such producers to publish per-node SLO meta data, which will be consumed by SSA Eligibility Exporter and
        /// published in the form of per node metric to Monarch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<NodeSloMetadata> Nodes { get; set; }

        /// <summary>Optional. Multiple per-instance SLI eligibilities which apply for individual SLIs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perSliEligibility")]
        public virtual PerSliSloEligibility PerSliEligibility { get; set; }

        /// <summary>
        /// Name of the SLO tier the Instance belongs to. This name will be expected to match the tiers specified in the
        /// service SLO configuration. Field is mandatory and must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or
        /// equal to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to
        /// 999,999,999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An
        /// API may allow the value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for EntityService.UpdateEntitiesWithConditions</summary>
    public class UpdateEntitiesWithConditionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Response returned by the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maintenance policy applicable to instance updates.</summary>
    public class UpdatePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Relative scheduling channel applied to resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>
        /// Deny Maintenance Period that is applied to resource to indicate when maintenance is forbidden. The protocol
        /// supports zero-to-many such periods, but the current SLM Rollout implementation only supports zero-to-one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyMaintenancePeriods")]
        public virtual System.Collections.Generic.IList<DenyMaintenancePeriod> DenyMaintenancePeriods { get; set; }

        /// <summary>Optional. Maintenance window that is applied to resources covered by this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("window")]
        public virtual MaintenanceWindow Window { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time window specified for weekly operations.</summary>
    public class WeeklyCycle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User can specify multiple windows in a week. Minimum of 1 window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual System.Collections.Generic.IList<Schedule> Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
