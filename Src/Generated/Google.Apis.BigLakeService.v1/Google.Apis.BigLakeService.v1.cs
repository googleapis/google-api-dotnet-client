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

namespace Google.Apis.BigLakeService.v1
{
    /// <summary>The BigLakeService Service.</summary>
    public class BigLakeServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BigLakeServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BigLakeServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "biglake";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://biglake.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://biglake.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the BigLake API.</summary>
        public class Scope
        {
            /// <summary>
            /// View and manage your data in Google BigQuery and see the email address for your Google Account
            /// </summary>
            public static string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the BigLake API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// View and manage your data in Google BigQuery and see the email address for your Google Account
            /// </summary>
            public const string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for BigLakeService requests.</summary>
    public abstract class BigLakeServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BigLakeServiceBaseServiceRequest instance.</summary>
        protected BigLakeServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes BigLakeService parameter list.</summary>
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
                Catalogs = new CatalogsResource(service);
            }

            /// <summary>Gets the Catalogs resource.</summary>
            public virtual CatalogsResource Catalogs { get; }

            /// <summary>The "catalogs" collection of methods.</summary>
            public class CatalogsResource
            {
                private const string Resource = "catalogs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CatalogsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Databases = new DatabasesResource(service);
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
                        Tables = new TablesResource(service);
                    }

                    /// <summary>Gets the Tables resource.</summary>
                    public virtual TablesResource Tables { get; }

