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

namespace Google.Apis.Recommender.v1
{
    /// <summary>The Recommender Service.</summary>
    public class RecommenderService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public RecommenderService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public RecommenderService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            BillingAccounts = new BillingAccountsResource(this);
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "recommender";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://recommender.googleapis.com/";
        #else
            "https://recommender.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://recommender.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Recommender API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Recommender API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the BillingAccounts resource.</summary>
        public virtual BillingAccountsResource BillingAccounts { get; }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Recommender requests.</summary>
    public abstract class RecommenderBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new RecommenderBaseServiceRequest instance.</summary>
        protected RecommenderBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Recommender parameter list.</summary>
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

    /// <summary>The "billingAccounts" collection of methods.</summary>
    public class BillingAccountsResource
    {
        private const string Resource = "billingAccounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BillingAccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

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
                InsightTypes = new InsightTypesResource(service);
                Recommenders = new RecommendersResource(service);
            }

            /// <summary>Gets the InsightTypes resource.</summary>
            public virtual InsightTypesResource InsightTypes { get; }

            /// <summary>The "insightTypes" collection of methods.</summary>
            public class InsightTypesResource
            {
                private const string Resource = "insightTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InsightTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Insights = new InsightsResource(service);
                }

                /// <summary>Gets the Insights resource.</summary>
                public virtual InsightsResource Insights { get; }

