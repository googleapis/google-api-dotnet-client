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

namespace Google.Apis.Playdeveloperreporting.v1beta1
{
    /// <summary>The Playdeveloperreporting Service.</summary>
    public class PlaydeveloperreportingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PlaydeveloperreportingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PlaydeveloperreportingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Anomalies = new AnomaliesResource(this);
            Vitals = new VitalsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "playdeveloperreporting";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://playdeveloperreporting.googleapis.com/";
        #else
            "https://playdeveloperreporting.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://playdeveloperreporting.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Gets the Anomalies resource.</summary>
        public virtual AnomaliesResource Anomalies { get; }

        /// <summary>Gets the Vitals resource.</summary>
        public virtual VitalsResource Vitals { get; }
    }

    /// <summary>A base abstract class for Playdeveloperreporting requests.</summary>
    public abstract class PlaydeveloperreportingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PlaydeveloperreportingBaseServiceRequest instance.</summary>
        protected PlaydeveloperreportingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Playdeveloperreporting parameter list.</summary>
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

    /// <summary>The "anomalies" collection of methods.</summary>
    public class AnomaliesResource
    {
        private const string Resource = "anomalies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AnomaliesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists anomalies in any of the datasets.</summary>
        /// <param name="parent">Required. Parent app for which anomalies were detected. Format: apps/{app}</param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>Lists anomalies in any of the datasets.</summary>
        public class ListRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1ListAnomaliesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>Required. Parent app for which anomalies were detected. Format: apps/{app}</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Filtering criteria for anomalies. For basic filter guidance, please check: https://google.aip.dev/160.
            /// **Supported functions:** * `activeBetween(startTime, endTime)`: If specified, only list anomalies that
            /// were active in between `startTime` (inclusive) and `endTime` (exclusive). Both parameters are expected
            /// to conform to an RFC-3339 formatted string (e.g. `2012-04-21T11:30:00-04:00`). UTC offsets are
            /// supported. Both `startTime` and `endTime` accept the special value `UNBOUNDED`, to signify intervals
            /// with no lower or upper bound, respectively. Examples: * `activeBetween("2021-04-21T11:30:00Z",
            /// "2021-07-21T00:00:00Z")` * `activeBetween(UNBOUNDED, "2021-11-21T00:00:00-04:00")` *
            /// `activeBetween("2021-07-21T00:00:00-04:00", UNBOUNDED)`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Maximum size of the returned data. If unspecified, at most 10 anomalies will be returned. The maximum
            /// value is 100; values above 100 will be coerced to 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `ListErrorReports` call. Provide this to retrieve the subsequent
            /// page. When paginating, all other parameters provided to `ListErrorReports` must match the call that
            /// provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+parent}/anomalies";

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
                    Pattern = @"^apps/[^/]+$",
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

    /// <summary>The "vitals" collection of methods.</summary>
    public class VitalsResource
    {
        private const string Resource = "vitals";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VitalsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Anrrate = new AnrrateResource(service);
            Crashrate = new CrashrateResource(service);
            Excessivewakeuprate = new ExcessivewakeuprateResource(service);
            Stuckbackgroundwakelockrate = new StuckbackgroundwakelockrateResource(service);
        }

        /// <summary>Gets the Anrrate resource.</summary>
        public virtual AnrrateResource Anrrate { get; }

        /// <summary>The "anrrate" collection of methods.</summary>
        public class AnrrateResource
        {
            private const string Resource = "anrrate";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AnrrateResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Describes the properties of the metric set.</summary>
            /// <param name="name">Required. The resource name. Format: apps/{app}/anrRateMetricSet</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1AnrRateMetricSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/anrRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^apps/[^/]+/anrRateMetricSet$",
                    });
                }
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name. Format: apps/{app}/anrRateMetricSet</param>
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryAnrRateMetricSetRequest body, string name)
            {
                return new QueryRequest(service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryAnrRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryAnrRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/anrRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryAnrRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:query";

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
                        Pattern = @"^apps/[^/]+/anrRateMetricSet$",
                    });
                }
            }
        }

        /// <summary>Gets the Crashrate resource.</summary>
        public virtual CrashrateResource Crashrate { get; }

        /// <summary>The "crashrate" collection of methods.</summary>
        public class CrashrateResource
        {
            private const string Resource = "crashrate";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CrashrateResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Describes the properties of the metric set.</summary>
            /// <param name="name">Required. The resource name. Format: apps/{app}/crashRateMetricSet</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1CrashRateMetricSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/crashRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^apps/[^/]+/crashRateMetricSet$",
                    });
                }
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name. Format: apps/{app}/crashRateMetricSet</param>
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryCrashRateMetricSetRequest body, string name)
            {
                return new QueryRequest(service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryCrashRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryCrashRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/crashRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryCrashRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:query";

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
                        Pattern = @"^apps/[^/]+/crashRateMetricSet$",
                    });
                }
            }
        }

        /// <summary>Gets the Excessivewakeuprate resource.</summary>
        public virtual ExcessivewakeuprateResource Excessivewakeuprate { get; }

        /// <summary>The "excessivewakeuprate" collection of methods.</summary>
        public class ExcessivewakeuprateResource
        {
            private const string Resource = "excessivewakeuprate";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExcessivewakeuprateResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Describes the properties of the metric set.</summary>
            /// <param name="name">Required. The resource name. Format: apps/{app}/excessiveWakeupRateMetricSet</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1ExcessiveWakeupRateMetricSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/excessiveWakeupRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^apps/[^/]+/excessiveWakeupRateMetricSet$",
                    });
                }
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name. Format: apps/{app}/excessiveWakeupRateMetricSet</param>
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryExcessiveWakeupRateMetricSetRequest body, string name)
            {
                return new QueryRequest(service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryExcessiveWakeupRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryExcessiveWakeupRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/excessiveWakeupRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryExcessiveWakeupRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:query";

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
                        Pattern = @"^apps/[^/]+/excessiveWakeupRateMetricSet$",
                    });
                }
            }
        }

        /// <summary>Gets the Stuckbackgroundwakelockrate resource.</summary>
        public virtual StuckbackgroundwakelockrateResource Stuckbackgroundwakelockrate { get; }

        /// <summary>The "stuckbackgroundwakelockrate" collection of methods.</summary>
        public class StuckbackgroundwakelockrateResource
        {
            private const string Resource = "stuckbackgroundwakelockrate";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public StuckbackgroundwakelockrateResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Describes the properties of the metric set.</summary>
            /// <param name="name">
            /// Required. The resource name. Format: apps/{app}/stuckBackgroundWakelockRateMetricSet
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1StuckBackgroundWakelockRateMetricSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name. Format: apps/{app}/stuckBackgroundWakelockRateMetricSet
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^apps/[^/]+/stuckBackgroundWakelockRateMetricSet$",
                    });
                }
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name. Format: apps/{app}/stuckBackgroundWakelockRateMetricSet
            /// </param>
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryStuckBackgroundWakelockRateMetricSetRequest body, string name)
            {
                return new QueryRequest(service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryStuckBackgroundWakelockRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryStuckBackgroundWakelockRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name. Format: apps/{app}/stuckBackgroundWakelockRateMetricSet
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1beta1.Data.GooglePlayDeveloperReportingV1beta1QueryStuckBackgroundWakelockRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}:query";

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
                        Pattern = @"^apps/[^/]+/stuckBackgroundWakelockRateMetricSet$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Playdeveloperreporting.v1beta1.Data
{
    /// <summary>
    /// Represents an anomaly detected in a dataset. Our anomaly detection systems flag datapoints in a time series that
    /// fall outside of and expected range derived from historical data. Although those expected ranges have an upper
    /// and a lower bound, we only flag anomalies when the data has become unexpectedly _worse_, which usually
    /// corresponds to the case where the metric crosses the upper bound. Multiple contiguous datapoints in a timeline
    /// outside of the expected range will be grouped into a single anomaly. Therefore, an anomaly represents
    /// effectively a segment of a metric's timeline. The information stored in the `timeline_spec`, `dimensions` and
    /// `metric` can be used to fetch a full timeline with extended ragne for context. **Required permissions**: to
    /// access this resource, the calling user needs the _View app information (read-only)_ permission for the app.
    /// </summary>
    public class GooglePlayDeveloperReportingV1beta1Anomaly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Combination of dimensions in which the anomaly was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1DimensionValue> Dimensions { get; set; }

        /// <summary>Metric where the anomaly was detected, together with the anomalous value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual GooglePlayDeveloperReportingV1beta1MetricValue Metric { get; set; }

        /// <summary>Metric set resource where the anomaly was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricSet")]
        public virtual string MetricSet { get; set; }

        /// <summary>Name of the anomaly. Format: apps/{app}/anomalies/{anomaly}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Timeline specification that covers the anomaly period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1beta1TimelineSpec TimelineSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of ANR (Application not responding) metrics. This metric set contains
    /// ANRs data combined with usage data to produce a normalized metric independent of user counts. **Supported
    /// aggregation periods:** * DAILY: metrics are aggregated in calendar date intervals. Due to historical
    /// constraints, the only supported timezone is `America/Los_Angeles`. **Supported metrics:** * `anrRate`
    /// (`google.type.Decimal`): Percentage of distinct users in the aggregation period that experienced at least one
    /// ANR. If your app exhibits an ANR rate equal to or higher than the threshold, it's in the bottom 25% of the top
    /// 1,000 apps on Google Play (by number of installs). * `anrRate7dUserWeighted` (`google.type.Decimal`): Rolling
    /// average value of `anrRate` in the last 7 days. The daily values are weighted by the count of distinct users for
    /// the day. * `anrRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of `anrRate` in the last 28
    /// days. The daily values are weighted by the count of distinct users for the day. * `distinctUsers`
    /// (`google.type.Decimal`): Count of distinct users in the aggregation period that were used as normalization value
    /// for the `anrRate` metric. A user is counted in this metric if they used the app in the foreground during the
    /// aggregation period. Care must be taken not to aggregate this count further, as it may result in users being
    /// counted multiple times. **Supported dimensions:** * `apiLevel` (string): the API level of Android that was
    /// running on the user's device. * `versionCode` (int64): version of the app that was running on the user's device.
    /// * `deviceModel` (string): unique identifier of the user's device model. * `deviceType` (string): the type (also
    /// known as form factor) of the user's device. * `countryCode` (string): the country or region of the user's device
    /// based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US for the United States). *
    /// `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string):
    /// Make of the device's primary system-on-chip, e.g., Samsung.
    /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER) * `deviceSocModel`
    /// (string): Model of the device's primary system-on-chip, e.g., "Exynos 2100".
    /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MODEL) * `deviceCpuMake` (string): Make
    /// of the device's CPU, e.g., Qualcomm. * `deviceCpuModel` (string): Model of the device's CPU, e.g., "Kryo 240". *
    /// `deviceGpuMake` (string): Make of the device's GPU, e.g., ARM. * `deviceGpuModel` (string): Model of the
    /// device's GPU, e.g., Mali. * `deviceGpuVersion` (string): Version of the device's GPU, e.g., T750. *
    /// `deviceVulkanVersion` (string): Vulkan version of the device, e.g., "4198400". * `deviceGlEsVersion` (string):
    /// OpenGL ES version of the device, e.g., "196610". * `deviceScreenSize` (string): Screen size of the device, e.g.,
    /// NORMAL, LARGE. * `deviceScreenDpi` (string): Screen density of the device, e.g., mdpi, hdpi. **Required
    /// permissions**: to access this resource, the calling user needs the _View app information (read-only)_ permission
    /// for the app. **Related metric sets:** * vitals.errors contains unnormalized version (absolute counts) of
    /// crashes. * vitals.errors contains normalized metrics about crashes, another stability metric.
    /// </summary>
    public class GooglePlayDeveloperReportingV1beta1AnrRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1beta1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>The resource name. Format: apps/{app}/anrRateMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of crashrate metrics. This metric set contains crashes data combined
    /// with usage data to produce a normalized metric independent of user counts. **Supported aggregation periods:** *
    /// DAILY: metrics are aggregated in calendar date intervals. Due to historical constraints, the only supported
    /// timezone is `America/Los_Angeles`. **Supported metrics:** * `crashRate` (`google.type.Decimal`): Percentage of
    /// distinct users in the aggregation period that experienced at least one crash. If your app exhibits a crash rate
    /// equal to or higher than the threshold, it's in the bottom 25% of the top 1,000 apps on Google Play (by number of
    /// installs). * `crashRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of `crashRate` in the last
    /// 7 days. The daily values are weighted by the count of distinct users for the day. * `crashRate28dUserWeighted`
    /// (`google.type.Decimal`): Rolling average value of `crashRate` in the last 28 days. The daily values are weighted
    /// by the count of distinct users for the day. * `distinctUsers` (`google.type.Decimal`): Count of distinct users
    /// in the aggregation period that were used as normalization value for the `crashRate` metric. A user is counted in
    /// this metric if they used the app in the foreground during the aggregation period. Care must be taken not to
    /// aggregate this count further, as it may result in users being counted multiple times. **Supported dimensions:**
    /// * `apiLevel` (string): the API level of Android that was running on the user's device. * `versionCode` (int64):
    /// version of the app that was running on the user's device. * `deviceModel` (string): unique identifier of the
    /// user's device model. * `deviceType` (string): the type (also known as form factor) of the user's device. *
    /// `countryCode` (string): the country or region of the user's device based on their IP address, represented as a
    /// 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket` (int64): RAM of the device, in MB,
    /// in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g.,
    /// Samsung. [Reference](https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER) *
    /// `deviceSocModel` (string): Model of the device's primary system-on-chip, e.g., "Exynos 2100".
    /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MODEL) * `deviceCpuMake` (string): Make
    /// of the device's CPU, e.g., Qualcomm. * `deviceCpuModel` (string): Model of the device's CPU, e.g., "Kryo 240". *
    /// `deviceGpuMake` (string): Make of the device's GPU, e.g., ARM. * `deviceGpuModel` (string): Model of the
    /// device's GPU, e.g., Mali. * `deviceGpuVersion` (string): Version of the device's GPU, e.g., T750. *
    /// `deviceVulkanVersion` (string): Vulkan version of the device, e.g., "4198400". * `deviceGlEsVersion` (string):
    /// OpenGL ES version of the device, e.g., "196610". * `deviceScreenSize` (string): Screen size of the device, e.g.,
    /// NORMAL, LARGE. * `deviceScreenDpi` (string): Screen density of the device, e.g., mdpi, hdpi. **Required
    /// permissions**: to access this resource, the calling user needs the _View app information (read-only)_ permission
    /// for the app. **Related metric sets:** * vitals.errors contains unnormalized version (absolute counts) of
    /// crashes. * vitals.errors contains normalized metrics about ANRs, another stability metric.
    /// </summary>
    public class GooglePlayDeveloperReportingV1beta1CrashRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1beta1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>The resource name. Format: apps/{app}/crashRateMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the value of a single dimension.</summary>
    public class GooglePlayDeveloperReportingV1beta1DimensionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>Actual value, represented as an int64.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>Actual value, represented as a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>
        /// Optional. Human-friendly label for the value, always in English. For example, 'Spain' for the 'ES' country
        /// code. Whereas the dimension value is stable, this value label is subject to change. Do not assume that the
        /// (value, value_label) relationship is stable. For example, the ISO country code 'MK' changed its name
        /// recently to 'North Macedonia'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueLabel")]
        public virtual string ValueLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of Excessive Weakeups metrics. This metric set contains AlarmManager
    /// wakeup counts data combined with process state data to produce a normalized metric independent of user counts.
    /// **Supported aggregation periods:** * DAILY: metrics are aggregated in calendar date intervals. Due to historical
    /// constraints, the only supported timezone is `America/Los_Angeles`. **Supported metrics:** *
    /// `excessiveWakeupRate` (`google.type.Decimal`): Percentage of distinct users in the aggregation period that had
    /// more than 10 wakeups per hour. If your app exhibits an excessive wakeup rate equal to or higher than the
    /// threshold, it's in the bottom 25% of the top 1,000 apps on Google Play (by number of installs). *
    /// `excessiveWakeupRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of `excessiveWakeupRate` in
    /// the last 7 days. The daily values are weighted by the count of distinct users for the day. *
    /// `excessiveWakeupRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of `excessiveWakeupRate` in
    /// the last 28 days. The daily values are weighted by the count of distinct users for the day. * `distinctUsers`
    /// (`google.type.Decimal`): Count of distinct users in the aggregation period that were used as normalization value
    /// for the `excessiveWakeupRate` metric. A user is counted in this metric if they app was doing any work on the
    /// device, i.e., not just active foreground usage but also background work. Care must be taken not to aggregate
    /// this count further, as it may result in users being counted multiple times. **Supported dimensions:** *
    /// `apiLevel` (string): the API level of Android that was running on the user's device. * `versionCode` (int64):
    /// version of the app that was running on the user's device. * `deviceModel` (string): unique identifier of the
    /// user's device model. * `deviceType` (string): the type (also known as form factor) of the user's device. *
    /// `countryCode` (string): the country or region of the user's device based on their IP address, represented as a
    /// 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket` (int64): RAM of the device, in MB,
    /// in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g.,
    /// Samsung. [Reference](https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER) *
    /// `deviceSocModel` (string): Model of the device's primary system-on-chip, e.g., "Exynos 2100".
    /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MODEL) * `deviceCpuMake` (string): Make
    /// of the device's CPU, e.g., Qualcomm. * `deviceCpuModel` (string): Model of the device's CPU, e.g., "Kryo 240". *
    /// `deviceGpuMake` (string): Make of the device's GPU, e.g., ARM. * `deviceGpuModel` (string): Model of the
    /// device's GPU, e.g., Mali. * `deviceGpuVersion` (string): Version of the device's GPU, e.g., T750. *
    /// `deviceVulkanVersion` (string): Vulkan version of the device, e.g., "4198400". * `deviceGlEsVersion` (string):
    /// OpenGL ES version of the device, e.g., "196610". * `deviceScreenSize` (string): Screen size of the device, e.g.,
    /// NORMAL, LARGE. * `deviceScreenDpi` (string): Screen density of the device, e.g., mdpi, hdpi. **Required
    /// permissions**: to access this resource, the calling user needs the _View app information (read-only)_ permission
    /// for the app.
    /// </summary>
    public class GooglePlayDeveloperReportingV1beta1ExcessiveWakeupRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1beta1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>The resource name. Format: apps/{app}/excessiveWakeupRateMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the latest available time that can be requested in a TimelineSpec. Different aggregation periods have
    /// different freshness. For example, `DAILY` aggregation may lag behind `HOURLY` in cases where such aggregation is
    /// computed only once at the end of the day.
    /// </summary>
    public class GooglePlayDeveloperReportingV1beta1FreshnessInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about data freshness for every supported aggregation period. This field has set semantics, keyed
        /// by the `aggregation_period` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnesses")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1FreshnessInfoFreshness> Freshnesses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about data freshness for a single aggregation period.</summary>
    public class GooglePlayDeveloperReportingV1beta1FreshnessInfoFreshness : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregation period for which data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationPeriod")]
        public virtual string AggregationPeriod { get; set; }

        /// <summary>
        /// Latest end time for which data is available, for the aggregation period. The time is specified in the metric
        /// set's default timezone. *Note:* time ranges in TimelineSpec are represented as `start_time, end_time)`. For
        /// example, if the latest available timeline data point for a `DAILY` aggregation period is `2021-06-23
        /// 00:00:00 America/Los_Angeles`, the value of this field would be `2021-06-24 00:00:00 America/Los_Angeles` so
        /// it can be easily reused in [TimelineSpec.end_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestEndTime")]
        public virtual GoogleTypeDateTime LatestEndTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with a list of anomalies in datasets.</summary>
    public class GooglePlayDeveloperReportingV1beta1ListAnomaliesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anomalies that were found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anomalies")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1Anomaly> Anomalies { get; set; }

        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the value of a metric.</summary>
    public class GooglePlayDeveloperReportingV1beta1MetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Actual value, represented as a decimal number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decimalValue")]
        public virtual GoogleTypeDecimal DecimalValue { get; set; }

        /// <summary>Name of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a row of dimensions and metrics.</summary>
    public class GooglePlayDeveloperReportingV1beta1MetricsRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Granularity of the aggregation period of the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationPeriod")]
        public virtual string AggregationPeriod { get; set; }

        /// <summary>Dimension columns in the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1DimensionValue> Dimensions { get; set; }

        /// <summary>Metric columns in the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1MetricValue> Metrics { get; set; }

        /// <summary>Starting date (and time for hourly aggregation) of the period covered by this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual GoogleTypeDateTime StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryAnrRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1beta1QueryAnrRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the metrics by. **Supported dimensions:** * `apiLevel` (string): the API level of
        /// Android that was running on the user's device. * `versionCode` (int64): version of the app that was running
        /// on the user's device. * `deviceModel` (string): unique identifier of the user's device model. * `deviceType`
        /// (string): the type (also known as form factor) of the user's device. * `countryCode` (string): the country
        /// or region of the user's device based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US
        /// for the United States). * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.).
        /// * `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
        /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER) * `deviceSocModel`
        /// (string): Model of the device's primary system-on-chip, e.g., "Exynos 2100".
        /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MODEL) * `deviceCpuMake` (string):
        /// Make of the device's CPU, e.g., Qualcomm. * `deviceCpuModel` (string): Model of the device's CPU, e.g.,
        /// "Kryo 240". * `deviceGpuMake` (string): Make of the device's GPU, e.g., ARM. * `deviceGpuModel` (string):
        /// Model of the device's GPU, e.g., Mali. * `deviceGpuVersion` (string): Version of the device's GPU, e.g.,
        /// T750. * `deviceVulkanVersion` (string): Vulkan version of the device, e.g., "4198400". * `deviceGlEsVersion`
        /// (string): OpenGL ES version of the device, e.g., "196610". * `deviceScreenSize` (string): Screen size of the
        /// device, e.g., NORMAL, LARGE. * `deviceScreenDpi` (string): Screen density of the device, e.g., mdpi, hdpi.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>
        /// Filters to apply to data. The filtering expression follows [AIP-160](https://google.aip.dev/160) standard
        /// and supports filtering by equality of all breakdown dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Metrics to aggregate. **Supported metrics:** * `anrRate` (`google.type.Decimal`): Percentage of distinct
        /// users in the aggregation period that experienced at least one ANR. If your app exhibits an ANR rate equal to
        /// or higher than the threshold, it's in the bottom 25% of the top 1,000 apps on Google Play (by number of
        /// installs). * `anrRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of `anrRate` in the last
        /// 7 days. The daily values are weighted by the count of distinct users for the day. * `anrRate28dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `anrRate` in the last 28 days. The daily values are
        /// weighted by the count of distinct users for the day. * `distinctUsers` (`google.type.Decimal`): Count of
        /// distinct users in the aggregation period that were used as normalization value for the `anrRate` metric. A
        /// user is counted in this metric if they used the app in the foreground during the aggregation period. Care
        /// must be taken not to aggregate this count further, as it may result in users being counted multiple times.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// Maximum size of the returned data. If unspecified, at most 1000 rows will be returned. The maximum value is
        /// 100,000; values above 100,000 will be coerced to 100,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous call. Provide this to retrieve the subsequent page. When paginating,
        /// all other parameters provided to the request must match the call that provided the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Specification of the timeline aggregation parameters. **Supported aggregation periods:** * DAILY: metrics
        /// are aggregated in calendar date intervals. Due to historical constraints, the default and only supported
        /// timezone is `America/Los_Angeles`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1beta1TimelineSpec TimelineSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryAnrRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1beta1QueryAnrRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryCrashRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1beta1QueryCrashRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the metrics by. **Supported dimensions:** * `apiLevel` (string): the API level of
        /// Android that was running on the user's device. * `versionCode` (int64): version of the app that was running
        /// on the user's device. * `deviceModel` (string): unique identifier of the user's device model. * `deviceType`
        /// (string): the type (also known as form factor) of the user's device. * `countryCode` (string): the country
        /// or region of the user's device based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US
        /// for the United States). * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.).
        /// * `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
        /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER) * `deviceSocModel`
        /// (string): Model of the device's primary system-on-chip, e.g., "Exynos 2100".
        /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MODEL) * `deviceCpuMake` (string):
        /// Make of the device's CPU, e.g., Qualcomm. * `deviceCpuModel` (string): Model of the device's CPU, e.g.,
        /// "Kryo 240". * `deviceGpuMake` (string): Make of the device's GPU, e.g., ARM. * `deviceGpuModel` (string):
        /// Model of the device's GPU, e.g., Mali. * `deviceGpuVersion` (string): Version of the device's GPU, e.g.,
        /// T750. * `deviceVulkanVersion` (string): Vulkan version of the device, e.g., "4198400". * `deviceGlEsVersion`
        /// (string): OpenGL ES version of the device, e.g., "196610". * `deviceScreenSize` (string): Screen size of the
        /// device, e.g., NORMAL, LARGE. * `deviceScreenDpi` (string): Screen density of the device, e.g., mdpi, hdpi.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>
        /// Filters to apply to data. The filtering expression follows [AIP-160](https://google.aip.dev/160) standard
        /// and supports filtering by equality of all breakdown dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Metrics to aggregate. **Supported metrics:** * `crashRate` (`google.type.Decimal`): Percentage of distinct
        /// users in the aggregation period that experienced at least one crash. If your app exhibits a crash rate equal
        /// to or higher than the threshold, it's in the bottom 25% of the top 1,000 apps on Google Play (by number of
        /// installs). * `crashRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of `crashRate` in the
        /// last 7 days. The daily values are weighted by the count of distinct users for the day. *
        /// `crashRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of `crashRate` in the last 28
        /// days. The daily values are weighted by the count of distinct users for the day. * `distinctUsers`
        /// (`google.type.Decimal`): Count of distinct users in the aggregation period that were used as normalization
        /// value for the `crashRate` metric. A user is counted in this metric if they used the app in the foreground
        /// during the aggregation period. Care must be taken not to aggregate this count further, as it may result in
        /// users being counted multiple times.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// Maximum size of the returned data. If unspecified, at most 1000 rows will be returned. The maximum value is
        /// 100,000; values above 100,000 will be coerced to 100,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous call. Provide this to retrieve the subsequent page. When paginating,
        /// all other parameters provided to the request must match the call that provided the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Specification of the timeline aggregation parameters. **Supported aggregation periods:** * DAILY: metrics
        /// are aggregated in calendar date intervals. Due to historical constraints, the default and only supported
        /// timezone is `America/Los_Angeles`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1beta1TimelineSpec TimelineSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryCrashRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1beta1QueryCrashRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryExcessiveWakeupRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1beta1QueryExcessiveWakeupRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the data by. **Supported dimensions:** * `apiLevel` (string): the API level of Android
        /// that was running on the user's device. * `versionCode` (int64): version of the app that was running on the
        /// user's device. * `deviceModel` (string): unique identifier of the user's device model. * `deviceType`
        /// (string): the type (also known as form factor) of the user's device. * `countryCode` (string): the country
        /// or region of the user's device based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US
        /// for the United States). * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.).
        /// * `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
        /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER) * `deviceSocModel`
        /// (string): Model of the device's primary system-on-chip, e.g., "Exynos 2100".
        /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MODEL) * `deviceCpuMake` (string):
        /// Make of the device's CPU, e.g., Qualcomm. * `deviceCpuModel` (string): Model of the device's CPU, e.g.,
        /// "Kryo 240". * `deviceGpuMake` (string): Make of the device's GPU, e.g., ARM. * `deviceGpuModel` (string):
        /// Model of the device's GPU, e.g., Mali. * `deviceGpuVersion` (string): Version of the device's GPU, e.g.,
        /// T750. * `deviceVulkanVersion` (string): Vulkan version of the device, e.g., "4198400". * `deviceGlEsVersion`
        /// (string): OpenGL ES version of the device, e.g., "196610". * `deviceScreenSize` (string): Screen size of the
        /// device, e.g., NORMAL, LARGE. * `deviceScreenDpi` (string): Screen density of the device, e.g., mdpi, hdpi.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>
        /// Filters to apply to data. The filtering expression follows [AIP-160](https://google.aip.dev/160) standard
        /// and supports filtering by equality of all breakdown dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Metrics to aggregate. **Supported metrics:** * `excessiveWakeupRate` (`google.type.Decimal`): Percentage of
        /// distinct users in the aggregation period that had more than 10 wakeups per hour. If your app exhibits an
        /// excessive wakeup rate equal to or higher than the threshold, it's in the bottom 25% of the top 1,000 apps on
        /// Google Play (by number of installs). * `excessiveWakeupRate7dUserWeighted` (`google.type.Decimal`): Rolling
        /// average value of `excessiveWakeupRate` in the last 7 days. The daily values are weighted by the count of
        /// distinct users for the day. * `excessiveWakeupRate28dUserWeighted` (`google.type.Decimal`): Rolling average
        /// value of `excessiveWakeupRate` in the last 28 days. The daily values are weighted by the count of distinct
        /// users for the day. * `distinctUsers` (`google.type.Decimal`): Count of distinct users in the aggregation
        /// period that were used as normalization value for the `excessiveWakeupRate` metric. A user is counted in this
        /// metric if they app was doing any work on the device, i.e., not just active foreground usage but also
        /// background work. Care must be taken not to aggregate this count further, as it may result in users being
        /// counted multiple times.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// Maximum size of the returned data. If unspecified, at most 1000 rows will be returned. The maximum value is
        /// 100000; values above 100000 will be coerced to 100000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous call. Provide this to retrieve the subsequent page. When paginating,
        /// all other parameters provided to the request must match the call that provided the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Specification of the timeline aggregation parameters. **Supported aggregation periods:** * DAILY: metrics
        /// are aggregated in calendar date intervals. Due to historical constraints, the only supported timezone is
        /// `America/Los_Angeles`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1beta1TimelineSpec TimelineSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryExcessiveWakeupRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1beta1QueryExcessiveWakeupRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryStuckBackgroundWakelockRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1beta1QueryStuckBackgroundWakelockRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the data by. **Supported dimensions:** * `apiLevel` (string): the API level of Android
        /// that was running on the user's device. * `versionCode` (int64): version of the app that was running on the
        /// user's device. * `deviceModel` (string): unique identifier of the user's device model. * `deviceType`
        /// (string): the type (also known as form factor) of the user's device. * `countryCode` (string): the country
        /// or region of the user's device based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US
        /// for the United States). * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.).
        /// * `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
        /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER) * `deviceSocModel`
        /// (string): Model of the device's primary system-on-chip, e.g., "Exynos 2100".
        /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MODEL) * `deviceCpuMake` (string):
        /// Make of the device's CPU, e.g., Qualcomm. * `deviceCpuModel` (string): Model of the device's CPU, e.g.,
        /// "Kryo 240". * `deviceGpuMake` (string): Make of the device's GPU, e.g., ARM. * `deviceGpuModel` (string):
        /// Model of the device's GPU, e.g., Mali. * `deviceGpuVersion` (string): Version of the device's GPU, e.g.,
        /// T750. * `deviceVulkanVersion` (string): Vulkan version of the device, e.g., "4198400". * `deviceGlEsVersion`
        /// (string): OpenGL ES version of the device, e.g., "196610". * `deviceScreenSize` (string): Screen size of the
        /// device, e.g., NORMAL, LARGE. * `deviceScreenDpi` (string): Screen density of the device, e.g., mdpi, hdpi.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>
        /// Filters to apply to data. The filtering expression follows [AIP-160](https://google.aip.dev/160) standard
        /// and supports filtering by equality of all breakdown dimensions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Metrics to aggregate. **Supported metrics:** * `stuckBgWakelockRate` (`google.type.Decimal`): Percentage of
        /// distinct users in the aggregation period that had a wakelock held in the background for longer than 1 hour.
        /// If your app exhibits a stuck background wakelock rate equal to or higher than the threshold, it's in the
        /// bottom 25% of the top 1,000 apps on Google Play (by number of installs). *
        /// `stuckBgWakelockRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of `stuckBgWakelockRate`
        /// in the last 7 days. The daily values are weighted by the count of distinct users for the day. *
        /// `stuckBgWakelockRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of `stuckBgWakelockRate`
        /// in the last 28 days. The daily values are weighted by the count of distinct users for the day. *
        /// `distinctUsers` (`google.type.Decimal`): Count of distinct users in the aggregation period that were used as
        /// normalization value for the `stuckBgWakelockRate` metric. A user is counted in this metric if they app was
        /// doing any work on the device, i.e., not just active foreground usage but also background work. Care must be
        /// taken not to aggregate this count further, as it may result in users being counted multiple times.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>
        /// Maximum size of the returned data. If unspecified, at most 1000 rows will be returned. The maximum value is
        /// 100000; values above 100000 will be coerced to 100000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous call. Provide this to retrieve the subsequent page. When paginating,
        /// all other parameters provided to the request must match the call that provided the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Specification of the timeline aggregation parameters. **Supported aggregation periods:** * DAILY: metrics
        /// are aggregated in calendar date intervals. Due to historical constraints, the only supported timezone is
        /// `America/Los_Angeles`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1beta1TimelineSpec TimelineSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryStuckBackgroundWakelockRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1beta1QueryStuckBackgroundWakelockRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1beta1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of Stuck Background Wakelocks metrics. This metric set contains
    /// PowerManager wakelock duration data combined with process state data to produce a normalized metric independent
    /// of user counts. **Supported aggregation periods:** * DAILY: metrics are aggregated in calendar date intervals.
    /// Due to historical constraints, the only supported timezone is `America/Los_Angeles`. **Supported metrics:** *
    /// `stuckBgWakelockRate` (`google.type.Decimal`): Percentage of distinct users in the aggregation period that had a
    /// wakelock held in the background for longer than 1 hour. If your app exhibits a stuck background wakelocks rate
    /// equal to or higher than the threshold, it's in the bottom 25% of the top 1,000 apps on Google Play (by number of
    /// installs). * `stuckBgWakelockRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of
    /// `stuckBgWakelockRate` in the last 7 days. The daily values are weighted by the count of distinct users for the
    /// day. * `stuckBgWakelockRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of
    /// `stuckBgWakelockRate` in the last 28 days. The daily values are weighted by the count of distinct users for the
    /// day. * `distinctUsers` (`google.type.Decimal`): Count of distinct users in the aggregation period that were used
    /// as normalization value for the `stuckBgWakelockRate` metric. A user is counted in this metric if their app was
    /// doing any work on the device, i.e., not just active foreground usage but also background work. Care must be
    /// taken not to aggregate this count further, as it may result in users being counted multiple times. **Supported
    /// dimensions:** * `apiLevel` (string): the API level of Android that was running on the user's device. *
    /// `versionCode` (int64): version of the app that was running on the user's device. * `deviceModel` (string):
    /// unique identifier of the user's device model. * `deviceType` (string): the type (also known as form factor) of
    /// the user's device. * `countryCode` (string): the country or region of the user's device based on their IP
    /// address, represented as a 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket` (int64):
    /// RAM of the device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the device's primary
    /// system-on-chip, e.g., Samsung.
    /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER) * `deviceSocModel`
    /// (string): Model of the device's primary system-on-chip, e.g., "Exynos 2100".
    /// [Reference](https://developer.android.com/reference/android/os/Build#SOC_MODEL) * `deviceCpuMake` (string): Make
    /// of the device's CPU, e.g., Qualcomm. * `deviceCpuModel` (string): Model of the device's CPU, e.g., "Kryo 240". *
    /// `deviceGpuMake` (string): Make of the device's GPU, e.g., ARM. * `deviceGpuModel` (string): Model of the
    /// device's GPU, e.g., Mali. * `deviceGpuVersion` (string): Version of the device's GPU, e.g., T750. *
    /// `deviceVulkanVersion` (string): Vulkan version of the device, e.g., "4198400". * `deviceGlEsVersion` (string):
    /// OpenGL ES version of the device, e.g., "196610". * `deviceScreenSize` (string): Screen size of the device, e.g.,
    /// NORMAL, LARGE. * `deviceScreenDpi` (string): Screen density of the device, e.g., mdpi, hdpi. **Required
    /// permissions**: to access this resource, the calling user needs the _View app information (read-only)_ permission
    /// for the app.
    /// </summary>
    public class GooglePlayDeveloperReportingV1beta1StuckBackgroundWakelockRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1beta1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>The resource name. Format: apps/{app}/stuckBackgroundWakelockRateMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specification of the time-related aggregation parameters of a timeline. Timelines have an aggregation period
    /// (`DAILY`, `HOURLY`, etc) which defines how events are aggregated in metrics. The points in a timeline are
    /// defined by the starting DateTime of the aggregation period. The duration is implicit in the AggregationPeriod.
    /// Hourly aggregation periods, when supported by a metric set, are always specified in UTC to avoid ambiguities
    /// around daylight saving time transitions, where an hour is skipped when adopting DST, and repeated when
    /// abandoning DST. For example, the timestamp '2021-11-07 01:00:00 America/Los_Angeles' is ambiguous since it can
    /// correspond to '2021-11-07 08:00:00 UTC' or '2021-11-07 09:00:00 UTC'. Daily aggregation periods require
    /// specifying a timezone which will determine the precise instants of the start and the end of the day. Not all
    /// metric sets support all timezones, so make sure to check which timezones are supported by the metric set you
    /// want to query.
    /// </summary>
    public class GooglePlayDeveloperReportingV1beta1TimelineSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type of the aggregation period of the datapoints in the timeline. Intervals are identified by the date and
        /// time at the start of the interval.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationPeriod")]
        public virtual string AggregationPeriod { get; set; }

        /// <summary>
        /// Ending datapoint of the timeline (exclusive). See start_time for restrictions. The timezone of the end point
        /// must match the timezone of the start point.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual GoogleTypeDateTime EndTime { get; set; }

        /// <summary>
        /// Starting datapoint of the timeline (inclusive). Must be aligned to the aggregation period as follows: *
        /// HOURLY: the 'minutes', 'seconds' and 'nanos' fields must be unset. The time_zone can be left unset (defaults
        /// to UTC) or set explicitly to "UTC". Setting any other utc_offset or timezone id will result in a validation
        /// error. * DAILY: the 'hours', 'minutes', 'seconds' and 'nanos' fields must be unset. Different metric sets
        /// support different timezones. It can be left unset to use the default timezone specified by the metric set.
        /// The timezone of the end point must match the timezone of the start point.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual GoogleTypeDateTime StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents civil time (or occasionally physical time). This type can represent a civil time in one of a few
    /// possible ways: * When utc_offset is set and time_zone is unset: a civil time on a calendar day with a particular
    /// offset from UTC. * When time_zone is set and utc_offset is unset: a civil time on a calendar day in a particular
    /// time zone. * When neither time_zone nor utc_offset is set: a civil time on a calendar day in local time. The
    /// date is relative to the Proleptic Gregorian Calendar. If year, month, or day are 0, the DateTime is considered
    /// not to have a specific year, month, or day respectively. This type may also be used to represent a physical time
    /// if all the date and time fields are set and either case of the `time_offset` oneof is set. Consider using
    /// `Timestamp` message for physical time instead. If your use case also would like to store the user's timezone,
    /// that can be done in another field. This type is more flexible than some applications may want. Make sure to
    /// document and validate your application's limitations.
    /// </summary>
    public class GoogleTypeDateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a datetime
        /// without a day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>
        /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An API may
        /// choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>
        /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API may allow the
        /// value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>Time zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual GoogleTypeTimeZone TimeZone { get; set; }

        /// <summary>
        /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of -4:00 would
        /// be represented as { seconds: -14400 }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>
        /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A representation of a decimal value, such as 2.5. Clients may convert values into language-native decimal
    /// formats, such as Java's BigDecimal or Python's decimal.Decimal. [BigDecimal]:
    /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html [decimal.Decimal]:
    /// https://docs.python.org/3/library/decimal.html
    /// </summary>
    public class GoogleTypeDecimal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The decimal value, as a string. The string representation consists of an optional sign, `+` (`U+002B`) or
        /// `-` (`U+002D`), followed by a sequence of zero or more decimal digits ("the integer"), optionally followed
        /// by a fraction, optionally followed by an exponent. The fraction consists of a decimal point followed by zero
        /// or more decimal digits. The string must contain at least one digit in either the integer or the fraction.
        /// The number formed by the sign, the integer and the fraction is referred to as the significand. The exponent
        /// consists of the character `e` (`U+0065`) or `E` (`U+0045`) followed by one or more decimal digits. Services
        /// **should** normalize decimal values before storing them by: - Removing an explicitly-provided `+` sign
        /// (`+2.5` -&amp;gt; `2.5`). - Replacing a zero-length integer value with `0` (`.5` -&amp;gt; `0.5`). -
        /// Coercing the exponent character to lower-case (`2.5E8` -&amp;gt; `2.5e8`). - Removing an explicitly-provided
        /// zero exponent (`2.5e0` -&amp;gt; `2.5`). Services **may** perform additional normalization based on its own
        /// needs and the internal decimal implementation selected, such as shifting the decimal point and exponent
        /// value together (example: `2.5e-1` &amp;lt;-&amp;gt; `0.25`). Additionally, services **may** preserve
        /// trailing zeroes in the fraction to indicate increased precision, but are not required to do so. Note that
        /// only the `.` character is supported to divide the integer and the fraction; `,` **should not** be supported
        /// regardless of locale. Additionally, thousand separators **should not** be supported. If a service does
        /// support them, values **must** be normalized. The ENBF grammar is: DecimalString = [Sign] Significand
        /// [Exponent]; Sign = '+' | '-'; Significand = Digits '.' | [Digits] '.' Digits; Exponent = ('e' | 'E') [Sign]
        /// Digits; Digits = { '0' | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' }; Services **should** clearly
        /// document the range of supported values, the maximum supported precision (total number of digits), and, if
        /// applicable, the scale (number of digits after the decimal point), as well as how it behaves when receiving
        /// out-of-bounds values. Services **may** choose to accept values passed as input even when the value has a
        /// higher precision or scale than the service supports, and **should** round the value to fit the supported
        /// scale. Alternatively, the service **may** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if
        /// precision would be lost. Services **should** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if
        /// the service receives a value outside of the supported range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

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