                    /// <summary>The "tables" collection of methods.</summary>
                    public class TablesResource
                    {
                        private const string Resource = "tables";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TablesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a new table.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The parent resource where this table will be created. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.BigLakeService.v1.Data.Table body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a new table.</summary>
                        public class CreateRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Table>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigLakeService.v1.Data.Table body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent resource where this table will be created. Format:
                            /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID to use for the table, which will become the final component of the
                            /// table's resource name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("tableId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string TableId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.BigLakeService.v1.Data.Table Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/tables";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+$",
                                });
                                RequestParameters.Add("tableId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "tableId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>Deletes an existing table specified by the table ID.</summary>
                        /// <param name="name">
                        /// Required. The name of the table to delete. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes an existing table specified by the table ID.</summary>
                        public class DeleteRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Table>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the table to delete. Format:
                            /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+/tables/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets the table specified by the resource name.</summary>
                        /// <param name="name">
                        /// Required. The name of the table to retrieve. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets the table specified by the resource name.</summary>
                        public class GetRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Table>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the table to retrieve. Format:
                            /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+/tables/[^/]+$",
                                });
                            }
                        }

                        /// <summary>List all tables in a specified database.</summary>
                        /// <param name="parent">
                        /// Required. The parent, which owns this collection of tables. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>List all tables in a specified database.</summary>
                        public class ListRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.ListTablesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The parent, which owns this collection of tables. Format:
                            /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The maximum number of tables to return. The service may return fewer than this value. If
                            /// unspecified, at most 50 tables will be returned. The maximum value is 1000; values above
                            /// 1000 will be coerced to 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListTables` call. Provide this to retrieve the
                            /// subsequent page. When paginating, all other parameters provided to `ListTables` must
                            /// match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>The view for the returned tables.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>The view for the returned tables.</summary>
                            public enum ViewEnum
                            {
                                /// <summary>Default value. The API will default to the BASIC view.</summary>
                                [Google.Apis.Util.StringValueAttribute("TABLE_VIEW_UNSPECIFIED")]
                                TABLEVIEWUNSPECIFIED = 0,

                                /// <summary>Include only table names. This is the default value.</summary>
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
                            public override string RestPath => "v1/{+parent}/tables";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+$",
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

                        /// <summary>Updates an existing table specified by the table ID.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Output only. The resource name. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.BigLakeService.v1.Data.Table body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates an existing table specified by the table ID.</summary>
                        public class PatchRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Table>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigLakeService.v1.Data.Table body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Output only. The resource name. Format:
                            /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// The list of fields to update. For the `FieldMask` definition, see
                            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                            /// If not set, defaults to all of the fields that are allowed to update.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.BigLakeService.v1.Data.Table Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+/tables/[^/]+$",
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

                        /// <summary>Renames an existing table specified by the table ID.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The table's `name` field is used to identify the table to rename. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
                        /// </param>
                        public virtual RenameRequest Rename(Google.Apis.BigLakeService.v1.Data.RenameTableRequest body, string name)
                        {
                            return new RenameRequest(service, body, name);
                        }

                        /// <summary>Renames an existing table specified by the table ID.</summary>
                        public class RenameRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Table>
                        {
                            /// <summary>Constructs a new Rename request.</summary>
                            public RenameRequest(Google.Apis.Services.IClientService service, Google.Apis.BigLakeService.v1.Data.RenameTableRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The table's `name` field is used to identify the table to rename. Format:
                            /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.BigLakeService.v1.Data.RenameTableRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "rename";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:rename";

                            /// <summary>Initializes Rename parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+/tables/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a new database.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource where this database will be created. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.BigLakeService.v1.Data.Database body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new database.</summary>
                    public class CreateRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Database>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigLakeService.v1.Data.Database body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this database will be created. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the database, which will become the final component of the
                        /// database's resource name.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("databaseId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DatabaseId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigLakeService.v1.Data.Database Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/databases";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                            });
                            RequestParameters.Add("databaseId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "databaseId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes an existing database specified by the database ID.</summary>
                    /// <param name="name">
                    /// Required. The name of the database to delete. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes an existing database specified by the database ID.</summary>
                    public class DeleteRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Database>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the database to delete. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the database specified by the resource name.</summary>
                    /// <param name="name">
                    /// Required. The name of the database to retrieve. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets the database specified by the resource name.</summary>
                    public class GetRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Database>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the database to retrieve. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List all databases in a specified catalog.</summary>
                    /// <param name="parent">
                    /// Required. The parent, which owns this collection of databases. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List all databases in a specified catalog.</summary>
                    public class ListRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.ListDatabasesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent, which owns this collection of databases. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of databases to return. The service may return fewer than this value. If
                        /// unspecified, at most 50 databases will be returned. The maximum value is 1000; values above
                        /// 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListDatabases` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListDatabases` must
                        /// match the call that provided the page token.
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
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

                    /// <summary>Updates an existing database specified by the database ID.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.BigLakeService.v1.Data.Database body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates an existing database specified by the database ID.</summary>
                    public class PatchRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Database>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigLakeService.v1.Data.Database body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name. Format:
                        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The list of fields to update. For the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask If
                        /// not set, defaults to all of the fields that are allowed to update.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.BigLakeService.v1.Data.Database Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+/databases/[^/]+$",
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

                /// <summary>Creates a new catalog.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource where this catalog will be created. Format:
                /// projects/{project_id_or_number}/locations/{location_id}
                /// </param>
                public virtual CreateRequest Create(Google.Apis.BigLakeService.v1.Data.Catalog body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new catalog.</summary>
                public class CreateRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Catalog>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigLakeService.v1.Data.Catalog body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource where this catalog will be created. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the catalog, which will become the final component of the catalog's
                    /// resource name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("catalogId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string CatalogId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigLakeService.v1.Data.Catalog Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/catalogs";

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
                        RequestParameters.Add("catalogId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "catalogId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes an existing catalog specified by the catalog ID.</summary>
                /// <param name="name">
                /// Required. The name of the catalog to delete. Format:
                /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes an existing catalog specified by the catalog ID.</summary>
                public class DeleteRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Catalog>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the catalog to delete. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the catalog specified by the resource name.</summary>
                /// <param name="name">
                /// Required. The name of the catalog to retrieve. Format:
                /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the catalog specified by the resource name.</summary>
                public class GetRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.Catalog>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the catalog to retrieve. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/catalogs/[^/]+$",
                        });
                    }
                }

                /// <summary>List all catalogs in a specified project.</summary>
                /// <param name="parent">
                /// Required. The parent, which owns this collection of catalogs. Format:
                /// projects/{project_id_or_number}/locations/{location_id}
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List all catalogs in a specified project.</summary>
                public class ListRequest : BigLakeServiceBaseServiceRequest<Google.Apis.BigLakeService.v1.Data.ListCatalogsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent, which owns this collection of catalogs. Format:
                    /// projects/{project_id_or_number}/locations/{location_id}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of catalogs to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 catalogs will be returned. The maximum value is 1000; values above 1000
                    /// will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `ListCatalogs` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `ListCatalogs` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/catalogs";

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
        }
    }
}
namespace Google.Apis.BigLakeService.v1.Data
{
    /// <summary>Catalog is the container of databases.</summary>
    public class Catalog : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation time of the catalog.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The deletion time of the catalog. Only set after the catalog is deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. The time when this catalog is considered expired. Only set after the catalog is deleted.
        /// </summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Output only. The resource name. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last modification time of the catalog.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Database is the container of tables.</summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation time of the database.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The deletion time of the database. Only set after the database is deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. The time when this database is considered expired. Only set after the database is deleted.
        /// </summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Options of a Hive database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveOptions")]
        public virtual HiveDatabaseOptions HiveOptions { get; set; }

