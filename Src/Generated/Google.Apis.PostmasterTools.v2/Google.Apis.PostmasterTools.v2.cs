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

namespace Google.Apis.PostmasterTools.v2
{
    /// <summary>The PostmasterTools Service.</summary>
    public class PostmasterToolsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PostmasterToolsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PostmasterToolsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            DomainStats = new DomainStatsResource(this);
            Domains = new DomainsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://gmailpostmastertools.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://gmailpostmastertools.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gmailpostmastertools";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Gmail Postmaster Tools API.</summary>
        public class Scope
        {
            /// <summary>
            /// Get email traffic metrics, manage domains, and manage domain users for the domains you have registered
            /// with Postmaster Tools
            /// </summary>
            public static string Postmaster = "https://www.googleapis.com/auth/postmaster";

            /// <summary>View and manage the domains you have registered with Postmaster Tools</summary>
            public static string PostmasterDomain = "https://www.googleapis.com/auth/postmaster.domain";

            /// <summary>Get email traffic metrics for the domains you have registered with Postmaster Tools</summary>
            public static string PostmasterTrafficReadonly = "https://www.googleapis.com/auth/postmaster.traffic.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Gmail Postmaster Tools API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// Get email traffic metrics, manage domains, and manage domain users for the domains you have registered
            /// with Postmaster Tools
            /// </summary>
            public const string Postmaster = "https://www.googleapis.com/auth/postmaster";

            /// <summary>View and manage the domains you have registered with Postmaster Tools</summary>
            public const string PostmasterDomain = "https://www.googleapis.com/auth/postmaster.domain";

            /// <summary>Get email traffic metrics for the domains you have registered with Postmaster Tools</summary>
            public const string PostmasterTrafficReadonly = "https://www.googleapis.com/auth/postmaster.traffic.readonly";
        }

        /// <summary>Gets the DomainStats resource.</summary>
        public virtual DomainStatsResource DomainStats { get; }

