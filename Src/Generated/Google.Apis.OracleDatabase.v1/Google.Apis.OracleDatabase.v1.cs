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

namespace Google.Apis.OracleDatabase.v1
{
    /// <summary>The OracleDatabase Service.</summary>
    public class OracleDatabaseService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public OracleDatabaseService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public OracleDatabaseService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://oracledatabase.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://oracledatabase.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "oracledatabase";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Oracle Database@Google Cloud API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Oracle Database@Google Cloud API.</summary>
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

    /// <summary>A base abstract class for OracleDatabase requests.</summary>
    public abstract class OracleDatabaseBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new OracleDatabaseBaseServiceRequest instance.</summary>
        protected OracleDatabaseBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes OracleDatabase parameter list.</summary>
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
                AutonomousDatabaseBackups = new AutonomousDatabaseBackupsResource(service);
                AutonomousDatabaseCharacterSets = new AutonomousDatabaseCharacterSetsResource(service);
                AutonomousDatabases = new AutonomousDatabasesResource(service);
                AutonomousDbVersions = new AutonomousDbVersionsResource(service);
                CloudExadataInfrastructures = new CloudExadataInfrastructuresResource(service);
                CloudVmClusters = new CloudVmClustersResource(service);
                DatabaseCharacterSets = new DatabaseCharacterSetsResource(service);
                Databases = new DatabasesResource(service);
                DbSystemInitialStorageSizes = new DbSystemInitialStorageSizesResource(service);
                DbSystemShapes = new DbSystemShapesResource(service);
                DbSystems = new DbSystemsResource(service);
                DbVersions = new DbVersionsResource(service);
                Entitlements = new EntitlementsResource(service);
                ExadbVmClusters = new ExadbVmClustersResource(service);
                ExascaleDbStorageVaults = new ExascaleDbStorageVaultsResource(service);
                GiVersions = new GiVersionsResource(service);
                GoldengateConnectionAssignments = new GoldengateConnectionAssignmentsResource(service);
                GoldengateConnectionTypes = new GoldengateConnectionTypesResource(service);
                GoldengateConnections = new GoldengateConnectionsResource(service);
                GoldengateDeploymentEnvironments = new GoldengateDeploymentEnvironmentsResource(service);
                GoldengateDeploymentTypes = new GoldengateDeploymentTypesResource(service);
                GoldengateDeploymentVersions = new GoldengateDeploymentVersionsResource(service);
                GoldengateDeployments = new GoldengateDeploymentsResource(service);
                OdbNetworks = new OdbNetworksResource(service);
                Operations = new OperationsResource(service);
                PluggableDatabases = new PluggableDatabasesResource(service);
            }

            /// <summary>Gets the AutonomousDatabaseBackups resource.</summary>
            public virtual AutonomousDatabaseBackupsResource AutonomousDatabaseBackups { get; }

            /// <summary>The "autonomousDatabaseBackups" collection of methods.</summary>
            public class AutonomousDatabaseBackupsResource
            {
                private const string Resource = "autonomousDatabaseBackups";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AutonomousDatabaseBackupsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the long-term and automatic backups of an Autonomous Database.</summary>
                /// <param name="parent">
                /// Required. The parent value for ListAutonomousDatabaseBackups in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the long-term and automatic backups of an Autonomous Database.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListAutonomousDatabaseBackupsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for ListAutonomousDatabaseBackups in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Only the
                    /// **autonomous_database_id** field is supported in the following format:
                    /// `autonomous_database_id="{autonomous_database_id}"`. The accepted values must be a valid
                    /// Autonomous Database ID, limited to the naming restrictions of the ID:
                    /// ^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$). The ID must start with a letter, end with a letter or a
                    /// number, and be a maximum of 63 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 Autonomous DB
                    /// Backups will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/autonomousDatabaseBackups";

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
            }

            /// <summary>Gets the AutonomousDatabaseCharacterSets resource.</summary>
            public virtual AutonomousDatabaseCharacterSetsResource AutonomousDatabaseCharacterSets { get; }

            /// <summary>The "autonomousDatabaseCharacterSets" collection of methods.</summary>
            public class AutonomousDatabaseCharacterSetsResource
            {
                private const string Resource = "autonomousDatabaseCharacterSets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AutonomousDatabaseCharacterSetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists Autonomous Database Character Sets in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Autonomous Database Character Sets in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListAutonomousDatabaseCharacterSetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Only the
                    /// **character_set_type** field is supported in the following format:
                    /// `character_set_type="{characterSetType}"`. Accepted values include `DATABASE` and `NATIONAL`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 Autonomous DB
                    /// Character Sets will be returned. The maximum value is 1000; values above 1000 will be coerced to
                    /// 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/autonomousDatabaseCharacterSets";

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
            }

            /// <summary>Gets the AutonomousDatabases resource.</summary>
            public virtual AutonomousDatabasesResource AutonomousDatabases { get; }

            /// <summary>The "autonomousDatabases" collection of methods.</summary>
            public class AutonomousDatabasesResource
            {
                private const string Resource = "autonomousDatabases";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AutonomousDatabasesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new Autonomous Database in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the parent in the following format: projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.AutonomousDatabase body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Autonomous Database in a given project and location.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.AutonomousDatabase body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the parent in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the Autonomous Database to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("autonomousDatabaseId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AutonomousDatabaseId { get; set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.AutonomousDatabase Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/autonomousDatabases";

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
                        RequestParameters.Add("autonomousDatabaseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "autonomousDatabaseId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Autonomous Database.</summary>
                /// <param name="name">
                /// Required. The name of the resource in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Autonomous Database.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the resource in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Initiates a failover to target autonomous database from the associated primary database.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual FailoverRequest Failover(Google.Apis.OracleDatabase.v1.Data.FailoverAutonomousDatabaseRequest body, string name)
                {
                    return new FailoverRequest(this.service, body, name);
                }

                /// <summary>
                /// Initiates a failover to target autonomous database from the associated primary database.
                /// </summary>
                public class FailoverRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Failover request.</summary>
                    public FailoverRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.FailoverAutonomousDatabaseRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.FailoverAutonomousDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "failover";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:failover";

                    /// <summary>Initializes Failover parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                    }
                }

                /// <summary>Generates a wallet for an Autonomous Database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual GenerateWalletRequest GenerateWallet(Google.Apis.OracleDatabase.v1.Data.GenerateAutonomousDatabaseWalletRequest body, string name)
                {
                    return new GenerateWalletRequest(this.service, body, name);
                }

                /// <summary>Generates a wallet for an Autonomous Database.</summary>
                public class GenerateWalletRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.GenerateAutonomousDatabaseWalletResponse>
                {
                    /// <summary>Constructs a new GenerateWallet request.</summary>
                    public GenerateWalletRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.GenerateAutonomousDatabaseWalletRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.GenerateAutonomousDatabaseWalletRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "generateWallet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:generateWallet";

                    /// <summary>Initializes GenerateWallet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a single Autonomous Database.</summary>
                /// <param name="name">
                /// Required. The name of the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a single Autonomous Database.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.AutonomousDatabase>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the Autonomous Databases in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the Autonomous Databases in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListAutonomousDatabasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An expression for filtering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. An expression for ordering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 Autonomous Database
                    /// will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/autonomousDatabases";

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

                /// <summary>Updates the parameters of a single Autonomous Database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the Autonomous Database resource in the following format:
                /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.OracleDatabase.v1.Data.AutonomousDatabase body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Autonomous Database.</summary>
                public class PatchRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.AutonomousDatabase body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the Autonomous Database resource in the following format:
                    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. Field mask is used to specify the fields to be overwritten in the Exadata resource by
                    /// the update. The fields specified in the update_mask are relative to the resource, not the full
                    /// request. A field will be overwritten if it is in the mask. If the user does not provide a mask
                    /// then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.AutonomousDatabase Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
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

                /// <summary>Restarts an Autonomous Database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual RestartRequest Restart(Google.Apis.OracleDatabase.v1.Data.RestartAutonomousDatabaseRequest body, string name)
                {
                    return new RestartRequest(this.service, body, name);
                }

                /// <summary>Restarts an Autonomous Database.</summary>
                public class RestartRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Restart request.</summary>
                    public RestartRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.RestartAutonomousDatabaseRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.RestartAutonomousDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restart";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:restart";

                    /// <summary>Initializes Restart parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                    }
                }

                /// <summary>Restores a single Autonomous Database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual RestoreRequest Restore(Google.Apis.OracleDatabase.v1.Data.RestoreAutonomousDatabaseRequest body, string name)
                {
                    return new RestoreRequest(this.service, body, name);
                }

                /// <summary>Restores a single Autonomous Database.</summary>
                public class RestoreRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.RestoreAutonomousDatabaseRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.RestoreAutonomousDatabaseRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                    }
                }

                /// <summary>Starts an Autonomous Database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual StartRequest Start(Google.Apis.OracleDatabase.v1.Data.StartAutonomousDatabaseRequest body, string name)
                {
                    return new StartRequest(this.service, body, name);
                }

                /// <summary>Starts an Autonomous Database.</summary>
                public class StartRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Start request.</summary>
                    public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.StartAutonomousDatabaseRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.StartAutonomousDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "start";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:start";

                    /// <summary>Initializes Start parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                    }
                }

                /// <summary>Stops an Autonomous Database.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual StopRequest Stop(Google.Apis.OracleDatabase.v1.Data.StopAutonomousDatabaseRequest body, string name)
                {
                    return new StopRequest(this.service, body, name);
                }

                /// <summary>Stops an Autonomous Database.</summary>
                public class StopRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.StopAutonomousDatabaseRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.StopAutonomousDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "stop";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:stop";

                    /// <summary>Initializes Stop parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Initiates a switchover of specified autonomous database to the associated peer database.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                /// </param>
                public virtual SwitchoverRequest Switchover(Google.Apis.OracleDatabase.v1.Data.SwitchoverAutonomousDatabaseRequest body, string name)
                {
                    return new SwitchoverRequest(this.service, body, name);
                }

                /// <summary>
                /// Initiates a switchover of specified autonomous database to the associated peer database.
                /// </summary>
                public class SwitchoverRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Switchover request.</summary>
                    public SwitchoverRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.SwitchoverAutonomousDatabaseRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.SwitchoverAutonomousDatabaseRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "switchover";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:switchover";

                    /// <summary>Initializes Switchover parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/autonomousDatabases/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the AutonomousDbVersions resource.</summary>
            public virtual AutonomousDbVersionsResource AutonomousDbVersions { get; }

            /// <summary>The "autonomousDbVersions" collection of methods.</summary>
            public class AutonomousDbVersionsResource
            {
                private const string Resource = "autonomousDbVersions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AutonomousDbVersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists all the available Autonomous Database versions for a project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for the Autonomous Database in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the available Autonomous Database versions for a project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListAutonomousDbVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the Autonomous Database in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 Autonomous DB
                    /// Versions will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/autonomousDbVersions";

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
            }

            /// <summary>Gets the CloudExadataInfrastructures resource.</summary>
            public virtual CloudExadataInfrastructuresResource CloudExadataInfrastructures { get; }

            /// <summary>The "cloudExadataInfrastructures" collection of methods.</summary>
            public class CloudExadataInfrastructuresResource
            {
                private const string Resource = "cloudExadataInfrastructures";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CloudExadataInfrastructuresResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    DbServers = new DbServersResource(service);
                }

                /// <summary>Gets the DbServers resource.</summary>
                public virtual DbServersResource DbServers { get; }

                /// <summary>The "dbServers" collection of methods.</summary>
                public class DbServersResource
                {
                    private const string Resource = "dbServers";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DbServersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists the database servers of an Exadata Infrastructure instance.</summary>
                    /// <param name="parent">
                    /// Required. The parent value for database server in the following format:
                    /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloudExadataInfrastructure}.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the database servers of an Exadata Infrastructure instance.</summary>
                    public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDbServersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent value for database server in the following format:
                        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloudExadataInfrastructure}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If unspecified, a maximum of 50 db servers
                        /// will be returned. The maximum value is 1000; values above 1000 will be reset to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dbServers";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/cloudExadataInfrastructures/[^/]+$",
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

                /// <summary>Creates a new Exadata Infrastructure in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent value for CloudExadataInfrastructure in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.CloudExadataInfrastructure body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Exadata Infrastructure in a given project and location.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.CloudExadataInfrastructure body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for CloudExadataInfrastructure in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the Exadata Infrastructure to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("cloudExadataInfrastructureId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CloudExadataInfrastructureId { get; set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.CloudExadataInfrastructure Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/cloudExadataInfrastructures";

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
                        RequestParameters.Add("cloudExadataInfrastructureId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "cloudExadataInfrastructureId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Exadata Infrastructure.</summary>
                /// <param name="name">
                /// Required. The name of the Cloud Exadata Infrastructure in the following format:
                /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Exadata Infrastructure.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Cloud Exadata Infrastructure in the following format:
                    /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, all VM clusters for this Exadata Infrastructure will be deleted. An
                    /// Exadata Infrastructure can only be deleted once all its VM clusters have been deleted.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/cloudExadataInfrastructures/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single Exadata Infrastructure.</summary>
                /// <param name="name">
                /// Required. The name of the Cloud Exadata Infrastructure in the following format:
                /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Exadata Infrastructure.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.CloudExadataInfrastructure>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Cloud Exadata Infrastructure in the following format:
                    /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/cloudExadataInfrastructures/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Exadata Infrastructures in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for CloudExadataInfrastructure in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Exadata Infrastructures in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListCloudExadataInfrastructuresResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for CloudExadataInfrastructure in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An expression for filtering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. An expression for ordering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 Exadata
                    /// infrastructures will be returned. The maximum value is 1000; values above 1000 will be coerced
                    /// to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/cloudExadataInfrastructures";

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
            }

            /// <summary>Gets the CloudVmClusters resource.</summary>
            public virtual CloudVmClustersResource CloudVmClusters { get; }

            /// <summary>The "cloudVmClusters" collection of methods.</summary>
            public class CloudVmClustersResource
            {
                private const string Resource = "cloudVmClusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CloudVmClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    DbNodes = new DbNodesResource(service);
                }

                /// <summary>Gets the DbNodes resource.</summary>
                public virtual DbNodesResource DbNodes { get; }

                /// <summary>The "dbNodes" collection of methods.</summary>
                public class DbNodesResource
                {
                    private const string Resource = "dbNodes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DbNodesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists the database nodes of a VM Cluster.</summary>
                    /// <param name="parent">
                    /// Required. The parent value for database node in the following format:
                    /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}. .
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the database nodes of a VM Cluster.</summary>
                    public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDbNodesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent value for database node in the following format:
                        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}. .
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If unspecified, at most 50 db nodes will be
                        /// returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the node should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dbNodes";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/cloudVmClusters/[^/]+$",
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

                /// <summary>Creates a new VM Cluster in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the parent in the following format: projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.CloudVmCluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new VM Cluster in a given project and location.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.CloudVmCluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the parent in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the VM Cluster to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("cloudVmClusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CloudVmClusterId { get; set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.CloudVmCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/cloudVmClusters";

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
                        RequestParameters.Add("cloudVmClusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "cloudVmClusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single VM Cluster.</summary>
                /// <param name="name">
                /// Required. The name of the Cloud VM Cluster in the following format:
                /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single VM Cluster.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Cloud VM Cluster in the following format:
                    /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, all child resources for the VM Cluster will be deleted. A VM Cluster
                    /// can only be deleted once all its child resources have been deleted.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/cloudVmClusters/[^/]+$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single VM Cluster.</summary>
                /// <param name="name">
                /// Required. The name of the Cloud VM Cluster in the following format:
                /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single VM Cluster.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.CloudVmCluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Cloud VM Cluster in the following format:
                    /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/cloudVmClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the VM Clusters in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The name of the parent in the following format: projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the VM Clusters in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListCloudVmClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the parent in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An expression for filtering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The number of VM clusters to return. If unspecified, at most 50 VM clusters will be
                    /// returned. The maximum value is 1,000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying the page of results the server returns.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/cloudVmClusters";

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
            }

            /// <summary>Gets the DatabaseCharacterSets resource.</summary>
            public virtual DatabaseCharacterSetsResource DatabaseCharacterSets { get; }

            /// <summary>The "databaseCharacterSets" collection of methods.</summary>
            public class DatabaseCharacterSetsResource
            {
                private const string Resource = "databaseCharacterSets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DatabaseCharacterSetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List DatabaseCharacterSets for the given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for DatabaseCharacterSets in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List DatabaseCharacterSets for the given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDatabaseCharacterSetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for DatabaseCharacterSets in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Only the
                    /// **character_set_type** field is supported in the following format:
                    /// `character_set_type="{characterSetType}"`. Accepted values include `DATABASE` and `NATIONAL`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of DatabaseCharacterSets to return. The service may return fewer
                    /// than this value. If unspecified, at most 50 DatabaseCharacterSets will be returned. The maximum
                    /// value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListDatabaseCharacterSets` call. Provide this
                    /// to retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListDatabaseCharacterSets` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/databaseCharacterSets";

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
            }

            /// <summary>Gets the Databases resource.</summary>
            public virtual DatabasesResource Databases { get; }

            /// <summary>The "databases" collection of methods.</summary>
            public class DatabasesResource
            {
                private const string Resource = "databases";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DatabasesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details of a single Database.</summary>
                /// <param name="name">
                /// Required. The name of the Database resource in the following format:
                /// projects/{project}/locations/{region}/databases/{database}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Database.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Database>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Database resource in the following format:
                    /// projects/{project}/locations/{region}/databases/{database}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/databases/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the Databases for the given project, location and DbSystem.</summary>
                /// <param name="parent">
                /// Required. The parent resource name in the following format: projects/{project}/locations/{region}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the Databases for the given project, location and DbSystem.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDatabasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name in the following format:
                    /// projects/{project}/locations/{region}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. list for container databases
                    /// is supported only with a valid dbSystem (full resource name) filter in this format:
                    /// `dbSystem="projects/{project}/locations/{location}/dbSystems/{dbSystemId}"`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, a maximum of 50 Databases will
                    /// be returned. The maximum value is 1000; values above 1000 will be reset to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token identifying the requested page of results to return. All fields except the
                    /// filter should remain the same as in the request that provided this page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/databases";

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
            }

            /// <summary>Gets the DbSystemInitialStorageSizes resource.</summary>
            public virtual DbSystemInitialStorageSizesResource DbSystemInitialStorageSizes { get; }

            /// <summary>The "dbSystemInitialStorageSizes" collection of methods.</summary>
            public class DbSystemInitialStorageSizesResource
            {
                private const string Resource = "dbSystemInitialStorageSizes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DbSystemInitialStorageSizesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists all the DbSystemInitialStorageSizes for the given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for the DbSystemInitialStorageSize resource with the format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the DbSystemInitialStorageSizes for the given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDbSystemInitialStorageSizesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the DbSystemInitialStorageSize resource with the format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, a maximum of 50
                    /// DbSystemInitialStorageSizes will be returned. The maximum value is 1000; values above 1000 will
                    /// be reset to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token identifying the requested page of results to return. All fields except the
                    /// filter should remain the same as in the request that provided this page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dbSystemInitialStorageSizes";

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
            }

            /// <summary>Gets the DbSystemShapes resource.</summary>
            public virtual DbSystemShapesResource DbSystemShapes { get; }

            /// <summary>The "dbSystemShapes" collection of methods.</summary>
            public class DbSystemShapesResource
            {
                private const string Resource = "dbSystemShapes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DbSystemShapesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the database system shapes available for the project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for Database System Shapes in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the database system shapes available for the project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDbSystemShapesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for Database System Shapes in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Only the gcp_oracle_zone_id
                    /// field is supported in this format: `gcp_oracle_zone_id="{gcp_oracle_zone_id}"`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 database system
                    /// shapes will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dbSystemShapes";

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
            }

            /// <summary>Gets the DbSystems resource.</summary>
            public virtual DbSystemsResource DbSystems { get; }

            /// <summary>The "dbSystems" collection of methods.</summary>
            public class DbSystemsResource
            {
                private const string Resource = "dbSystems";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DbSystemsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new DbSystem in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The value for parent of the DbSystem in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.DbSystem body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new DbSystem in a given project and location.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.DbSystem body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The value for parent of the DbSystem in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the DbSystem to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dbSystemId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DbSystemId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.DbSystem Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dbSystems";

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
                        RequestParameters.Add("dbSystemId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dbSystemId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single DbSystem.</summary>
                /// <param name="name">
                /// Required. The name of the DbSystem in the following format:
                /// projects/{project}/locations/{location}/dbSystems/{db_system}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single DbSystem.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the DbSystem in the following format:
                    /// projects/{project}/locations/{location}/dbSystems/{db_system}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dbSystems/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single DbSystem.</summary>
                /// <param name="name">
                /// Required. The name of the DbSystem in the following format:
                /// projects/{project}/locations/{location}/dbSystems/{db_system}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single DbSystem.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.DbSystem>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the DbSystem in the following format:
                    /// projects/{project}/locations/{location}/dbSystems/{db_system}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dbSystems/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the DbSystems for the given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for DbSystems in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the DbSystems for the given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDbSystemsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for DbSystems in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An expression for filtering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. An expression for ordering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 DbSystems will be
                    /// returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dbSystems";

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
            }

            /// <summary>Gets the DbVersions resource.</summary>
            public virtual DbVersionsResource DbVersions { get; }

            /// <summary>The "dbVersions" collection of methods.</summary>
            public class DbVersionsResource
            {
                private const string Resource = "dbVersions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DbVersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List DbVersions for the given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for the DbVersion resource with the format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List DbVersions for the given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDbVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the DbVersion resource with the format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Filter expression that matches a subset of the DbVersions to show. The supported
                    /// filter for dbSystem creation is `db_system_shape = {db_system_shape} AND storage_management =
                    /// {storage_management}`. If no filter is provided, all DbVersions will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, a maximum of 50 DbVersions will
                    /// be returned. The maximum value is 1000; values above 1000 will be reset to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A token identifying the requested page of results to return. All fields except the
                    /// filter should remain the same as in the request that provided this page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/dbVersions";

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
            }

            /// <summary>Gets the Entitlements resource.</summary>
            public virtual EntitlementsResource Entitlements { get; }

            /// <summary>The "entitlements" collection of methods.</summary>
            public class EntitlementsResource
            {
                private const string Resource = "entitlements";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EntitlementsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the entitlements in a given project.</summary>
                /// <param name="parent">
                /// Required. The parent value for the entitlement in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the entitlements in a given project.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListEntitlementsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the entitlement in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, a maximum of 50 entitlements
                    /// will be returned. The maximum value is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/entitlements";

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
            }

            /// <summary>Gets the ExadbVmClusters resource.</summary>
            public virtual ExadbVmClustersResource ExadbVmClusters { get; }

            /// <summary>The "exadbVmClusters" collection of methods.</summary>
            public class ExadbVmClustersResource
            {
                private const string Resource = "exadbVmClusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ExadbVmClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    DbNodes = new DbNodesResource(service);
                }

                /// <summary>Gets the DbNodes resource.</summary>
                public virtual DbNodesResource DbNodes { get; }

                /// <summary>The "dbNodes" collection of methods.</summary>
                public class DbNodesResource
                {
                    private const string Resource = "dbNodes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DbNodesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists the database nodes of a VM Cluster.</summary>
                    /// <param name="parent">
                    /// Required. The parent value for database node in the following format:
                    /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}. .
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists the database nodes of a VM Cluster.</summary>
                    public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListDbNodesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent value for database node in the following format:
                        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}. .
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If unspecified, at most 50 db nodes will be
                        /// returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the node should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dbNodes";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/exadbVmClusters/[^/]+$",
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

                /// <summary>Creates a new Exadb (Exascale) VM Cluster resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The value for parent of the ExadbVmCluster in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.ExadbVmCluster body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Exadb (Exascale) VM Cluster resource.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.ExadbVmCluster body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The value for parent of the ExadbVmCluster in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the ExadbVmCluster to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("exadbVmClusterId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ExadbVmClusterId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.ExadbVmCluster Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/exadbVmClusters";

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
                        RequestParameters.Add("exadbVmClusterId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "exadbVmClusterId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Exadb (Exascale) VM Cluster.</summary>
                /// <param name="name">
                /// Required. The name of the ExadbVmCluster in the following format:
                /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Exadb (Exascale) VM Cluster.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ExadbVmCluster in the following format:
                    /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/exadbVmClusters/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single Exadb (Exascale) VM Cluster.</summary>
                /// <param name="name">
                /// Required. The name of the ExadbVmCluster in the following format:
                /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Exadb (Exascale) VM Cluster.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ExadbVmCluster>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ExadbVmCluster in the following format:
                    /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/exadbVmClusters/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the Exadb (Exascale) VM Clusters for the given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for ExadbVmClusters in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the Exadb (Exascale) VM Clusters for the given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListExadbVmClustersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for ExadbVmClusters in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An expression for filtering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. An expression for ordering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 ExadbVmClusters will
                    /// be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/exadbVmClusters";

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

                /// <summary>
                /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to existing exadb vm cluster,
                /// only pass the node count.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The name of the ExadbVmCluster resource in the following format:
                /// projects/{project}/locations/{region}/exadbVmClusters/{exadb_vm_cluster}
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.OracleDatabase.v1.Data.ExadbVmCluster body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to existing exadb vm cluster,
                /// only pass the node count.
                /// </summary>
                public class PatchRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.ExadbVmCluster body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The name of the ExadbVmCluster resource in the following format:
                    /// projects/{project}/locations/{region}/exadbVmClusters/{exadb_vm_cluster}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Optional. A mask specifying which fields in th VM Cluster should be updated. A field specified
                    /// in the mask is overwritten. If a mask isn't provided then all the fields in the VM Cluster are
                    /// overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.ExadbVmCluster Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/exadbVmClusters/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
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

                /// <summary>Removes virtual machines from an existing exadb vm cluster.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the ExadbVmCluster in the following format:
                /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
                /// </param>
                public virtual RemoveVirtualMachineRequest RemoveVirtualMachine(Google.Apis.OracleDatabase.v1.Data.RemoveVirtualMachineExadbVmClusterRequest body, string name)
                {
                    return new RemoveVirtualMachineRequest(this.service, body, name);
                }

                /// <summary>Removes virtual machines from an existing exadb vm cluster.</summary>
                public class RemoveVirtualMachineRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new RemoveVirtualMachine request.</summary>
                    public RemoveVirtualMachineRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.RemoveVirtualMachineExadbVmClusterRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ExadbVmCluster in the following format:
                    /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.RemoveVirtualMachineExadbVmClusterRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "removeVirtualMachine";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:removeVirtualMachine";

                    /// <summary>Initializes RemoveVirtualMachine parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/exadbVmClusters/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the ExascaleDbStorageVaults resource.</summary>
            public virtual ExascaleDbStorageVaultsResource ExascaleDbStorageVaults { get; }

            /// <summary>The "exascaleDbStorageVaults" collection of methods.</summary>
            public class ExascaleDbStorageVaultsResource
            {
                private const string Resource = "exascaleDbStorageVaults";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ExascaleDbStorageVaultsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new ExascaleDB Storage Vault resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The value for parent of the ExascaleDbStorageVault in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.ExascaleDbStorageVault body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new ExascaleDB Storage Vault resource.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.ExascaleDbStorageVault body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The value for parent of the ExascaleDbStorageVault in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the ExascaleDbStorageVault to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("exascaleDbStorageVaultId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ExascaleDbStorageVaultId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.ExascaleDbStorageVault Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/exascaleDbStorageVaults";

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
                        RequestParameters.Add("exascaleDbStorageVaultId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "exascaleDbStorageVaultId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single ExascaleDB Storage Vault.</summary>
                /// <param name="name">
                /// Required. The name of the ExascaleDbStorageVault in the following format:
                /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single ExascaleDB Storage Vault.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ExascaleDbStorageVault in the following format:
                    /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/exascaleDbStorageVaults/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single ExascaleDB Storage Vault.</summary>
                /// <param name="name">
                /// Required. The name of the ExascaleDbStorageVault in the following format:
                /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single ExascaleDB Storage Vault.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ExascaleDbStorageVault>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ExascaleDbStorageVault in the following format:
                    /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/exascaleDbStorageVaults/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the ExascaleDB Storage Vaults for the given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for ExascaleDbStorageVault in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the ExascaleDB Storage Vaults for the given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListExascaleDbStorageVaultsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for ExascaleDbStorageVault in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Filter the list as specified
                    /// in https://google.aip.dev/160.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. An expression for ordering the results of the request. Order results as specified in
                    /// https://google.aip.dev/132.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50
                    /// ExascaleDbStorageVaults will be returned. The maximum value is 1000; values above 1000 will be
                    /// coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/exascaleDbStorageVaults";

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
            }

            /// <summary>Gets the GiVersions resource.</summary>
            public virtual GiVersionsResource GiVersions { get; }

            /// <summary>The "giVersions" collection of methods.</summary>
            public class GiVersionsResource
            {
                private const string Resource = "giVersions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GiVersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    MinorVersions = new MinorVersionsResource(service);
                }

                /// <summary>Gets the MinorVersions resource.</summary>
                public virtual MinorVersionsResource MinorVersions { get; }

                /// <summary>The "minorVersions" collection of methods.</summary>
                public class MinorVersionsResource
                {
                    private const string Resource = "minorVersions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MinorVersionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Lists all the valid minor versions for the given project, location, gi version and shape family.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The parent value for the MinorVersion resource with the format:
                    /// projects/{project}/locations/{location}/giVersions/{gi_version}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>
                    /// Lists all the valid minor versions for the given project, location, gi version and shape family.
                    /// </summary>
                    public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListMinorVersionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent value for the MinorVersion resource with the format:
                        /// projects/{project}/locations/{location}/giVersions/{gi_version}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. An expression for filtering the results of the request. Only shapeFamily and
                        /// gcp_oracle_zone_id are supported in this format: `shape_family="{shapeFamily}" AND
                        /// gcp_oracle_zone_id="{gcp_oracle_zone_id}"`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If unspecified, a maximum of 50 System
                        /// Versions will be returned. The maximum value is 1000; values above 1000 will be reset to
                        /// 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. A token identifying the requested page of results to return. All fields except the
                        /// filter should remain the same as in the request that provided this page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/minorVersions";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/giVersions/[^/]+$",
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

                /// <summary>
                /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given project and location.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent value for Grid Infrastructure Version in the following format: Format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given project and location.
                /// </summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListGiVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for Grid Infrastructure Version in the following format: Format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Only the shape,
                    /// gcp_oracle_zone and gi_version fields are supported in this format: `shape="{shape}"`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, a maximum of 50 Oracle Grid
                    /// Infrastructure (GI) versions will be returned. The maximum value is 1000; values above 1000 will
                    /// be reset to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/giVersions";

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
            }

            /// <summary>Gets the GoldengateConnectionAssignments resource.</summary>
            public virtual GoldengateConnectionAssignmentsResource GoldengateConnectionAssignments { get; }

            /// <summary>The "goldengateConnectionAssignments" collection of methods.</summary>
            public class GoldengateConnectionAssignmentsResource
            {
                private const string Resource = "goldengateConnectionAssignments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GoldengateConnectionAssignmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new GoldengateConnectionAssignment in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this GoldengateConnectionAssignment will be created. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.GoldengateConnectionAssignment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new GoldengateConnectionAssignment in a given project and location.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.GoldengateConnectionAssignment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this GoldengateConnectionAssignment will be created. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The ID of the GoldengateConnectionAssignment to create.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("goldengateConnectionAssignmentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GoldengateConnectionAssignmentId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.GoldengateConnectionAssignment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateConnectionAssignments";

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
                        RequestParameters.Add("goldengateConnectionAssignmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "goldengateConnectionAssignmentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single GoldengateConnectionAssignment.</summary>
                /// <param name="name">
                /// Required. The name of the GoldengateConnectionAssignment to delete. Format:
                /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single GoldengateConnectionAssignment.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the GoldengateConnectionAssignment to delete. Format:
                    /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateConnectionAssignments/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single GoldengateConnectionAssignment.</summary>
                /// <param name="name">
                /// Required. The name of the GoldengateConnectionAssignment to retrieve. Format:
                /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single GoldengateConnectionAssignment.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.GoldengateConnectionAssignment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the GoldengateConnectionAssignment to retrieve. Format:
                    /// projects/{project}/locations/{location}/goldengateConnectionAssignments/{goldengate_connection_assignment}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateConnectionAssignments/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists GoldengateConnectionAssignments in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for the GoldengateConnectionAssignments. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists GoldengateConnectionAssignments in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListGoldengateConnectionAssignmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the GoldengateConnectionAssignments. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. A filter expression that filters GoldengateConnectionAssignments listed in the
                    /// response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. A comma-separated list of fields to order by, sorted in ascending order. Use "DESC"
                    /// after a field name for descending.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of GoldengateConnectionAssignments to return. The service may
                    /// return fewer than this value. If unspecified, at most 50 GoldengateConnectionAssignments will be
                    /// returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListGoldengateConnectionAssignments` call.
                    /// Provide this to retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListGoldengateConnectionAssignments` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateConnectionAssignments";

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

                /// <summary>Tests a single GoldengateConnectionAssignment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Name of the connection assignment for which to test connection.
                /// projects/{project}/locations/{region}/goldengateConnectionAssignments/{goldengate_connection_assignment}
                /// </param>
                public virtual TestRequest Test(Google.Apis.OracleDatabase.v1.Data.TestGoldengateConnectionAssignmentRequest body, string name)
                {
                    return new TestRequest(this.service, body, name);
                }

                /// <summary>Tests a single GoldengateConnectionAssignment.</summary>
                public class TestRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.TestGoldengateConnectionAssignmentResponse>
                {
                    /// <summary>Constructs a new Test request.</summary>
                    public TestRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.TestGoldengateConnectionAssignmentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the connection assignment for which to test connection.
                    /// projects/{project}/locations/{region}/goldengateConnectionAssignments/{goldengate_connection_assignment}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.TestGoldengateConnectionAssignmentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "test";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:test";

                    /// <summary>Initializes Test parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateConnectionAssignments/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the GoldengateConnectionTypes resource.</summary>
            public virtual GoldengateConnectionTypesResource GoldengateConnectionTypes { get; }

            /// <summary>The "goldengateConnectionTypes" collection of methods.</summary>
            public class GoldengateConnectionTypesResource
            {
                private const string Resource = "goldengateConnectionTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GoldengateConnectionTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details of a single GoldengateConnectionType.</summary>
                /// <param name="name">
                /// Required. Name of the resource in the format:
                /// projects/{project}/locations/{location}/goldengateConnectionTypes/{goldengate_connection_type}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single GoldengateConnectionType.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.GoldengateConnectionType>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource in the format:
                    /// projects/{project}/locations/{location}/goldengateConnectionTypes/{goldengate_connection_type}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateConnectionTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists GoldengateConnectionTypes in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent value for ListGoldengateConnectionTypesRequest Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists GoldengateConnectionTypes in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListGoldengateConnectionTypesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent value for ListGoldengateConnectionTypesRequest Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. The connection_type field must
                    /// be specified in the format: `connection_type="ORACLE"`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateConnectionTypes";

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
            }

            /// <summary>Gets the GoldengateConnections resource.</summary>
            public virtual GoldengateConnectionsResource GoldengateConnections { get; }

            /// <summary>The "goldengateConnections" collection of methods.</summary>
            public class GoldengateConnectionsResource
            {
                private const string Resource = "goldengateConnections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GoldengateConnectionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new GoldengateConnection in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The value for parent of the GoldengateConnection in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.GoldengateConnection body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new GoldengateConnection in a given project and location.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.GoldengateConnection body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The value for parent of the GoldengateConnection in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the GoldengateConnection to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("goldengateConnectionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GoldengateConnectionId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.GoldengateConnection Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateConnections";

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
                        RequestParameters.Add("goldengateConnectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "goldengateConnectionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single GoldengateConnection.</summary>
                /// <param name="name">
                /// Required. The name of the GoldengateConnection in the following format:
                /// projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single GoldengateConnection.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the GoldengateConnection in the following format:
                    /// projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateConnections/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single GoldengateConnection.</summary>
                /// <param name="name">
                /// Required. The name of the GoldengateConnection in the following format:
                /// projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single GoldengateConnection.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.GoldengateConnection>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the GoldengateConnection in the following format:
                    /// projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateConnections/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the GoldengateConnections for the given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for GoldengateConnections in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the GoldengateConnections for the given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListGoldengateConnectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for GoldengateConnections in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An expression for filtering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. An expression for ordering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50
                    /// GoldengateConnections will be returned. The maximum value is 1000; values above 1000 will be
                    /// coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous ListGoldengateConnections call. Provide this to
                    /// retrieve the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateConnections";

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
            }

            /// <summary>Gets the GoldengateDeploymentEnvironments resource.</summary>
            public virtual GoldengateDeploymentEnvironmentsResource GoldengateDeploymentEnvironments { get; }

            /// <summary>The "goldengateDeploymentEnvironments" collection of methods.</summary>
            public class GoldengateDeploymentEnvironmentsResource
            {
                private const string Resource = "goldengateDeploymentEnvironments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GoldengateDeploymentEnvironmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details of a single GoldengateDeploymentEnvironment.</summary>
                /// <param name="name">
                /// Required. Name of the resource with the format:
                /// projects/{project}/locations/{location}/goldengateDeploymentEnvironments/{goldengate_deployment_environment}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single GoldengateDeploymentEnvironment.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.GoldengateDeploymentEnvironment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource with the format:
                    /// projects/{project}/locations/{location}/goldengateDeploymentEnvironments/{goldengate_deployment_environment}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateDeploymentEnvironments/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists GoldengateDeploymentEnvironments in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of GoldengateDeploymentEnvironments. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists GoldengateDeploymentEnvironments in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListGoldengateDeploymentEnvironmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of GoldengateDeploymentEnvironments. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 deployment
                    /// environments will be returned. The maximum value is 1000; values above 1000 will be coerced to
                    /// 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateDeploymentEnvironments";

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
            }

            /// <summary>Gets the GoldengateDeploymentTypes resource.</summary>
            public virtual GoldengateDeploymentTypesResource GoldengateDeploymentTypes { get; }

            /// <summary>The "goldengateDeploymentTypes" collection of methods.</summary>
            public class GoldengateDeploymentTypesResource
            {
                private const string Resource = "goldengateDeploymentTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GoldengateDeploymentTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details of a single GoldenGateDeploymentType.</summary>
                /// <param name="name">
                /// Required. The name of the GoldengateDeploymentType to retrieve. Format:
                /// projects/{project}/locations/{location}/goldengateDeploymentTypes/{goldengate_deployment_type}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single GoldenGateDeploymentType.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.GoldengateDeploymentType>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the GoldengateDeploymentType to retrieve. Format:
                    /// projects/{project}/locations/{location}/goldengateDeploymentTypes/{goldengate_deployment_type}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateDeploymentTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists GoldenGateDeploymentTypes in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent resource. Format: projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists GoldenGateDeploymentTypes in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListGoldengateDeploymentTypesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource. Format: projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Either the deployment_type and
                    /// ogg_version fields must be specified in the format: `deployment_type="DATABASE_ORACLE"` or
                    /// `ogg_version="version"`. Allowed values for deployment_type are: `DATABASE_ORACLE`, `BIGDATA`,
                    /// `DATABASE_MICROSOFT_SQLSERVER`, `DATABASE_MYSQL`, `DATABASE_POSTGRESQL`, `DATABASE_DB2ZOS`,
                    /// `DATABASE_DB2I`, `GGSA`, `DATA_TRANSFORMS`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateDeploymentTypes";

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
            }

            /// <summary>Gets the GoldengateDeploymentVersions resource.</summary>
            public virtual GoldengateDeploymentVersionsResource GoldengateDeploymentVersions { get; }

            /// <summary>The "goldengateDeploymentVersions" collection of methods.</summary>
            public class GoldengateDeploymentVersionsResource
            {
                private const string Resource = "goldengateDeploymentVersions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GoldengateDeploymentVersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details of a single GoldengateDeploymentVersion.</summary>
                /// <param name="name">
                /// Required. The name of the GoldengateDeploymentVersion to retrieve. Format:
                /// projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single GoldengateDeploymentVersion.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.GoldengateDeploymentVersion>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the GoldengateDeploymentVersion to retrieve. Format:
                    /// projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateDeploymentVersions/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists GoldengateDeploymentVersions in a given project and location.</summary>
                /// <param name="parent">
                /// Required. Parent value for ListGoldengateDeploymentVersionsRequest Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists GoldengateDeploymentVersions in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListGoldengateDeploymentVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent value for ListGoldengateDeploymentVersionsRequest Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. Either the deployment_id and
                    /// deployment_type fields must be specified in the format: `deployment_id="id"` or
                    /// `deployment_type="DATABASE_ORACLE"`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default. The maximum value is 1000; values above 1000 will be
                    /// coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateDeploymentVersions";

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
            }

            /// <summary>Gets the GoldengateDeployments resource.</summary>
            public virtual GoldengateDeploymentsResource GoldengateDeployments { get; }

            /// <summary>The "goldengateDeployments" collection of methods.</summary>
            public class GoldengateDeploymentsResource
            {
                private const string Resource = "goldengateDeployments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public GoldengateDeploymentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new GoldengateDeployment in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The value for parent of the GoldengateDeployment in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.GoldengateDeployment body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new GoldengateDeployment in a given project and location.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.GoldengateDeployment body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The value for parent of the GoldengateDeployment in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the GoldengateDeployment to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("goldengateDeploymentId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string GoldengateDeploymentId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.GoldengateDeployment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateDeployments";

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
                        RequestParameters.Add("goldengateDeploymentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "goldengateDeploymentId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single GoldengateDeployment.</summary>
                /// <param name="name">
                /// Required. The name of the GoldengateDeployment in the following format:
                /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single GoldengateDeployment.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the GoldengateDeployment in the following format:
                    /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateDeployments/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single GoldengateDeployment.</summary>
                /// <param name="name">
                /// Required. The name of the GoldengateDeployment in the following format:
                /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single GoldengateDeployment.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.GoldengateDeployment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the GoldengateDeployment in the following format:
                    /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists all the GoldengateDeployments for the given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for GoldengateDeployments in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists all the GoldengateDeployments for the given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListGoldengateDeploymentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for GoldengateDeployments in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An expression for filtering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. An expression for ordering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50
                    /// GoldengateDeployments will be returned. The maximum value is 1000; values above 1000 will be
                    /// coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous ListGoldengateDeployments call. Provide this to
                    /// retrieve the subsequent page.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/goldengateDeployments";

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

                /// <summary>Starts a single GoldengateDeployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Goldengate Deployment in the following format:
                /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}.
                /// </param>
                public virtual StartRequest Start(Google.Apis.OracleDatabase.v1.Data.StartGoldengateDeploymentRequest body, string name)
                {
                    return new StartRequest(this.service, body, name);
                }

                /// <summary>Starts a single GoldengateDeployment.</summary>
                public class StartRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Start request.</summary>
                    public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.StartGoldengateDeploymentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Goldengate Deployment in the following format:
                    /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.StartGoldengateDeploymentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "start";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:start";

                    /// <summary>Initializes Start parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateDeployments/[^/]+$",
                        });
                    }
                }

                /// <summary>Stops a single GoldengateDeployment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the Goldengate Deployment in the following format:
                /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}.
                /// </param>
                public virtual StopRequest Stop(Google.Apis.OracleDatabase.v1.Data.StopGoldengateDeploymentRequest body, string name)
                {
                    return new StopRequest(this.service, body, name);
                }

                /// <summary>Stops a single GoldengateDeployment.</summary>
                public class StopRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Stop request.</summary>
                    public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.StopGoldengateDeploymentRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Goldengate Deployment in the following format:
                    /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.StopGoldengateDeploymentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "stop";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:stop";

                    /// <summary>Initializes Stop parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/goldengateDeployments/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the OdbNetworks resource.</summary>
            public virtual OdbNetworksResource OdbNetworks { get; }

            /// <summary>The "odbNetworks" collection of methods.</summary>
            public class OdbNetworksResource
            {
                private const string Resource = "odbNetworks";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OdbNetworksResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    OdbSubnets = new OdbSubnetsResource(service);
                }

                /// <summary>Gets the OdbSubnets resource.</summary>
                public virtual OdbSubnetsResource OdbSubnets { get; }

                /// <summary>The "odbSubnets" collection of methods.</summary>
                public class OdbSubnetsResource
                {
                    private const string Resource = "odbSubnets";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OdbSubnetsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Creates a new ODB Subnet in a given ODB Network.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent value for the OdbSubnet in the following format:
                    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.OdbSubnet body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Creates a new ODB Subnet in a given ODB Network.</summary>
                    public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.OdbSubnet body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent value for the OdbSubnet in the following format:
                        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the OdbSubnet to create. This value is restricted to
                        /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The
                        /// value must start with a letter and end with a letter or a number.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("odbSubnetId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OdbSubnetId { get; set; }

                        /// <summary>
                        /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                        /// requests. If you make a request with the same request ID and the original request is still
                        /// in progress or completed, the server ignores the second request. This prevents clients from
                        /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                        /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.OracleDatabase.v1.Data.OdbSubnet Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/odbSubnets";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/odbNetworks/[^/]+$",
                            });
                            RequestParameters.Add("odbSubnetId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "odbSubnetId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single ODB Subnet.</summary>
                    /// <param name="name">
                    /// Required. The name of the resource in the following format:
                    /// projects/{project}/locations/{region}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single ODB Subnet.</summary>
                    public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the resource in the following format:
                        /// projects/{project}/locations/{region}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                        /// requests. If you make a request with the same request ID and the original request is still
                        /// in progress or completed, the server ignores the second request. This prevents clients from
                        /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                        /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/odbNetworks/[^/]+/odbSubnets/[^/]+$",
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets details of a single ODB Subnet.</summary>
                    /// <param name="name">
                    /// Required. The name of the OdbSubnet in the following format:
                    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single ODB Subnet.</summary>
                    public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.OdbSubnet>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the OdbSubnet in the following format:
                        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/odbNetworks/[^/]+/odbSubnets/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists all the ODB Subnets in a given ODB Network.</summary>
                    /// <param name="parent">
                    /// Required. The parent value for the OdbSubnet in the following format:
                    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists all the ODB Subnets in a given ODB Network.</summary>
                    public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListOdbSubnetsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent value for the OdbSubnet in the following format:
                        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. An expression for filtering the results of the request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. An expression for ordering the results of the request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of items to return. If unspecified, at most 50 ODB Networks
                        /// will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/odbSubnets";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/odbNetworks/[^/]+$",
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

                /// <summary>Creates a new ODB Network in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent value for the OdbNetwork in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.OracleDatabase.v1.Data.OdbNetwork body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new ODB Network in a given project and location.</summary>
                public class CreateRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.OdbNetwork body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the OdbNetwork in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID of the OdbNetwork to create. This value is restricted to
                    /// (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63 characters in length. The value
                    /// must start with a letter and end with a letter or a number.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("odbNetworkId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OdbNetworkId { get; set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.OdbNetwork Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/odbNetworks";

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
                        RequestParameters.Add("odbNetworkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "odbNetworkId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single ODB Network.</summary>
                /// <param name="name">
                /// Required. The name of the resource in the following format:
                /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single ODB Network.</summary>
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the resource in the following format:
                    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. An optional ID to identify the request. This value is used to identify duplicate
                    /// requests. If you make a request with the same request ID and the original request is still in
                    /// progress or completed, the server ignores the second request. This prevents clients from
                    /// accidentally creating duplicate commitments. The request ID must be a valid UUID with the
                    /// exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/odbNetworks/[^/]+$",
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single ODB Network.</summary>
                /// <param name="name">
                /// Required. The name of the OdbNetwork in the following format:
                /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single ODB Network.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.OdbNetwork>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the OdbNetwork in the following format:
                    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/odbNetworks/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists the ODB Networks in a given project and location.</summary>
                /// <param name="parent">
                /// Required. The parent value for the ODB Network in the following format:
                /// projects/{project}/locations/{location}.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the ODB Networks in a given project and location.</summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListOdbNetworksResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent value for the ODB Network in the following format:
                    /// projects/{project}/locations/{location}.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An expression for filtering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. An expression for ordering the results of the request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of items to return. If unspecified, at most 50 ODB Networks will be
                    /// returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/odbNetworks";

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
                public virtual CancelRequest Cancel(Google.Apis.OracleDatabase.v1.Data.CancelOperationRequest body, string name)
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
                public class CancelRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.OracleDatabase.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.OracleDatabase.v1.Data.CancelOperationRequest Body { get; set; }

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
                public class DeleteRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Empty>
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
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Operation>
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
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets the PluggableDatabases resource.</summary>
            public virtual PluggableDatabasesResource PluggableDatabases { get; }

            /// <summary>The "pluggableDatabases" collection of methods.</summary>
            public class PluggableDatabasesResource
            {
                private const string Resource = "pluggableDatabases";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PluggableDatabasesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets details of a single PluggableDatabase.</summary>
                /// <param name="name">
                /// Required. The name of the PluggableDatabase resource in the following format:
                /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single PluggableDatabase.</summary>
                public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.PluggableDatabase>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the PluggableDatabase resource in the following format:
                    /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/pluggableDatabases/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all the PluggableDatabases for the given project, location and Container Database.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of PluggableDatabases. Format:
                /// projects/{project}/locations/{location}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists all the PluggableDatabases for the given project, location and Container Database.
                /// </summary>
                public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListPluggableDatabasesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of PluggableDatabases. Format:
                    /// projects/{project}/locations/{location}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. An expression for filtering the results of the request. List for pluggable databases
                    /// is supported only with a valid container database (full resource name) filter in this format:
                    /// `database="projects/{project}/locations/{location}/databases/{database}"`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of PluggableDatabases to return. The service may return fewer than
                    /// this value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListPluggableDatabases` call. Provide this to
                    /// retrieve the subsequent page. When paginating, all other parameters provided to
                    /// `ListPluggableDatabases` must match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/pluggableDatabases";

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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.Location>
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
            /// Lists information about the supported locations for this service. This method lists locations based on
            /// the resource scope provided in the ListLocationsRequest.name field: * **Global locations**: If `name` is
            /// empty, the method lists the public locations available to all projects. * **Project-specific
            /// locations**: If `name` follows the format `projects/{project}`, the method lists locations visible to
            /// that specific project. This includes public, private, or other project-specific locations enabled for
            /// the project. For gRPC and client library implementations, the resource name is passed as the `name`
            /// field. For direct service calls, the resource name is incorporated into the request path based on the
            /// specific service implementation and version.
            /// </summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists information about the supported locations for this service. This method lists locations based on
            /// the resource scope provided in the ListLocationsRequest.name field: * **Global locations**: If `name` is
            /// empty, the method lists the public locations available to all projects. * **Project-specific
            /// locations**: If `name` follows the format `projects/{project}`, the method lists locations visible to
            /// that specific project. This includes public, private, or other project-specific locations enabled for
            /// the project. For gRPC and client library implementations, the resource name is passed as the `name`
            /// field. For direct service calls, the resource name is incorporated into the request path based on the
            /// specific service implementation and version.
            /// </summary>
            public class ListRequest : OracleDatabaseBaseServiceRequest<Google.Apis.OracleDatabase.v1.Data.ListLocationsResponse>
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
                /// Optional. Do not use this field unless explicitly documented otherwise. This is primarily for
                /// internal usage.
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
namespace Google.Apis.OracleDatabase.v1.Data
{
    /// <summary>A list of all connection strings that can be used to connect to the Autonomous Database.</summary>
    public class AllConnectionStrings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The database service provides the highest level of resources to each SQL statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("high")]
        public virtual string High { get; set; }

        /// <summary>
        /// Output only. The database service provides the least level of resources to each SQL statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("low")]
        public virtual string Low { get; set; }

        /// <summary>
        /// Output only. The database service provides a lower level of resources to each SQL statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Amazon S3 Iceberg storage.</summary>
    public class AmazonS3IcebergStorage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The access key ID of Amazon S3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessKeyId")]
        public virtual string AccessKeyId { get; set; }

        /// <summary>Required. The bucket of Amazon S3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>Optional. The endpoint of Amazon S3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>Required. The region of Amazon S3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Required. The scheme type of Amazon S3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemeType")]
        public virtual string SchemeType { get; set; }

        /// <summary>Optional. The secret access key of Amazon S3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretAccessKeySecret")]
        public virtual string SecretAccessKeySecret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the Autonomous Database resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/AutonomousDatabase/
    /// </summary>
    public class AutonomousDatabase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. The password for the default ADMIN user. Note: Only one of
        /// `admin_password_secret_version` or `admin_password` can be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminPassword")]
        public virtual string AdminPassword { get; set; }

        /// <summary>
        /// Optional. Immutable. The resource name of a secret version in Secret Manager which contains the database
        /// admin user's password. Format: projects/{project}/secrets/{secret}/versions/{version}. Note: Only one of
        /// `admin_password_secret_version` or `admin_password` can be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminPasswordSecretVersion")]
        public virtual string AdminPasswordSecretVersion { get; set; }

        /// <summary>Optional. Immutable. The subnet CIDR range for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the Autonomous Database was created.</summary>
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
        /// Optional. Immutable. The name of the Autonomous Database. The database name must be unique in the project.
        /// The name must begin with a letter and can contain a maximum of 30 alphanumeric characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>
        /// Output only. List of supported GCP region to clone the Autonomous Database for disaster recovery. Format:
        /// `project/{project}/locations/{location}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disasterRecoverySupportedLocations")]
        public virtual System.Collections.Generic.IList<string> DisasterRecoverySupportedLocations { get; set; }

        /// <summary>
        /// Optional. Immutable. The display name for the Autonomous Database. The name does not have to be unique
        /// within your project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The ID of the subscription entitlement associated with the Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>Optional. The labels or tags associated with the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the Autonomous Database resource in the following format:
        /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Immutable. The name of the VPC network used by the Autonomous Database in the following format:
        /// projects/{project}/global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. Immutable. The name of the OdbNetwork associated with the Autonomous Database. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network} It is optional but if specified, this
        /// should match the parent ODBNetwork of the OdbSubnet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbNetwork")]
        public virtual string OdbNetwork { get; set; }

        /// <summary>
        /// Optional. Immutable. The name of the OdbSubnet associated with the Autonomous Database. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbSubnet")]
        public virtual string OdbSubnet { get; set; }

        /// <summary>Output only. The peer Autonomous Database names of the given Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerAutonomousDatabases")]
        public virtual System.Collections.Generic.IList<string> PeerAutonomousDatabases { get; set; }

        /// <summary>Optional. The properties of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual AutonomousDatabaseProperties Properties { get; set; }

        /// <summary>
        /// Optional. Immutable. The source Autonomous Database configuration for the standby Autonomous Database. The
        /// source Autonomous Database is configured while creating the Peer Autonomous Database and can't be updated
        /// after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceConfig")]
        public virtual SourceConfig SourceConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Oracle APEX Application Development.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseApex
    /// </summary>
    public class AutonomousDatabaseApex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The Oracle APEX Application Development version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apexVersion")]
        public virtual string ApexVersion { get; set; }

        /// <summary>Output only. The Oracle REST Data Services (ORDS) version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ordsVersion")]
        public virtual string OrdsVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the Autonomous Database Backup resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/AutonomousDatabaseBackup/
    /// </summary>
    public class AutonomousDatabaseBackup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the Autonomous Database resource for which the backup is being created. Format:
        /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autonomousDatabase")]
        public virtual string AutonomousDatabase { get; set; }

        /// <summary>Optional. User friendly name for the Backup. The name does not have to be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. labels or tags associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the Autonomous Database Backup resource with the format:
        /// projects/{project}/locations/{region}/autonomousDatabaseBackups/{autonomous_database_backup}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Various properties of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual AutonomousDatabaseBackupProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of the Autonomous Database Backup resource.</summary>
    public class AutonomousDatabaseBackupProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _availableTillTimeRaw;

        private object _availableTillTime;

        /// <summary>Output only. Timestamp until when the backup will be available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableTillTime")]
        public virtual string AvailableTillTimeRaw
        {
            get => _availableTillTimeRaw;
            set
            {
                _availableTillTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _availableTillTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AvailableTillTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AvailableTillTimeDateTimeOffset instead.")]
        public virtual object AvailableTillTime
        {
            get => _availableTillTime;
            set
            {
                _availableTillTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _availableTillTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="AvailableTillTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AvailableTillTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AvailableTillTimeRaw);
            set => AvailableTillTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The OCID of the compartment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compartmentId")]
        public virtual string CompartmentId { get; set; }

        /// <summary>Output only. The quantity of data in the database, in terabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseSizeTb")]
        public virtual System.Nullable<float> DatabaseSizeTb { get; set; }

        /// <summary>Output only. A valid Oracle Database version for Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbVersion")]
        public virtual string DbVersion { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. The date and time the backup completed.</summary>
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

        /// <summary>Output only. Indicates if the backup is automatic or user initiated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAutomaticBackup")]
        public virtual System.Nullable<bool> IsAutomaticBackup { get; set; }

        /// <summary>Output only. Indicates if the backup is long term backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isLongTermBackup")]
        public virtual System.Nullable<bool> IsLongTermBackup { get; set; }

        /// <summary>Output only. Indicates if the backup can be used to restore the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRestorable")]
        public virtual System.Nullable<bool> IsRestorable { get; set; }

        /// <summary>Optional. The OCID of the key store of Oracle Vault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStoreId")]
        public virtual string KeyStoreId { get; set; }

        /// <summary>Optional. The wallet name for Oracle Key Vault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStoreWallet")]
        public virtual string KeyStoreWallet { get; set; }

        /// <summary>
        /// Optional. The OCID of the key container that is used as the master encryption key in database transparent
        /// data encryption (TDE) operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyId")]
        public virtual string KmsKeyId { get; set; }

        /// <summary>
        /// Optional. The OCID of the key container version that is used in database transparent data encryption (TDE)
        /// operations KMS Key can have multiple key versions. If none is specified, the current key version (latest) of
        /// the Key Id is used for the operation. Autonomous Database Serverless does not use key versions, hence is not
        /// applicable for Autonomous Database Serverless instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyVersionId")]
        public virtual string KmsKeyVersionId { get; set; }

        /// <summary>Output only. Additional information about the current lifecycle state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleDetails")]
        public virtual string LifecycleDetails { get; set; }

        /// <summary>Output only. The lifecycle state of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>
        /// Output only. OCID of the Autonomous Database backup.
        /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Optional. Retention period in days for the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionPeriodDays")]
        public virtual System.Nullable<int> RetentionPeriodDays { get; set; }

        /// <summary>Output only. The backup size in terabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeTb")]
        public virtual System.Nullable<float> SizeTb { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. The date and time the backup started.</summary>
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

        /// <summary>Output only. The type of the backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Optional. The OCID of the vault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vaultId")]
        public virtual string VaultId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the Autonomous Database character set resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/AutonomousDatabaseCharacterSets/
    /// </summary>
    public class AutonomousDatabaseCharacterSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The character set name for the Autonomous Database which is the ID in the resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterSet")]
        public virtual string CharacterSet { get; set; }

        /// <summary>Output only. The character set type for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterSetType")]
        public virtual string CharacterSetType { get; set; }

        /// <summary>
        /// Identifier. The name of the Autonomous Database Character Set resource in the following format:
        /// projects/{project}/locations/{region}/autonomousDatabaseCharacterSets/{autonomous_database_character_set}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The connection string used to connect to the Autonomous Database.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionStrings
    /// </summary>
    public class AutonomousDatabaseConnectionStrings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Returns all connection strings that can be used to connect to the Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConnectionStrings")]
        public virtual AllConnectionStrings AllConnectionStrings { get; set; }

        /// <summary>
        /// Output only. The database service provides the least level of resources to each SQL statement, but supports
        /// the most number of concurrent SQL statements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dedicated")]
        public virtual string Dedicated { get; set; }

        /// <summary>
        /// Output only. The database service provides the highest level of resources to each SQL statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("high")]
        public virtual string High { get; set; }

        /// <summary>
        /// Output only. The database service provides the least level of resources to each SQL statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("low")]
        public virtual string Low { get; set; }

        /// <summary>
        /// Output only. The database service provides a lower level of resources to each SQL statement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("medium")]
        public virtual string Medium { get; set; }

        /// <summary>
        /// Output only. A list of connection string profiles to allow clients to group, filter, and select values based
        /// on the structured metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profiles")]
        public virtual System.Collections.Generic.IList<DatabaseConnectionStringProfile> Profiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The URLs for accessing Oracle Application Express (APEX) and SQL Developer Web with a browser from a Compute
    /// instance.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseConnectionUrls
    /// </summary>
    public class AutonomousDatabaseConnectionUrls : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Oracle Application Express (APEX) URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apexUri")]
        public virtual string ApexUri { get; set; }

        /// <summary>Output only. The URL of the Database Transforms for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseTransformsUri")]
        public virtual string DatabaseTransformsUri { get; set; }

        /// <summary>Output only. The URL of the Graph Studio for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("graphStudioUri")]
        public virtual string GraphStudioUri { get; set; }

        /// <summary>
        /// Output only. The URL of the Oracle Machine Learning (OML) Notebook for the Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineLearningNotebookUri")]
        public virtual string MachineLearningNotebookUri { get; set; }

        /// <summary>Output only. The URL of Machine Learning user management the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineLearningUserManagementUri")]
        public virtual string MachineLearningUserManagementUri { get; set; }

        /// <summary>Output only. The URL of the MongoDB API for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mongoDbUri")]
        public virtual string MongoDbUri { get; set; }

        /// <summary>
        /// Output only. The Oracle REST Data Services (ORDS) URL of the Web Access for the Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ordsUri")]
        public virtual string OrdsUri { get; set; }

        /// <summary>Output only. The URL of the Oracle SQL Developer Web for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlDevWebUri")]
        public virtual string SqlDevWebUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of an Autonomous Database.</summary>
    public class AutonomousDatabaseProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The amount of storage currently being used for user and system data, in terabytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actualUsedDataStorageSizeTb")]
        public virtual System.Nullable<double> ActualUsedDataStorageSizeTb { get; set; }

        /// <summary>
        /// Output only. The amount of storage currently allocated for the database tables and billed for, rounded up in
        /// terabytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocatedStorageSizeTb")]
        public virtual System.Nullable<double> AllocatedStorageSizeTb { get; set; }

        /// <summary>Optional. Immutable. The list of allowlisted IP addresses for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowlistedIps")]
        public virtual System.Collections.Generic.IList<string> AllowlistedIps { get; set; }

        /// <summary>Output only. The details for the Oracle APEX Application Development.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apexDetails")]
        public virtual AutonomousDatabaseApex ApexDetails { get; set; }

        /// <summary>
        /// Output only. This field indicates the status of Data Guard and Access control for the Autonomous Database.
        /// The field's value is null if Data Guard is disabled or Access Control is disabled. The field's value is TRUE
        /// if both Data Guard and Access Control are enabled, and the Autonomous Database is using primary IP access
        /// control list (ACL) for standby. The field's value is FALSE if both Data Guard and Access Control are
        /// enabled, and the Autonomous Database is using a different IP access control list (ACL) for standby compared
        /// to primary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arePrimaryAllowlistedIpsUsed")]
        public virtual System.Nullable<bool> ArePrimaryAllowlistedIpsUsed { get; set; }

        /// <summary>Output only. The Autonomous Container Database OCID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autonomousContainerDatabaseId")]
        public virtual string AutonomousContainerDatabaseId { get; set; }

        /// <summary>
        /// Output only. The list of available Oracle Database upgrade versions for an Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableUpgradeVersions")]
        public virtual System.Collections.Generic.IList<string> AvailableUpgradeVersions { get; set; }

        /// <summary>
        /// Optional. Immutable. The retention period for the Autonomous Database. This field is specified in days, can
        /// range from 1 day to 60 days, and has a default value of 60 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetentionPeriodDays")]
        public virtual System.Nullable<int> BackupRetentionPeriodDays { get; set; }

        /// <summary>
        /// Optional. Immutable. The character set for the Autonomous Database. The default is AL32UTF8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterSet")]
        public virtual string CharacterSet { get; set; }

        /// <summary>Optional. Immutable. The number of compute servers for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeCount")]
        public virtual System.Nullable<float> ComputeCount { get; set; }

        /// <summary>Output only. The connection strings used to connect to an Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionStrings")]
        public virtual AutonomousDatabaseConnectionStrings ConnectionStrings { get; set; }

        /// <summary>Output only. The Oracle Connection URLs for an Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionUrls")]
        public virtual AutonomousDatabaseConnectionUrls ConnectionUrls { get; set; }

        /// <summary>Optional. Immutable. The number of CPU cores to be made available to the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCoreCount")]
        public virtual System.Nullable<int> CpuCoreCount { get; set; }

        /// <summary>Optional. Immutable. The list of customer contacts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerContacts")]
        public virtual System.Collections.Generic.IList<CustomerContact> CustomerContacts { get; set; }

        private string _dataGuardRoleChangedTimeRaw;

        private object _dataGuardRoleChangedTime;

        /// <summary>
        /// Output only. The date and time the Autonomous Data Guard role was changed for the standby Autonomous
        /// Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataGuardRoleChangedTime")]
        public virtual string DataGuardRoleChangedTimeRaw
        {
            get => _dataGuardRoleChangedTimeRaw;
            set
            {
                _dataGuardRoleChangedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dataGuardRoleChangedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DataGuardRoleChangedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DataGuardRoleChangedTimeDateTimeOffset instead.")]
        public virtual object DataGuardRoleChangedTime
        {
            get => _dataGuardRoleChangedTime;
            set
            {
                _dataGuardRoleChangedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dataGuardRoleChangedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DataGuardRoleChangedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DataGuardRoleChangedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DataGuardRoleChangedTimeRaw);
            set => DataGuardRoleChangedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The current state of the Data Safe registration for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSafeState")]
        public virtual string DataSafeState { get; set; }

        /// <summary>Optional. Immutable. The size of the data stored in the database, in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageSizeGb")]
        public virtual System.Nullable<int> DataStorageSizeGb { get; set; }

        /// <summary>Optional. Immutable. The size of the data stored in the database, in terabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageSizeTb")]
        public virtual System.Nullable<int> DataStorageSizeTb { get; set; }

        /// <summary>Output only. The current state of database management for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseManagementState")]
        public virtual string DatabaseManagementState { get; set; }

        /// <summary>Optional. Immutable. The edition of the Autonomous Databases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbEdition")]
        public virtual string DbEdition { get; set; }

        /// <summary>Optional. Immutable. The Oracle Database version for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbVersion")]
        public virtual string DbVersion { get; set; }

        /// <summary>Required. Immutable. The workload type of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbWorkload")]
        public virtual string DbWorkload { get; set; }

        private string _disasterRecoveryRoleChangedTimeRaw;

        private object _disasterRecoveryRoleChangedTime;

        /// <summary>
        /// Output only. The date and time the Disaster Recovery role was changed for the standby Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disasterRecoveryRoleChangedTime")]
        public virtual string DisasterRecoveryRoleChangedTimeRaw
        {
            get => _disasterRecoveryRoleChangedTimeRaw;
            set
            {
                _disasterRecoveryRoleChangedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _disasterRecoveryRoleChangedTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="DisasterRecoveryRoleChangedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DisasterRecoveryRoleChangedTimeDateTimeOffset instead.")]
        public virtual object DisasterRecoveryRoleChangedTime
        {
            get => _disasterRecoveryRoleChangedTime;
            set
            {
                _disasterRecoveryRoleChangedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _disasterRecoveryRoleChangedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DisasterRecoveryRoleChangedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DisasterRecoveryRoleChangedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DisasterRecoveryRoleChangedTimeRaw);
            set => DisasterRecoveryRoleChangedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. The encryption key used to encrypt the Autonomous Database. Updating this field will add a new
        /// entry in the `encryption_key_history_entries` field with the former version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual EncryptionKey EncryptionKey { get; set; }

        /// <summary>Output only. The history of the encryption keys used to encrypt the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKeyHistoryEntries")]
        public virtual System.Collections.Generic.IList<EncryptionKeyHistoryEntry> EncryptionKeyHistoryEntries { get; set; }

        /// <summary>
        /// Output only. This field indicates the number of seconds of data loss during a Data Guard failover.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedDataRecoveryDuration")]
        public virtual object FailedDataRecoveryDuration { get; set; }

        /// <summary>
        /// Optional. Immutable. This field indicates if auto scaling is enabled for the Autonomous Database CPU core
        /// count.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAutoScalingEnabled")]
        public virtual System.Nullable<bool> IsAutoScalingEnabled { get; set; }

        /// <summary>
        /// Output only. Deprecated: Please use `local_data_guard_enabled` instead. This field indicates whether the
        /// Autonomous Database has local (in-region) Data Guard enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isLocalDataGuardEnabled")]
        public virtual System.Nullable<bool> IsLocalDataGuardEnabled { get; set; }

        /// <summary>
        /// Optional. Immutable. This field indicates if auto scaling is enabled for the Autonomous Database storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isStorageAutoScalingEnabled")]
        public virtual System.Nullable<bool> IsStorageAutoScalingEnabled { get; set; }

        /// <summary>Required. Immutable. The license type used for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>Output only. The details of the current lifestyle state of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleDetails")]
        public virtual string LifecycleDetails { get; set; }

        /// <summary>
        /// Output only. Deprecated: Please use `local_adg_auto_failover_max_data_loss_limit_duration` instead. This
        /// field indicates the maximum data loss limit for an Autonomous Database, in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localAdgAutoFailoverMaxDataLossLimit")]
        public virtual System.Nullable<int> LocalAdgAutoFailoverMaxDataLossLimit { get; set; }

        /// <summary>
        /// Optional. This field indicates the maximum data loss limit for an Autonomous Database, in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localAdgAutoFailoverMaxDataLossLimitDuration")]
        public virtual System.Nullable<int> LocalAdgAutoFailoverMaxDataLossLimitDuration { get; set; }

        /// <summary>
        /// Optional. Indicates whether the Autonomous Database has a local (in-region) standby database. Not applicable
        /// to cross-region Data Guard or dedicated Exadata infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localDataGuardEnabled")]
        public virtual System.Nullable<bool> LocalDataGuardEnabled { get; set; }

        /// <summary>
        /// Output only. This field indicates the local disaster recovery (DR) type of an Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localDisasterRecoveryType")]
        public virtual string LocalDisasterRecoveryType { get; set; }

        /// <summary>Output only. The details of the Autonomous Data Guard standby database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localStandbyDb")]
        public virtual AutonomousDatabaseStandbySummary LocalStandbyDb { get; set; }

        private string _maintenanceBeginTimeRaw;

        private object _maintenanceBeginTime;

        /// <summary>Output only. The date and time when maintenance will begin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceBeginTime")]
        public virtual string MaintenanceBeginTimeRaw
        {
            get => _maintenanceBeginTimeRaw;
            set
            {
                _maintenanceBeginTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _maintenanceBeginTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MaintenanceBeginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MaintenanceBeginTimeDateTimeOffset instead.")]
        public virtual object MaintenanceBeginTime
        {
            get => _maintenanceBeginTime;
            set
            {
                _maintenanceBeginTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _maintenanceBeginTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MaintenanceBeginTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MaintenanceBeginTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MaintenanceBeginTimeRaw);
            set => MaintenanceBeginTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _maintenanceEndTimeRaw;

        private object _maintenanceEndTime;

        /// <summary>Output only. The date and time when maintenance will end.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceEndTime")]
        public virtual string MaintenanceEndTimeRaw
        {
            get => _maintenanceEndTimeRaw;
            set
            {
                _maintenanceEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _maintenanceEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MaintenanceEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MaintenanceEndTimeDateTimeOffset instead.")]
        public virtual object MaintenanceEndTime
        {
            get => _maintenanceEndTime;
            set
            {
                _maintenanceEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _maintenanceEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MaintenanceEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MaintenanceEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MaintenanceEndTimeRaw);
            set => MaintenanceEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Immutable. The maintenance schedule of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceScheduleType")]
        public virtual string MaintenanceScheduleType { get; set; }

        /// <summary>Output only. The amount of memory enabled per ECPU, in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryPerOracleComputeUnitGbs")]
        public virtual System.Nullable<int> MemoryPerOracleComputeUnitGbs { get; set; }

        /// <summary>Output only. The memory assigned to in-memory tables in an Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryTableGbs")]
        public virtual System.Nullable<int> MemoryTableGbs { get; set; }

        /// <summary>
        /// Optional. Immutable. This field specifies if the Autonomous Database requires mTLS connections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mtlsConnectionRequired")]
        public virtual System.Nullable<bool> MtlsConnectionRequired { get; set; }

        /// <summary>
        /// Optional. Immutable. The national character set for the Autonomous Database. The default is AL16UTF16.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nCharacterSet")]
        public virtual string NCharacterSet { get; set; }

        private string _nextLongTermBackupTimeRaw;

        private object _nextLongTermBackupTime;

        /// <summary>Output only. The long term backup schedule of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLongTermBackupTime")]
        public virtual string NextLongTermBackupTimeRaw
        {
            get => _nextLongTermBackupTimeRaw;
            set
            {
                _nextLongTermBackupTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextLongTermBackupTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextLongTermBackupTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextLongTermBackupTimeDateTimeOffset instead.")]
        public virtual object NextLongTermBackupTime
        {
            get => _nextLongTermBackupTime;
            set
            {
                _nextLongTermBackupTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextLongTermBackupTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextLongTermBackupTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextLongTermBackupTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextLongTermBackupTimeRaw);
            set => NextLongTermBackupTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The Oracle Cloud Infrastructure link for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUrl")]
        public virtual string OciUrl { get; set; }

        /// <summary>
        /// Output only. OCID of the Autonomous Database.
        /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Output only. This field indicates the current mode of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openMode")]
        public virtual string OpenMode { get; set; }

        /// <summary>
        /// Output only. This field indicates the state of Operations Insights for the Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationsInsightsState")]
        public virtual string OperationsInsightsState { get; set; }

        /// <summary>
        /// Output only. The list of OCIDs of standby databases located in Autonomous Data Guard remote regions that are
        /// associated with the source database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerDbIds")]
        public virtual System.Collections.Generic.IList<string> PeerDbIds { get; set; }

        /// <summary>Output only. The permission level of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionLevel")]
        public virtual string PermissionLevel { get; set; }

        /// <summary>Output only. The private endpoint for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateEndpoint")]
        public virtual string PrivateEndpoint { get; set; }

        /// <summary>Optional. Immutable. The private endpoint IP address for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateEndpointIp")]
        public virtual string PrivateEndpointIp { get; set; }

        /// <summary>Optional. Immutable. The private endpoint label for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateEndpointLabel")]
        public virtual string PrivateEndpointLabel { get; set; }

        /// <summary>Output only. The refresh mode of the cloned Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshableMode")]
        public virtual string RefreshableMode { get; set; }

        /// <summary>Output only. The refresh State of the clone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshableState")]
        public virtual string RefreshableState { get; set; }

        /// <summary>Output only. The Data Guard role of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>Output only. The list and details of the scheduled operations of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledOperationDetails")]
        public virtual System.Collections.Generic.IList<ScheduledOperationDetails> ScheduledOperationDetails { get; set; }

        /// <summary>Optional. Immutable. The ID of the Oracle Cloud Infrastructure vault secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretId")]
        public virtual string SecretId { get; set; }

        /// <summary>
        /// Output only. An Oracle-managed Google Cloud service account on which customers can grant roles to access
        /// resources in the customer project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAgentEmail")]
        public virtual string ServiceAgentEmail { get; set; }

        /// <summary>Output only. The SQL Web Developer URL for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlWebDeveloperUrl")]
        public virtual string SqlWebDeveloperUrl { get; set; }

        /// <summary>Output only. The current lifecycle state of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. The list of available regions that can be used to create a clone for the Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedCloneRegions")]
        public virtual System.Collections.Generic.IList<string> SupportedCloneRegions { get; set; }

        /// <summary>
        /// Output only. The storage space used by automatic backups of Autonomous Database, in gigabytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalAutoBackupStorageSizeGbs")]
        public virtual System.Nullable<float> TotalAutoBackupStorageSizeGbs { get; set; }

        /// <summary>Output only. The storage space used by Autonomous Database, in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedDataStorageSizeTbs")]
        public virtual System.Nullable<int> UsedDataStorageSizeTbs { get; set; }

        /// <summary>Optional. Immutable. The ID of the Oracle Cloud Infrastructure vault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vaultId")]
        public virtual string VaultId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Autonomous Data Guard standby database details.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/AutonomousDatabaseStandbySummary
    /// </summary>
    public class AutonomousDatabaseStandbySummary : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _dataGuardRoleChangedTimeRaw;

        private object _dataGuardRoleChangedTime;

        /// <summary>
        /// Output only. The date and time the Autonomous Data Guard role was switched for the standby Autonomous
        /// Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataGuardRoleChangedTime")]
        public virtual string DataGuardRoleChangedTimeRaw
        {
            get => _dataGuardRoleChangedTimeRaw;
            set
            {
                _dataGuardRoleChangedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dataGuardRoleChangedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DataGuardRoleChangedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DataGuardRoleChangedTimeDateTimeOffset instead.")]
        public virtual object DataGuardRoleChangedTime
        {
            get => _dataGuardRoleChangedTime;
            set
            {
                _dataGuardRoleChangedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _dataGuardRoleChangedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DataGuardRoleChangedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DataGuardRoleChangedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DataGuardRoleChangedTimeRaw);
            set => DataGuardRoleChangedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _disasterRecoveryRoleChangedTimeRaw;

        private object _disasterRecoveryRoleChangedTime;

        /// <summary>
        /// Output only. The date and time the Disaster Recovery role was switched for the standby Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disasterRecoveryRoleChangedTime")]
        public virtual string DisasterRecoveryRoleChangedTimeRaw
        {
            get => _disasterRecoveryRoleChangedTimeRaw;
            set
            {
                _disasterRecoveryRoleChangedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _disasterRecoveryRoleChangedTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="DisasterRecoveryRoleChangedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DisasterRecoveryRoleChangedTimeDateTimeOffset instead.")]
        public virtual object DisasterRecoveryRoleChangedTime
        {
            get => _disasterRecoveryRoleChangedTime;
            set
            {
                _disasterRecoveryRoleChangedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _disasterRecoveryRoleChangedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DisasterRecoveryRoleChangedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DisasterRecoveryRoleChangedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DisasterRecoveryRoleChangedTimeRaw);
            set => DisasterRecoveryRoleChangedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The amount of time, in seconds, that the data of the standby database lags in comparison to the
        /// data of the primary database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lagTimeDuration")]
        public virtual object LagTimeDuration { get; set; }

        /// <summary>
        /// Output only. The additional details about the current lifecycle state of the Autonomous Database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleDetails")]
        public virtual string LifecycleDetails { get; set; }

        /// <summary>Output only. The current lifecycle state of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the Autonomous Database version.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/AutonomousDbVersionSummary/
    /// </summary>
    public class AutonomousDbVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The Autonomous Database workload type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbWorkload")]
        public virtual string DbWorkload { get; set; }

        /// <summary>
        /// Identifier. The name of the Autonomous Database Version resource with the format:
        /// projects/{project}/locations/{region}/autonomousDbVersions/{autonomous_db_version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. An Oracle Database version for Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>
        /// Output only. A URL that points to a detailed description of the Autonomous Database version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workloadUri")]
        public virtual string WorkloadUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Azure Data Lake Storage Iceberg storage.</summary>
    public class AzureDataLakeStorageIcebergStorage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The account key of Azure Data Lake Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountKeySecret")]
        public virtual string AccountKeySecret { get; set; }

        /// <summary>Required. The account of Azure Data Lake Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureAccount")]
        public virtual string AzureAccount { get; set; }

        /// <summary>Required. The container of Azure Data Lake Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>Optional. The endpoint of Azure Data Lake Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of the database backup destination.</summary>
    public class BackupDestinationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The type of the database backup destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the OCI Cloud Account.</summary>
    public class CloudAccountDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. URL to create a new account and link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountCreationUri")]
        public virtual string AccountCreationUri { get; set; }

        /// <summary>Output only. OCI account name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudAccount")]
        public virtual string CloudAccount { get; set; }

        /// <summary>Output only. OCI account home region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudAccountHomeRegion")]
        public virtual string CloudAccountHomeRegion { get; set; }

        /// <summary>Output only. URL to link an existing account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkExistingAccountUri")]
        public virtual string LinkExistingAccountUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents CloudExadataInfrastructure resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/CloudExadataInfrastructure/
    /// </summary>
    public class CloudExadataInfrastructure : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the Exadata Infrastructure was created.</summary>
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

        /// <summary>Optional. User friendly name for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Entitlement ID of the private offer against which this infrastructure resource is provisioned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>
        /// Optional. The GCP Oracle zone where Oracle Exadata Infrastructure is hosted. Example: us-east4-b-r2. If not
        /// specified, the system will pick a zone based on availability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>Optional. Labels or tags associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the Exadata Infrastructure resource with the format:
        /// projects/{project}/locations/{region}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Various properties of the infra.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual CloudExadataInfrastructureProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Various properties of Exadata Infrastructure.</summary>
    public class CloudExadataInfrastructureProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The requested number of additional storage servers activated for the Exadata Infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activatedStorageCount")]
        public virtual System.Nullable<int> ActivatedStorageCount { get; set; }

        /// <summary>
        /// Output only. The requested number of additional storage servers for the Exadata Infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalStorageCount")]
        public virtual System.Nullable<int> AdditionalStorageCount { get; set; }

        /// <summary>
        /// Output only. The available storage can be allocated to the Exadata Infrastructure resource, in gigabytes
        /// (GB).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableStorageSizeGb")]
        public virtual System.Nullable<int> AvailableStorageSizeGb { get; set; }

        /// <summary>Optional. The number of compute servers for the Exadata Infrastructure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeCount")]
        public virtual System.Nullable<int> ComputeCount { get; set; }

        /// <summary>Output only. The compute model of the Exadata Infrastructure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeModel")]
        public virtual string ComputeModel { get; set; }

        /// <summary>Output only. The number of enabled CPU cores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCount")]
        public virtual System.Nullable<int> CpuCount { get; set; }

        /// <summary>Optional. The list of customer contacts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerContacts")]
        public virtual System.Collections.Generic.IList<CustomerContact> CustomerContacts { get; set; }

        /// <summary>Output only. Size, in terabytes, of the DATA disk group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageSizeTb")]
        public virtual System.Nullable<double> DataStorageSizeTb { get; set; }

        /// <summary>Output only. The database server type of the Exadata Infrastructure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseServerType")]
        public virtual string DatabaseServerType { get; set; }

        /// <summary>Output only. The local node storage allocated in GBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbNodeStorageSizeGb")]
        public virtual System.Nullable<int> DbNodeStorageSizeGb { get; set; }

        /// <summary>
        /// Output only. The software version of the database servers (dom0) in the Exadata Infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbServerVersion")]
        public virtual string DbServerVersion { get; set; }

        /// <summary>Optional. Maintenance window for repair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceWindow")]
        public virtual MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>Output only. The total number of CPU cores available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxCpuCount")]
        public virtual System.Nullable<int> MaxCpuCount { get; set; }

        /// <summary>Output only. The total available DATA disk group size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDataStorageTb")]
        public virtual System.Nullable<double> MaxDataStorageTb { get; set; }

        /// <summary>Output only. The total local node storage available in GBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDbNodeStorageSizeGb")]
        public virtual System.Nullable<int> MaxDbNodeStorageSizeGb { get; set; }

        /// <summary>Output only. The total memory available in GBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMemoryGb")]
        public virtual System.Nullable<int> MaxMemoryGb { get; set; }

        /// <summary>Output only. The memory allocated in GBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<int> MemorySizeGb { get; set; }

        /// <summary>
        /// Output only. The monthly software version of the database servers (dom0) in the Exadata Infrastructure.
        /// Example: 20.1.15
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyDbServerVersion")]
        public virtual string MonthlyDbServerVersion { get; set; }

        /// <summary>
        /// Output only. The monthly software version of the storage servers (cells) in the Exadata Infrastructure.
        /// Example: 20.1.15
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlyStorageServerVersion")]
        public virtual string MonthlyStorageServerVersion { get; set; }

        /// <summary>Output only. The OCID of the next maintenance run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextMaintenanceRunId")]
        public virtual string NextMaintenanceRunId { get; set; }

        private string _nextMaintenanceRunTimeRaw;

        private object _nextMaintenanceRunTime;

        /// <summary>Output only. The time when the next maintenance run will occur.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextMaintenanceRunTime")]
        public virtual string NextMaintenanceRunTimeRaw
        {
            get => _nextMaintenanceRunTimeRaw;
            set
            {
                _nextMaintenanceRunTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextMaintenanceRunTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextMaintenanceRunTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextMaintenanceRunTimeDateTimeOffset instead.")]
        public virtual object NextMaintenanceRunTime
        {
            get => _nextMaintenanceRunTime;
            set
            {
                _nextMaintenanceRunTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextMaintenanceRunTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextMaintenanceRunTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextMaintenanceRunTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextMaintenanceRunTimeRaw);
            set => NextMaintenanceRunTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _nextSecurityMaintenanceRunTimeRaw;

        private object _nextSecurityMaintenanceRunTime;

        /// <summary>Output only. The time when the next security maintenance run will occur.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSecurityMaintenanceRunTime")]
        public virtual string NextSecurityMaintenanceRunTimeRaw
        {
            get => _nextSecurityMaintenanceRunTimeRaw;
            set
            {
                _nextSecurityMaintenanceRunTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextSecurityMaintenanceRunTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="NextSecurityMaintenanceRunTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextSecurityMaintenanceRunTimeDateTimeOffset instead.")]
        public virtual object NextSecurityMaintenanceRunTime
        {
            get => _nextSecurityMaintenanceRunTime;
            set
            {
                _nextSecurityMaintenanceRunTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextSecurityMaintenanceRunTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextSecurityMaintenanceRunTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextSecurityMaintenanceRunTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextSecurityMaintenanceRunTimeRaw);
            set => NextSecurityMaintenanceRunTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Deep link to the OCI console to view this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUrl")]
        public virtual string OciUrl { get; set; }

        /// <summary>
        /// Output only. OCID of created infra.
        /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>
        /// Required. The shape of the Exadata Infrastructure. The shape determines the amount of CPU, storage, and
        /// memory resources allocated to the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shape")]
        public virtual string Shape { get; set; }

        /// <summary>Output only. The current lifecycle state of the Exadata Infrastructure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. The number of Cloud Exadata storage servers for the Exadata Infrastructure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageCount")]
        public virtual System.Nullable<int> StorageCount { get; set; }

        /// <summary>Output only. The storage server type of the Exadata Infrastructure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageServerType")]
        public virtual string StorageServerType { get; set; }

        /// <summary>
        /// Output only. The software version of the storage servers (cells) in the Exadata Infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageServerVersion")]
        public virtual string StorageServerVersion { get; set; }

        /// <summary>
        /// Optional. The total storage allocated to the Exadata Infrastructure resource, in gigabytes (GB).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalStorageSizeGb")]
        public virtual System.Nullable<int> TotalStorageSizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the Cloud VM Cluster resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/CloudVmCluster/
    /// </summary>
    public class CloudVmCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the backup OdbSubnet associated with the VM Cluster. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupOdbSubnet")]
        public virtual string BackupOdbSubnet { get; set; }

        /// <summary>Optional. CIDR range of the backup subnet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSubnetCidr")]
        public virtual string BackupSubnetCidr { get; set; }

        /// <summary>Optional. Network settings. CIDR to use for cluster IP allocation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the VM cluster was created.</summary>
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

        /// <summary>Optional. User friendly name for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. The name of the Exadata Infrastructure resource on which VM cluster resource is created, in the
        /// following format:
        /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exadataInfrastructure")]
        public virtual string ExadataInfrastructure { get; set; }

        /// <summary>
        /// Output only. The GCP Oracle zone where Oracle CloudVmCluster is hosted. This will be the same as the
        /// gcp_oracle_zone of the CloudExadataInfrastructure. Example: us-east4-b-r2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>
        /// Output only. The identity connector details which will allow OCI to securely access the resources in the
        /// customer project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityConnector")]
        public virtual IdentityConnector IdentityConnector { get; set; }

        /// <summary>Optional. Labels or tags associated with the VM Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the VM Cluster resource with the format:
        /// projects/{project}/locations/{region}/cloudVmClusters/{cloud_vm_cluster}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The name of the VPC network. Format: projects/{project}/global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// Optional. The name of the OdbNetwork associated with the VM Cluster. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network} It is optional but if specified, this
        /// should match the parent ODBNetwork of the odb_subnet and backup_odb_subnet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbNetwork")]
        public virtual string OdbNetwork { get; set; }

        /// <summary>
        /// Optional. The name of the OdbSubnet associated with the VM Cluster for IP allocation. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbSubnet")]
        public virtual string OdbSubnet { get; set; }

        /// <summary>Optional. Various properties of the VM Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual CloudVmClusterProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Various properties and settings associated with Exadata VM cluster.</summary>
    public class CloudVmClusterProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. OCI Cluster name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>Output only. Compartment ID of cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compartmentId")]
        public virtual string CompartmentId { get; set; }

        /// <summary>Output only. The compute model of the VM Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeModel")]
        public virtual string ComputeModel { get; set; }

        /// <summary>Required. Number of enabled CPU cores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCoreCount")]
        public virtual System.Nullable<int> CpuCoreCount { get; set; }

        /// <summary>Optional. The data disk group size to be allocated in TBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageSizeTb")]
        public virtual System.Nullable<double> DataStorageSizeTb { get; set; }

        /// <summary>Optional. Local storage per VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbNodeStorageSizeGb")]
        public virtual System.Nullable<int> DbNodeStorageSizeGb { get; set; }

        /// <summary>Optional. OCID of database servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbServerOcids")]
        public virtual System.Collections.Generic.IList<string> DbServerOcids { get; set; }

        /// <summary>Optional. Data collection options for diagnostics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticsDataCollectionOptions")]
        public virtual DataCollectionOptions DiagnosticsDataCollectionOptions { get; set; }

        /// <summary>Optional. The type of redundancy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskRedundancy")]
        public virtual string DiskRedundancy { get; set; }

        /// <summary>Output only. DNS listener IP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsListenerIp")]
        public virtual string DnsListenerIp { get; set; }

        /// <summary>
        /// Output only. Parent DNS domain where SCAN DNS and hosts names are qualified. ex:
        /// ocispdelegated.ocisp10jvnet.oraclevcn.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>Optional. Grid Infrastructure Version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("giVersion")]
        public virtual string GiVersion { get; set; }

        /// <summary>
        /// Output only. host name without domain. format: "-" with some suffix. ex: sp2-yi0xq where "sp2" is the
        /// hostname_prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Optional. Prefix for VM cluster host names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostnamePrefix")]
        public virtual string HostnamePrefix { get; set; }

        /// <summary>Required. License type of VM Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>Optional. Use local backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localBackupEnabled")]
        public virtual System.Nullable<bool> LocalBackupEnabled { get; set; }

        /// <summary>Optional. Memory allocated in GBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<int> MemorySizeGb { get; set; }

        /// <summary>Optional. Number of database servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>Output only. Deep link to the OCI console to view this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUrl")]
        public virtual string OciUrl { get; set; }

        /// <summary>Output only. Oracle Cloud Infrastructure ID of VM Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Optional. OCPU count per VM. Minimum is 0.1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocpuCount")]
        public virtual System.Nullable<float> OcpuCount { get; set; }

        /// <summary>Output only. SCAN DNS name. ex: sp2-yi0xq-scan.ocispdelegated.ocisp10jvnet.oraclevcn.com</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanDns")]
        public virtual string ScanDns { get; set; }

        /// <summary>Output only. OCID of scan DNS record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanDnsRecordId")]
        public virtual string ScanDnsRecordId { get; set; }

        /// <summary>Output only. OCIDs of scan IPs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanIpIds")]
        public virtual System.Collections.Generic.IList<string> ScanIpIds { get; set; }

        /// <summary>Output only. SCAN listener port - TCP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanListenerPortTcp")]
        public virtual System.Nullable<int> ScanListenerPortTcp { get; set; }

        /// <summary>Output only. SCAN listener port - TLS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanListenerPortTcpSsl")]
        public virtual System.Nullable<int> ScanListenerPortTcpSsl { get; set; }

        /// <summary>Output only. Shape of VM Cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shape")]
        public virtual string Shape { get; set; }

        /// <summary>Optional. Use exadata sparse snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparseDiskgroupEnabled")]
        public virtual System.Nullable<bool> SparseDiskgroupEnabled { get; set; }

        /// <summary>Optional. SSH public keys to be stored with cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKeys")]
        public virtual System.Collections.Generic.IList<string> SshPublicKeys { get; set; }

        /// <summary>Output only. State of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The storage allocation for the disk group, in gigabytes (GB).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSizeGb")]
        public virtual System.Nullable<int> StorageSizeGb { get; set; }

        /// <summary>Optional. Operating system version of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemVersion")]
        public virtual string SystemVersion { get; set; }

        /// <summary>Optional. Time zone of VM Cluster to set. Defaults to UTC if not specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The CustomerContact reference as defined by Oracle.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/CustomerContact
    /// </summary>
    public class CustomerContact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The email address used by Oracle to send notifications regarding databases and infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data collection options for diagnostics.</summary>
    public class DataCollectionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indicates whether diagnostic collection is enabled for the VM cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticsEventsEnabled")]
        public virtual System.Nullable<bool> DiagnosticsEventsEnabled { get; set; }

        /// <summary>Optional. Indicates whether health monitoring is enabled for the VM cluster</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthMonitoringEnabled")]
        public virtual System.Nullable<bool> HealthMonitoringEnabled { get; set; }

        /// <summary>
        /// Optional. Indicates whether incident logs and trace collection are enabled for the VM cluster
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incidentLogsEnabled")]
        public virtual System.Nullable<bool> IncidentLogsEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data collection options for diagnostics.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/DataCollectionOptions
    /// </summary>
    public class DataCollectionOptionsCommon : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indicates whether to enable data collection for diagnostics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDiagnosticsEventsEnabled")]
        public virtual System.Nullable<bool> IsDiagnosticsEventsEnabled { get; set; }

        /// <summary>Optional. Indicates whether to enable health monitoring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isHealthMonitoringEnabled")]
        public virtual System.Nullable<bool> IsHealthMonitoringEnabled { get; set; }

        /// <summary>Optional. Indicates whether to enable incident logs and trace collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isIncidentLogsEnabled")]
        public virtual System.Nullable<bool> IsIncidentLogsEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data collection options for DbSystem.</summary>
    public class DataCollectionOptionsDbSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indicates whether to enable data collection for diagnostics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDiagnosticsEventsEnabled")]
        public virtual System.Nullable<bool> IsDiagnosticsEventsEnabled { get; set; }

        /// <summary>Optional. Indicates whether to enable incident logs and trace collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isIncidentLogsEnabled")]
        public virtual System.Nullable<bool> IsIncidentLogsEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the Database resource. https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/Database/
    /// </summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The password for the default ADMIN user. Note: Only one of `admin_password_secret_version` or
        /// `admin_password` can be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminPassword")]
        public virtual string AdminPassword { get; set; }

        /// <summary>
        /// Optional. The resource name of a secret version in Secret Manager which contains the database admin user's
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}. Note: Only one of
        /// `admin_password_secret_version` or `admin_password` can be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminPasswordSecretVersion")]
        public virtual string AdminPasswordSecretVersion { get; set; }

        /// <summary>Optional. The character set for the database. The default is AL32UTF8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterSet")]
        public virtual string CharacterSet { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the Database was created.</summary>
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

        /// <summary>Optional. The database ID of the Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseId")]
        public virtual string DatabaseId { get; set; }

        /// <summary>Optional. The name of the DbHome resource associated with the Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbHomeName")]
        public virtual string DbHomeName { get; set; }

        /// <summary>
        /// Optional. The database name. The name must begin with an alphabetic character and can contain a maximum of
        /// eight alphanumeric characters. Special characters are not permitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbName")]
        public virtual string DbName { get; set; }

        /// <summary>Optional. The DB_UNIQUE_NAME of the Oracle Database being backed up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbUniqueName")]
        public virtual string DbUniqueName { get; set; }

        /// <summary>Output only. The GCP Oracle zone where the Database is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>
        /// Identifier. The name of the Database resource in the following format:
        /// projects/{project}/locations/{region}/databases/{database}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The national character set for the database. The default is AL16UTF16.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ncharacterSet")]
        public virtual string NcharacterSet { get; set; }

        /// <summary>Output only. HTTPS link to OCI resources exposed to Customer via UI Interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUrl")]
        public virtual string OciUrl { get; set; }

        /// <summary>Output only. The Status of Operations Insights for this Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("opsInsightsStatus")]
        public virtual string OpsInsightsStatus { get; set; }

        /// <summary>
        /// Optional. The ID of the pluggable database associated with the Database. The ID must be unique within the
        /// project and location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluggableDatabaseId")]
        public virtual string PluggableDatabaseId { get; set; }

        /// <summary>
        /// Optional. The pluggable database associated with the Database. The name must begin with an alphabetic
        /// character and can contain a maximum of thirty alphanumeric characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluggableDatabaseName")]
        public virtual string PluggableDatabaseName { get; set; }

        /// <summary>Optional. The properties of the Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual DatabaseProperties Properties { get; set; }

        /// <summary>
        /// Optional. The TDE wallet password for the database. Note: Only one of `tde_wallet_password_secret_version`
        /// or `tde_wallet_password` can be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tdeWalletPassword")]
        public virtual string TdeWalletPassword { get; set; }

        /// <summary>
        /// Optional. The resource name of a secret version in Secret Manager which contains the TDE wallet password for
        /// the database. Format: projects/{project}/secrets/{secret}/versions/{version}. Note: Only one of
        /// `tde_wallet_password_secret_version` or `tde_wallet_password` can be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tdeWalletPasswordSecretVersion")]
        public virtual string TdeWalletPasswordSecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the Database character set resource.</summary>
    public class DatabaseCharacterSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The character set name for the Database which is the ID in the resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterSet")]
        public virtual string CharacterSet { get; set; }

        /// <summary>Output only. The character set type for the Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterSetType")]
        public virtual string CharacterSetType { get; set; }

        /// <summary>
        /// Identifier. The name of the Database Character Set resource in the following format:
        /// projects/{project}/locations/{region}/databaseCharacterSets/{database_character_set}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The connection string profile to allow clients to group.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/DatabaseConnectionStringProfile
    /// </summary>
    public class DatabaseConnectionStringProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The current consumer group being used by the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerGroup")]
        public virtual string ConsumerGroup { get; set; }

        /// <summary>Output only. The display name for the database connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The host name format being currently used in connection string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostFormat")]
        public virtual string HostFormat { get; set; }

        /// <summary>
        /// Output only. This field indicates if the connection string is regional and is only applicable for
        /// cross-region Data Guard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRegional")]
        public virtual System.Nullable<bool> IsRegional { get; set; }

        /// <summary>Output only. The protocol being used by the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Output only. The current session mode of the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionMode")]
        public virtual string SessionMode { get; set; }

        /// <summary>Output only. The syntax of the connection string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntaxFormat")]
        public virtual string SyntaxFormat { get; set; }

        /// <summary>Output only. This field indicates the TLS authentication type of the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsAuthentication")]
        public virtual string TlsAuthentication { get; set; }

        /// <summary>Output only. The value of the connection string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of the Database Management service.</summary>
    public class DatabaseManagementConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The status of the Database Management service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementState")]
        public virtual string ManagementState { get; set; }

        /// <summary>Output only. The Database Management type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementType")]
        public virtual string ManagementType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of a Database.</summary>
    public class DatabaseProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The Database Management config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseManagementConfig")]
        public virtual DatabaseManagementConfig DatabaseManagementConfig { get; set; }

        /// <summary>Optional. Backup options for the Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbBackupConfig")]
        public virtual DbBackupConfig DbBackupConfig { get; set; }

        /// <summary>Required. The Oracle Database version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbVersion")]
        public virtual string DbVersion { get; set; }

        /// <summary>Output only. State of the Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Backup Options for the Database.</summary>
    public class DbBackupConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, enables automatic backups on the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoBackupEnabled")]
        public virtual System.Nullable<bool> AutoBackupEnabled { get; set; }

        /// <summary>
        /// Optional. The day of the week on which the full backup should be performed on the database. If no value is
        /// provided, it will default to Sunday.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoFullBackupDay")]
        public virtual string AutoFullBackupDay { get; set; }

        /// <summary>
        /// Optional. The window in which the full backup should be performed on the database. If no value is provided,
        /// the default is anytime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoFullBackupWindow")]
        public virtual string AutoFullBackupWindow { get; set; }

        /// <summary>
        /// Optional. The window in which the incremental backup should be performed on the database. If no value is
        /// provided, the default is anytime except the auto full backup day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoIncrementalBackupWindow")]
        public virtual string AutoIncrementalBackupWindow { get; set; }

        /// <summary>Optional. This defines when the backups will be deleted after Database termination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupDeletionPolicy")]
        public virtual string BackupDeletionPolicy { get; set; }

        /// <summary>Optional. Details of the database backup destinations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupDestinationDetails")]
        public virtual System.Collections.Generic.IList<BackupDestinationDetails> BackupDestinationDetails { get; set; }

        /// <summary>
        /// Optional. The number of days an automatic backup is retained before being automatically deleted. This value
        /// determines the earliest point in time to which a database can be restored. Min: 1, Max: 60.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionPeriodDays")]
        public virtual System.Nullable<int> RetentionPeriodDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the Database Home resource.</summary>
    public class DbHome : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Database resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual Database Database { get; set; }

        /// <summary>
        /// Required. A valid Oracle Database version. For a list of supported versions, use the ListDbVersions
        /// operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbVersion")]
        public virtual string DbVersion { get; set; }

        /// <summary>
        /// Optional. The display name for the Database Home. The name does not have to be unique within your project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Whether unified auditing is enabled for the Database Home.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isUnifiedAuditingEnabled")]
        public virtual System.Nullable<bool> IsUnifiedAuditingEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the database node resource. https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/DbNode/
    /// </summary>
    public class DbNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The name of the database node resource in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}/dbNodes/{db_node}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Various properties of the database node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual DbNodeProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Various properties and settings associated with Db node.</summary>
    public class DbNodeProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the database node was created.</summary>
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

        /// <summary>Optional. Local storage per database node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbNodeStorageSizeGb")]
        public virtual System.Nullable<int> DbNodeStorageSizeGb { get; set; }

        /// <summary>Optional. Database server OCID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbServerOcid")]
        public virtual string DbServerOcid { get; set; }

        /// <summary>Optional. DNS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Memory allocated in GBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<int> MemorySizeGb { get; set; }

        /// <summary>Output only. OCID of database node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Optional. OCPU count per database node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocpuCount")]
        public virtual System.Nullable<int> OcpuCount { get; set; }

        /// <summary>Output only. State of the database node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Total CPU core count of the database node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCpuCoreCount")]
        public virtual System.Nullable<int> TotalCpuCoreCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the database server resource. https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/DbServer/
    /// </summary>
    public class DbServer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. User friendly name for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The name of the database server resource with the format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}/dbServers/{db_server}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Various properties of the database server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual DbServerProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Various properties and settings associated with Exadata database server.</summary>
    public class DbServerProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. OCID of database nodes associated with the database server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbNodeIds")]
        public virtual System.Collections.Generic.IList<string> DbNodeIds { get; set; }

        /// <summary>Optional. Local storage per VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbNodeStorageSizeGb")]
        public virtual System.Nullable<int> DbNodeStorageSizeGb { get; set; }

        /// <summary>Optional. Maximum local storage per VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDbNodeStorageSizeGb")]
        public virtual System.Nullable<int> MaxDbNodeStorageSizeGb { get; set; }

        /// <summary>Optional. Maximum memory allocated in GBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMemorySizeGb")]
        public virtual System.Nullable<int> MaxMemorySizeGb { get; set; }

        /// <summary>Optional. Maximum OCPU count per database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOcpuCount")]
        public virtual System.Nullable<int> MaxOcpuCount { get; set; }

        /// <summary>Optional. Memory allocated in GBs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<int> MemorySizeGb { get; set; }

        /// <summary>Output only. OCID of database server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Optional. OCPU count per database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocpuCount")]
        public virtual System.Nullable<int> OcpuCount { get; set; }

        /// <summary>Output only. State of the database server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Vm count per database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmCount")]
        public virtual System.Nullable<int> VmCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the DbSystem (BaseDB) resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/DbSystem/
    /// </summary>
    public class DbSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the DbSystem was created.</summary>
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
        /// Required. The display name for the System db. The name does not have to be unique within your project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The ID of the subscription entitlement associated with the DbSystem</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>
        /// Optional. The GCP Oracle zone where Oracle DbSystem is hosted. Example: us-east4-b-r2. If not specified, the
        /// system will pick a zone based on availability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>Optional. The labels or tags associated with the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the DbSystem resource in the following format:
        /// projects/{project}/locations/{region}/dbSystems/{db_system}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. HTTPS link to OCI resources exposed to Customer via UI Interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUrl")]
        public virtual string OciUrl { get; set; }

        /// <summary>
        /// Optional. The name of the OdbNetwork associated with the DbSystem. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network} It is optional but if specified, this
        /// should match the parent ODBNetwork of the OdbSubnet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbNetwork")]
        public virtual string OdbNetwork { get; set; }

        /// <summary>
        /// Required. The name of the OdbSubnet associated with the DbSystem for IP allocation. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbSubnet")]
        public virtual string OdbSubnet { get; set; }

        /// <summary>Optional. The properties of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual DbSystemProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary of the DbSystem initial storage size.</summary>
    public class DbSystemInitialStorageSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The properties of the DbSystem initial storage size summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual DbSystemInitialStorageSizeProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of a DbSystem initial storage size summary.</summary>
    public class DbSystemInitialStorageSizeProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of storage disk details available for launches from backup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchFromBackupStorageSizeDetails")]
        public virtual System.Collections.Generic.IList<StorageSizeDetails> LaunchFromBackupStorageSizeDetails { get; set; }

        /// <summary>Output only. VM shape platform type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shapeType")]
        public virtual string ShapeType { get; set; }

        /// <summary>Output only. The storage option used in DB system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageManagement")]
        public virtual string StorageManagement { get; set; }

        /// <summary>Output only. List of storage disk details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageSizeDetails")]
        public virtual System.Collections.Generic.IList<StorageSizeDetails> StorageSizeDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the DbSystem Options.</summary>
    public class DbSystemOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The storage option used in DB system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageManagement")]
        public virtual string StorageManagement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of a DbSystem.</summary>
    public class DbSystemProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The number of CPU cores to enable for the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeCount")]
        public virtual System.Nullable<int> ComputeCount { get; set; }

        /// <summary>Optional. The compute model of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeModel")]
        public virtual string ComputeModel { get; set; }

        /// <summary>Optional. Data collection options for diagnostics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCollectionOptions")]
        public virtual DataCollectionOptionsDbSystem DataCollectionOptions { get; set; }

        /// <summary>Optional. The data storage size in GB that is currently available to DbSystems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageSizeGb")]
        public virtual System.Nullable<int> DataStorageSizeGb { get; set; }

        /// <summary>Required. The database edition of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseEdition")]
        public virtual string DatabaseEdition { get; set; }

        /// <summary>Optional. Details for creating a Database Home.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbHome")]
        public virtual DbHome DbHome { get; set; }

        /// <summary>Optional. The options for the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbSystemOptions")]
        public virtual DbSystemOptions DbSystemOptions { get; set; }

        /// <summary>Optional. The host domain name of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>Output only. The hostname of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Optional. Prefix for DB System host names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostnamePrefix")]
        public virtual string HostnamePrefix { get; set; }

        /// <summary>Required. The initial data storage size in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialDataStorageSizeGb")]
        public virtual System.Nullable<int> InitialDataStorageSizeGb { get; set; }

        /// <summary>Required. The license model of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseModel")]
        public virtual string LicenseModel { get; set; }

        /// <summary>Output only. State of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>Optional. The memory size in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<int> MemorySizeGb { get; set; }

        /// <summary>Optional. The number of nodes in the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>Output only. OCID of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Optional. The private IP address of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateIp")]
        public virtual string PrivateIp { get; set; }

        /// <summary>Optional. The reco/redo storage size in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoStorageSizeGb")]
        public virtual System.Nullable<int> RecoStorageSizeGb { get; set; }

        /// <summary>Required. Shape of DB System.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shape")]
        public virtual string Shape { get; set; }

        /// <summary>Required. SSH public keys to be stored with the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKeys")]
        public virtual System.Collections.Generic.IList<string> SshPublicKeys { get; set; }

        /// <summary>Optional. Time zone of the DbSystem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the Database System Shapes resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/DbSystemShapeSummary/
    /// </summary>
    public class DbSystemShape : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Number of cores per node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableCoreCountPerNode")]
        public virtual System.Nullable<int> AvailableCoreCountPerNode { get; set; }

        /// <summary>Optional. Storage per storage server in terabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableDataStorageTb")]
        public virtual System.Nullable<int> AvailableDataStorageTb { get; set; }

        /// <summary>Optional. Memory per database server node in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableMemoryPerNodeGb")]
        public virtual System.Nullable<int> AvailableMemoryPerNodeGb { get; set; }

        /// <summary>Optional. Maximum number of database servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxNodeCount")]
        public virtual System.Nullable<int> MaxNodeCount { get; set; }

        /// <summary>Optional. Maximum number of storage servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxStorageCount")]
        public virtual System.Nullable<int> MaxStorageCount { get; set; }

        /// <summary>Optional. Minimum core count per node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCoreCountPerNode")]
        public virtual System.Nullable<int> MinCoreCountPerNode { get; set; }

        /// <summary>Optional. Minimum node storage per database server in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minDbNodeStoragePerNodeGb")]
        public virtual System.Nullable<int> MinDbNodeStoragePerNodeGb { get; set; }

        /// <summary>Optional. Minimum memory per node in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minMemoryPerNodeGb")]
        public virtual System.Nullable<int> MinMemoryPerNodeGb { get; set; }

        /// <summary>Optional. Minimum number of database servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minNodeCount")]
        public virtual System.Nullable<int> MinNodeCount { get; set; }

        /// <summary>Optional. Minimum number of storage servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minStorageCount")]
        public virtual System.Nullable<int> MinStorageCount { get; set; }

        /// <summary>
        /// Identifier. The name of the Database System Shape resource with the format:
        /// projects/{project}/locations/{region}/dbSystemShapes/{db_system_shape}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. shape</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shape")]
        public virtual string Shape { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A valid Oracle Database version.</summary>
    public class DbVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The name of the DbVersion resource in the following format:
        /// projects/{project}/locations/{region}/dbVersions/{db_version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The properties of the DbVersion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual DbVersionProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of a DbVersion.</summary>
    public class DbVersionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. True if this version of the Oracle Database software is the latest version for a release.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isLatestForMajorVersion")]
        public virtual System.Nullable<bool> IsLatestForMajorVersion { get; set; }

        /// <summary>Output only. True if this version of the Oracle Database software is the preview version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPreviewDbVersion")]
        public virtual System.Nullable<bool> IsPreviewDbVersion { get; set; }

        /// <summary>
        /// Output only. True if this version of the Oracle Database software is supported for Upgrade.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isUpgradeSupported")]
        public virtual System.Nullable<bool> IsUpgradeSupported { get; set; }

        /// <summary>
        /// Output only. True if this version of the Oracle Database software supports pluggable databases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsPdb")]
        public virtual System.Nullable<bool> SupportsPdb { get; set; }

        /// <summary>Output only. A valid Oracle Database version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wrapper message for the value of a defined tag.</summary>
    public class DefinedTagValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The tags within the namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The deployment diagnostic data.</summary>
    public class DeploymentDiagnosticData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The bucket name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        private string _diagnosticEndTimeRaw;

        private object _diagnosticEndTime;

        /// <summary>Output only. The time diagnostic end.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticEndTime")]
        public virtual string DiagnosticEndTimeRaw
        {
            get => _diagnosticEndTimeRaw;
            set
            {
                _diagnosticEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _diagnosticEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DiagnosticEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DiagnosticEndTimeDateTimeOffset instead.")]
        public virtual object DiagnosticEndTime
        {
            get => _diagnosticEndTime;
            set
            {
                _diagnosticEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _diagnosticEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DiagnosticEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DiagnosticEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DiagnosticEndTimeRaw);
            set => DiagnosticEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _diagnosticStartTimeRaw;

        private object _diagnosticStartTime;

        /// <summary>Output only. The time diagnostic start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticStartTime")]
        public virtual string DiagnosticStartTimeRaw
        {
            get => _diagnosticStartTimeRaw;
            set
            {
                _diagnosticStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _diagnosticStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DiagnosticStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DiagnosticStartTimeDateTimeOffset instead.")]
        public virtual object DiagnosticStartTime
        {
            get => _diagnosticStartTime;
            set
            {
                _diagnosticStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _diagnosticStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DiagnosticStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DiagnosticStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DiagnosticStartTimeRaw);
            set => DiagnosticStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The diagnostic state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticState")]
        public virtual string DiagnosticState { get; set; }

        /// <summary>Output only. The namespace name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>Output only. The object name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

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

    /// <summary>The encryption key used to encrypt the Autonomous Database.</summary>
    public class EncryptionKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The KMS key used to encrypt the Autonomous Database. This field is required if the provider is
        /// GOOGLE_MANAGED. The name of the KMS key resource in the following format:
        /// `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>Optional. The provider of the encryption key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The history of the encryption keys used to encrypt the Autonomous Database.</summary>
    public class EncryptionKeyHistoryEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _activationTimeRaw;

        private object _activationTime;

        /// <summary>
        /// Output only. The date and time when the encryption key was activated on the Autonomous Database..
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activationTime")]
        public virtual string ActivationTimeRaw
        {
            get => _activationTimeRaw;
            set
            {
                _activationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _activationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ActivationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ActivationTimeDateTimeOffset instead.")]
        public virtual object ActivationTime
        {
            get => _activationTime;
            set
            {
                _activationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _activationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ActivationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ActivationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ActivationTimeRaw);
            set => ActivationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The encryption key used to encrypt the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionKey")]
        public virtual EncryptionKey EncryptionKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the Entitlement resource.</summary>
    public class Entitlement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details of the OCI Cloud Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudAccountDetails")]
        public virtual CloudAccountDetails CloudAccountDetails { get; set; }

        /// <summary>Output only. Google Cloud Marketplace order ID (aka entitlement ID)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>
        /// Identifier. The name of the Entitlement resource with the format:
        /// projects/{project}/locations/{region}/entitlements/{entitlement}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Entitlement State.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ExadbVmCluster represents a cluster of VMs that are used to run Exadata workloads.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/ExadbVmCluster/
    /// </summary>
    public class ExadbVmCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The name of the backup OdbSubnet associated with the ExadbVmCluster. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupOdbSubnet")]
        public virtual string BackupOdbSubnet { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the ExadbVmCluster was created.</summary>
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
        /// Required. Immutable. The display name for the ExadbVmCluster. The name does not have to be unique within
        /// your project. The name must be 1-255 characters long and can only contain alphanumeric characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The ID of the subscription entitlement associated with the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>
        /// Output only. Immutable. The GCP Oracle zone where Oracle ExadbVmCluster is hosted. Example: us-east4-b-r2.
        /// During creation, the system will pick the zone assigned to the ExascaleDbStorageVault.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>Optional. The labels or tags associated with the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the ExadbVmCluster resource in the following format:
        /// projects/{project}/locations/{region}/exadbVmClusters/{exadb_vm_cluster}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Immutable. The name of the OdbNetwork associated with the ExadbVmCluster. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network} It is optional but if specified, this
        /// should match the parent ODBNetwork of the OdbSubnet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbNetwork")]
        public virtual string OdbNetwork { get; set; }

        /// <summary>
        /// Required. Immutable. The name of the OdbSubnet associated with the ExadbVmCluster for IP allocation. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbSubnet")]
        public virtual string OdbSubnet { get; set; }

        /// <summary>Required. The properties of the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual ExadbVmClusterProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of an ExadbVmCluster.</summary>
    public class ExadbVmClusterProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Immutable. The number of additional ECPUs per node for an Exadata VM cluster on exascale
        /// infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalEcpuCountPerNode")]
        public virtual System.Nullable<int> AdditionalEcpuCountPerNode { get; set; }

        /// <summary>
        /// Optional. Immutable. The cluster name for Exascale vm cluster. The cluster name must begin with an
        /// alphabetic character and may contain hyphens(-) but can not contain underscores(_). It should be not more
        /// than 11 characters and is not case sensitive. OCI Cluster name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>Optional. Immutable. Indicates user preference for data collection options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCollectionOptions")]
        public virtual DataCollectionOptionsCommon DataCollectionOptions { get; set; }

        /// <summary>
        /// Required. Immutable. The number of ECPUs enabled per node for an exadata vm cluster on exascale
        /// infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledEcpuCountPerNode")]
        public virtual System.Nullable<int> EnabledEcpuCountPerNode { get; set; }

        /// <summary>
        /// Required. Immutable. The name of ExascaleDbStorageVault associated with the ExadbVmCluster. It can refer to
        /// an existing ExascaleDbStorageVault. Or a new one can be created during the ExadbVmCluster creation (requires
        /// storage_vault_properties to be set). Format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exascaleDbStorageVault")]
        public virtual string ExascaleDbStorageVault { get; set; }

        /// <summary>Output only. The Oracle Grid Infrastructure (GI) software version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("giVersion")]
        public virtual string GiVersion { get; set; }

        /// <summary>Required. Immutable. Grid Infrastructure Version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gridImageId")]
        public virtual string GridImageId { get; set; }

        /// <summary>Output only. The hostname of the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Required. Immutable. Prefix for VM cluster host names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostnamePrefix")]
        public virtual string HostnamePrefix { get; set; }

        /// <summary>Optional. Immutable. The license type of the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseModel")]
        public virtual string LicenseModel { get; set; }

        /// <summary>Output only. State of the cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>
        /// Output only. Memory per VM (GB) (Read-only): Shows the amount of memory allocated to each VM. Memory is
        /// calculated based on 2.75 GB per Total ECPUs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<int> MemorySizeGb { get; set; }

        /// <summary>Required. The number of nodes/VMs in the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual System.Nullable<int> NodeCount { get; set; }

        /// <summary>Output only. Deep link to the OCI console to view this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUri")]
        public virtual string OciUri { get; set; }

        /// <summary>Optional. Immutable. SCAN listener port - TCP</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanListenerPortTcp")]
        public virtual System.Nullable<int> ScanListenerPortTcp { get; set; }

        /// <summary>
        /// Required. Immutable. The shape attribute of the VM cluster. The type of Exascale storage used for Exadata VM
        /// cluster. The default is SMART_STORAGE which supports Oracle Database 23ai and later
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shapeAttribute")]
        public virtual string ShapeAttribute { get; set; }

        /// <summary>Required. Immutable. The SSH public keys for the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKeys")]
        public virtual System.Collections.Generic.IList<string> SshPublicKeys { get; set; }

        /// <summary>Optional. Immutable. The time zone of the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>Required. Immutable. Total storage details for the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmFileSystemStorage")]
        public virtual ExadbVmClusterStorageDetails VmFileSystemStorage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The storage allocation for the exadbvmcluster, in gigabytes (GB).</summary>
    public class ExadbVmClusterStorageDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The storage allocation for the exadbvmcluster per node, in gigabytes (GB). This field is used to
        /// calculate the total storage allocation for the exadbvmcluster.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeInGbsPerNode")]
        public virtual System.Nullable<int> SizeInGbsPerNode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The storage details of the ExascaleDbStorageVault.</summary>
    public class ExascaleDbStorageDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The available storage capacity for the ExascaleDbStorageVault, in gigabytes (GB).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableSizeGbs")]
        public virtual System.Nullable<int> AvailableSizeGbs { get; set; }

        /// <summary>Required. The total storage allocation for the ExascaleDbStorageVault, in gigabytes (GB).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSizeGbs")]
        public virtual System.Nullable<int> TotalSizeGbs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ExascaleDbStorageVault represents a storage vault exadb vm cluster resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/ExascaleDbStorageVault/
    /// </summary>
    public class ExascaleDbStorageVault : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time when the ExascaleDbStorageVault was created.</summary>
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
        /// Required. The display name for the ExascaleDbStorageVault. The name does not have to be unique within your
        /// project. The name must be 1-255 characters long and can only contain alphanumeric characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The ID of the subscription entitlement associated with the ExascaleDbStorageVault.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>
        /// Optional. The GCP Oracle zone where Oracle ExascaleDbStorageVault is hosted. Example: us-east4-b-r2. If not
        /// specified, the system will pick a zone based on availability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>Optional. The labels or tags associated with the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name of the ExascaleDbStorageVault. Format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The properties of the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual ExascaleDbStorageVaultProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of the ExascaleDbStorageVault. next ID: 12</summary>
    public class ExascaleDbStorageVaultProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The size of additional flash cache in percentage of high capacity database storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalFlashCachePercent")]
        public virtual System.Nullable<int> AdditionalFlashCachePercent { get; set; }

        /// <summary>
        /// Output only. The shape attributes of the VM clusters attached to the ExascaleDbStorageVault.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedShapeAttributes")]
        public virtual System.Collections.Generic.IList<string> AttachedShapeAttributes { get; set; }

        /// <summary>
        /// Output only. The shape attributes available for the VM clusters to be attached to the
        /// ExascaleDbStorageVault.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableShapeAttributes")]
        public virtual System.Collections.Generic.IList<string> AvailableShapeAttributes { get; set; }

        /// <summary>Optional. The description of the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The storage details of the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exascaleDbStorageDetails")]
        public virtual ExascaleDbStorageDetails ExascaleDbStorageDetails { get; set; }

        /// <summary>Output only. Deep link to the OCI console to view this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUri")]
        public virtual string OciUri { get; set; }

        /// <summary>Output only. The OCID for the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Output only. The state of the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The time zone of the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>Output only. The number of VM clusters associated with the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmClusterCount")]
        public virtual System.Nullable<int> VmClusterCount { get; set; }

        /// <summary>Output only. The list of VM cluster OCIDs associated with the ExascaleDbStorageVault.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmClusterIds")]
        public virtual System.Collections.Generic.IList<string> VmClusterIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `OracleDatabase.FailoverAutonomousDatabase`.</summary>
    public class FailoverAutonomousDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The peer database name to fail over to. Required for cross-region standby, and must be omitted for
        /// in-region Data Guard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerAutonomousDatabase")]
        public virtual string PeerAutonomousDatabase { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `AutonomousDatabase.GenerateWallet`.</summary>
    public class GenerateAutonomousDatabaseWalletRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. True when requesting regional connection strings in PDB connect info, applicable to cross-region
        /// Data Guard only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRegional")]
        public virtual System.Nullable<bool> IsRegional { get; set; }

        /// <summary>
        /// Required. The password used to encrypt the keys inside the wallet. The password must be a minimum of 8
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. The type of wallet generation for the Autonomous Database. The default value is SINGLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `AutonomousDatabase.GenerateWallet`.</summary>
    public class GenerateAutonomousDatabaseWalletResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The base64 encoded wallet files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveContent")]
        public virtual string ArchiveContent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of the Oracle Grid Infrastructure (GI) version resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/GiVersionSummary/
    /// </summary>
    public class GiVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The name of the Oracle Grid Infrastructure (GI) version resource with the format:
        /// projects/{project}/locations/{region}/giVersions/{gi_versions}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Glue Iceberg catalog.</summary>
    public class GlueIcebergCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The catalog ID of Glue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glueId")]
        public virtual string GlueId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateAmazonKinesisConnection.</summary>
    public class GoldengateAmazonKinesisConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Access key ID to access the Amazon Kinesis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessKeyId")]
        public virtual string AccessKeyId { get; set; }

        /// <summary>
        /// Optional. The name of the AWS region. If not provided, Goldengate will default to 'us-west-1'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsRegion")]
        public virtual string AwsRegion { get; set; }

        /// <summary>
        /// Optional. The endpoint URL of the Amazon Kinesis service. e.g.: 'https://kinesis.us-east-1.amazonaws.com' If
        /// not provided, Goldengate will default to 'https://kinesis..amazonaws.com'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>Optional. Secret access key to access the Amazon Kinesis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretAccessKeySecret")]
        public virtual string SecretAccessKeySecret { get; set; }

        /// <summary>Optional. The technology type of AmazonKinesisConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateAmazonRedshiftConnection.</summary>
    public class GoldengateAmazonRedshiftConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Connection URL. e.g.:
        /// 'jdbc:redshift://aws-redshift-instance.aaaaaaaaaaaa.us-east-2.redshift.amazonaws.com:5439/mydb'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionUrl")]
        public virtual string ConnectionUrl { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses for Amazon Redshift connection in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses for Amazon Redshift connection. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The technology type of AmazonRedshiftConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>
        /// Optional. The username Oracle Goldengate uses to connect the associated system of the given technology.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateAmazonS3Connection.</summary>
    public class GoldengateAmazonS3ConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Access key ID to access the Amazon S3 bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessKeyId")]
        public virtual string AccessKeyId { get; set; }

        /// <summary>Optional. The Amazon Endpoint for S3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>Optional. The name of the AWS region where the bucket is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Optional. Secret access key to access the Amazon S3 bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretAccessKeySecret")]
        public virtual string SecretAccessKeySecret { get; set; }

        /// <summary>Optional. The technology type of AmazonS3Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateAzureDataLakeStorageConnection.</summary>
    public class GoldengateAzureDataLakeStorageConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Sets the Azure storage account name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        /// <summary>
        /// Optional. Azure storage account key. This property is required when 'authentication_type' is set to
        /// 'SHARED_KEY'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountKeySecret")]
        public virtual string AccountKeySecret { get; set; }

        /// <summary>Optional. Authentication mechanism to access Azure Data Lake Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationType")]
        public virtual string AuthenticationType { get; set; }

        /// <summary>
        /// Optional. The endpoint used for authentication with Microsoft Entra ID (formerly Azure Active Directory).
        /// Default value: https://login.microsoftonline.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureAuthorityHost")]
        public virtual string AzureAuthorityHost { get; set; }

        /// <summary>
        /// Optional. Azure tenant ID of the application. This property is required when 'authentication_type' is set to
        /// 'AZURE_ACTIVE_DIRECTORY'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureTenantId")]
        public virtual string AzureTenantId { get; set; }

        /// <summary>
        /// Optional. Azure client ID of the application. This property is required when 'authentication_type' is set to
        /// 'AZURE_ACTIVE_DIRECTORY'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Optional. Azure client secret (aka application password) for authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>Optional. Azure Storage service endpoint. e.g: https://test.blob.core.windows.net</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>
        /// Optional. Credential that uses a shared access signature (SAS) to authenticate to an Azure Service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sasTokenSecret")]
        public virtual string SasTokenSecret { get; set; }

        /// <summary>Optional. The technology type of AzureDataLakeStorageConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateAzureSynapseAnalyticsConnection.</summary>
    public class GoldengateAzureSynapseAnalyticsConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. JDBC connection string. e.g.:
        /// 'jdbc:sqlserver://.sql.azuresynapse.net:1433;database=;encrypt=true;trustServerCertificate=false;hostNameInCertificate=*.sql.azuresynapse.net;loginTimeout=300;'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionString")]
        public virtual string ConnectionString { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses for Azure Synapse Analytics connection in plain
        /// text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses for Azure Synapse Analytics connection. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The technology type of AzureSynapseAnalyticsConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>
        /// Optional. The username Oracle Goldengate uses to connect the associated system of the given technology.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The backup schedule of the GoldengateDeployment.</summary>
    public class GoldengateBackupSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _backupScheduledTimeRaw;

        private object _backupScheduledTime;

        /// <summary>Output only. The timestamp of when the backup was scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupScheduledTime")]
        public virtual string BackupScheduledTimeRaw
        {
            get => _backupScheduledTimeRaw;
            set
            {
                _backupScheduledTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _backupScheduledTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BackupScheduledTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BackupScheduledTimeDateTimeOffset instead.")]
        public virtual object BackupScheduledTime
        {
            get => _backupScheduledTime;
            set
            {
                _backupScheduledTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _backupScheduledTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BackupScheduledTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BackupScheduledTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BackupScheduledTimeRaw);
            set => BackupScheduledTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The bucket name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>Output only. The compartment id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compartmentId")]
        public virtual string CompartmentId { get; set; }

        /// <summary>Output only. The frequency backup scheduled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequencyBackupScheduled")]
        public virtual string FrequencyBackupScheduled { get; set; }

        /// <summary>Output only. If metadata only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataOnly")]
        public virtual System.Nullable<bool> MetadataOnly { get; set; }

        /// <summary>Output only. The namespace name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the GoldengateConnection resource.</summary>
    public class GoldengateConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the GoldengateConnection was created.</summary>
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
        /// Output only. The ID of the subscription entitlement associated with the GoldengateConnection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>
        /// Optional. The GCP Oracle zone where Oracle GoldengateConnection is hosted. Example: us-east4-b-r2. If not
        /// specified, the system will pick a zone based on availability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>Optional. The labels or tags associated with the GoldengateConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the GoldengateConnection resource in the following format:
        /// projects/{project}/locations/{region}/goldengateConnections/{goldengate_connection}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. HTTPS link to OCI resources exposed to Customer via UI Interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUrl")]
        public virtual string OciUrl { get; set; }

        /// <summary>
        /// Optional. The name of the OdbNetwork associated with the GoldengateConnection. The format is
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}. It is optional but if specified, this
        /// should match the parent ODBNetwork of the OdbSubnet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbNetwork")]
        public virtual string OdbNetwork { get; set; }

        /// <summary>
        /// Optional. The name of the OdbSubnet associated with the GoldengateConnection for IP allocation. Format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbSubnet")]
        public virtual string OdbSubnet { get; set; }

        /// <summary>Required. The properties of the GoldengateConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoldengateConnectionProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the metadata of a Goldengate Connection Assignment.</summary>
    public class GoldengateConnectionAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time when the connection assignment was created.</summary>
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

        /// <summary>Optional. The display name for the GoldengateConnectionAssignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The OCID of the entitlement linked to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>Optional. The labels or tags associated with the GoldengateConnectionAssignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the GoldengateConnectionAssignment resource in the following format:
        /// projects/{project}/locations/{region}/goldengateConnectionAssignments/{goldengate_connection_assignment}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The properties of the GoldengateConnectionAssignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoldengateConnectionAssignmentProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of a GoldengateConnectionAssignment.</summary>
    public class GoldengateConnectionAssignmentProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Credential store alias.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>
        /// Required. The GoldengateConnection resource to be assigned. Format:
        /// projects/{project}/locations/{location}/goldengateConnections/{goldengate_connection}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateConnection")]
        public virtual string GoldengateConnection { get; set; }

        /// <summary>
        /// Required. The GoldenGateDeployment to assign the connection to. Format:
        /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateDeployment")]
        public virtual string GoldengateDeployment { get; set; }

        /// <summary>
        /// Output only. The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the
        /// connection assignment being referenced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Output only. The lifecycle state of the connection assignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of a GoldengateConnection.</summary>
    public class GoldengateConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Properties for an Amazon Kinesis connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amazonKinesisConnectionProperties")]
        public virtual GoldengateAmazonKinesisConnectionProperties AmazonKinesisConnectionProperties { get; set; }

        /// <summary>Properties for an Amazon Redshift connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amazonRedshiftConnectionProperties")]
        public virtual GoldengateAmazonRedshiftConnectionProperties AmazonRedshiftConnectionProperties { get; set; }

        /// <summary>Properties for an Amazon S3 connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amazonS3ConnectionProperties")]
        public virtual GoldengateAmazonS3ConnectionProperties AmazonS3ConnectionProperties { get; set; }

        /// <summary>Properties for an Azure Data Lake Storage Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureDataLakeStorageConnectionProperties")]
        public virtual GoldengateAzureDataLakeStorageConnectionProperties AzureDataLakeStorageConnectionProperties { get; set; }

        /// <summary>Properties for an Azure Synapse Analytics connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureSynapseAnalyticsConnectionProperties")]
        public virtual GoldengateAzureSynapseAnalyticsConnectionProperties AzureSynapseAnalyticsConnectionProperties { get; set; }

        /// <summary>Required. The connection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>Properties for a Databricks connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databricksConnectionProperties")]
        public virtual GoldengateDatabricksConnectionProperties DatabricksConnectionProperties { get; set; }

        /// <summary>Properties for a DB2 connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("db2ConnectionProperties")]
        public virtual GoldengateDb2ConnectionProperties Db2ConnectionProperties { get; set; }

        /// <summary>Optional. Metadata about this specific object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. An object's Display Name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Properties for an Elasticsearch connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elasticsearchConnectionProperties")]
        public virtual GoldengateElasticsearchConnectionProperties ElasticsearchConnectionProperties { get; set; }

        /// <summary>Properties for a Generic Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericConnectionProperties")]
        public virtual GoldengateGenericConnectionProperties GenericConnectionProperties { get; set; }

        /// <summary>Properties for a Goldengate Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateConnectionProperties")]
        public virtual GoldengateGoldengateConnectionProperties GoldengateConnectionPropertiesValue { get; set; }

        /// <summary>Properties for a Google BigQuery Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleBigQueryConnectionProperties")]
        public virtual GoldengateGoogleBigQueryConnectionProperties GoogleBigQueryConnectionProperties { get; set; }

        /// <summary>Properties for a Google Cloud Storage Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudStorageConnectionProperties")]
        public virtual GoldengateGoogleCloudStorageConnectionProperties GoogleCloudStorageConnectionProperties { get; set; }

        /// <summary>Properties for a Google Pub/Sub connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googlePubsubConnectionProperties")]
        public virtual GoldengateGooglePubsubConnectionProperties GooglePubsubConnectionProperties { get; set; }

        /// <summary>Properties for an HDFS connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hdfsConnectionProperties")]
        public virtual GoldengateHdfsConnectionProperties HdfsConnectionProperties { get; set; }

        /// <summary>Properties for an Iceberg connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icebergConnectionProperties")]
        public virtual GoldengateIcebergConnectionProperties IcebergConnectionProperties { get; set; }

        /// <summary>Output only. The Ingress IPs of the GoldengateConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressIpAddresses")]
        public virtual System.Collections.Generic.IList<string> IngressIpAddresses { get; set; }

        /// <summary>Properties for a Java Message Service connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("javaMessageServiceConnectionProperties")]
        public virtual GoldengateJavaMessageServiceConnectionProperties JavaMessageServiceConnectionProperties { get; set; }

        /// <summary>Properties for a Kafka Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kafkaConnectionProperties")]
        public virtual GoldengateKafkaConnectionProperties KafkaConnectionProperties { get; set; }

        /// <summary>Properties for a Kafka Schema Registry Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kafkaSchemaRegistryConnectionProperties")]
        public virtual GoldengateKafkaSchemaRegistryConnectionProperties KafkaSchemaRegistryConnectionProperties { get; set; }

        /// <summary>
        /// Output only. Describes the object's current state in detail. For example, it can be used to provide
        /// actionable information for a resource in a Failed state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleDetails")]
        public virtual string LifecycleDetails { get; set; }

        /// <summary>Output only. The lifecycle state of the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>Properties for a Microsoft Fabric connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("microsoftFabricConnectionProperties")]
        public virtual GoldengateMicrosoftFabricConnectionProperties MicrosoftFabricConnectionProperties { get; set; }

        /// <summary>Properties for a Microsoft SQL Server connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("microsoftSqlserverConnectionProperties")]
        public virtual GoldengateMicrosoftSqlserverConnectionProperties MicrosoftSqlserverConnectionProperties { get; set; }

        /// <summary>Properties for a MongoDB connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mongodbConnectionProperties")]
        public virtual GoldengateMongodbConnectionProperties MongodbConnectionProperties { get; set; }

        /// <summary>Properties for a Mysql Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mysqlConnectionProperties")]
        public virtual GoldengateMysqlConnectionProperties MysqlConnectionProperties { get; set; }

        /// <summary>Properties for an OCI Object Storage Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociObjectStorageConnectionProperties")]
        public virtual GoldengateOciObjectStorageConnectionProperties OciObjectStorageConnectionProperties { get; set; }

        /// <summary>Output only. The [OCID] of the connection being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Properties for an Oracle AI Data Platform connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleAiDataPlatformConnectionProperties")]
        public virtual GoldengateOracleAIDataPlatformConnectionProperties OracleAiDataPlatformConnectionProperties { get; set; }

        /// <summary>Properties for an Oracle Database Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleConnectionProperties")]
        public virtual GoldengateOracleConnectionProperties OracleConnectionProperties { get; set; }

        /// <summary>Properties for an Oracle NoSQL connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oracleNosqlConnectionProperties")]
        public virtual GoldengateOracleNosqlConnectionProperties OracleNosqlConnectionProperties { get; set; }

        /// <summary>Properties for a PostgreSQL connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postgresqlConnectionProperties")]
        public virtual GoldengatePostgresqlConnectionProperties PostgresqlConnectionProperties { get; set; }

        /// <summary>Properties for a Redis connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisConnectionProperties")]
        public virtual GoldengateRedisConnectionProperties RedisConnectionProperties { get; set; }

        /// <summary>Optional. The routing method for the GoldengateConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingMethod")]
        public virtual string RoutingMethod { get; set; }

        /// <summary>Properties for a Snowflake connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snowflakeConnectionProperties")]
        public virtual GoldengateSnowflakeConnectionProperties SnowflakeConnectionProperties { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the resource was last updated.</summary>
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

    /// <summary>Details of the Goldengate Connection Type resource.</summary>
    public class GoldengateConnectionType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The connection type of the Goldengate Connection Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>
        /// Identifier. The name of the Goldengate Connection Type resource with the format:
        /// projects/{project}/locations/{region}/goldengateConnectionTypes/{goldengate_connection_type}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The technology type of the Goldengate Connection Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyTypes")]
        public virtual System.Collections.Generic.IList<string> TechnologyTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateDatabricksConnection.</summary>
    public class GoldengateDatabricksConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authentication type for Databricks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationType")]
        public virtual string AuthenticationType { get; set; }

        /// <summary>Optional. OAuth client id, only applicable for authentication_type == OAUTH_M2M</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Optional. OAuth client secret, only applicable for authentication_type == OAUTH_M2M</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>
        /// Optional. Connection URL. e.g.:
        /// 'jdbc:databricks://adb-33934.4.azuredatabricks.net:443/default;transportMode=http;ssl=1;httpPath=sql/protocolv1/o/3393########44/0##3-7-hlrb'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionUrl")]
        public virtual string ConnectionUrl { get; set; }

        /// <summary>Optional. Input only. The password used to connect to Databricks in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// used to connect to Databricks. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>
        /// Optional. External storage credential name to access files on object storage such as ADLS Gen2, S3 or Cloud
        /// Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageCredential")]
        public virtual string StorageCredential { get; set; }

        /// <summary>Optional. The technology type of DatabricksConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateDb2Connection.</summary>
    public class GoldengateDb2ConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An array of name-value pair attribute entries. Used as additional parameters in connection string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAttributes")]
        public virtual System.Collections.Generic.IList<NameValuePair> AdditionalAttributes { get; set; }

        /// <summary>Optional. The name of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Optional. The name or address of a host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses for Db2 connection in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses for Db2 connection. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The port of an endpoint usually specified for a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Optional. Security protocol for the DB2 database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>
        /// Optional. The keystash file which contains the encrypted password to the key database file. Not supported
        /// for IBM Db2 for i.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslClientKeystashFile")]
        public virtual string SslClientKeystashFile { get; set; }

        /// <summary>
        /// Optional. The keystore file created at the client containing the server certificate / CA root certificate.
        /// Not supported for IBM Db2 for i.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslClientKeystoredbFile")]
        public virtual string SslClientKeystoredbFile { get; set; }

        /// <summary>
        /// Optional. The file which contains the self-signed server certificate / Certificate Authority (CA)
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslServerCertificateFile")]
        public virtual string SslServerCertificateFile { get; set; }

        /// <summary>Optional. The technology type of Db2Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The username Oracle Goldengate uses to connect to the DB2 database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>GoldengateDeployment Goldengate Deployment resource model.</summary>
    public class GoldengateDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the GoldengateDeployment was created.</summary>
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

        /// <summary>Required. The display name for the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The ID of the subscription entitlement associated with the GoldengateDeployment
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>
        /// Optional. The GCP Oracle zone where Oracle GoldengateDeployment is hosted. Example: us-east4-b-r2. If not
        /// specified, the system will pick a zone based on availability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>Optional. The labels or tags associated with the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the GoldengateDeployment resource in the following format:
        /// projects/{project}/locations/{region}/goldengateDeployments/{goldengate_deployment}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. HTTPS link to OCI resources exposed to Customer via UI Interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUrl")]
        public virtual string OciUrl { get; set; }

        /// <summary>Optional. The name of the OdbNetwork associated with the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbNetwork")]
        public virtual string OdbNetwork { get; set; }

        /// <summary>
        /// Required. The name of the OdbSubnet associated with the GoldengateDeployment for IP allocation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbSubnet")]
        public virtual string OdbSubnet { get; set; }

        /// <summary>Required. The properties of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoldengateDeploymentProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the Goldengate Deployment Environment resource.</summary>
    public class GoldengateDeploymentEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether auto scaling is enabled by default for the Goldengate Deployment Environment resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoScalingEnabled")]
        public virtual System.Nullable<bool> AutoScalingEnabled { get; set; }

        /// <summary>Output only. The category of the Goldengate Deployment Environment resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Output only. The default CPU core count of the Goldengate Deployment Environment resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultCpuCoreCount")]
        public virtual System.Nullable<int> DefaultCpuCoreCount { get; set; }

        /// <summary>The display name of the Goldengate Deployment Environment resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. The environment type of the Goldengate Deployment Environment resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentType")]
        public virtual string EnvironmentType { get; set; }

        /// <summary>Output only. The max CPU core count of the Goldengate Deployment Environment resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxCpuCoreCount")]
        public virtual System.Nullable<int> MaxCpuCoreCount { get; set; }

        /// <summary>
        /// Output only. The memory per CPU core in GBs of the Goldengate Deployment Environment resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryGbPerCpuCore")]
        public virtual System.Nullable<int> MemoryGbPerCpuCore { get; set; }

        /// <summary>Output only. The min CPU core count of the Goldengate Deployment Environment resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minCpuCoreCount")]
        public virtual System.Nullable<int> MinCpuCoreCount { get; set; }

        /// <summary>
        /// Identifier. The name of the Goldengate Deployment Environment resource with the format:
        /// projects/{project}/locations/{location}/goldengateDeploymentEnvironments/{goldengate_deployment_environment}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The network bandwidth per CPU core in Gbps of the Goldengate Deployment Environment resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkBandwidthGbpsPerCpuCore")]
        public virtual System.Nullable<int> NetworkBandwidthGbpsPerCpuCore { get; set; }

        /// <summary>
        /// Output only. The storage usage limit per CPU core in GBs of the Goldengate Deployment Environment resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageUsageLimitGbPerCpuCore")]
        public virtual System.Nullable<int> StorageUsageLimitGbPerCpuCore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The lock of the GoldengateDeployment.</summary>
    public class GoldengateDeploymentLock : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The compartment id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compartmentId")]
        public virtual string CompartmentId { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time created.</summary>
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

        /// <summary>Output only. The message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Output only. The related resource id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedResourceId")]
        public virtual string RelatedResourceId { get; set; }

        /// <summary>Output only. The type of lock.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of GoldengateDeployment.</summary>
    public class GoldengateDeploymentProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The backup schedule of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupSchedule")]
        public virtual GoldengateBackupSchedule BackupSchedule { get; set; }

        /// <summary>Output only. The category of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Optional. The Minimum number of OCPUs to be made available for this Deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCoreCount")]
        public virtual System.Nullable<int> CpuCoreCount { get; set; }

        /// <summary>Output only. The deployment backup id of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentBackupId")]
        public virtual string DeploymentBackupId { get; set; }

        /// <summary>Output only. The deployment diagnostic data of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentDiagnosticData")]
        public virtual DeploymentDiagnosticData DeploymentDiagnosticData { get; set; }

        /// <summary>Output only. The deployment role of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentRole")]
        public virtual string DeploymentRole { get; set; }

        /// <summary>
        /// Required. A valid Goldengate Deployment type. For a list of supported types, use the
        /// `ListGoldengateDeploymentTypes` operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentType")]
        public virtual string DeploymentType { get; set; }

        /// <summary>Output only. The deployment url of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentUrl")]
        public virtual string DeploymentUrl { get; set; }

        /// <summary>Optional. The description of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. The environment type of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentType")]
        public virtual string EnvironmentType { get; set; }

        /// <summary>Output only. The Fully Qualified Domain Name of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fqdn")]
        public virtual string Fqdn { get; set; }

        /// <summary>Output only. Whether the GoldengateDeployment is healthy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthy")]
        public virtual System.Nullable<bool> Healthy { get; set; }

        /// <summary>Output only. The ingress ips of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressIps")]
        public virtual System.Collections.Generic.IList<IngressIp> IngressIps { get; set; }

        /// <summary>Optional. Indicates if auto scaling is enabled for the Deployment's CPU core count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAutoScalingEnabled")]
        public virtual System.Nullable<bool> IsAutoScalingEnabled { get; set; }

        /// <summary>Output only. Whether the GoldengateDeployment is of the latest version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isLatestVersion")]
        public virtual System.Nullable<bool> IsLatestVersion { get; set; }

        /// <summary>Output only. Whether the GoldengateDeployment is public.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPublic")]
        public virtual System.Nullable<bool> IsPublic { get; set; }

        /// <summary>Output only. Whether storage utilization limit is exceeded of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isStorageUtilizationLimitExceeded")]
        public virtual System.Nullable<bool> IsStorageUtilizationLimitExceeded { get; set; }

        private string _lastBackupScheduleTimeRaw;

        private object _lastBackupScheduleTime;

        /// <summary>Output only. The time last backup scheduled of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastBackupScheduleTime")]
        public virtual string LastBackupScheduleTimeRaw
        {
            get => _lastBackupScheduleTimeRaw;
            set
            {
                _lastBackupScheduleTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastBackupScheduleTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastBackupScheduleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastBackupScheduleTimeDateTimeOffset instead.")]
        public virtual object LastBackupScheduleTime
        {
            get => _lastBackupScheduleTime;
            set
            {
                _lastBackupScheduleTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastBackupScheduleTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastBackupScheduleTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastBackupScheduleTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastBackupScheduleTimeRaw);
            set => LastBackupScheduleTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. The Oracle license model that applies to a Deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseModel")]
        public virtual string LicenseModel { get; set; }

        /// <summary>Output only. The lifecycle details of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleDetails")]
        public virtual string LifecycleDetails { get; set; }

        /// <summary>Output only. State of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>Output only. The lifecycle sub-state of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleSubState")]
        public virtual string LifecycleSubState { get; set; }

        /// <summary>Output only. The load balancer id of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerId")]
        public virtual string LoadBalancerId { get; set; }

        /// <summary>Output only. The load balancer subnet id of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerSubnetId")]
        public virtual string LoadBalancerSubnetId { get; set; }

        /// <summary>Output only. The locks of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locks")]
        public virtual System.Collections.Generic.IList<GoldengateDeploymentLock> Locks { get; set; }

        /// <summary>Optional. The maintenance configuration of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceConfig")]
        public virtual GoldengateMaintenanceConfig MaintenanceConfig { get; set; }

        /// <summary>Optional. The maintenance window of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceWindow")]
        public virtual GoldengateMaintenanceWindow MaintenanceWindow { get; set; }

        private string _nextBackupScheduleTimeRaw;

        private object _nextBackupScheduleTime;

        /// <summary>Output only. The time next backup scheduled of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextBackupScheduleTime")]
        public virtual string NextBackupScheduleTimeRaw
        {
            get => _nextBackupScheduleTimeRaw;
            set
            {
                _nextBackupScheduleTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextBackupScheduleTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextBackupScheduleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextBackupScheduleTimeDateTimeOffset instead.")]
        public virtual object NextBackupScheduleTime
        {
            get => _nextBackupScheduleTime;
            set
            {
                _nextBackupScheduleTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextBackupScheduleTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextBackupScheduleTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextBackupScheduleTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextBackupScheduleTimeRaw);
            set => NextBackupScheduleTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The next maintenance action type of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextMaintenanceActionType")]
        public virtual string NextMaintenanceActionType { get; set; }

        /// <summary>Output only. The next maintenance description of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextMaintenanceDescription")]
        public virtual string NextMaintenanceDescription { get; set; }

        private string _nextMaintenanceTimeRaw;

        private object _nextMaintenanceTime;

        /// <summary>Output only. The time of next maintenance of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextMaintenanceTime")]
        public virtual string NextMaintenanceTimeRaw
        {
            get => _nextMaintenanceTimeRaw;
            set
            {
                _nextMaintenanceTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextMaintenanceTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextMaintenanceTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextMaintenanceTimeDateTimeOffset instead.")]
        public virtual object NextMaintenanceTime
        {
            get => _nextMaintenanceTime;
            set
            {
                _nextMaintenanceTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextMaintenanceTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextMaintenanceTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextMaintenanceTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextMaintenanceTimeRaw);
            set => NextMaintenanceTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The nsg ids of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nsgIds")]
        public virtual System.Collections.Generic.IList<string> NsgIds { get; set; }

        /// <summary>Output only. OCID of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Required. The ogg data of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oggData")]
        public virtual GoldengateOggDeployment OggData { get; set; }

        private string _oggVersionSupportEndTimeRaw;

        private object _oggVersionSupportEndTime;

        /// <summary>Output only. The time ogg version supported until of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oggVersionSupportEndTime")]
        public virtual string OggVersionSupportEndTimeRaw
        {
            get => _oggVersionSupportEndTimeRaw;
            set
            {
                _oggVersionSupportEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _oggVersionSupportEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OggVersionSupportEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OggVersionSupportEndTimeDateTimeOffset instead.")]
        public virtual object OggVersionSupportEndTime
        {
            get => _oggVersionSupportEndTime;
            set
            {
                _oggVersionSupportEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _oggVersionSupportEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OggVersionSupportEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OggVersionSupportEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OggVersionSupportEndTimeRaw);
            set => OggVersionSupportEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The placements of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placements")]
        public virtual System.Collections.Generic.IList<GoldengatePlacement> Placements { get; set; }

        /// <summary>Output only. The private ip address of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateIpAddress")]
        public virtual string PrivateIpAddress { get; set; }

        /// <summary>Output only. The public ip address of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicIpAddress")]
        public virtual string PublicIpAddress { get; set; }

        private string _roleChangeTimeRaw;

        private object _roleChangeTime;

        /// <summary>Output only. The time when the role of the GoldengateDeployment was changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleChangeTime")]
        public virtual string RoleChangeTimeRaw
        {
            get => _roleChangeTimeRaw;
            set
            {
                _roleChangeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _roleChangeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RoleChangeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RoleChangeTimeDateTimeOffset instead.")]
        public virtual object RoleChangeTime
        {
            get => _roleChangeTime;
            set
            {
                _roleChangeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _roleChangeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RoleChangeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RoleChangeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RoleChangeTimeRaw);
            set => RoleChangeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The storage utilization in bytes of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageUtilizationBytes")]
        public virtual System.Nullable<long> StorageUtilizationBytes { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the GoldengateDeployment was updated.</summary>
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

        private string _upgradeRequiredTimeRaw;

        private object _upgradeRequiredTime;

        /// <summary>Output only. The time upgrade required of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeRequiredTime")]
        public virtual string UpgradeRequiredTimeRaw
        {
            get => _upgradeRequiredTimeRaw;
            set
            {
                _upgradeRequiredTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _upgradeRequiredTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpgradeRequiredTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpgradeRequiredTimeDateTimeOffset instead.")]
        public virtual object UpgradeRequiredTime
        {
            get => _upgradeRequiredTime;
            set
            {
                _upgradeRequiredTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _upgradeRequiredTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="UpgradeRequiredTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpgradeRequiredTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpgradeRequiredTimeRaw);
            set => UpgradeRequiredTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the Goldengate Deployment Type resource.</summary>
    public class GoldengateDeploymentType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The category of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Output only. The connection types of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionTypes")]
        public virtual System.Collections.Generic.IList<string> ConnectionTypes { get; set; }

        /// <summary>Output only. The default username of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultUsername")]
        public virtual string DefaultUsername { get; set; }

        /// <summary>Output only. The deployment type of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentType")]
        public virtual string DeploymentType { get; set; }

        /// <summary>Output only. The display name of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The name of the Goldengate Deployment Type resource with the format:
        /// projects/{project}/locations/{region}/goldengateDeploymentTypes/{goldengate_deployment_type}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The Ogg version of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oggVersion")]
        public virtual string OggVersion { get; set; }

        /// <summary>Output only. The source technologies of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTechnologies")]
        public virtual System.Collections.Generic.IList<string> SourceTechnologies { get; set; }

        /// <summary>Output only. The supported capabilities of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedCapabilities")]
        public virtual System.Collections.Generic.IList<string> SupportedCapabilities { get; set; }

        /// <summary>Output only. The supported technologies URL of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedTechnologiesUrl")]
        public virtual string SupportedTechnologiesUrl { get; set; }

        /// <summary>Output only. The target technologies of the Goldengate Deployment Type resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetTechnologies")]
        public virtual System.Collections.Generic.IList<string> TargetTechnologies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the Goldengate Deployment Version resource.</summary>
    public class GoldengateDeploymentVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The name of the Goldengate Deployment Version resource with the format:
        /// projects/{project}/locations/{location}/goldengateDeploymentVersions/{goldengate_deployment_version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The deployment version ocid of the Goldengate Deployment Version resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Output only. The technology type of the Goldengate Deployment Version resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual GoldengateDeploymentVersionProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of GoldengateDeploymentVersion.</summary>
    public class GoldengateDeploymentVersionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The deployment type of the Goldengate Deployment Version resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentType")]
        public virtual string DeploymentType { get; set; }

        /// <summary>Output only. The OGG version of the Goldengate Deployment Version resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oggVersion")]
        public virtual string OggVersion { get; set; }

        private string _releaseTimeRaw;

        private object _releaseTime;

        /// <summary>Output only. The release time of the Goldengate Deployment Version resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseTime")]
        public virtual string ReleaseTimeRaw
        {
            get => _releaseTimeRaw;
            set
            {
                _releaseTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _releaseTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReleaseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReleaseTimeDateTimeOffset instead.")]
        public virtual object ReleaseTime
        {
            get => _releaseTime;
            set
            {
                _releaseTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _releaseTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReleaseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReleaseTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReleaseTimeRaw);
            set => ReleaseTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The release type of the Goldengate Deployment Version resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseType")]
        public virtual string ReleaseType { get; set; }

        /// <summary>Optional. Whether the Goldengate Deployment Version resource is a security fix.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityFix")]
        public virtual System.Nullable<bool> SecurityFix { get; set; }

        private string _supportEndTimeRaw;

        private object _supportEndTime;

        /// <summary>Output only. The support end time of the Goldengate Deployment Version resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportEndTime")]
        public virtual string SupportEndTimeRaw
        {
            get => _supportEndTimeRaw;
            set
            {
                _supportEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _supportEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SupportEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SupportEndTimeDateTimeOffset instead.")]
        public virtual object SupportEndTime
        {
            get => _supportEndTime;
            set
            {
                _supportEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _supportEndTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SupportEndTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SupportEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SupportEndTimeRaw);
            set => SupportEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateElasticsearchConnection.</summary>
    public class GoldengateElasticsearchConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authentication type for Elasticsearch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationType")]
        public virtual string AuthenticationType { get; set; }

        /// <summary>
        /// Optional. Fingerprint required by TLS security protocol. Eg.:
        /// '6152b2dfbff200f973c5074a5b91d06ab3b472c07c09a1ea57bb7fd406cdce9c'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses for Elastic Search connection in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses for Elastic Search connection. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. Security protocol for Elasticsearch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>
        /// Optional. Comma separated list of Elasticsearch server addresses, specified as host:port entries, where
        /// :port is optional. If port is not specified, it defaults to 9200. Example:
        /// "server1.example.com:4000,server2.example.com:4000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servers")]
        public virtual string Servers { get; set; }

        /// <summary>Optional. The technology type of ElasticsearchConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>
        /// Optional. The username Oracle Goldengate uses to connect the associated system of the given technology.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateGenericConnectionProperties.</summary>
    public class GoldengateGenericConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The host of the GenericConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>Optional. The technology type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateGoldengateConnectionProperties.</summary>
    public class GoldengateGoldengateConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The name of the GoldengateDeployment associated with the GoldengateConnection. Format:
        /// projects/{project}/locations/{location}/goldengateDeployments/{goldengate_deployment}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateDeploymentId")]
        public virtual string GoldengateDeploymentId { get; set; }

        /// <summary>Optional. The host of the GoldengateConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Optional. Input only. The password used to connect to the Oracle Goldengate in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// used to connect to the Oracle Goldengate. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The port of the GoldengateConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Optional. The technology type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The username credential.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateGoogleBigQueryConnectionProperties.</summary>
    public class GoldengateGoogleBigQueryConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The service account key file Cloud Storage containing the credentials required to use Google
        /// BigQuery.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyFile")]
        public virtual string ServiceAccountKeyFile { get; set; }

        /// <summary>Optional. The technology type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateGoogleCloudStorageConnectionProperties.</summary>
    public class GoldengateGoogleCloudStorageConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The service account key Cloud Storage file containing the credentials required to use Google Cloud
        /// Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyFile")]
        public virtual string ServiceAccountKeyFile { get; set; }

        /// <summary>Optional. The technology type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateGooglePubsubConnection.</summary>
    public class GoldengateGooglePubsubConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The content of the service account key file containing the credentials required to use Google
        /// Pub/Sub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyFile")]
        public virtual string ServiceAccountKeyFile { get; set; }

        /// <summary>Optional. The technology type of GooglePubsubConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The group to roles mapping of the GoldengateDeployment.</summary>
    public class GoldengateGroupToRolesMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The administrator group id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administratorGroupId")]
        public virtual string AdministratorGroupId { get; set; }

        /// <summary>Output only. The operator group id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatorGroupId")]
        public virtual string OperatorGroupId { get; set; }

        /// <summary>Output only. The security group id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityGroupId")]
        public virtual string SecurityGroupId { get; set; }

        /// <summary>Output only. The user group id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userGroupId")]
        public virtual string UserGroupId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateHdfsConnection.</summary>
    public class GoldengateHdfsConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The content of the Hadoop Distributed File System configuration file (core-site.xml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coreSiteXml")]
        public virtual string CoreSiteXml { get; set; }

        /// <summary>Optional. The technology type of HdfsConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateIcebergConnection.</summary>
    public class GoldengateIcebergConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Iceberg catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalog")]
        public virtual IcebergCatalog Catalog { get; set; }

        /// <summary>Required. The Iceberg storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storage")]
        public virtual IcebergStorage Storage { get; set; }

        /// <summary>Required. The technology type of Iceberg connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateJavaMessageServiceConnection.</summary>
    public class GoldengateJavaMessageServiceConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authentication type for Java Message Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationType")]
        public virtual string AuthenticationType { get; set; }

        /// <summary>
        /// Optional. The Java class implementing javax.jms.ConnectionFactory interface supplied by the JMS provider.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionFactory")]
        public virtual string ConnectionFactory { get; set; }

        /// <summary>
        /// Optional. Connection URL of the Java Message Service, specifying the protocol, host, and port. e.g.:
        /// 'mq://myjms.host.domain:7676'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionUrl")]
        public virtual string ConnectionUrl { get; set; }

        /// <summary>
        /// Optional. The Connection Factory can be looked up using this name. e.g.: 'ConnectionFactory'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jndiConnectionFactory")]
        public virtual string JndiConnectionFactory { get; set; }

        /// <summary>
        /// Optional. The implementation of javax.naming.spi.InitialContextFactory interface used to obtain initial
        /// naming context.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jndiInitialContextFactory")]
        public virtual string JndiInitialContextFactory { get; set; }

        /// <summary>
        /// Optional. The URL that Java Message Service will use to contact the JNDI provider. e.g.:
        /// 'tcp://myjms.host.domain:61616?jms.prefetchPolicy.all=1000'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jndiProviderUrl")]
        public virtual string JndiProviderUrl { get; set; }

        /// <summary>Optional. The password associated to the principal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jndiSecurityCredentialsSecret")]
        public virtual string JndiSecurityCredentialsSecret { get; set; }

        /// <summary>Optional. Specifies the identity of the principal (user) to be authenticated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jndiSecurityPrincipal")]
        public virtual string JndiSecurityPrincipal { get; set; }

        /// <summary>Optional. The content of the KeyStore file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStoreFile")]
        public virtual string KeyStoreFile { get; set; }

        /// <summary>Optional. Input only. The KeyStore password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStorePassword")]
        public virtual string KeyStorePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the KeyStore
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStorePasswordSecretVersion")]
        public virtual string KeyStorePasswordSecretVersion { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses to connect the Java Message Service in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses to connect the associated Java Message Service. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. Security protocol for Java Message Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>Optional. Input only. The password for the cert inside of the KeyStore in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslKeyPassword")]
        public virtual string SslKeyPassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// for the cert inside of the KeyStore. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslKeyPasswordSecretVersion")]
        public virtual string SslKeyPasswordSecretVersion { get; set; }

        /// <summary>Optional. The technology type of JavaMessageServiceConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The content of the TrustStore file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStoreFile")]
        public virtual string TrustStoreFile { get; set; }

        /// <summary>Optional. Input only. The TrustStore password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStorePassword")]
        public virtual string TrustStorePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the TrustStore
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStorePasswordSecretVersion")]
        public virtual string TrustStorePasswordSecretVersion { get; set; }

        /// <summary>
        /// Optional. If set to true, Java Naming and Directory Interface (JNDI) properties should be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useJndi")]
        public virtual System.Nullable<bool> UseJndi { get; set; }

        /// <summary>Optional. The username Oracle Goldengate uses to connect to the Java Message Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateKafkaConnection.</summary>
    public class GoldengateKafkaConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Kafka bootstrap. Equivalent of bootstrap.servers configuration property in Kafka: list of
        /// KafkaBootstrapServer objects specified by host/port. Used for establishing the initial connection to the
        /// Kafka cluster. Example: "server1.example.com:9092,server2.example.com:9092"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootstrapServers")]
        public virtual System.Collections.Generic.IList<KafkaBootstrapServer> BootstrapServers { get; set; }

        /// <summary>
        /// Optional. The OCID of the Kafka cluster being referenced from OCI Streaming with Apache Kafka.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterId")]
        public virtual string ClusterId { get; set; }

        /// <summary>Optional. The content of the consumer.properties file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerPropertiesFile")]
        public virtual string ConsumerPropertiesFile { get; set; }

        /// <summary>Optional. The content of the KeyStore file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStoreFile")]
        public virtual string KeyStoreFile { get; set; }

        /// <summary>Optional. Input only. The KeyStore password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStorePassword")]
        public virtual string KeyStorePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the KeyStore
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStorePasswordSecretVersion")]
        public virtual string KeyStorePasswordSecretVersion { get; set; }

        /// <summary>Optional. Input only. The password for Kafka basic/SASL auth in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// for Kafka basic/SASL auth. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The content of the producer.properties file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerPropertiesFile")]
        public virtual string ProducerPropertiesFile { get; set; }

        /// <summary>Optional. Security Type for Kafka.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>Optional. Input only. The password for the cert inside of the KeyStore in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslKeyPassword")]
        public virtual string SslKeyPassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// for the cert inside of the KeyStore. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslKeyPasswordSecretVersion")]
        public virtual string SslKeyPasswordSecretVersion { get; set; }

        /// <summary>Optional. The OCID of the stream pool being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamPoolId")]
        public virtual string StreamPoolId { get; set; }

        /// <summary>Optional. The technology type of KafkaConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The content of the TrustStore file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStoreFile")]
        public virtual string TrustStoreFile { get; set; }

        /// <summary>Optional. Input only. The TrustStore password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStorePassword")]
        public virtual string TrustStorePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the TrustStore
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStorePasswordSecretVersion")]
        public virtual string TrustStorePasswordSecretVersion { get; set; }

        /// <summary>
        /// Optional. Specifies that the user intends to authenticate to the instance using a resource principal.
        /// Applicable only for OCI Streaming connections.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useResourcePrincipal")]
        public virtual System.Nullable<bool> UseResourcePrincipal { get; set; }

        /// <summary>
        /// Optional. The username Oracle Goldengate uses to connect the associated system of the given technology.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateKafkaSchemaRegistryConnection.</summary>
    public class GoldengateKafkaSchemaRegistryConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Used authentication mechanism to access Schema Registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationType")]
        public virtual string AuthenticationType { get; set; }

        /// <summary>Optional. The content of the KeyStore file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStoreFile")]
        public virtual string KeyStoreFile { get; set; }

        /// <summary>Optional. Input only. The KeyStore password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStorePassword")]
        public virtual string KeyStorePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the KeyStore
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStorePasswordSecretVersion")]
        public virtual string KeyStorePasswordSecretVersion { get; set; }

        /// <summary>Optional. Input only. The password to access Schema Registry in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password to
        /// access Schema Registry using basic authentication. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. Input only. The password for the cert inside the KeyStore in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslKeyPassword")]
        public virtual string SslKeyPassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// for the cert inside the KeyStore. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslKeyPasswordSecretVersion")]
        public virtual string SslKeyPasswordSecretVersion { get; set; }

        /// <summary>Optional. The technology type of KafkaSchemaRegistryConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The content of the TrustStore file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStoreFile")]
        public virtual string TrustStoreFile { get; set; }

        /// <summary>Optional. Input only. The TrustStore password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStorePassword")]
        public virtual string TrustStorePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the TrustStore
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStorePasswordSecretVersion")]
        public virtual string TrustStorePasswordSecretVersion { get; set; }

        /// <summary>Optional. Kafka Schema Registry URL. e.g.: 'https://server1.us.oracle.com:8081'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>
        /// Optional. The username to access Schema Registry using basic authentication. This value is injected into
        /// 'schema.registry.basic.auth.user.info=user:password' configuration property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The maintenance configuration of the GoldengateDeployment.</summary>
    public class GoldengateMaintenanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Defines auto upgrade period for bundle releases. Manually configured period cannot be longer than
        /// service defined period for bundle releases. This period must be shorter or equal to major release upgrade
        /// period. Not passing this field during create will equate to using the service default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleReleaseUpgradePeriodDays")]
        public virtual System.Nullable<int> BundleReleaseUpgradePeriodDays { get; set; }

        /// <summary>
        /// Optional. Defines auto upgrade period for interim releases. This period must be shorter or equal to bundle
        /// release upgrade period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interimReleaseUpgradePeriodDays")]
        public virtual System.Nullable<int> InterimReleaseUpgradePeriodDays { get; set; }

        /// <summary>
        /// Optional. By default auto upgrade for interim releases are not enabled. If auto-upgrade is enabled for
        /// interim release, you have to specify interim_release_upgrade_period_days too.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInterimReleaseAutoUpgradeEnabled")]
        public virtual System.Nullable<bool> IsInterimReleaseAutoUpgradeEnabled { get; set; }

        /// <summary>
        /// Optional. Defines auto upgrade period for major releases. Manually configured period cannot be longer than
        /// service defined period for major releases. Not passing this field during create will equate to using the
        /// service default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("majorReleaseUpgradePeriodDays")]
        public virtual System.Nullable<int> MajorReleaseUpgradePeriodDays { get; set; }

        /// <summary>
        /// Optional. Defines auto upgrade period for releases with security fix. Manually configured period cannot be
        /// longer than service defined period for security releases. Not passing this field during create will equate
        /// to using the service default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPatchUpgradePeriodDays")]
        public virtual System.Nullable<int> SecurityPatchUpgradePeriodDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The maintenance window of the GoldengateDeployment.</summary>
    public class GoldengateMaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Days of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>Required. Start hour for maintenance period. Hour is in UTC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startHour")]
        public virtual System.Nullable<int> StartHour { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateMicrosoftFabricConnection.</summary>
    public class GoldengateMicrosoftFabricConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Azure client ID of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Optional. Client secret associated with the client id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>
        /// Optional. Optional Microsoft Fabric service endpoint. Default value:
        /// https://onelake.dfs.fabric.microsoft.com
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoint")]
        public virtual string Endpoint { get; set; }

        /// <summary>Optional. The technology type of MicrosoftFabricConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. Azure tenant ID of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantId")]
        public virtual string TenantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateMicrosoftSqlserverConnection.</summary>
    public class GoldengateMicrosoftSqlserverConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An array of name-value pair attribute entries. Used as additional parameters in connection string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAttributes")]
        public virtual System.Collections.Generic.IList<NameValuePair> AdditionalAttributes { get; set; }

        /// <summary>Optional. The name of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Optional. The name or address of a host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses for Microsoft SQL Server connection in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses for Microsoft SQL Server connection. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The port of an endpoint usually specified for a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Optional. Security Type for Microsoft SQL Server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>
        /// Optional. If set to true, the driver validates the certificate that is sent by the database server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCertificateValidationRequired")]
        public virtual System.Nullable<bool> ServerCertificateValidationRequired { get; set; }

        /// <summary>
        /// Optional. Database Certificate - The content of a .pem or .crt file containing the server public key (for
        /// 1-way SSL).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCaFile")]
        public virtual string SslCaFile { get; set; }

        /// <summary>Optional. The technology type of MicrosoftSqlserverConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The username Oracle Goldengate uses to connect to the Microsoft SQL Server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateMongodbConnection.</summary>
    public class GoldengateMongodbConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. MongoDB connection string. e.g.: 'mongodb://mongodb0.example.com:27017/recordsrecords'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionString")]
        public virtual string ConnectionString { get; set; }

        /// <summary>Optional. The OCID of the Oracle Autonomous Json Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseId")]
        public virtual string DatabaseId { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses to connect the Mongodb connection in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses to connect the Mongodb connection. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. Security Type for MongoDB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>Optional. The technology type of MongodbConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>
        /// Optional. Database Certificate - The content of a .pem file, containing the server public key (for 1 and
        /// 2-way SSL).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsCaFile")]
        public virtual string TlsCaFile { get; set; }

        /// <summary>
        /// Optional. Client Certificate - The content of a .pem file, containing the client public key (for 2-way SSL).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsCertificateKeyFile")]
        public virtual string TlsCertificateKeyFile { get; set; }

        /// <summary>Optional. Input only. The Client Certificate key file password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsCertificateKeyFilePassword")]
        public virtual string TlsCertificateKeyFilePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the Client
        /// Certificate key file password in Secret Manager. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tlsCertificateKeyFilePasswordSecretVersion")]
        public virtual string TlsCertificateKeyFilePasswordSecretVersion { get; set; }

        /// <summary>Optional. The username Oracle Goldengate uses to connect to the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of GoldengateMysqlConnection.</summary>
    public class GoldengateMysqlConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An array of name-value pair attribute entries. Used as additional parameters in connection string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAttributes")]
        public virtual System.Collections.Generic.IList<NameValuePair> AdditionalAttributes { get; set; }

        /// <summary>Optional. The name of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Optional. The OCID of the database system being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbSystemId")]
        public virtual string DbSystemId { get; set; }

        /// <summary>Optional. The name or address of a host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses to connect to MySQL in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses to connect to MySQL. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The port of an endpoint usually specified for a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Optional. Security Type for MySQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>
        /// Optional. Database Certificate - The content of a .pem or .crt file containing the server public key (for 1
        /// and 2-way SSL).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCaFile")]
        public virtual string SslCaFile { get; set; }

        /// <summary>
        /// Optional. Client Certificate - The content of a .pem or .crt file containing the client public key (for
        /// 2-way SSL).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCertFile")]
        public virtual string SslCertFile { get; set; }

        /// <summary>
        /// Optional. The list of certificates revoked by the trusted certificate authorities (Trusted CA).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCrlFile")]
        public virtual string SslCrlFile { get; set; }

        /// <summary>
        /// Optional. Client Key - The content of a .pem or .crt file containing the client private key (for 2-way SSL).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslKeyFile")]
        public virtual string SslKeyFile { get; set; }

        /// <summary>Optional. SSL modes for MySQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslMode")]
        public virtual string SslMode { get; set; }

        /// <summary>Optional. The technology type of MysqlConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>
        /// Optional. The username Oracle Goldengate uses to connect the associated system of the given technology.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateOciObjectStorageConnection.</summary>
    public class GoldengateOciObjectStorageConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The content of the private key file (PEM file) corresponding to the API key of the fingerprint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyFile")]
        public virtual string PrivateKeyFile { get; set; }

        /// <summary>Optional. The passphrase of the private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyPassphraseSecret")]
        public virtual string PrivateKeyPassphraseSecret { get; set; }

        /// <summary>Optional. The fingerprint of the API Key of the user specified by the userId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyFingerprint")]
        public virtual string PublicKeyFingerprint { get; set; }

        /// <summary>
        /// Optional. The name of the region of OCI Object Storage. e.g.: us-ashburn-1 If the region is not provided,
        /// backend will default to the default region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Optional. The technology type of OciObjectStorageConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The OCID of the related OCI tenancy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenancyId")]
        public virtual string TenancyId { get; set; }

        /// <summary>
        /// Optional. Specifies that the user intends to authenticate to the instance using a resource principal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useResourcePrincipal")]
        public virtual System.Nullable<bool> UseResourcePrincipal { get; set; }

        /// <summary>
        /// Optional. The OCID of the OCI user who will access the Object Storage. The user must have write access to
        /// the bucket they want to connect to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Ogg data of the GoldengateDeployment.</summary>
    public class GoldengateOggDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The Goldengate deployment console password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminPassword")]
        public virtual string AdminPassword { get; set; }

        /// <summary>Optional. Input only. The Goldengate deployment console password secret version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminPasswordSecretVersion")]
        public virtual string AdminPasswordSecretVersion { get; set; }

        /// <summary>Required. The Goldengate deployment console username.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminUsername")]
        public virtual string AdminUsername { get; set; }

        /// <summary>Output only. The certificate of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificate")]
        public virtual string Certificate { get; set; }

        /// <summary>Output only. The credential store of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentialStore")]
        public virtual string CredentialStore { get; set; }

        /// <summary>
        /// Required. The name given to the Goldengate service deployment. The name must be 1 to 32 characters long,
        /// must contain only alphanumeric characters and must start with a letter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual string Deployment { get; set; }

        /// <summary>Output only. The group to roles mapping of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupRolesMapping")]
        public virtual GoldengateGroupToRolesMapping GroupRolesMapping { get; set; }

        /// <summary>Output only. The identity domain id of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityDomainId")]
        public virtual string IdentityDomainId { get; set; }

        /// <summary>Optional. Version of OGG</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oggVersion")]
        public virtual string OggVersion { get; set; }

        /// <summary>Output only. The password secret id of the GoldengateDeployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretId")]
        public virtual string PasswordSecretId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateOracleAIDataPlatformConnection.</summary>
    public class GoldengateOracleAIDataPlatformConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Connection URL. It must start with 'jdbc:spark://'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionUrl")]
        public virtual string ConnectionUrl { get; set; }

        /// <summary>
        /// Optional. The content of the private key file (PEM file) corresponding to the API key of the fingerprint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyFile")]
        public virtual string PrivateKeyFile { get; set; }

        /// <summary>Optional. The passphrase of the private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyPassphraseSecret")]
        public virtual string PrivateKeyPassphraseSecret { get; set; }

        /// <summary>Optional. The fingerprint of the API Key of the user specified by the user_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyFingerprint")]
        public virtual string PublicKeyFingerprint { get; set; }

        /// <summary>Optional. The name of the region. e.g.: us-ashburn-1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Optional. The technology type of OracleAiDataPlatformConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The OCID of the related OCI tenancy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenancyId")]
        public virtual string TenancyId { get; set; }

        /// <summary>
        /// Optional. Specifies that the user intends to authenticate to the instance using a resource principal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useResourcePrincipal")]
        public virtual System.Nullable<bool> UseResourcePrincipal { get; set; }

        /// <summary>Optional. The OCID of the OCI user who will access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of Goldengate Oracle Database Connection.</summary>
    public class GoldengateOracleConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authentication mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationMode")]
        public virtual string AuthenticationMode { get; set; }

        /// <summary>Optional. Connect descriptor or Easy Connect Naming method used to connect to a database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionString")]
        public virtual string ConnectionString { get; set; }

        /// <summary>
        /// Optional. Database instance id of database in Oracle Database @ Google Cloud. If gcp_oracle_database_id is
        /// provided, connection_string must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleDatabaseId")]
        public virtual string GcpOracleDatabaseId { get; set; }

        /// <summary>Optional. Input only. The password Oracle Goldengate uses in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>
        /// Optional. The mode of the database connection session to be established by the data client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionMode")]
        public virtual string SessionMode { get; set; }

        /// <summary>Optional. The technology type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The username Oracle Goldengate uses to connect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>Optional. The wallet contents Oracle Goldengate uses to make connections to a database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("walletFile")]
        public virtual string WalletFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateOracleNosqlConnection.</summary>
    public class GoldengateOracleNosqlConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The content of the private key file (PEM file) corresponding to the API key of the fingerprint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyFile")]
        public virtual string PrivateKeyFile { get; set; }

        /// <summary>Optional. The passphrase of the private key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyPassphraseSecret")]
        public virtual string PrivateKeyPassphraseSecret { get; set; }

        /// <summary>Optional. The fingerprint of the API Key of the user specified by the userId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyFingerprint")]
        public virtual string PublicKeyFingerprint { get; set; }

        /// <summary>Optional. The name of the region. e.g.: us-ashburn-1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>Optional. The technology type of OracleNosqlConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The OCID of the OCI tenancy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenancyId")]
        public virtual string TenancyId { get; set; }

        /// <summary>
        /// Optional. Specifies that the user intends to authenticate to the instance using a resource principal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useResourcePrincipal")]
        public virtual System.Nullable<bool> UseResourcePrincipal { get; set; }

        /// <summary>Optional. The OCID of the OCI user who will access the Oracle NoSQL database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The placement of the GoldengateDeployment.</summary>
    public class GoldengatePlacement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The availability domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityDomain")]
        public virtual string AvailabilityDomain { get; set; }

        /// <summary>Output only. The fault domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faultDomain")]
        public virtual string FaultDomain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengatePostgresqlConnection.</summary>
    public class GoldengatePostgresqlConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An array of name-value pair attribute entries. Used as additional parameters in connection string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAttributes")]
        public virtual System.Collections.Generic.IList<NameValuePair> AdditionalAttributes { get; set; }

        /// <summary>Optional. The name of the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Optional. The OCID of the database system being referenced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbSystemId")]
        public virtual string DbSystemId { get; set; }

        /// <summary>Optional. The name or address of a host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses for PostgreSQL connection in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses for PostgreSQL connection. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The port of an endpoint usually specified for a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>Optional. Security protocol for PostgreSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>
        /// Optional. The certificate of the trusted certificate authorities (Trusted CA) for PostgreSQL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCaFile")]
        public virtual string SslCaFile { get; set; }

        /// <summary>Optional. The certificate of the PostgreSQL server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCertFile")]
        public virtual string SslCertFile { get; set; }

        /// <summary>
        /// Optional. The list of certificates revoked by the trusted certificate authorities (Trusted CA).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCrlFile")]
        public virtual string SslCrlFile { get; set; }

        /// <summary>Optional. The private key of the PostgreSQL server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslKeyFile")]
        public virtual string SslKeyFile { get; set; }

        /// <summary>Optional. SSL modes for PostgreSQL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslMode")]
        public virtual string SslMode { get; set; }

        /// <summary>Optional. The technology type of PostgresqlConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>
        /// Optional. The username Oracle Goldengate uses to connect the associated system of the given technology.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateRedisConnection.</summary>
    public class GoldengateRedisConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Authentication type for Redis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationType")]
        public virtual string AuthenticationType { get; set; }

        /// <summary>Optional. The content of the KeyStore file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStoreFile")]
        public virtual string KeyStoreFile { get; set; }

        /// <summary>Optional. Input only. The KeyStore password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStorePassword")]
        public virtual string KeyStorePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the KeyStore
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyStorePasswordSecretVersion")]
        public virtual string KeyStorePasswordSecretVersion { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses for Redis connection in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses for Redis connection. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The OCID of the Redis cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisClusterId")]
        public virtual string RedisClusterId { get; set; }

        /// <summary>Optional. Security protocol for Redis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProtocol")]
        public virtual string SecurityProtocol { get; set; }

        /// <summary>
        /// Optional. Comma separated list of Redis server addresses, specified as host:port entries, where :port is
        /// optional. If port is not specified, it defaults to 6379. Example:
        /// "server1.example.com:6379,server2.example.com:6379"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servers")]
        public virtual string Servers { get; set; }

        /// <summary>Optional. The technology type of RedisConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The content of the TrustStore file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStoreFile")]
        public virtual string TrustStoreFile { get; set; }

        /// <summary>Optional. Input only. The TrustStore password in plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStorePassword")]
        public virtual string TrustStorePassword { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the TrustStore
        /// password. Format: projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trustStorePasswordSecretVersion")]
        public virtual string TrustStorePasswordSecretVersion { get; set; }

        /// <summary>
        /// Optional. The username Oracle Goldengate uses to connect the associated system of the given technology.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of GoldengateSnowflakeConnection.</summary>
    public class GoldengateSnowflakeConnectionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Used authentication mechanism to access Snowflake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationType")]
        public virtual string AuthenticationType { get; set; }

        /// <summary>
        /// Optional. JDBC connection URL. e.g.: 'jdbc:snowflake://.snowflakecomputing.com/?warehouse=&amp;amp;db='
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionUrl")]
        public virtual string ConnectionUrl { get; set; }

        /// <summary>
        /// Optional. Input only. The password Oracle Goldengate uses to connect to Snowflake platform in plain text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>
        /// Optional. Input only. The resource name of a secret version in Secret Manager which contains the password
        /// Oracle Goldengate uses to connect to Snowflake platform. Format:
        /// projects/{project}/secrets/{secret}/versions/{version}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordSecretVersion")]
        public virtual string PasswordSecretVersion { get; set; }

        /// <summary>Optional. The content of private key file in PEM format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyFile")]
        public virtual string PrivateKeyFile { get; set; }

        /// <summary>Optional. Password if the private key file is encrypted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeyPassphraseSecret")]
        public virtual string PrivateKeyPassphraseSecret { get; set; }

        /// <summary>Optional. The technology type of SnowflakeConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyType")]
        public virtual string TechnologyType { get; set; }

        /// <summary>Optional. The username Oracle Goldengate uses to connect to Snowflake.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Google Cloud Storage Iceberg storage.</summary>
    public class GoogleCloudStorageIcebergStorage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The bucket of Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>Required. The project ID of Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Optional. The service account key file of Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyFile")]
        public virtual string ServiceAccountKeyFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Iceberg catalog details.</summary>
    public class IcebergCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of Iceberg catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogType")]
        public virtual string CatalogType { get; set; }

        /// <summary>The Glue Iceberg catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glueIcebergCatalog")]
        public virtual GlueIcebergCatalog GlueIcebergCatalog { get; set; }

        /// <summary>The Nessie Iceberg catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nessieIcebergCatalog")]
        public virtual NessieIcebergCatalog NessieIcebergCatalog { get; set; }

        /// <summary>The Polaris Iceberg catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("polarisIcebergCatalog")]
        public virtual PolarisIcebergCatalog PolarisIcebergCatalog { get; set; }

        /// <summary>The REST Iceberg catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restIcebergCatalog")]
        public virtual RestIcebergCatalog RestIcebergCatalog { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Iceberg storage details.</summary>
    public class IcebergStorage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Amazon S3 Iceberg storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amazonS3IcebergStorage")]
        public virtual AmazonS3IcebergStorage AmazonS3IcebergStorage { get; set; }

        /// <summary>The Azure Data Lake Storage Iceberg storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureDataLakeStorageIcebergStorage")]
        public virtual AzureDataLakeStorageIcebergStorage AzureDataLakeStorageIcebergStorage { get; set; }

        /// <summary>The Google Cloud Storage Iceberg storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudStorageIcebergStorage")]
        public virtual GoogleCloudStorageIcebergStorage GoogleCloudStorageIcebergStorage { get; set; }

        /// <summary>Required. The type of Iceberg storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageType")]
        public virtual string StorageType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The identity connector details which will allow OCI to securely access the resources in the customer project.
    /// </summary>
    public class IdentityConnector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The connection state of the identity connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionState")]
        public virtual string ConnectionState { get; set; }

        /// <summary>
        /// Output only. A google managed service account on which customers can grant roles to access resources in the
        /// customer project. Example: `p176944527254-55-75119d87fd8f@gcp-sa-oci.iam.gserviceaccount.com`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAgentEmail")]
        public virtual string ServiceAgentEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ingress IPs of the GoldengateDeployment.</summary>
    public class IngressIp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ingress IP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressIpAddress")]
        public virtual string IngressIpAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Kafka bootstrap server with host name, optional port defaults to 9092, and an optional private ip.
    /// </summary>
    public class KafkaBootstrapServer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name or address of a host.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>Optional. The port of an endpoint usually specified for a connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// Optional. The private IP address of the connection's endpoint in the customer's VCN, typically a database
        /// endpoint or a big data endpoint (e.g. Kafka bootstrap server). In case the privateIp is provided, the
        /// subnetId must also be provided. In case the privateIp (and the subnetId) is not provided it is assumed the
        /// datasource is publicly accessible. In case the connection is accessible only privately, the lack of
        /// privateIp will result in not being able to access the connection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateIpAddress")]
        public virtual string PrivateIpAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `AutonomousDatabaseBackup.List`.</summary>
    public class ListAutonomousDatabaseBackupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Autonomous Database Backups.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autonomousDatabaseBackups")]
        public virtual System.Collections.Generic.IList<AutonomousDatabaseBackup> AutonomousDatabaseBackups { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `AutonomousDatabaseCharacterSet.List`.</summary>
    public class ListAutonomousDatabaseCharacterSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Autonomous Database Character Sets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autonomousDatabaseCharacterSets")]
        public virtual System.Collections.Generic.IList<AutonomousDatabaseCharacterSet> AutonomousDatabaseCharacterSets { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `AutonomousDatabase.List`.</summary>
    public class ListAutonomousDatabasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Autonomous Databases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autonomousDatabases")]
        public virtual System.Collections.Generic.IList<AutonomousDatabase> AutonomousDatabases { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `AutonomousDbVersion.List`.</summary>
    public class ListAutonomousDbVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Autonomous Database versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autonomousDbVersions")]
        public virtual System.Collections.Generic.IList<AutonomousDbVersion> AutonomousDbVersions { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `CloudExadataInfrastructures.list`.</summary>
    public class ListCloudExadataInfrastructuresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Exadata Infrastructures.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudExadataInfrastructures")]
        public virtual System.Collections.Generic.IList<CloudExadataInfrastructure> CloudExadataInfrastructures { get; set; }

        /// <summary>A token for fetching next page of response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `CloudVmCluster.List`.</summary>
    public class ListCloudVmClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of VM Clusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudVmClusters")]
        public virtual System.Collections.Generic.IList<CloudVmCluster> CloudVmClusters { get; set; }

        /// <summary>A token to fetch the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `DatabaseCharacterSet.List`.</summary>
    public class ListDatabaseCharacterSetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of DatabaseCharacterSets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseCharacterSets")]
        public virtual System.Collections.Generic.IList<DatabaseCharacterSet> DatabaseCharacterSets { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `Database.List`.</summary>
    public class ListDatabasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Databases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databases")]
        public virtual System.Collections.Generic.IList<Database> Databases { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `DbNode.List`.</summary>
    public class ListDbNodesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of DB Nodes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbNodes")]
        public virtual System.Collections.Generic.IList<DbNode> DbNodes { get; set; }

        /// <summary>A token identifying a page of results the node should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `DbServer.List`.</summary>
    public class ListDbServersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of database servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbServers")]
        public virtual System.Collections.Generic.IList<DbServer> DbServers { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `DbSystemInitialStorageSizes.List`.</summary>
    public class ListDbSystemInitialStorageSizesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of DbSystemInitialStorageSizes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbSystemInitialStorageSizes")]
        public virtual System.Collections.Generic.IList<DbSystemInitialStorageSize> DbSystemInitialStorageSizes { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `DbSystemShape.List`.</summary>
    public class ListDbSystemShapesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Database System shapes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbSystemShapes")]
        public virtual System.Collections.Generic.IList<DbSystemShape> DbSystemShapes { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `DbSystem.List`.</summary>
    public class ListDbSystemsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of DbSystems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbSystems")]
        public virtual System.Collections.Generic.IList<DbSystem> DbSystems { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `DbVersions.List`.</summary>
    public class ListDbVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of DbVersions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbVersions")]
        public virtual System.Collections.Generic.IList<DbVersion> DbVersions { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `Entitlement.List`.</summary>
    public class ListEntitlementsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Entitlements</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlements")]
        public virtual System.Collections.Generic.IList<Entitlement> Entitlements { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `ExadbVmCluster.List`.</summary>
    public class ListExadbVmClustersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of ExadbVmClusters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exadbVmClusters")]
        public virtual System.Collections.Generic.IList<ExadbVmCluster> ExadbVmClusters { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `ExascaleDbStorageVault.List`.</summary>
    public class ListExascaleDbStorageVaultsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ExascaleDbStorageVaults.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exascaleDbStorageVaults")]
        public virtual System.Collections.Generic.IList<ExascaleDbStorageVault> ExascaleDbStorageVaults { get; set; }

        /// <summary>
        /// A token identifying a page of results the server should return. If present, the next page token can be
        /// provided to a subsequent ListExascaleDbStorageVaults call to list the next page. If empty, there are no more
        /// pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `GiVersion.List`.</summary>
    public class ListGiVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Oracle Grid Infrastructure (GI) versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("giVersions")]
        public virtual System.Collections.Generic.IList<GiVersion> GiVersions { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing GoldengateConnectionAssignments.</summary>
    public class ListGoldengateConnectionAssignmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GoldengateConnectionAssignments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateConnectionAssignments")]
        public virtual System.Collections.Generic.IList<GoldengateConnectionAssignment> GoldengateConnectionAssignments { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing GoldengateConnectionTypes</summary>
    public class ListGoldengateConnectionTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GoldengateConnectionType</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateConnectionTypes")]
        public virtual System.Collections.Generic.IList<GoldengateConnectionType> GoldengateConnectionTypes { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unordered list. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `GoldengateConnection.List`.</summary>
    public class ListGoldengateConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GoldengateConnections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateConnections")]
        public virtual System.Collections.Generic.IList<GoldengateConnection> GoldengateConnections { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Optional. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing GoldengateDeploymentEnvironments</summary>
    public class ListGoldengateDeploymentEnvironmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GoldengateDeploymentEnvironment</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateDeploymentEnvironments")]
        public virtual System.Collections.Generic.IList<GoldengateDeploymentEnvironment> GoldengateDeploymentEnvironments { get; set; }

        /// <summary>
        /// A token identifying a page of results the server should return. If this field is empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unordered list. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing GoldengateDeploymentTypes</summary>
    public class ListGoldengateDeploymentTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GoldengateDeploymentType</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateDeploymentTypes")]
        public virtual System.Collections.Generic.IList<GoldengateDeploymentType> GoldengateDeploymentTypes { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unordered list. The resource names of locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing GoldengateDeploymentVersions</summary>
    public class ListGoldengateDeploymentVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GoldengateDeploymentVersion</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateDeploymentVersions")]
        public virtual System.Collections.Generic.IList<GoldengateDeploymentVersion> GoldengateDeploymentVersions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Unordered list. Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `GoldengateDeployment.List`.</summary>
    public class ListGoldengateDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GoldengateDeployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goldengateDeployments")]
        public virtual System.Collections.Generic.IList<GoldengateDeployment> GoldengateDeployments { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Optional. Locations that could not be reached.</summary>
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

    /// <summary>The response for `MinorVersion.List`.</summary>
    public class ListMinorVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of MinorVersions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minorVersions")]
        public virtual System.Collections.Generic.IList<MinorVersion> MinorVersions { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `OdbNetwork.List`.</summary>
    public class ListOdbNetworksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of ODB Networks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbNetworks")]
        public virtual System.Collections.Generic.IList<OdbNetwork> OdbNetworks { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response for `OdbSubnet.List`.</summary>
    public class ListOdbSubnetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of ODB Subnets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("odbSubnets")]
        public virtual System.Collections.Generic.IList<OdbSubnet> OdbSubnets { get; set; }

        /// <summary>
        /// Unreachable locations when listing resources across all locations using wildcard location '-'.
        /// </summary>
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

    /// <summary>The response for `PluggableDatabase.List`.</summary>
    public class ListPluggableDatabasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of PluggableDatabases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluggableDatabases")]
        public virtual System.Collections.Generic.IList<PluggableDatabase> PluggableDatabases { get; set; }

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

    /// <summary>Metadata for a given Location.</summary>
    public class LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Google Cloud Platform Oracle zones in a location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZones")]
        public virtual System.Collections.Generic.IList<string> GcpOracleZones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maintenance window as defined by Oracle.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/MaintenanceWindow
    /// </summary>
    public class MaintenanceWindow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Determines the amount of time the system will wait before the start of each database server
        /// patching operation. Custom action timeout is in minutes and valid value is between 15 to 120 (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customActionTimeoutMins")]
        public virtual System.Nullable<int> CustomActionTimeoutMins { get; set; }

        /// <summary>Optional. Days during the week when maintenance should be performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOfWeek")]
        public virtual System.Collections.Generic.IList<string> DaysOfWeek { get; set; }

        /// <summary>
        /// Optional. The window of hours during the day when maintenance should be performed. The window is a 4 hour
        /// slot. Valid values are: 0 - represents time slot 0:00 - 3:59 UTC 4 - represents time slot 4:00 - 7:59 UTC 8
        /// - represents time slot 8:00 - 11:59 UTC 12 - represents time slot 12:00 - 15:59 UTC 16 - represents time
        /// slot 16:00 - 19:59 UTC 20 - represents time slot 20:00 - 23:59 UTC
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hoursOfDay")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> HoursOfDay { get; set; }

        /// <summary>
        /// Optional. If true, enables the configuration of a custom action timeout (waiting period) between database
        /// server patching operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCustomActionTimeoutEnabled")]
        public virtual System.Nullable<bool> IsCustomActionTimeoutEnabled { get; set; }

        /// <summary>
        /// Optional. Lead time window allows user to set a lead time to prepare for a down time. The lead time is in
        /// weeks and valid value is between 1 to 4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadTimeWeek")]
        public virtual System.Nullable<int> LeadTimeWeek { get; set; }

        /// <summary>Optional. Months during the year when maintenance should be performed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("months")]
        public virtual System.Collections.Generic.IList<string> Months { get; set; }

        /// <summary>
        /// Optional. Cloud CloudExadataInfrastructure node patching method, either "ROLLING" or "NONROLLING". Default
        /// value is ROLLING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchingMode")]
        public virtual string PatchingMode { get; set; }

        /// <summary>Optional. The maintenance window scheduling preference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preference")]
        public virtual string Preference { get; set; }

        /// <summary>
        /// Optional. Weeks during the month when maintenance should be performed. Weeks start on the 1st, 8th, 15th,
        /// and 22nd days of the month, and have a duration of 7 days. Weeks start and end based on calendar dates, not
        /// days of the week.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeksOfMonth")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> WeeksOfMonth { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MinorVersion represents a minor version of a GI.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/GiMinorVersionSummary/
    /// </summary>
    public class MinorVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The ID of the Grid Image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gridImageId")]
        public virtual string GridImageId { get; set; }

        /// <summary>
        /// Identifier. The name of the MinorVersion resource with the format:
        /// projects/{project}/locations/{region}/giVersions/{gi_version}/minorVersions/{minor_version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The valid Oracle grid infrastructure software version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A name-value pair representing an attribute entry usable in a list of attributes.</summary>
    public class NameValuePair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the property entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Required. The value of the property entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Nessie Iceberg catalog.</summary>
    public class NessieIcebergCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Nessie branch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("branch")]
        public virtual string Branch { get; set; }

        /// <summary>Required. The Nessie uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents OdbNetwork resource.</summary>
    public class OdbNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the OdbNetwork was created.</summary>
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

        /// <summary>Output only. The ID of the subscription entitlement associated with the OdbNetwork.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entitlementId")]
        public virtual string EntitlementId { get; set; }

        /// <summary>
        /// Optional. The GCP Oracle zone where OdbNetwork is hosted. Example: us-east4-b-r2. If not specified, the
        /// system will pick a zone based on availability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

        /// <summary>Optional. Labels or tags associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the OdbNetwork resource in the following format:
        /// projects/{project}/locations/{region}/odbNetworks/{odb_network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The name of the VPC network in the following format: projects/{project}/global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Output only. State of the ODB Network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents OdbSubnet resource.</summary>
    public class OdbSubnet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The CIDR range of the subnet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidrRange")]
        public virtual string CidrRange { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the OdbNetwork was created.</summary>
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

        /// <summary>Optional. Labels or tags associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The name of the OdbSubnet resource in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Purpose of the subnet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purpose")]
        public virtual string Purpose { get; set; }

        /// <summary>Output only. State of the ODB Subnet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

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
        /// Output only. An estimated percentage of the operation that has been completed at a given moment of time,
        /// between 0 and 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentComplete")]
        public virtual System.Nullable<double> PercentComplete { get; set; }

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have Operation.error value with a google.rpc.Status.code of 1, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. The status of the operation.</summary>
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
    /// The PluggableDatabase resource. https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/PluggableDatabase/
    /// </summary>
    public class PluggableDatabase : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The date and time that the PluggableDatabase was created.</summary>
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
        /// Identifier. The name of the PluggableDatabase resource in the following format:
        /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. HTTPS link to OCI resources exposed to Customer via UI Interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ociUrl")]
        public virtual string OciUrl { get; set; }

        /// <summary>Optional. The properties of the PluggableDatabase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual PluggableDatabaseProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The connection strings used to connect to the Oracle Database.</summary>
    public class PluggableDatabaseConnectionStrings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. All connection strings to use to connect to the pluggable database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allConnectionStrings")]
        public virtual System.Collections.Generic.IDictionary<string, string> AllConnectionStrings { get; set; }

        /// <summary>Optional. The default connection string to use to connect to the pluggable database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pdbDefault")]
        public virtual string PdbDefault { get; set; }

        /// <summary>
        /// Optional. The default connection string to use to connect to the pluggable database using IP.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pdbIpDefault")]
        public virtual string PdbIpDefault { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Pluggable Database Node Level Details.</summary>
    public class PluggableDatabaseNodeLevelDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Node name of the Database home.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeName")]
        public virtual string NodeName { get; set; }

        /// <summary>Required. The mode that the pluggable database is in to open it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openMode")]
        public virtual string OpenMode { get; set; }

        /// <summary>Required. The OCID of the Pluggable Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluggableDatabaseId")]
        public virtual string PluggableDatabaseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The properties of a PluggableDatabase.</summary>
    public class PluggableDatabaseProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The OCID of the compartment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compartmentId")]
        public virtual string CompartmentId { get; set; }

        /// <summary>Optional. The Connection strings used to connect to the Oracle Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionStrings")]
        public virtual PluggableDatabaseConnectionStrings ConnectionStrings { get; set; }

        /// <summary>Required. The OCID of the CDB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerDatabaseOcid")]
        public virtual string ContainerDatabaseOcid { get; set; }

        /// <summary>Output only. The configuration of the Database Management service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseManagementConfig")]
        public virtual DatabaseManagementConfig DatabaseManagementConfig { get; set; }

        /// <summary>
        /// Optional. Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definedTags")]
        public virtual System.Collections.Generic.IDictionary<string, DefinedTagValue> DefinedTags { get; set; }

        /// <summary>
        /// Optional. Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name,
        /// type, or namespace.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freeformTags")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags { get; set; }

        /// <summary>
        /// Optional. The restricted mode of the pluggable database. If a pluggable database is opened in restricted
        /// mode, the user needs both create a session and have restricted session privileges to connect to it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRestricted")]
        public virtual System.Nullable<bool> IsRestricted { get; set; }

        /// <summary>Output only. Additional information about the current lifecycle state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleDetails")]
        public virtual string LifecycleDetails { get; set; }

        /// <summary>Output only. The current state of the pluggable database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleState")]
        public virtual string LifecycleState { get; set; }

        /// <summary>Output only. The OCID of the pluggable database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ocid")]
        public virtual string Ocid { get; set; }

        /// <summary>Output only. The status of Operations Insights for this Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationsInsightsState")]
        public virtual string OperationsInsightsState { get; set; }

        /// <summary>Required. The database name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pdbName")]
        public virtual string PdbName { get; set; }

        /// <summary>Optional. Pluggable Database Node Level Details</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pdbNodeLevelDetails")]
        public virtual System.Collections.Generic.IList<PluggableDatabaseNodeLevelDetails> PdbNodeLevelDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Polaris Iceberg catalog.</summary>
    public class PolarisIcebergCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Polaris client ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>Optional. The Polaris client secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientSecret")]
        public virtual string ClientSecret { get; set; }

        /// <summary>Required. The catalog name within Polaris.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("polarisCatalog")]
        public virtual string PolarisCatalog { get; set; }

        /// <summary>Required. The Polaris principal role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalRole")]
        public virtual string PrincipalRole { get; set; }

        /// <summary>Required. The Polaris uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `ExadbVmCluster.RemoveVirtualMachine`.</summary>
    public class RemoveVirtualMachineExadbVmClusterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of host names of db nodes to be removed from the ExadbVmCluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostnames")]
        public virtual System.Collections.Generic.IList<string> Hostnames { get; set; }

        /// <summary>
        /// Optional. An optional ID to identify the request. This value is used to identify duplicate requests. If you
        /// make a request with the same request ID and the original request is still in progress or completed, the
        /// server ignores the second request. This prevents clients from accidentally creating duplicate commitments.
        /// The request ID must be a valid UUID with the exception that zero UUID is not supported
        /// (00000000-0000-0000-0000-000000000000).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The REST Iceberg catalog.</summary>
    public class RestIcebergCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The content of the configuration file containing additional properties for the REST catalog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual string Properties { get; set; }

        /// <summary>Required. The REST uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `AutonomousDatabase.Restart`.</summary>
    public class RestartAutonomousDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `AutonomousDatabase.Restore`.</summary>
    public class RestoreAutonomousDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _restoreTimeRaw;

        private object _restoreTime;

        /// <summary>Required. The time and date to restore the database to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreTime")]
        public virtual string RestoreTimeRaw
        {
            get => _restoreTimeRaw;
            set
            {
                _restoreTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _restoreTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RestoreTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RestoreTimeDateTimeOffset instead.")]
        public virtual object RestoreTime
        {
            get => _restoreTime;
            set
            {
                _restoreTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _restoreTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RestoreTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RestoreTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RestoreTimeRaw);
            set => RestoreTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of scheduled operation.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/datatypes/ScheduledOperationDetails
    /// </summary>
    public class ScheduledOperationDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Day of week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>Output only. Auto start time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>Output only. Auto stop time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopTime")]
        public virtual TimeOfDay StopTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The source configuration for the standby Autonomous Database.</summary>
    public class SourceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. This field specifies if the replication of automatic backups is enabled when creating a Data
        /// Guard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automaticBackupsReplicationEnabled")]
        public virtual System.Nullable<bool> AutomaticBackupsReplicationEnabled { get; set; }

        /// <summary>
        /// Optional. The name of the primary Autonomous Database that is used to create a Peer Autonomous Database from
        /// a source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autonomousDatabase")]
        public virtual string AutonomousDatabase { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `AutonomousDatabase.Start`.</summary>
    public class StartAutonomousDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `GoldengateDeployment.Start`.</summary>
    public class StartGoldengateDeploymentRequest : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>The request for `AutonomousDatabase.Stop`.</summary>
    public class StopAutonomousDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `GoldengateDeployment.Stop`.</summary>
    public class StopGoldengateDeploymentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The initial storage size, in gigabytes, that is applicable for virtual machine DBSystem.</summary>
    public class StorageSizeDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The data storage size, in gigabytes, that is applicable for virtual machine DBSystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageSizeInGbs")]
        public virtual System.Nullable<int> DataStorageSizeInGbs { get; set; }

        /// <summary>
        /// Output only. The RECO/REDO storage size, in gigabytes, that is applicable for virtual machine DBSystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoStorageSizeInGbs")]
        public virtual System.Nullable<int> RecoStorageSizeInGbs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for `OracleDatabase.SwitchoverAutonomousDatabase`.</summary>
    public class SwitchoverAutonomousDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The peer database name to switch over to. Required for cross-region standby, and must be omitted
        /// for in-region Data Guard.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerAutonomousDatabase")]
        public virtual string PeerAutonomousDatabase { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error details for TestGoldengateConnectionAssignment.</summary>
    public class TestConnectionAssignmentError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text describing the action required to fix the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>A short error code that defines the error, meant for programmatic parsing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The text describing the root cause of the reported issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual string Issue { get; set; }

        /// <summary>A human-readable error message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TestGoldengateConnectionAssignment.</summary>
    public class TestGoldengateConnectionAssignmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The type of the test of the assigned connection. The only type actually supported is DEFAULT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The result of the connectivity test performed between the Goldengate deployment and the associated database /
    /// service.
    /// </summary>
    public class TestGoldengateConnectionAssignmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error details if test connection failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual TestConnectionAssignmentError Error { get; set; }

        /// <summary>List of test connection assignment error objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<TestConnectionAssignmentError> Errors { get; set; }

        /// <summary>Type of the result i.e. Success, Failure or Timeout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultType")]
        public virtual string ResultType { get; set; }

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

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
