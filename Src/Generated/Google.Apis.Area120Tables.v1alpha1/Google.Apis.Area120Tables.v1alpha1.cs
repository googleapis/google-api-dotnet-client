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

namespace Google.Apis.Area120Tables.v1alpha1
{
    /// <summary>The Area120Tables Service.</summary>
    public class Area120TablesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public Area120TablesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public Area120TablesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Tables = new TablesResource(this);
            Workspaces = new WorkspacesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "area120tables";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://area120tables.googleapis.com/";
        #else
            "https://area120tables.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://area120tables.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Area120 Tables API.</summary>
        public class Scope
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public static string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public static string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>See, edit, create, and delete all your Google Sheets spreadsheets</summary>
            public static string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>See all your Google Sheets spreadsheets</summary>
            public static string SpreadsheetsReadonly = "https://www.googleapis.com/auth/spreadsheets.readonly";

            /// <summary>See, edit, create, and delete your tables in Tables by Area 120</summary>
            public static string Tables = "https://www.googleapis.com/auth/tables";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Area120 Tables API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public const string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public const string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public const string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>See, edit, create, and delete all your Google Sheets spreadsheets</summary>
            public const string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>See all your Google Sheets spreadsheets</summary>
            public const string SpreadsheetsReadonly = "https://www.googleapis.com/auth/spreadsheets.readonly";

