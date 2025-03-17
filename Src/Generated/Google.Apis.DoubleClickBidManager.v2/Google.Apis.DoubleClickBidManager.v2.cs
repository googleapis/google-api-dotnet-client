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

namespace Google.Apis.DoubleClickBidManager.v2
{
    /// <summary>The DoubleClickBidManager Service.</summary>
    public class DoubleClickBidManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DoubleClickBidManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DoubleClickBidManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Queries = new QueriesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://doubleclickbidmanager.googleapis.com/v2/");
            BatchUri = GetEffectiveUri(null, "https://doubleclickbidmanager.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "doubleclickbidmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "v2/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the DoubleClick Bid Manager API.</summary>
        public class Scope
        {
            /// <summary>View and manage your reports in DoubleClick Bid Manager</summary>
            public static string Doubleclickbidmanager = "https://www.googleapis.com/auth/doubleclickbidmanager";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the DoubleClick Bid Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your reports in DoubleClick Bid Manager</summary>
            public const string Doubleclickbidmanager = "https://www.googleapis.com/auth/doubleclickbidmanager";
        }

        /// <summary>Gets the Queries resource.</summary>
        public virtual QueriesResource Queries { get; }
    }

    /// <summary>A base abstract class for DoubleClickBidManager requests.</summary>
    public abstract class DoubleClickBidManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DoubleClickBidManagerBaseServiceRequest instance.</summary>
        protected DoubleClickBidManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DoubleClickBidManager parameter list.</summary>
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

