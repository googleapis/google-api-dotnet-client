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

namespace Google.Apis.Localservices.v1
{
    /// <summary>The Localservices Service.</summary>
    public class LocalservicesService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public LocalservicesService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public LocalservicesService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AccountReports = new AccountReportsResource(this);
            DetailedLeadReports = new DetailedLeadReportsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "localservices";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://localservices.googleapis.com/";
        #else
            "https://localservices.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://localservices.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Local Services API.</summary>
        public class Scope
        {
            /// <summary>Manage your AdWords campaigns</summary>
            public static string Adwords = "https://www.googleapis.com/auth/adwords";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Local Services API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your AdWords campaigns</summary>
            public const string Adwords = "https://www.googleapis.com/auth/adwords";
        }

        /// <summary>Gets the AccountReports resource.</summary>
        public virtual AccountReportsResource AccountReports { get; }

        /// <summary>Gets the DetailedLeadReports resource.</summary>
        public virtual DetailedLeadReportsResource DetailedLeadReports { get; }
    }

    /// <summary>A base abstract class for Localservices requests.</summary>
    public abstract class LocalservicesBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new LocalservicesBaseServiceRequest instance.</summary>
        protected LocalservicesBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Localservices parameter list.</summary>
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

    /// <summary>The "accountReports" collection of methods.</summary>
    public class AccountReportsResource
    {
        private const string Resource = "accountReports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountReportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Get account reports containing aggregate account data of all linked GLS accounts. Caller needs to provide
        /// their manager customer id and the associated auth credential that allows them read permissions on their
        /// linked accounts.
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>
        /// Get account reports containing aggregate account data of all linked GLS accounts. Caller needs to provide
        /// their manager customer id and the associated auth credential that allows them read permissions on their
        /// linked accounts.
        /// </summary>
        public class SearchRequest : LocalservicesBaseServiceRequest<Google.Apis.Localservices.v1.Data.GoogleAdsHomeservicesLocalservicesV1SearchAccountReportsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself
            /// or a year and month where the day isn't significant.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateDay { get; set; }

            /// <summary>
            /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateMonth { get; set; }

            /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateYear { get; set; }

            /// <summary>
            /// The maximum number of accounts to return. If the page size is unset, page size will default to 1000.
            /// Maximum page_size is 10000. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// The `next_page_token` value returned from a previous request to SearchAccountReports that indicates
            /// where listing should continue. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// A query string for searching for account reports. Caller must provide a customer id of their MCC account
            /// with an associated Gaia Mint that allows read permission on their linked accounts. Search expressions
            /// are case insensitive. Example query: | Query | Description |
            /// |-------------------------|-----------------------------------------------| | manager_customer_id:123 |
            /// Get Account Report for Manager with id 123. | Required.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself
            /// or a year and month where the day isn't significant.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateDay { get; set; }

            /// <summary>
            /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateMonth { get; set; }

            /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateYear { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accountReports:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("endDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.year",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "detailedLeadReports" collection of methods.</summary>
    public class DetailedLeadReportsResource
    {
        private const string Resource = "detailedLeadReports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DetailedLeadReportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Get detailed lead reports containing leads that have been received by all linked GLS accounts. Caller needs
        /// to provide their manager customer id and the associated auth credential that allows them read permissions on
        /// their linked accounts.
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>
        /// Get detailed lead reports containing leads that have been received by all linked GLS accounts. Caller needs
        /// to provide their manager customer id and the associated auth credential that allows them read permissions on
        /// their linked accounts.
        /// </summary>
        public class SearchRequest : LocalservicesBaseServiceRequest<Google.Apis.Localservices.v1.Data.GoogleAdsHomeservicesLocalservicesV1SearchDetailedLeadReportsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself
            /// or a year and month where the day isn't significant.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateDay { get; set; }

            /// <summary>
            /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateMonth { get; set; }

            /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> EndDateYear { get; set; }

            /// <summary>
            /// The maximum number of accounts to return. If the page size is unset, page size will default to 1000.
            /// Maximum page_size is 10000. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// The `next_page_token` value returned from a previous request to SearchDetailedLeadReports that indicates
            /// where listing should continue. Optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// A query string for searching for account reports. Caller must provide a customer id of their MCC account
            /// with an associated Gaia Mint that allows read permission on their linked accounts. Search expressions
            /// are case insensitive. Example query: | Query | Description |
            /// |-------------------------|-----------------------------------------------| | manager_customer_id:123 |
            /// Get Detailed Lead Report for Manager with id | | | 123. | Required.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>
            /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself
            /// or a year and month where the day isn't significant.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateDay { get; set; }

            /// <summary>
            /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateMonth { get; set; }

            /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> StartDateYear { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/detailedLeadReports:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("endDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate.year",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Localservices.v1.Data
{
    /// <summary>
    /// An Account Report of a GLS account identified by their account id containing aggregate data gathered from a
    /// particular date range. Next ID: 18
    /// </summary>
    public class GoogleAdsHomeservicesLocalservicesV1AccountReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier of the GLS account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; }

        /// <summary>Aggregator specific information related to the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatorInfo")]
        public virtual GoogleAdsHomeservicesLocalservicesV1AggregatorInfo AggregatorInfo { get; set; }

        /// <summary>Average review rating score from 1-5 stars.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageFiveStarRating")]
        public virtual System.Nullable<double> AverageFiveStarRating { get; set; }

        /// <summary>Average weekly budget in the currency code of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageWeeklyBudget")]
        public virtual System.Nullable<double> AverageWeeklyBudget { get; set; }

        /// <summary>Business name of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessName")]
        public virtual string BusinessName { get; set; }

        /// <summary>Currency code of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Number of charged leads the account received in current specified period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentPeriodChargedLeads")]
        public virtual System.Nullable<long> CurrentPeriodChargedLeads { get; set; }

        /// <summary>Number of connected phone calls (duration over 30s) in current specified period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentPeriodConnectedPhoneCalls")]
        public virtual System.Nullable<long> CurrentPeriodConnectedPhoneCalls { get; set; }

        /// <summary>
        /// Number of phone calls in current specified period, including both connected and unconnected calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentPeriodPhoneCalls")]
        public virtual System.Nullable<long> CurrentPeriodPhoneCalls { get; set; }

        /// <summary>
        /// Total cost of the account in current specified period in the account's specified currency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentPeriodTotalCost")]
        public virtual System.Nullable<double> CurrentPeriodTotalCost { get; set; }

        /// <summary>Number of impressions that customers have had in the past 2 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionsLastTwoDays")]
        public virtual System.Nullable<long> ImpressionsLastTwoDays { get; set; }

        /// <summary>
        /// Phone lead responsiveness of the account for the past 90 days from current date. This is computed by taking
        /// the total number of connected calls from charged phone leads and dividing by the total number of calls
        /// received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneLeadResponsiveness")]
        public virtual System.Nullable<double> PhoneLeadResponsiveness { get; set; }

        /// <summary>Number of charged leads the account received in previous specified period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousPeriodChargedLeads")]
        public virtual System.Nullable<long> PreviousPeriodChargedLeads { get; set; }

        /// <summary>Number of connected phone calls (duration over 30s) in previous specified period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousPeriodConnectedPhoneCalls")]
        public virtual System.Nullable<long> PreviousPeriodConnectedPhoneCalls { get; set; }

        /// <summary>
        /// Number of phone calls in previous specified period, including both connected and unconnected calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousPeriodPhoneCalls")]
        public virtual System.Nullable<long> PreviousPeriodPhoneCalls { get; set; }

        /// <summary>
        /// Total cost of the account in previous specified period in the account's specified currency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousPeriodTotalCost")]
        public virtual System.Nullable<double> PreviousPeriodTotalCost { get; set; }

        /// <summary>Total number of reviews the account has up to current date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalReview")]
        public virtual System.Nullable<int> TotalReview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Conatiner for aggregator specific information if lead is for an aggregator GLS account.</summary>
    public class GoogleAdsHomeservicesLocalservicesV1AggregatorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Provider id (listed in aggregator system) which maps to a account id in GLS system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatorProviderId")]
        public virtual string AggregatorProviderId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for booking lead specific information.</summary>
    public class GoogleAdsHomeservicesLocalservicesV1BookingLead : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp of when service is provided by advertiser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bookingAppointmentTimestamp")]
        public virtual object BookingAppointmentTimestamp { get; set; }

        /// <summary>Consumer email associated with the booking lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerEmail")]
        public virtual string ConsumerEmail { get; set; }

        /// <summary>Consumer phone number associated with the booking lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerPhoneNumber")]
        public virtual string ConsumerPhoneNumber { get; set; }

        /// <summary>Name of the customer who created the lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerName")]
        public virtual string CustomerName { get; set; }

        /// <summary>The job type of the specified lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobType")]
        public virtual string JobType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Detailed Lead Report of a lead identified by their lead id and contains consumer, account, monetization, and
    /// lead data.
    /// </summary>
    public class GoogleAdsHomeservicesLocalservicesV1DetailedLeadReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifies account that received the lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; }

        /// <summary>Aggregator specific information related to the lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatorInfo")]
        public virtual GoogleAdsHomeservicesLocalservicesV1AggregatorInfo AggregatorInfo { get; set; }

        /// <summary>More information associated to only booking leads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bookingLead")]
        public virtual GoogleAdsHomeservicesLocalservicesV1BookingLead BookingLead { get; set; }

        /// <summary>Business name associated to the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessName")]
        public virtual string BusinessName { get; set; }

        /// <summary>Whether the lead has been charged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chargeStatus")]
        public virtual string ChargeStatus { get; set; }

        /// <summary>Currency code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Dispute status related to the lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disputeStatus")]
        public virtual string DisputeStatus { get; set; }

        /// <summary>Location of the associated account's home city.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geo")]
        public virtual string Geo { get; set; }

        /// <summary>Lead category (e.g. hvac, plumber)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadCategory")]
        public virtual string LeadCategory { get; set; }

        /// <summary>Timestamp of when the lead was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadCreationTimestamp")]
        public virtual object LeadCreationTimestamp { get; set; }

        /// <summary>Unique identifier of a Detailed Lead Report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadId")]
        public virtual System.Nullable<long> LeadId { get; set; }

        /// <summary>Price of the lead (available only after it has been charged).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadPrice")]
        public virtual System.Nullable<double> LeadPrice { get; set; }

        /// <summary>Lead type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leadType")]
        public virtual string LeadType { get; set; }

        /// <summary>More information associated to only message leads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageLead")]
        public virtual GoogleAdsHomeservicesLocalservicesV1MessageLead MessageLead { get; set; }

        /// <summary>More information associated to only phone leads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneLead")]
        public virtual GoogleAdsHomeservicesLocalservicesV1PhoneLead PhoneLead { get; set; }

        /// <summary>Timezone of the particular provider associated to a lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezone")]
        public virtual GoogleTypeTimeZone Timezone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for message lead specific information.</summary>
    public class GoogleAdsHomeservicesLocalservicesV1MessageLead : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Consumer phone number associated with the message lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerPhoneNumber")]
        public virtual string ConsumerPhoneNumber { get; set; }

        /// <summary>Name of the customer who created the lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerName")]
        public virtual string CustomerName { get; set; }

        /// <summary>The job type of the specified lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobType")]
        public virtual string JobType { get; set; }

        /// <summary>The postal code of the customer who created the lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for phone lead specific information.</summary>
    public class GoogleAdsHomeservicesLocalservicesV1PhoneLead : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp of the phone call which resulted in a charged phone lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chargedCallTimestamp")]
        public virtual object ChargedCallTimestamp { get; set; }

        /// <summary>Duration of the charged phone call in seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chargedConnectedCallDurationSeconds")]
        public virtual object ChargedConnectedCallDurationSeconds { get; set; }

        /// <summary>Consumer phone number associated with the phone lead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerPhoneNumber")]
        public virtual string ConsumerPhoneNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A page of the response received from the SearchAccountReports method. A paginated response where more pages are
    /// available has `next_page_token` set. This token can be used in a subsequent request to retrieve the next request
    /// page.
    /// </summary>
    public class GoogleAdsHomeservicesLocalservicesV1SearchAccountReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of account reports which maps 1:1 to a particular linked GLS account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountReports")]
        public virtual System.Collections.Generic.IList<GoogleAdsHomeservicesLocalservicesV1AccountReport> AccountReports { get; set; }

        /// <summary>
        /// Pagination token to retrieve the next page of results. When `next_page_token` is not filled in, there is no
        /// next page and the list returned is the last page in the result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A page of the response received from the SearchDetailedLeadReports method. A paginated response where more pages
    /// are available has `next_page_token` set. This token can be used in a subsequent request to retrieve the next
    /// request page.
    /// </summary>
    public class GoogleAdsHomeservicesLocalservicesV1SearchDetailedLeadReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of detailed lead reports uniquely identified by external lead id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailedLeadReports")]
        public virtual System.Collections.Generic.IList<GoogleAdsHomeservicesLocalservicesV1DetailedLeadReport> DetailedLeadReports { get; set; }

        /// <summary>
        /// Pagination token to retrieve the next page of results. When `next_page_token` is not filled in, there is no
        /// next page and the list returned is the last page in the result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class GoogleTypeTimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number, e.g. "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
