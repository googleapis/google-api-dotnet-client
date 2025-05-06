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

namespace Google.Apis.Merchant.reports_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "reports_v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MerchantService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MerchantService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://merchantapi.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://merchantapi.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "merchantapi";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Merchant API.</summary>
        public class Scope
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public static string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Merchant API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public const string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for Merchant requests.</summary>
    public abstract class MerchantBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MerchantBaseServiceRequest instance.</summary>
        protected MerchantBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Merchant parameter list.</summary>
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

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
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

            /// <summary>
            /// Retrieves a report defined by a search query. The response might contain fewer rows than specified by
            /// `page_size`. Rely on `next_page_token` to determine if there are more rows to be requested.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Id of the account making the call. Must be a standalone account or an MCA subaccount. Format:
            /// accounts/{account}
            /// </param>
            public virtual SearchRequest Search(Google.Apis.Merchant.reports_v1beta.Data.SearchRequest body, string parent)
            {
                return new SearchRequest(this.service, body, parent);
            }

            /// <summary>
            /// Retrieves a report defined by a search query. The response might contain fewer rows than specified by
            /// `page_size`. Rely on `next_page_token` to determine if there are more rows to be requested.
            /// </summary>
            public class SearchRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.reports_v1beta.Data.SearchResponse>
            {
                /// <summary>Constructs a new Search request.</summary>
                public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.reports_v1beta.Data.SearchRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Id of the account making the call. Must be a standalone account or an MCA subaccount.
                /// Format: accounts/{account}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.reports_v1beta.Data.SearchRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "search";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "reports/v1beta/{+parent}/reports:search";

                /// <summary>Initializes Search parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Merchant.reports_v1beta.Data
{
    /// <summary>
    /// Fields available for query in `best_sellers_brand_view` table. [Best
    /// sellers](https://support.google.com/merchants/answer/9488679) report with top brands. Values are only set for
    /// fields requested explicitly in the request's search query.
    /// </summary>
    public class BestSellersBrandView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the brand.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>Popularity rank in the previous week or month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousRank")]
        public virtual System.Nullable<long> PreviousRank { get; set; }

        /// <summary>
        /// Estimated demand in relation to the brand with the highest popularity rank in the same category and country
        /// in the previous week or month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousRelativeDemand")]
        public virtual string PreviousRelativeDemand { get; set; }

        /// <summary>
        /// Popularity of the brand on Ads and organic surfaces, in the selected category and country, based on the
        /// estimated number of units sold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rank")]
        public virtual System.Nullable<long> Rank { get; set; }

        /// <summary>
        /// Estimated demand in relation to the brand with the highest popularity rank in the same category and country.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeDemand")]
        public virtual string RelativeDemand { get; set; }

        /// <summary>Change in the estimated demand. Whether it rose, sank or remained flat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeDemandChange")]
        public virtual string RelativeDemandChange { get; set; }

        /// <summary>
        /// Google product category ID to calculate the ranking for, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436). Required in the `SELECT` clause. If a
        /// `WHERE` condition on `report_category_id` is not specified in the query, rankings for all top-level
        /// categories are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCategoryId")]
        public virtual System.Nullable<long> ReportCategoryId { get; set; }

        /// <summary>
        /// Country where the ranking is calculated. Represented in the ISO 3166 format. Required in the `SELECT`
        /// clause. Condition on `report_country_code` is required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCountryCode")]
        public virtual string ReportCountryCode { get; set; }

        /// <summary>
        /// Report date. The value of this field can only be one of the following: * The first day of the week (Monday)
        /// for weekly reports, * The first day of the month for monthly reports. Required in the `SELECT` clause. If a
        /// `WHERE` condition on `report_date` is not specified in the query, the latest available weekly or monthly
        /// report is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDate")]
        public virtual Date ReportDate { get; set; }

        /// <summary>
        /// Granularity of the report. The ranking can be done over a week or a month timeframe. Required in the
        /// `SELECT` clause. Condition on `report_granularity` is required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportGranularity")]
        public virtual string ReportGranularity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `best_sellers_product_cluster_view` table. [Best
    /// sellers](https://support.google.com/merchants/answer/9488679) report with top product clusters. A product
    /// cluster is a grouping for different offers and variants that represent the same product, for example, Google
    /// Pixel 7. Values are only set for fields requested explicitly in the request's search query.
    /// </summary>
    public class BestSellersProductClusterView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Brand of the product cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>
        /// Whether there is at least one product of the brand currently `IN_STOCK` in your product data source in at
        /// least one of the countries, all products are `OUT_OF_STOCK` in your product data source in all countries, or
        /// `NOT_IN_INVENTORY`. The field doesn't take the Best sellers report country filter into account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brandInventoryStatus")]
        public virtual string BrandInventoryStatus { get; set; }

        /// <summary>
        /// Product category (1st level) of the product cluster, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL1")]
        public virtual string CategoryL1 { get; set; }

        /// <summary>
        /// Product category (2nd level) of the product cluster, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL2")]
        public virtual string CategoryL2 { get; set; }

        /// <summary>
        /// Product category (3rd level) of the product cluster, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL3")]
        public virtual string CategoryL3 { get; set; }

        /// <summary>
        /// Product category (4th level) of the product cluster, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL4")]
        public virtual string CategoryL4 { get; set; }

        /// <summary>
        /// Product category (5th level) of the product cluster, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL5")]
        public virtual string CategoryL5 { get; set; }

        /// <summary>
        /// Whether the product cluster is `IN_STOCK` in your product data source in at least one of the countries,
        /// `OUT_OF_STOCK` in your product data source in all countries, or `NOT_IN_INVENTORY` at all. The field doesn't
        /// take the Best sellers report country filter into account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryStatus")]
        public virtual string InventoryStatus { get; set; }

        /// <summary>Popularity rank in the previous week or month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousRank")]
        public virtual System.Nullable<long> PreviousRank { get; set; }

        /// <summary>
        /// Estimated demand in relation to the product cluster with the highest popularity rank in the same category
        /// and country in the previous week or month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousRelativeDemand")]
        public virtual string PreviousRelativeDemand { get; set; }

        /// <summary>
        /// Popularity of the product cluster on Ads and organic surfaces, in the selected category and country, based
        /// on the estimated number of units sold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rank")]
        public virtual System.Nullable<long> Rank { get; set; }

        /// <summary>
        /// Estimated demand in relation to the product cluster with the highest popularity rank in the same category
        /// and country.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeDemand")]
        public virtual string RelativeDemand { get; set; }

        /// <summary>Change in the estimated demand. Whether it rose, sank or remained flat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeDemandChange")]
        public virtual string RelativeDemandChange { get; set; }

        /// <summary>
        /// Google product category ID to calculate the ranking for, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436). Required in the `SELECT` clause. If a
        /// `WHERE` condition on `report_category_id` is not specified in the query, rankings for all top-level
        /// categories are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCategoryId")]
        public virtual System.Nullable<long> ReportCategoryId { get; set; }

        /// <summary>
        /// Country where the ranking is calculated. Represented in the ISO 3166 format. Required in the `SELECT`
        /// clause. Condition on `report_country_code` is required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCountryCode")]
        public virtual string ReportCountryCode { get; set; }

        /// <summary>
        /// Report date. The value of this field can only be one of the following: * The first day of the week (Monday)
        /// for weekly reports, * The first day of the month for monthly reports. Required in the `SELECT` clause. If a
        /// `WHERE` condition on `report_date` is not specified in the query, the latest available weekly or monthly
        /// report is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDate")]
        public virtual Date ReportDate { get; set; }

        /// <summary>
        /// Granularity of the report. The ranking can be done over a week or a month timeframe. Required in the
        /// `SELECT` clause. Condition on `report_granularity` is required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportGranularity")]
        public virtual string ReportGranularity { get; set; }

        /// <summary>Title of the product cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>GTINs of example variants of the product cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantGtins")]
        public virtual System.Collections.Generic.IList<string> VariantGtins { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `competitive_visibility_benchmark_view` table. [Competitive
    /// visibility](https://support.google.com/merchants/answer/11366442) report with the category benchmark. Values are
    /// only set for fields requested explicitly in the request's search query.
    /// </summary>
    public class CompetitiveVisibilityBenchmarkView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Change in visibility based on impressions with respect to the start of the selected time range (or first day
        /// with non-zero impressions) for a combined set of merchants with highest visibility approximating the market.
        /// Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryBenchmarkVisibilityTrend")]
        public virtual System.Nullable<double> CategoryBenchmarkVisibilityTrend { get; set; }

        /// <summary>
        /// Date of this row. Required in the `SELECT` clause. A condition on `date` is required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Google product category ID to calculate the report for, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436). Required in the `SELECT` clause. A condition
        /// on `report_category_id` is required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCategoryId")]
        public virtual System.Nullable<long> ReportCategoryId { get; set; }

        /// <summary>
        /// Country where impressions appeared. Required in the `SELECT` clause. A condition on `report_country_code` is
        /// required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCountryCode")]
        public virtual string ReportCountryCode { get; set; }

        /// <summary>Traffic source of impressions. Required in the `SELECT` clause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficSource")]
        public virtual string TrafficSource { get; set; }

        /// <summary>
        /// Change in visibility based on impressions for your domain with respect to the start of the selected time
        /// range (or first day with non-zero impressions). Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yourDomainVisibilityTrend")]
        public virtual System.Nullable<double> YourDomainVisibilityTrend { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `competitive_visibility_competitor_view` table. [Competitive
    /// visibility](https://support.google.com/merchants/answer/11366442) report with businesses with similar
    /// visibility. Values are only set for fields requested explicitly in the request's search query.
    /// </summary>
    public class CompetitiveVisibilityCompetitorView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Ads / organic ratio] (https://support.google.com/merchants/answer/11366442#zippy=%2Cads-free-ratio) shows
        /// how often the domain receives impressions from Shopping ads compared to organic traffic. The number is
        /// rounded and bucketed. Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsOrganicRatio")]
        public virtual System.Nullable<double> AdsOrganicRatio { get; set; }

        /// <summary>Date of this row. A condition on `date` is required in the `WHERE` clause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Domain of your competitor or your domain, if 'is_your_domain' is true. Required in the `SELECT` clause.
        /// Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// [Higher position rate] (https://support.google.com/merchants/answer/11366442#zippy=%2Chigher-position-rate)
        /// shows how often a competitor’s offer got placed in a higher position on the page than your offer. Cannot be
        /// filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("higherPositionRate")]
        public virtual System.Nullable<double> HigherPositionRate { get; set; }

        /// <summary>
        /// True if this row contains data for your domain. Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isYourDomain")]
        public virtual System.Nullable<bool> IsYourDomain { get; set; }

        /// <summary>
        /// [Page overlap rate] (https://support.google.com/merchants/answer/11366442#zippy=%2Cpage-overlap-rate) shows
        /// how frequently competing retailers’ offers are shown together with your offers on the same page. Cannot be
        /// filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageOverlapRate")]
        public virtual System.Nullable<double> PageOverlapRate { get; set; }

        /// <summary>
        /// Position of the domain in the similar businesses ranking for the selected keys (`date`,
        /// `report_category_id`, `report_country_code`, `traffic_source`) based on impressions. 1 is the highest.
        /// Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rank")]
        public virtual System.Nullable<long> Rank { get; set; }

        /// <summary>
        /// [Relative visibility] (https://support.google.com/merchants/answer/11366442#zippy=%2Crelative-visibility)
        /// shows how often your competitors’ offers are shown compared to your offers. In other words, this is the
        /// number of displayed impressions of a competitor retailer divided by the number of your displayed impressions
        /// during a selected time range for a selected product category and country. Cannot be filtered on in the
        /// 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeVisibility")]
        public virtual System.Nullable<double> RelativeVisibility { get; set; }

        /// <summary>
        /// Google product category ID to calculate the report for, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436). Required in the `SELECT` clause. A condition
        /// on `report_category_id` is required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCategoryId")]
        public virtual System.Nullable<long> ReportCategoryId { get; set; }

        /// <summary>
        /// Country where impressions appeared. Required in the `SELECT` clause. A condition on `report_country_code` is
        /// required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCountryCode")]
        public virtual string ReportCountryCode { get; set; }

        /// <summary>Traffic source of impressions. Required in the `SELECT` clause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficSource")]
        public virtual string TrafficSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `competitive_visibility_top_merchant_view` table. [Competitive
    /// visibility](https://support.google.com/merchants/answer/11366442) report with business with highest visibility.
    /// Values are only set for fields requested explicitly in the request's search query.
    /// </summary>
    public class CompetitiveVisibilityTopMerchantView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Ads / organic ratio] (https://support.google.com/merchants/answer/11366442#zippy=%2Cads-free-ratio) shows
        /// how often the domain receives impressions from Shopping ads compared to organic traffic. The number is
        /// rounded and bucketed. Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adsOrganicRatio")]
        public virtual System.Nullable<double> AdsOrganicRatio { get; set; }

        /// <summary>
        /// Date of this row. Cannot be selected in the `SELECT` clause. A condition on `date` is required in the
        /// `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Domain of your competitor or your domain, if 'is_your_domain' is true. Required in the `SELECT` clause.
        /// Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// [Higher position rate] (https://support.google.com/merchants/answer/11366442#zippy=%2Chigher-position-rate)
        /// shows how often a competitor’s offer got placed in a higher position on the page than your offer. Cannot be
        /// filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("higherPositionRate")]
        public virtual System.Nullable<double> HigherPositionRate { get; set; }

        /// <summary>
        /// True if this row contains data for your domain. Cannot be filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isYourDomain")]
        public virtual System.Nullable<bool> IsYourDomain { get; set; }

        /// <summary>
        /// [Page overlap rate] (https://support.google.com/merchants/answer/11366442#zippy=%2Cpage-overlap-rate) shows
        /// how frequently competing retailers’ offers are shown together with your offers on the same page. Cannot be
        /// filtered on in the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageOverlapRate")]
        public virtual System.Nullable<double> PageOverlapRate { get; set; }

        /// <summary>
        /// Position of the domain in the top merchants ranking for the selected keys (`date`, `report_category_id`,
        /// `report_country_code`, `traffic_source`) based on impressions. 1 is the highest. Cannot be filtered on in
        /// the 'WHERE' clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rank")]
        public virtual System.Nullable<long> Rank { get; set; }

        /// <summary>
        /// Google product category ID to calculate the report for, represented in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436). Required in the `SELECT` clause. A condition
        /// on `report_category_id` is required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCategoryId")]
        public virtual System.Nullable<long> ReportCategoryId { get; set; }

        /// <summary>
        /// Country where impressions appeared. Required in the `SELECT` clause. A condition on `report_country_code` is
        /// required in the `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCountryCode")]
        public virtual string ReportCountryCode { get; set; }

        /// <summary>Traffic source of impressions. Required in the `SELECT` clause.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficSource")]
        public virtual string TrafficSource { get; set; }

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

    /// <summary>Issue severity per reporting context.</summary>
    public class IssueSeverityPerReportingContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of demoted countries in the reporting context, represented in ISO 3166 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("demotedCountries")]
        public virtual System.Collections.Generic.IList<string> DemotedCountries { get; set; }

        /// <summary>List of disapproved countries in the reporting context, represented in ISO 3166 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapprovedCountries")]
        public virtual System.Collections.Generic.IList<string> DisapprovedCountries { get; set; }

        /// <summary>Reporting context the issue applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Item issue associated with the product.</summary>
    public class ItemIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Item issue resolution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolution")]
        public virtual string Resolution { get; set; }

        /// <summary>Item issue severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual ItemIssueSeverity Severity { get; set; }

        /// <summary>Item issue type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual ItemIssueType Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>How the issue affects the serving of the product.</summary>
    public class ItemIssueSeverity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Aggregated severity of the issue for all reporting contexts it affects. **This field can be used for
        /// filtering the results.**
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatedSeverity")]
        public virtual string AggregatedSeverity { get; set; }

        /// <summary>Issue severity per reporting context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityPerReportingContext")]
        public virtual System.Collections.Generic.IList<IssueSeverityPerReportingContext> SeverityPerReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Issue type.</summary>
    public class ItemIssueType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Canonical attribute name for attribute-specific issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalAttribute")]
        public virtual string CanonicalAttribute { get; set; }

        /// <summary>
        /// Error code of the issue, equivalent to the `code` of [Product
        /// issues](https://developers.google.com/shopping-content/guides/product-issues).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `non_product_performance_view` table. Performance data on images and online store
    /// links leading to your non-product pages. This includes performance metrics (for example, `clicks`) and
    /// dimensions according to which performance metrics are segmented (for example, `date`). Segment fields cannot be
    /// selected in queries without also selecting at least one metric field. Values are only set for fields requested
    /// explicitly in the request's search query.
    /// </summary>
    public class NonProductPerformanceView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Click-through rate - the number of clicks (`clicks`) divided by the number of impressions (`impressions`) of
        /// images and online store links leading to your non-product pages. Metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickThroughRate")]
        public virtual System.Nullable<double> ClickThroughRate { get; set; }

        /// <summary>
        /// Number of clicks on images and online store links leading to your non-product pages. Metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clicks")]
        public virtual System.Nullable<long> Clicks { get; set; }

        /// <summary>
        /// Date in the merchant timezone to which metrics apply. Segment. Condition on `date` is required in the
        /// `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Number of times images and online store links leading to your non-product pages were shown. Metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressions")]
        public virtual System.Nullable<long> Impressions { get; set; }

        /// <summary>First day of the week (Monday) of the metrics date in the merchant timezone. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("week")]
        public virtual Date Week { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price represented as a number and currency.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The price represented as a number in micros (1 million micros is an equivalent to one's currency standard
        /// unit, for example, 1 USD = 1000000 micros).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<long> AmountMicros { get; set; }

        /// <summary>
        /// The currency of the price using three-letter acronyms according to [ISO
        /// 4217](http://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `price_competitiveness_product_view` table. [Price
    /// competitiveness](https://support.google.com/merchants/answer/9626903) report. Values are only set for fields
    /// requested explicitly in the request's search query.
    /// </summary>
    public class PriceCompetitivenessProductView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Latest available price benchmark for the product's catalog in the benchmark country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("benchmarkPrice")]
        public virtual Price BenchmarkPrice { get; set; }

        /// <summary>Brand of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>
        /// Product category (1st level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL1")]
        public virtual string CategoryL1 { get; set; }

        /// <summary>
        /// Product category (2nd level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL2")]
        public virtual string CategoryL2 { get; set; }

        /// <summary>
        /// Product category (3rd level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL3")]
        public virtual string CategoryL3 { get; set; }

        /// <summary>
        /// Product category (4th level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL4")]
        public virtual string CategoryL4 { get; set; }

        /// <summary>
        /// Product category (5th level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL5")]
        public virtual string CategoryL5 { get; set; }

        /// <summary>
        /// REST ID of the product, in the form of `channel~languageCode~feedLabel~offerId`. Can be used to join data
        /// with the `product_view` table. Required in the `SELECT` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Merchant-provided id of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>Current price of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>
        /// Product type (1st level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL1")]
        public virtual string ProductTypeL1 { get; set; }

        /// <summary>
        /// Product type (2nd level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL2")]
        public virtual string ProductTypeL2 { get; set; }

        /// <summary>
        /// Product type (3rd level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL3")]
        public virtual string ProductTypeL3 { get; set; }

        /// <summary>
        /// Product type (4th level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL4")]
        public virtual string ProductTypeL4 { get; set; }

        /// <summary>
        /// Product type (5th level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL5")]
        public virtual string ProductTypeL5 { get; set; }

        /// <summary>
        /// Country of the price benchmark. Represented in the ISO 3166 format. Required in the `SELECT` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportCountryCode")]
        public virtual string ReportCountryCode { get; set; }

        /// <summary>Title of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `price_insights_product_view` table. [Price
    /// insights](https://support.google.com/merchants/answer/11916926) report. Values are only set for fields requested
    /// explicitly in the request's search query.
    /// </summary>
    public class PriceInsightsProductView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Brand of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>
        /// Product category (1st level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL1")]
        public virtual string CategoryL1 { get; set; }

        /// <summary>
        /// Product category (2nd level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL2")]
        public virtual string CategoryL2 { get; set; }

        /// <summary>
        /// Product category (3rd level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL3")]
        public virtual string CategoryL3 { get; set; }

        /// <summary>
        /// Product category (4th level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL4")]
        public virtual string CategoryL4 { get; set; }

        /// <summary>
        /// Product category (5th level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL5")]
        public virtual string CategoryL5 { get; set; }

        /// <summary>The predicted effectiveness of applying the price suggestion, bucketed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveness")]
        public virtual string Effectiveness { get; set; }

        /// <summary>
        /// REST ID of the product, in the form of `channel~languageCode~feedLabel~offerId`. Can be used to join data
        /// with the `product_view` table. Required in the `SELECT` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Merchant-provided id of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>
        /// Predicted change in clicks as a fraction after introducing the suggested price compared to current active
        /// price. For example, 0.05 is a 5% predicted increase in clicks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictedClicksChangeFraction")]
        public virtual System.Nullable<double> PredictedClicksChangeFraction { get; set; }

        /// <summary>
        /// Predicted change in conversions as a fraction after introducing the suggested price compared to current
        /// active price. For example, 0.05 is a 5% predicted increase in conversions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictedConversionsChangeFraction")]
        public virtual System.Nullable<double> PredictedConversionsChangeFraction { get; set; }

        /// <summary>
        /// Predicted change in impressions as a fraction after introducing the suggested price compared to current
        /// active price. For example, 0.05 is a 5% predicted increase in impressions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predictedImpressionsChangeFraction")]
        public virtual System.Nullable<double> PredictedImpressionsChangeFraction { get; set; }

        /// <summary>Current price of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>
        /// Product type (1st level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL1")]
        public virtual string ProductTypeL1 { get; set; }

        /// <summary>
        /// Product type (2nd level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL2")]
        public virtual string ProductTypeL2 { get; set; }

        /// <summary>
        /// Product type (3rd level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL3")]
        public virtual string ProductTypeL3 { get; set; }

        /// <summary>
        /// Product type (4th level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL4")]
        public virtual string ProductTypeL4 { get; set; }

        /// <summary>
        /// Product type (5th level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL5")]
        public virtual string ProductTypeL5 { get; set; }

        /// <summary>Latest suggested price for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedPrice")]
        public virtual Price SuggestedPrice { get; set; }

        /// <summary>Title of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The change that happened to the product including old value, new value, country code as the region code and
    /// reporting context.
    /// </summary>
    public class ProductChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new value of the changed resource or attribute. If empty, it means that the product was deleted. Will
        /// have one of these values : (`approved`, `pending`, `disapproved`, ``)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>
        /// The old value of the changed resource or attribute. If empty, it means that the product was created. Will
        /// have one of these values : (`approved`, `pending`, `disapproved`, ``)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual string OldValue { get; set; }

        /// <summary>Countries that have the change (if applicable). Represented in the ISO 3166 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// Reporting contexts that have the change (if applicable). Currently this field supports only (`SHOPPING_ADS`,
        /// `LOCAL_INVENTORY_ADS`, `YOUTUBE_SHOPPING`, `YOUTUBE_CHECKOUT`, `YOUTUBE_AFFILIATE`) from the enum value
        /// [ReportingContextEnum](/merchant/api/reference/rest/Shared.Types/ReportingContextEnum)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `product_performance_view` table. Product performance data for your account,
    /// including performance metrics (for example, `clicks`) and dimensions according to which performance metrics are
    /// segmented (for example, `offer_id`). Values of product dimensions, such as `offer_id`, reflect the state of a
    /// product at the time of the impression. Segment fields cannot be selected in queries without also selecting at
    /// least one metric field. Values are only set for fields requested explicitly in the request's search query.
    /// </summary>
    public class ProductPerformanceView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Brand of the product. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>
        /// [Product category (1st
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in Google's product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL1")]
        public virtual string CategoryL1 { get; set; }

        /// <summary>
        /// [Product category (2nd
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in Google's product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL2")]
        public virtual string CategoryL2 { get; set; }

        /// <summary>
        /// [Product category (3rd
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in Google's product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL3")]
        public virtual string CategoryL3 { get; set; }

        /// <summary>
        /// [Product category (4th
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in Google's product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL4")]
        public virtual string CategoryL4 { get; set; }

        /// <summary>
        /// [Product category (5th
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in Google's product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL5")]
        public virtual string CategoryL5 { get; set; }

        /// <summary>
        /// Click-through rate - the number of clicks merchant's products receive (clicks) divided by the number of
        /// times the products are shown (impressions). Metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickThroughRate")]
        public virtual System.Nullable<double> ClickThroughRate { get; set; }

        /// <summary>Number of clicks. Metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clicks")]
        public virtual System.Nullable<long> Clicks { get; set; }

        /// <summary>
        /// Number of conversions divided by the number of clicks, reported on the impression date. Metric. Available
        /// only for the `FREE` traffic source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionRate")]
        public virtual System.Nullable<double> ConversionRate { get; set; }

        /// <summary>
        /// Value of conversions attributed to the product, reported on the conversion date. Metric. Available only for
        /// the `FREE` traffic source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversionValue")]
        public virtual Price ConversionValue { get; set; }

        /// <summary>
        /// Number of conversions attributed to the product, reported on the conversion date. Depending on the
        /// attribution model, a conversion might be distributed across multiple clicks, where each click gets its own
        /// credit assigned. This metric is a sum of all such credits. Metric. Available only for the `FREE` traffic
        /// source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversions")]
        public virtual System.Nullable<double> Conversions { get; set; }

        /// <summary>Custom label 0 for custom grouping of products. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel0")]
        public virtual string CustomLabel0 { get; set; }

        /// <summary>Custom label 1 for custom grouping of products. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel1")]
        public virtual string CustomLabel1 { get; set; }

        /// <summary>Custom label 2 for custom grouping of products. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel2")]
        public virtual string CustomLabel2 { get; set; }

        /// <summary>Custom label 3 for custom grouping of products. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel3")]
        public virtual string CustomLabel3 { get; set; }

        /// <summary>Custom label 4 for custom grouping of products. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabel4")]
        public virtual string CustomLabel4 { get; set; }

        /// <summary>
        /// Code of the country where the customer is located at the time of the event. Represented in the ISO 3166
        /// format. Segment. If the customer country cannot be determined, a special 'ZZ' code is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerCountryCode")]
        public virtual string CustomerCountryCode { get; set; }

        /// <summary>
        /// Date in the merchant timezone to which metrics apply. Segment. Condition on `date` is required in the
        /// `WHERE` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Number of times merchant's products are shown. Metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressions")]
        public virtual System.Nullable<long> Impressions { get; set; }

        /// <summary>Marketing method to which metrics apply. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingMethod")]
        public virtual string MarketingMethod { get; set; }

        /// <summary>Merchant-provided id of the product. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>
        /// [Product type (1st
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in merchant's own product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL1")]
        public virtual string ProductTypeL1 { get; set; }

        /// <summary>
        /// [Product type (2nd
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in merchant's own product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL2")]
        public virtual string ProductTypeL2 { get; set; }

        /// <summary>
        /// [Product type (3rd
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in merchant's own product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL3")]
        public virtual string ProductTypeL3 { get; set; }

        /// <summary>
        /// [Product type (4th
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in merchant's own product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL4")]
        public virtual string ProductTypeL4 { get; set; }

        /// <summary>
        /// [Product type (5th
        /// level)](https://developers.google.com/shopping-content/guides/reports/segmentation#category_and_product_type)
        /// in merchant's own product taxonomy. Segment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL5")]
        public virtual string ProductTypeL5 { get; set; }

        /// <summary>Title of the product. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>First day of the week (Monday) of the metrics date in the merchant timezone. Segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("week")]
        public virtual Date Week { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message that the merchant will receive to notify about product status change event</summary>
    public class ProductStatusChangeMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target account that owns the entity that changed. Format : `accounts/{merchant_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        /// <summary>The attribute in the resource that changed, in this case it will be always `Status`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>A message to describe the change that happened to the product</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<ProductChange> Changes { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// The time at which the event was generated. If you want to order the notification messages you receive you
        /// should rely on this field not on the order of receiving the notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// Optional. The product expiration time. This field will not bet set if the notification is sent for a product
        /// deletion event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The account that manages the merchant's account. can be the same as merchant id if it is standalone account.
        /// Format : `accounts/{service_provider_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managingAccount")]
        public virtual string ManagingAccount { get; set; }

        /// <summary>The product name. Format: `accounts/{account}/products/{product}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The product id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The resource that changed, in this case it will always be `Product`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fields available for query in `product_view` table. Products in the current inventory. Products in this table
    /// are the same as in Products sub-API but not all product attributes from Products sub-API are available for query
    /// in this table. In contrast to Products sub-API, this table allows to filter the returned list of products by
    /// product attributes. To retrieve a single product by `id` or list all products, Products sub-API should be used.
    /// Values are only set for fields requested explicitly in the request's search query.
    /// </summary>
    public class ProductView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregated status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatedReportingContextStatus")]
        public virtual string AggregatedReportingContextStatus { get; set; }

        /// <summary>[Availability](https://support.google.com/merchants/answer/6324448) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        /// <summary>Brand of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>
        /// Product category (1st level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL1")]
        public virtual string CategoryL1 { get; set; }

        /// <summary>
        /// Product category (2nd level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL2")]
        public virtual string CategoryL2 { get; set; }

        /// <summary>
        /// Product category (3rd level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL3")]
        public virtual string CategoryL3 { get; set; }

        /// <summary>
        /// Product category (4th level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL4")]
        public virtual string CategoryL4 { get; set; }

        /// <summary>
        /// Product category (5th level) in [Google's product
        /// taxonomy](https://support.google.com/merchants/answer/6324436).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoryL5")]
        public virtual string CategoryL5 { get; set; }

        /// <summary>Channel of the product. Can be `ONLINE` or `LOCAL`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>Estimated performance potential compared to highest performing products of the merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickPotential")]
        public virtual string ClickPotential { get; set; }

        /// <summary>
        /// Rank of the product based on its click potential. A product with `click_potential_rank` 1 has the highest
        /// click potential among the merchant's products that fulfill the search query conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickPotentialRank")]
        public virtual System.Nullable<long> ClickPotentialRank { get; set; }

        /// <summary>[Condition](https://support.google.com/merchants/answer/6324469) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        private string _creationTimeRaw;

        private object _creationTime;

        /// <summary>The time the merchant created the product in timestamp seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTimeRaw
        {
            get => _creationTimeRaw;
            set
            {
                _creationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _creationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreationTimeDateTimeOffset instead.")]
        public virtual object CreationTime
        {
            get => _creationTime;
            set
            {
                _creationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _creationTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreationTimeRaw);
            set => CreationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Expiration date for the product, specified on insertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationDate")]
        public virtual Date ExpirationDate { get; set; }

        /// <summary>Feed label of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>List of Global Trade Item Numbers (GTINs) of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual System.Collections.Generic.IList<string> Gtin { get; set; }

        /// <summary>
        /// REST ID of the product, in the form of `channel~languageCode~feedLabel~offerId`. Merchant API methods that
        /// operate on products take this as their `name` parameter. Required in the `SELECT` clause.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Item group id provided by the merchant for grouping variants together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemGroupId")]
        public virtual string ItemGroupId { get; set; }

        /// <summary>
        /// List of item issues for the product. **This field cannot be used for sorting the results.** **Only selected
        /// attributes of this field (for example, `item_issues.severity.aggregated_severity`) can be used for filtering
        /// the results.**
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemIssues")]
        public virtual System.Collections.Generic.IList<ItemIssue> ItemIssues { get; set; }

        /// <summary>Language code of the product in BCP 47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Merchant-provided id of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>Product price. Absent if the information about the price of the product is not available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>
        /// Product type (1st level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL1")]
        public virtual string ProductTypeL1 { get; set; }

        /// <summary>
        /// Product type (2nd level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL2")]
        public virtual string ProductTypeL2 { get; set; }

        /// <summary>
        /// Product type (3rd level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL3")]
        public virtual string ProductTypeL3 { get; set; }

        /// <summary>
        /// Product type (4th level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL4")]
        public virtual string ProductTypeL4 { get; set; }

        /// <summary>
        /// Product type (5th level) in merchant's own [product
        /// taxonomy](https://support.google.com/merchants/answer/6324406).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productTypeL5")]
        public virtual string ProductTypeL5 { get; set; }

        /// <summary>
        /// Normalized [shipping label](https://support.google.com/merchants/answer/6324504) specified in the data
        /// source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingLabel")]
        public virtual string ShippingLabel { get; set; }

        /// <summary>Link to the processed image of the product, hosted on the Google infrastructure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailLink")]
        public virtual string ThumbnailLink { get; set; }

        /// <summary>Title of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Result row returned from the search query. Only the message corresponding to the queried table is populated in
    /// the response. Within the populated message, only the fields requested explicitly in the query are populated.
    /// </summary>
    public class ReportRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fields available for query in `best_sellers_brand_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestSellersBrandView")]
        public virtual BestSellersBrandView BestSellersBrandView { get; set; }

        /// <summary>Fields available for query in `best_sellers_product_cluster_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestSellersProductClusterView")]
        public virtual BestSellersProductClusterView BestSellersProductClusterView { get; set; }

        /// <summary>Fields available for query in `competitive_visibility_benchmark_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("competitiveVisibilityBenchmarkView")]
        public virtual CompetitiveVisibilityBenchmarkView CompetitiveVisibilityBenchmarkView { get; set; }

        /// <summary>Fields available for query in `competitive_visibility_competitor_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("competitiveVisibilityCompetitorView")]
        public virtual CompetitiveVisibilityCompetitorView CompetitiveVisibilityCompetitorView { get; set; }

        /// <summary>Fields available for query in `competitive_visibility_top_merchant_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("competitiveVisibilityTopMerchantView")]
        public virtual CompetitiveVisibilityTopMerchantView CompetitiveVisibilityTopMerchantView { get; set; }

        /// <summary>Fields available for query in `non_product_performance_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonProductPerformanceView")]
        public virtual NonProductPerformanceView NonProductPerformanceView { get; set; }

        /// <summary>Fields available for query in `price_competitiveness_product_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceCompetitivenessProductView")]
        public virtual PriceCompetitivenessProductView PriceCompetitivenessProductView { get; set; }

        /// <summary>Fields available for query in `price_insights_product_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceInsightsProductView")]
        public virtual PriceInsightsProductView PriceInsightsProductView { get; set; }

        /// <summary>Fields available for query in `product_performance_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productPerformanceView")]
        public virtual ProductPerformanceView ProductPerformanceView { get; set; }

        /// <summary>Fields available for query in `product_view` table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productView")]
        public virtual ProductView ProductView { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the `ReportService.Search` method.</summary>
    public class SearchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Number of `ReportRows` to retrieve in a single page. Defaults to 1000. Values above 5000 are
        /// coerced to 5000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. Token of the page to retrieve. If not specified, the first page of results is returned. In order
        /// to request the next page of results, the value obtained from `next_page_token` in the previous response
        /// should be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. Query that defines a report to be retrieved. For details on how to construct your query, see the
        /// [Query Language guide](/merchant/api/guides/reports/query-language). For the full list of available tables
        /// and fields, see the [Available fields](/merchant/api/reference/rest/reports_v1beta/accounts.reports).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the `ReportService.Search` method.</summary>
    public class SearchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token which can be sent as `page_token` to retrieve the next page. If omitted, there are no subsequent
        /// pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Rows that matched the search query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<ReportRow> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