        /// <summary>Gets the Domains resource.</summary>
        public virtual DomainsResource Domains { get; }
    }

    /// <summary>A base abstract class for PostmasterTools requests.</summary>
    public abstract class PostmasterToolsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PostmasterToolsBaseServiceRequest instance.</summary>
        protected PostmasterToolsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PostmasterTools parameter list.</summary>
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

    /// <summary>The "domainStats" collection of methods.</summary>
    public class DomainStatsResource
    {
        private const string Resource = "domainStats";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DomainStatsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Executes a batch of QueryDomainStats requests for multiple domains. Returns PERMISSION_DENIED if you don't
        /// have permission to access DomainStats for any of the requested domains.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchQueryRequest BatchQuery(Google.Apis.PostmasterTools.v2.Data.BatchQueryDomainStatsRequest body)
        {
            return new BatchQueryRequest(this.service, body);
        }

        /// <summary>
        /// Executes a batch of QueryDomainStats requests for multiple domains. Returns PERMISSION_DENIED if you don't
        /// have permission to access DomainStats for any of the requested domains.
        /// </summary>
        public class BatchQueryRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v2.Data.BatchQueryDomainStatsResponse>
        {
            /// <summary>Constructs a new BatchQuery request.</summary>
            public BatchQueryRequest(Google.Apis.Services.IClientService service, Google.Apis.PostmasterTools.v2.Data.BatchQueryDomainStatsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.PostmasterTools.v2.Data.BatchQueryDomainStatsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchQuery";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/domainStats:batchQuery";

            /// <summary>Initializes BatchQuery parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "domains" collection of methods.</summary>
    public class DomainsResource
    {
        private const string Resource = "domains";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DomainsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            DomainStats = new DomainStatsResource(service);
        }

        /// <summary>Gets the DomainStats resource.</summary>
        public virtual DomainStatsResource DomainStats { get; }

        /// <summary>The "domainStats" collection of methods.</summary>
        public class DomainStatsResource
        {
            private const string Resource = "domainStats";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DomainStatsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Retrieves a list of domain statistics for a given domain and time period. Returns statistics only for
            /// dates where data is available. Returns PERMISSION_DENIED if you don't have permission to access
            /// DomainStats for the domain.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource name where the stats are queried. Format: domains/{domain}
            /// </param>
            public virtual QueryRequest Query(Google.Apis.PostmasterTools.v2.Data.QueryDomainStatsRequest body, string parent)
            {
                return new QueryRequest(this.service, body, parent);
            }

            /// <summary>
            /// Retrieves a list of domain statistics for a given domain and time period. Returns statistics only for
            /// dates where data is available. Returns PERMISSION_DENIED if you don't have permission to access
            /// DomainStats for the domain.
            /// </summary>
            public class QueryRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v2.Data.QueryDomainStatsResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.PostmasterTools.v2.Data.QueryDomainStatsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource name where the stats are queried. Format: domains/{domain}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.PostmasterTools.v2.Data.QueryDomainStatsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/domainStats:query";

                /// <summary>Initializes Query parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^domains/[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Retrieves detailed information about a domain registered by you. Returns NOT_FOUND if the domain is not
        /// registered by you. Domain represents the metadata of a domain that has been registered within the system and
        /// linked to a user.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the domain. Format: `domains/{domain_name}`, where domain_name is the fully
        /// qualified domain name (i.e., mymail.mydomain.com).
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Retrieves detailed information about a domain registered by you. Returns NOT_FOUND if the domain is not
        /// registered by you. Domain represents the metadata of a domain that has been registered within the system and
        /// linked to a user.
        /// </summary>
        public class GetRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v2.Data.Domain>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the domain. Format: `domains/{domain_name}`, where domain_name is the
            /// fully qualified domain name (i.e., mymail.mydomain.com).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

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
                    Pattern = @"^domains/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieves the compliance status for a given domain. Returns PERMISSION_DENIED if you don't have permission
        /// to access compliance status for the domain.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the domain's compliance status to retrieve. Format:
        /// `domains/{domain_id}/complianceStatus`.
        /// </param>
        public virtual GetComplianceStatusRequest GetComplianceStatus(string name)
        {
            return new GetComplianceStatusRequest(this.service, name);
        }

        /// <summary>
        /// Retrieves the compliance status for a given domain. Returns PERMISSION_DENIED if you don't have permission
        /// to access compliance status for the domain.
        /// </summary>
        public class GetComplianceStatusRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v2.Data.DomainComplianceStatus>
        {
            /// <summary>Constructs a new GetComplianceStatus request.</summary>
            public GetComplianceStatusRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the domain's compliance status to retrieve. Format:
            /// `domains/{domain_id}/complianceStatus`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getComplianceStatus";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}";

            /// <summary>Initializes GetComplianceStatus parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^domains/[^/]+/complianceStatus$",
                });
            }
        }

        /// <summary>
        /// Retrieves a list of all domains registered by you, along with their corresponding metadata. The order of
        /// domains in the response is unspecified and non-deterministic. Newly registered domains will not necessarily
        /// be added to the end of this list.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Retrieves a list of all domains registered by you, along with their corresponding metadata. The order of
        /// domains in the response is unspecified and non-deterministic. Newly registered domains will not necessarily
        /// be added to the end of this list.
        /// </summary>
        public class ListRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v2.Data.ListDomainsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Requested page size. Server may return fewer domains than requested. If unspecified, the
            /// default value for this field is 10. The maximum value for this field is 200.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. The next_page_token value returned from a previous List request, if any.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/domains";

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
namespace Google.Apis.PostmasterTools.v2.Data
{
    /// <summary>
    /// Specifies the base metric to query, which can be a predefined standard metric or a user-defined custom metric
    /// (if supported in the future).
    /// </summary>
    public class BaseMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A predefined standard metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardMetric")]
        public virtual string StandardMetric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchQueryDomainStats.</summary>
    public class BatchQueryDomainStatsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of individual query requests. Each request can be for a different domain. A maximum of 100
        /// requests can be included in a single batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<QueryDomainStatsRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchQueryDomainStats.</summary>
    public class BatchQueryDomainStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of responses, one for each query in the BatchQueryDomainStatsRequest. The order of responses will
        /// correspond to the order of requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<BatchQueryDomainStatsResult> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of a single QueryDomainStatsRequest within a batch.</summary>
    public class BatchQueryDomainStatsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error status if the individual query failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The successful response for the individual query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual QueryDomainStatsResponse Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data for a single row of the compliance status table.</summary>
    public class ComplianceRowData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The compliance requirement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requirement")]
        public virtual string Requirement { get; set; }

        /// <summary>The compliance status for the requirement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ComplianceStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The status of a sender compliance requirement.</summary>
    public class ComplianceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The compliance status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

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

    /// <summary>A set of specific dates.</summary>
    public class DateList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of specific dates for which to retrieve data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dates")]
        public virtual System.Collections.Generic.IList<Date> Dates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single date range defined by a start and end date.</summary>
    public class DateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The inclusive end date of the date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual Date End { get; set; }

        /// <summary>Required. The inclusive start date of the date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual Date Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of date ranges.</summary>
    public class DateRanges : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of date ranges for which to retrieve data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual System.Collections.Generic.IList<DateRange> DateRangesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a domain registered by the user.</summary>
    public class Domain : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. Immutable. The timestamp at which the domain was added to the user's account.
        /// </summary>
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

        private string _lastVerifyTimeRaw;

        private object _lastVerifyTime;

        /// <summary>The timestamp at which the domain was last verified by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastVerifyTime")]
        public virtual string LastVerifyTimeRaw
        {
            get => _lastVerifyTimeRaw;
            set
            {
                _lastVerifyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastVerifyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastVerifyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastVerifyTimeDateTimeOffset instead.")]
        public virtual object LastVerifyTime
        {
            get => _lastVerifyTime;
            set
            {
                _lastVerifyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastVerifyTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastVerifyTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastVerifyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastVerifyTimeRaw);
            set => LastVerifyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Identifier. The resource name of the domain. Format: `domains/{domain_name}`, where domain_name is the fully
        /// qualified domain name (i.e., mymail.mydomain.com).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. User's permission of this domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>
        /// Output only. Information about a user's verification history and properties for the domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationState")]
        public virtual string VerificationState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compliance data for a given domain.</summary>
    public class DomainComplianceData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Domain that this data is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainId")]
        public virtual string DomainId { get; set; }

        /// <summary>Unsubscribe honoring compliance verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("honorUnsubscribeVerdict")]
        public virtual HonorUnsubscribeVerdict HonorUnsubscribeVerdict { get; set; }

        /// <summary>One-click unsubscribe compliance verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneClickUnsubscribeVerdict")]
        public virtual OneClickUnsubscribeVerdict OneClickUnsubscribeVerdict { get; set; }

        /// <summary>
        /// Data for each of the rows of the table. Each message contains all the data that backs a single row.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowData")]
        public virtual System.Collections.Generic.IList<ComplianceRowData> RowData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compliance status for a domain.</summary>
    public class DomainComplianceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compliance data for the registrable domain part of the domain in `name`. For example, if `name` is
        /// `domains/example.com/complianceStatus`, this field contains compliance data for `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceData")]
        public virtual DomainComplianceData ComplianceData { get; set; }

        /// <summary>
        /// Identifier. The resource name of the domain's compliance status. Format:
        /// `domains/{domain_id}/complianceStatus`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Compliance data calculated specifically for the subdomain in `name`. This field is only populated if the
        /// domain in `name` is a subdomain that differs from its registrable domain (e.g., `sub.example.com`), and if
        /// compliance data is available for that specific subdomain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subdomainComplianceData")]
        public virtual DomainComplianceData SubdomainComplianceData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Email statistics for a domain for a specified time period or date.</summary>
    public class DomainStat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The specific date for these stats, if granularity is DAILY. This field is populated if the
        /// QueryDomainStatsRequest specified a DAILY aggregation granularity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// The user-defined name from MetricDefinition.name in the request, used to correlate this result with the
        /// requested metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>
        /// Output only. The resource name of the DomainStat resource. Format:
        /// domains/{domain}/domainStats/{domain_stat} The `{domain_stat}` segment is an opaque, server-generated ID. We
        /// recommend using the `metric` field to identify queried metrics instead of parsing the name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The value of the corresponding metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual StatisticValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Compliance verdict for whether a sender meets the unsubscribe honoring compliance requirement.
    /// </summary>
    public class HonorUnsubscribeVerdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specific reason for the compliance verdict. Must be empty if the status is compliant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The compliance status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ComplianceStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListDomains.</summary>
    public class ListDomainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domains that have been registered by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<Domain> Domains { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a specific metric to query, including a user-defined name, the base metric type, and optional filters.
    /// </summary>
    public class MetricDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The underlying metric to query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseMetric")]
        public virtual BaseMetric BaseMetric { get; set; }

        /// <summary>Optional. Optional filters to apply to the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. The user-defined name for this metric. This name will be used as the key for this metric's value
        /// in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Compliance verdict for whether a sender meets the one-click unsubscribe compliance requirement.
    /// </summary>
    public class OneClickUnsubscribeVerdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The specific reason for the compliance verdict. Must be empty if the status is compliant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The compliance status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ComplianceStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryDomainStats.</summary>
    public class QueryDomainStatsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The granularity at which to aggregate the statistics. If unspecified, defaults to DAILY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationGranularity")]
        public virtual string AggregationGranularity { get; set; }

        /// <summary>
        /// Required. The specific metrics to query. You can define a custom name for each metric, which will be used in
        /// the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricDefinitions")]
        public virtual System.Collections.Generic.IList<MetricDefinition> MetricDefinitions { get; set; }

        /// <summary>
        /// Optional. The maximum number of DomainStats resources to return in the response. The server may return fewer
        /// than this value. If unspecified, a default value of 10 will be used. The maximum value is 200.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. The next_page_token value returned from a previous List request, if any. If the aggregation
        /// granularity is DAILY, the page token will be the encoded date + "/" + metric name. If the aggregation
        /// granularity is OVERALL, the page token will be the encoded metric name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>Required. The parent resource name where the stats are queried. Format: domains/{domain}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. The time range or specific dates for which to retrieve the metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeQuery")]
        public virtual TimeQuery TimeQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryDomainStats.</summary>
    public class QueryDomainStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of domain statistics. Each DomainStat object contains the value for a metric requested in the
        /// QueryDomainStatsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainStats")]
        public virtual System.Collections.Generic.IList<DomainStat> DomainStats { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The actual value of a statistic.</summary>
    public class StatisticValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Float value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<float> FloatValue { get; set; }

        /// <summary>Integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>List of string values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringList")]
        public virtual StringList StringList { get; set; }

        /// <summary>String value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

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

    /// <summary>Represents a list of strings.</summary>
    public class StringList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The string values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The date ranges or specific dates for which you want to retrieve data.</summary>
    public class TimeQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of specific dates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateList")]
        public virtual DateList DateList { get; set; }

        /// <summary>A list of date ranges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual DateRanges DateRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
