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

namespace Google.Apis.MyBusinessBusinessCalls.v1
{
    /// <summary>The MyBusinessBusinessCalls Service.</summary>
    public class MyBusinessBusinessCallsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MyBusinessBusinessCallsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MyBusinessBusinessCallsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Locations = new LocationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "mybusinessbusinesscalls";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://mybusinessbusinesscalls.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://mybusinessbusinesscalls.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }
    }

    /// <summary>A base abstract class for MyBusinessBusinessCalls requests.</summary>
    public abstract class MyBusinessBusinessCallsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MyBusinessBusinessCallsBaseServiceRequest instance.</summary>
        protected MyBusinessBusinessCallsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes MyBusinessBusinessCalls parameter list.</summary>
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
            Businesscallsinsights = new BusinesscallsinsightsResource(service);
        }

        /// <summary>Gets the Businesscallsinsights resource.</summary>
        public virtual BusinesscallsinsightsResource Businesscallsinsights { get; }

        /// <summary>The "businesscallsinsights" collection of methods.</summary>
        public class BusinesscallsinsightsResource
        {
            private const string Resource = "businesscallsinsights";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BusinesscallsinsightsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Returns insights for Business calls for a location.</summary>
            /// <param name="parent">
            /// Required. The parent location to fetch calls insights for. Format: locations/{location_id}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Returns insights for Business calls for a location.</summary>
            public class ListRequest : MyBusinessBusinessCallsBaseServiceRequest<Google.Apis.MyBusinessBusinessCalls.v1.Data.ListBusinessCallsInsightsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent location to fetch calls insights for. Format: locations/{location_id}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. A filter constraining the calls insights to return. The response includes only entries
                /// that match the filter. If the MetricType is not provided, AGGREGATE_COUNT is returned. If no
                /// end_date is provided, the last date for which data is available is used. If no start_date is
                /// provided, we will default to the first date for which data is available, which is currently 6
                /// months. If start_date is before the date when data is available, data is returned starting from the
                /// date when it is available. At this time we support following filters. 1. start_date="DATE" where
                /// date is in YYYY-MM-DD format. 2. end_date="DATE" where date is in YYYY-MM-DD format. 3.
                /// metric_type=XYZ where XYZ is a valid MetricType. 4. Conjunctions(AND) of all of the above. e.g.,
                /// "start_date=2021-08-01 AND end_date=2021-08-10 AND metric_type=AGGREGATE_COUNT" The AGGREGATE_COUNT
                /// metric_type ignores the DD part of the date.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of BusinessCallsInsights to return. If unspecified, at most 20 will be
                /// returned. Some of the metric_types(e.g, AGGREGATE_COUNT) returns a single page. For these metrics,
                /// the page_size is ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListBusinessCallsInsights` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListBusinessCallsInsights` must match the call that provided the page token. Some of the
                /// metric_types (e.g, AGGREGATE_COUNT) returns a single page. For these metrics, the pake_token is
                /// ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/businesscallsinsights";

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
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
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

        /// <summary>Returns the Business calls settings resource for the given location.</summary>
        /// <param name="name">
        /// Required. The BusinessCallsSettings to get. The `name` field is used to identify the business call settings
        /// to get. Format: locations/{location_id}/businesscallssettings.
        /// </param>
        public virtual GetBusinesscallssettingsRequest GetBusinesscallssettings(string name)
        {
            return new GetBusinesscallssettingsRequest(service, name);
        }

        /// <summary>Returns the Business calls settings resource for the given location.</summary>
        public class GetBusinesscallssettingsRequest : MyBusinessBusinessCallsBaseServiceRequest<Google.Apis.MyBusinessBusinessCalls.v1.Data.BusinessCallsSettings>
        {
            /// <summary>Constructs a new GetBusinesscallssettings request.</summary>
            public GetBusinesscallssettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The BusinessCallsSettings to get. The `name` field is used to identify the business call
            /// settings to get. Format: locations/{location_id}/businesscallssettings.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getBusinesscallssettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetBusinesscallssettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+/businesscallssettings$",
                });
            }
        }

        /// <summary>Updates the Business call settings for the specified location.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The resource name of the calls settings. Format: locations/{location}/businesscallssettings
        /// </param>
        public virtual UpdateBusinesscallssettingsRequest UpdateBusinesscallssettings(Google.Apis.MyBusinessBusinessCalls.v1.Data.BusinessCallsSettings body, string name)
        {
            return new UpdateBusinesscallssettingsRequest(service, body, name);
        }

        /// <summary>Updates the Business call settings for the specified location.</summary>
        public class UpdateBusinesscallssettingsRequest : MyBusinessBusinessCallsBaseServiceRequest<Google.Apis.MyBusinessBusinessCalls.v1.Data.BusinessCallsSettings>
        {
            /// <summary>Constructs a new UpdateBusinesscallssettings request.</summary>
            public UpdateBusinesscallssettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.MyBusinessBusinessCalls.v1.Data.BusinessCallsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the calls settings. Format: locations/{location}/businesscallssettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. The list of fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.MyBusinessBusinessCalls.v1.Data.BusinessCallsSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateBusinesscallssettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateBusinesscallssettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^locations/[^/]+/businesscallssettings$",
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
}
namespace Google.Apis.MyBusinessBusinessCalls.v1.Data
{
    /// <summary>Metrics aggregated over the input time range.</summary>
    public class AggregateMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total count of answered calls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answeredCallsCount")]
        public virtual System.Nullable<int> AnsweredCallsCount { get; set; }