    /// <summary>The "queries" collection of methods.</summary>
    public class QueriesResource
    {
        private const string Resource = "queries";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public QueriesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Reports = new ReportsResource(service);
        }

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }

        /// <summary>The "reports" collection of methods.</summary>
        public class ReportsResource
        {
            private const string Resource = "reports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieves a report.</summary>
            /// <param name="queryId">Required. The ID of the query that generated the report.</param>
            /// <param name="reportId">Required. The ID of the query to retrieve.</param>
            public virtual GetRequest Get(long queryId, long reportId)
            {
                return new GetRequest(this.service, queryId, reportId);
            }

            /// <summary>Retrieves a report.</summary>
            public class GetRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v2.Data.Report>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, long queryId, long reportId) : base(service)
                {
                    QueryId = queryId;
                    ReportId = reportId;
                    InitParameters();
                }

                /// <summary>Required. The ID of the query that generated the report.</summary>
                [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long QueryId { get; private set; }

                /// <summary>Required. The ID of the query to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("reportId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long ReportId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "queries/{queryId}/reports/{reportId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("queryId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "queryId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("reportId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "reportId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists reports generated by the provided query.</summary>
            /// <param name="queryId">Required. The ID of the query that generated the reports.</param>
            public virtual ListRequest List(long queryId)
            {
                return new ListRequest(this.service, queryId);
            }

            /// <summary>Lists reports generated by the provided query.</summary>
            public class ListRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v2.Data.ListReportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long queryId) : base(service)
                {
                    QueryId = queryId;
                    InitParameters();
                }

                /// <summary>Required. The ID of the query that generated the reports.</summary>
                [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long QueryId { get; private set; }

                /// <summary>
                /// Field to sort the list by. Accepts the following values: * `key.reportId` (default) The default
                /// sorting order is ascending. To specify descending order for a field, add the suffix `desc` to the
                /// field name. For example, `key.reportId desc`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Maximum number of results per page. Must be between `1` and `100`. Defaults to `100` if unspecified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying which page of results the server should return. Typically, this is the value of
                /// nextPageToken returned from the previous call to the `queries.reports.list` method. If unspecified,
                /// the first page of results is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "queries/{queryId}/reports";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("queryId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "queryId",
                        IsRequired = true,
                        ParameterType = "path",
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

        /// <summary>Creates a new query.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.DoubleClickBidManager.v2.Data.Query body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>Creates a new query.</summary>
        public class CreateRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v2.Data.Query>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DoubleClickBidManager.v2.Data.Query body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DoubleClickBidManager.v2.Data.Query Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "queries";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Deletes an existing query as well as its generated reports.</summary>
        /// <param name="queryId">Required. The ID of the query to delete.</param>
        public virtual DeleteRequest Delete(long queryId)
        {
            return new DeleteRequest(this.service, queryId);
        }

        /// <summary>Deletes an existing query as well as its generated reports.</summary>
        public class DeleteRequest : DoubleClickBidManagerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, long queryId) : base(service)
            {
                QueryId = queryId;
                InitParameters();
            }

            /// <summary>Required. The ID of the query to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long QueryId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "queries/{queryId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("queryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "queryId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a query.</summary>
        /// <param name="queryId">Required. The ID of the query to retrieve.</param>
        public virtual GetRequest Get(long queryId)
        {
            return new GetRequest(this.service, queryId);
        }

        /// <summary>Retrieves a query.</summary>
        public class GetRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v2.Data.Query>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long queryId) : base(service)
            {
                QueryId = queryId;
                InitParameters();
            }

            /// <summary>Required. The ID of the query to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long QueryId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "queries/{queryId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("queryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "queryId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists queries created by the current user.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists queries created by the current user.</summary>
        public class ListRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v2.Data.ListQueriesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Field to sort the list by. Accepts the following values: * `queryId` (default) * `metadata.title` The
            /// default sorting order is ascending. To specify descending order for a field, add the suffix `desc` to
            /// the field name. For example, `queryId desc`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Maximum number of results per page. Must be between `1` and `100`. Defaults to `100` if unspecified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying which page of results the server should return. Typically, this is the value of
            /// nextPageToken, returned from the previous call to the `queries.list` method. If unspecified, the first
            /// page of results is returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "queries";

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

        /// <summary>Runs an existing query to generate a report.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="queryId">Required. The ID of the query to run.</param>
        public virtual RunRequest Run(Google.Apis.DoubleClickBidManager.v2.Data.RunQueryRequest body, long queryId)
        {
            return new RunRequest(this.service, body, queryId);
        }

        /// <summary>Runs an existing query to generate a report.</summary>
        public class RunRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v2.Data.Report>
        {
            /// <summary>Constructs a new Run request.</summary>
            public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.DoubleClickBidManager.v2.Data.RunQueryRequest body, long queryId) : base(service)
            {
                QueryId = queryId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The ID of the query to run.</summary>
            [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long QueryId { get; private set; }

            /// <summary>
            /// Whether the query should be run synchronously. When `true`, the request won't return until the resulting
            /// report has finished running. This parameter is `false` by default. Setting this parameter to `true` is
            /// **not recommended**.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("synchronous", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Synchronous { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DoubleClickBidManager.v2.Data.RunQueryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "run";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "queries/{queryId}:run";

            /// <summary>Initializes Run parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("queryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "queryId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("synchronous", new Google.Apis.Discovery.Parameter
                {
                    Name = "synchronous",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.DoubleClickBidManager.v2.Data
{
    /// <summary>The date range to be reported on.</summary>
    public class DataRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `CUSTOM_DATES` is assigned to range, this field specifies the end date for the date range that is
        /// reported on. This field is required if using `CUSTOM_DATES` range and will be ignored otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customEndDate")]
        public virtual Date CustomEndDate { get; set; }

        /// <summary>
        /// If `CUSTOM_DATES` is assigned to range, this field specifies the starting date for the date range that is
        /// reported on. This field is required if using `CUSTOM_DATES` range and will be ignored otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customStartDate")]
        public virtual Date CustomStartDate { get; set; }

        /// <summary>
        /// The preset date range to be reported on. If `CUSTOM_DATES` is assigned to this field, fields
        /// custom_start_date and custom_end_date must be set to specify the custom date range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual string Range { get; set; }

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

    /// <summary>Represents a single filter rule.</summary>
    public class FilterPair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of value to filter by. Defined by a
        /// [Filter](/bid-manager/reference/rest/v2/filters-metrics#filters) value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The identifying value to filter by, such as a relevant resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListQueriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the page_token field in the subsequent call
        /// to `queries.list` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of queries. This field will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual System.Collections.Generic.IList<Query> Queries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the page_token field in the subsequent call
        /// to `queries.reports.list` method to retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of reports. This field will be absent if empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Report parameter options.</summary>
    public class Options : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether to include data for audience lists specifically targeted by filtered line items or insertion orders.
        /// Requires the use of `FILTER_INSERTION_ORDER` or `FILTER_LINE_ITEM` filters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeOnlyTargetedUserLists")]
        public virtual System.Nullable<bool> IncludeOnlyTargetedUserLists { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters of a generated report.</summary>
    public class Parameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filters to limit the scope of reported data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<FilterPair> Filters { get; set; }

        /// <summary>
        /// Dimensions by which to segment and group the data. Defined by
        /// [Filter](/bid-manager/reference/rest/v2/filters-metrics#filters) values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupBys")]
        public virtual System.Collections.Generic.IList<string> GroupBys { get; set; }

        /// <summary>
        /// Metrics to define the data populating the report. Defined by
        /// [Metric](/bid-manager/reference/rest/v2/filters-metrics#metrics) values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>Additional report parameter options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual Options Options { get; set; }

        /// <summary>
        /// The type of the report. The type of the report determines the dimesions, filters, and metrics that can be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single query used to generate a report.</summary>
    public class Query : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metadata of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual QueryMetadata Metadata { get; set; }

        /// <summary>The parameters of the report generated by the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual Parameters Params__ { get; set; }

        /// <summary>Output only. The unique ID of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryId")]
        public virtual System.Nullable<long> QueryId { get; set; }

        /// <summary>
        /// When and how often the query is scheduled to run. If the frequency field is set to `ONE_TIME`, the query
        /// will only run when queries.run is called.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual QuerySchedule Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata of the query.</summary>
    public class QueryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date range the report generated by the query will report on. This date range will be defined by the time
        /// zone as used by the advertiser.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRange")]
        public virtual DataRange DataRange { get; set; }

        /// <summary>The format of the report generated by the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Whether an email notification is sent to the query creator when a report generated by the query is ready.
        /// This value is `false` by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendNotification")]
        public virtual System.Nullable<bool> SendNotification { get; set; }

        /// <summary>
        /// List of additional email addresses with which to share the query. If send_notification is `true`, these
        /// email addresses will receive a notification when a report generated by the query is ready. If these email
        /// addresses are connected to Display &amp;amp; Video 360 users, the query will be available to them in the
        /// Display &amp;amp; Video 360 interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareEmailAddress")]
        public virtual System.Collections.Generic.IList<string> ShareEmailAddress { get; set; }

        /// <summary>
        /// The display name of the query. This value will be used in the file name of reports generated by the query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings on when and how frequently to run a query.</summary>
    public class QuerySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date on which to end the scheduled runs. This field is required if frequency is not set to `ONE_TIME`.
        /// Otherwise, it will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>
        /// How frequently to run the query. If set to `ONE_TIME`, the query will only be run when queries.run is
        /// called.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual string Frequency { get; set; }

        /// <summary>
        /// The canonical code for the timezone the query schedule is based on. Scheduled runs are usually conducted in
        /// the morning of a given day. Defaults to `America/New_York`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRunTimezoneCode")]
        public virtual string NextRunTimezoneCode { get; set; }

        /// <summary>
        /// The date on which to begin the scheduled runs. This field is required if frequency is not set to `ONE_TIME`.
        /// Otherwise, it will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single report generated by its parent report.</summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key information identifying the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual ReportKey Key { get; set; }

        /// <summary>The metadata of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ReportMetadata Metadata { get; set; }

        /// <summary>The parameters of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual Parameters Params__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifying information of a report.</summary>
    public class ReportKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique ID of the query that generated the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryId")]
        public virtual System.Nullable<long> QueryId { get; set; }

        /// <summary>Output only. The unique ID of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportId")]
        public virtual System.Nullable<long> ReportId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The metadata of a report.</summary>
    public class ReportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The location of the generated report file in Google Cloud Storage. This field will be absent if
        /// status.state is not `DONE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudStoragePath")]
        public virtual string GoogleCloudStoragePath { get; set; }

        /// <summary>The end date of the report data date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataEndDate")]
        public virtual Date ReportDataEndDate { get; set; }

        /// <summary>The start date of the report data date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataStartDate")]
        public virtual Date ReportDataStartDate { get; set; }

        /// <summary>The status of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ReportStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of a report.</summary>
    public class ReportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _finishTimeRaw;

        private object _finishTime;

        /// <summary>
        /// Output only. The timestamp of when report generation finished successfully or in failure. This field will
        /// not be set unless state is `DONE` or `FAILED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual string FinishTimeRaw
        {
            get => _finishTimeRaw;
            set
            {
                _finishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _finishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FinishTimeDateTimeOffset instead.")]
        public virtual object FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _finishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FinishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FinishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FinishTimeRaw);
            set => FinishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The format of the generated report file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Output only. The state of the report generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details specifying how to run a query.</summary>
    public class RunQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date range used by the query to generate the report. If unspecified, the query's original data_range is
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRange")]
        public virtual DataRange DataRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
