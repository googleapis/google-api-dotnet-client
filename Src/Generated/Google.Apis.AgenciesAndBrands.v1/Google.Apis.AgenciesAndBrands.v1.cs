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

namespace Google.Apis.AgenciesAndBrands.v1
{
    /// <summary>The AgenciesAndBrands Service.</summary>
    public class AgenciesAndBrandsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AgenciesAndBrandsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AgenciesAndBrandsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Agencies = new AgenciesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://agenciesandbrands.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://agenciesandbrands.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "agenciesandbrands";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Agencies and Brands API.</summary>
        public class Scope
        {
            /// <summary>View, create, edit, and delete data entities in your Agency account.</summary>
            public static string AgenciesAndBrands = "https://www.googleapis.com/auth/agencies-and-brands";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Agencies and Brands API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View, create, edit, and delete data entities in your Agency account.</summary>
            public const string AgenciesAndBrands = "https://www.googleapis.com/auth/agencies-and-brands";
        }

        /// <summary>Gets the Agencies resource.</summary>
        public virtual AgenciesResource Agencies { get; }
    }

    /// <summary>A base abstract class for AgenciesAndBrands requests.</summary>
    public abstract class AgenciesAndBrandsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AgenciesAndBrandsBaseServiceRequest instance.</summary>
        protected AgenciesAndBrandsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AgenciesAndBrands parameter list.</summary>
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

    /// <summary>The "agencies" collection of methods.</summary>
    public class AgenciesResource
    {
        private const string Resource = "agencies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AgenciesResource(Google.Apis.Services.IClientService service)
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
                Operations = new OperationsResource(service);
                Results = new ResultsResource(service);
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
                public class GetRequest : AgenciesAndBrandsBaseServiceRequest<Google.Apis.AgenciesAndBrands.v1.Data.Operation>
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
                            Pattern = @"^agencies/[^/]+/reports/[^/]+/operations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Results resource.</summary>
            public virtual ResultsResource Results { get; }

            /// <summary>The "results" collection of methods.</summary>
            public class ResultsResource
            {
                private const string Resource = "results";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ResultsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Returns the result rows from a completed report. The caller must have previously called `RunReport`
                /// and waited for that operation to complete. The rows will be returned according to the order
                /// specified by the `sorts` member of the report definition.
                /// </summary>
                /// <param name="name">
                /// The report result being fetched. Format:
                /// `agencies/{account_id}/reports/{report_id}/results/{report_result_id}`
                /// </param>
                public virtual FetchRowsRequest FetchRows(string name)
                {
                    return new FetchRowsRequest(this.service, name);
                }

                /// <summary>
                /// Returns the result rows from a completed report. The caller must have previously called `RunReport`
                /// and waited for that operation to complete. The rows will be returned according to the order
                /// specified by the `sorts` member of the report definition.
                /// </summary>
                public class FetchRowsRequest : AgenciesAndBrandsBaseServiceRequest<Google.Apis.AgenciesAndBrands.v1.Data.FetchReportResultRowsResponse>
                {
                    /// <summary>Constructs a new FetchRows request.</summary>
                    public FetchRowsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The report result being fetched. Format:
                    /// `agencies/{account_id}/reports/{report_id}/results/{report_result_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of rows to return. The service may return fewer than this value. If
                    /// unspecified, at most 1,000 rows will be returned. The maximum value is 10,000; values greater
                    /// than 10,000 will be reduced to 10,000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `FetchReportResultRows` call. Provide this to
                    /// retrieve the second and subsequent batches of rows.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchRows";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:fetchRows";

                    /// <summary>Initializes FetchRows parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^agencies/[^/]+/reports/[^/]+/results/[^/]+$",
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

            /// <summary>Creates a `Report` object.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this `Report` will be created. Format: `agencies/{account_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AgenciesAndBrands.v1.Data.Report body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a `Report` object.</summary>
            public class CreateRequest : AgenciesAndBrandsBaseServiceRequest<Google.Apis.AgenciesAndBrands.v1.Data.Report>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AgenciesAndBrands.v1.Data.Report body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this `Report` will be created. Format: `agencies/{account_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AgenciesAndBrands.v1.Data.Report Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/reports";

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
                        Pattern = @"^agencies/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a `Report` object.</summary>
            /// <param name="name">
            /// Required. Resource name of the report to delete. Format: `agencies/{account_id}/reports/{report_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a `Report` object.</summary>
            public class DeleteRequest : AgenciesAndBrandsBaseServiceRequest<Google.Apis.AgenciesAndBrands.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the report to delete. Format: `agencies/{account_id}/reports/{report_id}`
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
                        Pattern = @"^agencies/[^/]+/reports/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves a `Report` object.</summary>
            /// <param name="name">
            /// Required. The resource name of the report. Format: `agencies/{account_id}/reports/{report_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves a `Report` object.</summary>
            public class GetRequest : AgenciesAndBrandsBaseServiceRequest<Google.Apis.AgenciesAndBrands.v1.Data.Report>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the report. Format: `agencies/{account_id}/reports/{report_id}`
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
                        Pattern = @"^agencies/[^/]+/reports/[^/]+$",
                    });
                }
            }

            /// <summary>Lists `Report` objects.</summary>
            /// <param name="parent">
            /// Required. The parent, which owns this collection of reports. Format: `agencies/{account_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists `Report` objects.</summary>
            public class ListRequest : AgenciesAndBrandsBaseServiceRequest<Google.Apis.AgenciesAndBrands.v1.Data.ListReportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns this collection of reports. Format: `agencies/{account_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Expression to filter the response. See syntax details at
                /// https://developers.google.com/ad-manager/api/beta/filters
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Expression to specify sorting order. See syntax details at
                /// https://developers.google.com/ad-manager/api/beta/filters#order
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Optional. The maximum number of `Reports` to return. The service may return fewer than this value.
                /// If unspecified, at most 50 `Reports` will be returned. The maximum value is 1000; values greater
                /// than 1000 will be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListReports` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListReports` must match the call
                /// that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Optional. Number of individual resources to skip while paginating.</summary>
                [Google.Apis.Util.RequestParameterAttribute("skip", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Skip { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/reports";

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
                        Pattern = @"^agencies/[^/]+$",
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
                    RequestParameters.Add("skip", new Google.Apis.Discovery.Parameter
                    {
                        Name = "skip",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a `Report` object.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the report. Report resource name have the form:
            /// `agencies/{account_id}/reports/{report_id}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AgenciesAndBrands.v1.Data.Report body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a `Report` object.</summary>
            public class PatchRequest : AgenciesAndBrandsBaseServiceRequest<Google.Apis.AgenciesAndBrands.v1.Data.Report>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AgenciesAndBrands.v1.Data.Report body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the report. Report resource name have the form:
                /// `agencies/{account_id}/reports/{report_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AgenciesAndBrands.v1.Data.Report Body { get; set; }

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
                        Pattern = @"^agencies/[^/]+/reports/[^/]+$",
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
            /// Initiates the execution of an existing report asynchronously. Users can get the report by polling this
            /// operation using `OperationsService.GetOperation`. Poll every 5 seconds initially, with an exponential
            /// backoff. Once a report is complete, the operation will contain a `RunReportResponse` in its response
            /// field containing a report_result that can be passed to the `FetchReportResultRows` method to retrieve
            /// the report data.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The report to run. Format: `agencies/{account_id}/reports/{report_id}`
            /// </param>
            public virtual RunRequest Run(Google.Apis.AgenciesAndBrands.v1.Data.RunReportRequest body, string name)
            {
                return new RunRequest(this.service, body, name);
            }

            /// <summary>
            /// Initiates the execution of an existing report asynchronously. Users can get the report by polling this
            /// operation using `OperationsService.GetOperation`. Poll every 5 seconds initially, with an exponential
            /// backoff. Once a report is complete, the operation will contain a `RunReportResponse` in its response
            /// field containing a report_result that can be passed to the `FetchReportResultRows` method to retrieve
            /// the report data.
            /// </summary>
            public class RunRequest : AgenciesAndBrandsBaseServiceRequest<Google.Apis.AgenciesAndBrands.v1.Data.Operation>
            {
                /// <summary>Constructs a new Run request.</summary>
                public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.AgenciesAndBrands.v1.Data.RunReportRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The report to run. Format: `agencies/{account_id}/reports/{report_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AgenciesAndBrands.v1.Data.RunReportRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "run";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:run";

                /// <summary>Initializes Run parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^agencies/[^/]+/reports/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.AgenciesAndBrands.v1.Data
{
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

    /// <summary>A date range for a report.</summary>
    public class DateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A fixed date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixed")]
        public virtual FixedDateRange Fixed__ { get; set; }

        /// <summary>A relative date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relative")]
        public virtual string Relative { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of double values.</summary>
    public class DoubleList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Values { get; set; }

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

    /// <summary>The response message for the fetch report result rows endpoint.</summary>
    public class FetchReportResultRowsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The computed fixed date ranges this report includes. Only returned with the first page of results (when
        /// page_token is not included in the request).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual System.Collections.Generic.IList<FixedDateRange> DateRanges { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Up to `page_size` rows of report data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        private string _runTimeRaw;

        private object _runTime;

        /// <summary>
        /// The time at which the report was scheduled to run. For non-scheduled reports, this is the time at which the
        /// report was requested to be run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runTime")]
        public virtual string RunTimeRaw
        {
            get => _runTimeRaw;
            set
            {
                _runTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _runTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RunTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RunTimeDateTimeOffset instead.")]
        public virtual object RunTime
        {
            get => _runTime;
            set
            {
                _runTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _runTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RunTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RunTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RunTimeRaw);
            set => RunTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The total number of rows available from this report. Useful for pagination. Only returned with the first
        /// page of results (when page_token is not included in the request).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRowCount")]
        public virtual System.Nullable<int> TotalRowCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A dimension or a metric in a report.</summary>
    public class Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension this field represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>The metric this field represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter on a specific field.</summary>
    public class FieldFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The field to filter on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual Field Field { get; set; }

        /// <summary>Required. The operation of this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>Required. Values to filter to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<ReportValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter over one or more fields.</summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of filters whose results are AND-ed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("andFilter")]
        public virtual FilterList AndFilter { get; set; }

        /// <summary>A filter on a single field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldFilter")]
        public virtual FieldFilter FieldFilter { get; set; }

        /// <summary>A filter whose result is negated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notFilter")]
        public virtual Filter NotFilter { get; set; }

        /// <summary>A list of filters whose results are OR-ed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orFilter")]
        public virtual FilterList OrFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of filters.</summary>
    public class FilterList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<Filter> Filters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A date range between two fixed dates (inclusive of end date).</summary>
    public class FixedDateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The end date (inclusive) of this date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>Required. The start date of this date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of integer values.</summary>
    public class IntList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object for `ListReportsResponse` containing matching `Report` objects.</summary>
    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The `Report` objects from the specified network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>
        /// Total number of `Report` objects. If a filter was included in the request, this reflects the total number
        /// after the filtering is applied. `total_size` won't be calculated in the response unless it has been included
        /// in a response field mask. The response field mask can be provided to the method by using the URL parameter
        /// `$fields` or `fields`, or by using the HTTP/gRPC header `X-Goog-FieldMask`. For more information, see
        /// https://developers.google.com/ad-manager/api/beta/field-masks
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains all metric values requested for a single date range and set of column dimension values (returned in the
    /// columns field of the response). The order of the metrics in each field corresponds to the order of the metrics
    /// specified in the request.
    /// </summary>
    public class MetricValueGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data for the PRIMARY MetricValueType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryValues")]
        public virtual System.Collections.Generic.IList<ReportValue> PrimaryValues { get; set; }

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

    /// <summary>The `Report` resource.</summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The instant this report was created.</summary>
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

        /// <summary>Optional. Display name for the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The locale of this report. Locale is set from the user's locale at the time of the request.
        /// Locale can't be modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// Identifier. The resource name of the report. Report resource name have the form:
        /// `agencies/{account_id}/reports/{report_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The report definition of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDefinition")]
        public virtual ReportDefinition ReportDefinition { get; set; }

        /// <summary>Output only. Report ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportId")]
        public virtual System.Nullable<long> ReportId { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The instant this report was last modified.</summary>
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

    /// <summary>The definition of how a report should be run.</summary>
    public class ReportDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The ISO 4217 currency code for this report. Defaults to account currency code if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Required. The primary date range of this report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>
        /// Required. The list of dimensions to report on. If empty, the report will have no dimensions, and any metrics
        /// will be totals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>Optional. The filters for this report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<Filter> Filters { get; set; }

        /// <summary>Required. The list of metrics to report on. If empty, the report will have no metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>Optional. Default sorts to apply to this report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sorts")]
        public virtual System.Collections.Generic.IList<Sort> Sorts { get; set; }

        /// <summary>
        /// Optional. If time_zone_source is PROVIDED, this is the time zone to use for this report. Leave empty for any
        /// other time zone source. Time zone in IANA format. For example, "America/New_York".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>
        /// Optional. Where to get the time zone for this report. Defaults to using the Pacific time zone (PT). If
        /// source is PROVIDED, the time_zone field in the report definition must also set a time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneSource")]
        public virtual string TimeZoneSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single value in a report.</summary>
    public class ReportValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For boolean values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>For bytes values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesValue")]
        public virtual string BytesValue { get; set; }

        /// <summary>For lists of double values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleListValue")]
        public virtual DoubleList DoubleListValue { get; set; }

        /// <summary>For double values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>For lists of integer values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intListValue")]
        public virtual IntList IntListValue { get; set; }

        /// <summary>For integer values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>For lists of string values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringListValue")]
        public virtual StringList StringListValue { get; set; }

        /// <summary>For string values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of report data.</summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The order of the dimension values is the same as the order of the dimensions specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IList<ReportValue> DimensionValues { get; set; }

        /// <summary>
        ///  The length of the metric_value_groups field will be equal to the length of the date_ranges field in the
        /// fetch response. The metric_value_groups field is ordered such that each index corresponds to the date_range
        /// at the same index. For example, given date_ranges [x, y], metric_value_groups will have a length of two. The
        /// first entry in metric_value_groups represents the metrics for date x and the second entry in
        /// metric_value_groups represents the metrics for date y.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValueGroups")]
        public virtual System.Collections.Generic.IList<MetricValueGroup> MetricValueGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`RunReport` operation metadata.</summary>
    public class RunReportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An estimate of how close this report is to being completed. Will always be 100 for failed and completed
        /// reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentComplete")]
        public virtual System.Nullable<int> PercentComplete { get; set; }

        /// <summary>The result's parent report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("report")]
        public virtual string Report { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for a running a report.</summary>
    public class RunReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for a completed `RunReport` operation.</summary>
    public class RunReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique name of the generated result. Use with `FetchReportResultRows` to retrieve data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportResult")]
        public virtual string ReportResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a sorting in a report.</summary>
    public class Sort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The sort order. If true the sort will be descending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descending")]
        public virtual System.Nullable<bool> Descending { get; set; }

        /// <summary>Required. A field (dimension or metric) to sort by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual Field Field { get; set; }

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

    /// <summary>A list of string values.</summary>
    public class StringList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
