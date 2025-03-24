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

namespace Google.Apis.Monitoring.v3
{
    /// <summary>The Monitoring Service.</summary>
    public class MonitoringService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MonitoringService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MonitoringService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            Services = new ServicesResource(this);
            UptimeCheckIps = new UptimeCheckIpsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://monitoring.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://monitoring.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "monitoring";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Monitoring API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View and write monitoring data for all of your Google and third-party Cloud and API projects
            /// </summary>
            public static string Monitoring = "https://www.googleapis.com/auth/monitoring";

            /// <summary>View monitoring data for all of your Google Cloud and third-party projects</summary>
            public static string MonitoringRead = "https://www.googleapis.com/auth/monitoring.read";

            /// <summary>Publish metric data to your Google Cloud projects</summary>
            public static string MonitoringWrite = "https://www.googleapis.com/auth/monitoring.write";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Monitoring API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View and write monitoring data for all of your Google and third-party Cloud and API projects
            /// </summary>
            public const string Monitoring = "https://www.googleapis.com/auth/monitoring";

            /// <summary>View monitoring data for all of your Google Cloud and third-party projects</summary>
            public const string MonitoringRead = "https://www.googleapis.com/auth/monitoring.read";

            /// <summary>Publish metric data to your Google Cloud projects</summary>
            public const string MonitoringWrite = "https://www.googleapis.com/auth/monitoring.write";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }

        /// <summary>Gets the UptimeCheckIps resource.</summary>
        public virtual UptimeCheckIpsResource UptimeCheckIps { get; }
    }

    /// <summary>A base abstract class for Monitoring requests.</summary>
    public abstract class MonitoringBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MonitoringBaseServiceRequest instance.</summary>
        protected MonitoringBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Monitoring parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            TimeSeries = new TimeSeriesResource(service);
        }

        /// <summary>Gets the TimeSeries resource.</summary>
        public virtual TimeSeriesResource TimeSeries { get; }

        /// <summary>The "timeSeries" collection of methods.</summary>
        public class TimeSeriesResource
        {
            private const string Resource = "timeSeries";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TimeSeriesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists time series that match a filter.</summary>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name), organization or folder
            /// on which to execute the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// organizations/[ORGANIZATION_ID] folders/[FOLDER_ID]
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists time series that match a filter.</summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListTimeSeriesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name), organization or
                /// folder on which to execute the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// organizations/[ORGANIZATION_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The alignment_period specifies a time interval, in seconds, that is used to divide the data in all
                /// the time series into consistent blocks of time. This will be done before the per-series aligner can
                /// be applied to the data.The value must be at least 60 seconds. If a per-series aligner other than
                /// ALIGN_NONE is specified, this field is required or an error is returned. If no per-series aligner is
                /// specified, or the aligner ALIGN_NONE is specified, then this field is ignored.The maximum value of
                /// the alignment_period is 104 weeks (2 years) for charts, and 90,000 seconds (25 hours) for alerting
                /// policies.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.alignmentPeriod", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object AggregationAlignmentPeriod { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.crossSeriesReducer", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AggregationCrossSeriesReducerEnum> AggregationCrossSeriesReducer { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                public enum AggregationCrossSeriesReducerEnum
                {
                    /// <summary>No cross-time series reduction. The output of the Aligner is returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_NONE")]
                    REDUCENONE = 0,

                    /// <summary>
                    /// Reduce by computing the mean value across time series for each alignment period. This reducer is
                    /// valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type of the
                    /// output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MEAN")]
                    REDUCEMEAN = 1,

                    /// <summary>
                    /// Reduce by computing the minimum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MIN")]
                    REDUCEMIN = 2,

                    /// <summary>
                    /// Reduce by computing the maximum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MAX")]
                    REDUCEMAX = 3,

                    /// <summary>
                    /// Reduce by computing the sum across time series for each alignment period. This reducer is valid
                    /// for DELTA and GAUGE metrics with numeric and distribution values. The value_type of the output
                    /// is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_SUM")]
                    REDUCESUM = 4,

                    /// <summary>
                    /// Reduce by computing the standard deviation across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type
                    /// of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_STDDEV")]
                    REDUCESTDDEV = 5,

                    /// <summary>
                    /// Reduce by computing the number of data points across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics of numeric, Boolean, distribution, and string
                    /// value_type. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT")]
                    REDUCECOUNT = 6,

                    /// <summary>
                    /// Reduce by computing the number of True-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_TRUE")]
                    REDUCECOUNTTRUE = 7,

                    /// <summary>
                    /// Reduce by computing the number of False-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_FALSE")]
                    REDUCECOUNTFALSE = 8,

                    /// <summary>
                    /// Reduce by computing the ratio of the number of True-valued data points to the total number of
                    /// data points for each alignment period. This reducer is valid for DELTA and GAUGE metrics of
                    /// Boolean value_type. The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_FRACTION_TRUE")]
                    REDUCEFRACTIONTRUE = 9,

                    /// <summary>
                    /// Reduce by computing the 99th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_99")]
                    REDUCEPERCENTILE99 = 10,

                    /// <summary>
                    /// Reduce by computing the 95th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_95")]
                    REDUCEPERCENTILE95 = 11,

                    /// <summary>
                    /// Reduce by computing the 50th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_50")]
                    REDUCEPERCENTILE50 = 12,

                    /// <summary>
                    /// Reduce by computing the 5th percentile (https://en.wikipedia.org/wiki/Percentile) of data points
                    /// across time series for each alignment period. This reducer is valid for GAUGE and DELTA metrics
                    /// of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_05")]
                    REDUCEPERCENTILE05 = 13,
                }

                /// <summary>
                /// The set of fields to preserve when cross_series_reducer is specified. The group_by_fields determine
                /// how the time series are partitioned into subsets prior to applying the aggregation operation. Each
                /// subset contains time series that have the same value for each of the grouping fields. Each
                /// individual time series is a member of exactly one subset. The cross_series_reducer is applied to
                /// each subset of time series. It is not possible to reduce across different resource types, so this
                /// field implicitly contains resource.type. Fields not specified in group_by_fields are aggregated
                /// away. If group_by_fields is not specified and all the time series have the same resource type, then
                /// the time series are aggregated into a single output time series. If cross_series_reducer is not
                /// defined, this field is ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.groupByFields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> AggregationGroupByFields { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.perSeriesAligner", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AggregationPerSeriesAlignerEnum> AggregationPerSeriesAligner { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                public enum AggregationPerSeriesAlignerEnum
                {
                    /// <summary>
                    /// No alignment. Raw data is returned. Not valid if cross-series reduction is requested. The
                    /// value_type of the result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NONE")]
                    ALIGNNONE = 0,

                    /// <summary>
                    /// Align and convert to DELTA. The output is delta = y1 - y0.This alignment is valid for CUMULATIVE
                    /// and DELTA metrics. If the selected alignment period results in periods with no data, then the
                    /// aligned value for such a period is created by interpolation. The value_type of the aligned
                    /// result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_DELTA")]
                    ALIGNDELTA = 1,

                    /// <summary>
                    /// Align and convert to a rate. The result is computed as rate = (y1 - y0)/(t1 - t0), or "delta
                    /// over time". Think of this aligner as providing the slope of the line that passes through the
                    /// value at the start and at the end of the alignment_period.This aligner is valid for CUMULATIVE
                    /// and DELTA metrics with numeric values. If the selected alignment period results in periods with
                    /// no data, then the aligned value for such a period is created by interpolation. The output is a
                    /// GAUGE metric with value_type DOUBLE.If, by "rate", you mean "percentage change", see the
                    /// ALIGN_PERCENT_CHANGE aligner instead.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_RATE")]
                    ALIGNRATE = 2,

                    /// <summary>
                    /// Align by interpolating between adjacent points around the alignment period boundary. This
                    /// aligner is valid for GAUGE metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_INTERPOLATE")]
                    ALIGNINTERPOLATE = 3,

                    /// <summary>
                    /// Align by moving the most recent data point before the end of the alignment period to the
                    /// boundary at the end of the alignment period. This aligner is valid for GAUGE metrics. The
                    /// value_type of the aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NEXT_OLDER")]
                    ALIGNNEXTOLDER = 4,

                    /// <summary>
                    /// Align the time series by returning the minimum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MIN")]
                    ALIGNMIN = 5,

                    /// <summary>
                    /// Align the time series by returning the maximum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MAX")]
                    ALIGNMAX = 6,

                    /// <summary>
                    /// Align the time series by returning the mean value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MEAN")]
                    ALIGNMEAN = 7,

                    /// <summary>
                    /// Align the time series by returning the number of values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric or Boolean values. The value_type of the
                    /// aligned result is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT")]
                    ALIGNCOUNT = 8,

                    /// <summary>
                    /// Align the time series by returning the sum of the values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric and distribution values. The value_type of the
                    /// aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_SUM")]
                    ALIGNSUM = 9,

                    /// <summary>
                    /// Align the time series by returning the standard deviation of the values in each alignment
                    /// period. This aligner is valid for GAUGE and DELTA metrics with numeric values. The value_type of
                    /// the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_STDDEV")]
                    ALIGNSTDDEV = 10,

                    /// <summary>
                    /// Align the time series by returning the number of True values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_TRUE")]
                    ALIGNCOUNTTRUE = 11,

                    /// <summary>
                    /// Align the time series by returning the number of False values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_FALSE")]
                    ALIGNCOUNTFALSE = 12,

                    /// <summary>
                    /// Align the time series by returning the ratio of the number of True values to the total number of
                    /// values in each alignment period. This aligner is valid for GAUGE metrics with Boolean values.
                    /// The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_FRACTION_TRUE")]
                    ALIGNFRACTIONTRUE = 13,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 99th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_99")]
                    ALIGNPERCENTILE99 = 14,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 95th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_95")]
                    ALIGNPERCENTILE95 = 15,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 50th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_50")]
                    ALIGNPERCENTILE50 = 16,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 5th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_05")]
                    ALIGNPERCENTILE05 = 17,

                    /// <summary>
                    /// Align and convert to a percentage change. This aligner is valid for GAUGE and DELTA metrics with
                    /// numeric values. This alignment returns ((current - previous)/previous) * 100, where the value of
                    /// previous is determined based on the alignment_period.If the values of current and previous are
                    /// both 0, then the returned value is 0. If only previous is 0, the returned value is infinity.A
                    /// 10-minute moving mean is computed at each point of the alignment period prior to the above
                    /// calculation to smooth the metric and prevent false positives from very short-lived spikes. The
                    /// moving mean is only applicable for data whose values are &amp;gt;= 0. Any values &amp;lt; 0 are
                    /// treated as a missing datapoint, and are ignored. While DELTA metrics are accepted by this
                    /// alignment, special care should be taken that the values for the metric will always be positive.
                    /// The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENT_CHANGE")]
                    ALIGNPERCENTCHANGE = 18,
                }

                /// <summary>
                /// Required. A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) that specifies
                /// which time series should be returned. The filter must specify a single metric type, and can
                /// additionally specify metric labels and other information. For example: metric.type =
                /// "compute.googleapis.com/instance/cpu/usage_time" AND metric.labels.instance_name =
                /// "my-instance-name"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                private object _intervalEndTime;

                /// <summary>
                /// String representation of <see cref="IntervalEndTimeDateTimeOffset"/>, formatted for inclusion in the
                /// HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("interval.endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string IntervalEndTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="IntervalEndTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalEndTimeDateTimeOffset instead.")]
                public virtual object IntervalEndTime
                {
                    get => _intervalEndTime;
                    set
                    {
                        IntervalEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _intervalEndTime = value;
                    }
                }

                public virtual System.DateTimeOffset? IntervalEndTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalEndTimeRaw);
                    set
                    {
                        IntervalEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _intervalEndTime = value;
                    }
                }

                private object _intervalStartTime;

                /// <summary>
                /// String representation of <see cref="IntervalStartTimeDateTimeOffset"/>, formatted for inclusion in
                /// the HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("interval.startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string IntervalStartTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="IntervalStartTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalStartTimeDateTimeOffset instead.")]
                public virtual object IntervalStartTime
                {
                    get => _intervalStartTime;
                    set
                    {
                        IntervalStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _intervalStartTime = value;
                    }
                }

                public virtual System.DateTimeOffset? IntervalStartTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalStartTimeRaw);
                    set
                    {
                        IntervalStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _intervalStartTime = value;
                    }
                }

                /// <summary>
                /// Unsupported: must be left blank. The points in each time series are currently returned in reverse
                /// time order (most recent to oldest).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// A positive number that is the maximum number of results to return. If page_size is empty or more
                /// than 100,000 results, the effective page_size is 100,000 results. If view is set to FULL, this is
                /// the maximum number of Points returned. If view is set to HEADERS, this is the maximum number of
                /// TimeSeries returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If this field is not empty then it must contain the nextPageToken value returned by a previous call
                /// to this method. Using this field causes the method to return additional results from the previous
                /// method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The alignment_period specifies a time interval, in seconds, that is used to divide the data in all
                /// the time series into consistent blocks of time. This will be done before the per-series aligner can
                /// be applied to the data.The value must be at least 60 seconds. If a per-series aligner other than
                /// ALIGN_NONE is specified, this field is required or an error is returned. If no per-series aligner is
                /// specified, or the aligner ALIGN_NONE is specified, then this field is ignored.The maximum value of
                /// the alignment_period is 104 weeks (2 years) for charts, and 90,000 seconds (25 hours) for alerting
                /// policies.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.alignmentPeriod", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object SecondaryAggregationAlignmentPeriod { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.crossSeriesReducer", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SecondaryAggregationCrossSeriesReducerEnum> SecondaryAggregationCrossSeriesReducer { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                public enum SecondaryAggregationCrossSeriesReducerEnum
                {
                    /// <summary>No cross-time series reduction. The output of the Aligner is returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_NONE")]
                    REDUCENONE = 0,

                    /// <summary>
                    /// Reduce by computing the mean value across time series for each alignment period. This reducer is
                    /// valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type of the
                    /// output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MEAN")]
                    REDUCEMEAN = 1,

                    /// <summary>
                    /// Reduce by computing the minimum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MIN")]
                    REDUCEMIN = 2,

                    /// <summary>
                    /// Reduce by computing the maximum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MAX")]
                    REDUCEMAX = 3,

                    /// <summary>
                    /// Reduce by computing the sum across time series for each alignment period. This reducer is valid
                    /// for DELTA and GAUGE metrics with numeric and distribution values. The value_type of the output
                    /// is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_SUM")]
                    REDUCESUM = 4,

                    /// <summary>
                    /// Reduce by computing the standard deviation across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type
                    /// of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_STDDEV")]
                    REDUCESTDDEV = 5,

                    /// <summary>
                    /// Reduce by computing the number of data points across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics of numeric, Boolean, distribution, and string
                    /// value_type. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT")]
                    REDUCECOUNT = 6,

                    /// <summary>
                    /// Reduce by computing the number of True-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_TRUE")]
                    REDUCECOUNTTRUE = 7,

                    /// <summary>
                    /// Reduce by computing the number of False-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_FALSE")]
                    REDUCECOUNTFALSE = 8,

                    /// <summary>
                    /// Reduce by computing the ratio of the number of True-valued data points to the total number of
                    /// data points for each alignment period. This reducer is valid for DELTA and GAUGE metrics of
                    /// Boolean value_type. The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_FRACTION_TRUE")]
                    REDUCEFRACTIONTRUE = 9,

                    /// <summary>
                    /// Reduce by computing the 99th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_99")]
                    REDUCEPERCENTILE99 = 10,

                    /// <summary>
                    /// Reduce by computing the 95th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_95")]
                    REDUCEPERCENTILE95 = 11,

                    /// <summary>
                    /// Reduce by computing the 50th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_50")]
                    REDUCEPERCENTILE50 = 12,

                    /// <summary>
                    /// Reduce by computing the 5th percentile (https://en.wikipedia.org/wiki/Percentile) of data points
                    /// across time series for each alignment period. This reducer is valid for GAUGE and DELTA metrics
                    /// of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_05")]
                    REDUCEPERCENTILE05 = 13,
                }

                /// <summary>
                /// The set of fields to preserve when cross_series_reducer is specified. The group_by_fields determine
                /// how the time series are partitioned into subsets prior to applying the aggregation operation. Each
                /// subset contains time series that have the same value for each of the grouping fields. Each
                /// individual time series is a member of exactly one subset. The cross_series_reducer is applied to
                /// each subset of time series. It is not possible to reduce across different resource types, so this
                /// field implicitly contains resource.type. Fields not specified in group_by_fields are aggregated
                /// away. If group_by_fields is not specified and all the time series have the same resource type, then
                /// the time series are aggregated into a single output time series. If cross_series_reducer is not
                /// defined, this field is ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.groupByFields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> SecondaryAggregationGroupByFields { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.perSeriesAligner", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SecondaryAggregationPerSeriesAlignerEnum> SecondaryAggregationPerSeriesAligner { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                public enum SecondaryAggregationPerSeriesAlignerEnum
                {
                    /// <summary>
                    /// No alignment. Raw data is returned. Not valid if cross-series reduction is requested. The
                    /// value_type of the result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NONE")]
                    ALIGNNONE = 0,

                    /// <summary>
                    /// Align and convert to DELTA. The output is delta = y1 - y0.This alignment is valid for CUMULATIVE
                    /// and DELTA metrics. If the selected alignment period results in periods with no data, then the
                    /// aligned value for such a period is created by interpolation. The value_type of the aligned
                    /// result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_DELTA")]
                    ALIGNDELTA = 1,

                    /// <summary>
                    /// Align and convert to a rate. The result is computed as rate = (y1 - y0)/(t1 - t0), or "delta
                    /// over time". Think of this aligner as providing the slope of the line that passes through the
                    /// value at the start and at the end of the alignment_period.This aligner is valid for CUMULATIVE
                    /// and DELTA metrics with numeric values. If the selected alignment period results in periods with
                    /// no data, then the aligned value for such a period is created by interpolation. The output is a
                    /// GAUGE metric with value_type DOUBLE.If, by "rate", you mean "percentage change", see the
                    /// ALIGN_PERCENT_CHANGE aligner instead.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_RATE")]
                    ALIGNRATE = 2,

                    /// <summary>
                    /// Align by interpolating between adjacent points around the alignment period boundary. This
                    /// aligner is valid for GAUGE metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_INTERPOLATE")]
                    ALIGNINTERPOLATE = 3,

                    /// <summary>
                    /// Align by moving the most recent data point before the end of the alignment period to the
                    /// boundary at the end of the alignment period. This aligner is valid for GAUGE metrics. The
                    /// value_type of the aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NEXT_OLDER")]
                    ALIGNNEXTOLDER = 4,

                    /// <summary>
                    /// Align the time series by returning the minimum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MIN")]
                    ALIGNMIN = 5,

                    /// <summary>
                    /// Align the time series by returning the maximum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MAX")]
                    ALIGNMAX = 6,

                    /// <summary>
                    /// Align the time series by returning the mean value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MEAN")]
                    ALIGNMEAN = 7,

                    /// <summary>
                    /// Align the time series by returning the number of values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric or Boolean values. The value_type of the
                    /// aligned result is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT")]
                    ALIGNCOUNT = 8,

                    /// <summary>
                    /// Align the time series by returning the sum of the values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric and distribution values. The value_type of the
                    /// aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_SUM")]
                    ALIGNSUM = 9,

                    /// <summary>
                    /// Align the time series by returning the standard deviation of the values in each alignment
                    /// period. This aligner is valid for GAUGE and DELTA metrics with numeric values. The value_type of
                    /// the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_STDDEV")]
                    ALIGNSTDDEV = 10,

                    /// <summary>
                    /// Align the time series by returning the number of True values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_TRUE")]
                    ALIGNCOUNTTRUE = 11,

                    /// <summary>
                    /// Align the time series by returning the number of False values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_FALSE")]
                    ALIGNCOUNTFALSE = 12,

                    /// <summary>
                    /// Align the time series by returning the ratio of the number of True values to the total number of
                    /// values in each alignment period. This aligner is valid for GAUGE metrics with Boolean values.
                    /// The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_FRACTION_TRUE")]
                    ALIGNFRACTIONTRUE = 13,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 99th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_99")]
                    ALIGNPERCENTILE99 = 14,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 95th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_95")]
                    ALIGNPERCENTILE95 = 15,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 50th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_50")]
                    ALIGNPERCENTILE50 = 16,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 5th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_05")]
                    ALIGNPERCENTILE05 = 17,

                    /// <summary>
                    /// Align and convert to a percentage change. This aligner is valid for GAUGE and DELTA metrics with
                    /// numeric values. This alignment returns ((current - previous)/previous) * 100, where the value of
                    /// previous is determined based on the alignment_period.If the values of current and previous are
                    /// both 0, then the returned value is 0. If only previous is 0, the returned value is infinity.A
                    /// 10-minute moving mean is computed at each point of the alignment period prior to the above
                    /// calculation to smooth the metric and prevent false positives from very short-lived spikes. The
                    /// moving mean is only applicable for data whose values are &amp;gt;= 0. Any values &amp;lt; 0 are
                    /// treated as a missing datapoint, and are ignored. While DELTA metrics are accepted by this
                    /// alignment, special care should be taken that the values for the metric will always be positive.
                    /// The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENT_CHANGE")]
                    ALIGNPERCENTCHANGE = 18,
                }

                /// <summary>Required. Specifies which information is returned about the time series.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Required. Specifies which information is returned about the time series.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// Returns the identity of the metric(s), the time series, and the time series data.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 0,

                    /// <summary>
                    /// Returns the identity of the metric and the time series resource, but not the time series data.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("HEADERS")]
                    HEADERS = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/timeSeries";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+$",
                    });
                    RequestParameters.Add("aggregation.alignmentPeriod", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.alignmentPeriod",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.crossSeriesReducer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.crossSeriesReducer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.groupByFields", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.groupByFields",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.perSeriesAligner", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.perSeriesAligner",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("interval.endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "interval.endTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("interval.startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "interval.startTime",
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
                    RequestParameters.Add("secondaryAggregation.alignmentPeriod", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.alignmentPeriod",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.crossSeriesReducer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.crossSeriesReducer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.groupByFields", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.groupByFields",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.perSeriesAligner", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.perSeriesAligner",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            TimeSeries = new TimeSeriesResource(service);
        }

        /// <summary>Gets the TimeSeries resource.</summary>
        public virtual TimeSeriesResource TimeSeries { get; }

        /// <summary>The "timeSeries" collection of methods.</summary>
        public class TimeSeriesResource
        {
            private const string Resource = "timeSeries";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TimeSeriesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists time series that match a filter.</summary>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name), organization or folder
            /// on which to execute the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// organizations/[ORGANIZATION_ID] folders/[FOLDER_ID]
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists time series that match a filter.</summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListTimeSeriesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name), organization or
                /// folder on which to execute the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// organizations/[ORGANIZATION_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The alignment_period specifies a time interval, in seconds, that is used to divide the data in all
                /// the time series into consistent blocks of time. This will be done before the per-series aligner can
                /// be applied to the data.The value must be at least 60 seconds. If a per-series aligner other than
                /// ALIGN_NONE is specified, this field is required or an error is returned. If no per-series aligner is
                /// specified, or the aligner ALIGN_NONE is specified, then this field is ignored.The maximum value of
                /// the alignment_period is 104 weeks (2 years) for charts, and 90,000 seconds (25 hours) for alerting
                /// policies.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.alignmentPeriod", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object AggregationAlignmentPeriod { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.crossSeriesReducer", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AggregationCrossSeriesReducerEnum> AggregationCrossSeriesReducer { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                public enum AggregationCrossSeriesReducerEnum
                {
                    /// <summary>No cross-time series reduction. The output of the Aligner is returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_NONE")]
                    REDUCENONE = 0,

                    /// <summary>
                    /// Reduce by computing the mean value across time series for each alignment period. This reducer is
                    /// valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type of the
                    /// output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MEAN")]
                    REDUCEMEAN = 1,

                    /// <summary>
                    /// Reduce by computing the minimum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MIN")]
                    REDUCEMIN = 2,

                    /// <summary>
                    /// Reduce by computing the maximum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MAX")]
                    REDUCEMAX = 3,

                    /// <summary>
                    /// Reduce by computing the sum across time series for each alignment period. This reducer is valid
                    /// for DELTA and GAUGE metrics with numeric and distribution values. The value_type of the output
                    /// is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_SUM")]
                    REDUCESUM = 4,

                    /// <summary>
                    /// Reduce by computing the standard deviation across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type
                    /// of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_STDDEV")]
                    REDUCESTDDEV = 5,

                    /// <summary>
                    /// Reduce by computing the number of data points across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics of numeric, Boolean, distribution, and string
                    /// value_type. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT")]
                    REDUCECOUNT = 6,

                    /// <summary>
                    /// Reduce by computing the number of True-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_TRUE")]
                    REDUCECOUNTTRUE = 7,

                    /// <summary>
                    /// Reduce by computing the number of False-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_FALSE")]
                    REDUCECOUNTFALSE = 8,

                    /// <summary>
                    /// Reduce by computing the ratio of the number of True-valued data points to the total number of
                    /// data points for each alignment period. This reducer is valid for DELTA and GAUGE metrics of
                    /// Boolean value_type. The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_FRACTION_TRUE")]
                    REDUCEFRACTIONTRUE = 9,

                    /// <summary>
                    /// Reduce by computing the 99th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_99")]
                    REDUCEPERCENTILE99 = 10,

                    /// <summary>
                    /// Reduce by computing the 95th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_95")]
                    REDUCEPERCENTILE95 = 11,

                    /// <summary>
                    /// Reduce by computing the 50th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_50")]
                    REDUCEPERCENTILE50 = 12,

                    /// <summary>
                    /// Reduce by computing the 5th percentile (https://en.wikipedia.org/wiki/Percentile) of data points
                    /// across time series for each alignment period. This reducer is valid for GAUGE and DELTA metrics
                    /// of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_05")]
                    REDUCEPERCENTILE05 = 13,
                }

                /// <summary>
                /// The set of fields to preserve when cross_series_reducer is specified. The group_by_fields determine
                /// how the time series are partitioned into subsets prior to applying the aggregation operation. Each
                /// subset contains time series that have the same value for each of the grouping fields. Each
                /// individual time series is a member of exactly one subset. The cross_series_reducer is applied to
                /// each subset of time series. It is not possible to reduce across different resource types, so this
                /// field implicitly contains resource.type. Fields not specified in group_by_fields are aggregated
                /// away. If group_by_fields is not specified and all the time series have the same resource type, then
                /// the time series are aggregated into a single output time series. If cross_series_reducer is not
                /// defined, this field is ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.groupByFields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> AggregationGroupByFields { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.perSeriesAligner", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AggregationPerSeriesAlignerEnum> AggregationPerSeriesAligner { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                public enum AggregationPerSeriesAlignerEnum
                {
                    /// <summary>
                    /// No alignment. Raw data is returned. Not valid if cross-series reduction is requested. The
                    /// value_type of the result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NONE")]
                    ALIGNNONE = 0,

                    /// <summary>
                    /// Align and convert to DELTA. The output is delta = y1 - y0.This alignment is valid for CUMULATIVE
                    /// and DELTA metrics. If the selected alignment period results in periods with no data, then the
                    /// aligned value for such a period is created by interpolation. The value_type of the aligned
                    /// result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_DELTA")]
                    ALIGNDELTA = 1,

                    /// <summary>
                    /// Align and convert to a rate. The result is computed as rate = (y1 - y0)/(t1 - t0), or "delta
                    /// over time". Think of this aligner as providing the slope of the line that passes through the
                    /// value at the start and at the end of the alignment_period.This aligner is valid for CUMULATIVE
                    /// and DELTA metrics with numeric values. If the selected alignment period results in periods with
                    /// no data, then the aligned value for such a period is created by interpolation. The output is a
                    /// GAUGE metric with value_type DOUBLE.If, by "rate", you mean "percentage change", see the
                    /// ALIGN_PERCENT_CHANGE aligner instead.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_RATE")]
                    ALIGNRATE = 2,

                    /// <summary>
                    /// Align by interpolating between adjacent points around the alignment period boundary. This
                    /// aligner is valid for GAUGE metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_INTERPOLATE")]
                    ALIGNINTERPOLATE = 3,

                    /// <summary>
                    /// Align by moving the most recent data point before the end of the alignment period to the
                    /// boundary at the end of the alignment period. This aligner is valid for GAUGE metrics. The
                    /// value_type of the aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NEXT_OLDER")]
                    ALIGNNEXTOLDER = 4,

                    /// <summary>
                    /// Align the time series by returning the minimum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MIN")]
                    ALIGNMIN = 5,

                    /// <summary>
                    /// Align the time series by returning the maximum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MAX")]
                    ALIGNMAX = 6,

                    /// <summary>
                    /// Align the time series by returning the mean value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MEAN")]
                    ALIGNMEAN = 7,

                    /// <summary>
                    /// Align the time series by returning the number of values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric or Boolean values. The value_type of the
                    /// aligned result is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT")]
                    ALIGNCOUNT = 8,

                    /// <summary>
                    /// Align the time series by returning the sum of the values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric and distribution values. The value_type of the
                    /// aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_SUM")]
                    ALIGNSUM = 9,

                    /// <summary>
                    /// Align the time series by returning the standard deviation of the values in each alignment
                    /// period. This aligner is valid for GAUGE and DELTA metrics with numeric values. The value_type of
                    /// the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_STDDEV")]
                    ALIGNSTDDEV = 10,

                    /// <summary>
                    /// Align the time series by returning the number of True values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_TRUE")]
                    ALIGNCOUNTTRUE = 11,

                    /// <summary>
                    /// Align the time series by returning the number of False values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_FALSE")]
                    ALIGNCOUNTFALSE = 12,

                    /// <summary>
                    /// Align the time series by returning the ratio of the number of True values to the total number of
                    /// values in each alignment period. This aligner is valid for GAUGE metrics with Boolean values.
                    /// The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_FRACTION_TRUE")]
                    ALIGNFRACTIONTRUE = 13,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 99th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_99")]
                    ALIGNPERCENTILE99 = 14,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 95th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_95")]
                    ALIGNPERCENTILE95 = 15,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 50th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_50")]
                    ALIGNPERCENTILE50 = 16,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 5th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_05")]
                    ALIGNPERCENTILE05 = 17,

                    /// <summary>
                    /// Align and convert to a percentage change. This aligner is valid for GAUGE and DELTA metrics with
                    /// numeric values. This alignment returns ((current - previous)/previous) * 100, where the value of
                    /// previous is determined based on the alignment_period.If the values of current and previous are
                    /// both 0, then the returned value is 0. If only previous is 0, the returned value is infinity.A
                    /// 10-minute moving mean is computed at each point of the alignment period prior to the above
                    /// calculation to smooth the metric and prevent false positives from very short-lived spikes. The
                    /// moving mean is only applicable for data whose values are &amp;gt;= 0. Any values &amp;lt; 0 are
                    /// treated as a missing datapoint, and are ignored. While DELTA metrics are accepted by this
                    /// alignment, special care should be taken that the values for the metric will always be positive.
                    /// The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENT_CHANGE")]
                    ALIGNPERCENTCHANGE = 18,
                }

                /// <summary>
                /// Required. A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) that specifies
                /// which time series should be returned. The filter must specify a single metric type, and can
                /// additionally specify metric labels and other information. For example: metric.type =
                /// "compute.googleapis.com/instance/cpu/usage_time" AND metric.labels.instance_name =
                /// "my-instance-name"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                private object _intervalEndTime;

                /// <summary>
                /// String representation of <see cref="IntervalEndTimeDateTimeOffset"/>, formatted for inclusion in the
                /// HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("interval.endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string IntervalEndTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="IntervalEndTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalEndTimeDateTimeOffset instead.")]
                public virtual object IntervalEndTime
                {
                    get => _intervalEndTime;
                    set
                    {
                        IntervalEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _intervalEndTime = value;
                    }
                }

                public virtual System.DateTimeOffset? IntervalEndTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalEndTimeRaw);
                    set
                    {
                        IntervalEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _intervalEndTime = value;
                    }
                }

                private object _intervalStartTime;

                /// <summary>
                /// String representation of <see cref="IntervalStartTimeDateTimeOffset"/>, formatted for inclusion in
                /// the HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("interval.startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string IntervalStartTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="IntervalStartTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalStartTimeDateTimeOffset instead.")]
                public virtual object IntervalStartTime
                {
                    get => _intervalStartTime;
                    set
                    {
                        IntervalStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _intervalStartTime = value;
                    }
                }

                public virtual System.DateTimeOffset? IntervalStartTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalStartTimeRaw);
                    set
                    {
                        IntervalStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _intervalStartTime = value;
                    }
                }

                /// <summary>
                /// Unsupported: must be left blank. The points in each time series are currently returned in reverse
                /// time order (most recent to oldest).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// A positive number that is the maximum number of results to return. If page_size is empty or more
                /// than 100,000 results, the effective page_size is 100,000 results. If view is set to FULL, this is
                /// the maximum number of Points returned. If view is set to HEADERS, this is the maximum number of
                /// TimeSeries returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If this field is not empty then it must contain the nextPageToken value returned by a previous call
                /// to this method. Using this field causes the method to return additional results from the previous
                /// method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The alignment_period specifies a time interval, in seconds, that is used to divide the data in all
                /// the time series into consistent blocks of time. This will be done before the per-series aligner can
                /// be applied to the data.The value must be at least 60 seconds. If a per-series aligner other than
                /// ALIGN_NONE is specified, this field is required or an error is returned. If no per-series aligner is
                /// specified, or the aligner ALIGN_NONE is specified, then this field is ignored.The maximum value of
                /// the alignment_period is 104 weeks (2 years) for charts, and 90,000 seconds (25 hours) for alerting
                /// policies.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.alignmentPeriod", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object SecondaryAggregationAlignmentPeriod { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.crossSeriesReducer", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SecondaryAggregationCrossSeriesReducerEnum> SecondaryAggregationCrossSeriesReducer { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                public enum SecondaryAggregationCrossSeriesReducerEnum
                {
                    /// <summary>No cross-time series reduction. The output of the Aligner is returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_NONE")]
                    REDUCENONE = 0,

                    /// <summary>
                    /// Reduce by computing the mean value across time series for each alignment period. This reducer is
                    /// valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type of the
                    /// output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MEAN")]
                    REDUCEMEAN = 1,

                    /// <summary>
                    /// Reduce by computing the minimum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MIN")]
                    REDUCEMIN = 2,

                    /// <summary>
                    /// Reduce by computing the maximum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MAX")]
                    REDUCEMAX = 3,

                    /// <summary>
                    /// Reduce by computing the sum across time series for each alignment period. This reducer is valid
                    /// for DELTA and GAUGE metrics with numeric and distribution values. The value_type of the output
                    /// is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_SUM")]
                    REDUCESUM = 4,

                    /// <summary>
                    /// Reduce by computing the standard deviation across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type
                    /// of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_STDDEV")]
                    REDUCESTDDEV = 5,

                    /// <summary>
                    /// Reduce by computing the number of data points across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics of numeric, Boolean, distribution, and string
                    /// value_type. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT")]
                    REDUCECOUNT = 6,

                    /// <summary>
                    /// Reduce by computing the number of True-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_TRUE")]
                    REDUCECOUNTTRUE = 7,

                    /// <summary>
                    /// Reduce by computing the number of False-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_FALSE")]
                    REDUCECOUNTFALSE = 8,

                    /// <summary>
                    /// Reduce by computing the ratio of the number of True-valued data points to the total number of
                    /// data points for each alignment period. This reducer is valid for DELTA and GAUGE metrics of
                    /// Boolean value_type. The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_FRACTION_TRUE")]
                    REDUCEFRACTIONTRUE = 9,

                    /// <summary>
                    /// Reduce by computing the 99th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_99")]
                    REDUCEPERCENTILE99 = 10,

                    /// <summary>
                    /// Reduce by computing the 95th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_95")]
                    REDUCEPERCENTILE95 = 11,

                    /// <summary>
                    /// Reduce by computing the 50th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_50")]
                    REDUCEPERCENTILE50 = 12,

                    /// <summary>
                    /// Reduce by computing the 5th percentile (https://en.wikipedia.org/wiki/Percentile) of data points
                    /// across time series for each alignment period. This reducer is valid for GAUGE and DELTA metrics
                    /// of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_05")]
                    REDUCEPERCENTILE05 = 13,
                }

                /// <summary>
                /// The set of fields to preserve when cross_series_reducer is specified. The group_by_fields determine
                /// how the time series are partitioned into subsets prior to applying the aggregation operation. Each
                /// subset contains time series that have the same value for each of the grouping fields. Each
                /// individual time series is a member of exactly one subset. The cross_series_reducer is applied to
                /// each subset of time series. It is not possible to reduce across different resource types, so this
                /// field implicitly contains resource.type. Fields not specified in group_by_fields are aggregated
                /// away. If group_by_fields is not specified and all the time series have the same resource type, then
                /// the time series are aggregated into a single output time series. If cross_series_reducer is not
                /// defined, this field is ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.groupByFields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> SecondaryAggregationGroupByFields { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.perSeriesAligner", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SecondaryAggregationPerSeriesAlignerEnum> SecondaryAggregationPerSeriesAligner { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                public enum SecondaryAggregationPerSeriesAlignerEnum
                {
                    /// <summary>
                    /// No alignment. Raw data is returned. Not valid if cross-series reduction is requested. The
                    /// value_type of the result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NONE")]
                    ALIGNNONE = 0,

                    /// <summary>
                    /// Align and convert to DELTA. The output is delta = y1 - y0.This alignment is valid for CUMULATIVE
                    /// and DELTA metrics. If the selected alignment period results in periods with no data, then the
                    /// aligned value for such a period is created by interpolation. The value_type of the aligned
                    /// result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_DELTA")]
                    ALIGNDELTA = 1,

                    /// <summary>
                    /// Align and convert to a rate. The result is computed as rate = (y1 - y0)/(t1 - t0), or "delta
                    /// over time". Think of this aligner as providing the slope of the line that passes through the
                    /// value at the start and at the end of the alignment_period.This aligner is valid for CUMULATIVE
                    /// and DELTA metrics with numeric values. If the selected alignment period results in periods with
                    /// no data, then the aligned value for such a period is created by interpolation. The output is a
                    /// GAUGE metric with value_type DOUBLE.If, by "rate", you mean "percentage change", see the
                    /// ALIGN_PERCENT_CHANGE aligner instead.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_RATE")]
                    ALIGNRATE = 2,

                    /// <summary>
                    /// Align by interpolating between adjacent points around the alignment period boundary. This
                    /// aligner is valid for GAUGE metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_INTERPOLATE")]
                    ALIGNINTERPOLATE = 3,

                    /// <summary>
                    /// Align by moving the most recent data point before the end of the alignment period to the
                    /// boundary at the end of the alignment period. This aligner is valid for GAUGE metrics. The
                    /// value_type of the aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NEXT_OLDER")]
                    ALIGNNEXTOLDER = 4,

                    /// <summary>
                    /// Align the time series by returning the minimum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MIN")]
                    ALIGNMIN = 5,

                    /// <summary>
                    /// Align the time series by returning the maximum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MAX")]
                    ALIGNMAX = 6,

                    /// <summary>
                    /// Align the time series by returning the mean value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MEAN")]
                    ALIGNMEAN = 7,

                    /// <summary>
                    /// Align the time series by returning the number of values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric or Boolean values. The value_type of the
                    /// aligned result is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT")]
                    ALIGNCOUNT = 8,

                    /// <summary>
                    /// Align the time series by returning the sum of the values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric and distribution values. The value_type of the
                    /// aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_SUM")]
                    ALIGNSUM = 9,

                    /// <summary>
                    /// Align the time series by returning the standard deviation of the values in each alignment
                    /// period. This aligner is valid for GAUGE and DELTA metrics with numeric values. The value_type of
                    /// the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_STDDEV")]
                    ALIGNSTDDEV = 10,

                    /// <summary>
                    /// Align the time series by returning the number of True values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_TRUE")]
                    ALIGNCOUNTTRUE = 11,

                    /// <summary>
                    /// Align the time series by returning the number of False values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_FALSE")]
                    ALIGNCOUNTFALSE = 12,

                    /// <summary>
                    /// Align the time series by returning the ratio of the number of True values to the total number of
                    /// values in each alignment period. This aligner is valid for GAUGE metrics with Boolean values.
                    /// The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_FRACTION_TRUE")]
                    ALIGNFRACTIONTRUE = 13,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 99th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_99")]
                    ALIGNPERCENTILE99 = 14,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 95th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_95")]
                    ALIGNPERCENTILE95 = 15,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 50th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_50")]
                    ALIGNPERCENTILE50 = 16,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 5th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_05")]
                    ALIGNPERCENTILE05 = 17,

                    /// <summary>
                    /// Align and convert to a percentage change. This aligner is valid for GAUGE and DELTA metrics with
                    /// numeric values. This alignment returns ((current - previous)/previous) * 100, where the value of
                    /// previous is determined based on the alignment_period.If the values of current and previous are
                    /// both 0, then the returned value is 0. If only previous is 0, the returned value is infinity.A
                    /// 10-minute moving mean is computed at each point of the alignment period prior to the above
                    /// calculation to smooth the metric and prevent false positives from very short-lived spikes. The
                    /// moving mean is only applicable for data whose values are &amp;gt;= 0. Any values &amp;lt; 0 are
                    /// treated as a missing datapoint, and are ignored. While DELTA metrics are accepted by this
                    /// alignment, special care should be taken that the values for the metric will always be positive.
                    /// The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENT_CHANGE")]
                    ALIGNPERCENTCHANGE = 18,
                }

                /// <summary>Required. Specifies which information is returned about the time series.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Required. Specifies which information is returned about the time series.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// Returns the identity of the metric(s), the time series, and the time series data.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 0,

                    /// <summary>
                    /// Returns the identity of the metric and the time series resource, but not the time series data.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("HEADERS")]
                    HEADERS = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/timeSeries";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("aggregation.alignmentPeriod", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.alignmentPeriod",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.crossSeriesReducer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.crossSeriesReducer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.groupByFields", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.groupByFields",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.perSeriesAligner", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.perSeriesAligner",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("interval.endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "interval.endTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("interval.startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "interval.startTime",
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
                    RequestParameters.Add("secondaryAggregation.alignmentPeriod", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.alignmentPeriod",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.crossSeriesReducer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.crossSeriesReducer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.groupByFields", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.groupByFields",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.perSeriesAligner", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.perSeriesAligner",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            AlertPolicies = new AlertPoliciesResource(service);
            CollectdTimeSeries = new CollectdTimeSeriesResource(service);
            Groups = new GroupsResource(service);
            MetricDescriptors = new MetricDescriptorsResource(service);
            MonitoredResourceDescriptors = new MonitoredResourceDescriptorsResource(service);
            NotificationChannelDescriptors = new NotificationChannelDescriptorsResource(service);
            NotificationChannels = new NotificationChannelsResource(service);
            Snoozes = new SnoozesResource(service);
            TimeSeries = new TimeSeriesResource(service);
            UptimeCheckConfigs = new UptimeCheckConfigsResource(service);
        }

        /// <summary>Gets the AlertPolicies resource.</summary>
        public virtual AlertPoliciesResource AlertPolicies { get; }

        /// <summary>The "alertPolicies" collection of methods.</summary>
        public class AlertPoliciesResource
        {
            private const string Resource = "alertPolicies";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AlertPoliciesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new alerting policy.Design your application to single-thread API calls that modify the state
            /// of alerting policies in a single project. This includes calls to CreateAlertPolicy, DeleteAlertPolicy
            /// and UpdateAlertPolicy.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in which to create the
            /// alerting policy. The format is: projects/[PROJECT_ID_OR_NUMBER] Note that this field names the parent
            /// container in which the alerting policy will be written, not the name of the created policy. |name| must
            /// be a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will return. The alerting policy
            /// that is returned will have a name that contains a normalized representation of this name as a prefix but
            /// adds a suffix of the form /alertPolicies/[ALERT_POLICY_ID], identifying the policy in the container.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.AlertPolicy body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates a new alerting policy.Design your application to single-thread API calls that modify the state
            /// of alerting policies in a single project. This includes calls to CreateAlertPolicy, DeleteAlertPolicy
            /// and UpdateAlertPolicy.
            /// </summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.AlertPolicy>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.AlertPolicy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in which to create
                /// the alerting policy. The format is: projects/[PROJECT_ID_OR_NUMBER] Note that this field names the
                /// parent container in which the alerting policy will be written, not the name of the created policy.
                /// |name| must be a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will return. The
                /// alerting policy that is returned will have a name that contains a normalized representation of this
                /// name as a prefix but adds a suffix of the form /alertPolicies/[ALERT_POLICY_ID], identifying the
                /// policy in the container.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.AlertPolicy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/alertPolicies";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an alerting policy.Design your application to single-thread API calls that modify the state of
            /// alerting policies in a single project. This includes calls to CreateAlertPolicy, DeleteAlertPolicy and
            /// UpdateAlertPolicy.
            /// </summary>
            /// <param name="name">
            /// Required. The alerting policy to delete. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID] For more information, see AlertPolicy.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes an alerting policy.Design your application to single-thread API calls that modify the state of
            /// alerting policies in a single project. This includes calls to CreateAlertPolicy, DeleteAlertPolicy and
            /// UpdateAlertPolicy.
            /// </summary>
            public class DeleteRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The alerting policy to delete. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID] For more information, see
                /// AlertPolicy.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/alertPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a single alerting policy.</summary>
            /// <param name="name">
            /// Required. The alerting policy to retrieve. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a single alerting policy.</summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.AlertPolicy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The alerting policy to retrieve. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/alertPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the existing alerting policies for the workspace.</summary>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) whose alert policies are
            /// to be listed. The format is: projects/[PROJECT_ID_OR_NUMBER] Note that this field names the parent
            /// container in which the alerting policies to be listed are stored. To retrieve a single alerting policy
            /// by name, use the GetAlertPolicy operation, instead.
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists the existing alerting policies for the workspace.</summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListAlertPoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) whose alert policies
                /// are to be listed. The format is: projects/[PROJECT_ID_OR_NUMBER] Note that this field names the
                /// parent container in which the alerting policies to be listed are stored. To retrieve a single
                /// alerting policy by name, use the GetAlertPolicy operation, instead.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. If provided, this field specifies the criteria that must be met by alert policies to be
                /// included in the response.For more details, see sorting and filtering
                /// (https://cloud.google.com/monitoring/api/v3/sorting-and-filtering).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. A comma-separated list of fields by which to sort the result. Supports the same set of
                /// field references as the filter field. Entries can be prefixed with a minus sign to sort by the field
                /// in descending order.For more details, see sorting and filtering
                /// (https://cloud.google.com/monitoring/api/v3/sorting-and-filtering).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Optional. The maximum number of results to return in a single response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If this field is not empty then it must contain the nextPageToken value returned by a
                /// previous call to this method. Using this field causes the method to return more results from the
                /// previous method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/alertPolicies";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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
                }
            }

            /// <summary>
            /// Updates an alerting policy. You can either replace the entire policy with a new one or replace only
            /// certain fields in the current alerting policy by specifying the fields to be updated via updateMask.
            /// Returns the updated alerting policy.Design your application to single-thread API calls that modify the
            /// state of alerting policies in a single project. This includes calls to CreateAlertPolicy,
            /// DeleteAlertPolicy and UpdateAlertPolicy.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. Required if the policy exists. The resource name for this policy. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID] [ALERT_POLICY_ID] is assigned by Cloud
            /// Monitoring when the policy is created. When calling the alertPolicies.create method, do not include the
            /// name field in the alerting policy passed as part of the request.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Monitoring.v3.Data.AlertPolicy body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an alerting policy. You can either replace the entire policy with a new one or replace only
            /// certain fields in the current alerting policy by specifying the fields to be updated via updateMask.
            /// Returns the updated alerting policy.Design your application to single-thread API calls that modify the
            /// state of alerting policies in a single project. This includes calls to CreateAlertPolicy,
            /// DeleteAlertPolicy and UpdateAlertPolicy.
            /// </summary>
            public class PatchRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.AlertPolicy>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.AlertPolicy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. Required if the policy exists. The resource name for this policy. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID] [ALERT_POLICY_ID] is assigned by
                /// Cloud Monitoring when the policy is created. When calling the alertPolicies.create method, do not
                /// include the name field in the alerting policy passed as part of the request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. A list of alerting policy field names. If this field is not empty, each listed field in
                /// the existing alerting policy is set to the value of the corresponding field in the supplied policy
                /// (alert_policy), or to the field's default value if the field is not in the supplied alerting policy.
                /// Fields not listed retain their previous value.Examples of valid field masks include display_name,
                /// documentation, documentation.content, documentation.mime_type, user_labels, user_label.nameofkey,
                /// enabled, conditions, combiner, etc.If this field is empty, then the supplied alerting policy
                /// replaces the existing policy. It is the same as deleting the existing policy and adding the supplied
                /// policy, except for the following: The new policy will have the same [ALERT_POLICY_ID] as the former
                /// policy. This gives you continuity with the former policy in your notifications and incidents.
                /// Conditions in the new policy will keep their former [CONDITION_ID] if the supplied condition
                /// includes the name field with that [CONDITION_ID]. If the supplied condition omits the name field,
                /// then a new [CONDITION_ID] is created.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.AlertPolicy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/alertPolicies/[^/]+$",
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

        /// <summary>Gets the CollectdTimeSeries resource.</summary>
        public virtual CollectdTimeSeriesResource CollectdTimeSeries { get; }

        /// <summary>The "collectdTimeSeries" collection of methods.</summary>
        public class CollectdTimeSeriesResource
        {
            private const string Resource = "collectdTimeSeries";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CollectdTimeSeriesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Cloud Monitoring Agent only: Creates a new time series.This method is only for use by the Cloud
            /// Monitoring Agent. Use projects.timeSeries.create instead.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The project (https://cloud.google.com/monitoring/api/v3#project_name) in which to create the time
            /// series. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.CreateCollectdTimeSeriesRequest body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Cloud Monitoring Agent only: Creates a new time series.This method is only for use by the Cloud
            /// Monitoring Agent. Use projects.timeSeries.create instead.
            /// </summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.CreateCollectdTimeSeriesResponse>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.CreateCollectdTimeSeriesRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The project (https://cloud.google.com/monitoring/api/v3#project_name) in which to create the time
                /// series. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.CreateCollectdTimeSeriesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/collectdTimeSeries";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }

        /// <summary>The "groups" collection of methods.</summary>
        public class GroupsResource
        {
            private const string Resource = "groups";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GroupsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Members = new MembersResource(service);
            }

            /// <summary>Gets the Members resource.</summary>
            public virtual MembersResource Members { get; }

            /// <summary>The "members" collection of methods.</summary>
            public class MembersResource
            {
                private const string Resource = "members";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MembersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Lists the monitored resources that are members of a group.</summary>
                /// <param name="name">
                /// Required. The group whose members are listed. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
                /// </param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>Lists the monitored resources that are members of a group.</summary>
                public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListGroupMembersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The group whose members are listed. The format is:
                    /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// An optional list filter (https://cloud.google.com/monitoring/api/learn_more#filtering)
                    /// describing the members to be returned. The filter may reference the type, labels, and metadata
                    /// of monitored resources that comprise the group. For example, to return only resources
                    /// representing Compute Engine VM instances, use this filter: `resource.type = "gce_instance"`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    private object _intervalEndTime;

                    /// <summary>
                    /// String representation of <see cref="IntervalEndTimeDateTimeOffset"/>, formatted for inclusion in
                    /// the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalEndTimeRaw { get; private set; }

                    /// <summary><seealso cref="object"/> representation of <see cref="IntervalEndTimeRaw"/>.</summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalEndTimeDateTimeOffset instead.")]
                    public virtual object IntervalEndTime
                    {
                        get => _intervalEndTime;
                        set
                        {
                            IntervalEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _intervalEndTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? IntervalEndTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalEndTimeRaw);
                        set
                        {
                            IntervalEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _intervalEndTime = value;
                        }
                    }

                    private object _intervalStartTime;

                    /// <summary>
                    /// String representation of <see cref="IntervalStartTimeDateTimeOffset"/>, formatted for inclusion
                    /// in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalStartTimeRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="IntervalStartTimeRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalStartTimeDateTimeOffset instead.")]
                    public virtual object IntervalStartTime
                    {
                        get => _intervalStartTime;
                        set
                        {
                            IntervalStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _intervalStartTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? IntervalStartTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalStartTimeRaw);
                        set
                        {
                            IntervalStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _intervalStartTime = value;
                        }
                    }

                    /// <summary>A positive number that is the maximum number of results to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// If this field is not empty then it must contain the next_page_token value returned by a previous
                    /// call to this method. Using this field causes the method to return additional results from the
                    /// previous method call.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v3/{+name}/members";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/groups/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime",
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

            /// <summary>Creates a new group.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in which to create the
            /// group. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.Group body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>Creates a new group.</summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Group>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.Group body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in which to create
                /// the group. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>If true, validate this request but do not create the group.</summary>
                [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ValidateOnly { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.Group Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/groups";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "validateOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an existing group.</summary>
            /// <param name="name">
            /// Required. The group to delete. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes an existing group.</summary>
            public class DeleteRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The group to delete. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If this field is true, then the request means to delete a group with all its descendants. Otherwise,
                /// the request means to delete a group only when it has no descendants. The default value is false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("recursive", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Recursive { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                    RequestParameters.Add("recursive", new Google.Apis.Discovery.Parameter
                    {
                        Name = "recursive",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a single group.</summary>
            /// <param name="name">
            /// Required. The group to retrieve. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a single group.</summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Group>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The group to retrieve. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the existing groups.</summary>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) whose groups are to be
            /// listed. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists the existing groups.</summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListGroupsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) whose groups are to
                /// be listed. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// A group name. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID] Returns groups that
                /// are ancestors of the specified group. The groups are returned in order, starting with the immediate
                /// parent and ending with the most distant ancestor. If the specified group has no immediate parent,
                /// the results are empty.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ancestorsOfGroup", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AncestorsOfGroup { get; set; }

                /// <summary>
                /// A group name. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID] Returns groups whose
                /// parent_name field contains the group name. If no groups have this parent, the results are empty.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("childrenOfGroup", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ChildrenOfGroup { get; set; }

                /// <summary>
                /// A group name. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID] Returns the
                /// descendants of the specified group. This is a superset of the results returned by the
                /// children_of_group filter, and includes children-of-children, and so forth.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("descendantsOfGroup", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DescendantsOfGroup { get; set; }

                /// <summary>A positive number that is the maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If this field is not empty then it must contain the next_page_token value returned by a previous
                /// call to this method. Using this field causes the method to return additional results from the
                /// previous method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/groups";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("ancestorsOfGroup", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ancestorsOfGroup",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("childrenOfGroup", new Google.Apis.Discovery.Parameter
                    {
                        Name = "childrenOfGroup",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("descendantsOfGroup", new Google.Apis.Discovery.Parameter
                    {
                        Name = "descendantsOfGroup",
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

            /// <summary>Updates an existing group. You can change any group attributes except name.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The name of this group. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
            /// When creating a group, this field is ignored and a new name is created consisting of the project
            /// specified in the call to CreateGroup and a unique [GROUP_ID] that is generated automatically.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.Monitoring.v3.Data.Group body, string name)
            {
                return new UpdateRequest(this.service, body, name);
            }

            /// <summary>Updates an existing group. You can change any group attributes except name.</summary>
            public class UpdateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Group>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.Group body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The name of this group. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID] When creating a group, this field is ignored and a
                /// new name is created consisting of the project specified in the call to CreateGroup and a unique
                /// [GROUP_ID] that is generated automatically.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>If true, validate this request but do not update the existing group.</summary>
                [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ValidateOnly { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.Group Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/groups/[^/]+$",
                    });
                    RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "validateOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the MetricDescriptors resource.</summary>
        public virtual MetricDescriptorsResource MetricDescriptors { get; }

        /// <summary>The "metricDescriptors" collection of methods.</summary>
        public class MetricDescriptorsResource
        {
            private const string Resource = "metricDescriptors";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MetricDescriptorsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new metric descriptor. The creation is executed asynchronously. User-created metric
            /// descriptors define custom metrics (https://cloud.google.com/monitoring/custom-metrics). The metric
            /// descriptor is updated if it already exists, except that metric labels are never removed.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute the
            /// request. The format is: 4 projects/PROJECT_ID_OR_NUMBER
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.MetricDescriptor body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates a new metric descriptor. The creation is executed asynchronously. User-created metric
            /// descriptors define custom metrics (https://cloud.google.com/monitoring/custom-metrics). The metric
            /// descriptor is updated if it already exists, except that metric labels are never removed.
            /// </summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.MetricDescriptor>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.MetricDescriptor body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute
                /// the request. The format is: 4 projects/PROJECT_ID_OR_NUMBER
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.MetricDescriptor Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/metricDescriptors";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a metric descriptor. Only user-created custom metrics
            /// (https://cloud.google.com/monitoring/custom-metrics) can be deleted.
            /// </summary>
            /// <param name="name">
            /// Required. The metric descriptor on which to execute the request. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID] An example of [METRIC_ID] is:
            /// "custom.googleapis.com/my_test_metric".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a metric descriptor. Only user-created custom metrics
            /// (https://cloud.google.com/monitoring/custom-metrics) can be deleted.
            /// </summary>
            public class DeleteRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The metric descriptor on which to execute the request. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID] An example of [METRIC_ID] is:
                /// "custom.googleapis.com/my_test_metric".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/metricDescriptors/.*$",
                    });
                }
            }

            /// <summary>Gets a single metric descriptor.</summary>
            /// <param name="name">
            /// Required. The metric descriptor on which to execute the request. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID] An example value of [METRIC_ID] is
            /// "compute.googleapis.com/instance/disk/read_bytes_count".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a single metric descriptor.</summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.MetricDescriptor>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The metric descriptor on which to execute the request. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID] An example value of [METRIC_ID] is
                /// "compute.googleapis.com/instance/disk/read_bytes_count".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/metricDescriptors/.*$",
                    });
                }
            }

            /// <summary>Lists metric descriptors that match a filter.</summary>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute the
            /// request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists metric descriptors that match a filter.</summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListMetricDescriptorsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute
                /// the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. If true, only metrics and monitored resource types that have recent data (within roughly
                /// 25 hours) will be included in the response. - If a metric descriptor enumerates monitored resource
                /// types, only the monitored resource types for which the metric type has recent data will be included
                /// in the returned metric descriptor, and if none of them have recent data, the metric descriptor will
                /// not be returned. - If a metric descriptor does not enumerate the compatible monitored resource
                /// types, it will be returned only if the metric type has recent data for some monitored resource type.
                /// The returned descriptor will not enumerate any monitored resource types.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("activeOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ActiveOnly { get; set; }

                /// <summary>
                /// Optional. If this field is empty, all custom and system-defined metric descriptors are returned.
                /// Otherwise, the filter (https://cloud.google.com/monitoring/api/v3/filters) specifies which metric
                /// descriptors are to be returned. For example, the following filter matches all custom metrics
                /// (https://cloud.google.com/monitoring/custom-metrics): metric.type =
                /// starts_with("custom.googleapis.com/")
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. A positive number that is the maximum number of results to return. The default and maximum
                /// value is 10,000. If a page_size &amp;lt;= 0 or &amp;gt; 10,000 is submitted, will instead return a
                /// maximum of 10,000 results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If this field is not empty then it must contain the nextPageToken value returned by a
                /// previous call to this method. Using this field causes the method to return additional results from
                /// the previous method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/metricDescriptors";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("activeOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "activeOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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

        /// <summary>Gets the MonitoredResourceDescriptors resource.</summary>
        public virtual MonitoredResourceDescriptorsResource MonitoredResourceDescriptors { get; }

        /// <summary>The "monitoredResourceDescriptors" collection of methods.</summary>
        public class MonitoredResourceDescriptorsResource
        {
            private const string Resource = "monitoredResourceDescriptors";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MonitoredResourceDescriptorsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets a single monitored resource descriptor.</summary>
            /// <param name="name">
            /// Required. The monitored resource descriptor to get. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE] The [RESOURCE_TYPE] is a
            /// predefined type, such as cloudsql_database.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a single monitored resource descriptor.</summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.MonitoredResourceDescriptor>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The monitored resource descriptor to get. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE] The [RESOURCE_TYPE] is
                /// a predefined type, such as cloudsql_database.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/monitoredResourceDescriptors/.*$",
                    });
                }
            }

            /// <summary>Lists monitored resource descriptors that match a filter.</summary>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute the
            /// request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists monitored resource descriptors that match a filter.</summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListMonitoredResourceDescriptorsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute
                /// the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// An optional filter (https://cloud.google.com/monitoring/api/v3/filters) describing the descriptors
                /// to be returned. The filter can reference the descriptor's type and labels. For example, the
                /// following filter returns only Google Compute Engine descriptors that have an id label: resource.type
                /// = starts_with("gce_") AND resource.label:id
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>A positive number that is the maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If this field is not empty then it must contain the nextPageToken value returned by a previous call
                /// to this method. Using this field causes the method to return additional results from the previous
                /// method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/monitoredResourceDescriptors";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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

        /// <summary>Gets the NotificationChannelDescriptors resource.</summary>
        public virtual NotificationChannelDescriptorsResource NotificationChannelDescriptors { get; }

        /// <summary>The "notificationChannelDescriptors" collection of methods.</summary>
        public class NotificationChannelDescriptorsResource
        {
            private const string Resource = "notificationChannelDescriptors";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NotificationChannelDescriptorsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Gets a single channel descriptor. The descriptor indicates which fields are expected / permitted for a
            /// notification channel of the given type.
            /// </summary>
            /// <param name="name">
            /// Required. The channel type for which to execute the request. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Gets a single channel descriptor. The descriptor indicates which fields are expected / permitted for a
            /// notification channel of the given type.
            /// </summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.NotificationChannelDescriptor>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The channel type for which to execute the request. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/notificationChannelDescriptors/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the descriptors for supported channel types. The use of descriptors makes it possible for new
            /// channel types to be dynamically added.
            /// </summary>
            /// <param name="name">
            /// Required. The REST resource name of the parent from which to retrieve the notification channel
            /// descriptors. The expected syntax is: projects/[PROJECT_ID_OR_NUMBER] Note that this names
            /// (https://cloud.google.com/monitoring/api/v3#project_name) the parent container in which to look for the
            /// descriptors; to retrieve a single descriptor by name, use the GetNotificationChannelDescriptor
            /// operation, instead.
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists the descriptors for supported channel types. The use of descriptors makes it possible for new
            /// channel types to be dynamically added.
            /// </summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListNotificationChannelDescriptorsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The REST resource name of the parent from which to retrieve the notification channel
                /// descriptors. The expected syntax is: projects/[PROJECT_ID_OR_NUMBER] Note that this names
                /// (https://cloud.google.com/monitoring/api/v3#project_name) the parent container in which to look for
                /// the descriptors; to retrieve a single descriptor by name, use the GetNotificationChannelDescriptor
                /// operation, instead.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. If not set to a positive number, a
                /// reasonable value will be chosen by the service.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If non-empty, page_token must contain a value returned as the next_page_token in a previous response
                /// to request the next set of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/notificationChannelDescriptors";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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

        /// <summary>Gets the NotificationChannels resource.</summary>
        public virtual NotificationChannelsResource NotificationChannels { get; }

        /// <summary>The "notificationChannels" collection of methods.</summary>
        public class NotificationChannelsResource
        {
            private const string Resource = "notificationChannels";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NotificationChannelsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new notification channel, representing a single notification endpoint such as an email
            /// address, SMS number, or PagerDuty service.Design your application to single-thread API calls that modify
            /// the state of notification channels in a single project. This includes calls to
            /// CreateNotificationChannel, DeleteNotificationChannel and UpdateNotificationChannel.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute the
            /// request. The format is: projects/[PROJECT_ID_OR_NUMBER] This names the container into which the channel
            /// will be written, this does not name the newly created channel. The resulting channel's name will have a
            /// normalized version of this field as a prefix, but will add /notificationChannels/[CHANNEL_ID] to
            /// identify the channel.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.NotificationChannel body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates a new notification channel, representing a single notification endpoint such as an email
            /// address, SMS number, or PagerDuty service.Design your application to single-thread API calls that modify
            /// the state of notification channels in a single project. This includes calls to
            /// CreateNotificationChannel, DeleteNotificationChannel and UpdateNotificationChannel.
            /// </summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.NotificationChannel>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.NotificationChannel body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute
                /// the request. The format is: projects/[PROJECT_ID_OR_NUMBER] This names the container into which the
                /// channel will be written, this does not name the newly created channel. The resulting channel's name
                /// will have a normalized version of this field as a prefix, but will add
                /// /notificationChannels/[CHANNEL_ID] to identify the channel.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.NotificationChannel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/notificationChannels";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a notification channel.Design your application to single-thread API calls that modify the state
            /// of notification channels in a single project. This includes calls to CreateNotificationChannel,
            /// DeleteNotificationChannel and UpdateNotificationChannel.
            /// </summary>
            /// <param name="name">
            /// Required. The channel for which to execute the request. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a notification channel.Design your application to single-thread API calls that modify the state
            /// of notification channels in a single project. This includes calls to CreateNotificationChannel,
            /// DeleteNotificationChannel and UpdateNotificationChannel.
            /// </summary>
            public class DeleteRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The channel for which to execute the request. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// If true, the notification channel will be deleted regardless of its use in alert policies (the
                /// policies will be updated to remove the channel). If false, this operation will fail if the
                /// notification channel is referenced by existing alerting policies.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Force { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/notificationChannels/[^/]+$",
                    });
                    RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                    {
                        Name = "force",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Gets a single notification channel. The channel includes the relevant configuration details with which
            /// the channel was created. However, the response may truncate or omit passwords, API keys, or other
            /// private key matter and thus the response may not be 100% identical to the information that was supplied
            /// in the call to the create method.
            /// </summary>
            /// <param name="name">
            /// Required. The channel for which to execute the request. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>
            /// Gets a single notification channel. The channel includes the relevant configuration details with which
            /// the channel was created. However, the response may truncate or omit passwords, API keys, or other
            /// private key matter and thus the response may not be 100% identical to the information that was supplied
            /// in the call to the create method.
            /// </summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.NotificationChannel>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The channel for which to execute the request. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/notificationChannels/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Requests a verification code for an already verified channel that can then be used in a call to
            /// VerifyNotificationChannel() on a different channel with an equivalent identity in the same or in a
            /// different project. This makes it possible to copy a channel between projects without requiring manual
            /// reverification of the channel. If the channel is not in the verified state, this method will fail (in
            /// other words, this may only be used if the SendNotificationChannelVerificationCode and
            /// VerifyNotificationChannel paths have already been used to put the given channel into the verified
            /// state).There is no guarantee that the verification codes returned by this method will be of a similar
            /// structure or form as the ones that are delivered to the channel via
            /// SendNotificationChannelVerificationCode; while VerifyNotificationChannel() will recognize both the codes
            /// delivered via SendNotificationChannelVerificationCode() and returned from
            /// GetNotificationChannelVerificationCode(), it is typically the case that the verification codes delivered
            /// via SendNotificationChannelVerificationCode() will be shorter and also have a shorter expiration (e.g.
            /// codes such as "G-123456") whereas GetVerificationCode() will typically return a much longer, websafe
            /// base 64 encoded string that has a longer expiration time.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The notification channel for which a verification code is to be generated and retrieved. This
            /// must name a channel that is already verified; if the specified channel is not verified, the request will
            /// fail.
            /// </param>
            public virtual GetVerificationCodeRequest GetVerificationCode(Google.Apis.Monitoring.v3.Data.GetNotificationChannelVerificationCodeRequest body, string name)
            {
                return new GetVerificationCodeRequest(this.service, body, name);
            }

            /// <summary>
            /// Requests a verification code for an already verified channel that can then be used in a call to
            /// VerifyNotificationChannel() on a different channel with an equivalent identity in the same or in a
            /// different project. This makes it possible to copy a channel between projects without requiring manual
            /// reverification of the channel. If the channel is not in the verified state, this method will fail (in
            /// other words, this may only be used if the SendNotificationChannelVerificationCode and
            /// VerifyNotificationChannel paths have already been used to put the given channel into the verified
            /// state).There is no guarantee that the verification codes returned by this method will be of a similar
            /// structure or form as the ones that are delivered to the channel via
            /// SendNotificationChannelVerificationCode; while VerifyNotificationChannel() will recognize both the codes
            /// delivered via SendNotificationChannelVerificationCode() and returned from
            /// GetNotificationChannelVerificationCode(), it is typically the case that the verification codes delivered
            /// via SendNotificationChannelVerificationCode() will be shorter and also have a shorter expiration (e.g.
            /// codes such as "G-123456") whereas GetVerificationCode() will typically return a much longer, websafe
            /// base 64 encoded string that has a longer expiration time.
            /// </summary>
            public class GetVerificationCodeRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.GetNotificationChannelVerificationCodeResponse>
            {
                /// <summary>Constructs a new GetVerificationCode request.</summary>
                public GetVerificationCodeRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.GetNotificationChannelVerificationCodeRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The notification channel for which a verification code is to be generated and retrieved.
                /// This must name a channel that is already verified; if the specified channel is not verified, the
                /// request will fail.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.GetNotificationChannelVerificationCodeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getVerificationCode";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}:getVerificationCode";

                /// <summary>Initializes GetVerificationCode parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notificationChannels/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the notification channels that have been created for the project. To list the types of
            /// notification channels that are supported, use the ListNotificationChannelDescriptors method.
            /// </summary>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute the
            /// request. The format is: projects/[PROJECT_ID_OR_NUMBER] This names the container in which to look for
            /// the notification channels; it does not name a specific channel. To query a specific channel by REST
            /// resource name, use the GetNotificationChannel operation.
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>
            /// Lists the notification channels that have been created for the project. To list the types of
            /// notification channels that are supported, use the ListNotificationChannelDescriptors method.
            /// </summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListNotificationChannelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute
                /// the request. The format is: projects/[PROJECT_ID_OR_NUMBER] This names the container in which to
                /// look for the notification channels; it does not name a specific channel. To query a specific channel
                /// by REST resource name, use the GetNotificationChannel operation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. If provided, this field specifies the criteria that must be met by notification channels
                /// to be included in the response.For more details, see sorting and filtering
                /// (https://cloud.google.com/monitoring/api/v3/sorting-and-filtering).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. A comma-separated list of fields by which to sort the result. Supports the same set of
                /// fields as in filter. Entries can be prefixed with a minus sign to sort in descending rather than
                /// ascending order.For more details, see sorting and filtering
                /// (https://cloud.google.com/monitoring/api/v3/sorting-and-filtering).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Optional. The maximum number of results to return in a single response. If not set to a positive
                /// number, a reasonable value will be chosen by the service.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If non-empty, page_token must contain a value returned as the next_page_token in a
                /// previous response to request the next set of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/notificationChannels";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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
                }
            }

            /// <summary>
            /// Updates a notification channel. Fields not specified in the field mask remain unchanged.Design your
            /// application to single-thread API calls that modify the state of notification channels in a single
            /// project. This includes calls to CreateNotificationChannel, DeleteNotificationChannel and
            /// UpdateNotificationChannel.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The full REST resource name for this channel. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID] The [CHANNEL_ID] is automatically
            /// assigned by the server on creation.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Monitoring.v3.Data.NotificationChannel body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a notification channel. Fields not specified in the field mask remain unchanged.Design your
            /// application to single-thread API calls that modify the state of notification channels in a single
            /// project. This includes calls to CreateNotificationChannel, DeleteNotificationChannel and
            /// UpdateNotificationChannel.
            /// </summary>
            public class PatchRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.NotificationChannel>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.NotificationChannel body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The full REST resource name for this channel. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID] The [CHANNEL_ID] is automatically
                /// assigned by the server on creation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.NotificationChannel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/notificationChannels/[^/]+$",
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
            /// Causes a verification code to be delivered to the channel. The code can then be supplied in
            /// VerifyNotificationChannel to verify the channel.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The notification channel to which to send a verification code.</param>
            public virtual SendVerificationCodeRequest SendVerificationCode(Google.Apis.Monitoring.v3.Data.SendNotificationChannelVerificationCodeRequest body, string name)
            {
                return new SendVerificationCodeRequest(this.service, body, name);
            }

            /// <summary>
            /// Causes a verification code to be delivered to the channel. The code can then be supplied in
            /// VerifyNotificationChannel to verify the channel.
            /// </summary>
            public class SendVerificationCodeRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new SendVerificationCode request.</summary>
                public SendVerificationCodeRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.SendNotificationChannelVerificationCodeRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The notification channel to which to send a verification code.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.SendNotificationChannelVerificationCodeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "sendVerificationCode";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}:sendVerificationCode";

                /// <summary>Initializes SendVerificationCode parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notificationChannels/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Verifies a NotificationChannel by proving receipt of the code delivered to the channel as a result of
            /// calling SendNotificationChannelVerificationCode.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The notification channel to verify.</param>
            public virtual VerifyRequest Verify(Google.Apis.Monitoring.v3.Data.VerifyNotificationChannelRequest body, string name)
            {
                return new VerifyRequest(this.service, body, name);
            }

            /// <summary>
            /// Verifies a NotificationChannel by proving receipt of the code delivered to the channel as a result of
            /// calling SendNotificationChannelVerificationCode.
            /// </summary>
            public class VerifyRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.NotificationChannel>
            {
                /// <summary>Constructs a new Verify request.</summary>
                public VerifyRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.VerifyNotificationChannelRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The notification channel to verify.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.VerifyNotificationChannelRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "verify";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}:verify";

                /// <summary>Initializes Verify parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/notificationChannels/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Snoozes resource.</summary>
        public virtual SnoozesResource Snoozes { get; }

        /// <summary>The "snoozes" collection of methods.</summary>
        public class SnoozesResource
        {
            private const string Resource = "snoozes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SnoozesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a Snooze that will prevent alerts, which match the provided criteria, from being opened. The
            /// Snooze applies for a specific time interval.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in which a Snooze should
            /// be created. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.Snooze body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a Snooze that will prevent alerts, which match the provided criteria, from being opened. The
            /// Snooze applies for a specific time interval.
            /// </summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Snooze>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.Snooze body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in which a Snooze
                /// should be created. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.Snooze Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}/snoozes";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves a Snooze by name.</summary>
            /// <param name="name">
            /// Required. The ID of the Snooze to retrieve. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID]
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves a Snooze by name.</summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Snooze>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The ID of the Snooze to retrieve. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/snoozes/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the Snoozes associated with a project. Can optionally pass in filter, which specifies predicates
            /// to match Snoozes.
            /// </summary>
            /// <param name="parent">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) whose Snoozes should be
            /// listed. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the Snoozes associated with a project. Can optionally pass in filter, which specifies predicates
            /// to match Snoozes.
            /// </summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListSnoozesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) whose Snoozes should
                /// be listed. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Optional filter to restrict results to the given criteria. The following fields are
                /// supported. interval.start_time interval.end_timeFor example: interval.start_time &amp;gt;
                /// "2022-03-11T00:00:00-08:00" AND interval.end_time &amp;lt; "2022-03-12T00:00:00-08:00"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. The maximum number of results to return for a single query. The server may further
                /// constrain the maximum number of results returned in a single page. The value should be in the range
                /// 1, 1000. If the value given is outside this range, the server will decide the number of results to
                /// be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. The next_page_token from a previous call to ListSnoozesRequest to get the next page of
                /// results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}/snoozes";

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
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>
            /// Updates a Snooze, identified by its name, with the parameters in the given Snooze object.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Identifier. The name of the Snooze. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID] The ID of the Snooze will be generated by the
            /// system.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Monitoring.v3.Data.Snooze body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a Snooze, identified by its name, with the parameters in the given Snooze object.
            /// </summary>
            public class PatchRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Snooze>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.Snooze body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Identifier. The name of the Snooze. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID] The ID of the Snooze will be generated by the
                /// system.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. The fields to update.For each field listed in update_mask: If the Snooze object supplied
                /// in the UpdateSnoozeRequest has a value for that field, the value of the field in the existing Snooze
                /// will be set to the value of the field in the supplied Snooze. If the field does not have a value in
                /// the supplied Snooze, the field in the existing Snooze is set to its default value.Fields not listed
                /// retain their existing value.The following are the field names that are accepted in update_mask:
                /// display_name interval.start_time interval.end_timeThat said, the start time and end time of the
                /// Snooze determines which fields can legally be updated. Before attempting an update, users should
                /// consult the documentation for UpdateSnoozeRequest, which talks about which fields can be updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.Snooze Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/snoozes/[^/]+$",
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

        /// <summary>Gets the TimeSeries resource.</summary>
        public virtual TimeSeriesResource TimeSeries { get; }

        /// <summary>The "timeSeries" collection of methods.</summary>
        public class TimeSeriesResource
        {
            private const string Resource = "timeSeries";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TimeSeriesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates or adds data to one or more time series. The response is empty if all time series in the request
            /// were written. If any time series could not be written, a corresponding failure message is included in
            /// the error response. This method does not support resource locations constraint of an organization policy
            /// (https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute the
            /// request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.CreateTimeSeriesRequest body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates or adds data to one or more time series. The response is empty if all time series in the request
            /// were written. If any time series could not be written, a corresponding failure message is included in
            /// the error response. This method does not support resource locations constraint of an organization policy
            /// (https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
            /// </summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.CreateTimeSeriesRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute
                /// the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.CreateTimeSeriesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/timeSeries";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates or adds data to one or more service time series. A service time series is a time series for a
            /// metric from a Google Cloud service. The response is empty if all time series in the request were
            /// written. If any time series could not be written, a corresponding failure message is included in the
            /// error response. This endpoint rejects writes to user-defined metrics. This method is only for use by
            /// Google Cloud services. Use projects.timeSeries.create instead.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute the
            /// request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual CreateServiceRequest CreateService(Google.Apis.Monitoring.v3.Data.CreateTimeSeriesRequest body, string name)
            {
                return new CreateServiceRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates or adds data to one or more service time series. A service time series is a time series for a
            /// metric from a Google Cloud service. The response is empty if all time series in the request were
            /// written. If any time series could not be written, a corresponding failure message is included in the
            /// error response. This endpoint rejects writes to user-defined metrics. This method is only for use by
            /// Google Cloud services. Use projects.timeSeries.create instead.
            /// </summary>
            public class CreateServiceRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new CreateService request.</summary>
                public CreateServiceRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.CreateTimeSeriesRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute
                /// the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.CreateTimeSeriesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "createService";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/timeSeries:createService";

                /// <summary>Initializes CreateService parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Lists time series that match a filter.</summary>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name), organization or folder
            /// on which to execute the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// organizations/[ORGANIZATION_ID] folders/[FOLDER_ID]
            /// </param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists time series that match a filter.</summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListTimeSeriesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name), organization or
                /// folder on which to execute the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// organizations/[ORGANIZATION_ID] folders/[FOLDER_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The alignment_period specifies a time interval, in seconds, that is used to divide the data in all
                /// the time series into consistent blocks of time. This will be done before the per-series aligner can
                /// be applied to the data.The value must be at least 60 seconds. If a per-series aligner other than
                /// ALIGN_NONE is specified, this field is required or an error is returned. If no per-series aligner is
                /// specified, or the aligner ALIGN_NONE is specified, then this field is ignored.The maximum value of
                /// the alignment_period is 104 weeks (2 years) for charts, and 90,000 seconds (25 hours) for alerting
                /// policies.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.alignmentPeriod", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object AggregationAlignmentPeriod { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.crossSeriesReducer", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AggregationCrossSeriesReducerEnum> AggregationCrossSeriesReducer { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                public enum AggregationCrossSeriesReducerEnum
                {
                    /// <summary>No cross-time series reduction. The output of the Aligner is returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_NONE")]
                    REDUCENONE = 0,

                    /// <summary>
                    /// Reduce by computing the mean value across time series for each alignment period. This reducer is
                    /// valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type of the
                    /// output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MEAN")]
                    REDUCEMEAN = 1,

                    /// <summary>
                    /// Reduce by computing the minimum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MIN")]
                    REDUCEMIN = 2,

                    /// <summary>
                    /// Reduce by computing the maximum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MAX")]
                    REDUCEMAX = 3,

                    /// <summary>
                    /// Reduce by computing the sum across time series for each alignment period. This reducer is valid
                    /// for DELTA and GAUGE metrics with numeric and distribution values. The value_type of the output
                    /// is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_SUM")]
                    REDUCESUM = 4,

                    /// <summary>
                    /// Reduce by computing the standard deviation across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type
                    /// of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_STDDEV")]
                    REDUCESTDDEV = 5,

                    /// <summary>
                    /// Reduce by computing the number of data points across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics of numeric, Boolean, distribution, and string
                    /// value_type. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT")]
                    REDUCECOUNT = 6,

                    /// <summary>
                    /// Reduce by computing the number of True-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_TRUE")]
                    REDUCECOUNTTRUE = 7,

                    /// <summary>
                    /// Reduce by computing the number of False-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_FALSE")]
                    REDUCECOUNTFALSE = 8,

                    /// <summary>
                    /// Reduce by computing the ratio of the number of True-valued data points to the total number of
                    /// data points for each alignment period. This reducer is valid for DELTA and GAUGE metrics of
                    /// Boolean value_type. The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_FRACTION_TRUE")]
                    REDUCEFRACTIONTRUE = 9,

                    /// <summary>
                    /// Reduce by computing the 99th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_99")]
                    REDUCEPERCENTILE99 = 10,

                    /// <summary>
                    /// Reduce by computing the 95th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_95")]
                    REDUCEPERCENTILE95 = 11,

                    /// <summary>
                    /// Reduce by computing the 50th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_50")]
                    REDUCEPERCENTILE50 = 12,

                    /// <summary>
                    /// Reduce by computing the 5th percentile (https://en.wikipedia.org/wiki/Percentile) of data points
                    /// across time series for each alignment period. This reducer is valid for GAUGE and DELTA metrics
                    /// of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_05")]
                    REDUCEPERCENTILE05 = 13,
                }

                /// <summary>
                /// The set of fields to preserve when cross_series_reducer is specified. The group_by_fields determine
                /// how the time series are partitioned into subsets prior to applying the aggregation operation. Each
                /// subset contains time series that have the same value for each of the grouping fields. Each
                /// individual time series is a member of exactly one subset. The cross_series_reducer is applied to
                /// each subset of time series. It is not possible to reduce across different resource types, so this
                /// field implicitly contains resource.type. Fields not specified in group_by_fields are aggregated
                /// away. If group_by_fields is not specified and all the time series have the same resource type, then
                /// the time series are aggregated into a single output time series. If cross_series_reducer is not
                /// defined, this field is ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.groupByFields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> AggregationGroupByFields { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("aggregation.perSeriesAligner", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AggregationPerSeriesAlignerEnum> AggregationPerSeriesAligner { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                public enum AggregationPerSeriesAlignerEnum
                {
                    /// <summary>
                    /// No alignment. Raw data is returned. Not valid if cross-series reduction is requested. The
                    /// value_type of the result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NONE")]
                    ALIGNNONE = 0,

                    /// <summary>
                    /// Align and convert to DELTA. The output is delta = y1 - y0.This alignment is valid for CUMULATIVE
                    /// and DELTA metrics. If the selected alignment period results in periods with no data, then the
                    /// aligned value for such a period is created by interpolation. The value_type of the aligned
                    /// result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_DELTA")]
                    ALIGNDELTA = 1,

                    /// <summary>
                    /// Align and convert to a rate. The result is computed as rate = (y1 - y0)/(t1 - t0), or "delta
                    /// over time". Think of this aligner as providing the slope of the line that passes through the
                    /// value at the start and at the end of the alignment_period.This aligner is valid for CUMULATIVE
                    /// and DELTA metrics with numeric values. If the selected alignment period results in periods with
                    /// no data, then the aligned value for such a period is created by interpolation. The output is a
                    /// GAUGE metric with value_type DOUBLE.If, by "rate", you mean "percentage change", see the
                    /// ALIGN_PERCENT_CHANGE aligner instead.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_RATE")]
                    ALIGNRATE = 2,

                    /// <summary>
                    /// Align by interpolating between adjacent points around the alignment period boundary. This
                    /// aligner is valid for GAUGE metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_INTERPOLATE")]
                    ALIGNINTERPOLATE = 3,

                    /// <summary>
                    /// Align by moving the most recent data point before the end of the alignment period to the
                    /// boundary at the end of the alignment period. This aligner is valid for GAUGE metrics. The
                    /// value_type of the aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NEXT_OLDER")]
                    ALIGNNEXTOLDER = 4,

                    /// <summary>
                    /// Align the time series by returning the minimum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MIN")]
                    ALIGNMIN = 5,

                    /// <summary>
                    /// Align the time series by returning the maximum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MAX")]
                    ALIGNMAX = 6,

                    /// <summary>
                    /// Align the time series by returning the mean value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MEAN")]
                    ALIGNMEAN = 7,

                    /// <summary>
                    /// Align the time series by returning the number of values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric or Boolean values. The value_type of the
                    /// aligned result is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT")]
                    ALIGNCOUNT = 8,

                    /// <summary>
                    /// Align the time series by returning the sum of the values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric and distribution values. The value_type of the
                    /// aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_SUM")]
                    ALIGNSUM = 9,

                    /// <summary>
                    /// Align the time series by returning the standard deviation of the values in each alignment
                    /// period. This aligner is valid for GAUGE and DELTA metrics with numeric values. The value_type of
                    /// the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_STDDEV")]
                    ALIGNSTDDEV = 10,

                    /// <summary>
                    /// Align the time series by returning the number of True values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_TRUE")]
                    ALIGNCOUNTTRUE = 11,

                    /// <summary>
                    /// Align the time series by returning the number of False values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_FALSE")]
                    ALIGNCOUNTFALSE = 12,

                    /// <summary>
                    /// Align the time series by returning the ratio of the number of True values to the total number of
                    /// values in each alignment period. This aligner is valid for GAUGE metrics with Boolean values.
                    /// The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_FRACTION_TRUE")]
                    ALIGNFRACTIONTRUE = 13,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 99th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_99")]
                    ALIGNPERCENTILE99 = 14,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 95th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_95")]
                    ALIGNPERCENTILE95 = 15,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 50th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_50")]
                    ALIGNPERCENTILE50 = 16,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 5th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_05")]
                    ALIGNPERCENTILE05 = 17,

                    /// <summary>
                    /// Align and convert to a percentage change. This aligner is valid for GAUGE and DELTA metrics with
                    /// numeric values. This alignment returns ((current - previous)/previous) * 100, where the value of
                    /// previous is determined based on the alignment_period.If the values of current and previous are
                    /// both 0, then the returned value is 0. If only previous is 0, the returned value is infinity.A
                    /// 10-minute moving mean is computed at each point of the alignment period prior to the above
                    /// calculation to smooth the metric and prevent false positives from very short-lived spikes. The
                    /// moving mean is only applicable for data whose values are &amp;gt;= 0. Any values &amp;lt; 0 are
                    /// treated as a missing datapoint, and are ignored. While DELTA metrics are accepted by this
                    /// alignment, special care should be taken that the values for the metric will always be positive.
                    /// The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENT_CHANGE")]
                    ALIGNPERCENTCHANGE = 18,
                }

                /// <summary>
                /// Required. A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) that specifies
                /// which time series should be returned. The filter must specify a single metric type, and can
                /// additionally specify metric labels and other information. For example: metric.type =
                /// "compute.googleapis.com/instance/cpu/usage_time" AND metric.labels.instance_name =
                /// "my-instance-name"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                private object _intervalEndTime;

                /// <summary>
                /// String representation of <see cref="IntervalEndTimeDateTimeOffset"/>, formatted for inclusion in the
                /// HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("interval.endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string IntervalEndTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="IntervalEndTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalEndTimeDateTimeOffset instead.")]
                public virtual object IntervalEndTime
                {
                    get => _intervalEndTime;
                    set
                    {
                        IntervalEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _intervalEndTime = value;
                    }
                }

                public virtual System.DateTimeOffset? IntervalEndTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalEndTimeRaw);
                    set
                    {
                        IntervalEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _intervalEndTime = value;
                    }
                }

                private object _intervalStartTime;

                /// <summary>
                /// String representation of <see cref="IntervalStartTimeDateTimeOffset"/>, formatted for inclusion in
                /// the HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("interval.startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string IntervalStartTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="IntervalStartTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IntervalStartTimeDateTimeOffset instead.")]
                public virtual object IntervalStartTime
                {
                    get => _intervalStartTime;
                    set
                    {
                        IntervalStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _intervalStartTime = value;
                    }
                }

                public virtual System.DateTimeOffset? IntervalStartTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IntervalStartTimeRaw);
                    set
                    {
                        IntervalStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _intervalStartTime = value;
                    }
                }

                /// <summary>
                /// Unsupported: must be left blank. The points in each time series are currently returned in reverse
                /// time order (most recent to oldest).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// A positive number that is the maximum number of results to return. If page_size is empty or more
                /// than 100,000 results, the effective page_size is 100,000 results. If view is set to FULL, this is
                /// the maximum number of Points returned. If view is set to HEADERS, this is the maximum number of
                /// TimeSeries returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If this field is not empty then it must contain the nextPageToken value returned by a previous call
                /// to this method. Using this field causes the method to return additional results from the previous
                /// method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// The alignment_period specifies a time interval, in seconds, that is used to divide the data in all
                /// the time series into consistent blocks of time. This will be done before the per-series aligner can
                /// be applied to the data.The value must be at least 60 seconds. If a per-series aligner other than
                /// ALIGN_NONE is specified, this field is required or an error is returned. If no per-series aligner is
                /// specified, or the aligner ALIGN_NONE is specified, then this field is ignored.The maximum value of
                /// the alignment_period is 104 weeks (2 years) for charts, and 90,000 seconds (25 hours) for alerting
                /// policies.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.alignmentPeriod", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object SecondaryAggregationAlignmentPeriod { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.crossSeriesReducer", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SecondaryAggregationCrossSeriesReducerEnum> SecondaryAggregationCrossSeriesReducer { get; set; }

                /// <summary>
                /// The reduction operation to be used to combine time series into a single time series, where the value
                /// of each data point in the resulting series is a function of all the already aligned values in the
                /// input time series.Not all reducer operations can be applied to all time series. The valid choices
                /// depend on the metric_kind and the value_type of the original time series. Reduction can yield a time
                /// series with a different metric_kind or value_type than the input time series.Time series data must
                /// first be aligned (see per_series_aligner) in order to perform cross-time series reduction. If
                /// cross_series_reducer is specified, then per_series_aligner must be specified, and must not be
                /// ALIGN_NONE. An alignment_period must also be specified; otherwise, an error is returned.
                /// </summary>
                public enum SecondaryAggregationCrossSeriesReducerEnum
                {
                    /// <summary>No cross-time series reduction. The output of the Aligner is returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_NONE")]
                    REDUCENONE = 0,

                    /// <summary>
                    /// Reduce by computing the mean value across time series for each alignment period. This reducer is
                    /// valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type of the
                    /// output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MEAN")]
                    REDUCEMEAN = 1,

                    /// <summary>
                    /// Reduce by computing the minimum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MIN")]
                    REDUCEMIN = 2,

                    /// <summary>
                    /// Reduce by computing the maximum value across time series for each alignment period. This reducer
                    /// is valid for DELTA and GAUGE metrics with numeric values. The value_type of the output is the
                    /// same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_MAX")]
                    REDUCEMAX = 3,

                    /// <summary>
                    /// Reduce by computing the sum across time series for each alignment period. This reducer is valid
                    /// for DELTA and GAUGE metrics with numeric and distribution values. The value_type of the output
                    /// is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_SUM")]
                    REDUCESUM = 4,

                    /// <summary>
                    /// Reduce by computing the standard deviation across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics with numeric or distribution values. The value_type
                    /// of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_STDDEV")]
                    REDUCESTDDEV = 5,

                    /// <summary>
                    /// Reduce by computing the number of data points across time series for each alignment period. This
                    /// reducer is valid for DELTA and GAUGE metrics of numeric, Boolean, distribution, and string
                    /// value_type. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT")]
                    REDUCECOUNT = 6,

                    /// <summary>
                    /// Reduce by computing the number of True-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_TRUE")]
                    REDUCECOUNTTRUE = 7,

                    /// <summary>
                    /// Reduce by computing the number of False-valued data points across time series for each alignment
                    /// period. This reducer is valid for DELTA and GAUGE metrics of Boolean value_type. The value_type
                    /// of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_COUNT_FALSE")]
                    REDUCECOUNTFALSE = 8,

                    /// <summary>
                    /// Reduce by computing the ratio of the number of True-valued data points to the total number of
                    /// data points for each alignment period. This reducer is valid for DELTA and GAUGE metrics of
                    /// Boolean value_type. The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_FRACTION_TRUE")]
                    REDUCEFRACTIONTRUE = 9,

                    /// <summary>
                    /// Reduce by computing the 99th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_99")]
                    REDUCEPERCENTILE99 = 10,

                    /// <summary>
                    /// Reduce by computing the 95th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_95")]
                    REDUCEPERCENTILE95 = 11,

                    /// <summary>
                    /// Reduce by computing the 50th percentile (https://en.wikipedia.org/wiki/Percentile) of data
                    /// points across time series for each alignment period. This reducer is valid for GAUGE and DELTA
                    /// metrics of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_50")]
                    REDUCEPERCENTILE50 = 12,

                    /// <summary>
                    /// Reduce by computing the 5th percentile (https://en.wikipedia.org/wiki/Percentile) of data points
                    /// across time series for each alignment period. This reducer is valid for GAUGE and DELTA metrics
                    /// of numeric and distribution type. The value of the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("REDUCE_PERCENTILE_05")]
                    REDUCEPERCENTILE05 = 13,
                }

                /// <summary>
                /// The set of fields to preserve when cross_series_reducer is specified. The group_by_fields determine
                /// how the time series are partitioned into subsets prior to applying the aggregation operation. Each
                /// subset contains time series that have the same value for each of the grouping fields. Each
                /// individual time series is a member of exactly one subset. The cross_series_reducer is applied to
                /// each subset of time series. It is not possible to reduce across different resource types, so this
                /// field implicitly contains resource.type. Fields not specified in group_by_fields are aggregated
                /// away. If group_by_fields is not specified and all the time series have the same resource type, then
                /// the time series are aggregated into a single output time series. If cross_series_reducer is not
                /// defined, this field is ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.groupByFields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> SecondaryAggregationGroupByFields { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("secondaryAggregation.perSeriesAligner", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<SecondaryAggregationPerSeriesAlignerEnum> SecondaryAggregationPerSeriesAligner { get; set; }

                /// <summary>
                /// An Aligner describes how to bring the data points in a single time series into temporal alignment.
                /// Except for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be
                /// mathematically grouped together, resulting in a single data point for each alignment_period with end
                /// timestamp at the end of the period.Not all alignment operations may be applied to all time series.
                /// The valid choices depend on the metric_kind and value_type of the original time series. Alignment
                /// can change the metric_kind or the value_type of the time series.Time series data must be aligned in
                /// order to perform cross-time series reduction. If cross_series_reducer is specified, then
                /// per_series_aligner must be specified and not equal to ALIGN_NONE and alignment_period must be
                /// specified; otherwise, an error is returned.
                /// </summary>
                public enum SecondaryAggregationPerSeriesAlignerEnum
                {
                    /// <summary>
                    /// No alignment. Raw data is returned. Not valid if cross-series reduction is requested. The
                    /// value_type of the result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NONE")]
                    ALIGNNONE = 0,

                    /// <summary>
                    /// Align and convert to DELTA. The output is delta = y1 - y0.This alignment is valid for CUMULATIVE
                    /// and DELTA metrics. If the selected alignment period results in periods with no data, then the
                    /// aligned value for such a period is created by interpolation. The value_type of the aligned
                    /// result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_DELTA")]
                    ALIGNDELTA = 1,

                    /// <summary>
                    /// Align and convert to a rate. The result is computed as rate = (y1 - y0)/(t1 - t0), or "delta
                    /// over time". Think of this aligner as providing the slope of the line that passes through the
                    /// value at the start and at the end of the alignment_period.This aligner is valid for CUMULATIVE
                    /// and DELTA metrics with numeric values. If the selected alignment period results in periods with
                    /// no data, then the aligned value for such a period is created by interpolation. The output is a
                    /// GAUGE metric with value_type DOUBLE.If, by "rate", you mean "percentage change", see the
                    /// ALIGN_PERCENT_CHANGE aligner instead.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_RATE")]
                    ALIGNRATE = 2,

                    /// <summary>
                    /// Align by interpolating between adjacent points around the alignment period boundary. This
                    /// aligner is valid for GAUGE metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_INTERPOLATE")]
                    ALIGNINTERPOLATE = 3,

                    /// <summary>
                    /// Align by moving the most recent data point before the end of the alignment period to the
                    /// boundary at the end of the alignment period. This aligner is valid for GAUGE metrics. The
                    /// value_type of the aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_NEXT_OLDER")]
                    ALIGNNEXTOLDER = 4,

                    /// <summary>
                    /// Align the time series by returning the minimum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MIN")]
                    ALIGNMIN = 5,

                    /// <summary>
                    /// Align the time series by returning the maximum value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MAX")]
                    ALIGNMAX = 6,

                    /// <summary>
                    /// Align the time series by returning the mean value in each alignment period. This aligner is
                    /// valid for GAUGE and DELTA metrics with numeric values. The value_type of the aligned result is
                    /// DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_MEAN")]
                    ALIGNMEAN = 7,

                    /// <summary>
                    /// Align the time series by returning the number of values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric or Boolean values. The value_type of the
                    /// aligned result is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT")]
                    ALIGNCOUNT = 8,

                    /// <summary>
                    /// Align the time series by returning the sum of the values in each alignment period. This aligner
                    /// is valid for GAUGE and DELTA metrics with numeric and distribution values. The value_type of the
                    /// aligned result is the same as the value_type of the input.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_SUM")]
                    ALIGNSUM = 9,

                    /// <summary>
                    /// Align the time series by returning the standard deviation of the values in each alignment
                    /// period. This aligner is valid for GAUGE and DELTA metrics with numeric values. The value_type of
                    /// the output is DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_STDDEV")]
                    ALIGNSTDDEV = 10,

                    /// <summary>
                    /// Align the time series by returning the number of True values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_TRUE")]
                    ALIGNCOUNTTRUE = 11,

                    /// <summary>
                    /// Align the time series by returning the number of False values in each alignment period. This
                    /// aligner is valid for GAUGE metrics with Boolean values. The value_type of the output is INT64.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_COUNT_FALSE")]
                    ALIGNCOUNTFALSE = 12,

                    /// <summary>
                    /// Align the time series by returning the ratio of the number of True values to the total number of
                    /// values in each alignment period. This aligner is valid for GAUGE metrics with Boolean values.
                    /// The output value is in the range 0.0, 1.0 and has value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_FRACTION_TRUE")]
                    ALIGNFRACTIONTRUE = 13,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 99th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_99")]
                    ALIGNPERCENTILE99 = 14,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 95th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_95")]
                    ALIGNPERCENTILE95 = 15,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 50th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_50")]
                    ALIGNPERCENTILE50 = 16,

                    /// <summary>
                    /// Align the time series by using percentile aggregation
                    /// (https://en.wikipedia.org/wiki/Percentile). The resulting data point in each alignment period is
                    /// the 5th percentile of all data points in the period. This aligner is valid for GAUGE and DELTA
                    /// metrics with distribution values. The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENTILE_05")]
                    ALIGNPERCENTILE05 = 17,

                    /// <summary>
                    /// Align and convert to a percentage change. This aligner is valid for GAUGE and DELTA metrics with
                    /// numeric values. This alignment returns ((current - previous)/previous) * 100, where the value of
                    /// previous is determined based on the alignment_period.If the values of current and previous are
                    /// both 0, then the returned value is 0. If only previous is 0, the returned value is infinity.A
                    /// 10-minute moving mean is computed at each point of the alignment period prior to the above
                    /// calculation to smooth the metric and prevent false positives from very short-lived spikes. The
                    /// moving mean is only applicable for data whose values are &amp;gt;= 0. Any values &amp;lt; 0 are
                    /// treated as a missing datapoint, and are ignored. While DELTA metrics are accepted by this
                    /// alignment, special care should be taken that the values for the metric will always be positive.
                    /// The output is a GAUGE metric with value_type DOUBLE.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ALIGN_PERCENT_CHANGE")]
                    ALIGNPERCENTCHANGE = 18,
                }

                /// <summary>Required. Specifies which information is returned about the time series.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Required. Specifies which information is returned about the time series.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// Returns the identity of the metric(s), the time series, and the time series data.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 0,

                    /// <summary>
                    /// Returns the identity of the metric and the time series resource, but not the time series data.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("HEADERS")]
                    HEADERS = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/timeSeries";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("aggregation.alignmentPeriod", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.alignmentPeriod",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.crossSeriesReducer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.crossSeriesReducer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.groupByFields", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.groupByFields",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("aggregation.perSeriesAligner", new Google.Apis.Discovery.Parameter
                    {
                        Name = "aggregation.perSeriesAligner",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("interval.endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "interval.endTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("interval.startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "interval.startTime",
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
                    RequestParameters.Add("secondaryAggregation.alignmentPeriod", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.alignmentPeriod",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.crossSeriesReducer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.crossSeriesReducer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.groupByFields", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.groupByFields",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("secondaryAggregation.perSeriesAligner", new Google.Apis.Discovery.Parameter
                    {
                        Name = "secondaryAggregation.perSeriesAligner",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Queries time series by using Monitoring Query Language (MQL). We recommend using PromQL instead of MQL.
            /// For more information about the status of MQL, see the MQL deprecation notice
            /// (https://cloud.google.com/stackdriver/docs/deprecations/mql).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute the
            /// request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual QueryRequest Query(Google.Apis.Monitoring.v3.Data.QueryTimeSeriesRequest body, string name)
            {
                return new QueryRequest(this.service, body, name);
            }

            /// <summary>
            /// Queries time series by using Monitoring Query Language (MQL). We recommend using PromQL instead of MQL.
            /// For more information about the status of MQL, see the MQL deprecation notice
            /// (https://cloud.google.com/stackdriver/docs/deprecations/mql).
            /// </summary>
            public class QueryRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.QueryTimeSeriesResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.QueryTimeSeriesRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on which to execute
                /// the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.QueryTimeSeriesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}/timeSeries:query";

                /// <summary>Initializes Query parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the UptimeCheckConfigs resource.</summary>
        public virtual UptimeCheckConfigsResource UptimeCheckConfigs { get; }

        /// <summary>The "uptimeCheckConfigs" collection of methods.</summary>
        public class UptimeCheckConfigsResource
        {
            private const string Resource = "uptimeCheckConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UptimeCheckConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new Uptime check configuration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in which to create the
            /// Uptime check. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.UptimeCheckConfig body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a new Uptime check configuration.</summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.UptimeCheckConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.UptimeCheckConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in which to create
                /// the Uptime check. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.UptimeCheckConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}/uptimeCheckConfigs";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an Uptime check configuration. Note that this method will fail if the Uptime check configuration
            /// is referenced by an alert policy or other dependent configs that would be rendered invalid by the
            /// deletion.
            /// </summary>
            /// <param name="name">
            /// Required. The Uptime check configuration to delete. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes an Uptime check configuration. Note that this method will fail if the Uptime check configuration
            /// is referenced by an alert policy or other dependent configs that would be rendered invalid by the
            /// deletion.
            /// </summary>
            public class DeleteRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Uptime check configuration to delete. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/uptimeCheckConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a single Uptime check configuration.</summary>
            /// <param name="name">
            /// Required. The Uptime check configuration to retrieve. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a single Uptime check configuration.</summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.UptimeCheckConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Uptime check configuration to retrieve. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/uptimeCheckConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the existing valid Uptime check configurations for the project (leaving out any invalid
            /// configurations).
            /// </summary>
            /// <param name="parent">
            /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) whose Uptime check
            /// configurations are listed. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the existing valid Uptime check configurations for the project (leaving out any invalid
            /// configurations).
            /// </summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListUptimeCheckConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) whose Uptime check
                /// configurations are listed. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// If provided, this field specifies the criteria that must be met by uptime checks to be included in
                /// the response.For more details, see Filtering syntax
                /// (https://cloud.google.com/monitoring/api/v3/sorting-and-filtering#filter_syntax).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return in a single response. The server may further constrain the
                /// maximum number of results returned in a single page. If the page_size is &amp;lt;=0, the server will
                /// decide the number of results to be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If this field is not empty then it must contain the nextPageToken value returned by a previous call
                /// to this method. Using this field causes the method to return more results from the previous method
                /// call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}/uptimeCheckConfigs";

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
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>
            /// Updates an Uptime check configuration. You can either replace the entire configuration with a new one or
            /// replace only certain fields in the current configuration by specifying the fields to be updated via
            /// updateMask. Returns the updated configuration.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. A unique resource name for this Uptime check configuration. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID] [PROJECT_ID_OR_NUMBER] is the
            /// Workspace host project associated with the Uptime check.This field should be omitted when creating the
            /// Uptime check configuration; on create, the resource name is assigned by the server and included in the
            /// response.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Monitoring.v3.Data.UptimeCheckConfig body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an Uptime check configuration. You can either replace the entire configuration with a new one or
            /// replace only certain fields in the current configuration by specifying the fields to be updated via
            /// updateMask. Returns the updated configuration.
            /// </summary>
            public class PatchRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.UptimeCheckConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.UptimeCheckConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. A unique resource name for this Uptime check configuration. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID] [PROJECT_ID_OR_NUMBER] is the
                /// Workspace host project associated with the Uptime check.This field should be omitted when creating
                /// the Uptime check configuration; on create, the resource name is assigned by the server and included
                /// in the response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. If present, only the listed fields in the current Uptime check configuration are updated
                /// with values from the new configuration. If this field is empty, then the current configuration is
                /// completely replaced with the new configuration.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.UptimeCheckConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^projects/[^/]+/uptimeCheckConfigs/[^/]+$",
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

    /// <summary>The "services" collection of methods.</summary>
    public class ServicesResource
    {
        private const string Resource = "services";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ServicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            ServiceLevelObjectives = new ServiceLevelObjectivesResource(service);
        }

        /// <summary>Gets the ServiceLevelObjectives resource.</summary>
        public virtual ServiceLevelObjectivesResource ServiceLevelObjectives { get; }

        /// <summary>The "serviceLevelObjectives" collection of methods.</summary>
        public class ServiceLevelObjectivesResource
        {
            private const string Resource = "serviceLevelObjectives";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServiceLevelObjectivesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create a ServiceLevelObjective for the given Service.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the parent Service. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.ServiceLevelObjective body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Create a ServiceLevelObjective for the given Service.</summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ServiceLevelObjective>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.ServiceLevelObjective body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent Service. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The ServiceLevelObjective id to use for this ServiceLevelObjective. If omitted, an id will
                /// be generated instead. Must match the pattern ^[a-zA-Z0-9-_:.]+$
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceLevelObjectiveId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceLevelObjectiveId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.ServiceLevelObjective Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}/serviceLevelObjectives";

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
                        Pattern = @"^[^/]+/[^/]+/services/[^/]+$",
                    });
                    RequestParameters.Add("serviceLevelObjectiveId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceLevelObjectiveId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Delete the given ServiceLevelObjective.</summary>
            /// <param name="name">
            /// Required. Resource name of the ServiceLevelObjective to delete. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Delete the given ServiceLevelObjective.</summary>
            public class DeleteRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the ServiceLevelObjective to delete. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^[^/]+/[^/]+/services/[^/]+/serviceLevelObjectives/[^/]+$",
                    });
                }
            }

            /// <summary>Get a ServiceLevelObjective by name.</summary>
            /// <param name="name">
            /// Required. Resource name of the ServiceLevelObjective to get. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get a ServiceLevelObjective by name.</summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ServiceLevelObjective>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the ServiceLevelObjective to get. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// View of the ServiceLevelObjective to return. If DEFAULT, return the ServiceLevelObjective as
                /// originally defined. If EXPLICIT and the ServiceLevelObjective is defined in terms of a BasicSli,
                /// replace the BasicSli with a RequestBasedSli spelling out how the SLI is computed.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>
                /// View of the ServiceLevelObjective to return. If DEFAULT, return the ServiceLevelObjective as
                /// originally defined. If EXPLICIT and the ServiceLevelObjective is defined in terms of a BasicSli,
                /// replace the BasicSli with a RequestBasedSli spelling out how the SLI is computed.
                /// </summary>
                public enum ViewEnum
                {
                    /// <summary>Same as FULL.</summary>
                    [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                    VIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// Return the embedded ServiceLevelIndicator in the form in which it was defined. If it was defined
                    /// using a BasicSli, return that BasicSli.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 1,

                    /// <summary>
                    /// For ServiceLevelIndicators using BasicSli articulation, instead return the ServiceLevelIndicator
                    /// with its mode of computation fully spelled out as a RequestBasedSli. For ServiceLevelIndicators
                    /// using RequestBasedSli or WindowsBasedSli, return the ServiceLevelIndicator as it was provided.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("EXPLICIT")]
                    EXPLICIT__ = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^[^/]+/[^/]+/services/[^/]+/serviceLevelObjectives/[^/]+$",
                    });
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>List the ServiceLevelObjectives for the given Service.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent containing the listed SLOs, either a project or a Monitoring
            /// Metrics Scope. The formats are: projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
            /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]/services/-
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List the ServiceLevelObjectives for the given Service.</summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListServiceLevelObjectivesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent containing the listed SLOs, either a project or a Monitoring
                /// Metrics Scope. The formats are: projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
                /// workspaces/[HOST_PROJECT_ID_OR_NUMBER]/services/-
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>A filter specifying what ServiceLevelObjectives to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// A non-negative number that is the maximum number of results to return. When 0, use default page
                /// size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If this field is not empty then it must contain the nextPageToken value returned by a previous call
                /// to this method. Using this field causes the method to return additional results from the previous
                /// method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// View of the ServiceLevelObjectives to return. If DEFAULT, return each ServiceLevelObjective as
                /// originally defined. If EXPLICIT and the ServiceLevelObjective is defined in terms of a BasicSli,
                /// replace the BasicSli with a RequestBasedSli spelling out how the SLI is computed.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>
                /// View of the ServiceLevelObjectives to return. If DEFAULT, return each ServiceLevelObjective as
                /// originally defined. If EXPLICIT and the ServiceLevelObjective is defined in terms of a BasicSli,
                /// replace the BasicSli with a RequestBasedSli spelling out how the SLI is computed.
                /// </summary>
                public enum ViewEnum
                {
                    /// <summary>Same as FULL.</summary>
                    [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                    VIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// Return the embedded ServiceLevelIndicator in the form in which it was defined. If it was defined
                    /// using a BasicSli, return that BasicSli.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL = 1,

                    /// <summary>
                    /// For ServiceLevelIndicators using BasicSli articulation, instead return the ServiceLevelIndicator
                    /// with its mode of computation fully spelled out as a RequestBasedSli. For ServiceLevelIndicators
                    /// using RequestBasedSli or WindowsBasedSli, return the ServiceLevelIndicator as it was provided.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("EXPLICIT")]
                    EXPLICIT__ = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+parent}/serviceLevelObjectives";

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
                        Pattern = @"^[^/]+/[^/]+/services/[^/]+$",
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
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Update the given ServiceLevelObjective.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. Resource name for this ServiceLevelObjective. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Monitoring.v3.Data.ServiceLevelObjective body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Update the given ServiceLevelObjective.</summary>
            public class PatchRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ServiceLevelObjective>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.ServiceLevelObjective body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. Resource name for this ServiceLevelObjective. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>A set of field paths defining which fields to use for the update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v3.Data.ServiceLevelObjective Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v3/{+name}";

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
                        Pattern = @"^[^/]+/[^/]+/services/[^/]+/serviceLevelObjectives/[^/]+$",
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

        /// <summary>Create a Service.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Resource name (https://cloud.google.com/monitoring/api/v3#project_name) of the parent Metrics
        /// Scope. The format is: projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        public virtual CreateRequest Create(Google.Apis.Monitoring.v3.Data.Service body, string parent)
        {
            return new CreateRequest(this.service, body, parent);
        }

        /// <summary>Create a Service.</summary>
        public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Service>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.Service body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name (https://cloud.google.com/monitoring/api/v3#project_name) of the parent Metrics
            /// Scope. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Optional. The Service id to use for this Service. If omitted, an id will be generated instead. Must
            /// match the pattern [a-z0-9\-]+
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ServiceId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Monitoring.v3.Data.Service Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+parent}/services";

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
                RequestParameters.Add("serviceId", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Soft delete this Service.</summary>
        /// <param name="name">
        /// Required. Resource name of the Service to delete. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>Soft delete this Service.</summary>
        public class DeleteRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the Service to delete. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/services/[^/]+$",
                });
            }
        }

        /// <summary>Get the named Service.</summary>
        /// <param name="name">
        /// Required. Resource name of the Service. The format is: projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// 
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Get the named Service.</summary>
        public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Service>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the Service. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/services/[^/]+$",
                });
            }
        }

        /// <summary>List Services for this Metrics Scope.</summary>
        /// <param name="parent">
        /// Required. Resource name of the parent containing the listed services, either a project
        /// (https://cloud.google.com/monitoring/api/v3#project_name) or a Monitoring Metrics Scope. The formats are:
        /// projects/[PROJECT_ID_OR_NUMBER] workspaces/[HOST_PROJECT_ID_OR_NUMBER]
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(this.service, parent);
        }

        /// <summary>List Services for this Metrics Scope.</summary>
        public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListServicesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the parent containing the listed services, either a project
            /// (https://cloud.google.com/monitoring/api/v3#project_name) or a Monitoring Metrics Scope. The formats
            /// are: projects/[PROJECT_ID_OR_NUMBER] workspaces/[HOST_PROJECT_ID_OR_NUMBER]
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// A filter specifying what Services to return. The filter supports filtering on a particular
            /// service-identifier type or one of its attributes.To filter on a particular service-identifier type, the
            /// identifier_case refers to which option in the identifier field is populated. For example, the filter
            /// identifier_case = "CUSTOM" would match all services with a value for the custom field. Valid options
            /// include "CUSTOM", "APP_ENGINE", "MESH_ISTIO", and the other options listed at
            /// https://cloud.google.com/monitoring/api/ref_v3/rest/v3/services#ServiceTo filter on an attribute of a
            /// service-identifier type, apply the filter name by using the snake case of the service-identifier type
            /// and the attribute of that service-identifier type, and join the two with a period. For example, to
            /// filter by the meshUid field of the MeshIstio service-identifier type, you must filter on
            /// mesh_istio.mesh_uid = "123" to match all services with mesh UID "123". Service-identifier types and
            /// their attributes are described at
            /// https://cloud.google.com/monitoring/api/ref_v3/rest/v3/services#Service
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// A non-negative number that is the maximum number of results to return. When 0, use default page size.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// If this field is not empty then it must contain the nextPageToken value returned by a previous call to
            /// this method. Using this field causes the method to return additional results from the previous method
            /// call.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+parent}/services";

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
                    Pattern = @"^[^/]+/[^/]+$",
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

        /// <summary>Update this Service.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. Resource name for this Service. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Monitoring.v3.Data.Service body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>Update this Service.</summary>
        public class PatchRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.Service>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v3.Data.Service body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. Resource name for this Service. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>A set of field paths defining which fields to use for the update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Monitoring.v3.Data.Service Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/services/[^/]+$",
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

    /// <summary>The "uptimeCheckIps" collection of methods.</summary>
    public class UptimeCheckIpsResource
    {
        private const string Resource = "uptimeCheckIps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UptimeCheckIpsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns the list of IP addresses that checkers run from.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns the list of IP addresses that checkers run from.</summary>
        public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v3.Data.ListUptimeCheckIpsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of results to return in a single response. The server may further constrain the
            /// maximum number of results returned in a single page. If the page_size is &amp;lt;=0, the server will
            /// decide the number of results to be returned. NOTE: this field is not yet implemented
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// If this field is not empty then it must contain the nextPageToken value returned by a previous call to
            /// this method. Using this field causes the method to return more results from the previous method call.
            /// NOTE: this field is not yet implemented
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/uptimeCheckIps";

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
namespace Google.Apis.Monitoring.v3.Data
{
    /// <summary>
    /// Describes how to combine multiple time series to provide a different view of the data. Aggregation of time
    /// series is done in two steps. First, each time series in the set is aligned to the same time interval boundaries,
    /// then the set of time series is optionally reduced in number.Alignment consists of applying the
    /// per_series_aligner operation to each time series after its data has been divided into regular alignment_period
    /// time intervals. This process takes all of the data points in an alignment period, applies a mathematical
    /// transformation such as averaging, minimum, maximum, delta, etc., and converts them into a single data point per
    /// period.Reduction is when the aligned and transformed time series can optionally be combined, reducing the number
    /// of time series through similar mathematical transformations. Reduction involves applying a cross_series_reducer
    /// to all the time series, optionally sorting the time series into subsets with group_by_fields, and applying the
    /// reducer to each subset.The raw time series data can contain a huge amount of information from multiple sources.
    /// Alignment and reduction transforms this mass of data into a more manageable and representative collection of
    /// data, for example "the 95% latency across the average of all tasks in a cluster". This representative data can
    /// be more easily graphed and comprehended, and the individual time series data is still available for later
    /// drilldown. For more details, see Filtering and aggregation
    /// (https://cloud.google.com/monitoring/api/v3/aggregation).
    /// </summary>
    public class Aggregation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The alignment_period specifies a time interval, in seconds, that is used to divide the data in all the time
        /// series into consistent blocks of time. This will be done before the per-series aligner can be applied to the
        /// data.The value must be at least 60 seconds. If a per-series aligner other than ALIGN_NONE is specified, this
        /// field is required or an error is returned. If no per-series aligner is specified, or the aligner ALIGN_NONE
        /// is specified, then this field is ignored.The maximum value of the alignment_period is 104 weeks (2 years)
        /// for charts, and 90,000 seconds (25 hours) for alerting policies.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alignmentPeriod")]
        public virtual object AlignmentPeriod { get; set; }

        /// <summary>
        /// The reduction operation to be used to combine time series into a single time series, where the value of each
        /// data point in the resulting series is a function of all the already aligned values in the input time
        /// series.Not all reducer operations can be applied to all time series. The valid choices depend on the
        /// metric_kind and the value_type of the original time series. Reduction can yield a time series with a
        /// different metric_kind or value_type than the input time series.Time series data must first be aligned (see
        /// per_series_aligner) in order to perform cross-time series reduction. If cross_series_reducer is specified,
        /// then per_series_aligner must be specified, and must not be ALIGN_NONE. An alignment_period must also be
        /// specified; otherwise, an error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossSeriesReducer")]
        public virtual string CrossSeriesReducer { get; set; }

        /// <summary>
        /// The set of fields to preserve when cross_series_reducer is specified. The group_by_fields determine how the
        /// time series are partitioned into subsets prior to applying the aggregation operation. Each subset contains
        /// time series that have the same value for each of the grouping fields. Each individual time series is a
        /// member of exactly one subset. The cross_series_reducer is applied to each subset of time series. It is not
        /// possible to reduce across different resource types, so this field implicitly contains resource.type. Fields
        /// not specified in group_by_fields are aggregated away. If group_by_fields is not specified and all the time
        /// series have the same resource type, then the time series are aggregated into a single output time series. If
        /// cross_series_reducer is not defined, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupByFields")]
        public virtual System.Collections.Generic.IList<string> GroupByFields { get; set; }

        /// <summary>
        /// An Aligner describes how to bring the data points in a single time series into temporal alignment. Except
        /// for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be mathematically grouped
        /// together, resulting in a single data point for each alignment_period with end timestamp at the end of the
        /// period.Not all alignment operations may be applied to all time series. The valid choices depend on the
        /// metric_kind and value_type of the original time series. Alignment can change the metric_kind or the
        /// value_type of the time series.Time series data must be aligned in order to perform cross-time series
        /// reduction. If cross_series_reducer is specified, then per_series_aligner must be specified and not equal to
        /// ALIGN_NONE and alignment_period must be specified; otherwise, an error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perSeriesAligner")]
        public virtual string PerSeriesAligner { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A description of the conditions under which some aspect of your system is considered to be "unhealthy" and the
    /// ways to notify people or services about this state. For an overview of alerting policies, see Introduction to
    /// Alerting (https://cloud.google.com/monitoring/alerts/).
    /// </summary>
    public class AlertPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Control over how this alerting policy's notification channels are notified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertStrategy")]
        public virtual AlertStrategy AlertStrategy { get; set; }

        /// <summary>
        /// How to combine the results of multiple conditions to determine if an incident should be opened. If
        /// condition_time_series_query_language is present, this must be COMBINE_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combiner")]
        public virtual string Combiner { get; set; }

        /// <summary>
        /// A list of conditions for the policy. The conditions are combined by AND or OR according to the combiner
        /// field. If the combined conditions evaluate to true, then an incident is created. A policy can have from one
        /// to six conditions. If condition_time_series_query_language is present, it must be the only condition. If
        /// condition_monitoring_query_language is present, it must be the only condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<Condition> Conditions { get; set; }

        /// <summary>
        /// A read-only record of the creation of the alerting policy. If provided in a call to create or update, this
        /// field will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationRecord")]
        public virtual MutationRecord CreationRecord { get; set; }

        /// <summary>
        /// A short name or phrase used to identify the policy in dashboards, notifications, and incidents. To avoid
        /// confusion, don't use the same display name for multiple policies in the same project. The name is limited to
        /// 512 Unicode characters.The convention for the display_name of a PrometheusQueryLanguageCondition is "{rule
        /// group name}/{alert name}", where the {rule group name} and {alert name} should be taken from the
        /// corresponding Prometheus configuration file. This convention is not enforced. In any case the display_name
        /// is not a unique key of the AlertPolicy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Documentation that is included with notifications and incidents related to this policy. Best practice is for
        /// the documentation to include information to help responders understand, mitigate, escalate, and correct the
        /// underlying problems detected by the alerting policy. Notification channels that have limited capacity might
        /// not show this documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentation")]
        public virtual Documentation Documentation { get; set; }

        /// <summary>
        /// Whether or not the policy is enabled. On write, the default interpretation if unset is that the policy is
        /// enabled. On read, clients should not make any assumption about the state if it has not been populated. The
        /// field should always be populated on List and Get operations, unless a field projection has been specified
        /// that strips it out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// A read-only record of the most recent change to the alerting policy. If provided in a call to create or
        /// update, this field will be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationRecord")]
        public virtual MutationRecord MutationRecord { get; set; }

        /// <summary>
        /// Identifier. Required if the policy exists. The resource name for this policy. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID] [ALERT_POLICY_ID] is assigned by Cloud
        /// Monitoring when the policy is created. When calling the alertPolicies.create method, do not include the name
        /// field in the alerting policy passed as part of the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Identifies the notification channels to which notifications should be sent when incidents are opened or
        /// closed or when new violations occur on an already opened incident. Each element of this array corresponds to
        /// the name field in each of the NotificationChannel objects that are returned from the
        /// ListNotificationChannels method. The format of the entries in this field is:
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationChannels")]
        public virtual System.Collections.Generic.IList<string> NotificationChannels { get; set; }

        /// <summary>
        /// Optional. The severity of an alerting policy indicates how important incidents generated by that policy are.
        /// The severity level will be displayed on the Incident detail page and in notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// User-supplied key/value data to be used for organizing and identifying the AlertPolicy objects.The field can
        /// contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is
        /// smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must
        /// begin with a letter.Note that Prometheus {alert name} is a valid Prometheus label names
        /// (https://prometheus.io/docs/concepts/data_model/#metric-names-and-labels), whereas Prometheus {rule group}
        /// is an unrestricted UTF-8 string. This means that they cannot be stored as-is in user labels, because they
        /// may contain characters that are not allowed in user-label values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>
        /// Read-only description of how the alerting policy is invalid. This field is only set when the alerting policy
        /// is invalid. An invalid alerting policy will not generate incidents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validity")]
        public virtual Status Validity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Control over how the notification channels in notification_channels are notified when this alert fires.
    /// </summary>
    public class AlertStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If an alerting policy that was active has no data for this long, any open incidents will close
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoClose")]
        public virtual object AutoClose { get; set; }

        /// <summary>Control how notifications will be sent out, on a per-channel basis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationChannelStrategy")]
        public virtual System.Collections.Generic.IList<NotificationChannelStrategy> NotificationChannelStrategy { get; set; }

        /// <summary>
        /// For log-based alert policies, the notification prompts is always OPENED. For non log-based alert policies,
        /// the notification prompts can be OPENED or OPENED, CLOSED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationPrompts")]
        public virtual System.Collections.Generic.IList<string> NotificationPrompts { get; set; }

        /// <summary>
        /// Required for log-based alerting policies, i.e. policies with a LogMatch condition.This limit is not
        /// implemented for alerting policies that do not have a LogMatch condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationRateLimit")]
        public virtual NotificationRateLimit NotificationRateLimit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>App Engine service. Learn more at https://cloud.google.com/appengine.</summary>
    public class AppEngine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the App Engine module underlying this service. Corresponds to the module_id resource label in the
        /// gae_app monitored resource (https://cloud.google.com/monitoring/api/resources#tag_gae_app).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleId")]
        public virtual string ModuleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Future parameters for the availability SLI.</summary>
    public class AvailabilityCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The authentication parameters to provide to the specified resource or URL that requires a username and password.
    /// Currently, only Basic HTTP authentication (https://tools.ietf.org/html/rfc7617) is supported in Uptime checks.
    /// </summary>
    public class BasicAuthentication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The password to use when authenticating with the HTTP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; }

        /// <summary>The username to use when authenticating with the HTTP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A well-known service type, defined by its service type and service labels. Documentation and examples here
    /// (https://cloud.google.com/stackdriver/docs/solutions/slo-monitoring/api/api-structures#basic-svc-w-basic-sli).
    /// </summary>
    public class BasicService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Labels that specify the resource that emits the monitoring data which is used for SLO reporting of this
        /// Service. Documentation and valid values for given service types here
        /// (https://cloud.google.com/stackdriver/docs/solutions/slo-monitoring/api/api-structures#basic-svc-w-basic-sli).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> ServiceLabels { get; set; }

        /// <summary>
        /// The type of service that this basic service defines, e.g. APP_ENGINE service type. Documentation and valid
        /// values here
        /// (https://cloud.google.com/stackdriver/docs/solutions/slo-monitoring/api/api-structures#basic-svc-w-basic-sli).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceType")]
        public virtual string ServiceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An SLI measuring performance on a well-known service type. Performance will be computed on the basis of
    /// pre-defined metrics. The type of the service_resource determines the metrics to use and the
    /// service_resource.labels and metric_labels are used to construct a monitoring filter to filter that metric down
    /// to just the data relevant to this service.
    /// </summary>
    public class BasicSli : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Good service is defined to be the count of requests made to this service that return successfully.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual AvailabilityCriteria Availability { get; set; }

        /// <summary>
        /// Good service is defined to be the count of requests made to this service that are fast enough with respect
        /// to latency.threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency")]
        public virtual LatencyCriteria Latency { get; set; }

        /// <summary>
        /// OPTIONAL: The set of locations to which this SLI is relevant. Telemetry from other locations will not be
        /// used to calculate performance for this SLI. If omitted, this SLI applies to all locations in which the
        /// Service has activity. For service types that don't support breaking down by location, setting this field
        /// will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual System.Collections.Generic.IList<string> Location { get; set; }

        /// <summary>
        /// OPTIONAL: The set of RPCs to which this SLI is relevant. Telemetry from other methods will not be used to
        /// calculate performance for this SLI. If omitted, this SLI applies to all the Service's methods. For service
        /// types that don't support breaking down by method, setting this field will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual System.Collections.Generic.IList<string> Method { get; set; }

        /// <summary>
        /// OPTIONAL: The set of API versions to which this SLI is relevant. Telemetry from other API versions will not
        /// be used to calculate performance for this SLI. If omitted, this SLI applies to all API versions. For service
        /// types that don't support breaking down by version, setting this field will result in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Collections.Generic.IList<string> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A test that uses an alerting result in a boolean column produced by the SQL query.</summary>
    public class BooleanTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the column containing the boolean value. If the value in a row is NULL, that row is
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual string Column { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BucketOptions describes the bucket boundaries used to create a histogram for the distribution. The buckets can
    /// be in a linear sequence, an exponential sequence, or each bucket can be specified explicitly. BucketOptions does
    /// not include the number of values in each bucket.A bucket has an inclusive lower bound and exclusive upper bound
    /// for the values that are counted for that bucket. The upper bound of a bucket must be strictly greater than the
    /// lower bound. The sequence of N buckets for a distribution consists of an underflow bucket (number 0), zero or
    /// more finite buckets (number 1 through N - 2) and an overflow bucket (number N - 1). The buckets are contiguous:
    /// the lower bound of bucket i (i &amp;gt; 0) is the same as the upper bound of bucket i - 1. The buckets span the
    /// whole range of finite values: lower bound of the underflow bucket is -infinity and the upper bound of the
    /// overflow bucket is +infinity. The finite buckets are so-called because both bounds are finite.
    /// </summary>
    public class BucketOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The explicit buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitBuckets")]
        public virtual Explicit ExplicitBuckets { get; set; }

        /// <summary>The exponential buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exponentialBuckets")]
        public virtual Exponential ExponentialBuckets { get; set; }

        /// <summary>The linear bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linearBuckets")]
        public virtual Linear LinearBuckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Endpoints service. Learn more at https://cloud.google.com/endpoints.</summary>
    public class CloudEndpoints : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the Cloud Endpoints service underlying this service. Corresponds to the service resource label
        /// in the api monitored resource (https://cloud.google.com/monitoring/api/resources#tag_api).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Synthetic Monitor deployed to a Cloud Functions V2 instance.</summary>
    public class CloudFunctionV2Target : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The cloud_run_revision Monitored Resource associated with the GCFv2. The Synthetic Monitor
        /// execution results (metrics, logs, and spans) are reported against this Monitored Resource. This field is
        /// output only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRunRevision")]
        public virtual MonitoredResource CloudRunRevision { get; set; }

        /// <summary>
        /// Required. Fully qualified GCFv2 resource name i.e.
        /// projects/{project}/locations/{location}/functions/{function} Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Run service. Learn more at https://cloud.google.com/run.</summary>
    public class CloudRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location the service is run. Corresponds to the location resource label in the cloud_run_revision
        /// monitored resource (https://cloud.google.com/monitoring/api/resources#tag_cloud_run_revision).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The name of the Cloud Run service. Corresponds to the service_name resource label in the cloud_run_revision
        /// monitored resource (https://cloud.google.com/monitoring/api/resources#tag_cloud_run_revision).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Istio service scoped to a single Kubernetes cluster. Learn more at https://istio.io. Clusters running OSS Istio
    /// will have their services ingested as this type.
    /// </summary>
    public class ClusterIstio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the Kubernetes cluster in which this Istio service is defined. Corresponds to the cluster_name
        /// resource label in k8s_cluster resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>
        /// The location of the Kubernetes cluster in which this Istio service is defined. Corresponds to the location
        /// resource label in k8s_cluster resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The name of the Istio service underlying this service. Corresponds to the destination_service_name metric
        /// label in Istio metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// The namespace of the Istio service underlying this service. Corresponds to the destination_service_namespace
        /// metric label in Istio metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceNamespace")]
        public virtual string ServiceNamespace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of data points sent from a collectd-based plugin. See the collectd documentation for more
    /// information.
    /// </summary>
    public class CollectdPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The end time of the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The measurement metadata. Example: "process_id" -&gt; 12345</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, TypedValue> Metadata { get; set; }

        /// <summary>The name of the plugin. Example: "disk".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plugin")]
        public virtual string Plugin { get; set; }

        /// <summary>The instance name of the plugin Example: "hdcl".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pluginInstance")]
        public virtual string PluginInstance { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The start time of the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The measurement type. Example: "memory".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The measurement type instance. Example: "used".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeInstance")]
        public virtual string TypeInstance { get; set; }

        /// <summary>
        /// The measured values during this time interval. Each value must have a different data_source_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<CollectdValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the error status for payloads that were not written.</summary>
    public class CollectdPayloadError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Records the error status for the payload. If this field is present, the partial errors for nested values
        /// won't be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>The zero-based index in CreateCollectdTimeSeriesRequest.collectd_payloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// Records the error status for values that were not written due to an error.Failed payloads for which nothing
        /// is written will not include partial value errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueErrors")]
        public virtual System.Collections.Generic.IList<CollectdValueError> ValueErrors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single data point from a collectd-based plugin.</summary>
    public class CollectdValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The data source for the collectd value. For example, there are two data sources for network measurements:
        /// "rx" and "tx".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceName")]
        public virtual string DataSourceName { get; set; }

        /// <summary>The type of measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceType")]
        public virtual string DataSourceType { get; set; }

        /// <summary>The measurement value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual TypedValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the error status for values that were not written.</summary>
    public class CollectdValueError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Records the error status for the value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// The zero-based index in CollectdPayload.values within the parent
        /// CreateCollectdTimeSeriesRequest.collectd_payloads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition is a true/false test that determines when an alerting policy should open an incident. If a condition
    /// evaluates to true, it signifies that something is wrong.
    /// </summary>
    public class Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A condition that checks that a time series continues to receive new data points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionAbsent")]
        public virtual MetricAbsence ConditionAbsent { get; set; }

        /// <summary>
        /// A condition that checks for log messages matching given constraints. If set, no other conditions can be
        /// present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionMatchedLog")]
        public virtual LogMatch ConditionMatchedLog { get; set; }

        /// <summary>A condition that uses the Monitoring Query Language to define alerts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionMonitoringQueryLanguage")]
        public virtual MonitoringQueryLanguageCondition ConditionMonitoringQueryLanguage { get; set; }

        /// <summary>A condition that uses the Prometheus query language to define alerts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionPrometheusQueryLanguage")]
        public virtual PrometheusQueryLanguageCondition ConditionPrometheusQueryLanguage { get; set; }

        /// <summary>A condition that periodically evaluates a SQL query result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionSql")]
        public virtual SqlCondition ConditionSql { get; set; }

        /// <summary>A condition that compares a time series against a threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionThreshold")]
        public virtual MetricThreshold ConditionThreshold { get; set; }

        /// <summary>
        /// A short name or phrase used to identify the condition in dashboards, notifications, and incidents. To avoid
        /// confusion, don't use the same display name for multiple conditions in the same policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required if the condition exists. The unique resource name for this condition. Its format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[POLICY_ID]/conditions/[CONDITION_ID] [CONDITION_ID] is
        /// assigned by Cloud Monitoring when the condition is created as part of a new or updated alerting policy.When
        /// calling the alertPolicies.create method, do not include the name field in the conditions of the requested
        /// alerting policy. Cloud Monitoring creates the condition identifiers and includes them in the new policy.When
        /// calling the alertPolicies.update method to update a policy, including a condition name causes the existing
        /// condition to be updated. Conditions without names are added to the updated policy. Existing conditions are
        /// deleted if they are not updated.Best practice is to preserve [CONDITION_ID] if you make only small changes,
        /// such as those to condition thresholds, durations, or trigger values. Otherwise, treat the change as a new
        /// condition and let the existing condition be deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Optional. Used to perform content matching. This allows matching based on substrings and regular expressions,
    /// together with their negations. Only the first 4 MB of an HTTP or HTTPS check's response (and the first 1 MB of a
    /// TCP check's response) are examined for purposes of content matching.
    /// </summary>
    public class ContentMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// String, regex or JSON content to match. Maximum 1024 bytes. An empty content string indicates no content
        /// matching is to be performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Matcher information for MATCHES_JSON_PATH and NOT_MATCHES_JSON_PATH</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonPathMatcher")]
        public virtual JsonPathMatcher JsonPathMatcher { get; set; }

        /// <summary>
        /// The type of content matcher that will be applied to the server output, compared to the content string when
        /// the check is run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matcher")]
        public virtual string Matcher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The CreateCollectdTimeSeries request.</summary>
    public class CreateCollectdTimeSeriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The collectd payloads representing the time series data. You must not include more than a single point for
        /// each time series, so no two payloads can have the same values for all of the fields plugin, plugin_instance,
        /// type, and type_instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectdPayloads")]
        public virtual System.Collections.Generic.IList<CollectdPayload> CollectdPayloads { get; set; }

        /// <summary>The version of collectd that collected the data. Example: "5.3.0-192.el6".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectdVersion")]
        public virtual string CollectdVersion { get; set; }

        /// <summary>The monitored resource associated with the time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual MonitoredResource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The CreateCollectdTimeSeries response.</summary>
    public class CreateCollectdTimeSeriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Records the error status for points that were not written due to an error in the request.Failed requests for
        /// which nothing is written will return an error response instead. Requests where data points were rejected by
        /// the backend will set summary instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payloadErrors")]
        public virtual System.Collections.Generic.IList<CollectdPayloadError> PayloadErrors { get; set; }

        /// <summary>
        /// Aggregate statistics from writing the payloads. This field is omitted if all points were successfully
        /// written, so that the response is empty. This is for backwards compatibility with clients that log errors on
        /// any non-empty response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual CreateTimeSeriesSummary Summary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The CreateTimeSeries request.</summary>
    public class CreateTimeSeriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The new data to be added to a list of time series. Adds at most one data point to each of several
        /// time series. The new data point must be more recent than any other point in its time series. Each TimeSeries
        /// value must fully specify a unique time series by supplying all label values for the metric and the monitored
        /// resource.The maximum number of TimeSeries objects per Create request is 200.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeries")]
        public virtual System.Collections.Generic.IList<TimeSeries> TimeSeries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary of the result of a failed request to write data to a time series.</summary>
    public class CreateTimeSeriesSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of points that failed to be written. Order is not guaranteed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Error> Errors { get; set; }

        /// <summary>The number of points that were successfully written.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successPointCount")]
        public virtual System.Nullable<int> SuccessPointCount { get; set; }

        /// <summary>The number of points in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalPointCount")]
        public virtual System.Nullable<int> TotalPointCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Criteria specific to the AlertPolicys that this Snooze applies to. The Snooze will suppress alerts that come
    /// from one of the AlertPolicys whose names are supplied.
    /// </summary>
    public class Criteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The filter string to match on Alert fields when silencing the alerts. It follows the standard
        /// https://google.aip.dev/160 syntax. A filter string used to apply the snooze to specific incidents that have
        /// matching filter values. Filters can be defined for snoozes that apply to one alerting policy. Filters must
        /// be a string formatted as one or more resource labels with specific label values. If multiple resource labels
        /// are used, then they must be connected with an AND operator. For example, the following filter applies the
        /// snooze to incidents that have an instance ID of 1234567890 and a zone of us-central1-a:
        /// resource.labels.instance_id="1234567890" AND resource.labels.zone="us-central1-a"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The specific AlertPolicy names for the alert that should be snoozed. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[POLICY_ID] There is a limit of 16 policies per snooze. This
        /// limit is checked during snooze creation. Exactly 1 alert policy is required if filter is specified at the
        /// same time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<string> Policies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Use a custom service to designate a service that you want to monitor when none of the other service types (like
    /// App Engine, Cloud Run, or a GKE type) matches your intended service.
    /// </summary>
    public class Custom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used to schedule the query to run every so many days.</summary>
    public class Daily : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The time of day (in UTC) at which the query should run. If left unspecified, the server picks an
        /// arbitrary time of day and runs the query at the same time each day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionTime")]
        public virtual TimeOfDay ExecutionTime { get; set; }

        /// <summary>
        /// Required. The number of days between runs. Must be greater than or equal to 1 day and less than or equal to
        /// 31 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodicity")]
        public virtual System.Nullable<int> Periodicity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Distribution contains summary statistics for a population of values. It optionally contains a histogram
    /// representing the distribution of those values across a set of buckets.The summary statistics are the count,
    /// mean, sum of the squared deviation from the mean, the minimum, and the maximum of the set of population of
    /// values. The histogram is based on a sequence of buckets and gives a count of values that fall into each bucket.
    /// The boundaries of the buckets are given either explicitly or by formulas for buckets of fixed or exponentially
    /// increasing widths.Although it is not forbidden, it is generally a bad idea to include non-finite values
    /// (infinities or NaNs) in the population of values, as this will render the mean and sum_of_squared_deviation
    /// fields meaningless.
    /// </summary>
    public class Distribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required in the Cloud Monitoring API v3. The values for each bucket specified in bucket_options. The sum of
        /// the values in bucketCounts must equal the value in the count field of the Distribution object. The order of
        /// the bucket counts follows the numbering schemes described for the three bucket types. The underflow bucket
        /// has number 0; the finite buckets, if any, have numbers 1 through N-2; and the overflow bucket has number
        /// N-1. The size of bucket_counts must not be greater than N. If the size is less than N, then the remaining
        /// buckets are assigned values of zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketCounts")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> BucketCounts { get; set; }

        /// <summary>Required in the Cloud Monitoring API v3. Defines the histogram bucket boundaries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketOptions")]
        public virtual BucketOptions BucketOptions { get; set; }

        /// <summary>
        /// The number of values in the population. Must be non-negative. This value must equal the sum of the values in
        /// bucket_counts if a histogram is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Must be in increasing order of value field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemplars")]
        public virtual System.Collections.Generic.IList<Exemplar> Exemplars { get; set; }

        /// <summary>
        /// The arithmetic mean of the values in the population. If count is zero then this field must be zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mean")]
        public virtual System.Nullable<double> Mean { get; set; }

        /// <summary>
        /// If specified, contains the range of the population values. The field must not be present if the count is
        /// zero. This field is presently ignored by the Cloud Monitoring API v3.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Range Range { get; set; }

        /// <summary>
        /// The sum of squared deviations from the mean of the values in the population. For values x_i this is:
        /// Sum[i=1..n]((x_i - mean)^2) Knuth, "The Art of Computer Programming", Vol. 2, page 232, 3rd edition
        /// describes Welford's method for accumulating this sum in one pass.If count is zero then this field must be
        /// zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sumOfSquaredDeviation")]
        public virtual System.Nullable<double> SumOfSquaredDeviation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A DistributionCut defines a TimeSeries and thresholds used for measuring good service and total service. The
    /// TimeSeries must have ValueType = DISTRIBUTION and MetricKind = DELTA or MetricKind = CUMULATIVE. The computed
    /// good_service will be the estimated count of values in the Distribution that fall within the specified min and
    /// max.
    /// </summary>
    public class DistributionCut : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) specifying a TimeSeries aggregating
        /// values. Must have ValueType = DISTRIBUTION and MetricKind = DELTA or MetricKind = CUMULATIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributionFilter")]
        public virtual string DistributionFilter { get; set; }

        /// <summary>
        /// Range of values considered "good." For a one-sided range, set one bound to an infinite value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GoogleMonitoringV3Range Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Documentation that is included in the notifications and incidents pertaining to this policy.</summary>
    public class Documentation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The body of the documentation, interpreted according to mime_type. The content may not exceed 8,192 Unicode
        /// characters and may not exceed more than 10,240 bytes when encoded in UTF-8 format, whichever is smaller.
        /// This text can be templatized by using variables
        /// (https://cloud.google.com/monitoring/alerts/doc-variables#doc-vars).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// Optional. Links to content such as playbooks, repositories, and other resources. This field can contain up
        /// to 3 entries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("links")]
        public virtual System.Collections.Generic.IList<Link> Links { get; set; }

        /// <summary>
        /// The format of the content field. Presently, only the value "text/markdown" is supported. See Markdown
        /// (https://en.wikipedia.org/wiki/Markdown) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// Optional. The subject line of the notification. The subject line may not exceed 10,240 bytes. In
        /// notifications generated by this policy, the contents of the subject line after variable expansion will be
        /// truncated to 255 bytes or shorter at the latest UTF-8 character boundary. The 255-byte limit is recommended
        /// by this thread (https://stackoverflow.com/questions/1592291/what-is-the-email-subject-length-limit). It is
        /// both the limit imposed by some third-party ticketing products and it is common to define textual fields in
        /// databases as VARCHAR(255).The contents of the subject line can be templatized by using variables
        /// (https://cloud.google.com/monitoring/alerts/doc-variables#doc-vars). If this field is missing or empty, a
        /// default subject line will be generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of (label, value) pairs that were removed from a Distribution time series during aggregation and then
    /// added as an attachment to a Distribution.Exemplar.The full label set for the exemplars is constructed by using
    /// the dropped pairs in combination with the label values that remain on the aggregated Distribution time series.
    /// The constructed full label set can be used to identify the specific entity, such as the instance or job, which
    /// might be contributing to a long-tail. However, with dropped labels, the storage requirements are reduced because
    /// only the aggregated distribution values for a large group of time series are stored.Note that there are no
    /// guarantees on ordering of the labels from exemplar-to-exemplar and from distribution-to-distribution in the same
    /// stream, and there may be duplicates. It is up to clients to resolve any ambiguities.
    /// </summary>
    public class DroppedLabels : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map from label to its value, for all labels dropped in any aggregation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual System.Collections.Generic.IDictionary<string, string> Label { get; set; }

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

    /// <summary>Detailed information about an error category.</summary>
    public class Error : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of points that couldn't be written because of status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointCount")]
        public virtual System.Nullable<int> PointCount { get; set; }

        /// <summary>The status of the requested write operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Exemplars are example points that may be used to annotate aggregated distribution values. They are metadata that
    /// gives information about a particular value added to a Distribution bucket, such as a trace ID that was active
    /// when a value was added. They may contain further information, such as a example values and timestamps, origin,
    /// etc.
    /// </summary>
    public class Exemplar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contextual information about the example value. Examples are:Trace:
        /// type.googleapis.com/google.monitoring.v3.SpanContextLiteral string:
        /// type.googleapis.com/google.protobuf.StringValueLabels dropped during aggregation:
        /// type.googleapis.com/google.monitoring.v3.DroppedLabelsThere may be only a single attachment of any given
        /// message type in a single exemplar, and this is enforced by the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Attachments { get; set; }

        private string _timestampRaw;

        private object _timestamp;

        /// <summary>The observation (sampling) time of the above value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string TimestampRaw
        {
            get => _timestampRaw;
            set
            {
                _timestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampDateTimeOffset instead.")]
        public virtual object Timestamp
        {
            get => _timestamp;
            set
            {
                _timestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampRaw);
            set => TimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Value of the exemplar point. This value determines to which bucket the exemplar belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies a set of buckets with arbitrary widths.There are size(bounds) + 1 (= N) buckets. Bucket i has the
    /// following boundaries:Upper bound (0 &amp;lt;= i &amp;lt; N-1): boundsi Lower bound (1 &amp;lt;= i &amp;lt; N);
    /// boundsi - 1The bounds field must contain at least one element. If bounds has only one element, then there are no
    /// finite buckets, and that single element is the common boundary of the overflow and underflow buckets.
    /// </summary>
    public class Explicit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values must be monotonically increasing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bounds")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Bounds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies an exponential sequence of buckets that have a width that is proportional to the value of the lower
    /// bound. Each bucket represents a constant relative uncertainty on a specific value in the bucket.There are
    /// num_finite_buckets + 2 (= N) buckets. Bucket i has the following boundaries:Upper bound (0 &amp;lt;= i &amp;lt;
    /// N-1): scale * (growth_factor ^ i).Lower bound (1 &amp;lt;= i &amp;lt; N): scale * (growth_factor ^ (i - 1)).
    /// </summary>
    public class Exponential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be greater than 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("growthFactor")]
        public virtual System.Nullable<double> GrowthFactor { get; set; }

        /// <summary>Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFiniteBuckets")]
        public virtual System.Nullable<int> NumFiniteBuckets { get; set; }

        /// <summary>Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<double> Scale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single field of a message type.</summary>
    public class Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field cardinality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardinality")]
        public virtual string Cardinality { get; set; }

        /// <summary>The string value of the default value of this field. Proto2 syntax only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; }

        /// <summary>The field JSON name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonName")]
        public virtual string JsonName { get; set; }

        /// <summary>The field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The field name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The field number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>
        /// The index of the field type in Type.oneofs, for message or enumeration types. The first type has index 1;
        /// zero means the type is not in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneofIndex")]
        public virtual System.Nullable<int> OneofIndex { get; set; }

        /// <summary>The protocol buffer options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>Whether to use alternative packed wire representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packed")]
        public virtual System.Nullable<bool> Packed { get; set; }

        /// <summary>
        /// The field type URL, without the scheme, for message or enumeration types. Example:
        /// "type.googleapis.com/google.protobuf.Timestamp".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeUrl")]
        public virtual string TypeUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options used when forecasting the time series and testing the predicted value against the threshold.
    /// </summary>
    public class ForecastOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The length of time into the future to forecast whether a time series will violate the threshold.
        /// If the predicted value is found to violate the threshold, and the violation is observed in all forecasts
        /// made for the configured duration, then the time series is considered to be failing. The forecast horizon can
        /// range from 1 hour to 60 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forecastHorizon")]
        public virtual object ForecastHorizon { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The GetNotificationChannelVerificationCode request.</summary>
    public class GetNotificationChannelVerificationCodeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// The desired expiration time. If specified, the API will guarantee that the returned code will not be valid
        /// after the specified timestamp; however, the API cannot guarantee that the returned code will be valid for at
        /// least as long as the requested time (the API puts an upper bound on the amount of time for which a code may
        /// be valid). If omitted, a default expiration will be used, which may be less than the max permissible
        /// expiration (so specifying an expiration may extend the code's lifetime over omitting an expiration, even
        /// though the API does impose an upper limit on the maximum expiration that is permitted).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The GetNotificationChannelVerificationCode request.</summary>
    public class GetNotificationChannelVerificationCodeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The verification code, which may be used to verify other channels that have an equivalent identity (i.e.
        /// other channels of the same type with the same fingerprint such as other email channels with the same email
        /// address or other sms channels with the same number).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// The expiration time associated with the code that was returned. If an expiration was provided in the
        /// request, this is the minimum of the requested expiration in the request and the max permitted expiration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GKE Namespace. The field names correspond to the resource metadata labels on monitored resources that fall under
    /// a namespace (for example, k8s_container or k8s_pod).
    /// </summary>
    public class GkeNamespace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parent cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>The location of the parent cluster. This may be a zone or region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The name of this namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceName")]
        public virtual string NamespaceName { get; set; }

        /// <summary>
        /// Output only. The project this resource lives in. For legacy services migrated from the Custom type, this may
        /// be a distinct project from the one parenting the service itself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// GKE Service. The "service" here represents a Kubernetes service object
    /// (https://kubernetes.io/docs/concepts/services-networking/service). The field names correspond to the resource
    /// labels on k8s_service monitored resources (https://cloud.google.com/monitoring/api/resources#tag_k8s_service).
    /// </summary>
    public class GkeService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parent cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>The location of the parent cluster. This may be a zone or region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The name of the parent namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceName")]
        public virtual string NamespaceName { get; set; }

        /// <summary>
        /// Output only. The project this resource lives in. For legacy services migrated from the Custom type, this may
        /// be a distinct project from the one parenting the service itself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The name of this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A GKE Workload (Deployment, StatefulSet, etc). The field names correspond to the metadata labels on monitored
    /// resources that fall under a workload (for example, k8s_container or k8s_pod).
    /// </summary>
    public class GkeWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the parent cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>The location of the parent cluster. This may be a zone or region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The name of the parent namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceName")]
        public virtual string NamespaceName { get; set; }

        /// <summary>
        /// Output only. The project this resource lives in. For legacy services migrated from the Custom type, this may
        /// be a distinct project from the one parenting the service itself.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The name of this workload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLevelControllerName")]
        public virtual string TopLevelControllerName { get; set; }

        /// <summary>The type of this workload (for example, "Deployment" or "DaemonSet")</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topLevelControllerType")]
        public virtual string TopLevelControllerType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Range of numerical values within min and max.</summary>
    public class GoogleMonitoringV3Range : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Range maximum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<double> Max { get; set; }

        /// <summary>Range minimum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<double> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The description of a dynamic collection of monitored resources. Each group has a filter that is matched against
    /// monitored resources and their associated metadata. If a group's filter matches an available monitored resource,
    /// then that resource is a member of that group. Groups can contain any number of monitored resources, and each
    /// monitored resource can be a member of any number of groups.Groups can be nested in parent-child hierarchies. The
    /// parentName field identifies an optional parent for each group. If a group has a parent, then the only monitored
    /// resources available to be matched by the group's filter are the resources contained in the parent group. In
    /// other words, a group contains the monitored resources that match its filter and the filters of all the group's
    /// ancestors. A group without a parent can contain any monitored resource.For example, consider an infrastructure
    /// running a set of instances with two user-defined tags: "environment" and "role". A parent group has a filter,
    /// environment="production". A child of that parent group has a filter, role="transcoder". The parent group
    /// contains all instances in the production environment, regardless of their roles. The child group contains
    /// instances that have the transcoder role and are in the production environment.The monitored resources contained
    /// in a group can change at any moment, depending on what resources exist and what filters are associated with the
    /// group and its ancestors.
    /// </summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A user-assigned name for this group, used only for display purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The filter used to determine which monitored resources belong to this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// If true, the members of this group are considered to be a cluster. The system can perform additional
        /// analysis on groups that are clusters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCluster")]
        public virtual System.Nullable<bool> IsCluster { get; set; }

        /// <summary>
        /// Output only. The name of this group. The format is: projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID] When
        /// creating a group, this field is ignored and a new name is created consisting of the project specified in the
        /// call to CreateGroup and a unique [GROUP_ID] that is generated automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the group's parent, if it has one. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID] For groups with no parent, parent_name is the empty
        /// string, "".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentName")]
        public virtual string ParentName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used to schedule the query to run every so many hours.</summary>
    public class Hourly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The number of minutes after the hour (in UTC) to run the query. Must be greater than or equal to 0
        /// minutes and less than or equal to 59 minutes. If left unspecified, then an arbitrary offset is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minuteOffset")]
        public virtual System.Nullable<int> MinuteOffset { get; set; }

        /// <summary>
        /// Required. The number of hours between runs. Must be greater than or equal to 1 hour and less than or equal
        /// to 48 hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodicity")]
        public virtual System.Nullable<int> Periodicity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information involved in an HTTP/HTTPS Uptime check request.</summary>
    public class HttpCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the check will only pass if the HTTP response status code is in this set of status codes. If
        /// empty, the HTTP status code will only pass if the HTTP status code is 200-299.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acceptedResponseStatusCodes")]
        public virtual System.Collections.Generic.IList<ResponseStatusCode> AcceptedResponseStatusCodes { get; set; }

        /// <summary>
        /// The authentication information. Optional when creating an HTTP check; defaults to empty. Do not set both
        /// auth_method and auth_info.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authInfo")]
        public virtual BasicAuthentication AuthInfo { get; set; }

        /// <summary>
        /// The request body associated with the HTTP POST request. If content_type is URL_ENCODED, the body passed in
        /// must be URL-encoded. Users can provide a Content-Length header via the headers field or the API will do so.
        /// If the request_method is GET and body is not empty, the API will return an error. The maximum byte size is 1
        /// megabyte.Note: If client libraries aren't used (which performs the conversion automatically) base64 encode
        /// your body data since the field is of bytes type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// The content type header to use for the check. The following configurations result in errors: 1. Content type
        /// is specified in both the headers field and the content_type field. 2. Request method is GET and content_type
        /// is not TYPE_UNSPECIFIED 3. Request method is POST and content_type is TYPE_UNSPECIFIED. 4. Request method is
        /// POST and a "Content-Type" header is provided via headers field. The content_type field should be used
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// A user provided content type header to use for the check. The invalid configurations outlined in the
        /// content_type field apply to custom_content_type, as well as the following: 1. content_type is URL_ENCODED
        /// and custom_content_type is set. 2. content_type is USER_PROVIDED and custom_content_type is not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customContentType")]
        public virtual string CustomContentType { get; set; }

        /// <summary>
        /// The list of headers to send as part of the Uptime check request. If two headers have the same key and
        /// different values, they should be entered as a single header, with the value being a comma-separated list of
        /// all the desired values as described at https://www.w3.org/Protocols/rfc2616/rfc2616.txt (page 31). Entering
        /// two separate headers with the same key in a Create call will cause the first to be overwritten by the
        /// second. The maximum number of headers allowed is 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Boolean specifying whether to encrypt the header information. Encryption should be specified for any headers
        /// related to authentication that you do not wish to be seen when retrieving the configuration. The server will
        /// be responsible for encrypting the headers. On Get/List calls, if mask_headers is set to true then the
        /// headers will be obscured with ******.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maskHeaders")]
        public virtual System.Nullable<bool> MaskHeaders { get; set; }

        /// <summary>
        /// Optional (defaults to "/"). The path to the page against which to run the check. Will be combined with the
        /// host (specified within the monitored_resource) and port to construct the full URL. If the provided path does
        /// not begin with "/", a "/" will be prepended automatically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Contains information needed to add pings to an HTTP check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pingConfig")]
        public virtual PingConfig PingConfig { get; set; }

        /// <summary>
        /// Optional (defaults to 80 when use_ssl is false, and 443 when use_ssl is true). The TCP port on the HTTP
        /// server against which to run the check. Will be combined with host (specified within the monitored_resource)
        /// and path to construct the full URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>
        /// The HTTP request method to use for the check. If set to METHOD_UNSPECIFIED then request_method defaults to
        /// GET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMethod")]
        public virtual string RequestMethod { get; set; }

        /// <summary>
        /// If specified, Uptime will generate and attach an OIDC JWT token for the Monitoring service agent service
        /// account as an Authorization header in the HTTP request when probing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAgentAuthentication")]
        public virtual ServiceAgentAuthentication ServiceAgentAuthentication { get; set; }

        /// <summary>If true, use HTTPS instead of HTTP to run the check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useSsl")]
        public virtual System.Nullable<bool> UseSsl { get; set; }

        /// <summary>
        /// Boolean specifying whether to include SSL certificate validation as a part of the Uptime check. Only applies
        /// to checks where monitored_resource is set to uptime_url. If use_ssl is false, setting validate_ssl to true
        /// has no effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateSsl")]
        public virtual System.Nullable<bool> ValidateSsl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An internal checker allows Uptime checks to run on private/internal GCP resources.</summary>
    public class InternalChecker : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The checker's human-readable name. The display name should be unique within a Cloud Monitoring Metrics Scope
        /// in order to make it easier to identify; however, uniqueness is not enforced.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The GCP zone the Uptime check should egress from. Only respected for internal Uptime checks, where
        /// internal_network is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpZone")]
        public virtual string GcpZone { get; set; }

        /// <summary>
        /// A unique resource name for this InternalChecker. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/internalCheckers/[INTERNAL_CHECKER_ID] [PROJECT_ID_OR_NUMBER] is the Cloud
        /// Monitoring Metrics Scope project for the Uptime check config associated with the internal checker.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The GCP VPC network (https://cloud.google.com/vpc/docs/vpc) where the internal resource lives (ex:
        /// "default").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// The GCP project ID where the internal checker lives. Not necessary the same as the Metrics Scope project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peerProjectId")]
        public virtual string PeerProjectId { get; set; }

        /// <summary>The current operational state of the internal checker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Canonical service scoped to an Istio mesh. Anthos clusters running ASM &amp;gt;= 1.6.8 will have their services
    /// ingested as this type.
    /// </summary>
    public class IstioCanonicalService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the canonical service underlying this service. Corresponds to the
        /// destination_canonical_service_name metric label in label in Istio metrics
        /// (https://cloud.google.com/monitoring/api/metrics_istio).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalService")]
        public virtual string CanonicalService { get; set; }

        /// <summary>
        /// The namespace of the canonical service underlying this service. Corresponds to the
        /// destination_canonical_service_namespace metric label in Istio metrics
        /// (https://cloud.google.com/monitoring/api/metrics_istio).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalServiceNamespace")]
        public virtual string CanonicalServiceNamespace { get; set; }

        /// <summary>
        /// Identifier for the Istio mesh in which this canonical service is defined. Corresponds to the mesh_uid metric
        /// label in Istio metrics (https://cloud.google.com/monitoring/api/metrics_istio).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshUid")]
        public virtual string MeshUid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information needed to perform a JSONPath content match. Used for ContentMatcherOption::MATCHES_JSON_PATH and
    /// ContentMatcherOption::NOT_MATCHES_JSON_PATH.
    /// </summary>
    public class JsonPathMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The type of JSONPath match that will be applied to the JSON output (ContentMatcher.content)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonMatcher")]
        public virtual string JsonMatcher { get; set; }

        /// <summary>
        /// JSONPath within the response output pointing to the expected ContentMatcher::content to match against.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonPath")]
        public virtual string JsonPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A description of a label.</summary>
    public class LabelDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A human-readable description for the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The key for this label. The key must meet the following criteria: Does not exceed 100 characters. Matches
        /// the following regular expression: [a-zA-Z][a-zA-Z0-9_]* The first character must be an upper- or lower-case
        /// letter. The remaining characters must be letters, digits, or underscores.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The type of data that can be assigned to the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A label value.</summary>
    public class LabelValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A bool label value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>An int64 label value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>A string label value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters for a latency threshold SLI.</summary>
    public class LatencyCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Good service is defined to be the count of requests made to this service that return in no more than
        /// threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual object Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies a linear sequence of buckets that all have the same width (except overflow and underflow). Each bucket
    /// represents a constant absolute uncertainty on the specific value in the bucket.There are num_finite_buckets + 2
    /// (= N) buckets. Bucket i has the following boundaries:Upper bound (0 &amp;lt;= i &amp;lt; N-1): offset + (width *
    /// i).Lower bound (1 &amp;lt;= i &amp;lt; N): offset + (width * (i - 1)).
    /// </summary>
    public class Linear : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFiniteBuckets")]
        public virtual System.Nullable<int> NumFiniteBuckets { get; set; }

        /// <summary>Lower bound of the first bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<double> Offset { get; set; }

        /// <summary>Must be greater than 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<double> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Links to content such as playbooks, repositories, and other resources.</summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A short display name for the link. The display name must not be empty or exceed 63 characters. Example:
        /// "playbook".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The url of a webpage. A url can be templatized by using variables in the path or the query parameters. The
        /// total length of a URL should not exceed 2083 characters before and after variable expansion. Example:
        /// "https://my_domain.com/playbook?name=${resource.name}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The protocol for the ListAlertPolicies response.</summary>
    public class ListAlertPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned alert policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertPolicies")]
        public virtual System.Collections.Generic.IList<AlertPolicy> AlertPolicies { get; set; }

        /// <summary>
        /// If there might be more results than were returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The total number of alert policies in all pages. This number is only an estimate, and may change in
        /// subsequent pages. https://aip.dev/158
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListGroupMembers response.</summary>
    public class ListGroupMembersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of monitored resources in the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<MonitoredResource> Members { get; set; }

        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The total number of elements matching this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListGroups response.</summary>
    public class ListGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The groups that match the specified filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual System.Collections.Generic.IList<Group> Group { get; set; }

        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListMetricDescriptors response.</summary>
    public class ListMetricDescriptorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The metric descriptors that are available to the project and that match the value of filter, if present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricDescriptors")]
        public virtual System.Collections.Generic.IList<MetricDescriptor> MetricDescriptors { get; set; }

        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListMonitoredResourceDescriptors response.</summary>
    public class ListMonitoredResourceDescriptorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The monitored resource descriptors that are available to this project and that match filter, if present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceDescriptors")]
        public virtual System.Collections.Generic.IList<MonitoredResourceDescriptor> ResourceDescriptors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListNotificationChannelDescriptors response.</summary>
    public class ListNotificationChannelDescriptorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The monitored resource descriptors supported for the specified project, optionally filtered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelDescriptors")]
        public virtual System.Collections.Generic.IList<NotificationChannelDescriptor> ChannelDescriptors { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more results that match the request. Use the value in the
        /// page_token field in a subsequent request to fetch the next set of results. If empty, all results have been
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListNotificationChannels response.</summary>
    public class ListNotificationChannelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If not empty, indicates that there may be more results that match the request. Use the value in the
        /// page_token field in a subsequent request to fetch the next set of results. If empty, all results have been
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The notification channels defined for the specified project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationChannels")]
        public virtual System.Collections.Generic.IList<NotificationChannel> NotificationChannels { get; set; }

        /// <summary>
        /// The total number of notification channels in all pages. This number is only an estimate, and may change in
        /// subsequent pages. https://aip.dev/158
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListServiceLevelObjectives response.</summary>
    public class ListServiceLevelObjectivesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ServiceLevelObjectives matching the specified filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLevelObjectives")]
        public virtual System.Collections.Generic.IList<ServiceLevelObjective> ServiceLevelObjectives { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListServices response.</summary>
    public class ListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Services matching the specified filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<Service> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The results of a successful ListSnoozes call, containing the matching Snoozes.</summary>
    public class ListSnoozesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Page token for repeated calls to ListSnoozes, to fetch additional pages of results. If this is empty or
        /// missing, there are no more pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Snoozes matching this list call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snoozes")]
        public virtual System.Collections.Generic.IList<Snooze> Snoozes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListTimeSeries response.</summary>
    public class ListTimeSeriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Query execution errors that may have caused the time series data returned to be incomplete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionErrors")]
        public virtual System.Collections.Generic.IList<Status> ExecutionErrors { get; set; }

        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>One or more time series that match the filter included in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeries")]
        public virtual System.Collections.Generic.IList<TimeSeries> TimeSeries { get; set; }

        /// <summary>
        /// The unit in which all time_series point values are reported. unit follows the UCUM format for units as seen
        /// in https://unitsofmeasure.org/ucum.html. If different time_series have different units (for example, because
        /// they come from different metric types, or a unit is absent), then unit will be "{not_a_unit}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The protocol for the ListUptimeCheckConfigs response.</summary>
    public class ListUptimeCheckConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field represents the pagination token to retrieve the next page of results. If the value is empty, it
        /// means no further results for the request. To retrieve the next page of results, the value of the
        /// next_page_token is passed to the subsequent List method call (in the request message's page_token field).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The total number of Uptime check configurations for the project, irrespective of any pagination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The returned Uptime check configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uptimeCheckConfigs")]
        public virtual System.Collections.Generic.IList<UptimeCheckConfig> UptimeCheckConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The protocol for the ListUptimeCheckIps response.</summary>
    public class ListUptimeCheckIpsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field represents the pagination token to retrieve the next page of results. If the value is empty, it
        /// means no further results for the request. To retrieve the next page of results, the value of the
        /// next_page_token is passed to the subsequent List method call (in the request message's page_token field).
        /// NOTE: this field is not yet implemented
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The returned list of IP addresses (including region and location) that the checkers run from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uptimeCheckIps")]
        public virtual System.Collections.Generic.IList<UptimeCheckIp> UptimeCheckIps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition type that checks whether a log message in the scoping project
    /// (https://cloud.google.com/monitoring/api/v3#project_name) satisfies the given filter. Logs from other projects
    /// in the metrics scope are not evaluated.
    /// </summary>
    public class LogMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A logs-based filter. See Advanced Logs Queries
        /// (https://cloud.google.com/logging/docs/view/advanced-queries) for how this filter should be constructed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. A map from a label key to an extractor expression, which is used to extract the value for this
        /// label key. Each entry in this map is a specification for how data should be extracted from log entries that
        /// match filter. Each combination of extracted values is treated as a separate rule for the purposes of
        /// triggering notifications. Label keys and corresponding values can be used in notifications generated by this
        /// condition.Please see the documentation on logs-based metric valueExtractors
        /// (https://cloud.google.com/logging/docs/reference/v2/rest/v2/projects.metrics#LogMetric.FIELDS.value_extractor)
        /// for syntax and examples.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelExtractors")]
        public virtual System.Collections.Generic.IDictionary<string, string> LabelExtractors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Istio service scoped to an Istio mesh. Anthos clusters running ASM &amp;lt; 1.6.8 will have their services
    /// ingested as this type.
    /// </summary>
    public class MeshIstio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier for the mesh in which this Istio service is defined. Corresponds to the mesh_uid metric label in
        /// Istio metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshUid")]
        public virtual string MeshUid { get; set; }

        /// <summary>
        /// The name of the Istio service underlying this service. Corresponds to the destination_service_name metric
        /// label in Istio metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// The namespace of the Istio service underlying this service. Corresponds to the destination_service_namespace
        /// metric label in Istio metrics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceNamespace")]
        public virtual string ServiceNamespace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A specific metric, identified by specifying values for all of the labels of a MetricDescriptor.
    /// </summary>
    public class Metric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of label values that uniquely identify this metric. All labels listed in the MetricDescriptor must
        /// be assigned values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// An existing metric type, see google.api.MetricDescriptor. For example,
        /// custom.googleapis.com/invoice/paid/amount.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition type that checks that monitored resources are reporting data. The configuration defines a metric and
    /// a set of monitored resources. The predicate is considered in violation when a time series for the specified
    /// metric of a monitored resource does not include any data in the specified duration.
    /// </summary>
    public class MetricAbsence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the alignment of data points in individual time series as well as how to combine the retrieved
        /// time series together (such as when aggregating multiple streams on each resource to a single stream for each
        /// resource or when aggregating streams across all members of a group of resources). Multiple aggregations are
        /// applied in the order specified.This field is similar to the one in the ListTimeSeries request
        /// (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list). It is advisable to use
        /// the ListTimeSeries method when debugging this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregations")]
        public virtual System.Collections.Generic.IList<Aggregation> Aggregations { get; set; }

        /// <summary>
        /// The amount of time that a time series must fail to report new data to be considered failing. The minimum
        /// value of this field is 120 seconds. Larger values that are a multiple of a minute--for example, 240 or 300
        /// seconds--are supported. If an invalid value is given, an error will be returned. The Duration.nanos field is
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// Required. A filter (https://cloud.google.com/monitoring/api/v3/filters) that identifies which time series
        /// should be compared with the threshold.The filter is similar to the one that is specified in the
        /// ListTimeSeries request (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list)
        /// (that call is useful to verify the time series that will be retrieved / processed). The filter must specify
        /// the metric type and the resource type. Optionally, it can specify resource labels and metric labels. This
        /// field must not exceed 2048 Unicode characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The number/percent of time series for which the comparison must hold in order for the condition to trigger.
        /// If unspecified, then the condition will trigger if the comparison is true for any of the time series that
        /// have been identified by filter and aggregations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual Trigger Trigger { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a metric type and its schema. Once a metric descriptor is created, deleting or altering it stops data
    /// collection and makes the metric type's existing data unusable.
    /// </summary>
    public class MetricDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A detailed description of the metric, which can be used in documentation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an
        /// ending period, for example "Request count". This field is optional but it is recommended to be set for any
        /// metrics associated with user-visible concepts, such as Quota.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The set of labels that can be used to describe a specific instance of this metric type. For example, the
        /// appengine.googleapis.com/http/server/response_latencies metric type has a label for the HTTP response code,
        /// response_code, so you can look at latencies for successful responses or just for responses that failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> Labels { get; set; }

        /// <summary>Optional. The launch stage of the metric definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>Optional. Metadata which can be used to guide usage of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual MetricDescriptorMetadata Metadata { get; set; }

        /// <summary>
        /// Whether the metric records instantaneous values, changes to a value, etc. Some combinations of metric_kind
        /// and value_type might not be supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricKind")]
        public virtual string MetricKind { get; set; }

        /// <summary>
        /// Read-only. If present, then a time series, which is identified partially by a metric type and a
        /// MonitoredResourceDescriptor, that is associated with this metric type can only be associated with one of the
        /// monitored resource types listed here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResourceTypes")]
        public virtual System.Collections.Generic.IList<string> MonitoredResourceTypes { get; set; }

        /// <summary>The resource name of the metric descriptor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The metric type, including its DNS name prefix. The type is not URL-encoded. All user-defined metric types
        /// have the DNS name custom.googleapis.com or external.googleapis.com. Metric types should use a natural
        /// hierarchical grouping. For example: "custom.googleapis.com/invoice/paid/amount"
        /// "external.googleapis.com/prometheus/up" "appengine.googleapis.com/http/server/response_latencies"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The units in which the metric value is reported. It is only applicable if the value_type is INT64, DOUBLE,
        /// or DISTRIBUTION. The unit defines the representation of the stored metric values.Different systems might
        /// scale the values to be more easily displayed (so a value of 0.02kBy might be displayed as 20By, and a value
        /// of 3523kBy might be displayed as 3.5MBy). However, if the unit is kBy, then the value of the metric is
        /// always in thousands of bytes, no matter how it might be displayed.If you want a custom metric to record the
        /// exact number of CPU-seconds used by a job, you can create an INT64 CUMULATIVE metric whose unit is s{CPU}
        /// (or equivalently 1s{CPU} or just s). If the job uses 12,005 CPU-seconds, then the value is written as
        /// 12005.Alternatively, if you want a custom metric to record data in a more granular way, you can create a
        /// DOUBLE CUMULATIVE metric whose unit is ks{CPU}, and then write the value 12.005 (which is 12005/1000), or
        /// use Kis{CPU} and write 11.723 (which is 12005/1024).The supported units are a subset of The Unified Code for
        /// Units of Measure (https://unitsofmeasure.org/ucum.html) standard:Basic units (UNIT) bit bit By byte s second
        /// min minute h hour d day 1 dimensionlessPrefixes (PREFIX) k kilo (10^3) M mega (10^6) G giga (10^9) T tera
        /// (10^12) P peta (10^15) E exa (10^18) Z zetta (10^21) Y yotta (10^24) m milli (10^-3) u micro (10^-6) n nano
        /// (10^-9) p pico (10^-12) f femto (10^-15) a atto (10^-18) z zepto (10^-21) y yocto (10^-24) Ki kibi (2^10) Mi
        /// mebi (2^20) Gi gibi (2^30) Ti tebi (2^40) Pi pebi (2^50)GrammarThe grammar also includes these connectors: /
        /// division or ratio (as an infix operator). For examples, kBy/{email} or MiBy/10ms (although you should almost
        /// never have /s in a metric unit; rates should always be computed at query time from the underlying cumulative
        /// or delta value). . multiplication or composition (as an infix operator). For examples, GBy.d or
        /// k{watt}.h.The grammar for a unit is as follows: Expression = Component { "." Component } { "/" Component } ;
        /// Component = ( [ PREFIX ] UNIT | "%" ) [ Annotation ] | Annotation | "1" ; Annotation = "{" NAME "}" ; Notes:
        /// Annotation is just a comment if it follows a UNIT. If the annotation is used alone, then the unit is
        /// equivalent to 1. For examples, {request}/s == 1/s, By{transmitted}/s == By/s. NAME is a sequence of
        /// non-blank printable ASCII characters not containing { or }. 1 represents a unitary dimensionless unit
        /// (https://en.wikipedia.org/wiki/Dimensionless_quantity) of 1, such as in 1/s. It is typically used when none
        /// of the basic units are appropriate. For example, "new users per day" can be represented as 1/d or
        /// {new-users}/d (and a metric value 5 would mean "5 new users). Alternatively, "thousands of page views per
        /// day" would be represented as 1000/d or k1/d or k{page_views}/d (and a metric value of 5.3 would mean "5300
        /// page views per day"). % represents dimensionless value of 1/100, and annotates values giving a percentage
        /// (so the metric values are typically in the range of 0..100, and a metric value 3 means "3 percent"). 10^2.%
        /// indicates a metric contains a ratio, typically in the range 0..1, that will be multiplied by 100 and
        /// displayed as a percentage (so a metric value 0.03 means "3 percent").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// Whether the measurement is an integer, a floating-point number, etc. Some combinations of metric_kind and
        /// value_type might not be supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional annotations that can be used to guide the usage of a metric.</summary>
    public class MetricDescriptorMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The delay of data points caused by ingestion. Data points older than this age are guaranteed to be ingested
        /// and available to be read, excluding data loss due to errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestDelay")]
        public virtual object IngestDelay { get; set; }

        /// <summary>Deprecated. Must use the MetricDescriptor.launch_stage instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The sampling period of metric data points. For metrics which are written periodically, consecutive data
        /// points are stored at this time interval, excluding data loss due to errors. Metrics with a higher
        /// granularity have a smaller sampling period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("samplePeriod")]
        public virtual object SamplePeriod { get; set; }

        /// <summary>The scope of the timeseries data of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesResourceHierarchyLevel")]
        public virtual System.Collections.Generic.IList<string> TimeSeriesResourceHierarchyLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A MetricRange is used when each window is good when the value x of a single TimeSeries satisfies range.min
    /// &amp;lt;= x &amp;lt;= range.max. The provided TimeSeries must have ValueType = INT64 or ValueType = DOUBLE and
    /// MetricKind = GAUGE.
    /// </summary>
    public class MetricRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Range of values considered "good." For a one-sided range, set one bound to an infinite value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GoogleMonitoringV3Range Range { get; set; }

        /// <summary>
        /// A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) specifying the TimeSeries to use
        /// for evaluating window quality.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeries")]
        public virtual string TimeSeries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A condition type that compares a collection of time series against a threshold.</summary>
    public class MetricThreshold : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the alignment of data points in individual time series as well as how to combine the retrieved
        /// time series together (such as when aggregating multiple streams on each resource to a single stream for each
        /// resource or when aggregating streams across all members of a group of resources). Multiple aggregations are
        /// applied in the order specified.This field is similar to the one in the ListTimeSeries request
        /// (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list). It is advisable to use
        /// the ListTimeSeries method when debugging this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregations")]
        public virtual System.Collections.Generic.IList<Aggregation> Aggregations { get; set; }

        /// <summary>
        /// The comparison to apply between the time series (indicated by filter and aggregation) and the threshold
        /// (indicated by threshold_value). The comparison is applied on each time series, with the time series on the
        /// left-hand side and the threshold on the right-hand side.Only COMPARISON_LT and COMPARISON_GT are supported
        /// currently.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comparison")]
        public virtual string Comparison { get; set; }

        /// <summary>
        /// Specifies the alignment of data points in individual time series selected by denominatorFilter as well as
        /// how to combine the retrieved time series together (such as when aggregating multiple streams on each
        /// resource to a single stream for each resource or when aggregating streams across all members of a group of
        /// resources).When computing ratios, the aggregations and denominator_aggregations fields must use the same
        /// alignment period and produce time series that have the same periodicity and labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denominatorAggregations")]
        public virtual System.Collections.Generic.IList<Aggregation> DenominatorAggregations { get; set; }

        /// <summary>
        /// A filter (https://cloud.google.com/monitoring/api/v3/filters) that identifies a time series that should be
        /// used as the denominator of a ratio that will be compared with the threshold. If a denominator_filter is
        /// specified, the time series specified by the filter field will be used as the numerator.The filter must
        /// specify the metric type and optionally may contain restrictions on resource type, resource labels, and
        /// metric labels. This field may not exceed 2048 Unicode characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denominatorFilter")]
        public virtual string DenominatorFilter { get; set; }

        /// <summary>
        /// The amount of time that a time series must violate the threshold to be considered failing. Currently, only
        /// values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value
        /// is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of
        /// the underlying time series data (which may also be affected by any alignments specified in the aggregations
        /// field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short
        /// enough that unhealthy states are detected and alerted on quickly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// A condition control that determines how metric-threshold conditions are evaluated when data stops arriving.
        /// To use this control, the value of the duration field must be greater than or equal to 60 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMissingData")]
        public virtual string EvaluationMissingData { get; set; }

        /// <summary>
        /// Required. A filter (https://cloud.google.com/monitoring/api/v3/filters) that identifies which time series
        /// should be compared with the threshold.The filter is similar to the one that is specified in the
        /// ListTimeSeries request (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list)
        /// (that call is useful to verify the time series that will be retrieved / processed). The filter must specify
        /// the metric type and the resource type. Optionally, it can specify resource labels and metric labels. This
        /// field must not exceed 2048 Unicode characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// When this field is present, the MetricThreshold condition forecasts whether the time series is predicted to
        /// violate the threshold within the forecast_horizon. When this field is not set, the MetricThreshold tests the
        /// current value of the timeseries against the threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forecastOptions")]
        public virtual ForecastOptions ForecastOptions { get; set; }

        /// <summary>A value against which to compare the time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholdValue")]
        public virtual System.Nullable<double> ThresholdValue { get; set; }

        /// <summary>
        /// The number/percent of time series for which the comparison must hold in order for the condition to trigger.
        /// If unspecified, then the condition will trigger if the comparison is true for any of the time series that
        /// have been identified by filter and aggregations, or by the ratio, if denominator_filter and
        /// denominator_aggregations are specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual Trigger Trigger { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used to schedule the query to run every so many minutes.</summary>
    public class Minutes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Number of minutes between runs. The interval must be greater than or equal to 5 minutes and less
        /// than or equal to 1440 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodicity")]
        public virtual System.Nullable<int> Periodicity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object representing a resource that can be used for monitoring, logging, billing, or other purposes. Examples
    /// include virtual machine instances, databases, and storage devices such as disks. The type field identifies a
    /// MonitoredResourceDescriptor object that describes the resource's schema. Information in the labels field
    /// identifies the actual resource and its attributes according to the schema. For example, a particular Compute
    /// Engine VM instance could be represented by the following object, because the MonitoredResourceDescriptor for
    /// "gce_instance" has labels "project_id", "instance_id" and "zone": { "type": "gce_instance", "labels": {
    /// "project_id": "my-project", "instance_id": "12345678901234", "zone": "us-central1-a" }}
    /// </summary>
    public class MonitoredResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Values for all of the labels listed in the associated monitored resource descriptor. For example,
        /// Compute Engine VM instances use the labels "project_id", "instance_id", and "zone".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The monitored resource type. This field must match the type field of a MonitoredResourceDescriptor
        /// object. For example, the type of a Compute Engine VM instance is gce_instance. For a list of types, see
        /// Monitoring resource types (https://cloud.google.com/monitoring/api/resources) and Logging resource types
        /// (https://cloud.google.com/logging/docs/api/v2/resource-list).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An object that describes the schema of a MonitoredResource object using a type name and a set of labels. For
    /// example, the monitored resource descriptor for Google Compute Engine VM instances has a type of "gce_instance"
    /// and specifies the use of the labels "instance_id" and "zone" to identify particular VM instances.Different APIs
    /// can support different monitored resource types. APIs generally provide a list method that returns the monitored
    /// resource descriptors used by the API.
    /// </summary>
    public class MonitoredResourceDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A detailed description of the monitored resource type that might be used in documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. A concise name for the monitored resource type that might be displayed in user interfaces. It
        /// should be a Title Cased Noun Phrase, without any article or other determiners. For example, "Google Cloud
        /// SQL Database".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. A set of labels used to describe instances of this monitored resource type. For example, an
        /// individual Google Cloud SQL database is identified by values for the labels "database_id" and "zone".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> Labels { get; set; }

        /// <summary>Optional. The launch stage of the monitored resource definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// Optional. The resource name of the monitored resource descriptor:
        /// "projects/{project_id}/monitoredResourceDescriptors/{type}" where {type} is the value of the type field in
        /// this object and {project_id} is a project ID that provides API-specific context for accessing the type. APIs
        /// that do not use project information can use the resource name format "monitoredResourceDescriptors/{type}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The monitored resource type. For example, the type "cloudsql_database" represents databases in
        /// Google Cloud SQL. For a list of types, see Monitored resource types
        /// (https://cloud.google.com/monitoring/api/resources) and Logging resource types
        /// (https://cloud.google.com/logging/docs/api/v2/resource-list).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Auxiliary metadata for a MonitoredResource object. MonitoredResource objects contain the minimum set of
    /// information to uniquely identify a monitored resource instance. There is some other useful auxiliary metadata.
    /// Monitoring and Logging use an ingestion pipeline to extract metadata for cloud resources of all types, and store
    /// the metadata in this message.
    /// </summary>
    public class MonitoredResourceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Values for predefined system metadata labels. System labels are a kind of metadata extracted by
        /// Google, including "machine_image", "vpc", "subnet_id", "security_group", "name", etc. System label values
        /// can be only strings, Boolean values, or a list of strings. For example: { "name": "my-test-instance",
        /// "security_group": ["a", "b", "c"], "spot_instance": false }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemLabels")]
        public virtual System.Collections.Generic.IDictionary<string, object> SystemLabels { get; set; }

        /// <summary>Output only. A map of user-defined metadata labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition type that allows alerting policies to be defined using Monitoring Query Language
    /// (https://cloud.google.com/monitoring/mql).
    /// </summary>
    public class MonitoringQueryLanguageCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of time that a time series must violate the threshold to be considered failing. Currently, only
        /// values that are a multiple of a minute--e.g., 0, 60, 120, or 300 seconds--are supported. If an invalid value
        /// is given, an error will be returned. When choosing a duration, it is useful to keep in mind the frequency of
        /// the underlying time series data (which may also be affected by any alignments specified in the aggregations
        /// field); a good duration is long enough so that a single outlier does not generate spurious alerts, but short
        /// enough that unhealthy states are detected and alerted on quickly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// A condition control that determines how metric-threshold conditions are evaluated when data stops arriving.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationMissingData")]
        public virtual string EvaluationMissingData { get; set; }

        /// <summary>
        /// Monitoring Query Language (https://cloud.google.com/monitoring/mql) query that outputs a boolean stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The number/percent of time series for which the comparison must hold in order for the condition to trigger.
        /// If unspecified, then the condition will trigger if the comparison is true for any of the time series that
        /// have been identified by filter and aggregations, or by the ratio, if denominator_filter and
        /// denominator_aggregations are specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual Trigger Trigger { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a change made to a configuration.</summary>
    public class MutationRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _mutateTimeRaw;

        private object _mutateTime;

        /// <summary>When the change occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutateTime")]
        public virtual string MutateTimeRaw
        {
            get => _mutateTimeRaw;
            set
            {
                _mutateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _mutateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MutateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MutateTimeDateTimeOffset instead.")]
        public virtual object MutateTime
        {
            get => _mutateTime;
            set
            {
                _mutateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _mutateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="MutateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MutateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MutateTimeRaw);
            set => MutateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The email address of the user making the change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutatedBy")]
        public virtual string MutatedBy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A NotificationChannel is a medium through which an alert is delivered when a policy violation is detected.
    /// Examples of channels include email, SMS, and third-party messaging applications. Fields containing sensitive
    /// information like authentication tokens or contact info are only partially populated on retrieval.
    /// </summary>
    public class NotificationChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Record of the creation of this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationRecord")]
        public virtual MutationRecord CreationRecord { get; set; }

        /// <summary>
        /// An optional human-readable description of this notification channel. This description may provide additional
        /// details, beyond the display name, for the channel. This may not exceed 1024 Unicode characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// An optional human-readable name for this notification channel. It is recommended that you specify a
        /// non-empty and unique name in order to make it easier to identify the channels in your project, though this
        /// is not enforced. The display name is limited to 512 Unicode characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Whether notifications are forwarded to the described channel. This makes it possible to disable delivery of
        /// notifications to a particular channel without removing the channel from all alerting policies that reference
        /// the channel. This is a more convenient approach when the change is temporary and you want to receive
        /// notifications from the same set of alerting policies on the channel at some point in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>
        /// Configuration fields that define the channel and its behavior. The permissible and required labels are
        /// specified in the NotificationChannelDescriptor.labels of the NotificationChannelDescriptor corresponding to
        /// the type field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Records of the modification of this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mutationRecords")]
        public virtual System.Collections.Generic.IList<MutationRecord> MutationRecords { get; set; }

        /// <summary>
        /// Identifier. The full REST resource name for this channel. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID] The [CHANNEL_ID] is automatically assigned
        /// by the server on creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The type of the notification channel. This field matches the value of the NotificationChannelDescriptor.type
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// User-supplied key/value data that does not need to conform to the corresponding
        /// NotificationChannelDescriptor's schema, unlike the labels field. This field is intended to be used for
        /// organizing and identifying the NotificationChannel objects.The field can contain up to 64 entries. Each key
        /// and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can
        /// contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>
        /// Indicates whether this channel has been verified or not. On a ListNotificationChannels or
        /// GetNotificationChannel operation, this field is expected to be populated.If the value is UNVERIFIED, then it
        /// indicates that the channel is non-functioning (it both requires verification and lacks verification);
        /// otherwise, it is assumed that the channel works.If the channel is neither VERIFIED nor UNVERIFIED, it
        /// implies that the channel is of a type that does not require verification or that this specific channel has
        /// been exempted from verification because it was created prior to verification being required for channels of
        /// this type.This field cannot be modified using a standard UpdateNotificationChannel operation. To change the
        /// value of this field, you must call VerifyNotificationChannel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationStatus")]
        public virtual string VerificationStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A description of a notification channel. The descriptor includes the properties of the channel and the set of
    /// labels or fields that must be specified to configure channels of a given type.
    /// </summary>
    public class NotificationChannelDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A human-readable description of the notification channel type. The description may include a description of
        /// the properties of the channel and pointers to external documentation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A human-readable name for the notification channel type. This form of the name is suitable for a user
        /// interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The set of labels that must be defined to identify a particular channel of the corresponding type. Each
        /// label includes a description for how that field should be populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> Labels { get; set; }

        /// <summary>The product launch stage for channels of this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("launchStage")]
        public virtual string LaunchStage { get; set; }

        /// <summary>
        /// The full REST resource name for this descriptor. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[TYPE] In the above, [TYPE] is the value of
        /// the type field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The tiers that support this notification channel; the project service tier must be one of the
        /// supported_tiers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedTiers")]
        public virtual System.Collections.Generic.IList<string> SupportedTiers { get; set; }

        /// <summary>
        /// The type of notification channel, such as "email" and "sms". To view the full list of channels, see Channel
        /// descriptors (https://cloud.google.com/monitoring/alerts/using-channels-api#ncd). Notification channel types
        /// are globally unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Control over how the notification channels in notification_channels are notified when this alert fires, on a
    /// per-channel basis.
    /// </summary>
    public class NotificationChannelStrategy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full REST resource name for the notification channels that these settings apply to. Each of these
        /// correspond to the name field in one of the NotificationChannel objects referenced in the
        /// notification_channels field of this AlertPolicy. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationChannelNames")]
        public virtual System.Collections.Generic.IList<string> NotificationChannelNames { get; set; }

        /// <summary>The frequency at which to send reminder notifications for open incidents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renotifyInterval")]
        public virtual object RenotifyInterval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Control over the rate of notifications sent to this alerting policy's notification channels.</summary>
    public class NotificationRateLimit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Not more than one notification per period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual object Period { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains metadata for longrunning operation for the edit Metrics Scope endpoints.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time when the batch request was received.</summary>
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

        /// <summary>Current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time when the operation result was last updated.</summary>
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

    /// <summary>A protocol buffer option, which can be attached to a message, field, enumeration, etc.</summary>
    public class Option : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The option's name. For protobuf built-in options (options defined in descriptor.proto), this is the short
        /// name. For example, "map_entry". For custom options, it should be the fully-qualified name. For example,
        /// "google.api.http".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The option's value packed in an Any message. If the value is a primitive, the corresponding wrapper type
        /// defined in google/protobuf/wrappers.proto should be used. If the value is an enum, it should be stored as an
        /// int32 value using the google.protobuf.Int32Value type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IDictionary<string, object> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A PerformanceThreshold is used when each window is good when that window has a sufficiently high performance.
    /// </summary>
    public class PerformanceThreshold : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BasicSli to evaluate to judge window quality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicSliPerformance")]
        public virtual BasicSli BasicSliPerformance { get; set; }

        /// <summary>RequestBasedSli to evaluate to judge window quality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performance")]
        public virtual RequestBasedSli Performance { get; set; }

        /// <summary>If window performance &gt;= threshold, the window is counted as good.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual System.Nullable<double> Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information involved in sending ICMP pings alongside public HTTP/TCP checks. For HTTP, the pings are performed
    /// for each part of the redirect chain.
    /// </summary>
    public class PingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of ICMP pings. A maximum of 3 ICMP pings is currently supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pingsCount")]
        public virtual System.Nullable<int> PingsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single data point in a time series.</summary>
    public class Point : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time interval to which the data point applies. For GAUGE metrics, the start time is optional, but if it
        /// is supplied, it must equal the end time. For DELTA metrics, the start and end time should specify a non-zero
        /// interval, with subsequent points specifying contiguous and non-overlapping intervals. For CUMULATIVE
        /// metrics, the start and end time should specify a non-zero interval, with subsequent points specifying the
        /// same start time and increasing end times, until an event resets the cumulative value to zero and sets a new
        /// start time for the following points.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual TimeInterval Interval { get; set; }

        /// <summary>The value of the data point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual TypedValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A point's value columns and time interval. Each point has one or more point values corresponding to the entries
    /// in point_descriptors field in the TimeSeriesDescriptor associated with this object.
    /// </summary>
    public class PointData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time interval associated with the point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInterval")]
        public virtual TimeInterval TimeInterval { get; set; }

        /// <summary>The values that make up the point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<TypedValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition type that allows alerting policies to be defined using Prometheus Query Language (PromQL)
    /// (https://prometheus.io/docs/prometheus/latest/querying/basics/).The PrometheusQueryLanguageCondition message
    /// contains information from a Prometheus alerting rule and its associated rule group.A Prometheus alerting rule is
    /// described here (https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/). The semantics of a
    /// Prometheus alerting rule is described here
    /// (https://prometheus.io/docs/prometheus/latest/configuration/recording_rules/#rule).A Prometheus rule group is
    /// described here (https://prometheus.io/docs/prometheus/latest/configuration/recording_rules/). The semantics of a
    /// Prometheus rule group is described here
    /// (https://prometheus.io/docs/prometheus/latest/configuration/recording_rules/#rule_group).Because Cloud Alerting
    /// has no representation of a Prometheus rule group resource, we must embed the information of the parent rule
    /// group inside each of the conditions that refer to it. We must also update the contents of all Prometheus alerts
    /// in case the information of their rule group changes.The PrometheusQueryLanguageCondition protocol buffer
    /// combines the information of the corresponding rule group and alerting rule. The structure of the
    /// PrometheusQueryLanguageCondition protocol buffer does NOT mimic the structure of the Prometheus rule group and
    /// alerting rule YAML declarations. The PrometheusQueryLanguageCondition protocol buffer may change in the future
    /// to support future rule group and/or alerting rule features. There are no new such features at the present time
    /// (2023-06-26).
    /// </summary>
    public class PrometheusQueryLanguageCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The alerting rule name of this alert in the corresponding Prometheus configuration file.Some
        /// external tools may require this field to be populated correctly in order to refer to the original Prometheus
        /// configuration file. The rule group name and the alert name are necessary to update the relevant
        /// AlertPolicies in case the definition of the rule group changes in the future.This field is optional. If this
        /// field is not empty, then it must be a valid Prometheus label name
        /// (https://prometheus.io/docs/concepts/data_model/#metric-names-and-labels). This field may not exceed 2048
        /// Unicode characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertRule")]
        public virtual string AlertRule { get; set; }

        /// <summary>
        /// Optional. Whether to disable metric existence validation for this condition.This allows alerting policies to
        /// be defined on metrics that do not yet exist, improving advanced customer workflows such as configuring
        /// alerting policies using Terraform.Users with the monitoring.alertPolicyViewer role are able to see the name
        /// of the non-existent metric in the alerting policy condition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableMetricValidation")]
        public virtual System.Nullable<bool> DisableMetricValidation { get; set; }

        /// <summary>
        /// Optional. Alerts are considered firing once their PromQL expression was evaluated to be "true" for this
        /// long. Alerts whose PromQL expression was not evaluated to be "true" for long enough are considered pending.
        /// Must be a non-negative duration or missing. This field is optional. Its default value is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// Optional. How often this rule should be evaluated. Must be a positive multiple of 30 seconds or missing.
        /// This field is optional. Its default value is 30 seconds. If this PrometheusQueryLanguageCondition was
        /// generated from a Prometheus alerting rule, then this value should be taken from the enclosing rule group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationInterval")]
        public virtual object EvaluationInterval { get; set; }

        /// <summary>
        /// Optional. Labels to add to or overwrite in the PromQL query result. Label names must be valid
        /// (https://prometheus.io/docs/concepts/data_model/#metric-names-and-labels). Label values can be templatized
        /// by using variables (https://cloud.google.com/monitoring/alerts/doc-variables#doc-vars). The only available
        /// variable names are the names of the labels in the PromQL result, including "__name__" and "value". "labels"
        /// may be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The PromQL expression to evaluate. Every evaluation cycle this expression is evaluated at the
        /// current time, and all resultant time series become pending/firing alerts. This field must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// Optional. The rule group name of this alert in the corresponding Prometheus configuration file.Some external
        /// tools may require this field to be populated correctly in order to refer to the original Prometheus
        /// configuration file. The rule group name and the alert name are necessary to update the relevant
        /// AlertPolicies in case the definition of the rule group changes in the future.This field is optional. If this
        /// field is not empty, then it must contain a valid UTF-8 string. This field may not exceed 2048 Unicode
        /// characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleGroup")]
        public virtual string RuleGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The QueryTimeSeries request. For information about the status of Monitoring Query Language (MQL), see the MQL
    /// deprecation notice (https://cloud.google.com/stackdriver/docs/deprecations/mql).
    /// </summary>
    public class QueryTimeSeriesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A positive number that is the maximum number of time_series_data to return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// If this field is not empty then it must contain the nextPageToken value returned by a previous call to this
        /// method. Using this field causes the method to return additional results from the previous method call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. The query in the Monitoring Query Language (https://cloud.google.com/monitoring/mql/reference)
        /// format. The default time zone is in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The QueryTimeSeries response. For information about the status of Monitoring Query Language (MQL), see the MQL
    /// deprecation notice (https://cloud.google.com/stackdriver/docs/deprecations/mql).
    /// </summary>
    public class QueryTimeSeriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// Query execution errors that may have caused the time series data returned to be incomplete. The available
        /// data will be available in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialErrors")]
        public virtual System.Collections.Generic.IList<Status> PartialErrors { get; set; }

        /// <summary>The time series data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesData")]
        public virtual System.Collections.Generic.IList<TimeSeriesData> TimeSeriesData { get; set; }

        /// <summary>The descriptor for the time series data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesDescriptor")]
        public virtual TimeSeriesDescriptor TimeSeriesDescriptor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The range of the population values.</summary>
    public class Range : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum of the population values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<double> Max { get; set; }

        /// <summary>The minimum of the population values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<double> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Service Level Indicators for which atomic units of service are counted directly.</summary>
    public class RequestBasedSli : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// distribution_cut is used when good_service is a count of values aggregated in a Distribution that fall into
        /// a good range. The total_service is the total count of all values aggregated in the Distribution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributionCut")]
        public virtual DistributionCut DistributionCut { get; set; }

        /// <summary>
        /// good_total_ratio is used when the ratio of good_service to total_service is computed from two TimeSeries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goodTotalRatio")]
        public virtual TimeSeriesRatio GoodTotalRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The resource submessage for group checks. It can be used instead of a monitored resource, when multiple
    /// resources are being monitored.
    /// </summary>
    public class ResourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The group of resources being monitored. Should be only the [GROUP_ID], and not the full-path
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>The resource type of the group members.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A status to accept. Either a status code class like "2xx", or an integer status code like "200".
    /// </summary>
    public class ResponseStatusCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A class of status codes to accept.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusClass")]
        public virtual string StatusClass { get; set; }

        /// <summary>A status code to accept.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusValue")]
        public virtual System.Nullable<int> StatusValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A test that checks if the number of rows in the result set violates some threshold.</summary>
    public class RowCountTest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The comparison to apply between the number of rows returned by the query and the threshold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comparison")]
        public virtual string Comparison { get; set; }

        /// <summary>Required. The value against which to compare the row count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual System.Nullable<long> Threshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The SendNotificationChannelVerificationCode request.</summary>
    public class SendNotificationChannelVerificationCodeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Service is a discrete, autonomous, and network-accessible unit, designed to solve an individual concern
    /// (Wikipedia (https://en.wikipedia.org/wiki/Service-orientation)). In Cloud Monitoring, a Service acts as the root
    /// resource under which operational aspects of the service are accessible.
    /// </summary>
    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type used for App Engine services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngine")]
        public virtual AppEngine AppEngine { get; set; }

        /// <summary>
        /// Message that contains the service type and service labels of this service if it is a basic service.
        /// Documentation and examples here
        /// (https://cloud.google.com/stackdriver/docs/solutions/slo-monitoring/api/api-structures#basic-svc-w-basic-sli).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicService")]
        public virtual BasicService BasicService { get; set; }

        /// <summary>Type used for Cloud Endpoints services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudEndpoints")]
        public virtual CloudEndpoints CloudEndpoints { get; set; }

        /// <summary>Type used for Cloud Run services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudRun")]
        public virtual CloudRun CloudRun { get; set; }

        /// <summary>Type used for Istio services that live in a Kubernetes cluster.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterIstio")]
        public virtual ClusterIstio ClusterIstio { get; set; }

        /// <summary>Custom service type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual Custom Custom { get; set; }

        /// <summary>Name used for UI elements listing this Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Type used for GKE Namespaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeNamespace")]
        public virtual GkeNamespace GkeNamespace { get; set; }

        /// <summary>Type used for GKE Services (the Kubernetes concept of a service).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeService")]
        public virtual GkeService GkeService { get; set; }

        /// <summary>Type used for GKE Workloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gkeWorkload")]
        public virtual GkeWorkload GkeWorkload { get; set; }

        /// <summary>
        /// Type used for canonical services scoped to an Istio mesh. Metrics for Istio are documented here
        /// (https://istio.io/latest/docs/reference/config/metrics/)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("istioCanonicalService")]
        public virtual IstioCanonicalService IstioCanonicalService { get; set; }

        /// <summary>Type used for Istio services scoped to an Istio mesh.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meshIstio")]
        public virtual MeshIstio MeshIstio { get; set; }

        /// <summary>
        /// Identifier. Resource name for this Service. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Configuration for how to query telemetry on a Service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("telemetry")]
        public virtual Telemetry Telemetry { get; set; }

        /// <summary>
        /// Labels which have been used to annotate the service. Label keys must start with a letter. Label keys and
        /// values may contain lowercase letters, numbers, underscores, and dashes. Label keys and values have a maximum
        /// length of 63 characters, and must be less than 128 bytes in size. Up to 64 label entries may be stored. For
        /// labels which do not have a semantic value, the empty string may be supplied for the label value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information needed for generating either an OpenID Connect token
    /// (https://developers.google.com/identity/protocols/OpenIDConnect) or OAuth token
    /// (https://developers.google.com/identity/protocols/oauth2). The token will be generated for the Monitoring
    /// service agent service account.
    /// </summary>
    public class ServiceAgentAuthentication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Service-Level Indicator (SLI) describes the "performance" of a service. For some services, the SLI is
    /// well-defined. In such cases, the SLI can be described easily by referencing the well-known SLI and providing the
    /// needed parameters. Alternatively, a "custom" SLI can be defined with a query to the underlying metric store. An
    /// SLI is defined to be good_service / total_service over any queried time interval. The value of performance
    /// always falls into the range 0 &amp;lt;= performance &amp;lt;= 1. A custom SLI describes how to compute this
    /// ratio, whether this is by dividing values from a pair of time series, cutting a Distribution into good and bad
    /// counts, or counting time windows in which the service complies with a criterion. For separation of concerns, a
    /// single Service-Level Indicator measures performance for only one aspect of service quality, such as fraction of
    /// successful queries or fast-enough queries.
    /// </summary>
    public class ServiceLevelIndicator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Basic SLI on a well-known service type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicSli")]
        public virtual BasicSli BasicSli { get; set; }

        /// <summary>Request-based SLIs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestBased")]
        public virtual RequestBasedSli RequestBased { get; set; }

        /// <summary>Windows-based SLIs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsBased")]
        public virtual WindowsBasedSli WindowsBased { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Service-Level Objective (SLO) describes a level of desired good service. It consists of a service-level
    /// indicator (SLI), a performance goal, and a period over which the objective is to be evaluated against that goal.
    /// The SLO can use SLIs defined in a number of different manners. Typical SLOs might include "99% of requests in
    /// each rolling week have latency below 200 milliseconds" or "99.5% of requests in each calendar month return
    /// successfully."
    /// </summary>
    public class ServiceLevelObjective : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A calendar period, semantically "since the start of the current ". At this time, only DAY, WEEK, FORTNIGHT,
        /// and MONTH are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calendarPeriod")]
        public virtual string CalendarPeriod { get; set; }

        /// <summary>Name used for UI elements listing this SLO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The fraction of service that must be good in order for this objective to be met. 0 &amp;lt; goal &amp;lt;=
        /// 0.9999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goal")]
        public virtual System.Nullable<double> Goal { get; set; }

        /// <summary>
        /// Identifier. Resource name for this ServiceLevelObjective. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A rolling time period, semantically "in the past ". Must be an integer multiple of 1 day no larger than 30
        /// days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollingPeriod")]
        public virtual object RollingPeriod { get; set; }

        /// <summary>
        /// The definition of good service, used to measure and calculate the quality of the Service's performance with
        /// respect to a single aspect of service quality.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceLevelIndicator")]
        public virtual ServiceLevelIndicator ServiceLevelIndicator { get; set; }

        /// <summary>
        /// Labels which have been used to annotate the service-level objective. Label keys must start with a letter.
        /// Label keys and values may contain lowercase letters, numbers, underscores, and dashes. Label keys and values
        /// have a maximum length of 63 characters, and must be less than 128 bytes in size. Up to 64 label entries may
        /// be stored. For labels which do not have a semantic value, the empty string may be supplied for the label
        /// value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Snooze will prevent any alerts from being opened, and close any that are already open. The Snooze will work on
    /// alerts that match the criteria defined in the Snooze. The Snooze will be active from interval.start_time through
    /// interval.end_time.
    /// </summary>
    public class Snooze : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. This defines the criteria for applying the Snooze. See Criteria for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criteria")]
        public virtual Criteria Criteria { get; set; }

        /// <summary>Required. A display name for the Snooze. This can be, at most, 512 unicode characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. The Snooze will be active from interval.start_time through interval.end_time. interval.start_time
        /// cannot be in the past. There is a 15 second clock skew to account for the time it takes for a request to
        /// reach the API from the UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual TimeInterval Interval { get; set; }

        /// <summary>
        /// Required. Identifier. The name of the Snooze. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID] The ID of the Snooze will be generated by the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SourceContext represents information about the source of a protobuf element, like the file in which it is
    /// defined.
    /// </summary>
    public class SourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The path-qualified name of the .proto file that contained the associated protobuf element. For example:
        /// "google/protobuf/source_context.proto".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The context of a span. This is attached to an Exemplar in Distribution values during aggregation.It contains the
    /// name of a span with format: projects/[PROJECT_ID_OR_NUMBER]/traces/[TRACE_ID]/spans/[SPAN_ID]
    /// </summary>
    public class SpanContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the span. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/traces/[TRACE_ID]/spans/[SPAN_ID] [TRACE_ID] is a unique identifier for a
        /// trace within a project; it is a 32-character hexadecimal encoding of a 16-byte array.[SPAN_ID] is a unique
        /// identifier for a span within a trace; it is a 16-character hexadecimal encoding of an 8-byte array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanName")]
        public virtual string SpanName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition that allows alerting policies to be defined using GoogleSQL. SQL conditions examine a sliding window
    /// of logs using GoogleSQL. Alert policies with SQL conditions may incur additional billing.
    /// </summary>
    public class SqlCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Test the boolean value in the indicated column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanTest")]
        public virtual BooleanTest BooleanTest { get; set; }

        /// <summary>Schedule the query to execute every so many days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daily")]
        public virtual Daily Daily { get; set; }

        /// <summary>Schedule the query to execute every so many hours.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hourly")]
        public virtual Hourly Hourly { get; set; }

        /// <summary>Schedule the query to execute every so many minutes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual Minutes Minutes { get; set; }

        /// <summary>
        /// Required. The Log Analytics SQL query to run, as a string. The query must conform to the required shape.
        /// Specifically, the query must not try to filter the input by time. A filter will automatically be applied to
        /// filter the input so that the query receives all rows received since the last time the query was run.For
        /// example, the following query extracts all log entries containing an HTTP request: SELECT timestamp,
        /// log_name, severity, http_request, resource, labels FROM my-project.global._Default._AllLogs WHERE
        /// http_request IS NOT NULL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>Test the row count against a threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCountTest")]
        public virtual RowCountTest RowCountTest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Status type defines a logical error model that is suitable for different programming environments, including
    /// REST APIs and RPC APIs. It is used by gRPC (https://github.com/grpc). Each Status message contains three pieces
    /// of data: error code, error message, and error details.You can find out more about this error model and how to
    /// work with it in the API Design Guide (https://cloud.google.com/apis/design/errors).
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

    /// <summary>Describes a Synthetic Monitor to be invoked by Uptime.</summary>
    public class SyntheticMonitorTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target a Synthetic Monitor GCFv2 instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudFunctionV2")]
        public virtual CloudFunctionV2Target CloudFunctionV2 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information required for a TCP Uptime check request.</summary>
    public class TcpCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains information needed to add pings to a TCP check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pingConfig")]
        public virtual PingConfig PingConfig { get; set; }

        /// <summary>
        /// The TCP port on the server against which to run the check. Will be combined with host (specified within the
        /// monitored_resource) to construct the full URL. Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for how to query telemetry on a Service.</summary>
    public class Telemetry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The full name of the resource that defines this service. Formatted as described in
        /// https://cloud.google.com/apis/design/resource_names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a time interval: Reads: A half-open time interval. It includes the end time but excludes the start
    /// time: (startTime, endTime]. The start time must be specified, must be earlier than the end time, and should be
    /// no older than the data retention period for the metric. Writes: A closed time interval. It extends from the
    /// start time to the end time, and includes both: [startTime, endTime]. Valid time intervals depend on the
    /// MetricKind (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors#MetricKind) of the
    /// metric value. The end time must not be earlier than the start time, and the end time must not be more than 25
    /// hours in the past or more than five minutes in the future. For GAUGE metrics, the startTime value is technically
    /// optional; if no value is specified, the start time defaults to the value of the end time, and the interval
    /// represents a single point in time. If both start and end times are specified, they must be identical. Such an
    /// interval is valid only for GAUGE metrics, which are point-in-time measurements. The end time of a new interval
    /// must be at least a millisecond after the end time of the previous interval. For DELTA metrics, the start time
    /// and end time must specify a non-zero interval, with subsequent points specifying contiguous and non-overlapping
    /// intervals. For DELTA metrics, the start time of the next interval must be at least a millisecond after the end
    /// time of the previous interval. For CUMULATIVE metrics, the start time and end time must specify a non-zero
    /// interval, with subsequent points specifying the same start time and increasing end times, until an event resets
    /// the cumulative value to zero and sets a new start time for the following points. The new start time must be at
    /// least a millisecond after the end time of the previous interval. The start time of a new interval must be at
    /// least a millisecond after the end time of the previous interval because intervals are closed. If the start time
    /// of a new interval is the same as the end time of the previous interval, then data written at the new start time
    /// could overwrite data written at the previous end time.
    /// </summary>
    public class TimeInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Required. The end of the time interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. The beginning of the time interval. The default value for the start time is the end time. The
        /// start time must not be later than the end time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and google.protobuf.Timestamp.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or
        /// equal to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to
        /// 999,999,999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An
        /// API may allow the value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of data points that describes the time-varying values of a metric. A time series is identified by a
    /// combination of a fully-specified monitored resource and a fully-specified metric. This type is used for both
    /// listing and creating time series.
    /// </summary>
    public class TimeSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. A detailed description of the time series that will be associated with the
        /// google.api.MetricDescriptor for the metric. Once set, this field cannot be changed through CreateTimeSeries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The associated monitored resource metadata. When reading a time series, this field will include
        /// metadata labels that are explicitly named in the reduction. When creating a time series, this field is
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual MonitoredResourceMetadata Metadata { get; set; }

        /// <summary>The associated metric. A fully-specified metric used to identify the time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual Metric Metric { get; set; }

        /// <summary>
        /// The metric kind of the time series. When listing time series, this metric kind might be different from the
        /// metric kind of the associated metric if this time series is an alignment or reduction of other time
        /// series.When creating a time series, this field is optional. If present, it must be the same as the metric
        /// kind of the associated metric. If the associated metric's descriptor must be auto-created, then this field
        /// specifies the metric kind of the new descriptor and must be either GAUGE (the default) or CUMULATIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricKind")]
        public virtual string MetricKind { get; set; }

        /// <summary>
        /// The data points of this time series. When listing time series, points are returned in reverse time
        /// order.When creating a time series, this field must contain exactly one point and the point's type must be
        /// the same as the value type of the associated metric. If the associated metric's descriptor must be
        /// auto-created, then the value type of the descriptor is determined by the point's type, which must be BOOL,
        /// INT64, DOUBLE, or DISTRIBUTION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("points")]
        public virtual System.Collections.Generic.IList<Point> Points { get; set; }

        /// <summary>
        /// The associated monitored resource. Custom metrics can use only certain monitored resource types in their
        /// time series data. For more information, see Monitored resources for custom metrics
        /// (https://cloud.google.com/monitoring/custom-metrics/creating-metrics#custom-metric-resources).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual MonitoredResource Resource { get; set; }

        /// <summary>
        /// The units in which the metric value is reported. It is only applicable if the value_type is INT64, DOUBLE,
        /// or DISTRIBUTION. The unit defines the representation of the stored metric values. This field can only be
        /// changed through CreateTimeSeries when it is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>
        /// The value type of the time series. When listing time series, this value type might be different from the
        /// value type of the associated metric if this time series is an alignment or reduction of other time
        /// series.When creating a time series, this field is optional. If present, it must be the same as the type of
        /// the data in the points field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the values of a time series associated with a TimeSeriesDescriptor.</summary>
    public class TimeSeriesData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The values of the labels in the time series identifier, given in the same order as the label_descriptors
        /// field of the TimeSeriesDescriptor associated with this object. Each value must have a value of the type
        /// given in the corresponding entry of label_descriptors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelValues")]
        public virtual System.Collections.Generic.IList<LabelValue> LabelValues { get; set; }

        /// <summary>The points in the time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointData")]
        public virtual System.Collections.Generic.IList<PointData> PointData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A descriptor for the labels and points in a time series.</summary>
    public class TimeSeriesDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Descriptors for the labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelDescriptors")]
        public virtual System.Collections.Generic.IList<LabelDescriptor> LabelDescriptors { get; set; }

        /// <summary>Descriptors for the point data value columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointDescriptors")]
        public virtual System.Collections.Generic.IList<ValueDescriptor> PointDescriptors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A TimeSeriesRatio specifies two TimeSeries to use for computing the good_service / total_service ratio. The
    /// specified TimeSeries must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or
    /// MetricKind = CUMULATIVE. The TimeSeriesRatio must specify exactly two of good, bad, and total, and the
    /// relationship good_service + bad_service = total_service will be assumed.
    /// </summary>
    public class TimeSeriesRatio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) specifying a TimeSeries quantifying
        /// bad service, either demanded service that was not provided or demanded service that was of inadequate
        /// quality. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or MetricKind =
        /// CUMULATIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("badServiceFilter")]
        public virtual string BadServiceFilter { get; set; }

        /// <summary>
        /// A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) specifying a TimeSeries quantifying
        /// good service provided. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA or
        /// MetricKind = CUMULATIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goodServiceFilter")]
        public virtual string GoodServiceFilter { get; set; }

        /// <summary>
        /// A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) specifying a TimeSeries quantifying
        /// total demanded service. Must have ValueType = DOUBLE or ValueType = INT64 and must have MetricKind = DELTA
        /// or MetricKind = CUMULATIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalServiceFilter")]
        public virtual string TotalServiceFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies how many time series must fail a predicate to trigger a condition. If not specified, then a {count: 1}
    /// trigger is used.
    /// </summary>
    public class Trigger : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The absolute number of time series that must fail the predicate for the condition to be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>
        /// The percentage of time series that must fail the predicate for the condition to be triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<double> Percent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A protocol buffer message type.</summary>
    public class Type : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source edition string, only valid when syntax is SYNTAX_EDITIONS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>The list of fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<Field> Fields { get; set; }

        /// <summary>The fully qualified message name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The list of types appearing in oneof definitions in this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneofs")]
        public virtual System.Collections.Generic.IList<string> Oneofs { get; set; }

        /// <summary>The protocol buffer options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>The source context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceContext")]
        public virtual SourceContext SourceContext { get; set; }

        /// <summary>The source syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntax")]
        public virtual string Syntax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single strongly-typed value.</summary>
    public class TypedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A Boolean value: true or false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>A distribution value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributionValue")]
        public virtual Distribution DistributionValue { get; set; }

        /// <summary>
        /// A 64-bit double-precision floating-point number. Its magnitude is approximately ±10±300 and it has 16
        /// significant digits of precision.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>A 64-bit integer. Its range is approximately ±9.2x1018.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>A variable-length string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This message configures which resources and services to monitor for availability.</summary>
    public class UptimeCheckConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of checkers to use to execute the Uptime check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkerType")]
        public virtual string CheckerType { get; set; }

        /// <summary>
        /// The content that is expected to appear in the data returned by the target server against which the check is
        /// run. Currently, only the first entry in the content_matchers list is supported, and additional entries will
        /// be ignored. This field is optional and should only be specified if a content match is required as part of
        /// the/ Uptime check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentMatchers")]
        public virtual System.Collections.Generic.IList<ContentMatcher> ContentMatchers { get; set; }

        /// <summary>Whether the check is disabled or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// A human-friendly name for the Uptime check configuration. The display name should be unique within a Cloud
        /// Monitoring Workspace in order to make it easier to identify; however, uniqueness is not enforced. Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Contains information needed to make an HTTP or HTTPS check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpCheck")]
        public virtual HttpCheck HttpCheck { get; set; }

        /// <summary>
        /// The internal checkers that this check will egress from. If is_internal is true and this list is empty, the
        /// check will egress from all the InternalCheckers configured for the project that owns this UptimeCheckConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalCheckers")]
        public virtual System.Collections.Generic.IList<InternalChecker> InternalCheckers { get; set; }

        /// <summary>
        /// If this is true, then checks are made only from the 'internal_checkers'. If it is false, then checks are
        /// made only from the 'selected_regions'. It is an error to provide 'selected_regions' when is_internal is
        /// true, or to provide 'internal_checkers' when is_internal is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInternal")]
        public virtual System.Nullable<bool> IsInternal { get; set; }

        /// <summary>To specify whether to log the results of failed probes to Cloud Logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logCheckFailures")]
        public virtual System.Nullable<bool> LogCheckFailures { get; set; }

        /// <summary>
        /// The monitored resource (https://cloud.google.com/monitoring/api/resources) associated with the
        /// configuration. The following monitored resource types are valid for this field: uptime_url, gce_instance,
        /// gae_app, aws_ec2_instance, aws_elb_load_balancer k8s_service servicedirectory_service cloud_run_revision
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResource")]
        public virtual MonitoredResource MonitoredResource { get; set; }

        /// <summary>
        /// Identifier. A unique resource name for this Uptime check configuration. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID] [PROJECT_ID_OR_NUMBER] is the Workspace
        /// host project associated with the Uptime check.This field should be omitted when creating the Uptime check
        /// configuration; on create, the resource name is assigned by the server and included in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// How often, in seconds, the Uptime check is performed. Currently, the only supported values are 60s (1
        /// minute), 300s (5 minutes), 600s (10 minutes), and 900s (15 minutes). Optional, defaults to 60s.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual object Period { get; set; }

        /// <summary>The group resource associated with the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroup")]
        public virtual ResourceGroup ResourceGroup { get; set; }

        /// <summary>
        /// The list of regions from which the check will be run. Some regions contain one location, and others contain
        /// more than one. If this field is specified, enough regions must be provided to include a minimum of 3
        /// locations. Not specifying this field will result in Uptime checks running from all available regions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedRegions")]
        public virtual System.Collections.Generic.IList<string> SelectedRegions { get; set; }

        /// <summary>Specifies a Synthetic Monitor to invoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntheticMonitor")]
        public virtual SyntheticMonitorTarget SyntheticMonitor { get; set; }

        /// <summary>Contains information needed to make a TCP check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcpCheck")]
        public virtual TcpCheck TcpCheck { get; set; }

        /// <summary>
        /// The maximum amount of time to wait for the request to complete (must be between 1 and 60 seconds). Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>
        /// User-supplied key/value data to be used for organizing and identifying the UptimeCheckConfig objects.The
        /// field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes,
        /// whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and
        /// dashes. Keys must begin with a letter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the region, location, and list of IP addresses where checkers in the location run from.
    /// </summary>
    public class UptimeCheckIp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The IP address from which the Uptime check originates. This is a fully specified IP address (not an IP
        /// address range). Most IP addresses, as of this publication, are in IPv4 format; however, one should not rely
        /// on the IP addresses being in IPv4 format indefinitely, and should support interpreting this field in either
        /// IPv4 or IPv6 format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// A more specific location within the region that typically encodes a particular city/town/metro (and its
        /// containing state/province or country) within the broader umbrella region category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>A broad region category in which the IP address is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A descriptor for the value columns in a data point.</summary>
    public class ValueDescriptor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The value stream kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricKind")]
        public virtual string MetricKind { get; set; }

        /// <summary>
        /// The unit in which time_series point values are reported. unit follows the UCUM format for units as seen in
        /// https://unitsofmeasure.org/ucum.html. unit is only valid if value_type is INTEGER, DOUBLE, DISTRIBUTION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unit")]
        public virtual string Unit { get; set; }

        /// <summary>The value type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueType")]
        public virtual string ValueType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The VerifyNotificationChannel request.</summary>
    public class VerifyNotificationChannelRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The verification code that was delivered to the channel as a result of invoking the
        /// SendNotificationChannelVerificationCode API method or that was retrieved from a verified channel via
        /// GetNotificationChannelVerificationCode. For example, one might have "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv"
        /// (in general, one is only guaranteed that the code is valid UTF-8; one should not make any assumptions
        /// regarding the structure or format of the code).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A WindowsBasedSli defines good_service as the count of time windows for which the provided service was of good
    /// quality. Criteria for determining if service was good are embedded in the window_criterion.
    /// </summary>
    public class WindowsBasedSli : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) specifying a TimeSeries with
        /// ValueType = BOOL. The window is good if any true values appear in the window.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goodBadMetricFilter")]
        public virtual string GoodBadMetricFilter { get; set; }

        /// <summary>A window is good if its performance is high enough.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goodTotalRatioThreshold")]
        public virtual PerformanceThreshold GoodTotalRatioThreshold { get; set; }

        /// <summary>
        /// A window is good if the metric's value is in a good range, averaged across returned streams.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricMeanInRange")]
        public virtual MetricRange MetricMeanInRange { get; set; }

        /// <summary>
        /// A window is good if the metric's value is in a good range, summed across returned streams.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricSumInRange")]
        public virtual MetricRange MetricSumInRange { get; set; }

        /// <summary>
        /// Duration over which window quality is evaluated. Must be an integer fraction of a day and at least 60s.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowPeriod")]
        public virtual object WindowPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