            /// <summary>See, edit, create, and delete your tables in Tables by Area 120</summary>
            public const string Tables = "https://www.googleapis.com/auth/tables";
        }

        /// <summary>Gets the Tables resource.</summary>
        public virtual TablesResource Tables { get; }

        /// <summary>Gets the Workspaces resource.</summary>
        public virtual WorkspacesResource Workspaces { get; }
    }

    /// <summary>A base abstract class for Area120Tables requests.</summary>
    public abstract class Area120TablesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new Area120TablesBaseServiceRequest instance.</summary>
        protected Area120TablesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Area120Tables parameter list.</summary>
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
            Rows = new RowsResource(service);
        }

        /// <summary>Gets the Rows resource.</summary>
        public virtual RowsResource Rows { get; }

        /// <summary>The "rows" collection of methods.</summary>
        public class RowsResource
        {
            private const string Resource = "rows";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RowsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates multiple rows.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent table where the rows will be created. Format: tables/{table}
            /// </param>
            public virtual BatchCreateRequest BatchCreate(Google.Apis.Area120Tables.v1alpha1.Data.BatchCreateRowsRequest body, string parent)
            {
                return new BatchCreateRequest(service, body, parent);
            }

            /// <summary>Creates multiple rows.</summary>
            public class BatchCreateRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.BatchCreateRowsResponse>
            {
                /// <summary>Constructs a new BatchCreate request.</summary>
                public BatchCreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Area120Tables.v1alpha1.Data.BatchCreateRowsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent table where the rows will be created. Format: tables/{table}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Area120Tables.v1alpha1.Data.BatchCreateRowsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchCreate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}/rows:batchCreate";

                /// <summary>Initializes BatchCreate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^tables/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes multiple rows.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent table shared by all rows being deleted. Format: tables/{table}
            /// </param>
            public virtual BatchDeleteRequest BatchDelete(Google.Apis.Area120Tables.v1alpha1.Data.BatchDeleteRowsRequest body, string parent)
            {
                return new BatchDeleteRequest(service, body, parent);
            }

            /// <summary>Deletes multiple rows.</summary>
            public class BatchDeleteRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.Empty>
            {
                /// <summary>Constructs a new BatchDelete request.</summary>
                public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Area120Tables.v1alpha1.Data.BatchDeleteRowsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent table shared by all rows being deleted. Format: tables/{table}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Area120Tables.v1alpha1.Data.BatchDeleteRowsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchDelete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}/rows:batchDelete";

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
                        Pattern = @"^tables/[^/]+$",
                    });
                }
            }

            /// <summary>Updates multiple rows.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent table shared by all rows being updated. Format: tables/{table}
            /// </param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.Area120Tables.v1alpha1.Data.BatchUpdateRowsRequest body, string parent)
            {
                return new BatchUpdateRequest(service, body, parent);
            }

            /// <summary>Updates multiple rows.</summary>
            public class BatchUpdateRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.BatchUpdateRowsResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Area120Tables.v1alpha1.Data.BatchUpdateRowsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent table shared by all rows being updated. Format: tables/{table}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Area120Tables.v1alpha1.Data.BatchUpdateRowsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}/rows:batchUpdate";

                /// <summary>Initializes BatchUpdate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^tables/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a row.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent table where this row will be created. Format: tables/{table}
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Area120Tables.v1alpha1.Data.Row body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a row.</summary>
            public class CreateRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.Row>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Area120Tables.v1alpha1.Data.Row body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent table where this row will be created. Format: tables/{table}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
                public enum ViewEnum
                {
                    /// <summary>Defaults to user entered text.</summary>
                    [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                    VIEWUNSPECIFIED = 0,

                    /// <summary>Uses internally generated column id to identify values.</summary>
                    [Google.Apis.Util.StringValueAttribute("COLUMN_ID_VIEW")]
                    COLUMNIDVIEW = 1,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Area120Tables.v1alpha1.Data.Row Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}/rows";

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
                        Pattern = @"^tables/[^/]+$",
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

            /// <summary>Deletes a row.</summary>
            /// <param name="name">Required. The name of the row to delete. Format: tables/{table}/rows/{row}</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a row.</summary>
            public class DeleteRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the row to delete. Format: tables/{table}/rows/{row}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^tables/[^/]+/rows/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a row. Returns NOT_FOUND if the row does not exist in the table.</summary>
            /// <param name="name">Required. The name of the row to retrieve. Format: tables/{table}/rows/{row}</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a row. Returns NOT_FOUND if the row does not exist in the table.</summary>
            public class GetRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.Row>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the row to retrieve. Format: tables/{table}/rows/{row}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
                public enum ViewEnum
                {
                    /// <summary>Defaults to user entered text.</summary>
                    [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                    VIEWUNSPECIFIED = 0,

                    /// <summary>Uses internally generated column id to identify values.</summary>
                    [Google.Apis.Util.StringValueAttribute("COLUMN_ID_VIEW")]
                    COLUMNIDVIEW = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^tables/[^/]+/rows/[^/]+$",
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

            /// <summary>Lists rows in a table. Returns NOT_FOUND if the table does not exist.</summary>
            /// <param name="parent">Required. The parent table. Format: tables/{table}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists rows in a table. Returns NOT_FOUND if the table does not exist.</summary>
            public class ListRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.ListRowsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent table. Format: tables/{table}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Filter to only include resources matching the requirements. For more information, see
                /// [Filtering list results](https://support.google.com/area120-tables/answer/10503371).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Optional. Sorting order for the list of rows on createTime/updateTime.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of rows to return. The service may return fewer than this value. If unspecified,
                /// at most 50 rows are returned. The maximum value is 1,000; values above 1,000 are coerced to 1,000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListRows` call. Provide this to retrieve the subsequent
                /// page. When paginating, all other parameters provided to `ListRows` must match the call that provided
                /// the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
                public enum ViewEnum
                {
                    /// <summary>Defaults to user entered text.</summary>
                    [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                    VIEWUNSPECIFIED = 0,

                    /// <summary>Uses internally generated column id to identify values.</summary>
                    [Google.Apis.Util.StringValueAttribute("COLUMN_ID_VIEW")]
                    COLUMNIDVIEW = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}/rows";

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
                        Pattern = @"^tables/[^/]+$",
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

            /// <summary>Updates a row.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the row. Row names have the form `tables/{table}/rows/{row}`. The name is ignored
            /// when creating a row.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Area120Tables.v1alpha1.Data.Row body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a row.</summary>
            public class PatchRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.Row>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Area120Tables.v1alpha1.Data.Row body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the row. Row names have the form `tables/{table}/rows/{row}`. The name is
                /// ignored when creating a row.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
                public enum ViewEnum
                {
                    /// <summary>Defaults to user entered text.</summary>
                    [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                    VIEWUNSPECIFIED = 0,

                    /// <summary>Uses internally generated column id to identify values.</summary>
                    [Google.Apis.Util.StringValueAttribute("COLUMN_ID_VIEW")]
                    COLUMNIDVIEW = 1,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Area120Tables.v1alpha1.Data.Row Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^tables/[^/]+/rows/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
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

        /// <summary>Gets a table. Returns NOT_FOUND if the table does not exist.</summary>
        /// <param name="name">Required. The name of the table to retrieve. Format: tables/{table}</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets a table. Returns NOT_FOUND if the table does not exist.</summary>
        public class GetRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.Table>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the table to retrieve. Format: tables/{table}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/{+name}";

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
                    Pattern = @"^tables/[^/]+$",
                });
            }
        }

        /// <summary>Lists tables for the user.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists tables for the user.</summary>
        public class ListRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.ListTablesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Optional. Sorting order for the list of tables on createTime/updateTime.</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// The maximum number of tables to return. The service may return fewer than this value. If unspecified, at
            /// most 20 tables are returned. The maximum value is 100; values above 100 are coerced to 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListTables` call. Provide this to retrieve the subsequent page.
            /// When paginating, all other parameters provided to `ListTables` must match the call that provided the
            /// page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/tables";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

    /// <summary>The "workspaces" collection of methods.</summary>
    public class WorkspacesResource
    {
        private const string Resource = "workspaces";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public WorkspacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets a workspace. Returns NOT_FOUND if the workspace does not exist.</summary>
        /// <param name="name">Required. The name of the workspace to retrieve. Format: workspaces/{workspace}</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Gets a workspace. Returns NOT_FOUND if the workspace does not exist.</summary>
        public class GetRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.Workspace>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the workspace to retrieve. Format: workspaces/{workspace}</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/{+name}";

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
                    Pattern = @"^workspaces/[^/]+$",
                });
            }
        }

        /// <summary>Lists workspaces for the user.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists workspaces for the user.</summary>
        public class ListRequest : Area120TablesBaseServiceRequest<Google.Apis.Area120Tables.v1alpha1.Data.ListWorkspacesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of workspaces to return. The service may return fewer than this value. If
            /// unspecified, at most 10 workspaces are returned. The maximum value is 25; values above 25 are coerced to
            /// 25.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListWorkspaces` call. Provide this to retrieve the subsequent
            /// page. When paginating, all other parameters provided to `ListWorkspaces` must match the call that
            /// provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/workspaces";

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
            }
        }
    }
}
namespace Google.Apis.Area120Tables.v1alpha1.Data
{
    /// <summary>Request message for TablesService.BatchCreateRows.</summary>
    public class BatchCreateRowsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The request message specifying the rows to create. A maximum of 500 rows can be created in a
        /// single batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<CreateRowRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for TablesService.BatchCreateRows.</summary>
    public class BatchCreateRowsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The created rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TablesService.BatchDeleteRows</summary>
    public class BatchDeleteRowsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The names of the rows to delete. All rows must belong to the parent table or else the entire batch
        /// will fail. A maximum of 500 rows can be deleted in a batch. Format: tables/{table}/rows/{row}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TablesService.BatchUpdateRows.</summary>
    public class BatchUpdateRowsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The request messages specifying the rows to update. A maximum of 500 rows can be modified in a
        /// single batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<UpdateRowRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for TablesService.BatchUpdateRows.</summary>
    public class BatchUpdateRowsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details on a column in the table.</summary>
    public class ColumnDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data type of the column Supported types are auto_id, boolean, boolean_list, creator, create_timestamp, date,
        /// dropdown, location, integer, integer_list, number, number_list, person, person_list, tags, check_list, text,
        /// text_list, update_timestamp, updater, relationship, file_attachment_list. These types directly map to the
        /// column types supported on Tables website.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Internal id for a column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Optional. Range of labeled values for the column. Some columns like tags and drop-downs limit the values to
        /// a set of possible values. We return the range of values in such cases to help clients implement better user
        /// data validation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabeledItem> Labels { get; set; }

