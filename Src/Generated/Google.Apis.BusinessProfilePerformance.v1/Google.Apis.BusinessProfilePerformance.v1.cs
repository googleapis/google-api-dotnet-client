// Copyright 2022 Google LLC
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

namespace Google.Apis.BusinessProfilePerformance.v1
{
    /// <summary>The BusinessProfilePerformance Service.</summary>
    public class BusinessProfilePerformanceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BusinessProfilePerformanceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BusinessProfilePerformanceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Locations = new LocationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "businessprofileperformance";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://businessprofileperformance.googleapis.com/";
        #else
            "https://businessprofileperformance.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://businessprofileperformance.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }
    }

    /// <summary>A base abstract class for BusinessProfilePerformance requests.</summary>
    public abstract class BusinessProfilePerformanceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BusinessProfilePerformanceBaseServiceRequest instance.</summary>
        protected BusinessProfilePerformanceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes BusinessProfilePerformance parameter list.</summary>
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
            Searchkeywords = new SearchkeywordsResource(service);
        }

        /// <summary>Gets the Searchkeywords resource.</summary>
        public virtual SearchkeywordsResource Searchkeywords { get; }

        /// <summary>The "searchkeywords" collection of methods.</summary>
        public class SearchkeywordsResource
        {
            private const string Resource = "searchkeywords";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SearchkeywordsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Impressions = new ImpressionsResource(service);
            }

            /// <summary>Gets the Impressions resource.</summary>
            public virtual ImpressionsResource Impressions { get; }

            /// <summary>The "impressions" collection of methods.</summary>
            public class ImpressionsResource
            {
                private const string Resource = "impressions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ImpressionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Monthly = new MonthlyResource(service);
                }

                /// <summary>Gets the Monthly resource.</summary>
                public virtual MonthlyResource Monthly { get; }

                /// <summary>The "monthly" collection of methods.</summary>
                public class MonthlyResource
                {
                    private const string Resource = "monthly";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public MonthlyResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Returns the search keywords used to find a business in search or maps. Each search keyword is
                    /// accompanied by impressions which are aggregated on a monthly basis. Example request: GET
                    /// https://businessprofileperformance.googleapis.com/v1/locations/12345/searchkeywords/impressions/monthly?monthly_range.start_month.year=2022&amp;amp;monthly_range.start_month.month=1&amp;amp;monthly_range.end_month.year=2022&amp;amp;monthly_range.end_month.month=3
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The location for which the time series should be fetched. Format:
                    /// locations/{location_id} where location_id is an unobfuscated listing id.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Returns the search keywords used to find a business in search or maps. Each search keyword is
                    /// accompanied by impressions which are aggregated on a monthly basis. Example request: GET
                    /// https://businessprofileperformance.googleapis.com/v1/locations/12345/searchkeywords/impressions/monthly?monthly_range.start_month.year=2022&amp;amp;monthly_range.start_month.month=1&amp;amp;monthly_range.end_month.year=2022&amp;amp;monthly_range.end_month.month=3
                    /// </summary>
                    public class ListRequest : BusinessProfilePerformanceBaseServiceRequest<Google.Apis.BusinessProfilePerformance.v1.Data.ListSearchKeywordImpressionsMonthlyResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The location for which the time series should be fetched. Format:
                        /// locations/{location_id} where location_id is an unobfuscated listing id.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a
                        /// year by itself or a year and month where the day isn't significant.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("monthlyRange.endMonth.day", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> MonthlyRangeEndMonthDay { get; set; }

                        /// <summary>
                        /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("monthlyRange.endMonth.month", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> MonthlyRangeEndMonthMonth { get; set; }

                        /// <summary>
                        /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("monthlyRange.endMonth.year", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> MonthlyRangeEndMonthYear { get; set; }

                        /// <summary>
                        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a
                        /// year by itself or a year and month where the day isn't significant.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("monthlyRange.startMonth.day", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> MonthlyRangeStartMonthDay { get; set; }

                        /// <summary>
                        /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("monthlyRange.startMonth.month", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> MonthlyRangeStartMonthMonth { get; set; }

                        /// <summary>
                        /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("monthlyRange.startMonth.year", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> MonthlyRangeStartMonthYear { get; set; }

                        /// <summary>
                        /// Optional. The number of results requested. The default page size is 100. Page size can be
                        /// set to a maximum of 100.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token indicating the next paginated result to be returned.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/searchkeywords/impressions/monthly";

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
                                Pattern = @"^locations/[^/]+$",
                            });
                            RequestParameters.Add("monthlyRange.endMonth.day", new Google.Apis.Discovery.Parameter
                            {
                                Name = "monthlyRange.endMonth.day",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("monthlyRange.endMonth.month", new Google.Apis.Discovery.Parameter
                            {
                                Name = "monthlyRange.endMonth.month",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("monthlyRange.endMonth.year", new Google.Apis.Discovery.Parameter
                            {
                                Name = "monthlyRange.endMonth.year",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("monthlyRange.startMonth.day", new Google.Apis.Discovery.Parameter
                            {
                                Name = "monthlyRange.startMonth.day",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("monthlyRange.startMonth.month", new Google.Apis.Discovery.Parameter
                            {
                                Name = "monthlyRange.startMonth.month",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("monthlyRange.startMonth.year", new Google.Apis.Discovery.Parameter
                            {
                                Name = "monthlyRange.startMonth.year",
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

        /// <summary>
        ///  Returns the values for each date from a given time range that are associated with the specific daily
        /// metric. Example request: GET
        /// https://businessprofileperformance.googleapis.com/v1/locations/12345:getDailyMetricsTimeSeries?dailyMetric=WEBSITE_CLICKS&amp;amp;daily_range.start_date.year=2022&amp;amp;daily_range.start_date.month=1&amp;amp;daily_range.start_date.day=1&amp;amp;daily_range.end_date.year=2022&amp;amp;daily_range.end_date.month=3&amp;amp;daily_range.end_date.day=31
        /// </summary>
        /// <param name="name">
        /// Required. The location for which the time series should be fetched. Format: locations/{location_id} where
        /// location_id is an unobfuscated listing id.
        /// </param>
        public virtual GetDailyMetricsTimeSeriesRequest GetDailyMetricsTimeSeries(string name)
        {
            return new GetDailyMetricsTimeSeriesRequest(service, name);
        }

        /// <summary>
        ///  Returns the values for each date from a given time range that are associated with the specific daily
        /// metric. Example request: GET
        /// https://businessprofileperformance.googleapis.com/v1/locations/12345:getDailyMetricsTimeSeries?dailyMetric=WEBSITE_CLICKS&amp;amp;daily_range.start_date.year=2022&amp;amp;daily_range.start_date.month=1&amp;amp;daily_range.start_date.day=1&amp;amp;daily_range.end_date.year=2022&amp;amp;daily_range.end_date.month=3&amp;amp;daily_range.end_date.day=31
        /// </summary>
        public class GetDailyMetricsTimeSeriesRequest : BusinessProfilePerformanceBaseServiceRequest<Google.Apis.BusinessProfilePerformance.v1.Data.GetDailyMetricsTimeSeriesResponse>
        {
            /// <summary>Constructs a new GetDailyMetricsTimeSeries request.</summary>
            public GetDailyMetricsTimeSeriesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The location for which the time series should be fetched. Format: locations/{location_id}
            /// where location_id is an unobfuscated listing id.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. The metric to retrieve time series.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dailyMetric", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DailyMetricEnum> DailyMetric { get; set; }

            /// <summary>Required. The metric to retrieve time series.</summary>
            public enum DailyMetricEnum
            {
                /// <summary>Represents the default unknown value.</summary>
                [Google.Apis.Util.StringValueAttribute("DAILY_METRIC_UNKNOWN")]
                DAILYMETRICUNKNOWN = 0,

                /// <summary>
                /// Business impressions on Google Maps on Desktop devices. Multiple impressions by a unique user within
                /// a single day are counted as a single impression.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BUSINESS_IMPRESSIONS_DESKTOP_MAPS")]
                BUSINESSIMPRESSIONSDESKTOPMAPS = 1,

                /// <summary>
                /// Business impressions on Google Search on Desktop devices. Multiple impressions by a unique user
                /// within a single day are counted as a single impression.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BUSINESS_IMPRESSIONS_DESKTOP_SEARCH")]
                BUSINESSIMPRESSIONSDESKTOPSEARCH = 2,

                /// <summary>
                /// Business impressions on Google Maps on Mobile devices. Multiple impressions by a unique user within
                /// a single day are counted as a single impression.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BUSINESS_IMPRESSIONS_MOBILE_MAPS")]
                BUSINESSIMPRESSIONSMOBILEMAPS = 3,

                /// <summary>
                /// Business impressions on Google Search on Mobile devices. Multiple impressions by a unique user
                /// within a single day are counted as a single impression.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("BUSINESS_IMPRESSIONS_MOBILE_SEARCH")]
                BUSINESSIMPRESSIONSMOBILESEARCH = 4,

                /// <summary>The number of message conversations received on the business profile.</summary>
                [Google.Apis.Util.StringValueAttribute("BUSINESS_CONVERSATIONS")]
                BUSINESSCONVERSATIONS = 5,

                /// <summary>The number of times a direction request was requested to the business location.</summary>
                [Google.Apis.Util.StringValueAttribute("BUSINESS_DIRECTION_REQUESTS")]
                BUSINESSDIRECTIONREQUESTS = 6,

                /// <summary>The number of times the business profile call button was clicked.</summary>
                [Google.Apis.Util.StringValueAttribute("CALL_CLICKS")]
                CALLCLICKS = 7,

                /// <summary>The number of times the business profile website was clicked.</summary>
                [Google.Apis.Util.StringValueAttribute("WEBSITE_CLICKS")]
                WEBSITECLICKS = 8,

                /// <summary>The number of bookings received from the business profile.</summary>
                [Google.Apis.Util.StringValueAttribute("BUSINESS_BOOKINGS")]
                BUSINESSBOOKINGS = 9,

                /// <summary>The number of food orders received from the business profile.</summary>
                [Google.Apis.Util.StringValueAttribute("BUSINESS_FOOD_ORDERS")]
                BUSINESSFOODORDERS = 10,
            }

            /// <summary>
            /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself
            /// or a year and month where the day isn't significant.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dailyRange.endDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailyRangeEndDateDay { get; set; }

            /// <summary>
            /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dailyRange.endDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailyRangeEndDateMonth { get; set; }

            /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dailyRange.endDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailyRangeEndDateYear { get; set; }

            /// <summary>
            /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself
            /// or a year and month where the day isn't significant.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dailyRange.startDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailyRangeStartDateDay { get; set; }

            /// <summary>
            /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dailyRange.startDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailyRangeStartDateMonth { get; set; }

            /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dailyRange.startDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailyRangeStartDateYear { get; set; }

            /// <summary>Represents the day of the week. Eg: MONDAY.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dailySubEntityType.dayOfWeek", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DailySubEntityTypeDayOfWeekEnum> DailySubEntityTypeDayOfWeek { get; set; }

            /// <summary>Represents the day of the week. Eg: MONDAY.</summary>
            public enum DailySubEntityTypeDayOfWeekEnum
            {
                /// <summary>The day of the week is unspecified.</summary>
                [Google.Apis.Util.StringValueAttribute("DAY_OF_WEEK_UNSPECIFIED")]
                DAYOFWEEKUNSPECIFIED = 0,

                /// <summary>Monday</summary>
                [Google.Apis.Util.StringValueAttribute("MONDAY")]
                MONDAY = 1,

                /// <summary>Tuesday</summary>
                [Google.Apis.Util.StringValueAttribute("TUESDAY")]
                TUESDAY = 2,

                /// <summary>Wednesday</summary>
                [Google.Apis.Util.StringValueAttribute("WEDNESDAY")]
                WEDNESDAY = 3,

                /// <summary>Thursday</summary>
                [Google.Apis.Util.StringValueAttribute("THURSDAY")]
                THURSDAY = 4,

                /// <summary>Friday</summary>
                [Google.Apis.Util.StringValueAttribute("FRIDAY")]
                FRIDAY = 5,

                /// <summary>Saturday</summary>
                [Google.Apis.Util.StringValueAttribute("SATURDAY")]
                SATURDAY = 6,

                /// <summary>Sunday</summary>
                [Google.Apis.Util.StringValueAttribute("SUNDAY")]
                SUNDAY = 7,
            }

            /// <summary>
            /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00"
            /// for scenarios like business closing time.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dailySubEntityType.timeOfDay.hours", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailySubEntityTypeTimeOfDayHours { get; set; }

            /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dailySubEntityType.timeOfDay.minutes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailySubEntityTypeTimeOfDayMinutes { get; set; }

            /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dailySubEntityType.timeOfDay.nanos", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailySubEntityTypeTimeOfDayNanos { get; set; }

            /// <summary>
            /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it
            /// allows leap-seconds.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("dailySubEntityType.timeOfDay.seconds", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> DailySubEntityTypeTimeOfDaySeconds { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getDailyMetricsTimeSeries";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:getDailyMetricsTimeSeries";

            /// <summary>Initializes GetDailyMetricsTimeSeries parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+$",
                });
                RequestParameters.Add("dailyMetric", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailyMetric",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailyRange.endDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailyRange.endDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailyRange.endDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailyRange.endDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailyRange.endDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailyRange.endDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailyRange.startDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailyRange.startDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailyRange.startDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailyRange.startDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailyRange.startDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailyRange.startDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailySubEntityType.dayOfWeek", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailySubEntityType.dayOfWeek",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailySubEntityType.timeOfDay.hours", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailySubEntityType.timeOfDay.hours",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailySubEntityType.timeOfDay.minutes", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailySubEntityType.timeOfDay.minutes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailySubEntityType.timeOfDay.nanos", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailySubEntityType.timeOfDay.nanos",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("dailySubEntityType.timeOfDay.seconds", new Google.Apis.Discovery.Parameter
                {
                    Name = "dailySubEntityType.timeOfDay.seconds",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.BusinessProfilePerformance.v1.Data
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

    /// <summary>Represents a single datapoint in the timeseries, where each datapoint is a date-value pair.</summary>
    public class DatedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The date that the datapoint corresponds to. This represents a month value if the day field is not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>The value of the datapoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the response for GetDailyMetricsTimeSeries.</summary>
    public class GetDailyMetricsTimeSeriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The daily time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeries")]
        public virtual TimeSeries TimeSeries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an insights value.</summary>
    public class InsightsValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents the threshold below which the actual value falls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual System.Nullable<long> Threshold { get; set; }

        /// <summary>Represents the actual value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<long> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the response for ListSearchKeywordImpressionsMonthly.</summary>
    public class ListSearchKeywordImpressionsMonthlyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token indicating the last paginated result returned. This can be used by succeeding requests to get the
        /// next "page" of keywords. It will only be present when there are more results to be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Search terms which have been used to find a business.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchKeywordsCounts")]
        public virtual System.Collections.Generic.IList<SearchKeywordCount> SearchKeywordsCounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single search keyword and its value.</summary>
    public class SearchKeywordCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// One of either: 1) The sum of the number of unique users that used the keyword in a month, aggregated for
        /// each month requested. 2) A threshold that indicates that the actual value is below this threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insightsValue")]
        public virtual InsightsValue InsightsValue { get; set; }

        /// <summary>The lower-cased string that the user entered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchKeyword")]
        public virtual string SearchKeyword { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a timeseries.</summary>
    public class TimeSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of datapoints in the timeseries, where each datapoint is a date-value pair.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datedValues")]
        public virtual System.Collections.Generic.IList<DatedValue> DatedValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
