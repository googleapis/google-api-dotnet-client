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

namespace Google.Apis.ChromeUXReport.v1
{
    /// <summary>The ChromeUXReport Service.</summary>
    public class ChromeUXReportService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ChromeUXReportService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ChromeUXReportService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Records = new RecordsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "chromeuxreport";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://chromeuxreport.googleapis.com/";
        #else
            "https://chromeuxreport.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://chromeuxreport.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Records resource.</summary>
        public virtual RecordsResource Records { get; }
    }

    /// <summary>A base abstract class for ChromeUXReport requests.</summary>
    public abstract class ChromeUXReportBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ChromeUXReportBaseServiceRequest instance.</summary>
        protected ChromeUXReportBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ChromeUXReport parameter list.</summary>
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

    /// <summary>The "records" collection of methods.</summary>
    public class RecordsResource
    {
        private const string Resource = "records";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RecordsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Queries the Chrome User Experience for a single `record` for a given site. Returns a `record` that contains
        /// one or more `metrics` corresponding to performance data about the requested site.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryRecordRequest QueryRecord(Google.Apis.ChromeUXReport.v1.Data.QueryRequest body)
        {
            return new QueryRecordRequest(service, body);
        }

        /// <summary>
        /// Queries the Chrome User Experience for a single `record` for a given site. Returns a `record` that contains
        /// one or more `metrics` corresponding to performance data about the requested site.
        /// </summary>
        public class QueryRecordRequest : ChromeUXReportBaseServiceRequest<Google.Apis.ChromeUXReport.v1.Data.QueryResponse>
        {
            /// <summary>Constructs a new QueryRecord request.</summary>
            public QueryRecordRequest(Google.Apis.Services.IClientService service, Google.Apis.ChromeUXReport.v1.Data.QueryRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ChromeUXReport.v1.Data.QueryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryRecord";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/records:queryRecord";

            /// <summary>Initializes QueryRecord parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.ChromeUXReport.v1.Data
{
    /// <summary>
    /// A bin is a discrete portion of data spanning from start to end, or if no end is given, then from start to +inf.
    /// A bin's start and end values are given in the value type of the metric it represents. For example, "first
    /// contentful paint" is measured in milliseconds and exposed as ints, therefore its metric bins will use int32s for
    /// its start and end types. However, "cumulative layout shift" is measured in unitless decimals and is exposed as a
    /// decimal encoded as a string, therefore its metric bins will use strings for its value type.
    /// </summary>
    public class Bin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The proportion of users that experienced this bin's value for the given metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("density")]
        public virtual System.Nullable<double> Density { get; set; }

        /// <summary>
        /// End is the end of the data bin. If end is not populated, then the bin has no end and is valid from start to
        /// +inf.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual object End { get; set; }

        /// <summary>Start is the beginning of the data bin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual object Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Key defines all the dimensions that identify this record as unique.</summary>
    public class Key : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The effective connection type is the general connection class that all users experienced for this record.
        /// This field uses the values ["offline", "slow-2G", "2G", "3G", "4G"] as specified in:
        /// https://wicg.github.io/netinfo/#effective-connection-types If the effective connection type is unspecified,
        /// then aggregated data over all effective connection types will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveConnectionType")]
        public virtual string EffectiveConnectionType { get; set; }

        /// <summary>
        /// The form factor is the device class that all users used to access the site for this record. If the form
        /// factor is unspecified, then aggregated data over all form factors will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>
        /// Origin specifies the origin that this record is for. Note: When specifying an origin, data for loads under
        /// this origin over all pages are aggregated into origin level user experience data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>
        /// Url specifies a specific url that this record is for. Note: When specifying a "url" only data for that
        /// specific url will be aggregated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A `metric` is a set of user experience data for a single web performance metric, like "first contentful paint".
    /// It contains a summary histogram of real world Chrome usage as a series of `bins`.
    /// </summary>
    public class Metric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The histogram of user experiences for a metric. The histogram will have at least one bin and the densities
        /// of all bins will add up to ~1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogram")]
        public virtual System.Collections.Generic.IList<Bin> Histogram { get; set; }

        /// <summary>
        /// Common useful percentiles of the Metric. The value type for the percentiles will be the same as the value
        /// types given for the Histogram bins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentiles")]
        public virtual Percentiles Percentiles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Percentiles contains synthetic values of a metric at a given statistical percentile. These are used for
    /// estimating a metric's value as experienced by a percentage of users out of the total number of users.
    /// </summary>
    public class Percentiles : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>75% of users experienced the given metric at or below this value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p75")]
        public virtual object P75 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request payload sent by a physical web client. This request includes all necessary context to load a particular
    /// user experience record.
    /// </summary>
    public class QueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The effective connection type is a query dimension that specifies the effective network class that the
        /// record's data should belong to. This field uses the values ["offline", "slow-2G", "2G", "3G", "4G"] as
        /// specified in: https://wicg.github.io/netinfo/#effective-connection-types Note: If no effective connection
        /// type is specified, then a special record with aggregated data over all effective connection types will be
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveConnectionType")]
        public virtual string EffectiveConnectionType { get; set; }

        /// <summary>
        /// The form factor is a query dimension that specifies the device class that the record's data should belong
        /// to. Note: If no form factor is specified, then a special record with aggregated data over all form factors
        /// will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>
        /// The metrics that should be included in the response. If none are specified then any metrics found will be
        /// returned. Allowed values: ["first_contentful_paint", "first_input_delay", "largest_contentful_paint",
        /// "cumulative_layout_shift", "experimental_uncapped_cumulative_layout_shift"]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// The url pattern "origin" refers to a url pattern that is the origin of a website. Examples:
        /// "https://example.com", "https://cloud.google.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

        /// <summary>
        /// The url pattern "url" refers to a url pattern that is any arbitrary url. Examples: "https://example.com/",
        /// "https://cloud.google.com/why-google-cloud/"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response payload sent back to a physical web client. This response contains the record found based on the
    /// identiers present in a `QueryRequest`. The returned response will have a record, and sometimes details on
    /// normalization actions taken on the request that were necessary to make the request successful.
    /// </summary>
    public class QueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The record that was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("record")]
        public virtual Record Record { get; set; }

        /// <summary>
        /// These are details about automated normalization actions that were taken in order to make the requested
        /// `url_pattern` valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlNormalizationDetails")]
        public virtual UrlNormalization UrlNormalizationDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Record is a single Chrome UX report data record. It contains use experience statistics for a single url pattern
    /// and set of dimensions.
    /// </summary>
    public class Record : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Key defines all of the unique querying parameters needed to look up a user experience record.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual Key Key { get; set; }

        /// <summary>
        /// Metrics is the map of user experience data available for the record defined in the key field. Metrics are
        /// keyed on the metric name. Allowed key values: ["first_contentful_paint", "first_input_delay",
        /// "largest_contentful_paint", "cumulative_layout_shift"]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IDictionary<string, Metric> Metrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Object representing the normalization actions taken to normalize a url to achieve a higher chance of successful
    /// lookup. These are simple automated changes that are taken when looking up the provided `url_patten` would be
    /// known to fail. Complex actions like following redirects are not handled.
    /// </summary>
    public class UrlNormalization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The URL after any normalization actions. This is a valid user experience URL that could reasonably be looked
        /// up.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedUrl")]
        public virtual string NormalizedUrl { get; set; }

        /// <summary>The original requested URL prior to any normalization actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalUrl")]
        public virtual string OriginalUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
