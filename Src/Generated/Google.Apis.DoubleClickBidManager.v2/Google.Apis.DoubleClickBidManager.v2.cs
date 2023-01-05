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
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "doubleclickbidmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://doubleclickbidmanager.googleapis.com/v2/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "v2/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://doubleclickbidmanager.googleapis.com/batch";

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
            /// <param name="queryId">Required. ID of the query the report is associated with.</param>
            /// <param name="reportId">Required. ID of the report to retrieve.</param>
            public virtual GetRequest Get(long queryId, long reportId)
            {
                return new GetRequest(service, queryId, reportId);
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

                /// <summary>Required. ID of the query the report is associated with.</summary>
                [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long QueryId { get; private set; }

                /// <summary>Required. ID of the report to retrieve.</summary>
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

            /// <summary>Lists reports associated with a query.</summary>
            /// <param name="queryId">Required. ID of the query with which the reports are associated.</param>
            public virtual ListRequest List(long queryId)
            {
                return new ListRequest(service, queryId);
            }

            /// <summary>Lists reports associated with a query.</summary>
            public class ListRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v2.Data.ListReportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, long queryId) : base(service)
                {
                    QueryId = queryId;
                    InitParameters();
                }

                /// <summary>Required. ID of the query with which the reports are associated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long QueryId { get; private set; }

                /// <summary>
                /// Name of a field used to order results. The default sorting order is ascending. To specify descending
                /// order for a field, append a " desc" suffix. For example "key.reportId desc". Sorting is only
                /// supported for the following fields: * `key.reportId`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Maximum number of results per page. Must be between `1` and `100`. Defaults to `100` if unspecified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous list call. Provide this to retrieve the subsequent page of
                /// reports.
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

        /// <summary>Creates a query.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.DoubleClickBidManager.v2.Data.Query body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a query.</summary>
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

        /// <summary>Deletes a query as well as the associated reports.</summary>
        /// <param name="queryId">Required. ID of query to delete.</param>
        public virtual DeleteRequest Delete(long queryId)
        {
            return new DeleteRequest(service, queryId);
        }

        /// <summary>Deletes a query as well as the associated reports.</summary>
        public class DeleteRequest : DoubleClickBidManagerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, long queryId) : base(service)
            {
                QueryId = queryId;
                InitParameters();
            }

            /// <summary>Required. ID of query to delete.</summary>
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
        /// <param name="queryId">Required. ID of query to retrieve.</param>
        public virtual GetRequest Get(long queryId)
        {
            return new GetRequest(service, queryId);
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

            /// <summary>Required. ID of query to retrieve.</summary>
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
            return new ListRequest(service);
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
            /// Name of a field used to order results. The default sorting order is ascending. To specify descending
            /// order for a field, append a " desc" suffix. For example "metadata.title desc". Sorting is only supported
            /// for the following fields: * `queryId` * `metadata.title`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Maximum number of results per page. Must be between `1` and `100`. Defaults to `100` if unspecified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous list call. Provide this to retrieve the subsequent page of
            /// queries.
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

        /// <summary>Runs a stored query to generate a report.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="queryId">Required. ID of query to run.</param>
        public virtual RunRequest Run(Google.Apis.DoubleClickBidManager.v2.Data.RunQueryRequest body, long queryId)
        {
            return new RunRequest(service, body, queryId);
        }

        /// <summary>Runs a stored query to generate a report.</summary>
        public class RunRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v2.Data.Report>
        {
            /// <summary>Constructs a new Run request.</summary>
            public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.DoubleClickBidManager.v2.Data.RunQueryRequest body, long queryId) : base(service)
            {
                QueryId = queryId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. ID of query to run.</summary>
            [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long QueryId { get; private set; }

            /// <summary>
            /// Whether the query should be run synchronously. When true, this method will not return until the query
            /// has finished running. When false or not specified, this method will return immediately.
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
    /// <summary>
    /// A channel grouping defines a set of rules that can be used to categorize events in a path report.
    /// </summary>
    public class ChannelGrouping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name to apply to an event that does not match any of the rules in the channel grouping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fallbackName")]
        public virtual string FallbackName { get; set; }

        /// <summary>Channel Grouping name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Rules within Channel Grouping. There is a limit of 100 rules that can be set per channel grouping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<Rule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Report data range.</summary>
    public class DataRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ending date for the data that is shown in the report. Note, `customEndDate` is required if `range` is
        /// `CUSTOM_DATES` and ignored otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customEndDate")]
        public virtual Date CustomEndDate { get; set; }

        /// <summary>
        /// The starting data for the data that is shown in the report. Note, `customStartDate` is required if `range`
        /// is `CUSTOM_DATES` and ignored otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customStartDate")]
        public virtual Date CustomStartDate { get; set; }

        /// <summary>Report data range used to generate the report.</summary>
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

    /// <summary>DisjunctiveMatchStatement that OR's all contained filters.</summary>
    public class DisjunctiveMatchStatement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filters. There is a limit of 100 filters that can be set per disjunctive match statement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventFilters")]
        public virtual System.Collections.Generic.IList<EventFilter> EventFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the type of filter to be applied to the path, a DV360 event dimension filter.</summary>
    public class EventFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filter on a dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilter")]
        public virtual PathQueryOptionsFilter DimensionFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter used to match traffic data in your report.</summary>
    public class FilterPair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filter type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Filter value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListQueriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as page_token to retrieve the next page of queries. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual System.Collections.Generic.IList<Query> Queries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as page_token to retrieve the next page of reports. If this field is omitted,
        /// there are no subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Retrieved reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional query options.</summary>
    public class Options : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set to true and filter your report by `FILTER_INSERTION_ORDER` or `FILTER_LINE_ITEM` to include data for
        /// audience lists specifically targeted by those items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeOnlyTargetedUserLists")]
        public virtual System.Nullable<bool> IncludeOnlyTargetedUserLists { get; set; }

        /// <summary>Options that contain Path Filters and Custom Channel Groupings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathQueryOptions")]
        public virtual PathQueryOptions PathQueryOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters of a query or report.</summary>
    public class Parameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filters used to match traffic data in your report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<FilterPair> Filters { get; set; }

        /// <summary>Data is grouped by the filters listed in this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupBys")]
        public virtual System.Collections.Generic.IList<string> GroupBys { get; set; }

        /// <summary>Metrics to include as columns in your report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>Additional query options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual Options Options { get; set; }

        /// <summary>
        /// The type of the report. The type of the report will dictate what dimesions, filters, and metrics can be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Path filters specify which paths to include in a report. A path is the result of combining DV360 events based on
    /// User ID to create a workflow of users' actions. When a path filter is set, the resulting report will only
    /// include paths that match the specified event at the specified position. All other paths will be excluded.
    /// </summary>
    public class PathFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filter on an event to be applied to some part of the path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventFilters")]
        public virtual System.Collections.Generic.IList<EventFilter> EventFilters { get; set; }

        /// <summary>The position of the path the filter should match to (first, last, or any event in path).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathMatchPosition")]
        public virtual string PathMatchPosition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Path Query Options for Report Options.</summary>
    public class PathQueryOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Channel Groupings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelGrouping")]
        public virtual ChannelGrouping ChannelGrouping { get; set; }

        /// <summary>Path Filters. There is a limit of 100 path filters that can be set per report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathFilters")]
        public virtual System.Collections.Generic.IList<PathFilter> PathFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension filter on path events.</summary>
    public class PathQueryOptionsFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dimension the filter is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Match logic of the filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("match")]
        public virtual string Match { get; set; }

        /// <summary>Values to filter on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a query.</summary>
    public class Query : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Query metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual QueryMetadata Metadata { get; set; }

        /// <summary>Query parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual Parameters Params__ { get; set; }

        /// <summary>Output only. Query ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryId")]
        public virtual System.Nullable<long> QueryId { get; set; }

        /// <summary>
        /// Information on how often and when to run a query. If `ONE_TIME` is set to the frequency field, the query
        /// will only be run at the time of creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual QuerySchedule Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Query metadata.</summary>
    public class QueryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Range of report data. All reports will be based on the same time zone as used by the advertiser.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRange")]
        public virtual DataRange DataRange { get; set; }

        /// <summary>Format of the generated report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Whether to send an email notification when a report is ready. Defaults to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendNotification")]
        public virtual System.Nullable<bool> SendNotification { get; set; }

        /// <summary>
        /// List of email addresses which are sent email notifications when the report is finished. Separate from
        /// send_notification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareEmailAddress")]
        public virtual System.Collections.Generic.IList<string> ShareEmailAddress { get; set; }

        /// <summary>Query title. It is used to name the reports generated from this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information on when and how frequently to run a query.</summary>
    public class QuerySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date to periodically run the query until. Not applicable to `ONE_TIME` frequency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>How often the query is run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual string Frequency { get; set; }

        /// <summary>Canonical timezone code for report generation time. Defaults to `America/New_York`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRunTimezoneCode")]
        public virtual string NextRunTimezoneCode { get; set; }

        /// <summary>When to start running the query. Not applicable to `ONE_TIME` frequency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a report.</summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key used to identify a report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual ReportKey Key { get; set; }

        /// <summary>Report metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ReportMetadata Metadata { get; set; }

        /// <summary>Report parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual Parameters Params__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Key used to identify a report.</summary>
    public class ReportKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Query ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryId")]
        public virtual System.Nullable<long> QueryId { get; set; }

        /// <summary>Output only. Report ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportId")]
        public virtual System.Nullable<long> ReportId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Report metadata.</summary>
    public class ReportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The path to the location in Google Cloud Storage where the report is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudStoragePath")]
        public virtual string GoogleCloudStoragePath { get; set; }

        /// <summary>The ending time for the data that is shown in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataEndDate")]
        public virtual Date ReportDataEndDate { get; set; }

        /// <summary>The starting time for the data that is shown in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataStartDate")]
        public virtual Date ReportDataStartDate { get; set; }

        /// <summary>Report status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ReportStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Report status.</summary>
    public class ReportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when this report either completed successfully or failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTime")]
        public virtual object FinishTime { get; set; }

        /// <summary>The file type of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Output only. The state of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Rule defines a name, and a boolean expression in [conjunctive normal form]
    /// (http://mathworld.wolfram.com/ConjunctiveNormalForm.html){.external} that can be applied to a path event to
    /// determine if that name should be applied.
    /// </summary>
    public class Rule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// DisjunctiveMatchStatements within a Rule. DisjunctiveMatchStatement OR's all contained filters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disjunctiveMatchStatements")]
        public virtual System.Collections.Generic.IList<DisjunctiveMatchStatement> DisjunctiveMatchStatements { get; set; }

        /// <summary>Rule name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to run a stored query to generate a report.</summary>
    public class RunQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Report data range used to generate the report. If unspecified, the original parent query's data range is
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRange")]
        public virtual DataRange DataRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
