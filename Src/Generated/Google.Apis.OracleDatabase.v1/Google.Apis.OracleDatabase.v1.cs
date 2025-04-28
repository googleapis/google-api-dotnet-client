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
                DbSystemShapes = new DbSystemShapesResource(service);
                Entitlements = new EntitlementsResource(service);
                GiVersions = new GiVersionsResource(service);
                Operations = new OperationsResource(service);
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
                /// Initiates a switchover of specified autonomous deatabase to the associated peer database.
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
                /// Initiates a switchover of specified autonomous deatabase to the associated peer database.
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
                    /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}.
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
                        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}.
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

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
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

    /// <summary>
    /// Details of the Autonomous Database resource.
    /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/AutonomousDatabase/
    /// </summary>
    public class AutonomousDatabase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The password for the default ADMIN user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminPassword")]
        public virtual string AdminPassword { get; set; }

        /// <summary>Optional. The subnet CIDR range for the Autonmous Database.</summary>
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
        /// Optional. The name of the Autonomous Database. The database name must be unique in the project. The name
        /// must begin with a letter and can contain a maximum of 30 alphanumeric characters.
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
        /// Optional. The display name for the Autonomous Database. The name does not have to be unique within your
        /// project.
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
        /// Optional. The name of the VPC network used by the Autonomous Database in the following format:
        /// projects/{project}/global/networks/{network}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>Output only. The peer Autonomous Database names of the given Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerAutonomousDatabases")]
        public virtual System.Collections.Generic.IList<string> PeerAutonomousDatabases { get; set; }

        /// <summary>Optional. The properties of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual AutonomousDatabaseProperties Properties { get; set; }

        /// <summary>
        /// Optional. The source Autonomous Database configuration for the standby Autonomous Database. The source
        /// Autonomous Database is configured while creating the Peer Autonomous Database and can't be updated after
        /// creation.
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

        /// <summary>Optional. The list of allowlisted IP addresses for the Autonomous Database.</summary>
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
        /// Optional. The retention period for the Autonomous Database. This field is specified in days, can range from
        /// 1 day to 60 days, and has a default value of 60 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRetentionPeriodDays")]
        public virtual System.Nullable<int> BackupRetentionPeriodDays { get; set; }

        /// <summary>Optional. The character set for the Autonomous Database. The default is AL32UTF8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterSet")]
        public virtual string CharacterSet { get; set; }

        /// <summary>Optional. The number of compute servers for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeCount")]
        public virtual System.Nullable<float> ComputeCount { get; set; }

        /// <summary>Output only. The connection strings used to connect to an Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionStrings")]
        public virtual AutonomousDatabaseConnectionStrings ConnectionStrings { get; set; }

        /// <summary>Output only. The Oracle Connection URLs for an Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionUrls")]
        public virtual AutonomousDatabaseConnectionUrls ConnectionUrls { get; set; }

        /// <summary>Optional. The number of CPU cores to be made available to the database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuCoreCount")]
        public virtual System.Nullable<int> CpuCoreCount { get; set; }

        /// <summary>Optional. The list of customer contacts.</summary>
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

        /// <summary>Optional. The size of the data stored in the database, in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageSizeGb")]
        public virtual System.Nullable<int> DataStorageSizeGb { get; set; }

        /// <summary>Optional. The size of the data stored in the database, in terabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStorageSizeTb")]
        public virtual System.Nullable<int> DataStorageSizeTb { get; set; }

        /// <summary>Output only. The current state of database management for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseManagementState")]
        public virtual string DatabaseManagementState { get; set; }

        /// <summary>Optional. The edition of the Autonomous Databases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbEdition")]
        public virtual string DbEdition { get; set; }

        /// <summary>Optional. The Oracle Database version for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dbVersion")]
        public virtual string DbVersion { get; set; }

        /// <summary>Required. The workload type of the Autonomous Database.</summary>
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
        /// Output only. This field indicates the number of seconds of data loss during a Data Guard failover.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedDataRecoveryDuration")]
        public virtual object FailedDataRecoveryDuration { get; set; }

        /// <summary>
        /// Optional. This field indicates if auto scaling is enabled for the Autonomous Database CPU core count.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAutoScalingEnabled")]
        public virtual System.Nullable<bool> IsAutoScalingEnabled { get; set; }

        /// <summary>
        /// Output only. This field indicates whether the Autonomous Database has local (in-region) Data Guard enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isLocalDataGuardEnabled")]
        public virtual System.Nullable<bool> IsLocalDataGuardEnabled { get; set; }

        /// <summary>
        /// Optional. This field indicates if auto scaling is enabled for the Autonomous Database storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isStorageAutoScalingEnabled")]
        public virtual System.Nullable<bool> IsStorageAutoScalingEnabled { get; set; }

        /// <summary>Required. The license type used for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("licenseType")]
        public virtual string LicenseType { get; set; }

        /// <summary>Output only. The details of the current lifestyle state of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycleDetails")]
        public virtual string LifecycleDetails { get; set; }

        /// <summary>
        /// Output only. This field indicates the maximum data loss limit for an Autonomous Database, in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localAdgAutoFailoverMaxDataLossLimit")]
        public virtual System.Nullable<int> LocalAdgAutoFailoverMaxDataLossLimit { get; set; }

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

        /// <summary>Optional. The maintenance schedule of the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceScheduleType")]
        public virtual string MaintenanceScheduleType { get; set; }

        /// <summary>Output only. The amount of memory enabled per ECPU, in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryPerOracleComputeUnitGbs")]
        public virtual System.Nullable<int> MemoryPerOracleComputeUnitGbs { get; set; }

        /// <summary>Output only. The memory assigned to in-memory tables in an Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryTableGbs")]
        public virtual System.Nullable<int> MemoryTableGbs { get; set; }

        /// <summary>Optional. This field specifies if the Autonomous Database requires mTLS connections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mtlsConnectionRequired")]
        public virtual System.Nullable<bool> MtlsConnectionRequired { get; set; }

        /// <summary>
        /// Optional. The national character set for the Autonomous Database. The default is AL16UTF16.
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

        /// <summary>Optional. The private endpoint IP address for the Autonomous Database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateEndpointIp")]
        public virtual string PrivateEndpointIp { get; set; }

        /// <summary>Optional. The private endpoint label for the Autonomous Database.</summary>
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

        /// <summary>Optional. The ID of the Oracle Cloud Infrastructure vault secret.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretId")]
        public virtual string SecretId { get; set; }

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

        /// <summary>Optional. The ID of the Oracle Cloud Infrastructure vault.</summary>
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

        /// <summary>Optional. Google Cloud Platform location where Oracle Exadata is hosted.</summary>
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
        /// Output only. Google Cloud Platform location where Oracle Exadata is hosted. It is same as Google Cloud
        /// Platform Oracle zone of Exadata infrastructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpOracleZone")]
        public virtual string GcpOracleZone { get; set; }

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

    /// <summary>The source configuration for the standby Autonomnous Database.</summary>
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

    /// <summary>The request for `AutonomousDatabase.Switchover`.</summary>
    public class SwitchoverAutonomousDatabaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The peer database name to switch over to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerAutonomousDatabase")]
        public virtual string PeerAutonomousDatabase { get; set; }

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
