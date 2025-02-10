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

namespace Google.Apis.Playdeveloperreporting.v1alpha1
{
    /// <summary>The Playdeveloperreporting Service.</summary>
    public class PlaydeveloperreportingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

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
            Apps = new AppsResource(this);
            Vitals = new VitalsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://playdeveloperreporting.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://playdeveloperreporting.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "playdeveloperreporting";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Developer Reporting API.</summary>
        public class Scope
        {
            /// <summary>See metrics and data about the apps in your Google Play Developer account</summary>
            public static string Playdeveloperreporting = "https://www.googleapis.com/auth/playdeveloperreporting";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Play Developer Reporting API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See metrics and data about the apps in your Google Play Developer account</summary>
            public const string Playdeveloperreporting = "https://www.googleapis.com/auth/playdeveloperreporting";
        }

        /// <summary>Gets the Anomalies resource.</summary>
        public virtual AnomaliesResource Anomalies { get; }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

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
            return new ListRequest(this.service, parent);
        }

        /// <summary>Lists anomalies in any of the datasets.</summary>
        public class ListRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1ListAnomaliesResponse>
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
            public override string RestPath => "v1alpha1/{+parent}/anomalies";

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

    /// <summary>The "apps" collection of methods.</summary>
    public class AppsResource
    {
        private const string Resource = "apps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AppsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Describes filtering options for releases.</summary>
        /// <param name="name">
        /// Required. Name of the resource, i.e. app the filtering options are for. Format: apps/{app}
        /// </param>
        public virtual FetchReleaseFilterOptionsRequest FetchReleaseFilterOptions(string name)
        {
            return new FetchReleaseFilterOptionsRequest(this.service, name);
        }

        /// <summary>Describes filtering options for releases.</summary>
        public class FetchReleaseFilterOptionsRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1ReleaseFilterOptions>
        {
            /// <summary>Constructs a new FetchReleaseFilterOptions request.</summary>
            public FetchReleaseFilterOptionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Name of the resource, i.e. app the filtering options are for. Format: apps/{app}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "fetchReleaseFilterOptions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/{+name}:fetchReleaseFilterOptions";

            /// <summary>Initializes FetchReleaseFilterOptions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^apps/[^/]+$",
                });
            }
        }

        /// <summary>Searches for Apps accessible by the user.</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(this.service);
        }

        /// <summary>Searches for Apps accessible by the user.</summary>
        public class SearchRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1SearchAccessibleAppsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// The maximum number of apps to return. The service may return fewer than this value. If unspecified, at
            /// most 50 apps will be returned. The maximum value is 1000; values above 1000 will be coerced to 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A page token, received from a previous `SearchAccessibleApps` call. Provide this to retrieve the
            /// subsequent page. When paginating, all other parameters provided to `SearchAccessibleApps` must match the
            /// call that provided the page token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha1/apps:search";

            /// <summary>Initializes Search parameter list.</summary>
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
            Errors = new ErrorsResource(service);
            Excessivewakeuprate = new ExcessivewakeuprateResource(service);
            Slowrenderingrate = new SlowrenderingrateResource(service);
            Slowstartrate = new SlowstartrateResource(service);
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
                return new GetRequest(this.service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1AnrRateMetricSet>
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
                public override string RestPath => "v1alpha1/{+name}";

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
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryAnrRateMetricSetRequest body, string name)
            {
                return new QueryRequest(this.service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryAnrRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryAnrRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/anrRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryAnrRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}:query";

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
                return new GetRequest(this.service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1CrashRateMetricSet>
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
                public override string RestPath => "v1alpha1/{+name}";

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
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryCrashRateMetricSetRequest body, string name)
            {
                return new QueryRequest(this.service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryCrashRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryCrashRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/crashRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryCrashRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}:query";

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

        /// <summary>Gets the Errors resource.</summary>
        public virtual ErrorsResource Errors { get; }

        /// <summary>The "errors" collection of methods.</summary>
        public class ErrorsResource
        {
            private const string Resource = "errors";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ErrorsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Counts = new CountsResource(service);
                Issues = new IssuesResource(service);
                Reports = new ReportsResource(service);
            }

            /// <summary>Gets the Counts resource.</summary>
            public virtual CountsResource Counts { get; }

            /// <summary>The "counts" collection of methods.</summary>
            public class CountsResource
            {
                private const string Resource = "counts";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CountsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Describes the properties of the metrics set.</summary>
                /// <param name="name">
                /// Required. Name of the errors metric set. Format: apps/{app}/errorCountMetricSet
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Describes the properties of the metrics set.</summary>
                public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1ErrorCountMetricSet>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the errors metric set. Format: apps/{app}/errorCountMetricSet
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^apps/[^/]+/errorCountMetricSet$",
                        });
                    }
                }

                /// <summary>Queries the metrics in the metrics set.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The resource name. Format: apps/{app}/errorCountMetricSet</param>
                public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryErrorCountMetricSetRequest body, string name)
                {
                    return new QueryRequest(this.service, body, name);
                }

                /// <summary>Queries the metrics in the metrics set.</summary>
                public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryErrorCountMetricSetResponse>
                {
                    /// <summary>Constructs a new Query request.</summary>
                    public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryErrorCountMetricSetRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name. Format: apps/{app}/errorCountMetricSet</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryErrorCountMetricSetRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "query";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}:query";

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
                            Pattern = @"^apps/[^/]+/errorCountMetricSet$",
                        });
                    }
                }
            }

            /// <summary>Gets the Issues resource.</summary>
            public virtual IssuesResource Issues { get; }

            /// <summary>The "issues" collection of methods.</summary>
            public class IssuesResource
            {
                private const string Resource = "issues";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IssuesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Searches all error issues in which reports have been grouped.</summary>
                /// <param name="parent">
                /// Required. Parent resource of the error issues, indicating the application for which they were
                /// received. Format: apps/{app}
                /// </param>
                public virtual SearchRequest Search(string parent)
                {
                    return new SearchRequest(this.service, parent);
                }

                /// <summary>Searches all error issues in which reports have been grouped.</summary>
                public class SearchRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1SearchErrorIssuesResponse>
                {
                    /// <summary>Constructs a new Search request.</summary>
                    public SearchRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the error issues, indicating the application for which they were
                    /// received. Format: apps/{app}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A selection predicate to retrieve only a subset of the issues. Counts in the returned error
                    /// issues will only reflect occurrences that matched the filter. For filtering basics, please check
                    /// [AIP-160](https://google.aip.dev/160). ** Supported field names:** * `apiLevel`: Matches error
                    /// issues that occurred in the requested Android versions (specified as the numeric API level)
                    /// only. Example: `apiLevel = 28 OR apiLevel = 29`. * `versionCode`: Matches error issues that
                    /// occurred in the requested app version codes only. Example: `versionCode = 123 OR versionCode =
                    /// 456`. * `deviceModel`: Matches error issues that occurred in the requested devices. Example:
                    /// `deviceModel = "google/walleye" OR deviceModel = "google/marlin"`. * `deviceBrand`: Matches
                    /// error issues that occurred in the requested device brands. Example: `deviceBrand = "Google". *
                    /// `deviceType`: Matches error issues that occurred in the requested device types. Example:
                    /// `deviceType = "PHONE"`. * `errorIssueType`: Matches error issues of the requested types only.
                    /// Valid candidates: `CRASH`, `ANR`, `NON_FATAL`. Example: `errorIssueType = CRASH OR
                    /// errorIssueType = ANR`. * `appProcessState`: Matches error issues on the process state of an app,
                    /// indicating whether an app runs in the foreground (user-visible) or background. Valid candidates:
                    /// `FOREGROUND`, `BACKGROUND`. Example: `appProcessState = FOREGROUND`. * `isUserPerceived`:
                    /// Matches error issues that are user-perceived. It is not accompanied by any operators. Example:
                    /// `isUserPerceived`. ** Supported operators:** * Comparison operators: The only supported
                    /// comparison operator is equality. The filtered field must appear on the left hand side of the
                    /// comparison. * Logical Operators: Logical operators `AND` and `OR` can be used to build complex
                    /// filters following a conjunctive normal form (CNF), i.e., conjunctions of disjunctions. The `OR`
                    /// operator takes precedence over `AND` so the use of parenthesis is not necessary when building
                    /// CNF. The `OR` operator is only supported to build disjunctions that apply to the same field,
                    /// e.g., `versionCode = 123 OR errorIssueType = ANR` is not a valid filter. ** Examples ** Some
                    /// valid filtering expressions: * `versionCode = 123 AND errorIssueType = ANR` * `versionCode = 123
                    /// AND errorIssueType = OR errorIssueType = CRASH` * `versionCode = 123 AND (errorIssueType = OR
                    /// errorIssueType = CRASH)`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if
                    /// specifying a datetime without a day.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeDay { get; set; }

                    /// <summary>
                    /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An
                    /// API may choose to allow the value "24:00:00" for scenarios like business closing time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.hours", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeHours { get; set; }

                    /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.minutes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeMinutes { get; set; }

                    /// <summary>
                    /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeMonth { get; set; }

                    /// <summary>
                    /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.nanos", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeNanos { get; set; }

                    /// <summary>
                    /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API
                    /// may allow the value 60 if it allows leap-seconds.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.seconds", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeSeconds { get; set; }

                    /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.timeZone.id", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalEndTimeTimeZoneId { get; set; }

                    /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.timeZone.version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalEndTimeTimeZoneVersion { get; set; }

                    /// <summary>
                    /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of
                    /// -4:00 would be represented as { seconds: -14400 }.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.utcOffset", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object IntervalEndTimeUtcOffset { get; set; }

                    /// <summary>
                    /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeYear { get; set; }

                    /// <summary>
                    /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if
                    /// specifying a datetime without a day.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeDay { get; set; }

                    /// <summary>
                    /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An
                    /// API may choose to allow the value "24:00:00" for scenarios like business closing time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.hours", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeHours { get; set; }

                    /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.minutes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeMinutes { get; set; }

                    /// <summary>
                    /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeMonth { get; set; }

                    /// <summary>
                    /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.nanos", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeNanos { get; set; }

                    /// <summary>
                    /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API
                    /// may allow the value 60 if it allows leap-seconds.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.seconds", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeSeconds { get; set; }

                    /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.timeZone.id", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalStartTimeTimeZoneId { get; set; }

                    /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.timeZone.version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalStartTimeTimeZoneVersion { get; set; }

                    /// <summary>
                    /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of
                    /// -4:00 would be represented as { seconds: -14400 }.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.utcOffset", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object IntervalStartTimeUtcOffset { get; set; }

                    /// <summary>
                    /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeYear { get; set; }

                    /// <summary>
                    /// Specifies a field that will be used to order the results. ** Supported dimensions:** *
                    /// `errorReportCount`: Orders issues by number of error reports. * `distinctUsers`: Orders issues
                    /// by number of unique affected users. ** Supported operations:** * `asc` for ascending order. *
                    /// `desc` for descending order. Format: A field and an operation, e.g., `errorReportCount desc`
                    /// *Note:* currently only one field is supported at a time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of error issues to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 error issues will be returned. The maximum value is 1000; values above
                    /// 1000 will be coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous call. Provide this to retrieve the subsequent page. When
                    /// paginating, all other parameters provided to the request must match the call that provided the
                    /// page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. Number of sample error reports to return per ErrorIssue. If unspecified, 0 will be
                    /// used. *Note:* currently only 0 and 1 are supported.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("sampleErrorReportLimit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> SampleErrorReportLimit { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "search";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+parent}/errorIssues:search";

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
                        RequestParameters.Add("interval.endTime.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.hours", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.hours",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.minutes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.minutes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.nanos", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.nanos",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.seconds", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.seconds",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.timeZone.id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.timeZone.id",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.timeZone.version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.timeZone.version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.utcOffset", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.utcOffset",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.hours", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.hours",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.minutes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.minutes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.nanos", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.nanos",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.seconds", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.seconds",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.timeZone.id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.timeZone.id",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.timeZone.version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.timeZone.version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.utcOffset", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.utcOffset",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.year",
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
                        RequestParameters.Add("sampleErrorReportLimit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sampleErrorReportLimit",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
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

                /// <summary>Searches all error reports received for an app.</summary>
                /// <param name="parent">
                /// Required. Parent resource of the reports, indicating the application for which they were received.
                /// Format: apps/{app}
                /// </param>
                public virtual SearchRequest Search(string parent)
                {
                    return new SearchRequest(this.service, parent);
                }

                /// <summary>Searches all error reports received for an app.</summary>
                public class SearchRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1SearchErrorReportsResponse>
                {
                    /// <summary>Constructs a new Search request.</summary>
                    public SearchRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource of the reports, indicating the application for which they were
                    /// received. Format: apps/{app}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A selection predicate to retrieve only a subset of the reports. For filtering basics, please
                    /// check [AIP-160](https://google.aip.dev/160). ** Supported field names:** * `apiLevel`: Matches
                    /// error reports that occurred in the requested Android versions (specified as the numeric API
                    /// level) only. Example: `apiLevel = 28 OR apiLevel = 29`. * `versionCode`: Matches error reports
                    /// that occurred in the requested app version codes only. Example: `versionCode = 123 OR
                    /// versionCode = 456`. * `deviceModel`: Matches error issues that occurred in the requested
                    /// devices. Example: `deviceModel = "google/walleye" OR deviceModel = "google/marlin"`. *
                    /// `deviceBrand`: Matches error issues that occurred in the requested device brands. Example:
                    /// `deviceBrand = "Google". * `deviceType`: Matches error reports that occurred in the requested
                    /// device types. Example: `deviceType = "PHONE"`. * `errorIssueType`: Matches error reports of the
                    /// requested types only. Valid candidates: `CRASH`, `ANR`, `NON_FATAL`. Example: `errorIssueType =
                    /// CRASH OR errorIssueType = ANR`. * `errorIssueId`: Matches error reports belonging to the
                    /// requested error issue ids only. Example: `errorIssueId = 1234 OR errorIssueId = 4567`. *
                    /// `errorReportId`: Matches error reports with the requested error report id. Example:
                    /// `errorReportId = 1234 OR errorReportId = 4567`. * `appProcessState`: Matches error reports on
                    /// the process state of an app, indicating whether an app runs in the foreground (user-visible) or
                    /// background. Valid candidates: `FOREGROUND`, `BACKGROUND`. Example: `appProcessState =
                    /// FOREGROUND`. * `isUserPerceived`: Matches error reports that are user-perceived. It is not
                    /// accompanied by any operators. Example: `isUserPerceived`. ** Supported operators:** * Comparison
                    /// operators: The only supported comparison operator is equality. The filtered field must appear on
                    /// the left hand side of the comparison. * Logical Operators: Logical operators `AND` and `OR` can
                    /// be used to build complex filters following a conjunctive normal form (CNF), i.e., conjunctions
                    /// of disjunctions. The `OR` operator takes precedence over `AND` so the use of parenthesis is not
                    /// necessary when building CNF. The `OR` operator is only supported to build disjunctions that
                    /// apply to the same field, e.g., `versionCode = 123 OR versionCode = ANR`. The filter expression
                    /// `versionCode = 123 OR errorIssueType = ANR` is not valid. ** Examples ** Some valid filtering
                    /// expressions: * `versionCode = 123 AND errorIssueType = ANR` * `versionCode = 123 AND
                    /// errorIssueType = OR errorIssueType = CRASH` * `versionCode = 123 AND (errorIssueType = OR
                    /// errorIssueType = CRASH)`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if
                    /// specifying a datetime without a day.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeDay { get; set; }

                    /// <summary>
                    /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An
                    /// API may choose to allow the value "24:00:00" for scenarios like business closing time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.hours", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeHours { get; set; }

                    /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.minutes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeMinutes { get; set; }

                    /// <summary>
                    /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeMonth { get; set; }

                    /// <summary>
                    /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.nanos", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeNanos { get; set; }

                    /// <summary>
                    /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API
                    /// may allow the value 60 if it allows leap-seconds.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.seconds", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeSeconds { get; set; }

                    /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.timeZone.id", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalEndTimeTimeZoneId { get; set; }

                    /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.timeZone.version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalEndTimeTimeZoneVersion { get; set; }

                    /// <summary>
                    /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of
                    /// -4:00 would be represented as { seconds: -14400 }.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.utcOffset", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object IntervalEndTimeUtcOffset { get; set; }

                    /// <summary>
                    /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.endTime.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalEndTimeYear { get; set; }

                    /// <summary>
                    /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if
                    /// specifying a datetime without a day.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.day", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeDay { get; set; }

                    /// <summary>
                    /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An
                    /// API may choose to allow the value "24:00:00" for scenarios like business closing time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.hours", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeHours { get; set; }

                    /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.minutes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeMinutes { get; set; }

                    /// <summary>
                    /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.month", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeMonth { get; set; }

                    /// <summary>
                    /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.nanos", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeNanos { get; set; }

                    /// <summary>
                    /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API
                    /// may allow the value 60 if it allows leap-seconds.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.seconds", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeSeconds { get; set; }

                    /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.timeZone.id", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalStartTimeTimeZoneId { get; set; }

                    /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.timeZone.version", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string IntervalStartTimeTimeZoneVersion { get; set; }

                    /// <summary>
                    /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of
                    /// -4:00 would be represented as { seconds: -14400 }.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.utcOffset", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object IntervalStartTimeUtcOffset { get; set; }

                    /// <summary>
                    /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("interval.startTime.year", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> IntervalStartTimeYear { get; set; }

                    /// <summary>
                    /// The maximum number of reports to return. The service may return fewer than this value. If
                    /// unspecified, at most 50 reports will be returned. The maximum value is 100; values above 100
                    /// will be coerced to 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A page token, received from a previous `SearchErrorReports` call. Provide this to retrieve the
                    /// subsequent page. When paginating, all other parameters provided to `SearchErrorReports` must
                    /// match the call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "search";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+parent}/errorReports:search";

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
                        RequestParameters.Add("interval.endTime.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.hours", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.hours",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.minutes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.minutes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.nanos", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.nanos",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.seconds", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.seconds",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.timeZone.id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.timeZone.id",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.timeZone.version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.timeZone.version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.utcOffset", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.utcOffset",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.endTime.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.endTime.year",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.day", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.day",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.hours", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.hours",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.minutes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.minutes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.month", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.month",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.nanos", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.nanos",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.seconds", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.seconds",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.timeZone.id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.timeZone.id",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.timeZone.version", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.timeZone.version",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.utcOffset", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.utcOffset",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("interval.startTime.year", new Google.Apis.Discovery.Parameter
                        {
                            Name = "interval.startTime.year",
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
                return new GetRequest(this.service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1ExcessiveWakeupRateMetricSet>
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
                public override string RestPath => "v1alpha1/{+name}";

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
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryExcessiveWakeupRateMetricSetRequest body, string name)
            {
                return new QueryRequest(this.service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryExcessiveWakeupRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryExcessiveWakeupRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/excessiveWakeupRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryExcessiveWakeupRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}:query";

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

        /// <summary>Gets the Slowrenderingrate resource.</summary>
        public virtual SlowrenderingrateResource Slowrenderingrate { get; }

        /// <summary>The "slowrenderingrate" collection of methods.</summary>
        public class SlowrenderingrateResource
        {
            private const string Resource = "slowrenderingrate";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SlowrenderingrateResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Describes the properties of the metric set.</summary>
            /// <param name="name">Required. The resource name. Format: apps/{app}/slowRenderingRateMetricSet</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1SlowRenderingRateMetricSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/slowRenderingRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^apps/[^/]+/slowRenderingRateMetricSet$",
                    });
                }
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name. Format: apps/{app}/slowRenderingRateMetricSet</param>
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QuerySlowRenderingRateMetricSetRequest body, string name)
            {
                return new QueryRequest(this.service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QuerySlowRenderingRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QuerySlowRenderingRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/slowRenderingRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QuerySlowRenderingRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}:query";

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
                        Pattern = @"^apps/[^/]+/slowRenderingRateMetricSet$",
                    });
                }
            }
        }

        /// <summary>Gets the Slowstartrate resource.</summary>
        public virtual SlowstartrateResource Slowstartrate { get; }

        /// <summary>The "slowstartrate" collection of methods.</summary>
        public class SlowstartrateResource
        {
            private const string Resource = "slowstartrate";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SlowstartrateResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Describes the properties of the metric set.</summary>
            /// <param name="name">Required. The resource name. Format: apps/{app}/slowStartRateMetricSet</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1SlowStartRateMetricSet>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/slowStartRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^apps/[^/]+/slowStartRateMetricSet$",
                    });
                }
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The resource name. Format: apps/{app}/slowStartRateMetricSet</param>
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QuerySlowStartRateMetricSetRequest body, string name)
            {
                return new QueryRequest(this.service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QuerySlowStartRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QuerySlowStartRateMetricSetRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name. Format: apps/{app}/slowStartRateMetricSet</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QuerySlowStartRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}:query";

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
                        Pattern = @"^apps/[^/]+/slowStartRateMetricSet$",
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
                return new GetRequest(this.service, name);
            }

            /// <summary>Describes the properties of the metric set.</summary>
            public class GetRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1StuckBackgroundWakelockRateMetricSet>
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
                public override string RestPath => "v1alpha1/{+name}";

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
            public virtual QueryRequest Query(Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryStuckBackgroundWakelockRateMetricSetRequest body, string name)
            {
                return new QueryRequest(this.service, body, name);
            }

            /// <summary>Queries the metrics in the metric set.</summary>
            public class QueryRequest : PlaydeveloperreportingBaseServiceRequest<Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryStuckBackgroundWakelockRateMetricSetResponse>
            {
                /// <summary>Constructs a new Query request.</summary>
                public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryStuckBackgroundWakelockRateMetricSetRequest body, string name) : base(service)
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
                Google.Apis.Playdeveloperreporting.v1alpha1.Data.GooglePlayDeveloperReportingV1alpha1QueryStuckBackgroundWakelockRateMetricSetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "query";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}:query";

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
namespace Google.Apis.Playdeveloperreporting.v1alpha1.Data
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
    public class GooglePlayDeveloperReportingV1alpha1Anomaly : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Combination of dimensions in which the anomaly was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1DimensionValue> Dimensions { get; set; }

        /// <summary>Metric where the anomaly was detected, together with the anomalous value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual GooglePlayDeveloperReportingV1alpha1MetricValue Metric { get; set; }

        /// <summary>Metric set resource where the anomaly was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricSet")]
        public virtual string MetricSet { get; set; }

        /// <summary>Identifier. Name of the anomaly. Format: apps/{app}/anomalies/{anomaly}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Timeline specification that covers the anomaly period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1alpha1TimelineSpec TimelineSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of ANR (Application not responding) metrics. This metric set contains
    /// ANRs data combined with usage data to produce a normalized metric independent of user counts. **Supported
    /// aggregation periods:** * DAILY: metrics are aggregated in calendar date intervals. Due to historical
    /// constraints, the only supported timezone is `America/Los_Angeles`. * HOURLY: metrics are aggregated in hourly
    /// intervals. The default and only supported timezone is `UTC`. **Supported metrics:** * `anrRate`
    /// (`google.type.Decimal`): Percentage of distinct users in the aggregation period that experienced at least one
    /// ANR. * `anrRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of `anrRate` in the last 7 days.
    /// The daily values are weighted by the count of distinct users for the day. Not supported in HOURLY granularity. *
    /// `anrRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of `anrRate` in the last 28 days. The
    /// daily values are weighted by the count of distinct users for the day. Not supported in HOURLY granularity. *
    /// `userPerceivedAnrRate` (`google.type.Decimal`): Percentage of distinct users in the aggregation period that
    /// experienced at least one user-perceived ANR. User-perceived ANRs are currently those of 'Input dispatching'
    /// type. * `userPerceivedAnrRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of
    /// `userPerceivedAnrRate` in the last 7 days. The daily values are weighted by the count of distinct users for the
    /// day. Not supported in HOURLY granularity. * `userPerceivedAnrRate28dUserWeighted` (`google.type.Decimal`):
    /// Rolling average value of `userPerceivedAnrRate` in the last 28 days. The daily values are weighted by the count
    /// of distinct users for the day. * `distinctUsers` (`google.type.Decimal`): Count of distinct users in the
    /// aggregation period that were used as normalization value for the `anrRate` and `userPerceivedAnrRate` metrics. A
    /// user is counted in this metric if they used the app in the foreground during the aggregation period. Care must
    /// be taken not to aggregate this count further, as it may result in users being counted multiple times. The value
    /// is rounded to the nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the magnitude of the value.
    /// **Supported dimensions:** * `apiLevel` (string): the API level of Android that was running on the user's device,
    /// e.g., 26. * `versionCode` (int64): version of the app that was running on the user's device. * `deviceModel`
    /// (string): unique identifier of the user's device model. The form of the identifier is 'deviceBrand/device',
    /// where deviceBrand corresponds to Build.BRAND and device corresponds to Build.DEVICE, e.g., google/coral. *
    /// `deviceBrand` (string): unique identifier of the user's device brand, e.g., google. * `deviceType` (string): the
    /// type (also known as form factor) of the user's device, e.g., PHONE. * `countryCode` (string): the country or
    /// region of the user's device based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US for the
    /// United States). * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). *
    /// `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
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
    public class GooglePlayDeveloperReportingV1alpha1AnrRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1alpha1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>Identifier. The resource name. Format: apps/{app}/anrRateMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of an app in the Play Store.</summary>
    public class GooglePlayDeveloperReportingV1alpha1App : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Title of the app. This is the latest title as set in the Play Console and may not yet have been reviewed, so
        /// might not match the Play Store. Example: `Google Maps`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Identifier. The resource name. Format: apps/{app}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Package name of the app. Example: `com.example.app123`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representations of an app version.</summary>
    public class GooglePlayDeveloperReportingV1alpha1AppVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Numeric version code of the app version (set by the app's developer).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<long> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of crashrate metrics. This metric set contains crashes data combined
    /// with usage data to produce a normalized metric independent of user counts. **Supported aggregation periods:** *
    /// DAILY: metrics are aggregated in calendar date intervals. Due to historical constraints, the only supported
    /// timezone is `America/Los_Angeles`. * HOURLY: metrics are aggregated in hourly intervals. The default and only
    /// supported timezone is `UTC`. **Supported metrics:** * `crashRate` (`google.type.Decimal`): Percentage of
    /// distinct users in the aggregation period that experienced at least one crash. * `crashRate7dUserWeighted`
    /// (`google.type.Decimal`): Rolling average value of `crashRate` in the last 7 days. The daily values are weighted
    /// by the count of distinct users for the day. Not supported in HOURLY granularity. * `crashRate28dUserWeighted`
    /// (`google.type.Decimal`): Rolling average value of `crashRate` in the last 28 days. The daily values are weighted
    /// by the count of distinct users for the day. Not supported in HOURLY granularity. * `userPerceivedCrashRate`
    /// (`google.type.Decimal`): Percentage of distinct users in the aggregation period that experienced at least one
    /// crash while they were actively using your app (a user-perceived crash). An app is considered to be in active use
    /// if it is displaying any activity or executing any foreground service. * `userPerceivedCrashRate7dUserWeighted`
    /// (`google.type.Decimal`): Rolling average value of `userPerceivedCrashRate` in the last 7 days. The daily values
    /// are weighted by the count of distinct users for the day. Not supported in HOURLY granularity. *
    /// `userPerceivedCrashRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of
    /// `userPerceivedCrashRate` in the last 28 days. The daily values are weighted by the count of distinct users for
    /// the day. Not supported in HOURLY granularity. * `distinctUsers` (`google.type.Decimal`): Count of distinct users
    /// in the aggregation period that were used as normalization value for the `crashRate` and `userPerceivedCrashRate`
    /// metrics. A user is counted in this metric if they used the app actively during the aggregation period. An app is
    /// considered to be in active use if it is displaying any activity or executing any foreground service. Care must
    /// be taken not to aggregate this count further, as it may result in users being counted multiple times. The value
    /// is rounded to the nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the magnitude of the value.
    /// **Supported dimensions:** * `apiLevel` (string): the API level of Android that was running on the user's device,
    /// e.g., 26. * `versionCode` (int64): version of the app that was running on the user's device. * `deviceModel`
    /// (string): unique identifier of the user's device model. The form of the identifier is 'deviceBrand/device',
    /// where deviceBrand corresponds to Build.BRAND and device corresponds to Build.DEVICE, e.g., google/coral. *
    /// `deviceBrand` (string): unique identifier of the user's device brand, e.g., google. * `deviceType` (string): the
    /// type (also known as form factor) of the user's device, e.g., PHONE. * `countryCode` (string): the country or
    /// region of the user's device based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US for the
    /// United States). * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). *
    /// `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
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
    /// crashes. * vitals.errors contains normalized metrics about ANRs, another stability metric.
    /// </summary>
    public class GooglePlayDeveloperReportingV1alpha1CrashRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1alpha1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>Identifier. The resource name. Format: apps/{app}/crashRateMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the confidence interval of a metric.</summary>
    public class GooglePlayDeveloperReportingV1alpha1DecimalConfidenceInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence interval's lower bound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerBound")]
        public virtual GoogleTypeDecimal LowerBound { get; set; }

        /// <summary>The confidence interval's upper bound.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upperBound")]
        public virtual GoogleTypeDecimal UpperBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifier of a device.</summary>
    public class GooglePlayDeveloperReportingV1alpha1DeviceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value of Build.BRAND.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildBrand")]
        public virtual string BuildBrand { get; set; }

        /// <summary>Value of Build.DEVICE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildDevice")]
        public virtual string BuildDevice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary of a device</summary>
    public class GooglePlayDeveloperReportingV1alpha1DeviceModelSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual GooglePlayDeveloperReportingV1alpha1DeviceId DeviceId { get; set; }

        /// <summary>Link to the device in Play Device Catalog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUri")]
        public virtual string DeviceUri { get; set; }

        /// <summary>Display name of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingName")]
        public virtual string MarketingName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the value of a single dimension.</summary>
    public class GooglePlayDeveloperReportingV1alpha1DimensionValue : Google.Apis.Requests.IDirectResponseSchema
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
    /// Singleton resource representing the set of error report metrics. This metric set contains un-normalized error
    /// report counts. **Supported aggregation periods:** * HOURLY: metrics are aggregated in hourly intervals. The
    /// default and only supported timezone is `UTC`. * DAILY: metrics are aggregated in calendar date intervals. The
    /// default and only supported timezone is `America/Los_Angeles`. **Supported metrics:** * `errorReportCount`
    /// (`google.type.Decimal`): Absolute count of individual error reports that have been received for an app. *
    /// `distinctUsers` (`google.type.Decimal`): Count of distinct users for which reports have been received. Care must
    /// be taken not to aggregate this count further, as it may result in users being counted multiple times. This value
    /// is not rounded, however it may be an approximation. **Required dimension:** This dimension must be always
    /// specified in all requests in the `dimensions` field in query requests. * `reportType` (string): the type of
    /// error. The value should correspond to one of the possible values in ErrorType. **Supported dimensions:** *
    /// `apiLevel` (string): the API level of Android that was running on the user's device, e.g., 26. * `versionCode`
    /// (int64): version of the app that was running on the user's device. * `deviceModel` (string): unique identifier
    /// of the user's device model. The form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to
    /// Build.BRAND and device corresponds to Build.DEVICE, e.g., google/coral. * `deviceType` (string): identifier of
    /// the device's form factor, e.g., PHONE. * `issueId` (string): the id an error was assigned to. The value should
    /// correspond to the `{issue}` component of the issue name. * `deviceRamBucket` (int64): RAM of the device, in MB,
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
    /// for the app. **Related metric sets:** * vitals.errors.counts contains normalized metrics about Crashes, another
    /// stability metric. * vitals.errors.counts contains normalized metrics about ANRs, another stability metric.
    /// </summary>
    public class GooglePlayDeveloperReportingV1alpha1ErrorCountMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1alpha1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>The resource name. Format: apps/{app}/errorCountMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group of related ErrorReports received for an app. Similar error reports are grouped together into issues with
    /// a likely identical root cause. **Please note:** this resource is currently in Alpha. There could be changes to
    /// the issue grouping that would result in similar but more recent error reports being assigned to different
    /// issues. This could also cause some issues disappearing entirely and being replaced by new ones. **Required
    /// permissions**: to access this resource, the calling user needs the _View app information (read-only)_ permission
    /// for the app.
    /// </summary>
    public class GooglePlayDeveloperReportingV1alpha1ErrorIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of annotations for an issue. Annotations provide additional information that may help in diagnosing and
        /// fixing the issue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1IssueAnnotation> Annotations { get; set; }

        /// <summary>
        /// Cause of the issue. Depending on the type this can be either: * APPLICATION_NOT_RESPONDING: the type of ANR
        /// that occurred, e.g., 'Input dispatching timed out'. * CRASH: for Java unhandled exception errors, the type
        /// of the innermost exception that was thrown, e.g., IllegalArgumentException. For signals in native code, the
        /// signal that was raised, e.g. SIGSEGV.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>
        /// An estimate of the number of unique users who have experienced this issue (only considering occurrences
        /// matching the filters and within the requested time period).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctUsers")]
        public virtual System.Nullable<long> DistinctUsers { get; set; }

        /// <summary>
        /// An estimated percentage of users affected by any issue that are affected by this issue (only considering
        /// occurrences matching the filters and within the requested time period).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctUsersPercent")]
        public virtual GoogleTypeDecimal DistinctUsersPercent { get; set; }

        /// <summary>
        /// The total number of error reports in this issue (only considering occurrences matching the filters and
        /// within the requested time period).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorReportCount")]
        public virtual System.Nullable<long> ErrorReportCount { get; set; }

        /// <summary>
        /// The earliest (inclusive) app version appearing in this ErrorIssue in the requested time period (only
        /// considering occurrences matching the filters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstAppVersion")]
        public virtual GooglePlayDeveloperReportingV1alpha1AppVersion FirstAppVersion { get; set; }

        /// <summary>
        /// The smallest OS version in which this error cluster has occurred in the requested time period (only
        /// considering occurrences matching the filters and within the requested time period).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstOsVersion")]
        public virtual GooglePlayDeveloperReportingV1alpha1OsVersion FirstOsVersion { get; set; }

        /// <summary>Link to the issue in Android vitals in the Play Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueUri")]
        public virtual string IssueUri { get; set; }

        /// <summary>
        /// The latest (inclusive) app version appearing in this ErrorIssue in the requested time period (only
        /// considering occurrences matching the filters).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAppVersion")]
        public virtual GooglePlayDeveloperReportingV1alpha1AppVersion LastAppVersion { get; set; }

        private string _lastErrorReportTimeRaw;

        private object _lastErrorReportTime;

        /// <summary>Start of the hour during which the last error report in this issue occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastErrorReportTime")]
        public virtual string LastErrorReportTimeRaw
        {
            get => _lastErrorReportTimeRaw;
            set
            {
                _lastErrorReportTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastErrorReportTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastErrorReportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastErrorReportTimeDateTimeOffset instead.")]
        public virtual object LastErrorReportTime
        {
            get => _lastErrorReportTime;
            set
            {
                _lastErrorReportTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastErrorReportTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastErrorReportTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastErrorReportTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastErrorReportTimeRaw);
            set => LastErrorReportTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The latest OS version in which this error cluster has occurred in the requested time period (only
        /// considering occurrences matching the filters and within the requested time period).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastOsVersion")]
        public virtual GooglePlayDeveloperReportingV1alpha1OsVersion LastOsVersion { get; set; }

        /// <summary>
        /// Location where the issue happened. Depending on the type this can be either: * APPLICATION_NOT_RESPONDING:
        /// the name of the activity or service that stopped responding. * CRASH: the likely method name that caused the
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Identifier. The resource name of the issue. Format: apps/{app}/{issue}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Sample error reports which belong to this ErrorIssue. *Note:* currently a maximum of 1 per
        /// ErrorIssue is supported. Format: "apps/{app}/{report}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleErrorReports")]
        public virtual System.Collections.Generic.IList<string> SampleErrorReports { get; set; }

        /// <summary>Type of the errors grouped in this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An error report received for an app. There reports are produced by the Android platform code when a (potentially
    /// fatal) error condition is detected. Identical reports from many users will be deduplicated and coalesced into a
    /// single ErrorReport. **Required permissions**: to access this resource, the calling user needs the _View app
    /// information (read-only)_ permission for the app.
    /// </summary>
    public class GooglePlayDeveloperReportingV1alpha1ErrorReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The app version on which an event in this error report occurred on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersion")]
        public virtual GooglePlayDeveloperReportingV1alpha1AppVersion AppVersion { get; set; }

        /// <summary>A device model on which an event in this error report occurred on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceModel")]
        public virtual GooglePlayDeveloperReportingV1alpha1DeviceModelSummary DeviceModel { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Start of the hour during which the latest event in this error report occurred.</summary>
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

        /// <summary>
        /// The issue this report was associated with. **Please note:** this resource is currently in Alpha. There could
        /// be changes to the issue grouping that would result in similar but more recent error reports being assigned
        /// to a different issue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual string Issue { get; set; }

        /// <summary>The resource name of the report. Format: apps/{app}/{report}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The OS version on which an event in this error report occurred on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual GooglePlayDeveloperReportingV1alpha1OsVersion OsVersion { get; set; }

        /// <summary>
        /// Textual representation of the error report. These textual reports are produced by the platform. The reports
        /// are then sanitized and filtered to remove any potentially sensitive information. Although their format is
        /// fairly stable, they are not entirely meant for machine consumption and we cannot guarantee that there won't
        /// be subtle changes to the formatting that may break systems trying to parse information out of the reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportText")]
        public virtual string ReportText { get; set; }

        /// <summary>Type of the error for which this report was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Version control system information from BUNDLE-METADATA/version-control-info.textproto or
        /// META-INF/version-control-info.textproto of the app bundle or APK, respectively.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcsInformation")]
        public virtual string VcsInformation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of Excessive Weakeups metrics. This metric set contains AlarmManager
    /// wakeup counts data combined with process state data to produce a normalized metric independent of user counts.
    /// **Supported aggregation periods:** * DAILY: metrics are aggregated in calendar date intervals. Due to historical
    /// constraints, the only supported timezone is `America/Los_Angeles`. **Supported metrics:** *
    /// `excessiveWakeupRate` (`google.type.Decimal`): Percentage of distinct users in the aggregation period that had
    /// more than 10 wakeups per hour. * `excessiveWakeupRate7dUserWeighted` (`google.type.Decimal`): Rolling average
    /// value of `excessiveWakeupRate` in the last 7 days. The daily values are weighted by the count of distinct users
    /// for the day. * `excessiveWakeupRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of
    /// `excessiveWakeupRate` in the last 28 days. The daily values are weighted by the count of distinct users for the
    /// day. * `distinctUsers` (`google.type.Decimal`): Count of distinct users in the aggregation period that were used
    /// as normalization value for the `excessiveWakeupRate` metric. A user is counted in this metric if they app was
    /// doing any work on the device, i.e., not just active foreground usage but also background work. Care must be
    /// taken not to aggregate this count further, as it may result in users being counted multiple times. The value is
    /// rounded to the nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the magnitude of the value.
    /// **Supported dimensions:** * `apiLevel` (string): the API level of Android that was running on the user's device,
    /// e.g., 26. * `versionCode` (int64): version of the app that was running on the user's device. * `deviceModel`
    /// (string): unique identifier of the user's device model. The form of the identifier is 'deviceBrand/device',
    /// where deviceBrand corresponds to Build.BRAND and device corresponds to Build.DEVICE, e.g., google/coral. *
    /// `deviceBrand` (string): unique identifier of the user's device brand, e.g., google. * `deviceType` (string): the
    /// type (also known as form factor) of the user's device, e.g., PHONE. * `countryCode` (string): the country or
    /// region of the user's device based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US for the
    /// United States). * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). *
    /// `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
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
    public class GooglePlayDeveloperReportingV1alpha1ExcessiveWakeupRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1alpha1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>Identifier. The resource name. Format: apps/{app}/excessiveWakeupRateMetricSet</summary>
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
    public class GooglePlayDeveloperReportingV1alpha1FreshnessInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about data freshness for every supported aggregation period. This field has set semantics, keyed
        /// by the `aggregation_period` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnesses")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1FreshnessInfoFreshness> Freshnesses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about data freshness for a single aggregation period.</summary>
    public class GooglePlayDeveloperReportingV1alpha1FreshnessInfoFreshness : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Representation of an annotation message for an issue.</summary>
    public class GooglePlayDeveloperReportingV1alpha1IssueAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains the contents of the annotation message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// Category that the annotation belongs to. An annotation will belong to a single category. Example categories:
        /// "Potential fix", "Insight".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Title for the annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with a list of anomalies in datasets.</summary>
    public class GooglePlayDeveloperReportingV1alpha1ListAnomaliesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anomalies that were found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anomalies")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1Anomaly> Anomalies { get; set; }

        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the value of a metric.</summary>
    public class GooglePlayDeveloperReportingV1alpha1MetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Actual value, represented as a decimal number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decimalValue")]
        public virtual GoogleTypeDecimal DecimalValue { get; set; }

        /// <summary>Confidence interval of a value that is of type `type.Decimal`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decimalValueConfidenceInterval")]
        public virtual GooglePlayDeveloperReportingV1alpha1DecimalConfidenceInterval DecimalValueConfidenceInterval { get; set; }

        /// <summary>Name of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a row of dimensions and metrics.</summary>
    public class GooglePlayDeveloperReportingV1alpha1MetricsRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Granularity of the aggregation period of the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationPeriod")]
        public virtual string AggregationPeriod { get; set; }

        /// <summary>Dimension columns in the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1DimensionValue> Dimensions { get; set; }

        /// <summary>Metric columns in the row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1MetricValue> Metrics { get; set; }

        /// <summary>Starting date (and time for hourly aggregation) of the period covered by this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual GoogleTypeDateTime StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of an OS version.</summary>
    public class GooglePlayDeveloperReportingV1alpha1OsVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Numeric version code of the OS - API level</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiLevel")]
        public virtual System.Nullable<long> ApiLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryAnrRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryAnrRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the metrics by. **Supported dimensions:** * `apiLevel` (string): the API level of
        /// Android that was running on the user's device, e.g., 26. * `versionCode` (int64): version of the app that
        /// was running on the user's device. * `deviceModel` (string): unique identifier of the user's device model.
        /// The form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to Build.BRAND and device
        /// corresponds to Build.DEVICE, e.g., google/coral. * `deviceBrand` (string): unique identifier of the user's
        /// device brand, e.g., google. * `deviceType` (string): the type (also known as form factor) of the user's
        /// device, e.g., PHONE. * `countryCode` (string): the country or region of the user's device based on their IP
        /// address, represented as a 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket`
        /// (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the
        /// device's primary system-on-chip, e.g., Samsung.
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
        /// users in the aggregation period that experienced at least one ANR. * `anrRate7dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `anrRate` in the last 7 days. The daily values are
        /// weighted by the count of distinct users for the day. Not supported in HOURLY granularity. *
        /// `anrRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of `anrRate` in the last 28 days.
        /// The daily values are weighted by the count of distinct users for the day. Not supported in HOURLY
        /// granularity. * `userPerceivedAnrRate` (`google.type.Decimal`): Percentage of distinct users in the
        /// aggregation period that experienced at least one user-perceived ANR. User-perceived ANRs are currently those
        /// of 'Input dispatching' type. * `userPerceivedAnrRate7dUserWeighted` (`google.type.Decimal`): Rolling average
        /// value of `userPerceivedAnrRate` in the last 7 days. The daily values are weighted by the count of distinct
        /// users for the day. Not supported in HOURLY granularity. * `userPerceivedAnrRate28dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `userPerceivedAnrRate` in the last 28 days. The daily
        /// values are weighted by the count of distinct users for the day. Not . supported in HOURLY granularity. *
        /// `distinctUsers` (`google.type.Decimal`): Count of distinct users in the aggregation period that were used as
        /// normalization value for the `anrRate` and `userPerceivedAnrRate` metrics. A user is counted in this metric
        /// if they used the app in the foreground during the aggregation period. Care must be taken not to aggregate
        /// this count further, as it may result in users being counted multiple times. The value is rounded to the
        /// nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the magnitude of the value.
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
        /// timezone is `America/Los_Angeles`. * HOURLY: metrics are aggregated in hourly intervals. The default and
        /// only supported timezone is `UTC`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1alpha1TimelineSpec TimelineSpec { get; set; }

        /// <summary>
        /// User view to select. The output data will correspond to the selected view. **Supported values:** *
        /// `OS_PUBLIC` To select data from all publicly released Android versions. This is the default. Supports all
        /// the above dimensions. * `APP_TESTERS` To select data from users who have opted in to be testers. Supports
        /// all the above dimensions. * `OS_BETA` To select data from beta android versions only, excluding data from
        /// released android versions. Only the following dimensions are supported: * `versionCode` (int64): version of
        /// the app that was running on the user's device. * `osBuild` (string): OS build of the user's device, e.g.,
        /// "T1B2.220916.004".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCohort")]
        public virtual string UserCohort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryAnrRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryAnrRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryCrashRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryCrashRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the metrics by. **Supported dimensions:** * `apiLevel` (string): the API level of
        /// Android that was running on the user's device, e.g., 26. * `versionCode` (int64): version of the app that
        /// was running on the user's device. * `deviceModel` (string): unique identifier of the user's device model.
        /// The form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to Build.BRAND and device
        /// corresponds to Build.DEVICE, e.g., google/coral. * `deviceBrand` (string): unique identifier of the user's
        /// device brand, e.g., google. * `deviceType` (string): the type (also known as form factor) of the user's
        /// device, e.g., PHONE. * `countryCode` (string): the country or region of the user's device based on their IP
        /// address, represented as a 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket`
        /// (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the
        /// device's primary system-on-chip, e.g., Samsung.
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
        /// users in the aggregation period that experienced at least one crash. * `crashRate7dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `crashRate` in the last 7 days. The daily values are
        /// weighted by the count of distinct users for the day. * `crashRate28dUserWeighted` (`google.type.Decimal`):
        /// Rolling average value of `crashRate` in the last 28 days. The daily values are weighted by the count of
        /// distinct users for the day. Not supported in HOURLY granularity. * `userPerceivedCrashRate`
        /// (`google.type.Decimal`): Percentage of distinct users in the aggregation period that experienced at least
        /// one crash while they were actively using your app (a user-perceived crash). An app is considered to be in
        /// active use if it is displaying any activity or executing any foreground service. *
        /// `userPerceivedCrashRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of
        /// `userPerceivedCrashRate` in the last 7 days. The daily values are weighted by the count of distinct users
        /// for the day. Not supported in HOURLY granularity. * `userPerceivedCrashRate28dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `userPerceivedCrashRate` in the last 28 days. The daily
        /// values are weighted by the count of distinct users for the day. Not supported in HOURLY granularity. *
        /// `distinctUsers` (`google.type.Decimal`): Count of distinct users in the aggregation period that were used as
        /// normalization value for the `crashRate` and `userPerceivedCrashRate` metrics. A user is counted in this
        /// metric if they used the app actively during the aggregation period. An app is considered to be in active use
        /// if it is displaying any activity or executing any foreground service. Care must be taken not to aggregate
        /// this count further, as it may result in users being counted multiple times. The value is rounded to the
        /// nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the magnitude of the value.
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
        /// timezone is `America/Los_Angeles`. * HOURLY: metrics are aggregated in hourly intervals. The default and
        /// only supported timezone is `UTC`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1alpha1TimelineSpec TimelineSpec { get; set; }

        /// <summary>
        /// User view to select. The output data will correspond to the selected view. **Supported values:** *
        /// `OS_PUBLIC` To select data from all publicly released Android versions. This is the default. Supports all
        /// the above dimensions. * `APP_TESTERS` To select data from users who have opted in to be testers. Supports
        /// all the above dimensions. * `OS_BETA` To select data from beta android versions only, excluding data from
        /// released android versions. Only the following dimensions are supported: * `versionCode` (int64): version of
        /// the app that was running on the user's device. * `osBuild` (string): OS build of the user's device, e.g.,
        /// "T1B2.220916.004".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCohort")]
        public virtual string UserCohort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryCrashRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryCrashRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryErrorCountMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryErrorCountMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the data by. **Supported dimensions:** * `apiLevel` (string): the API level of Android
        /// that was running on the user's device, e.g., 26. * `versionCode` (int64): unique identifier of the user's
        /// device model. The form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to
        /// Build.BRAND and device corresponds to Build.DEVICE, e.g., google/coral. * `deviceModel` (string): unique
        /// identifier of the user's device model. * `deviceType` (string): identifier of the device's form factor,
        /// e.g., PHONE. * `reportType` (string): the type of error. The value should correspond to one of the possible
        /// values in ErrorType. * `issueId` (string): the id an error was assigned to. The value should correspond to
        /// the `{issue}` component of the issue name. * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets
        /// (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
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
        /// and supports filtering by equality of all breakdown dimensions and: * `isUserPerceived` (string): denotes
        /// whether error is user perceived or not, USER_PERCEIVED or NOT_USER_PERCEIVED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Metrics to aggregate. **Supported metrics:** * `errorReportCount` (`google.type.Decimal`): Absolute count of
        /// individual error reports that have been received for an app. * `distinctUsers` (`google.type.Decimal`):
        /// Count of distinct users for which reports have been received. Care must be taken not to aggregate this count
        /// further, as it may result in users being counted multiple times. This value is not rounded, however it may
        /// be an approximation.
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
        /// are aggregated in calendar date intervals. The default and only supported timezone is `America/Los_Angeles`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timelineSpec")]
        public virtual GooglePlayDeveloperReportingV1alpha1TimelineSpec TimelineSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error counts query response.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryErrorCountMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryExcessiveWakeupRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryExcessiveWakeupRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the data by. **Supported dimensions:** * `apiLevel` (string): the API level of Android
        /// that was running on the user's device, e.g., 26. * `versionCode` (int64): version of the app that was
        /// running on the user's device. * `deviceModel` (string): unique identifier of the user's device model. The
        /// form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to Build.BRAND and device
        /// corresponds to Build.DEVICE, e.g., google/coral. * `deviceBrand` (string): unique identifier of the user's
        /// device brand, e.g., google. * `deviceType` (string): the type (also known as form factor) of the user's
        /// device, e.g., PHONE. * `countryCode` (string): the country or region of the user's device based on their IP
        /// address, represented as a 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket`
        /// (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the
        /// device's primary system-on-chip, e.g., Samsung.
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
        /// distinct users in the aggregation period that had more than 10 wakeups per hour. *
        /// `excessiveWakeupRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of `excessiveWakeupRate`
        /// in the last 7 days. The daily values are weighted by the count of distinct users for the day. *
        /// `excessiveWakeupRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of `excessiveWakeupRate`
        /// in the last 28 days. The daily values are weighted by the count of distinct users for the day. *
        /// `distinctUsers` (`google.type.Decimal`): Count of distinct users in the aggregation period that were used as
        /// normalization value for the `excessiveWakeupRate` metric. A user is counted in this metric if they app was
        /// doing any work on the device, i.e., not just active foreground usage but also background work. Care must be
        /// taken not to aggregate this count further, as it may result in users being counted multiple times. The value
        /// is rounded to the nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the magnitude of the value.
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
        public virtual GooglePlayDeveloperReportingV1alpha1TimelineSpec TimelineSpec { get; set; }

        /// <summary>
        /// User view to select. The output data will correspond to the selected view. The only supported value is
        /// `OS_PUBLIC`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCohort")]
        public virtual string UserCohort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryExcessiveWakeupRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryExcessiveWakeupRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QuerySlowRenderingRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QuerySlowRenderingRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the data by. **Supported dimensions:** * `apiLevel` (string): the API level of Android
        /// that was running on the user's device, e.g., 26. * `versionCode` (int64): version of the app that was
        /// running on the user's device. * `deviceModel` (string): unique identifier of the user's device model. The
        /// form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to Build.BRAND and device
        /// corresponds to Build.DEVICE, e.g., google/coral. * `deviceBrand` (string): unique identifier of the user's
        /// device brand, e.g., google. * `deviceType` (string): the type (also known as form factor) of the user's
        /// device, e.g., PHONE. * `countryCode` (string): the country or region of the user's device based on their IP
        /// address, represented as a 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket`
        /// (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the
        /// device's primary system-on-chip, e.g., Samsung.
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
        /// Metrics to aggregate. **Supported metrics:** * `slowRenderingRate20Fps` (`google.type.Decimal`): Percentage
        /// of distinct users in the aggregation period that had a slow rendering. *
        /// `slowRenderingRate20Fps7dUserWeighted` (`google.type.Decimal`): Rolling average value of
        /// `slowRenderingRate20Fps` in the last 7 days. The daily values are weighted by the count of distinct users
        /// for the day. * `slowRenderingRate20Fps28dUserWeighted` (`google.type.Decimal`): Rolling average value of
        /// `slowRenderingRate20Fps` in the last 28 days. The daily values are weighted by the count of distinct users
        /// for the day. * `slowRenderingRate30Fps` (`google.type.Decimal`): Percentage of distinct users in the
        /// aggregation period that had a slow rendering. * `slowRenderingRate30Fps7dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `slowRenderingRate30Fps` in the last 7 days. The daily
        /// values are weighted by the count of distinct users for the day. * `slowRenderingRate30Fps28dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `slowRenderingRate30Fps` in the last 28 days. The daily
        /// values are weighted by the count of distinct users for the day. * `distinctUsers` (`google.type.Decimal`):
        /// Count of distinct users in the aggregation period that were used as normalization value for the
        /// `slowRenderingRate20Fps`/`slowRenderingRate30Fps` metric. A user is counted in this metric if their app was
        /// launched in the device. Care must be taken not to aggregate this count further, as it may result in users
        /// being counted multiple times. The value is rounded to the nearest multiple of 10, 100, 1,000 or 1,000,000,
        /// depending on the magnitude of the value.
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
        public virtual GooglePlayDeveloperReportingV1alpha1TimelineSpec TimelineSpec { get; set; }

        /// <summary>
        /// User view to select. The output data will correspond to the selected view. The only supported value is
        /// `OS_PUBLIC`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCohort")]
        public virtual string UserCohort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QuerySlowRenderingRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QuerySlowRenderingRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QuerySlowStartRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QuerySlowStartRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the data by. **Supported dimensions:** * `apiLevel` (string): the API level of Android
        /// that was running on the user's device, e.g., 26. * `versionCode` (int64): version of the app that was
        /// running on the user's device. * `deviceModel` (string): unique identifier of the user's device model. The
        /// form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to Build.BRAND and device
        /// corresponds to Build.DEVICE, e.g., google/coral. * `deviceBrand` (string): unique identifier of the user's
        /// device brand, e.g., google. * `deviceType` (string): the type (also known as form factor) of the user's
        /// device, e.g., PHONE. * `countryCode` (string): the country or region of the user's device based on their IP
        /// address, represented as a 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket`
        /// (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the
        /// device's primary system-on-chip, e.g., Samsung.
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
        /// Metrics to aggregate. **Supported metrics:** * `slowStartRate` (`google.type.Decimal`): Percentage of
        /// distinct users in the aggregation period that had a slow start. * `slowStartRate7dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `slowStartRate` in the last 7 days. The daily values are
        /// weighted by the count of distinct users for the day. * `slowStartRate28dUserWeighted`
        /// (`google.type.Decimal`): Rolling average value of `slowStartRate` in the last 28 days. The daily values are
        /// weighted by the count of distinct users for the day. * `distinctUsers` (`google.type.Decimal`): Count of
        /// distinct users in the aggregation period that were used as normalization value for the `slowStartRate`
        /// metric. A user is counted in this metric if their app was launched in the device. Care must be taken not to
        /// aggregate this count further, as it may result in users being counted multiple times. The value is rounded
        /// to the nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the magnitude of the value.
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
        public virtual GooglePlayDeveloperReportingV1alpha1TimelineSpec TimelineSpec { get; set; }

        /// <summary>
        /// User view to select. The output data will correspond to the selected view. The only supported value is
        /// `OS_PUBLIC`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCohort")]
        public virtual string UserCohort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QuerySlowStartRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QuerySlowStartRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for QueryStuckBackgroundWakelockRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryStuckBackgroundWakelockRateMetricSetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Dimensions to slice the data by. **Supported dimensions:** * `apiLevel` (string): the API level of Android
        /// that was running on the user's device, e.g., 26. * `versionCode` (int64): version of the app that was
        /// running on the user's device. * `deviceModel` (string): unique identifier of the user's device model. The
        /// form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to Build.BRAND and device
        /// corresponds to Build.DEVICE, e.g., google/coral. * `deviceBrand` (string): unique identifier of the user's
        /// device brand, e.g., google. * `deviceType` (string): the type (also known as form factor) of the user's
        /// device, e.g., PHONE. * `countryCode` (string): the country or region of the user's device based on their IP
        /// address, represented as a 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket`
        /// (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the
        /// device's primary system-on-chip, e.g., Samsung.
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
        /// * `stuckBgWakelockRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of
        /// `stuckBgWakelockRate` in the last 7 days. The daily values are weighted by the count of distinct users for
        /// the day. * `stuckBgWakelockRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of
        /// `stuckBgWakelockRate` in the last 28 days. The daily values are weighted by the count of distinct users for
        /// the day. * `distinctUsers` (`google.type.Decimal`): Count of distinct users in the aggregation period that
        /// were used as normalization value for the `stuckBgWakelockRate` metric. A user is counted in this metric if
        /// they app was doing any work on the device, i.e., not just active foreground usage but also background work.
        /// Care must be taken not to aggregate this count further, as it may result in users being counted multiple
        /// times. The value is rounded to the nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the
        /// magnitude of the value.
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
        public virtual GooglePlayDeveloperReportingV1alpha1TimelineSpec TimelineSpec { get; set; }

        /// <summary>
        /// User view to select. The output data will correspond to the selected view. The only supported value is
        /// `OS_PUBLIC`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCohort")]
        public virtual string UserCohort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for QueryStuckBackgroundWakelockRateMetricSet.</summary>
    public class GooglePlayDeveloperReportingV1alpha1QueryStuckBackgroundWakelockRateMetricSetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returned rows of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1MetricsRow> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of an app release.</summary>
    public class GooglePlayDeveloperReportingV1alpha1Release : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Readable identifier of the release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The version codes contained in this release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> VersionCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of filtering options for releases and version codes specific to an app.</summary>
    public class GooglePlayDeveloperReportingV1alpha1ReleaseFilterOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of tracks to filter releases over. Provides the grouping of version codes under releases and tracks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1Track> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SearchAccessibleApps.</summary>
    public class GooglePlayDeveloperReportingV1alpha1SearchAccessibleAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The apps accessible to the user calling the endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apps")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1App> Apps { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with a paginated list of issues that matched the request.</summary>
    public class GooglePlayDeveloperReportingV1alpha1SearchErrorIssuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ErrorIssues that were found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorIssues")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1ErrorIssue> ErrorIssues { get; set; }

        /// <summary>Continuation token to fetch the next page of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response with a paginated list of error reports matching the search query.</summary>
    public class GooglePlayDeveloperReportingV1alpha1SearchErrorReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error reports that were found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorReports")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1ErrorReport> ErrorReports { get; set; }

        /// <summary>Page token to fetch the next page of reports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of Slow Rendering metrics. This metric set contains low-level rendering
    /// data captured by SurafeFlinger. Sessions are evaluated based on the present-to-present histogram of frames
    /// handled by any SurfaceFlinger layer owned by the app. A slow session is a session where more than 25% of frames
    /// for the session did not meet the metric's target frame rate (either 20fps, or 30fps). *NOTE:* This metric set is
    /// only available for games. **Supported aggregation periods:** * DAILY: metrics are aggregated in calendar date
    /// intervals. Due to historical constraints, the only supported timezone is `America/Los_Angeles`. **Supported
    /// metrics:** * `slowRenderingRate20Fps` (`google.type.Decimal`): Percentage of distinct users in the aggregation
    /// period that had slow rendering. * `slowRenderingRate20Fps7dUserWeighted` (`google.type.Decimal`): Rolling
    /// average value of `slowRenderingRate20Fps` in the last 7 days. The daily values are weighted by the count of
    /// distinct users for the day. * `slowRenderingRate20Fps28dUserWeighted` (`google.type.Decimal`): Rolling average
    /// value of `slowRenderingRate20Fps` in the last 28 days. The daily values are weighted by the count of distinct
    /// users for the day. * `slowRenderingRate30Fps` (`google.type.Decimal`): Percentage of distinct users in the
    /// aggregation period that had slow rendering. * `slowRenderingRate30Fps7dUserWeighted` (`google.type.Decimal`):
    /// Rolling average value of `slowRenderingRate30Fps` in the last 7 days. The daily values are weighted by the count
    /// of distinct users for the day. * `slowRenderingRate30Fps28dUserWeighted` (`google.type.Decimal`): Rolling
    /// average value of `slowRenderingRate30Fps` in the last 28 days. The daily values are weighted by the count of
    /// distinct users for the day. * `distinctUsers` (`google.type.Decimal`): Count of distinct users in the
    /// aggregation period that were used as normalization value for the
    /// `slowRenderingRate20Fps`/`slowRenderingRate30Fps` metric. A user is counted in this metric if their app rendered
    /// any frames. Care must be taken not to aggregate this count further, as it may result in users being counted
    /// multiple times. The value is rounded to the nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the
    /// magnitude of the value. **Supported dimensions:** * `apiLevel` (string): the API level of Android that was
    /// running on the user's device, e.g., 26. * `versionCode` (int64): version of the app that was running on the
    /// user's device. * `deviceModel` (string): unique identifier of the user's device model. The form of the
    /// identifier is 'deviceBrand/device', where deviceBrand corresponds to Build.BRAND and device corresponds to
    /// Build.DEVICE, e.g., google/coral. * `deviceBrand` (string): unique identifier of the user's device brand, e.g.,
    /// google. * `deviceType` (string): the type (also known as form factor) of the user's device, e.g., PHONE. *
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
    public class GooglePlayDeveloperReportingV1alpha1SlowRenderingRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1alpha1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>Identifier. The resource name. Format: apps/{app}/slowRenderingRateMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of Slow Start metrics. This metric set contains Activity start duration
    /// data. **Supported aggregation periods:** * DAILY: metrics are aggregated in calendar date intervals. Due to
    /// historical constraints, the only supported timezone is `America/Los_Angeles`. **Supported metrics:** *
    /// `slowStartRate` (`google.type.Decimal`): Percentage of distinct users in the aggregation period that had a slow
    /// start. * `slowStartRate7dUserWeighted` (`google.type.Decimal`): Rolling average value of `slowStartRate` in the
    /// last 7 days. The daily values are weighted by the count of distinct users for the day. *
    /// `slowStartRate28dUserWeighted` (`google.type.Decimal`): Rolling average value of `slowStartRate` in the last 28
    /// days. The daily values are weighted by the count of distinct users for the day. * `distinctUsers`
    /// (`google.type.Decimal`): Count of distinct users in the aggregation period that were used as normalization value
    /// for the `slowStartRate` metric. A user is counted in this metric if their app was launched in the device. Care
    /// must be taken not to aggregate this count further, as it may result in users being counted multiple times. The
    /// value is rounded to the nearest multiple of 10, 100, 1,000 or 1,000,000, depending on the magnitude of the
    /// value. **Required dimension:** This dimension must be specified with each request for the request to be valid. *
    /// `startType` (string): the type of start that was measured. Valid types are `HOT`, `WARM` and `COLD`. **Supported
    /// dimensions:** * `apiLevel` (string): the API level of Android that was running on the user's device, e.g., 26. *
    /// `versionCode` (int64): version of the app that was running on the user's device. * `deviceModel` (string):
    /// unique identifier of the user's device model. The form of the identifier is 'deviceBrand/device', where
    /// deviceBrand corresponds to Build.BRAND and device corresponds to Build.DEVICE, e.g., google/coral. *
    /// `deviceBrand` (string): unique identifier of the user's device brand, e.g., google. * `deviceType` (string): the
    /// type (also known as form factor) of the user's device, e.g., PHONE. * `countryCode` (string): the country or
    /// region of the user's device based on their IP address, represented as a 2-letter ISO-3166 code (e.g. US for the
    /// United States). * `deviceRamBucket` (int64): RAM of the device, in MB, in buckets (3GB, 4GB, etc.). *
    /// `deviceSocMake` (string): Make of the device's primary system-on-chip, e.g., Samsung.
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
    public class GooglePlayDeveloperReportingV1alpha1SlowStartRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1alpha1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>Identifier. The resource name. Format: apps/{app}/slowStartRateMetricSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Singleton resource representing the set of Stuck Background Wakelocks metrics. This metric set contains
    /// PowerManager wakelock duration data combined with process state data to produce a normalized metric independent
    /// of user counts. **Supported aggregation periods:** * DAILY: metrics are aggregated in calendar date intervals.
    /// Due to historical constraints, the only supported timezone is `America/Los_Angeles`. **Supported metrics:** *
    /// `stuckBgWakelockRate` (`google.type.Decimal`): Percentage of distinct users in the aggregation period that had a
    /// wakelock held in the background for longer than 1 hour. * `stuckBgWakelockRate7dUserWeighted`
    /// (`google.type.Decimal`): Rolling average value of `stuckBgWakelockRate` in the last 7 days. The daily values are
    /// weighted by the count of distinct users for the day. * `stuckBgWakelockRate28dUserWeighted`
    /// (`google.type.Decimal`): Rolling average value of `stuckBgWakelockRate` in the last 28 days. The daily values
    /// are weighted by the count of distinct users for the day. * `distinctUsers` (`google.type.Decimal`): Count of
    /// distinct users in the aggregation period that were used as normalization value for the `stuckBgWakelockRate`
    /// metric. A user is counted in this metric if their app was doing any work on the device, i.e., not just active
    /// foreground usage but also background work. Care must be taken not to aggregate this count further, as it may
    /// result in users being counted multiple times. The value is rounded to the nearest multiple of 10, 100, 1,000 or
    /// 1,000,000, depending on the magnitude of the value. **Supported dimensions:** * `apiLevel` (string): the API
    /// level of Android that was running on the user's device, e.g., 26. * `versionCode` (int64): version of the app
    /// that was running on the user's device. * `deviceModel` (string): unique identifier of the user's device model.
    /// The form of the identifier is 'deviceBrand/device', where deviceBrand corresponds to Build.BRAND and device
    /// corresponds to Build.DEVICE, e.g., google/coral. * `deviceBrand` (string): unique identifier of the user's
    /// device brand, e.g., google. * `deviceType` (string): the type (also known as form factor) of the user's device,
    /// e.g., PHONE. * `countryCode` (string): the country or region of the user's device based on their IP address,
    /// represented as a 2-letter ISO-3166 code (e.g. US for the United States). * `deviceRamBucket` (int64): RAM of the
    /// device, in MB, in buckets (3GB, 4GB, etc.). * `deviceSocMake` (string): Make of the device's primary
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
    public class GooglePlayDeveloperReportingV1alpha1StuckBackgroundWakelockRateMetricSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Summary about data freshness in this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("freshnessInfo")]
        public virtual GooglePlayDeveloperReportingV1alpha1FreshnessInfo FreshnessInfo { get; set; }

        /// <summary>Identifier. The resource name. Format: apps/{app}/stuckBackgroundWakelockRateMetricSet</summary>
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
    public class GooglePlayDeveloperReportingV1alpha1TimelineSpec : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A representation of a Play release track.</summary>
    public class GooglePlayDeveloperReportingV1alpha1Track : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Readable identifier of the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Represents all active releases in the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingReleases")]
        public virtual System.Collections.Generic.IList<GooglePlayDeveloperReportingV1alpha1Release> ServingReleases { get; set; }

        /// <summary>The type of the track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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
    /// formats, such as Java's
    /// [BigDecimal](https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/math/BigDecimal.html) or Python's
    /// [decimal.Decimal](https://docs.python.org/3/library/decimal.html).
    /// </summary>
    public class GoogleTypeDecimal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The decimal value, as a string. The string representation consists of an optional sign, `+` (`U+002B`) or
        /// `-` (`U+002D`), followed by a sequence of zero or more decimal digits ("the integer"), optionally followed
        /// by a fraction, optionally followed by an exponent. An empty string **should** be interpreted as `0`. The
        /// fraction consists of a decimal point followed by zero or more decimal digits. The string must contain at
        /// least one digit in either the integer or the fraction. The number formed by the sign, the integer and the
        /// fraction is referred to as the significand. The exponent consists of the character `e` (`U+0065`) or `E`
        /// (`U+0045`) followed by one or more decimal digits. Services **should** normalize decimal values before
        /// storing them by: - Removing an explicitly-provided `+` sign (`+2.5` -&amp;gt; `2.5`). - Replacing a
        /// zero-length integer value with `0` (`.5` -&amp;gt; `0.5`). - Coercing the exponent character to upper-case,
        /// with explicit sign (`2.5e8` -&amp;gt; `2.5E+8`). - Removing an explicitly-provided zero exponent (`2.5E0`
        /// -&amp;gt; `2.5`). Services **may** perform additional normalization based on its own needs and the internal
        /// decimal implementation selected, such as shifting the decimal point and exponent value together (example:
        /// `2.5E-1` &amp;lt;-&amp;gt; `0.25`). Additionally, services **may** preserve trailing zeroes in the fraction
        /// to indicate increased precision, but are not required to do so. Note that only the `.` character is
        /// supported to divide the integer and the fraction; `,` **should not** be supported regardless of locale.
        /// Additionally, thousand separators **should not** be supported. If a service does support them, values
        /// **must** be normalized. The ENBF grammar is: DecimalString = '' | [Sign] Significand [Exponent]; Sign = '+'
        /// | '-'; Significand = Digits '.' | [Digits] '.' Digits; Exponent = ('e' | 'E') [Sign] Digits; Digits = { '0'
        /// | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' }; Services **should** clearly document the range of
        /// supported values, the maximum supported precision (total number of digits), and, if applicable, the scale
        /// (number of digits after the decimal point), as well as how it behaves when receiving out-of-bounds values.
        /// Services **may** choose to accept values passed as input even when the value has a higher precision or scale
        /// than the service supports, and **should** round the value to fit the supported scale. Alternatively, the
        /// service **may** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if precision would be lost.
        /// Services **should** error with `400 Bad Request` (`INVALID_ARGUMENT` in gRPC) if the service receives a
        /// value outside of the supported range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class GoogleTypeTimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