        /// <summary>
        /// Optional. Indicates that this is a lookup column whose value is derived from the relationship column
        /// specified in the details. Lookup columns can not be updated directly. To change the value you must update
        /// the associated relationship column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lookupDetails")]
        public virtual LookupDetails LookupDetails { get; set; }

        /// <summary>
        /// Optional. Indicates whether or not multiple values are allowed for array types where such a restriction is
        /// possible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleValuesDisallowed")]
        public virtual System.Nullable<bool> MultipleValuesDisallowed { get; set; }

        /// <summary>column name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Additional details about a relationship column. Specified when data_type is relationship.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipDetails")]
        public virtual RelationshipDetails RelationshipDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TablesService.CreateRow.</summary>
    public class CreateRowRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The parent table where this row will be created. Format: tables/{table}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. The row to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual Row Row { get; set; }

        /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual string View { get; set; }

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

    /// <summary>A single item in a labeled column.</summary>
    public class LabeledItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Internal id associated with the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Display string as entered by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for TablesService.ListRows.</summary>
    public class ListRowsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The rows from the specified table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for TablesService.ListTables.</summary>
    public class ListTablesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<Table> Tables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for TablesService.ListWorkspaces.</summary>
    public class ListWorkspacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is empty, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of workspaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaces")]
        public virtual System.Collections.Generic.IList<Workspace> Workspaces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a lookup column whose value comes from the associated relationship.</summary>
    public class LookupDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the relationship column associated with the lookup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipColumn")]
        public virtual string RelationshipColumn { get; set; }