                /// <summary>The "insights" collection of methods.</summary>
                public class InsightsResource
                {
                    private const string Resource = "insights";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public InsightsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the requested insight. Requires the recommender.*.get IAM permission for the specified
                    /// insight type.
                    /// </summary>
                    /// <param name="name">Required. Name of the insight.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the requested insight. Requires the recommender.*.get IAM permission for the specified
                    /// insight type.
                    /// </summary>
                    public class GetRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Insight>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the insight.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/insightTypes/[^/]+/insights/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists insights for the specified Cloud Resource. Requires the recommender.*.list IAM permission
                    /// for the specified insight type.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats: *
                    /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` LOCATION
                    /// here refers to GCP Locations: https://cloud.google.com/about/locations/ INSIGHT_TYPE_ID refers
                    /// to supported insight types: https://cloud.google.com/recommender/docs/insights/insight-types.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists insights for the specified Cloud Resource. Requires the recommender.*.list IAM permission
                    /// for the specified insight type.
                    /// </summary>
                    public class ListRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1ListInsightsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats: *
                        /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
                        /// LOCATION here refers to GCP Locations: https://cloud.google.com/about/locations/
                        /// INSIGHT_TYPE_ID refers to supported insight types:
                        /// https://cloud.google.com/recommender/docs/insights/insight-types.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter expression to restrict the insights returned. Supported filter fields: *
                        /// `stateInfo.state` * `insightSubtype` * `severity` Examples: * `stateInfo.state = ACTIVE OR
                        /// stateInfo.state = DISMISSED` * `insightSubtype = PERMISSIONS_USAGE` * `severity = CRITICAL
                        /// OR severity = HIGH` * `stateInfo.state = ACTIVE AND (severity = CRITICAL OR severity =
                        /// HIGH)` (These expressions are based on the filter language described at
                        /// https://google.aip.dev/160)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. If not specified, the server will determine the number of results to return.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, retrieves the next batch of results from the preceding call to this
                        /// method. `page_token` must be the value of `next_page_token` from the previous response. The
                        /// values of other method parameters must be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/insights";

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
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/insightTypes/[^/]+$",
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
                    /// Marks the Insight State as Accepted. Users can use this method to indicate to the Recommender
                    /// API that they have applied some action based on the insight. This stops the insight content from
                    /// being updated. MarkInsightAccepted can be applied to insights in ACTIVE state. Requires the
                    /// recommender.*.update IAM permission for the specified insight.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the insight.</param>
                    public virtual MarkAcceptedRequest MarkAccepted(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest body, string name)
                    {
                        return new MarkAcceptedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Insight State as Accepted. Users can use this method to indicate to the Recommender
                    /// API that they have applied some action based on the insight. This stops the insight content from
                    /// being updated. MarkInsightAccepted can be applied to insights in ACTIVE state. Requires the
                    /// recommender.*.update IAM permission for the specified insight.
                    /// </summary>
                    public class MarkAcceptedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Insight>
                    {
                        /// <summary>Constructs a new MarkAccepted request.</summary>
                        public MarkAcceptedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the insight.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markAccepted";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markAccepted";

                        /// <summary>Initializes MarkAccepted parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/insightTypes/[^/]+/insights/[^/]+$",
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the Recommenders resource.</summary>
            public virtual RecommendersResource Recommenders { get; }

            /// <summary>The "recommenders" collection of methods.</summary>
            public class RecommendersResource
            {
                private const string Resource = "recommenders";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RecommendersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Recommendations = new RecommendationsResource(service);
                }

                /// <summary>Gets the Recommendations resource.</summary>
                public virtual RecommendationsResource Recommendations { get; }

                /// <summary>The "recommendations" collection of methods.</summary>
                public class RecommendationsResource
                {
                    private const string Resource = "recommendations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RecommendationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the requested recommendation. Requires the recommender.*.get IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the requested recommendation. Requires the recommender.*.get IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    public class GetRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists recommendations for the specified Cloud Resource. Requires the recommender.*.list IAM
                    /// permission for the specified recommender.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats: *
                    /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` LOCATION
                    /// here refers to GCP Locations: https://cloud.google.com/about/locations/ RECOMMENDER_ID refers to
                    /// supported recommenders: https://cloud.google.com/recommender/docs/recommenders.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists recommendations for the specified Cloud Resource. Requires the recommender.*.list IAM
                    /// permission for the specified recommender.
                    /// </summary>
                    public class ListRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1ListRecommendationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats: *
                        /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
                        /// LOCATION here refers to GCP Locations: https://cloud.google.com/about/locations/
                        /// RECOMMENDER_ID refers to supported recommenders:
                        /// https://cloud.google.com/recommender/docs/recommenders.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filter expression to restrict the recommendations returned. Supported filter fields: *
                        /// `state_info.state` * `recommenderSubtype` * `priority` Examples: * `stateInfo.state = ACTIVE
                        /// OR stateInfo.state = DISMISSED` * `recommenderSubtype = REMOVE_ROLE OR recommenderSubtype =
                        /// REPLACE_ROLE` * `priority = P1 OR priority = P2` * `stateInfo.state = ACTIVE AND (priority =
                        /// P1 OR priority = P2)` (These expressions are based on the filter language described at
                        /// https://google.aip.dev/160)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. If not specified, the server will determine the number of results to return.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, retrieves the next batch of results from the preceding call to this
                        /// method. `page_token` must be the value of `next_page_token` from the previous response. The
                        /// values of other method parameters must be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/recommendations";

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
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/recommenders/[^/]+$",
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
                    /// Marks the Recommendation State as Claimed. Users can use this method to indicate to the
                    /// Recommender API that they are starting to apply the recommendation themselves. This stops the
                    /// recommendation content from being updated. Associated insights are frozen and placed in the
                    /// ACCEPTED state. MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
                    /// SUCCEEDED, FAILED, or ACTIVE state. Requires the recommender.*.update IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkClaimedRequest MarkClaimed(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest body, string name)
                    {
                        return new MarkClaimedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Claimed. Users can use this method to indicate to the
                    /// Recommender API that they are starting to apply the recommendation themselves. This stops the
                    /// recommendation content from being updated. Associated insights are frozen and placed in the
                    /// ACCEPTED state. MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
                    /// SUCCEEDED, FAILED, or ACTIVE state. Requires the recommender.*.update IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    public class MarkClaimedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkClaimed request.</summary>
                        public MarkClaimedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markClaimed";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markClaimed";

                        /// <summary>Initializes MarkClaimed parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Failed. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation failed.
                    /// This stops the recommendation content from being updated. Associated insights are frozen and
                    /// placed in the ACCEPTED state. MarkRecommendationFailed can be applied to recommendations in
                    /// ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the recommender.*.update IAM permission
                    /// for the specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkFailedRequest MarkFailed(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest body, string name)
                    {
                        return new MarkFailedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Failed. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation failed.
                    /// This stops the recommendation content from being updated. Associated insights are frozen and
                    /// placed in the ACCEPTED state. MarkRecommendationFailed can be applied to recommendations in
                    /// ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the recommender.*.update IAM permission
                    /// for the specified recommender.
                    /// </summary>
                    public class MarkFailedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkFailed request.</summary>
                        public MarkFailedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markFailed";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markFailed";

                        /// <summary>Initializes MarkFailed parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Succeeded. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation was
                    /// successful. This stops the recommendation content from being updated. Associated insights are
                    /// frozen and placed in the ACCEPTED state. MarkRecommendationSucceeded can be applied to
                    /// recommendations in ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the
                    /// recommender.*.update IAM permission for the specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkSucceededRequest MarkSucceeded(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest body, string name)
                    {
                        return new MarkSucceededRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Succeeded. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation was
                    /// successful. This stops the recommendation content from being updated. Associated insights are
                    /// frozen and placed in the ACCEPTED state. MarkRecommendationSucceeded can be applied to
                    /// recommendations in ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the
                    /// recommender.*.update IAM permission for the specified recommender.
                    /// </summary>
                    public class MarkSucceededRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkSucceeded request.</summary>
                        public MarkSucceededRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markSucceeded";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markSucceeded";

                        /// <summary>Initializes MarkSucceeded parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^billingAccounts/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }
                }
            }
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
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

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
                InsightTypes = new InsightTypesResource(service);
                Recommenders = new RecommendersResource(service);
            }

            /// <summary>Gets the InsightTypes resource.</summary>
            public virtual InsightTypesResource InsightTypes { get; }

            /// <summary>The "insightTypes" collection of methods.</summary>
            public class InsightTypesResource
            {
                private const string Resource = "insightTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InsightTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Insights = new InsightsResource(service);
                }

                /// <summary>Gets the Insights resource.</summary>
                public virtual InsightsResource Insights { get; }

                /// <summary>The "insights" collection of methods.</summary>
                public class InsightsResource
                {
                    private const string Resource = "insights";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public InsightsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the requested insight. Requires the recommender.*.get IAM permission for the specified
                    /// insight type.
                    /// </summary>
                    /// <param name="name">Required. Name of the insight.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the requested insight. Requires the recommender.*.get IAM permission for the specified
                    /// insight type.
                    /// </summary>
                    public class GetRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Insight>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the insight.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/insightTypes/[^/]+/insights/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists insights for the specified Cloud Resource. Requires the recommender.*.list IAM permission
                    /// for the specified insight type.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats: *
                    /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` LOCATION
                    /// here refers to GCP Locations: https://cloud.google.com/about/locations/ INSIGHT_TYPE_ID refers
                    /// to supported insight types: https://cloud.google.com/recommender/docs/insights/insight-types.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists insights for the specified Cloud Resource. Requires the recommender.*.list IAM permission
                    /// for the specified insight type.
                    /// </summary>
                    public class ListRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1ListInsightsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats: *
                        /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
                        /// LOCATION here refers to GCP Locations: https://cloud.google.com/about/locations/
                        /// INSIGHT_TYPE_ID refers to supported insight types:
                        /// https://cloud.google.com/recommender/docs/insights/insight-types.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter expression to restrict the insights returned. Supported filter fields: *
                        /// `stateInfo.state` * `insightSubtype` * `severity` Examples: * `stateInfo.state = ACTIVE OR
                        /// stateInfo.state = DISMISSED` * `insightSubtype = PERMISSIONS_USAGE` * `severity = CRITICAL
                        /// OR severity = HIGH` * `stateInfo.state = ACTIVE AND (severity = CRITICAL OR severity =
                        /// HIGH)` (These expressions are based on the filter language described at
                        /// https://google.aip.dev/160)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. If not specified, the server will determine the number of results to return.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, retrieves the next batch of results from the preceding call to this
                        /// method. `page_token` must be the value of `next_page_token` from the previous response. The
                        /// values of other method parameters must be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/insights";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/insightTypes/[^/]+$",
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
                    /// Marks the Insight State as Accepted. Users can use this method to indicate to the Recommender
                    /// API that they have applied some action based on the insight. This stops the insight content from
                    /// being updated. MarkInsightAccepted can be applied to insights in ACTIVE state. Requires the
                    /// recommender.*.update IAM permission for the specified insight.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the insight.</param>
                    public virtual MarkAcceptedRequest MarkAccepted(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest body, string name)
                    {
                        return new MarkAcceptedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Insight State as Accepted. Users can use this method to indicate to the Recommender
                    /// API that they have applied some action based on the insight. This stops the insight content from
                    /// being updated. MarkInsightAccepted can be applied to insights in ACTIVE state. Requires the
                    /// recommender.*.update IAM permission for the specified insight.
                    /// </summary>
                    public class MarkAcceptedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Insight>
                    {
                        /// <summary>Constructs a new MarkAccepted request.</summary>
                        public MarkAcceptedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the insight.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markAccepted";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markAccepted";

                        /// <summary>Initializes MarkAccepted parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^folders/[^/]+/locations/[^/]+/insightTypes/[^/]+/insights/[^/]+$",
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the Recommenders resource.</summary>
            public virtual RecommendersResource Recommenders { get; }

            /// <summary>The "recommenders" collection of methods.</summary>
            public class RecommendersResource
            {
                private const string Resource = "recommenders";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RecommendersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Recommendations = new RecommendationsResource(service);
                }

                /// <summary>Gets the Recommendations resource.</summary>
                public virtual RecommendationsResource Recommendations { get; }

                /// <summary>The "recommendations" collection of methods.</summary>
                public class RecommendationsResource
                {
                    private const string Resource = "recommendations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RecommendationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the requested recommendation. Requires the recommender.*.get IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the requested recommendation. Requires the recommender.*.get IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    public class GetRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists recommendations for the specified Cloud Resource. Requires the recommender.*.list IAM
                    /// permission for the specified recommender.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats: *
                    /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` LOCATION
                    /// here refers to GCP Locations: https://cloud.google.com/about/locations/ RECOMMENDER_ID refers to
                    /// supported recommenders: https://cloud.google.com/recommender/docs/recommenders.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists recommendations for the specified Cloud Resource. Requires the recommender.*.list IAM
                    /// permission for the specified recommender.
                    /// </summary>
                    public class ListRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1ListRecommendationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats: *
                        /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
                        /// LOCATION here refers to GCP Locations: https://cloud.google.com/about/locations/
                        /// RECOMMENDER_ID refers to supported recommenders:
                        /// https://cloud.google.com/recommender/docs/recommenders.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filter expression to restrict the recommendations returned. Supported filter fields: *
                        /// `state_info.state` * `recommenderSubtype` * `priority` Examples: * `stateInfo.state = ACTIVE
                        /// OR stateInfo.state = DISMISSED` * `recommenderSubtype = REMOVE_ROLE OR recommenderSubtype =
                        /// REPLACE_ROLE` * `priority = P1 OR priority = P2` * `stateInfo.state = ACTIVE AND (priority =
                        /// P1 OR priority = P2)` (These expressions are based on the filter language described at
                        /// https://google.aip.dev/160)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. If not specified, the server will determine the number of results to return.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, retrieves the next batch of results from the preceding call to this
                        /// method. `page_token` must be the value of `next_page_token` from the previous response. The
                        /// values of other method parameters must be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/recommendations";

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
                                Pattern = @"^folders/[^/]+/locations/[^/]+/recommenders/[^/]+$",
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
                    /// Marks the Recommendation State as Claimed. Users can use this method to indicate to the
                    /// Recommender API that they are starting to apply the recommendation themselves. This stops the
                    /// recommendation content from being updated. Associated insights are frozen and placed in the
                    /// ACCEPTED state. MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
                    /// SUCCEEDED, FAILED, or ACTIVE state. Requires the recommender.*.update IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkClaimedRequest MarkClaimed(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest body, string name)
                    {
                        return new MarkClaimedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Claimed. Users can use this method to indicate to the
                    /// Recommender API that they are starting to apply the recommendation themselves. This stops the
                    /// recommendation content from being updated. Associated insights are frozen and placed in the
                    /// ACCEPTED state. MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
                    /// SUCCEEDED, FAILED, or ACTIVE state. Requires the recommender.*.update IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    public class MarkClaimedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkClaimed request.</summary>
                        public MarkClaimedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markClaimed";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markClaimed";

                        /// <summary>Initializes MarkClaimed parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^folders/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Failed. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation failed.
                    /// This stops the recommendation content from being updated. Associated insights are frozen and
                    /// placed in the ACCEPTED state. MarkRecommendationFailed can be applied to recommendations in
                    /// ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the recommender.*.update IAM permission
                    /// for the specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkFailedRequest MarkFailed(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest body, string name)
                    {
                        return new MarkFailedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Failed. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation failed.
                    /// This stops the recommendation content from being updated. Associated insights are frozen and
                    /// placed in the ACCEPTED state. MarkRecommendationFailed can be applied to recommendations in
                    /// ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the recommender.*.update IAM permission
                    /// for the specified recommender.
                    /// </summary>
                    public class MarkFailedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkFailed request.</summary>
                        public MarkFailedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markFailed";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markFailed";

                        /// <summary>Initializes MarkFailed parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^folders/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Succeeded. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation was
                    /// successful. This stops the recommendation content from being updated. Associated insights are
                    /// frozen and placed in the ACCEPTED state. MarkRecommendationSucceeded can be applied to
                    /// recommendations in ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the
                    /// recommender.*.update IAM permission for the specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkSucceededRequest MarkSucceeded(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest body, string name)
                    {
                        return new MarkSucceededRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Succeeded. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation was
                    /// successful. This stops the recommendation content from being updated. Associated insights are
                    /// frozen and placed in the ACCEPTED state. MarkRecommendationSucceeded can be applied to
                    /// recommendations in ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the
                    /// recommender.*.update IAM permission for the specified recommender.
                    /// </summary>
                    public class MarkSucceededRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkSucceeded request.</summary>
                        public MarkSucceededRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markSucceeded";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markSucceeded";

                        /// <summary>Initializes MarkSucceeded parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^folders/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }
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
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

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
                InsightTypes = new InsightTypesResource(service);
                Recommenders = new RecommendersResource(service);
            }

            /// <summary>Gets the InsightTypes resource.</summary>
            public virtual InsightTypesResource InsightTypes { get; }

            /// <summary>The "insightTypes" collection of methods.</summary>
            public class InsightTypesResource
            {
                private const string Resource = "insightTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InsightTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Insights = new InsightsResource(service);
                }

                /// <summary>Gets the Insights resource.</summary>
                public virtual InsightsResource Insights { get; }

                /// <summary>The "insights" collection of methods.</summary>
                public class InsightsResource
                {
                    private const string Resource = "insights";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public InsightsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the requested insight. Requires the recommender.*.get IAM permission for the specified
                    /// insight type.
                    /// </summary>
                    /// <param name="name">Required. Name of the insight.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the requested insight. Requires the recommender.*.get IAM permission for the specified
                    /// insight type.
                    /// </summary>
                    public class GetRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Insight>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the insight.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/insightTypes/[^/]+/insights/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists insights for the specified Cloud Resource. Requires the recommender.*.list IAM permission
                    /// for the specified insight type.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats: *
                    /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` LOCATION
                    /// here refers to GCP Locations: https://cloud.google.com/about/locations/ INSIGHT_TYPE_ID refers
                    /// to supported insight types: https://cloud.google.com/recommender/docs/insights/insight-types.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists insights for the specified Cloud Resource. Requires the recommender.*.list IAM permission
                    /// for the specified insight type.
                    /// </summary>
                    public class ListRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1ListInsightsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats: *
                        /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
                        /// LOCATION here refers to GCP Locations: https://cloud.google.com/about/locations/
                        /// INSIGHT_TYPE_ID refers to supported insight types:
                        /// https://cloud.google.com/recommender/docs/insights/insight-types.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter expression to restrict the insights returned. Supported filter fields: *
                        /// `stateInfo.state` * `insightSubtype` * `severity` Examples: * `stateInfo.state = ACTIVE OR
                        /// stateInfo.state = DISMISSED` * `insightSubtype = PERMISSIONS_USAGE` * `severity = CRITICAL
                        /// OR severity = HIGH` * `stateInfo.state = ACTIVE AND (severity = CRITICAL OR severity =
                        /// HIGH)` (These expressions are based on the filter language described at
                        /// https://google.aip.dev/160)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. If not specified, the server will determine the number of results to return.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, retrieves the next batch of results from the preceding call to this
                        /// method. `page_token` must be the value of `next_page_token` from the previous response. The
                        /// values of other method parameters must be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/insights";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/insightTypes/[^/]+$",
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
                    /// Marks the Insight State as Accepted. Users can use this method to indicate to the Recommender
                    /// API that they have applied some action based on the insight. This stops the insight content from
                    /// being updated. MarkInsightAccepted can be applied to insights in ACTIVE state. Requires the
                    /// recommender.*.update IAM permission for the specified insight.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the insight.</param>
                    public virtual MarkAcceptedRequest MarkAccepted(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest body, string name)
                    {
                        return new MarkAcceptedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Insight State as Accepted. Users can use this method to indicate to the Recommender
                    /// API that they have applied some action based on the insight. This stops the insight content from
                    /// being updated. MarkInsightAccepted can be applied to insights in ACTIVE state. Requires the
                    /// recommender.*.update IAM permission for the specified insight.
                    /// </summary>
                    public class MarkAcceptedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Insight>
                    {
                        /// <summary>Constructs a new MarkAccepted request.</summary>
                        public MarkAcceptedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the insight.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markAccepted";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markAccepted";

                        /// <summary>Initializes MarkAccepted parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/insightTypes/[^/]+/insights/[^/]+$",
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the Recommenders resource.</summary>
            public virtual RecommendersResource Recommenders { get; }

            /// <summary>The "recommenders" collection of methods.</summary>
            public class RecommendersResource
            {
                private const string Resource = "recommenders";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RecommendersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Recommendations = new RecommendationsResource(service);
                }

                /// <summary>Gets the Recommendations resource.</summary>
                public virtual RecommendationsResource Recommendations { get; }

                /// <summary>The "recommendations" collection of methods.</summary>
                public class RecommendationsResource
                {
                    private const string Resource = "recommendations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RecommendationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the requested recommendation. Requires the recommender.*.get IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the requested recommendation. Requires the recommender.*.get IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    public class GetRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists recommendations for the specified Cloud Resource. Requires the recommender.*.list IAM
                    /// permission for the specified recommender.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats: *
                    /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` LOCATION
                    /// here refers to GCP Locations: https://cloud.google.com/about/locations/ RECOMMENDER_ID refers to
                    /// supported recommenders: https://cloud.google.com/recommender/docs/recommenders.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists recommendations for the specified Cloud Resource. Requires the recommender.*.list IAM
                    /// permission for the specified recommender.
                    /// </summary>
                    public class ListRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1ListRecommendationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats: *
                        /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
                        /// LOCATION here refers to GCP Locations: https://cloud.google.com/about/locations/
                        /// RECOMMENDER_ID refers to supported recommenders:
                        /// https://cloud.google.com/recommender/docs/recommenders.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filter expression to restrict the recommendations returned. Supported filter fields: *
                        /// `state_info.state` * `recommenderSubtype` * `priority` Examples: * `stateInfo.state = ACTIVE
                        /// OR stateInfo.state = DISMISSED` * `recommenderSubtype = REMOVE_ROLE OR recommenderSubtype =
                        /// REPLACE_ROLE` * `priority = P1 OR priority = P2` * `stateInfo.state = ACTIVE AND (priority =
                        /// P1 OR priority = P2)` (These expressions are based on the filter language described at
                        /// https://google.aip.dev/160)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. If not specified, the server will determine the number of results to return.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, retrieves the next batch of results from the preceding call to this
                        /// method. `page_token` must be the value of `next_page_token` from the previous response. The
                        /// values of other method parameters must be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/recommendations";

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
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/recommenders/[^/]+$",
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
                    /// Marks the Recommendation State as Claimed. Users can use this method to indicate to the
                    /// Recommender API that they are starting to apply the recommendation themselves. This stops the
                    /// recommendation content from being updated. Associated insights are frozen and placed in the
                    /// ACCEPTED state. MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
                    /// SUCCEEDED, FAILED, or ACTIVE state. Requires the recommender.*.update IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkClaimedRequest MarkClaimed(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest body, string name)
                    {
                        return new MarkClaimedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Claimed. Users can use this method to indicate to the
                    /// Recommender API that they are starting to apply the recommendation themselves. This stops the
                    /// recommendation content from being updated. Associated insights are frozen and placed in the
                    /// ACCEPTED state. MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
                    /// SUCCEEDED, FAILED, or ACTIVE state. Requires the recommender.*.update IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    public class MarkClaimedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkClaimed request.</summary>
                        public MarkClaimedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markClaimed";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markClaimed";

                        /// <summary>Initializes MarkClaimed parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Failed. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation failed.
                    /// This stops the recommendation content from being updated. Associated insights are frozen and
                    /// placed in the ACCEPTED state. MarkRecommendationFailed can be applied to recommendations in
                    /// ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the recommender.*.update IAM permission
                    /// for the specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkFailedRequest MarkFailed(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest body, string name)
                    {
                        return new MarkFailedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Failed. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation failed.
                    /// This stops the recommendation content from being updated. Associated insights are frozen and
                    /// placed in the ACCEPTED state. MarkRecommendationFailed can be applied to recommendations in
                    /// ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the recommender.*.update IAM permission
                    /// for the specified recommender.
                    /// </summary>
                    public class MarkFailedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkFailed request.</summary>
                        public MarkFailedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markFailed";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markFailed";

                        /// <summary>Initializes MarkFailed parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Succeeded. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation was
                    /// successful. This stops the recommendation content from being updated. Associated insights are
                    /// frozen and placed in the ACCEPTED state. MarkRecommendationSucceeded can be applied to
                    /// recommendations in ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the
                    /// recommender.*.update IAM permission for the specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkSucceededRequest MarkSucceeded(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest body, string name)
                    {
                        return new MarkSucceededRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Succeeded. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation was
                    /// successful. This stops the recommendation content from being updated. Associated insights are
                    /// frozen and placed in the ACCEPTED state. MarkRecommendationSucceeded can be applied to
                    /// recommendations in ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the
                    /// recommender.*.update IAM permission for the specified recommender.
                    /// </summary>
                    public class MarkSucceededRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkSucceeded request.</summary>
                        public MarkSucceededRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markSucceeded";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markSucceeded";

                        /// <summary>Initializes MarkSucceeded parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^organizations/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }
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
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

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
                InsightTypes = new InsightTypesResource(service);
                Recommenders = new RecommendersResource(service);
            }

            /// <summary>Gets the InsightTypes resource.</summary>
            public virtual InsightTypesResource InsightTypes { get; }

            /// <summary>The "insightTypes" collection of methods.</summary>
            public class InsightTypesResource
            {
                private const string Resource = "insightTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InsightTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Insights = new InsightsResource(service);
                }

                /// <summary>Gets the Insights resource.</summary>
                public virtual InsightsResource Insights { get; }

                /// <summary>The "insights" collection of methods.</summary>
                public class InsightsResource
                {
                    private const string Resource = "insights";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public InsightsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the requested insight. Requires the recommender.*.get IAM permission for the specified
                    /// insight type.
                    /// </summary>
                    /// <param name="name">Required. Name of the insight.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the requested insight. Requires the recommender.*.get IAM permission for the specified
                    /// insight type.
                    /// </summary>
                    public class GetRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Insight>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the insight.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/insightTypes/[^/]+/insights/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists insights for the specified Cloud Resource. Requires the recommender.*.list IAM permission
                    /// for the specified insight type.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats: *
                    /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                    /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` LOCATION
                    /// here refers to GCP Locations: https://cloud.google.com/about/locations/ INSIGHT_TYPE_ID refers
                    /// to supported insight types: https://cloud.google.com/recommender/docs/insights/insight-types.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists insights for the specified Cloud Resource. Requires the recommender.*.list IAM permission
                    /// for the specified insight type.
                    /// </summary>
                    public class ListRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1ListInsightsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats: *
                        /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]` *
                        /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
                        /// LOCATION here refers to GCP Locations: https://cloud.google.com/about/locations/
                        /// INSIGHT_TYPE_ID refers to supported insight types:
                        /// https://cloud.google.com/recommender/docs/insights/insight-types.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Filter expression to restrict the insights returned. Supported filter fields: *
                        /// `stateInfo.state` * `insightSubtype` * `severity` Examples: * `stateInfo.state = ACTIVE OR
                        /// stateInfo.state = DISMISSED` * `insightSubtype = PERMISSIONS_USAGE` * `severity = CRITICAL
                        /// OR severity = HIGH` * `stateInfo.state = ACTIVE AND (severity = CRITICAL OR severity =
                        /// HIGH)` (These expressions are based on the filter language described at
                        /// https://google.aip.dev/160)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. If not specified, the server will determine the number of results to return.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, retrieves the next batch of results from the preceding call to this
                        /// method. `page_token` must be the value of `next_page_token` from the previous response. The
                        /// values of other method parameters must be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/insights";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/insightTypes/[^/]+$",
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
                    /// Marks the Insight State as Accepted. Users can use this method to indicate to the Recommender
                    /// API that they have applied some action based on the insight. This stops the insight content from
                    /// being updated. MarkInsightAccepted can be applied to insights in ACTIVE state. Requires the
                    /// recommender.*.update IAM permission for the specified insight.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the insight.</param>
                    public virtual MarkAcceptedRequest MarkAccepted(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest body, string name)
                    {
                        return new MarkAcceptedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Insight State as Accepted. Users can use this method to indicate to the Recommender
                    /// API that they have applied some action based on the insight. This stops the insight content from
                    /// being updated. MarkInsightAccepted can be applied to insights in ACTIVE state. Requires the
                    /// recommender.*.update IAM permission for the specified insight.
                    /// </summary>
                    public class MarkAcceptedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Insight>
                    {
                        /// <summary>Constructs a new MarkAccepted request.</summary>
                        public MarkAcceptedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the insight.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkInsightAcceptedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markAccepted";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markAccepted";

                        /// <summary>Initializes MarkAccepted parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/insightTypes/[^/]+/insights/[^/]+$",
                            });
                        }
                    }
                }
            }

            /// <summary>Gets the Recommenders resource.</summary>
            public virtual RecommendersResource Recommenders { get; }

            /// <summary>The "recommenders" collection of methods.</summary>
            public class RecommendersResource
            {
                private const string Resource = "recommenders";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RecommendersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Recommendations = new RecommendationsResource(service);
                }

                /// <summary>Gets the Recommendations resource.</summary>
                public virtual RecommendationsResource Recommendations { get; }

                /// <summary>The "recommendations" collection of methods.</summary>
                public class RecommendationsResource
                {
                    private const string Resource = "recommendations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public RecommendationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Gets the requested recommendation. Requires the recommender.*.get IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the requested recommendation. Requires the recommender.*.get IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    public class GetRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists recommendations for the specified Cloud Resource. Requires the recommender.*.list IAM
                    /// permission for the specified recommender.
                    /// </summary>
                    /// <param name="parent">
                    /// Required. The container resource on which to execute the request. Acceptable formats: *
                    /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                    /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` LOCATION
                    /// here refers to GCP Locations: https://cloud.google.com/about/locations/ RECOMMENDER_ID refers to
                    /// supported recommenders: https://cloud.google.com/recommender/docs/recommenders.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>
                    /// Lists recommendations for the specified Cloud Resource. Requires the recommender.*.list IAM
                    /// permission for the specified recommender.
                    /// </summary>
                    public class ListRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1ListRecommendationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The container resource on which to execute the request. Acceptable formats: *
                        /// `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]` *
                        /// `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
                        /// LOCATION here refers to GCP Locations: https://cloud.google.com/about/locations/
                        /// RECOMMENDER_ID refers to supported recommenders:
                        /// https://cloud.google.com/recommender/docs/recommenders.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Filter expression to restrict the recommendations returned. Supported filter fields: *
                        /// `state_info.state` * `recommenderSubtype` * `priority` Examples: * `stateInfo.state = ACTIVE
                        /// OR stateInfo.state = DISMISSED` * `recommenderSubtype = REMOVE_ROLE OR recommenderSubtype =
                        /// REPLACE_ROLE` * `priority = P1 OR priority = P2` * `stateInfo.state = ACTIVE AND (priority =
                        /// P1 OR priority = P2)` (These expressions are based on the filter language described at
                        /// https://google.aip.dev/160)
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. The maximum number of results to return from this request. Non-positive values are
                        /// ignored. If not specified, the server will determine the number of results to return.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. If present, retrieves the next batch of results from the preceding call to this
                        /// method. `page_token` must be the value of `next_page_token` from the previous response. The
                        /// values of other method parameters must be identical to those in the previous call.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/recommendations";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/recommenders/[^/]+$",
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
                    /// Marks the Recommendation State as Claimed. Users can use this method to indicate to the
                    /// Recommender API that they are starting to apply the recommendation themselves. This stops the
                    /// recommendation content from being updated. Associated insights are frozen and placed in the
                    /// ACCEPTED state. MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
                    /// SUCCEEDED, FAILED, or ACTIVE state. Requires the recommender.*.update IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkClaimedRequest MarkClaimed(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest body, string name)
                    {
                        return new MarkClaimedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Claimed. Users can use this method to indicate to the
                    /// Recommender API that they are starting to apply the recommendation themselves. This stops the
                    /// recommendation content from being updated. Associated insights are frozen and placed in the
                    /// ACCEPTED state. MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
                    /// SUCCEEDED, FAILED, or ACTIVE state. Requires the recommender.*.update IAM permission for the
                    /// specified recommender.
                    /// </summary>
                    public class MarkClaimedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkClaimed request.</summary>
                        public MarkClaimedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationClaimedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markClaimed";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markClaimed";

                        /// <summary>Initializes MarkClaimed parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Failed. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation failed.
                    /// This stops the recommendation content from being updated. Associated insights are frozen and
                    /// placed in the ACCEPTED state. MarkRecommendationFailed can be applied to recommendations in
                    /// ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the recommender.*.update IAM permission
                    /// for the specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkFailedRequest MarkFailed(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest body, string name)
                    {
                        return new MarkFailedRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Failed. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation failed.
                    /// This stops the recommendation content from being updated. Associated insights are frozen and
                    /// placed in the ACCEPTED state. MarkRecommendationFailed can be applied to recommendations in
                    /// ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the recommender.*.update IAM permission
                    /// for the specified recommender.
                    /// </summary>
                    public class MarkFailedRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkFailed request.</summary>
                        public MarkFailedRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationFailedRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markFailed";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markFailed";

                        /// <summary>Initializes MarkFailed parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Succeeded. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation was
                    /// successful. This stops the recommendation content from being updated. Associated insights are
                    /// frozen and placed in the ACCEPTED state. MarkRecommendationSucceeded can be applied to
                    /// recommendations in ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the
                    /// recommender.*.update IAM permission for the specified recommender.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the recommendation.</param>
                    public virtual MarkSucceededRequest MarkSucceeded(Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest body, string name)
                    {
                        return new MarkSucceededRequest(service, body, name);
                    }

                    /// <summary>
                    /// Marks the Recommendation State as Succeeded. Users can use this method to indicate to the
                    /// Recommender API that they have applied the recommendation themselves, and the operation was
                    /// successful. This stops the recommendation content from being updated. Associated insights are
                    /// frozen and placed in the ACCEPTED state. MarkRecommendationSucceeded can be applied to
                    /// recommendations in ACTIVE, CLAIMED, SUCCEEDED, or FAILED state. Requires the
                    /// recommender.*.update IAM permission for the specified recommender.
                    /// </summary>
                    public class MarkSucceededRequest : RecommenderBaseServiceRequest<Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1Recommendation>
                    {
                        /// <summary>Constructs a new MarkSucceeded request.</summary>
                        public MarkSucceededRequest(Google.Apis.Services.IClientService service, Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the recommendation.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Recommender.v1.Data.GoogleCloudRecommenderV1MarkRecommendationSucceededRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "markSucceeded";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:markSucceeded";

                        /// <summary>Initializes MarkSucceeded parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/recommenders/[^/]+/recommendations/[^/]+$",
                            });
                        }
                    }
                }
            }
        }
    }
}
namespace Google.Apis.Recommender.v1.Data
{
    /// <summary>Contains metadata about how much money a recommendation can save or incur.</summary>
    public class GoogleCloudRecommenderV1CostProjection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An approximate projection on amount saved or amount incurred. Negative cost units indicate cost savings and
        /// positive cost units indicate increase. See google.type.Money documentation for positive/negative units.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cost")]
        public virtual GoogleTypeMoney Cost { get; set; }

        /// <summary>Duration for which this cost applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the impact a recommendation can have for a given category.</summary>
    public class GoogleCloudRecommenderV1Impact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Category that is being targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Use with CategoryType.COST</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costProjection")]
        public virtual GoogleCloudRecommenderV1CostProjection CostProjection { get; set; }

        /// <summary>Use with CategoryType.SECURITY</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityProjection")]
        public virtual GoogleCloudRecommenderV1SecurityProjection SecurityProjection { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An insight along with the information used to derive the insight. The insight may have associated recomendations
    /// as well.
    /// </summary>
    public class GoogleCloudRecommenderV1Insight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Recommendations derived from this insight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associatedRecommendations")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommenderV1InsightRecommendationReference> AssociatedRecommendations { get; set; }

        /// <summary>Category being targeted by the insight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// A struct of custom fields to explain the insight. Example: "grantedPermissionsCount": "1000"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual System.Collections.Generic.IDictionary<string, object> Content { get; set; }

        /// <summary>Free-form human readable summary in English. The maximum length is 500 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Fingerprint of the Insight. Provides optimistic locking when updating states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Insight subtype. Insight content schema will be stable for a given subtype.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insightSubtype")]
        public virtual string InsightSubtype { get; set; }

        /// <summary>Timestamp of the latest data used to generate the insight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRefreshTime")]
        public virtual object LastRefreshTime { get; set; }

        /// <summary>Name of the insight.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Observation period that led to the insight. The source data used to generate the insight ends at
        /// last_refresh_time and begins at (last_refresh_time - observation_period).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observationPeriod")]
        public virtual object ObservationPeriod { get; set; }

        /// <summary>Insight's severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Information state and metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateInfo")]
        public virtual GoogleCloudRecommenderV1InsightStateInfo StateInfo { get; set; }

        /// <summary>Fully qualified resource names that this insight is targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetResources")]
        public virtual System.Collections.Generic.IList<string> TargetResources { get; set; }
    }

    /// <summary>Reference to an associated recommendation.</summary>
    public class GoogleCloudRecommenderV1InsightRecommendationReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Recommendation resource name, e.g.
        /// projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/recommendations/[RECOMMENDATION_ID]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendation")]
        public virtual string Recommendation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to insight state.</summary>
    public class GoogleCloudRecommenderV1InsightStateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Insight state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A map of metadata for the state, provided by user or automations systems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> StateMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to the `ListInsights` method.</summary>
    public class GoogleCloudRecommenderV1ListInsightsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of insights for the `parent` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insights")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommenderV1Insight> Insights { get; set; }

        /// <summary>
        /// A token that can be used to request the next page of results. This field is empty if there are no additional
        /// results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to the `ListRecommendations` method.</summary>
    public class GoogleCloudRecommenderV1ListRecommendationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be used to request the next page of results. This field is empty if there are no additional
        /// results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The set of recommendations for the `parent` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendations")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommenderV1Recommendation> Recommendations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `MarkInsightAccepted` method.</summary>
    public class GoogleCloudRecommenderV1MarkInsightAcceptedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Fingerprint of the Insight. Provides optimistic locking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. State properties user wish to include with this state. Full replace of the current state_metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> StateMetadata { get; set; }
    }

    /// <summary>Request for the `MarkRecommendationClaimed` Method.</summary>
    public class GoogleCloudRecommenderV1MarkRecommendationClaimedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Fingerprint of the Recommendation. Provides optimistic locking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// State properties to include with this state. Overwrites any existing `state_metadata`. Keys must match the
        /// regex /^a-z0-9{0,62}$/. Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> StateMetadata { get; set; }
    }

    /// <summary>Request for the `MarkRecommendationFailed` Method.</summary>
    public class GoogleCloudRecommenderV1MarkRecommendationFailedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Fingerprint of the Recommendation. Provides optimistic locking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// State properties to include with this state. Overwrites any existing `state_metadata`. Keys must match the
        /// regex /^a-z0-9{0,62}$/. Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> StateMetadata { get; set; }
    }

    /// <summary>Request for the `MarkRecommendationSucceeded` Method.</summary>
    public class GoogleCloudRecommenderV1MarkRecommendationSucceededRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Fingerprint of the Recommendation. Provides optimistic locking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// State properties to include with this state. Overwrites any existing `state_metadata`. Keys must match the
        /// regex /^a-z0-9{0,62}$/. Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> StateMetadata { get; set; }
    }

    /// <summary>
    /// Contains an operation for a resource loosely based on the JSON-PATCH format with support for: * Custom filters
    /// for describing partial array patch. * Extended path values for describing nested arrays. * Custom fields for
    /// describing the resource for which the operation is being described. * Allows extension to custom operations not
    /// natively supported by RFC6902. See https://tools.ietf.org/html/rfc6902 for details on the original RFC.
    /// </summary>
    public class GoogleCloudRecommenderV1Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type of this operation. Contains one of 'add', 'remove', 'replace', 'move', 'copy', 'test' and custom
        /// operations. This field is case-insensitive and always populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// Path to the target field being operated on. If the operation is at the resource level, then path should be
        /// "/". This field is always populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Set of filters to apply if `path` refers to array elements or nested array elements in order to narrow down
        /// to a single unique element that is being tested/modified. This is intended to be an exact match per filter.
        /// To perform advanced matching, use path_value_matchers. * Example: { "/versions/*/name" : "it-123"
        /// "/versions/*/targetSize/percent": 20 } * Example: { "/bindings/*/role": "roles/owner"
        /// "/bindings/*/condition" : null } * Example: { "/bindings/*/role": "roles/owner" "/bindings/*/members/*" :
        /// ["x@example.com", "y@example.com"] } When both path_filters and path_value_matchers are set, an implicit AND
        /// must be performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathFilters")]
        public virtual System.Collections.Generic.IDictionary<string, object> PathFilters { get; set; }

        /// <summary>
        /// Similar to path_filters, this contains set of filters to apply if `path` field refers to array elements.
        /// This is meant to support value matching beyond exact match. To perform exact match, use path_filters. When
        /// both path_filters and path_value_matchers are set, an implicit AND must be performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathValueMatchers")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRecommenderV1ValueMatcher> PathValueMatchers { get; set; }

        /// <summary>
        /// Contains the fully qualified resource name. This field is always populated. ex:
        /// //cloudresourcemanager.googleapis.com/projects/foo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>
        /// Type of GCP resource being modified/tested. This field is always populated. Example:
        /// cloudresourcemanager.googleapis.com/Project, compute.googleapis.com/Instance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>
        /// Can be set with action 'copy' or 'move' to indicate the source field within resource or source_resource,
        /// ignored if provided for other operation types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePath")]
        public virtual string SourcePath { get; set; }

        /// <summary>
        /// Can be set with action 'copy' to copy resource configuration across different resources of the same type.
        /// Example: A resource clone can be done via action = 'copy', path = "/", from = "/", source_resource = and
        /// resource_name = . This field is empty for all other values of `action`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceResource")]
        public virtual string SourceResource { get; set; }

        /// <summary>
        /// Value for the `path` field. Will be set for actions:'add'/'replace'. Maybe set for action: 'test'. Either
        /// this or `value_matcher` will be set for 'test' operation. An exact match must be performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; }

        /// <summary>
        /// Can be set for action 'test' for advanced matching for the value of 'path' field. Either this or `value`
        /// will be set for 'test' operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueMatcher")]
        public virtual GoogleCloudRecommenderV1ValueMatcher ValueMatcher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Group of operations that need to be performed atomically.</summary>
    public class GoogleCloudRecommenderV1OperationGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of operations across one or more resources that belong to this group. Loosely based on RFC6902 and
        /// should be performed in the order they appear.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommenderV1Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A recommendation along with a suggested action. E.g., a rightsizing recommendation for an underutilized VM, IAM
    /// role recommendations, etc
    /// </summary>
    public class GoogleCloudRecommenderV1Recommendation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional set of additional impact that this recommendation may have when trying to optimize for the primary
        /// category. These may be positive or negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalImpact")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommenderV1Impact> AdditionalImpact { get; set; }

        /// <summary>Insights that led to this recommendation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associatedInsights")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommenderV1RecommendationInsightReference> AssociatedInsights { get; set; }

        /// <summary>Content of the recommendation describing recommended changes to resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual GoogleCloudRecommenderV1RecommendationContent Content { get; set; }

        /// <summary>Free-form human readable summary in English. The maximum length is 500 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Fingerprint of the Recommendation. Provides optimistic locking when updating states.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Last time this recommendation was refreshed by the system that created it in the first place.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRefreshTime")]
        public virtual object LastRefreshTime { get; set; }

        /// <summary>Name of recommendation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The primary impact that this recommendation can have while trying to optimize for one category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryImpact")]
        public virtual GoogleCloudRecommenderV1Impact PrimaryImpact { get; set; }

        /// <summary>Recommendation's priority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>
        /// Contains an identifier for a subtype of recommendations produced for the same recommender. Subtype is a
        /// function of content and impact, meaning a new subtype might be added when significant changes to `content`
        /// or `primary_impact.category` are introduced. See the Recommenders section to see a list of subtypes for a
        /// given Recommender. Examples: For recommender = "google.iam.policy.Recommender", recommender_subtype can be
        /// one of "REMOVE_ROLE"/"REPLACE_ROLE"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommenderSubtype")]
        public virtual string RecommenderSubtype { get; set; }

        /// <summary>Information for state. Contains state and metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateInfo")]
        public virtual GoogleCloudRecommenderV1RecommendationStateInfo StateInfo { get; set; }
    }

    /// <summary>Contains what resources are changing and how they are changing.</summary>
    public class GoogleCloudRecommenderV1RecommendationContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Operations to one or more Google Cloud resources grouped in such a way that, all operations within one group
        /// are expected to be performed atomically and in an order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecommenderV1OperationGroup> OperationGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reference to an associated insight.</summary>
    public class GoogleCloudRecommenderV1RecommendationInsightReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Insight resource name, e.g.
        /// projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/insights/[INSIGHT_ID]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insight")]
        public virtual string Insight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information for state. Contains state and metadata.</summary>
    public class GoogleCloudRecommenderV1RecommendationStateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of the recommendation, Eg ACTIVE, SUCCEEDED, FAILED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>A map of metadata for the state, provided by user or automations systems.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> StateMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains various ways of describing the impact on Security.</summary>
    public class GoogleCloudRecommenderV1SecurityProjection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional security impact details that is provided by the recommender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, object> Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains various matching options for values for a GCP resource field.</summary>
    public class GoogleCloudRecommenderV1ValueMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// To be used for full regex matching. The regular expression is using the Google RE2 syntax
        /// (https://github.com/google/re2/wiki/Syntax), so to be used with RE2::FullMatch
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchesPattern")]
        public virtual string MatchesPattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class GoogleTypeMoney : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
