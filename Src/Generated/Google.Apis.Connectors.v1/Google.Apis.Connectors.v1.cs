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

namespace Google.Apis.Connectors.v1
{
    /// <summary>The Connectors Service.</summary>
    public class ConnectorsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

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
                CustomConnectors = new CustomConnectorsResource(service);
                EndpointAttachments = new EndpointAttachmentsResource(service);
                Global = new GlobalResource(service);
                Operations = new OperationsResource(service);
                Providers = new ProvidersResource(service);
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
                    ConnectionSchemaMetadata = new ConnectionSchemaMetadataResource(service);
                    EndUserAuthentications = new EndUserAuthenticationsResource(service);
                    EventSubscriptions = new EventSubscriptionsResource(service);
                    RuntimeActionSchemas = new RuntimeActionSchemasResource(service);
                    RuntimeEntitySchemas = new RuntimeEntitySchemasResource(service);
                }

                /// <summary>Gets the ConnectionSchemaMetadata resource.</summary>
                public virtual ConnectionSchemaMetadataResource ConnectionSchemaMetadata { get; }

                /// <summary>The "connectionSchemaMetadata" collection of methods.</summary>
                public class ConnectionSchemaMetadataResource
                {
                    private const string Resource = "connectionSchemaMetadata";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConnectionSchemaMetadataResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Get action.</summary>
                    /// <param name="name">
                    /// Required. Resource name format:
                    /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                    /// </param>
                    public virtual GetActionRequest GetAction(string name)
                    {
                        return new GetActionRequest(this.service, name);
                    }

                    /// <summary>Get action.</summary>
                    public class GetActionRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new GetAction request.</summary>
                        public GetActionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name format:
                        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. Id of the action.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("actionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ActionId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getAction";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:getAction";

                        /// <summary>Initializes GetAction parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/connectionSchemaMetadata$",
                            });
                            RequestParameters.Add("actionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "actionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Get entity type.</summary>
                    /// <param name="name">
                    /// Required. Resource name format:
                    /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                    /// </param>
                    public virtual GetEntityTypeRequest GetEntityType(string name)
                    {
                        return new GetEntityTypeRequest(this.service, name);
                    }

                    /// <summary>Get entity type.</summary>
                    public class GetEntityTypeRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new GetEntityType request.</summary>
                        public GetEntityTypeRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name format:
                        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. Id of the entity type.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("entityId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string EntityId { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getEntityType";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:getEntityType";

                        /// <summary>Initializes GetEntityType parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/connectionSchemaMetadata$",
                            });
                            RequestParameters.Add("entityId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "entityId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>List actions.</summary>
                    /// <param name="name">
                    /// Required. Resource name format.
                    /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                    /// </param>
                    public virtual ListActionsRequest ListActions(string name)
                    {
                        return new ListActionsRequest(this.service, name);
                    }

                    /// <summary>List actions.</summary>
                    public class ListActionsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListActionsResponse>
                    {
                        /// <summary>Constructs a new ListActions request.</summary>
                        public ListActionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name format.
                        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. Filter Wildcards are not supported in the filter currently.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Page size. If unspecified, at most 50 actions will be returned.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Specifies which fields are returned in response. Defaults to BASIC view.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Specifies which fields are returned in response. Defaults to BASIC view.</summary>
                        public enum ViewEnum
                        {
                            /// <summary></summary>
                            [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                            VIEWUNSPECIFIED = 0,

                            /// <summary></summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "listActions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:listActions";

                        /// <summary>Initializes ListActions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/connectionSchemaMetadata$",
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

                    /// <summary>List entity types.</summary>
                    /// <param name="name">
                    /// Required. Resource name format:
                    /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                    /// </param>
                    public virtual ListEntityTypesRequest ListEntityTypes(string name)
                    {
                        return new ListEntityTypesRequest(this.service, name);
                    }

                    /// <summary>List entity types.</summary>
                    public class ListEntityTypesRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListEntityTypesResponse>
                    {
                        /// <summary>Constructs a new ListEntityTypes request.</summary>
                        public ListEntityTypesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name format:
                        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. Filter Wildcards are not supported in the filter currently.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Page size. If unspecified, at most 50 entity types will be returned.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Specifies which fields are returned in response. Defaults to BASIC view.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Specifies which fields are returned in response. Defaults to BASIC view.</summary>
                        public enum ViewEnum
                        {
                            /// <summary></summary>
                            [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                            VIEWUNSPECIFIED = 0,

                            /// <summary></summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC")]
                            BASIC = 1,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "listEntityTypes";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:listEntityTypes";

                        /// <summary>Initializes ListEntityTypes parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/connectionSchemaMetadata$",
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

                    /// <summary>Refresh runtime schema of a connection.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Resource name. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                    /// </param>
                    public virtual RefreshRequest Refresh(Google.Apis.Connectors.v1.Data.RefreshConnectionSchemaMetadataRequest body, string name)
                    {
                        return new RefreshRequest(this.service, body, name);
                    }

                    /// <summary>Refresh runtime schema of a connection.</summary>
                    public class RefreshRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Refresh request.</summary>
                        public RefreshRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.RefreshConnectionSchemaMetadataRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.RefreshConnectionSchemaMetadataRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "refresh";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:refresh";

                        /// <summary>Initializes Refresh parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/connectionSchemaMetadata$",
                            });
                        }
                    }
                }

                /// <summary>Gets the EndUserAuthentications resource.</summary>
                public virtual EndUserAuthenticationsResource EndUserAuthentications { get; }

                /// <summary>The "endUserAuthentications" collection of methods.</summary>
                public class EndUserAuthenticationsResource
                {
                    private const string Resource = "endUserAuthentications";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EndUserAuthenticationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a new EndUserAuthentication in a given project,location and connection.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Parent resource of the EndUserAuthentication, of the form:
                    /// `projects/*/locations/*/connections/*`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Connectors.v1.Data.EndUserAuthentication body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new EndUserAuthentication in a given project,location and connection.
                    /// </summary>
                    public class CreateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.EndUserAuthentication body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the EndUserAuthentication, of the form:
                        /// `projects/*/locations/*/connections/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Identifier to assign to the EndUserAuthentication. Must be unique within scope of
                        /// the parent resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("endUserAuthenticationId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string EndUserAuthenticationId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.EndUserAuthentication Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/endUserAuthentications";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                            });
                            RequestParameters.Add("endUserAuthenticationId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "endUserAuthenticationId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single EndUserAuthentication.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form:
                    /// `projects/*/locations/*/connections/*/endUserAuthentication/*`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single EndUserAuthentication.</summary>
                    public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/*/locations/*/connections/*/endUserAuthentication/*`
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/endUserAuthentications/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single EndUserAuthentication.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form:
                    /// `projects/*/locations/*/connections/*/EndUserAuthentications/*`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single EndUserAuthentication.</summary>
                    public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.EndUserAuthentication>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/*/locations/*/connections/*/EndUserAuthentications/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Optional. View of the EndUserAuthentication to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Optional. View of the EndUserAuthentication to return.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>END_USER_AUTHENTICATION_UNSPECIFIED.</summary>
                            [Google.Apis.Util.StringValueAttribute("END_USER_AUTHENTICATION_VIEW_UNSPECIFIED")]
                            ENDUSERAUTHENTICATIONVIEWUNSPECIFIED = 0,

                            /// <summary>Do not include secret fields.</summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC_VIEW")]
                            BASICVIEW = 1,

                            /// <summary>Include secret fields.</summary>
                            [Google.Apis.Util.StringValueAttribute("FULL_VIEW")]
                            FULLVIEW = 2,
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/endUserAuthentications/[^/]+$",
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

                    /// <summary>List EndUserAuthentications in a given project,location and connection.</summary>
                    /// <param name="parent">
                    /// Required. Parent resource of the EndUserAuthentication, of the form:
                    /// `projects/*/locations/*/connections/*`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List EndUserAuthentications in a given project,location and connection.</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListEndUserAuthenticationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the EndUserAuthentication, of the form:
                        /// `projects/*/locations/*/connections/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Order by parameters.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/endUserAuthentications";

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

                    /// <summary>Updates the parameters of a single EndUserAuthentication.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Identifier. Resource name of the EndUserAuthentication. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}/endUserAuthentications/{end_user_authentication}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Connectors.v1.Data.EndUserAuthentication body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the parameters of a single EndUserAuthentication.</summary>
                    public class PatchRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.EndUserAuthentication body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Identifier. Resource name of the EndUserAuthentication. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/endUserAuthentications/{end_user_authentication}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. The list of fields to update. A field will be overwritten if it is in the mask.
                        /// You can modify only the fields listed below. To update the EndUserAuthentication details: *
                        /// `notify_endpoint_destination`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.EndUserAuthentication Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/endUserAuthentications/[^/]+$",
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

                /// <summary>Gets the EventSubscriptions resource.</summary>
                public virtual EventSubscriptionsResource EventSubscriptions { get; }

                /// <summary>The "eventSubscriptions" collection of methods.</summary>
                public class EventSubscriptionsResource
                {
                    private const string Resource = "eventSubscriptions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EventSubscriptionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new EventSubscription in a given project,location and connection.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Parent resource of the EventSubscription, of the form:
                    /// `projects/*/locations/*/connections/*`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Connectors.v1.Data.EventSubscription body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new EventSubscription in a given project,location and connection.</summary>
                    public class CreateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.EventSubscription body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the EventSubscription, of the form:
                        /// `projects/*/locations/*/connections/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Identifier to assign to the Event Subscription. Must be unique within scope of the
                        /// parent resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("eventSubscriptionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string EventSubscriptionId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.EventSubscription Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/eventSubscriptions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                            });
                            RequestParameters.Add("eventSubscriptionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "eventSubscriptionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single EventSubscription.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form: `projects/*/locations/*/connections/*/eventsubscriptions/*`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single EventSubscription.</summary>
                    public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/*/locations/*/connections/*/eventsubscriptions/*`
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/eventSubscriptions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single EventSubscription.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form: `projects/*/locations/*/connections/*/eventSubscriptions/*`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single EventSubscription.</summary>
                    public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.EventSubscription>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/*/locations/*/connections/*/eventSubscriptions/*`
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/eventSubscriptions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List EventSubscriptions in a given project,location and connection.</summary>
                    /// <param name="parent">
                    /// Required. Parent resource of the EventSubscription, of the form:
                    /// `projects/*/locations/*/connections/*`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List EventSubscriptions in a given project,location and connection.</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListEventSubscriptionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the EventSubscription, of the form:
                        /// `projects/*/locations/*/connections/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Order by parameters.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/eventSubscriptions";

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

                    /// <summary>Updates the parameters of a single EventSubscription.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Identifier. Resource name of the EventSubscription. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}/eventSubscriptions/{event_subscription}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Connectors.v1.Data.EventSubscription body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the parameters of a single EventSubscription.</summary>
                    public class PatchRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.EventSubscription body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Identifier. Resource name of the EventSubscription. Format:
                        /// projects/{project}/locations/{location}/connections/{connection}/eventSubscriptions/{event_subscription}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. The list of fields to update. Fields are specified relative to the Subscription. A
                        /// field will be overwritten if it is in the mask. You can modify only the fields listed below.
                        /// To update the EventSubscription details: * `serviceAccount`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.EventSubscription Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/eventSubscriptions/[^/]+$",
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

                    /// <summary>RetryEventSubscription retries the registration of Subscription.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Resource name of the form: `projects/*/locations/*/connections/*/eventSubscriptions/*`
                    /// </param>
                    public virtual RetryRequest Retry(Google.Apis.Connectors.v1.Data.RetryEventSubscriptionRequest body, string name)
                    {
                        return new RetryRequest(this.service, body, name);
                    }

                    /// <summary>RetryEventSubscription retries the registration of Subscription.</summary>
                    public class RetryRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Retry request.</summary>
                        public RetryRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.RetryEventSubscriptionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/*/locations/*/connections/*/eventSubscriptions/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.RetryEventSubscriptionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "retry";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:retry";

                        /// <summary>Initializes Retry parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/eventSubscriptions/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the RuntimeActionSchemas resource.</summary>
                public virtual RuntimeActionSchemasResource RuntimeActionSchemas { get; }

                /// <summary>The "runtimeActionSchemas" collection of methods.</summary>
                public class RuntimeActionSchemasResource
                {
                    private const string Resource = "runtimeActionSchemas";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RuntimeActionSchemasResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>List schema of a runtime actions filtered by action name.</summary>
                    /// <param name="parent">
                    /// Required. Parent resource of RuntimeActionSchema Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List schema of a runtime actions filtered by action name.</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListRuntimeActionSchemasResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of RuntimeActionSchema Format:
                        /// projects/{project}/locations/{location}/connections/{connection}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Filter Format: action="{actionId}" Only action field is supported with literal
                        /// equality operator. Accepted filter example: action="CancelOrder" Wildcards are not supported
                        /// in the filter currently.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Optional. Flag to indicate if schema should be returned as string or not</summary>
                        [Google.Apis.Util.RequestParameterAttribute("schemaAsString", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> SchemaAsString { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/runtimeActionSchemas";

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
                            RequestParameters.Add("schemaAsString", new Google.Apis.Discovery.Parameter
                            {
                                Name = "schemaAsString",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the RuntimeEntitySchemas resource.</summary>
                public virtual RuntimeEntitySchemasResource RuntimeEntitySchemas { get; }

                /// <summary>The "runtimeEntitySchemas" collection of methods.</summary>
                public class RuntimeEntitySchemasResource
                {
                    private const string Resource = "runtimeEntitySchemas";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RuntimeEntitySchemasResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>List schema of a runtime entities filtered by entity name.</summary>
                    /// <param name="parent">
                    /// Required. Parent resource of RuntimeEntitySchema Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List schema of a runtime entities filtered by entity name.</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListRuntimeEntitySchemasResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of RuntimeEntitySchema Format:
                        /// projects/{project}/locations/{location}/connections/{connection}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Filter Format: entity="{entityId}" Only entity field is supported with literal
                        /// equality operator. Accepted filter example: entity="Order" Wildcards are not supported in
                        /// the filter currently.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/runtimeEntitySchemas";

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

                /// <summary>Creates a new Connection in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource of the Connection, of the form: `projects/*/locations/*`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Connectors.v1.Data.Connection body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Connection in a given project and location.</summary>
                public class CreateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.Connection body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the Connection, of the form: `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Identifier to assign to the Connection. Must be unique within scope of the parent
                    /// resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectionId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.Connection Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connections";

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
                        RequestParameters.Add("connectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connectionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Connection.</summary>
                /// <param name="name">
                /// Required. Resource name of the form: `projects/*/locations/*/connections/*`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Connection.</summary>
                public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the form: `projects/*/locations/*/connections/*`</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single Connection.</summary>
                /// <param name="name">
                /// Required. Resource name of the form: `projects/*/locations/*/connections/*`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Connection.</summary>
                public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Connection>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the form: `projects/*/locations/*/connections/*`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Specifies which fields of the Connection are returned in the response. Defaults to `BASIC` view.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Specifies which fields of the Connection are returned in the response. Defaults to `BASIC` view.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>CONNECTION_UNSPECIFIED.</summary>
                        [Google.Apis.Util.StringValueAttribute("CONNECTION_VIEW_UNSPECIFIED")]
                        CONNECTIONVIEWUNSPECIFIED = 0,

                        /// <summary>Do not include runtime required configs.</summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>Include runtime required configs.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
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
                /// Gets schema metadata of a connection. SchemaMetadata is a singleton resource for each connection.
                /// </summary>
                /// <param name="name">
                /// Required. Connection name Format:
                /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                /// </param>
                public virtual GetConnectionSchemaMetadataRequest GetConnectionSchemaMetadata(string name)
                {
                    return new GetConnectionSchemaMetadataRequest(this.service, name);
                }

                /// <summary>
                /// Gets schema metadata of a connection. SchemaMetadata is a singleton resource for each connection.
                /// </summary>
                public class GetConnectionSchemaMetadataRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ConnectionSchemaMetadata>
                {
                    /// <summary>Constructs a new GetConnectionSchemaMetadata request.</summary>
                    public GetConnectionSchemaMetadataRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Connection name Format:
                    /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getConnectionSchemaMetadata";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes GetConnectionSchemaMetadata parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/connectionSchemaMetadata$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
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
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Policy>
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
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
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

                /// <summary>Lists Connections in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent resource of the Connection, of the form: `projects/*/locations/*`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Connections in a given project and location.</summary>
                public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListConnectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the Connection, of the form: `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order by parameters.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Specifies which fields of the Connection are returned in the response. Defaults to `BASIC` view.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Specifies which fields of the Connection are returned in the response. Defaults to `BASIC` view.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>CONNECTION_UNSPECIFIED.</summary>
                        [Google.Apis.Util.StringValueAttribute("CONNECTION_VIEW_UNSPECIFIED")]
                        CONNECTIONVIEWUNSPECIFIED = 0,

                        /// <summary>Do not include runtime required configs.</summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 1,

                        /// <summary>Include runtime required configs.</summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connections";

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

                /// <summary>ListenEvent listens to the event.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resourcePath">Required. Resource path for request.</param>
                public virtual ListenEventRequest ListenEvent(Google.Apis.Connectors.v1.Data.ListenEventRequest body, string resourcePath)
                {
                    return new ListenEventRequest(this.service, body, resourcePath);
                }

                /// <summary>ListenEvent listens to the event.</summary>
                public class ListenEventRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListenEventResponse>
                {
                    /// <summary>Constructs a new ListenEvent request.</summary>
                    public ListenEventRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.ListenEventRequest body, string resourcePath) : base(service)
                    {
                        ResourcePath = resourcePath;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Resource path for request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("resourcePath", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ResourcePath { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.ListenEventRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listenEvent";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resourcePath}:listenEvent";

                    /// <summary>Initializes ListenEvent parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resourcePath", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resourcePath",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the parameters of a single Connection.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of the Connection. Format:
                /// projects/{project}/locations/{location}/connections/{connection}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Connectors.v1.Data.Connection body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Connection.</summary>
                public class PatchRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.Connection body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of the Connection. Format:
                    /// projects/{project}/locations/{location}/connections/{connection}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The list of fields to update. Fields are specified relative to the connection. A field
                    /// will be overwritten if it is in the mask. The field mask must not be empty, and it must not
                    /// contain fields that are immutable or only set by the server. You can modify only the fields
                    /// listed below. To lock/unlock a connection: * `lock_config` To suspend/resume a connection: *
                    /// `suspended` To update the connection details: * `description` * `labels` * `connector_version` *
                    /// `config_variables` * `auth_config` * `destination_configs` * `node_config` * `log_config` *
                    /// `ssl_config` * `eventing_enablement_type` * `eventing_config` * `auth_override_enabled`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.Connection Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
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

                /// <summary>RepaiEventing tries to repair eventing related event subscriptions.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the form: `projects/*/locations/*/connections/*`
                /// </param>
                public virtual RepairEventingRequest RepairEventing(Google.Apis.Connectors.v1.Data.RepairEventingRequest body, string name)
                {
                    return new RepairEventingRequest(this.service, body, name);
                }

                /// <summary>RepaiEventing tries to repair eventing related event subscriptions.</summary>
                public class RepairEventingRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                {
                    /// <summary>Constructs a new RepairEventing request.</summary>
                    public RepairEventingRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.RepairEventingRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the form: `projects/*/locations/*/connections/*`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.RepairEventingRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "repairEventing";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:repairEventing";

                    /// <summary>Initializes RepairEventing parameter list.</summary>
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

                /// <summary>Returns Top matching Connections for a given query.</summary>
                /// <param name="name">
                /// Required. Parent resource of the Connection, of the form: `projects/*/locations/*/connections`
                /// </param>
                public virtual SearchRequest Search(string name)
                {
                    return new SearchRequest(this.service, name);
                }

                /// <summary>Returns Top matching Connections for a given query.</summary>
                public class SearchRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.SearchConnectionsResponse>
                {
                    /// <summary>Constructs a new Search request.</summary>
                    public SearchRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the Connection, of the form: `projects/*/locations/*/connections`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Optional. The number of top matching connectors to return</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. page_token</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Required. The query against which the search needs to be done.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Query { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "search";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:search";

                    /// <summary>Initializes Search parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections$",
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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Connectors.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Connectors.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
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
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Connectors.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Connectors.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the CustomConnectors resource.</summary>
            public virtual CustomConnectorsResource CustomConnectors { get; }

            /// <summary>The "customConnectors" collection of methods.</summary>
            public class CustomConnectorsResource
            {
                private const string Resource = "customConnectors";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomConnectorsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    CustomConnectorVersions = new CustomConnectorVersionsResource(service);
                }

                /// <summary>Gets the CustomConnectorVersions resource.</summary>
                public virtual CustomConnectorVersionsResource CustomConnectorVersions { get; }

                /// <summary>The "customConnectorVersions" collection of methods.</summary>
                public class CustomConnectorVersionsResource
                {
                    private const string Resource = "customConnectorVersions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CustomConnectorVersionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a single CustomConnectorVersion.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form:
                    /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single CustomConnectorVersion.</summary>
                    public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}`
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/customConnectors/[^/]+/customConnectorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deprecates a single CustomConnectorVersion.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Resource name of the form:
                    /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}`
                    /// </param>
                    public virtual DeprecateRequest Deprecate(Google.Apis.Connectors.v1.Data.DeprecateCustomConnectorVersionRequest body, string name)
                    {
                        return new DeprecateRequest(this.service, body, name);
                    }

                    /// <summary>Deprecates a single CustomConnectorVersion.</summary>
                    public class DeprecateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Deprecate request.</summary>
                        public DeprecateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.DeprecateCustomConnectorVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.DeprecateCustomConnectorVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "deprecate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:deprecate";

                        /// <summary>Initializes Deprecate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/customConnectors/[^/]+/customConnectorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Publish request for the CustomConnectorVersion. Once approved, the CustomConnectorVersion will
                    /// be published as PartnerConnector.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Resource name of the form:
                    /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}`
                    /// </param>
                    public virtual PublishRequest Publish(Google.Apis.Connectors.v1.Data.PublishCustomConnectorVersionRequest body, string name)
                    {
                        return new PublishRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Publish request for the CustomConnectorVersion. Once approved, the CustomConnectorVersion will
                    /// be published as PartnerConnector.
                    /// </summary>
                    public class PublishRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Publish request.</summary>
                        public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.PublishCustomConnectorVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.PublishCustomConnectorVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "publish";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:publish";

                        /// <summary>Initializes Publish parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/customConnectors/[^/]+/customConnectorVersions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Withdraw the publish request for the CustomConnectorVersion. This can only be used before the
                    /// CustomConnectorVersion is published.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. Resource name of the form:
                    /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}`
                    /// </param>
                    public virtual WithdrawRequest Withdraw(Google.Apis.Connectors.v1.Data.WithdrawCustomConnectorVersionRequest body, string name)
                    {
                        return new WithdrawRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Withdraw the publish request for the CustomConnectorVersion. This can only be used before the
                    /// CustomConnectorVersion is published.
                    /// </summary>
                    public class WithdrawRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Withdraw request.</summary>
                        public WithdrawRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.WithdrawCustomConnectorVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.WithdrawCustomConnectorVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "withdraw";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:withdraw";

                        /// <summary>Initializes Withdraw parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/customConnectors/[^/]+/customConnectorVersions/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Validates a Custom Connector Spec.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Location at which the custom connector is being created.</param>
                public virtual ValidateCustomConnectorSpecRequest ValidateCustomConnectorSpec(Google.Apis.Connectors.v1.Data.ValidateCustomConnectorSpecRequest body, string parent)
                {
                    return new ValidateCustomConnectorSpecRequest(this.service, body, parent);
                }

                /// <summary>Validates a Custom Connector Spec.</summary>
                public class ValidateCustomConnectorSpecRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ValidateCustomConnectorSpecResponse>
                {
                    /// <summary>Constructs a new ValidateCustomConnectorSpec request.</summary>
                    public ValidateCustomConnectorSpecRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.ValidateCustomConnectorSpecRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Location at which the custom connector is being created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.ValidateCustomConnectorSpecRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "validateCustomConnectorSpec";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customConnectors:validateCustomConnectorSpec";

                    /// <summary>Initializes ValidateCustomConnectorSpec parameter list.</summary>
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

            /// <summary>Gets the EndpointAttachments resource.</summary>
            public virtual EndpointAttachmentsResource EndpointAttachments { get; }

            /// <summary>The "endpointAttachments" collection of methods.</summary>
            public class EndpointAttachmentsResource
            {
                private const string Resource = "endpointAttachments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EndpointAttachmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new EndpointAttachment in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource of the EndpointAttachment, of the form: `projects/*/locations/*`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Connectors.v1.Data.EndpointAttachment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new EndpointAttachment in a given project and location.</summary>
                public class CreateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.EndpointAttachment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the EndpointAttachment, of the form: `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Identifier to assign to the EndpointAttachment. Must be unique within scope of the
                    /// parent resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("endpointAttachmentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EndpointAttachmentId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.EndpointAttachment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/endpointAttachments";

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
                        RequestParameters.Add("endpointAttachmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endpointAttachmentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single EndpointAttachment.</summary>
                /// <param name="name">
                /// Required. Resource name of the form: `projects/*/locations/*/endpointAttachments/*`
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single EndpointAttachment.</summary>
                public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the form: `projects/*/locations/*/endpointAttachments/*`
                    /// </summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointAttachments/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets details of a single EndpointAttachment.</summary>
                /// <param name="name">
                /// Required. Resource name of the form: `projects/*/locations/*/endpointAttachments/*`
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single EndpointAttachment.</summary>
                public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.EndpointAttachment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the form: `projects/*/locations/*/endpointAttachments/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Specifies which fields of the EndpointAttachment are returned in the response.
                    /// Defaults to `ENDPOINT_ATTACHMENT_VIEW_BASIC` view.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Optional. Specifies which fields of the EndpointAttachment are returned in the response.
                    /// Defaults to `ENDPOINT_ATTACHMENT_VIEW_BASIC` view.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>ENDPOINT_ATTACHMENT_VIEW_UNSPECIFIED.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENDPOINT_ATTACHMENT_VIEW_UNSPECIFIED")]
                        ENDPOINTATTACHMENTVIEWUNSPECIFIED = 0,

                        /// <summary>Do not include status.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENDPOINT_ATTACHMENT_VIEW_BASIC")]
                        ENDPOINTATTACHMENTVIEWBASIC = 1,

                        /// <summary>Includes Status.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENDPOINT_ATTACHMENT_VIEW_FULL")]
                        ENDPOINTATTACHMENTVIEWFULL = 2,
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointAttachments/[^/]+$",
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

                /// <summary>List EndpointAttachments in a given project</summary>
                /// <param name="parent">
                /// Required. Parent resource od the EndpointAttachment, of the form: `projects/*/locations/*`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List EndpointAttachments in a given project</summary>
                public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListEndpointAttachmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource od the EndpointAttachment, of the form: `projects/*/locations/*`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Filter.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Order by parameters.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. Specifies which fields of the EndpointAttachment are returned in the response.
                    /// Defaults to `ENDPOINT_ATTACHMENT_VIEW_BASIC` view.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>
                    /// Optional. Specifies which fields of the EndpointAttachment are returned in the response.
                    /// Defaults to `ENDPOINT_ATTACHMENT_VIEW_BASIC` view.
                    /// </summary>
                    public enum ViewEnum
                    {
                        /// <summary>ENDPOINT_ATTACHMENT_VIEW_UNSPECIFIED.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENDPOINT_ATTACHMENT_VIEW_UNSPECIFIED")]
                        ENDPOINTATTACHMENTVIEWUNSPECIFIED = 0,

                        /// <summary>Do not include status.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENDPOINT_ATTACHMENT_VIEW_BASIC")]
                        ENDPOINTATTACHMENTVIEWBASIC = 1,

                        /// <summary>Includes Status.</summary>
                        [Google.Apis.Util.StringValueAttribute("ENDPOINT_ATTACHMENT_VIEW_FULL")]
                        ENDPOINTATTACHMENTVIEWFULL = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/endpointAttachments";

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

                /// <summary>Updates the parameters of a single EndpointAttachment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of the Endpoint Attachment. Format:
                /// projects/{project}/locations/{location}/endpointAttachments/{endpoint_attachment}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Connectors.v1.Data.EndpointAttachment body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single EndpointAttachment.</summary>
                public class PatchRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.EndpointAttachment body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of the Endpoint Attachment. Format:
                    /// projects/{project}/locations/{location}/endpointAttachments/{endpoint_attachment}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The list of fields to update. Fields are specified relative to the endpointAttachment.
                    /// A field will be overwritten if it is in the mask. You can modify only the fields listed below.
                    /// To update the endpointAttachment details: * `description` * `labels`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.EndpointAttachment Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/endpointAttachments/[^/]+$",
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

            /// <summary>Gets the Global resource.</summary>
            public virtual GlobalResource Global { get; }

            /// <summary>The "global" collection of methods.</summary>
            public class GlobalResource
            {
                private const string Resource = "global";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GlobalResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    CustomConnectors = new CustomConnectorsResource(service);
                    ManagedZones = new ManagedZonesResource(service);
                }

                /// <summary>Gets the CustomConnectors resource.</summary>
                public virtual CustomConnectorsResource CustomConnectors { get; }

                /// <summary>The "customConnectors" collection of methods.</summary>
                public class CustomConnectorsResource
                {
                    private const string Resource = "customConnectors";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CustomConnectorsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        CustomConnectorVersions = new CustomConnectorVersionsResource(service);
                    }

                    /// <summary>Gets the CustomConnectorVersions resource.</summary>
                    public virtual CustomConnectorVersionsResource CustomConnectorVersions { get; }

                    /// <summary>The "customConnectorVersions" collection of methods.</summary>
                    public class CustomConnectorVersionsResource
                    {
                        private const string Resource = "customConnectorVersions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public CustomConnectorVersionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a new CustomConnectorVersion in a given project and location.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. Parent resource of the CreateCustomConnector, of the form:
                        /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}`
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.Connectors.v1.Data.CustomConnectorVersion body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>Creates a new CustomConnectorVersion in a given project and location.</summary>
                        public class CreateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.CustomConnectorVersion body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Parent resource of the CreateCustomConnector, of the form:
                            /// `projects/{project}/locations/{location}/customConnectors/{custom_connector}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. Identifier to assign to the CreateCustomConnectorVersion. Must be unique
                            /// within scope of the parent resource.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("customConnectorVersionId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string CustomConnectorVersionId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Connectors.v1.Data.CustomConnectorVersion Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/customConnectorVersions";

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
                                    Pattern = @"^projects/[^/]+/locations/global/customConnectors/[^/]+$",
                                });
                                RequestParameters.Add("customConnectorVersionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "customConnectorVersionId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Gets details of a single CustomConnectorVersion.</summary>
                        /// <param name="name">
                        /// Required. Resource name of the form:
                        /// `projects/*/locations/{location}/customConnectors/*/customConnectorVersions/*`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a single CustomConnectorVersion.</summary>
                        public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.CustomConnectorVersion>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Resource name of the form:
                            /// `projects/*/locations/{location}/customConnectors/*/customConnectorVersions/*`
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
                                    Pattern = @"^projects/[^/]+/locations/global/customConnectors/[^/]+/customConnectorVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>List CustomConnectorVersions in a given project</summary>
                        /// <param name="parent">
                        /// Required. Parent resource of the connectors, of the form:
                        /// `projects/*/locations/{location}/customConnectors/*/customConnectorVersions/*`
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>List CustomConnectorVersions in a given project</summary>
                        public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListCustomConnectorVersionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Parent resource of the connectors, of the form:
                            /// `projects/*/locations/{location}/customConnectors/*/customConnectorVersions/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Page size.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>Page token.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/customConnectorVersions";

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
                                    Pattern = @"^projects/[^/]+/locations/global/customConnectors/[^/]+$",
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

                    /// <summary>Creates a new CustomConnector in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Parent resource of the CreateCustomConnector, of the form:
                    /// `projects/{project}/locations/*`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Connectors.v1.Data.CustomConnector body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new CustomConnector in a given project and location.</summary>
                    public class CreateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.CustomConnector body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the CreateCustomConnector, of the form:
                        /// `projects/{project}/locations/*`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Identifier to assign to the CreateCustomConnector. Must be unique within scope of
                        /// the parent resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("customConnectorId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string CustomConnectorId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.CustomConnector Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/customConnectors";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
                            });
                            RequestParameters.Add("customConnectorId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "customConnectorId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single CustomConnector.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form:
                    /// `projects/{project}/locations/{location}/customConnectors/{connector}`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single CustomConnector.</summary>
                    public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form:
                        /// `projects/{project}/locations/{location}/customConnectors/{connector}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. If set to true, any customConnectorVersion which is a child resource will also be
                        /// deleted. https://aip.dev/135#cascading-delete
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
                                Pattern = @"^projects/[^/]+/locations/global/customConnectors/[^/]+$",
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

                    /// <summary>Gets details of a single CustomConnector.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form: `projects/*/locations/*/customConnectors/*`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single CustomConnector.</summary>
                    public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.CustomConnector>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form: `projects/*/locations/*/customConnectors/*`
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
                                Pattern = @"^projects/[^/]+/locations/global/customConnectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List CustomConnectorVersions in a given project</summary>
                    /// <param name="parent">
                    /// Required. Parent resource of the custom connectors, of the form: `projects/*/locations/*` Only
                    /// global location is supported for CustomConnector resource.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List CustomConnectorVersions in a given project</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListCustomConnectorsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the custom connectors, of the form: `projects/*/locations/*`
                        /// Only global location is supported for CustomConnector resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filter string.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/customConnectors";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
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

                    /// <summary>Updates the parameters of a CustomConnector.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Identifier. Resource name of the CustomConnector. Format:
                    /// projects/{project}/locations/{location}/customConnectors/{connector}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Connectors.v1.Data.CustomConnector body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the parameters of a CustomConnector.</summary>
                    public class PatchRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.CustomConnector body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Identifier. Resource name of the CustomConnector. Format:
                        /// projects/{project}/locations/{location}/customConnectors/{connector}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Field mask is used to specify the fields to be overwritten in the Connector
                        /// resource by the update. The fields specified in the update_mask are relative to the
                        /// resource, not the full request. A field will be overwritten if it is in the mask. Set the
                        /// mask as "*" for full replacement, which means all fields will be overwritten.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.CustomConnector Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/customConnectors/[^/]+$",
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

                /// <summary>Gets the ManagedZones resource.</summary>
                public virtual ManagedZonesResource ManagedZones { get; }

                /// <summary>The "managedZones" collection of methods.</summary>
                public class ManagedZonesResource
                {
                    private const string Resource = "managedZones";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ManagedZonesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new ManagedZone in a given project and location.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. Parent resource of the ManagedZone, of the form: `projects/*/locations/global`
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.Connectors.v1.Data.ManagedZone body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new ManagedZone in a given project and location.</summary>
                    public class CreateRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.ManagedZone body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the ManagedZone, of the form: `projects/*/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. Identifier to assign to the ManagedZone. Must be unique within scope of the parent
                        /// resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("managedZoneId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ManagedZoneId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.ManagedZone Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/managedZones";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
                            });
                            RequestParameters.Add("managedZoneId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "managedZoneId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single ManagedZone.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form: `projects/*/locations/global/managedZones/*`
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single ManagedZone.</summary>
                    public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form: `projects/*/locations/global/managedZones/*`
                        /// </summary>
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
                                Pattern = @"^projects/[^/]+/locations/global/managedZones/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single ManagedZone.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form: `projects/*/locations/global/managedZones/*`
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single ManagedZone.</summary>
                    public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ManagedZone>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form: `projects/*/locations/global/managedZones/*`
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
                                Pattern = @"^projects/[^/]+/locations/global/managedZones/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List ManagedZones in a given project</summary>
                    /// <param name="parent">
                    /// Required. Parent resource of the Managed Zone, of the form: `projects/*/locations/global`
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List ManagedZones in a given project</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListManagedZonesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the Managed Zone, of the form: `projects/*/locations/global`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Order by parameters.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>
                        /// Optional. If true, allow partial responses for multi-regional Aggregated List requests.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("returnPartialSuccess", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ReturnPartialSuccess { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/managedZones";

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
                                Pattern = @"^projects/[^/]+/locations/global$",
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

                    /// <summary>Updates the parameters of a single ManagedZone.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Resource name of the Managed Zone. Format:
                    /// projects/{project}/locations/global/managedZones/{managed_zone}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Connectors.v1.Data.ManagedZone body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Updates the parameters of a single ManagedZone.</summary>
                    public class PatchRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.ManagedZone body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Resource name of the Managed Zone. Format:
                        /// projects/{project}/locations/global/managedZones/{managed_zone}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. The list of fields to update. Fields are specified relative to the managedZone. A
                        /// field will be overwritten if it is in the mask. You can modify only the fields listed below.
                        /// To update the managedZone details: * `description` * `labels` * `target_project` *
                        /// `target_network`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Connectors.v1.Data.ManagedZone Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/global/managedZones/[^/]+$",
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

                /// <summary>
                /// GetGlobalSettings gets settings of a project. GlobalSettings is a singleton resource.
                /// </summary>
                /// <param name="name">Required. The resource name of the Settings.</param>
                public virtual GetSettingsRequest GetSettings(string name)
                {
                    return new GetSettingsRequest(this.service, name);
                }

                /// <summary>
                /// GetGlobalSettings gets settings of a project. GlobalSettings is a singleton resource.
                /// </summary>
                public class GetSettingsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Settings>
                {
                    /// <summary>Constructs a new GetSettings request.</summary>
                    public GetSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the Settings.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes GetSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/global/settings$",
                        });
                    }
                }

                /// <summary>Update the global settings of a project.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Resource name of the Connection. Format: projects/{project}/locations/global/settings}
                /// </param>
                public virtual UpdateSettingsRequest UpdateSettings(Google.Apis.Connectors.v1.Data.Settings body, string name)
                {
                    return new UpdateSettingsRequest(this.service, body, name);
                }

                /// <summary>Update the global settings of a project.</summary>
                public class UpdateSettingsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
                {
                    /// <summary>Constructs a new UpdateSettings request.</summary>
                    public UpdateSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.Settings body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Resource name of the Connection. Format:
                    /// projects/{project}/locations/global/settings}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.Settings Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/global/settings$",
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
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.Connectors.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Connectors.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Empty>
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
                public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
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
                public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListOperationsResponse>
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
                    }
                }
            }

            /// <summary>Gets the Providers resource.</summary>
            public virtual ProvidersResource Providers { get; }

            /// <summary>The "providers" collection of methods.</summary>
            public class ProvidersResource
            {
                private const string Resource = "providers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ProvidersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Connectors = new ConnectorsResource(service);
                }

                /// <summary>Gets the Connectors resource.</summary>
                public virtual ConnectorsResource Connectors { get; }

                /// <summary>The "connectors" collection of methods.</summary>
                public class ConnectorsResource
                {
                    private const string Resource = "connectors";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConnectorsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Versions = new VersionsResource(service);
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
                            Eventtypes = new EventtypesResource(service);
                        }

                        /// <summary>Gets the Eventtypes resource.</summary>
                        public virtual EventtypesResource Eventtypes { get; }

                        /// <summary>The "eventtypes" collection of methods.</summary>
                        public class EventtypesResource
                        {
                            private const string Resource = "eventtypes";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public EventtypesResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;
                            }

                            /// <summary>Gets details of a single event type.</summary>
                            /// <param name="name">
                            /// Required. Resource name of the form:
                            /// `projects/*/locations/*/providers/*/connectors/*/versions/*/eventtypes/*` Only global
                            /// location is supported for EventType resource.
                            /// </param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(this.service, name);
                            }

                            /// <summary>Gets details of a single event type.</summary>
                            public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.EventType>
                            {
                                /// <summary>Constructs a new Get request.</summary>
                                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. Resource name of the form:
                                /// `projects/*/locations/*/providers/*/connectors/*/versions/*/eventtypes/*` Only
                                /// global location is supported for EventType resource.
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+/connectors/[^/]+/versions/[^/]+/eventtypes/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>Lists Event Types in a given Connector Version.</summary>
                            /// <param name="parent">
                            /// Required. Parent resource of the connectors, of the form:
                            /// `projects/*/locations/*/providers/*/connectors/*/versions/*` Only global location is
                            /// supported for EventType resource.
                            /// </param>
                            public virtual ListRequest List(string parent)
                            {
                                return new ListRequest(this.service, parent);
                            }

                            /// <summary>Lists Event Types in a given Connector Version.</summary>
                            public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListEventTypesResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                                {
                                    Parent = parent;
                                    InitParameters();
                                }

                                /// <summary>
                                /// Required. Parent resource of the connectors, of the form:
                                /// `projects/*/locations/*/providers/*/connectors/*/versions/*` Only global location is
                                /// supported for EventType resource.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>Page size.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>Page token.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/eventtypes";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+/connectors/[^/]+/versions/[^/]+$",
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
                        /// fetch and return the list of auth config variables required to override the connection
                        /// backend auth.
                        /// </summary>
                        /// <param name="name">
                        /// Required. Parent resource of the Connector Version, of the form:
                        /// `projects/*/locations/*/providers/*/connectors/*/versions/*`
                        /// </param>
                        public virtual FetchAuthSchemaRequest FetchAuthSchema(string name)
                        {
                            return new FetchAuthSchemaRequest(this.service, name);
                        }

                        /// <summary>
                        /// fetch and return the list of auth config variables required to override the connection
                        /// backend auth.
                        /// </summary>
                        public class FetchAuthSchemaRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.FetchAuthSchemaResponse>
                        {
                            /// <summary>Constructs a new FetchAuthSchema request.</summary>
                            public FetchAuthSchemaRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Parent resource of the Connector Version, of the form:
                            /// `projects/*/locations/*/providers/*/connectors/*/versions/*`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Optional. View of the AuthSchema. The default value is BASIC.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>Optional. View of the AuthSchema. The default value is BASIC.</summary>
                            public enum ViewEnum
                            {
                                /// <summary>Default value.</summary>
                                [Google.Apis.Util.StringValueAttribute("AUTH_SCHEMA_VIEW_UNSPECIFIED")]
                                AUTHSCHEMAVIEWUNSPECIFIED = 0,

                                /// <summary>Basic view of the AuthSchema.</summary>
                                [Google.Apis.Util.StringValueAttribute("BASIC")]
                                BASIC = 1,

                                /// <summary>JSON schema view of the AuthSchema.</summary>
                                [Google.Apis.Util.StringValueAttribute("JSON_SCHEMA")]
                                JSONSCHEMA = 2,

                                /// <summary>EUA Schema view of the AuthSchema.</summary>
                                [Google.Apis.Util.StringValueAttribute("EUA_SCHEMA")]
                                EUASCHEMA = 3,
                            }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "fetchAuthSchema";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:fetchAuthSchema";

                            /// <summary>Initializes FetchAuthSchema parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+/connectors/[^/]+/versions/[^/]+$",
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

                        /// <summary>Gets details of a single connector version.</summary>
                        /// <param name="name">
                        /// Required. Resource name of the form:
                        /// `projects/*/locations/*/providers/*/connectors/*/versions/*` Only global location is
                        /// supported for ConnectorVersion resource.
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Gets details of a single connector version.</summary>
                        public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ConnectorVersion>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Resource name of the form:
                            /// `projects/*/locations/*/providers/*/connectors/*/versions/*` Only global location is
                            /// supported for ConnectorVersion resource.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. Enum to control whether schema enrichment related fields should be included in
                            /// the response.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("schemaView", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<SchemaViewEnum> SchemaView { get; set; }

                            /// <summary>
                            /// Optional. Enum to control whether schema enrichment related fields should be included in
                            /// the response.
                            /// </summary>
                            public enum SchemaViewEnum
                            {
                                /// <summary>VIEW_UNSPECIFIED. The unset value. Defaults to BASIC View.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_SCHEMA_VIEW_UNSPECIFIED")]
                                CONNECTORVERSIONSCHEMAVIEWUNSPECIFIED = 0,

                                /// <summary>Return basic connector version schema.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_SCHEMA_VIEW_BASIC")]
                                CONNECTORVERSIONSCHEMAVIEWBASIC = 1,

                                /// <summary>Return enriched connector version schema.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_SCHEMA_VIEW_ENRICHED")]
                                CONNECTORVERSIONSCHEMAVIEWENRICHED = 2,
                            }

                            /// <summary>
                            /// Specifies which fields of the ConnectorVersion are returned in the response. Defaults to
                            /// `CUSTOMER` view.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>
                            /// Specifies which fields of the ConnectorVersion are returned in the response. Defaults to
                            /// `CUSTOMER` view.
                            /// </summary>
                            public enum ViewEnum
                            {
                                /// <summary>CONNECTOR_VERSION_VIEW_UNSPECIFIED.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_VIEW_UNSPECIFIED")]
                                CONNECTORVERSIONVIEWUNSPECIFIED = 0,

                                /// <summary>Do not include role grant configs.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_VIEW_BASIC")]
                                CONNECTORVERSIONVIEWBASIC = 1,

                                /// <summary>Include role grant configs.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_VIEW_FULL")]
                                CONNECTORVERSIONVIEWFULL = 2,
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+/connectors/[^/]+/versions/[^/]+$",
                                });
                                RequestParameters.Add("schemaView", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "schemaView",
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

                        /// <summary>Lists Connector Versions in a given project and location.</summary>
                        /// <param name="parent">
                        /// Required. Parent resource of the connectors, of the form:
                        /// `projects/*/locations/*/providers/*/connectors/*` Only global location is supported for
                        /// ConnectorVersion resource.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists Connector Versions in a given project and location.</summary>
                        public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListConnectorVersionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Parent resource of the connectors, of the form:
                            /// `projects/*/locations/*/providers/*/connectors/*` Only global location is supported for
                            /// ConnectorVersion resource.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Page size.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>Page token.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// Optional. Enum to control whether schema enrichment related fields should be included in
                            /// the response.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("schemaView", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<SchemaViewEnum> SchemaView { get; set; }

                            /// <summary>
                            /// Optional. Enum to control whether schema enrichment related fields should be included in
                            /// the response.
                            /// </summary>
                            public enum SchemaViewEnum
                            {
                                /// <summary>VIEW_UNSPECIFIED. The unset value. Defaults to BASIC View.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_SCHEMA_VIEW_UNSPECIFIED")]
                                CONNECTORVERSIONSCHEMAVIEWUNSPECIFIED = 0,

                                /// <summary>Return basic connector version schema.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_SCHEMA_VIEW_BASIC")]
                                CONNECTORVERSIONSCHEMAVIEWBASIC = 1,

                                /// <summary>Return enriched connector version schema.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_SCHEMA_VIEW_ENRICHED")]
                                CONNECTORVERSIONSCHEMAVIEWENRICHED = 2,
                            }

                            /// <summary>
                            /// Specifies which fields of the ConnectorVersion are returned in the response. Defaults to
                            /// `BASIC` view.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>
                            /// Specifies which fields of the ConnectorVersion are returned in the response. Defaults to
                            /// `BASIC` view.
                            /// </summary>
                            public enum ViewEnum
                            {
                                /// <summary>CONNECTOR_VERSION_VIEW_UNSPECIFIED.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_VIEW_UNSPECIFIED")]
                                CONNECTORVERSIONVIEWUNSPECIFIED = 0,

                                /// <summary>Do not include role grant configs.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_VIEW_BASIC")]
                                CONNECTORVERSIONVIEWBASIC = 1,

                                /// <summary>Include role grant configs.</summary>
                                [Google.Apis.Util.StringValueAttribute("CONNECTOR_VERSION_VIEW_FULL")]
                                CONNECTORVERSIONVIEWFULL = 2,
                            }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+/connectors/[^/]+$",
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
                                RequestParameters.Add("schemaView", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "schemaView",
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

                    /// <summary>Gets details of a single Connector.</summary>
                    /// <param name="name">
                    /// Required. Resource name of the form: `projects/*/locations/*/providers/*/connectors/*` Only
                    /// global location is supported for Connector resource.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single Connector.</summary>
                    public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Connector>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Resource name of the form: `projects/*/locations/*/providers/*/connectors/*` Only
                        /// global location is supported for Connector resource.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+/connectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Connectors in a given project and location.</summary>
                    /// <param name="parent">
                    /// Required. Parent resource of the connectors, of the form: `projects/*/locations/*/providers/*`
                    /// Only global location is supported for Connector resource.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Connectors in a given project and location.</summary>
                    public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListConnectorsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Parent resource of the connectors, of the form:
                        /// `projects/*/locations/*/providers/*` Only global location is supported for Connector
                        /// resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Filter string.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/connectors";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+$",
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

                /// <summary>Gets details of a provider.</summary>
                /// <param name="name">
                /// Required. Resource name of the form: `projects/*/locations/*/providers/*` Only global location is
                /// supported for Provider resource.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a provider.</summary>
                public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Provider>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the form: `projects/*/locations/*/providers/*` Only global location
                    /// is supported for Provider resource.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
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
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Policy>
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
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+$",
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

                /// <summary>Lists Providers in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent resource of the API, of the form: `projects/*/locations/*` Only global location is
                /// supported for Provider resource.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Providers in a given project and location.</summary>
                public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListProvidersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the API, of the form: `projects/*/locations/*` Only global location
                    /// is supported for Provider resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/providers";

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
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Connectors.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.Connectors.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+$",
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
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Connectors.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.Connectors.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/providers/[^/]+$",
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
            public class GetRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Location>
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
            /// GetRegionalSettings gets settings of a region. RegionalSettings is a singleton resource.
            /// </summary>
            /// <param name="name">Required. The resource name of the Regional Settings.</param>
            public virtual GetRegionalSettingsRequest GetRegionalSettings(string name)
            {
                return new GetRegionalSettingsRequest(this.service, name);
            }

            /// <summary>
            /// GetRegionalSettings gets settings of a region. RegionalSettings is a singleton resource.
            /// </summary>
            public class GetRegionalSettingsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.RegionalSettings>
            {
                /// <summary>Constructs a new GetRegionalSettings request.</summary>
                public GetRegionalSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the Regional Settings.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getRegionalSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetRegionalSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/regionalSettings$",
                    });
                }
            }

            /// <summary>
            /// Gets the runtimeConfig of a location. RuntimeConfig is a singleton resource for each location.
            /// </summary>
            /// <param name="name">Required. Resource name of the form: `projects/*/locations/*/runtimeConfig`</param>
            public virtual GetRuntimeConfigRequest GetRuntimeConfig(string name)
            {
                return new GetRuntimeConfigRequest(this.service, name);
            }

            /// <summary>
            /// Gets the runtimeConfig of a location. RuntimeConfig is a singleton resource for each location.
            /// </summary>
            public class GetRuntimeConfigRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.RuntimeConfig>
            {
                /// <summary>Constructs a new GetRuntimeConfig request.</summary>
                public GetRuntimeConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the form: `projects/*/locations/*/runtimeConfig`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getRuntimeConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetRuntimeConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/runtimeConfig$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.ListLocationsResponse>
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
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
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

            /// <summary>Update the settings of a region.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. Resource name of the Connection. Format:
            /// projects/{project}/locations/{location}/regionalSettings
            /// </param>
            public virtual UpdateRegionalSettingsRequest UpdateRegionalSettings(Google.Apis.Connectors.v1.Data.RegionalSettings body, string name)
            {
                return new UpdateRegionalSettingsRequest(this.service, body, name);
            }

            /// <summary>Update the settings of a region.</summary>
            public class UpdateRegionalSettingsRequest : ConnectorsBaseServiceRequest<Google.Apis.Connectors.v1.Data.Operation>
            {
                /// <summary>Constructs a new UpdateRegionalSettings request.</summary>
                public UpdateRegionalSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.Connectors.v1.Data.RegionalSettings body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. Resource name of the Connection. Format:
                /// projects/{project}/locations/{location}/regionalSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Connectors.v1.Data.RegionalSettings Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateRegionalSettings";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateRegionalSettings parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/regionalSettings$",
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
    }
}
namespace Google.Apis.Connectors.v1.Data
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
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

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

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthConfig defines details of a authentication type.</summary>
    public class AuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List containing additional auth configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariable> AdditionalVariables { get; set; }

        /// <summary>Optional. Identifier key for auth config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authKey")]
        public virtual string AuthKey { get; set; }

        /// <summary>Optional. The type of authentication configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authType")]
        public virtual string AuthType { get; set; }

        /// <summary>Oauth2AuthCodeFlow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2AuthCodeFlow")]
        public virtual Oauth2AuthCodeFlow Oauth2AuthCodeFlow { get; set; }

        /// <summary>Oauth2AuthCodeFlowGoogleManaged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2AuthCodeFlowGoogleManaged")]
        public virtual Oauth2AuthCodeFlowGoogleManaged Oauth2AuthCodeFlowGoogleManaged { get; set; }

        /// <summary>Oauth2ClientCredentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientCredentials")]
        public virtual Oauth2ClientCredentials Oauth2ClientCredentials { get; set; }

        /// <summary>Oauth2JwtBearer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2JwtBearer")]
        public virtual Oauth2JwtBearer Oauth2JwtBearer { get; set; }

        /// <summary>SSH Public Key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKey")]
        public virtual SshPublicKey SshPublicKey { get; set; }

        /// <summary>UserPassword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPassword")]
        public virtual UserPassword UserPassword { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthConfigTemplate defines required field over an authentication type.</summary>
    public class AuthConfigTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier key for auth config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authKey")]
        public virtual string AuthKey { get; set; }

        /// <summary>The type of authentication configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authType")]
        public virtual string AuthType { get; set; }

        /// <summary>Config variables to describe an `AuthConfig` for a `Connection`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configVariableTemplates")]
        public virtual System.Collections.Generic.IList<ConfigVariableTemplate> ConfigVariableTemplates { get; set; }

        /// <summary>Connector specific description for an authentication template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name for authentication template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Whether the auth config is the default one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthField defines a field in an authentication type.</summary>
    public class AuthField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data type of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Description of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Key of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthObject defines a JSON schema of an authentication type.</summary>
    public class AuthObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the object has additional properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalProperties")]
        public virtual System.Nullable<bool> AdditionalProperties { get; set; }

        /// <summary>Auth key of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authKey")]
        public virtual string AuthKey { get; set; }

        /// <summary>Auth type of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authType")]
        public virtual string AuthType { get; set; }

        /// <summary>Description of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Whether the object is the default one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>Properties of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, AuthProperty> Properties { get; set; }

        /// <summary>Type of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthProperty defines a property of an authentication type.</summary>
    public class AuthProperty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Type of the property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthSchema defines the schema of an authentication type.</summary>
    public class AuthSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of AuthFields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authFields")]
        public virtual System.Collections.Generic.IList<AuthField> AuthFields { get; set; }

        /// <summary>Auth key of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authKey")]
        public virtual string AuthKey { get; set; }

        /// <summary>Auth type of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authType")]
        public virtual string AuthType { get; set; }

        /// <summary>Description of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name of the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Whether the auth schema is the default one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDefault")]
        public virtual System.Nullable<bool> IsDefault { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This configuration captures the details required to render an authorization link for the OAuth Authorization
    /// Code Flow.
    /// </summary>
    public class AuthorizationCodeLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The client ID assigned to the Google Cloud Connectors OAuth app for the connector data source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>
        /// Optional. The client secret assigned to the Google Cloud Connectors OAuth app for the connector data source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual Secret ClientSecret { get; set; }

        /// <summary>Optional. Whether to enable PKCE for the auth code flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePkce")]
        public virtual System.Nullable<bool> EnablePkce { get; set; }

        /// <summary>Optional. Omit query params from the redirect URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("omitQueryParams")]
        public virtual System.Nullable<bool> OmitQueryParams { get; set; }

        /// <summary>
        /// Optional. The scopes for which the user will authorize Google Cloud Connectors on the connector data source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>Optional. The base URI the user must click to trigger the authorization code login flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Billing config for the connection.</summary>
    public class BillingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Billing category for the connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingCategory")]
        public virtual string BillingCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConfigVariable represents a configuration variable present in a Connection. or AuthConfig.</summary>
    public class ConfigVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value is a bool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Value is a Encryption Key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyValue")]
        public virtual EncryptionKey EncryptionKeyValue { get; set; }

        /// <summary>Value is an integer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Optional. Key of the config variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value is a secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretValue")]
        public virtual Secret SecretValue { get; set; }

        /// <summary>Value is a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ConfigVariableTemplate provides metadata about a `ConfigVariable` that is used in a Connection.
    /// </summary>
    public class ConfigVariableTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Authorization code link options. To be populated if `ValueType` is `AUTHORIZATION_CODE`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationCodeLink")]
        public virtual AuthorizationCodeLink AuthorizationCodeLink { get; set; }

        /// <summary>Optional. Description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Display name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Enum options. To be populated if `ValueType` is `ENUM`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumOptions")]
        public virtual System.Collections.Generic.IList<EnumOption> EnumOptions { get; set; }

        /// <summary>Optional. enum source denotes the source of api to fill the enum options</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumSource")]
        public virtual string EnumSource { get; set; }

        /// <summary>Optional. Indicates if current template is part of advanced settings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAdvanced")]
        public virtual System.Nullable<bool> IsAdvanced { get; set; }

        /// <summary>Optional. Key of the config variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. Location Tyep denotes where this value should be sent in BYOC connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; }

        /// <summary>Optional. MultipleSelectConfig represents the multiple options for a config variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleSelectConfig")]
        public virtual MultipleSelectConfig MultipleSelectConfig { get; set; }

        /// <summary>Optional. Flag represents that this `ConfigVariable` must be provided for a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>
        /// Optional. Condition under which a field would be required. The condition can be represented in the form of a
        /// logical expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredCondition")]
        public virtual LogicalExpression RequiredCondition { get; set; }

        /// <summary>Optional. Role grant configuration for the config variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleGrant")]
        public virtual RoleGrant RoleGrant { get; set; }

        /// <summary>Output only. State of the config variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Optional. Regular expression in RE2 syntax used for validating the `value` of a `ConfigVariable`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validationRegex")]
        public virtual string ValidationRegex { get; set; }

        /// <summary>
        /// Optional. Type of the parameter: string, int, bool etc. consider custom type for the benefit for the
        /// validation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Connection represents an instance of connector.</summary>
    public class Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Async operations enabled for the connection. If Async Operations is enabled, Connection allows the
        /// customers to initiate async long running operations using the actions API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asyncOperationsEnabled")]
        public virtual System.Nullable<bool> AsyncOperationsEnabled { get; set; }

        /// <summary>
        /// Optional. Configuration for establishing the connection's authentication with an external system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// Optional. Auth override enabled for the connection. If Auth Override is enabled, Connection allows the
        /// backend service auth to be overridden in the entities/actions API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authOverrideEnabled")]
        public virtual System.Nullable<bool> AuthOverrideEnabled { get; set; }

        /// <summary>Output only. Billing config for the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingConfig")]
        public virtual BillingConfig BillingConfig { get; set; }

        /// <summary>Optional. Configuration for configuring the connection with an external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariable> ConfigVariables { get; set; }

        /// <summary>
        /// Output only. Connection revision. This field is only updated when the connection is created or updated by
        /// User.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionRevision")]
        public virtual System.Nullable<long> ConnectionRevision { get; set; }

        /// <summary>
        /// Required. Connector version on which the connection is created. The format is:
        /// projects/*/locations/*/providers/*/connectors/*/versions/* Only global location is supported for
        /// ConnectorVersion resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorVersion")]
        public virtual string ConnectorVersion { get; set; }

        /// <summary>Output only. Infra configs supported by Connector Version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorVersionInfraConfig")]
        public virtual ConnectorVersionInfraConfig ConnectorVersionInfraConfig { get; set; }

        /// <summary>Output only. Flag to mark the version indicating the launch stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorVersionLaunchStage")]
        public virtual string ConnectorVersionLaunchStage { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Optional. Description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. Configuration of the Connector's destination. Only accepted for Connectors that accepts user
        /// defined destination(s).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConfigs")]
        public virtual System.Collections.Generic.IList<DestinationConfig> DestinationConfigs { get; set; }

        /// <summary>
        /// Output only. GCR location where the envoy image is stored. formatted like: gcr.io/{bucketName}/{imageName}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envoyImageLocation")]
        public virtual string EnvoyImageLocation { get; set; }

        /// <summary>
        /// Optional. Additional Oauth2.0 Auth config for EUA. If the connection is configured using non-OAuth
        /// authentication but OAuth needs to be used for EUA, this field can be populated with the OAuth config. This
        /// should be a OAuth2AuthCodeFlow Auth type only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("euaOauthAuthConfig")]
        public virtual AuthConfig EuaOauthAuthConfig { get; set; }

        /// <summary>Optional. Eventing config of a connection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventingConfig")]
        public virtual EventingConfig EventingConfig { get; set; }

        /// <summary>Optional. Eventing enablement type. Will be nil if eventing is not enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventingEnablementType")]
        public virtual string EventingEnablementType { get; set; }

        /// <summary>Output only. Eventing Runtime Data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventingRuntimeData")]
        public virtual EventingRuntimeData EventingRuntimeData { get; set; }

        /// <summary>
        /// Optional. Fallback on admin credentials for the connection. If this both auth_override_enabled and
        /// fallback_on_admin_credentials are set to true, the connection will use the admin credentials if the dynamic
        /// auth header is not present during auth override.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallbackOnAdminCredentials")]
        public virtual System.Nullable<bool> FallbackOnAdminCredentials { get; set; }

        /// <summary>Output only. The name of the Hostname of the Service Directory service with TLS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Output only. GCR location where the runtime image is stored. formatted like: gcr.io/{bucketName}/{imageName}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageLocation")]
        public virtual string ImageLocation { get; set; }

        /// <summary>Output only. Is trusted tester program enabled for the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTrustedTester")]
        public virtual System.Nullable<bool> IsTrustedTester { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Configuration that indicates whether or not the Connection can be edited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lockConfig")]
        public virtual LockConfig LockConfig { get; set; }

        /// <summary>Optional. Log configuration for the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logConfig")]
        public virtual ConnectorsLogConfig LogConfig { get; set; }

        /// <summary>
        /// Output only. Resource name of the Connection. Format:
        /// projects/{project}/locations/{location}/connections/{connection}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Node configuration for the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeConfig")]
        public virtual NodeConfig NodeConfig { get; set; }

        /// <summary>Optional. Service account needed for runtime plane to access Google Cloud resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Output only. The name of the Service Directory service name. Used for Private Harpoon to resolve the ILB
        /// address. e.g.
        /// "projects/cloud-connectors-e2e-testing/locations/us-central1/namespaces/istio-system/services/istio-ingressgateway-connectors"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectory")]
        public virtual string ServiceDirectory { get; set; }

        /// <summary>Optional. Ssl config of a connection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslConfig")]
        public virtual SslConfig SslConfig { get; set; }

        /// <summary>Output only. Current status of the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ConnectionStatus Status { get; set; }

        /// <summary>Output only. This subscription type enum states the subscription type of the project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionType")]
        public virtual string SubscriptionType { get; set; }

        /// <summary>Optional. Suspended indicates if a user has suspended a connection or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; }

        /// <summary>Output only. The name of the Service Directory service with TLS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsServiceDirectory")]
        public virtual string TlsServiceDirectory { get; set; }

        /// <summary>Optional. Traffic shaping configuration for the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficShapingConfigs")]
        public virtual System.Collections.Generic.IList<TrafficShapingConfig> TrafficShapingConfigs { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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
    /// ConnectionSchemaMetadata is the singleton resource of each connection. It includes the entity and action names
    /// of runtime resources exposed by a connection backend.
    /// </summary>
    public class ConnectionSchemaMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<string> Actions { get; set; }

        /// <summary>Output only. List of entity names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<string> Entities { get; set; }

        /// <summary>Error message for users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// Output only. Resource name. Format:
        /// projects/{project}/locations/{location}/connections/{connection}/connectionSchemaMetadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _refreshTimeRaw;

        private object _refreshTime;

        /// <summary>Output only. Timestamp when the connection runtime schema refresh was triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshTime")]
        public virtual string RefreshTimeRaw
        {
            get => _refreshTimeRaw;
            set
            {
                _refreshTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _refreshTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RefreshTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RefreshTimeDateTimeOffset instead.")]
        public virtual object RefreshTime
        {
            get => _refreshTime;
            set
            {
                _refreshTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _refreshTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RefreshTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RefreshTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RefreshTimeRaw);
            set => RefreshTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The current state of runtime schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the connection runtime schema was updated.</summary>
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

    /// <summary>ConnectionStatus indicates the state of the connection.</summary>
    public class ConnectionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>State.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Status provides detailed information for the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Connectors indicates a specific connector type, e.x. Salesforce, SAP etc.</summary>
    public class Connector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Category of the connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Output only. The type of the connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorType")]
        public virtual string ConnectorType { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Output only. Description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Link to documentation page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUri")]
        public virtual string DocumentationUri { get; set; }

        /// <summary>Output only. Eventing details. Will be null if eventing is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventingDetails")]
        public virtual EventingDetails EventingDetails { get; set; }

        /// <summary>Output only. Link to external page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>
        /// Output only. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Flag to mark the version indicating the launch stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// Output only. Marketplace connector details. Will be null if the connector is not marketplace connector.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplaceConnectorDetails")]
        public virtual MarketplaceConnectorDetails MarketplaceConnectorDetails { get; set; }

        /// <summary>
        /// Output only. Resource name of the Connector. Format:
        /// projects/{project}/locations/{location}/providers/{provider}/connectors/{connector} Only global location is
        /// supported for Connector resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Tags of the connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

        /// <summary>Output only. Cloud storage location of icons etc consumed by UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webAssetsLocation")]
        public virtual string WebAssetsLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This cofiguration provides infra configs like rate limit threshold which need to be configurable for every
    /// connector version
    /// </summary>
    public class ConnectorInfraConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates that the Cloud Run CPU should always be allocated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alwaysAllocateCpu")]
        public virtual System.Nullable<bool> AlwaysAllocateCpu { get; set; }

        /// <summary>The window used for ratelimiting runtime requests to connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionRatelimitWindowSeconds")]
        public virtual System.Nullable<long> ConnectionRatelimitWindowSeconds { get; set; }

        /// <summary>Indicate whether connector versioning is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorVersioningEnabled")]
        public virtual System.Nullable<bool> ConnectorVersioningEnabled { get; set; }

        /// <summary>Indicate whether connector is deployed on GKE/CloudRun</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentModel")]
        public virtual string DeploymentModel { get; set; }

        /// <summary>HPA autoscaling config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hpaConfig")]
        public virtual HPAConfig HpaConfig { get; set; }

        /// <summary>Max QPS supported for internal requests originating from Connd.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalclientRatelimitThreshold")]
        public virtual System.Nullable<long> InternalclientRatelimitThreshold { get; set; }

        /// <summary>Max Instance Request Conncurrency for Cloud Run service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceRequestConcurrency")]
        public virtual System.Nullable<int> MaxInstanceRequestConcurrency { get; set; }

        /// <summary>Indicate whether connector is being migrated to cloud run deployment model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrateDeploymentModel")]
        public virtual System.Nullable<bool> MigrateDeploymentModel { get; set; }

        /// <summary>Indicate whether connector is being migrated to TLS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migrateTls")]
        public virtual System.Nullable<bool> MigrateTls { get; set; }

        /// <summary>Indicate whether connector is being migrated to use direct VPC egress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkEgressMode")]
        public virtual string NetworkEgressMode { get; set; }

        /// <summary>Indicate whether cloud spanner is required for connector job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionCloudSpanner")]
        public virtual System.Nullable<bool> ProvisionCloudSpanner { get; set; }

        /// <summary>Indicate whether memstore is required for connector job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionMemstore")]
        public virtual System.Nullable<bool> ProvisionMemstore { get; set; }

        /// <summary>Max QPS supported by the connector version before throttling of requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratelimitThreshold")]
        public virtual System.Nullable<long> RatelimitThreshold { get; set; }

        /// <summary>System resource limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLimits")]
        public virtual ResourceLimits ResourceLimits { get; set; }

        /// <summary>System resource requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceRequests")]
        public virtual ResourceRequests ResourceRequests { get; set; }

        /// <summary>The name of shared connector deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedDeployment")]
        public virtual string SharedDeployment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ConnectorVersion indicates a specific version of a connector.</summary>
    public class ConnectorVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of auth configs supported by the Connector Version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfigTemplates")]
        public virtual System.Collections.Generic.IList<AuthConfigTemplate> AuthConfigTemplates { get; set; }

        /// <summary>Output only. Flag to mark the dynamic auth override.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authOverrideEnabled")]
        public virtual System.Nullable<bool> AuthOverrideEnabled { get; set; }

        /// <summary>Output only. List of config variables needed to create a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configVariableTemplates")]
        public virtual System.Collections.Generic.IList<ConfigVariableTemplate> ConfigVariableTemplates { get; set; }

        /// <summary>Output only. Infra configs supported by Connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorInfraConfig")]
        public virtual ConnectorInfraConfig ConnectorInfraConfig { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Output only. List of destination configs needed to create a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConfigTemplates")]
        public virtual System.Collections.Generic.IList<DestinationConfigTemplate> DestinationConfigTemplates { get; set; }

        /// <summary>Output only. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Configuration for Egress Control.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressControlConfig")]
        public virtual EgressControlConfig EgressControlConfig { get; set; }

        /// <summary>Output only. Eventing configuration supported by the Connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventingConfigTemplate")]
        public virtual EventingConfigTemplate EventingConfigTemplate { get; set; }

        /// <summary>Output only. Is custom actions supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCustomActionsSupported")]
        public virtual System.Nullable<bool> IsCustomActionsSupported { get; set; }

        /// <summary>Output only. Is custom entities supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCustomEntitiesSupported")]
        public virtual System.Nullable<bool> IsCustomEntitiesSupported { get; set; }

        /// <summary>
        /// Output only. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Flag to mark the version indicating the launch stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// Output only. Resource name of the Version. Format:
        /// projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version} Only
        /// global location is supported for Connector resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The priority entity types for the connector version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorityEntityTypes")]
        public virtual System.Collections.Generic.IList<PriorityEntityType> PriorityEntityTypes { get; set; }

        /// <summary>Output only. ReleaseVersion of the connector, for example: "1.0.1-alpha".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseVersion")]
        public virtual string ReleaseVersion { get; set; }

        /// <summary>
        /// Output only. Role grant configuration for this config variable. It will be DEPRECATED soon.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleGrant")]
        public virtual RoleGrant RoleGrant { get; set; }

        /// <summary>Output only. Role grant configurations for this connector version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleGrants")]
        public virtual System.Collections.Generic.IList<RoleGrant> RoleGrants { get; set; }

        /// <summary>Connection Schema Refresh Config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaRefreshConfig")]
        public virtual SchemaRefreshConfig SchemaRefreshConfig { get; set; }

        /// <summary>Output only. Ssl configuration supported by the Connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslConfigTemplate")]
        public virtual SslConfigTemplate SslConfigTemplate { get; set; }

        /// <summary>Output only. Information about the runtime features supported by the Connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedRuntimeFeatures")]
        public virtual SupportedRuntimeFeatures SupportedRuntimeFeatures { get; set; }

        /// <summary>Output only. Supported standard actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedStandardActions")]
        public virtual System.Collections.Generic.IList<StandardAction> SupportedStandardActions { get; set; }

        /// <summary>Output only. Supported standard entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedStandardEntities")]
        public virtual System.Collections.Generic.IList<StandardEntity> SupportedStandardEntities { get; set; }

        /// <summary>Output only. Unsupported connection types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsupportedConnectionTypes")]
        public virtual System.Collections.Generic.IList<string> UnsupportedConnectionTypes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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
    /// This configuration provides infra configs like rate limit threshold which need to be configurable for every
    /// connector version
    /// </summary>
    public class ConnectorVersionInfraConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The window used for ratelimiting runtime requests to connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionRatelimitWindowSeconds")]
        public virtual System.Nullable<long> ConnectionRatelimitWindowSeconds { get; set; }

        /// <summary>Output only. Indicates whether connector is deployed on GKE/CloudRun</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentModel")]
        public virtual string DeploymentModel { get; set; }

        /// <summary>Output only. Status of the deployment model migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentModelMigrationState")]
        public virtual string DeploymentModelMigrationState { get; set; }

        /// <summary>Output only. HPA autoscaling config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hpaConfig")]
        public virtual HPAConfig HpaConfig { get; set; }

        /// <summary>Output only. Max QPS supported for internal requests originating from Connd.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalclientRatelimitThreshold")]
        public virtual System.Nullable<long> InternalclientRatelimitThreshold { get; set; }

        /// <summary>Output only. Max instance request concurrency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstanceRequestConcurrency")]
        public virtual System.Nullable<int> MaxInstanceRequestConcurrency { get; set; }

        /// <summary>Output only. Max QPS supported by the connector version before throttling of requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratelimitThreshold")]
        public virtual System.Nullable<long> RatelimitThreshold { get; set; }

        /// <summary>Output only. System resource limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLimits")]
        public virtual ResourceLimits ResourceLimits { get; set; }

        /// <summary>Output only. System resource requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceRequests")]
        public virtual ResourceRequests ResourceRequests { get; set; }

        /// <summary>Output only. The name of shared connector deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sharedDeployment")]
        public virtual string SharedDeployment { get; set; }

        /// <summary>Output only. Status of the TLS migration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsMigrationState")]
        public virtual string TlsMigrationState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Log configuration for the connection.</summary>
    public class ConnectorsLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Enabled represents whether logging is enabled or not for a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Optional. Log configuration level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual string Level { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomConnector represents the custom connector defined by the customer as part of byoc.</summary>
    public class CustomConnector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Active connector versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeConnectorVersions")]
        public virtual System.Collections.Generic.IList<string> ActiveConnectorVersions { get; set; }

        /// <summary>Output only. All connector versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConnectorVersions")]
        public virtual System.Collections.Generic.IList<string> AllConnectorVersions { get; set; }

        /// <summary>Output only. All marketplace versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allMarketplaceVersions")]
        public virtual System.Collections.Generic.IList<string> AllMarketplaceVersions { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Required. Type of the custom connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConnectorType")]
        public virtual string CustomConnectorType { get; set; }

        /// <summary>Optional. Description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Optional. Logo of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logo")]
        public virtual string Logo { get; set; }

        /// <summary>
        /// Identifier. Resource name of the CustomConnector. Format:
        /// projects/{project}/locations/{location}/customConnectors/{connector}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Published marketplace versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedMarketplaceVersions")]
        public virtual System.Collections.Generic.IList<string> PublishedMarketplaceVersions { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

    /// <summary>CustomConnectorVersion indicates a specific version of a connector.</summary>
    public class CustomConnectorVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Indicates if Async Operations/Connector Job is supported. This is only available for SDK based
        /// custom connectors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asyncOperationsSupport")]
        public virtual System.Nullable<bool> AsyncOperationsSupport { get; set; }

        /// <summary>
        /// Optional. Authentication config for accessing connector service (facade). This is used only when
        /// enable_backend_destination_config is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// Optional. Auth Config Templates is only used when connector backend is enabled. This is used to specify the
        /// auth configs supported by the connector backend service to talk to the actual application backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfigTemplates")]
        public virtual System.Collections.Generic.IList<AuthConfigTemplate> AuthConfigTemplates { get; set; }

        /// <summary>Optional. Auth override support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authOverrideSupport")]
        public virtual System.Nullable<bool> AuthOverrideSupport { get; set; }

        /// <summary>
        /// Optional. Backend variable templates is only used when connector backend is enabled. This is used to specify
        /// the variables required by the connector backend service to talk to the actual application backend. This
        /// translates to additional variable templates in the connection config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendVariableTemplates")]
        public virtual System.Collections.Generic.IList<ConfigVariableTemplate> BackendVariableTemplates { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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
        /// Optional. Destination config(s) for accessing connector service (facade). This is used only when
        /// enable_backend_destination_config is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConfigs")]
        public virtual System.Collections.Generic.IList<DestinationConfig> DestinationConfigs { get; set; }

        /// <summary>
        /// Optional. Indicates if an intermediatory connectorservice is used as backend. When this is enabled, the
        /// connector destination and connector auth config are required. For SDK based connectors, this is always
        /// enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableBackendDestinationConfig")]
        public virtual System.Nullable<bool> EnableBackendDestinationConfig { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Identifier. Resource name of the Version. Format:
        /// projects/{project}/locations/{location}/customConnectors/{custom_connector}/customConnectorVersions/{custom_connector_version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Partner metadata details. This should be populated only when publishing the custom connector to
        /// partner connector.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerMetadata")]
        public virtual PartnerMetadata PartnerMetadata { get; set; }

        /// <summary>Output only. Publish status of a custom connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishStatus")]
        public virtual PublishStatus PublishStatus { get; set; }

        /// <summary>Optional. Service account used by runtime plane to access auth config secrets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Optional. Location of the custom connector spec. This is only used for Open API based custom connectors. The
        /// location can be either a public url like `https://public-url.com/spec` Or a Google Cloud Storage location
        /// like `gs:///`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specLocation")]
        public virtual string SpecLocation { get; set; }

        /// <summary>
        /// Output only. Server URLs parsed from the Open API spec. This is only used for Open API based custom
        /// connectors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specServerUrls")]
        public virtual System.Collections.Generic.IList<string> SpecServerUrls { get; set; }

        /// <summary>Output only. State of the custom connector version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

    /// <summary>Dead Letter configuration details provided by the user.</summary>
    public class DeadLetterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Project which has the topic given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Optional. Topic to push events which couldn't be processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

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

    /// <summary>Request message for ConnectorsService.DeprecateCustomConnectorVersion</summary>
    public class DeprecateCustomConnectorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Destination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For publicly routable host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>The port is the target port number that is accepted by the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>PSC service attachments. Format: projects/*/regions/*/serviceAttachments/*</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachment")]
        public virtual string ServiceAttachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Define the Connectors target endpoint.</summary>
    public class DestinationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The destinations for the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual System.Collections.Generic.IList<Destination> Destinations { get; set; }

        /// <summary>The key is the destination identifier that is supported by the Connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DestinationConfigTemplate defines required destinations supported by the Connector.</summary>
    public class DestinationConfigTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Autocomplete suggestions for destination URL field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autocompleteSuggestions")]
        public virtual System.Collections.Generic.IList<string> AutocompleteSuggestions { get; set; }

        /// <summary>The default port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPort")]
        public virtual System.Nullable<int> DefaultPort { get; set; }

        /// <summary>Description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Whether the current destination tempalate is part of Advanced settings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAdvanced")]
        public virtual System.Nullable<bool> IsAdvanced { get; set; }

        /// <summary>Key of the destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The maximum number of destinations supported for this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<int> Max { get; set; }

        /// <summary>The minimum number of destinations supported for this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<int> Min { get; set; }

        /// <summary>Whether port number should be provided by customers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portFieldType")]
        public virtual string PortFieldType { get; set; }

        /// <summary>Regex pattern for host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexPattern")]
        public virtual string RegexPattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EUASecret provides a reference to entries in Secret Manager.</summary>
    public class EUASecret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The plain string value of the secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretValue")]
        public virtual string SecretValue { get; set; }

        /// <summary>
        /// Optional. The resource name of the secret version in the format, format as:
        /// `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretVersion")]
        public virtual string SecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Egress control config for connector runtime. These configurations define the rules to identify which outbound
    /// domains/hosts needs to be whitelisted. It may be a static information for a particular connector version or it
    /// is derived from the configurations provided by the customer in Connection resource.
    /// </summary>
    public class EgressControlConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Static Comma separated backends which are common for all Connection resources. Supported formats for each
        /// backend are host:port or just host (host can be ip address or domain name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backends")]
        public virtual string Backends { get; set; }

        /// <summary>Extractions Rules to extract the backends from customer provided configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractionRules")]
        public virtual ExtractionRules ExtractionRules { get; set; }

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

    /// <summary>Regional encryption config for CMEK details.</summary>
    public class EncryptionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Encryption type for the region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionType")]
        public virtual string EncryptionType { get; set; }

        /// <summary>
        /// Optional. KMS crypto key. This field accepts identifiers of the form
        /// `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/ {crypto_key}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encryption Key value.</summary>
    public class EncryptionKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The [KMS key name] with which the content of the Operation is encrypted. The expected format:
        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`. Will be empty string if google managed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Endpoint message includes details of the Destination endpoint.</summary>
    public class EndPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The URI of the Endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>Optional. List of Header to be added to the Endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<Header> Headers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AuthConfig defines details of a authentication type.</summary>
    public class EndUserAuthentication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Config variables for the EndUserAuthentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configVariables")]
        public virtual System.Collections.Generic.IList<EndUserAuthenticationConfigVariable> ConfigVariables { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Optional. Destination configs for the EndUserAuthentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationConfigs")]
        public virtual System.Collections.Generic.IList<DestinationConfig> DestinationConfigs { get; set; }

        /// <summary>Optional. The EndUserAuthenticationConfig for the EndUserAuthentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUserAuthenticationConfig")]
        public virtual EndUserAuthenticationConfig EndUserAuthenticationConfig { get; set; }

        /// <summary>Optional. Labels for the EndUserAuthentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Required. Identifier. Resource name of the EndUserAuthentication. Format:
        /// projects/{project}/locations/{location}/connections/{connection}/endUserAuthentications/{end_user_authentication}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The destination to hit when we receive an event</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifyEndpointDestination")]
        public virtual EndUserAuthenticationNotifyEndpointDestination NotifyEndpointDestination { get; set; }

        /// <summary>Optional. Roles for the EndUserAuthentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>Optional. Status of the EndUserAuthentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual EndUserAuthenticationEndUserAuthenticationStatus Status { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

        /// <summary>Optional. The user id of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EndUserAuthenticationConfig defines details of a authentication configuration for EUC</summary>
    public class EndUserAuthenticationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List containing additional auth configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalVariables")]
        public virtual System.Collections.Generic.IList<EndUserAuthenticationConfigVariable> AdditionalVariables { get; set; }

        /// <summary>Identifier key for auth config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authKey")]
        public virtual string AuthKey { get; set; }

        /// <summary>The type of authentication configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authType")]
        public virtual string AuthType { get; set; }

        /// <summary>Oauth2AuthCodeFlow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2AuthCodeFlow")]
        public virtual EndUserAuthenticationConfigOauth2AuthCodeFlow Oauth2AuthCodeFlow { get; set; }

        /// <summary>Oauth2AuthCodeFlowGoogleManaged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2AuthCodeFlowGoogleManaged")]
        public virtual EndUserAuthenticationConfigOauth2AuthCodeFlowGoogleManaged Oauth2AuthCodeFlowGoogleManaged { get; set; }

        /// <summary>Oauth2ClientCredentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientCredentials")]
        public virtual EndUserAuthenticationConfigOauth2ClientCredentials Oauth2ClientCredentials { get; set; }

        /// <summary>Oauth2JwtBearer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2JwtBearer")]
        public virtual EndUserAuthenticationConfigOauth2JwtBearer Oauth2JwtBearer { get; set; }

        /// <summary>SSH Public Key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKey")]
        public virtual EndUserAuthenticationConfigSshPublicKey SshPublicKey { get; set; }

        /// <summary>UserPassword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPassword")]
        public virtual EndUserAuthenticationConfigUserPassword UserPassword { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support Oauth 2.0 Auth Code Grant Authentication. See
    /// https://www.rfc-editor.org/rfc/rfc6749#section-1.3.1 for more details.
    /// </summary>
    public class EndUserAuthenticationConfigOauth2AuthCodeFlow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authorization code to be exchanged for access and refresh tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authCode")]
        public virtual string AuthCode { get; set; }

        /// <summary>Optional. Auth URL for Authorization Code Flow</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authUri")]
        public virtual string AuthUri { get; set; }

        /// <summary>Optional. Client ID for user-provided OAuth app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Optional. Client secret for user-provided OAuth app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual EUASecret ClientSecret { get; set; }

        /// <summary>Optional. Whether to enable PKCE when the user performs the auth code flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePkce")]
        public virtual System.Nullable<bool> EnablePkce { get; set; }

        /// <summary>Optional. Auth Code Data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthTokenData")]
        public virtual OAuthTokenData OauthTokenData { get; set; }

        /// <summary>Optional. PKCE verifier to be used during the auth code exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkceVerifier")]
        public virtual string PkceVerifier { get; set; }

        /// <summary>Optional. Redirect URI to be provided during the auth code exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>Optional. Scopes the connection will request when the user performs the auth code flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support Oauth 2.0 Auth Code Grant Authentication using Google Provided OAuth Client. See
    /// https://tools.ietf.org/html/rfc6749#section-1.3.1 for more details.
    /// </summary>
    public class EndUserAuthenticationConfigOauth2AuthCodeFlowGoogleManaged : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authorization code to be exchanged for access and refresh tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authCode")]
        public virtual string AuthCode { get; set; }

        /// <summary>Auth Code Data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthTokenData")]
        public virtual OAuthTokenData OauthTokenData { get; set; }

        /// <summary>Optional. Redirect URI to be provided during the auth code exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>Required. Scopes the connection will request when the user performs the auth code flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support Oauth 2.0 Client Credentials Grant Authentication. See
    /// https://tools.ietf.org/html/rfc6749#section-1.3.4 for more details.
    /// </summary>
    public class EndUserAuthenticationConfigOauth2ClientCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The client identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Required. string value or secret version containing the client secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual EUASecret ClientSecret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support JSON Web Token (JWT) Profile for Oauth 2.0 Authorization Grant based authentication. See
    /// https://tools.ietf.org/html/rfc7523 for more details.
    /// </summary>
    public class EndUserAuthenticationConfigOauth2JwtBearer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. secret version/value reference containing a PKCS#8 PEM-encoded private key associated with the
        /// Client Certificate. This private key will be used to sign JWTs used for the jwt-bearer authorization grant.
        /// Specified in the form as: `projects/*/strings/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual EUASecret ClientKey { get; set; }

        /// <summary>JwtClaims providers fields to generate the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwtClaims")]
        public virtual EndUserAuthenticationConfigOauth2JwtBearerJwtClaims JwtClaims { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JWT claims used for the jwt-bearer authorization grant.</summary>
    public class EndUserAuthenticationConfigOauth2JwtBearerJwtClaims : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value for the "aud" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>Value for the "iss" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        /// <summary>Value for the "sub" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to support Ssh public key Authentication.</summary>
    public class EndUserAuthenticationConfigSshPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Format of SSH Client cert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certType")]
        public virtual string CertType { get; set; }

        /// <summary>Required. SSH Client Cert. It should contain both public and private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshClientCert")]
        public virtual EUASecret SshClientCert { get; set; }

        /// <summary>Required. Password (passphrase) for ssh client certificate if it has one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshClientCertPass")]
        public virtual EUASecret SshClientCertPass { get; set; }

        /// <summary>The user account used to authenticate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to support Username and Password Authentication.</summary>
    public class EndUserAuthenticationConfigUserPassword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. string value or secret version reference containing the password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual EUASecret Password { get; set; }

        /// <summary>Username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EndUserAuthenticationConfigVariable represents a configuration variable present in a EndUserAuthentication.
    /// </summary>
    public class EndUserAuthenticationConfigVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value is a bool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Value is an integer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Required. Key of the config variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Value is a secret</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretValue")]
        public virtual EUASecret SecretValue { get; set; }

        /// <summary>Value is a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EndUserAuthentication Status denotes the status of the EndUserAuthentication resource.</summary>
    public class EndUserAuthenticationEndUserAuthenticationStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Description of the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. State of Event Subscription resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for NotifyEndpointDestination Destination to hit when the refresh token is expired.</summary>
    public class EndUserAuthenticationNotifyEndpointDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. OPTION 1: Hit an endpoint when the refresh token is expired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual EndUserAuthenticationNotifyEndpointDestinationEndPoint Endpoint { get; set; }

        /// <summary>Required. Service account needed for runtime plane to notify the backend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Required. type of the destination</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Endpoint message includes details of the Destination endpoint.</summary>
    public class EndUserAuthenticationNotifyEndpointDestinationEndPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The URI of the Endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>Optional. List of Header to be added to the Endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<EndUserAuthenticationNotifyEndpointDestinationEndPointHeader> Headers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Header details for a given header to be added to Endpoint.</summary>
    public class EndUserAuthenticationNotifyEndpointDestinationEndPointHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Key of Header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Required. Value of Header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>represents the Connector's Endpoint Attachment resource</summary>
    public class EndpointAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Optional. Description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. The Private Service Connect Connection Endpoint Global Access.
        /// https://cloud.google.com/vpc/docs/about-accessing-vpc-hosted-services-endpoints#global-access
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointGlobalAccess")]
        public virtual System.Nullable<bool> EndpointGlobalAccess { get; set; }

        /// <summary>Output only. The Private Service Connect connection endpoint ip</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointIp")]
        public virtual string EndpointIp { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Resource name of the Endpoint Attachment. Format:
        /// projects/{project}/locations/{location}/endpointAttachments/{endpoint_attachment}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The path of the service attachment</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAttachment")]
        public virtual string ServiceAttachment { get; set; }

        /// <summary>
        /// Output only. The Private Service Connect Connection Endpoint State. This value is only available in the Full
        /// view.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

    /// <summary>Data enrichment configuration.</summary>
    public class EnrichmentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Append ACL to the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendAcl")]
        public virtual System.Nullable<bool> AppendAcl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnumOption definition</summary>
    public class EnumOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Display name of the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Id of the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>represents the Connector's EventSubscription resource</summary>
    public class EventSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Optional. The destination to hit when we receive an event</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual EventSubscriptionDestination Destinations { get; set; }

        /// <summary>Optional. Event type id of the event of current EventSubscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTypeId")]
        public virtual string EventTypeId { get; set; }

        /// <summary>Optional. JMS is the source for the event listener.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jms")]
        public virtual JMS Jms { get; set; }

        /// <summary>
        /// Required. Identifier. Resource name of the EventSubscription. Format:
        /// projects/{project}/locations/{location}/connections/{connection}/eventSubscriptions/{event_subscription}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Status indicates the status of the event subscription resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual EventSubscriptionStatus Status { get; set; }

        /// <summary>Optional. name of the Subscriber for the current EventSubscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriber")]
        public virtual string Subscriber { get; set; }

        /// <summary>Optional. Link for Subscriber of the current EventSubscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberLink")]
        public virtual string SubscriberLink { get; set; }

        /// <summary>Optional. Configuration for configuring the trigger</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerConfigVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariable> TriggerConfigVariables { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

    /// <summary>Message for EventSubscription Destination to act on receiving an event</summary>
    public class EventSubscriptionDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTION 1: Hit an endpoint when we receive an event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual EndPoint Endpoint { get; set; }

        /// <summary>OPTION 3: Write the event to Pub/Sub topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsub")]
        public virtual PubSub Pubsub { get; set; }

        /// <summary>Optional. Service account needed for runtime plane to trigger IP workflow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Optional. type of the destination</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EventSubscription Status denotes the status of the EventSubscription resource.</summary>
    public class EventSubscriptionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Description of the state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. State of Event Subscription resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EventType includes fields.</summary>
    public class EventType : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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
        /// Output only. Schema of the event payload after enriched. Will be null if read before send is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrichedEventPayloadSchema")]
        public virtual string EnrichedEventPayloadSchema { get; set; }

        /// <summary>
        /// Output only. Runtime entity type name. Will be null if entity type map is not available. Used for read
        /// before send feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>Output only. Schema of webhook event payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventPayloadSchema")]
        public virtual string EventPayloadSchema { get; set; }

        /// <summary>Output only. Event type id. Example: `ticket.created`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTypeId")]
        public virtual string EventTypeId { get; set; }

        /// <summary>Output only. Id path denotes the path of id in webhook payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idPath")]
        public virtual string IdPath { get; set; }

        /// <summary>
        /// Output only. Resource name of the eventtype. Format:
        /// projects/{project}/locations/{location}/providers/{provider}/connectors/{connector}/versions/{version}/eventtypes/{eventtype}
        /// Only global location is supported for Connector resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

    /// <summary>Eventing Configuration of a connection next: 18</summary>
    public class EventingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Additional eventing related field values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariable> AdditionalVariables { get; set; }

        /// <summary>Optional. Auth details for the webhook adapter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfig")]
        public virtual AuthConfig AuthConfig { get; set; }

        /// <summary>Optional. Dead letter configuration for eventing of a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadLetterConfig")]
        public virtual DeadLetterConfig DeadLetterConfig { get; set; }

        /// <summary>Optional. Data enrichment configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrichmentConfig")]
        public virtual EnrichmentConfig EnrichmentConfig { get; set; }

        /// <summary>Optional. Enrichment Enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrichmentEnabled")]
        public virtual System.Nullable<bool> EnrichmentEnabled { get; set; }

        /// <summary>
        /// Optional. Ingress endpoint of the event listener. This is used only when private connectivity is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventsListenerIngressEndpoint")]
        public virtual string EventsListenerIngressEndpoint { get; set; }

        /// <summary>Optional. Auth details for the event listener.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listenerAuthConfig")]
        public virtual AuthConfig ListenerAuthConfig { get; set; }

        /// <summary>Optional. Private Connectivity Enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateConnectivityEnabled")]
        public virtual System.Nullable<bool> PrivateConnectivityEnabled { get; set; }

        /// <summary>Optional. Proxy for Eventing auto-registration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxyDestinationConfig")]
        public virtual DestinationConfig ProxyDestinationConfig { get; set; }

        /// <summary>Optional. Registration endpoint for auto registration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registrationDestinationConfig")]
        public virtual DestinationConfig RegistrationDestinationConfig { get; set; }

        /// <summary>Optional. Ssl config of a connection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslConfig")]
        public virtual SslConfig SslConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Eventing Config details of a connector version. next: 14</summary>
    public class EventingConfigTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional fields that need to be rendered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariableTemplate> AdditionalVariables { get; set; }

        /// <summary>AuthConfigTemplates represents the auth values for the webhook adapter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authConfigTemplates")]
        public virtual System.Collections.Generic.IList<AuthConfigTemplate> AuthConfigTemplates { get; set; }

        /// <summary>Auto refresh to extend webhook life.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRefresh")]
        public virtual System.Nullable<bool> AutoRefresh { get; set; }

        /// <summary>Auto Registration supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRegistrationSupported")]
        public virtual System.Nullable<bool> AutoRegistrationSupported { get; set; }

        /// <summary>Encryption key (can be either Google managed or CMEK).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyTemplate")]
        public virtual ConfigVariableTemplate EncryptionKeyTemplate { get; set; }

        /// <summary>Enrichment Supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrichmentSupported")]
        public virtual System.Nullable<bool> EnrichmentSupported { get; set; }

        /// <summary>The type of the event listener for a specific connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventListenerType")]
        public virtual string EventListenerType { get; set; }

        /// <summary>Is Eventing Supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEventingSupported")]
        public virtual System.Nullable<bool> IsEventingSupported { get; set; }

        /// <summary>ListenerAuthConfigTemplates represents the auth values for the event listener.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listenerAuthConfigTemplates")]
        public virtual System.Collections.Generic.IList<AuthConfigTemplate> ListenerAuthConfigTemplates { get; set; }

        /// <summary>Proxy destination config template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proxyDestinationConfig")]
        public virtual DestinationConfigTemplate ProxyDestinationConfig { get; set; }

        /// <summary>Registration host destination config template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registrationDestinationConfig")]
        public virtual DestinationConfigTemplate RegistrationDestinationConfig { get; set; }

        /// <summary>SSL Config template for the connector version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslConfigTemplate")]
        public virtual SslConfigTemplate SslConfigTemplate { get; set; }

        /// <summary>Trigger Config fields that needs to be rendered</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerConfigVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariableTemplate> TriggerConfigVariables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Eventing Details message.</summary>
    public class EventingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Custom Event Types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customEventTypes")]
        public virtual System.Nullable<bool> CustomEventTypes { get; set; }

        /// <summary>Output only. Description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Link to public documentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationLink")]
        public virtual string DocumentationLink { get; set; }

        /// <summary>Output only. Cloud storage location of the icon.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconLocation")]
        public virtual string IconLocation { get; set; }

        /// <summary>Output only. Eventing Launch Stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Output only. Name of the Eventing trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Array of search keywords.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchTags")]
        public virtual System.Collections.Generic.IList<string> SearchTags { get; set; }

        /// <summary>Output only. The type of the event listener for a specific connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Eventing runtime data has the details related to eventing managed by the system.</summary>
    public class EventingRuntimeData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Events listener endpoint. The value will populated after provisioning the events listener.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventsListenerEndpoint")]
        public virtual string EventsListenerEndpoint { get; set; }

        /// <summary>
        /// Output only. Events listener PSC Service attachment. The value will be populated after provisioning the
        /// events listener with private connectivity enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventsListenerPscSa")]
        public virtual string EventsListenerPscSa { get; set; }

        /// <summary>Output only. Current status of eventing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual EventingStatus Status { get; set; }

        /// <summary>Output only. Webhook data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookData")]
        public virtual WebhookData WebhookData { get; set; }

        /// <summary>Output only. Webhook subscriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSubscriptions")]
        public virtual WebhookSubscriptions WebhookSubscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EventingStatus indicates the state of eventing.</summary>
    public class EventingStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Description of error if State is set to "ERROR".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. State.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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

    /// <summary>Extraction Rule.</summary>
    public class ExtractionRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regex used to extract backend details from source. If empty, whole source value will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractionRegex")]
        public virtual string ExtractionRegex { get; set; }

        /// <summary>Source on which the rule is applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Source Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Extraction Rules to identity the backends from customer provided configuration in Connection resource.
    /// </summary>
    public class ExtractionRules : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Collection of Extraction Rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractionRule")]
        public virtual System.Collections.Generic.IList<ExtractionRule> ExtractionRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Connectors.GetAuthSchema.</summary>
    public class FetchAuthSchemaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of AuthSchemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authSchemas")]
        public virtual System.Collections.Generic.IList<AuthSchema> AuthSchemas { get; set; }

        /// <summary>
        /// JSON schema of the AuthSchemas. This is only populated if the view is JSON_SCHEMA. The schema is in draft-07
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonAuthSchema JsonSchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of an entity field.</summary>
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

        /// <summary>Name of the Field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string FieldValue { get; set; }

        /// <summary>JsonSchema representation of this entity's schema</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonSchema JsonSchema { get; set; }

        /// <summary>
        /// The following boolean field specifies if the current Field acts as a primary key or id if the parent is of
        /// type entity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual System.Nullable<bool> Key { get; set; }

        /// <summary>Specifies whether a null value is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>Specifies if the Field is readonly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readonly")]
        public virtual System.Nullable<bool> Readonly__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Field that needs to be compared.</summary>
    public class FieldComparison : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Boolean value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Optional. Comparator to use for comparing the field value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comparator")]
        public virtual string Comparator { get; set; }

        /// <summary>Integer value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Optional. Key of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>String value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Autoscaling config for connector deployment system metrics.</summary>
    public class HPAConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Percent CPU utilization where HPA triggers autoscaling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuUtilizationThreshold")]
        public virtual System.Nullable<long> CpuUtilizationThreshold { get; set; }

        /// <summary>Output only. Percent Memory utilization where HPA triggers autoscaling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryUtilizationThreshold")]
        public virtual System.Nullable<long> MemoryUtilizationThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Header details for a given header to be added to Endpoint.</summary>
    public class Header : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Key of Header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. Value of Header.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of an input parameter.</summary>
    public class InputParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data type of the Parameter.</summary>
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

        /// <summary>JsonSchema representation of this action's parameter</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonSchema JsonSchema { get; set; }

        /// <summary>Specifies whether a null value is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>Name of the Parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual string Parameter { get; set; }

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

    /// <summary>JMS message denotes the source of the event</summary>
    public class JMS : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Name of the JMS source. i.e. queueName or topicName</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Type of the JMS Source. i.e. Queue or Topic</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JsonAuthSchema defines the JSON schema of all authentication types.</summary>
    public class JsonAuthSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>JSON schema of the AuthSchemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("$schema")]
        public virtual string Schema { get; set; }

        /// <summary>List of AuthObjects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneOf")]
        public virtual System.Collections.Generic.IList<AuthObject> OneOf { get; set; }

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

    /// <summary>JWT claims used for the jwt-bearer authorization grant.</summary>
    public class JwtClaims : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Value for the "aud" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>Optional. Value for the "iss" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        /// <summary>Optional. Value for the "sub" claim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListActions API</summary>
    public class ListActionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>list of actions</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<RuntimeActionSchema> Actions { get; set; }

        /// <summary>token for next page</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConnectorsService.ListConnections</summary>
    public class ListConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<Connection> Connections { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Connectors.ListConnectorVersions.</summary>
    public class ListConnectorVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of connector versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorVersions")]
        public virtual System.Collections.Generic.IList<ConnectorVersion> ConnectorVersions { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Connectors.ListConnectors.</summary>
    public class ListConnectorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of connectors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectors")]
        public virtual System.Collections.Generic.IList<Connector> Connectors { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Connectors.ListCustomConnectorVersions.</summary>
    public class ListCustomConnectorVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of connector versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConnectorVersions")]
        public virtual System.Collections.Generic.IList<CustomConnectorVersion> CustomConnectorVersions { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Connectors.ListCustomConnectors.</summary>
    public class ListCustomConnectorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of customConnectors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConnectors")]
        public virtual System.Collections.Generic.IList<CustomConnector> CustomConnectors { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConnectorsService.ListEndUserAuthentications</summary>
    public class ListEndUserAuthenticationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Subscriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUserAuthentications")]
        public virtual System.Collections.Generic.IList<EndUserAuthentication> EndUserAuthentications { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConnectorsService.ListEndpointAttachments</summary>
    public class ListEndpointAttachmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>EndpointAttachments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointAttachments")]
        public virtual System.Collections.Generic.IList<EndpointAttachment> EndpointAttachments { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListEntityTypes API</summary>
    public class ListEntityTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>list of entity types</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityTypes")]
        public virtual System.Collections.Generic.IList<RuntimeEntitySchema> EntityTypes { get; set; }

        /// <summary>token for next page</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConnectorsService.ListEventSubscriptions</summary>
    public class ListEventSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Subscriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventSubscriptions")]
        public virtual System.Collections.Generic.IList<EventSubscription> EventSubscriptions { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Connectors.ListEventTypes.</summary>
    public class ListEventTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of connector versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTypes")]
        public virtual System.Collections.Generic.IList<EventType> EventTypes { get; set; }

        /// <summary>Next page token.</summary>
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

    /// <summary>Response message for ConnectorsService.ListManagedZones</summary>
    public class ListManagedZonesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ManagedZones.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedZones")]
        public virtual System.Collections.Generic.IList<ManagedZone> ManagedZones { get; set; }

        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Response message for Connectors.ListProviders.</summary>
    public class ListProvidersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of providers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providers")]
        public virtual System.Collections.Generic.IList<Provider> Providers { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConnectorsService.ListRuntimeActionSchemas.</summary>
    public class ListRuntimeActionSchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Runtime action schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeActionSchemas")]
        public virtual System.Collections.Generic.IList<RuntimeActionSchema> RuntimeActionSchemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConnectorsService.ListRuntimeEntitySchemas.</summary>
    public class ListRuntimeEntitySchemasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Next page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Runtime entity schemas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeEntitySchemas")]
        public virtual System.Collections.Generic.IList<RuntimeEntitySchema> RuntimeEntitySchemas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Expected request for ListenEvent API.</summary>
    public class ListenEventRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Request payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string, object> Payload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Expected response for ListenEvent API.</summary>
    public class ListenEventResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Determines whether or no a connection is locked. If locked, a reason must be specified.</summary>
    public class LockConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indicates whether or not the connection is locked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locked")]
        public virtual System.Nullable<bool> Locked { get; set; }

        /// <summary>Optional. Describes why a connection is locked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Struct for representing boolean expressions.</summary>
    public class LogicalExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A list of fields to be compared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldComparisons")]
        public virtual System.Collections.Generic.IList<FieldComparison> FieldComparisons { get; set; }

        /// <summary>Optional. A list of nested conditions to be compared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalExpressions")]
        public virtual System.Collections.Generic.IList<LogicalExpression> LogicalExpressions { get; set; }

        /// <summary>Optional. The logical operator to use between the fields and conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalOperator")]
        public virtual string LogicalOperator { get; set; }

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

    /// <summary>represents the Connector's Managed Zone resource</summary>
    public class ManagedZone : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Optional. Description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. DNS Name of the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dns")]
        public virtual string Dns { get; set; }

        /// <summary>
        /// Optional. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Resource name of the Managed Zone. Format:
        /// projects/{project}/locations/global/managedZones/{managed_zone}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The name of the Target Project</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetProject")]
        public virtual string TargetProject { get; set; }

        /// <summary>Required. The name of the Target Project VPC Network</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetVpc")]
        public virtual string TargetVpc { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

    /// <summary>Marketplace connector details.</summary>
    public class MarketplaceConnectorDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Marketplace product name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplaceProduct")]
        public virtual string MarketplaceProduct { get; set; }

        /// <summary>Marketplace product ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplaceProductId")]
        public virtual string MarketplaceProductId { get; set; }

        /// <summary>Marketplace product URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplaceProductUri")]
        public virtual string MarketplaceProductUri { get; set; }

        /// <summary>The name of the partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partner")]
        public virtual string Partner { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MultipleSelectConfig represents the multiple options for a config variable.</summary>
    public class MultipleSelectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Allow custom values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowCustomValues")]
        public virtual System.Nullable<bool> AllowCustomValues { get; set; }

        /// <summary>Required. Multiple select options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleSelectOptions")]
        public virtual System.Collections.Generic.IList<MultipleSelectOption> MultipleSelectOptions { get; set; }

        /// <summary>Required. Value separator. Only "," can be used for OAuth auth code flow scope field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueSeparator")]
        public virtual string ValueSeparator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MultiplSelecteOption represents the single option for a config variable.</summary>
    public class MultipleSelectOption : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Value of the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Display name of the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Required. Key of the option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. Indicates if the option is preselected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preselected")]
        public virtual System.Nullable<bool> Preselected { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Regional Network Config.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Egress IPs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressIps")]
        public virtual System.Collections.Generic.IList<string> EgressIps { get; set; }

        /// <summary>Optional. Egress mode for the network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressMode")]
        public virtual string EgressMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Node configuration for the connection.</summary>
    public class NodeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Maximum number of nodes in the runtime nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNodeCount")]
        public virtual System.Nullable<int> MaxNodeCount { get; set; }

        /// <summary>Optional. Minimum number of nodes in the runtime nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minNodeCount")]
        public virtual System.Nullable<int> MinNodeCount { get; set; }

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

    /// <summary>pass only at create and not update using updateMask Auth Code Data</summary>
    public class OAuthTokenData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Access token for the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual EUASecret AccessToken { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Optional. Timestamp when the access token was created.</summary>
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

        /// <summary>Optional. Time in seconds when the access token expires.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiry")]
        public virtual object Expiry { get; set; }

        /// <summary>Optional. Refresh token for the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshToken")]
        public virtual EUASecret RefreshToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support Oauth 2.0 Auth Code Grant Authentication. See
    /// https://www.rfc-editor.org/rfc/rfc6749#section-1.3.1 for more details.
    /// </summary>
    public class Oauth2AuthCodeFlow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authorization code to be exchanged for access and refresh tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authCode")]
        public virtual string AuthCode { get; set; }

        /// <summary>Optional. Auth URL for Authorization Code Flow</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authUri")]
        public virtual string AuthUri { get; set; }

        /// <summary>Optional. Client ID for user-provided OAuth app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Optional. Client secret for user-provided OAuth app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual Secret ClientSecret { get; set; }

        /// <summary>Optional. Whether to enable PKCE when the user performs the auth code flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablePkce")]
        public virtual System.Nullable<bool> EnablePkce { get; set; }

        /// <summary>Optional. PKCE verifier to be used during the auth code exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pkceVerifier")]
        public virtual string PkceVerifier { get; set; }

        /// <summary>Optional. Redirect URI to be provided during the auth code exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>Optional. Scopes the connection will request when the user performs the auth code flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support Oauth 2.0 Auth Code Grant Authentication using Google Provided OAuth Client. See
    /// https://tools.ietf.org/html/rfc6749#section-1.3.1 for more details.
    /// </summary>
    public class Oauth2AuthCodeFlowGoogleManaged : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authorization code to be exchanged for access and refresh tokens.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authCode")]
        public virtual string AuthCode { get; set; }

        /// <summary>Optional. Redirect URI to be provided during the auth code exchange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUri")]
        public virtual string RedirectUri { get; set; }

        /// <summary>Required. Scopes the connection will request when the user performs the auth code flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support Oauth 2.0 Client Credentials Grant Authentication. See
    /// https://tools.ietf.org/html/rfc6749#section-1.3.4 for more details.
    /// </summary>
    public class Oauth2ClientCredentials : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The client identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Optional. Secret version reference containing the client secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual Secret ClientSecret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Parameters to support JSON Web Token (JWT) Profile for Oauth 2.0 Authorization Grant based authentication. See
    /// https://tools.ietf.org/html/rfc7523 for more details.
    /// </summary>
    public class Oauth2JwtBearer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Secret version reference containing a PKCS#8 PEM-encoded private key associated with the Client
        /// Certificate. This private key will be used to sign JWTs used for the jwt-bearer authorization grant.
        /// Specified in the form as: `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientKey")]
        public virtual Secret ClientKey { get; set; }

        /// <summary>Optional. JwtClaims providers fields to generate the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jwtClaims")]
        public virtual JwtClaims JwtClaims { get; set; }

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
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

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

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Partner metadata details. This will be populated when publishing the custom connector as a partner connector
    /// version. On publishing, parntner connector version will be created using the fields in PartnerMetadata.
    /// </summary>
    public class PartnerMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Whether the user has accepted the Google Cloud Platform Terms of Service
        /// (https://cloud.google.com/terms/) and the Google Cloud Marketplace Terms of Service
        /// (https://cloud.google.com/terms/marketplace/launcher?hl=en).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptGcpTos")]
        public virtual System.Nullable<bool> AcceptGcpTos { get; set; }

        /// <summary>Optional. Additional comments for the submission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalComments")]
        public virtual string AdditionalComments { get; set; }

        /// <summary>
        /// Required. Confirmation that connector meets all applicable requirements mentioned in the Partner Connector
        /// Publishing requirements list and Partner onboardiong requirements list
        /// (https://cloud.google.com/marketplace/docs/partners/get-started#requirements).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confirmPartnerRequirements")]
        public virtual System.Nullable<bool> ConfirmPartnerRequirements { get; set; }

        /// <summary>Required. Public URL for the demo video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("demoUri")]
        public virtual string DemoUri { get; set; }

        /// <summary>Output only. Has dynamic open api spec uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDynamicSpecUri")]
        public virtual System.Nullable<bool> HasDynamicSpecUri { get; set; }

        /// <summary>Required. Integration example templates for the custom connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationTemplates")]
        public virtual string IntegrationTemplates { get; set; }

        /// <summary>Output only. Local spec path. Required if has_dynamic_spec_uri is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localSpecPath")]
        public virtual string LocalSpecPath { get; set; }

        /// <summary>Optional. Marketplace product name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplaceProduct")]
        public virtual string MarketplaceProduct { get; set; }

        /// <summary>Required. Marketplace product ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplaceProductId")]
        public virtual string MarketplaceProductId { get; set; }

        /// <summary>Optional. Marketplace product project ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplaceProductProjectId")]
        public virtual string MarketplaceProductProjectId { get; set; }

        /// <summary>Optional. Marketplace product URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketplaceProductUri")]
        public virtual string MarketplaceProductUri { get; set; }

        /// <summary>Required. Partner name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partner")]
        public virtual string Partner { get; set; }

        /// <summary>Required. Partner connector display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerConnectorDisplayName")]
        public virtual string PartnerConnectorDisplayName { get; set; }

        private string _publishRequestTimeRaw;

        private object _publishRequestTime;

        /// <summary>Output only. Publish request time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishRequestTime")]
        public virtual string PublishRequestTimeRaw
        {
            get => _publishRequestTimeRaw;
            set
            {
                _publishRequestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _publishRequestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PublishRequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishRequestTimeDateTimeOffset instead.")]
        public virtual object PublishRequestTime
        {
            get => _publishRequestTime;
            set
            {
                _publishRequestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _publishRequestTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="PublishRequestTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PublishRequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PublishRequestTimeRaw);
            set => PublishRequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Target application for which partner connector is built.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetApplication")]
        public virtual string TargetApplication { get; set; }

        /// <summary>Required. Target customer segment for the partner connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCustomerSegment")]
        public virtual string TargetCustomerSegment { get; set; }

        /// <summary>Required. Details about partner connector use cases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useCases")]
        public virtual string UseCases { get; set; }

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
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
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

    /// <summary>PriorityEntityType represents an entity type with its associated priority and order.</summary>
    public class PriorityEntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The order of the entity type within its priority group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("order")]
        public virtual System.Nullable<int> Order { get; set; }

        /// <summary>The priority of the entity type, such as P0, P1, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provider indicates the owner who provides the connectors.</summary>
    public class Provider : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Created time.</summary>
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

        /// <summary>Output only. Description of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Link to documentation page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUri")]
        public virtual string DocumentationUri { get; set; }

        /// <summary>Output only. Link to external page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>
        /// Output only. Resource labels to represent user-provided metadata. Refer to cloud documentation on labels for
        /// more details. https://cloud.google.com/compute/docs/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Output only. Flag to mark the version indicating the launch stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// Output only. Resource name of the Provider. Format:
        /// projects/{project}/locations/{location}/providers/{provider} Only global location is supported for Provider
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Updated time.</summary>
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

        /// <summary>Output only. Cloud storage location of icons etc consumed by UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webAssetsLocation")]
        public virtual string WebAssetsLocation { get; set; }

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

    /// <summary>Pub/Sub message includes details of the Destination Pub/Sub topic.</summary>
    public class PubSub : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Pub/Sub message attributes to be added to the Pub/Sub message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>Optional. Configuration for configuring the trigger</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariable> ConfigVariables { get; set; }

        /// <summary>Required. The project id which has the Pub/Sub topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Required. The topic id of the Pub/Sub topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicId")]
        public virtual string TopicId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ConnectorsService.PublishCustomConnectorVersion</summary>
    public class PublishCustomConnectorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Partner metadata details for validating and publishing the custom connector as a partner connector
        /// version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partnerMetadata")]
        public virtual PartnerMetadata PartnerMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Publish status of a custom connector.</summary>
    public class PublishStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Publish state of the custom connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishState")]
        public virtual string PublishState { get; set; }

        private string _publishTimeRaw;

        private object _publishTime;

        /// <summary>Output only. Publish time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual string PublishTimeRaw
        {
            get => _publishTimeRaw;
            set
            {
                _publishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _publishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishTimeDateTimeOffset instead.")]
        public virtual object PublishTime
        {
            get => _publishTime;
            set
            {
                _publishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _publishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PublishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PublishTimeRaw);
            set => PublishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Partner connector name. Will be set on the custom connector. Format:
        /// providers/partner/connectors//versions/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedAs")]
        public virtual string PublishedAs { get; set; }

        /// <summary>
        /// Output only. Custom connector name. Will be set on the partner connector. Format:
        /// providers/customconnectors/connectors//versions/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishedSource")]
        public virtual string PublishedSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ConnectorsService.RefreshConnectionSchemaMetadata.</summary>
    public class RefreshConnectionSchemaMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Regional Settings details.</summary>
    public class RegionalSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Regional encryption config to hold CMEK details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionConfig")]
        public virtual EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Output only. Resource name of the Connection. Format:
        /// projects/{project}/locations/{location}/regionalSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Regional network config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkConfig")]
        public virtual NetworkConfig NetworkConfig { get; set; }

        /// <summary>Output only. Specifies whether the region is provisioned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioned")]
        public virtual System.Nullable<bool> Provisioned { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ConnectorsService.RepairEventing</summary>
    public class RepairEventingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource definition</summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Template to uniquely represent a Google Cloud resource in a format IAM expects This is a template
        /// that can have references to other values provided in the config variable template.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathTemplate")]
        public virtual string PathTemplate { get; set; }

        /// <summary>Optional. Different types of resource supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource limits defined for connection pods of a given connector type.</summary>
    public class ResourceLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. CPU limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual string Cpu { get; set; }

        /// <summary>Output only. Memory limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual string Memory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource requests defined for connection pods of a given connector type.</summary>
    public class ResourceRequests : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. CPU request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual string Cpu { get; set; }

        /// <summary>Output only. Memory request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual string Memory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of result field.</summary>
    public class ResultMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data type of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// The following field specifies the default value of the Parameter provided by the external system if a value
        /// is not provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual object DefaultValue { get; set; }

        /// <summary>A brief description of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Name of the result field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>JsonSchema representation of this action's result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonSchema JsonSchema { get; set; }

        /// <summary>Specifies whether a null value is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullable")]
        public virtual System.Nullable<bool> Nullable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ConnectorsService.RefreshEventSubscription</summary>
    public class RetryEventSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This configuration defines all the Cloud IAM roles that needs to be granted to a particular Google Cloud
    /// resource for the selected principal like service account. These configurations will let UI display to customers
    /// what IAM roles need to be granted by them. Or these configurations can be used by the UI to render a 'grant'
    /// button to do the same on behalf of the user.
    /// </summary>
    public class RoleGrant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Template that UI can use to provide helper text to customers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("helperTextTemplate")]
        public virtual string HelperTextTemplate { get; set; }

        /// <summary>Optional. Principal/Identity for whom the role need to assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        /// <summary>Optional. Resource on which the roles needs to be granted for the principal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>Optional. List of roles that need to be granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Schema of a runtime action.</summary>
    public class RuntimeActionSchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>Output only. Brief Description of action</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Display Name of action to be shown on client side</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. JsonSchema representation of this action's input metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputJsonSchema")]
        public virtual JsonSchema InputJsonSchema { get; set; }

        /// <summary>Output only. List of input parameter metadata for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputParameters")]
        public virtual System.Collections.Generic.IList<InputParameter> InputParameters { get; set; }

        /// <summary>Output only. Input schema as string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputSchemaAsString")]
        public virtual string InputSchemaAsString { get; set; }

        /// <summary>Output only. JsonSchema representation of this action's result metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultJsonSchema")]
        public virtual JsonSchema ResultJsonSchema { get; set; }

        /// <summary>Output only. List of result field metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultMetadata")]
        public virtual System.Collections.Generic.IList<ResultMetadata> ResultMetadata { get; set; }

        /// <summary>Output only. Result schema as string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultSchemaAsString")]
        public virtual string ResultSchemaAsString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// RuntimeConfig is the singleton resource of each location. It includes generic resource configs consumed by
    /// control plane and runtime plane like: pub/sub topic/subscription resource name, Cloud Storage location storing
    /// schema etc.
    /// </summary>
    public class RuntimeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Pub/Sub subscription for connd to receive message. E.g.
        /// projects/{project-id}/subscriptions/{topic-id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conndSubscription")]
        public virtual string ConndSubscription { get; set; }

        /// <summary>
        /// Output only. Pub/Sub topic for connd to send message. E.g. projects/{project-id}/topics/{topic-id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conndTopic")]
        public virtual string ConndTopic { get; set; }

        /// <summary>
        /// Output only. Pub/Sub subscription for control plane to receive message. E.g.
        /// projects/{project-id}/subscriptions/{topic-id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneSubscription")]
        public virtual string ControlPlaneSubscription { get; set; }

        /// <summary>
        /// Output only. Pub/Sub topic for control plne to send message. communication. E.g.
        /// projects/{project-id}/topics/{topic-id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controlPlaneTopic")]
        public virtual string ControlPlaneTopic { get; set; }

        /// <summary>Output only. location_id of the runtime location. E.g. "us-west1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Output only. Name of the runtimeConfig resource. Format:
        /// projects/{project}/locations/{location}/runtimeConfig
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The endpoint of the connectors runtime ingress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeEndpoint")]
        public virtual string RuntimeEndpoint { get; set; }

        /// <summary>Output only. The Cloud Storage bucket that stores connector's schema reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaGcsBucket")]
        public virtual string SchemaGcsBucket { get; set; }

        /// <summary>Output only. The name of the Service Directory service name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectory")]
        public virtual string ServiceDirectory { get; set; }

        /// <summary>Output only. The state of the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Schema of a runtime entity.</summary>
    public class RuntimeEntitySchema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Name of the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual string Entity { get; set; }

        /// <summary>Output only. List of fields in the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<Field> Fields { get; set; }

        /// <summary>Output only. JsonSchema representation of this entity's metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchema")]
        public virtual JsonSchema JsonSchema { get; set; }

        /// <summary>List of operations supported by this entity</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<string> Operations { get; set; }

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

    /// <summary>Config for connection schema refresh</summary>
    public class SchemaRefreshConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to use displayName for actions in UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useActionDisplayNames")]
        public virtual System.Nullable<bool> UseActionDisplayNames { get; set; }

        /// <summary>Whether to use synchronous schema refresh.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSynchronousSchemaRefresh")]
        public virtual System.Nullable<bool> UseSynchronousSchemaRefresh { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SearchConnectionInstance represents an instance of connector with specific fields</summary>
    public class SearchConnectionInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Schema of a runtime action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionSchema")]
        public virtual RuntimeActionSchema ActionSchema { get; set; }

        /// <summary>Output only. Connection details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connection")]
        public virtual Connection Connection { get; set; }

        /// <summary>Output only. Schema of a runtime entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitySchema")]
        public virtual RuntimeEntitySchema EntitySchema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Connectors.SearchConnections.</summary>
    public class SearchConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of connectors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<SearchConnectionInstance> Connections { get; set; }

        /// <summary>Optional. page_token</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Secret provides a reference to entries in Secret Manager.</summary>
    public class Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource name of the secret version in the format, format as:
        /// `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretVersion")]
        public virtual string SecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
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

    /// <summary>Global Settings details.</summary>
    public class Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Resource name of the Connection. Format: projects/{project}/locations/global/settings}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Flag indicates if user is in PayG model</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payg")]
        public virtual System.Nullable<bool> Payg { get; set; }

        /// <summary>Output only. Tenant project id of the consumer project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectId")]
        public virtual string TenantProjectId { get; set; }

        /// <summary>Optional. Flag indicates whether vpc-sc is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcsc")]
        public virtual System.Nullable<bool> Vpcsc { get; set; }

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

    /// <summary>Source to extract the backend from.</summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Field identifier. For example config variable name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; }

        /// <summary>Type of the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceType")]
        public virtual string SourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters to support Ssh public key Authentication.</summary>
    public class SshPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Format of SSH Client cert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certType")]
        public virtual string CertType { get; set; }

        /// <summary>Optional. SSH Client Cert. It should contain both public and private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshClientCert")]
        public virtual Secret SshClientCert { get; set; }

        /// <summary>Optional. Password (passphrase) for ssh client certificate if it has one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshClientCertPass")]
        public virtual Secret SshClientCertPass { get; set; }

        /// <summary>Optional. The user account used to authenticate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SSL Configuration of a connection</summary>
    public class SslConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Additional SSL related field values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariable> AdditionalVariables { get; set; }

        /// <summary>Optional. Type of Client Cert (PEM/JKS/.. etc.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertType")]
        public virtual string ClientCertType { get; set; }

        /// <summary>Optional. Client Certificate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertificate")]
        public virtual Secret ClientCertificate { get; set; }

        /// <summary>Optional. Client Private Key</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientPrivateKey")]
        public virtual Secret ClientPrivateKey { get; set; }

        /// <summary>Optional. Secret containing the passphrase protecting the Client Private Key</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientPrivateKeyPass")]
        public virtual Secret ClientPrivateKeyPass { get; set; }

        /// <summary>Optional. Private Server Certificate. Needs to be specified if trust model is `PRIVATE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateServerCertificate")]
        public virtual Secret PrivateServerCertificate { get; set; }

        /// <summary>Optional. Type of Server Cert (PEM/JKS/.. etc.)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCertType")]
        public virtual string ServerCertType { get; set; }

        /// <summary>Optional. Trust Model of the SSL connection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustModel")]
        public virtual string TrustModel { get; set; }

        /// <summary>Optional. Controls the ssl type for the given connector version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Optional. Bool for enabling SSL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSsl")]
        public virtual System.Nullable<bool> UseSsl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ssl config details of a connector version</summary>
    public class SslConfigTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Any additional fields that need to be rendered</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariableTemplate> AdditionalVariables { get; set; }

        /// <summary>List of supported Client Cert Types</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientCertType")]
        public virtual System.Collections.Generic.IList<string> ClientCertType { get; set; }

        /// <summary>Boolean for determining if the connector version mandates TLS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTlsMandatory")]
        public virtual System.Nullable<bool> IsTlsMandatory { get; set; }

        /// <summary>List of supported Server Cert Types</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCertType")]
        public virtual System.Collections.Generic.IList<string> ServerCertType { get; set; }

        /// <summary>Controls the ssl type for the given connector version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslType")]
        public virtual string SslType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Standard action</summary>
    public class StandardAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the standard action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Standard entity</summary>
    public class StandardEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the standard entity.</summary>
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

    /// <summary>Supported runtime features of a connector version.</summary>
    public class SupportedRuntimeFeatures : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies if the connector supports action apis like 'executeAction'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionApis")]
        public virtual System.Nullable<bool> ActionApis { get; set; }

        /// <summary>Specifies if the connector supports async long running operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asyncOperations")]
        public virtual System.Nullable<bool> AsyncOperations { get; set; }

        /// <summary>Specifies if the connector supports entity apis like 'createEntity'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityApis")]
        public virtual System.Nullable<bool> EntityApis { get; set; }

        /// <summary>Specifies if the connector supports 'ExecuteSqlQuery' operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlQuery")]
        public virtual System.Nullable<bool> SqlQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
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
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

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

    /// <summary>
    /// * TrafficShapingConfig defines the configuration for shaping API traffic by specifying a quota limit and the
    /// duration over which this limit is enforced. This configuration helps to control and manage the rate at which API
    /// calls are made on the client side, preventing service overload on the backend. For example: - if the quota limit
    /// is 100 calls per 10 seconds, then the message would be: { quota_limit: 100 duration: { seconds: 10 } } - if the
    /// quota limit is 100 calls per 5 minutes, then the message would be: { quota_limit: 100 duration: { seconds: 300 }
    /// } - if the quota limit is 10000 calls per day, then the message would be: { quota_limit: 10000 duration: {
    /// seconds: 86400 } and so on.
    /// </summary>
    public class TrafficShapingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. * The duration over which the API call quota limits are calculated. This duration is used to
        /// define the time window for evaluating if the number of API calls made by a user is within the allowed quota
        /// limits. For example: - To define a quota sampled over 16 seconds, set `seconds` to 16 - To define a quota
        /// sampled over 5 minutes, set `seconds` to 300 (5 * 60) - To define a quota sampled over 1 day, set `seconds`
        /// to 86400 (24 * 60 * 60) and so on. It is important to note that this duration is not the time the quota is
        /// valid for, but rather the time window over which the quota is evaluated. For example, if the quota is 100
        /// calls per 10 seconds, then this duration field would be set to 10 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Required. Maximum number of api calls allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaLimit")]
        public virtual System.Nullable<long> QuotaLimit { get; set; }

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

    /// <summary>Parameters to support Username and Password Authentication.</summary>
    public class UserPassword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Secret version reference containing the password.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual Secret Password { get; set; }

        /// <summary>Optional. Username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ConnectorsService.ValidateCustomConnectorSpec</summary>
    public class ValidateCustomConnectorSpecRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Service account to access the spec from Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Required. Location of the custom connector spec. The location can be either a public url like
        /// `https://public-url.com/spec` Or a Google Cloud Storage location like `gs:///`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specLocation")]
        public virtual string SpecLocation { get; set; }

        /// <summary>Required. Spec type of the custom connector spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specType")]
        public virtual string SpecType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConnectorsService.ValidateCustomConnectorSpec</summary>
    public class ValidateCustomConnectorSpecResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error message. The spec is valid if the error message is empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>WebhookData has details of webhook configuration.</summary>
    public class WebhookData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Additional webhook related field values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalVariables")]
        public virtual System.Collections.Generic.IList<ConfigVariable> AdditionalVariables { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp when the webhook was created.</summary>
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

        /// <summary>Output only. ID to uniquely identify webhook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Name of the Webhook</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _nextRefreshTimeRaw;

        private object _nextRefreshTime;

        /// <summary>Output only. Next webhook refresh time. Will be null if refresh is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRefreshTime")]
        public virtual string NextRefreshTimeRaw
        {
            get => _nextRefreshTimeRaw;
            set
            {
                _nextRefreshTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextRefreshTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextRefreshTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextRefreshTimeDateTimeOffset instead.")]
        public virtual object NextRefreshTime
        {
            get => _nextRefreshTime;
            set
            {
                _nextRefreshTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextRefreshTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextRefreshTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextRefreshTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextRefreshTimeRaw);
            set => NextRefreshTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when the webhook was last updated.</summary>
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

    /// <summary>WebhookSubscriptions has details of webhook subscriptions.</summary>
    public class WebhookSubscriptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Webhook data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookData")]
        public virtual System.Collections.Generic.IList<WebhookData> WebhookData { get; set; }

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

    /// <summary>Request message for ConnectorsService.WithdrawCustomConnectorVersion</summary>
    public class WithdrawCustomConnectorVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