        /// <summary>The id of the relationship column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relationshipColumnId")]
        public virtual string RelationshipColumnId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a relationship column.</summary>
    public class RelationshipDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the table this relationship is linked to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedTable")]
        public virtual string LinkedTable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single row in a table.</summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time when the row was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The resource name of the row. Row names have the form `tables/{table}/rows/{row}`. The name is ignored when
        /// creating a row.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Time when the row was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// The values of the row. This is a map of column key to value. Key is user entered name(default) or the
        /// internal column id based on the view in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IDictionary<string, object> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A saved view of a table. NextId: 3</summary>
    public class SavedView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Internal id associated with the saved view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Display name of the saved view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single table. NextId: 7</summary>
    public class Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of columns in this table. Order of columns matches the display order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<ColumnDescription> Columns { get; set; }

        /// <summary>Time when the table was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The human readable title of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The resource name of the table. Table names have the form `tables/{table}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Saved views for this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("savedViews")]
        public virtual System.Collections.Generic.IList<SavedView> SavedViews { get; set; }

        /// <summary>Time when the table was last updated excluding updates to individual rows</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for TablesService.UpdateRow.</summary>
    public class UpdateRowRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The row to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("row")]
        public virtual Row Row { get; set; }

        /// <summary>The list of fields to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>Optional. Column key to use for values in the row. Defaults to user entered name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("view")]
        public virtual string View { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single workspace.</summary>
    public class Workspace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time when the workspace was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The human readable title of the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The resource name of the workspace. Workspace names have the form `workspaces/{workspace}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The list of tables in the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tables")]
        public virtual System.Collections.Generic.IList<Table> Tables { get; set; }

        /// <summary>Time when the workspace was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
