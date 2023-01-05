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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "connectors";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://connectors.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://connectors.googleapis.com/batch";

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
                        return new ExecuteRequest(service, body, name);
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

                    /// <summary>Gets the schema of all the actions supported by the connector.</summary>
                    /// <param name="parent">
                    /// Required. Parent resource name of the Action. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
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
                            return new CreateRequest(service, body, parent);
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
                            return new DeleteRequest(service, name);
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
                            return new DeleteEntitiesWithConditionsRequest(service, entityType);
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
                            return new GetRequest(service, name);
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
                            return new ListRequest(service, parent);
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
                            return new PatchRequest(service, body, name);
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
                            return new UpdateEntitiesWithConditionsRequest(service, body, entityType);
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

                    /// <summary>Lists metadata related to all entity types present in the external system.</summary>
                    /// <param name="parent">
                    /// Required. Resource name of the Entity Type. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
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
                        }
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
                    return new ExecuteSqlQueryRequest(service, body, connection);
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
            }
        }
    }
}
namespace Google.Apis.Connectors.v2.Data
{
    /// <summary>
    /// Action message contains metadata information about a single action present in the external system.
    /// </summary>
    public class Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List containing input parameter metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputParameters")]
        public virtual System.Collections.Generic.IList<InputParameter> InputParameters { get; set; }

        /// <summary>Name of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>List containing the metadata of result fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultMetadata")]
        public virtual System.Collections.Generic.IList<ResultMetadata> ResultMetadata { get; set; }

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

        /// <summary>The name of the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

        /// <summary>Name of the Parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Specifies whether a null value is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

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

    /// <summary>
    /// A wrapper around the SQL query statement. This is needed so that the JSON representation of
    /// ExecuteSqlQueryRequest has the following format: `{"query":"select *"}`.
    /// </summary>
    public class Query : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Sql query to execute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string QueryValue { get; set; }

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

    /// <summary>
    /// Result Metadata message contains metadata about the result returned after executing an Action.
    /// </summary>
    public class ResultMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data type of the metadata field</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>A brief description of the metadata field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Name of the metadata field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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
}
