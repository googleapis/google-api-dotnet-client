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

namespace Google.Apis.AnalyticsData.v1beta
{
    /// <summary>The AnalyticsData Service.</summary>
    public class AnalyticsDataService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AnalyticsDataService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AnalyticsDataService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Properties = new PropertiesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "analyticsdata";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://analyticsdata.googleapis.com/";
        #else
            "https://analyticsdata.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://analyticsdata.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Analytics Data API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Analytics data</summary>
            public static string Analytics = "https://www.googleapis.com/auth/analytics";

            /// <summary>See and download your Google Analytics data</summary>
            public static string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Analytics Data API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Analytics data</summary>
            public const string Analytics = "https://www.googleapis.com/auth/analytics";

            /// <summary>See and download your Google Analytics data</summary>
            public const string AnalyticsReadonly = "https://www.googleapis.com/auth/analytics.readonly";
        }

        /// <summary>Gets the Properties resource.</summary>
        public virtual PropertiesResource Properties { get; }
    }

    /// <summary>A base abstract class for AnalyticsData requests.</summary>
    public abstract class AnalyticsDataBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AnalyticsDataBaseServiceRequest instance.</summary>
        protected AnalyticsDataBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AnalyticsData parameter list.</summary>
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

    /// <summary>The "properties" collection of methods.</summary>
    public class PropertiesResource
    {
        private const string Resource = "properties";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PropertiesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns multiple pivot reports in a batch. All reports must be for the same GA4 Property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="property">
        /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not the
        /// body. To learn more, see [where to find your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). This property must be
        /// specified for the batch. The property within RunPivotReportRequest may either be unspecified or consistent
        /// with this property. Example: properties/1234
        /// </param>
        public virtual BatchRunPivotReportsRequest BatchRunPivotReports(Google.Apis.AnalyticsData.v1beta.Data.BatchRunPivotReportsRequest body, string property)
        {
            return new BatchRunPivotReportsRequest(service, body, property);
        }

        /// <summary>Returns multiple pivot reports in a batch. All reports must be for the same GA4 Property.</summary>
        public class BatchRunPivotReportsRequest : AnalyticsDataBaseServiceRequest<Google.Apis.AnalyticsData.v1beta.Data.BatchRunPivotReportsResponse>
        {
            /// <summary>Constructs a new BatchRunPivotReports request.</summary>
            public BatchRunPivotReportsRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsData.v1beta.Data.BatchRunPivotReportsRequest body, string property) : base(service)
            {
                Property = property;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not
            /// the body. To learn more, see [where to find your Property
            /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). This property must
            /// be specified for the batch. The property within RunPivotReportRequest may either be unspecified or
            /// consistent with this property. Example: properties/1234
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("property", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Property { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AnalyticsData.v1beta.Data.BatchRunPivotReportsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchRunPivotReports";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+property}:batchRunPivotReports";

            /// <summary>Initializes BatchRunPivotReports parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("property", new Google.Apis.Discovery.Parameter
                {
                    Name = "property",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }

        /// <summary>Returns multiple reports in a batch. All reports must be for the same GA4 Property.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="property">
        /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not the
        /// body. To learn more, see [where to find your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). This property must be
        /// specified for the batch. The property within RunReportRequest may either be unspecified or consistent with
        /// this property. Example: properties/1234
        /// </param>
        public virtual BatchRunReportsRequest BatchRunReports(Google.Apis.AnalyticsData.v1beta.Data.BatchRunReportsRequest body, string property)
        {
            return new BatchRunReportsRequest(service, body, property);
        }

        /// <summary>Returns multiple reports in a batch. All reports must be for the same GA4 Property.</summary>
        public class BatchRunReportsRequest : AnalyticsDataBaseServiceRequest<Google.Apis.AnalyticsData.v1beta.Data.BatchRunReportsResponse>
        {
            /// <summary>Constructs a new BatchRunReports request.</summary>
            public BatchRunReportsRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsData.v1beta.Data.BatchRunReportsRequest body, string property) : base(service)
            {
                Property = property;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not
            /// the body. To learn more, see [where to find your Property
            /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). This property must
            /// be specified for the batch. The property within RunReportRequest may either be unspecified or consistent
            /// with this property. Example: properties/1234
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("property", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Property { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AnalyticsData.v1beta.Data.BatchRunReportsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchRunReports";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+property}:batchRunReports";

            /// <summary>Initializes BatchRunReports parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("property", new Google.Apis.Discovery.Parameter
                {
                    Name = "property",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods. Used to explore the dimensions
        /// and metrics. In this method, a Google Analytics GA4 Property Identifier is specified in the request, and the
        /// metadata response includes Custom dimensions and metrics as well as Universal metadata. For example if a
        /// custom metric with parameter name `levels_unlocked` is registered to a property, the Metadata response will
        /// contain `customEvent:levels_unlocked`. Universal metadata are dimensions and metrics applicable to any
        /// property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is specified in the URL path and
        /// not URL parameters. Property is a numeric Google Analytics GA4 Property identifier. To learn more, see
        /// [where to find your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Example:
        /// properties/1234/metadata Set the Property ID to 0 for dimensions and metrics common to all properties. In
        /// this special mode, this method will not return custom dimensions and metrics.
        /// </param>
        public virtual GetMetadataRequest GetMetadata(string name)
        {
            return new GetMetadataRequest(service, name);
        }

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods. Used to explore the dimensions
        /// and metrics. In this method, a Google Analytics GA4 Property Identifier is specified in the request, and the
        /// metadata response includes Custom dimensions and metrics as well as Universal metadata. For example if a
        /// custom metric with parameter name `levels_unlocked` is registered to a property, the Metadata response will
        /// contain `customEvent:levels_unlocked`. Universal metadata are dimensions and metrics applicable to any
        /// property such as `country` and `totalUsers`.
        /// </summary>
        public class GetMetadataRequest : AnalyticsDataBaseServiceRequest<Google.Apis.AnalyticsData.v1beta.Data.Metadata>
        {
            /// <summary>Constructs a new GetMetadata request.</summary>
            public GetMetadataRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The resource name of the metadata to retrieve. This name field is specified in the URL path
            /// and not URL parameters. Property is a numeric Google Analytics GA4 Property identifier. To learn more,
            /// see [where to find your Property
            /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Example:
            /// properties/1234/metadata Set the Property ID to 0 for dimensions and metrics common to all properties.
            /// In this special mode, this method will not return custom dimensions and metrics.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getMetadata";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes GetMetadata parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+/metadata$",
                });
            }
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data. Pivot reports are more advanced and
        /// expressive formats than regular reports. In a pivot report, dimensions are only visible if they are included
        /// in a pivot. Multiple pivots can be specified to further dissect your data.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="property">
        /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not the
        /// body. To learn more, see [where to find your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Within a batch
        /// request, this property should either be unspecified or consistent with the batch-level property. Example:
        /// properties/1234
        /// </param>
        public virtual RunPivotReportRequest RunPivotReport(Google.Apis.AnalyticsData.v1beta.Data.RunPivotReportRequest body, string property)
        {
            return new RunPivotReportRequest(service, body, property);
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data. Pivot reports are more advanced and
        /// expressive formats than regular reports. In a pivot report, dimensions are only visible if they are included
        /// in a pivot. Multiple pivots can be specified to further dissect your data.
        /// </summary>
        public class RunPivotReportRequest : AnalyticsDataBaseServiceRequest<Google.Apis.AnalyticsData.v1beta.Data.RunPivotReportResponse>
        {
            /// <summary>Constructs a new RunPivotReport request.</summary>
            public RunPivotReportRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsData.v1beta.Data.RunPivotReportRequest body, string property) : base(service)
            {
                Property = property;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not
            /// the body. To learn more, see [where to find your Property
            /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Within a batch
            /// request, this property should either be unspecified or consistent with the batch-level property.
            /// Example: properties/1234
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("property", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Property { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AnalyticsData.v1beta.Data.RunPivotReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runPivotReport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+property}:runPivotReport";

            /// <summary>Initializes RunPivotReport parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("property", new Google.Apis.Discovery.Parameter
                {
                    Name = "property",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime event data for your property.
        /// These reports show events and usage from the last 30 minutes.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="property">
        /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not the
        /// body. To learn more, see [where to find your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Example:
        /// properties/1234
        /// </param>
        public virtual RunRealtimeReportRequest RunRealtimeReport(Google.Apis.AnalyticsData.v1beta.Data.RunRealtimeReportRequest body, string property)
        {
            return new RunRealtimeReportRequest(service, body, property);
        }

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime event data for your property.
        /// These reports show events and usage from the last 30 minutes.
        /// </summary>
        public class RunRealtimeReportRequest : AnalyticsDataBaseServiceRequest<Google.Apis.AnalyticsData.v1beta.Data.RunRealtimeReportResponse>
        {
            /// <summary>Constructs a new RunRealtimeReport request.</summary>
            public RunRealtimeReportRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsData.v1beta.Data.RunRealtimeReportRequest body, string property) : base(service)
            {
                Property = property;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not
            /// the body. To learn more, see [where to find your Property
            /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Example:
            /// properties/1234
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("property", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Property { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AnalyticsData.v1beta.Data.RunRealtimeReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runRealtimeReport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+property}:runRealtimeReport";

            /// <summary>Initializes RunRealtimeReport parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("property", new Google.Apis.Discovery.Parameter
                {
                    Name = "property",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports contain statistics derived from
        /// data collected by the Google Analytics tracking code. The data returned from the API is as a table with
        /// columns for the requested dimensions and metrics. Metrics are individual measurements of user activity on
        /// your property, such as active users or event count. Dimensions break down metrics across some common
        /// criteria, such as country or event name.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="property">
        /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not the
        /// body. To learn more, see [where to find your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Within a batch
        /// request, this property should either be unspecified or consistent with the batch-level property. Example:
        /// properties/1234
        /// </param>
        public virtual RunReportRequest RunReport(Google.Apis.AnalyticsData.v1beta.Data.RunReportRequest body, string property)
        {
            return new RunReportRequest(service, body, property);
        }

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports contain statistics derived from
        /// data collected by the Google Analytics tracking code. The data returned from the API is as a table with
        /// columns for the requested dimensions and metrics. Metrics are individual measurements of user activity on
        /// your property, such as active users or event count. Dimensions break down metrics across some common
        /// criteria, such as country or event name.
        /// </summary>
        public class RunReportRequest : AnalyticsDataBaseServiceRequest<Google.Apis.AnalyticsData.v1beta.Data.RunReportResponse>
        {
            /// <summary>Constructs a new RunReport request.</summary>
            public RunReportRequest(Google.Apis.Services.IClientService service, Google.Apis.AnalyticsData.v1beta.Data.RunReportRequest body, string property) : base(service)
            {
                Property = property;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not
            /// the body. To learn more, see [where to find your Property
            /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Within a batch
            /// request, this property should either be unspecified or consistent with the batch-level property.
            /// Example: properties/1234
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("property", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Property { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AnalyticsData.v1beta.Data.RunReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "runReport";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+property}:runReport";

            /// <summary>Initializes RunReport parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("property", new Google.Apis.Discovery.Parameter
                {
                    Name = "property",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^properties/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.AnalyticsData.v1beta.Data
{
    /// <summary>The batch request containing multiple pivot report requests.</summary>
    public class BatchRunPivotReportsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Individual requests. Each request has a separate pivot report response. Each batch request is allowed up to
        /// 5 requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<RunPivotReportRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The batch response containing multiple pivot reports.</summary>
    public class BatchRunPivotReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this message is. This `kind` is always the fixed string
        /// "analyticsData#batchRunPivotReports". Useful to distinguish between response types in JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Individual responses. Each response has a separate pivot report request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivotReports")]
        public virtual System.Collections.Generic.IList<RunPivotReportResponse> PivotReports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The batch request containing multiple report requests.</summary>
    public class BatchRunReportsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Individual requests. Each request has a separate report response. Each batch request is allowed up to 5
        /// requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<RunReportRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The batch response containing multiple reports.</summary>
    public class BatchRunReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifies what kind of resource this message is. This `kind` is always the fixed string
        /// "analyticsData#batchRunReports". Useful to distinguish between response types in JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Individual responses. Each response has a separate report request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<RunReportResponse> Reports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>To express that the result needs to be between two numbers (inclusive).</summary>
    public class BetweenFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Begins with this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromValue")]
        public virtual NumericValue FromValue { get; set; }

        /// <summary>Ends with this number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toValue")]
        public virtual NumericValue ToValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used to convert a dimension value to a single case.</summary>
    public class CaseExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of a dimension. The name must refer back to a name in dimensions field of the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a cohort selection criteria. A cohort is a group of users who share a common characteristic. For
    /// example, users with the same `firstSessionDate` belong to the same cohort.
    /// </summary>
    public class Cohort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The cohort selects users whose first touch date is between start date and end date defined in the
        /// `dateRange`. This `dateRange` does not specify the full date range of event data that is present in a cohort
        /// report. In a cohort report, this `dateRange` is extended by the granularity and offset present in the
        /// `cohortsRange`; event data for the extended reporting date range is present in a cohort report. In a cohort
        /// request, this `dateRange` is required and the `dateRanges` in the `RunReportRequest` or
        /// `RunPivotReportRequest` must be unspecified. This `dateRange` should generally be aligned with the cohort's
        /// granularity. If `CohortsRange` uses daily granularity, this `dateRange` can be a single day. If
        /// `CohortsRange` uses weekly granularity, this `dateRange` can be aligned to a week boundary, starting at
        /// Sunday and ending Saturday. If `CohortsRange` uses monthly granularity, this `dateRange` can be aligned to a
        /// month, starting at the first and ending on the last day of the month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>Dimension used by the cohort. Required and only supports `firstSessionDate`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>
        /// Assigns a name to this cohort. The dimension `cohort` is valued to this name in a report response. If set,
        /// cannot begin with `cohort_` or `RESERVED_`. If not set, cohorts are named by their zero based index
        /// `cohort_0`, `cohort_1`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Optional settings of a cohort report.</summary>
    public class CohortReportSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, accumulates the result from first touch day to the end day. Not supported in `RunReportRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accumulate")]
        public virtual System.Nullable<bool> Accumulate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The specification of cohorts for a cohort report. Cohort reports create a time series of user retention for the
    /// cohort. For example, you could select the cohort of users that were acquired in the first week of September and
    /// follow that cohort for the next six weeks. Selecting the users acquired in the first week of September cohort is
    /// specified in the `cohort` object. Following that cohort for the next six weeks is specified in the
    /// `cohortsRange` object. For examples, see [Cohort Report
    /// Examples](https://developers.google.com/analytics/devguides/reporting/data/v1/advanced#cohort_report_examples).
    /// The report response could show a weekly time series where say your app has retained 60% of this cohort after
    /// three weeks and 25% of this cohort after six weeks. These two percentages can be calculated by the metric
    /// `cohortActiveUsers/cohortTotalUsers` and will be separate rows in the report.
    /// </summary>
    public class CohortSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional settings for a cohort report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cohortReportSettings")]
        public virtual CohortReportSettings CohortReportSettings { get; set; }

        /// <summary>
        /// Defines the selection criteria to group users into cohorts. Most cohort reports define only a single cohort.
        /// If multiple cohorts are specified, each cohort can be recognized in the report by their name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cohorts")]
        public virtual System.Collections.Generic.IList<Cohort> Cohorts { get; set; }

        /// <summary>
        /// Cohort reports follow cohorts over an extended reporting date range. This range specifies an offset duration
        /// to follow the cohorts over.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cohortsRange")]
        public virtual CohortsRange CohortsRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures the extended reporting date range for a cohort report. Specifies an offset duration to follow the
    /// cohorts over.
    /// </summary>
    public class CohortsRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. `endOffset` specifies the end date of the extended reporting date range for a cohort report.
        /// `endOffset` can be any positive integer but is commonly set to 5 to 10 so that reports contain data on the
        /// cohort for the next several granularity time periods. If `granularity` is `DAILY`, the `endDate` of the
        /// extended reporting date range is `endDate` of the cohort plus `endOffset` days. If `granularity` is
        /// `WEEKLY`, the `endDate` of the extended reporting date range is `endDate` of the cohort plus `endOffset * 7`
        /// days. If `granularity` is `MONTHLY`, the `endDate` of the extended reporting date range is `endDate` of the
        /// cohort plus `endOffset * 30` days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual System.Nullable<int> EndOffset { get; set; }

        /// <summary>
        /// Required. The granularity used to interpret the `startOffset` and `endOffset` for the extended reporting
        /// date range for a cohort report.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("granularity")]
        public virtual string Granularity { get; set; }

        /// <summary>
        /// `startOffset` specifies the start date of the extended reporting date range for a cohort report.
        /// `startOffset` is commonly set to 0 so that reports contain data from the acquisition of the cohort forward.
        /// If `granularity` is `DAILY`, the `startDate` of the extended reporting date range is `startDate` of the
        /// cohort plus `startOffset` days. If `granularity` is `WEEKLY`, the `startDate` of the extended reporting date
        /// range is `startDate` of the cohort plus `startOffset * 7` days. If `granularity` is `MONTHLY`, the
        /// `startDate` of the extended reporting date range is `startDate` of the cohort plus `startOffset * 30` days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual System.Nullable<int> StartOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used to combine dimension values to a single dimension.</summary>
    public class ConcatenateExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The delimiter placed between dimension names. Delimiters are often single characters such as "|" or "," but
        /// can be longer strings. If a dimension value contains the delimiter, both will be present in response with no
        /// distinction. For example if dimension 1 value = "US,FR", dimension 2 value = "JP", and delimiter = ",", then
        /// the response will contain "US,FR,JP".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiter")]
        public virtual string Delimiter { get; set; }

        /// <summary>
        /// Names of dimensions. The names must refer back to names in the dimensions field of the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionNames")]
        public virtual System.Collections.Generic.IList<string> DimensionNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A contiguous set of days: startDate, startDate + 1, ..., endDate. Requests are allowed up to 4 date ranges.
    /// </summary>
    public class DateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The inclusive end date for the query in the format `YYYY-MM-DD`. Cannot be before `start_date`. The format
        /// `NdaysAgo`, `yesterday`, or `today` is also accepted, and in that case, the date is inferred based on the
        /// property's reporting time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; }

        /// <summary>
        /// Assigns a name to this date range. The dimension `dateRange` is valued to this name in a report response. If
        /// set, cannot begin with `date_range_` or `RESERVED_`. If not set, date ranges are named by their zero based
        /// index in the request: `date_range_0`, `date_range_1`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The inclusive start date for the query in the format `YYYY-MM-DD`. Cannot be after `end_date`. The format
        /// `NdaysAgo`, `yesterday`, or `today` is also accepted, and in that case, the date is inferred based on the
        /// property's reporting time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Dimensions are attributes of your data. For example, the dimension city indicates the city from which an event
    /// originates. Dimension values in report responses are strings; for example, city could be "Paris" or "New York".
    /// Requests are allowed up to 9 dimensions.
    /// </summary>
    public class Dimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// One dimension can be the result of an expression of multiple dimensions. For example, dimension "country,
        /// city": concatenate(country, ", ", city).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionExpression")]
        public virtual DimensionExpression DimensionExpression { get; set; }

        /// <summary>
        /// The name of the dimension. See the [API
        /// Dimensions](https://developers.google.com/analytics/devguides/reporting/data/v1/api-schema#dimensions) for
        /// the list of dimension names. If `dimensionExpression` is specified, `name` can be any string that you would
        /// like within the allowed character set. For example if a `dimensionExpression` concatenates `country` and
        /// `city`, you could call that dimension `countryAndCity`. Dimension names that you choose must match the
        /// regular expression "^[a-zA-Z0-9_]$". Dimensions are referenced by `name` in `dimensionFilter`, `orderBys`,
        /// `dimensionExpression`, and `pivots`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Used to express a dimension which is the result of a formula of multiple dimensions. Example usages: 1)
    /// lower_case(dimension) 2) concatenate(dimension1, symbol, dimension2).
    /// </summary>
    public class DimensionExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Used to combine dimension values to a single dimension. For example, dimension "country, city":
        /// concatenate(country, ", ", city).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concatenate")]
        public virtual ConcatenateExpression Concatenate { get; set; }

        /// <summary>Used to convert a dimension value to lower case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerCase")]
        public virtual CaseExpression LowerCase { get; set; }

        /// <summary>Used to convert a dimension value to upper case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upperCase")]
        public virtual CaseExpression UpperCase { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a dimension column in the report. Dimensions requested in a report produce column entries within rows
    /// and DimensionHeaders. However, dimensions used exclusively within filters or expressions do not produce columns
    /// in a report; correspondingly, those dimensions do not produce headers.
    /// </summary>
    public class DimensionHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Explains a dimension.</summary>
    public class DimensionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This dimension's name. Useable in [Dimension](#Dimension)'s `name`. For example, `eventName`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiName")]
        public virtual string ApiName { get; set; }

        /// <summary>True if the dimension is a custom dimension for this property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDefinition")]
        public virtual System.Nullable<bool> CustomDefinition { get; set; }

        /// <summary>
        /// Still usable but deprecated names for this dimension. If populated, this dimension is available by either
        /// `apiName` or one of `deprecatedApiNames` for a period of time. After the deprecation period, the dimension
        /// will be available only by `apiName`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecatedApiNames")]
        public virtual System.Collections.Generic.IList<string> DeprecatedApiNames { get; set; }

        /// <summary>Description of how this dimension is used and calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// This dimension's name within the Google Analytics user interface. For example, `Event name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uiName")]
        public virtual string UiName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorts by dimension values.</summary>
    public class DimensionOrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A dimension name in the request to order by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>Controls the rule for dimension value ordering.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderType")]
        public virtual string OrderType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The value of a dimension.</summary>
    public class DimensionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value as a string if the dimension type is a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An expression to filter dimension or metric values.</summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A filter for two values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("betweenFilter")]
        public virtual BetweenFilter BetweenFilter { get; set; }

        /// <summary>The dimension name or metric name. Must be a name defined in dimensions or metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; }

        /// <summary>A filter for in list values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inListFilter")]
        public virtual InListFilter InListFilter { get; set; }

        /// <summary>A filter for numeric or date values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericFilter")]
        public virtual NumericFilter NumericFilter { get; set; }

        /// <summary>Strings related filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringFilter")]
        public virtual StringFilter StringFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// To express dimension or metric filters. The fields in the same FilterExpression need to be either all dimensions
    /// or all metrics.
    /// </summary>
    public class FilterExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The FilterExpressions in and_group have an AND relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("andGroup")]
        public virtual FilterExpressionList AndGroup { get; set; }

        /// <summary>
        /// A primitive filter. All fields in filter in same FilterExpression needs to be either all dimensions or
        /// metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual Filter Filter { get; set; }

        /// <summary>The FilterExpression is NOT of not_expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notExpression")]
        public virtual FilterExpression NotExpression { get; set; }

        /// <summary>The FilterExpressions in or_group have an OR relationship.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orGroup")]
        public virtual FilterExpressionList OrGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of filter expressions.</summary>
    public class FilterExpressionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of filter expressions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressions")]
        public virtual System.Collections.Generic.IList<FilterExpression> Expressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result needs to be in a list of string values.</summary>
    public class InListFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, the string value is case sensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>The list of string values. Must be non-empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The dimensions and metrics currently accepted in reporting methods.</summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension descriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<DimensionMetadata> Dimensions { get; set; }

        /// <summary>The metric descriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<MetricMetadata> Metrics { get; set; }

        /// <summary>Resource name of this metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The quantitative measurements of a report. For example, the metric `eventCount` is the total number of events.
    /// Requests are allowed up to 10 metrics.
    /// </summary>
    public class Metric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mathematical expression for derived metrics. For example, the metric Event count per user is
        /// `eventCount/totalUsers`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Indicates if a metric is invisible in the report response. If a metric is invisible, the metric will not
        /// produce a column in the response, but can be used in `metricFilter`, `orderBys`, or a metric `expression`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invisible")]
        public virtual System.Nullable<bool> Invisible { get; set; }

        /// <summary>
        /// The name of the metric. See the [API
        /// Metrics](https://developers.google.com/analytics/devguides/reporting/data/v1/api-schema#metrics) for the
        /// list of metric names. If `expression` is specified, `name` can be any string that you would like within the
        /// allowed character set. For example if `expression` is `screenPageViews/sessions`, you could call that
        /// metric's name = `viewsPerSession`. Metric names that you choose must match the regular expression
        /// "^[a-zA-Z0-9_]$". Metrics are referenced by `name` in `metricFilter`, `orderBys`, and metric `expression`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a metric column in the report. Visible metrics requested in a report produce column entries within
    /// rows and MetricHeaders. However, metrics used exclusively within filters or expressions do not produce columns
    /// in a report; correspondingly, those metrics do not produce headers.
    /// </summary>
    public class MetricHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metric's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The metric's data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Explains a metric.</summary>
    public class MetricMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A metric name. Useable in [Metric](#Metric)'s `name`. For example, `eventCount`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiName")]
        public virtual string ApiName { get; set; }

        /// <summary>True if the metric is a custom metric for this property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDefinition")]
        public virtual System.Nullable<bool> CustomDefinition { get; set; }

        /// <summary>
        /// Still usable but deprecated names for this metric. If populated, this metric is available by either
        /// `apiName` or one of `deprecatedApiNames` for a period of time. After the deprecation period, the metric will
        /// be available only by `apiName`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecatedApiNames")]
        public virtual System.Collections.Generic.IList<string> DeprecatedApiNames { get; set; }

        /// <summary>Description of how this metric is used and calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The mathematical expression for this derived metric. Can be used in [Metric](#Metric)'s `expression` field
        /// for equivalent reports. Most metrics are not expressions, and for non-expressions, this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>The type of this metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// This metric's name within the Google Analytics user interface. For example, `Event count`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uiName")]
        public virtual string UiName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorts by metric values.</summary>
    public class MetricOrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A metric name in the request to order by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The value of a metric.</summary>
    public class MetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Measurement value. See MetricHeader for type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A contiguous set of minutes: startMinutesAgo, startMinutesAgo + 1, ..., endMinutesAgo. Requests are allowed up
    /// to 2 minute ranges.
    /// </summary>
    public class MinuteRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The inclusive end minute for the query as a number of minutes before now. Cannot be before
        /// `startMinutesAgo`. For example, `"endMinutesAgo": 15` specifies the report should include event data from
        /// prior to 15 minutes ago. If unspecified, `endMinutesAgo` is defaulted to 0. Standard Analytics properties
        /// can request any minute in the last 30 minutes of event data (`endMinutesAgo &amp;lt;= 29`), and 360
        /// Analytics properties can request any minute in the last 60 minutes of event data (`endMinutesAgo &amp;lt;=
        /// 59`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endMinutesAgo")]
        public virtual System.Nullable<int> EndMinutesAgo { get; set; }

        /// <summary>
        /// Assigns a name to this minute range. The dimension `dateRange` is valued to this name in a report response.
        /// If set, cannot begin with `date_range_` or `RESERVED_`. If not set, minute ranges are named by their zero
        /// based index in the request: `date_range_0`, `date_range_1`, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The inclusive start minute for the query as a number of minutes before now. For example, `"startMinutesAgo":
        /// 29` specifies the report should include event data from 29 minutes ago and after. Cannot be after
        /// `endMinutesAgo`. If unspecified, `startMinutesAgo` is defaulted to 29. Standard Analytics properties can
        /// request up to the last 30 minutes of event data (`startMinutesAgo &amp;lt;= 29`), and 360 Analytics
        /// properties can request up to the last 60 minutes of event data (`startMinutesAgo &amp;lt;= 59`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startMinutesAgo")]
        public virtual System.Nullable<int> StartMinutesAgo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filters for numeric or date values.</summary>
    public class NumericFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The operation type for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>A numeric value or a date value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual NumericValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>To represent a number.</summary>
    public class NumericValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Double value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>Integer value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The sort options.</summary>
    public class OrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, sorts by descending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desc")]
        public virtual System.Nullable<bool> Desc { get; set; }

        /// <summary>Sorts results by a dimension's values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual DimensionOrderBy Dimension { get; set; }

        /// <summary>Sorts results by a metric's values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual MetricOrderBy Metric { get; set; }

        /// <summary>Sorts results by a metric's values within a pivot column group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivot")]
        public virtual PivotOrderBy Pivot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the visible dimension columns and rows in the report response.</summary>
    public class Pivot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimension names for visible columns in the report response. Including "dateRange" produces a date range
        /// column; for each row in the response, dimension values in the date range column will indicate the
        /// corresponding date range from the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldNames")]
        public virtual System.Collections.Generic.IList<string> FieldNames { get; set; }

        /// <summary>
        /// The number of unique combinations of dimension values to return in this pivot. The `limit` parameter is
        /// required. A `limit` of 10,000 is common for single pivot requests. The product of the `limit` for each
        /// `pivot` in a `RunPivotReportRequest` must not exceed 100,000. For example, a two pivot request with `limit:
        /// 1000` in each pivot will fail because the product is `1,000,000`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>
        /// Aggregate the metrics by dimensions in this pivot using the specified metric_aggregations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricAggregations")]
        public virtual System.Collections.Generic.IList<string> MetricAggregations { get; set; }

        /// <summary>The row count of the start row. The first row is counted as row 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<long> Offset { get; set; }

        /// <summary>
        /// Specifies how dimensions are ordered in the pivot. In the first Pivot, the OrderBys determine Row and
        /// PivotDimensionHeader ordering; in subsequent Pivots, the OrderBys determine only PivotDimensionHeader
        /// ordering. Dimensions specified in these OrderBys must be a subset of Pivot.field_names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBys")]
        public virtual System.Collections.Generic.IList<OrderBy> OrderBys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summarizes dimension values from a row for this pivot.</summary>
    public class PivotDimensionHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Values of multiple dimensions in a pivot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IList<DimensionValue> DimensionValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimensions' values in a single pivot.</summary>
    public class PivotHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The size is the same as the cardinality of the corresponding dimension combinations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivotDimensionHeaders")]
        public virtual System.Collections.Generic.IList<PivotDimensionHeader> PivotDimensionHeaders { get; set; }

        /// <summary>
        /// The cardinality of the pivot. The total number of rows for this pivot's fields regardless of how the
        /// parameters `offset` and `limit` are specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorts by a pivot column group.</summary>
    public class PivotOrderBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// In the response to order by, order rows by this column. Must be a metric name from the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>
        /// Used to select a dimension name and value pivot. If multiple pivot selections are given, the sort occurs on
        /// rows where all pivot selection dimension name and value pairs match the row's dimension name and value pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivotSelections")]
        public virtual System.Collections.Generic.IList<PivotSelection> PivotSelections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A pair of dimension names and values. Rows with this dimension pivot pair are ordered by the metric's value. For
    /// example if pivots = {{"browser", "Chrome"}} and metric_name = "Sessions", then the rows will be sorted based on
    /// Sessions in Chrome. ---------|----------|----------------|----------|---------------- | Chrome | Chrome | Safari
    /// | Safari ---------|----------|----------------|----------|---------------- Country | Sessions | Pages/Sessions |
    /// Sessions | Pages/Sessions ---------|----------|----------------|----------|---------------- US | 2 | 2 | 3 | 1
    /// ---------|----------|----------------|----------|---------------- Canada | 3 | 1 | 4 | 1
    /// ---------|----------|----------------|----------|----------------
    /// </summary>
    public class PivotSelection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be a dimension name from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionName")]
        public virtual string DimensionName { get; set; }

        /// <summary>Order by only when the named dimension is this value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValue")]
        public virtual string DimensionValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Current state of all quotas for this Analytics Property. If any quota for a property is exhausted, all requests
    /// to that property will return Resource Exhausted errors.
    /// </summary>
    public class PropertyQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Standard Analytics Properties can send up to 10 concurrent requests; Analytics 360 Properties can use up to
        /// 50 concurrent requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("concurrentRequests")]
        public virtual QuotaStatus ConcurrentRequests { get; set; }

        /// <summary>
        /// Analytics Properties can send up to 120 requests with potentially thresholded dimensions per hour. In a
        /// batch request, each report request is individually counted for this quota if the request contains
        /// potentially thresholded dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("potentiallyThresholdedRequestsPerHour")]
        public virtual QuotaStatus PotentiallyThresholdedRequestsPerHour { get; set; }

        /// <summary>
        /// Standard Analytics Properties and cloud project pairs can have up to 10 server errors per hour; Analytics
        /// 360 Properties and cloud project pairs can have up to 50 server errors per hour.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverErrorsPerProjectPerHour")]
        public virtual QuotaStatus ServerErrorsPerProjectPerHour { get; set; }

        /// <summary>
        /// Standard Analytics Properties can use up to 25,000 tokens per day; Analytics 360 Properties can use 250,000
        /// tokens per day. Most requests consume fewer than 10 tokens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokensPerDay")]
        public virtual QuotaStatus TokensPerDay { get; set; }

        /// <summary>
        /// Standard Analytics Properties can use up to 5,000 tokens per hour; Analytics 360 Properties can use 50,000
        /// tokens per hour. An API request consumes a single number of tokens, and that number is deducted from both
        /// the hourly and daily quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokensPerHour")]
        public virtual QuotaStatus TokensPerHour { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Current state for a particular quota group.</summary>
    public class QuotaStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Quota consumed by this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumed")]
        public virtual System.Nullable<int> Consumed { get; set; }

        /// <summary>Quota remaining after this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remaining")]
        public virtual System.Nullable<int> Remaining { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response's metadata carrying additional information about the report content.</summary>
    public class ResponseMetaData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, indicates some buckets of dimension combinations are rolled into "(other)" row. This can happen for
        /// high cardinality reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLossFromOtherRow")]
        public virtual System.Nullable<bool> DataLossFromOtherRow { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Report data for each row. For example if RunReportRequest contains: ```none "dimensions": [ { "name":
    /// "eventName" }, { "name": "countryId" } ], "metrics": [ { "name": "eventCount" } ] ``` One row with
    /// 'in_app_purchase' as the eventName, 'JP' as the countryId, and 15 as the eventCount, would be: ```none
    /// "dimensionValues": [ { "value": "in_app_purchase" }, { "value": "JP" } ], "metricValues": [ { "value": "15" } ]
    /// ```
    /// </summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of requested dimension values. In a PivotReport, dimension_values are only listed for dimensions
        /// included in a pivot.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IList<DimensionValue> DimensionValues { get; set; }

        /// <summary>List of requested visible metric values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValues")]
        public virtual System.Collections.Generic.IList<MetricValue> MetricValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to generate a pivot report.</summary>
    public class RunPivotReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cohort group associated with this request. If there is a cohort group in the request the 'cohort' dimension
        /// must be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cohortSpec")]
        public virtual CohortSpec CohortSpec { get; set; }

        /// <summary>
        /// A currency code in ISO4217 format, such as "AED", "USD", "JPY". If the field is empty, the report uses the
        /// property's default currency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// The date range to retrieve event data for the report. If multiple date ranges are specified, event data from
        /// each date range is used in the report. A special dimension with field name "dateRange" can be included in a
        /// Pivot's field names; if included, the report compares between date ranges. In a cohort request, this
        /// `dateRanges` must be unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual System.Collections.Generic.IList<DateRange> DateRanges { get; set; }

        /// <summary>
        /// The filter clause of dimensions. Dimensions must be requested to be used in this filter. Metrics cannot be
        /// used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilter")]
        public virtual FilterExpression DimensionFilter { get; set; }

        /// <summary>
        /// The dimensions requested. All defined dimensions must be used by one of the following: dimension_expression,
        /// dimension_filter, pivots, order_bys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// If false or unspecified, each row with all metrics equal to 0 will not be returned. If true, these rows will
        /// be returned if they are not separately removed by a filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepEmptyRows")]
        public virtual System.Nullable<bool> KeepEmptyRows { get; set; }

        /// <summary>
        /// The filter clause of metrics. Applied at post aggregation phase, similar to SQL having-clause. Metrics must
        /// be requested to be used in this filter. Dimensions cannot be used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricFilter")]
        public virtual FilterExpression MetricFilter { get; set; }

        /// <summary>
        /// The metrics requested, at least one metric needs to be specified. All defined metrics must be used by one of
        /// the following: metric_expression, metric_filter, order_bys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<Metric> Metrics { get; set; }

        /// <summary>
        /// Describes the visual format of the report's dimensions in columns or rows. The union of the fieldNames
        /// (dimension names) in all pivots must be a subset of dimension names defined in Dimensions. No two pivots can
        /// share a dimension. A dimension is only visible if it appears in a pivot.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivots")]
        public virtual System.Collections.Generic.IList<Pivot> Pivots { get; set; }

        /// <summary>
        /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not the
        /// body. To learn more, see [where to find your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Within a batch
        /// request, this property should either be unspecified or consistent with the batch-level property. Example:
        /// properties/1234
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>
        /// Toggles whether to return the current state of this Analytics Property's quota. Quota is returned in
        /// [PropertyQuota](#PropertyQuota).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPropertyQuota")]
        public virtual System.Nullable<bool> ReturnPropertyQuota { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response pivot report table corresponding to a pivot request.</summary>
    public class RunPivotReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Aggregation of metric values. Can be totals, minimums, or maximums. The returned aggregations are controlled
        /// by the metric_aggregations in the pivot. The type of aggregation returned in each row is shown by the
        /// dimension_values which are set to "RESERVED_".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregates")]
        public virtual System.Collections.Generic.IList<Row> Aggregates { get; set; }

        /// <summary>
        /// Describes dimension columns. The number of DimensionHeaders and ordering of DimensionHeaders matches the
        /// dimensions present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionHeaders")]
        public virtual System.Collections.Generic.IList<DimensionHeader> DimensionHeaders { get; set; }

        /// <summary>
        /// Identifies what kind of resource this message is. This `kind` is always the fixed string
        /// "analyticsData#runPivotReport". Useful to distinguish between response types in JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata for the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetaData Metadata { get; set; }

        /// <summary>
        /// Describes metric columns. The number of MetricHeaders and ordering of MetricHeaders matches the metrics
        /// present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricHeaders")]
        public virtual System.Collections.Generic.IList<MetricHeader> MetricHeaders { get; set; }

        /// <summary>
        /// Summarizes the columns and rows created by a pivot. Each pivot in the request produces one header in the
        /// response. If we have a request like this: "pivots": [{ "fieldNames": ["country", "city"] }, { "fieldNames":
        /// "eventName" }] We will have the following `pivotHeaders` in the response: "pivotHeaders" : [{
        /// "dimensionHeaders": [{ "dimensionValues": [ { "value": "United Kingdom" }, { "value": "London" } ] }, {
        /// "dimensionValues": [ { "value": "Japan" }, { "value": "Osaka" } ] }] }, { "dimensionHeaders": [{
        /// "dimensionValues": [{ "value": "session_start" }] }, { "dimensionValues": [{ "value": "scroll" }] }] }]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivotHeaders")]
        public virtual System.Collections.Generic.IList<PivotHeader> PivotHeaders { get; set; }

        /// <summary>This Analytics Property's quota state including this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyQuota")]
        public virtual PropertyQuota PropertyQuota { get; set; }

        /// <summary>Rows of dimension value combinations and metric values in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to generate a realtime report.</summary>
    public class RunRealtimeReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The filter clause of dimensions. Dimensions must be requested to be used in this filter. Metrics cannot be
        /// used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilter")]
        public virtual FilterExpression DimensionFilter { get; set; }

        /// <summary>The dimensions requested and displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// The number of rows to return. If unspecified, 10,000 rows are returned. The API returns a maximum of 100,000
        /// rows per request, no matter how many you ask for. `limit` must be positive. The API can also return fewer
        /// rows than the requested `limit`, if there aren't as many dimension values as the `limit`. For instance,
        /// there are fewer than 300 possible values for the dimension `country`, so when reporting on only `country`,
        /// you can't get more than 300 rows, even if you set `limit` to a higher value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>
        /// Aggregation of metrics. Aggregated metric values will be shown in rows where the dimension_values are set to
        /// "RESERVED_(MetricAggregation)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricAggregations")]
        public virtual System.Collections.Generic.IList<string> MetricAggregations { get; set; }

        /// <summary>
        /// The filter clause of metrics. Applied at post aggregation phase, similar to SQL having-clause. Metrics must
        /// be requested to be used in this filter. Dimensions cannot be used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricFilter")]
        public virtual FilterExpression MetricFilter { get; set; }

        /// <summary>The metrics requested and displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<Metric> Metrics { get; set; }

        /// <summary>
        /// The minute ranges of event data to read. If unspecified, one minute range for the last 30 minutes will be
        /// used. If multiple minute ranges are requested, each response row will contain a zero based minute range
        /// index. If two minute ranges overlap, the event data for the overlapping minutes is included in the response
        /// rows for both minute ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minuteRanges")]
        public virtual System.Collections.Generic.IList<MinuteRange> MinuteRanges { get; set; }

        /// <summary>Specifies how rows are ordered in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBys")]
        public virtual System.Collections.Generic.IList<OrderBy> OrderBys { get; set; }

        /// <summary>
        /// Toggles whether to return the current state of this Analytics Property's Realtime quota. Quota is returned
        /// in [PropertyQuota](#PropertyQuota).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPropertyQuota")]
        public virtual System.Nullable<bool> ReturnPropertyQuota { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response realtime report table corresponding to a request.</summary>
    public class RunRealtimeReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describes dimension columns. The number of DimensionHeaders and ordering of DimensionHeaders matches the
        /// dimensions present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionHeaders")]
        public virtual System.Collections.Generic.IList<DimensionHeader> DimensionHeaders { get; set; }

        /// <summary>
        /// Identifies what kind of resource this message is. This `kind` is always the fixed string
        /// "analyticsData#runRealtimeReport". Useful to distinguish between response types in JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>If requested, the maximum values of metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximums")]
        public virtual System.Collections.Generic.IList<Row> Maximums { get; set; }

        /// <summary>
        /// Describes metric columns. The number of MetricHeaders and ordering of MetricHeaders matches the metrics
        /// present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricHeaders")]
        public virtual System.Collections.Generic.IList<MetricHeader> MetricHeaders { get; set; }

        /// <summary>If requested, the minimum values of metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimums")]
        public virtual System.Collections.Generic.IList<Row> Minimums { get; set; }

        /// <summary>This Analytics Property's Realtime quota state including this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyQuota")]
        public virtual PropertyQuota PropertyQuota { get; set; }

        /// <summary>
        /// The total number of rows in the query result. `rowCount` is independent of the number of rows returned in
        /// the response and the `limit` request parameter. For example if a query returns 175 rows and includes `limit`
        /// of 50 in the API request, the response will contain `rowCount` of 175 but only 50 rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>Rows of dimension value combinations and metric values in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>If requested, the totaled values of metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totals")]
        public virtual System.Collections.Generic.IList<Row> Totals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to generate a report.</summary>
    public class RunReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cohort group associated with this request. If there is a cohort group in the request the 'cohort' dimension
        /// must be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cohortSpec")]
        public virtual CohortSpec CohortSpec { get; set; }

        /// <summary>
        /// A currency code in ISO4217 format, such as "AED", "USD", "JPY". If the field is empty, the report uses the
        /// property's default currency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Date ranges of data to read. If multiple date ranges are requested, each response row will contain a zero
        /// based date range index. If two date ranges overlap, the event data for the overlapping days is included in
        /// the response rows for both date ranges. In a cohort request, this `dateRanges` must be unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual System.Collections.Generic.IList<DateRange> DateRanges { get; set; }

        /// <summary>
        /// The filter clause of dimensions. Dimensions must be requested to be used in this filter. Metrics cannot be
        /// used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilter")]
        public virtual FilterExpression DimensionFilter { get; set; }

        /// <summary>The dimensions requested and displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// If false or unspecified, each row with all metrics equal to 0 will not be returned. If true, these rows will
        /// be returned if they are not separately removed by a filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepEmptyRows")]
        public virtual System.Nullable<bool> KeepEmptyRows { get; set; }

        /// <summary>
        /// The number of rows to return. If unspecified, 10,000 rows are returned. The API returns a maximum of 100,000
        /// rows per request, no matter how many you ask for. `limit` must be positive. The API can also return fewer
        /// rows than the requested `limit`, if there aren't as many dimension values as the `limit`. For instance,
        /// there are fewer than 300 possible values for the dimension `country`, so when reporting on only `country`,
        /// you can't get more than 300 rows, even if you set `limit` to a higher value. To learn more about this
        /// pagination parameter, see
        /// [Pagination](https://developers.google.com/analytics/devguides/reporting/data/v1/basics#pagination).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual System.Nullable<long> Limit { get; set; }

        /// <summary>
        /// Aggregation of metrics. Aggregated metric values will be shown in rows where the dimension_values are set to
        /// "RESERVED_(MetricAggregation)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricAggregations")]
        public virtual System.Collections.Generic.IList<string> MetricAggregations { get; set; }

        /// <summary>
        /// The filter clause of metrics. Applied at post aggregation phase, similar to SQL having-clause. Metrics must
        /// be requested to be used in this filter. Dimensions cannot be used in this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricFilter")]
        public virtual FilterExpression MetricFilter { get; set; }

        /// <summary>The metrics requested and displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<Metric> Metrics { get; set; }

        /// <summary>
        /// The row count of the start row. The first row is counted as row 0. When paging, the first request does not
        /// specify offset; or equivalently, sets offset to 0; the first request returns the first `limit` of rows. The
        /// second request sets offset to the `limit` of the first request; the second request returns the second
        /// `limit` of rows. To learn more about this pagination parameter, see
        /// [Pagination](https://developers.google.com/analytics/devguides/reporting/data/v1/basics#pagination).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<long> Offset { get; set; }

        /// <summary>Specifies how rows are ordered in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBys")]
        public virtual System.Collections.Generic.IList<OrderBy> OrderBys { get; set; }

        /// <summary>
        /// A Google Analytics GA4 property identifier whose events are tracked. Specified in the URL path and not the
        /// body. To learn more, see [where to find your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id). Within a batch
        /// request, this property should either be unspecified or consistent with the batch-level property. Example:
        /// properties/1234
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual string Property { get; set; }

        /// <summary>
        /// Toggles whether to return the current state of this Analytics Property's quota. Quota is returned in
        /// [PropertyQuota](#PropertyQuota).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnPropertyQuota")]
        public virtual System.Nullable<bool> ReturnPropertyQuota { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response report table corresponding to a request.</summary>
    public class RunReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describes dimension columns. The number of DimensionHeaders and ordering of DimensionHeaders matches the
        /// dimensions present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionHeaders")]
        public virtual System.Collections.Generic.IList<DimensionHeader> DimensionHeaders { get; set; }

        /// <summary>
        /// Identifies what kind of resource this message is. This `kind` is always the fixed string
        /// "analyticsData#runReport". Useful to distinguish between response types in JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>If requested, the maximum values of metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximums")]
        public virtual System.Collections.Generic.IList<Row> Maximums { get; set; }

        /// <summary>Metadata for the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ResponseMetaData Metadata { get; set; }

        /// <summary>
        /// Describes metric columns. The number of MetricHeaders and ordering of MetricHeaders matches the metrics
        /// present in rows.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricHeaders")]
        public virtual System.Collections.Generic.IList<MetricHeader> MetricHeaders { get; set; }

        /// <summary>If requested, the minimum values of metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimums")]
        public virtual System.Collections.Generic.IList<Row> Minimums { get; set; }

        /// <summary>This Analytics Property's quota state including this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("propertyQuota")]
        public virtual PropertyQuota PropertyQuota { get; set; }

        /// <summary>
        /// The total number of rows in the query result. `rowCount` is independent of the number of rows returned in
        /// the response, the `limit` request parameter, and the `offset` request parameter. For example if a query
        /// returns 175 rows and includes `limit` of 50 in the API request, the response will contain `rowCount` of 175
        /// but only 50 rows. To learn more about this pagination parameter, see
        /// [Pagination](https://developers.google.com/analytics/devguides/reporting/data/v1/basics#pagination).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>Rows of dimension value combinations and metric values in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>If requested, the totaled values of metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totals")]
        public virtual System.Collections.Generic.IList<Row> Totals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The filter for string</summary>
    public class StringFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, the string value is case sensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
        public virtual System.Nullable<bool> CaseSensitive { get; set; }

        /// <summary>The match type for this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; }

        /// <summary>The string value used for the matching.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