        /// <summary>End date for this metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>A list of metrics by hour of day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hourlyMetrics")]
        public virtual System.Collections.Generic.IList<HourlyMetrics> HourlyMetrics { get; set; }

        /// <summary>Total count of missed calls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missedCallsCount")]
        public virtual System.Nullable<int> MissedCallsCount { get; set; }

        /// <summary>Date for this metric. If metric is monthly, only year and month are used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>A list of metrics by day of week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekdayMetrics")]
        public virtual System.Collections.Generic.IList<WeekDayMetrics> WeekdayMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Insights for calls made to a location.</summary>
    public class BusinessCallsInsights : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metric for the time range based on start_date and end_date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateMetrics")]
        public virtual AggregateMetrics AggregateMetrics { get; set; }

        /// <summary>The metric for which the value applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricType")]
        public virtual string MetricType { get; set; }

        /// <summary>
        /// Required. The resource name of the calls insights. Format: locations/{location}/businesscallsinsights
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Business calls settings for a location.</summary>
    public class BusinessCallsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The state of this location's enrollment in Business calls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callsState")]
        public virtual string CallsState { get; set; }

        /// <summary>
        /// Input only. Time when the end user provided consent to the API user to enable business calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentTime")]
        public virtual object ConsentTime { get; set; }

        /// <summary>
        /// Required. The resource name of the calls settings. Format: locations/{location}/businesscallssettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>Metrics for an hour.</summary>
    public class HourlyMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hour of the day. Allowed values are 0-23.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hour")]
        public virtual System.Nullable<int> Hour { get; set; }

        /// <summary>Total count of missed calls for this hour.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missedCallsCount")]
        public virtual System.Nullable<int> MissedCallsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListBusinessCallsInsights.</summary>
    public class ListBusinessCallsInsightsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A collection of business calls insights for the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("businessCallsInsights")]
        public virtual System.Collections.Generic.IList<BusinessCallsInsights> BusinessCallsInsights { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages. Some of the metric_types (e.g, AGGREGATE_COUNT) returns a single page. For these metrics,
        /// the next_page_token will be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for a week day.</summary>
    public class WeekDayMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Day of the week. Allowed values are Sunday - Saturday.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>Total count of missed calls for this hour.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("missedCallsCount")]
        public virtual System.Nullable<int> MissedCallsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