        /// <summary>
        /// Output only. The resource name. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The database type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last modification time of the database.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options of a Hive database.</summary>
    public class HiveDatabaseOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud Storage folder URI where the database data is stored, starting with "gs://".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationUri")]
        public virtual string LocationUri { get; set; }

        /// <summary>Stores user supplied Hive database parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options of a Hive table.</summary>
    public class HiveTableOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Stores user supplied Hive table parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters { get; set; }

        /// <summary>Stores physical storage information of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageDescriptor")]
        public virtual StorageDescriptor StorageDescriptor { get; set; }

        /// <summary>Hive table type. For example, MANAGED_TABLE, EXTERNAL_TABLE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableType")]
        public virtual string TableType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListCatalogs method.</summary>
    public class ListCatalogsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The catalogs from the specified project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("catalogs")]
        public virtual System.Collections.Generic.IList<Catalog> Catalogs { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListDatabases method.</summary>
    public class ListDatabasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The databases from the specified catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databases")]
        public virtual System.Collections.Generic.IList<Database> Databases { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListTables method.</summary>
    public class ListTablesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The tables from the specified database.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<Table> Tables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the RenameTable method in MetastoreService</summary>
    public class RenameTableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The new `name` for the specified table, must be in the same database. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newName")]
        public virtual string NewName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Serializer and deserializer information.</summary>
    public class SerDeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fully qualified Java class name of the serialization library.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serializationLib")]
        public virtual string SerializationLib { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Stores physical storage information of the data.</summary>
    public class StorageDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fully qualified Java class name of the input format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputFormat")]
        public virtual string InputFormat { get; set; }

        /// <summary>Cloud Storage folder URI where the table data is stored, starting with "gs://".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationUri")]
        public virtual string LocationUri { get; set; }

        /// <summary>The fully qualified Java class name of the output format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputFormat")]
        public virtual string OutputFormat { get; set; }

        /// <summary>Serializer and deserializer information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serdeInfo")]
        public virtual SerDeInfo SerdeInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a table.</summary>
    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation time of the table.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. The deletion time of the table. Only set after the table is deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// The checksum of a table object computed by the server based on the value of other fields. It may be sent on
        /// update requests to ensure the client has an up-to-date value before proceeding. It is only checked for
        /// update table operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. The time when this table is considered expired. Only set after the table is deleted.
        /// </summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Options of a Hive table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiveOptions")]
        public virtual HiveTableOptions HiveOptions { get; set; }

        /// <summary>
        /// Output only. The resource name. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}/tables/{table_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The table type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The last modification time of the table.</summary>
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
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }
    }
}
