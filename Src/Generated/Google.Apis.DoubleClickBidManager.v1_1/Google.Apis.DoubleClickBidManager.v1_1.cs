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

namespace Google.Apis.DoubleClickBidManager.v1_1
{
    /// <summary>The DoubleClickBidManager Service.</summary>
    public class DoubleClickBidManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1.1";

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
            Reports = new ReportsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "doubleclickbidmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://doubleclickbidmanager.googleapis.com/doubleclickbidmanager/v1.1/";
        #else
            "https://doubleclickbidmanager.googleapis.com/doubleclickbidmanager/v1.1/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "doubleclickbidmanager/v1.1/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://doubleclickbidmanager.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

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

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }
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
        }

        /// <summary>Creates a query.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreatequeryRequest Createquery(Google.Apis.DoubleClickBidManager.v1_1.Data.Query body)
        {
            return new CreatequeryRequest(service, body);
        }

        /// <summary>Creates a query.</summary>
        public class CreatequeryRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v1_1.Data.Query>
        {
            /// <summary>Constructs a new Createquery request.</summary>
            public CreatequeryRequest(Google.Apis.Services.IClientService service, Google.Apis.DoubleClickBidManager.v1_1.Data.Query body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// If true, tries to run the query asynchronously. Only applicable when the frequency is ONE_TIME.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("asynchronous", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Asynchronous { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DoubleClickBidManager.v1_1.Data.Query Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createquery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "query";

            /// <summary>Initializes Createquery parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("asynchronous", new Google.Apis.Discovery.Parameter
                {
                    Name = "asynchronous",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a stored query as well as the associated stored reports.</summary>
        /// <param name="queryId">Query ID to delete.</param>
        public virtual DeletequeryRequest Deletequery(long queryId)
        {
            return new DeletequeryRequest(service, queryId);
        }

        /// <summary>Deletes a stored query as well as the associated stored reports.</summary>
        public class DeletequeryRequest : DoubleClickBidManagerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Deletequery request.</summary>
            public DeletequeryRequest(Google.Apis.Services.IClientService service, long queryId) : base(service)
            {
                QueryId = queryId;
                InitParameters();
            }

            /// <summary>Query ID to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long QueryId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deletequery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "query/{queryId}";

            /// <summary>Initializes Deletequery parameter list.</summary>
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

        /// <summary>Retrieves a stored query.</summary>
        /// <param name="queryId">Query ID to retrieve.</param>
        public virtual GetqueryRequest Getquery(long queryId)
        {
            return new GetqueryRequest(service, queryId);
        }

        /// <summary>Retrieves a stored query.</summary>
        public class GetqueryRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v1_1.Data.Query>
        {
            /// <summary>Constructs a new Getquery request.</summary>
            public GetqueryRequest(Google.Apis.Services.IClientService service, long queryId) : base(service)
            {
                QueryId = queryId;
                InitParameters();
            }

            /// <summary>Query ID to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long QueryId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getquery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "query/{queryId}";

            /// <summary>Initializes Getquery parameter list.</summary>
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

        /// <summary>Retrieves stored queries.</summary>
        public virtual ListqueriesRequest Listqueries()
        {
            return new ListqueriesRequest(service);
        }

        /// <summary>Retrieves stored queries.</summary>
        public class ListqueriesRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v1_1.Data.ListQueriesResponse>
        {
            /// <summary>Constructs a new Listqueries request.</summary>
            public ListqueriesRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Maximum number of results per page. Must be between 1 and 100. Defaults to 100 if unspecified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional pagination token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listqueries";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "queries";

            /// <summary>Initializes Listqueries parameter list.</summary>
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

        /// <summary>Runs a stored query to generate a report.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="queryId">Query ID to run.</param>
        public virtual RunqueryRequest Runquery(Google.Apis.DoubleClickBidManager.v1_1.Data.RunQueryRequest body, long queryId)
        {
            return new RunqueryRequest(service, body, queryId);
        }

        /// <summary>Runs a stored query to generate a report.</summary>
        public class RunqueryRequest : DoubleClickBidManagerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Runquery request.</summary>
            public RunqueryRequest(Google.Apis.Services.IClientService service, Google.Apis.DoubleClickBidManager.v1_1.Data.RunQueryRequest body, long queryId) : base(service)
            {
                QueryId = queryId;
                Body = body;
                InitParameters();
            }

            /// <summary>Query ID to run.</summary>
            [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long QueryId { get; private set; }

            /// <summary>If true, tries to run the query asynchronously.</summary>
            [Google.Apis.Util.RequestParameterAttribute("asynchronous", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Asynchronous { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DoubleClickBidManager.v1_1.Data.RunQueryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runquery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "query/{queryId}";

            /// <summary>Initializes Runquery parameter list.</summary>
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
                RequestParameters.Add("asynchronous", new Google.Apis.Discovery.Parameter
                {
                    Name = "asynchronous",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
            }
        }
    }

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

        /// <summary>Retrieves stored reports.</summary>
        /// <param name="queryId">Query ID with which the reports are associated.</param>
        public virtual ListreportsRequest Listreports(long queryId)
        {
            return new ListreportsRequest(service, queryId);
        }

        /// <summary>Retrieves stored reports.</summary>
        public class ListreportsRequest : DoubleClickBidManagerBaseServiceRequest<Google.Apis.DoubleClickBidManager.v1_1.Data.ListReportsResponse>
        {
            /// <summary>Constructs a new Listreports request.</summary>
            public ListreportsRequest(Google.Apis.Services.IClientService service, long queryId) : base(service)
            {
                QueryId = queryId;
                InitParameters();
            }

            /// <summary>Query ID with which the reports are associated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("queryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long QueryId { get; private set; }

            /// <summary>
            /// Maximum number of results per page. Must be between 1 and 100. Defaults to 100 if unspecified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional pagination token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listreports";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "queries/{queryId}/reports";

            /// <summary>Initializes Listreports parameter list.</summary>
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
namespace Google.Apis.DoubleClickBidManager.v1_1.Data
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

    /// <summary>List queries response.</summary>
    public class ListQueriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string
        /// "doubleclickbidmanager#listQueriesResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Next page's pagination token if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Retrieved queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual System.Collections.Generic.IList<Query> Queries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List reports response.</summary>
    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string
        /// "doubleclickbidmanager#listReportsResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Next page's pagination token if one exists.</summary>
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

        /// <summary>Deprecated. This field is no longer in use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeInviteData")]
        public virtual System.Nullable<bool> IncludeInviteData { get; set; }

        /// <summary>Metrics to include as columns in your report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>Additional query options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual Options Options { get; set; }

        /// <summary>Report type.</summary>
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

        /// <summary>
        /// Indicates the position of the path the filter should match to (first, last, or any event in path).
        /// </summary>
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

    /// <summary>Dimension Filter on path events.</summary>
    public class PathQueryOptionsFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dimension the filter is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Indicates how the filter should be matched to the value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("match")]
        public virtual string Match { get; set; }

        /// <summary>Value to filter on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a query.</summary>
    public class Query : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this is. Value: the fixed string "doubleclickbidmanager#query".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Query metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual QueryMetadata Metadata { get; set; }

        /// <summary>Query parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual Parameters Params__ { get; set; }

        /// <summary>Query ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryId")]
        public virtual System.Nullable<long> QueryId { get; set; }

        /// <summary>
        /// The ending time for the data that is shown in the report. Note, reportDataEndTimeMs is required if
        /// metadata.dataRange is CUSTOM_DATES and ignored otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataEndTimeMs")]
        public virtual System.Nullable<long> ReportDataEndTimeMs { get; set; }

        /// <summary>
        /// The starting time for the data that is shown in the report. Note, reportDataStartTimeMs is required if
        /// metadata.dataRange is CUSTOM_DATES and ignored otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataStartTimeMs")]
        public virtual System.Nullable<long> ReportDataStartTimeMs { get; set; }

        /// <summary>Information on how often and when to run a query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual QuerySchedule Schedule { get; set; }

        /// <summary>Canonical timezone code for report data time. Defaults to America/New_York.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezoneCode")]
        public virtual string TimezoneCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Query metadata.</summary>
    public class QueryMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Range of report data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRange")]
        public virtual string DataRange { get; set; }

        /// <summary>Format of the generated report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>The path to the location in Google Cloud Storage where the latest report is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudStoragePathForLatestReport")]
        public virtual string GoogleCloudStoragePathForLatestReport { get; set; }

        /// <summary>The path in Google Drive for the latest report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleDrivePathForLatestReport")]
        public virtual string GoogleDrivePathForLatestReport { get; set; }

        /// <summary>The time when the latest report started to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestReportRunTimeMs")]
        public virtual System.Nullable<long> LatestReportRunTimeMs { get; set; }

        /// <summary>
        /// Locale of the generated reports. Valid values are cs CZECH de GERMAN en ENGLISH es SPANISH fr FRENCH it
        /// ITALIAN ja JAPANESE ko KOREAN pl POLISH pt-BR BRAZILIAN_PORTUGUESE ru RUSSIAN tr TURKISH uk UKRAINIAN zh-CN
        /// CHINA_CHINESE zh-TW TAIWAN_CHINESE An locale string not in the list above will generate reports in English.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>Number of reports that have been generated for the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCount")]
        public virtual System.Nullable<int> ReportCount { get; set; }

        /// <summary>Whether the latest report is currently running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("running")]
        public virtual System.Nullable<bool> Running { get; set; }

        /// <summary>Whether to send an email notification when a report is ready. Default to false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendNotification")]
        public virtual System.Nullable<bool> SendNotification { get; set; }

        /// <summary>
        /// List of email addresses which are sent email notifications when the report is finished. Separate from
        /// sendNotification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareEmailAddress")]
        public virtual System.Collections.Generic.IList<string> ShareEmailAddress { get; set; }

        /// <summary>Query title. It is used to name the reports generated from this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information on how frequently and when to run a query.</summary>
    public class QuerySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Datetime to periodically run the query until.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeMs")]
        public virtual System.Nullable<long> EndTimeMs { get; set; }

        /// <summary>How often the query is run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual string Frequency { get; set; }

        /// <summary>
        /// Time of day at which a new report will be generated, represented as minutes past midnight. Range is 0 to
        /// 1439. Only applies to scheduled reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRunMinuteOfDay")]
        public virtual System.Nullable<int> NextRunMinuteOfDay { get; set; }

        /// <summary>Canonical timezone code for report generation time. Defaults to America/New_York.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRunTimezoneCode")]
        public virtual string NextRunTimezoneCode { get; set; }

        /// <summary>When to start running the query. Not applicable to `ONE_TIME` frequency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMs")]
        public virtual System.Nullable<long> StartTimeMs { get; set; }

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

    /// <summary>An explanation of a report failure.</summary>
    public class ReportFailure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error code that shows why the report was not created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Key used to identify a report.</summary>
    public class ReportKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Query ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryId")]
        public virtual System.Nullable<long> QueryId { get; set; }

        /// <summary>Report ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportId")]
        public virtual System.Nullable<long> ReportId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Report metadata.</summary>
    public class ReportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The path to the location in Google Cloud Storage where the report is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudStoragePath")]
        public virtual string GoogleCloudStoragePath { get; set; }

        /// <summary>The ending time for the data that is shown in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataEndTimeMs")]
        public virtual System.Nullable<long> ReportDataEndTimeMs { get; set; }

        /// <summary>The starting time for the data that is shown in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataStartTimeMs")]
        public virtual System.Nullable<long> ReportDataStartTimeMs { get; set; }

        /// <summary>Report status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ReportStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Report status.</summary>
    public class ReportStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the report failed, this records the cause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failure")]
        public virtual ReportFailure Failure { get; set; }

        /// <summary>The time when this report either completed successfully or failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finishTimeMs")]
        public virtual System.Nullable<long> FinishTimeMs { get; set; }

        /// <summary>The file type of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>The state of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Rule defines a name, and a boolean expression in [conjunctive normal form](http:
    /// //mathworld.wolfram.com/ConjunctiveNormalForm.html){.external} that can be // applied to a path event to
    /// determine if that name should be applied.
    /// </summary>
    public class Rule : Google.Apis.Requests.IDirectResponseSchema
    {
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
        /// <summary>Report data range used to generate the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRange")]
        public virtual string DataRange { get; set; }

        /// <summary>
        /// The ending time for the data that is shown in the report. Note, reportDataEndTimeMs is required if dataRange
        /// is CUSTOM_DATES and ignored otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataEndTimeMs")]
        public virtual System.Nullable<long> ReportDataEndTimeMs { get; set; }

        /// <summary>
        /// The starting time for the data that is shown in the report. Note, reportDataStartTimeMs is required if
        /// dataRange is CUSTOM_DATES and ignored otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDataStartTimeMs")]
        public virtual System.Nullable<long> ReportDataStartTimeMs { get; set; }

        /// <summary>Canonical timezone code for report data time. Defaults to America/New_York.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezoneCode")]
        public virtual string TimezoneCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
