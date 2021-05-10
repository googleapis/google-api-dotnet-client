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

namespace Google.Apis.GameServices.v1beta
{
    /// <summary>The GameServices Service.</summary>
    public class GameServicesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GameServicesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GameServicesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gameservices";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://gameservices.googleapis.com/";
        #else
            "https://gameservices.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://gameservices.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Game Services API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Game Services API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for GameServices requests.</summary>
    public abstract class GameServicesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GameServicesBaseServiceRequest instance.</summary>
        protected GameServicesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GameServices parameter list.</summary>
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
                GameServerDeployments = new GameServerDeploymentsResource(service);
                Operations = new OperationsResource(service);
                Realms = new RealmsResource(service);
            }

            /// <summary>Gets the GameServerDeployments resource.</summary>
            public virtual GameServerDeploymentsResource GameServerDeployments { get; }

            /// <summary>The "gameServerDeployments" collection of methods.</summary>
            public class GameServerDeploymentsResource
            {
                private const string Resource = "gameServerDeployments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GameServerDeploymentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Configs = new ConfigsResource(service);
                }

                /// <summary>Gets the Configs resource.</summary>
                public virtual ConfigsResource Configs { get; }

                /// <summary>The "configs" collection of methods.</summary>
                public class ConfigsResource
                {
                    private const string Resource = "configs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConfigsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new game server config in a given project, location, and game server deployment. Game
                    /// server configs are immutable, and are not applied until referenced in the game server deployment
                    /// rollout resource.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource name, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GameServices.v1beta.Data.GameServerConfig body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new game server config in a given project, location, and game server deployment. Game
                    /// server configs are immutable, and are not applied until referenced in the game server deployment
                    /// rollout resource.
                    /// </summary>
                    public class CreateRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerConfig body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name, in the following form:
                        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The ID of the game server config resource to be created.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ConfigId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GameServices.v1beta.Data.GameServerConfig Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/configs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
                            });
                            RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "configId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a single game server config. The deletion will fail if the game server config is
                    /// referenced in a game server deployment rollout.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the game server config to delete, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a single game server config. The deletion will fail if the game server config is
                    /// referenced in a game server deployment rollout.
                    /// </summary>
                    public class DeleteRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the game server config to delete, in the following form:
                        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+/configs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single game server config.</summary>
                    /// <param name="name">
                    /// Required. The name of the game server config to retrieve, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets details of a single game server config.</summary>
                    public class GetRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.GameServerConfig>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the game server config to retrieve, in the following form:
                        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+/configs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists game server configs in a given project, location, and game server deployment.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent resource name, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists game server configs in a given project, location, and game server deployment.
                    /// </summary>
                    public class ListRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.ListGameServerConfigsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name, in the following form:
                        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter to apply to list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specifies the ordering of results following syntax at
                        /// https://cloud.google.com/apis/design/design_patterns#sorting_order.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If unspecified, server will pick an
                        /// appropriate default. Server may return fewer items than requested. A caller should only rely
                        /// on response's next_page_token to determine if there are more GameServerConfigs left to be
                        /// queried.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous list request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/configs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
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

                /// <summary>Creates a new game server deployment in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name, in the following form:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GameServices.v1beta.Data.GameServerDeployment body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new game server deployment in a given project and location.</summary>
                public class CreateRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerDeployment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the following form:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The ID of the game server delpoyment resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("deploymentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DeploymentId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.GameServerDeployment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/gameServerDeployments";

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

                /// <summary>Deletes a single game server deployment.</summary>
                /// <param name="name">
                /// Required. The name of the game server delpoyment to delete, in the following form:
                /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single game server deployment.</summary>
                public class DeleteRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the game server delpoyment to delete, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Retrieves information about the current state of the game server deployment. Gathers all the Agones
                /// fleets and Agones autoscalers, including fleets running an older version of the game server
                /// deployment.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the game server delpoyment, in the following form:
                /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
                /// </param>
                public virtual FetchDeploymentStateRequest FetchDeploymentState(Google.Apis.GameServices.v1beta.Data.FetchDeploymentStateRequest body, string name)
                {
                    return new FetchDeploymentStateRequest(service, body, name);
                }

                /// <summary>
                /// Retrieves information about the current state of the game server deployment. Gathers all the Agones
                /// fleets and Agones autoscalers, including fleets running an older version of the game server
                /// deployment.
                /// </summary>
                public class FetchDeploymentStateRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.FetchDeploymentStateResponse>
                {
                    /// <summary>Constructs a new FetchDeploymentState request.</summary>
                    public FetchDeploymentStateRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.FetchDeploymentStateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the game server delpoyment, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.FetchDeploymentStateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchDeploymentState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}:fetchDeploymentState";

                    /// <summary>Initializes FetchDeploymentState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single game server deployment.</summary>
                /// <param name="name">
                /// Required. The name of the game server delpoyment to retrieve, in the following form:
                /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single game server deployment.</summary>
                public class GetRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.GameServerDeployment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the game server delpoyment to retrieve, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected. Requests for policies with any conditional
                    /// bindings must specify version 3. Policies without any conditional bindings may specify any valid
                    /// value or leave the field unset. To learn which resources support conditions in their IAM
                    /// policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
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

                /// <summary>Gets details a single game server deployment rollout.</summary>
                /// <param name="name">
                /// Required. The name of the game server delpoyment to retrieve, in the following form:
                /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
                /// </param>
                public virtual GetRolloutRequest GetRollout(string name)
                {
                    return new GetRolloutRequest(service, name);
                }

                /// <summary>Gets details a single game server deployment rollout.</summary>
                public class GetRolloutRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.GameServerDeploymentRollout>
                {
                    /// <summary>Constructs a new GetRollout request.</summary>
                    public GetRolloutRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the game server delpoyment to retrieve, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getRollout";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}/rollout";

                    /// <summary>Initializes GetRollout parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists game server deployments in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource name, in the following form:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists game server deployments in a given project and location.</summary>
                public class ListRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.ListGameServerDeploymentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the following form:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter to apply to list results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Specifies the ordering of results following syntax at
                    /// https://cloud.google.com/apis/design/design_patterns#sorting_order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, the server will pick an
                    /// appropriate default. The server may return fewer items than requested. A caller should only rely
                    /// on response's next_page_token to determine if there are more GameServerDeployments left to be
                    /// queried.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The next_page_token value returned from a previous List request, if any.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/gameServerDeployments";

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

                /// <summary>Patches a game server deployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the game server deployment, in the following form:
                /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`. For example,
                /// `projects/my-project/locations/global/gameServerDeployments/my-deployment`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GameServices.v1beta.Data.GameServerDeployment body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Patches a game server deployment.</summary>
                public class PatchRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerDeployment body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the game server deployment, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`. For example,
                    /// `projects/my-project/locations/global/gameServerDeployments/my-deployment`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Mask of fields to update. At least one path must be supplied in this field. For the
                    /// `FieldMask` definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.GameServerDeployment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
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
                /// Previews the game server deployment rollout. This API does not mutate the rollout resource.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the game server deployment rollout, in the following form:
                /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`. For example,
                /// `projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout`.
                /// </param>
                public virtual PreviewRolloutRequest PreviewRollout(Google.Apis.GameServices.v1beta.Data.GameServerDeploymentRollout body, string name)
                {
                    return new PreviewRolloutRequest(service, body, name);
                }

                /// <summary>
                /// Previews the game server deployment rollout. This API does not mutate the rollout resource.
                /// </summary>
                public class PreviewRolloutRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.PreviewGameServerDeploymentRolloutResponse>
                {
                    /// <summary>Constructs a new PreviewRollout request.</summary>
                    public PreviewRolloutRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerDeploymentRollout body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the game server deployment rollout, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`. For
                    /// example, `projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The target timestamp to compute the preview. Defaults to the immediately after the
                    /// proposed rollout completes.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("previewTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object PreviewTime { get; set; }

                    /// <summary>
                    /// Optional. Mask of fields to update. At least one path must be supplied in this field. For the
                    /// `FieldMask` definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.GameServerDeploymentRollout Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "previewRollout";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}/rollout:preview";

                    /// <summary>Initializes PreviewRollout parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
                        });
                        RequestParameters.Add("previewTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "previewTime",
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
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.GameServices.v1beta.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.GameServices.v1beta.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.GameServices.v1beta.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.GameServices.v1beta.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Patches a single game server deployment rollout. The method will not return an error if the update
                /// does not affect any existing realms. For example - if the default_game_server_config is changed but
                /// all existing realms use the override, that is valid. Similarly, if a non existing realm is
                /// explicitly called out in game_server_config_overrides field, that will also not result in an error.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the game server deployment rollout, in the following form:
                /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`. For example,
                /// `projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout`.
                /// </param>
                public virtual UpdateRolloutRequest UpdateRollout(Google.Apis.GameServices.v1beta.Data.GameServerDeploymentRollout body, string name)
                {
                    return new UpdateRolloutRequest(service, body, name);
                }

                /// <summary>
                /// Patches a single game server deployment rollout. The method will not return an error if the update
                /// does not affect any existing realms. For example - if the default_game_server_config is changed but
                /// all existing realms use the override, that is valid. Similarly, if a non existing realm is
                /// explicitly called out in game_server_config_overrides field, that will also not result in an error.
                /// </summary>
                public class UpdateRolloutRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new UpdateRollout request.</summary>
                    public UpdateRolloutRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerDeploymentRollout body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the game server deployment rollout, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`. For
                    /// example, `projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Mask of fields to update. At least one path must be supplied in this field. For the
                    /// `FieldMask` definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.GameServerDeploymentRollout Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateRollout";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}/rollout";

                    /// <summary>Initializes UpdateRollout parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/gameServerDeployments/[^/]+$",
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
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.GameServices.v1beta.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}:cancel";

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
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Empty>
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
                    public override string RestPath => "v1beta/{+name}";

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
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
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
                    public override string RestPath => "v1beta/{+name}";

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
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.ListOperationsResponse>
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

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}/operations";

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
            }

            /// <summary>Gets the Realms resource.</summary>
            public virtual RealmsResource Realms { get; }

            /// <summary>The "realms" collection of methods.</summary>
            public class RealmsResource
            {
                private const string Resource = "realms";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RealmsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    GameServerClusters = new GameServerClustersResource(service);
                }

                /// <summary>Gets the GameServerClusters resource.</summary>
                public virtual GameServerClustersResource GameServerClusters { get; }

                /// <summary>The "gameServerClusters" collection of methods.</summary>
                public class GameServerClustersResource
                {
                    private const string Resource = "gameServerClusters";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public GameServerClustersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new game server cluster in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource name, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm-id}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.GameServices.v1beta.Data.GameServerCluster body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new game server cluster in a given project and location.</summary>
                    public class CreateRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerCluster body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name, in the following form:
                        /// `projects/{project}/locations/{location}/realms/{realm-id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The ID of the game server cluster resource to be created.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("gameServerClusterId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string GameServerClusterId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GameServices.v1beta.Data.GameServerCluster Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/gameServerClusters";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+$",
                            });
                            RequestParameters.Add("gameServerClusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gameServerClusterId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single game server cluster.</summary>
                    /// <param name="name">
                    /// Required. The name of the game server cluster to delete, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a single game server cluster.</summary>
                    public class DeleteRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the game server cluster to delete, in the following form:
                        /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+/gameServerClusters/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single game server cluster.</summary>
                    /// <param name="name">
                    /// Required. The name of the game server cluster to retrieve, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets details of a single game server cluster.</summary>
                    public class GetRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.GameServerCluster>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the game server cluster to retrieve, in the following form:
                        /// `projects/{project}/locations/{location}/realms/{realm-id}/gameServerClusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. View for the returned GameServerCluster objects. When `FULL` is specified, the
                        /// `cluster_state` field is also returned in the GameServerCluster object, which includes the
                        /// state of the referenced Kubernetes cluster such as versions and provider info. The
                        /// default/unset value is GAME_SERVER_CLUSTER_VIEW_UNSPECIFIED, same as BASIC, which does not
                        /// return the `cluster_state` field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. View for the returned GameServerCluster objects. When `FULL` is specified, the
                        /// `cluster_state` field is also returned in the GameServerCluster object, which includes the
                        /// state of the referenced Kubernetes cluster such as versions and provider info. The
                        /// default/unset value is GAME_SERVER_CLUSTER_VIEW_UNSPECIFIED, same as BASIC, which does not
                        /// return the `cluster_state` field.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                            [Google.Apis.Util.StringValueAttribute("GAME_SERVER_CLUSTER_VIEW_UNSPECIFIED")]
                            GAMESERVERCLUSTERVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Include basic information of a GameServerCluster resource and omit `cluster_state`. This
                            /// is the default value (for ListGameServerClusters, GetGameServerCluster and
                            /// PreviewCreateGameServerCluster).
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+/gameServerClusters/[^/]+$",
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

                    /// <summary>Lists game server clusters in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. The parent resource name, in the following form:
                    /// "projects/{project}/locations/{location}/realms/{realm}".
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists game server clusters in a given project and location.</summary>
                    public class ListRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.ListGameServerClustersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name, in the following form:
                        /// "projects/{project}/locations/{location}/realms/{realm}".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. The filter to apply to list results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specifies the ordering of results following syntax at
                        /// https://cloud.google.com/apis/design/design_patterns#sorting_order.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If unspecified, the server will pick an
                        /// appropriate default. The server may return fewer items than requested. A caller should only
                        /// rely on response's next_page_token to determine if there are more GameServerClusters left to
                        /// be queried.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. The next_page_token value returned from a previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. View for the returned GameServerCluster objects. When `FULL` is specified, the
                        /// `cluster_state` field is also returned in the GameServerCluster object, which includes the
                        /// state of the referenced Kubernetes cluster such as versions and provider info. The
                        /// default/unset value is GAME_SERVER_CLUSTER_VIEW_UNSPECIFIED, same as BASIC, which does not
                        /// return the `cluster_state` field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. View for the returned GameServerCluster objects. When `FULL` is specified, the
                        /// `cluster_state` field is also returned in the GameServerCluster object, which includes the
                        /// state of the referenced Kubernetes cluster such as versions and provider info. The
                        /// default/unset value is GAME_SERVER_CLUSTER_VIEW_UNSPECIFIED, same as BASIC, which does not
                        /// return the `cluster_state` field.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                            [Google.Apis.Util.StringValueAttribute("GAME_SERVER_CLUSTER_VIEW_UNSPECIFIED")]
                            GAMESERVERCLUSTERVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Include basic information of a GameServerCluster resource and omit `cluster_state`. This
                            /// is the default value (for ListGameServerClusters, GetGameServerCluster and
                            /// PreviewCreateGameServerCluster).
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/gameServerClusters";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+$",
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

                    /// <summary>Patches a single game server cluster.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the game server cluster, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}`. For
                    /// example,
                    /// `projects/my-project/locations/{location}/realms/zanzibar/gameServerClusters/my-onprem-cluster`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.GameServices.v1beta.Data.GameServerCluster body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Patches a single game server cluster.</summary>
                    public class PatchRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerCluster body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the game server cluster, in the following form:
                        /// `projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}`. For
                        /// example,
                        /// `projects/my-project/locations/{location}/realms/zanzibar/gameServerClusters/my-onprem-cluster`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field. For
                        /// the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GameServices.v1beta.Data.GameServerCluster Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+/gameServerClusters/[^/]+$",
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
                    /// Previews creation of a new game server cluster in a given project and location.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource name, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm}`.
                    /// </param>
                    public virtual PreviewCreateRequest PreviewCreate(Google.Apis.GameServices.v1beta.Data.GameServerCluster body, string parent)
                    {
                        return new PreviewCreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Previews creation of a new game server cluster in a given project and location.
                    /// </summary>
                    public class PreviewCreateRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.PreviewCreateGameServerClusterResponse>
                    {
                        /// <summary>Constructs a new PreviewCreate request.</summary>
                        public PreviewCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerCluster body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource name, in the following form:
                        /// `projects/{project}/locations/{location}/realms/{realm}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Required. The ID of the game server cluster resource to be created.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("gameServerClusterId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string GameServerClusterId { get; set; }

                        /// <summary>Optional. The target timestamp to compute the preview.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("previewTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object PreviewTime { get; set; }

                        /// <summary>
                        /// Optional. This field is deprecated, preview will always return KubernetesClusterState.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>
                        /// Optional. This field is deprecated, preview will always return KubernetesClusterState.
                        /// </summary>
                        public enum ViewEnum
                        {
                            /// <summary>The default / unset value. The API will default to the BASIC view.</summary>
                            [Google.Apis.Util.StringValueAttribute("GAME_SERVER_CLUSTER_VIEW_UNSPECIFIED")]
                            GAMESERVERCLUSTERVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Include basic information of a GameServerCluster resource and omit `cluster_state`. This
                            /// is the default value (for ListGameServerClusters, GetGameServerCluster and
                            /// PreviewCreateGameServerCluster).
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,

                            /// <summary>Include everything.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 2,
                        }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GameServices.v1beta.Data.GameServerCluster Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "previewCreate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+parent}/gameServerClusters:previewCreate";

                        /// <summary>Initializes PreviewCreate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+$",
                            });
                            RequestParameters.Add("gameServerClusterId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gameServerClusterId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("previewTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "previewTime",
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

                    /// <summary>Previews deletion of a single game server cluster.</summary>
                    /// <param name="name">
                    /// Required. The name of the game server cluster to delete, in the following form:
                    /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
                    /// </param>
                    public virtual PreviewDeleteRequest PreviewDelete(string name)
                    {
                        return new PreviewDeleteRequest(service, name);
                    }

                    /// <summary>Previews deletion of a single game server cluster.</summary>
                    public class PreviewDeleteRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.PreviewDeleteGameServerClusterResponse>
                    {
                        /// <summary>Constructs a new PreviewDelete request.</summary>
                        public PreviewDeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the game server cluster to delete, in the following form:
                        /// `projects/{project}/locations/{location}/gameServerClusters/{cluster}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. The target timestamp to compute the preview.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("previewTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object PreviewTime { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "previewDelete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}:previewDelete";

                        /// <summary>Initializes PreviewDelete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+/gameServerClusters/[^/]+$",
                            });
                            RequestParameters.Add("previewTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "previewTime",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Previews updating a GameServerCluster.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the game server cluster, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}`. For
                    /// example,
                    /// `projects/my-project/locations/{location}/realms/zanzibar/gameServerClusters/my-onprem-cluster`.
                    /// </param>
                    public virtual PreviewUpdateRequest PreviewUpdate(Google.Apis.GameServices.v1beta.Data.GameServerCluster body, string name)
                    {
                        return new PreviewUpdateRequest(service, body, name);
                    }

                    /// <summary>Previews updating a GameServerCluster.</summary>
                    public class PreviewUpdateRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.PreviewUpdateGameServerClusterResponse>
                    {
                        /// <summary>Constructs a new PreviewUpdate request.</summary>
                        public PreviewUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.GameServerCluster body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the game server cluster, in the following form:
                        /// `projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}`. For
                        /// example,
                        /// `projects/my-project/locations/{location}/realms/zanzibar/gameServerClusters/my-onprem-cluster`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. The target timestamp to compute the preview.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("previewTime", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object PreviewTime { get; set; }

                        /// <summary>
                        /// Required. Mask of fields to update. At least one path must be supplied in this field. For
                        /// the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.GameServices.v1beta.Data.GameServerCluster Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "previewUpdate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/{+name}:previewUpdate";

                        /// <summary>Initializes PreviewUpdate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+/gameServerClusters/[^/]+$",
                            });
                            RequestParameters.Add("previewTime", new Google.Apis.Discovery.Parameter
                            {
                                Name = "previewTime",
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
                        }
                    }
                }

                /// <summary>Creates a new realm in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name, in the following form:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GameServices.v1beta.Data.Realm body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new realm in a given project and location.</summary>
                public class CreateRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.Realm body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the following form:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The ID of the realm resource to be created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("realmId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RealmId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.Realm Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/realms";

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
                        RequestParameters.Add("realmId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "realmId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single realm.</summary>
                /// <param name="name">
                /// Required. The name of the realm to delete, in the following form:
                /// `projects/{project}/locations/{location}/realms/{realm}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a single realm.</summary>
                public class DeleteRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the realm to delete, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single realm.</summary>
                /// <param name="name">
                /// Required. The name of the realm to retrieve, in the following form:
                /// `projects/{project}/locations/{location}/realms/{realm}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets details of a single realm.</summary>
                public class GetRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Realm>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the realm to retrieve, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists realms in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource name, in the following form:
                /// `projects/{project}/locations/{location}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists realms in a given project and location.</summary>
                public class ListRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.ListRealmsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name, in the following form:
                    /// `projects/{project}/locations/{location}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. The filter to apply to list results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Specifies the ordering of results following syntax at
                    /// https://cloud.google.com/apis/design/design_patterns#sorting_order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, server will pick an appropriate
                    /// default. Server may return fewer items than requested. A caller should only rely on response's
                    /// next_page_token to determine if there are more realms left to be queried.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. The next_page_token value returned from a previous List request, if any.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/realms";

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

                /// <summary>Patches a single realm.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the realm, in the following form:
                /// `projects/{project}/locations/{location}/realms/{realm}`. For example,
                /// `projects/my-project/locations/{location}/realms/my-realm`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GameServices.v1beta.Data.Realm body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Patches a single realm.</summary>
                public class PatchRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.Realm body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the realm, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm}`. For example,
                    /// `projects/my-project/locations/{location}/realms/my-realm`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The update mask applies to the resource. For the `FieldMask` definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.Realm Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+$",
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

                /// <summary>Previews patches to a single realm.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the realm, in the following form:
                /// `projects/{project}/locations/{location}/realms/{realm}`. For example,
                /// `projects/my-project/locations/{location}/realms/my-realm`.
                /// </param>
                public virtual PreviewUpdateRequest PreviewUpdate(Google.Apis.GameServices.v1beta.Data.Realm body, string name)
                {
                    return new PreviewUpdateRequest(service, body, name);
                }

                /// <summary>Previews patches to a single realm.</summary>
                public class PreviewUpdateRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.PreviewRealmUpdateResponse>
                {
                    /// <summary>Constructs a new PreviewUpdate request.</summary>
                    public PreviewUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.GameServices.v1beta.Data.Realm body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the realm, in the following form:
                    /// `projects/{project}/locations/{location}/realms/{realm}`. For example,
                    /// `projects/my-project/locations/{location}/realms/my-realm`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The target timestamp to compute the preview.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("previewTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object PreviewTime { get; set; }

                    /// <summary>
                    /// Required. The update mask applies to the resource. For the `FieldMask` definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GameServices.v1beta.Data.Realm Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "previewUpdate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}:previewUpdate";

                    /// <summary>Initializes PreviewUpdate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/realms/[^/]+$",
                        });
                        RequestParameters.Add("previewTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "previewTime",
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
            public class GetRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.Location>
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
                public override string RestPath => "v1beta/{+name}";

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
            public class ListRequest : GameServicesBaseServiceRequest<Google.Apis.GameServices.v1beta.Data.ListLocationsResponse>
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

                /// <summary>If true, the returned list will include locations which are not yet revealed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUnrevealedLocations", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUnrevealedLocations { get; set; }

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
                public override string RestPath => "v1beta/{+name}/locations";

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
                    RequestParameters.Add("includeUnrevealedLocations", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUnrevealedLocations",
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
namespace Google.Apis.GameServices.v1beta.Data
{
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
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

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
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ignoreChildExemptions")]
        public virtual System.Nullable<bool> IgnoreChildExemptions { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Authorization-related information used by Cloud Audit Logging.</summary>
    public class AuthorizationLoggingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the permission that was checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionType")]
        public virtual string PermissionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("bindingId")]
        public virtual string BindingId { get; set; }

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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Write a Cloud Audit log</summary>
    public class CloudAuditOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information used by the Cloud Audit Logging pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationLoggingOptions")]
        public virtual AuthorizationLoggingOptions AuthorizationLoggingOptions { get; set; }

        /// <summary>The log_name to populate in the Cloud Audit Record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logName")]
        public virtual string LogName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A condition to be met.</summary>
    public class Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Trusted attributes supplied by the IAM system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iam")]
        public virtual string Iam { get; set; }

        /// <summary>An operator to apply the subject with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("op")]
        public virtual string Op { get; set; }

        /// <summary>Trusted attributes discharged by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("svc")]
        public virtual string Svc { get; set; }

        /// <summary>
        /// Trusted attributes supplied by any service that owns resources and uses the IAM system for access control.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sys")]
        public virtual string Sys { get; set; }

        /// <summary>The objects of the condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Increment a streamz counter with the specified metric and field names. Metric names should start with a '/',
    /// generally be lowercase-only, and end in "_count". Field names should not contain an initial slash. The actual
    /// exported metric names will have "/iam/policy" prepended. Field names correspond to IAM request parameters and
    /// field values are their respective values. Supported field names: - "authority", which is "[token]" if
    /// IAMContext.token is present, otherwise the value of IAMContext.authority_selector if present, and otherwise a
    /// representation of IAMContext.principal; or - "iam_principal", a representation of IAMContext.principal even if a
    /// token or authority selector is present; or - "" (empty string), resulting in a counter with no fields. Examples:
    /// counter { metric: "/debug_access_count" field: "iam_principal" } ==&amp;gt; increment counter
    /// /iam/policy/debug_access_count {iam_principal=[value of IAMContext.principal]}
    /// </summary>
    public class CounterOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFields")]
        public virtual System.Collections.Generic.IList<CustomField> CustomFields { get; set; }

        /// <summary>The field value to attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The metric to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Custom fields. These can be used to create a counter with arbitrary field/value pairs. See:
    /// go/rpcsp-custom-fields.
    /// </summary>
    public class CustomField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name is the field name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Value is the field value. It is important that in contrast to the CounterOptions.field, the value here is a
        /// constant that is not derived from the IAMContext.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Write a Data Access (Gin) log</summary>
    public class DataAccessOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("logMode")]
        public virtual string LogMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The game server cluster changes made by the game server deployment.</summary>
    public class DeployedClusterState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>The details about the Agones fleets and autoscalers created in the game server cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetDetails")]
        public virtual System.Collections.Generic.IList<DeployedFleetDetails> FleetDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Agones fleet specification and details.</summary>
    public class DeployedFleet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Agones fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleet")]
        public virtual string Fleet { get; set; }

        /// <summary>The fleet spec retrieved from the Agones fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetSpec")]
        public virtual string FleetSpec { get; set; }

        /// <summary>
        /// The source spec that is used to create the Agones fleet. The GameServerConfig resource may no longer exist
        /// in the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specSource")]
        public virtual SpecSource SpecSource { get; set; }

        /// <summary>The current status of the Agones fleet. Includes count of game servers in various states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual DeployedFleetStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the Agones autoscaler.</summary>
    public class DeployedFleetAutoscaler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Agones autoscaler.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscaler")]
        public virtual string Autoscaler { get; set; }

        /// <summary>The autoscaler spec retrieved from Agones.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetAutoscalerSpec")]
        public virtual string FleetAutoscalerSpec { get; set; }

        /// <summary>
        /// The source spec that is used to create the autoscaler. The GameServerConfig resource may no longer exist in
        /// the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specSource")]
        public virtual SpecSource SpecSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the deployed Agones fleet.</summary>
    public class DeployedFleetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the Agones autoscaler for that fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployedAutoscaler")]
        public virtual DeployedFleetAutoscaler DeployedAutoscaler { get; set; }

        /// <summary>Information about the Agones fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployedFleet")]
        public virtual DeployedFleet DeployedFleet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DeployedFleetStatus has details about the Agones fleets such as how many are running, how many allocated, and so
    /// on.
    /// </summary>
    public class DeployedFleetStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of GameServer replicas in the ALLOCATED state in this fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedReplicas")]
        public virtual System.Nullable<long> AllocatedReplicas { get; set; }

        /// <summary>The number of GameServer replicas in the READY state in this fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readyReplicas")]
        public virtual System.Nullable<long> ReadyReplicas { get; set; }

        /// <summary>The total number of current GameServer replicas in this fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replicas")]
        public virtual System.Nullable<long> Replicas { get; set; }

        /// <summary>
        /// The number of GameServer replicas in the RESERVED state in this fleet. Reserved instances won't be deleted
        /// on scale down, but won't cause an autoscaler to scale up.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedReplicas")]
        public virtual System.Nullable<long> ReservedReplicas { get; set; }

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

    /// <summary>Request message for GameServerDeploymentsService.FetchDeploymentState.</summary>
    public class FetchDeploymentStateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GameServerDeploymentsService.FetchDeploymentState.</summary>
    public class FetchDeploymentStateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of the game server deployment in each game server cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterState")]
        public virtual System.Collections.Generic.IList<DeployedClusterState> ClusterState { get; set; }

        /// <summary>List of locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unavailable")]
        public virtual System.Collections.Generic.IList<string> Unavailable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fleet configs for Agones.</summary>
    public class FleetConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Agones fleet spec. Example spec: `https://agones.dev/site/docs/reference/fleet/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetSpec")]
        public virtual string FleetSpec { get; set; }

        /// <summary>The name of the FleetConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A game server cluster resource.</summary>
    public class GameServerCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The allocation priority assigned to the game server cluster. Game server clusters receive new game
        /// server allocations based on the relative allocation priorites set for each cluster, if the realm is
        /// configured for multicluster allocation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocationPriority")]
        public virtual string AllocationPriority { get; set; }

        /// <summary>
        /// Output only. The state of the Kubernetes cluster, this will be available if 'view' is set to `FULL` in the
        /// relevant List/Get/Preview request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterState")]
        public virtual KubernetesClusterState ClusterState { get; set; }

        /// <summary>
        /// The game server cluster connection information. This information is used to manage game server clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionInfo")]
        public virtual GameServerClusterConnectionInfo ConnectionInfo { get; set; }

        /// <summary>Output only. The creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Human readable description of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The labels associated with this game server cluster. Each label is a key-value pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The resource name of the game server cluster, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}`. For example,
        /// `projects/my-project/locations/{location}/realms/zanzibar/gameServerClusters/my-onprem-cluster`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>The game server cluster connection information.</summary>
    public class GameServerClusterConnectionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reference to the GKE cluster where the game servers are installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeClusterReference")]
        public virtual GkeClusterReference GkeClusterReference { get; set; }

        /// <summary>
        /// Reference to a Kubernetes cluster registered through GKE Hub. See
        /// https://cloud.google.com/anthos/multicluster-management/ for more information about registering Kubernetes
        /// clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeHubClusterReference")]
        public virtual GkeHubClusterReference GkeHubClusterReference { get; set; }

        /// <summary>
        /// Namespace designated on the game server cluster where the Agones game server instances will be created.
        /// Existence of the namespace will be validated during creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A game server config resource.</summary>
    public class GameServerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The description of the game server config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>FleetConfig contains a list of Agones fleet specs. Only one FleetConfig is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetConfigs")]
        public virtual System.Collections.Generic.IList<FleetConfig> FleetConfigs { get; set; }

        /// <summary>The labels associated with this game server config. Each label is a key-value pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The resource name of the game server config, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/configs/{config}`. For example,
        /// `projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The autoscaling settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scalingConfigs")]
        public virtual System.Collections.Generic.IList<ScalingConfig> ScalingConfigs { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A game server config override.</summary>
    public class GameServerConfigOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The game server config for this override.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configVersion")]
        public virtual string ConfigVersion { get; set; }

        /// <summary>Selector for choosing applicable realms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realmsSelector")]
        public virtual RealmSelector RealmsSelector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A game server deployment resource.</summary>
    public class GameServerDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Human readable description of the game server delpoyment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The labels associated with this game server deployment. Each label is a key-value pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The resource name of the game server deployment, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`. For example,
        /// `projects/my-project/locations/global/gameServerDeployments/my-deployment`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>The game server deployment rollout which represents the desired rollout state.</summary>
    public class GameServerDeploymentRollout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The default game server config is applied to all realms unless overridden in the rollout. For example,
        /// `projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultGameServerConfig")]
        public virtual string DefaultGameServerConfig { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Contains the game server config rollout overrides. Overrides are processed in the order they are listed.
        /// Once a match is found for a realm, the rest of the list is not processed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameServerConfigOverrides")]
        public virtual System.Collections.Generic.IList<GameServerConfigOverride> GameServerConfigOverrides { get; set; }

        /// <summary>
        /// The resource name of the game server deployment rollout, in the following form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`. For example,
        /// `projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>A reference to a GKE cluster.</summary>
    public class GkeClusterReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full or partial name of a GKE cluster, using one of the following forms: *
        /// `projects/{project}/locations/{location}/clusters/{cluster}` * `locations/{location}/clusters/{cluster}` *
        /// `{cluster}` If project and location are not specified, the project and location of the GameServerCluster
        /// resource are used to generate the full name of the GKE cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GkeHubClusterReference represents a reference to a Kubernetes cluster registered through GKE Hub.
    /// </summary>
    public class GkeHubClusterReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full or partial name of a GKE Hub membership, using one of the following forms: *
        /// `https://gkehub.googleapis.com/v1beta1/projects/{project_id}/locations/global/memberships/{membership_id}` *
        /// `projects/{project_id}/locations/global/memberships/{membership_id}` * `{membership_id}` If project is not
        /// specified, the project of the GameServerCluster resource is used to generate the full name of the GKE Hub
        /// membership.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membership")]
        public virtual string Membership { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The state of the Kubernetes cluster.</summary>
    public class KubernetesClusterState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The version of Agones currently installed in the registered Kubernetes cluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agonesVersionInstalled")]
        public virtual string AgonesVersionInstalled { get; set; }

        /// <summary>Output only. The version of Agones that is targeted to be installed in the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agonesVersionTargeted")]
        public virtual string AgonesVersionTargeted { get; set; }

        /// <summary>Output only. The state for the installed versions of Agones/Kubernetes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installationState")]
        public virtual string InstallationState { get; set; }

        /// <summary>
        /// Output only. The version of Kubernetes that is currently used in the registered Kubernetes cluster (as
        /// detected by the Cloud Game Servers service).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetesVersionInstalled")]
        public virtual string KubernetesVersionInstalled { get; set; }

        /// <summary>
        /// Output only. The cloud provider type reported by the first node's providerID in the list of nodes on the
        /// Kubernetes endpoint. On Kubernetes platforms that support zero-node clusters (like GKE-on-GCP), the provider
        /// type will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Output only. The detailed error message for the installed versions of Agones/Kubernetes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionInstalledErrorMessage")]
        public virtual string VersionInstalledErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The label selector, used to group labels on the resources.</summary>
    public class LabelSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource labels for this selector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GameServerClustersService.ListGameServerClusters.</summary>
    public class ListGameServerClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of game server clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameServerClusters")]
        public virtual System.Collections.Generic.IList<GameServerCluster> GameServerClusters { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GameServerConfigsService.ListGameServerConfigs.</summary>
    public class ListGameServerConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of game server configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameServerConfigs")]
        public virtual System.Collections.Generic.IList<GameServerConfig> GameServerConfigs { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for GameServerDeploymentsService.ListGameServerDeployments.</summary>
    public class ListGameServerDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of game server deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameServerDeployments")]
        public virtual System.Collections.Generic.IList<GameServerDeployment> GameServerDeployments { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for RealmsService.ListRealms.</summary>
    public class ListRealmsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of realms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realms")]
        public virtual System.Collections.Generic.IList<Realm> Realms { get; set; }

        /// <summary>List of locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Specifies what kind of log the caller must write</summary>
    public class LogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud audit options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudAudit")]
        public virtual CloudAuditOptions CloudAudit { get; set; }

        /// <summary>Counter options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counter")]
        public virtual CounterOptions Counter { get; set; }

        /// <summary>Data access options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataAccess")]
        public virtual DataAccessOptions DataAccess { get; set; }

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
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
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
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>Output only. The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. Operation status for Game Services API operations. Operation status is in the form of key-value
        /// pairs where keys are resource IDs and the values show the status of the operation. In case of failures, the
        /// value includes an error code and error message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationStatus")]
        public virtual System.Collections.Generic.IDictionary<string, OperationStatus> OperationStatus { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. List of Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OperationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether the operation is done or still in progress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error code in case of failures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>The human-readable error message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

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
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

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

        [Newtonsoft.Json.JsonPropertyAttribute("iamOwned")]
        public virtual System.Nullable<bool> IamOwned { get; set; }

        /// <summary>
        /// If more than one rule is specified, the rules are applied in the following manner: - All matching LOG rules
        /// are always applied. - If any DENY/DENY_WITH_LOG rule matches, permission is denied. Logging will be applied
        /// if one or more matching rule requires logging. - Otherwise, if any ALLOW/ALLOW_WITH_LOG rule matches,
        /// permission is granted. Logging will be applied if one or more matching rule requires logging. - Otherwise,
        /// if no rule applies, permission is denied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<Rule> Rules { get; set; }

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

    /// <summary>Response message for GameServerClustersService.PreviewCreateGameServerCluster.</summary>
    public class PreviewCreateGameServerClusterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The state of the Kubernetes cluster in preview, this will be available if 'view' is set to
        /// `FULL` in the relevant List/Get/Preview request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterState")]
        public virtual KubernetesClusterState ClusterState { get; set; }

        /// <summary>The ETag of the game server cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The target state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetState")]
        public virtual TargetState TargetState { get; set; }
    }

    /// <summary>Response message for GameServerClustersService.PreviewDeleteGameServerCluster.</summary>
    public class PreviewDeleteGameServerClusterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the game server cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The target state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetState")]
        public virtual TargetState TargetState { get; set; }
    }

    /// <summary>
    /// Response message for PreviewGameServerDeploymentRollout. This has details about the Agones fleet and autoscaler
    /// to be actuated.
    /// </summary>
    public class PreviewGameServerDeploymentRolloutResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the game server deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The target state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetState")]
        public virtual TargetState TargetState { get; set; }

        /// <summary>Locations that could not be reached on this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unavailable")]
        public virtual System.Collections.Generic.IList<string> Unavailable { get; set; }
    }

    /// <summary>Response message for RealmsService.PreviewRealmUpdate.</summary>
    public class PreviewRealmUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the realm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The target state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetState")]
        public virtual TargetState TargetState { get; set; }
    }

    /// <summary>Response message for GameServerClustersService.PreviewUpdateGameServerCluster</summary>
    public class PreviewUpdateGameServerClusterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the game server cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The target state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetState")]
        public virtual TargetState TargetState { get; set; }
    }

    /// <summary>A realm resource.</summary>
    public class Realm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Human readable description of the realm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The labels associated with this realm. Each label is a key-value pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The resource name of the realm, in the following form:
        /// `projects/{project}/locations/{location}/realms/{realm}`. For example,
        /// `projects/my-project/locations/{location}/realms/my-realm`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Time zone where all policies targeting this realm are evaluated. The value of this field must be
        /// from the IANA time zone database: https://www.iana.org/time-zones.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>Output only. The last-modified time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>The realm selector, used to match realm resources.</summary>
    public class RealmSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of realms to match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("realms")]
        public virtual System.Collections.Generic.IList<string> Realms { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A rule to be applied in a Policy.</summary>
    public class Rule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Additional restrictions that must be met. All conditions must pass for the rule to match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<Condition> Conditions { get; set; }

        /// <summary>Human-readable description of the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// If one or more 'in' clauses are specified, the rule matches if the PRINCIPAL/AUTHORITY_SELECTOR is in at
        /// least one of these entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("in")]
        public virtual System.Collections.Generic.IList<string> In__ { get; set; }

        /// <summary>
        /// The config returned to callers of tech.iam.IAM.CheckPolicy for any entries that match the LOG action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logConfig")]
        public virtual System.Collections.Generic.IList<LogConfig> LogConfig { get; set; }

        /// <summary>
        /// If one or more 'not_in' clauses are specified, the rule matches if the PRINCIPAL/AUTHORITY_SELECTOR is in
        /// none of the entries. The format for in and not_in entries can be found at in the Local IAM documentation
        /// (see go/local-iam#features).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notIn")]
        public virtual System.Collections.Generic.IList<string> NotIn { get; set; }

        /// <summary>
        /// A permission is a string of form '..' (e.g., 'storage.buckets.list'). A value of '*' matches all
        /// permissions, and a verb part of '*' (e.g., 'storage.buckets.*') matches all verbs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Autoscaling config for an Agones fleet.</summary>
    public class ScalingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Agones fleet autoscaler spec. Example spec:
        /// https://agones.dev/site/docs/reference/fleetautoscaler/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetAutoscalerSpec")]
        public virtual string FleetAutoscalerSpec { get; set; }

        /// <summary>Required. The name of the Scaling Config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The schedules to which this Scaling Config applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedules")]
        public virtual System.Collections.Generic.IList<Schedule> Schedules { get; set; }

        /// <summary>
        /// Labels used to identify the game server clusters to which this Agones scaling config applies. A game server
        /// cluster is subject to this Agones scaling config if its labels match any of the selector entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectors")]
        public virtual System.Collections.Generic.IList<LabelSelector> Selectors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The schedule of a recurring or one time event. The event's time span is specified by start_time and end_time. If
    /// the scheduled event's timespan is larger than the cron_spec + cron_job_duration, the event will be recurring. If
    /// only cron_spec + cron_job_duration are specified, the event is effective starting at the local time specified by
    /// cron_spec, and is recurring. start_time|-------[cron job]-------[cron job]-------[cron job]---|end_time cron
    /// job: cron spec start time + duration
    /// </summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The duration for the cron job event. The duration of the event is effective after the cron job's start time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronJobDuration")]
        public virtual object CronJobDuration { get; set; }

        /// <summary>
        /// The cron definition of the scheduled event. See https://en.wikipedia.org/wiki/Cron. Cron spec specifies the
        /// local time as defined by the realm.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cronSpec")]
        public virtual string CronSpec { get; set; }

        /// <summary>The end time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The start time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

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

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates Agones fleet spec and Agones autoscaler spec sources.</summary>
    public class SpecSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The game server config resource. Uses the form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment_id}/configs/{config_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameServerConfigName")]
        public virtual string GameServerConfigName { get; set; }

        /// <summary>
        /// The name of the Agones leet config or Agones scaling config used to derive the Agones fleet or Agones
        /// autoscaler spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>Details about the Agones resources.</summary>
    public class TargetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Agones fleet details for game server clusters and game server deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleetDetails")]
        public virtual System.Collections.Generic.IList<TargetFleetDetails> FleetDetails { get; set; }

        /// <summary>
        /// The game server cluster name. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}/gameServerClusters/{cluster}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameServerClusterName")]
        public virtual string GameServerClusterName { get; set; }

        /// <summary>
        /// The game server deployment name. Uses the form:
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gameServerDeploymentName")]
        public virtual string GameServerDeploymentName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Target Agones fleet specification.</summary>
    public class TargetFleet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Agones fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Encapsulates the source of the Agones fleet spec. The Agones fleet spec source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specSource")]
        public virtual SpecSource SpecSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Target Agones autoscaler policy reference.</summary>
    public class TargetFleetAutoscaler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Agones autoscaler.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Encapsulates the source of the Agones fleet spec. Details about the Agones autoscaler spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specSource")]
        public virtual SpecSource SpecSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the target Agones fleet.</summary>
    public class TargetFleetDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reference to target Agones fleet autoscaling policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoscaler")]
        public virtual TargetFleetAutoscaler Autoscaler { get; set; }

        /// <summary>Reference to target Agones fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fleet")]
        public virtual TargetFleet Fleet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates the Target state.</summary>
    public class TargetState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details about Agones fleets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<TargetDetails> Details { get; set; }

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
